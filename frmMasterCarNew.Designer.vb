<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterCarNew
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmbTon = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Carnum1Label = New System.Windows.Forms.Label()
        Me.txtCarnum1 = New System.Windows.Forms.TextBox()
        Me.Carnum2Label = New System.Windows.Forms.Label()
        Me.txtCarnum2 = New System.Windows.Forms.TextBox()
        Me.Carnum3Label = New System.Windows.Forms.Label()
        Me.txtCarnum3 = New System.Windows.Forms.TextBox()
        Me.Carnum4Label = New System.Windows.Forms.Label()
        Me.txtCarnum4 = New System.Windows.Forms.TextBox()
        Me.MusenLabel = New System.Windows.Forms.Label()
        Me.txtMusen = New System.Windows.Forms.TextBox()
        Me.TonLabel = New System.Windows.Forms.Label()
        Me.txtBiko = New System.Windows.Forms.TextBox()
        Me.Branch_idLabel = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.TblcarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.TblbranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_branchTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter()
        Me.Tbl_carTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        Me.txtMaxLoad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnFileSelect = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBed_height = New System.Windows.Forms.TextBox()
        Me.txtBed_width = New System.Windows.Forms.TextBox()
        Me.txtBed_length = New System.Windows.Forms.TextBox()
        Me.txtCar_height = New System.Windows.Forms.TextBox()
        Me.txtCar_width = New System.Windows.Forms.TextBox()
        Me.txtCar_length = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbxEmergency = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cmbMaker = New System.Windows.Forms.ComboBox()
        Me.cmbCarType = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cbxRetireFlag = New System.Windows.Forms.CheckBox()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbTon
        '
        Me.cmbTon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTon.FormattingEnabled = True
        Me.cmbTon.Location = New System.Drawing.Point(85, 141)
        Me.cmbTon.Name = "cmbTon"
        Me.cmbTon.Size = New System.Drawing.Size(92, 20)
        Me.cmbTon.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 12)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "(半角数字4桁)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 12)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "(き)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(155, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 12)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "(100)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "(足立)"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(510, 440)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(55, 23)
        Me.btnCancel.TabIndex = 101
        Me.btnCancel.Text = "閉じる"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(447, 440)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(57, 23)
        Me.btnRegister.TabIndex = 100
        Me.btnRegister.Text = "登録"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Carnum1Label
        '
        Me.Carnum1Label.AutoSize = True
        Me.Carnum1Label.Location = New System.Drawing.Point(25, 19)
        Me.Carnum1Label.Name = "Carnum1Label"
        Me.Carnum1Label.Size = New System.Drawing.Size(53, 12)
        Me.Carnum1Label.TabIndex = 54
        Me.Carnum1Label.Text = "車両番号"
        '
        'txtCarnum1
        '
        Me.txtCarnum1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtCarnum1.Location = New System.Drawing.Point(85, 16)
        Me.txtCarnum1.Name = "txtCarnum1"
        Me.txtCarnum1.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum1.TabIndex = 1
        '
        'Carnum2Label
        '
        Me.Carnum2Label.AutoSize = True
        Me.Carnum2Label.Location = New System.Drawing.Point(39, 44)
        Me.Carnum2Label.Name = "Carnum2Label"
        Me.Carnum2Label.Size = New System.Drawing.Size(29, 12)
        Me.Carnum2Label.TabIndex = 55
        Me.Carnum2Label.Text = "地名"
        '
        'txtCarnum2
        '
        Me.txtCarnum2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtCarnum2.Location = New System.Drawing.Point(85, 41)
        Me.txtCarnum2.Name = "txtCarnum2"
        Me.txtCarnum2.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum2.TabIndex = 2
        '
        'Carnum3Label
        '
        Me.Carnum3Label.AutoSize = True
        Me.Carnum3Label.Location = New System.Drawing.Point(25, 69)
        Me.Carnum3Label.Name = "Carnum3Label"
        Me.Carnum3Label.Size = New System.Drawing.Size(53, 12)
        Me.Carnum3Label.TabIndex = 56
        Me.Carnum3Label.Text = "分類番号"
        '
        'txtCarnum3
        '
        Me.txtCarnum3.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtCarnum3.Location = New System.Drawing.Point(85, 66)
        Me.txtCarnum3.Name = "txtCarnum3"
        Me.txtCarnum3.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum3.TabIndex = 3
        '
        'Carnum4Label
        '
        Me.Carnum4Label.AutoSize = True
        Me.Carnum4Label.Location = New System.Drawing.Point(25, 94)
        Me.Carnum4Label.Name = "Carnum4Label"
        Me.Carnum4Label.Size = New System.Drawing.Size(43, 12)
        Me.Carnum4Label.TabIndex = 57
        Me.Carnum4Label.Text = "ひらがな"
        '
        'txtCarnum4
        '
        Me.txtCarnum4.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtCarnum4.Location = New System.Drawing.Point(85, 91)
        Me.txtCarnum4.Name = "txtCarnum4"
        Me.txtCarnum4.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum4.TabIndex = 4
        '
        'MusenLabel
        '
        Me.MusenLabel.AutoSize = True
        Me.MusenLabel.Location = New System.Drawing.Point(25, 119)
        Me.MusenLabel.Name = "MusenLabel"
        Me.MusenLabel.Size = New System.Drawing.Size(53, 12)
        Me.MusenLabel.TabIndex = 58
        Me.MusenLabel.Text = "無線番号"
        '
        'txtMusen
        '
        Me.txtMusen.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMusen.Location = New System.Drawing.Point(85, 116)
        Me.txtMusen.Name = "txtMusen"
        Me.txtMusen.Size = New System.Drawing.Size(64, 19)
        Me.txtMusen.TabIndex = 5
        '
        'TonLabel
        '
        Me.TonLabel.AutoSize = True
        Me.TonLabel.Location = New System.Drawing.Point(39, 144)
        Me.TonLabel.Name = "TonLabel"
        Me.TonLabel.Size = New System.Drawing.Size(29, 12)
        Me.TonLabel.TabIndex = 59
        Me.TonLabel.Text = "車格"
        '
        'txtBiko
        '
        Me.txtBiko.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtBiko.Location = New System.Drawing.Point(84, 344)
        Me.txtBiko.Multiline = True
        Me.txtBiko.Name = "txtBiko"
        Me.txtBiko.Size = New System.Drawing.Size(481, 90)
        Me.txtBiko.TabIndex = 21
        '
        'Branch_idLabel
        '
        Me.Branch_idLabel.AutoSize = True
        Me.Branch_idLabel.Location = New System.Drawing.Point(39, 169)
        Me.Branch_idLabel.Name = "Branch_idLabel"
        Me.Branch_idLabel.Size = New System.Drawing.Size(29, 12)
        Me.Branch_idLabel.TabIndex = 61
        Me.Branch_idLabel.Text = "所属"
        '
        'cmbBranch
        '
        Me.cmbBranch.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblcarBindingSource, "branch_id", True))
        Me.cmbBranch.DataSource = Me.TblbranchBindingSource
        Me.cmbBranch.DisplayMember = "branch_name"
        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.ItemHeight = 12
        Me.cmbBranch.Location = New System.Drawing.Point(85, 166)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(92, 20)
        Me.cmbBranch.TabIndex = 7
        Me.cmbBranch.ValueMember = "id_branch"
        '
        'TblcarBindingSource
        '
        Me.TblcarBindingSource.DataMember = "tbl_car"
        Me.TblcarBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'PhoneNumDBDataSet
        '
        Me.PhoneNumDBDataSet.DataSetName = "PhoneNumDBDataSet"
        Me.PhoneNumDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblbranchBindingSource
        '
        Me.TblbranchBindingSource.DataMember = "tbl_branch"
        Me.TblbranchBindingSource.DataSource = Me.PhoneNumDBDataSetBindingSource
        '
        'PhoneNumDBDataSetBindingSource
        '
        Me.PhoneNumDBDataSetBindingSource.DataSource = Me.PhoneNumDBDataSet
        Me.PhoneNumDBDataSetBindingSource.Position = 0
        '
        'Tbl_branchTableAdapter
        '
        Me.Tbl_branchTableAdapter.ClearBeforeFill = True
        '
        'Tbl_carTableAdapter
        '
        Me.Tbl_carTableAdapter.ClearBeforeFill = True
        '
        'txtMaxLoad
        '
        Me.txtMaxLoad.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMaxLoad.Location = New System.Drawing.Point(87, 94)
        Me.txtMaxLoad.Name = "txtMaxLoad"
        Me.txtMaxLoad.Size = New System.Drawing.Size(100, 19)
        Me.txtMaxLoad.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "最大積載量"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "車検証期限"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "備考"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(193, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 12)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "kg"
        '
        'btnFileSelect
        '
        Me.btnFileSelect.Location = New System.Drawing.Point(215, 269)
        Me.btnFileSelect.Name = "btnFileSelect"
        Me.btnFileSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnFileSelect.TabIndex = 12
        Me.btnFileSelect.Text = "ファイル選択"
        Me.btnFileSelect.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 12)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "車検証ファイル"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(85, 271)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(124, 19)
        Me.txtFilePath.TabIndex = 75
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtBed_height)
        Me.GroupBox1.Controls.Add(Me.txtBed_width)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMaxLoad)
        Me.GroupBox1.Controls.Add(Me.txtBed_length)
        Me.GroupBox1.Controls.Add(Me.txtCar_height)
        Me.GroupBox1.Controls.Add(Me.txtCar_width)
        Me.GroupBox1.Controls.Add(Me.txtCar_length)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Location = New System.Drawing.Point(304, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 200)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "車両寸法"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(192, 172)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 12)
        Me.Label19.TabIndex = 115
        Me.Label19.Text = "cm"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(192, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 12)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "cm"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(192, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 12)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "cm"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(192, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 12)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "cm"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(192, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 12)
        Me.Label15.TabIndex = 111
        Me.Label15.Text = "cm"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(192, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 12)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "cm"
        '
        'txtBed_height
        '
        Me.txtBed_height.Location = New System.Drawing.Point(86, 169)
        Me.txtBed_height.Name = "txtBed_height"
        Me.txtBed_height.Size = New System.Drawing.Size(100, 19)
        Me.txtBed_height.TabIndex = 20
        '
        'txtBed_width
        '
        Me.txtBed_width.Location = New System.Drawing.Point(86, 144)
        Me.txtBed_width.Name = "txtBed_width"
        Me.txtBed_width.Size = New System.Drawing.Size(100, 19)
        Me.txtBed_width.TabIndex = 19
        '
        'txtBed_length
        '
        Me.txtBed_length.Location = New System.Drawing.Point(86, 119)
        Me.txtBed_length.Name = "txtBed_length"
        Me.txtBed_length.Size = New System.Drawing.Size(100, 19)
        Me.txtBed_length.TabIndex = 18
        '
        'txtCar_height
        '
        Me.txtCar_height.Location = New System.Drawing.Point(86, 69)
        Me.txtCar_height.Name = "txtCar_height"
        Me.txtCar_height.Size = New System.Drawing.Size(100, 19)
        Me.txtCar_height.TabIndex = 16
        '
        'txtCar_width
        '
        Me.txtCar_width.Location = New System.Drawing.Point(86, 44)
        Me.txtCar_width.Name = "txtCar_width"
        Me.txtCar_width.Size = New System.Drawing.Size(100, 19)
        Me.txtCar_width.TabIndex = 15
        '
        'txtCar_length
        '
        Me.txtCar_length.Location = New System.Drawing.Point(86, 19)
        Me.txtCar_length.Name = "txtCar_length"
        Me.txtCar_length.Size = New System.Drawing.Size(100, 19)
        Me.txtCar_length.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 12)
        Me.Label13.TabIndex = 103
        Me.Label13.Text = "荷台高"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 12)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "荷台幅"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 12)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "荷台長"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 12)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "高さ"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(27, 47)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(17, 12)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "幅"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(23, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 12)
        Me.Label21.TabIndex = 98
        Me.Label21.Text = "長さ"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(25, 299)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 12)
        Me.Label22.TabIndex = 103
        Me.Label22.Text = "緊急車両"
        '
        'cbxEmergency
        '
        Me.cbxEmergency.AutoSize = True
        Me.cbxEmergency.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblcarBindingSource, "emergency", True))
        Me.cbxEmergency.Location = New System.Drawing.Point(84, 299)
        Me.cbxEmergency.Name = "cbxEmergency"
        Me.cbxEmergency.Size = New System.Drawing.Size(15, 14)
        Me.cbxEmergency.TabIndex = 13
        Me.cbxEmergency.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(263, 247)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(17, 12)
        Me.Label23.TabIndex = 110
        Me.Label23.Text = "日"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(209, 247)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(17, 12)
        Me.Label24.TabIndex = 109
        Me.Label24.Text = "月"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(155, 247)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(17, 12)
        Me.Label25.TabIndex = 108
        Me.Label25.Text = "年"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(89, 247)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(29, 12)
        Me.Label26.TabIndex = 107
        Me.Label26.Text = "平成"
        '
        'txtDay
        '
        Me.txtDay.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtDay.Location = New System.Drawing.Point(227, 244)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(34, 19)
        Me.txtDay.TabIndex = 11
        '
        'txtMonth
        '
        Me.txtMonth.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMonth.Location = New System.Drawing.Point(174, 244)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(33, 19)
        Me.txtMonth.TabIndex = 10
        '
        'txtYear
        '
        Me.txtYear.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtYear.Location = New System.Drawing.Point(120, 244)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(33, 19)
        Me.txtYear.TabIndex = 9
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(34, 193)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(42, 12)
        Me.Label27.TabIndex = 111
        Me.Label27.Text = "メーカー"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(39, 217)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(29, 12)
        Me.Label28.TabIndex = 112
        Me.Label28.Text = "車種"
        '
        'cmbMaker
        '
        Me.cmbMaker.FormattingEnabled = True
        Me.cmbMaker.Location = New System.Drawing.Point(85, 190)
        Me.cmbMaker.Name = "cmbMaker"
        Me.cmbMaker.Size = New System.Drawing.Size(92, 20)
        Me.cmbMaker.TabIndex = 113
        '
        'cmbCarType
        '
        Me.cmbCarType.FormattingEnabled = True
        Me.cmbCarType.Location = New System.Drawing.Point(85, 214)
        Me.cmbCarType.Name = "cmbCarType"
        Me.cmbCarType.Size = New System.Drawing.Size(92, 20)
        Me.cmbCarType.TabIndex = 114
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(37, 321)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(29, 12)
        Me.Label29.TabIndex = 122
        Me.Label29.Text = "廃車"
        '
        'cbxRetireFlag
        '
        Me.cbxRetireFlag.AutoSize = True
        Me.cbxRetireFlag.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblcarBindingSource, "retire_flag", True))
        Me.cbxRetireFlag.Enabled = False
        Me.cbxRetireFlag.Location = New System.Drawing.Point(84, 320)
        Me.cbxRetireFlag.Name = "cbxRetireFlag"
        Me.cbxRetireFlag.Size = New System.Drawing.Size(15, 14)
        Me.cbxRetireFlag.TabIndex = 121
        Me.cbxRetireFlag.UseVisualStyleBackColor = True
        '
        'frmMasterCarNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(577, 466)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.cbxRetireFlag)
        Me.Controls.Add(Me.cmbCarType)
        Me.Controls.Add(Me.cmbMaker)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cbxEmergency)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnFileSelect)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbTon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Carnum1Label)
        Me.Controls.Add(Me.txtCarnum1)
        Me.Controls.Add(Me.Carnum2Label)
        Me.Controls.Add(Me.txtCarnum2)
        Me.Controls.Add(Me.Carnum3Label)
        Me.Controls.Add(Me.txtCarnum3)
        Me.Controls.Add(Me.Carnum4Label)
        Me.Controls.Add(Me.txtCarnum4)
        Me.Controls.Add(Me.MusenLabel)
        Me.Controls.Add(Me.txtMusen)
        Me.Controls.Add(Me.TonLabel)
        Me.Controls.Add(Me.txtBiko)
        Me.Controls.Add(Me.Branch_idLabel)
        Me.Controls.Add(Me.cmbBranch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMasterCarNew"
        Me.Text = "車両マスタ新規"
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTon As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Carnum1Label As Label
    Friend WithEvents txtCarnum1 As TextBox
    Friend WithEvents Carnum2Label As Label
    Friend WithEvents txtCarnum2 As TextBox
    Friend WithEvents Carnum3Label As Label
    Friend WithEvents txtCarnum3 As TextBox
    Friend WithEvents Carnum4Label As Label
    Friend WithEvents txtCarnum4 As TextBox
    Friend WithEvents MusenLabel As Label
    Friend WithEvents txtMusen As TextBox
    Friend WithEvents TonLabel As Label
    Friend WithEvents txtBiko As TextBox
    Friend WithEvents Branch_idLabel As Label
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents PhoneNumDBDataSetBindingSource As BindingSource
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents TblbranchBindingSource As BindingSource
    Friend WithEvents Tbl_branchTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter
    Friend WithEvents TblcarBindingSource As BindingSource
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
    Friend WithEvents txtMaxLoad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnFileSelect As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBed_height As TextBox
    Friend WithEvents txtBed_width As TextBox
    Friend WithEvents txtBed_length As TextBox
    Friend WithEvents txtCar_height As TextBox
    Friend WithEvents txtCar_width As TextBox
    Friend WithEvents txtCar_length As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cbxEmergency As CheckBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtDay As TextBox
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents cmbMaker As ComboBox
    Friend WithEvents cmbCarType As ComboBox
    Friend WithEvents Label29 As Label
    Friend WithEvents cbxRetireFlag As CheckBox
End Class
