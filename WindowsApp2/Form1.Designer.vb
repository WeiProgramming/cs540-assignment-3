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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.greetingLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.usaFlag = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usaFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(708, 259)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(159, 80)
        Me.exitButton.TabIndex = 0
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'greetingLabel
        '
        Me.greetingLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.greetingLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.greetingLabel.Location = New System.Drawing.Point(271, 25)
        Me.greetingLabel.Name = "greetingLabel"
        Me.greetingLabel.Size = New System.Drawing.Size(318, 93)
        Me.greetingLabel.TabIndex = 1
        Me.greetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(442, 133)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(147, 64)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'usaFlag
        '
        Me.usaFlag.Location = New System.Drawing.Point(274, 133)
        Me.usaFlag.Name = "usaFlag"
        Me.usaFlag.Size = New System.Drawing.Size(147, 64)
        Me.usaFlag.TabIndex = 4
        Me.usaFlag.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 351)
        Me.Controls.Add(Me.usaFlag)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.greetingLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Name = "Form1"
        Me.Text = "CS540 Assignment 3"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usaFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents exitButton As Button
    Friend WithEvents greetingLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents usaFlag As PictureBox
End Class
