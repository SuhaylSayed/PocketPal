<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendar
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
        Me.lsvEvents = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dtpMain = New System.Windows.Forms.DateTimePicker()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboSelectTime = New System.Windows.Forms.ComboBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lsvEvents
        '
        Me.lsvEvents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lsvEvents.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvEvents.Location = New System.Drawing.Point(384, 23)
        Me.lsvEvents.Name = "lsvEvents"
        Me.lsvEvents.Size = New System.Drawing.Size(361, 439)
        Me.lsvEvents.TabIndex = 11
        Me.lsvEvents.UseCompatibleStateImageBehavior = False
        Me.lsvEvents.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Time"
        Me.ColumnHeader1.Width = 170
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Event"
        Me.ColumnHeader2.Width = 275
        '
        'dtpMain
        '
        Me.dtpMain.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMain.Location = New System.Drawing.Point(19, 74)
        Me.dtpMain.Name = "dtpMain"
        Me.dtpMain.Size = New System.Drawing.Size(336, 23)
        Me.dtpMain.TabIndex = 8
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Tomato
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(182, 267)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(166, 72)
        Me.btnRemove.TabIndex = 14
        Me.btnRemove.Text = "Remove Event"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(12, 269)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(166, 69)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add Event"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cboSelectTime
        '
        Me.cboSelectTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectTime.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectTime.FormattingEnabled = True
        Me.cboSelectTime.Items.AddRange(New Object() {"12:00 am", "1:00 am", "2:00 am", "3:00 am", "4:00 am", "5:00 am", "6:00 am", "7:00 am", "8:00 am", "9:00 am", "10:00 am", "11:00 am", "12:00 pm", "1:00 pm", "2:00 pm", "3:00 pm", "4:00 pm", "5:00 pm", "6:00 pm", "7:00 pm", "8:00 pm", "9:00 pm", "10:00 pm", "11:00 pm"})
        Me.cboSelectTime.Location = New System.Drawing.Point(12, 153)
        Me.cboSelectTime.Name = "cboSelectTime"
        Me.cboSelectTime.Size = New System.Drawing.Size(336, 26)
        Me.cboSelectTime.TabIndex = 15
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.BackgroundImage = Global.frmSplashScreen_PocketPal.My.Resources.Resources.CloseRed
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picClose.Location = New System.Drawing.Point(12, 12)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(20, 20)
        Me.picClose.TabIndex = 16
        Me.picClose.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(14, 42)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(72, 25)
        Me.lblDate.TabIndex = 17
        Me.lblDate.Text = "Date:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(14, 125)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(75, 25)
        Me.lblTime.TabIndex = 18
        Me.lblTime.Text = "Time:"
        '
        'frmCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.frmSplashScreen_PocketPal.My.Resources.Resources.CalmColor1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(757, 496)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.cboSelectTime)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lsvEvents)
        Me.Controls.Add(Me.dtpMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCalendar"
        Me.Text = "Form1"
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvEvents As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents dtpMain As DateTimePicker
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents cboSelectTime As ComboBox
    Friend WithEvents picClose As PictureBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
End Class
