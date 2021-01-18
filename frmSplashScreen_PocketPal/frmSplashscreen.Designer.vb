<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashscreen
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
        Me.components = New System.ComponentModel.Container()
        Me.timerSplashScreen = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picGif = New System.Windows.Forms.PictureBox()
        CType(Me.picGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerSplashScreen
        '
        Me.timerSplashScreen.Interval = 5000
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.LightBlue
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 66.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(3, -2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(473, 101)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Pocket Pal"
        '
        'picGif
        '
        Me.picGif.Image = Global.frmSplashScreen_PocketPal.My.Resources.Resources.book_shelf_loader1
        Me.picGif.Location = New System.Drawing.Point(-4, -2)
        Me.picGif.Name = "picGif"
        Me.picGif.Size = New System.Drawing.Size(494, 355)
        Me.picGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGif.TabIndex = 0
        Me.picGif.TabStop = False
        '
        'frmSplashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(479, 311)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picGif)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplashscreen"
        Me.Text = "Form1"
        CType(Me.picGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGif As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents timerSplashScreen As Timer
End Class
