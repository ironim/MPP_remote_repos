Public Class frmMasterPhoneNew
    Private Sub frmMasterPhoneNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_PhoneNum' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)


    End Sub

    'キャンセルボタン
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    '[登録]ボタン
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click


        '登録するデータのチェック　不備があればキャンセルになる
        If Not CheckEditData() Then
            Return
        End If

        '保存確認と保存処理
        If MsgBox("この内容で新規登録してよろしいですか？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            '行の定義
            Dim newrecord As PhoneNumDBDataSet.tbl_PhoneNumRow = Me.PhoneNumDBDataSet.tbl_PhoneNum.Newtbl_PhoneNumRow

            Try
                '行にデータをセットする
                newrecord.phonenum = txtPhonenum.Text
                newrecord.mail = txtMail.Text
                newrecord.model = txtModel.Text
                newrecord.biko = txtBiko.Text

                '新規行をデータテーブルに追加する
                Me.PhoneNumDBDataSet.tbl_PhoneNum.Addtbl_PhoneNumRow(newrecord)

                'テーブルアダプタを介して、tbl_integrateテーブルを更新する
                Me.Tbl_PhoneNumTableAdapter.Update(Me.PhoneNumDBDataSet.tbl_PhoneNum)

            Catch ex As Exception
                'エラーメッセージを表示する
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, Me.Text)
                Return

            End Try

            'フォームを閉じる
            Me.Close()
        End If
    End Sub

    Private Function CheckEditData() As Boolean

        'データの検査(電話番号)
        With txtPhonenum
            '空白でない
            If txtPhonenum.Text = "" Then
                MsgBox("電話番号は必ず入力してください")
                .Select()
                Return False
            End If

            '文字数チェック
            If Not CheckMaxLengthPhone("phonenum", .Text) Then
                MsgBox("電話番号は以内で入力してください")
                .Select()
                Return False

            End If

            '数字とﾊｲﾌﾝからなっている
            If Not CheckPhoneNumber(txtPhonenum.Text) Then

                .Select()
                Return False

            End If

            '電話番号は、既存の登録と重複がないかチェックする
            If Not CheckOverlap(txtPhonenum.Text) Then
                MsgBox("電話番号が既存のデータと重複しています")
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


        'データの検査(機種名)
        With txtModel
            If Not CheckMaxLengthPhone("model", .Text) Then
                MsgBox("機種名は半角20字以内で入力してください")
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
    Private Function CheckMaxLengthPhone(ByVal fieldname As String, ByVal value As String) As Boolean
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

    '重複チェック―電話番号
    Private Function CheckOverlap(ByVal number As String) As Boolean


        For Each drw As DataRow In PhoneNumDBDataSet.tbl_PhoneNum.Rows()
            '行の状態が"削除"のデータを除外する
            If drw.RowState <> DataRowState.Deleted Then
                'この行の電話番号と、入力された電話番号を比較する
                If drw("phonenum") = number Then
                    '重複の場合には終了する

                    Return False
                End If
            End If
        Next

        Return True
    End Function

    '電話番号が数字とﾊｲﾌﾝからなっているかチェック
    Private Function CheckPhoneNumber(ByVal number As String) As Boolean
        Dim i As Integer
        Dim cs As String

        For i = 1 To Len(number)
            '検査する文字を1つずつ抜き出す
            cs = Mid(number, i, 1)

            If (cs < "0" OrElse cs > "9") AndAlso cs <> "-" Then
                '数字とハイフン以外が含まれていた場合
                MsgBox("電話番号に数字とハイフン以外の文字が含まれています")
                Return False
            End If
        Next

        'ハイフンが含まれていなければfalse
        If number.IndexOf("-") = -1 Then
            MsgBox("電話番号にはハイフンを含めてください")
            Return False

        End If
        '適切な文字列だった
        Return True
    End Function

    'キーボードショートカット
    Private Sub frmMasterPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub


End Class