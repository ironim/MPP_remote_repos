Public Class frmMasterPhone
    Private Sub frmMasterPhone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_PhoneNum' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)

    End Sub

    '[新規登録]ボタン
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As New frmMasterPhoneNew
        frm.ShowDialog(Me)

        Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)
    End Sub

    '[閉じる]ボタン
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    '[編集]ボタン
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'データグリッドビューが空のときは終了する
        If grdPhone.Rows.Count = 0 Then Return

        Dim row As Integer
        Dim number As String

        'データグリッドビューの行番号を取得する
        row = grdPhone.CurrentRow.Index

        '行番号から電話番号を取得する
        number = grdPhone.Item(0, row).Value.ToString

        '[選択行の編集]フォームのSetSelectedRecordプロシージャを呼び出し、
        '指定した電話番号のデータを表示する
        Dim frm As New frmMasterPhoneEdit
        frm.SetSelectedPhone(number, Me)

        '[選択行の編集]フォームを表示する
        frm.ShowDialog(Me)

        '編集フォームから戻ったら、グリッドを更新する
        Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)

    End Sub

    '[削除]ボタン
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'データグリッドビューが空のときは終了する
        If grdPhone.Rows.Count = 0 Then Return

        Dim row As Integer
        Dim phonenum As String

        'データグリッドビューの行番号を取得する
        row = grdPhone.CurrentRow.Index
        '行番号から電話番号、氏名、車番、integ_idを取得する
        phonenum = grdPhone.Item(0, row).Value.ToString

        'メッセージボックスに行情報を表示し、削除してよいか確認
        If MsgBox("電話番号：" & phonenum & vbCrLf & "このデータを削除してもよろしいですか？", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) <> MsgBoxResult.Yes Then
            Return

        End If

        '処理の成功をチェックするフラグ
        Dim bSuccess As Boolean = False

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)

            'コマンドを定義する
            Dim command As SqlClient.SqlCommand = connection.CreateCommand()

            'コネクションを開く
            connection.Open()

            'トランザクションの開始
            command.Transaction = connection.BeginTransaction()

            Try
                'コマンドの定義と実行
                '
                command.CommandText = "DELETE FROM tbl_PhoneNum WHERE phonenum = '" & phonenum & "'"
                command.ExecuteNonQuery()

                'トランザクションのコミット
                command.Transaction.Commit()

                MsgBox("選択されたデータを削除しました。")

                '処理が成功したため、フラグにセットする
                bSuccess = True

                '処理が失敗したとき
            Catch ex As Exception
                'トランザクションのロールバック
                command.Transaction.Rollback()

                MsgBox("エラーが発生したため、処理を中止します。" & vbCrLf & ex.Message)

            End Try

        End Using

        '成功した時の後処理
        If bSuccess Then

            'グリッドを更新する
            Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)


        End If


    End Sub

    '絞り込みボックス


    'Private Sub FillByNumToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByNumToolStripButton.Click
    '    Try
    '        Me.Tbl_PhoneNumTableAdapter.FillByNum(Me.PhoneNumDBDataSet.tbl_PhoneNum, "%" & txtFilter.Text & "%")

    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub


    'キーボードショートカット
    Private Sub frmMasterGrdPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim pcode As String
        pcode = txtSearch.Text
        Me.Tbl_PhoneNumTableAdapter.FillBySearch(Me.PhoneNumDBDataSet.tbl_PhoneNum, "%" & txtSearch.Text & "%")
    End Sub
End Class