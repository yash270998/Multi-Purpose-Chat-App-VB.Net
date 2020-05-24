Public Class MainMenu
    Private Sub MFSBtn_Click(sender As Object, e As EventArgs) Handles MFSBtn.Click
        Dim fs As New SendorReceive

        fs.Show()
        Me.Hide()
    End Sub

    Private Sub MTEBtn_Click(sender As Object, e As EventArgs) Handles MTEBtn.Click
        Dim te As New TextEditor
        Me.Hide()
        te.Show()
    End Sub

    Private Sub MMGBtn_Click(sender As Object, e As EventArgs) Handles MMGBtn.Click
        Dim mm As New MazeMenu
        Me.Hide()
        mm.Show()
    End Sub

    Private Sub MchatBtn_Click(sender As Object, e As EventArgs) Handles MchatBtn.Click
        Dim ch As New Chat
        Me.Hide()
        ch.Show()
    End Sub
End Class