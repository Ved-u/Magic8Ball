Public Class Form1

    Dim responce(20) As String
    Public ReadOnly Property appPath() As String
        Get
            Dim s As String = Application.StartupPath
            If s.Substring(s.Length - 1) <> "\" Then s &= "\"
            Return s
        End Get
    End Property
    Private Sub btnMagic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMagic.Click
        If txtQuestion.Text = "" Then
            Beep()
            Exit Sub
        End If
        If Len(txtQuestion.Text) < 4 Then
            Exit Sub
        End If
        Dim Speech
        Speech = CreateObject("sapi.spvoice")

        responce(0) = "As I see it, yes"
        responce(1) = "It is certain"
        responce(2) = "It is decidedly so"
        responce(3) = "Most likely"
        responce(4) = "Outlook good"
        responce(5) = "Signs point to yes"
        responce(6) = "Without a doubt"
        responce(7) = "Yes"
        responce(8) = "Yes - definitely"
        responce(9) = "You may rely on it"
        responce(10) = "Reply hazy, try again"
        responce(11) = "Ask again later"
        responce(12) = "Better not tell you now"
        responce(13) = "Cannot predict now"
        responce(14) = "Concentrate and ask again"
        responce(15) = "Don't count on it"
        responce(16) = "My reply is no"
        responce(17) = "My sources say no"
        responce(18) = "Outlook not so good"
        responce(19) = "Very doubtful"
        Dim generator As New Random
        Dim randomValue As Integer
        randomValue = generator.Next(1, 20)

        If randomValue = 1 Then
            PictureBox1.BackgroundImage = My.Resources.ball1
        End If
        If randomValue = 2 Then
            PictureBox1.BackgroundImage = My.Resources.ball2
        End If
        If randomValue = 3 Then
            PictureBox1.BackgroundImage = My.Resources.ball3
        End If
        If randomValue = 4 Then
            PictureBox1.BackgroundImage = My.Resources.ball4
        End If
        If randomValue = 5 Then
            PictureBox1.BackgroundImage = My.Resources.ball5
        End If
        If randomValue = 6 Then
            PictureBox1.BackgroundImage = My.Resources.ball6
        End If
        If randomValue = 7 Then
            PictureBox1.BackgroundImage = My.Resources.ball7
        End If
        If randomValue = 8 Then
            PictureBox1.BackgroundImage = My.Resources.ball8
        End If
        If randomValue = 9 Then
            PictureBox1.BackgroundImage = My.Resources.ball9
        End If
        If randomValue = 10 Then
            PictureBox1.BackgroundImage = My.Resources.ball10
        End If
        If randomValue = 11 Then
            PictureBox1.BackgroundImage = My.Resources.ball11
        End If
        If randomValue = 12 Then
            PictureBox1.BackgroundImage = My.Resources.ball12
        End If
        If randomValue = 13 Then
            PictureBox1.BackgroundImage = My.Resources.ball13
        End If
        If randomValue = 14 Then
            PictureBox1.BackgroundImage = My.Resources.ball14
        End If
        If randomValue = 15 Then
            PictureBox1.BackgroundImage = My.Resources.ball15
        End If
        If randomValue = 16 Then
            PictureBox1.BackgroundImage = My.Resources.ball16
        End If
        If randomValue = 17 Then
            PictureBox1.BackgroundImage = My.Resources.ball17
        End If
        If randomValue = 18 Then
            PictureBox1.BackgroundImage = My.Resources.ball18
        End If
        If randomValue = 19 Then
            PictureBox1.BackgroundImage = My.Resources.ball19
        End If
        If randomValue = 20 Then
            PictureBox1.BackgroundImage = My.Resources.ball20
        End If
        Speech.Speak(responce(randomValue - 1))
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim responce As String
        responce = MessageBox.Show("Are you sure..?", "Confirm choice", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If responce = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        PictureBox1.BackgroundImage = My.Resources._8_Ball_picture_3
        txtQuestion.Clear()
    End Sub
End Class
