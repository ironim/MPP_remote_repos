
Imports System
Imports System.Globalization


Public Class frmGrd
    'sender As Object, e As EventArgs

    Private Sub frmGrd_Load() Handles MyBase.Load
        '日付を和暦で表示する
        Dim culture As CultureInfo = New CultureInfo("ja-JP", True)
        culture.DateTimeFormat.Calendar = New JapaneseCalendar()

        Application.CurrentCulture = culture
        DateTimeFormatInfo.CurrentInfo.ShortDatePattern = "gg yy/MM/dd"

        'frmMainの位置とウィンドウサイズを呼び出す
        Me.Top = My.Settings.frmMain_Top
        Me.Left = My.Settings.frmMain_Left
        Me.Width = My.Settings.frmMain_Width
        Me.Height = My.Settings.frmMain_Height


        grdMain.AutoGenerateColumns = False

        'grdMainの列順を呼び出す

        grdMain.Columns("phonenum").DisplayIndex = My.Settings.grdMain_phonenum_DisplayIndex
        grdMain.Columns("staff_name").DisplayIndex = My.Settings.grdMain_staff_name_DisplayIndex
        grdMain.Columns("carnum1").DisplayIndex = My.Settings.grdMain_carnum1_DisplayIndex
        grdMain.Columns("branch_name").DisplayIndex = My.Settings.grdMain_branch_name_DisplayIndex
        grdMain.Columns("musen").DisplayIndex = My.Settings.grdMain_musen_DisplayIndex
        grdMain.Columns("ton").DisplayIndex = My.Settings.grdMain_ton_DisplayIndex
        grdMain.Columns("car_branch").DisplayIndex = My.Settings.grdMain_car_branch_DisplayIndex
        grdMain.Columns("max_load").DisplayIndex = My.Settings.grdMain_max_load_DisplayIndex
        grdMain.Columns("limit_menkyo").DisplayIndex = My.Settings.grdMain_limit_menkyo_DisplayIndex
        grdMain.Columns("limit_syaken").DisplayIndex = My.Settings.grdMain_limit_syaken_DisplayIndex
        grdMain.Columns("car_length").DisplayIndex = My.Settings.grdMain_car_length_DisplayIndex
        grdMain.Columns("car_width").DisplayIndex = My.Settings.grdMain_car_width_DisplayIndex
        grdMain.Columns("car_height").DisplayIndex = My.Settings.grdMain_car_height_DisplayIndex
        grdMain.Columns("bed_length").DisplayIndex = My.Settings.grdMain_bed_length_DisplayIndex
        grdMain.Columns("bed_width").DisplayIndex = My.Settings.grdMain_bed_width_DisplayIndex
        grdMain.Columns("bed_height").DisplayIndex = My.Settings.grdMain_bed_height_DisplayIndex
        grdMain.Columns("maker").DisplayIndex = My.Settings.grdMain_maker_DisplayIndex
        grdMain.Columns("car_type").DisplayIndex = My.Settings.grdMain_car_type_DisplayIndex


        'TODO: このコード行はデータを 'PhoneNumDBDataSet.dtInteg' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.DtIntegTableAdapter.FillIntegTable(Me.PhoneNumDBDataSet.dtInteg)

        'コネクションを指定する
        Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)

            'コマンドをコネクションから作成する
            Dim command As SqlClient.SqlCommand = connection.CreateCommand

            'コネクションを開く
            connection.Open()

            'データリーダーの定義
            Dim dr As SqlClient.SqlDataReader

            '### 所属コンボボックス、車庫コンボボックスの設定###
            'コンボボックスをクリアする
            cmbBranchStaff.Items.Clear()
            cmbBranchCar.Items.Clear()
            '先頭に(全て)を追加する
            cmbBranchStaff.Items.Add("(すべて)")
            cmbBranchCar.Items.Add("(すべて)")

            'データコマンドの定義
            command.CommandText = "SELECT * FROM tbl_branch ORDER BY id_branch"

            'データリーダーからのデータの読出し
            dr = command.ExecuteReader()
            Do While dr.Read
                '読みだしたデータをコンボボックスに追加する
                cmbBranchStaff.Items.Add(dr("id_branch") & ":" & dr("branch_name"))
                cmbBranchCar.Items.Add(dr("id_branch") & ":" & dr("branch_name"))
            Loop

            'データリーダーを閉じる
            dr.Close()

            'コネクションを閉じる
            connection.Close()

            '2つのコンボボックスで既定の状態として、先頭の(すべて)を選択する
            cmbBranchStaff.SelectedIndex = 0
            cmbBranchCar.SelectedIndex = 0


            '管理者としてログインした場合、免許出力と管理メニューをenableする
            If mdlMain.UserIsAdmin Then
                btnAdmin.Enabled = True
                btnExportMenkyo.Enabled = True

            Else
                btnAdmin.Enabled = False
                btnExportMenkyo.Enabled = False

            End If



        End Using

        '指定された条件でデータベースを読み込む
        LoadDatabase()

    End Sub

    Public Sub LoadDatabase()
        Dim fs As String = ""
        Dim sql As String

        '電話番号フィルタの条件指定(部分一致)と条件式の作成
        If txtFilterPhonenum.Text <> "" Then
            fs = "tbl_phonenum.phonenum like '%" & txtFilterPhonenum.Text & "%'"
        End If

        '氏名フィルタの条件指定(部分一致)と条件式の作成
        If txtFilterKana.Text <> "" Then
            fs = "tbl_staff.staff_kana like '%" & txtFilterKana.Text & "%'"
        End If

        '所属コンボボックスの条件指定と条件式の作成
        If cmbBranchStaff.SelectedIndex > 0 Then
            If fs <> "" Then
                fs &= " AND "
            End If

            fs &= "tbl_staff.branch_id = '" & Strings.Left(cmbBranchStaff.Text, cmbBranchStaff.Text.IndexOf(":")) & "'"

        End If

        '車庫コンボボックスの条件指定と条件式の作成
        If cmbBranchCar.SelectedIndex > 0 Then
            If fs <> "" Then
                fs &= " AND "
            End If

            fs &= "tbl_car_enabled.branch_id = '" & Strings.Left(cmbBranchCar.Text, cmbBranchCar.Text.IndexOf(":")) & "'"

        End If

        '備考検索コンボボックスの条件指定と条件式の作成
        If txtFilterBiko.Text <> "" Then
            If fs <> "" Then
                fs &= " AND "
            End If
            fs &= "tbl_car_enabled.biko like '%" & txtFilterBiko.Text & "%' OR tbl_staff.biko like '%" & txtFilterBiko.Text & "%' OR tbl_phonenum.biko like '%" & txtFilterBiko.Text & "%' "
        End If
        'SQLステートメントの定義
        'sql = "Select tbl_PhoneNum.*, tbl_branch_1.*, tbl_staff.*, tbl_car.*, tbl_branch.* " &
        '      "From tbl_car INNER Join tbl_branch On tbl_car.branch_id = tbl_branch.id_branch FULL OUTER Join " &
        '      "tbl_staff INNER Join tbl_branch As tbl_branch_1 On tbl_staff.branch_id = tbl_branch_1.id_branch LEFT OUTER Join " &
        '      "tbl_PhoneNum On tbl_staff.staff_phonenum = tbl_PhoneNum.phonenum " &
        '      "ON tbl_car.carnum1 = tbl_staff.staff_carnum "

        'ON tbl_car.staff_id = tbl_staff.id_staff "

        sql = "Select tbl_PhoneNum.*, tbl_branch_1.*, tbl_staff.*, tbl_car_enabled.*, tbl_branch.* " &
           " From(select * from tbl_car where retire_flag = 0) As tbl_car_enabled INNER Join tbl_branch On tbl_car_enabled.branch_id = tbl_branch.id_branch " &
                   " FULL OUTER Join tbl_staff " &
                   " INNER Join tbl_branch As tbl_branch_1 On tbl_staff.branch_id = tbl_branch_1.id_branch " &
                   " Left OUTER Join tbl_PhoneNum On tbl_staff.staff_phonenum = tbl_PhoneNum.phonenum ON tbl_car_enabled.carnum1 = tbl_staff.staff_carnum "

        '条件が指定されているときには、WHERE句を追加する
        If fs <> "" Then
            sql &= " WHERE " & fs
            ' sql &= " WHERE tbl_car.retire_flag <> 1 AND " & fs
        Else
            '条件がなければ、無線番号順にソート（SQL文の末尾にORDER BYを追加）

            sql &= " ORDER BY tbl_car_enabled.musen "
            'sql &= "WHERE tbl_car.retire_flag <> 1 ORDER BY tbl_car.musen "
        End If

        'sql &= " EXCEPT SELECT tbl_car.* FROM tbl_car WHERE tbl_car.retire_flag = 1 "

        'データアダプタにSQLステートメントを設定する
        Dim da As New SqlClient.SqlDataAdapter(sql, My.Settings.PhoneNumDBConnectionString)

        'データテーブルをクリアする
        Me.PhoneNumDBDataSet.dtMain.Clear()

        'データテーブルにデータアダプタを介してデータをセットする
        da.Fill(Me.PhoneNumDBDataSet.dtMain)

        '現在の行数をラベルに表示する
        lblHowManyRecords.Text = Me.grdMain.RowCount & "件のデータが選択されました"

    End Sub

    '電話番号フィルター変更時、データベースを再読み込み
    Private Sub txtFilterPhonenum_TextChanged(sender As Object, e As EventArgs) Handles txtFilterPhonenum.TextChanged
        LoadDatabase()
    End Sub

    '氏名ｶﾅフィルター変更時、データベースを再読み込み
    Private Sub txtFilterKana_TextChanged(sender As Object, e As EventArgs) Handles txtFilterKana.TextChanged
        LoadDatabase()
    End Sub

    '所属コンボボックス変更時、データベースを再読み込み
    Private Sub cmbBranchStaff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranchStaff.SelectedIndexChanged


        LoadDatabase()

    End Sub

    '車庫コンボボックス変更時、データベースを再読み込み
    Private Sub cmbBranchCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranchCar.SelectedIndexChanged


        LoadDatabase()

    End Sub

    '絞り込みボタンから呼び出すプロシージャ
    '引数fsは必ず値を持つこと。
    Private Sub shiboriDatabase(ByVal fs As String)
        'データグリッドビューのソート（列名をクリックすると△ボタン表示されるやつ）が効いていると、そっちが優先されてしまうので、解除する。
        DtMainBindingSource.Sort = ""

        Dim sql As String

        'SQLステートメントの定義
        'sql = "Select tbl_PhoneNum.*, tbl_branch_1.*, tbl_staff.*, tbl_car.*, tbl_branch.* " &
        '      "From tbl_car INNER Join tbl_branch On tbl_car.branch_id = tbl_branch.id_branch FULL OUTER Join " &
        '      "tbl_staff INNER Join tbl_branch As tbl_branch_1 On tbl_staff.branch_id = tbl_branch_1.id_branch LEFT OUTER Join " &
        '      "tbl_PhoneNum On tbl_staff.staff_phonenum = tbl_PhoneNum.phonenum " &
        '      "ON tbl_car.carnum1 = tbl_staff.staff_carnum "

        'sql = "Select tbl_PhoneNum.*, tbl_branch_1.*, tbl_staff.*, tbl_car.*, tbl_branch.* " &
        '      "From tbl_car INNER Join tbl_branch On tbl_car.branch_id = tbl_branch.id_branch FULL OUTER Join " &
        '      "tbl_staff INNER Join tbl_branch As tbl_branch_1 On tbl_staff.branch_id = tbl_branch_1.id_branch LEFT OUTER Join " &
        '      "tbl_PhoneNum On tbl_staff.staff_phonenum = tbl_PhoneNum.phonenum ON tbl_car.staff_id = tbl_staff.id_staff "


        'sql &= " WHERE tbl_car.retire_flag = 0 AND "

        sql = "Select tbl_PhoneNum.*, tbl_branch_1.*, tbl_staff.*, tbl_car_enabled.*, tbl_branch.* " &
           " From(select * from tbl_car where retire_flag = 0) As tbl_car_enabled INNER Join tbl_branch On tbl_car_enabled.branch_id = tbl_branch.id_branch " &
                   " FULL OUTER Join tbl_staff " &
                   " INNER Join tbl_branch As tbl_branch_1 On tbl_staff.branch_id = tbl_branch_1.id_branch " &
                   " Left OUTER Join tbl_PhoneNum On tbl_staff.staff_phonenum = tbl_PhoneNum.phonenum ON tbl_car_enabled.carnum1 = tbl_staff.staff_carnum "

        sql &= "WHERE "


        '所属コンボボックスの条件指定と条件式の作成
        '車庫コンボボックスの条件指定と条件式の作成
        If cmbBranchStaff.SelectedIndex > 0 Then
            '車庫コンボボックスが値を持つ
            sql &= "tbl_staff.branch_id = '" & Strings.Left(cmbBranchStaff.Text, cmbBranchStaff.Text.IndexOf(":")) & "'"

            '車庫が値をもち、かつ所属も値を持つ
            If cmbBranchCar.SelectedIndex > 0 Then
                sql &= " AND tbl_car_enabled.branch_id = '" & Strings.Left(cmbBranchCar.Text, cmbBranchCar.Text.IndexOf(":")) & "'"
                sql &= " AND "
            End If
            '車庫が値をもつが、所属は値を持たない
            sql &= " AND "
        Else
            '車庫が値を持たない
            '車庫が値をもたないが、所属は値を持つ
            If cmbBranchCar.SelectedIndex > 0 Then
                sql &= " tbl_car_enabled.branch_id = '" & Strings.Left(cmbBranchCar.Text, cmbBranchCar.Text.IndexOf(":")) & "'"
                sql &= " AND "
            End If
            '車庫も所属も値を持たない

        End If


        sql &= fs

        'データアダプタにSQLステートメントを設定する
        Dim da As New SqlClient.SqlDataAdapter(sql, My.Settings.PhoneNumDBConnectionString)

        'データテーブルをクリアする
        Me.PhoneNumDBDataSet.dtMain.Clear()
        'Me.PhoneNumDBDataSet.dtMain.OrderBy(PhoneNumDBDataSet.dtMain.musenColumn)
        'データテーブルにデータアダプタを介してデータをセットする
        da.Fill(Me.PhoneNumDBDataSet.dtMain)

        '現在の行数をラベルに表示する
        lblHowManyRecords.Text = Me.grdMain.RowCount & "件のデータが選択されました"
    End Sub

    '絞り込みア行
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ｱ-ｵ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みカ行
    Private Sub btnKa_Click(sender As Object, e As EventArgs) Handles btnKa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ｶ-ｺ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みサ行
    Private Sub btnSa_Click(sender As Object, e As EventArgs) Handles btnSa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ｻ-ｿ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みタ行
    Private Sub btnTa_Click(sender As Object, e As EventArgs) Handles btnTa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾀ-ﾄ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みナ行
    Private Sub btnNa_Click(sender As Object, e As EventArgs) Handles btnNa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾅ-ﾉ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みハ行
    Private Sub btnHa_Click(sender As Object, e As EventArgs) Handles btnHa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾊ-ﾎ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みマ行
    Private Sub btnMa_Click(sender As Object, e As EventArgs) Handles btnMa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾏ-ﾓ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みヤ行
    Private Sub btnYa_Click(sender As Object, e As EventArgs) Handles btnYa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾔ-ﾖ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みラ行
    Private Sub btnRa_Click(sender As Object, e As EventArgs) Handles btnRa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾗ-ﾛ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込みワ行
    Private Sub btnWa_Click(sender As Object, e As EventArgs) Handles btnWa.Click
        Dim fs As String
        fs = "tbl_staff.staff_kana like '[ﾜ-ｦ]%' ORDER BY tbl_staff.staff_kana"

        shiboriDatabase(fs)
    End Sub

    '絞り込み1000未満
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim fs As String
        fs = "tbl_car_enabled.carnum1 like '___' ORDER BY tbl_car_enabled.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み1000番台
    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        Dim fs As String
        fs = "tbl_car_enabled.carnum1 like '1___' ORDER BY tbl_car_enabled.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み2000番台
    Private Sub btn2000_Click(sender As Object, e As EventArgs) Handles btn2000.Click
        Dim fs As String
        fs = "tbl_car_enabled.carnum1 like '2___' ORDER BY tbl_car_enabled.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み3000番台
    Private Sub btn3000_Click(sender As Object, e As EventArgs) Handles btn3000.Click
        Dim fs As String
        fs = "tbl_car_enabled.carnum1 like '3___' ORDER BY tbl_car_enabled.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み4000番台
    Private Sub btn4000_Click(sender As Object, e As EventArgs) Handles btn4000.Click
        Dim fs As String
        fs = "tbl_car_enabled.carnum1 like '4___' ORDER BY tbl_car_enabled.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み5000番台
    Private Sub btn5000_Click(sender As Object, e As EventArgs) Handles btn5000.Click
        Dim fs As String
        fs = "tbl_car_enabled.carnum1 like '5___' ORDER BY tbl_car_enabled.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み6000番台
    Private Sub btn6000_Click(sender As Object, e As EventArgs) Handles btn6000.Click
        Dim fs As String
        fs = "tbl_car_enabled.carnum1 like '6___' ORDER BY tbl_car_enabled.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み7000番台
    Private Sub btn7000_Click(sender As Object, e As EventArgs) Handles btn7000.Click
        Dim fs As String
        fs = "tbl_car_enabled.carnum1 like '7___' ORDER BY tbl_car_enabled.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み8000番台
    Private Sub btn8000_Click(sender As Object, e As EventArgs) Handles btn8000.Click
        Dim fs As String
        fs = "tbl_car_enabled.carnum1 like '8___' ORDER BY tbl_car_enabled.carnum1"

        shiboriDatabase(fs)
    End Sub

    '絞り込み9000番台
    Private Sub btn9000_Click(sender As Object, e As EventArgs) Handles btn9000.Click
        Dim fs As String
        fs = "tbl_car_enabled.carnum1 like '9___' ORDER BY tbl_car_enabled.carnum1"

        shiboriDatabase(fs)




    End Sub

    '[解除]ボタンを押すとフィルタを解除して全レコードを表示する
    Private Sub btnFilterClear_Click(sender As Object, e As EventArgs) Handles btnFilterClear.Click
        txtFilterKana.Text = ""
        txtFilterPhonenum.Text = ""
        cmbBranchStaff.SelectedIndex = 0
        cmbBranchCar.SelectedIndex = 0

        LoadDatabase()
    End Sub

    '[選択行の編集]ボタン
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        'データグリッドビューが空のときは終了する
        If grdMain.Rows.Count = 0 Then Return

        Dim row As Integer
        Dim pcode As String
        Dim scode As String
        Dim ccode As String

        'データグリッドビューの行番号を取得する
        row = grdMain.CurrentRow.Index
        '行番号から電話番号を取得する
        pcode = grdMain.Item(5, row).Value.ToString
        scode = grdMain.Item(16, row).Value.ToString
        ccode = grdMain.Item(2, row).Value.ToString

        Dim frm As New frmModifier
        '[選択行の編集]フォームのSetSelectedRecordプロシージャを呼び出し、
        '指定した電話番号のデータを表示する
        frm.SetSelectedRecord(pcode, scode, ccode, Me)
        '[選択行の編集]フォームを表示する
        frm.ShowDialog(Me)

        '[選択行の編集］フォームから戻ったら、このフォームを更新する
        LoadDatabase()

    End Sub

    '管理メニューボタン
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim frm As New frmAdmin
        frm.Show(Me)

    End Sub

    '[新しい行を追加]ボタン
    'Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddNewRow.Click
    '    Dim f As New frmAddRecord() '[新しい行を追加]フォーム

    '    '[新しい行を追加]フォームを表示する
    '    f.ShowDialog(Me)

    '    '新規登録の処理から戻ってきたら、表を更新する
    '    LoadDatabase()

    'End Sub

    '[選択した行を削除]ボタン
    'Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
    '    'データグリッドビューが空のときは終了する
    '    If grdMain.Rows.Count = 0 Then Return

    '    Dim row As Integer
    '    Dim phonenum As String
    '    Dim staffname As String
    '    Dim carnum As String
    '    Dim id As String

    '    'データグリッドビューの行番号を取得する
    '    row = grdMain.CurrentRow.Index
    '    '行番号から電話番号、氏名、車番、integ_idを取得する
    '    phonenum = grdMain.Item(1, row).Value.ToString
    '    staffname = grdMain.Item(9, row).Value.ToString
    '    carnum = grdMain.Item(15, row).Value.ToString
    '    id = grdMain.Item(0, row).Value.ToString


    '    'メッセージボックスに行情報を表示し、削除してよいか確認
    '    If MsgBox("電話番号：" & phonenum & ",　氏名：" & staffname & ",　車番：" & carnum & vbCrLf & "この行を削除してもよろしいですか？(マスタは削除されません。)", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) <> MsgBoxResult.Yes Then
    '        Return

    '    End If

    '    '処理の成功をチェックするフラグ
    '    Dim bSuccess As Boolean = False

    '    'コネクションを指定する
    '    Using connection As New SqlClient.SqlConnection(My.Settings.PhoneNumDBConnectionString)

    '        'コマンドを定義する
    '        Dim command As SqlClient.SqlCommand = connection.CreateCommand()

    '        'コネクションを開く
    '        connection.Open()

    '        'トランザクションの開始
    '        command.Transaction = connection.BeginTransaction()

    '        Try
    '            'コマンドの定義と実行
    '            '
    '            command.CommandText = "DELETE FROM tbl_integrate WHERE integ_id = '" & id & "'"
    '            command.ExecuteNonQuery()

    '            'トランザクションのコミット
    '            command.Transaction.Commit()

    '            MsgBox("選択された行を削除しました。")

    '            '処理が成功したため、フラグにセットする
    '            bSuccess = True

    '            '処理が失敗したとき
    '        Catch ex As Exception
    '            'トランザクションのロールバック
    '            command.Transaction.Rollback()

    '            MsgBox("エラーが発生したため、処理を中止します。" & vbCrLf & ex.Message)

    '        End Try

    '    End Using

    '    '成功した時の後処理
    '    If bSuccess Then

    '        'frmGrdを更新する
    '        LoadDatabase()


    '    End If


    'End Sub

    '[2t平]ボタン
    Private Sub btn2tHira_Click(sender As Object, e As EventArgs) Handles btn2tHira.Click
        Dim fs As String
        fs = "tbl_car_enabled.ton like '2t平%' ORDER BY tbl_car_enabled.musen"

        shiboriDatabase(fs)
    End Sub


    '[2tU]ボタン
    Private Sub btn2tU_Click(sender As Object, e As EventArgs) Handles btn2tU.Click
        Dim fs As String
        fs = "tbl_car_enabled.ton = '2tU' ORDER BY tbl_car_enabled.musen"

        shiboriDatabase(fs)
    End Sub

    '[3tu]ボタン
    Private Sub btn3tU_Click(sender As Object, e As EventArgs) Handles btn3tU.Click
        Dim fs As String
        fs = "tbl_car_enabled.ton = '3tU' ORDER BY tbl_car_enabled.musen"

        shiboriDatabase(fs)
    End Sub

    '[4tu]ボタン
    Private Sub btn4tU_Click(sender As Object, e As EventArgs) Handles btn4tU.Click
        Dim fs As String
        fs = "tbl_car_enabled.ton = '4tU' ORDER BY tbl_car_enabled.musen"

        shiboriDatabase(fs)
    End Sub

    '[7tu]ボタン
    Private Sub btn7tU_Click(sender As Object, e As EventArgs) Handles btn7tU.Click
        Dim fs As String
        fs = "tbl_car_enabled.ton = '7tU' ORDER BY tbl_car_enabled.musen"

        shiboriDatabase(fs)
    End Sub

    '[10tU]
    Private Sub btn10tU_Click(sender As Object, e As EventArgs) Handles btn10tU.Click
        Dim fs As String
        fs = "tbl_car_enabled.ton = '10tU' ORDER BY tbl_car_enabled.musen"

        shiboriDatabase(fs)
    End Sub

    '[15tU]ボタン
    Private Sub btn15tU_Click(sender As Object, e As EventArgs) Handles btn15tU.Click
        Dim fs As String
        fs = "tbl_car_enabled.ton = '15tU' ORDER BY tbl_car_enabled.musen"

        shiboriDatabase(fs)
    End Sub

    '[全車両]ボタン 
    Private Sub btnAllCar_Click(sender As Object, e As EventArgs) Handles btnAllCar.Click
        Dim fs As String
        fs = "tbl_car_enabled.carnum1 like '%[0-9]%' ORDER BY tbl_car_enabled.musen"

        shiboriDatabase(fs)
    End Sub

    '緊急車両ボタン
    Private Sub btnEmergency_Click(sender As Object, e As EventArgs) Handles btnEmergency.Click
        Dim fs As String
        fs = "tbl_car_enabled.emergency = 1"
        shiboriDatabase(fs)
    End Sub

    '選択行の車検証エクスポートボタン
    Private Sub btnExportSyaken_Click(sender As Object, e As EventArgs) Handles btnExportSyaken.Click

        'データグリッドビューが空のときは終了する
        If grdMain.Rows.Count = 0 Then Return

        'セルが選択されていなければ戻る
        If grdMain.SelectedCells.Count = 0 Then
            MsgBox("行が選択されていません")
            Return
        End If

        Dim frm As New frmProgressSyakenMenkyo
        frm.Syaken_DownLoad()


    End Sub

    '免許証ファイル出力ボタン
    Private Sub btnExportMenkyo_Click(sender As Object, e As EventArgs) Handles btnExportMenkyo.Click

        'データグリッドビューが空のときは終了する
        If grdMain.Rows.Count = 0 Then Return

        'セルが選択されていなければ戻る
        If grdMain.SelectedCells.Count = 0 Then
            MsgBox("行が選択されていません")
            Return
        End If


        Dim frm As New frmProgressSyakenMenkyo
        frm.Menkyo_Download()

    End Sub



    'アプリの終了時処理
    Private Sub frmGrd_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        'grdMainの列順を記憶する
        My.Settings.grdMain_phonenum_DisplayIndex = grdMain.Columns("phonenum").DisplayIndex
        My.Settings.grdMain_staff_name_DisplayIndex = grdMain.Columns("staff_name").DisplayIndex
        My.Settings.grdMain_carnum1_DisplayIndex = grdMain.Columns("carnum1").DisplayIndex
        My.Settings.grdMain_branch_name_DisplayIndex = grdMain.Columns("branch_name").DisplayIndex
        My.Settings.grdMain_musen_DisplayIndex = grdMain.Columns("musen").DisplayIndex
        My.Settings.grdMain_ton_DisplayIndex = grdMain.Columns("ton").DisplayIndex
        My.Settings.grdMain_car_branch_DisplayIndex = grdMain.Columns("car_branch").DisplayIndex
        My.Settings.grdMain_max_load_DisplayIndex = grdMain.Columns("max_load").DisplayIndex
        My.Settings.grdMain_limit_menkyo_DisplayIndex = grdMain.Columns("limit_menkyo").DisplayIndex
        My.Settings.grdMain_limit_syaken_DisplayIndex = grdMain.Columns("limit_syaken").DisplayIndex
        My.Settings.grdMain_car_length_DisplayIndex = grdMain.Columns("car_length").DisplayIndex
        My.Settings.grdMain_car_width_DisplayIndex = grdMain.Columns("car_width").DisplayIndex
        My.Settings.grdMain_car_height_DisplayIndex = grdMain.Columns("car_height").DisplayIndex
        My.Settings.grdMain_bed_length_DisplayIndex = grdMain.Columns("bed_length").DisplayIndex
        My.Settings.grdMain_bed_width_DisplayIndex = grdMain.Columns("bed_width").DisplayIndex
        My.Settings.grdMain_bed_height_DisplayIndex = grdMain.Columns("bed_height").DisplayIndex
        My.Settings.grdMain_maker_DisplayIndex = grdMain.Columns("maker").DisplayIndex
        My.Settings.grdMain_car_type_DisplayIndex = grdMain.Columns("car_type").DisplayIndex

        'frmMainの位置を記憶する
        My.Settings.frmMain_Top = Me.Top
        My.Settings.frmMain_Left = Me.Left

        'frmMainのウィンドウサイズを記憶する
        My.Settings.frmMain_Width = Me.Width
        My.Settings.frmMain_Height = Me.Height


    End Sub


    'セルの色を変える
    Private Sub grdMain_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grdMain.CellFormatting
        'ヘッダー以外のセル
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Dim dgv As DataGridView = CType(sender, DataGridView)
            '車庫ごとに色分け
            If dgv(0, e.RowIndex).Value.ToString = "三郷" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Khaki

            ElseIf dgv(0, e.RowIndex).Value.ToString = "横浜" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.PaleGreen

            ElseIf dgv(0, e.RowIndex).Value.ToString = "ﾄﾗﾝｽﾎﾟｰﾄｼﾞｬｺ" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Salmon

            ElseIf dgv(0, e.RowIndex).Value.ToString = "石井運送" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.SkyBlue

            ElseIf dgv(0, e.RowIndex).Value.ToString = "船橋" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            Else
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Gray
            End If

            '免許証・車検証の期限が切れていたら赤く塗る
            '車検
            If Not IsDBNull(dgv(8, e.RowIndex).Value) Then
                Dim result_datecompare1 As Integer = DateTime.Compare(dgv(8, e.RowIndex).Value, Today)
                If result_datecompare1 < 0 Then
                    dgv(8, e.RowIndex).Style.BackColor = Color.Red


                End If
            End If
            '免許
            If Not IsDBNull(dgv(9, e.RowIndex).Value) Then
                Dim result_datecompare2 As Integer = DateTime.Compare(dgv(9, e.RowIndex).Value, Today)
                If result_datecompare2 < 0 Then
                    dgv(9, e.RowIndex).Style.BackColor = Color.Red


                End If
            End If
        End If



    End Sub

    'ログインボタン
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frm As New frmPassword
        frm.ShowDialog(Me)
        Call frmGrd_Load()
    End Sub

    Private Sub btnRetire_Click(sender As Object, e As EventArgs) Handles btnRetire.Click
        ' Dim fs As String

        'データグリッドビューのソート（列名をクリックすると△ボタン表示されるやつ）が効いていると、そっちが優先されてしまうので、解除する。
        DtMainBindingSource.Sort = ""

        Dim sql As String
            
        'SQLステートメントの定義
        sql = "Select tbl_PhoneNum.*, tbl_branch_1.*, tbl_staff.*, tbl_car.*, tbl_branch.* " &
              "From tbl_car INNER Join tbl_branch On tbl_car.branch_id = tbl_branch.id_branch FULL OUTER Join " &
              "tbl_staff INNER Join tbl_branch As tbl_branch_1 On tbl_staff.branch_id = tbl_branch_1.id_branch LEFT OUTER Join " &
              "tbl_PhoneNum On tbl_staff.staff_phonenum = tbl_PhoneNum.phonenum " &
              "ON tbl_car.carnum1 = tbl_staff.staff_carnum "

        sql &= " WHERE tbl_car.retire_flag = 1 "

        '所属コンボボックスの条件指定と条件式の作成
        If cmbBranchStaff.SelectedIndex > 0 Then

            sql &= "AND tbl_staff.branch_id = '" & Strings.Left(cmbBranchStaff.Text, cmbBranchStaff.Text.IndexOf(":")) & "'"

        End If

        '車庫コンボボックスの条件指定と条件式の作成
        If cmbBranchCar.SelectedIndex > 0 Then
            'If cmbBranchStaff.SelectedIndex > 0 Then
            '    sql &= "AND "
            'End If
            sql &= "AND tbl_car.branch_id = '" & Strings.Left(cmbBranchCar.Text, cmbBranchCar.Text.IndexOf(":")) & "'"

        End If

        'If cmbBranchCar.SelectedIndex > 0 OrElse cmbBranchStaff.SelectedIndex > 0 Then
        '    sql &= "AND "

        'End If

        'sql &= fs

        'データアダプタにSQLステートメントを設定する
        Dim da As New SqlClient.SqlDataAdapter(sql, My.Settings.PhoneNumDBConnectionString)

        'データテーブルをクリアする
        Me.PhoneNumDBDataSet.dtMain.Clear()
        'Me.PhoneNumDBDataSet.dtMain.OrderBy(PhoneNumDBDataSet.dtMain.musenColumn)
        'データテーブルにデータアダプタを介してデータをセットする
        da.Fill(Me.PhoneNumDBDataSet.dtMain)

        '現在の行数をラベルに表示する
        lblHowManyRecords.Text = Me.grdMain.RowCount & "件のデータが選択されました"
    End Sub

    '備考検索
    Private Sub txtFilterBiko_TextChanged(sender As Object, e As EventArgs) Handles txtFilterBiko.TextChanged
        LoadDatabase()
    End Sub

End Class