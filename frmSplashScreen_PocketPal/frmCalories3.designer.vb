<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalories3
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.lstLunch = New System.Windows.Forms.ListBox()
        Me.lstDinner = New System.Windows.Forms.ListBox()
        Me.lstBreakfast = New System.Windows.Forms.ListBox()
        Me.lstSnack = New System.Windows.Forms.ListBox()
        Me.lblBreak = New System.Windows.Forms.Label()
        Me.lblLunch = New System.Windows.Forms.Label()
        Me.lblDinner = New System.Windows.Forms.Label()
        Me.lblSnack = New System.Windows.Forms.Label()
        Me.lblBreakCal = New System.Windows.Forms.Label()
        Me.lblLunchCal = New System.Windows.Forms.Label()
        Me.lblDinnerCal = New System.Windows.Forms.Label()
        Me.lblSnackCal = New System.Windows.Forms.Label()
        Me.lblTotalCal = New System.Windows.Forms.Label()
        Me.btnBreakfast = New System.Windows.Forms.Button()
        Me.btnLunch = New System.Windows.Forms.Button()
        Me.btnDinner = New System.Windows.Forms.Button()
        Me.btnSnack = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel1.Controls.Add(Me.btnItem)
        Me.Panel1.Controls.Add(Me.btnBMI)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 57)
        Me.Panel1.TabIndex = 1
        '
        'btnItem
        '
        Me.btnItem.BackColor = System.Drawing.Color.Lime
        Me.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItem.Location = New System.Drawing.Point(124, 0)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(125, 57)
        Me.btnItem.TabIndex = 1
        Me.btnItem.Text = "Caloric Goal"
        Me.btnItem.UseVisualStyleBackColor = False
        '
        'btnBMI
        '
        Me.btnBMI.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBMI.Location = New System.Drawing.Point(0, 0)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(128, 57)
        Me.btnBMI.TabIndex = 0
        Me.btnBMI.Text = "BMI Calculator"
        Me.btnBMI.UseVisualStyleBackColor = False
        '
        'lstLunch
        '
        Me.lstLunch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstLunch.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLunch.FormattingEnabled = True
        Me.lstLunch.ItemHeight = 21
        Me.lstLunch.Location = New System.Drawing.Point(204, 92)
        Me.lstLunch.Name = "lstLunch"
        Me.lstLunch.Size = New System.Drawing.Size(184, 189)
        Me.lstLunch.TabIndex = 6
        '
        'lstDinner
        '
        Me.lstDinner.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstDinner.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDinner.FormattingEnabled = True
        Me.lstDinner.ItemHeight = 21
        Me.lstDinner.Location = New System.Drawing.Point(394, 92)
        Me.lstDinner.Name = "lstDinner"
        Me.lstDinner.Size = New System.Drawing.Size(183, 189)
        Me.lstDinner.TabIndex = 5
        '
        'lstBreakfast
        '
        Me.lstBreakfast.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstBreakfast.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBreakfast.FormattingEnabled = True
        Me.lstBreakfast.ItemHeight = 21
        Me.lstBreakfast.Location = New System.Drawing.Point(11, 92)
        Me.lstBreakfast.Name = "lstBreakfast"
        Me.lstBreakfast.Size = New System.Drawing.Size(184, 189)
        Me.lstBreakfast.TabIndex = 4
        '
        'lstSnack
        '
        Me.lstSnack.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstSnack.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSnack.FormattingEnabled = True
        Me.lstSnack.ItemHeight = 21
        Me.lstSnack.Location = New System.Drawing.Point(583, 92)
        Me.lstSnack.Name = "lstSnack"
        Me.lstSnack.Size = New System.Drawing.Size(184, 189)
        Me.lstSnack.TabIndex = 7
        '
        'lblBreak
        '
        Me.lblBreak.AutoSize = True
        Me.lblBreak.BackColor = System.Drawing.Color.Transparent
        Me.lblBreak.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreak.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblBreak.Location = New System.Drawing.Point(13, 65)
        Me.lblBreak.Name = "lblBreak"
        Me.lblBreak.Size = New System.Drawing.Size(119, 25)
        Me.lblBreak.TabIndex = 21
        Me.lblBreak.Text = "Breakfast:"
        '
        'lblLunch
        '
        Me.lblLunch.AutoSize = True
        Me.lblLunch.BackColor = System.Drawing.Color.Transparent
        Me.lblLunch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLunch.ForeColor = System.Drawing.Color.Yellow
        Me.lblLunch.Location = New System.Drawing.Point(209, 65)
        Me.lblLunch.Name = "lblLunch"
        Me.lblLunch.Size = New System.Drawing.Size(83, 25)
        Me.lblLunch.TabIndex = 22
        Me.lblLunch.Text = "Lunch:"
        '
        'lblDinner
        '
        Me.lblDinner.AutoSize = True
        Me.lblDinner.BackColor = System.Drawing.Color.Transparent
        Me.lblDinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinner.ForeColor = System.Drawing.Color.Lime
        Me.lblDinner.Location = New System.Drawing.Point(392, 65)
        Me.lblDinner.Name = "lblDinner"
        Me.lblDinner.Size = New System.Drawing.Size(88, 25)
        Me.lblDinner.TabIndex = 23
        Me.lblDinner.Text = "Dinner:"
        '
        'lblSnack
        '
        Me.lblSnack.AutoSize = True
        Me.lblSnack.BackColor = System.Drawing.Color.Transparent
        Me.lblSnack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnack.ForeColor = System.Drawing.Color.Cyan
        Me.lblSnack.Location = New System.Drawing.Point(576, 65)
        Me.lblSnack.Name = "lblSnack"
        Me.lblSnack.Size = New System.Drawing.Size(84, 25)
        Me.lblSnack.TabIndex = 24
        Me.lblSnack.Text = "Snack:"
        '
        'lblBreakCal
        '
        Me.lblBreakCal.AutoSize = True
        Me.lblBreakCal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblBreakCal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreakCal.ForeColor = System.Drawing.Color.Black
        Me.lblBreakCal.Location = New System.Drawing.Point(12, 351)
        Me.lblBreakCal.Name = "lblBreakCal"
        Me.lblBreakCal.Size = New System.Drawing.Size(170, 44)
        Me.lblBreakCal.TabIndex = 27
        Me.lblBreakCal.Text = "Breakfast Calorie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Count:"
        '
        'lblLunchCal
        '
        Me.lblLunchCal.AutoSize = True
        Me.lblLunchCal.BackColor = System.Drawing.Color.Yellow
        Me.lblLunchCal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLunchCal.ForeColor = System.Drawing.Color.Black
        Me.lblLunchCal.Location = New System.Drawing.Point(200, 351)
        Me.lblLunchCal.Name = "lblLunchCal"
        Me.lblLunchCal.Size = New System.Drawing.Size(140, 44)
        Me.lblLunchCal.TabIndex = 31
        Me.lblLunchCal.Text = "Lunch Calorie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Count:"
        '
        'lblDinnerCal
        '
        Me.lblDinnerCal.AutoSize = True
        Me.lblDinnerCal.BackColor = System.Drawing.Color.Lime
        Me.lblDinnerCal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinnerCal.ForeColor = System.Drawing.Color.Black
        Me.lblDinnerCal.Location = New System.Drawing.Point(392, 351)
        Me.lblDinnerCal.Name = "lblDinnerCal"
        Me.lblDinnerCal.Size = New System.Drawing.Size(143, 44)
        Me.lblDinnerCal.TabIndex = 32
        Me.lblDinnerCal.Text = "Dinner Calorie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Count:"
        '
        'lblSnackCal
        '
        Me.lblSnackCal.AutoSize = True
        Me.lblSnackCal.BackColor = System.Drawing.Color.Cyan
        Me.lblSnackCal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnackCal.ForeColor = System.Drawing.Color.Black
        Me.lblSnackCal.Location = New System.Drawing.Point(579, 351)
        Me.lblSnackCal.Name = "lblSnackCal"
        Me.lblSnackCal.Size = New System.Drawing.Size(139, 44)
        Me.lblSnackCal.TabIndex = 33
        Me.lblSnackCal.Text = "Snack Calorie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Count:"
        '
        'lblTotalCal
        '
        Me.lblTotalCal.AutoSize = True
        Me.lblTotalCal.BackColor = System.Drawing.Color.Red
        Me.lblTotalCal.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCal.ForeColor = System.Drawing.Color.Black
        Me.lblTotalCal.Location = New System.Drawing.Point(13, 404)
        Me.lblTotalCal.Name = "lblTotalCal"
        Me.lblTotalCal.Size = New System.Drawing.Size(160, 60)
        Me.lblTotalCal.TabIndex = 34
        Me.lblTotalCal.Text = "Total Calorie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Count:"
        '
        'btnBreakfast
        '
        Me.btnBreakfast.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBreakfast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBreakfast.Location = New System.Drawing.Point(29, 287)
        Me.btnBreakfast.Name = "btnBreakfast"
        Me.btnBreakfast.Size = New System.Drawing.Size(143, 52)
        Me.btnBreakfast.TabIndex = 2
        Me.btnBreakfast.Text = "Add Item To Breakfast"
        Me.btnBreakfast.UseVisualStyleBackColor = False
        '
        'btnLunch
        '
        Me.btnLunch.BackColor = System.Drawing.Color.Yellow
        Me.btnLunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLunch.Location = New System.Drawing.Point(217, 287)
        Me.btnLunch.Name = "btnLunch"
        Me.btnLunch.Size = New System.Drawing.Size(143, 52)
        Me.btnLunch.TabIndex = 35
        Me.btnLunch.Text = "Add Item To Lunch"
        Me.btnLunch.UseVisualStyleBackColor = False
        '
        'btnDinner
        '
        Me.btnDinner.BackColor = System.Drawing.Color.Lime
        Me.btnDinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDinner.Location = New System.Drawing.Point(413, 287)
        Me.btnDinner.Name = "btnDinner"
        Me.btnDinner.Size = New System.Drawing.Size(143, 52)
        Me.btnDinner.TabIndex = 36
        Me.btnDinner.Text = "Add Item To Dinner"
        Me.btnDinner.UseVisualStyleBackColor = False
        '
        'btnSnack
        '
        Me.btnSnack.BackColor = System.Drawing.Color.Cyan
        Me.btnSnack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnack.Location = New System.Drawing.Point(605, 287)
        Me.btnSnack.Name = "btnSnack"
        Me.btnSnack.Size = New System.Drawing.Size(143, 52)
        Me.btnSnack.TabIndex = 37
        Me.btnSnack.Text = "Add Item To Snack"
        Me.btnSnack.UseVisualStyleBackColor = False
        '
        'frmCalories3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = Global.frmSplashScreen_PocketPal.My.Resources.Resources.CalmCOlor4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(777, 473)
        Me.Controls.Add(Me.btnSnack)
        Me.Controls.Add(Me.btnDinner)
        Me.Controls.Add(Me.btnLunch)
        Me.Controls.Add(Me.btnBreakfast)
        Me.Controls.Add(Me.lblTotalCal)
        Me.Controls.Add(Me.lblSnackCal)
        Me.Controls.Add(Me.lblDinnerCal)
        Me.Controls.Add(Me.lblLunchCal)
        Me.Controls.Add(Me.lblBreakCal)
        Me.Controls.Add(Me.lblSnack)
        Me.Controls.Add(Me.lblDinner)
        Me.Controls.Add(Me.lblLunch)
        Me.Controls.Add(Me.lblBreak)
        Me.Controls.Add(Me.lstSnack)
        Me.Controls.Add(Me.lstDinner)
        Me.Controls.Add(Me.lstLunch)
        Me.Controls.Add(Me.lstBreakfast)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "frmCalories3"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnItem As Button
    Friend WithEvents btnBMI As Button
    Friend WithEvents lstLunch As ListBox
    Friend WithEvents lstDinner As ListBox
    Friend WithEvents lstBreakfast As ListBox
    Friend WithEvents lstSnack As ListBox
    Friend WithEvents lblBreak As Label
    Friend WithEvents lblLunch As Label
    Friend WithEvents lblDinner As Label
    Friend WithEvents lblSnack As Label
    Friend WithEvents lblBreakCal As Label
    Friend WithEvents lblLunchCal As Label
    Friend WithEvents lblDinnerCal As Label
    Friend WithEvents lblSnackCal As Label
    Friend WithEvents lblTotalCal As Label
    Friend WithEvents btnBreakfast As Button
    Friend WithEvents btnLunch As Button
    Friend WithEvents btnDinner As Button
    Friend WithEvents btnSnack As Button
End Class
