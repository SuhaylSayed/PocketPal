'***********************************************************************
'	PROGRAMME NAME  	:	Final Assignment PocketPal
'
'	PROGRAMME OUTLINE	:	This programme allows the user to track their financial spendings.
'                           The program allows the user to do a variety of things such as add their goals, 
'                           balance, spendings, and also get a visual representation of their spendings in the form
'                           of a donut chart.
'
'	PROGRAMMER		    :	Russell Tang
'
'	DATE				:	Nov 21, 2018
'
'***********************************************************************
Public Class frmPocketPal_Finance
    Dim storedIncome As Decimal
    Dim storedExpense As Decimal
    Dim goalNum As Integer
    Private Sub btnIncome_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        Dim input As String

        input = txtBalance.Text
        If Not IsNumeric(input) Then
            input = Nothing
            MessageBox.Show("Invalid Input! Please Try Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsNumeric(input) = True Then
            storedIncome += CDec(input)
        End If

        prgBalance.Maximum = storedIncome
        prgExpense.Maximum = storedIncome
        prgBalance.Value = storedIncome


        If Not goalNum = 0 Then
            Call GoalCheck()
            prgGoal.Value = storedIncome - storedExpense
        End If

        btnBalance.Enabled = False

        lblBalanceValue.Text = "CAD " & FormatCurrency(storedIncome)
        lblIncomeTitle.Text = "CAD " & FormatCurrency(storedIncome)
        lblGoalProgress.Text = "You Reached CAD " & FormatCurrency(storedIncome - storedExpense) & " of Your CAD " & FormatCurrency(goalNum) & " Goal!"

        txtBalance.Clear()

    End Sub

    Private Sub btnExpense_Click(sender As Object, e As EventArgs) Handles btnExpense.Click
        Dim input As String

        input = txtExpense.Text
        If Not IsNumeric(input) Then
            input = Nothing
            MessageBox.Show("Invalid Input! Please Try Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf storedExpense > storedIncome Or (input + storedExpense) > storedIncome Then
            MessageBox.Show("Invalid Input! Your Expenses Can't be Greater Than Your Balance. Please Try Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            input = Nothing
            GoTo Skip
        Else
            storedExpense += CDec(input)
        End If

        prgExpense.Value = storedExpense

        If Not goalNum = 0 Then
            Call GoalCheck()
            prgGoal.Value = storedIncome - storedExpense
        End If

        btnExpense.Enabled = False

Skip:
        lblExpenseValue.Text = "CAD " & FormatCurrency(storedExpense)
        lblIncomeTitle.Text = "CAD " & FormatCurrency(storedIncome - storedExpense)
        lblGoalProgress.Text = "You Have Reached CAD " & FormatCurrency(storedIncome - storedExpense) & " of Your CAD " & FormatCurrency(goalNum) & " Goal!"

        txtExpense.Clear()
    End Sub

    Private Sub txtBalance_TextChanged(sender As Object, e As EventArgs) Handles txtBalance.TextChanged
        btnBalance.Enabled = True
    End Sub

    Private Sub txtExpense_TextChanged(sender As Object, e As EventArgs) Handles txtExpense.TextChanged
        btnExpense.Enabled = True
    End Sub

    Private Sub btnPanelIncome_Click(sender As Object, e As EventArgs) Handles btnPanelIncome.Click, btnPanelGoals.Click, btnPanelSpendings.Click
        Dim btnPanel As Button = sender
        Select Case btnPanel.Tag
            Case 1
                pnlIncome.Visible = True
                pnlGoal.Visible = False
                pnlSpendings.Visible = False
            Case 2
                pnlIncome.Visible = False
                pnlGoal.Visible = True
                pnlSpendings.Visible = False
            Case 3
                pnlIncome.Visible = False
                pnlGoal.Visible = False
                pnlSpendings.Visible = True
        End Select
    End Sub

    Private Sub btnAddGoal_Click(sender As Object, e As EventArgs) Handles btnAddGoal.Click
        Dim input As String
        input = InputBox("Enter a Goal", "Goal")

        If input = "" Then
            input = Nothing
        ElseIf Not IsNumeric(input) Then
            input = Nothing
            MessageBox.Show("Invalid Input! Please Try Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            prgGoal.Maximum = CDec(input)
            goalNum = CDec(input)
        End If

        If Not goalNum = 0 Then
            Call GoalCheck()
            prgGoal.Value = storedIncome - storedExpense
        End If
        lblGoalProgress.Text = "You Have Reached CAD " & FormatCurrency(storedIncome - storedExpense) & " of Your CAD " & FormatCurrency(goalNum) & " Goal!"
    End Sub

    'Thi procedure checks if the user has reached their goal or not
    Sub GoalCheck()
        If (storedIncome - storedExpense) >= goalNum Then
            MessageBox.Show("Congrats on Reaching Your Goal!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            prgGoal.Maximum = storedIncome - storedExpense
            prgGoal.Value = prgGoal.Maximum
            prgGoal.ForeColor = Color.Orange
        End If
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub frmPocketPal_Finance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlIncome.Visible = True
        pnlGoal.Visible = False
        pnlSpendings.Visible = False
    End Sub

    Private Sub btnChartFood_Click(sender As Object, e As EventArgs) Handles btnChartFood.Click, btnChartEntertainment.Click, btnChartHousing.Click, btnChartShopping.Click, btnChartTransportation.Click
        Dim btnChart As Button = sender
        Dim input As String
        Dim chartLabel As String

        input = InputBox("Enter an Amount to Add", "Add Spendings")

        If input = "" Then
            input = 0
            Exit Sub
        ElseIf Not IsNumeric(input) Then
            input = Nothing
            chartLabel = Nothing
            MessageBox.Show("Invalid Input! Please Try Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Select Case btnChart.Tag
            Case 1
                chartLabel = "Transportation " & FormatCurrency(input)
            Case 2
                chartLabel = "Food " & FormatCurrency(input)
            Case 3
                chartLabel = "Housing " & FormatCurrency(input)
            Case 4
                chartLabel = "Shopping " & FormatCurrency(input)
            Case 5
                chartLabel = "Entertainment " & FormatCurrency(input)
        End Select

        If input = "" Then
            input = Nothing
            chartLabel = Nothing
        ElseIf Not IsNumeric(input) Then
            input = Nothing
            chartLabel = Nothing
            MessageBox.Show("Invalid Input! Please Try Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.chartSpendings.Series("Spendings").Points.AddXY(chartLabel, input)
        End If
    End Sub
End Class
