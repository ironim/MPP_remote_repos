Imports System.Text.RegularExpressions
Public Class frmMasterStaffNew


    Private menkyoLimit As Date
    Private Sub frmMasterStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_carTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_car)
        ''TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_PhoneNum' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_staffTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_staff)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_branch' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_branchTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_branch)


        ''### 新しい社員IDを生成する ###

        ''コネクションを指定する
        'Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)

        '    'コマンドをコネクションから作成する
        '    Dim command As SqlClient.SqlCommand = connection.CreateCommand

        '    'コネクションを開く
        '    connection.Open()

        '    'データリーダーの定義
        '    Dim dr As SqlClient.SqlDataReader

        '    'データコマンドの定義
        '    command.CommandText = "SELECT id_staff FROM tbl_staff ORDER BY id_staff"
        '    'データリーダーからのデータの読出し
        '    dr = command.ExecuteReader()


        '    Do While dr.Read
        '        lblStaffID.Text = dr("id_staff")
        '    Loop

        '    'データリーダーを閉じる
        '    dr.Close()

        '    '最大IDに1を足す
        '    lblStaffID.Text = (lblStaffID.Text) + 1

        '    'IDの文字数を取得し、6-(文字数)個の0を先頭に付加する
        '    Dim nZero As Integer
        '    nZero = (5 - Len(lblStaffID.Text))

        '    Dim i As Integer = 1
        '    Do While i <= nZero
        '        lblStaffID.Text = "0" & lblStaffID.Text
        '        i = i + 1
        '    Loop

        'End Using

        '### 所属コンボボックスの設定###
        cmbBranch.SelectedIndex = -1


        '免許証期限の初期値はオブジェクトのプロパティで設定した


    End Sub


    '[閉じる]ボタン
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    '[登録]ボタン
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click


        '登録するデータのチェック　不備があればキャンセルになる
        If Not CheckEditData() Then
            Return
        End If

        '免許証ファイルの登録があれば、日付入力をチェックし、日付のDateデータを生成する
        If Not txtFilePath.Text = "" Then
            '日付が入力されていなければキャンセル
            If txtYear.Text = "" Or txtMonth.Text = "" Or txtDay.Text = "" Then
                MsgBox("日付を入力してください")

                Return
            End If

            '日付の値チェック
            If Not CheckTxtYear(txtYear.Text) Or Not CheckTxtMonth(txtMonth.Text) Or Not CheckTxtDate(txtDay.Text) Then
                MsgBox("日付を正しく入力してください")
                Return
            End If

            '日付入力を1行にまとめる
            menkyoLimit = mdlMain.Wareki_to_AD("平成" & txtYear.Text & "年" & txtMonth.Text & "月" & txtDay.Text & "日")

        End If



        '保存確認と保存処理
        If MsgBox("この内容で新規登録してよろしいですか？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then


            '処理の成功をチェックするフラグ
            Dim bSuccess As Boolean = False

            '### 新しい社員IDを生成する ###

            'コネクションを指定する
            Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)

                'コマンドをコネクションから作成する
                Dim command As SqlClient.SqlCommand = connection.CreateCommand

                'コネクションを開く
                connection.Open()

                'トランザクションの開始
                command.Transaction = connection.BeginTransaction()

                Try


                    'データリーダーの定義
                    Dim dr As SqlClient.SqlDataReader

                    'データコマンドの定義
                    command.CommandText = "SELECT id_staff FROM tbl_staff ORDER BY id_staff"
                    'データリーダーからのデータの読出し
                    dr = command.ExecuteReader()


                    Do While dr.Read
                        lblStaffID.Text = dr("id_staff")
                    Loop

                    'データリーダーを閉じる
                    dr.Close()

                    '最大IDに1を足す
                    lblStaffID.Text = (lblStaffID.Text) + 1

                    'IDの文字数を取得し、6-(文字数)個の0を先頭に付加する
                    Dim nZero As Integer
                    nZero = (5 - Len(lblStaffID.Text))

                    Dim i As Integer = 1
                    Do While i <= nZero
                        lblStaffID.Text = "0" & lblStaffID.Text
                        i = i + 1
                    Loop

                    '行の定義
                    Dim newrecord As PhoneNumDBDataSet.tbl_staffRow = Me.PhoneNumDBDataSet.tbl_staff.Newtbl_staffRow

                    '行にデータをセットする
                    newrecord.id_staff = lblStaffID.Text
                    newrecord.staff_name = txtStaffName.Text
                    newrecord.staff_kana = txtStaffKana.Text
                    newrecord.branch_id = cmbBranch.SelectedValue
                    newrecord.biko = txtBiko.Text

                    If Not txtFilePath.Text = "" Then
                        newrecord.limit_menkyo = menkyoLimit

                    End If

                    '新規行をデータテーブルに追加する
                    Me.PhoneNumDBDataSet.tbl_staff.Addtbl_staffRow(newrecord)

                    'トランザクションのコミット
                    command.Transaction.Commit()

                    '処理が成功したため、フラグにセットする
                    bSuccess = True

                    '処理が失敗したとき
                Catch ex As Exception
                    'トランザクションのロールバック
                    command.Transaction.Rollback()

                    MsgBox("エラーが発生したため、処理を中止します。" & vbCrLf & ex.Message)

                End Try

            End Using

            'テーブルアダプタを介して、tbl_carテーブルを更新する
            Me.Tbl_staffTableAdapter.Update(Me.PhoneNumDBDataSet.tbl_staff)

            If Not txtFilePath.Text = "" Then
                '免許証ファイルアップロード処理
                '選択された社員の新しい免許証をmenkyoフォルダにコピー＆リネーム　例：岩田　久彌_免許証_20170101.pdf
                Dim newMenkyoFilePath As String
                newMenkyoFilePath = "\\192.168.8.190\share\system\menkyo\" & txtStaffName.Text & "_免許証_" & menkyoLimit.ToLongDateString & ".pdf"

                System.IO.File.Copy(txtFilePath.Text, newMenkyoFilePath)

            End If
            'フォームを閉じる
            Me.Close()
        End If
    End Sub

    Private Function CheckEditData() As Boolean

        'データの検査(氏名)
        With txtStaffName
            '空白でない
            If .Text = "" Then
                MsgBox("氏名は必ず入力してください")
                .Select()
                Return False
            End If

            '文字数チェック
            If Not CheckMaxLengthStaff("staff_name", .Text) Then
                MsgBox("氏名は全角10字以内で入力してください")
                .Select()
                Return False

            End If

            '氏名は、既存の登録と重複がないかチェックする。ただし、警告メッセージを表示するだけ
            If Not CheckNameOverlap(txtStaffName.Text) Then
                MsgBox("注意：既に同名の登録があります")

            End If
        End With

        'データの検査(氏名ｶﾅ)
        With txtStaffKana
            '空白でない
            If .Text = "" Then
                MsgBox("氏名ｶﾅは必ず入力してください")
                .Select()
                Return False
            End If
            '文字数チェック
            If Not CheckMaxLengthStaff("staff_kana", .Text) Then

                .Select()
                Return False
            End If
        End With



        'データの検査(備考)
        With txtBiko
            If Not CheckMaxLengthStaff("biko", .Text) Then
                MsgBox("備考は全角50字以内で入力してください")
                .Select()
                Return False

            End If
        End With



        '全ての検査を通過した
        Return True

    End Function

    '桁数チェック-車両番号(指定された列のサイズと文字列の比較) 
    Private Function CheckMaxLengthStaff(ByVal fieldname As String, ByVal value As String) As Boolean
        'データセットから列の情報を読み取る
        Dim column As DataColumn = PhoneNumDBDataSet.tbl_staff.Columns(fieldname)
        'シフトJISで文字列のバイト数を取得する
        Dim length As Integer = System.Text.Encoding.GetEncoding(932).GetByteCount(value)

        '指定されたサイズを超えたときはエラーになる
        If length > column.MaxLength Then
            Return False
        Else
            Return True
        End If

    End Function


    '重複チェック―氏名
    Private Function CheckNameOverlap(ByVal staffname As String) As Boolean
        Dim dbName As String
        Dim inputName As String

        For Each drw As DataRow In PhoneNumDBDataSet.tbl_staff.Rows()
            '行の状態が"削除"のデータを除外する
            If drw.RowState <> DataRowState.Deleted Then

                'この行の氏名と、入力された氏名を比較する
                '比較する文字列からスペースを抜く
                dbName = Replace(drw("staff_name"), "　", "")
                dbName = Replace(dbName, " ", "")
                inputName = Replace(staffname, "　", "")
                inputName = Replace(inputName, " ", "")
                If dbName = inputName Then
                    '重複の場合には終了する

                    Return False
                End If
            End If
        Next

        Return True
    End Function

    '氏名ｶﾅ用半角カタカナチェック
    Private Function CheckKana(ByVal value As String)


        If Not Regex.IsMatch(value, "^[0-9]{1,5}$") Then
            Return False

        Else
            Return True
        End If

    End Function

    'キーボードショートカット
    Private Sub frmMasterStaffNew_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub


    'ファイル選択ボタン
    Private Sub btnFileSelect_Click(sender As Object, e As EventArgs) Handles btnFileSelect.Click
        'OpenFileDialogクラスのインスタンスを作成
        Dim ofd As New OpenFileDialog()

        'はじめのファイル名を指定する
        'はじめに「ファイル名」で表示される文字列を指定する
        ofd.FileName = "XXXX.pdf"
        'はじめに表示されるフォルダを指定する
        '指定しない（空の文字列）の時は、現在のディレクトリが表示される
        ofd.InitialDirectory = "\\192.168.8.190\share\★★個人用フォルダ★★\菅原\scan"
        '[ファイルの種類]に表示される選択肢を指定する
        '指定しないとすべてのファイルが表示される
        ofd.Filter = "pdfファイル(*.pdf)|*.pdf|すべてのファイル(*.*)|*.*"
        '[ファイルの種類]ではじめに選択されるものを指定する
        '2番目の「すべてのファイル」が選択されているようにする
        ofd.FilterIndex = 1
        'タイトルを設定する
        ofd.Title = "車検証ファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        ofd.RestoreDirectory = True
        '存在しないファイルの名前が指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        ofd.CheckFileExists = True
        '存在しないパスが指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        ofd.CheckPathExists = True

        'ダイアログを表示する
        If ofd.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき、選択されたファイル名を表示する
            Console.WriteLine(ofd.FileName)
            txtFilePath.Text = ofd.FileName.ToString
        End If
    End Sub

    '日付チェック-年
    Private Function CheckTxtYear(ByVal value As String)
        '0を除く、1桁または2桁の整数
        If Regex.IsMatch(value, "^[0]$") Then
            Return False
        ElseIf Regex.IsMatch(value, "^[0-9]{1,2}$") Then
            Return True
        Else
            Return False
        End If

    End Function

    '日付チェック-月
    Private Function CheckTxtMonth(ByVal value As String)
        '1から12まで
        If Regex.IsMatch(value, "^[1-9]$|^[1][0-2]$") Then
            Return True
        Else
            Return False
        End If

    End Function

    '日付チェック-日
    Private Function CheckTxtDate(ByVal value As String)
        '1から31まで
        If Regex.IsMatch(value, "^[1-9]$|^[1][0-9]$|^[2][0-9]$|^[3][0-1]$") Then
            Return True
        Else
            Return False
        End If

    End Function
End Class