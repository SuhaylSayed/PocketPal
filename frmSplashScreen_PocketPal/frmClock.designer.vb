<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClock
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
        Me.components = New System.ComponentModel.Container()
        Me.btnClock = New System.Windows.Forms.Button()
        Me.pnlClock = New System.Windows.Forms.Panel()
        Me.pnlTimer = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.btnTimer = New System.Windows.Forms.Button()
        Me.timClock = New System.Windows.Forms.Timer(Me.components)
        Me.timTimer = New System.Windows.Forms.Timer(Me.components)
        Me.timStopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.pnlClock.SuspendLayout()
        Me.pnlTimer.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClock
        '
        Me.btnClock.BackColor = System.Drawing.Color.Black
        Me.btnClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClock.ForeColor = System.Drawing.Color.Gold
        Me.btnClock.Location = New System.Drawing.Point(221, 0)
        Me.btnClock.Name = "btnClock"
        Me.btnClock.Size = New System.Drawing.Size(75, 23)
        Me.btnClock.TabIndex = 0
        Me.btnClock.Text = "Clock"
        Me.btnClock.UseVisualStyleBackColor = False
        '
        'pnlClock
        '
        Me.pnlClock.BackColor = System.Drawing.Color.Black
        Me.pnlClock.Controls.Add(Me.pnlTimer)
        Me.pnlClock.Controls.Add(Me.lblClock)
        Me.pnlClock.Location = New System.Drawing.Point(-1, 23)
        Me.pnlClock.Name = "pnlClock"
        Me.pnlClock.Size = New System.Drawing.Size(440, 235)
        Me.pnlClock.TabIndex = 1
        '
        'pnlTimer
        '
        Me.pnlTimer.BackColor = System.Drawing.Color.Black
        Me.pnlTimer.Controls.Add(Me.btnReset)
        Me.pnlTimer.Controls.Add(Me.btnStop)
        Me.pnlTimer.Controls.Add(Me.btnStart)
        Me.pnlTimer.Controls.Add(Me.lblTimer)
        Me.pnlTimer.Location = New System.Drawing.Point(1, 0)
        Me.pnlTimer.Name = "pnlTimer"
        Me.pnlTimer.Size = New System.Drawing.Size(440, 235)
        Me.pnlTimer.TabIndex = 4
        Me.pnlTimer.Visible = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Black
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Gold
        Me.btnReset.Location = New System.Drawing.Point(271, 160)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Black
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Gold
        Me.btnStop.Location = New System.Drawing.Point(175, 161)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "Stop"
        Me.btnStop.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Black
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Gold
        Me.btnStart.Location = New System.Drawing.Point(78, 161)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.Gold
        Me.lblTimer.Location = New System.Drawing.Point(147, 75)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(135, 33)
        Me.lblTimer.TabIndex = 3
        Me.lblTimer.Text = "00:00:00"
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.Color.Gold
        Me.lblClock.Location = New System.Drawing.Point(129, 81)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(167, 33)
        Me.lblClock.TabIndex = 3
        Me.lblClock.Text = "HH:MM:SS"
        '
        'btnTimer
        '
        Me.btnTimer.BackColor = System.Drawing.Color.Black
        Me.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimer.ForeColor = System.Drawing.Color.Gold
        Me.btnTimer.Location = New System.Drawing.Point(153, 0)
        Me.btnTimer.Name = "btnTimer"
        Me.btnTimer.Size = New System.Drawing.Size(75, 23)
        Me.btnTimer.TabIndex = 1
        Me.btnTimer.Text = "Timer"
        Me.btnTimer.UseVisualStyleBackColor = False
        '
        'timClock
        '
        Me.timClock.Enabled = True
        '
        'timTimer
        '
        Me.timTimer.Interval = 1000
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.BackgroundImage = Global.frmSplashScreen_PocketPal.My.Resources.Resources.CloseRed
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picClose.Location = New System.Drawing.Point(3, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(20, 20)
        Me.picClose.TabIndex = 12
        Me.picClose.TabStop = False
        '
        'frmClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(432, 253)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.pnlClock)
        Me.Controls.Add(Me.btnTimer)
        Me.Controls.Add(Me.btnClock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClock"
        Me.Text = "Clock"
        Me.pnlClock.ResumeLayout(False)
        Me.pnlClock.PerformLayout()
        Me.pnlTimer.ResumeLayout(False)
        Me.pnlTimer.PerformLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClock As Button
    Friend WithEvents pnlClock As Panel
    Friend WithEvents lblClock As Label
    Friend WithEvents btnTimer As Button
    Friend WithEvents timClock As Timer
    Friend WithEvents pnlTimer As Panel
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents timTimer As Timer
    Friend WithEvents timStopwatch As Timer
    Friend WithEvents picClose As PictureBox
End Class
