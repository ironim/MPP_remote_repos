<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMasterPhoneEdit
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
        Dim PhonenumLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim BikoLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtPhonenum = New System.Windows.Forms.TextBox()
        Me.TblPhoneNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtBiko = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Tbl_PhoneNumTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter()
        PhonenumLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        BikoLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        CType(Me.TblPhoneNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PhonenumLabel
        '
        PhonenumLabel.AutoSize = True
        PhonenumLabel.Location = New System.Drawing.Point(13, 14)
        PhonenumLabel.Name = "PhonenumLabel"
        PhonenumLabel.Size = New System.Drawing.Size(53, 12)
        PhonenumLabel.TabIndex = 8
        PhonenumLabel.Text = "電話番号"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(13, 39)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(58, 12)
        MailLabel.TabIndex = 11
        MailLabel.Text = "ﾒｰﾙｱﾄﾞﾚｽ"
        '
        'BikoLabel
        '
        BikoLabel.AutoSize = True
        BikoLabel.Location = New System.Drawing.Point(13, 89)
        BikoLabel.Name = "BikoLabel"
        BikoLabel.Size = New System.Drawing.Size(29, 12)
        BikoLabel.TabIndex = 15
        BikoLabel.Text = "備考"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(13, 64)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(29, 12)
        ModelLabel.TabIndex = 17
        ModelLabel.Text = "機種"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(207, 255)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(65, 23)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "キャンセル"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(135, 255)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(66, 23)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "決定"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtPhonenum
        '
        Me.txtPhonenum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneNumBindingSource, "phonenum", True))
        Me.txtPhonenum.Enabled = False
        Me.txtPhonenum.Location = New System.Drawing.Point(77, 11)
        Me.txtPhonenum.Name = "txtPhonenum"
        Me.txtPhonenum.Size = New System.Drawing.Size(100, 19)
        Me.txtPhonenum.TabIndex = 9
        '
        'TblPhoneNumBindingSource
        '
        Me.TblPhoneNumBindingSource.DataMember = "tbl_PhoneNum"
        Me.TblPhoneNumBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'PhoneNumDBDataSet
        '
        Me.PhoneNumDBDataSet.DataSetName = "PhoneNumDBDataSet"
        Me.PhoneNumDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtMail
        '
        Me.txtMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneNumBindingSource, "mail", True))
        Me.txtMail.Location = New System.Drawing.Point(77, 36)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(195, 19)
        Me.txtMail.TabIndex = 10
        '
        'txtBiko
        '
        Me.txtBiko.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneNumBindingSource, "biko", True))
        Me.txtBiko.Location = New System.Drawing.Point(77, 86)
        Me.txtBiko.Multiline = True
        Me.txtBiko.Name = "txtBiko"
        Me.txtBiko.Size = New System.Drawing.Size(195, 163)
        Me.txtBiko.TabIndex = 13
        '
        'txtModel
        '
        Me.txtModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPhoneNumBindingSource, "model", True))
        Me.txtModel.Location = New System.Drawing.Point(77, 61)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(100, 19)
        Me.txtModel.TabIndex = 12
        '
        'Tbl_PhoneNumTableAdapter
        '
        Me.Tbl_PhoneNumTableAdapter.ClearBeforeFill = True
        '
        'frmMasterPhoneEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(290, 292)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(PhonenumLabel)
        Me.Controls.Add(Me.txtPhonenum)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(BikoLabel)
        Me.Controls.Add(Me.txtBiko)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.txtModel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMasterPhoneEdit"
        Me.Text = "電話番号マスタ編集"
        CType(Me.TblPhoneNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents txtPhonenum As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtBiko As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents TblPhoneNumBindingSource As BindingSource
    Friend WithEvents Tbl_PhoneNumTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter
End Class
