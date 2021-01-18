<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalories2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalories2))
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rdbMetric = New System.Windows.Forms.RadioButton()
        Me.rdbStandard = New System.Windows.Forms.RadioButton()
        Me.grpHeight = New System.Windows.Forms.GroupBox()
        Me.pnlWhatIsBMI = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBMI2 = New System.Windows.Forms.Label()
        Me.lblWhat1 = New System.Windows.Forms.Label()
        Me.btnWhatBMI = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.grpHeight.SuspendLayout()
        Me.pnlWhatIsBMI.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.ForeColor = System.Drawing.Color.Black
        Me.lblAnswer.Location = New System.Drawing.Point(191, 135)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(286, 52)
        Me.lblAnswer.TabIndex = 30
        Me.lblAnswer.Text = "Your BMI Count is ___." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is considered to be ____."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnItem)
        Me.Panel1.Controls.Add(Me.btnBMI)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(612, 54)
        Me.Panel1.TabIndex = 26
        '
        'btnItem
        '
        Me.btnItem.BackColor = System.Drawing.Color.LightSalmon
        Me.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItem.Location = New System.Drawing.Point(124, 0)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(129, 54)
        Me.btnItem.TabIndex = 1
        Me.btnItem.Text = "Calorie List"
        Me.btnItem.UseVisualStyleBackColor = False
        '
        'btnBMI
        '
        Me.btnBMI.BackColor = System.Drawing.Color.Lime
        Me.btnBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBMI.Location = New System.Drawing.Point(0, 0)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(128, 54)
        Me.btnBMI.TabIndex = 0
        Me.btnBMI.Text = "Calorie Goal"
        Me.btnBMI.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(12, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 47)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Check My BMI"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'rdbMetric
        '
        Me.rdbMetric.AutoSize = True
        Me.rdbMetric.Location = New System.Drawing.Point(17, 47)
        Me.rdbMetric.Name = "rdbMetric"
        Me.rdbMetric.Size = New System.Drawing.Size(76, 24)
        Me.rdbMetric.TabIndex = 34
        Me.rdbMetric.TabStop = True
        Me.rdbMetric.Text = "Metric"
        Me.rdbMetric.UseVisualStyleBackColor = True
        '
        'rdbStandard
        '
        Me.rdbStandard.AutoSize = True
        Me.rdbStandard.Location = New System.Drawing.Point(17, 75)
        Me.rdbStandard.Name = "rdbStandard"
        Me.rdbStandard.Size = New System.Drawing.Size(91, 24)
        Me.rdbStandard.TabIndex = 35
        Me.rdbStandard.TabStop = True
        Me.rdbStandard.Text = "Imperial"
        Me.rdbStandard.UseVisualStyleBackColor = True
        '
        'grpHeight
        '
        Me.grpHeight.BackColor = System.Drawing.Color.Transparent
        Me.grpHeight.Controls.Add(Me.rdbMetric)
        Me.grpHeight.Controls.Add(Me.rdbStandard)
        Me.grpHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHeight.Location = New System.Drawing.Point(12, 116)
        Me.grpHeight.Name = "grpHeight"
        Me.grpHeight.Size = New System.Drawing.Size(158, 115)
        Me.grpHeight.TabIndex = 38
        Me.grpHeight.TabStop = False
        Me.grpHeight.Text = "Unit Of Measurment"
        '
        'pnlWhatIsBMI
        '
        Me.pnlWhatIsBMI.BackColor = System.Drawing.Color.Transparent
        Me.pnlWhatIsBMI.Controls.Add(Me.btnBack)
        Me.pnlWhatIsBMI.Controls.Add(Me.Label2)
        Me.pnlWhatIsBMI.Controls.Add(Me.lblBMI2)
        Me.pnlWhatIsBMI.Controls.Add(Me.lblWhat1)
        Me.pnlWhatIsBMI.Location = New System.Drawing.Point(-2, 0)
        Me.pnlWhatIsBMI.Name = "pnlWhatIsBMI"
        Me.pnlWhatIsBMI.Size = New System.Drawing.Size(612, 323)
        Me.pnlWhatIsBMI.TabIndex = 39
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(17, 258)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(128, 41)
        Me.btnBack.TabIndex = 37
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(5, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 24)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "What is BMI?"
        '
        'lblBMI2
        '
        Me.lblBMI2.AutoSize = True
        Me.lblBMI2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMI2.ForeColor = System.Drawing.Color.Black
        Me.lblBMI2.Location = New System.Drawing.Point(13, 141)
        Me.lblBMI2.Name = "lblBMI2"
        Me.lblBMI2.Size = New System.Drawing.Size(251, 100)
        Me.lblBMI2.TabIndex = 35
        Me.lblBMI2.Text = "BMI Categories: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Underweight = <18.5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Normal weight = 18.5–24.9 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Overweight = 2" &
    "5–29.9 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Obesity = BMI of 30 or greater"
        '
        'lblWhat1
        '
        Me.lblWhat1.AutoSize = True
        Me.lblWhat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhat1.ForeColor = System.Drawing.Color.Black
        Me.lblWhat1.Location = New System.Drawing.Point(6, 47)
        Me.lblWhat1.Name = "lblWhat1"
        Me.lblWhat1.Size = New System.Drawing.Size(544, 72)
        Me.lblWhat1.TabIndex = 34
        Me.lblWhat1.Text = resources.GetString("lblWhat1.Text")
        '
        'btnWhatBMI
        '
        Me.btnWhatBMI.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnWhatBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWhatBMI.Location = New System.Drawing.Point(12, 68)
        Me.btnWhatBMI.Name = "btnWhatBMI"
        Me.btnWhatBMI.Size = New System.Drawing.Size(158, 33)
        Me.btnWhatBMI.TabIndex = 39
        Me.btnWhatBMI.Text = "What Is BMI?"
        Me.btnWhatBMI.UseVisualStyleBackColor = False
        '
        'frmCalories2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.BackgroundImage = Global.frmSplashScreen_PocketPal.My.Resources.Resources.CalmColor2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(609, 320)
        Me.Controls.Add(Me.pnlWhatIsBMI)
        Me.Controls.Add(Me.btnWhatBMI)
        Me.Controls.Add(Me.grpHeight)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "frmCalories2"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.grpHeight.ResumeLayout(False)
        Me.grpHeight.PerformLayout()
        Me.pnlWhatIsBMI.ResumeLayout(False)
        Me.pnlWhatIsBMI.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAnswer As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnItem As Button
    Friend WithEvents btnBMI As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents rdbMetric As RadioButton
    Friend WithEvents rdbStandard As RadioButton
    Friend WithEvents grpHeight As GroupBox
    Friend WithEvents pnlWhatIsBMI As Panel
    Friend WithEvents lblWhat1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBMI2 As Label
    Friend WithEvents btnWhatBMI As Button
End Class
