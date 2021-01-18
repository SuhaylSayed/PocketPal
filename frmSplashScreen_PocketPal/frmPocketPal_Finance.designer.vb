<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPocketPal_Finance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPocketPal_Finance))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.btnPanelSpendings = New System.Windows.Forms.Button()
        Me.btnPanelGoals = New System.Windows.Forms.Button()
        Me.btnPanelIncome = New System.Windows.Forms.Button()
        Me.btnBalance = New System.Windows.Forms.Button()
        Me.lblIncomeTitle = New System.Windows.Forms.Label()
        Me.lblIncomeSubTitle = New System.Windows.Forms.Label()
        Me.btnExpense = New System.Windows.Forms.Button()
        Me.prgExpense = New System.Windows.Forms.ProgressBar()
        Me.lblExpense = New System.Windows.Forms.Label()
        Me.prgBalance = New System.Windows.Forms.ProgressBar()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.pnlIncome = New System.Windows.Forms.Panel()
        Me.lblBalanceValue = New System.Windows.Forms.Label()
        Me.lblExpenseValue = New System.Windows.Forms.Label()
        Me.txtExpense = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.pnlGoal = New System.Windows.Forms.Panel()
        Me.btnAddGoal = New System.Windows.Forms.Button()
        Me.lblGoalProgress = New System.Windows.Forms.Label()
        Me.prgGoal = New System.Windows.Forms.ProgressBar()
        Me.pnlSpendings = New System.Windows.Forms.Panel()
        Me.btnChartTransportation = New System.Windows.Forms.Button()
        Me.btnChartHousing = New System.Windows.Forms.Button()
        Me.btnChartShopping = New System.Windows.Forms.Button()
        Me.btnChartEntertainment = New System.Windows.Forms.Button()
        Me.btnChartFood = New System.Windows.Forms.Button()
        Me.chartSpendings = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlTop.SuspendLayout()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlIncome.SuspendLayout()
        Me.pnlGoal.SuspendLayout()
        Me.pnlSpendings.SuspendLayout()
        CType(Me.chartSpendings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.picMinimize)
        Me.pnlTop.Controls.Add(Me.picClose)
        Me.pnlTop.Controls.Add(Me.btnPanelSpendings)
        Me.pnlTop.Controls.Add(Me.btnPanelGoals)
        Me.pnlTop.Controls.Add(Me.btnPanelIncome)
        Me.pnlTop.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(470, 70)
        Me.pnlTop.TabIndex = 0
        '
        'picMinimize
        '
        Me.picMinimize.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid
        Me.picMinimize.BackColor = System.Drawing.Color.Transparent
        Me.picMinimize.BackgroundImage = CType(resources.GetObject("picMinimize.BackgroundImage"), System.Drawing.Image)
        Me.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMinimize.Location = New System.Drawing.Point(32, 6)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(20, 20)
        Me.picMinimize.TabIndex = 25
        Me.picMinimize.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.Transparent
        Me.picClose.BackgroundImage = CType(resources.GetObject("picClose.BackgroundImage"), System.Drawing.Image)
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picClose.Location = New System.Drawing.Point(6, 6)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(18, 18)
        Me.picClose.TabIndex = 24
        Me.picClose.TabStop = False
        '
        'btnPanelSpendings
        '
        Me.btnPanelSpendings.BackColor = System.Drawing.Color.Transparent
        Me.btnPanelSpendings.FlatAppearance.BorderSize = 0
        Me.btnPanelSpendings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnPanelSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPanelSpendings.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPanelSpendings.ForeColor = System.Drawing.Color.White
        Me.btnPanelSpendings.Location = New System.Drawing.Point(321, 35)
        Me.btnPanelSpendings.Name = "btnPanelSpendings"
        Me.btnPanelSpendings.Size = New System.Drawing.Size(149, 31)
        Me.btnPanelSpendings.TabIndex = 24
        Me.btnPanelSpendings.Tag = "3"
        Me.btnPanelSpendings.Text = "Spendings"
        Me.btnPanelSpendings.UseVisualStyleBackColor = False
        '
        'btnPanelGoals
        '
        Me.btnPanelGoals.BackColor = System.Drawing.Color.Transparent
        Me.btnPanelGoals.FlatAppearance.BorderSize = 0
        Me.btnPanelGoals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnPanelGoals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPanelGoals.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPanelGoals.ForeColor = System.Drawing.Color.White
        Me.btnPanelGoals.Location = New System.Drawing.Point(220, 35)
        Me.btnPanelGoals.Name = "btnPanelGoals"
        Me.btnPanelGoals.Size = New System.Drawing.Size(107, 31)
        Me.btnPanelGoals.TabIndex = 23
        Me.btnPanelGoals.Tag = "2"
        Me.btnPanelGoals.Text = "Goals"
        Me.btnPanelGoals.UseVisualStyleBackColor = False
        '
        'btnPanelIncome
        '
        Me.btnPanelIncome.BackColor = System.Drawing.Color.Transparent
        Me.btnPanelIncome.FlatAppearance.BorderSize = 0
        Me.btnPanelIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnPanelIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPanelIncome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPanelIncome.ForeColor = System.Drawing.Color.White
        Me.btnPanelIncome.Location = New System.Drawing.Point(3, 35)
        Me.btnPanelIncome.Name = "btnPanelIncome"
        Me.btnPanelIncome.Size = New System.Drawing.Size(213, 31)
        Me.btnPanelIncome.TabIndex = 22
        Me.btnPanelIncome.Tag = "1"
        Me.btnPanelIncome.Text = "Income and Expenses"
        Me.btnPanelIncome.UseVisualStyleBackColor = False
        '
        'btnBalance
        '
        Me.btnBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnBalance.Enabled = False
        Me.btnBalance.FlatAppearance.BorderSize = 0
        Me.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBalance.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalance.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBalance.Location = New System.Drawing.Point(325, 133)
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(115, 23)
        Me.btnBalance.TabIndex = 5
        Me.btnBalance.Text = "Add Balance"
        Me.btnBalance.UseVisualStyleBackColor = False
        '
        'lblIncomeTitle
        '
        Me.lblIncomeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncomeTitle.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblIncomeTitle.Location = New System.Drawing.Point(259, 13)
        Me.lblIncomeTitle.Name = "lblIncomeTitle"
        Me.lblIncomeTitle.Size = New System.Drawing.Size(178, 25)
        Me.lblIncomeTitle.TabIndex = 0
        Me.lblIncomeTitle.Text = "CAD$0.00"
        Me.lblIncomeTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIncomeSubTitle
        '
        Me.lblIncomeSubTitle.AutoSize = True
        Me.lblIncomeSubTitle.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncomeSubTitle.ForeColor = System.Drawing.Color.Black
        Me.lblIncomeSubTitle.Location = New System.Drawing.Point(6, 13)
        Me.lblIncomeSubTitle.Name = "lblIncomeSubTitle"
        Me.lblIncomeSubTitle.Size = New System.Drawing.Size(247, 19)
        Me.lblIncomeSubTitle.TabIndex = 1
        Me.lblIncomeSubTitle.Text = "You have this much in your account:"
        '
        'btnExpense
        '
        Me.btnExpense.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.btnExpense.Enabled = False
        Me.btnExpense.FlatAppearance.BorderSize = 0
        Me.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpense.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpense.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExpense.Location = New System.Drawing.Point(325, 162)
        Me.btnExpense.Name = "btnExpense"
        Me.btnExpense.Size = New System.Drawing.Size(116, 23)
        Me.btnExpense.TabIndex = 8
        Me.btnExpense.Text = "Add Expense"
        Me.btnExpense.UseVisualStyleBackColor = False
        '
        'prgExpense
        '
        Me.prgExpense.BackColor = System.Drawing.Color.White
        Me.prgExpense.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.prgExpense.Location = New System.Drawing.Point(6, 99)
        Me.prgExpense.Name = "prgExpense"
        Me.prgExpense.Size = New System.Drawing.Size(435, 23)
        Me.prgExpense.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgExpense.TabIndex = 10
        '
        'lblExpense
        '
        Me.lblExpense.AutoSize = True
        Me.lblExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpense.ForeColor = System.Drawing.Color.DimGray
        Me.lblExpense.Location = New System.Drawing.Point(5, 83)
        Me.lblExpense.Name = "lblExpense"
        Me.lblExpense.Size = New System.Drawing.Size(65, 13)
        Me.lblExpense.TabIndex = 11
        Me.lblExpense.Text = "Expenses:"
        '
        'prgBalance
        '
        Me.prgBalance.BackColor = System.Drawing.Color.White
        Me.prgBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.prgBalance.Location = New System.Drawing.Point(6, 59)
        Me.prgBalance.Name = "prgBalance"
        Me.prgBalance.Size = New System.Drawing.Size(435, 23)
        Me.prgBalance.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgBalance.TabIndex = 14
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.DimGray
        Me.lblBalance.Location = New System.Drawing.Point(7, 43)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(61, 13)
        Me.lblBalance.TabIndex = 15
        Me.lblBalance.Text = "Balance: "
        '
        'pnlIncome
        '
        Me.pnlIncome.BackColor = System.Drawing.Color.White
        Me.pnlIncome.Controls.Add(Me.lblBalanceValue)
        Me.pnlIncome.Controls.Add(Me.lblExpenseValue)
        Me.pnlIncome.Controls.Add(Me.txtExpense)
        Me.pnlIncome.Controls.Add(Me.txtBalance)
        Me.pnlIncome.Controls.Add(Me.lblBalance)
        Me.pnlIncome.Controls.Add(Me.prgBalance)
        Me.pnlIncome.Controls.Add(Me.lblExpense)
        Me.pnlIncome.Controls.Add(Me.prgExpense)
        Me.pnlIncome.Controls.Add(Me.btnExpense)
        Me.pnlIncome.Controls.Add(Me.lblIncomeSubTitle)
        Me.pnlIncome.Controls.Add(Me.lblIncomeTitle)
        Me.pnlIncome.Controls.Add(Me.btnBalance)
        Me.pnlIncome.Location = New System.Drawing.Point(12, 84)
        Me.pnlIncome.Name = "pnlIncome"
        Me.pnlIncome.Size = New System.Drawing.Size(445, 200)
        Me.pnlIncome.TabIndex = 1
        '
        'lblBalanceValue
        '
        Me.lblBalanceValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.lblBalanceValue.Location = New System.Drawing.Point(263, 43)
        Me.lblBalanceValue.Name = "lblBalanceValue"
        Me.lblBalanceValue.Size = New System.Drawing.Size(178, 13)
        Me.lblBalanceValue.TabIndex = 19
        Me.lblBalanceValue.Text = "CAD $0.00"
        Me.lblBalanceValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblExpenseValue
        '
        Me.lblExpenseValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpenseValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.lblExpenseValue.Location = New System.Drawing.Point(262, 83)
        Me.lblExpenseValue.Name = "lblExpenseValue"
        Me.lblExpenseValue.Size = New System.Drawing.Size(178, 13)
        Me.lblExpenseValue.TabIndex = 18
        Me.lblExpenseValue.Text = "CAD $0.00"
        Me.lblExpenseValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtExpense
        '
        Me.txtExpense.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.txtExpense.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpense.ForeColor = System.Drawing.Color.White
        Me.txtExpense.Location = New System.Drawing.Point(6, 162)
        Me.txtExpense.Multiline = True
        Me.txtExpense.Name = "txtExpense"
        Me.txtExpense.Size = New System.Drawing.Size(320, 23)
        Me.txtExpense.TabIndex = 17
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.Color.White
        Me.txtBalance.Location = New System.Drawing.Point(6, 133)
        Me.txtBalance.Multiline = True
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(320, 23)
        Me.txtBalance.TabIndex = 16
        '
        'pnlGoal
        '
        Me.pnlGoal.BackColor = System.Drawing.Color.White
        Me.pnlGoal.Controls.Add(Me.btnAddGoal)
        Me.pnlGoal.Controls.Add(Me.lblGoalProgress)
        Me.pnlGoal.Controls.Add(Me.prgGoal)
        Me.pnlGoal.Location = New System.Drawing.Point(12, 84)
        Me.pnlGoal.Name = "pnlGoal"
        Me.pnlGoal.Size = New System.Drawing.Size(445, 200)
        Me.pnlGoal.TabIndex = 20
        '
        'btnAddGoal
        '
        Me.btnAddGoal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnAddGoal.FlatAppearance.BorderSize = 0
        Me.btnAddGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddGoal.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddGoal.ForeColor = System.Drawing.Color.White
        Me.btnAddGoal.Location = New System.Drawing.Point(15, 59)
        Me.btnAddGoal.Name = "btnAddGoal"
        Me.btnAddGoal.Size = New System.Drawing.Size(416, 48)
        Me.btnAddGoal.TabIndex = 25
        Me.btnAddGoal.Tag = "2"
        Me.btnAddGoal.Text = "Add a New Goal?"
        Me.btnAddGoal.UseVisualStyleBackColor = False
        '
        'lblGoalProgress
        '
        Me.lblGoalProgress.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoalProgress.ForeColor = System.Drawing.Color.Black
        Me.lblGoalProgress.Location = New System.Drawing.Point(18, 11)
        Me.lblGoalProgress.Name = "lblGoalProgress"
        Me.lblGoalProgress.Size = New System.Drawing.Size(413, 45)
        Me.lblGoalProgress.TabIndex = 20
        Me.lblGoalProgress.Text = "You Reached CAD$ 0.00 of Your CAD$ 0.00 Goal!"
        '
        'prgGoal
        '
        Me.prgGoal.BackColor = System.Drawing.Color.White
        Me.prgGoal.ForeColor = System.Drawing.Color.DarkViolet
        Me.prgGoal.Location = New System.Drawing.Point(15, 122)
        Me.prgGoal.Name = "prgGoal"
        Me.prgGoal.Size = New System.Drawing.Size(416, 63)
        Me.prgGoal.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgGoal.TabIndex = 20
        '
        'pnlSpendings
        '
        Me.pnlSpendings.BackColor = System.Drawing.Color.White
        Me.pnlSpendings.Controls.Add(Me.chartSpendings)
        Me.pnlSpendings.Controls.Add(Me.btnChartTransportation)
        Me.pnlSpendings.Controls.Add(Me.btnChartHousing)
        Me.pnlSpendings.Controls.Add(Me.btnChartShopping)
        Me.pnlSpendings.Controls.Add(Me.btnChartEntertainment)
        Me.pnlSpendings.Controls.Add(Me.btnChartFood)
        Me.pnlSpendings.Location = New System.Drawing.Point(12, 84)
        Me.pnlSpendings.Name = "pnlSpendings"
        Me.pnlSpendings.Size = New System.Drawing.Size(445, 203)
        Me.pnlSpendings.TabIndex = 21
        '
        'btnChartTransportation
        '
        Me.btnChartTransportation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnChartTransportation.FlatAppearance.BorderSize = 0
        Me.btnChartTransportation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChartTransportation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChartTransportation.ForeColor = System.Drawing.Color.White
        Me.btnChartTransportation.Location = New System.Drawing.Point(346, 10)
        Me.btnChartTransportation.Name = "btnChartTransportation"
        Me.btnChartTransportation.Size = New System.Drawing.Size(93, 37)
        Me.btnChartTransportation.TabIndex = 33
        Me.btnChartTransportation.Tag = "1"
        Me.btnChartTransportation.Text = "Add Transportation"
        Me.btnChartTransportation.UseVisualStyleBackColor = False
        '
        'btnChartHousing
        '
        Me.btnChartHousing.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnChartHousing.FlatAppearance.BorderSize = 0
        Me.btnChartHousing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChartHousing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChartHousing.ForeColor = System.Drawing.Color.White
        Me.btnChartHousing.Location = New System.Drawing.Point(346, 80)
        Me.btnChartHousing.Name = "btnChartHousing"
        Me.btnChartHousing.Size = New System.Drawing.Size(93, 28)
        Me.btnChartHousing.TabIndex = 31
        Me.btnChartHousing.Tag = "3"
        Me.btnChartHousing.Text = "Add Housing"
        Me.btnChartHousing.UseVisualStyleBackColor = False
        '
        'btnChartShopping
        '
        Me.btnChartShopping.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnChartShopping.FlatAppearance.BorderSize = 0
        Me.btnChartShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChartShopping.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChartShopping.ForeColor = System.Drawing.Color.White
        Me.btnChartShopping.Location = New System.Drawing.Point(346, 114)
        Me.btnChartShopping.Name = "btnChartShopping"
        Me.btnChartShopping.Size = New System.Drawing.Size(93, 33)
        Me.btnChartShopping.TabIndex = 30
        Me.btnChartShopping.Tag = "4"
        Me.btnChartShopping.Text = "Add Shopping"
        Me.btnChartShopping.UseVisualStyleBackColor = False
        '
        'btnChartEntertainment
        '
        Me.btnChartEntertainment.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnChartEntertainment.FlatAppearance.BorderSize = 0
        Me.btnChartEntertainment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChartEntertainment.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChartEntertainment.ForeColor = System.Drawing.Color.White
        Me.btnChartEntertainment.Location = New System.Drawing.Point(346, 151)
        Me.btnChartEntertainment.Name = "btnChartEntertainment"
        Me.btnChartEntertainment.Size = New System.Drawing.Size(93, 41)
        Me.btnChartEntertainment.TabIndex = 29
        Me.btnChartEntertainment.Tag = "5"
        Me.btnChartEntertainment.Text = "Add Entertainment"
        Me.btnChartEntertainment.UseVisualStyleBackColor = False
        '
        'btnChartFood
        '
        Me.btnChartFood.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnChartFood.FlatAppearance.BorderSize = 0
        Me.btnChartFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChartFood.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChartFood.ForeColor = System.Drawing.Color.White
        Me.btnChartFood.Location = New System.Drawing.Point(346, 53)
        Me.btnChartFood.Name = "btnChartFood"
        Me.btnChartFood.Size = New System.Drawing.Size(93, 22)
        Me.btnChartFood.TabIndex = 27
        Me.btnChartFood.Tag = "2"
        Me.btnChartFood.Text = "Add Food"
        Me.btnChartFood.UseVisualStyleBackColor = False
        '
        'chartSpendings
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartSpendings.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartSpendings.Legends.Add(Legend2)
        Me.chartSpendings.Location = New System.Drawing.Point(10, 10)
        Me.chartSpendings.Name = "chartSpendings"
        Me.chartSpendings.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.chartSpendings.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(202, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(70, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(240, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(255, Byte), Integer))}
        Series2.BackSecondaryColor = System.Drawing.Color.White
        Series2.BorderColor = System.Drawing.Color.White
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series2.Color = System.Drawing.Color.White
        Series2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.LabelBackColor = System.Drawing.Color.Turquoise
        Series2.LabelBorderColor = System.Drawing.Color.Transparent
        Series2.LabelForeColor = System.Drawing.Color.White
        Series2.Legend = "Legend1"
        Series2.Name = "Spendings"
        Me.chartSpendings.Series.Add(Series2)
        Me.chartSpendings.Size = New System.Drawing.Size(321, 172)
        Me.chartSpendings.TabIndex = 34
        Me.chartSpendings.Text = "Chart1"
        '
        'frmPocketPal_Finance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 295)
        Me.Controls.Add(Me.pnlSpendings)
        Me.Controls.Add(Me.pnlGoal)
        Me.Controls.Add(Me.pnlIncome)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPocketPal_Finance"
        Me.Text = "Financial Tracker"
        Me.pnlTop.ResumeLayout(False)
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlIncome.ResumeLayout(False)
        Me.pnlIncome.PerformLayout()
        Me.pnlGoal.ResumeLayout(False)
        Me.pnlSpendings.ResumeLayout(False)
        CType(Me.chartSpendings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnBalance As Button
    Friend WithEvents lblIncomeTitle As Label
    Friend WithEvents lblIncomeSubTitle As Label
    Friend WithEvents btnExpense As Button
    Friend WithEvents prgExpense As ProgressBar
    Friend WithEvents lblExpense As Label
    Friend WithEvents prgBalance As ProgressBar
    Friend WithEvents lblBalance As Label
    Friend WithEvents pnlIncome As Panel
    Friend WithEvents txtExpense As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents lblBalanceValue As Label
    Friend WithEvents lblExpenseValue As Label
    Friend WithEvents pnlGoal As Panel
    Friend WithEvents pnlSpendings As Panel
    Friend WithEvents btnPanelSpendings As Button
    Friend WithEvents btnPanelGoals As Button
    Friend WithEvents btnPanelIncome As Button
    Friend WithEvents btnAddGoal As Button
    Friend WithEvents lblGoalProgress As Label
    Friend WithEvents prgGoal As ProgressBar
    Friend WithEvents picMinimize As PictureBox
    Friend WithEvents picClose As PictureBox
    Friend WithEvents btnChartFood As Button
    Friend WithEvents btnChartTransportation As Button
    Friend WithEvents btnChartHousing As Button
    Friend WithEvents btnChartShopping As Button
    Friend WithEvents btnChartEntertainment As Button
    Friend WithEvents chartSpendings As DataVisualization.Charting.Chart
End Class
