<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnCancel = New Button()
        btnSave = New Button()
        ListBox1 = New ListBox()
        Label2 = New Label()
        Label1 = New Label()
        txtSavepath = New TextBox()
        btnDelete = New Button()
        btnEdit = New Button()
        btnAdd = New Button()
        txtgame = New TextBox()
        TabPage2 = New TabPage()
        btncancel2 = New Button()
        btnsave2 = New Button()
        ListBox2 = New ListBox()
        Label3 = New Label()
        Label4 = New Label()
        txtPass = New TextBox()
        btndelete2 = New Button()
        btnedit2 = New Button()
        btnadd2 = New Button()
        txtUser = New TextBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(596, 435)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnCancel)
        TabPage1.Controls.Add(btnSave)
        TabPage1.Controls.Add(ListBox1)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(txtSavepath)
        TabPage1.Controls.Add(btnDelete)
        TabPage1.Controls.Add(btnEdit)
        TabPage1.Controls.Add(btnAdd)
        TabPage1.Controls.Add(txtgame)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(588, 407)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Game List"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Enabled = False
        btnCancel.Image = My.Resources.Resources.icons8_cancel_50
        btnCancel.Location = New Point(404, 251)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(114, 79)
        btnCancel.TabIndex = 18
        btnCancel.Text = "Cancel"
        btnCancel.TextImageRelation = TextImageRelation.ImageAboveText
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Enabled = False
        btnSave.Image = My.Resources.Resources.icons8_save_48
        btnSave.Location = New Point(284, 251)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(114, 79)
        btnSave.TabIndex = 17
        btnSave.Text = "Save"
        btnSave.TextImageRelation = TextImageRelation.ImageAboveText
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.AllowDrop = True
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(7, 18)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(211, 364)
        ListBox1.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(222, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 15
        Label2.Text = "Save Path:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(222, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 14
        Label1.Text = "Game:"
        ' 
        ' txtSavepath
        ' 
        txtSavepath.Enabled = False
        txtSavepath.Location = New Point(301, 75)
        txtSavepath.Multiline = True
        txtSavepath.Name = "txtSavepath"
        txtSavepath.Size = New Size(270, 73)
        txtSavepath.TabIndex = 13
        ' 
        ' btnDelete
        ' 
        btnDelete.Image = My.Resources.Resources.icons8_delete_30
        btnDelete.Location = New Point(462, 171)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(114, 74)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete"
        btnDelete.TextImageRelation = TextImageRelation.ImageAboveText
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Image = My.Resources.Resources.icons8_edit_50
        btnEdit.Location = New Point(342, 171)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(114, 74)
        btnEdit.TabIndex = 11
        btnEdit.Text = "Edit"
        btnEdit.TextImageRelation = TextImageRelation.ImageAboveText
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Image = My.Resources.Resources.icons8_add_48
        btnAdd.Location = New Point(222, 171)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(114, 74)
        btnAdd.TabIndex = 10
        btnAdd.Text = "Add"
        btnAdd.TextImageRelation = TextImageRelation.ImageAboveText
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtgame
        ' 
        txtgame.Enabled = False
        txtgame.Location = New Point(301, 46)
        txtgame.Name = "txtgame"
        txtgame.Size = New Size(270, 23)
        txtgame.TabIndex = 4
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btncancel2)
        TabPage2.Controls.Add(btnsave2)
        TabPage2.Controls.Add(ListBox2)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(txtPass)
        TabPage2.Controls.Add(btndelete2)
        TabPage2.Controls.Add(btnedit2)
        TabPage2.Controls.Add(btnadd2)
        TabPage2.Controls.Add(txtUser)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(588, 407)
        TabPage2.TabIndex = 1
        TabPage2.Text = "User Management"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btncancel2
        ' 
        btncancel2.Enabled = False
        btncancel2.Image = My.Resources.Resources.icons8_cancel_50
        btncancel2.Location = New Point(400, 261)
        btncancel2.Name = "btncancel2"
        btncancel2.Size = New Size(114, 76)
        btncancel2.TabIndex = 26
        btncancel2.Text = "Cancel"
        btncancel2.TextImageRelation = TextImageRelation.ImageAboveText
        btncancel2.UseVisualStyleBackColor = True
        ' 
        ' btnsave2
        ' 
        btnsave2.Enabled = False
        btnsave2.Image = My.Resources.Resources.icons8_save_48
        btnsave2.Location = New Point(280, 261)
        btnsave2.Name = "btnsave2"
        btnsave2.Size = New Size(114, 76)
        btnsave2.TabIndex = 25
        btnsave2.Text = "Save"
        btnsave2.TextImageRelation = TextImageRelation.ImageAboveText
        btnsave2.UseVisualStyleBackColor = True
        ' 
        ' ListBox2
        ' 
        ListBox2.AllowDrop = True
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(8, 12)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(211, 379)
        ListBox2.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(232, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 23
        Label3.Text = "Password:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(232, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 15)
        Label4.TabIndex = 22
        Label4.Text = "User:"
        ' 
        ' txtPass
        ' 
        txtPass.Enabled = False
        txtPass.Location = New Point(296, 113)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(270, 23)
        txtPass.TabIndex = 21
        ' 
        ' btndelete2
        ' 
        btndelete2.Image = My.Resources.Resources.icons8_delete_30
        btndelete2.Location = New Point(465, 175)
        btndelete2.Name = "btndelete2"
        btndelete2.Size = New Size(114, 80)
        btndelete2.TabIndex = 20
        btndelete2.Text = "Delete"
        btndelete2.TextImageRelation = TextImageRelation.ImageAboveText
        btndelete2.UseVisualStyleBackColor = True
        ' 
        ' btnedit2
        ' 
        btnedit2.Image = My.Resources.Resources.icons8_edit_50
        btnedit2.Location = New Point(345, 175)
        btnedit2.Name = "btnedit2"
        btnedit2.Size = New Size(114, 80)
        btnedit2.TabIndex = 19
        btnedit2.Text = "Edit"
        btnedit2.TextImageRelation = TextImageRelation.ImageAboveText
        btnedit2.UseVisualStyleBackColor = True
        ' 
        ' btnadd2
        ' 
        btnadd2.Image = My.Resources.Resources.icons8_add_48
        btnadd2.Location = New Point(225, 175)
        btnadd2.Name = "btnadd2"
        btnadd2.Size = New Size(114, 80)
        btnadd2.TabIndex = 18
        btnadd2.Text = "Add"
        btnadd2.TextImageRelation = TextImageRelation.ImageAboveText
        btnadd2.UseVisualStyleBackColor = True
        ' 
        ' txtUser
        ' 
        txtUser.Enabled = False
        txtUser.Location = New Point(296, 72)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(270, 23)
        txtUser.TabIndex = 17
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(620, 459)
        Controls.Add(TabControl1)
        Name = "Settings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Settings"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtgame As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSavepath As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btndelete2 As Button
    Friend WithEvents btnedit2 As Button
    Friend WithEvents btnadd2 As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnsave2 As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btncancel2 As Button
End Class
