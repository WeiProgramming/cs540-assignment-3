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
        Me.usaPictureBox = New System.Windows.Forms.PictureBox()
        Me.belarusPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.usaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.belarusPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'usaPictureBox
        '
        resources.ApplyResources(Me.usaPictureBox, "usaPictureBox")
        Me.usaPictureBox.Image = Global.WindowsApp2.My.Resources.Resources.usa_flag_wallpaper_01
        Me.usaPictureBox.Name = "usaPictureBox"
        Me.usaPictureBox.TabStop = False
        '
        'belarusPictureBox
        '
        resources.ApplyResources(Me.belarusPictureBox, "belarusPictureBox")
        Me.belarusPictureBox.Image = Global.WindowsApp2.My.Resources.Resources.Belarus_flag_8
        Me.belarusPictureBox.Name = "belarusPictureBox"
        Me.belarusPictureBox.TabStop = False
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.usaPictureBox)
        Me.Controls.Add(Me.belarusPictureBox)
        Me.Controls.Add(Me.greetingLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Name = "Form1"
        CType(Me.usaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.belarusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents exitButton As Button
    Friend WithEvents greetingLabel As Label
    Friend WithEvents belarusPictureBox As PictureBox
    Friend WithEvents usaPictureBox As PictureBox
End Class
