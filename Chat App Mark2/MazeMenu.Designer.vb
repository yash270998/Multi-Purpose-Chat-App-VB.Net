<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MazeMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MazeMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MMBtn = New System.Windows.Forms.Button()
        Me.MFSBtn = New System.Windows.Forms.Button()
        Me.MchatBtn = New System.Windows.Forms.Button()
        Me.MTEBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.InstBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(727, 36)
        Me.Panel1.TabIndex = 9
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
        Me.Label1.Text = "The Maze Game"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MMBtn)
        Me.Panel2.Controls.Add(Me.MFSBtn)
        Me.Panel2.Controls.Add(Me.MchatBtn)
        Me.Panel2.Controls.Add(Me.MTEBtn)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(6, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 500)
        Me.Panel2.TabIndex = 10
        '
        'MMBtn
        '
        Me.MMBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.MMBtn.FlatAppearance.BorderSize = 0
        Me.MMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MMBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MMBtn.Location = New System.Drawing.Point(3, 331)
        Me.MMBtn.Name = "MMBtn"
        Me.MMBtn.Size = New System.Drawing.Size(228, 38)
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
        Me.MFSBtn.Size = New System.Drawing.Size(228, 38)
        Me.MFSBtn.TabIndex = 1
        Me.MFSBtn.Text = "File Sharing"
        Me.MFSBtn.UseVisualStyleBackColor = False
        '
        'MchatBtn
        '
        Me.MchatBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.MchatBtn.FlatAppearance.BorderSize = 0
        Me.MchatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MchatBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MchatBtn.Location = New System.Drawing.Point(0, 243)
        Me.MchatBtn.Name = "MchatBtn"
        Me.MchatBtn.Size = New System.Drawing.Size(231, 38)
        Me.MchatBtn.TabIndex = 0
        Me.MchatBtn.Text = "Chat"
        Me.MchatBtn.UseVisualStyleBackColor = False
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
        Me.Button1.Text = "Maze-Menu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StartBtn
        '
        Me.StartBtn.AutoSize = True
        Me.StartBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.StartBtn.FlatAppearance.BorderSize = 0
        Me.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.StartBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StartBtn.Location = New System.Drawing.Point(428, 147)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(96, 30)
        Me.StartBtn.TabIndex = 11
        Me.StartBtn.Text = "Start Game"
        Me.StartBtn.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.RichTextBox1.Location = New System.Drawing.Point(299, 283)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(380, 224)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'InstBtn
        '
        Me.InstBtn.AutoSize = True
        Me.InstBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.InstBtn.FlatAppearance.BorderSize = 0
        Me.InstBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InstBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.InstBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InstBtn.Location = New System.Drawing.Point(428, 203)
        Me.InstBtn.Name = "InstBtn"
        Me.InstBtn.Size = New System.Drawing.Size(96, 30)
        Me.InstBtn.TabIndex = 13
        Me.InstBtn.Text = "Instructions"
        Me.InstBtn.UseVisualStyleBackColor = False
        '
        'MazeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(729, 541)
        Me.Controls.Add(Me.InstBtn)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MazeMenu"
        Me.Text = "MazeMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MMBtn As Button
    Friend WithEvents MFSBtn As Button
    Friend WithEvents MchatBtn As Button
    Friend WithEvents MTEBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents StartBtn As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents InstBtn As Button
End Class
