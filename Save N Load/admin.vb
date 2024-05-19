Imports Microsoft.SqlServer

Public Class admin
    Public serverIP As String = checkBackSlash(loadXML("sharedFolder"))
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim password = Encrypt(TextBox2.Text.Trim())
        Dim doc = XDocument.Load(serverIP & "admin.xml")
        Dim storedPasswordHash = doc.<passwordHash>.Value
        If storedPasswordHash.Equals(password) Then
            Dim settings As New Settings
            Me.Close()
            settings.ShowDialog()
            settings.BringToFront()
        End If
    End Sub
End Class