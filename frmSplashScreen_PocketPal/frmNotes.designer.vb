<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotes
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.btnNote6 = New System.Windows.Forms.Button()
        Me.btnNote5 = New System.Windows.Forms.Button()
        Me.btnNote4 = New System.Windows.Forms.Button()
        Me.btnNote3 = New System.Windows.Forms.Button()
        Me.btnNote2 = New System.Windows.Forms.Button()
        Me.btnNote1 = New System.Windows.Forms.Button()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.pnlHeader.SuspendLayout()
        Me.pnlHome.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlHeader.Controls.Add(Me.picClose)
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Controls.Add(Me.btnAdd)
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(505, 48)
        Me.pnlHeader.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBack.Location = New System.Drawing.Point(75, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(45, 35)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = " ←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAdd.Location = New System.Drawing.Point(365, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(40, 35)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(198, 4)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(113, 39)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Notes"
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.Color.SandyBrown
        Me.txtNote.Location = New System.Drawing.Point(12, 54)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(481, 202)
        Me.txtNote.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SandyBrown
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(12, 262)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(481, 55)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'pnlHome
        '
        Me.pnlHome.Controls.Add(Me.btnNote6)
        Me.pnlHome.Controls.Add(Me.btnNote5)
        Me.pnlHome.Controls.Add(Me.btnNote4)
        Me.pnlHome.Controls.Add(Me.btnNote3)
        Me.pnlHome.Controls.Add(Me.btnNote2)
        Me.pnlHome.Controls.Add(Me.btnNote1)
        Me.pnlHome.Location = New System.Drawing.Point(0, 47)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(505, 280)
        Me.pnlHome.TabIndex = 3
        '
        'btnNote6
        '
        Me.btnNote6.BackColor = System.Drawing.Color.Transparent
        Me.btnNote6.FlatAppearance.BorderSize = 0
        Me.btnNote6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnNote6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNote6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNote6.Location = New System.Drawing.Point(0, 225)
        Me.btnNote6.Name = "btnNote6"
        Me.btnNote6.Size = New System.Drawing.Size(505, 45)
        Me.btnNote6.TabIndex = 5
        Me.btnNote6.UseVisualStyleBackColor = False
        '
        'btnNote5
        '
        Me.btnNote5.BackColor = System.Drawing.Color.Transparent
        Me.btnNote5.FlatAppearance.BorderSize = 0
        Me.btnNote5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnNote5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNote5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNote5.Location = New System.Drawing.Point(0, 184)
        Me.btnNote5.Name = "btnNote5"
        Me.btnNote5.Size = New System.Drawing.Size(505, 44)
        Me.btnNote5.TabIndex = 4
        Me.btnNote5.UseVisualStyleBackColor = False
        '
        'btnNote4
        '
        Me.btnNote4.BackColor = System.Drawing.Color.Transparent
        Me.btnNote4.FlatAppearance.BorderSize = 0
        Me.btnNote4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnNote4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNote4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNote4.Location = New System.Drawing.Point(0, 138)
        Me.btnNote4.Name = "btnNote4"
        Me.btnNote4.Size = New System.Drawing.Size(505, 44)
        Me.btnNote4.TabIndex = 3
        Me.btnNote4.UseVisualStyleBackColor = False
        '
        'btnNote3
        '
        Me.btnNote3.BackColor = System.Drawing.Color.Transparent
        Me.btnNote3.FlatAppearance.BorderSize = 0
        Me.btnNote3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnNote3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNote3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNote3.Location = New System.Drawing.Point(0, 92)
        Me.btnNote3.Name = "btnNote3"
        Me.btnNote3.Size = New System.Drawing.Size(505, 44)
        Me.btnNote3.TabIndex = 2
        Me.btnNote3.UseVisualStyleBackColor = False
        '
        'btnNote2
        '
        Me.btnNote2.BackColor = System.Drawing.Color.Transparent
        Me.btnNote2.FlatAppearance.BorderSize = 0
        Me.btnNote2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnNote2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNote2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNote2.Location = New System.Drawing.Point(0, 46)
        Me.btnNote2.Name = "btnNote2"
        Me.btnNote2.Size = New System.Drawing.Size(505, 44)
        Me.btnNote2.TabIndex = 1
        Me.btnNote2.UseVisualStyleBackColor = False
        '
        'btnNote1
        '
        Me.btnNote1.BackColor = System.Drawing.Color.Transparent
        Me.btnNote1.FlatAppearance.BorderSize = 0
        Me.btnNote1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnNote1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNote1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNote1.Location = New System.Drawing.Point(0, -1)
        Me.btnNote1.Name = "btnNote1"
        Me.btnNote1.Size = New System.Drawing.Size(505, 44)
        Me.btnNote1.TabIndex = 0
        Me.btnNote1.UseVisualStyleBackColor = False
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.BackgroundImage = Global.frmSplashScreen_PocketPal.My.Resources.Resources.CloseRed
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picClose.Location = New System.Drawing.Point(22, 12)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(20, 20)
        Me.picClose.TabIndex = 12
        Me.picClose.TabStop = False
        '
        'frmNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(505, 320)
        Me.Controls.Add(Me.pnlHome)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNotes"
        Me.Text = "Notes"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlHome.ResumeLayout(False)
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents pnlHome As Panel
    Friend WithEvents btnNote6 As Button
    Friend WithEvents btnNote5 As Button
    Friend WithEvents btnNote4 As Button
    Friend WithEvents btnNote3 As Button
    Friend WithEvents btnNote2 As Button
    Friend WithEvents btnNote1 As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents picClose As PictureBox
End Class
