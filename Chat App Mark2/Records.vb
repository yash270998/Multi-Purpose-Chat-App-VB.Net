Imports System.Data.SqlClient

Public Class Records
    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Dim total As Int32
        total = Level1.score + Level2.score + Level3.score
        Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

        con.Open()
        Dim cmd As New SqlCommand("Insert into Records values('" & TextBox1.Text & "'," & Level1.score & "," & Level2.score & "," & Level3.score & "," & total & ")", con)
        cmd.ExecuteNonQuery()

        con.Close()

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

    Private Sub MMBtn_Click(sender As Object, e As EventArgs) Handles MMBtn.Click
        Dim mm As New MainMenu
        Me.Hide()
        mm.Show()
    End Sub
End Class