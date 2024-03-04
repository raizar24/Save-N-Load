<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtpass = New TextBox()
        btnLogin = New Button()
        btnRegister = New Button()
        ListBox1 = New ListBox()
        DataGridView1 = New DataGridView()
        DateModified = New DataGridViewTextBoxColumn()
        btnSave = New Button()
        btnLoad = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btnSettings = New Button()
        txtuser = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(240, 12)
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "*"c
        txtpass.Size = New Size(100, 23)
        txtpass.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(359, 12)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(453, 12)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(75, 23)
        btnRegister.TabIndex = 4
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.AllowDrop = True
        ListBox1.Enabled = False
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 52)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(249, 274)
        ListBox1.TabIndex = 5
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowDrop = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {DateModified})
        DataGridView1.Enabled = False
        DataGridView1.Location = New Point(267, 52)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(279, 73)
        DataGridView1.TabIndex = 6
        ' 
        ' DateModified
        ' 
        DateModified.HeaderText = "Date Modified"
        DateModified.Name = "DateModified"
        DateModified.ReadOnly = True
        DateModified.Width = 230
        ' 
        ' btnSave
        ' 
        btnSave.AllowDrop = True
        btnSave.BackColor = Color.PaleGreen
        btnSave.Enabled = False
        btnSave.Location = New Point(284, 145)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(114, 61)
        btnSave.TabIndex = 7
        btnSave.Text = "Save Game"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnLoad
        ' 
        btnLoad.AllowDrop = True
        btnLoad.BackColor = Color.Khaki
        btnLoad.Enabled = False
        btnLoad.Location = New Point(404, 145)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(114, 61)
        btnLoad.TabIndex = 8
        btnLoad.Text = "Load Game"
        btnLoad.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 10
        Label1.Text = "User ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(177, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 11
        Label2.Text = "Password"
        ' 
        ' btnSettings
        ' 
        btnSettings.Location = New Point(471, 304)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(75, 23)
        btnSettings.TabIndex = 12
        btnSettings.Text = "Settings"
        btnSettings.UseVisualStyleBackColor = True
        ' 
        ' txtuser
        ' 
        txtuser.Location = New Point(62, 12)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(109, 23)
        txtuser.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(554, 335)
        Controls.Add(txtuser)
        Controls.Add(btnSettings)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLoad)
        Controls.Add(btnSave)
        Controls.Add(DataGridView1)
        Controls.Add(ListBox1)
        Controls.Add(btnRegister)
        Controls.Add(btnLogin)
        Controls.Add(txtpass)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Save N Load - BETA"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtpass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSettings As Button
    Friend WithEvents txtuser As TextBox
    Friend WithEvents DateModified As DataGridViewTextBoxColumn

End Class
