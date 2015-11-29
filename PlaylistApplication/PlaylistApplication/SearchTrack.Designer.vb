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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchTrack))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTrack = New System.Windows.Forms.TextBox()
        Me.btnTrack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstTrack = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Track:"
        '
        'txtTrack
        '
        Me.txtTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrack.Location = New System.Drawing.Point(139, 22)
        Me.txtTrack.Name = "txtTrack"
        Me.txtTrack.Size = New System.Drawing.Size(592, 23)
        Me.txtTrack.TabIndex = 3
        '
        'btnTrack
        '
        Me.btnTrack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrack.Location = New System.Drawing.Point(737, 17)
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
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Track"
        '
        'lstTrack
        '
        Me.lstTrack.FormattingEnabled = True
        Me.lstTrack.Location = New System.Drawing.Point(15, 72)
        Me.lstTrack.Name = "lstTrack"
        Me.lstTrack.Size = New System.Drawing.Size(320, 407)
        Me.lstTrack.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(12, 489)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Designed by Angelo and Freddy"
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(341, 72)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(483, 407)
        Me.AxShockwaveFlash1.TabIndex = 15
        '
        'SearchTrack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(837, 511)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstTrack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTrack)
        Me.Controls.Add(Me.txtTrack)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(853, 549)
        Me.MinimumSize = New System.Drawing.Size(853, 549)
        Me.Name = "SearchTrack"
        Me.Text = "Search by Track"
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTrack As TextBox
    Friend WithEvents btnTrack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lstTrack As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
