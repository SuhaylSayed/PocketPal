<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPocketPal_Contacts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPocketPal_Contacts))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lstContacts = New System.Windows.Forms.ListBox()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pnlContactDetails = New System.Windows.Forms.Panel()
        Me.lstDetails = New System.Windows.Forms.ListBox()
        Me.pnlDetailButtons = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.pnlContactDetails.SuspendLayout()
        Me.pnlDetailButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pnlTop.Controls.Add(Me.picMinimize)
        Me.pnlTop.Controls.Add(Me.picClose)
        Me.pnlTop.Location = New System.Drawing.Point(-2, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(270, 45)
        Me.pnlTop.TabIndex = 1
        '
        'picMinimize
        '
        Me.picMinimize.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid
        Me.picMinimize.BackColor = System.Drawing.Color.Transparent
        Me.picMinimize.BackgroundImage = CType(resources.GetObject("picMinimize.BackgroundImage"), System.Drawing.Image)
        Me.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMinimize.Location = New System.Drawing.Point(29, 3)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(20, 20)
        Me.picMinimize.TabIndex = 27
        Me.picMinimize.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.BackgroundImage = CType(resources.GetObject("picClose.BackgroundImage"), System.Drawing.Image)
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picClose.Location = New System.Drawing.Point(3, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(18, 18)
        Me.picClose.TabIndex = 26
        Me.picClose.TabStop = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Controls.Add(Me.lstContacts)
        Me.pnlMain.Controls.Add(Me.pnlButtons)
        Me.pnlMain.Location = New System.Drawing.Point(12, 51)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(242, 387)
        Me.pnlMain.TabIndex = 2
        '
        'lstContacts
        '
        Me.lstContacts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstContacts.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstContacts.FormattingEnabled = True
        Me.lstContacts.ItemHeight = 21
        Me.lstContacts.Location = New System.Drawing.Point(12, 11)
        Me.lstContacts.Name = "lstContacts"
        Me.lstContacts.Size = New System.Drawing.Size(219, 315)
        Me.lstContacts.TabIndex = 3
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.Turquoise
        Me.pnlButtons.Controls.Add(Me.btnRemove)
        Me.pnlButtons.Controls.Add(Me.btnAdd)
        Me.pnlButtons.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlButtons.Location = New System.Drawing.Point(12, 333)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(219, 41)
        Me.pnlButtons.TabIndex = 5
        '
        'btnRemove
        '
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(116, 3)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 35)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 35)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'pnlContactDetails
        '
        Me.pnlContactDetails.BackColor = System.Drawing.Color.White
        Me.pnlContactDetails.Controls.Add(Me.lstDetails)
        Me.pnlContactDetails.Controls.Add(Me.pnlDetailButtons)
        Me.pnlContactDetails.Location = New System.Drawing.Point(12, 51)
        Me.pnlContactDetails.Name = "pnlContactDetails"
        Me.pnlContactDetails.Size = New System.Drawing.Size(242, 387)
        Me.pnlContactDetails.TabIndex = 6
        '
        'lstDetails
        '
        Me.lstDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstDetails.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDetails.FormattingEnabled = True
        Me.lstDetails.ItemHeight = 16
        Me.lstDetails.Location = New System.Drawing.Point(12, 11)
        Me.lstDetails.Name = "lstDetails"
        Me.lstDetails.Size = New System.Drawing.Size(219, 304)
        Me.lstDetails.TabIndex = 3
        '
        'pnlDetailButtons
        '
        Me.pnlDetailButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.pnlDetailButtons.Controls.Add(Me.btnBack)
        Me.pnlDetailButtons.Controls.Add(Me.btnView)
        Me.pnlDetailButtons.Font = New System.Drawing.Font("Myanmar Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDetailButtons.Location = New System.Drawing.Point(12, 333)
        Me.pnlDetailButtons.Name = "pnlDetailButtons"
        Me.pnlDetailButtons.Size = New System.Drawing.Size(219, 41)
        Me.pnlDetailButtons.TabIndex = 5
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(3, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(78, 35)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.FlatAppearance.BorderSize = 0
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Myanmar Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(79, 6)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(137, 32)
        Me.btnView.TabIndex = 5
        Me.btnView.Text = "View Contact"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'frmPocketPal_Contacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(269, 450)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlContactDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPocketPal_Contacts"
        Me.Text = "Contacts"
        Me.pnlTop.ResumeLayout(False)
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlContactDetails.ResumeLayout(False)
        Me.pnlDetailButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lstContacts As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents picMinimize As PictureBox
    Friend WithEvents picClose As PictureBox
    Friend WithEvents pnlContactDetails As Panel
    Friend WithEvents lstDetails As ListBox
    Friend WithEvents pnlDetailButtons As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnView As Button
End Class
