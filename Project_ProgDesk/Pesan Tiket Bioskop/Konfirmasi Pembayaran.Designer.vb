<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPembayaran
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
        components = New ComponentModel.Container()
        PanelHeaderTimer = New Panel()
        LblWaktuTimer = New Label()
        LblSubPesanTimer = New Label()
        LblPesanTimer = New Label()
        LblTitleHalaman = New Label()
        PanelDetailKanan = New Panel()
        BtnLanjutBayar = New Button()
        PanelMetode = New Panel()
        RbKredit = New RadioButton()
        RbOvo = New RadioButton()
        RbTransfer = New RadioButton()
        LblTitleMetode = New Label()
        PanelGarisMetode = New Panel()
        LblNilaiTotal = New Label()
        LblTitleTotal = New Label()
        LblNilaiSubtotal = New Label()
        LblTitleSubtotal = New Label()
        PanelGarisBawah = New Panel()
        LblNilaiHargaTiket = New Label()
        LblInfoTiket = New Label()
        PanelGarisAtas = New Panel()
        LblWaktu = New Label()
        LblStudio = New Label()
        LblJudul = New Label()
        PicPoster = New PictureBox()
        LblTitleDetail = New Label()
        TimerPembayaran = New Timer(components)
        BtnKembali = New Button()
        PanelHeaderTimer.SuspendLayout()
        PanelDetailKanan.SuspendLayout()
        PanelMetode.SuspendLayout()
        CType(PicPoster, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelHeaderTimer
        ' 
        PanelHeaderTimer.BackColor = Color.FloralWhite
        PanelHeaderTimer.Controls.Add(LblWaktuTimer)
        PanelHeaderTimer.Controls.Add(LblSubPesanTimer)
        PanelHeaderTimer.Controls.Add(LblPesanTimer)
        PanelHeaderTimer.Dock = DockStyle.Top
        PanelHeaderTimer.Location = New Point(0, 0)
        PanelHeaderTimer.Margin = New Padding(3, 4, 3, 4)
        PanelHeaderTimer.Name = "PanelHeaderTimer"
        PanelHeaderTimer.Size = New Size(571, 93)
        PanelHeaderTimer.TabIndex = 0
        ' 
        ' LblWaktuTimer
        ' 
        LblWaktuTimer.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LblWaktuTimer.AutoSize = True
        LblWaktuTimer.BackColor = Color.Moccasin
        LblWaktuTimer.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblWaktuTimer.ForeColor = Color.SaddleBrown
        LblWaktuTimer.Location = New Point(457, 27)
        LblWaktuTimer.Name = "LblWaktuTimer"
        LblWaktuTimer.Padding = New Padding(6, 7, 6, 7)
        LblWaktuTimer.Size = New Size(77, 42)
        LblWaktuTimer.TabIndex = 2
        LblWaktuTimer.Text = "10:00"
        ' 
        ' LblSubPesanTimer
        ' 
        LblSubPesanTimer.AutoSize = True
        LblSubPesanTimer.Font = New Font("Segoe UI", 9.0F)
        LblSubPesanTimer.ForeColor = Color.DimGray
        LblSubPesanTimer.Location = New Point(23, 51)
        LblSubPesanTimer.Name = "LblSubPesanTimer"
        LblSubPesanTimer.Size = New Size(420, 20)
        LblSubPesanTimer.TabIndex = 1
        LblSubPesanTimer.Text = "Yuk, lakukan pembayaran agar pesanan kamu segera diproses."
        ' 
        ' LblPesanTimer
        ' 
        LblPesanTimer.AutoSize = True
        LblPesanTimer.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        LblPesanTimer.ForeColor = Color.DarkGoldenrod
        LblPesanTimer.Location = New Point(21, 20)
        LblPesanTimer.Name = "LblPesanTimer"
        LblPesanTimer.Size = New Size(279, 25)
        LblPesanTimer.TabIndex = 0
        LblPesanTimer.Text = "Selesaikan pembayaran dalam"
        ' 
        ' LblTitleHalaman
        ' 
        LblTitleHalaman.AutoSize = True
        LblTitleHalaman.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LblTitleHalaman.Location = New Point(57, 127)
        LblTitleHalaman.Name = "LblTitleHalaman"
        LblTitleHalaman.Size = New Size(241, 32)
        LblTitleHalaman.TabIndex = 1
        LblTitleHalaman.Text = "Konfirmasi pesanan"
        ' 
        ' PanelDetailKanan
        ' 
        PanelDetailKanan.BackColor = Color.White
        PanelDetailKanan.BorderStyle = BorderStyle.FixedSingle
        PanelDetailKanan.Controls.Add(BtnLanjutBayar)
        PanelDetailKanan.Controls.Add(PanelMetode)
        PanelDetailKanan.Controls.Add(LblTitleMetode)
        PanelDetailKanan.Controls.Add(PanelGarisMetode)
        PanelDetailKanan.Controls.Add(LblNilaiTotal)
        PanelDetailKanan.Controls.Add(LblTitleTotal)
        PanelDetailKanan.Controls.Add(LblNilaiSubtotal)
        PanelDetailKanan.Controls.Add(LblTitleSubtotal)
        PanelDetailKanan.Controls.Add(PanelGarisBawah)
        PanelDetailKanan.Controls.Add(LblNilaiHargaTiket)
        PanelDetailKanan.Controls.Add(LblInfoTiket)
        PanelDetailKanan.Controls.Add(PanelGarisAtas)
        PanelDetailKanan.Controls.Add(LblWaktu)
        PanelDetailKanan.Controls.Add(LblStudio)
        PanelDetailKanan.Controls.Add(LblJudul)
        PanelDetailKanan.Controls.Add(PicPoster)
        PanelDetailKanan.Location = New Point(57, 213)
        PanelDetailKanan.Margin = New Padding(3, 4, 3, 4)
        PanelDetailKanan.Name = "PanelDetailKanan"
        PanelDetailKanan.Size = New Size(457, 633)
        PanelDetailKanan.TabIndex = 2
        ' 
        ' BtnLanjutBayar
        ' 
        BtnLanjutBayar.BackColor = Color.DimGray
        BtnLanjutBayar.Cursor = Cursors.Hand
        BtnLanjutBayar.FlatAppearance.BorderSize = 0
        BtnLanjutBayar.FlatStyle = FlatStyle.Flat
        BtnLanjutBayar.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        BtnLanjutBayar.ForeColor = Color.White
        BtnLanjutBayar.Location = New Point(23, 533)
        BtnLanjutBayar.Margin = New Padding(3, 4, 3, 4)
        BtnLanjutBayar.Name = "BtnLanjutBayar"
        BtnLanjutBayar.Size = New Size(411, 67)
        BtnLanjutBayar.TabIndex = 16
        BtnLanjutBayar.Text = "Bayar Rp0"
        BtnLanjutBayar.UseVisualStyleBackColor = False
        ' 
        ' PanelMetode
        ' 
        PanelMetode.BackColor = Color.White
        PanelMetode.Controls.Add(RbKredit)
        PanelMetode.Controls.Add(RbOvo)
        PanelMetode.Controls.Add(RbTransfer)
        PanelMetode.Location = New Point(23, 473)
        PanelMetode.Margin = New Padding(3, 4, 3, 4)
        PanelMetode.Name = "PanelMetode"
        PanelMetode.Size = New Size(411, 40)
        PanelMetode.TabIndex = 15
        ' 
        ' RbKredit
        ' 
        RbKredit.AutoSize = True
        RbKredit.Font = New Font("Segoe UI", 9.0F)
        RbKredit.Location = New Point(291, 4)
        RbKredit.Margin = New Padding(3, 4, 3, 4)
        RbKredit.Name = "RbKredit"
        RbKredit.Size = New Size(109, 24)
        RbKredit.TabIndex = 2
        RbKredit.TabStop = True
        RbKredit.Text = "Kartu Kredit"
        RbKredit.UseVisualStyleBackColor = True
        ' 
        ' RbOvo
        ' 
        RbOvo.AutoSize = True
        RbOvo.Font = New Font("Segoe UI", 9.0F)
        RbOvo.Location = New Point(143, 4)
        RbOvo.Margin = New Padding(3, 4, 3, 4)
        RbOvo.Name = "RbOvo"
        RbOvo.Size = New Size(131, 24)
        RbOvo.TabIndex = 1
        RbOvo.TabStop = True
        RbOvo.Text = "OVO (E-Wallet)"
        RbOvo.UseVisualStyleBackColor = True
        ' 
        ' RbTransfer
        ' 
        RbTransfer.AutoSize = True
        RbTransfer.Font = New Font("Segoe UI", 9.0F)
        RbTransfer.Location = New Point(0, 4)
        RbTransfer.Margin = New Padding(3, 4, 3, 4)
        RbTransfer.Name = "RbTransfer"
        RbTransfer.Size = New Size(118, 24)
        RbTransfer.TabIndex = 0
        RbTransfer.TabStop = True
        RbTransfer.Text = "Transfer Bank"
        RbTransfer.UseVisualStyleBackColor = True
        ' 
        ' LblTitleMetode
        ' 
        LblTitleMetode.AutoSize = True
        LblTitleMetode.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblTitleMetode.ForeColor = Color.Black
        LblTitleMetode.Location = New Point(23, 440)
        LblTitleMetode.Name = "LblTitleMetode"
        LblTitleMetode.Size = New Size(175, 23)
        LblTitleMetode.TabIndex = 14
        LblTitleMetode.Text = "Metode Pembayaran"
        ' 
        ' PanelGarisMetode
        ' 
        PanelGarisMetode.BackColor = Color.Gainsboro
        PanelGarisMetode.Location = New Point(23, 427)
        PanelGarisMetode.Margin = New Padding(3, 4, 3, 4)
        PanelGarisMetode.Name = "PanelGarisMetode"
        PanelGarisMetode.Size = New Size(411, 1)
        PanelGarisMetode.TabIndex = 13
        ' 
        ' LblNilaiTotal
        ' 
        LblNilaiTotal.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        LblNilaiTotal.Location = New Point(263, 380)
        LblNilaiTotal.Name = "LblNilaiTotal"
        LblNilaiTotal.Size = New Size(171, 27)
        LblNilaiTotal.TabIndex = 11
        LblNilaiTotal.Text = "Rp0"
        LblNilaiTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblTitleTotal
        ' 
        LblTitleTotal.AutoSize = True
        LblTitleTotal.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblTitleTotal.Location = New Point(23, 380)
        LblTitleTotal.Name = "LblTitleTotal"
        LblTitleTotal.Size = New Size(154, 23)
        LblTitleTotal.TabIndex = 10
        LblTitleTotal.Text = "Total pembayaran"
        ' 
        ' LblNilaiSubtotal
        ' 
        LblNilaiSubtotal.Font = New Font("Segoe UI", 10.0F)
        LblNilaiSubtotal.ForeColor = Color.DimGray
        LblNilaiSubtotal.Location = New Point(263, 340)
        LblNilaiSubtotal.Name = "LblNilaiSubtotal"
        LblNilaiSubtotal.Size = New Size(171, 27)
        LblNilaiSubtotal.TabIndex = 9
        LblNilaiSubtotal.Text = "Rp0"
        LblNilaiSubtotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblTitleSubtotal
        ' 
        LblTitleSubtotal.AutoSize = True
        LblTitleSubtotal.Font = New Font("Segoe UI", 10.0F)
        LblTitleSubtotal.Location = New Point(23, 340)
        LblTitleSubtotal.Name = "LblTitleSubtotal"
        LblTitleSubtotal.Size = New Size(74, 23)
        LblTitleSubtotal.TabIndex = 8
        LblTitleSubtotal.Text = "Subtotal"
        ' 
        ' PanelGarisBawah
        ' 
        PanelGarisBawah.BackColor = Color.Gainsboro
        PanelGarisBawah.Location = New Point(23, 320)
        PanelGarisBawah.Margin = New Padding(3, 4, 3, 4)
        PanelGarisBawah.Name = "PanelGarisBawah"
        PanelGarisBawah.Size = New Size(411, 1)
        PanelGarisBawah.TabIndex = 7
        ' 
        ' LblNilaiHargaTiket
        ' 
        LblNilaiHargaTiket.Font = New Font("Segoe UI", 10.0F)
        LblNilaiHargaTiket.ForeColor = Color.DimGray
        LblNilaiHargaTiket.Location = New Point(263, 253)
        LblNilaiHargaTiket.Name = "LblNilaiHargaTiket"
        LblNilaiHargaTiket.Size = New Size(171, 53)
        LblNilaiHargaTiket.TabIndex = 6
        LblNilaiHargaTiket.Text = "1 x Rp0" & vbCrLf & "Rp0"
        LblNilaiHargaTiket.TextAlign = ContentAlignment.TopRight
        ' 
        ' LblInfoTiket
        ' 
        LblInfoTiket.Font = New Font("Segoe UI", 10.0F)
        LblInfoTiket.Location = New Point(23, 253)
        LblInfoTiket.Name = "LblInfoTiket"
        LblInfoTiket.Size = New Size(229, 53)
        LblInfoTiket.TabIndex = 5
        LblInfoTiket.Text = "Tiket" & vbCrLf & "-"
        ' 
        ' PanelGarisAtas
        ' 
        PanelGarisAtas.BackColor = Color.Gainsboro
        PanelGarisAtas.Location = New Point(23, 233)
        PanelGarisAtas.Margin = New Padding(3, 4, 3, 4)
        PanelGarisAtas.Name = "PanelGarisAtas"
        PanelGarisAtas.Size = New Size(411, 1)
        PanelGarisAtas.TabIndex = 4
        ' 
        ' LblWaktu
        ' 
        LblWaktu.Font = New Font("Segoe UI", 9.0F)
        LblWaktu.ForeColor = Color.DimGray
        LblWaktu.Location = New Point(137, 160)
        LblWaktu.Name = "LblWaktu"
        LblWaktu.Size = New Size(297, 53)
        LblWaktu.TabIndex = 3
        LblWaktu.Text = "Hari, Tanggal | Jam"
        ' 
        ' LblStudio
        ' 
        LblStudio.Font = New Font("Segoe UI", 9.0F)
        LblStudio.ForeColor = Color.DimGray
        LblStudio.Location = New Point(137, 127)
        LblStudio.Name = "LblStudio"
        LblStudio.Size = New Size(297, 27)
        LblStudio.TabIndex = 2
        LblStudio.Text = "CinemaHub, Studio"
        ' 
        ' LblJudul
        ' 
        LblJudul.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        LblJudul.Location = New Point(137, 27)
        LblJudul.Name = "LblJudul"
        LblJudul.Size = New Size(297, 80)
        LblJudul.TabIndex = 1
        LblJudul.Text = "JUDUL FILM"
        ' 
        ' PicPoster
        ' 
        PicPoster.BackColor = Color.Gainsboro
        PicPoster.Location = New Point(23, 27)
        PicPoster.Margin = New Padding(3, 4, 3, 4)
        PicPoster.Name = "PicPoster"
        PicPoster.Size = New Size(103, 173)
        PicPoster.SizeMode = PictureBoxSizeMode.Zoom
        PicPoster.TabIndex = 0
        PicPoster.TabStop = False
        ' 
        ' LblTitleDetail
        ' 
        LblTitleDetail.AutoSize = True
        LblTitleDetail.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        LblTitleDetail.ForeColor = Color.DarkSlateGray
        LblTitleDetail.Location = New Point(57, 180)
        LblTitleDetail.Name = "LblTitleDetail"
        LblTitleDetail.Size = New Size(142, 25)
        LblTitleDetail.TabIndex = 3
        LblTitleDetail.Text = "Detail pesanan"
        ' 
        ' TimerPembayaran
        ' 
        TimerPembayaran.Interval = 1000
        ' 
        ' BtnKembali
        ' 
        BtnKembali.Cursor = Cursors.Hand
        BtnKembali.FlatAppearance.BorderSize = 0
        BtnKembali.FlatStyle = FlatStyle.Flat
        BtnKembali.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        BtnKembali.Location = New Point(11, 120)
        BtnKembali.Margin = New Padding(3, 4, 3, 4)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(46, 47)
        BtnKembali.TabIndex = 6
        BtnKembali.Text = "←"
        BtnKembali.UseVisualStyleBackColor = True
        ' 
        ' FormPembayaran
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(571, 907)
        Controls.Add(BtnKembali)
        Controls.Add(LblTitleDetail)
        Controls.Add(PanelDetailKanan)
        Controls.Add(LblTitleHalaman)
        Controls.Add(PanelHeaderTimer)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormPembayaran"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Konfirmasi Pesanan"
        PanelHeaderTimer.ResumeLayout(False)
        PanelHeaderTimer.PerformLayout()
        PanelDetailKanan.ResumeLayout(False)
        PanelDetailKanan.PerformLayout()
        PanelMetode.ResumeLayout(False)
        PanelMetode.PerformLayout()
        CType(PicPoster, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PanelHeaderTimer As Panel
    Friend WithEvents LblPesanTimer As Label
    Friend WithEvents LblWaktuTimer As Label
    Friend WithEvents LblSubPesanTimer As Label
    Friend WithEvents LblTitleHalaman As Label
    Friend WithEvents PanelDetailKanan As Panel
    Friend WithEvents PicPoster As PictureBox
    Friend WithEvents LblJudul As Label
    Friend WithEvents LblWaktu As Label
    Friend WithEvents LblStudio As Label
    Friend WithEvents LblTitleDetail As Label
    Friend WithEvents PanelGarisAtas As Panel
    Friend WithEvents LblNilaiHargaTiket As Label
    Friend WithEvents LblInfoTiket As Label
    Friend WithEvents PanelGarisBawah As Panel
    Friend WithEvents LblNilaiTotal As Label
    Friend WithEvents LblTitleTotal As Label
    Friend WithEvents LblNilaiSubtotal As Label
    Friend WithEvents LblTitleSubtotal As Label
    Friend WithEvents BtnLanjutBayar As Button
    Friend WithEvents LblTitleMetode As Label
    Friend WithEvents PanelMetode As Panel
    Friend WithEvents PanelGarisMetode As Panel
    Friend WithEvents RbKredit As RadioButton
    Friend WithEvents RbOvo As RadioButton
    Friend WithEvents RbTransfer As RadioButton
    Friend WithEvents TimerPembayaran As Timer
    Friend WithEvents BtnKembali As Button
End Class