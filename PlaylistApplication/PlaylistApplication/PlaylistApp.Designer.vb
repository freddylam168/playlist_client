<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlaylistApp
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
        Me.btnAllPlaylist = New System.Windows.Forms.Button()
        Me.lstPlaylistlst = New System.Windows.Forms.ListBox()
        Me.lstTrack = New System.Windows.Forms.ListBox()
        Me.btnAddPlaylist = New System.Windows.Forms.Button()
        Me.btnEditPlaylist = New System.Windows.Forms.Button()
        Me.btnSearchUsername = New System.Windows.Forms.Button()
        Me.btnSearchPlaylist = New System.Windows.Forms.Button()
        Me.btnSearchTrack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRank = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAllPlaylist
        '
        Me.btnAllPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllPlaylist.Location = New System.Drawing.Point(13, 13)
        Me.btnAllPlaylist.Name = "btnAllPlaylist"
        Me.btnAllPlaylist.Size = New System.Drawing.Size(88, 48)
        Me.btnAllPlaylist.TabIndex = 0
        Me.btnAllPlaylist.Text = "Get All Playlist"
        Me.btnAllPlaylist.UseVisualStyleBackColor = True
        '
        'lstPlaylistlst
        '
        Me.lstPlaylistlst.FormattingEnabled = True
        Me.lstPlaylistlst.Location = New System.Drawing.Point(12, 95)
        Me.lstPlaylistlst.Name = "lstPlaylistlst"
        Me.lstPlaylistlst.Size = New System.Drawing.Size(463, 160)
        Me.lstPlaylistlst.TabIndex = 1
        '
        'lstTrack
        '
        Me.lstTrack.FormattingEnabled = True
        Me.lstTrack.Location = New System.Drawing.Point(12, 285)
        Me.lstTrack.Name = "lstTrack"
        Me.lstTrack.Size = New System.Drawing.Size(463, 173)
        Me.lstTrack.TabIndex = 2
        '
        'btnAddPlaylist
        '
        Me.btnAddPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPlaylist.Location = New System.Drawing.Point(130, 464)
        Me.btnAddPlaylist.Name = "btnAddPlaylist"
        Me.btnAddPlaylist.Size = New System.Drawing.Size(88, 46)
        Me.btnAddPlaylist.TabIndex = 3
        Me.btnAddPlaylist.Text = "Add Playlist"
        Me.btnAddPlaylist.UseVisualStyleBackColor = True
        '
        'btnEditPlaylist
        '
        Me.btnEditPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPlaylist.Location = New System.Drawing.Point(242, 464)
        Me.btnEditPlaylist.Name = "btnEditPlaylist"
        Me.btnEditPlaylist.Size = New System.Drawing.Size(88, 46)
        Me.btnEditPlaylist.TabIndex = 4
        Me.btnEditPlaylist.Text = "Edit Playlist"
        Me.btnEditPlaylist.UseVisualStyleBackColor = True
        '
        'btnSearchUsername
        '
        Me.btnSearchUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchUsername.Location = New System.Drawing.Point(130, 13)
        Me.btnSearchUsername.Name = "btnSearchUsername"
        Me.btnSearchUsername.Size = New System.Drawing.Size(88, 48)
        Me.btnSearchUsername.TabIndex = 5
        Me.btnSearchUsername.Text = "Search by Username"
        Me.btnSearchUsername.UseVisualStyleBackColor = True
        '
        'btnSearchPlaylist
        '
        Me.btnSearchPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPlaylist.Location = New System.Drawing.Point(251, 13)
        Me.btnSearchPlaylist.Name = "btnSearchPlaylist"
        Me.btnSearchPlaylist.Size = New System.Drawing.Size(88, 48)
        Me.btnSearchPlaylist.TabIndex = 6
        Me.btnSearchPlaylist.Text = "Search by Playlist Name"
        Me.btnSearchPlaylist.UseVisualStyleBackColor = True
        '
        'btnSearchTrack
        '
        Me.btnSearchTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchTrack.Location = New System.Drawing.Point(367, 13)
        Me.btnSearchTrack.Name = "btnSearchTrack"
        Me.btnSearchTrack.Size = New System.Drawing.Size(88, 48)
        Me.btnSearchTrack.TabIndex = 7
        Me.btnSearchTrack.Text = "Search by Track Name"
        Me.btnSearchTrack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Playlist"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Track"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 464)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 46)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Play"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(402, 464)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(73, 46)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Remove"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRank
        '
        Me.btnRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRank.ForeColor = System.Drawing.Color.Blue
        Me.btnRank.Location = New System.Drawing.Point(336, 464)
        Me.btnRank.Name = "btnRank"
        Me.btnRank.Size = New System.Drawing.Size(60, 46)
        Me.btnRank.TabIndex = 12
        Me.btnRank.Text = "Rate"
        Me.btnRank.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(3, 519)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Designed by Angelo and Freddy"
        '
        'PlaylistApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(498, 535)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRank)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearchTrack)
        Me.Controls.Add(Me.btnSearchPlaylist)
        Me.Controls.Add(Me.btnSearchUsername)
        Me.Controls.Add(Me.btnEditPlaylist)
        Me.Controls.Add(Me.btnAddPlaylist)
        Me.Controls.Add(Me.lstTrack)
        Me.Controls.Add(Me.lstPlaylistlst)
        Me.Controls.Add(Me.btnAllPlaylist)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(514, 573)
        Me.MinimumSize = New System.Drawing.Size(514, 573)
        Me.Name = "PlaylistApp"
        Me.Text = "PlaylistApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAllPlaylist As Button
    Friend WithEvents lstPlaylistlst As ListBox
    Friend WithEvents lstTrack As ListBox
    Friend WithEvents btnAddPlaylist As Button
    Friend WithEvents btnEditPlaylist As Button
    Friend WithEvents btnSearchUsername As Button
    Friend WithEvents btnSearchPlaylist As Button
    Friend WithEvents btnSearchTrack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRank As Button
    Friend WithEvents Label4 As Label
End Class
