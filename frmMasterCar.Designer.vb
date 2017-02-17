<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterCar
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.grdCar = New System.Windows.Forms.DataGridView()
        Me.TblcarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.Tbl_carTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Carnum1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carnum2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carnum3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carnum4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MusenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BikoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.max_load = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.limit_syaken = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.car_length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.car_width = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.car_height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bed_length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bed_width = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bed_height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 439)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(182, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "選択行の削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(93, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(83, 23)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "選択行の編集"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(12, 12)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "新規登録"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'grdCar
        '
        Me.grdCar.AllowUserToAddRows = False
        Me.grdCar.AllowUserToDeleteRows = False
        Me.grdCar.AllowUserToOrderColumns = True
        Me.grdCar.AutoGenerateColumns = False
        Me.grdCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Carnum1DataGridViewTextBoxColumn, Me.Carnum2DataGridViewTextBoxColumn, Me.Carnum3DataGridViewTextBoxColumn, Me.Carnum4DataGridViewTextBoxColumn, Me.MusenDataGridViewTextBoxColumn, Me.TonDataGridViewTextBoxColumn, Me.BikoDataGridViewTextBoxColumn, Me.max_load, Me.limit_syaken, Me.car_length, Me.car_width, Me.car_height, Me.bed_length, Me.bed_width, Me.bed_height, Me.BranchidDataGridViewTextBoxColumn, Me.StaffidDataGridViewTextBoxColumn})
        Me.grdCar.DataSource = Me.TblcarBindingSource
        Me.grdCar.Location = New System.Drawing.Point(12, 41)
        Me.grdCar.Name = "grdCar"
        Me.grdCar.ReadOnly = True
        Me.grdCar.RowTemplate.Height = 21
        Me.grdCar.Size = New System.Drawing.Size(1059, 392)
        Me.grdCar.TabIndex = 6
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
        'Tbl_carTableAdapter
        '
        Me.Tbl_carTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(300, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "車番検索"
        '
        'txtSearch
        '
        Me.txtSearch.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtSearch.Location = New System.Drawing.Point(359, 16)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 19)
        Me.txtSearch.TabIndex = 12
        '
        'Carnum1DataGridViewTextBoxColumn
        '
        Me.Carnum1DataGridViewTextBoxColumn.DataPropertyName = "carnum1"
        Me.Carnum1DataGridViewTextBoxColumn.HeaderText = "車両番号"
        Me.Carnum1DataGridViewTextBoxColumn.Name = "Carnum1DataGridViewTextBoxColumn"
        Me.Carnum1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Carnum2DataGridViewTextBoxColumn
        '
        Me.Carnum2DataGridViewTextBoxColumn.DataPropertyName = "carnum2"
        Me.Carnum2DataGridViewTextBoxColumn.HeaderText = "地名"
        Me.Carnum2DataGridViewTextBoxColumn.Name = "Carnum2DataGridViewTextBoxColumn"
        Me.Carnum2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Carnum3DataGridViewTextBoxColumn
        '
        Me.Carnum3DataGridViewTextBoxColumn.DataPropertyName = "carnum3"
        Me.Carnum3DataGridViewTextBoxColumn.HeaderText = "分類番号"
        Me.Carnum3DataGridViewTextBoxColumn.Name = "Carnum3DataGridViewTextBoxColumn"
        Me.Carnum3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Carnum4DataGridViewTextBoxColumn
        '
        Me.Carnum4DataGridViewTextBoxColumn.DataPropertyName = "carnum4"
        Me.Carnum4DataGridViewTextBoxColumn.HeaderText = "ひらがな"
        Me.Carnum4DataGridViewTextBoxColumn.Name = "Carnum4DataGridViewTextBoxColumn"
        Me.Carnum4DataGridViewTextBoxColumn.ReadOnly = True
        '
        'MusenDataGridViewTextBoxColumn
        '
        Me.MusenDataGridViewTextBoxColumn.DataPropertyName = "musen"
        Me.MusenDataGridViewTextBoxColumn.HeaderText = "無線"
        Me.MusenDataGridViewTextBoxColumn.Name = "MusenDataGridViewTextBoxColumn"
        Me.MusenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TonDataGridViewTextBoxColumn
        '
        Me.TonDataGridViewTextBoxColumn.DataPropertyName = "ton"
        Me.TonDataGridViewTextBoxColumn.HeaderText = "車格"
        Me.TonDataGridViewTextBoxColumn.Name = "TonDataGridViewTextBoxColumn"
        Me.TonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BikoDataGridViewTextBoxColumn
        '
        Me.BikoDataGridViewTextBoxColumn.DataPropertyName = "biko"
        Me.BikoDataGridViewTextBoxColumn.HeaderText = "備考"
        Me.BikoDataGridViewTextBoxColumn.Name = "BikoDataGridViewTextBoxColumn"
        Me.BikoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'max_load
        '
        Me.max_load.DataPropertyName = "max_load"
        Me.max_load.HeaderText = "最大積載量"
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
        'car_length
        '
        Me.car_length.DataPropertyName = "car_length"
        Me.car_length.HeaderText = "長さ"
        Me.car_length.Name = "car_length"
        Me.car_length.ReadOnly = True
        '
        'car_width
        '
        Me.car_width.DataPropertyName = "car_width"
        Me.car_width.HeaderText = "幅"
        Me.car_width.Name = "car_width"
        Me.car_width.ReadOnly = True
        '
        'car_height
        '
        Me.car_height.DataPropertyName = "car_height"
        Me.car_height.HeaderText = "高さ"
        Me.car_height.Name = "car_height"
        Me.car_height.ReadOnly = True
        '
        'bed_length
        '
        Me.bed_length.DataPropertyName = "bed_length"
        Me.bed_length.HeaderText = "荷台長"
        Me.bed_length.Name = "bed_length"
        Me.bed_length.ReadOnly = True
        '
        'bed_width
        '
        Me.bed_width.DataPropertyName = "bed_width"
        Me.bed_width.HeaderText = "荷台幅"
        Me.bed_width.Name = "bed_width"
        Me.bed_width.ReadOnly = True
        '
        'bed_height
        '
        Me.bed_height.DataPropertyName = "bed_height"
        Me.bed_height.HeaderText = "荷台高"
        Me.bed_height.Name = "bed_height"
        Me.bed_height.ReadOnly = True
        '
        'BranchidDataGridViewTextBoxColumn
        '
        Me.BranchidDataGridViewTextBoxColumn.DataPropertyName = "branch_id"
        Me.BranchidDataGridViewTextBoxColumn.HeaderText = "branch_id"
        Me.BranchidDataGridViewTextBoxColumn.Name = "BranchidDataGridViewTextBoxColumn"
        Me.BranchidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StaffidDataGridViewTextBoxColumn
        '
        Me.StaffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id"
        Me.StaffidDataGridViewTextBoxColumn.HeaderText = "staff_id"
        Me.StaffidDataGridViewTextBoxColumn.Name = "StaffidDataGridViewTextBoxColumn"
        Me.StaffidDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffidDataGridViewTextBoxColumn.Visible = False
        '
        'frmMasterCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1091, 472)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.grdCar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMasterCar"
        Me.Text = "車両マスタ"
        CType(Me.grdCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents grdCar As DataGridView
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents TblcarBindingSource As BindingSource
    Friend WithEvents Tbl_carTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_carTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Carnum1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Carnum2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Carnum3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Carnum4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MusenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BikoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents max_load As DataGridViewTextBoxColumn
    Friend WithEvents limit_syaken As DataGridViewTextBoxColumn
    Friend WithEvents car_length As DataGridViewTextBoxColumn
    Friend WithEvents car_width As DataGridViewTextBoxColumn
    Friend WithEvents car_height As DataGridViewTextBoxColumn
    Friend WithEvents bed_length As DataGridViewTextBoxColumn
    Friend WithEvents bed_width As DataGridViewTextBoxColumn
    Friend WithEvents bed_height As DataGridViewTextBoxColumn
    Friend WithEvents BranchidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
