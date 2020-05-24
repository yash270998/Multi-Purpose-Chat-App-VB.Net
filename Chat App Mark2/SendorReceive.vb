Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Threading
Public Class SendorReceive
    Public ServerIP As IPAddress = IPAddress.Parse("192.168.43.43")
    Public ServerPort As Integer = 64555
    Public Server As TcpListener
    Private Sub SendorReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PRec.Hide()
        PSend.Hide()
    End Sub
    Private Sub SendOp_Click(sender As Object, e As EventArgs) Handles SendOp.Click
        PSend.Show()
        PRec.Hide()
    End Sub

    Private Sub ReceiveOp_Click(sender As Object, e As EventArgs) Handles ReceiveOp.Click
        PSend.Hide()
        PRec.Show()

    End Sub

#Region "Sending"
    Public Delegate Sub sending(ByVal filename As String)



    Private Sub Sendpath_Click(sender As Object, e As EventArgs) Handles Sendpath.Click
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub SendBtn_Click(sender As Object, e As EventArgs) Handles SendBtn.Click
        Dim d As New sending(AddressOf sends)
        d.BeginInvoke(OpenFileDialog1.FileName, Nothing, Nothing)
    End Sub

    Public Sub sends(ByVal fullfilename As String)

        Dim RecIp As String
        RecIp = IPTB.Text
        Dim Recport As Int32
        Recport = PortTb.Text

        'sends filename, filelength, filebytes
        Dim info As New IO.FileInfo(fullfilename)
        Dim client As New TcpClient
        client.Connect(RecIp, Recport)
        'writes a String and a Long with binarywriter (wrapping networkstream)
        Dim bw As New IO.BinaryWriter(client.GetStream)
        bw.Write(info.Name)
        bw.Write(info.Length)
        'using filestream to read file, writes this directly to networkstream
        Using fs As New IO.FileStream(fullfilename, IO.FileMode.Open, IO.FileAccess.Read)
            Dim buffer(8092) As Byte, reads As Integer = -1
            Do Until reads = 0
                reads = fs.Read(buffer, 0, buffer.Length)
                client.GetStream.Write(buffer, 0, reads)
            Loop
        End Using
        bw.Close()

    End Sub

#End Region
#Region "Receiving"
    Private Sub ReceiveBtn_Click(sender As Object, e As EventArgs) Handles ReceiveBtn.Click
        Server = New TcpListener(ServerIP, ServerPort)
        Server.Start()
        Do
            If Server.Pending Then Server.BeginAcceptTcpClient(AddressOf accepting, Server)
            Threading.Thread.Sleep(1000)
        Loop
    End Sub

    Sub accepting(ByVal ar As IAsyncResult)

        Dim path As String = IO.Path.GetDirectoryName(FolderBrowserDialog1.SelectedPath)
        'receives filename, filelength, filebytes
        Dim listener As TcpListener = CType(ar.AsyncState, TcpListener)
        Dim clientSocket As TcpClient = listener.EndAcceptTcpClient(ar)
        Dim filename, filepath As String, filelen As Long
        'using binaryreader (wrapped networkstream) to read a String and a Long
        Dim br As New IO.BinaryReader(clientSocket.GetStream)
        filename = br.ReadString
        filelen = br.ReadInt64
        'filepath = IO.Path.Combine(Application.StartupPath, filename)

        filepath = IO.Path.Combine(path, filename)
        Dim buffer(8092) As Byte, readstotal As Long = 0
        Dim reads As Integer = -1
        'using filestream to write read filebytes directly from networkstream
        Using fs As New IO.FileStream(filepath, IO.FileMode.Create, IO.FileAccess.Write)
            Do Until readstotal = filelen
                reads = clientSocket.GetStream.Read(buffer, 0, buffer.Length)
                fs.Write(buffer, 0, reads)
                readstotal += reads
            Loop
        End Using
        MsgBox("Received: " & filename)
        br.Close()
        clientSocket.Close()

    End Sub

    Private Sub Recpath_Click(sender As Object, e As EventArgs) Handles Recpath.Click
        FolderBrowserDialog1.ShowDialog()

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

    Private Sub MMBtn_Click_1(sender As Object, e As EventArgs) Handles MMBtn.Click
        Dim mm As New MainMenu
        Me.Hide()
        mm.Show()


    End Sub





#End Region


End Class