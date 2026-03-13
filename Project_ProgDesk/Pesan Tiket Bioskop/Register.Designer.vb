<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        LblNama = New Label()
        TxtNama = New TextBox()
        LblEmail = New Label()
        TxtEmail = New TextBox()
        LblPassword = New Label()
        TxtPassword = New TextBox()
        LblConfirmPassword = New Label()
        TxtConfirmPassword = New TextBox()
        BtnRegister = New Button()
        BtnBatal = New Button()
        SuspendLayout()
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        LblTitle.Location = New Point(100, 30)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(307, 45)
        LblTitle.TabIndex = 0
        LblTitle.Text = "Halaman Registrasi"
        ' 
        ' LblNama
        ' 
        LblNama.AutoSize = True
        LblNama.Location = New Point(50, 90)
        LblNama.Name = "LblNama"
        LblNama.Size = New Size(131, 25)
        LblNama.TabIndex = 1
        LblNama.Text = "Nama Lengkap"
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(200, 87)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(200, 31)
        TxtNama.TabIndex = 2
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.Location = New Point(50, 130)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(54, 25)
        LblEmail.TabIndex = 3
        LblEmail.Text = "Email"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(200, 127)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(200, 31)
        TxtEmail.TabIndex = 4
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.Location = New Point(50, 170)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(95, 25)
        LblPassword.TabIndex = 5
        LblPassword.Text = "Kata Sandi"
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(200, 167)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(200, 31)
        TxtPassword.TabIndex = 6
        ' 
        ' LblConfirmPassword
        ' 
        LblConfirmPassword.AutoSize = True
        LblConfirmPassword.Location = New Point(50, 210)
        LblConfirmPassword.Name = "LblConfirmPassword"
        LblConfirmPassword.Size = New Size(184, 25)
        LblConfirmPassword.TabIndex = 7
        LblConfirmPassword.Text = "Konfirmasi Kata Sandi"
        ' 
        ' TxtConfirmPassword
        ' 
        TxtConfirmPassword.Location = New Point(200, 207)
        TxtConfirmPassword.Name = "TxtConfirmPassword"
        TxtConfirmPassword.PasswordChar = "*"c
        TxtConfirmPassword.Size = New Size(200, 31)
        TxtConfirmPassword.TabIndex = 8
        ' 
        ' BtnRegister
        ' 
        BtnRegister.BackColor = Color.Teal
        BtnRegister.ForeColor = Color.White
        BtnRegister.Location = New Point(200, 260)
        BtnRegister.Name = "BtnRegister"
        BtnRegister.Size = New Size(100, 35)
        BtnRegister.TabIndex = 9
        BtnRegister.Text = "Daftar"
        BtnRegister.UseVisualStyleBackColor = False
        ' 
        ' BtnBatal
        ' 
        BtnBatal.Location = New Point(310, 260)
        BtnBatal.Name = "BtnBatal"
        BtnBatal.Size = New Size(90, 35)
        BtnBatal.TabIndex = 10
        BtnBatal.Text = "Kembali"
        BtnBatal.UseVisualStyleBackColor = True
        ' 
        ' Register
        ' 
        ClientSize = New Size(460, 330)
        Controls.Add(BtnBatal)
        Controls.Add(BtnRegister)
        Controls.Add(TxtConfirmPassword)
        Controls.Add(LblConfirmPassword)
        Controls.Add(TxtPassword)
        Controls.Add(LblPassword)
        Controls.Add(TxtEmail)
        Controls.Add(LblEmail)
        Controls.Add(TxtNama)
        Controls.Add(LblNama)
        Controls.Add(LblTitle)
        Name = "Register"
        Text = "Registrasi Akun"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents TxtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents BtnRegister As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
End Class