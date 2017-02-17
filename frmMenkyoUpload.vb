Imports System.Text.RegularExpressions

Public Class frmMenkyoUpload
    Private Sub frmMenkyoUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_staffTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_staff)

    End Sub

    Public Sub SetSelectedStaff(ByVal scode As String, ByVal f As frmModifier)
        '呼び出し元フォームを格納する
        'frm_Modifier = f

        '受け取ったコードを利用して、該当するテーブルのデータをデータソースにセット
        Me.Tbl_staffTableAdapter.FillByScode(Me.PhoneNumDBDataSet.tbl_staff, scode)

    End Sub

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
        ofd.Title = "免許証ファイルを選択してください"
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
            txtFilePath.Text = ofd.FileName.ToString
        End If

    End Sub



    'アップロードボタン
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'ファイルが選択されていなければキャンセル
        If txtFilePath.Text = "" Then
            MsgBox("ファイルを選択してください")
            Return
        End If

        '日付が入力されていなければキャンセル
        If txtYear.Text = "" Or txtMonth.Text = "" Or txtDay.Text = "" Then
            MsgBox("日付を入力してください")

            Return
        End If

        '日付の値チェック
        If Not CheckTxtYear(txtYear.Text) Or Not CheckTxtMonth(txtMonth.Text) Or Not ChecktxtDate(txtDay.Text) Then
            MsgBox("日付を正しく入力してください")
            Return
        End If

        '選択された氏名の免許証をoldフォルダに移動
        Dim files As System.Collections.ObjectModel.ReadOnlyCollection(Of String) =
                 My.Computer.FileSystem.GetFiles(
                 "\\192.168.8.190\share\system\menkyo",
                  FileIO.SearchOption.SearchTopLevelOnly,
                 "" & cmbStaff.Text & "_*")

        '\\system\syakenに該当氏名の免許証ファイルが見つからなかったら、メッセージを出して次へ
        If files.Count = 0 Then

            If MsgBox("氏名：" & cmbStaff.Text & "の以前の免許証ファイルが見つかりません。ファイルは新規に保存されます。続行しますか？", vbYesNo) = vbYes Then

            Else
                Return
            End If

            '\\system\menkyoに該当免許ファイルが見つかったら、以前の車検証ファイルはoldフォルダに移動する

        Else

            If MsgBox("氏名：" & cmbStaff.Text & "の以前の免許証ファイルが見つかりました。ファイルは上書きされます。続行しますか？", vbYesNo) = vbYes Then
                For Each f As String In files
                    System.IO.File.Move(f, "\\192.168.8.190\share\system\menkyo\old\" & Split(f, "\").Last)
                Next
            Else
                Return

            End If
        End If



        '日付入力を1行にまとめる
        Dim menkyoLimit As Date
        menkyoLimit = mdlMain.Wareki_to_AD("平成" & txtYear.Text & "年" & txtMonth.Text & "月" & txtDay.Text & "日")

        '選択された社員の新しい免許証をmenkyoフォルダにコピー＆リネーム　例：岩田　久彌_免許証_20170101.pdf
        Dim newMenkyoFilePath As String
        newMenkyoFilePath = "\\192.168.8.190\share\system\menkyo\" & cmbStaff.Text & "_免許証_" & menkyoLimit.ToLongDateString & ".pdf"

        System.IO.File.Copy(txtFilePath.Text, newMenkyoFilePath)

        'データベース上の免許証期限を更新する
        Me.Tbl_staffTableAdapter.UpdateLimitMenkyo(menkyoLimit, cmbStaff.SelectedValue)

        'フォームを閉じる
        Me.Close()

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