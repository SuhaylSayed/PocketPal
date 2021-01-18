<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalories1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.lblGoal1 = New System.Windows.Forms.Label()
        Me.lblConsume = New System.Windows.Forms.Label()
        Me.lblGoal3 = New System.Windows.Forms.Label()
        Me.pgbGoalIntake = New System.Windows.Forms.ProgressBar()
        Me.lblGoal2 = New System.Windows.Forms.Label()
        Me.lblHowMany = New System.Windows.Forms.Label()
        Me.btnNewGoal = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lime
        Me.Panel1.Controls.Add(Me.picClose)
        Me.Panel1.Controls.Add(Me.btnItem)
        Me.Panel1.Controls.Add(Me.btnBMI)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(589, 54)
        Me.Panel1.TabIndex = 0
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.BackgroundImage = Global.frmSplashScreen_PocketPal.My.Resources.Resources.CloseRed
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picClose.Location = New System.Drawing.Point(566, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(20, 20)
        Me.picClose.TabIndex = 23
        Me.picClose.TabStop = False
        '
        'btnItem
        '
        Me.btnItem.BackColor = System.Drawing.Color.LightSalmon
        Me.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItem.Location = New System.Drawing.Point(124, 0)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(125, 54)
        Me.btnItem.TabIndex = 1
        Me.btnItem.Text = "Calorie List"
        Me.btnItem.UseVisualStyleBackColor = False
        '
        'btnBMI
        '
        Me.btnBMI.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBMI.Location = New System.Drawing.Point(0, 0)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(128, 54)
        Me.btnBMI.TabIndex = 0
        Me.btnBMI.Text = "BMI Calculator"
        Me.btnBMI.UseVisualStyleBackColor = False
        '
        'lblGoal1
        '
        Me.lblGoal1.AutoSize = True
        Me.lblGoal1.BackColor = System.Drawing.Color.Transparent
        Me.lblGoal1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoal1.ForeColor = System.Drawing.Color.Black
        Me.lblGoal1.Location = New System.Drawing.Point(18, 68)
        Me.lblGoal1.Name = "lblGoal1"
        Me.lblGoal1.Size = New System.Drawing.Size(456, 26)
        Me.lblGoal1.TabIndex = 20
        Me.lblGoal1.Text = "Your have consumed this many calories today:"
        '
        'lblConsume
        '
        Me.lblConsume.BackColor = System.Drawing.Color.Transparent
        Me.lblConsume.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsume.ForeColor = System.Drawing.Color.Red
        Me.lblConsume.Location = New System.Drawing.Point(474, 69)
        Me.lblConsume.Name = "lblConsume"
        Me.lblConsume.Size = New System.Drawing.Size(89, 25)
        Me.lblConsume.TabIndex = 20
        Me.lblConsume.Text = "---"
        Me.lblConsume.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGoal3
        '
        Me.lblGoal3.AutoSize = True
        Me.lblGoal3.BackColor = System.Drawing.Color.Transparent
        Me.lblGoal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoal3.ForeColor = System.Drawing.Color.DimGray
        Me.lblGoal3.Location = New System.Drawing.Point(19, 167)
        Me.lblGoal3.Name = "lblGoal3"
        Me.lblGoal3.Size = New System.Drawing.Size(242, 24)
        Me.lblGoal3.TabIndex = 20
        Me.lblGoal3.Text = "Daily Caloric Intake Goal:"
        '
        'pgbGoalIntake
        '
        Me.pgbGoalIntake.BackColor = System.Drawing.Color.White
        Me.pgbGoalIntake.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pgbGoalIntake.Location = New System.Drawing.Point(22, 194)
        Me.pgbGoalIntake.Name = "pgbGoalIntake"
        Me.pgbGoalIntake.Size = New System.Drawing.Size(514, 41)
        Me.pgbGoalIntake.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbGoalIntake.TabIndex = 20
        '
        'lblGoal2
        '
        Me.lblGoal2.AutoSize = True
        Me.lblGoal2.BackColor = System.Drawing.Color.Transparent
        Me.lblGoal2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoal2.ForeColor = System.Drawing.Color.Black
        Me.lblGoal2.Location = New System.Drawing.Point(18, 116)
        Me.lblGoal2.Name = "lblGoal2"
        Me.lblGoal2.Size = New System.Drawing.Size(464, 26)
        Me.lblGoal2.TabIndex = 21
        Me.lblGoal2.Text = "You can still consume this many calories today:"
        '
        'lblHowMany
        '
        Me.lblHowMany.BackColor = System.Drawing.Color.Transparent
        Me.lblHowMany.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowMany.ForeColor = System.Drawing.Color.Red
        Me.lblHowMany.Location = New System.Drawing.Point(479, 117)
        Me.lblHowMany.Name = "lblHowMany"
        Me.lblHowMany.Size = New System.Drawing.Size(84, 25)
        Me.lblHowMany.TabIndex = 22
        Me.lblHowMany.Text = "---"
        Me.lblHowMany.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnNewGoal
        '
        Me.btnNewGoal.BackColor = System.Drawing.Color.Transparent
        Me.btnNewGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewGoal.Location = New System.Drawing.Point(23, 252)
        Me.btnNewGoal.Name = "btnNewGoal"
        Me.btnNewGoal.Size = New System.Drawing.Size(176, 32)
        Me.btnNewGoal.TabIndex = 2
        Me.btnNewGoal.Text = "Create New Goal"
        Me.btnNewGoal.UseVisualStyleBackColor = False
        '
        'frmCalories1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.frmSplashScreen_PocketPal.My.Resources.Resources.CalmColor1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(586, 314)
        Me.Controls.Add(Me.btnNewGoal)
        Me.Controls.Add(Me.lblHowMany)
        Me.Controls.Add(Me.lblGoal2)
        Me.Controls.Add(Me.pgbGoalIntake)
        Me.Controls.Add(Me.lblGoal3)
        Me.Controls.Add(Me.lblConsume)
        Me.Controls.Add(Me.lblGoal1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "frmCalories1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnItem As Button
    Friend WithEvents btnBMI As Button
    Friend WithEvents lblGoal1 As Label
    Friend WithEvents lblConsume As Label
    Friend WithEvents lblGoal3 As Label
    Friend WithEvents pgbGoalIntake As ProgressBar
    Friend WithEvents lblGoal2 As Label
    Friend WithEvents lblHowMany As Label
    Friend WithEvents btnNewGoal As Button
    Friend WithEvents picClose As PictureBox
End Class
