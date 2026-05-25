<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TentangKami
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
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PnlBody = New System.Windows.Forms.Panel()
        Me.LblNamaAplikasi = New System.Windows.Forms.Label()
        Me.LblVersi = New System.Windows.Forms.Label()
        Me.LblDeskripsiStatic = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.LblAnggotaStatic = New System.Windows.Forms.Label()
        Me.LblAnggota = New System.Windows.Forms.Label()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.PnlHeader.SuspendLayout()
        Me.PnlBody.SuspendLayout()
        Me.SuspendLayout()

        ' PnlHeader
        Me.PnlHeader.BackColor = System.Drawing.Color.Teal
        Me.PnlHeader.Controls.Add(Me.LblTitle)
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Height = 60

        ' LblTitle
        Me.LblTitle.Text = "Tentang Kami"
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' PnlBody
        Me.PnlBody.Padding = New System.Windows.Forms.Padding(30)
        Me.PnlBody.Controls.Add(Me.BtnKembali)
        Me.PnlBody.Controls.Add(Me.LblAnggota)
        Me.PnlBody.Controls.Add(Me.LblAnggotaStatic)
        Me.PnlBody.Controls.Add(Me.LblDeskripsi)
        Me.PnlBody.Controls.Add(Me.LblDeskripsiStatic)
        Me.PnlBody.Controls.Add(Me.LblVersi)
        Me.PnlBody.Controls.Add(Me.LblNamaAplikasi)
        Me.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill

        ' LblNamaAplikasi
        Me.LblNamaAplikasi.Text = "CinemaHub"
        Me.LblNamaAplikasi.Font = New System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold)
        Me.LblNamaAplikasi.ForeColor = System.Drawing.Color.Teal
        Me.LblNamaAplikasi.Location = New System.Drawing.Point(30, 20)
        Me.LblNamaAplikasi.Size = New System.Drawing.Size(360, 40)

        ' LblVersi
        Me.LblVersi.Text = "Versi 1.0.0  •  2026"
        Me.LblVersi.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.LblVersi.ForeColor = System.Drawing.Color.Gray
        Me.LblVersi.Location = New System.Drawing.Point(30, 60)
        Me.LblVersi.Size = New System.Drawing.Size(360, 20)

        ' LblDeskripsiStatic
        Me.LblDeskripsiStatic.Text = "Deskripsi"
        Me.LblDeskripsiStatic.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.LblDeskripsiStatic.ForeColor = System.Drawing.Color.Gray
        Me.LblDeskripsiStatic.Location = New System.Drawing.Point(30, 95)
        Me.LblDeskripsiStatic.Size = New System.Drawing.Size(360, 20)

        ' LblDeskripsi
        Me.LblDeskripsi.Text = "CinemaHub adalah aplikasi pemesanan tiket bioskop berbasis desktop " &
                               "yang memudahkan pengguna dalam memilih film, studio, jadwal, " &
                               "dan kursi secara praktis. Dilengkapi dengan e-ticket digital " &
                               "dan kode QR untuk kemudahan akses di bioskop."
        Me.LblDeskripsi.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.LblDeskripsi.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.LblDeskripsi.Location = New System.Drawing.Point(30, 118)
        Me.LblDeskripsi.Size = New System.Drawing.Size(360, 80)
        Me.LblDeskripsi.AutoSize = False

        ' LblAnggotaStatic
        Me.LblAnggotaStatic.Text = "Dikembangkan Oleh"
        Me.LblAnggotaStatic.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.LblAnggotaStatic.ForeColor = System.Drawing.Color.Gray
        Me.LblAnggotaStatic.Location = New System.Drawing.Point(30, 210)
        Me.LblAnggotaStatic.Size = New System.Drawing.Size(360, 20)

        ' LblAnggota
        Me.LblAnggota.Text = "1. Cynthia Angeline           - 71220858" & Environment.NewLine &
                             "2. Fransina Riyanty Batlayar  - 71231014" & Environment.NewLine &
                             "3. Amelia Agustin             - 71231038" & Environment.NewLine &
                             "4. Nengah Yesi Putri          - 71231047" & Environment.NewLine &
                             "5. Samuel Natanael            - 71231050"
        Me.LblAnggota.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.LblAnggota.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.LblAnggota.Location = New System.Drawing.Point(30, 235)
        Me.LblAnggota.Size = New System.Drawing.Size(360, 110)
        Me.LblAnggota.AutoSize = False

        ' BtnKembali
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.BtnKembali.BackColor = System.Drawing.Color.Teal
        Me.BtnKembali.ForeColor = System.Drawing.Color.White
        Me.BtnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKembali.FlatAppearance.BorderSize = 0
        Me.BtnKembali.Location = New System.Drawing.Point(30, 360)
        Me.BtnKembali.Size = New System.Drawing.Size(360, 40)
        Me.BtnKembali.Cursor = System.Windows.Forms.Cursors.Hand

        ' TentangKami Form
        Me.Text = "Tentang Kami"
        Me.Size = New System.Drawing.Size(440, 490)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Controls.Add(Me.PnlBody)
        Me.Controls.Add(Me.PnlHeader)

        Me.PnlHeader.ResumeLayout(False)
        Me.PnlBody.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents PnlBody As System.Windows.Forms.Panel
    Friend WithEvents LblNamaAplikasi As System.Windows.Forms.Label
    Friend WithEvents LblVersi As System.Windows.Forms.Label
    Friend WithEvents LblDeskripsiStatic As System.Windows.Forms.Label
    Friend WithEvents LblDeskripsi As System.Windows.Forms.Label
    Friend WithEvents LblAnggotaStatic As System.Windows.Forms.Label
    Friend WithEvents LblAnggota As System.Windows.Forms.Label
    Friend WithEvents BtnKembali As System.Windows.Forms.Button

End Class