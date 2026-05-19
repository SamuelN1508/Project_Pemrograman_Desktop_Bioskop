<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_Ticket___Kode_QR
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
        Me.PanelSidebar = New System.Windows.Forms.Panel()
        Me.LblNikmati = New System.Windows.Forms.Label()
        Me.LblSidebarETicket = New System.Windows.Forms.Label()
        Me.PicIconTicket = New System.Windows.Forms.PictureBox()
        Me.LblETicketAnda = New System.Windows.Forms.Label()
        Me.LblTerimaKasih = New System.Windows.Forms.Label()
        Me.LblStatusIssued = New System.Windows.Forms.Label()
        Me.PicQR = New System.Windows.Forms.PictureBox()
        Me.LblPindaiTitle = New System.Windows.Forms.Label()
        Me.LblInfoScan = New System.Windows.Forms.Label()
        Me.PanelDetail = New System.Windows.Forms.Panel()
        Me.LblHarga = New System.Windows.Forms.Label() ' [TAMBAHAN] Label Harga
        Me.LblKursi = New System.Windows.Forms.Label()
        Me.LblWaktu = New System.Windows.Forms.Label()
        Me.LblStudio = New System.Windows.Forms.Label()
        Me.LblJudulFilm = New System.Windows.Forms.Label()
        Me.LblDetailTitle = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnPrev = New System.Windows.Forms.Button() ' [TAMBAHAN] Tombol Prev
        Me.BtnNext = New System.Windows.Forms.Button() ' [TAMBAHAN] Tombol Next
        Me.LblHalamanTiket = New System.Windows.Forms.Label() ' [TAMBAHAN] Info Halaman Tiket
        Me.PanelSidebar.SuspendLayout()
        CType(Me.PicIconTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetail.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' PanelSidebar
        ' 
        Me.PanelSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PanelSidebar.Controls.Add(Me.LblNikmati)
        Me.PanelSidebar.Controls.Add(Me.LblSidebarETicket)
        Me.PanelSidebar.Controls.Add(Me.PicIconTicket)
        Me.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSidebar.Location = New System.Drawing.Point(0, 0)
        Me.PanelSidebar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelSidebar.Name = "PanelSidebar"
        Me.PanelSidebar.Size = New System.Drawing.Size(171, 693)
        Me.PanelSidebar.TabIndex = 0
        ' 
        ' LblNikmati
        ' 
        Me.LblNikmati.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.LblNikmati.ForeColor = System.Drawing.Color.Gray
        Me.LblNikmati.Location = New System.Drawing.Point(0, 347)
        Me.LblNikmati.Name = "LblNikmati"
        Me.LblNikmati.Size = New System.Drawing.Size(171, 27)
        Me.LblNikmati.TabIndex = 2
        Me.LblNikmati.Text = "Nikmati film Anda"
        Me.LblNikmati.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ' 
        ' LblSidebarETicket
        ' 
        Me.LblSidebarETicket.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblSidebarETicket.ForeColor = System.Drawing.Color.Teal
        Me.LblSidebarETicket.Location = New System.Drawing.Point(0, 293)
        Me.LblSidebarETicket.Name = "LblSidebarETicket"
        Me.LblSidebarETicket.Size = New System.Drawing.Size(171, 40)
        Me.LblSidebarETicket.TabIndex = 1
        Me.LblSidebarETicket.Text = "E-Ticket"
        Me.LblSidebarETicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ' 
        ' PicIconTicket
        ' 
        Me.PicIconTicket.ImageLocation = "https://cdn-icons-png.flaticon.com/512/1828/1828439.png"
        Me.PicIconTicket.Location = New System.Drawing.Point(46, 200)
        Me.PicIconTicket.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PicIconTicket.Name = "PicIconTicket"
        Me.PicIconTicket.Size = New System.Drawing.Size(80, 80)
        Me.PicIconTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicIconTicket.TabIndex = 0
        Me.PicIconTicket.TabStop = False
        ' 
        ' LblETicketAnda
        ' 
        Me.LblETicketAnda.AutoSize = True
        Me.LblETicketAnda.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.LblETicketAnda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.LblETicketAnda.Location = New System.Drawing.Point(206, 53)
        Me.LblETicketAnda.Name = "LblETicketAnda"
        Me.LblETicketAnda.Size = New System.Drawing.Size(263, 50)
        Me.LblETicketAnda.TabIndex = 1
        Me.LblETicketAnda.Text = "E-Ticket Anda"
        ' 
        ' LblTerimaKasih
        ' 
        Me.LblTerimaKasih.AutoSize = True
        Me.LblTerimaKasih.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LblTerimaKasih.ForeColor = System.Drawing.Color.Teal
        Me.LblTerimaKasih.Location = New System.Drawing.Point(211, 113)
        Me.LblTerimaKasih.Name = "LblTerimaKasih"
        Me.LblTerimaKasih.Size = New System.Drawing.Size(324, 25)
        Me.LblTerimaKasih.TabIndex = 2
        Me.LblTerimaKasih.Text = "Terima kasih atas Pemesanan Anda!"
        ' 
        ' LblStatusIssued
        ' 
        Me.LblStatusIssued.AutoSize = True
        Me.LblStatusIssued.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblStatusIssued.ForeColor = System.Drawing.Color.Gray
        Me.LblStatusIssued.Location = New System.Drawing.Point(211, 147)
        Me.LblStatusIssued.Name = "LblStatusIssued"
        Me.LblStatusIssued.Size = New System.Drawing.Size(151, 20)
        Me.LblStatusIssued.TabIndex = 3
        Me.LblStatusIssued.Text = "Status Tiket: ISSUED"
        ' 
        ' PicQR
        ' 
        Me.PicQR.BackColor = System.Drawing.Color.White
        Me.PicQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicQR.Location = New System.Drawing.Point(240, 260)
        Me.PicQR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PicQR.Name = "PicQR"
        Me.PicQR.Size = New System.Drawing.Size(205, 239)
        Me.PicQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicQR.TabIndex = 4
        Me.PicQR.TabStop = False
        ' 
        ' LblPindaiTitle
        ' 
        Me.LblPindaiTitle.AutoSize = True
        Me.LblPindaiTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblPindaiTitle.Location = New System.Drawing.Point(250, 233)
        Me.LblPindaiTitle.Name = "LblPindaiTitle"
        Me.LblPindaiTitle.Size = New System.Drawing.Size(182, 23)
        Me.LblPindaiTitle.TabIndex = 5
        Me.LblPindaiTitle.Text = "Pindai Kode QR Anda"
        ' 
        ' LblInfoScan
        ' 
        Me.LblInfoScan.AutoSize = True
        Me.LblInfoScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblInfoScan.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.LblInfoScan.ForeColor = System.Drawing.Color.Gray
        Me.LblInfoScan.Location = New System.Drawing.Point(240, 518)
        Me.LblInfoScan.Name = "LblInfoScan"
        Me.LblInfoScan.Padding = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.LblInfoScan.Size = New System.Drawing.Size(206, 34)
        Me.LblInfoScan.TabIndex = 6
        Me.LblInfoScan.Text = "ⓘ Scan QR saat masuk studio"
        ' 
        ' BtnPrev
        ' [TAMBAHAN] Posisi Tombol Sebelumnya
        Me.BtnPrev.BackColor = System.Drawing.Color.Teal
        Me.BtnPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrev.FlatAppearance.BorderSize = 0
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrev.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPrev.ForeColor = System.Drawing.Color.White
        Me.BtnPrev.Location = New System.Drawing.Point(240, 565)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(40, 30)
        Me.BtnPrev.TabIndex = 10
        Me.BtnPrev.Text = "<"
        Me.BtnPrev.UseVisualStyleBackColor = False
        ' 
        ' LblHalamanTiket
        ' [TAMBAHAN] Posisi Label Halaman
        Me.LblHalamanTiket.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblHalamanTiket.ForeColor = System.Drawing.Color.DimGray
        Me.LblHalamanTiket.Location = New System.Drawing.Point(286, 565)
        Me.LblHalamanTiket.Name = "LblHalamanTiket"
        Me.LblHalamanTiket.Size = New System.Drawing.Size(113, 30)
        Me.LblHalamanTiket.TabIndex = 11
        Me.LblHalamanTiket.Text = "Tiket 1 dari 3"
        Me.LblHalamanTiket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ' 
        ' BtnNext
        ' [TAMBAHAN] Posisi Tombol Selanjutnya
        Me.BtnNext.BackColor = System.Drawing.Color.Teal
        Me.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNext.FlatAppearance.BorderSize = 0
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNext.ForeColor = System.Drawing.Color.White
        Me.BtnNext.Location = New System.Drawing.Point(405, 565)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(40, 30)
        Me.BtnNext.TabIndex = 12
        Me.BtnNext.Text = ">"
        Me.BtnNext.UseVisualStyleBackColor = False
        ' 
        ' PanelDetail
        ' 
        Me.PanelDetail.BackColor = System.Drawing.Color.White
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.LblHarga)
        Me.PanelDetail.Controls.Add(Me.LblKursi)
        Me.PanelDetail.Controls.Add(Me.LblWaktu)
        Me.PanelDetail.Controls.Add(Me.LblStudio)
        Me.PanelDetail.Controls.Add(Me.LblJudulFilm)
        Me.PanelDetail.Controls.Add(Me.LblDetailTitle)
        Me.PanelDetail.Location = New System.Drawing.Point(503, 213)
        Me.PanelDetail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(400, 286)
        Me.PanelDetail.TabIndex = 7
        ' 
        ' LblHarga
        ' [TAMBAHAN] Menambahkan Harga ke Panel Detail
        Me.LblHarga.AutoSize = True
        Me.LblHarga.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LblHarga.ForeColor = System.Drawing.Color.Teal
        Me.LblHarga.Location = New System.Drawing.Point(63, 243)
        Me.LblHarga.Name = "LblHarga"
        Me.LblHarga.Size = New System.Drawing.Size(84, 25)
        Me.LblHarga.TabIndex = 5
        Me.LblHarga.Text = "Rp 0"
        ' 
        ' LblKursi
        ' 
        Me.LblKursi.AutoSize = True
        Me.LblKursi.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.LblKursi.Location = New System.Drawing.Point(63, 213)
        Me.LblKursi.Name = "LblKursi"
        Me.LblKursi.Size = New System.Drawing.Size(106, 21)
        Me.LblKursi.TabIndex = 4
        Me.LblKursi.Text = "Kursi: D4, D5"
        ' 
        ' LblWaktu
        ' 
        Me.LblWaktu.AutoSize = True
        Me.LblWaktu.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LblWaktu.Location = New System.Drawing.Point(63, 167)
        Me.LblWaktu.Name = "LblWaktu"
        Me.LblWaktu.Size = New System.Drawing.Size(165, 21)
        Me.LblWaktu.TabIndex = 3
        Me.LblWaktu.Text = "15 Mei 2026   |   10:00"
        ' 
        ' LblStudio
        ' 
        Me.LblStudio.AutoSize = True
        Me.LblStudio.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.LblStudio.Location = New System.Drawing.Point(63, 120)
        Me.LblStudio.Name = "LblStudio"
        Me.LblStudio.Size = New System.Drawing.Size(67, 21)
        Me.LblStudio.TabIndex = 2
        Me.LblStudio.Text = "Studio 1"
        ' 
        ' LblJudulFilm
        ' 
        Me.LblJudulFilm.AutoSize = True
        Me.LblJudulFilm.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblJudulFilm.Location = New System.Drawing.Point(63, 73)
        Me.LblJudulFilm.Name = "LblJudulFilm"
        Me.LblJudulFilm.Size = New System.Drawing.Size(107, 23)
        Me.LblJudulFilm.TabIndex = 1
        Me.LblJudulFilm.Text = "Inside Out 2"
        ' 
        ' LblDetailTitle
        ' 
        Me.LblDetailTitle.AutoSize = True
        Me.LblDetailTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblDetailTitle.ForeColor = System.Drawing.Color.Teal
        Me.LblDetailTitle.Location = New System.Drawing.Point(17, 20)
        Me.LblDetailTitle.Name = "LblDetailTitle"
        Me.LblDetailTitle.Size = New System.Drawing.Size(104, 23)
        Me.LblDetailTitle.TabIndex = 0
        Me.LblDetailTitle.Text = "Detail Tiket"
        ' 
        ' BtnSimpan
        ' 
        Me.BtnSimpan.BackColor = System.Drawing.Color.Teal
        Me.BtnSimpan.FlatAppearance.BorderSize = 0
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSimpan.ForeColor = System.Drawing.Color.White
        Me.BtnSimpan.Location = New System.Drawing.Point(503, 527)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(400, 60)
        Me.BtnSimpan.TabIndex = 8
        Me.BtnSimpan.Text = "💾 Simpan ke Memori Perangkat"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        ' 
        ' BtnKeluar
        ' 
        Me.BtnKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnKeluar.FlatAppearance.BorderSize = 0
        Me.BtnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKeluar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnKeluar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnKeluar.Location = New System.Drawing.Point(503, 600)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(400, 60)
        Me.BtnKeluar.TabIndex = 9
        Me.BtnKeluar.Text = "🚪 Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = False
        ' 
        ' E_Ticket___Kode_QR
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(949, 693)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.LblHalamanTiket)
        Me.Controls.Add(Me.BtnPrev)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.PanelDetail)
        Me.Controls.Add(Me.LblInfoScan)
        Me.Controls.Add(Me.LblPindaiTitle)
        Me.Controls.Add(Me.PicQR)
        Me.Controls.Add(Me.LblStatusIssued)
        Me.Controls.Add(Me.LblTerimaKasih)
        Me.Controls.Add(Me.LblETicketAnda)
        Me.Controls.Add(Me.PanelSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "E_Ticket___Kode_QR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-Ticket & Kode QR"
        Me.PanelSidebar.ResumeLayout(False)
        CType(Me.PicIconTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetail.ResumeLayout(False)
        Me.PanelDetail.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents PicIconTicket As PictureBox
    Friend WithEvents LblSidebarETicket As Label
    Friend WithEvents LblNikmati As Label
    Friend WithEvents LblETicketAnda As Label
    Friend WithEvents LblTerimaKasih As Label
    Friend WithEvents LblStatusIssued As Label
    Friend WithEvents PicQR As PictureBox
    Friend WithEvents LblPindaiTitle As Label
    Friend WithEvents LblInfoScan As Label
    Friend WithEvents PanelDetail As Panel
    Friend WithEvents LblDetailTitle As Label
    Friend WithEvents LblJudulFilm As Label
    Friend WithEvents LblStudio As Label
    Friend WithEvents LblWaktu As Label
    Friend WithEvents LblKursi As Label
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnPrev As Button ' [TAMBAHAN]
    Friend WithEvents BtnNext As Button ' [TAMBAHAN]
    Friend WithEvents LblHalamanTiket As Label ' [TAMBAHAN]
    Friend WithEvents LblHarga As Label ' [TAMBAHAN]
End Class