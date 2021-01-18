Public Class frmNotes
    Dim btnNotes(5) As Button
    Public notes(5) As String
    Public notesName(5) As String
    Dim opened As Integer
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnNotes = {btnNote1, btnNote2, btnNote3, btnNote4, btnNote5, btnNote6}
        Dim name As String
        Static count As Integer
        name = InputBox("Please enter the name of your note:")
        count += 1

        If count > 6 Then
            MessageBox.Show("Too many notes!", "Notes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        For i As Integer = 0 To btnNotes.Length - 1
            If btnNotes(i).Text = Nothing Then
                btnNotes(i).Text = name
                notesName(i) = name
                Exit For
            End If
        Next
    End Sub

    Private Sub btnNote1_Click(sender As Object, e As EventArgs) Handles btnNote1.Click
        If btnNote1.Text <> Nothing Then
            pnlHome.Hide()
            btnBack.Enabled = True
            txtNote.Text = notes(0)
            opened = 1
            Exit Sub
        End If
        MessageBox.Show("Please name the note first.", "Notes", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If opened = 1 Then
            notes(0) = txtNote.Text
        ElseIf opened = 2 Then
            notes(1) = txtNote.Text
        ElseIf opened = 3 Then
            notes(2) = txtNote.Text
        ElseIf opened = 4 Then
            notes(3) = txtNote.Text
        ElseIf opened = 5 Then
            notes(4) = txtNote.Text
        ElseIf opened = 6 Then
            notes(5) = txtNote.Text
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlHome.Show()
    End Sub

    Private Sub frmNotes_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNote1.Text = notesName(0)
        btnNote2.Text = notesName(1)
        btnNote3.Text = notesName(2)
        btnNote4.Text = notesName(3)
        btnNote5.Text = notesName(4)
        btnNote6.Text = notesName(5)
    End Sub

    Private Sub btnNote2_Click(sender As Object, e As EventArgs) Handles btnNote2.Click
        If btnNote2.Text <> Nothing Then
            pnlHome.Hide()
            btnBack.Enabled = False
            txtNote.Text = notes(1)
            opened = 2
        End If
        MessageBox.Show("Please name the note first.", "Notes", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnNote3_Click(sender As Object, e As EventArgs) Handles btnNote3.Click
        If btnNote3.Text <> Nothing Then
            pnlHome.Hide()
            btnBack.Enabled = False
            txtNote.Text = notes(2)
            opened = 3
        End If
        MessageBox.Show("Please name the note first.", "Notes", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnNote4_Click(sender As Object, e As EventArgs) Handles btnNote4.Click
        If btnNote4.Text <> Nothing Then
            pnlHome.Hide()
            btnBack.Enabled = False
            txtNote.Text = notes(3)
            opened = 4
        End If
        MessageBox.Show("Please name the note first.", "Notes", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnNote5_Click(sender As Object, e As EventArgs) Handles btnNote5.Click
        If btnNote5.Text <> Nothing Then
            pnlHome.Hide()
            btnBack.Enabled = False
            txtNote.Text = notes(4)
            opened = 5
        End If
        MessageBox.Show("Please name the note first.", "Notes", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnNote6_Click(sender As Object, e As EventArgs) Handles btnNote6.Click
        If btnNote6.Text <> Nothing Then
            pnlHome.Hide()
            btnBack.Enabled = False
            txtNote.Text = notes(5)
            opened = 6
        End If
        MessageBox.Show("Please name the note first.", "Notes", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Hide()
    End Sub
End Class
