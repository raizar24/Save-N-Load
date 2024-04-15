Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Xml
Imports Microsoft.Win32
Module Mods
    Function loadXML(ByVal value As String)
        Dim xDoc As XDocument = XDocument.Load("settings.xml")
        Dim xreturn As String = xDoc.Descendants(value).FirstOrDefault().Value
        Return xreturn
    End Function

    Sub saveXML(ByVal newVal As String, ByVal varLoc As String)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load("settings.xml")
        Dim node As XmlNode = xmlDoc.SelectSingleNode("/Variable/" & varLoc)
        node.InnerText = newVal
        xmlDoc.Save("settings.xml")
    End Sub

    Function checkBackSlash(ByVal path As String) As String
        If Not path.EndsWith("\") Then
            path &= "\"
        End If
        Return path
    End Function

    Function Encrypt(plainText As String) As String
        Dim reversedText As String = StrReverse(plainText)

        Dim encryptedText As String = ""
        For Each c As Char In reversedText
            encryptedText &= ChrW(AscW(c) + 4)
        Next

        Return encryptedText
    End Function

    Function Decrypt(encryptedText As String) As String
        Dim decryptedText As String = ""
        For Each c As Char In encryptedText
            decryptedText &= ChrW(AscW(c) - 4)
        Next

        decryptedText = StrReverse(decryptedText)

        Return decryptedText
    End Function

    Function ContainsSpecialCommand(input As String) As String
        Dim userProfile As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)

        Dim appdataRegex As New Regex("%appdata%", RegexOptions.IgnoreCase)
        Dim userProfileRegex As New Regex("%userprofile%", RegexOptions.IgnoreCase)

        Dim result As String = input

        If appdataRegex.IsMatch(input) Then
            result = appdataRegex.Replace(input, appData)
        End If

        If userProfileRegex.IsMatch(input) Then
            result = userProfileRegex.Replace(result, userProfile)
        End If

        Return result
    End Function

    Function GetGameSavePath(selectedGame As String) As String
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.serverIP & "games.xml")

        Dim xpathExpression = CheckXMLSingleQoute(selectedGame, "game")
        Dim pathNode As XmlNode = xmlDoc.SelectSingleNode(xpathExpression)

        'Dim pathNode As XmlNode = xmlDoc.SelectSingleNode($"/games/game[name='{selectedGame}']/path")

        If pathNode IsNot Nothing Then
            Return ContainsSpecialCommand(pathNode.InnerText)
        Else
            Return Nothing
        End If
    End Function

    Sub CopyDirectory(ByVal sourcePath As String, ByVal destinationPath As String)
        If Directory.Exists(sourcePath) Then
            My.Computer.FileSystem.CopyDirectory(sourcePath, destinationPath, True)
        Else
            Throw New DirectoryNotFoundException("Source directory does not exist: " + sourcePath)
        End If
    End Sub

    Sub CopyFile(ByVal sourcePath As String, ByVal destinationPath As String)
        If File.Exists(sourcePath) Then
            File.Copy(sourcePath, destinationPath, True)
        Else
            Throw New FileNotFoundException("Source file does not exist: " + sourcePath)
        End If
    End Sub

    Function loadList(ByVal xmlName As String, ByVal Descendant As String, ByVal element As String) As List(Of String)
        Dim doc As XDocument = XDocument.Load(xmlName)
        Dim listNames As List(Of String) = doc.Descendants(Descendant).Select(Function(game) game.Element(element).Value).ToList()

        Return listNames
    End Function

    Function CheckXMLSingleQoute(ByVal stringValue As String, ByVal xmlname As String)

        If Not stringValue.Contains("'") Then
            If xmlname = "game" Then
                stringValue = $"/games/game[name='{stringValue}']/path"
            End If

            If xmlname = "user" Then
                stringValue = $"/users/user[username='{stringValue}']/passwordHash"
            End If

            Return stringValue
        End If

        stringValue = stringValue.Replace("'", "', ""'"", '")
        If xmlname = "game" Then
            stringValue = $"/games/game[name=concat('{stringValue}')]/path"
        End If

        If xmlname = "user" Then
            stringValue = $"/users/user[username='{stringValue}']/passwordHash"
        End If

        Return stringValue
    End Function


End Module
