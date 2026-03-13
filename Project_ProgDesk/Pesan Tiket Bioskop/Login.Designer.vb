<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LblTitle = New Label()
        LblEmail = New Label()
        TxtEmail = New TextBox()
        LblPassword = New Label()
        TxtPassword = New TextBox()
        BtnLogin = New Button()
        BtnRegister = New Button()
        SuspendLayout()
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        LblTitle.Location = New Point(120, 30)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(211, 37)
        LblTitle.TabIndex = 6
        LblTitle.Text = "Halaman Login"
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.Location = New Point(50, 90)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(46, 20)
        LblEmail.TabIndex = 5
        LblEmail.Text = "Email"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(130, 87)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(200, 27)
        TxtEmail.TabIndex = 4
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.Location = New Point(50, 130)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(80, 20)
        LblPassword.TabIndex = 3
        LblPassword.Text = "Kata Sandi"
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(130, 127)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(200, 27)
        TxtPassword.TabIndex = 2
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.Teal
        BtnLogin.ForeColor = Color.White
        BtnLogin.Location = New Point(130, 170)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(80, 30)
        BtnLogin.TabIndex = 1
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' BtnRegister
        ' 
        BtnRegister.BackColor = Color.Teal
        BtnRegister.ForeColor = Color.White
        BtnRegister.Location = New Point(220, 170)
        BtnRegister.Name = "BtnRegister"
        BtnRegister.Size = New Size(110, 30)
        BtnRegister.TabIndex = 0
        BtnRegister.Text = "Daftar Akun Baru"
        BtnRegister.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        ClientSize = New Size(400, 250)
        Controls.Add(BtnRegister)
        Controls.Add(BtnLogin)
        Controls.Add(TxtPassword)
        Controls.Add(LblPassword)
        Controls.Add(TxtEmail)
        Controls.Add(LblEmail)
        Controls.Add(LblTitle)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents BtnRegister As System.Windows.Forms.Button
End Class