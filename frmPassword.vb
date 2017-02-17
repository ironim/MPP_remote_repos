Public Class frmPassword

    'キャンセルボタン
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    '決定ボタン
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        'DBからパスワードを取得し、入力したパスワードと比較する。あっていれば免許証出力処理へ
        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)
            Dim dbPasswd As String
            'コマンドをコネクションから作成する
            Dim command As SqlClient.SqlCommand = connection.CreateCommand

            'コネクションを開く
            connection.Open()

            'データリーダーの定義
            Dim dr As SqlClient.SqlDataReader

            'データコマンドの定義
            command.CommandText = "SELECT passwd FROM tbl_passwd where id = 'admin' "

            'データリーダーからのデータの読出し
            dr = command.ExecuteReader()
            dr.Read()
            dbPasswd = CStr(dr("passwd"))


            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()

            '
            If dbPasswd = txtPasswd.Text Then


                'Dim frm As New frmProgressSyakenMenkyo

                'frm.Menkyo_Download()
                'Me.Close()

                mdlMain.UserIsAdmin = True

                Me.Close()

            Else
                MsgBox("パスワードが違います")
                txtPasswd.Select()
                Return

            End If
        End Using



    End Sub

End Class