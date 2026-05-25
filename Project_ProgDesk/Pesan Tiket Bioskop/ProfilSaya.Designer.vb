<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfilSaya
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        PnlHeader = New Panel()
        LblTitle = New Label()
        PnlBody = New Panel()
        BtnKembali = New Button()
        LblEmail = New Label()
        LblEmailStatic = New Label()
        LblNama = New Label()
        LblNamaStatic = New Label()
        PnlHeader.SuspendLayout()
        PnlBody.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlHeader
        ' 
        PnlHeader.BackColor = Color.Teal
        PnlHeader.Controls.Add(LblTitle)
        PnlHeader.Dock = DockStyle.Top
        PnlHeader.Location = New Point(0, 0)
        PnlHeader.Name = "PnlHeader"
        PnlHeader.Size = New Size(402, 60)
        PnlHeader.TabIndex = 1
        ' 
        ' LblTitle
        ' 
        LblTitle.Dock = DockStyle.Fill
        LblTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblTitle.ForeColor = Color.White
        LblTitle.Location = New Point(0, 0)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(402, 60)
        LblTitle.TabIndex = 0
        LblTitle.Text = "Profil Saya"
        LblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlBody
        ' 
        PnlBody.Controls.Add(BtnKembali)
        PnlBody.Controls.Add(LblEmail)
        PnlBody.Controls.Add(LblEmailStatic)
        PnlBody.Controls.Add(LblNama)
        PnlBody.Controls.Add(LblNamaStatic)
        PnlBody.Dock = DockStyle.Fill
        PnlBody.Location = New Point(0, 60)
        PnlBody.Name = "PnlBody"
        PnlBody.Padding = New Padding(30)
        PnlBody.Size = New Size(402, 223)
        PnlBody.TabIndex = 0
        ' 
        ' BtnKembali
        ' 
        BtnKembali.BackColor = Color.Teal
        BtnKembali.Cursor = Cursors.Hand
        BtnKembali.FlatAppearance.BorderSize = 0
        BtnKembali.FlatStyle = FlatStyle.Flat
        BtnKembali.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnKembali.ForeColor = Color.White
        BtnKembali.Location = New Point(30, 171)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(320, 40)
        BtnKembali.TabIndex = 0
        BtnKembali.Text = "Kembali"
        BtnKembali.UseVisualStyleBackColor = False
        ' 
        ' LblEmail
        ' 
        LblEmail.BorderStyle = BorderStyle.FixedSingle
        LblEmail.Font = New Font("Segoe UI", 11F)
        LblEmail.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        LblEmail.Location = New Point(30, 130)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(320, 30)
        LblEmail.TabIndex = 1
        LblEmail.Text = "-"
        ' 
        ' LblEmailStatic
        ' 
        LblEmailStatic.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblEmailStatic.ForeColor = Color.Gray
        LblEmailStatic.Location = New Point(30, 105)
        LblEmailStatic.Name = "LblEmailStatic"
        LblEmailStatic.Size = New Size(120, 20)
        LblEmailStatic.TabIndex = 2
        LblEmailStatic.Text = "Email"
        ' 
        ' LblNama
        ' 
        LblNama.BorderStyle = BorderStyle.FixedSingle
        LblNama.Font = New Font("Segoe UI", 11F)
        LblNama.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        LblNama.Location = New Point(30, 55)
        LblNama.Name = "LblNama"
        LblNama.Size = New Size(320, 30)
        LblNama.TabIndex = 3
        LblNama.Text = "-"
        ' 
        ' LblNamaStatic
        ' 
        LblNamaStatic.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblNamaStatic.ForeColor = Color.Gray
        LblNamaStatic.Location = New Point(30, 30)
        LblNamaStatic.Name = "LblNamaStatic"
        LblNamaStatic.Size = New Size(120, 20)
        LblNamaStatic.TabIndex = 4
        LblNamaStatic.Text = "Nama Lengkap"
        ' 
        ' ProfilSaya
        ' 
        BackColor = Color.White
        ClientSize = New Size(402, 283)
        Controls.Add(PnlBody)
        Controls.Add(PnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "ProfilSaya"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Profil Saya"
        PnlHeader.ResumeLayout(False)
        PnlBody.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents PnlBody As System.Windows.Forms.Panel
    Friend WithEvents LblNamaStatic As System.Windows.Forms.Label
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents LblEmailStatic As System.Windows.Forms.Label
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents BtnKembali As System.Windows.Forms.Button
End Class