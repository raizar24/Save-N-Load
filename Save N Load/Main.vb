Imports System.IO
Imports System.Net

Public Class Form1
    Dim username As String
    Public serverIP As String = checkBackSlash(loadXML("sharedFolder"))
    Dim folderPath As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not serverIP.StartsWith("\\") Then
                serverIP = "\\" & serverIP
            End If

            If Not Directory.Exists(serverIP) Then
                MessageBox.Show("Shared folder cannot be accessed. Folder access denied: " & serverIP & "", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not File.Exists(serverIP & "users.xml") Or Not File.Exists(serverIP & "games.xml") Then
                CopyFile("users.xml", serverIP & "users.xml")
                CopyFile("games.xml", serverIP & "games.xml")
            End If

            ListBox1.Items.AddRange(loadList(serverIP & "games.xml", "game", "name").ToArray())
        Catch err As Exception
            MessageBox.Show("Error: " & err.Message, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Not Directory.Exists(serverIP) Then
            MessageBox.Show("Shared folder cannot be accessed. Folder access denied: " & serverIP, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Application.Exit()
            Exit Sub
        End If
        Dim register As New Register
        register.ShowDialog()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        If Not Directory.Exists(serverIP) Then
            MessageBox.Show("Shared folder cannot be accessed. Folder access denied: " & serverIP, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Application.Exit()
            Exit Sub
        End If
        Dim admin As New admin
        admin.ShowDialog()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            If Not Directory.Exists(serverIP) Then
                MessageBox.Show("Shared folder cannot be accessed. Folder access denied: " & serverIP, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Application.Exit()
                Exit Sub
            End If
            refreshgrid()
        Catch err As Exception
            MessageBox.Show("Error: " & err.Message, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not Directory.Exists(serverIP) Then
            MessageBox.Show("Shared folder cannot be accessed. Folder access denied: " & serverIP, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Application.Exit()
            Exit Sub
        End If

        Dim savePath = GetGameSavePath(ListBox1.SelectedItem)
        If Not Directory.Exists(savePath) Then
            MessageBox.Show("Save Directory Does not exist: " & savePath, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        CopyDirectory(savePath, folderPath)
        refreshgrid()
        MessageBox.Show("Save Successful", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If Not Directory.Exists(serverIP) Then
            MessageBox.Show("Shared folder cannot be accessed. Folder access denied: " & serverIP, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Application.Exit()
            Exit Sub
        End If

        Dim savePath = GetGameSavePath(ListBox1.SelectedItem)
        If Not Directory.Exists(savePath) Then
            Directory.CreateDirectory(savePath)
            'MessageBox.Show("Save Directory Does not exist: " & savePath, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Exit Sub
        End If
        CopyDirectory(folderPath, savePath)
        refreshgrid()
        MessageBox.Show("Load Successful", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not Directory.Exists(serverIP) Then
            MessageBox.Show("Shared folder cannot be accessed. Folder access denied: " & serverIP, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Application.Exit()
            Exit Sub
        End If
        username = txtuser.Text
        Dim password = Encrypt(txtpass.Text)
        Dim doc As XDocument = XDocument.Load(serverIP & "users.xml")
        Dim userExists As Boolean = (From user In doc.Descendants("user")
                                     Where user.Element("username").Value.Equals(username, StringComparison.OrdinalIgnoreCase) AndAlso
                                          user.Element("passwordHash").Value.Equals(password)
                                     Select user).Any()
        If userExists Then
            ListBox1.Enabled = True
            DataGridView1.Enabled = True
            btnLogin.Enabled = False
            btnRegister.Enabled = False
            btnSave.Enabled = True
            btnLoad.Enabled = True
            MessageBox.Show("Login Successful", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Username or Password is incorrect", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub refreshgrid()
        Dim selectedItem As String = ListBox1.SelectedItem
        folderPath = checkBackSlash(serverIP) & username & "\" & selectedItem
        Dim mostRecentlyModifiedFile As FileInfo = Nothing
        DataGridView1.Rows.Clear()
        If Directory.Exists(folderPath) Then
            For Each file In Directory.EnumerateFiles(folderPath, "*.*", SearchOption.AllDirectories)
                Dim currentFile As New FileInfo(file)
                If mostRecentlyModifiedFile Is Nothing OrElse currentFile.LastWriteTime > mostRecentlyModifiedFile.LastWriteTime Then
                    mostRecentlyModifiedFile = currentFile
                End If
            Next
            If mostRecentlyModifiedFile IsNot Nothing Then
                DataGridView1.Rows.Add(mostRecentlyModifiedFile.LastWriteTime)
            End If
        End If
    End Sub

End Class
