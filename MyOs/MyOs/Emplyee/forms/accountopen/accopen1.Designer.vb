<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accopen1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accopen1))
        Me.searchciftb = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.searchactb = New DevExpress.XtraEditors.TextEdit()
        CType(Me.searchciftb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchactb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchciftb
        '
        Me.searchciftb.Location = New System.Drawing.Point(12, 54)
        Me.searchciftb.Name = "searchciftb"
        Me.searchciftb.Size = New System.Drawing.Size(354, 22)
        Me.searchciftb.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(315, 200)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(40, 29)
        Me.SimpleButton1.TabIndex = 1
        '
        'searchactb
        '
        Me.searchactb.Location = New System.Drawing.Point(12, 123)
        Me.searchactb.Name = "searchactb"
        Me.searchactb.Size = New System.Drawing.Size(354, 22)
        Me.searchactb.TabIndex = 0
        '
        'accopen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 261)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.searchactb)
        Me.Controls.Add(Me.searchciftb)
        Me.Name = "accopen1"
        Me.Text = "accopen1"
        CType(Me.searchciftb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchactb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents searchciftb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents searchactb As DevExpress.XtraEditors.TextEdit
End Class
