Public Class frmMasterStaff

    Private Sub frmMasterStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_staffTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_staff)

    End Sub

    '[閉じる]ボタン
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    '[新規登録]ボタン
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As New frmMasterStaffNew
        frm.ShowDialog(Me)

        Me.Tbl_staffTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_staff)
    End Sub

    '[選択行の編集]ボタン
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'データグリッドビューが空のときは終了する
        If grdStaff.Rows.Count = 0 Then Return

        Dim row As Integer
        Dim staffid As String

        'データグリッドビューの行番号を取得する
        row = grdStaff.CurrentRow.Index

        '行番号から社員IDを取得する
        staffid = grdStaff.Item(0, row).Value.ToString

        '[選択行の編集]フォームのSetSelectedRecordプロシージャを呼び出し、
        '指定した社員IDのデータを表示する
        Dim frm As New frmMasterStaffEdit
        frm.SetSelectedStaff(staffid, Me)

        '[選択行の編集]フォームを表示する
        frm.ShowDialog(Me)

        '編集フォームから戻ったら、グリッドを更新する
        Me.Tbl_staffTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_staff)

    End Sub

    '［選択行の削除］ボタン
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'データグリッドビューが空のときは終了する
        If grdStaff.Rows.Count = 0 Then Return

        Dim row As Integer
        Dim staffname As String
        Dim id As String

        'データグリッドビューの行番号を取得する
        row = grdStaff.CurrentRow.Index
        '行番号からid、氏名を取得する
        staffname = grdStaff.Item(1, row).Value.ToString
        id = grdStaff.Item(0, row).Value.ToString

        'メッセージボックスに行情報を表示し、削除してよいか確認
        If MsgBox("氏名：" & staffname & vbCrLf & "このデータを削除してもよろしいですか？", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) <> MsgBoxResult.Yes Then
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
                command.CommandText = "DELETE FROM tbl_Staff WHERE id_staff = '" & id & "'"
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
            Me.Tbl_staffTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_staff)


        End If


    End Sub

    'キーボードショートカット
    Private Sub frmMasterGrdStaff_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Me.Tbl_staffTableAdapter.FillBySearch(Me.PhoneNumDBDataSet.tbl_staff, "%" & txtSearch.Text & "%")
    End Sub
End Class