Public Class frmPocketPal_HomeScreen

    Private Sub picContacts_Click(sender As Object, e As EventArgs) Handles picContacts.Click
        frmPocketPal_Contacts.Show()
    End Sub

    Private Sub picFinance_Click(sender As Object, e As EventArgs) Handles picFinance.Click
        frmPocketPal_Finance.Show()
    End Sub

    Private Sub picSpace_Click(sender As Object, e As EventArgs) Handles picSpace.Click
        frmGame.Show()
    End Sub

    Private Sub picCalender_Click(sender As Object, e As EventArgs) Handles picCalender.Click
        frmCalendar.Show()
    End Sub

    Private Sub picCalculator_Click(sender As Object, e As EventArgs) Handles picCalculator.Click
        frmCal1.Show()
    End Sub

    Private Sub picNotes_Click(sender As Object, e As EventArgs) Handles picNotes.Click
        frmNotes.Show()
    End Sub

    Private Sub picCalorie_Click(sender As Object, e As EventArgs) Handles picCalorie.Click
        frmCalories1.Show()
    End Sub

    Private Sub picSettings_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub picClock_Click(sender As Object, e As EventArgs) Handles picClock.Click
        frmClock.Show()
    End Sub

    Private Sub picTask_Click(sender As Object, e As EventArgs) Handles picTask.Click
        frmTasks.Show()
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        End
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub picHome_Click(sender As Object, e As EventArgs) Handles picHome.Click
        Me.Close()
    End Sub

    Private Sub btnPhoneHome_Click(sender As Object, e As EventArgs) Handles btnPhoneHome.Click
        pnlHelp.Visible = False
        pnlHomeScreen.Visible = True
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        pnlHelp.Visible = True
        pnlHomeScreen.Visible = False
    End Sub
End Class
