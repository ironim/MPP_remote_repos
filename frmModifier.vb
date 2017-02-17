Imports System.Text.RegularExpressions

Public Class frmModifier

    '###起動###
    'public sub SetSelectedRecordが実行されると、frmGrdから受け取ったpcode,scode,ccodeをもとに、Tbl_phonenum,tbl_staff,tbl_carにデータソースをセットする
    'TableAdapter.FillByCode(table,code)

    '###レコードの組み合わせの変更(コンボボックス)
    '三つの操作パターンがある。すなわち

    '3つのテーブルに対応する各コンボボックスの(cmbPhonenumChangeほか)のSelectedValueChangedイベントが発生すると、
    '(各テーブルにデータバインドしている)lblphonenum,lblstaffID,lblcarnumに値が入る。
    'このとき、電話番号、社員番号、車番の組み合わせの変更を一時記録するため、以下の2変数(連結用データ変数と呼称する)にコンボボックスの値を保存する。

    'Private tblPhonenumStaffID As String
    'Private tblStaffPhonenum As String
    'Private tblStaffCarnum As String
    'Private tblStaffBranchID As String
    'Private tblCarBranchID As String
    'Private tblCarStaffID As String

    'Private tblPhoneNumStaffIDnew = TblPhoneNumBindingSource.Current
    '[決定]ボタンが押されて変更が確定したら、まず、dataAdapter.Updateを実行し、(連結用データ以外の)レコード内容の変更を更新する。
    '次に、連結用データの変数をもとに、レコード変更クエリを実行し、当該レコードの連結用データを更新する。

    Private frm_Grd As frmGrd

    Public Sub SetSelectedRecord(ByVal pcode As String, ByVal scode As String, ByVal ccode As String, ByVal f As frmGrd)
        '呼び出し元フォームを格納する
        frm_Grd = f

        '電話番号マスタのデータをデータソースにセット
        'Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)

        '受け取ったコードを利用して、該当するテーブルのデータをデータソースにセット
        Me.Tbl_PhoneNumTableAdapter.FillByPcode(Me.PhoneNumDBDataSet.tbl_PhoneNum, pcode)
        Me.Tbl_staffTableAdapter.FillByScode(Me.PhoneNumDBDataSet.tbl_staff, scode)
        Me.Tbl_carTableAdapter.FillByCcode(Me.PhoneNumDBDataSet.tbl_car, ccode)

    End Sub

    Private Sub frmModifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_PhoneNum' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)
        ''TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_carTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_car)
        ''TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_staff' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_staffTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_staff)
        ''TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_branch' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_branchTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_branch)

        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_branch' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_branchTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_branch)

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)

            'コマンドをコネクションから作成する
            Dim command As SqlClient.SqlCommand = connection.CreateCommand

            'コネクションを開く
            connection.Open()

            'データリーダーの定義
            Dim dr As SqlClient.SqlDataReader

            '先頭に(全て)を追加する
            cmbPhonenumChange.Items.Add("")
            cmbStaffNameChange.Items.Add("")
            cmbCarnumChange.Items.Add("")

            '### 電話番号変更用コンボボックスの設定###
            'データコマンドの定義
            command.CommandText = "SELECT phonenum FROM tbl_phonenum ORDER BY phonenum"

            'データリーダーからのデータの読出し
            dr = command.ExecuteReader()

            Do While dr.Read
                '読みだしたデータをコンボボックスに追加する
                cmbPhonenumChange.Items.Add(dr("phonenum"))
            Loop

            'データリーダーを閉じる
            dr.Close()

            '###氏名変更用コンボボックス###
            'データコマンドの定義
            command.CommandText = "SELECT id_staff, staff_name, staff_kana FROM tbl_staff ORDER BY staff_kana"

            'データリーダーからのデータの読出し
            dr = command.ExecuteReader()

            Do While dr.Read
                '読みだしたデータをコンボボックスに追加する
                cmbStaffNameChange.Items.Add(dr("id_staff") & " " & dr("staff_name"))
            Loop

            'データリーダーを閉じる
            dr.Close()

            '###車番変更用コンボボックス###
            command.CommandText = "SELECT carnum1 FROM tbl_car ORDER BY carnum1"

            'データリーダーからのデータの読出し
            dr = command.ExecuteReader()

            Do While dr.Read
                '読みだしたデータをコンボボックスに追加する
                cmbCarnumChange.Items.Add(dr("carnum1"))
            Loop

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()

            '3つのコンボボックスで既定の状態として、先頭の空行を選択する
            cmbPhonenumChange.SelectedIndex = 0
            cmbStaffNameChange.SelectedIndex = 0
            cmbCarnumChange.SelectedIndex = 0

        End Using

        'フォーム開始時、所属コンボボックスの値が自動でセットされないでindex = 0になってしまうので苦肉の策
        cmbStaffBranch.SelectedValue = lblStaffBranch.Text
        cmbCarBranch.SelectedValue = lblCarBranch.Text

        ''### 車格コンボボックスに値をセット ###
        'cmbTon.Items.Add("2t平")
        'cmbTon.Items.Add("2t平PG")
        'cmbTon.Items.Add("2tU")
        'cmbTon.Items.Add("3tU")
        'cmbTon.Items.Add("4tU")
        'cmbTon.Items.Add("7tU")
        'cmbTon.Items.Add("10tU")
        'cmbTon.Items.Add("15tU")
        'cmbTon.Items.Add("その他")

    End Sub


    '###電話番号変更コンボボックスの値が変更されたら###
    Private Sub cmbPhonenumChange_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPhonenumChange.SelectedValueChanged
        'コンボボックスの変更後の値をクエリにしてfrmModifierに値をフィルしたあと、
        If cmbPhonenumChange.SelectedIndex > 0 Then
            Dim pcode As String = cmbPhonenumChange.Text
            Me.Tbl_PhoneNumTableAdapter.FillByPcode(Me.PhoneNumDBDataSet.tbl_PhoneNum, pcode)
        End If


    End Sub

    '###車番変更コンボボックスの値が変更されたら###
    Private Sub cmbCarnumChange_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCarnumChange.SelectedValueChanged
        '車番コンボボックスの変更後の値をクエリにしてfrmModifierに値をフィルした後、
        If cmbCarnumChange.SelectedIndex > 0 Then
            Dim carcode As String = cmbCarnumChange.Text
            Me.Tbl_carTableAdapter.FillByCcode(Me.PhoneNumDBDataSet.tbl_car, carcode)
        End If

    End Sub

    '###氏名変更コンボボックスの値が変更されたら###
    Private Sub cmbStaffNameChange_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbStaffNameChange.SelectedValueChanged
        If cmbStaffNameChange.SelectedIndex > 0 Then
            '    lblstaffID.Text = Strings.Left(cmbStaffNameChange.Text, 5)

            Dim scode As String = Strings.Left(cmbStaffNameChange.Text, 5)
            Me.Tbl_staffTableAdapter.FillByScode(Me.PhoneNumDBDataSet.tbl_staff, scode)

            '    lblCarStaffId.Text = lblstaffID.Text
            '    lblPhoneStaffID.Text = lblstaffID.Text
            '    lblStaffCarnum.Text = lblCarnum.Text
            '   End If

            ' tblCarStaffID = Strings.Left(cmbStaffNameChange.Text, 5)

            Me.Tbl_PhoneNumTableAdapter.FillByStaffPhonenum(Me.PhoneNumDBDataSet.tbl_PhoneNum, scode)
            ' tblStaffPhonenum = lblPhonenum.Text
        End If

    End Sub





    '[キャンセル]ボタン
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        '呼び出し元のフォームを表示する
        frm_Grd.Visible = True

        'このフォームを閉じる
        Me.Close()

    End Sub

    '[登録]ボタンを押すと、現在表示されている内容で各テーブルのレコードを更新する
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        '社員情報、車両情報がともに空欄ならキャンセルする
        If lblstaffID.Text = "" And lblCarnum.Text = "" Then
            MsgBox("編集するレコードがありません")
            Return
        End If

        '社員情報が空欄で、電話番号だけある場合、キャンセルする
        If lblstaffID.Text = "" And lblPhonenum.Text <> "" Then
            MsgBox("電話番号と社員の対応がありません")
            Return
        End If

        '登録する内容がデータ型と一致しているかチェック
        If Not CheckEditData() Then
            Return
        End If

        '保存確認と保存処理
        If MsgBox("これまでの修正内容をデータベースに保存しますか？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            '###テーブルアダプタを介して、レコードを更新する###

            '三つの処理：
            '1.備考をUpdate
            '2.ClearPreviousPhonenum/Carnumで外部キーをクリア
            '3.UpdateStaffPhonenum/Carnumで外部キーをUpdate

            '備考をUpdateする
            If Not lblPhonenum.Text = "" Then
                Me.Tbl_PhoneNumTableAdapter.UpdatePhonenumBiko(txtBikoPhone.Text, lblPhonenum.Text)
            End If

            If Not lblstaffID.Text = "" Then
                Me.Tbl_staffTableAdapter.UpdateStaffBiko(txtBikoStaff.Text, lblstaffID.Text)
            End If

            If Not lblCarnum.Text = "" Then
                Me.Tbl_carTableAdapter.UpdateCarBiko(txtBikoCar.Text, lblCarnum.Text)
            End If

            'tblStaffの外部キーの整合性をとる。(複数のstaffレコードが、同一のstaff_phonenumないしstaff_Carnumをもってはならない。)
            '変数tblStaffPhonenumをもつtbl_staff内のレコードをすべて探し、そのstaff_phonenum列をクリアする。
            'このとき、現在表示されているレコードのstaff_carnum/phonenumも消えるが、後段のUpdateStaffCarnum/Phonenumで再登録する。
            If Not lblPhonenum.Text = "" Then
                Me.Tbl_staffTableAdapter.ClearPreviousStaffPhonenum(lblPhonenum.Text)
            End If

            'tblCarnumについても同様。
            If Not lblCarnum.Text = "" Then
                Me.Tbl_staffTableAdapter.ClearPreviousStaffCarnum(lblCarnum.Text)
            End If

            '現在表示されているレコードのstaff_phonenum列に変数tblStaffPhonenumを代入する。
            If Not lblstaffID.Text = "" Then
                Me.Tbl_staffTableAdapter.UpdateStaffPhonenum(lblPhonenum.Text, lblstaffID.Text)
                'StaffCarnumについても同様。
                Me.Tbl_staffTableAdapter.UpdateStaffCarnum(lblCarnum.Text, lblstaffID.Text)
            End If

            'フォームを閉じる
            Me.Close()


            End If
    End Sub

    '[クリア]ボタンを押すと、lblIPhonenum,lblStaffID,lblCarnumを空白にする。
    '電話番号クリアボタン
    Private Sub btnClearPhone_Click(sender As Object, e As EventArgs) Handles btnClearPhone.Click
        lblPhonenum.Text = ""

        Dim pcode As String = lblPhonenum.Text
        Me.Tbl_PhoneNumTableAdapter.FillByPcode(Me.PhoneNumDBDataSet.tbl_PhoneNum, pcode)

    End Sub

    '社員クリアボタン
    Private Sub btnClearStaff_Click(sender As Object, e As EventArgs) Handles btnClearStaff.Click
        lblstaffID.Text = ""

        Dim scode As String = lblstaffID.Text
        Me.Tbl_staffTableAdapter.FillByScode(Me.PhoneNumDBDataSet.tbl_staff, scode)

        '電話番号も同時にクリアする
        lblPhonenum.Text = ""
        Dim pcode As String = lblPhonenum.Text
        Me.Tbl_PhoneNumTableAdapter.FillByPcode(Me.PhoneNumDBDataSet.tbl_PhoneNum, pcode)

    End Sub

    '車両クリアボタン
    Private Sub btnClearCar_Click(sender As Object, e As EventArgs) Handles btnClearCar.Click

        lblCarnum.Text = ""
        Dim carcode As String = lblCarnum.Text
        Me.Tbl_carTableAdapter.FillByCcode(Me.PhoneNumDBDataSet.tbl_car, carcode)

    End Sub

    Private Function CheckEditData() As Boolean

        '電話番号情報の検査 電話番号が選択されてなければスキップ
        If lblPhonenum.Text <> "" Then

            '同じ電話番号を使っている人がいないかチェック
            '同じ番号を使っている人がいた場合、上書きするかたずねる
            'If Not lblPhonenum.Text = "" Then
            '    CheckPhoneOverlap(lblPhonenum.Text)
            'End If
            ''データの検査(機種名)
            'With txtModel
            '    If Not CheckMaxLengthPhone("model", .Text) Then
            '        MsgBox("機種名は半角20字以内で入力してください")
            '        .Select()
            '        Return False
            '    End If
            'End With

            'With txtMail
            '    'データの検査(メール)
            '    If Not CheckMaxLengthPhone("mail", .Text) Then
            '        MsgBox("メールアドレスは半角50字以内で入力してください")
            '        .Select()
            '        Return False
            '    End If
            'End With

            'データの検査(備考)
            With txtBikoPhone
                If Not CheckMaxLengthPhone("biko", .Text) Then
                    MsgBox("備考は全角50字以内で入力してください")
                    .Select()
                    Return False
                End If
            End With

        End If

        '社員情報の検査　社員が選択されていなければスキップ
        If lblstaffID.Text <> "" Then
            'データの検査(氏名ｶﾅ)
            'With txtStaffKana
            '    If Not CheckMaxLengthStaff("staff_kana", .Text) Then
            '        MsgBox("氏名ｶﾅは半角20字以内で入力してください")
            '        .Select()
            '        Return False
            '    End If
            'End With

            'データの検査(備考)
            With txtBikoStaff
                If Not CheckMaxLengthStaff("biko", .Text) Then
                    MsgBox("備考は全角50字以内で入力してください")
                    .Select()
                    Return False

                End If


            End With
            ''データの検査(所属)
            'With cmbStaffBranch
            '    If .SelectedIndex = -1 Then
            '        MsgBox("社員の所属が選択されていません")
            '        .Select()
            '        Return False
            '    End If
            'End With

        End If

        '車両情報の検査　車両が選択されていなければスキップ
        If lblCarnum.Text <> "" Then

            '同じ車両に乗っている人がいないかチェック
            '同じ車両に乗っている人がいた場合、上書きするかたずねる
            'If Not lblCarnum.Text = "" Then
            '    CheckCarOverlap(lblCarnum.Text)

            'End If


            ''データの検査(車番2)
            'With txtCarnum2
            '    If Not CheckMaxLengthCar("carnum2", .Text) Then
            '        MsgBox("車番2は全角4字以内で入力してください")
            '        .Select()
            '        Return False
            '    End If
            'End With

            ''データの検査(車番3)
            'With txtCarnum3
            '    If Not CheckMaxLengthCar("carnum3", .Text) Then
            '        MsgBox("車番3は半角3字以内で入力してください")
            '        .Select()
            '        Return False
            '    End If
            'End With

            ''データの検査(車番4)
            'With txtCarnum4
            '    If Not CheckMaxLengthCar("carnum4", .Text) Then
            '        MsgBox("車番4は全角1文字で入力してください")
            '        .Select()
            '        Return False
            '    End If
            'End With

            ''データの検査(無線)
            'With txtMusen
            '    If Not CheckInteger(.Text) Then

            '        MsgBox("無線番号は1~9999の範囲で入力してください")
            '        .Select()
            '        Return False
            '    End If
            'End With

            ''データの検査(車格)
            'With txtTon
            '    If Not CheckMaxLengthCar("ton", .Text) Then
            '        MsgBox("車格は半角4字以内で入力してください")
            '        .Select()
            '        Return False
            '    End If
            'End With

            'データの検査(備考)
            With txtBikoCar
                If Not CheckMaxLengthCar("biko", .Text) Then
                    MsgBox("備考は全角50字以内で入力してください")
                    .Select()
                    Return False
                End If
            End With

            'データの検査(車庫)
            'With cmbCarBranch
            '    If .SelectedIndex = -1 Then
            '        MsgBox("車両の所属が選択されていません")
            '        .Select()
            '        Return False

            '    End If
            'End With
        End If

        '全ての検査を通過した
        Return True

    End Function

    'musen用integerチェック
    'Private Function CheckInteger(ByVal value As String)


    '    If Not Regex.IsMatch(value, "^[0-9]{1,4}$") Then
    '        Return False

    '    Else
    '        Return True
    '    End If

    'End Function

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

    '桁数チェック-社員(指定された列のサイズと文字列の比較)
    Private Function CheckMaxLengthStaff(ByVal fieldname As String, ByVal value As String)
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

    '桁数チェック-車両(指定された列のサイズと文字列の比較)
    Private Function CheckMaxLengthCar(ByVal fieldname As String, ByVal value As String)
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

    ''車格コンボボックスの値が変更されたら、車格テキストボックスに代入
    'Private Sub cmbTon_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    txtTon.Text = cmbTon.SelectedItem
    'End Sub

    ''重複チェック－－電話番号
    'Private Sub CheckPhoneOverlap(ByVal staffphonenum As String)
    '    Dim dbNum As String
    '    Dim inputNum As String

    '    inputNum = staffphonenum
    '    For Each drw As DataRow In PhoneNumDBDataSet.tbl_staff.Rows()
    '        If drw.RowState <> DataRowState.Deleted Then
    '            dbNum = drw("staff_phonenum").ToString

    '            If dbNum = inputNum Then
    '                MsgBox(drw("staff_phonenum").ToString & vbCrLf & "この番号は次の人に使用されています：" & drw("staff_name") & vbCrLf & "登録すると使用者は上書きされます。")

    '            End If
    '        End If
    '    Next


    'End Sub

    ''重複チェック－－車両番号
    'Private Sub CheckCarOverlap(ByVal staffcarnum As String)
    '    Dim dbCarnum As String
    '    Dim inputCarnum As String

    '    inputCarnum = staffcarnum
    '    For Each drw As DataRow In PhoneNumDBDataSet.tbl_staff.Rows()
    '        If drw.RowState <> DataRowState.Deleted Then
    '            dbCarnum = drw("staff_carnum").ToString

    '            If dbCarnum = inputCarnum Then
    '                MsgBox(drw("staff_carnum").ToString & vbCrLf & "この車両は次の人に使用されています：" & drw("staff_name") & vbCrLf & "登録すると使用者は上書きされます。")

    '            End If
    '        End If
    '    Next

    'End Sub


    'キーボードショートカット
    Private Sub frmModifier_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub

    '免許更新ボタン
    Private Sub btnMenkyoUpdate_Click(sender As Object, e As EventArgs) Handles btnMenkyoUpdate.Click
        If lblstaffID.Text = "" Then
            Return
        End If

        Dim frm As New frmMenkyoUpload
        '[選択行の編集]フォームのSetSelectedRecordプロシージャを呼び出し、
        '指定した電話番号のデータを表示する
        frm.SetSelectedStaff(lblstaffID.Text, Me)
        '[選択行の編集]フォームを表示する
        frm.ShowDialog(Me)
    End Sub

    '車検証更新ボタン
    Private Sub btnSyakenUpdate_Click(sender As Object, e As EventArgs) Handles btnSyakenUpdate.Click
        '車両レコードがなかったら戻る
        If lblCarnum.Text = "" Then
            Return
        End If

        Dim frm As New frmSyakenUpload
        '[選択行の編集]フォームのSetSelectedRecordプロシージャを呼び出し、
        '指定した電話番号のデータを表示する
        frm.SetSelectedCar(lblCarnum.Text, Me)
        '[選択行の編集]フォームを表示する
        frm.ShowDialog(Me)
    End Sub

    '自賠責更新ボタン
    Private Sub btnJibaiUpdate_Click(sender As Object, e As EventArgs) Handles btnJibaiUpdate.Click

    End Sub

    'クレーン点検簿更新ボタン
    Private Sub btnCraneUpdate_Click(sender As Object, e As EventArgs) Handles btnCraneUpdate.Click

    End Sub
End Class