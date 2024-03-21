Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btndoctor_Click(sender As Object, e As EventArgs) Handles btndoctor.Click
        fdoctorsform.Show()
    End Sub

    Private Sub btnappointments_Click(sender As Object, e As EventArgs) Handles btnappointments.Click
        fAppointmentsform.Show()
    End Sub

    Private Sub btnpatients_Click(sender As Object, e As EventArgs) Handles btnpatients.Click
        fpatientsform.Show()
    End Sub

    Private Sub btnpayments_Click(sender As Object, e As EventArgs) Handles btnpayments.Click
        fpaymentsform.Show()
    End Sub

    Private Sub btnpharmacy_Click(sender As Object, e As EventArgs) Handles btnpharmacy.Click
        fpharmacyform.Show()
    End Sub

    Private Sub btnlabels_Click(sender As Object, e As EventArgs) Handles btnlabels.Click
        fwardsform.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class