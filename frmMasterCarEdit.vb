Imports System.Text.RegularExpressions
Public Class frmMasterCarEdit
    Private Sub frmMasterEditCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。

        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_branch' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_branchTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_branch)
        'TODO: このコード行はデータを 'PhoneNumDBDataSet.tbl_car' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        'Me.Tbl_carTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_car)

        '### 車格コンボボックスに値をセット ###
        cmbTon.Items.Add("2t平")
        cmbTon.Items.Add("2t平PG")
        cmbTon.Items.Add("2tU")
        cmbTon.Items.Add("3tU")
        cmbTon.Items.Add("4tU")
        cmbTon.Items.Add("7tU")
        cmbTon.Items.Add("10tU")
        cmbTon.Items.Add("15tU")
        cmbTon.Items.Add("その他")

        '所属コンボボックスの規定値をレコードに合わせる
        cmbBranch.SelectedValue = lblCarBranch.Text

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

    '車格コンボボックスの値が変更されたら、車格テキストボックスに代入
    Private Sub cmbTon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTon.SelectedIndexChanged
        txtTon.Text = cmbTon.SelectedItem
    End Sub

    Private frm_MasterCar

    Public Sub SetSelectedCar(ByVal carnum As String, ByVal f As frmMasterCar)
        '呼び出し元フォームを格納する
        frm_MasterCar = f

        '電話番号マスタのデータをデータソースにセット
        'Me.Tbl_PhoneNumTableAdapter.Fill(Me.PhoneNumDBDataSet.tbl_PhoneNum)

        '受け取ったコードを利用して、該当する車両番号テーブルのデータをデータソースにセット
        Me.Tbl_carTableAdapter.FillByCcode(Me.PhoneNumDBDataSet.tbl_car, carnum)

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
            Me.TblcarBindingSource.EndEdit()

            'テーブルアダプタを介して、レコードを更新する
            Me.Tbl_carTableAdapter.Update(Me.PhoneNumDBDataSet.tbl_car)



            'フォームを閉じる
            Me.Close()
        End If
    End Sub

    Private Function CheckEditData() As Boolean
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
                MsgBox("ひらがなは全角1文字で入力してください")
                .Select()
                Return False
            End If
        End With

        'データの検査(無線)
        With txtMusen
            If Not .Text = "" Then
                If Not CheckInteger(.Text) Then

                    MsgBox("無線番号は半角数字のみで入力してください")
                    .Select()
                    Return False
                End If
            End If
        End With

        'データの検査(車格)
        With cmbTon
            If Not CheckMaxLengthCar("ton", .SelectedText) Then
                MsgBox("車格は半角4字以内で入力してください")
                .Select()
                Return False
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

        'データの検査(車庫)
        With cmbBranch
            If .SelectedIndex = -1 Then
                MsgBox("車両の所属が選択されていません")
                .Select()
                Return False

            End If
        End With

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

        '廃車フラグをオンにしたら、廃車日も入力しなければならない
        'ファイルが選択されていなければキャンセル
        If cbxRetireFlag.Checked Then

            '日付が入力されていなければキャンセル
            If txtYear.Text = "" Or txtMonth.Text = "" Or txtDay.Text = "" Then
                MsgBox("廃車した日付を入力してください")
                Return False
            End If

            '日付の値チェック
            If Not CheckTxtYear(txtYear.Text) Or Not CheckTxtMonth(txtMonth.Text) Or Not CheckTxtDate(txtDay.Text) Then
                MsgBox("日付を正しく入力してください")
                Return False
            End If

            '廃車フラグがオンになっており、日付の入力も正しかった
            '日付入力を1行にまとめる
            Dim HaisyaDate As Date
            HaisyaDate = mdlMain.Wareki_to_AD("平成" & txtYear.Text & "年" & txtMonth.Text & "月" & txtDay.Text & "日")
            lblRetireDate.Text = HaisyaDate.ToString
        Else
            '廃車フラグがオンになっていないのに廃車日が入力されていたら
            If Not txtYear.Text = "" Or Not txtMonth.Text = "" Or Not txtDay.Text = "" Then
                MsgBox("廃車チェックボックスがチェックされていません")
                Return False
            End If

        End If
        '全ての検査を通過した
        Return True

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

    'musen用integerチェック
    Private Function CheckInteger(ByVal value As String)


        If Not Regex.IsMatch(value, "^[0-9]{1,5}$") Then
            Return False

        Else
            Return True
        End If

    End Function

    'キーボードショートカット
    Private Sub frmMasterEditCar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub
End Class