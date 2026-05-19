<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pilih_Kursi
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
        PanelKiri = New Panel()
        FlpKursi = New FlowLayoutPanel()
        PanelLayar = New Panel()
        LblLayar = New Label()
        PanelKanan = New Panel()
        PicPosterDetail = New PictureBox()
        LblJudulDetail = New Label()
        LblStudioDetail = New Label()
        LblWaktuDetail = New Label()
        PanelGaris = New Panel()
        LblTitleKursi = New Label()
        LblKursiTerpilih = New Label()
        LblTitleTotal = New Label()
        LblTotalHarga = New Label()
        BtnKembali = New Button()
        BtnLanjutBayar = New Button()
        PanelKiri.SuspendLayout()
        PanelLayar.SuspendLayout()
        PanelKanan.SuspendLayout()
        CType(PicPosterDetail, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelKiri
        ' 
        PanelKiri.BackColor = Color.WhiteSmoke
        PanelKiri.Controls.Add(FlpKursi)
        PanelKiri.Controls.Add(PanelLayar)
        PanelKiri.Dock = DockStyle.Fill
        PanelKiri.Location = New Point(0, 0)
        PanelKiri.Margin = New Padding(3, 4, 3, 4)
        PanelKiri.Name = "PanelKiri"
        PanelKiri.Padding = New Padding(23, 27, 23, 27)
        PanelKiri.Size = New Size(743, 800)
        PanelKiri.TabIndex = 0
        ' 
        ' FlpKursi
        ' 
        FlpKursi.Dock = DockStyle.Fill
        FlpKursi.Location = New Point(23, 67)
        FlpKursi.Margin = New Padding(3, 4, 3, 4)
        FlpKursi.Name = "FlpKursi"
        FlpKursi.Padding = New Padding(11, 13, 11, 13)
        FlpKursi.Size = New Size(697, 706)
        FlpKursi.TabIndex = 1
        ' 
        ' PanelLayar
        ' 
        PanelLayar.BackColor = Color.LightGray
        PanelLayar.Controls.Add(LblLayar)
        PanelLayar.Dock = DockStyle.Top
        PanelLayar.Location = New Point(23, 27)
        PanelLayar.Margin = New Padding(3, 4, 3, 4)
        PanelLayar.Name = "PanelLayar"
        PanelLayar.Size = New Size(697, 40)
        PanelLayar.TabIndex = 0
        ' 
        ' LblLayar
        ' 
        LblLayar.Dock = DockStyle.Fill
        LblLayar.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblLayar.ForeColor = Color.DimGray
        LblLayar.Location = New Point(0, 0)
        LblLayar.Name = "LblLayar"
        LblLayar.Size = New Size(697, 40)
        LblLayar.TabIndex = 0
        LblLayar.Text = "A R E A   L A Y A R"
        LblLayar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelKanan
        ' 
        PanelKanan.BackColor = Color.White
        PanelKanan.Controls.Add(PicPosterDetail)
        PanelKanan.Controls.Add(LblJudulDetail)
        PanelKanan.Controls.Add(LblStudioDetail)
        PanelKanan.Controls.Add(LblWaktuDetail)
        PanelKanan.Controls.Add(PanelGaris)
        PanelKanan.Controls.Add(LblTitleKursi)
        PanelKanan.Controls.Add(LblKursiTerpilih)
        PanelKanan.Controls.Add(LblTitleTotal)
        PanelKanan.Controls.Add(LblTotalHarga)
        PanelKanan.Controls.Add(BtnKembali)
        PanelKanan.Controls.Add(BtnLanjutBayar)
        PanelKanan.Dock = DockStyle.Right
        PanelKanan.Location = New Point(743, 0)
        PanelKanan.Margin = New Padding(3, 4, 3, 4)
        PanelKanan.Name = "PanelKanan"
        PanelKanan.Size = New Size(400, 800)
        PanelKanan.TabIndex = 1
        ' 
        ' PicPosterDetail
        ' 
        PicPosterDetail.BackColor = Color.Gainsboro
        PicPosterDetail.Location = New Point(23, 40)
        PicPosterDetail.Margin = New Padding(3, 4, 3, 4)
        PicPosterDetail.Name = "PicPosterDetail"
        PicPosterDetail.Size = New Size(114, 187)
        PicPosterDetail.SizeMode = PictureBoxSizeMode.Zoom
        PicPosterDetail.TabIndex = 0
        PicPosterDetail.TabStop = False
        ' 
        ' LblJudulDetail
        ' 
        LblJudulDetail.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LblJudulDetail.Location = New Point(154, 40)
        LblJudulDetail.Name = "LblJudulDetail"
        LblJudulDetail.Size = New Size(229, 67)
        LblJudulDetail.TabIndex = 1
        LblJudulDetail.Text = "JUDUL FILM"
        ' 
        ' LblStudioDetail
        ' 
        LblStudioDetail.Font = New Font("Segoe UI", 9.5F)
        LblStudioDetail.ForeColor = Color.DimGray
        LblStudioDetail.Location = New Point(154, 120)
        LblStudioDetail.Name = "LblStudioDetail"
        LblStudioDetail.Size = New Size(229, 27)
        LblStudioDetail.TabIndex = 2
        LblStudioDetail.Text = "Nama Studio"
        ' 
        ' LblWaktuDetail
        ' 
        LblWaktuDetail.Font = New Font("Segoe UI", 9.5F)
        LblWaktuDetail.ForeColor = Color.DimGray
        LblWaktuDetail.Location = New Point(154, 160)
        LblWaktuDetail.Name = "LblWaktuDetail"
        LblWaktuDetail.Size = New Size(229, 53)
        LblWaktuDetail.TabIndex = 3
        LblWaktuDetail.Text = "Tanggal, Waktu"
        ' 
        ' PanelGaris
        ' 
        PanelGaris.BackColor = Color.LightGray
        PanelGaris.Location = New Point(23, 253)
        PanelGaris.Margin = New Padding(3, 4, 3, 4)
        PanelGaris.Name = "PanelGaris"
        PanelGaris.Size = New Size(354, 1)
        PanelGaris.TabIndex = 4
        ' 
        ' LblTitleKursi
        ' 
        LblTitleKursi.AutoSize = True
        LblTitleKursi.Font = New Font("Segoe UI", 10.0F)
        LblTitleKursi.ForeColor = Color.Gray
        LblTitleKursi.Location = New Point(23, 280)
        LblTitleKursi.Name = "LblTitleKursi"
        LblTitleKursi.Size = New Size(106, 23)
        LblTitleKursi.TabIndex = 5
        LblTitleKursi.Text = "Nomor Kursi"
        ' 
        ' LblKursiTerpilih
        ' 
        LblKursiTerpilih.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        LblKursiTerpilih.ForeColor = Color.DarkSlateGray
        LblKursiTerpilih.Location = New Point(23, 320)
        LblKursiTerpilih.Name = "LblKursiTerpilih"
        LblKursiTerpilih.Size = New Size(354, 67)
        LblKursiTerpilih.TabIndex = 6
        LblKursiTerpilih.Text = "-"
        ' 
        ' LblTitleTotal
        ' 
        LblTitleTotal.AutoSize = True
        LblTitleTotal.Font = New Font("Segoe UI", 10.0F)
        LblTitleTotal.ForeColor = Color.Gray
        LblTitleTotal.Location = New Point(23, 413)
        LblTitleTotal.Name = "LblTitleTotal"
        LblTitleTotal.Size = New Size(145, 23)
        LblTitleTotal.TabIndex = 7
        LblTitleTotal.Text = "Total Pembayaran"
        ' 
        ' LblTotalHarga
        ' 
        LblTotalHarga.AutoSize = True
        LblTotalHarga.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        LblTotalHarga.ForeColor = Color.Teal
        LblTotalHarga.Location = New Point(21, 453)
        LblTotalHarga.Name = "LblTotalHarga"
        LblTotalHarga.Size = New Size(68, 37)
        LblTotalHarga.TabIndex = 8
        LblTotalHarga.Text = "Rp0"
        ' 
        ' BtnKembali
        ' 
        BtnKembali.BackColor = Color.LightGray
        BtnKembali.Cursor = Cursors.Hand
        BtnKembali.Dock = DockStyle.Bottom
        BtnKembali.FlatAppearance.BorderSize = 0
        BtnKembali.FlatStyle = FlatStyle.Flat
        BtnKembali.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        BtnKembali.ForeColor = Color.DimGray
        BtnKembali.Location = New Point(0, 676)
        BtnKembali.Margin = New Padding(3, 4, 3, 4)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(400, 44)
        BtnKembali.TabIndex = 10
        BtnKembali.Text = "Kembali"
        BtnKembali.UseVisualStyleBackColor = False
        ' 
        ' BtnLanjutBayar
        ' 
        BtnLanjutBayar.BackColor = Color.Teal
        BtnLanjutBayar.Cursor = Cursors.Hand
        BtnLanjutBayar.Dock = DockStyle.Bottom
        BtnLanjutBayar.FlatAppearance.BorderSize = 0
        BtnLanjutBayar.FlatStyle = FlatStyle.Flat
        BtnLanjutBayar.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        BtnLanjutBayar.ForeColor = Color.White
        BtnLanjutBayar.Location = New Point(0, 720)
        BtnLanjutBayar.Margin = New Padding(3, 4, 3, 4)
        BtnLanjutBayar.Name = "BtnLanjutBayar"
        BtnLanjutBayar.Size = New Size(400, 80)
        BtnLanjutBayar.TabIndex = 9
        BtnLanjutBayar.Text = "Lanjut ke Pembayaran"
        BtnLanjutBayar.UseVisualStyleBackColor = False
        ' 
        ' Pilih_Kursi
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 800)
        Controls.Add(PanelKiri)
        Controls.Add(PanelKanan)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Pilih_Kursi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pilih Kursi"
        PanelKiri.ResumeLayout(False)
        PanelLayar.ResumeLayout(False)
        PanelKanan.ResumeLayout(False)
        PanelKanan.PerformLayout()
        CType(PicPosterDetail, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelKiri As Panel
    Friend WithEvents PanelKanan As Panel
    Friend WithEvents PanelLayar As Panel
    Friend WithEvents LblLayar As Label
    Friend WithEvents FlpKursi As FlowLayoutPanel
    Friend WithEvents PicPosterDetail As PictureBox
    Friend WithEvents LblJudulDetail As Label
    Friend WithEvents LblStudioDetail As Label
    Friend WithEvents LblWaktuDetail As Label
    Friend WithEvents PanelGaris As Panel
    Friend WithEvents LblTitleKursi As Label
    Friend WithEvents LblKursiTerpilih As Label
    Friend WithEvents LblTitleTotal As Label
    Friend WithEvents LblTotalHarga As Label
    Friend WithEvents BtnLanjutBayar As Button
    Friend WithEvents BtnKembali As Button ' [TAMBAHAN]
End Class