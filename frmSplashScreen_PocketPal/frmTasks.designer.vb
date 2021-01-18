<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTasks
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
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlView = New System.Windows.Forms.Panel()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnTask1 = New System.Windows.Forms.Button()
        Me.btnTask2 = New System.Windows.Forms.Button()
        Me.btnTask3 = New System.Windows.Forms.Button()
        Me.btnTask4 = New System.Windows.Forms.Button()
        Me.btnTask5 = New System.Windows.Forms.Button()
        Me.btnTask6 = New System.Windows.Forms.Button()
        Me.btnTask7 = New System.Windows.Forms.Button()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.pnlTitle.SuspendLayout()
        Me.pnlView.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlTitle.Controls.Add(Me.picClose)
        Me.pnlTitle.Controls.Add(Me.lblHeader)
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(475, 40)
        Me.pnlTitle.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Firebrick
        Me.lblHeader.Location = New System.Drawing.Point(200, 6)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(75, 25)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Tasks"
        '
        'pnlView
        '
        Me.pnlView.BackColor = System.Drawing.Color.Firebrick
        Me.pnlView.Controls.Add(Me.txtDescription)
        Me.pnlView.Controls.Add(Me.txtDate)
        Me.pnlView.Controls.Add(Me.txtTitle)
        Me.pnlView.Controls.Add(Me.lblDescription)
        Me.pnlView.Controls.Add(Me.lblDate)
        Me.pnlView.Controls.Add(Me.lblTitle)
        Me.pnlView.Location = New System.Drawing.Point(334, 40)
        Me.pnlView.Name = "pnlView"
        Me.pnlView.Size = New System.Drawing.Size(141, 231)
        Me.pnlView.TabIndex = 1
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.Firebrick
        Me.txtDescription.Location = New System.Drawing.Point(9, 131)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(118, 93)
        Me.txtDescription.TabIndex = 7
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.Firebrick
        Me.txtDate.Location = New System.Drawing.Point(10, 73)
        Me.txtDate.Multiline = True
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(117, 24)
        Me.txtDate.TabIndex = 5
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.Firebrick
        Me.txtTitle.Location = New System.Drawing.Point(10, 27)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(117, 24)
        Me.txtTitle.TabIndex = 4
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(7, 106)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(7, 54)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(56, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Due Date:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(7, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(33, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title: "
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Firebrick
        Me.btnAdd.Location = New System.Drawing.Point(334, 270)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(141, 27)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnTask1
        '
        Me.btnTask1.BackColor = System.Drawing.Color.Firebrick
        Me.btnTask1.FlatAppearance.BorderSize = 0
        Me.btnTask1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTask1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTask1.Location = New System.Drawing.Point(-1, 40)
        Me.btnTask1.Name = "btnTask1"
        Me.btnTask1.Size = New System.Drawing.Size(335, 35)
        Me.btnTask1.TabIndex = 4
        Me.btnTask1.UseVisualStyleBackColor = False
        '
        'btnTask2
        '
        Me.btnTask2.BackColor = System.Drawing.Color.Firebrick
        Me.btnTask2.FlatAppearance.BorderSize = 0
        Me.btnTask2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTask2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTask2.Location = New System.Drawing.Point(-1, 72)
        Me.btnTask2.Name = "btnTask2"
        Me.btnTask2.Size = New System.Drawing.Size(335, 35)
        Me.btnTask2.TabIndex = 5
        Me.btnTask2.UseVisualStyleBackColor = False
        '
        'btnTask3
        '
        Me.btnTask3.BackColor = System.Drawing.Color.Firebrick
        Me.btnTask3.FlatAppearance.BorderSize = 0
        Me.btnTask3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTask3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTask3.Location = New System.Drawing.Point(-1, 105)
        Me.btnTask3.Name = "btnTask3"
        Me.btnTask3.Size = New System.Drawing.Size(335, 35)
        Me.btnTask3.TabIndex = 6
        Me.btnTask3.UseVisualStyleBackColor = False
        '
        'btnTask4
        '
        Me.btnTask4.BackColor = System.Drawing.Color.Firebrick
        Me.btnTask4.FlatAppearance.BorderSize = 0
        Me.btnTask4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTask4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTask4.Location = New System.Drawing.Point(-1, 138)
        Me.btnTask4.Name = "btnTask4"
        Me.btnTask4.Size = New System.Drawing.Size(335, 35)
        Me.btnTask4.TabIndex = 7
        Me.btnTask4.UseVisualStyleBackColor = False
        '
        'btnTask5
        '
        Me.btnTask5.BackColor = System.Drawing.Color.Firebrick
        Me.btnTask5.FlatAppearance.BorderSize = 0
        Me.btnTask5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTask5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTask5.Location = New System.Drawing.Point(-1, 171)
        Me.btnTask5.Name = "btnTask5"
        Me.btnTask5.Size = New System.Drawing.Size(335, 35)
        Me.btnTask5.TabIndex = 8
        Me.btnTask5.UseVisualStyleBackColor = False
        '
        'btnTask6
        '
        Me.btnTask6.BackColor = System.Drawing.Color.Firebrick
        Me.btnTask6.FlatAppearance.BorderSize = 0
        Me.btnTask6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTask6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTask6.Location = New System.Drawing.Point(-1, 203)
        Me.btnTask6.Name = "btnTask6"
        Me.btnTask6.Size = New System.Drawing.Size(335, 35)
        Me.btnTask6.TabIndex = 9
        Me.btnTask6.UseVisualStyleBackColor = False
        '
        'btnTask7
        '
        Me.btnTask7.BackColor = System.Drawing.Color.Firebrick
        Me.btnTask7.FlatAppearance.BorderSize = 0
        Me.btnTask7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTask7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTask7.Location = New System.Drawing.Point(-1, 236)
        Me.btnTask7.Name = "btnTask7"
        Me.btnTask7.Size = New System.Drawing.Size(335, 35)
        Me.btnTask7.TabIndex = 10
        Me.btnTask7.UseVisualStyleBackColor = False
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.BackgroundImage = Global.frmSplashScreen_PocketPal.My.Resources.Resources.CloseRed
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picClose.Location = New System.Drawing.Point(23, 9)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(20, 20)
        Me.picClose.TabIndex = 12
        Me.picClose.TabStop = False
        '
        'frmTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(473, 296)
        Me.Controls.Add(Me.btnTask7)
        Me.Controls.Add(Me.btnTask6)
        Me.Controls.Add(Me.btnTask5)
        Me.Controls.Add(Me.btnTask4)
        Me.Controls.Add(Me.btnTask3)
        Me.Controls.Add(Me.btnTask2)
        Me.Controls.Add(Me.btnTask1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.pnlView)
        Me.Controls.Add(Me.pnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTasks"
        Me.Text = "Tasks"
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.pnlView.ResumeLayout(False)
        Me.pnlView.PerformLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents pnlView As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnTask1 As Button
    Friend WithEvents btnTask2 As Button
    Friend WithEvents btnTask3 As Button
    Friend WithEvents btnTask4 As Button
    Friend WithEvents btnTask5 As Button
    Friend WithEvents btnTask6 As Button
    Friend WithEvents btnTask7 As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents picClose As PictureBox
End Class
