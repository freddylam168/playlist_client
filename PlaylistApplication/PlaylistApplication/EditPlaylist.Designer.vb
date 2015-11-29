<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPlaylist
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPlaylist = New System.Windows.Forms.TextBox()
        Me.btnPlaylist = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstPlaylistlst = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdatePlaylist = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstTrack = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btnUpdateTrack = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Playlist:"
        '
        'txtPlaylist
        '
        Me.txtPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaylist.Location = New System.Drawing.Point(164, 17)
        Me.txtPlaylist.Name = "txtPlaylist"
        Me.txtPlaylist.Size = New System.Drawing.Size(228, 23)
        Me.txtPlaylist.TabIndex = 3
        '
        'btnPlaylist
        '
        Me.btnPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaylist.Location = New System.Drawing.Point(398, 12)
        Me.btnPlaylist.Name = "btnPlaylist"
        Me.btnPlaylist.Size = New System.Drawing.Size(88, 33)
        Me.btnPlaylist.TabIndex = 4
        Me.btnPlaylist.Text = "Search"
        Me.btnPlaylist.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Playlist"
        '
        'lstPlaylistlst
        '
        Me.lstPlaylistlst.FormattingEnabled = True
        Me.lstPlaylistlst.Location = New System.Drawing.Point(15, 68)
        Me.lstPlaylistlst.Name = "lstPlaylistlst"
        Me.lstPlaylistlst.Size = New System.Drawing.Size(463, 160)
        Me.lstPlaylistlst.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(164, 240)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(228, 23)
        Me.TextBox1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "New Playlist Name:"
        '
        'btnUpdatePlaylist
        '
        Me.btnUpdatePlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePlaylist.Location = New System.Drawing.Point(398, 234)
        Me.btnUpdatePlaylist.Name = "btnUpdatePlaylist"
        Me.btnUpdatePlaylist.Size = New System.Drawing.Size(88, 33)
        Me.btnUpdatePlaylist.TabIndex = 11
        Me.btnUpdatePlaylist.Text = "Update"
        Me.btnUpdatePlaylist.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Track"
        '
        'lstTrack
        '
        Me.lstTrack.FormattingEnabled = True
        Me.lstTrack.Location = New System.Drawing.Point(15, 297)
        Me.lstTrack.Name = "lstTrack"
        Me.lstTrack.Size = New System.Drawing.Size(463, 160)
        Me.lstTrack.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 482)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "New Track ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 511)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "New Title:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 541)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "New URL:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 571)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "New Duration:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(164, 476)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(228, 23)
        Me.TextBox2.TabIndex = 18
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(164, 505)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(228, 23)
        Me.TextBox3.TabIndex = 19
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(164, 535)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(228, 23)
        Me.TextBox4.TabIndex = 20
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(164, 565)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(228, 23)
        Me.TextBox5.TabIndex = 21
        '
        'btnUpdateTrack
        '
        Me.btnUpdateTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateTrack.Location = New System.Drawing.Point(398, 555)
        Me.btnUpdateTrack.Name = "btnUpdateTrack"
        Me.btnUpdateTrack.Size = New System.Drawing.Size(88, 33)
        Me.btnUpdateTrack.TabIndex = 22
        Me.btnUpdateTrack.Text = "Update"
        Me.btnUpdateTrack.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label9.Location = New System.Drawing.Point(3, 597)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Designed by Angelo and Freddy"
        '
        'EditPlaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(498, 613)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnUpdateTrack)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstTrack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnUpdatePlaylist)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lstPlaylistlst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPlaylist)
        Me.Controls.Add(Me.txtPlaylist)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(514, 651)
        Me.MinimumSize = New System.Drawing.Size(514, 651)
        Me.Name = "EditPlaylist"
        Me.Text = "Edit Playlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPlaylist As TextBox
    Friend WithEvents btnPlaylist As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lstPlaylistlst As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdatePlaylist As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lstTrack As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnUpdateTrack As Button
    Friend WithEvents Label9 As Label
End Class
