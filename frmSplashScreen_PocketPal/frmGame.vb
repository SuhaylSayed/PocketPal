Public Class frmGame
    Dim count As Integer
    Dim rand As New Random
    Dim numString As String
    Dim oneClick As Integer = 0
    Dim startOnce As Integer = 0
    Private numlength As Integer
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        startOnce += 1
        If startOnce = 1 Then
            Dim time As Integer
            lblReactionTime.Text = Nothing
            pnlColour.BackColor = Color.Yellow
            time = rand.Next(3000, 7001)

            timColour.Interval = time
            timColour.Start()
        End If
    End Sub

    Private Sub timColour_Tick(sender As Object, e As EventArgs) Handles timColour.Tick
        pnlColour.BackColor = Color.Green
        timColour.Stop()
        timColourCount.Start()
    End Sub

    Private Sub timColourCount_Tick(sender As Object, e As EventArgs) Handles timColourCount.Tick
        count += 1
        lblReactionTime.Text = count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        timColourCount.Stop()
        lblReactionTime.Text = count
        startOnce = 0
    End Sub



    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlNumbers.MouseClick
        oneClick += 1
        If oneClick = 1 Then
            txtInput.Enabled = False
            Dim num() As Integer
            Me.BackColor = Color.Yellow

            For i As Integer = 0 To 9
                If numlength = 9 Then
                    Exit For
                Else numlength = i
                    numlength = i + 1
                    Exit For
                End If
            Next
            ReDim num(numlength)

            For i As Integer = 0 To num.Length - 1
                num(i) = rand.Next(0, 10)
            Next

            For i As Integer = 0 To num.Length - 1
                lblOutput.Text &= num(i)
            Next

            For i As Integer = 0 To num.Length - 1
                numString &= num(i)
            Next

            If numlength > 6 Then
                timNums.Interval = 8000
            End If
            timNums.Start()
        End If
    End Sub

    Private Sub bntCheck_Click(sender As Object, e As EventArgs) Handles bntCheck.Click
        timNums.Stop()
        If txtInput.Text = numString Then
            Me.BackColor = Color.Green
        Else
            Me.BackColor = Color.Red
            numlength = 0
        End If
        numString = Nothing
        txtInput.Text = Nothing
        oneClick = 0
    End Sub

    Private Sub timNums_Tick(sender As Object, e As EventArgs) Handles timNums.Tick
        lblOutput.Text = Nothing
        txtInput.Enabled = True
    End Sub

    Private Sub btnColour_Click(sender As Object, e As EventArgs) Handles btnColour.Click
        pnlNumbers.Visible = False
        pnlColour.Visible = True
        pnlColour.BackColor = Color.Red

    End Sub

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btnNumber.Click
        pnlNumbers.Visible = True
        pnlColour.Visible = False
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Hide()
    End Sub
End Class
