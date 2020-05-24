<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chat))
        Me.connectbtn = New System.Windows.Forms.Button()
        Me.MessageTB = New System.Windows.Forms.TextBox()
        Me.Msglbl = New System.Windows.Forms.Label()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.ChatBox = New System.Windows.Forms.RichTextBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.SendBtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MMBtn = New System.Windows.Forms.Button()
        Me.MFSBtn = New System.Windows.Forms.Button()
        Me.MMGBtn = New System.Windows.Forms.Button()
        Me.MTEBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'connectbtn
        '
        Me.connectbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.connectbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.connectbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.connectbtn.Location = New System.Drawing.Point(378, 135)
        Me.connectbtn.Name = "connectbtn"
        Me.connectbtn.Size = New System.Drawing.Size(109, 27)
        Me.connectbtn.TabIndex = 0
        Me.connectbtn.Text = "Connect"
        Me.connectbtn.UseVisualStyleBackColor = False
        '
        'MessageTB
        '
        Me.MessageTB.Location = New System.Drawing.Point(428, 409)
        Me.MessageTB.Name = "MessageTB"
        Me.MessageTB.Size = New System.Drawing.Size(171, 22)
        Me.MessageTB.TabIndex = 1
        '
        'Msglbl
        '
        Me.Msglbl.AutoSize = True
        Me.Msglbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Msglbl.Location = New System.Drawing.Point(279, 412)
        Me.Msglbl.Name = "Msglbl"
        Me.Msglbl.Size = New System.Drawing.Size(143, 17)
        Me.Msglbl.TabIndex = 2
        Me.Msglbl.Text = "Enter your Message :"
        '
        'NameTB
        '
        Me.NameTB.Location = New System.Drawing.Point(428, 353)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(100, 22)
        Me.NameTB.TabIndex = 3
        '
        'Namelbl
        '
        Me.Namelbl.AutoSize = True
        Me.Namelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Namelbl.Location = New System.Drawing.Point(283, 358)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(121, 17)
        Me.Namelbl.TabIndex = 4
        Me.Namelbl.Text = "Enter your name :"
        '
        'ChatBox
        '
        Me.ChatBox.Location = New System.Drawing.Point(304, 184)
        Me.ChatBox.Name = "ChatBox"
        Me.ChatBox.Size = New System.Drawing.Size(254, 111)
        Me.ChatBox.TabIndex = 5
        Me.ChatBox.Text = ""
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(539, 184)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(19, 111)
        Me.VScrollBar1.TabIndex = 6
        '
        'SendBtn
        '
        Me.SendBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SendBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SendBtn.Location = New System.Drawing.Point(408, 466)
        Me.SendBtn.Name = "SendBtn"
        Me.SendBtn.Size = New System.Drawing.Size(109, 28)
        Me.SendBtn.TabIndex = 7
        Me.SendBtn.Text = "Send"
        Me.SendBtn.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 36)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Peer to Peer Chat App"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MMBtn)
        Me.Panel2.Controls.Add(Me.MFSBtn)
        Me.Panel2.Controls.Add(Me.MMGBtn)
        Me.Panel2.Controls.Add(Me.MTEBtn)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(2, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 500)
        Me.Panel2.TabIndex = 9
        '
        'MMBtn
        '
        Me.MMBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.MMBtn.FlatAppearance.BorderSize = 0
        Me.MMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MMBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MMBtn.Location = New System.Drawing.Point(0, 331)
        Me.MMBtn.Name = "MMBtn"
        Me.MMBtn.Size = New System.Drawing.Size(231, 38)
        Me.MMBtn.TabIndex = 2
        Me.MMBtn.Text = "Main Menu"
        Me.MMBtn.UseVisualStyleBackColor = False
        '
        'MFSBtn
        '
        Me.MFSBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.MFSBtn.FlatAppearance.BorderSize = 0
        Me.MFSBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MFSBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MFSBtn.Location = New System.Drawing.Point(3, 287)
        Me.MFSBtn.Name = "MFSBtn"
        Me.MFSBtn.Size = New System.Drawing.Size(231, 38)
        Me.MFSBtn.TabIndex = 1
        Me.MFSBtn.Text = "File Sharing"
        Me.MFSBtn.UseVisualStyleBackColor = False
        '
        'MMGBtn
        '
        Me.MMGBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.MMGBtn.FlatAppearance.BorderSize = 0
        Me.MMGBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MMGBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MMGBtn.Location = New System.Drawing.Point(0, 243)
        Me.MMGBtn.Name = "MMGBtn"
        Me.MMGBtn.Size = New System.Drawing.Size(231, 38)
        Me.MMGBtn.TabIndex = 0
        Me.MMGBtn.Text = "Maze-Game"
        Me.MMGBtn.UseVisualStyleBackColor = False
        '
        'MTEBtn
        '
        Me.MTEBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.MTEBtn.FlatAppearance.BorderSize = 0
        Me.MTEBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MTEBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MTEBtn.Location = New System.Drawing.Point(7, 199)
        Me.MTEBtn.Name = "MTEBtn"
        Me.MTEBtn.Size = New System.Drawing.Size(221, 38)
        Me.MTEBtn.TabIndex = 0
        Me.MTEBtn.Text = "Text Editor"
        Me.MTEBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(-3, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Chat"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(686, 538)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SendBtn)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.ChatBox)
        Me.Controls.Add(Me.Namelbl)
        Me.Controls.Add(Me.NameTB)
        Me.Controls.Add(Me.Msglbl)
        Me.Controls.Add(Me.MessageTB)
        Me.Controls.Add(Me.connectbtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Chat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents connectbtn As Button
    Friend WithEvents MessageTB As TextBox
    Friend WithEvents Msglbl As Label
    Friend WithEvents NameTB As TextBox
    Friend WithEvents Namelbl As Label
    Friend WithEvents ChatBox As RichTextBox
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents SendBtn As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MTEBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MMGBtn As Button
    Friend WithEvents MFSBtn As Button
    Friend WithEvents MMBtn As Button
End Class
