Public Class frmCalories2
    Dim height As Decimal
    Dim weight As Decimal
    Dim answer As Decimal
    Dim weightInput As String
    Dim heightInput As String
    Dim errorCheck As Boolean

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If rdbMetric.Checked = True Then

            Do
                weightInput = InputBox("Please Enter your Weight in Kilograms", "Weight", "50",)
                If IsNumeric(weightInput) = True Then
                    If weightInput.Length <= 3 Then
                        weight = CDec(weightInput)
                        errorCheck = True
                    Else
                        MessageBox.Show("Please Enter A Valid Weight In Kilograms. Max is 3 digits.", "Error", MessageBoxButtons.OK)
                    End If
                Else
                    MessageBox.Show("Please Enter A Valid Weight In Kilograms", "Error", MessageBoxButtons.OK)
                End If
            Loop Until errorCheck = True
            errorCheck = False
            Do
                heightInput = InputBox("Please Enter your Height in Meters", "Height", "1.3",)
                If IsNumeric(heightInput) = True Then
                    If heightInput.Length <= 3 Then
                        height = CDec(heightInput)
                        errorCheck = True
                    Else
                        MessageBox.Show("Please Enter A Valid Height In Meters. Max is 2 digits.", "Error", MessageBoxButtons.OK)
                    End If
                Else
                    MessageBox.Show("Please Enter A Valid Height In Meters", "Error", MessageBoxButtons.OK)
                End If
            Loop Until errorCheck = True
            errorCheck = False
            answer = ((weight / height) / height)
            answer = Math.Round(answer, 1)
            lblAnswer.Text = "Your BMI Count Is " & answer & "."
            Call WeightCat(answer)
        End If

            If rdbStandard.Checked = True Then
            Do
                weightInput = InputBox("Please Enter your Weight in Pounds", "Weight", "125",)
                If IsNumeric(weightInput) = True Then
                    If weightInput.Length <= 3 Then
                        weight = CDec(weightInput)
                        errorCheck = True
                    Else
                        MessageBox.Show("Please Enter A Valid Weight In Pounds. Max is 3 digits.", "Error", MessageBoxButtons.OK)
                    End If
                Else
                    MessageBox.Show("Please Enter A Valid Weight In Pounds", "Error", MessageBoxButtons.OK)
                End If
            Loop Until errorCheck = True
            Do
                heightInput = InputBox("Please Enter your Height in Inches", "Height", "63",)
                If IsNumeric(heightInput) = True Then
                    If heightInput.Length <= 3 Then
                        height = CDec(heightInput)
                        errorCheck = True
                    Else
                        MessageBox.Show("Please Enter A Valid Height In Inches. Max is 3 digits.", "Error", MessageBoxButtons.OK)
                    End If
                Else
                    MessageBox.Show("Please Enter A Valid Height In Inches", "Error", MessageBoxButtons.OK)
                End If
            Loop Until errorCheck = True
            weight = weight * 0.45
            height = height * 0.025
            height = height * height
            answer = weight / height
            answer = Math.Round(answer, 1)
            lblAnswer.Text = "Your BMI Count Is " & answer & "."
            Call WeightCat(answer)

        End If
    End Sub

    Private Sub frmCalories2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdbMetric.Checked = True
        pnlWhatIsBMI.Hide()
    End Sub

    'This Procedure Checks What Weight Category The User Is Based On Ther BMI
    Private Sub WeightCat(bmiAnswer As Decimal)
        Select Case bmiAnswer
            Case 0 To 18.4
                lblAnswer.Text &= vbNewLine & "This is considered to be Underweight!"
                lblAnswer.ForeColor = Color.Red
            Case 18.5 To 24.9
                lblAnswer.Text &= vbNewLine & "This is considered to be Normal weight!"
                lblAnswer.ForeColor = Color.Green

            Case 25 To 29.9
                lblAnswer.Text &= vbNewLine & "This is considered to be Overweight!"
                lblAnswer.ForeColor = Color.Yellow
            Case >= 30
                lblAnswer.Text &= vbNewLine & "This is considered to be OBESE!!!"
                lblAnswer.ForeColor = Color.Red


        End Select

    End Sub

    Private Sub btnWhatIsIt_Click(sender As Object, e As EventArgs) Handles btnWhatBMI.Click
        pnlWhatIsBMI.Visible = True

    End Sub
    Private Sub Back(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlWhatIsBMI.Hide()
    End Sub

    Private Sub btnItem_Click(sender As Object, e As EventArgs) Handles btnItem.Click
        frmCalories3.Show()
        Me.Hide()
    End Sub

    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        frmCalories1.Show()
        Me.Hide()
    End Sub

End Class