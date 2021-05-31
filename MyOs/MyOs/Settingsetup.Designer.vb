<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settingsetup
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settingsetup))
        Dim SnapOptions1 As DevExpress.Utils.Controls.SnapOptions = New DevExpress.Utils.Controls.SnapOptions()
        Me.WizardControl1 = New DevExpress.XtraWizard.WizardControl()
        Me.WelcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
        Me.WizardPage1 = New DevExpress.XtraWizard.WizardPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.WizardPage2 = New DevExpress.XtraWizard.WizardPage()
        Me.WizardPage3 = New DevExpress.XtraWizard.WizardPage()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.searchactb = New DevExpress.XtraEditors.TextEdit()
        Me.searchciftb = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WizardControl1.SuspendLayout()
        Me.WelcomeWizardPage1.SuspendLayout()
        Me.WizardPage1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchactb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchciftb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WizardControl1
        '
        Me.WizardControl1.Controls.Add(Me.WelcomeWizardPage1)
        Me.WizardControl1.Controls.Add(Me.WizardPage1)
        Me.WizardControl1.Controls.Add(Me.CompletionWizardPage1)
        Me.WizardControl1.Controls.Add(Me.WizardPage2)
        Me.WizardControl1.Controls.Add(Me.WizardPage3)
        Me.WizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WizardControl1.ImageWidth = 216
        Me.WizardControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WizardControl1.MinimumSize = New System.Drawing.Size(117, 123)
        Me.WizardControl1.Name = "WizardControl1"
        Me.WizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.WelcomeWizardPage1, Me.WizardPage1, Me.WizardPage2, Me.WizardPage3, Me.CompletionWizardPage1})
        Me.WizardControl1.Size = New System.Drawing.Size(790, 532)
        Me.WizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero
        '
        'WelcomeWizardPage1
        '
        Me.WelcomeWizardPage1.Controls.Add(Me.SimpleButton1)
        Me.WelcomeWizardPage1.Controls.Add(Me.searchactb)
        Me.WelcomeWizardPage1.Controls.Add(Me.searchciftb)
        Me.WelcomeWizardPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WelcomeWizardPage1.Name = "WelcomeWizardPage1"
        Me.WelcomeWizardPage1.Size = New System.Drawing.Size(716, 321)
        Me.WelcomeWizardPage1.Text = "Account Open Wizard"
        '
        'WizardPage1
        '
        Me.WizardPage1.Controls.Add(Me.LayoutControl1)
        Me.WizardPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WizardPage1.Name = "WizardPage1"
        Me.WizardPage1.Size = New System.Drawing.Size(716, 321)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.PanelControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1055, 147, 812, 500)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(716, 321)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(716, 321)
        Me.Root.TextVisible = False
        '
        'CompletionWizardPage1
        '
        Me.CompletionWizardPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CompletionWizardPage1.Name = "CompletionWizardPage1"
        Me.CompletionWizardPage1.Size = New System.Drawing.Size(716, 321)
        '
        'WizardPage2
        '
        Me.WizardPage2.Name = "WizardPage2"
        Me.WizardPage2.Size = New System.Drawing.Size(716, 321)
        '
        'WizardPage3
        '
        Me.WizardPage3.Name = "WizardPage3"
        Me.WizardPage3.Size = New System.Drawing.Size(716, 321)
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(530, 171)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(40, 29)
        Me.SimpleButton1.TabIndex = 4
        '
        'searchactb
        '
        Me.searchactb.Location = New System.Drawing.Point(133, 175)
        Me.searchactb.Name = "searchactb"
        Me.searchactb.Properties.NullText = "ENTER ACCOUNT"
        Me.searchactb.Properties.NullValuePrompt = "ENTER ACCOUNT NUMBER "
        Me.searchactb.Size = New System.Drawing.Size(354, 22)
        Me.searchactb.TabIndex = 2
        '
        'searchciftb
        '
        Me.searchciftb.Location = New System.Drawing.Point(133, 106)
        Me.searchciftb.Name = "searchciftb"
        Me.searchciftb.Properties.NullText = "ENTER CIF IF "
        Me.searchciftb.Properties.NullValuePrompt = "ENTER CIF"
        Me.searchciftb.Size = New System.Drawing.Size(354, 22)
        Me.searchciftb.TabIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.AllowTouchScroll = True
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(692, 297)
        Me.PanelControl1.TabIndex = 4
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PanelControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(696, 301)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'Settingsetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BehaviorManager1.SetBehaviors(Me, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.Behaviors.Common.SnapWindowBehavior.Create(GetType(DevExpress.Utils.BehaviorSource.SnapWindowBehaviorSourceForForm), SnapOptions1), DevExpress.Utils.Behaviors.Behavior)})
        Me.ClientSize = New System.Drawing.Size(790, 532)
        Me.Controls.Add(Me.WizardControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settingsetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WizardForm1"
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WizardControl1.ResumeLayout(False)
        Me.WelcomeWizardPage1.ResumeLayout(False)
        Me.WizardPage1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchactb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchciftb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WizardControl1 As DevExpress.XtraWizard.WizardControl
    Friend WithEvents WelcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
    Friend WithEvents WizardPage1 As DevExpress.XtraWizard.WizardPage
    Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents WizardPage2 As DevExpress.XtraWizard.WizardPage
    Friend WithEvents WizardPage3 As DevExpress.XtraWizard.WizardPage
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents searchactb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents searchciftb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
