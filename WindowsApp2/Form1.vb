
Imports System.ComponentModel
Imports System.Globalization
Imports System.Threading

Public Class Form1
    Dim usaInfo As CultureInfo = New CultureInfo("en-US")
    Dim belarusInfo As CultureInfo = New CultureInfo("be-BY")


    Private Sub greetingLabel_Click(sender As Object, e As EventArgs) Handles greetingLabel.Click

    End Sub

    Private Sub usaPictureBox_Click(sender As Object, e As EventArgs) Handles usaPictureBox.Click
        Thread.CurrentThread.CurrentUICulture = usaInfo
        ReInit()
    End Sub

    Private Sub belarusPictureBox_Click(sender As Object, e As EventArgs) Handles belarusPictureBox.Click
        Thread.CurrentThread.CurrentUICulture = belarusInfo
        ReInit()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        End
    End Sub

    Private Sub ReInit()
        Dim myResources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.exitButton.Text = myResources.GetString("exitButton.Text")
        Me.greetingLabel.Text = myResources.GetString("greetingLabel.Text")
    End Sub

End Class
