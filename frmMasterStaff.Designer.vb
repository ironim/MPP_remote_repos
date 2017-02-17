<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterStaff
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
        Me.grdStaff = New System.Windows.Forms.DataGridView()
        Me.IdstaffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffkanaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BikoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimitmenkyoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblstaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.Tbl_staffTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.grdStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(488, 532)
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
        Me.btnDelete.Size = New System.Drawing.Size(83, 23)
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
        'grdStaff
        '
        Me.grdStaff.AllowUserToAddRows = False
        Me.grdStaff.AllowUserToDeleteRows = False
        Me.grdStaff.AutoGenerateColumns = False
        Me.grdStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStaff.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdstaffDataGridViewTextBoxColumn, Me.StaffnameDataGridViewTextBoxColumn, Me.StaffkanaDataGridViewTextBoxColumn, Me.BranchidDataGridViewTextBoxColumn, Me.BikoDataGridViewTextBoxColumn, Me.LimitmenkyoDataGridViewTextBoxColumn})
        Me.grdStaff.DataSource = Me.TblstaffBindingSource
        Me.grdStaff.Location = New System.Drawing.Point(12, 41)
        Me.grdStaff.Name = "grdStaff"
        Me.grdStaff.ReadOnly = True
        Me.grdStaff.RowTemplate.Height = 21
        Me.grdStaff.Size = New System.Drawing.Size(551, 485)
        Me.grdStaff.TabIndex = 6
        '
        'IdstaffDataGridViewTextBoxColumn
        '
        Me.IdstaffDataGridViewTextBoxColumn.DataPropertyName = "id_staff"
        Me.IdstaffDataGridViewTextBoxColumn.HeaderText = "id_staff"
        Me.IdstaffDataGridViewTextBoxColumn.Name = "IdstaffDataGridViewTextBoxColumn"
        Me.IdstaffDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdstaffDataGridViewTextBoxColumn.Width = 50
        '
        'StaffnameDataGridViewTextBoxColumn
        '
        Me.StaffnameDataGridViewTextBoxColumn.DataPropertyName = "staff_name"
        Me.StaffnameDataGridViewTextBoxColumn.HeaderText = "氏名"
        Me.StaffnameDataGridViewTextBoxColumn.Name = "StaffnameDataGridViewTextBoxColumn"
        Me.StaffnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StaffkanaDataGridViewTextBoxColumn
        '
        Me.StaffkanaDataGridViewTextBoxColumn.DataPropertyName = "staff_kana"
        Me.StaffkanaDataGridViewTextBoxColumn.HeaderText = "氏名ｶﾅ"
        Me.StaffkanaDataGridViewTextBoxColumn.Name = "StaffkanaDataGridViewTextBoxColumn"
        Me.StaffkanaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BranchidDataGridViewTextBoxColumn
        '
        Me.BranchidDataGridViewTextBoxColumn.DataPropertyName = "branch_id"
        Me.BranchidDataGridViewTextBoxColumn.HeaderText = "branch_id"
        Me.BranchidDataGridViewTextBoxColumn.Name = "BranchidDataGridViewTextBoxColumn"
        Me.BranchidDataGridViewTextBoxColumn.ReadOnly = True
        Me.BranchidDataGridViewTextBoxColumn.Width = 50
        '
        'BikoDataGridViewTextBoxColumn
        '
        Me.BikoDataGridViewTextBoxColumn.DataPropertyName = "biko"
        Me.BikoDataGridViewTextBoxColumn.HeaderText = "備考"
        Me.BikoDataGridViewTextBoxColumn.Name = "BikoDataGridViewTextBoxColumn"
        Me.BikoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LimitmenkyoDataGridViewTextBoxColumn
        '
        Me.LimitmenkyoDataGridViewTextBoxColumn.DataPropertyName = "limit_menkyo"
        Me.LimitmenkyoDataGridViewTextBoxColumn.HeaderText = "免許証期限"
        Me.LimitmenkyoDataGridViewTextBoxColumn.Name = "LimitmenkyoDataGridViewTextBoxColumn"
        Me.LimitmenkyoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblstaffBindingSource
        '
        Me.TblstaffBindingSource.DataMember = "tbl_staff"
        Me.TblstaffBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'PhoneNumDBDataSet
        '
        Me.PhoneNumDBDataSet.DataSetName = "PhoneNumDBDataSet"
        Me.PhoneNumDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_staffTableAdapter
        '
        Me.Tbl_staffTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 12)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ｶﾅ検索"
        '
        'txtSearch
        '
        Me.txtSearch.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.txtSearch.Location = New System.Drawing.Point(328, 14)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 19)
        Me.txtSearch.TabIndex = 12
        '
        'frmMasterStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(576, 563)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.grdStaff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMasterStaff"
        Me.Text = "社員マスタ"
        CType(Me.grdStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents grdStaff As DataGridView
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents TblstaffBindingSource As BindingSource
    Friend WithEvents Tbl_staffTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_staffTableAdapter
    Friend WithEvents IdstaffDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffkanaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BranchidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BikoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimitmenkyoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
End Class
