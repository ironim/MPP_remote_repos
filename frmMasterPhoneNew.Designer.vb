<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterPhoneNew
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
        Dim MailLabel As System.Windows.Forms.Label
        Dim BikoLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtPhonenum = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtBiko = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.PhoneNumDBDataSet = New MPP.PhoneNumDBDataSet()
        Me.TblPhoneNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PhoneNumTableAdapter = New MPP.PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter()
        MailLabel = New System.Windows.Forms.Label()
        BikoLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPhoneNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(10, 41)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(58, 12)
        MailLabel.TabIndex = 14
        MailLabel.Text = "ﾒｰﾙｱﾄﾞﾚｽ"
        '
        'BikoLabel
        '
        BikoLabel.AutoSize = True
        BikoLabel.Location = New System.Drawing.Point(22, 91)
        BikoLabel.Name = "BikoLabel"
        BikoLabel.Size = New System.Drawing.Size(29, 12)
        BikoLabel.TabIndex = 18
        BikoLabel.Text = "備考"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(22, 66)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(29, 12)
        ModelLabel.TabIndex = 20
        ModelLabel.Text = "機種"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(200, 204)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(55, 23)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "閉じる"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "電話番号"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 12)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "(ﾊｲﾌﾝあり、半角)"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(137, 204)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(57, 23)
        Me.btnRegister.TabIndex = 17
        Me.btnRegister.Text = "登録"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'txtPhonenum
        '
        Me.txtPhonenum.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtPhonenum.Location = New System.Drawing.Point(74, 12)
        Me.txtPhonenum.Name = "txtPhonenum"
        Me.txtPhonenum.Size = New System.Drawing.Size(98, 19)
        Me.txtPhonenum.TabIndex = 12
        '
        'txtMail
        '
        Me.txtMail.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMail.Location = New System.Drawing.Point(74, 38)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(181, 19)
        Me.txtMail.TabIndex = 13
        '
        'txtBiko
        '
        Me.txtBiko.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtBiko.Location = New System.Drawing.Point(74, 88)
        Me.txtBiko.Multiline = True
        Me.txtBiko.Name = "txtBiko"
        Me.txtBiko.Size = New System.Drawing.Size(181, 110)
        Me.txtBiko.TabIndex = 16
        '
        'txtModel
        '
        Me.txtModel.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtModel.Location = New System.Drawing.Point(74, 63)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(181, 19)
        Me.txtModel.TabIndex = 15
        '
        'PhoneNumDBDataSet
        '
        Me.PhoneNumDBDataSet.DataSetName = "PhoneNumDBDataSet"
        Me.PhoneNumDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPhoneNumBindingSource
        '
        Me.TblPhoneNumBindingSource.DataMember = "tbl_PhoneNum"
        Me.TblPhoneNumBindingSource.DataSource = Me.PhoneNumDBDataSet
        '
        'Tbl_PhoneNumTableAdapter
        '
        Me.Tbl_PhoneNumTableAdapter.ClearBeforeFill = True
        '
        'frmMasterPhoneNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(278, 242)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtPhonenum)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(BikoLabel)
        Me.Controls.Add(Me.txtBiko)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.txtModel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMasterPhoneNew"
        Me.Text = "電話番号マスタ新規"
        CType(Me.PhoneNumDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPhoneNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtPhonenum As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtBiko As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents PhoneNumDBDataSet As PhoneNumDBDataSet
    Friend WithEvents TblPhoneNumBindingSource As BindingSource
    Friend WithEvents Tbl_PhoneNumTableAdapter As PhoneNumDBDataSetTableAdapters.tbl_PhoneNumTableAdapter
End Class
