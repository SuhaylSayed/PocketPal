'***********************************************************************
'	PROGRAMME NAME  	:	Final Assignment PocketPal
'
'	PROGRAMME OUTLINE	:	This programme allows the user to create a list of contacts with info such as their name, email, and phone number.
'                           They can view and delete contacts in their list.
'
'
'	PROGRAMMER		    :	Russell Tang
'
'	DATE				:	Nov 21, 2018
'
'***********************************************************************
Public Class frmPocketPal_Contacts
    Dim contact(9, 2) As String 'Contact Name and their details
    Dim contactNum(9) As String 'Contact Number of the person
    Dim num As Integer


    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim input As String
        input = InputBox("Enter a Contact to Remove", "Remove Contact")

        If input = "" Then
            input = Nothing
        ElseIf Not lstContacts.Items.Contains(input) Then
            MessageBox.Show("Contact Not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lstContacts.Items.Remove(input)
            MessageBox.Show("Contact Removed Successfully", "Contact Removed", MessageBoxButtons.OK, MessageBoxIcon.None)
            num -= 1
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        contact(num, 0) = InputBox("Add a Contact Name", "Add Contact Name")

        If num >= 10 Then
            MessageBox.Show("Too Many Contacts Made! (10 Max)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If contact(num, 0) = "" Then
            contact(num, 0) = Nothing
            Exit Sub
        Else
            lstContacts.Items.Add(StrConv(contact(num, 0), vbProperCase))
            contactNum(num) = (StrConv(contact(num, 0), vbProperCase))
        End If

Back1:
        contact(num, 1) = InputBox("Add a Contact Email", "Add Email")
        If contact(num, 1) = "" Then
            contact(num, 1) = Nothing
        ElseIf Not contact(num, 1).Contains("@") Then
            contact(num, 1) = Nothing
            MessageBox.Show("Invalid Email")
            GoTo Back1
        End If

Back2:
        contact(num, 2) = InputBox("Add a Contact Phone Number", "Add Phone Number")
        If contact(num, 2) = "" Then
            contact(num, 2) = Nothing
        ElseIf Not IsNumeric(contact(num, 2)) Then
            contact(num, 2) = Nothing
            MessageBox.Show("Invalid Number")
            GoTo Back2
        End If

        num += 1

    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Hide()
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub lstContacts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstContacts.DoubleClick
        pnlMain.Visible = False
        pnlContactDetails.Visible = True
    End Sub

    Private Sub frmPocketPal_Contacts_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnBack.Click
        pnlMain.Visible = True
        pnlContactDetails.Visible = False
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim input As String
        lstDetails.Items.Clear()

        input = InputBox("Enter a Contact to View", "View Contact")

        If input = "" Then
            input = Nothing
        ElseIf Not lstContacts.Items.Contains(input) Then
            MessageBox.Show("Contact Not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim indexContact As Integer = Array.IndexOf(contactNum, input)
            lstDetails.Items.Add("Name: " & vbTab & contact(indexContact, 0))
            lstDetails.Items.Add("Email: " & vbTab & contact(indexContact, 1))
            lstDetails.Items.Add("Phone Number: " & vbTab & contact(indexContact, 2))
        End If
    End Sub
End Class
