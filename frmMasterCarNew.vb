Imports System.Text.RegularExpressions
Public Class frmMasterCarNew
    Private Sub frmMasterCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_carTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_car)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_branch' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_branchTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_branch)


        '所属コンボボックスにデータをフィル


        '車格コンボボックスにデータをフィル
        cmbTon.Items.Add("2t平")
        cmbTon.Items.Add("2t平PG")
        cmbTon.Items.Add("2tU")
        cmbTon.Items.Add("3tU")
        cmbTon.Items.Add("4tU")
        cmbTon.Items.Add("7tU")
        cmbTon.Items.Add("10tU")
        cmbTon.Items.Add("15tU")
        cmbTon.Items.Add("その他")

        'メーカーコンボボックスにデータをフィル
        cmbMaker.Items.Add("日野")
        cmbMaker.Items.Add("いすゞ")
        cmbMaker.Items.Add("三菱")
        cmbMaker.Items.Add("トヨタ")

        '車種コンボボックスにデータをフィル
        cmbCarType.Items.Add("平４段クレーン")
        cmbCarType.Items.Add("平３段クレーン")
        cmbCarType.Items.Add("平３段クレーンPG")
        cmbCarType.Items.Add("平格納クレーン")
        cmbCarType.Items.Add("平パワーゲート")

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
        Dim syakenLimit As Date
        syakenLimit = mdlMain.Wareki_to_AD("平成" & txtYear.Text & "年" & txtMonth.Text & "月" & txtDay.Text & "日")


        '保存確認と保存処理
        If MsgBox("この内容で新規登録してよろしいですか？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            '行の定義
            Dim newrecord As PhoneNumDBDataSet.tbl_carRow = Me.PhoneNumDBDataSet.tbl_car.Newtbl_carRow

            Try
                '行にデータをセットする
                newrecord.carnum1 = txtCarnum1.Text
                newrecord.carnum2 = txtCarnum2.Text
                newrecord.carnum3 = txtCarnum3.Text
                newrecord.carnum4 = txtCarnum4.Text
                'txtMusenを空欄のまま処理すると、string→intの変換ができないと言われるので…
                If Not txtMusen.Text = "" Then
                    newrecord.musen = CInt(txtMusen.Text)
                End If
                newrecord.ton = cmbTon.SelectedItem
                newrecord.branch_id = cmbBranch.SelectedValue

                If Not txtMaxLoad.Text = "" Then
                    newrecord.max_load = txtMaxLoad.Text
                End If

                newrecord.limit_syaken = syakenLimit
                newrecord.biko = txtBiko.Text

                If Not txtCar_length.Text = "" Then
                    newrecord.car_length = CInt(txtCar_length.Text)
                End If

                If Not txtCar_width.Text = "" Then
                    newrecord.car_width = CInt(txtCar_width.Text)
                End If
                If Not txtCar_height.Text = "" Then
                    newrecord.car_height = CInt(txtCar_height.Text)
                End If

                If Not txtBed_length.Text = "" Then
                    newrecord.bed_length = CInt(txtBed_length.Text)
                End If
                If Not txtBed_width.Text = "" Then
                    newrecord.bed_width = CInt(txtBed_width.Text)
                End If
                If Not txtBed_height.Text = "" Then
                    newrecord.bed_height = CInt(txtBed_height.Text)
                End If

                newrecord.emergency = cbxEmergency.Checked
                newrecord.maker = cmbMaker.Text
                newrecord.car_type = cmbCarType.Text
                newrecord.retire_flag = cbxRetireFlag.Checked

                '新規行をデータテーブルに追加する
                Me.PhoneNumDBDataSet.tbl_car.Addtbl_carRow(newrecord)

                'テーブルアダプタを介して、tbl_carテーブルを更新する
                Me.Tbl_carTableAdapter.Update(Me.PhoneNumDBDataSet.tbl_car)

            Catch ex As Exception
                'エラーメッセージを表示する
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, Me.Text)
                Return

            End Try

            '車検証ファイルの登録処理

            ''選択された車番の車検証をoldフォルダに移動
            'Dim files As System.Collections.ObjectModel.ReadOnlyCollection(Of String) =
            '     My.Computer.FileSystem.GetFiles(
            '     "\\192.168.8.190\share\system\syaken",
            '      FileIO.SearchOption.SearchTopLevelOnly,
            '     "" & txtCarnum1.Text & "_*")

            '\\system\syakenに該当車番ファイルが見つからなかったら、メッセージを出して次へ
            'If files.Count = 0 Then

            '    If MsgBox("車両番号：" & txtCarnum1.Text & "の以前の車検証ファイルが見つかりません。ファイルは新規に保存されます。続行しますか？", vbYesNo) = vbYes Then

            '    Else
            '        Return

            '    End If

            '    '\\system\syakenに該当車番ファイルが見つかったら、以前の車検証ファイルはoldフォルダに移動する

            'Else

            'If MsgBox("車両番号：" & txtCarnum1.Text & "の以前の車検証ファイルが見つかりました。ファイルは上書きされます。続行しますか？", vbYesNo) = vbYes Then
            '        For Each f As String In files
            '            System.IO.File.Move(f, "\\192.168.8.190\share\system\syaken\old\" & Split(f, "\").Last)
            '        Next
            '    Else
            '        Return
            '    End If
            'End If

            '選択された車番の新しい車検証をsyakenフォルダにコピー＆リネーム　例：1467_車検証_20170101.pdf
            Dim newSyakenFilePath As String
            newSyakenFilePath = "\\192.168.8.190\share\system\syaken\" & txtCarnum1.Text & "_車検証_" & syakenLimit.ToLongDateString & ".pdf"
            System.IO.File.Copy(txtFilePath.Text, newSyakenFilePath)

            'フォームを閉じる
            Me.Close()
        End If
    End Sub

    Private Function CheckEditData() As Boolean

        'データの検査(車両番号)
        With txtCarnum1
            '空白でない
            If .Text = "" Then
                MsgBox("車両番号は必ず入力してください")
                .Select()
                Return False
            End If

            '文字数チェック
            If Not CheckMaxLengthCar("carnum1", .Text) Then
                MsgBox("車両番号は半角4字以内で入力してください")
                .Select()
                Return False

            End If

            '数字のみからなっている
            If Not CheckCarNumber(txtCarnum1.Text) Then

                .Select()
                Return False

            End If

            '車両番号は、既存の登録と重複がないかチェックする
            If Not CheckOverlap(txtCarnum1.Text) Then
                MsgBox("車両番号が既存のデータと重複しています")
                .Select()
                Return False
            End If
        End With

        'データの検査(地名)
        With txtCarnum2
            If Not CheckMaxLengthCar("carnum2", .Text) Then
                MsgBox("地名は全角4字以内で入力してください")
                .Select()
                Return False
            End If
        End With

        'データの検査(分類番号)
        With txtCarnum3
            If Not CheckMaxLengthCar("carnum3", .Text) Then
                MsgBox("分類番号は半角3字以内で入力してください")
                .Select()
                Return False
            End If
        End With

        'データの検査(ひらがな)
        With txtCarnum4
            If Not CheckMaxLengthCar("carnum4", .Text) Then
                MsgBox("ひらがなは全角1字で入力してください")
                .Select()
                Return False
            End If
        End With

        'データの検査(無線番号)

        With txtMusen
            If Not .Text = "" Then
                If Not CheckInteger(.Text) Then

                    MsgBox("無線番号は半角数字のみで入力してください")
                    .Select()
                    Return False
                End If
            End If
        End With

        'データの検査（最大積載量）
        With txtMaxLoad
            If Not .Text = "" Then
                If Not CheckInteger(.Text) Then
                    MsgBox("最大積載量は半角数字のみで入力してください")
                    .Select()
                    Return False
                End If
            End If
        End With

        'データの検査(備考)
        With txtBiko
            If Not CheckMaxLengthCar("biko", .Text) Then
                MsgBox("備考は全角50字以内で入力してください")
                .Select()
                Return False

            End If
        End With

        '車検証ファイルが選択されていなければキャンセル
        If txtFilePath.Text = "" Then
            MsgBox("車検証ファイルを選択してください")
            Return False
        End If


        'データの検査(長さ)
        With txtCar_length
            If Not .Text = "" Then
                If Not CheckInteger(.Text) Then

                    MsgBox("長さは半角数字のみで入力してください")
                    .Select()
                    Return False
                End If
            End If
        End With
        'データの検査(幅)
        With txtCar_width
            If Not .Text = "" Then
                If Not CheckInteger(.Text) Then

                    MsgBox("幅は半角数字のみで入力してください")
                    .Select()
                    Return False
                End If
            End If
        End With
        'データの検査(高さ)
        With txtCar_height
            If Not .Text = "" Then
                If Not CheckInteger(.Text) Then

                    MsgBox("高さは半角数字のみで入力してください")
                    .Select()
                    Return False
                End If
            End If
        End With
        'データの検査(荷台長)
        With txtBed_length
            If Not .Text = "" Then
                If Not CheckInteger(.Text) Then

                    MsgBox("荷台長は半角数字のみで入力してください")
                    .Select()
                    Return False
                End If
            End If
        End With
        'データの検査(荷台幅)
        With txtBed_width
            If Not .Text = "" Then
                If Not CheckInteger(.Text) Then

                    MsgBox("荷台幅は半角数字のみで入力してください")
                    .Select()
                    Return False
                End If
            End If
        End With
        'データの検査(荷台高)
        With txtBed_height
            If Not .Text = "" Then
                If Not CheckInteger(.Text) Then

                    MsgBox("荷台高は半角数字のみで入力してください")
                    .Select()
                    Return False
                End If
            End If
        End With

        'データの検査(メーカー)
        With cmbMaker
            If Not CheckMaxLengthCar("maker", .Text) Then
                MsgBox("メーカー名は全角７字以内で入力してください")
                .Select()
                Return False

            End If
        End With

        'データの検査(車種)
        With cmbCarType
            If Not CheckMaxLengthCar("car_type", .Text) Then
                MsgBox("メーカー名は全角15字以内で入力してください")
                .Select()
                Return False

            End If
        End With

        '全ての検査を通過した
        Return True

    End Function

    '桁数チェック-車両番号(指定された列のサイズと文字列の比較) 
    Private Function CheckMaxLengthCar(ByVal fieldname As String, ByVal value As String) As Boolean
        'データセットから列の情報を読み取る
        Dim column As DataColumn = PhoneNumDBDataSet.tbl_car.Columns(fieldname)
        'シフトJISで文字列のバイト数を取得する
        Dim length As Integer = System.Text.Encoding.GetEncoding(932).GetByteCount(value)

        '指定されたサイズを超えたときはエラーになる
        If length > column.MaxLength Then
            Return False
        Else
            Return True
        End If
    End Function

    '重複チェック―車両番号
    Private Function CheckOverlap(ByVal number As String) As Boolean


        For Each drw As DataRow In PhoneNumDBDataSet.tbl_car.Rows()
            '行の状態が"削除"のデータを除外する
            If drw.RowState <> DataRowState.Deleted Then
                'この行の電話番号と、入力された電話番号を比較する
                If drw("carnum1") = number Then
                    '重複の場合には終了する

                    Return False
                End If
            End If
        Next

        Return True
    End Function

    '車両番号が数字のみからなっているかチェック
    Private Function CheckCarNumber(ByVal number As String) As Boolean
        Dim i As Integer
        Dim cs As String

        For i = 1 To Len(number)
            '検査する文字を1つずつ抜き出す
            cs = Mid(number, i, 1)

            If (cs < "0" OrElse cs > "9") Then
                '数字以外が含まれていた場合
                MsgBox("車両番号に数字以外の文字が含まれています")
                Return False
            End If
        Next

        '適切な文字列だった
        Return True
    End Function

    'musen用integerチェック
    Private Function CheckInteger(ByVal value As String)


        If Not Regex.IsMatch(value, "^[0-9]{1,5}$") Then
            Return False

        Else
            Return True
        End If

    End Function

    'キーボードショートカット
    Private Sub frmMasterCar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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