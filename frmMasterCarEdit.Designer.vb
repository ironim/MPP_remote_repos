<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterCarEdit
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCarBranch = New System.Windows.Forms.Label()
        Me.TblcarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.txtTon = New System.Windows.Forms.TextBox()
        Me.cmbTon = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
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
        Me.BikoLabel = New System.Windows.Forms.Label()
        Me.txtBiko = New System.Windows.Forms.TextBox()
        Me.Branch_idLabel = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.TblbranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_branchTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter()
        Me.Tbl_carTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaxLoad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxEmergency = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbCarType = New System.Windows.Forms.ComboBox()
        Me.cmbMaker = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbxRetireFlag = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblRetireDate = New System.Windows.Forms.Label()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 12)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "id:"
        '
        'lblCarBranch
        '
        Me.lblCarBranch.AutoSize = True
        Me.lblCarBranch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "branch_id", True))
        Me.lblCarBranch.Location = New System.Drawing.Point(205, 181)
        Me.lblCarBranch.Name = "lblCarBranch"
        Me.lblCarBranch.Size = New System.Drawing.Size(71, 12)
        Me.lblCarBranch.TabIndex = 90
        Me.lblCarBranch.Text = "lblCarBranch"
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
        'txtTon
        '
        Me.txtTon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "ton", True))
        Me.txtTon.Enabled = False
        Me.txtTon.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtTon.Location = New System.Drawing.Point(84, 153)
        Me.txtTon.Name = "txtTon"
        Me.txtTon.Size = New System.Drawing.Size(81, 19)
        Me.txtTon.TabIndex = 6
        '
        'cmbTon
        '
        Me.cmbTon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTon.DropDownWidth = 100
        Me.cmbTon.FormattingEnabled = True
        Me.cmbTon.Location = New System.Drawing.Point(165, 152)
        Me.cmbTon.Name = "cmbTon"
        Me.cmbTon.Size = New System.Drawing.Size(20, 20)
        Me.cmbTon.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 12)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "(き)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 12)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "(100)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "(足立)"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(497, 478)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(55, 23)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(434, 478)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(57, 23)
        Me.btnOK.TabIndex = 25
        Me.btnOK.Text = "登録"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Carnum1Label
        '
        Me.Carnum1Label.AutoSize = True
        Me.Carnum1Label.Location = New System.Drawing.Point(24, 31)
        Me.Carnum1Label.Name = "Carnum1Label"
        Me.Carnum1Label.Size = New System.Drawing.Size(53, 12)
        Me.Carnum1Label.TabIndex = 79
        Me.Carnum1Label.Text = "車両番号"
        '
        'txtCarnum1
        '
        Me.txtCarnum1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum1", True))
        Me.txtCarnum1.Enabled = False
        Me.txtCarnum1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtCarnum1.Location = New System.Drawing.Point(84, 28)
        Me.txtCarnum1.Name = "txtCarnum1"
        Me.txtCarnum1.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum1.TabIndex = 1
        '
        'Carnum2Label
        '
        Me.Carnum2Label.AutoSize = True
        Me.Carnum2Label.Location = New System.Drawing.Point(38, 56)
        Me.Carnum2Label.Name = "Carnum2Label"
        Me.Carnum2Label.Size = New System.Drawing.Size(29, 12)
        Me.Carnum2Label.TabIndex = 80
        Me.Carnum2Label.Text = "地名"
        '
        'txtCarnum2
        '
        Me.txtCarnum2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum2", True))
        Me.txtCarnum2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtCarnum2.Location = New System.Drawing.Point(84, 53)
        Me.txtCarnum2.Name = "txtCarnum2"
        Me.txtCarnum2.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum2.TabIndex = 2
        '
        'Carnum3Label
        '
        Me.Carnum3Label.AutoSize = True
        Me.Carnum3Label.Location = New System.Drawing.Point(24, 81)
        Me.Carnum3Label.Name = "Carnum3Label"
        Me.Carnum3Label.Size = New System.Drawing.Size(53, 12)
        Me.Carnum3Label.TabIndex = 81
        Me.Carnum3Label.Text = "分類番号"
        '
        'txtCarnum3
        '
        Me.txtCarnum3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum3", True))
        Me.txtCarnum3.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtCarnum3.Location = New System.Drawing.Point(84, 78)
        Me.txtCarnum3.Name = "txtCarnum3"
        Me.txtCarnum3.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum3.TabIndex = 3
        '
        'Carnum4Label
        '
        Me.Carnum4Label.AutoSize = True
        Me.Carnum4Label.Location = New System.Drawing.Point(24, 106)
        Me.Carnum4Label.Name = "Carnum4Label"
        Me.Carnum4Label.Size = New System.Drawing.Size(43, 12)
        Me.Carnum4Label.TabIndex = 82
        Me.Carnum4Label.Text = "ひらがな"
        '
        'txtCarnum4
        '
        Me.txtCarnum4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "carnum4", True))
        Me.txtCarnum4.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtCarnum4.Location = New System.Drawing.Point(84, 103)
        Me.txtCarnum4.Name = "txtCarnum4"
        Me.txtCarnum4.Size = New System.Drawing.Size(64, 19)
        Me.txtCarnum4.TabIndex = 4
        '
        'MusenLabel
        '
        Me.MusenLabel.AutoSize = True
        Me.MusenLabel.Location = New System.Drawing.Point(24, 131)
        Me.MusenLabel.Name = "MusenLabel"
        Me.MusenLabel.Size = New System.Drawing.Size(53, 12)
        Me.MusenLabel.TabIndex = 83
        Me.MusenLabel.Text = "無線番号"
        '
        'txtMusen
        '
        Me.txtMusen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "musen", True))
        Me.txtMusen.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMusen.Location = New System.Drawing.Point(84, 128)
        Me.txtMusen.Name = "txtMusen"
        Me.txtMusen.Size = New System.Drawing.Size(64, 19)
        Me.txtMusen.TabIndex = 5
        '
        'TonLabel
        '
        Me.TonLabel.AutoSize = True
        Me.TonLabel.Location = New System.Drawing.Point(38, 156)
        Me.TonLabel.Name = "TonLabel"
        Me.TonLabel.Size = New System.Drawing.Size(29, 12)
        Me.TonLabel.TabIndex = 84
        Me.TonLabel.Text = "車格"
        '
        'BikoLabel
        '
        Me.BikoLabel.AutoSize = True
        Me.BikoLabel.Location = New System.Drawing.Point(38, 326)
        Me.BikoLabel.Name = "BikoLabel"
        Me.BikoLabel.Size = New System.Drawing.Size(29, 12)
        Me.BikoLabel.TabIndex = 85
        Me.BikoLabel.Text = "備考"
        '
        'txtBiko
        '
        Me.txtBiko.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "biko", True))
        Me.txtBiko.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtBiko.Location = New System.Drawing.Point(84, 323)
        Me.txtBiko.Multiline = True
        Me.txtBiko.Name = "txtBiko"
        Me.txtBiko.Size = New System.Drawing.Size(468, 149)
        Me.txtBiko.TabIndex = 24
        '
        'Branch_idLabel
        '
        Me.Branch_idLabel.AutoSize = True
        Me.Branch_idLabel.Location = New System.Drawing.Point(38, 181)
        Me.Branch_idLabel.Name = "Branch_idLabel"
        Me.Branch_idLabel.Size = New System.Drawing.Size(29, 12)
        Me.Branch_idLabel.TabIndex = 86
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
        Me.cmbBranch.Location = New System.Drawing.Point(84, 178)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(101, 20)
        Me.cmbBranch.TabIndex = 8
        Me.cmbBranch.ValueMember = "id_branch"
        '
        'TblbranchBindingSource
        '
        Me.TblbranchBindingSource.DataMember = "tbl_branch"
        Me.TblbranchBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'Tbl_branchTableAdapter
        '
        Me.Tbl_branchTableAdapter.ClearBeforeFill = True
        '
        'Tbl_carTableAdapter
        '
        Me.Tbl_carTableAdapter.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(193, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 12)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "kg"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "最大積載量"
        '
        'txtMaxLoad
        '
        Me.txtMaxLoad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "max_load", True))
        Me.txtMaxLoad.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMaxLoad.Location = New System.Drawing.Point(86, 94)
        Me.txtMaxLoad.Name = "txtMaxLoad"
        Me.txtMaxLoad.Size = New System.Drawing.Size(100, 19)
        Me.txtMaxLoad.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 12)
        Me.Label6.TabIndex = 98
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtBed_height)
        Me.GroupBox1.Controls.Add(Me.txtBed_width)
        Me.GroupBox1.Controls.Add(Me.txtBed_length)
        Me.GroupBox1.Controls.Add(Me.txtCar_height)
        Me.GroupBox1.Controls.Add(Me.txtCar_width)
        Me.GroupBox1.Controls.Add(Me.txtCar_length)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMaxLoad)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(291, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 200)
        Me.GroupBox1.TabIndex = 99
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
        Me.txtBed_height.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "bed_height", True))
        Me.txtBed_height.Location = New System.Drawing.Point(86, 169)
        Me.txtBed_height.Name = "txtBed_height"
        Me.txtBed_height.Size = New System.Drawing.Size(100, 19)
        Me.txtBed_height.TabIndex = 16
        '
        'txtBed_width
        '
        Me.txtBed_width.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "bed_width", True))
        Me.txtBed_width.Location = New System.Drawing.Point(86, 144)
        Me.txtBed_width.Name = "txtBed_width"
        Me.txtBed_width.Size = New System.Drawing.Size(100, 19)
        Me.txtBed_width.TabIndex = 15
        '
        'txtBed_length
        '
        Me.txtBed_length.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "bed_length", True))
        Me.txtBed_length.Location = New System.Drawing.Point(86, 119)
        Me.txtBed_length.Name = "txtBed_length"
        Me.txtBed_length.Size = New System.Drawing.Size(100, 19)
        Me.txtBed_length.TabIndex = 14
        '
        'txtCar_height
        '
        Me.txtCar_height.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "car_height", True))
        Me.txtCar_height.Location = New System.Drawing.Point(86, 69)
        Me.txtCar_height.Name = "txtCar_height"
        Me.txtCar_height.Size = New System.Drawing.Size(100, 19)
        Me.txtCar_height.TabIndex = 12
        '
        'txtCar_width
        '
        Me.txtCar_width.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "car_width", True))
        Me.txtCar_width.Location = New System.Drawing.Point(86, 44)
        Me.txtCar_width.Name = "txtCar_width"
        Me.txtCar_width.Size = New System.Drawing.Size(100, 19)
        Me.txtCar_width.TabIndex = 11
        '
        'txtCar_length
        '
        Me.txtCar_length.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "car_length", True))
        Me.txtCar_length.Location = New System.Drawing.Point(86, 19)
        Me.txtCar_length.Name = "txtCar_length"
        Me.txtCar_length.Size = New System.Drawing.Size(100, 19)
        Me.txtCar_length.TabIndex = 10
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 12)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "幅"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 12)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "長さ"
        '
        'cbxEmergency
        '
        Me.cbxEmergency.AutoSize = True
        Me.cbxEmergency.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblcarBindingSource, "emergency", True))
        Me.cbxEmergency.Location = New System.Drawing.Point(84, 257)
        Me.cbxEmergency.Name = "cbxEmergency"
        Me.cbxEmergency.Size = New System.Drawing.Size(15, 14)
        Me.cbxEmergency.TabIndex = 19
        Me.cbxEmergency.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(25, 257)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 12)
        Me.Label20.TabIndex = 101
        Me.Label20.Text = "緊急車両"
        '
        'cmbCarType
        '
        Me.cmbCarType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "car_type", True))
        Me.cmbCarType.FormattingEnabled = True
        Me.cmbCarType.Location = New System.Drawing.Point(84, 228)
        Me.cmbCarType.Name = "cmbCarType"
        Me.cmbCarType.Size = New System.Drawing.Size(92, 20)
        Me.cmbCarType.TabIndex = 18
        '
        'cmbMaker
        '
        Me.cmbMaker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "maker", True))
        Me.cmbMaker.FormattingEnabled = True
        Me.cmbMaker.ItemHeight = 12
        Me.cmbMaker.Location = New System.Drawing.Point(84, 204)
        Me.cmbMaker.Name = "cmbMaker"
        Me.cmbMaker.Size = New System.Drawing.Size(92, 20)
        Me.cmbMaker.TabIndex = 17
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(38, 231)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(29, 12)
        Me.Label28.TabIndex = 116
        Me.Label28.Text = "車種"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(33, 207)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(42, 12)
        Me.Label27.TabIndex = 115
        Me.Label27.Text = "メーカー"
        '
        'cbxRetireFlag
        '
        Me.cbxRetireFlag.AutoSize = True
        Me.cbxRetireFlag.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.TblcarBindingSource, "retire_flag", True))
        Me.cbxRetireFlag.Location = New System.Drawing.Point(84, 278)
        Me.cbxRetireFlag.Name = "cbxRetireFlag"
        Me.cbxRetireFlag.Size = New System.Drawing.Size(15, 14)
        Me.cbxRetireFlag.TabIndex = 20
        Me.cbxRetireFlag.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(37, 278)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 12)
        Me.Label21.TabIndex = 120
        Me.Label21.Text = "廃車"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(24, 301)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 12)
        Me.Label22.TabIndex = 122
        Me.Label22.Text = "廃車日付"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(257, 301)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(17, 12)
        Me.Label23.TabIndex = 129
        Me.Label23.Text = "日"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(203, 301)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(17, 12)
        Me.Label24.TabIndex = 128
        Me.Label24.Text = "月"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(149, 301)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(17, 12)
        Me.Label25.TabIndex = 127
        Me.Label25.Text = "年"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(83, 301)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(29, 12)
        Me.Label26.TabIndex = 126
        Me.Label26.Text = "平成"
        '
        'txtDay
        '
        Me.txtDay.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtDay.Location = New System.Drawing.Point(221, 298)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(34, 19)
        Me.txtDay.TabIndex = 23
        '
        'txtMonth
        '
        Me.txtMonth.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMonth.Location = New System.Drawing.Point(168, 298)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(33, 19)
        Me.txtMonth.TabIndex = 22
        '
        'txtYear
        '
        Me.txtYear.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtYear.Location = New System.Drawing.Point(114, 298)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(33, 19)
        Me.txtYear.TabIndex = 21
        '
        'lblRetireDate
        '
        Me.lblRetireDate.AutoSize = True
        Me.lblRetireDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblcarBindingSource, "retire_date", True))
        Me.lblRetireDate.ForeColor = System.Drawing.Color.LightBlue
        Me.lblRetireDate.Location = New System.Drawing.Point(280, 301)
        Me.lblRetireDate.Name = "lblRetireDate"
        Me.lblRetireDate.Size = New System.Drawing.Size(72, 12)
        Me.lblRetireDate.TabIndex = 130
        Me.lblRetireDate.Text = "lblRetireDate"
        '
        'frmMasterCarEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(569, 506)
        Me.Controls.Add(Me.lblRetireDate)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cbxRetireFlag)
        Me.Controls.Add(Me.cmbCarType)
        Me.Controls.Add(Me.cmbMaker)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cbxEmergency)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCarBranch)
        Me.Controls.Add(Me.txtTon)
        Me.Controls.Add(Me.cmbTon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
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
        Me.Controls.Add(Me.BikoLabel)
        Me.Controls.Add(Me.txtBiko)
        Me.Controls.Add(Me.Branch_idLabel)
        Me.Controls.Add(Me.cmbBranch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMasterCarEdit"
        Me.Text = "車両マスタ編集"
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents lblCarBranch As Label
    Friend WithEvents txtTon As TextBox
    Friend WithEvents cmbTon As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnOK As Button
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
    Friend WithEvents BikoLabel As Label
    Friend WithEvents txtBiko As TextBox
    Friend WithEvents Branch_idLabel As Label
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents TblbranchBindingSource As BindingSource
    Friend WithEvents Tbl_branchTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_branchTableAdapter
    Friend WithEvents TblcarBindingSource As BindingSource
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaxLoad As TextBox
    Friend WithEvents Label6 As Label
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
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxEmergency As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cmbCarType As ComboBox
    Friend WithEvents cmbMaker As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents cbxRetireFlag As CheckBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtDay As TextBox
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents lblRetireDate As Label
End Class
