Public Class frmCalories1
    Dim newgoalinput As String
    Dim errorCheck As Boolean


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If newGoal = 0 Then
            Exit Sub
        End If
        Call CheckGoal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewGoal.Click
        Do
            newgoalinput = InputBox("Please enter an new daily calorie goal", "New Goal", "2000",)
            If IsNumeric(newgoalinput) = True Then
                If newgoalinput > 0 Then
                    newGoal = CInt(newgoalinput)
                    errorCheck = True
                Else
                    MessageBox.Show("Please Enter A Valid Goal (Must Be Greater Then 0)", "Error", MessageBoxButtons.OK)
                End If
            Else
                    MessageBox.Show("Please Enter A Valid Goal", "Error", MessageBoxButtons.OK)
            End If
        Loop Until errorCheck = True
        errorCheck = False
        Call CheckGoal()
    End Sub

    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        frmCalories2.Show()
        Me.Hide()
    End Sub

    Private Sub btnItem_Click(sender As Object, e As EventArgs) Handles btnItem.Click
        frmCalories3.Show()
        Me.Close()
    End Sub
    'This Procedure Fills The Progress Bar And Checks If The User Has Reached Their Calorie Goal
    Private Sub CheckGoal()
        If newGoal > TotalCalories Then
            pgbGoalIntake.Maximum = newGoal
            pgbGoalIntake.Value = TotalCalories
            lblConsume.Text = TotalCalories
            lblHowMany.Text = CStr(newGoal - TotalCalories)
        ElseIf newGoal <= TotalCalories Then
            pgbGoalIntake.Maximum = newGoal
            pgbGoalIntake.Value = newGoal
            lblConsume.Text = TotalCalories
            lblHowMany.Text = "0"
            MessageBox.Show("Warning You Have Already Reached Your Calorie Goal", "Warning", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Hide()
    End Sub
End Class
