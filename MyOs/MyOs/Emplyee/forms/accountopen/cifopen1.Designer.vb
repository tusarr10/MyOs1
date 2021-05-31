<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cifopen1
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cifopen1))
        Me.searchciftb = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.searchactb = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.searchciftb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchactb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchciftb
        '
        Me.searchciftb.Location = New System.Drawing.Point(15, 64)
        Me.searchciftb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchciftb.Name = "searchciftb"
        Me.searchciftb.Properties.NullText = "ENTER CIF IF "
        Me.searchciftb.Properties.NullValuePrompt = "ENTER CIF"
        Me.searchciftb.Size = New System.Drawing.Size(455, 26)
        Me.searchciftb.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(405, 238)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(51, 34)
        Me.SimpleButton1.TabIndex = 1
        '
        'searchactb
        '
        Me.searchactb.Location = New System.Drawing.Point(15, 146)
        Me.searchactb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchactb.Name = "searchactb"
        Me.searchactb.Properties.NullText = "ENTER ACCOUNT"
        Me.searchactb.Properties.NullValuePrompt = "ENTER ACCOUNT NUMBER "
        Me.searchactb.Size = New System.Drawing.Size(455, 26)
        Me.searchactb.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(22, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(119, 19)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Enter Your CIF"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(22, 120)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(231, 19)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Enter Your Account Number "
        '
        'cifopen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 310)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.searchactb)
        Me.Controls.Add(Me.searchciftb)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "cifopen1"
        Me.Text = "accopen1"
        CType(Me.searchciftb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchactb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchciftb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents searchactb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
