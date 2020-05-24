Public Class Level1
    Public score As Integer = 1000


    Private Sub MFSBtn_Click(sender As Object, e As EventArgs) Handles MFSBtn.Click
        Dim fs As New SendorReceive
        Me.Hide()
        fs.Show()

    End Sub

    Private Sub MTEBtn_Click(sender As Object, e As EventArgs) Handles MTEBtn.Click
        Dim te As New TextEditor
        Me.Hide()
        te.Show()
    End Sub

    Private Sub MchatBtn_Click(sender As Object, e As EventArgs) Handles MchatBtn.Click
        Dim ch As New Chat
        Me.Hide()
        ch.Show()
    End Sub

    Private Sub MMBtn_Click(sender As Object, e As EventArgs) Handles MMBtn.Click
        Dim mm As New MainMenu
        Me.Hide()
        mm.Show()
    End Sub
    Private Sub Mazemark2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W Then
            PB1.Top = PB1.Top - 3
        End If

        If e.KeyCode = Keys.S Then
            PB1.Top = PB1.Top + 3
        End If

        If e.KeyCode = Keys.A Then
            PB1.Left = PB1.Left - 3
        End If

        If e.KeyCode = Keys.D Then
            PB1.Left = PB1.Left + 3
        End If


        For i As Integer = 1 To 49
            Dim lbl = Controls("Label" & i.ToString())
            If PB1.Bounds.IntersectsWith(lbl.Bounds) Then
                PB1.Top = 75
                PB1.Left = 440

                score = score - 50
            End If
        Next

        If PB1.Bounds.IntersectsWith(Finish.Bounds) Then
            MsgBox("You score is " + " " & score)
            Timer1.Stop()
            Dim L2 As New Level2
            Me.Hide()
            L2.Show()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        score = score - 10
        Scorelbl.Text = score
        If score < 0 Then
            Timer1.Stop()
            MsgBox("You Lost!")
        End If
    End Sub

    Private Sub Mazemark2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        MsgBox("The Game is commencing ")


        Timer1.Start()
        Scorelbl.Text = 1000
    End Sub


End Class