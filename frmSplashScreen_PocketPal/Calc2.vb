Public Class frmCalc2
    Dim rand As New Random
    Dim positiveNum As Boolean
    Dim secondran As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call VisibleNums(False)
        Call Level(True)
        MessageBox.Show("Note that all answers are rounded to the Integer!", "Info", MessageBoxButtons.OK)
    End Sub
    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click, btnMedium.Click, btnHard.Click
        Dim masterButton As Button = sender
        Call VisibleNums(True)
        Call Level(False)
        If masterButton.Name = "btnEasy" Then
            lblOperand2.Text = RandomNum(11)
            Do
                Dim secondnum As Integer = RandomNum(11)
                If secondnum < lblOperand2.Text Then
                    positiveNum = False
                Else
                    lblOperand1.Text = secondnum
                    positiveNum = True
                End If
            Loop Until positiveNum = True
            positiveNum = False
            Select Case RandomNum(3)
                Case 1
                    lblOperator.Text = "+"
                    secondran = 1
                Case 2
                    lblOperator.Text = "-"
                    secondran = 2
            End Select
        End If
        If masterButton.Name = "btnMedium" Then
            lblOperand2.Text = RandomNum(21)
            Do
                Dim secondnum As Integer = RandomNum(21)
                If secondnum < CInt(lblOperand2.Text) Then
                    positiveNum = False
                Else
                    lblOperand1.Text = CStr(secondnum)
                    positiveNum = True
                End If
            Loop Until positiveNum = True
            Select Case RandomNum(4)
                Case 1
                    lblOperator.Text = "+"
                    secondran = 1
                Case 2
                    lblOperator.Text = "-"
                    secondran = 2
                Case 3
                    lblOperator.Text = "*"
                    secondran = 3
            End Select
        End If

        If masterButton.Name = "btnHard" Then
            lblOperand2.Text = RandomNum(31)
            Do
                Dim secondnum As Integer = RandomNum(31)
                If secondnum < CInt(lblOperand2.Text) Then
                    positiveNum = False
                Else
                    lblOperand1.Text = CStr(secondnum)
                    positiveNum = True
                End If
            Loop Until positiveNum = True
            Select Case RandomNum(3)
                Case 1
                    lblOperator.Text = "*"
                    secondran = 3
                Case 2
                    lblOperator.Text = "/"
                    secondran = 4
            End Select
        End If
    End Sub

    'This Function Generates Random Numbers
    Private Function RandomNum(randNum As Integer)
        Return rand.Next(1, randNum)
    End Function

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If txtAnswer.Text = Nothing Then
            MessageBox.Show("Please Submit an Answer", "Error", MessageBoxButtons.OK)
            Exit Sub
        End If
        Call GetAnswer(CInt(lblOperand1.Text), CInt(lblOperand2.Text), secondran, CInt(txtAnswer.Text))
    End Sub

    Private Sub btnDontKnow_Click(sender As Object, e As EventArgs) Handles btnDontKnow.Click

        MessageBox.Show("Alright, The correct answer was " & GetAnswer(CInt(lblOperand1.Text), CInt(lblOperand2.Text), secondran) & " Try Again")
        lblOperand1.Text = Nothing
        lblOperand2.Text = Nothing
        lblOperator.Text = Nothing
        txtAnswer.Text = Nothing
        Call VisibleNums(False)
        Call Level(True)

    End Sub

    Private Sub GetAnswer(operand1 As Integer, operand2 As Integer, operand3 As Integer, useranswer As Integer)
        Dim firstint As Integer = operand1
        Dim secondint As Integer = operand2
        Dim operation As Integer = operand3
        Dim answerPrac As Integer
        Select Case operation
            Case 1
                answerPrac = (firstint + secondint)
            Case 2
                answerPrac = (firstint - secondint)
            Case 3
                answerPrac = (firstint * secondint)
            Case 4
                answerPrac = (firstint / secondint)
        End Select
        If answerPrac = useranswer Then
            MessageBox.Show("Correct Congradulations")
            lblOperand1.Text = Nothing
            lblOperand2.Text = Nothing
            lblOperator.Text = Nothing
            txtAnswer.Text = Nothing
            Call VisibleNums(False)
            Call Level(True)
        Else
            MessageBox.Show("Incorrect, Try Again")
            txtAnswer.Text = Nothing
        End If
    End Sub

    Private Sub allNumbers(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn4.Click, btn3.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim masterButton As Button = sender
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
    End Sub

    'This Procedure add the users input onto the equation screen.
    Private Sub CalcInputs(numInput As String)
        txtAnswer.Text = txtAnswer.Text & numInput
    End Sub

    'This Procedure Makes The Numbers Visible
    Private Sub VisibleNums(bln As Boolean)
        btn0.Visible = bln
        btn1.Visible = bln
        btn2.Visible = bln
        btn3.Visible = bln
        btn4.Visible = bln
        btn5.Visible = bln
        btn6.Visible = bln
        btn7.Visible = bln
        btn8.Visible = bln
        btn9.Visible = bln
        btnCheck.Visible = bln
        btnDontKnow.Visible = bln
    End Sub

    'This Procedure Makes The Level Buttons Visible
    Private Sub Level(bln As Boolean)
        btnEasy.Visible = bln
        btnMedium.Visible = bln
        btnHard.Visible = bln
        lblDIfficulty.Visible = bln
    End Sub

    'This Function Gets The Correct Answer Of The Random Equatiom.
    Private Function GetAnswer(operand1 As Integer, operand2 As Integer, operand3 As Integer)
        Dim firstint As Integer = operand1
        Dim secondint As Integer = operand2
        Dim operation As Integer = operand3
        Dim answerPrac As Integer
        Select Case operation
            Case 1
                answerPrac = (firstint + secondint)
            Case 2
                answerPrac = (firstint - secondint)
            Case 3
                answerPrac = (firstint * secondint)
            Case 4
                answerPrac = (firstint / secondint)
        End Select
        Return answerPrac
    End Function

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        frmCal1.Show()
        Me.Close()
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Hide()
    End Sub
End Class
