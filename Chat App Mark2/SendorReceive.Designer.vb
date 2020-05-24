<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SendorReceive
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
        Me.PRec = New System.Windows.Forms.Panel()
        Me.Recpath = New System.Windows.Forms.Button()
        Me.ReceiveBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Receivelbl = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PSend = New System.Windows.Forms.Panel()
        Me.Sendlbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PortTb = New System.Windows.Forms.TextBox()
        Me.IPTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SendBtn = New System.Windows.Forms.Button()
        Me.Sendpath = New System.Windows.Forms.Button()
        Me.SendOp = New System.Windows.Forms.Button()
        Me.ReceiveOp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MMBtn = New System.Windows.Forms.Button()
        Me.MchatBtn = New System.Windows.Forms.Button()
        Me.MTEBtn = New System.Windows.Forms.Button()
        Me.MMGBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PRec.SuspendLayout()
        Me.PSend.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PRec
        '
        Me.PRec.Controls.Add(Me.Recpath)
        Me.PRec.Controls.Add(Me.ReceiveBtn)
        Me.PRec.Controls.Add(Me.Label4)
        Me.PRec.Controls.Add(Me.Receivelbl)
        Me.PRec.Location = New System.Drawing.Point(217, 361)
        Me.PRec.Name = "PRec"
        Me.PRec.Size = New System.Drawing.Size(518, 206)
        Me.PRec.TabIndex = 0
        '
        'Recpath
        '
        Me.Recpath.Location = New System.Drawing.Point(279, 82)
        Me.Recpath.Name = "Recpath"
        Me.Recpath.Size = New System.Drawing.Size(75, 23)
        Me.Recpath.TabIndex = 6
        Me.Recpath.Text = "......"
        Me.Recpath.UseVisualStyleBackColor = True
        '
        'ReceiveBtn
        '
        Me.ReceiveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ReceiveBtn.FlatAppearance.BorderSize = 0
        Me.ReceiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReceiveBtn.Location = New System.Drawing.Point(172, 129)
        Me.ReceiveBtn.Name = "ReceiveBtn"
        Me.ReceiveBtn.Size = New System.Drawing.Size(144, 23)
        Me.ReceiveBtn.TabIndex = 4
        Me.ReceiveBtn.Text = "Start Receiving"
        Me.ReceiveBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(142, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Save Files to :"
        '
        'Receivelbl
        '
        Me.Receivelbl.AutoSize = True
        Me.Receivelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Receivelbl.Location = New System.Drawing.Point(44, 31)
        Me.Receivelbl.Name = "Receivelbl"
        Me.Receivelbl.Size = New System.Drawing.Size(59, 17)
        Me.Receivelbl.TabIndex = 0
        Me.Receivelbl.Text = "Receive"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PSend
        '
        Me.PSend.Controls.Add(Me.Sendlbl)
        Me.PSend.Controls.Add(Me.Label6)
        Me.PSend.Controls.Add(Me.Label5)
        Me.PSend.Controls.Add(Me.PortTb)
        Me.PSend.Controls.Add(Me.IPTB)
        Me.PSend.Controls.Add(Me.Label3)
        Me.PSend.Controls.Add(Me.SendBtn)
        Me.PSend.Controls.Add(Me.Sendpath)
        Me.PSend.Location = New System.Drawing.Point(217, 155)
        Me.PSend.Name = "PSend"
        Me.PSend.Size = New System.Drawing.Size(518, 200)
        Me.PSend.TabIndex = 1
        '
        'Sendlbl
        '
        Me.Sendlbl.AutoSize = True
        Me.Sendlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Sendlbl.Location = New System.Drawing.Point(44, 19)
        Me.Sendlbl.Name = "Sendlbl"
        Me.Sendlbl.Size = New System.Drawing.Size(49, 17)
        Me.Sendlbl.TabIndex = 15
        Me.Sendlbl.Text = "Send :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(208, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Port :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(189, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Send to IP :"
        '
        'PortTb
        '
        Me.PortTb.Location = New System.Drawing.Point(299, 74)
        Me.PortTb.Name = "PortTb"
        Me.PortTb.Size = New System.Drawing.Size(100, 22)
        Me.PortTb.TabIndex = 12
        '
        'IPTB
        '
        Me.IPTB.Location = New System.Drawing.Point(299, 41)
        Me.IPTB.Name = "IPTB"
        Me.IPTB.Size = New System.Drawing.Size(100, 22)
        Me.IPTB.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(131, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Browse File to send :"
        '
        'SendBtn
        '
        Me.SendBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SendBtn.FlatAppearance.BorderSize = 0
        Me.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SendBtn.Location = New System.Drawing.Point(229, 156)
        Me.SendBtn.Name = "SendBtn"
        Me.SendBtn.Size = New System.Drawing.Size(75, 23)
        Me.SendBtn.TabIndex = 9
        Me.SendBtn.Text = "Send"
        Me.SendBtn.UseVisualStyleBackColor = False
        '
        'Sendpath
        '
        Me.Sendpath.Location = New System.Drawing.Point(299, 108)
        Me.Sendpath.Name = "Sendpath"
        Me.Sendpath.Size = New System.Drawing.Size(75, 23)
        Me.Sendpath.TabIndex = 8
        Me.Sendpath.Text = "......"
        Me.Sendpath.UseVisualStyleBackColor = True
        '
        'SendOp
        '
        Me.SendOp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.SendOp.FlatAppearance.BorderSize = 0
        Me.SendOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SendOp.Location = New System.Drawing.Point(412, 83)
        Me.SendOp.Name = "SendOp"
        Me.SendOp.Size = New System.Drawing.Size(75, 23)
        Me.SendOp.TabIndex = 2
        Me.SendOp.Text = "Send"
        Me.SendOp.UseVisualStyleBackColor = False
        '
        'ReceiveOp
        '
        Me.ReceiveOp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ReceiveOp.FlatAppearance.BorderSize = 0
        Me.ReceiveOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReceiveOp.Location = New System.Drawing.Point(411, 112)
        Me.ReceiveOp.Name = "ReceiveOp"
        Me.ReceiveOp.Size = New System.Drawing.Size(75, 23)
        Me.ReceiveOp.TabIndex = 3
        Me.ReceiveOp.Text = "Receive "
        Me.ReceiveOp.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(403, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select an option :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 36)
        Me.Panel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(-1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sending/Receiving File"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MMBtn)
        Me.Panel2.Controls.Add(Me.MchatBtn)
        Me.Panel2.Controls.Add(Me.MTEBtn)
        Me.Panel2.Controls.Add(Me.MMGBtn)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(5, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 530)
        Me.Panel2.TabIndex = 10
        '
        'MMBtn
        '
        Me.MMBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.MMBtn.FlatAppearance.BorderSize = 0
        Me.MMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MMBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MMBtn.Location = New System.Drawing.Point(-3, 329)
        Me.MMBtn.Name = "MMBtn"
        Me.MMBtn.Size = New System.Drawing.Size(228, 38)
        Me.MMBtn.TabIndex = 2
        Me.MMBtn.Text = "Main Menu"
        Me.MMBtn.UseVisualStyleBackColor = False
        '
        'MchatBtn
        '
        Me.MchatBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.MchatBtn.FlatAppearance.BorderSize = 0
        Me.MchatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MchatBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MchatBtn.Location = New System.Drawing.Point(0, 285)
        Me.MchatBtn.Name = "MchatBtn"
        Me.MchatBtn.Size = New System.Drawing.Size(231, 38)
        Me.MchatBtn.TabIndex = 1
        Me.MchatBtn.Text = "Chat"
        Me.MchatBtn.UseVisualStyleBackColor = False
        '
        'MTEBtn
        '
        Me.MTEBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.MTEBtn.FlatAppearance.BorderSize = 0
        Me.MTEBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MTEBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MTEBtn.Location = New System.Drawing.Point(3, 197)
        Me.MTEBtn.Name = "MTEBtn"
        Me.MTEBtn.Size = New System.Drawing.Size(228, 38)
        Me.MTEBtn.TabIndex = 0
        Me.MTEBtn.Text = "Text Editor"
        Me.MTEBtn.UseVisualStyleBackColor = False
        '
        'MMGBtn
        '
        Me.MMGBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.MMGBtn.FlatAppearance.BorderSize = 0
        Me.MMGBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MMGBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MMGBtn.Location = New System.Drawing.Point(0, 241)
        Me.MMGBtn.Name = "MMGBtn"
        Me.MMGBtn.Size = New System.Drawing.Size(231, 38)
        Me.MMGBtn.TabIndex = 0
        Me.MMGBtn.Text = "Maze-Game"
        Me.MMGBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(0, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "File Sharing"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SendorReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(739, 571)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PRec)
        Me.Controls.Add(Me.ReceiveOp)
        Me.Controls.Add(Me.SendOp)
        Me.Controls.Add(Me.PSend)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "SendorReceive"
        Me.Text = "SendorReceive"
        Me.PRec.ResumeLayout(False)
        Me.PRec.PerformLayout()
        Me.PSend.ResumeLayout(False)
        Me.PSend.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PRec As Panel
    Friend WithEvents Receivelbl As Label
    Friend WithEvents Recpath As Button
    Friend WithEvents ReceiveBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PSend As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PortTb As TextBox
    Friend WithEvents IPTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SendBtn As Button
    Friend WithEvents Sendpath As Button
    Friend WithEvents Sendlbl As Label
    Friend WithEvents SendOp As Button
    Friend WithEvents ReceiveOp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents MTEBtn As Button
    Friend WithEvents MMGBtn As Button
    Friend WithEvents MchatBtn As Button
    Friend WithEvents MMBtn As Button
End Class
