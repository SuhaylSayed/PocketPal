Imports System.IO
Public Class frmCalories3
    Dim CaloriesFiles As StreamReader
    Dim arrayA() As String
    Dim userinput As String
    Dim CaloriesBreakfast, CaloriesLunch, CaloriesDinner, CaloriesSnack As Integer
    Dim NewItem As Integer
    Dim NewItemInput As String
    Dim infile, errorBln As Boolean

    Private Sub btnBreakfast_Click(sender As Object, e As EventArgs) Handles btnBreakfast.Click
        userinput = InputBox("Enter Name Of Item You Would Like To Add, Note: No Spaces And No Uppercase Letters", "Add Item", "Milk")
        Call FetchItem(lstBreakfast, CaloriesBreakfast)
        CaloriesFiles.Close()
        lblBreakCal.Text = "Breakfast Calorie" + vbNewLine + "Count:" + CStr(CaloriesBreakfast)
    End Sub

    Private Sub btnLunch_Click(sender As Object, e As EventArgs) Handles btnLunch.Click
        userinput = InputBox("Enter Name Of Item You Would Like To Add, Note: No Spaces And No Uppercase Letters", "Add Item", "Milk")
        Call FetchItem(lstLunch, CaloriesLunch)
        CaloriesFiles.Close()
        lblLunchCal.Text = "Lunch Calorie" + vbNewLine + "Count:" + CStr(CaloriesLunch)
    End Sub

    Private Sub btnItem_Click(sender As Object, e As EventArgs) Handles btnItem.Click
        frmCalories1.Show()
        Me.Hide()
    End Sub

    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        frmCalories2.Show()
        Me.Hide()
    End Sub

    Private Sub btnDinner_Click(sender As Object, e As EventArgs) Handles btnDinner.Click
        userinput = InputBox("Enter Name Of Item You Would Like To Add, Note: No Spaces And No Uppercase Letters", "Add Item", "Milk")
        Call FetchItem(lstDinner, CaloriesDinner)
        CaloriesFiles.Close()
        lblDinnerCal.Text = "Dinner Calorie" + vbNewLine + "Count:" + CStr(CaloriesDinner)
    End Sub

    Private Sub btnSnack_Click(sender As Object, e As EventArgs) Handles btnSnack.Click
        userinput = InputBox("Enter Name Of Item You Would Like To Add, Note: No Spaces And No Uppercase Letters", "Add Item", "Milk")
        Call FetchItem(lstSnack, CaloriesSnack)
        CaloriesFiles.Close()
        lblSnackCal.Text = "Snack Calorie" + vbNewLine + "Count:" + CStr(CaloriesSnack)
    End Sub

    'This Procedure Looks For The Item The User Has Inputed and Checks The DataBase. If Not It The Data Base The User Is Asked
    'To Input How Many Calories The Item Is.
    Private Sub FetchItem(ItemList As ListBox, ByRef Calorie As Integer)
        CaloriesFiles = File.OpenText("Caloriesfile.txt")
        Do Until CaloriesFiles.Peek = -1
            arrayA = Split(CaloriesFiles.ReadLine(), ",")
            If userinput = arrayA(0) Then

                ItemList.Items.Add(arrayA(0) & "(" & arrayA(2) + "):" & "   " & arrayA(1))
                Calorie += CInt(arrayA(1))
                TotalCalories += CInt(arrayA(1))
                infile = True
            End If
            lblTotalCal.Text = "Total Calorie" & vbNewLine & "Count:" & CStr(TotalCalories)
        Loop
        If infile = False Then
            Do
                NewItemInput = InputBox("Sorry Your Item Was Not Found In The Database, Please Enter The Calorie Total For The Item.", "Add Item", "100")
                If IsNumeric(NewItemInput) Then
                    If NewItemInput.Length <= 4 Then
                        NewItem = CInt(NewItemInput)
                        errorBln = True
                    Else
                        MessageBox.Show("Please Enter A Valid Calorie Total For The Item (Max 4 Digits)", "Error", MessageBoxButtons.OK)
                    End If
                Else
                    MessageBox.Show("Please Enter A Valid Calorie Total For The Item (Max 4 Digits)", "Error", MessageBoxButtons.OK)
                End If
            Loop Until errorBln = True
            errorBln = False
            ItemList.Items.Add(userinput + ":" + "   " + CStr(NewItem))
            TotalCalories += NewItem
            lblTotalCal.Text = "Total Calorie" & vbNewLine & "Count: " & CStr(TotalCalories)
            Calorie += NewItem
        End If
        infile = False
    End Sub

End Class