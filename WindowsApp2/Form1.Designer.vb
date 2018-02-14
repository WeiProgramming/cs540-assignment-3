<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.exitButton = New System.Windows.Forms.Button()
        Me.greetingLabel = New System.Windows.Forms.Label()
        Me.usaFlag = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.usaFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitButton
        '
        resources.ApplyResources(Me.exitButton, "exitButton")
        Me.exitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.exitButton.Name = "exitButton"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'greetingLabel
        '
        resources.ApplyResources(Me.greetingLabel, "greetingLabel")
        Me.greetingLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.greetingLabel.Name = "greetingLabel"
        '
        'usaFlag
        '
        resources.ApplyResources(Me.usaFlag, "usaFlag")
        Me.usaFlag.Image = Global.WindowsApp2.My.Resources.Resources.usa_flag_wallpaper_01
        Me.usaFlag.Name = "usaFlag"
        Me.usaFlag.TabStop = False
        '
        'PictureBox2
        '
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Image = Global.WindowsApp2.My.Resources.Resources.Belarus_flag_8
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.usaFlag)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.greetingLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Name = "Form1"
        CType(Me.usaFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents exitButton As Button
    Friend WithEvents greetingLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents usaFlag As PictureBox
End Class
