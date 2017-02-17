Public Class frmMasterPhoneEdit
    Private frm_MasterPhone

    Public Sub SetSelectedPhone(ByVal number As String, ByVal f As frmMasterPhone)
        '呼び出し元フォームを格納する
        frm_MasterPhone = f

        '電話番号マスタのデータをデータソースにセット
        'Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)

        '受け取ったコードを利用して、該当する電話番号テーブルのデータをデータソースにセット
        Me.Tbl_PhoneNumTableAdapter.FillByPcode(Me.PhoneNumDBDataSet.tbl_PhoneNum, number)

    End Sub
    '[キャンセル]ボタン
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    '[決定]ボタン
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        '登録する内容がデータ型と一致しているかチェック
        If Not CheckEditData() Then
            Return
        End If


        '保存確認と保存処理
        If MsgBox("これまでの修正内容をデータベースに保存しますか？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            '編集状態を確定する
            Me.TblPhoneNumBindingSource.EndEdit()


            'テーブルアダプタを介して、レコードを更新する
            Me.Tbl_PhoneNumTableAdapter.Update(Me.PhoneNumDBDataSet.tbl_PhoneNum)

            'フォームを閉じる
            Me.Close()
        End If
    End Sub

    Private Function CheckEditData() As Boolean
        'データの検査(機種名)
        With txtModel
            If Not CheckMaxLengthPhone("model", .Text) Then
                MsgBox("機種名は半角20字以内で入力してください")
                .Select()
                Return False
            End If
        End With

        With txtMail
            'データの検査(メール)
            If Not CheckMaxLengthPhone("mail", .Text) Then
                MsgBox("メールアドレスは半角50字以内で入力してください")
                .Select()
                Return False
            End If
        End With

        'データの検査(備考)
        With txtBiko
            If Not CheckMaxLengthPhone("biko", .Text) Then
                MsgBox("備考は全角50字以内で入力してください")
                .Select()
                Return False
            End If
        End With


        '全ての検査を通過した
        Return True

    End Function

    '桁数チェック-電話番号(指定された列のサイズと文字列の比較)
    Private Function CheckMaxLengthPhone(ByVal fieldname As String, ByVal value As String)
        'データセットから列の情報を読み取る
        Dim column As DataColumn = PhoneNumDBDataSet.tbl_PhoneNum.Columns(fieldname)
        'シフトJISで文字列のバイト数を取得する
        Dim length As Integer = System.Text.Encoding.GetEncoding(932).GetByteCount(value)

        '指定されたサイズを超えたときはエラーになる
        If length > column.MaxLength Then
            Return False
        Else
            Return True
        End If
    End Function

    'キーボードショートカット
    Private Sub frmMasterEditPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub


End Class