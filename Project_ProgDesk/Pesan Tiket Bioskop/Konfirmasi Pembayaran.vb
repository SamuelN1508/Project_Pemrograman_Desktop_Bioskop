Public Class FormPembayaran
    Dim waktuTersisa As Integer = 600

    Private Sub FormPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Tampilkan Judul dan Info Studio (Menggunakan nama Label dari Designer)
        LblJudul.Text = Transisi_Judul_Film
        LblStudio.Text = "CinemaHub, " & Transisi_Nama_Studio
        LblWaktu.Text = Transisi_Waktu_Tayang

        ' 2. Tampilkan Poster (Menggunakan nama PictureBox dari Designer)
        If Transisi_Poster_Film IsNot Nothing Then
            PicPoster.Image = Transisi_Poster_Film
            PicPoster.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        ' ========================================================
        ' [PERBAIKAN] 3. Tampilkan Detail Harga & Kursi
        ' ========================================================
        ' Memecah daftar kursi berdasarkan koma untuk mendapatkan jumlah tiket yang dibeli
        Dim daftarKursi() As String = Transisi_Daftar_Kursi.Split(","c)
        Dim jumlahKursi As Integer = daftarKursi.Length

        LblInfoTiket.Text = "Tiket" & vbCrLf & "Kursi: " & Transisi_Daftar_Kursi

        ' Mengubah rincian harga tiket secara dinamis (Contoh hasil: "3 x Rp 45.000" di baris pertama, dan totalnya di baris kedua)
        LblNilaiHargaTiket.Text = jumlahKursi.ToString() & " x " & FormatRupiah(Transisi_Harga_Tiket) & vbCrLf & FormatRupiah(Transisi_Total_Bayar)

        LblNilaiSubtotal.Text = FormatRupiah(Transisi_Total_Bayar)
        LblNilaiTotal.Text = FormatRupiah(Transisi_Total_Bayar)

        ' Tombol Bayar
        BtnLanjutBayar.Text = "Bayar " & FormatRupiah(Transisi_Total_Bayar)

        ' Jalankan Timer
        TimerPembayaran.Start()
    End Sub

    ' ========================================================
    ' KODE TIMER MUNDUR 10 MENIT
    ' ========================================================
    Private Sub TimerPembayaran_Tick(sender As Object, e As EventArgs) Handles TimerPembayaran.Tick
        waktuTersisa -= 1

        Dim menit As Integer = waktuTersisa \ 60
        Dim detik As Integer = waktuTersisa Mod 60

        LblWaktuTimer.Text = menit.ToString("00") & ":" & detik.ToString("00")

        If waktuTersisa <= 0 Then
            TimerPembayaran.Stop()
            MessageBox.Show("Waktu pembayaran habis!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Kembali ke halaman sebelumnya
            Dim formAwal As New Beranda()
            formAwal.Show()
            Me.Close()
        End If
    End Sub

    ' ========================================================
    ' TOMBOL BAYAR -> PINDAH KE E-TIKET
    ' ========================================================
    Private Sub BtnLanjutBayar_Click(sender As Object, e As EventArgs) Handles BtnLanjutBayar.Click
        TimerPembayaran.Stop()
        MessageBox.Show("Pembayaran Berhasil! Mengalihkan ke E-Tiket...", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim formTiket As New E_Ticket___Kode_QR()
        formTiket.Show()
        Me.Close()
    End Sub

    ' ========================================================
    ' TOMBOL KEMBALI
    ' ========================================================
    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        TimerPembayaran.Stop()
        Dim formKursi As New Pilih_Kursi()
        formKursi.Show()
        Me.Close()
    End Sub
End Class