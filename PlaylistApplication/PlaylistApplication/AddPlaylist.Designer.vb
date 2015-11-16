<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPlaylist
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddPlaylist = New System.Windows.Forms.TextBox()
        Me.txtAddUsername = New System.Windows.Forms.TextBox()
        Me.txtAddTitle = New System.Windows.Forms.TextBox()
        Me.txtAddLocation = New System.Windows.Forms.TextBox()
        Me.txtAddDuration = New System.Windows.Forms.TextBox()
        Me.btnAddNewPlaylist = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "New Playlist:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Title:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Location:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Duration:"
        '
        'txtAddPlaylist
        '
        Me.txtAddPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddPlaylist.Location = New System.Drawing.Point(118, 15)
        Me.txtAddPlaylist.Name = "txtAddPlaylist"
        Me.txtAddPlaylist.Size = New System.Drawing.Size(368, 23)
        Me.txtAddPlaylist.TabIndex = 6
        '
        'txtAddUsername
        '
        Me.txtAddUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddUsername.Location = New System.Drawing.Point(118, 44)
        Me.txtAddUsername.Name = "txtAddUsername"
        Me.txtAddUsername.Size = New System.Drawing.Size(368, 23)
        Me.txtAddUsername.TabIndex = 7
        '
        'txtAddTitle
        '
        Me.txtAddTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddTitle.Location = New System.Drawing.Point(118, 73)
        Me.txtAddTitle.Name = "txtAddTitle"
        Me.txtAddTitle.Size = New System.Drawing.Size(368, 23)
        Me.txtAddTitle.TabIndex = 8
        '
        'txtAddLocation
        '
        Me.txtAddLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddLocation.Location = New System.Drawing.Point(118, 102)
        Me.txtAddLocation.Name = "txtAddLocation"
        Me.txtAddLocation.Size = New System.Drawing.Size(368, 23)
        Me.txtAddLocation.TabIndex = 9
        '
        'txtAddDuration
        '
        Me.txtAddDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddDuration.Location = New System.Drawing.Point(118, 131)
        Me.txtAddDuration.Name = "txtAddDuration"
        Me.txtAddDuration.Size = New System.Drawing.Size(368, 23)
        Me.txtAddDuration.TabIndex = 10
        '
        'btnAddNewPlaylist
        '
        Me.btnAddNewPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewPlaylist.Location = New System.Drawing.Point(398, 169)
        Me.btnAddNewPlaylist.Name = "btnAddNewPlaylist"
        Me.btnAddNewPlaylist.Size = New System.Drawing.Size(88, 33)
        Me.btnAddNewPlaylist.TabIndex = 11
        Me.btnAddNewPlaylist.Text = "Add"
        Me.btnAddNewPlaylist.UseVisualStyleBackColor = True
        '
        'AddPlaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(498, 215)
        Me.Controls.Add(Me.btnAddNewPlaylist)
        Me.Controls.Add(Me.txtAddDuration)
        Me.Controls.Add(Me.txtAddLocation)
        Me.Controls.Add(Me.txtAddTitle)
        Me.Controls.Add(Me.txtAddUsername)
        Me.Controls.Add(Me.txtAddPlaylist)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "AddPlaylist"
        Me.Text = "Add Playlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddPlaylist As TextBox
    Friend WithEvents txtAddUsername As TextBox
    Friend WithEvents txtAddTitle As TextBox
    Friend WithEvents txtAddLocation As TextBox
    Friend WithEvents txtAddDuration As TextBox
    Friend WithEvents btnAddNewPlaylist As Button
End Class
