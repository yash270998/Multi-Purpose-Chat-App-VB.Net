Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Threading



Public Class Chat
    Private server As TCPServer
    Private Client As TCPControl

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
    Private Sub MMBtn_Click(sender As Object, e As EventArgs) Handles MMBtn.Click
        Dim mm As New MainMenu
        Me.Hide()
        mm.Show()
    End Sub
    Private Sub MMGBtn_Click(sender As Object, e As EventArgs) Handles MMGBtn.Click
        Dim mg As New MazeMenu
        Me.Hide()
        mg.Show()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        server.IsListening = False
        If Client.Client.Connected = True Then
            Client.DataStream.Close()
            Client.Client.Close()
        End If

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        server = New TCPServer

        ChatBox.Text = "Server Started " & vbCrLf
        AddHandler server.MessageReceived, AddressOf OnlineReceived

    End Sub

    ' ALLOW THREAD TO COMMUNICATE WITH FORM CONTROL
    Private Delegate Sub UpdateTextDelegate(TB As RichTextBox, txt As String)

    ' UPDATE TEXTBOX
    Private Sub UpdateText(TB As RichTextBox, txt As String)
        If TB.InvokeRequired Then
            TB.Invoke(New UpdateTextDelegate(AddressOf UpdateText), New Object() {TB, txt})
        Else
            If txt IsNot Nothing Then TB.AppendText(txt & vbCrLf)
        End If
    End Sub

    Private Sub OnlineReceived(sender As TCPServer, data As String)
        UpdateText(ChatBox, data)
    End Sub

    Private Sub connectbtn_Click(sender As Object, e As EventArgs) Handles connectbtn.Click
        Client = New TCPControl("192.168.43.179", 64554)

        If Client.Client.Connected Then connectbtn.Text = "Connected"
    End Sub

    Private Sub SendBtn_Click(sender As Object, e As EventArgs) Handles SendBtn.Click
        SendMessage()
        ChatBox.AppendText(NameTB.Text + " : " + MessageTB.Text + vbCrLf)

        MessageTB.Clear()
        MessageTB.Focus()
    End Sub

    Private Sub SendMessage()
        If Client.Client.Connected = True Then Client.Send(NameTB.Text + " : " + MessageTB.Text)
    End Sub
    Private Sub txtMessage_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles MessageTB.KeyDown
        If e.KeyCode = Keys.Enter Then SendMessage()
        If e.KeyCode = Keys.Enter Then ChatBox.AppendText(NameTB.Text + " : " + MessageTB.Text + vbCrLf)
    End Sub




End Class

Public Class TCPServer
    Public Event MessageReceived(sender As TCPServer, Data As String)

    ' SERVER CONFIG
    Public ServerIP As IPAddress = IPAddress.Parse("192.168.43.43")
    Public ServerPort As Integer = 64555
    Public Server As TcpListener

    Private CommThread As Thread

    Public IsListening As Boolean = True

    ' CLIENTS
    Private Client As TcpClient
    Private ClientData As StreamReader

    Public Sub New()
        Server = New TcpListener(ServerIP, ServerPort)
        Server.Start()

        CommThread = New Thread(New ThreadStart(AddressOf Listening))
        CommThread.Start()



    End Sub



    Private Sub Listening()
        ' CREATE LISTENER LOOP
        Do Until IsListening = False
            ' ACCEPT INCOMING CONNECTIONS
            If Server.Pending = True Then
                Client = Server.AcceptTcpClient
                ClientData = New StreamReader(Client.GetStream)
            End If

            ' RAISE EVENT FOR INCOMING MESSAGES
            Try
                RaiseEvent MessageReceived(Me, ClientData.ReadLine)

            Catch ex As Exception

            End Try

            ' REDUCE CPU USAGE
            'Thread.Sleep(100)
        Loop
    End Sub
End Class

' Client Class

Public Class TCPControl
    Public Client As TcpClient
    Public DataStream As StreamWriter


    Public Sub New(Host As String, Port As Integer)
        ' CLIENT
        Client = New TcpClient(Host, Port)
        DataStream = New StreamWriter(Client.GetStream)

    End Sub



    Public Sub Send(Data As String)
        DataStream.Write(Data & vbCrLf)
        DataStream.Flush()

    End Sub
End Class
