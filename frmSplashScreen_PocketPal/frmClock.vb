Public Class frmClock
    Private time(2) As Integer
    Private Sub timClock_Tick(sender As Object, e As EventArgs) Handles timClock.Tick
        lblClock.Text = TimeOfDay
    End Sub

    Private Sub timTimer_Tick(sender As Object, e As EventArgs) Handles timTimer.Tick

        time(0) += 1

        If time(0) < 10 And time(1) < 10 And time(2) < 10 Then
            lblTimer.Text = "0" & time(2) & ":0" & time(1) & ":0" & time(0)
        ElseIf time(1) < 10 And time(2) < 10 Then
            lblTimer.Text = "0" & time(2) & ":0" & time(1) & ":" & time(0)
        ElseIf time(2) < 10 Then
            lblTimer.Text = "0" & time(2) & ":" & time(1) & ":" & time(0)
        Else
            lblTimer.Text = time(2) & ":" & time(1) & ":" & time(0)
        End If




        For i As Integer = 0 To time.Length - 2
            If time(i) = 59 Then
                time(i) = -1
                time(i + 1) += 1
            End If
        Next

        If time(1) = 59 Then
            time(1) = 0
            time(2) += 1
        End If
    End Sub

    Private Sub btnTimer_Click(sender As Object, e As EventArgs) Handles btnTimer.Click
        pnlTimer.Show()
    End Sub

    Private Sub btnClock_Click(sender As Object, e As EventArgs) Handles btnClock.Click
        pnlTimer.Visible = False
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        timTimer.Start()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        timTimer.Stop()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblTimer.Text = "00:00:00"
        timTimer.Stop()
        For i As Integer = 0 To time.Length - 1
            time(i) = 0
        Next
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub
End Class
