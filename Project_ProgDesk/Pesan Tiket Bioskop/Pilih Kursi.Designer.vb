<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PilihKursi
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
        PnlLayar = New Panel()
        LblLayar = New Label()
        PnlLegend = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        BoxTerblokir = New PictureBox()
        BoxDipilih = New PictureBox()
        BoxDipesan = New PictureBox()
        BoxTersedia = New PictureBox()
        PnlKursi = New Panel()
        LblKursiDipilih = New Label()
        PnlDetail = New Panel()
        LblDetailInfo = New Label()
        LblDetailJudul = New Label()
        BtnLanjut = New Button()
        PnlLayar.SuspendLayout()
        PnlLegend.SuspendLayout()
        CType(BoxTerblokir, ComponentModel.ISupportInitialize).BeginInit()
        CType(BoxDipilih, ComponentModel.ISupportInitialize).BeginInit()
        CType(BoxDipesan, ComponentModel.ISupportInitialize).BeginInit()
        CType(BoxTersedia, ComponentModel.ISupportInitialize).BeginInit()
        PnlDetail.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        LblTitle.Location = New Point(20, 15)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(280, 37)
        LblTitle.TabIndex = 0
        LblTitle.Text = "Halaman Pilih Kursi"
        ' 
        ' PnlLayar
        ' 
        PnlLayar.Controls.Add(LblLayar)
        PnlLayar.Location = New Point(30, 70)
        PnlLayar.Name = "PnlLayar"
        PnlLayar.Size = New Size(540, 30)
        PnlLayar.TabIndex = 1
        ' 
        ' LblLayar
        ' 
        LblLayar.AutoSize = True
        LblLayar.BackColor = Color.FromArgb(240, 240, 240)
        LblLayar.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblLayar.Location = New Point(245, 5)
        LblLayar.Name = "LblLayar"
        LblLayar.Size = New Size(47, 20)
        LblLayar.TabIndex = 0
        LblLayar.Text = "Layar"
        ' 
        ' PnlLegend
        ' 
        PnlLegend.Controls.Add(Label5)
        PnlLegend.Controls.Add(Label6)
        PnlLegend.Controls.Add(Label7)
        PnlLegend.Controls.Add(Label8)
        PnlLegend.Controls.Add(BoxTerblokir)
        PnlLegend.Controls.Add(BoxDipilih)
        PnlLegend.Controls.Add(BoxDipesan)
        PnlLegend.Controls.Add(BoxTersedia)
        PnlLegend.Location = New Point(680, 110)
        PnlLegend.Name = "PnlLegend"
        PnlLegend.Size = New Size(120, 140)
        PnlLegend.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 105)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 7
        Label5.Text = "Terblokir"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(35, 75)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 6
        Label6.Text = "Dipilih"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(35, 45)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 20)
        Label7.TabIndex = 5
        Label7.Text = "Dipesan"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(35, 15)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 20)
        Label8.TabIndex = 4
        Label8.Text = "Tersedia"
        ' 
        ' BoxTerblokir
        ' 
        BoxTerblokir.BackColor = Color.Gray
        BoxTerblokir.BorderStyle = BorderStyle.FixedSingle
        BoxTerblokir.Location = New Point(10, 105)
        BoxTerblokir.Name = "BoxTerblokir"
        BoxTerblokir.Size = New Size(20, 20)
        BoxTerblokir.TabIndex = 3
        BoxTerblokir.TabStop = False
        ' 
        ' BoxDipilih
        ' 
        BoxDipilih.BackColor = Color.FromArgb(46, 139, 135)
        BoxDipilih.BorderStyle = BorderStyle.FixedSingle
        BoxDipilih.Location = New Point(10, 75)
        BoxDipilih.Name = "BoxDipilih"
        BoxDipilih.Size = New Size(20, 20)
        BoxDipilih.TabIndex = 2
        BoxDipilih.TabStop = False
        ' 
        ' BoxDipesan
        ' 
        BoxDipesan.BackColor = Color.IndianRed
        BoxDipesan.BorderStyle = BorderStyle.FixedSingle
        BoxDipesan.Location = New Point(10, 45)
        BoxDipesan.Name = "BoxDipesan"
        BoxDipesan.Size = New Size(20, 20)
        BoxDipesan.TabIndex = 1
        BoxDipesan.TabStop = False
        ' 
        ' BoxTersedia
        ' 
        BoxTersedia.BackColor = Color.White
        BoxTersedia.BorderStyle = BorderStyle.FixedSingle
        BoxTersedia.Location = New Point(10, 15)
        BoxTersedia.Name = "BoxTersedia"
        BoxTersedia.Size = New Size(20, 20)
        BoxTersedia.TabIndex = 0
        BoxTersedia.TabStop = False
        ' 
        ' PnlKursi
        ' 
        PnlKursi.Location = New Point(25, 110)
        PnlKursi.Name = "PnlKursi"
        PnlKursi.Size = New Size(650, 320)
        PnlKursi.TabIndex = 3
        ' 
        ' LblKursiDipilih
        ' 
        LblKursiDipilih.AutoSize = True
        LblKursiDipilih.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LblKursiDipilih.Location = New Point(25, 460)
        LblKursiDipilih.Name = "LblKursiDipilih"
        LblKursiDipilih.Size = New Size(171, 23)
        LblKursiDipilih.TabIndex = 4
        LblKursiDipilih.Text = "Kursi yang dipilih: -"
        ' 
        ' PnlDetail
        ' 
        PnlDetail.BackColor = Color.White
        PnlDetail.BorderStyle = BorderStyle.FixedSingle
        PnlDetail.Controls.Add(LblDetailInfo)
        PnlDetail.Controls.Add(LblDetailJudul)
        PnlDetail.Location = New Point(525, 440)
        PnlDetail.Name = "PnlDetail"
        PnlDetail.Size = New Size(300, 60)
        PnlDetail.TabIndex = 5
        ' 
        ' LblDetailInfo
        ' 
        LblDetailInfo.AutoSize = True
        LblDetailInfo.Font = New Font("Segoe UI", 9.0F)
        LblDetailInfo.Location = New Point(5, 30)
        LblDetailInfo.Name = "LblDetailInfo"
        LblDetailInfo.Size = New Size(195, 20)
        LblDetailInfo.TabIndex = 1
        LblDetailInfo.Text = "Film Title | Studio 1 | 14:00"
        ' 
        ' LblDetailJudul
        ' 
        LblDetailJudul.AutoSize = True
        LblDetailJudul.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        LblDetailJudul.Location = New Point(5, 5)
        LblDetailJudul.Name = "LblDetailJudul"
        LblDetailJudul.Size = New Size(140, 20)
        LblDetailJudul.TabIndex = 0
        LblDetailJudul.Text = "Detail Pembayaran"
        ' 
        ' BtnLanjut
        ' 
        BtnLanjut.BackColor = Color.FromArgb(46, 139, 135)
        BtnLanjut.FlatAppearance.BorderSize = 0
        BtnLanjut.FlatStyle = FlatStyle.Flat
        BtnLanjut.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        BtnLanjut.ForeColor = Color.White
        BtnLanjut.Location = New Point(25, 520)
        BtnLanjut.Name = "BtnLanjut"
        BtnLanjut.Size = New Size(800, 45)
        BtnLanjut.TabIndex = 6
        BtnLanjut.Text = "Lanjut ke Pembayaran"
        BtnLanjut.UseVisualStyleBackColor = False
        ' 
        ' PilihKursi
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(240, 240, 240)
        ClientSize = New Size(850, 600)
        Controls.Add(BtnLanjut)
        Controls.Add(PnlDetail)
        Controls.Add(LblKursiDipilih)
        Controls.Add(PnlKursi)
        Controls.Add(PnlLegend)
        Controls.Add(PnlLayar)
        Controls.Add(LblTitle)
        Name = "PilihKursi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pilih Kursi"
        PnlLayar.ResumeLayout(False)
        PnlLayar.PerformLayout()
        PnlLegend.ResumeLayout(False)
        PnlLegend.PerformLayout()
        CType(BoxTerblokir, ComponentModel.ISupportInitialize).EndInit()
        CType(BoxDipilih, ComponentModel.ISupportInitialize).EndInit()
        CType(BoxDipesan, ComponentModel.ISupportInitialize).EndInit()
        CType(BoxTersedia, ComponentModel.ISupportInitialize).EndInit()
        PnlDetail.ResumeLayout(False)
        PnlDetail.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents PnlLayar As Panel
    Friend WithEvents LblLayar As Label
    Friend WithEvents PnlLegend As Panel
    Friend WithEvents BoxTerblokir As PictureBox
    Friend WithEvents BoxDipilih As PictureBox
    Friend WithEvents BoxDipesan As PictureBox
    Friend WithEvents BoxTersedia As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PnlKursi As Panel
    Friend WithEvents LblKursiDipilih As Label
    Friend WithEvents PnlDetail As Panel
    Friend WithEvents LblDetailInfo As Label
    Friend WithEvents LblDetailJudul As Label
    Friend WithEvents BtnLanjut As Button
End Class