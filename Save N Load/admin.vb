Public Class admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text.Trim() = "admin" Then
            Dim settings As New Settings
            Me.Close()
            settings.ShowDialog()
            settings.BringToFront()
        End If
    End Sub
End Class