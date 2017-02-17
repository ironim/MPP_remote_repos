<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGrd
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GroupBox3 As System.Windows.Forms.GroupBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrd))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnExportCrane = New System.Windows.Forms.Button()
        Me.btnExportJibai = New System.Windows.Forms.Button()
        Me.btnExportMenkyo = New System.Windows.Forms.Button()
        Me.btnExportSyaken = New System.Windows.Forms.Button()
        Me.DtMainBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DtMainBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.grdMain = New System.Windows.Forms.DataGridView()
        Me.max_load = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.limit_syaken = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.limit_menkyo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.car_length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.car_width = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.car_height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bed_length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bed_width = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bed_height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_staff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staff_kana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maker = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.car_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biko = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biko1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biko2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFilterBiko = New System.Windows.Forms.TextBox()
        Me.btnRetire = New System.Windows.Forms.Button()
        Me.btnEmergency = New System.Windows.Forms.Button()
        Me.btnFilterClear = New System.Windows.Forms.Button()
        Me.btn15tU = New System.Windows.Forms.Button()
        Me.btn10tU = New System.Windows.Forms.Button()
        Me.btn7tU = New System.Windows.Forms.Button()
        Me.btn4tU = New System.Windows.Forms.Button()
        Me.btn3tU = New System.Windows.Forms.Button()
        Me.btn2tU = New System.Windows.Forms.Button()
        Me.btn2tHira = New System.Windows.Forms.Button()
        Me.btnAllCar = New System.Windows.Forms.Button()
        Me.btn8000 = New System.Windows.Forms.Button()
        Me.btn7000 = New System.Windows.Forms.Button()
        Me.btn6000 = New System.Windows.Forms.Button()
        Me.btn5000 = New System.Windows.Forms.Button()
        Me.btn4000 = New System.Windows.Forms.Button()
        Me.btn3000 = New System.Windows.Forms.Button()
        Me.btn2000 = New System.Windows.Forms.Button()
        Me.btn1000 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn9000 = New System.Windows.Forms.Button()
        Me.btnWa = New System.Windows.Forms.Button()
        Me.btnRa = New System.Windows.Forms.Button()
        Me.btnYa = New System.Windows.Forms.Button()
        Me.btnMa = New System.Windows.Forms.Button()
        Me.btnHa = New System.Windows.Forms.Button()
        Me.btnNa = New System.Windows.Forms.Button()
        Me.btnTa = New System.Windows.Forms.Button()
        Me.btnSa = New System.Windows.Forms.Button()
        Me.btnKa = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBranchCar = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbBranchStaff = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFilterKana = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilterPhonenum = New System.Windows.Forms.TextBox()
        Me.lblHowManyRecords = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.car_branch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.musen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carnum1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ton = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staff_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phonenum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtMainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.DtMainTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.dtMainTableAdapter()
        Me.TableAdapterManager = New MPP.PhoneNumDBDataSetTableAdapters.TableAdapterManager()
        Me.btnExportOther = New System.Windows.Forms.Button()
        GroupBox3 = New System.Windows.Forms.GroupBox()
        GroupBox3.SuspendLayout()
        CType(Me.DtMainBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DtMainBindingNavigator.SuspendLayout()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DtMainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        GroupBox3.BackColor = System.Drawing.SystemColors.ControlDark
        GroupBox3.Controls.Add(Me.btnExportOther)
        GroupBox3.Controls.Add(Me.btnExportCrane)
        GroupBox3.Controls.Add(Me.btnExportJibai)
        GroupBox3.Controls.Add(Me.btnExportMenkyo)
        GroupBox3.Controls.Add(Me.btnExportSyaken)
        GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        GroupBox3.Location = New System.Drawing.Point(9, 48)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New System.Drawing.Size(138, 95)
        GroupBox3.TabIndex = 8
        GroupBox3.TabStop = False
        GroupBox3.Text = "ファイル出力"
        '
        'btnExportCrane
        '
        Me.btnExportCrane.Location = New System.Drawing.Point(73, 42)
        Me.btnExportCrane.Name = "btnExportCrane"
        Me.btnExportCrane.Size = New System.Drawing.Size(56, 23)
        Me.btnExportCrane.TabIndex = 9
        Me.btnExportCrane.Text = "ｸﾚｰﾝ"
        Me.btnExportCrane.UseVisualStyleBackColor = True
        '
        'btnExportJibai
        '
        Me.btnExportJibai.Location = New System.Drawing.Point(73, 18)
        Me.btnExportJibai.Name = "btnExportJibai"
        Me.btnExportJibai.Size = New System.Drawing.Size(56, 23)
        Me.btnExportJibai.TabIndex = 8
        Me.btnExportJibai.Text = "自賠責"
        Me.btnExportJibai.UseVisualStyleBackColor = True
        '
        'btnExportMenkyo
        '
        Me.btnExportMenkyo.Location = New System.Drawing.Point(11, 42)
        Me.btnExportMenkyo.Name = "btnExportMenkyo"
        Me.btnExportMenkyo.Size = New System.Drawing.Size(56, 23)
        Me.btnExportMenkyo.TabIndex = 7
        Me.btnExportMenkyo.Text = "免許証"
        Me.btnExportMenkyo.UseVisualStyleBackColor = True
        '
        'btnExportSyaken
        '
        Me.btnExportSyaken.Location = New System.Drawing.Point(11, 18)
        Me.btnExportSyaken.Name = "btnExportSyaken"
        Me.btnExportSyaken.Size = New System.Drawing.Size(56, 23)
        Me.btnExportSyaken.TabIndex = 6
        Me.btnExportSyaken.Text = "車検証"
        Me.btnExportSyaken.UseVisualStyleBackColor = True
        '
        'DtMainBindingNavigator
        '
        Me.DtMainBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DtMainBindingNavigator.BindingSource = Me.DtMainBindingSource
        Me.DtMainBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DtMainBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DtMainBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DtMainBindingNavigatorSaveItem})
        Me.DtMainBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DtMainBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DtMainBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DtMainBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DtMainBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DtMainBindingNavigator.Name = "DtMainBindingNavigator"
        Me.DtMainBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DtMainBindingNavigator.Size = New System.Drawing.Size(836, 25)
        Me.DtMainBindingNavigator.TabIndex = 0
        Me.DtMainBindingNavigator.Text = "BindingNavigator1"
        Me.DtMainBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DtMainBindingNavigatorSaveItem
        '
        Me.DtMainBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DtMainBindingNavigatorSaveItem.Enabled = False
        Me.DtMainBindingNavigatorSaveItem.Image = CType(resources.GetObject("DtMainBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DtMainBindingNavigatorSaveItem.Name = "DtMainBindingNavigatorSaveItem"
        Me.DtMainBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DtMainBindingNavigatorSaveItem.Text = "データの保存"
        '
        'grdMain
        '
        Me.grdMain.AllowUserToAddRows = False
        Me.grdMain.AllowUserToDeleteRows = False
        Me.grdMain.AllowUserToOrderColumns = True
        Me.grdMain.AutoGenerateColumns = False
        Me.grdMain.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.car_branch, Me.musen, Me.carnum1, Me.ton, Me.staff_name, Me.phonenum, Me.branch_name, Me.max_load, Me.limit_syaken, Me.limit_menkyo, Me.car_length, Me.car_width, Me.car_height, Me.bed_length, Me.bed_width, Me.bed_height, Me.id_staff, Me.staff_kana, Me.mail, Me.model, Me.maker, Me.car_type, Me.biko, Me.biko1, Me.biko2})
        Me.grdMain.DataSource = Me.DtMainBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdMain.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMain.Location = New System.Drawing.Point(0, 0)
        Me.grdMain.Name = "grdMain"
        Me.grdMain.ReadOnly = True
        Me.grdMain.RowHeadersWidth = 30
        Me.grdMain.RowTemplate.Height = 21
        Me.grdMain.Size = New System.Drawing.Size(1073, 713)
        Me.grdMain.TabIndex = 1
        '
        'max_load
        '
        Me.max_load.DataPropertyName = "max_load"
        Me.max_load.HeaderText = "最大積載量(kg)"
        Me.max_load.Name = "max_load"
        Me.max_load.ReadOnly = True
        '
        'limit_syaken
        '
        Me.limit_syaken.DataPropertyName = "limit_syaken"
        Me.limit_syaken.HeaderText = "車検証期限"
        Me.limit_syaken.Name = "limit_syaken"
        Me.limit_syaken.ReadOnly = True
        '
        'limit_menkyo
        '
        Me.limit_menkyo.DataPropertyName = "limit_menkyo"
        Me.limit_menkyo.HeaderText = "免許証期限"
        Me.limit_menkyo.Name = "limit_menkyo"
        Me.limit_menkyo.ReadOnly = True
        '
        'car_length
        '
        Me.car_length.DataPropertyName = "car_length"
        Me.car_length.HeaderText = "車両_長さ(cm)"
        Me.car_length.Name = "car_length"
        Me.car_length.ReadOnly = True
        '
        'car_width
        '
        Me.car_width.DataPropertyName = "car_width"
        Me.car_width.HeaderText = "車両_幅(cm)"
        Me.car_width.Name = "car_width"
        Me.car_width.ReadOnly = True
        '
        'car_height
        '
        Me.car_height.DataPropertyName = "car_height"
        Me.car_height.HeaderText = "車両_高さ(cm)"
        Me.car_height.Name = "car_height"
        Me.car_height.ReadOnly = True
        '
        'bed_length
        '
        Me.bed_length.DataPropertyName = "bed_length"
        Me.bed_length.HeaderText = "荷台長(cm)"
        Me.bed_length.Name = "bed_length"
        Me.bed_length.ReadOnly = True
        '
        'bed_width
        '
        Me.bed_width.DataPropertyName = "bed_width"
        Me.bed_width.HeaderText = "荷台幅(cm)"
        Me.bed_width.Name = "bed_width"
        Me.bed_width.ReadOnly = True
        '
        'bed_height
        '
        Me.bed_height.DataPropertyName = "bed_height"
        Me.bed_height.HeaderText = "荷台高(cm)"
        Me.bed_height.Name = "bed_height"
        Me.bed_height.ReadOnly = True
        '
        'id_staff
        '
        Me.id_staff.DataPropertyName = "id_staff"
        Me.id_staff.HeaderText = "id_staff"
        Me.id_staff.Name = "id_staff"
        Me.id_staff.ReadOnly = True
        Me.id_staff.Visible = False
        '
        'staff_kana
        '
        Me.staff_kana.DataPropertyName = "staff_kana"
        Me.staff_kana.HeaderText = "staff_kana"
        Me.staff_kana.Name = "staff_kana"
        Me.staff_kana.ReadOnly = True
        Me.staff_kana.Visible = False
        '
        'mail
        '
        Me.mail.DataPropertyName = "mail"
        Me.mail.HeaderText = "mail"
        Me.mail.Name = "mail"
        Me.mail.ReadOnly = True
        Me.mail.Visible = False
        '
        'model
        '
        Me.model.DataPropertyName = "model"
        Me.model.HeaderText = "model"
        Me.model.Name = "model"
        Me.model.ReadOnly = True
        Me.model.Visible = False
        '
        'maker
        '
        Me.maker.DataPropertyName = "maker"
        Me.maker.HeaderText = "メーカー"
        Me.maker.Name = "maker"
        Me.maker.ReadOnly = True
        Me.maker.Width = 50
        '
        'car_type
        '
        Me.car_type.DataPropertyName = "car_type"
        Me.car_type.HeaderText = "車種"
        Me.car_type.Name = "car_type"
        Me.car_type.ReadOnly = True
        '
        'biko
        '
        Me.biko.DataPropertyName = "biko"
        Me.biko.HeaderText = "biko_staff"
        Me.biko.Name = "biko"
        Me.biko.ReadOnly = True
        '
        'biko1
        '
        Me.biko1.DataPropertyName = "biko1"
        Me.biko1.HeaderText = "biko_car"
        Me.biko1.Name = "biko1"
        Me.biko1.ReadOnly = True
        '
        'biko2
        '
        Me.biko2.DataPropertyName = "biko2"
        Me.biko2.HeaderText = "biko_phone"
        Me.biko2.Name = "biko2"
        Me.biko2.ReadOnly = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(9, 3)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(79, 23)
        Me.btnAdmin.TabIndex = 2
        Me.btnAdmin.Text = "管理メニュー"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtFilterBiko)
        Me.GroupBox1.Controls.Add(Me.btnRetire)
        Me.GroupBox1.Controls.Add(Me.btnEmergency)
        Me.GroupBox1.Controls.Add(Me.btnFilterClear)
        Me.GroupBox1.Controls.Add(Me.btn15tU)
        Me.GroupBox1.Controls.Add(Me.btn10tU)
        Me.GroupBox1.Controls.Add(Me.btn7tU)
        Me.GroupBox1.Controls.Add(Me.btn4tU)
        Me.GroupBox1.Controls.Add(Me.btn3tU)
        Me.GroupBox1.Controls.Add(Me.btn2tU)
        Me.GroupBox1.Controls.Add(Me.btn2tHira)
        Me.GroupBox1.Controls.Add(Me.btnAllCar)
        Me.GroupBox1.Controls.Add(Me.btn8000)
        Me.GroupBox1.Controls.Add(Me.btn7000)
        Me.GroupBox1.Controls.Add(Me.btn6000)
        Me.GroupBox1.Controls.Add(Me.btn5000)
        Me.GroupBox1.Controls.Add(Me.btn4000)
        Me.GroupBox1.Controls.Add(Me.btn3000)
        Me.GroupBox1.Controls.Add(Me.btn2000)
        Me.GroupBox1.Controls.Add(Me.btn1000)
        Me.GroupBox1.Controls.Add(Me.btn1)
        Me.GroupBox1.Controls.Add(Me.btn9000)
        Me.GroupBox1.Controls.Add(Me.btnWa)
        Me.GroupBox1.Controls.Add(Me.btnRa)
        Me.GroupBox1.Controls.Add(Me.btnYa)
        Me.GroupBox1.Controls.Add(Me.btnMa)
        Me.GroupBox1.Controls.Add(Me.btnHa)
        Me.GroupBox1.Controls.Add(Me.btnNa)
        Me.GroupBox1.Controls.Add(Me.btnTa)
        Me.GroupBox1.Controls.Add(Me.btnSa)
        Me.GroupBox1.Controls.Add(Me.btnKa)
        Me.GroupBox1.Controls.Add(Me.btnA)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbBranchCar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbBranchStaff)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFilterKana)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFilterPhonenum)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 504)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "絞り込み"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "備考"
        '
        'txtFilterBiko
        '
        Me.txtFilterBiko.Location = New System.Drawing.Point(82, 122)
        Me.txtFilterBiko.Name = "txtFilterBiko"
        Me.txtFilterBiko.Size = New System.Drawing.Size(65, 19)
        Me.txtFilterBiko.TabIndex = 39
        '
        'btnRetire
        '
        Me.btnRetire.Location = New System.Drawing.Point(96, 416)
        Me.btnRetire.Name = "btnRetire"
        Me.btnRetire.Size = New System.Drawing.Size(52, 23)
        Me.btnRetire.TabIndex = 38
        Me.btnRetire.Text = "廃車"
        Me.btnRetire.UseVisualStyleBackColor = True
        '
        'btnEmergency
        '
        Me.btnEmergency.Location = New System.Drawing.Point(96, 387)
        Me.btnEmergency.Name = "btnEmergency"
        Me.btnEmergency.Size = New System.Drawing.Size(52, 23)
        Me.btnEmergency.TabIndex = 37
        Me.btnEmergency.Text = "緊急"
        Me.btnEmergency.UseVisualStyleBackColor = True
        '
        'btnFilterClear
        '
        Me.btnFilterClear.Location = New System.Drawing.Point(7, 474)
        Me.btnFilterClear.Name = "btnFilterClear"
        Me.btnFilterClear.Size = New System.Drawing.Size(141, 23)
        Me.btnFilterClear.TabIndex = 36
        Me.btnFilterClear.Text = "絞り込み解除"
        Me.btnFilterClear.UseVisualStyleBackColor = True
        '
        'btn15tU
        '
        Me.btn15tU.Location = New System.Drawing.Point(96, 358)
        Me.btn15tU.Name = "btn15tU"
        Me.btn15tU.Size = New System.Drawing.Size(52, 23)
        Me.btn15tU.TabIndex = 35
        Me.btn15tU.Text = "15tU"
        Me.btn15tU.UseVisualStyleBackColor = True
        '
        'btn10tU
        '
        Me.btn10tU.Location = New System.Drawing.Point(96, 329)
        Me.btn10tU.Name = "btn10tU"
        Me.btn10tU.Size = New System.Drawing.Size(52, 23)
        Me.btn10tU.TabIndex = 34
        Me.btn10tU.Text = "10tU"
        Me.btn10tU.UseVisualStyleBackColor = True
        '
        'btn7tU
        '
        Me.btn7tU.Location = New System.Drawing.Point(96, 300)
        Me.btn7tU.Name = "btn7tU"
        Me.btn7tU.Size = New System.Drawing.Size(52, 23)
        Me.btn7tU.TabIndex = 33
        Me.btn7tU.Text = "7tU"
        Me.btn7tU.UseVisualStyleBackColor = True
        '
        'btn4tU
        '
        Me.btn4tU.Location = New System.Drawing.Point(96, 271)
        Me.btn4tU.Name = "btn4tU"
        Me.btn4tU.Size = New System.Drawing.Size(52, 23)
        Me.btn4tU.TabIndex = 32
        Me.btn4tU.Text = "4tU"
        Me.btn4tU.UseVisualStyleBackColor = True
        '
        'btn3tU
        '
        Me.btn3tU.Location = New System.Drawing.Point(96, 242)
        Me.btn3tU.Name = "btn3tU"
        Me.btn3tU.Size = New System.Drawing.Size(52, 23)
        Me.btn3tU.TabIndex = 31
        Me.btn3tU.Text = "3tU"
        Me.btn3tU.UseVisualStyleBackColor = True
        '
        'btn2tU
        '
        Me.btn2tU.Location = New System.Drawing.Point(96, 213)
        Me.btn2tU.Name = "btn2tU"
        Me.btn2tU.Size = New System.Drawing.Size(52, 23)
        Me.btn2tU.TabIndex = 30
        Me.btn2tU.Text = "2tU"
        Me.btn2tU.UseVisualStyleBackColor = True
        '
        'btn2tHira
        '
        Me.btn2tHira.Location = New System.Drawing.Point(96, 184)
        Me.btn2tHira.Name = "btn2tHira"
        Me.btn2tHira.Size = New System.Drawing.Size(52, 23)
        Me.btn2tHira.TabIndex = 29
        Me.btn2tHira.Text = "2t平"
        Me.btn2tHira.UseVisualStyleBackColor = True
        '
        'btnAllCar
        '
        Me.btnAllCar.Location = New System.Drawing.Point(39, 155)
        Me.btnAllCar.Name = "btnAllCar"
        Me.btnAllCar.Size = New System.Drawing.Size(108, 23)
        Me.btnAllCar.TabIndex = 28
        Me.btnAllCar.Text = "全ての車両"
        Me.btnAllCar.UseVisualStyleBackColor = True
        '
        'btn8000
        '
        Me.btn8000.Location = New System.Drawing.Point(39, 416)
        Me.btn8000.Name = "btn8000"
        Me.btn8000.Size = New System.Drawing.Size(51, 23)
        Me.btn8000.TabIndex = 27
        Me.btn8000.Text = "8000-"
        Me.btn8000.UseVisualStyleBackColor = True
        '
        'btn7000
        '
        Me.btn7000.Location = New System.Drawing.Point(39, 387)
        Me.btn7000.Name = "btn7000"
        Me.btn7000.Size = New System.Drawing.Size(51, 23)
        Me.btn7000.TabIndex = 26
        Me.btn7000.Text = "7000-"
        Me.btn7000.UseVisualStyleBackColor = True
        '
        'btn6000
        '
        Me.btn6000.Location = New System.Drawing.Point(39, 358)
        Me.btn6000.Name = "btn6000"
        Me.btn6000.Size = New System.Drawing.Size(51, 23)
        Me.btn6000.TabIndex = 25
        Me.btn6000.Text = "6000-"
        Me.btn6000.UseVisualStyleBackColor = True
        '
        'btn5000
        '
        Me.btn5000.Location = New System.Drawing.Point(39, 329)
        Me.btn5000.Name = "btn5000"
        Me.btn5000.Size = New System.Drawing.Size(51, 23)
        Me.btn5000.TabIndex = 24
        Me.btn5000.Text = "5000-"
        Me.btn5000.UseVisualStyleBackColor = True
        '
        'btn4000
        '
        Me.btn4000.Location = New System.Drawing.Point(39, 300)
        Me.btn4000.Name = "btn4000"
        Me.btn4000.Size = New System.Drawing.Size(51, 23)
        Me.btn4000.TabIndex = 23
        Me.btn4000.Text = "4000-"
        Me.btn4000.UseVisualStyleBackColor = True
        '
        'btn3000
        '
        Me.btn3000.Location = New System.Drawing.Point(39, 271)
        Me.btn3000.Name = "btn3000"
        Me.btn3000.Size = New System.Drawing.Size(51, 23)
        Me.btn3000.TabIndex = 22
        Me.btn3000.Text = "3000-"
        Me.btn3000.UseVisualStyleBackColor = True
        '
        'btn2000
        '
        Me.btn2000.Location = New System.Drawing.Point(39, 242)
        Me.btn2000.Name = "btn2000"
        Me.btn2000.Size = New System.Drawing.Size(51, 23)
        Me.btn2000.TabIndex = 21
        Me.btn2000.Text = "2000-"
        Me.btn2000.UseVisualStyleBackColor = True
        '
        'btn1000
        '
        Me.btn1000.Location = New System.Drawing.Point(39, 213)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(51, 23)
        Me.btn1000.TabIndex = 20
        Me.btn1000.Text = "1000-"
        Me.btn1000.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(39, 184)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(51, 23)
        Me.btn1.TabIndex = 19
        Me.btn1.Text = "1-"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn9000
        '
        Me.btn9000.Location = New System.Drawing.Point(39, 445)
        Me.btn9000.Name = "btn9000"
        Me.btn9000.Size = New System.Drawing.Size(51, 23)
        Me.btn9000.TabIndex = 18
        Me.btn9000.Text = "9000-"
        Me.btn9000.UseVisualStyleBackColor = True
        '
        'btnWa
        '
        Me.btnWa.Location = New System.Drawing.Point(7, 445)
        Me.btnWa.Name = "btnWa"
        Me.btnWa.Size = New System.Drawing.Size(26, 23)
        Me.btnWa.TabIndex = 17
        Me.btnWa.Text = "ﾜ"
        Me.btnWa.UseVisualStyleBackColor = True
        '
        'btnRa
        '
        Me.btnRa.Location = New System.Drawing.Point(7, 416)
        Me.btnRa.Name = "btnRa"
        Me.btnRa.Size = New System.Drawing.Size(26, 23)
        Me.btnRa.TabIndex = 16
        Me.btnRa.Text = "ﾗ"
        Me.btnRa.UseVisualStyleBackColor = True
        '
        'btnYa
        '
        Me.btnYa.Location = New System.Drawing.Point(7, 387)
        Me.btnYa.Name = "btnYa"
        Me.btnYa.Size = New System.Drawing.Size(26, 23)
        Me.btnYa.TabIndex = 15
        Me.btnYa.Text = "ﾔ"
        Me.btnYa.UseVisualStyleBackColor = True
        '
        'btnMa
        '
        Me.btnMa.Location = New System.Drawing.Point(7, 358)
        Me.btnMa.Name = "btnMa"
        Me.btnMa.Size = New System.Drawing.Size(26, 23)
        Me.btnMa.TabIndex = 14
        Me.btnMa.Text = "ﾏ"
        Me.btnMa.UseVisualStyleBackColor = True
        '
        'btnHa
        '
        Me.btnHa.Location = New System.Drawing.Point(7, 329)
        Me.btnHa.Name = "btnHa"
        Me.btnHa.Size = New System.Drawing.Size(26, 23)
        Me.btnHa.TabIndex = 13
        Me.btnHa.Text = "ﾊ"
        Me.btnHa.UseVisualStyleBackColor = True
        '
        'btnNa
        '
        Me.btnNa.Location = New System.Drawing.Point(7, 300)
        Me.btnNa.Name = "btnNa"
        Me.btnNa.Size = New System.Drawing.Size(26, 23)
        Me.btnNa.TabIndex = 12
        Me.btnNa.Text = "ﾅ"
        Me.btnNa.UseVisualStyleBackColor = True
        '
        'btnTa
        '
        Me.btnTa.Location = New System.Drawing.Point(7, 271)
        Me.btnTa.Name = "btnTa"
        Me.btnTa.Size = New System.Drawing.Size(26, 23)
        Me.btnTa.TabIndex = 11
        Me.btnTa.Text = "ﾀ"
        Me.btnTa.UseVisualStyleBackColor = True
        '
        'btnSa
        '
        Me.btnSa.Location = New System.Drawing.Point(7, 242)
        Me.btnSa.Name = "btnSa"
        Me.btnSa.Size = New System.Drawing.Size(26, 23)
        Me.btnSa.TabIndex = 10
        Me.btnSa.Text = "ｻ"
        Me.btnSa.UseVisualStyleBackColor = True
        '
        'btnKa
        '
        Me.btnKa.Location = New System.Drawing.Point(7, 213)
        Me.btnKa.Name = "btnKa"
        Me.btnKa.Size = New System.Drawing.Size(26, 23)
        Me.btnKa.TabIndex = 9
        Me.btnKa.Text = "ｶ"
        Me.btnKa.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(7, 184)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(26, 23)
        Me.btnA.TabIndex = 8
        Me.btnA.Text = "ｱ"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "所属(車両)"
        '
        'cmbBranchCar
        '
        Me.cmbBranchCar.FormattingEnabled = True
        Me.cmbBranchCar.Location = New System.Drawing.Point(82, 95)
        Me.cmbBranchCar.Name = "cmbBranchCar"
        Me.cmbBranchCar.Size = New System.Drawing.Size(65, 20)
        Me.cmbBranchCar.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "所属(社員)"
        '
        'cmbBranchStaff
        '
        Me.cmbBranchStaff.FormattingEnabled = True
        Me.cmbBranchStaff.Location = New System.Drawing.Point(82, 69)
        Me.cmbBranchStaff.Name = "cmbBranchStaff"
        Me.cmbBranchStaff.Size = New System.Drawing.Size(65, 20)
        Me.cmbBranchStaff.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "氏名ｶﾅ"
        '
        'txtFilterKana
        '
        Me.txtFilterKana.Location = New System.Drawing.Point(82, 43)
        Me.txtFilterKana.Name = "txtFilterKana"
        Me.txtFilterKana.Size = New System.Drawing.Size(65, 19)
        Me.txtFilterKana.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "電話番号"
        '
        'txtFilterPhonenum
        '
        Me.txtFilterPhonenum.Location = New System.Drawing.Point(82, 18)
        Me.txtFilterPhonenum.Name = "txtFilterPhonenum"
        Me.txtFilterPhonenum.Size = New System.Drawing.Size(65, 19)
        Me.txtFilterPhonenum.TabIndex = 0
        '
        'lblHowManyRecords
        '
        Me.lblHowManyRecords.AutoSize = True
        Me.lblHowManyRecords.Location = New System.Drawing.Point(12, 692)
        Me.lblHowManyRecords.Name = "lblHowManyRecords"
        Me.lblHowManyRecords.Size = New System.Drawing.Size(108, 12)
        Me.lblHowManyRecords.TabIndex = 4
        Me.lblHowManyRecords.Text = "lblHowManyRecords"
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(17, 18)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(126, 23)
        Me.btnModify.TabIndex = 5
        Me.btnModify.Text = "詳細表示/編集"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btnModify)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(153, 149)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "選択した行の操作"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnLogin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblHowManyRecords)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdmin)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdMain)
        Me.SplitContainer1.Size = New System.Drawing.Size(1247, 713)
        Me.SplitContainer1.SplitterDistance = 170
        Me.SplitContainer1.TabIndex = 8
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(90, 3)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "ログイン"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'car_branch
        '
        Me.car_branch.DataPropertyName = "branch_name1"
        Me.car_branch.HeaderText = "車庫"
        Me.car_branch.Name = "car_branch"
        Me.car_branch.ReadOnly = True
        Me.car_branch.Width = 50
        '
        'musen
        '
        Me.musen.DataPropertyName = "musen"
        Me.musen.HeaderText = "無線"
        Me.musen.Name = "musen"
        Me.musen.ReadOnly = True
        Me.musen.Width = 50
        '
        'carnum1
        '
        Me.carnum1.DataPropertyName = "carnum1"
        Me.carnum1.HeaderText = "車番"
        Me.carnum1.Name = "carnum1"
        Me.carnum1.ReadOnly = True
        Me.carnum1.Width = 50
        '
        'ton
        '
        Me.ton.DataPropertyName = "ton"
        Me.ton.HeaderText = "車格"
        Me.ton.Name = "ton"
        Me.ton.ReadOnly = True
        Me.ton.Width = 50
        '
        'staff_name
        '
        Me.staff_name.DataPropertyName = "staff_name"
        Me.staff_name.HeaderText = "氏名"
        Me.staff_name.Name = "staff_name"
        Me.staff_name.ReadOnly = True
        '
        'phonenum
        '
        Me.phonenum.DataPropertyName = "phonenum"
        Me.phonenum.HeaderText = "電話番号"
        Me.phonenum.Name = "phonenum"
        Me.phonenum.ReadOnly = True
        '
        'branch_name
        '
        Me.branch_name.DataPropertyName = "branch_name"
        Me.branch_name.HeaderText = "所属"
        Me.branch_name.Name = "branch_name"
        Me.branch_name.ReadOnly = True
        Me.branch_name.Width = 50
        '
        'DtMainBindingSource
        '
        Me.DtMainBindingSource.DataMember = "dtMain"
        Me.DtMainBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'PhoneNumDBDataSet
        '
        Me.PhoneNumDBDataSet.DataSetName = "PhoneNumDBDataSet"
        Me.PhoneNumDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtMainTableAdapter
        '
        Me.DtMainTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_branchTableAdapter = Nothing
        Me.TableAdapterManager.tbl_carTableAdapter = Nothing
        Me.TableAdapterManager.tbl_feeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PhoneNumTableAdapter = Nothing
        Me.TableAdapterManager.tbl_staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MPP.PhoneNumDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnExportOther
        '
        Me.btnExportOther.Location = New System.Drawing.Point(11, 66)
        Me.btnExportOther.Name = "btnExportOther"
        Me.btnExportOther.Size = New System.Drawing.Size(56, 23)
        Me.btnExportOther.TabIndex = 10
        Me.btnExportOther.Text = "その他"
        Me.btnExportOther.UseVisualStyleBackColor = True
        '
        'frmGrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1247, 713)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.DtMainBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGrd"
        Me.Text = "Men, Phones, and Plates"
        GroupBox3.ResumeLayout(False)
        CType(Me.DtMainBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DtMainBindingNavigator.ResumeLayout(False)
        Me.DtMainBindingNavigator.PerformLayout()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DtMainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents DtMainBindingSource As BindingSource
    Friend WithEvents DtMainTableAdapter As PhoneNumDBDataSetTableAdapters.dtMainTableAdapter
    Friend WithEvents TableAdapterManager As PhoneNumDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DtMainBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DtMainBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents grdMain As DataGridView
    Friend WithEvents btnAdmin As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFilterClear As Button
    Friend WithEvents btn15tU As Button
    Friend WithEvents btn10tU As Button
    Friend WithEvents btn7tU As Button
    Friend WithEvents btn4tU As Button
    Friend WithEvents btn3tU As Button
    Friend WithEvents btn2tU As Button
    Friend WithEvents btn2tHira As Button
    Friend WithEvents btnAllCar As Button
    Friend WithEvents btn8000 As Button
    Friend WithEvents btn7000 As Button
    Friend WithEvents btn6000 As Button
    Friend WithEvents btn5000 As Button
    Friend WithEvents btn4000 As Button
    Friend WithEvents btn3000 As Button
    Friend WithEvents btn2000 As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn9000 As Button
    Friend WithEvents btnWa As Button
    Friend WithEvents btnRa As Button
    Friend WithEvents btnYa As Button
    Friend WithEvents btnMa As Button
    Friend WithEvents btnHa As Button
    Friend WithEvents btnNa As Button
    Friend WithEvents btnTa As Button
    Friend WithEvents btnSa As Button
    Friend WithEvents btnKa As Button
    Friend WithEvents btnA As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbBranchCar As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbBranchStaff As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFilterKana As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFilterPhonenum As TextBox
    Friend WithEvents lblHowManyRecords As Label
    Friend WithEvents btnModify As Button
    Friend WithEvents btnExportSyaken As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnEmergency As Button
    Friend WithEvents btnExportCrane As Button
    Friend WithEvents btnExportJibai As Button
    Friend WithEvents btnExportMenkyo As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRetire As Button
    Friend WithEvents car_branch As DataGridViewTextBoxColumn
    Friend WithEvents musen As DataGridViewTextBoxColumn
    Friend WithEvents carnum1 As DataGridViewTextBoxColumn
    Friend WithEvents ton As DataGridViewTextBoxColumn
    Friend WithEvents staff_name As DataGridViewTextBoxColumn
    Friend WithEvents phonenum As DataGridViewTextBoxColumn
    Friend WithEvents branch_name As DataGridViewTextBoxColumn
    Friend WithEvents max_load As DataGridViewTextBoxColumn
    Friend WithEvents limit_syaken As DataGridViewTextBoxColumn
    Friend WithEvents limit_menkyo As DataGridViewTextBoxColumn
    Friend WithEvents car_length As DataGridViewTextBoxColumn
    Friend WithEvents car_width As DataGridViewTextBoxColumn
    Friend WithEvents car_height As DataGridViewTextBoxColumn
    Friend WithEvents bed_length As DataGridViewTextBoxColumn
    Friend WithEvents bed_width As DataGridViewTextBoxColumn
    Friend WithEvents bed_height As DataGridViewTextBoxColumn
    Friend WithEvents id_staff As DataGridViewTextBoxColumn
    Friend WithEvents staff_kana As DataGridViewTextBoxColumn
    Friend WithEvents mail As DataGridViewTextBoxColumn
    Friend WithEvents model As DataGridViewTextBoxColumn
    Friend WithEvents maker As DataGridViewTextBoxColumn
    Friend WithEvents car_type As DataGridViewTextBoxColumn
    Friend WithEvents biko As DataGridViewTextBoxColumn
    Friend WithEvents biko1 As DataGridViewTextBoxColumn
    Friend WithEvents biko2 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFilterBiko As TextBox
    Friend WithEvents btnExportOther As Button
End Class
