<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchTrack
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
        Me.txtTrack = New System.Windows.Forms.TextBox()
        Me.btnTrack = New System.Windows.Forms.Button()
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
        Me.Label1.Size = New System.Drawing.Size(144, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Track Name:"
        '
        'txtTrack
        '
        Me.txtTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrack.Location = New System.Drawing.Point(153, 17)
        Me.txtTrack.Name = "txtTrack"
        Me.txtTrack.Size = New System.Drawing.Size(239, 23)
        Me.txtTrack.TabIndex = 3
        '
        'btnTrack
        '
        Me.btnTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrack.Location = New System.Drawing.Point(398, 12)
        Me.btnTrack.Name = "btnTrack"
        Me.btnTrack.Size = New System.Drawing.Size(88, 33)
        Me.btnTrack.TabIndex = 4
        Me.btnTrack.Text = "Search"
        Me.btnTrack.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Track"
        '
        'lstTrack
        '
        Me.lstTrack.FormattingEnabled = True
        Me.lstTrack.Location = New System.Drawing.Point(15, 78)
        Me.lstTrack.Name = "lstTrack"
        Me.lstTrack.Size = New System.Drawing.Size(463, 160)
        Me.lstTrack.TabIndex = 10
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(15, 255)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(88, 33)
        Me.btnPlay.TabIndex = 11
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'SearchTrack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(498, 302)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lstTrack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTrack)
        Me.Controls.Add(Me.txtTrack)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "SearchTrack"
        Me.Text = "Search Track"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTrack As TextBox
    Friend WithEvents btnTrack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lstTrack As ListBox
    Friend WithEvents btnPlay As Button
End Class
