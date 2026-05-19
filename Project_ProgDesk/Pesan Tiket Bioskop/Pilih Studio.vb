Public Class Pilih_Studio

    ' [TAMBAHAN] Variabel untuk menyimpan tanggal yang sedang dipilih
    Dim tanggalTerpilih As String = ""

    Private Sub Pilih_Studio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Transisi_Judul_Film <> "" Then
            LblFilmInfo.Text = "Film: " & Transisi_Judul_Film
            LblFilmTitleRight.Text = "Film: " & Transisi_Judul_Film
        End If

        ' [TAMBAHAN] Panggil fungsi pembuat tombol tanggal
        BuatPilihanTanggal()
        MuatSemuaStudio()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim formAwal As New Beranda()
        formAwal.Show()
        Me.Close()
    End Sub

    Private Sub MuatSemuaStudio()
        FlowLayoutStudios.Controls.Clear()
        FlowLayoutStudios.FlowDirection = FlowDirection.TopDown
        FlowLayoutStudios.WrapContents = False

        ' Data statis / manual
        Dim namaStudio() As String = {"Studio 1 (Normal)", "Studio 2 (Luxe)", "Studio Max (IMAX)"}
        Dim hargaStudio() As Decimal = {45000, 60000, 85000}
        Dim kapasitas() As String = {"150 Kursi", "80 Kursi", "250 Kursi"}
        Dim fasilitas() As String = {
            "Layar standar dengan kualitas Dolby Audio.",
            "Kursi reclining seat dan layanan premium.",
            "Layar raksasa IMAX dengan sound system luar biasa."
        }
        Dim jamTayang() As String = {"12:35", "14:40", "18:50", "20:55"}
        Dim statusJam() As Boolean = {False, False, True, True}

        For i As Integer = 0 To 2
            Dim card As New Panel()
            card.Size = New Size(530, 180)
            card.BackColor = Color.White
            card.BorderStyle = BorderStyle.FixedSingle
            card.Margin = New Padding(0, 0, 0, 15)

            Dim lblJudul As New Label()
            lblJudul.Text = namaStudio(i)
            lblJudul.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            lblJudul.Location = New Point(20, 15)
            lblJudul.AutoSize = True
            card.Controls.Add(lblJudul)

            Dim lblHarga As New Label()
            lblHarga.Text = "Rp " & hargaStudio(i).ToString("N0", New Globalization.CultureInfo("id-ID"))
            lblHarga.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            lblHarga.ForeColor = Color.DimGray
            lblHarga.Location = New Point(380, 15)
            lblHarga.Size = New Size(130, 25)
            lblHarga.TextAlign = ContentAlignment.TopRight
            card.Controls.Add(lblHarga)

            Dim lblInfo As New Label()
            lblInfo.Text = "Kapasitas: " & kapasitas(i) & vbCrLf & fasilitas(i)
            lblInfo.Font = New Font("Segoe UI", 9)
            lblInfo.ForeColor = Color.Gray
            lblInfo.Location = New Point(20, 45)
            lblInfo.Size = New Size(400, 40)
            card.Controls.Add(lblInfo)

            Dim flpWaktu As New FlowLayoutPanel()
            flpWaktu.Location = New Point(20, 100)
            flpWaktu.Size = New Size(480, 60)
            flpWaktu.BackColor = Color.Transparent

            For j As Integer = 0 To jamTayang.Length - 1
                Dim btnJam As New Button()
                btnJam.Text = jamTayang(j)
                btnJam.Size = New Size(80, 40)
                btnJam.FlatStyle = FlatStyle.Flat
                btnJam.FlatAppearance.BorderSize = 0
                btnJam.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                btnJam.Margin = New Padding(0, 0, 10, 0)

                If statusJam(j) = True Then
                    btnJam.BackColor = Color.Teal
                    btnJam.ForeColor = Color.White
                    btnJam.Cursor = Cursors.Hand

                    ' Menyimpan Nama Studio, Harga, dan Jam ke dalam tombol
                    btnJam.Tag = namaStudio(i) & "|" & hargaStudio(i).ToString() & "|" & jamTayang(j)
                    AddHandler btnJam.Click, AddressOf TombolJam_Click
                Else
                    btnJam.BackColor = Color.FromArgb(230, 230, 230)
                    btnJam.ForeColor = Color.DarkGray
                    btnJam.Enabled = False
                End If
                flpWaktu.Controls.Add(btnJam)
            Next
            card.Controls.Add(flpWaktu)
            FlowLayoutStudios.Controls.Add(card)
        Next
    End Sub

    Private Sub TombolJam_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim dataData() As String = btn.Tag.ToString().Split("|"c)

        ' 1. Ambil data dari tombol yang diklik
        Transisi_Nama_Studio = dataData(0)
        Transisi_Harga_Tiket = Convert.ToDecimal(dataData(1))

        ' [PERUBAHAN KECIL]: Memakai variabel tanggalTerpilih + Jam yang diklik
        Transisi_Waktu_Tayang = tanggalTerpilih & " | " & dataData(2)

        Transisi_Daftar_Kursi = ""

        ' 2. TAMBAHAN WAJIB: Kirim ID Jadwal supaya Form Kursi bisa cek database
        ' Pastikan angka "1" ini benar-benar ada di kolom ID_Jadwal di database kamu.
        ' Jika nanti halaman Pilih Studio ini sudah pakai database, angka 1 ini harus 
        ' diganti dengan ID asli dari tabel jadwal.
        Transisi_ID_Jadwal = "1"

        ' 3. Buka form kursi
        Dim formKursi As New Pilih_Kursi()
        formKursi.Show()
        Me.Close()
    End Sub

    ' ========================================================
    ' [TAMBAHAN] FUNGSI BARU: MEMBUAT TOMBOL TANGGAL OTOMATIS
    ' ========================================================
    Private Sub BuatPilihanTanggal()
        ' Pastikan FlpTanggal sudah ada di Form (Design)
        If FlpTanggal IsNot Nothing Then
            FlpTanggal.Controls.Clear()
            FlpTanggal.WrapContents = False ' Agar tombol berjejer menyamping

            ' Mengambil tanggal hari ini dari komputer
            Dim tanggalSekarang As DateTime = DateTime.Now

            ' ========================================================
            ' PERUBAHAN DI SINI: Diubah ke 29 agar melakukan loop sebanyak 30 hari (sebulan)
            ' ========================================================
            For i As Integer = 0 To 29
                Dim tgl As DateTime = tanggalSekarang.AddDays(i)

                Dim btnTgl As New Button With {
                    .Size = New Size(70, 70),
                    .FlatStyle = FlatStyle.Flat,
                    .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                    .Text = tgl.ToString("ddd") & vbCrLf & tgl.ToString("dd"), ' Contoh: Kam (enter) 28
                    .Tag = tgl.ToString("dd MMM yyyy"), ' Format utuh: 28 Mei 2026
                    .Cursor = Cursors.Hand,
                    .Margin = New Padding(5)
                }
                btnTgl.FlatAppearance.BorderSize = 0

                ' Pewarnaan: Hari pertama (hari ini) otomatis terpilih (Teal)
                If i = 0 Then
                    btnTgl.BackColor = Color.Teal
                    btnTgl.ForeColor = Color.White
                    tanggalTerpilih = btnTgl.Tag.ToString()
                Else
                    ' Hari lainnya berwarna abu-abu
                    btnTgl.BackColor = Color.WhiteSmoke
                    btnTgl.ForeColor = Color.DimGray
                End If

                AddHandler btnTgl.Click, AddressOf TombolTanggal_Click
                FlpTanggal.Controls.Add(btnTgl)
            Next
        End If
    End Sub

    ' ========================================================
    ' [TAMBAHAN] EVENT KLIK UNTUK TANGGAL
    ' ========================================================
    Private Sub TombolTanggal_Click(sender As Object, e As EventArgs)
        ' 1. Reset warna semua tombol tanggal ke abu-abu
        For Each ctrl As Control In FlpTanggal.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                btn.BackColor = Color.WhiteSmoke
                btn.ForeColor = Color.DimGray
            End If
        Next

        ' 2. Beri warna Teal pada tombol yang baru saja diklik
        Dim btnClicked As Button = DirectCast(sender, Button)
        btnClicked.BackColor = Color.Teal
        btnClicked.ForeColor = Color.White

        ' 3. Simpan data tanggal ke variabel
        tanggalTerpilih = btnClicked.Tag.ToString()
    End Sub

End Class