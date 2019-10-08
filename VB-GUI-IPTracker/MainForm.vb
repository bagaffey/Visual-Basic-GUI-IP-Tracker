Public Class MainForm
    Private Sub btnTrackIP_Click(sender As Object, e As EventArgs) Handles btnTrackIP.Click
        If Not String.IsNullOrWhiteSpace(txtKillersIP.Text) Then
            txtKillersIP.ForeColor = Color.Red
        End If
        txtKillersIP.Text = "127.0.0.1"
    End Sub
End Class
