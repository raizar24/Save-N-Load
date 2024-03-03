<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        txtuser = New TextBox()
        txtpass = New TextBox()
        txtpass2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnConfirm = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' txtuser
        ' 
        txtuser.Location = New Point(125, 31)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(192, 23)
        txtuser.TabIndex = 0
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(125, 73)
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "*"c
        txtpass.Size = New Size(192, 23)
        txtpass.TabIndex = 1
        ' 
        ' txtpass2
        ' 
        txtpass2.Location = New Point(125, 118)
        txtpass2.Name = "txtpass2"
        txtpass2.PasswordChar = "*"c
        txtpass2.Size = New Size(192, 23)
        txtpass2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 3
        Label1.Text = "User ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 4
        Label2.Text = "Password:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 15)
        Label3.TabIndex = 5
        Label3.Text = "Confirm Password:"
        ' 
        ' btnConfirm
        ' 
        btnConfirm.Location = New Point(81, 166)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(75, 23)
        btnConfirm.TabIndex = 6
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(166, 166)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 7
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(340, 228)
        Controls.Add(btnCancel)
        Controls.Add(btnConfirm)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtpass2)
        Controls.Add(txtpass)
        Controls.Add(txtuser)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtpass2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
End Class
