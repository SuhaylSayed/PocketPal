Imports NCalc
Public Class frmCal1
    Dim clear, buttonType As Boolean
    Dim toMany As Integer
    Dim answer, a As Single
    Dim invalidEquation, invalidFunction As Boolean
    Private Sub allNumbers(sender As Object, e As EventArgs) Handles btn0.Click, btnAns.Click, btnRoot.Click, btnCos.Click, btnTan.Click, btn1.Click, btn2.Click, btn4.Click, btn3.Click, btn5.Click, btnDelete.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnAdd.Click, btnSubract.Click, btnMultiply.Click, btnDivide.Click, btnClear.Click, btnDec.Click, btnEqual.Click, btnSin.Click
        Dim masterButton As Button = sender
        buttonType = False
        If clear = True Then
            txtAnswer.Clear()
            clear = False

            If masterButton.Name = "btnDelete" Or masterButton.Name = "btnEqual" Or masterButton.Name = "btnClear" Then
            buttonType = True
        End If
        If txtAnswer.TextLength > 14 And buttonType = False Then
            txtAnswer.Text = "ERROR; TO MANY NUMBERS"
            clear = True
            Exit Sub
        End If
        If masterButton.Name = "btnRoot" Then
            Dim rootVal As Integer = CInt(InputBox("What number would you like to find the root of?", "Root"))
            Dim a As Single = Math.Sqrt(rootVal)
            Dim TextCheck As String = txtAnswer.Text
            a = Math.Round(a, 2)
            a = CStr(a)
            Call CheckSignBeforeVal(TextCheck, a)
        End If
        If masterButton.Name = "btnAns" Then
            Dim TextCheck As String = txtAnswer.Text
            If TextCheck = Nothing Then
                Call CalcInputs(answer)
            ElseIf TextCheck(TextCheck.Length - 1) = "+" Or TextCheck(TextCheck.Length - 1) = "-" Or TextCheck(TextCheck.Length - 1) = "*" Or TextCheck(TextCheck.Length - 1) = "/" Then
                Call CalcInputs(answer)
            Else
                txtAnswer.Text += "*"
                Call CalcInputs(answer)
            End If
        End If
        If masterButton.Name = "btn1" Then
            Call CalcInputs(1)
        End If
        If masterButton.Name = "btn2" Then
            Call CalcInputs(2)
        End If
        If masterButton.Name = "btn3" Then
            Call CalcInputs(3)
        End If
        If masterButton.Name = "btn4" Then
            Call CalcInputs(4)
        End If
        If masterButton.Name = "btn5" Then
            Call CalcInputs(5)
        End If
        If masterButton.Name = "btn6" Then
            Call CalcInputs(6)
        End If
        If masterButton.Name = "btn7" Then
            Call CalcInputs(7)
        End If
        If masterButton.Name = "btn8" Then
            Call CalcInputs(8)
        End If
        If masterButton.Name = "btn9" Then
            Call CalcInputs(9)
        End If
        If masterButton.Name = "btn0" Then
            Call CalcInputs(0)
        End If
        If masterButton.Name = "btnMultiply" Then
            Call CalcInputs("*")
        End If
        If masterButton.Name = "btnDivide" Then
            Call CalcInputs("/")
        End If
        If masterButton.Name = "btnAdd" Then
            Call CalcInputs("+")
        End If
        If masterButton.Name = "btnClear" Then
            txtAnswer.Clear()
        End If
        If masterButton.Name = "btnDec" Then
            Call CalcInputs(".")
        End If

        If masterButton.Name = "btnSubract" Then
            Call CalcInputs("-")
        End If
        If masterButton.Name = "btnDelete" Then
            Dim str As String
            str = txtAnswer.Text
            If str.Length > 0 Then
                str = str.Remove(str.Length - 1)
                txtAnswer.Text = str
            Else
                txtAnswer.Text = "ERROR; NOTHING TO DELETE"
                clear = True
            End If
        End If

        If masterButton.Name = "btnSin" Then
            Do
                invalidFunction = True
                Try
                    Dim sinVal As Integer = CInt(InputBox("What number would you like to find the sine value of?", "Sine"))
                    a = Math.Sin(sinVal)
                Catch
                    MessageBox.Show("Invalid Tangent Input, Please Try Again", "Error", MessageBoxButtons.OK)
                    invalidFunction = False
                End Try
            Loop Until invalidFunction = True
            a = Math.Round(a, 2)
            a = CStr(a)
            Dim TextCheck As String = txtAnswer.Text
            Call CheckSignBeforeVal(TextCheck, a)
        End If

        If masterButton.Name = "btnCos" Then
            Do
                invalidFunction = True
                Try
                    Dim cosVal As Integer = CInt(InputBox("What number would you like to find the cosine value of?", "Cos"))

                    a = Math.Cos(cosVal)
                Catch
                    MessageBox.Show("Invalid Cos Input, Please Try Again", "Error", MessageBoxButtons.OK)
                    invalidFunction = False
                End Try
            Loop Until invalidFunction = True
            invalidFunction = False
            a = Math.Round(a, 2)
            a = CStr(a)
            Dim TextCheck As String = txtAnswer.Text
            Call CheckSignBeforeVal(TextCheck, a)
        End If

        If masterButton.Name = "btnTan" Then
            Do
                invalidFunction = True
                Try
                    Dim tanVal As Integer = CInt(InputBox("What number would you like to find the tangent value of?", "Tan"))

                    a = Math.Tan(tanVal)
                Catch
                    MessageBox.Show("Invalid Tangent Input, Please Try Again", "Error", MessageBoxButtons.OK)
                    invalidFunction = False
                End Try
            Loop Until invalidFunction = True
            invalidFunction = False
            a = Math.Round(a, 2)
            a = CStr(a)
            Dim TextCheck As String = txtAnswer.Text
            Call CheckSignBeforeVal(TextCheck, a)
        End If

        If masterButton.Name = "btnEqual" Then
            Dim equation As String = txtAnswer.Text
            Try
                Dim a As Expression = New Expression(equation)
                answer = a.Evaluate()
            Catch
                txtAnswer.Text = "ERROR; INVALID EQUATION"
                invalidEquation = True
            End Try
            If invalidEquation = False Then
                txtAnswer.Text &= vbNewLine
                answer = Math.Round(answer, 2)
                answer = CStr(answer)
                txtAnswer.Text &= answer
                clear = True
            Else
                invalidEquation = False
                Exit Sub
            End If
        End If
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Hide()
    End Sub

    'This Procedure add the users input onto the equation screen.
    Private Sub CalcInputs(numInput As String)
        txtAnswer.Text = txtAnswer.Text & numInput
    End Sub

    Private Sub btnPractise_Click(sender As Object, e As EventArgs) Handles btnPractise.Click
        frmCalc2.Show()
        Me.Close()

    End Sub

    'This Procedure Check If When The User Inputs A Trig Ratio Or Square Root That There Is An Operation Ahead Of It. If Not It Adds Multiplication Sign.
    Private Sub CheckSignBeforeVal(stringInput As String, numberValue As String)
        If stringInput = Nothing Then
            txtAnswer.Text += numberValue
        ElseIf stringInput(stringInput.Length - 1) = "+" Or stringInput(stringInput.Length - 1) = "-" Or stringInput(stringInput.Length - 1) = "*" Or stringInput(stringInput.Length - 1) = "/" Then
            txtAnswer.Text += numberValue
        Else
            txtAnswer.Text += "*"
            txtAnswer.Text += numberValue
        End If
    End Sub

End Class

