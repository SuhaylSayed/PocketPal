Public Class frmCalendar
    Public calArray As String() = {"12:00 am", "1:00 am", "2:00 am", "3:00 am", "4:00 am", "5:00 am", "6:00 am", "7:00 am", "8:00 am", "9:00 am", "10:00 am", "11:00 am", "12:00 pm", "1:00 pm", "2:00 pm", "3:00 pm", "4:00 pm", "5:00 pm", "6:00 pm", "7:00 pm", "8:00 pm", "9:00 pm", "10:00 pm", "11:00 pm"}
    Public kvpLst As New List(Of KeyValuePair(Of String, String))
    Dim selectItem, currDate As String
    Dim ec As Boolean
    Public Sub frmBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCalendar(dtpMain.Value.ToLongDateString)
        selectItem = "6:00 am"
        cboSelectTime.SelectedItem = selectItem
    End Sub

    Public Sub dtpMain_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpMain.ValueChanged
        currDate = dtpMain.Value.Year & dtpMain.Value.Month & dtpMain.Value.Day
        LoadCalendar(dtpMain.Value.ToLongDateString)
    End Sub

    Public Sub btnBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Item, ItemInput As String
        Dim dateAndTime As String = dtpMain.Value.ToLongDateString & " " & cboSelectTime.SelectedItem
        Do
            ItemInput = InputBox("Enter The Name Of Your Event:", "Enter Event")
            If ItemInput.Length >= 20 Then
                MessageBox.Show("Please Make Sure Your Event Name Is Less Then 20 Characters", "Error", MessageBoxButtons.OK)
            Else
                ec = True
                Item = ItemInput
            End If
        Loop Until EC = True
        EC = False
        If kvpLst.Count > 0 Then
            If (InsideKVP(dateAndTime)) Then
                MessageBox.Show("This Time Is Already Filled. Please Remove It If You Would Like To Add Another Item", "Slot Full", MessageBoxButtons.OK)
                Exit Sub
            Else
                lsvEvents.Items(lsvEvents.Items.IndexOf(lsvEvents.FindItemWithText(cboSelectTime.SelectedItem))).SubItems.Add(Item)
                kvpLst.Add(New KeyValuePair(Of String, String)(dateAndTime, Item))
            End If
        Else
            lsvEvents.Items(lsvEvents.Items.IndexOf(lsvEvents.FindItemWithText(cboSelectTime.SelectedItem))).SubItems.Add(Item)
            kvpLst.Add(New KeyValuePair(Of String, String)(dateAndTime, Item))
        End If
    End Sub

    Public Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim Item As String
        Item = InputBox("Enter An Event You Would Like To Remove. (Case Sensitive) :", "Remove", MessageBoxButtons.OK)
        Dim numEle As String
        For Each element As KeyValuePair(Of String, String) In kvpLst
            numEle = element.Value
            If (numEle = Item) Then
                kvpLst.Remove(element)
                Exit For
            End If
        Next
        LoadCalendar(dtpMain.Value.ToLongDateString)
    End Sub
    ' This Procedure Loads the calendar and any events on the calender into the listview box.
    Public Sub LoadCalendar(ByVal currDate As String)
        Dim numElem, itemInside As String
        Dim inLVI As ListViewItem
        lsvEvents.Items.Clear()
        lsvEvents.Items.AddRange(calArray.Select(Function(A) New ListViewItem(A)).ToArray)
        For Each element As KeyValuePair(Of String, String) In kvpLst
            numElem = element.Key
            itemInside = element.Value
            If (numElem.Contains(currDate)) Then
                For count As Integer = 0 To 23
                    If (numElem.Contains(calArray(count))) Then
                        inLVI = lsvEvents.FindItemWithText(calArray(count))
                        inLVI.SubItems.Add(itemInside)
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Hide()
    End Sub

    'This function checks if the current time slot which the user wants to enter the event is already filled.
    Public Function InsideKVP(ByVal search As String)
        Dim isInside As Boolean
        Dim numElem As String
        For Each element As KeyValuePair(Of String, String) In kvpLst
            numElem = element.Key
            If (numElem = search) Then
                isInside = True
                Exit For
            End If
        Next
        Return isInside
    End Function
End Class