Public Class MazeMenu
    Private Sub MazeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Hide()
    End Sub

    Private Sub InstBtn_Click(sender As Object, e As EventArgs) Handles InstBtn.Click
        RichTextBox1.Show()
    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        Dim l1 As New Level1
        Me.Hide()
        l1.Show()
    End Sub
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
End Class