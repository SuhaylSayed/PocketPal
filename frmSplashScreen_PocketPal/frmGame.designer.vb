<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnNumber = New System.Windows.Forms.Button()
        Me.btnColour = New System.Windows.Forms.Button()
        Me.timColourCount = New System.Windows.Forms.Timer(Me.components)
        Me.lblReactionTime = New System.Windows.Forms.Label()
        Me.pnlNumbers = New System.Windows.Forms.Panel()
        Me.bntCheck = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblInstructions2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.timNums = New System.Windows.Forms.Timer(Me.components)
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.timColour = New System.Windows.Forms.Timer(Me.components)
        Me.pnlColour = New System.Windows.Forms.Panel()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.pnlHeader.SuspendLayout()
        Me.pnlNumbers.SuspendLayout()
        Me.pnlColour.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.DarkGray
        Me.pnlHeader.Controls.Add(Me.picClose)
        Me.pnlHeader.Controls.Add(Me.btnNumber)
        Me.pnlHeader.Controls.Add(Me.btnColour)
        Me.pnlHeader.Location = New System.Drawing.Point(137, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(215, 43)
        Me.pnlHeader.TabIndex = 1
        '
        'btnNumber
        '
        Me.btnNumber.BackColor = System.Drawing.Color.White
        Me.btnNumber.Font = New System.Drawing.Font("Montserrat Medium", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.btnNumber.Location = New System.Drawing.Point(129, 0)
        Me.btnNumber.Name = "btnNumber"
        Me.btnNumber.Size = New System.Drawing.Size(88, 43)
        Me.btnNumber.TabIndex = 1
        Me.btnNumber.Text = "Numbers"
        Me.btnNumber.UseVisualStyleBackColor = False
        '
        'btnColour
        '
        Me.btnColour.BackColor = System.Drawing.Color.White
        Me.btnColour.Font = New System.Drawing.Font("Montserrat Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColour.Location = New System.Drawing.Point(-1, 0)
        Me.btnColour.Name = "btnColour"
        Me.btnColour.Size = New System.Drawing.Size(92, 43)
        Me.btnColour.TabIndex = 0
        Me.btnColour.Text = "Colour"
        Me.btnColour.UseVisualStyleBackColor = False
        '
        'timColourCount
        '
        Me.timColourCount.Interval = 1
        '
        'lblReactionTime
        '
        Me.lblReactionTime.Font = New System.Drawing.Font("Montserrat", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReactionTime.ForeColor = System.Drawing.Color.White
        Me.lblReactionTime.Location = New System.Drawing.Point(182, 171)
        Me.lblReactionTime.Name = "lblReactionTime"
        Me.lblReactionTime.Size = New System.Drawing.Size(137, 86)
        Me.lblReactionTime.TabIndex = 2
        '
        'pnlNumbers
        '
        Me.pnlNumbers.Controls.Add(Me.bntCheck)
        Me.pnlNumbers.Controls.Add(Me.txtInput)
        Me.pnlNumbers.Controls.Add(Me.lblOutput)
        Me.pnlNumbers.Controls.Add(Me.lblInstructions2)
        Me.pnlNumbers.Location = New System.Drawing.Point(1, 2)
        Me.pnlNumbers.Name = "pnlNumbers"
        Me.pnlNumbers.Size = New System.Drawing.Size(491, 266)
        Me.pnlNumbers.TabIndex = 3
        '
        'bntCheck
        '
        Me.bntCheck.BackColor = System.Drawing.Color.White
        Me.bntCheck.Font = New System.Drawing.Font("Montserrat Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntCheck.Location = New System.Drawing.Point(215, 219)
        Me.bntCheck.Name = "bntCheck"
        Me.bntCheck.Size = New System.Drawing.Size(77, 33)
        Me.bntCheck.TabIndex = 4
        Me.bntCheck.Text = "Check"
        Me.bntCheck.UseVisualStyleBackColor = False
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Montserrat Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(172, 155)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(157, 44)
        Me.txtInput.TabIndex = 2
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblOutput
        '
        Me.lblOutput.Font = New System.Drawing.Font("Montserrat Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(180, 102)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(142, 43)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInstructions2
        '
        Me.lblInstructions2.AutoSize = True
        Me.lblInstructions2.Font = New System.Drawing.Font("Montserrat Medium", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblInstructions2.Location = New System.Drawing.Point(26, 64)
        Me.lblInstructions2.Name = "lblInstructions2"
        Me.lblInstructions2.Size = New System.Drawing.Size(452, 29)
        Me.lblInstructions2.TabIndex = 0
        Me.lblInstructions2.Text = "Enter the number when it disappears"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.White
        Me.btnStart.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(207, 63)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(77, 31)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'timNums
        '
        Me.timNums.Interval = 6000
        '
        'btnGreen
        '
        Me.btnGreen.BackColor = System.Drawing.Color.White
        Me.btnGreen.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGreen.Location = New System.Drawing.Point(117, 110)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(257, 58)
        Me.btnGreen.TabIndex = 6
        Me.btnGreen.Text = "Press when green"
        Me.btnGreen.UseVisualStyleBackColor = False
        '
        'timColour
        '
        '
        'pnlColour
        '
        Me.pnlColour.Controls.Add(Me.pnlNumbers)
        Me.pnlColour.Controls.Add(Me.lblReactionTime)
        Me.pnlColour.Controls.Add(Me.btnGreen)
        Me.pnlColour.Controls.Add(Me.btnStart)
        Me.pnlColour.Location = New System.Drawing.Point(0, 0)
        Me.pnlColour.Name = "pnlColour"
        Me.pnlColour.Size = New System.Drawing.Size(490, 268)
        Me.pnlColour.TabIndex = 7
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.BackgroundImage = Global.frmSplashScreen_PocketPal.My.Resources.Resources.CloseRed
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picClose.Location = New System.Drawing.Point(100, 11)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(20, 20)
        Me.picClose.TabIndex = 12
        Me.picClose.TabStop = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(490, 266)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlColour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGame"
        Me.Text = "Form1"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlNumbers.ResumeLayout(False)
        Me.pnlNumbers.PerformLayout()
        Me.pnlColour.ResumeLayout(False)
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnNumber As Button
    Friend WithEvents btnColour As Button
    Friend WithEvents timColourCount As Timer
    Friend WithEvents lblReactionTime As Label
    Friend WithEvents pnlNumbers As Panel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblInstructions2 As Label
    Friend WithEvents bntCheck As Button
    Friend WithEvents timNums As Timer
    Friend WithEvents btnStart As Button
    Friend WithEvents btnGreen As Button
    Friend WithEvents timColour As Timer
    Friend WithEvents pnlColour As Panel
    Friend WithEvents picClose As PictureBox
End Class
