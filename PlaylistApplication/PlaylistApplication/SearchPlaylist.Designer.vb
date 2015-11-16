<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPlaylist
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstTrack = New System.Windows.Forms.ListBox()
        Me.btnPlay = New System.Windows.Forms.Button()
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
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Playlist:"
        '
        'txtPlaylist
        '
        Me.txtPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaylist.Location = New System.Drawing.Point(139, 17)
        Me.txtPlaylist.Name = "txtPlaylist"
        Me.txtPlaylist.Size = New System.Drawing.Size(253, 23)
        Me.txtPlaylist.TabIndex = 2
        '
        'btnPlaylist
        '
        Me.btnPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaylist.Location = New System.Drawing.Point(398, 12)
        Me.btnPlaylist.Name = "btnPlaylist"
        Me.btnPlaylist.Size = New System.Drawing.Size(88, 33)
        Me.btnPlaylist.TabIndex = 3
        Me.btnPlaylist.Text = "Search"
        Me.btnPlaylist.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Playlist"
        '
        'lstPlaylistlst
        '
        Me.lstPlaylistlst.FormattingEnabled = True
        Me.lstPlaylistlst.Location = New System.Drawing.Point(15, 78)
        Me.lstPlaylistlst.Name = "lstPlaylistlst"
        Me.lstPlaylistlst.Size = New System.Drawing.Size(463, 160)
        Me.lstPlaylistlst.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Track"
        '
        'lstTrack
        '
        Me.lstTrack.FormattingEnabled = True
        Me.lstTrack.Location = New System.Drawing.Point(15, 271)
        Me.lstTrack.Name = "lstTrack"
        Me.lstTrack.Size = New System.Drawing.Size(463, 160)
        Me.lstTrack.TabIndex = 9
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(15, 448)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(88, 33)
        Me.btnPlay.TabIndex = 10
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'SearchPlaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(498, 493)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lstTrack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstPlaylistlst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPlaylist)
        Me.Controls.Add(Me.txtPlaylist)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "SearchPlaylist"
        Me.Text = "Search Playlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPlaylist As TextBox
    Friend WithEvents btnPlaylist As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lstPlaylistlst As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstTrack As ListBox
    Friend WithEvents btnPlay As Button
End Class
