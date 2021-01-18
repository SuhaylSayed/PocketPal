Imports System.IO
Public Class frmTasks
    Dim tasks(6, 2)
    Dim taskButtons(6) As Button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        taskButtons = {btnTask1, btnTask2, btnTask3, btnTask4, btnTask5, btnTask6, btnTask7}


        For i As Integer = 0 To taskButtons.Length - 1
            If taskButtons(i).Text = Nothing Then
                taskButtons(i).Text = txtTitle.Text
                tasks(i, 0) = txtTitle.Text
                Exit For
            End If
        Next

        For i As Integer = 0 To 6
            If tasks(i, 0) <> Nothing Then
                If tasks(i, 1) = Nothing Then
                    tasks(i, 1) = txtDate.Text
                End If
            End If
        Next

        For i As Integer = 0 To 6
            If tasks(i, 0) <> Nothing Then
                If tasks(i, 2) = Nothing Then
                    tasks(i, 2) = txtDescription.Text
                End If
            End If
        Next

        txtTitle.Text = Nothing
        txtDate.Text = Nothing
        txtDescription.Text = Nothing
    End Sub

    Private Sub btnTask1_Click(sender As Object, e As EventArgs) Handles btnTask1.Click
        txtTitle.Text = Nothing
        txtDate.Text = Nothing
        txtDescription.Text = Nothing
        txtTitle.Text = tasks(0, 0)
        txtDate.Text = tasks(0, 1)
        txtDescription.Text = tasks(0, 2)
    End Sub

    Private Sub btnTask2_Click(sender As Object, e As EventArgs) Handles btnTask2.Click
        txtTitle.Text = Nothing
        txtDate.Text = Nothing
        txtDescription.Text = Nothing
        txtTitle.Text = tasks(1, 0)
        txtDate.Text = tasks(1, 1)
        txtDescription.Text = tasks(1, 2)
    End Sub

    Private Sub btnTask3_Click(sender As Object, e As EventArgs) Handles btnTask3.Click
        txtTitle.Text = Nothing
        txtDate.Text = Nothing
        txtDescription.Text = Nothing
        txtTitle.Text = tasks(2, 0)
        txtDate.Text = tasks(2, 1)
        txtDescription.Text = tasks(2, 2)
    End Sub

    Private Sub btnTask4_Click(sender As Object, e As EventArgs) Handles btnTask4.Click
        txtTitle.Text = Nothing
        txtDate.Text = Nothing
        txtDescription.Text = Nothing
        txtTitle.Text = tasks(3, 0)
        txtDate.Text = tasks(3, 1)
        txtDescription.Text = tasks(3, 2)
    End Sub

    Private Sub btnTask5_Click(sender As Object, e As EventArgs) Handles btnTask5.Click
        txtTitle.Text = Nothing
        txtDate.Text = Nothing
        txtDescription.Text = Nothing
        txtTitle.Text = tasks(4, 0)
        txtDate.Text = tasks(4, 1)
        txtDescription.Text = tasks(4, 2)
    End Sub

    Private Sub btnTask6_Click(sender As Object, e As EventArgs) Handles btnTask6.Click
        txtTitle.Text = Nothing
        txtDate.Text = Nothing
        txtDescription.Text = Nothing
        txtTitle.Text = tasks(5, 0)
        txtDate.Text = tasks(5, 1)
        txtDescription.Text = tasks(5, 2)
    End Sub

    Private Sub btnTask7_Click(sender As Object, e As EventArgs) Handles btnTask7.Click
        txtTitle.Text = Nothing
        txtDate.Text = Nothing
        txtDescription.Text = Nothing
        txtTitle.Text = tasks(6, 0)
        txtDate.Text = tasks(6, 1)
        txtDescription.Text = tasks(6, 2)
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Hide()
    End Sub
End Class
