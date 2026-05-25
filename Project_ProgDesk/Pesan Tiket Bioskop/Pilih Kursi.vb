Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Pilih_Kursi
    ' Variabel untuk menyimpan kursi yang dipilih
    Dim listKursiTerpilih As New List(Of String)
    Dim hargaPerTiket As Decimal = 0

    Private Sub Pilih_Kursi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cek apakah harga tiket terbawa
        If Val(Transisi_Harga_Tiket) = 0 Then
            MessageBox.Show("Harga tiket belum terbawa dari form sebelumnya!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        hargaPerTiket = Transisi_Harga_Tiket

        MuatDetailPesanan()
        BuatDenahKursi()
    End Sub

    ' --- FUNGSI 1: MENGISI PANEL KANAN (LANGSUNG DARI VARIABEL) ---
    Private Sub MuatDetailPesanan()
        ' Menampilkan Teks
        LblJudulDetail.Text = Transisi_Judul_Film ' Ganti LblJudulDetail sesuai nama Label-mu
        LblStudioDetail.Text = "CinemaHub, " & Transisi_Nama_Studio
        LblWaktuDetail.Text = Transisi_Waktu_Tayang

        ' Menampilkan Poster
        If Transisi_Poster_Film IsNot Nothing Then
            PicPosterDetail.Image = Transisi_Poster_Film ' Ganti PicPosterDetail sesuai nama PictureBox-mu
            PicPosterDetail.SizeMode = PictureBoxSizeMode.StretchImage ' Agar pas di kotak
        End If
    End Sub

    ' --- FUNGSI 2: MEMBUAT KOTAK-KOTAK KURSI SECARA OTOMATIS ---
    Private Sub BuatDenahKursi()
        FlpKursi.Controls.Clear()

        ' 1. Siapkan List untuk menampung kursi yang sudah dipesan dari database
        Dim kursiSudahTerisi As New List(Of String)()

        ' Query untuk mencari kursi yang sudah di-booking pada Jadwal ini
        ' dan status pembayarannya tidak 'Dibatalkan'
        Dim query As String = "SELECT s.Kode_Kursi FROM booking_details bd " &
                              "JOIN bookings b ON bd.ID_Booking = b.ID_Booking " &
                              "JOIN seats s ON bd.ID_Kursi = s.ID_Kursi " &
                              "WHERE b.ID_Jadwal = @ID_Jadwal AND b.Status != 'Dibatalkan'"
        Try
            BukaKoneksi()
            Dim cmd As New MySqlCommand(query, KoneksiDB)
            ' Pastikan variabel Transisi_ID_Jadwal sudah dikirim dari form Pilih_Studio
            cmd.Parameters.AddWithValue("@ID_Jadwal", Transisi_ID_Jadwal)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Masukkan setiap Kode_Kursi yang ditemukan ke dalam list
            While reader.Read()
                kursiSudahTerisi.Add(reader("Kode_Kursi").ToString())
            End While
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error memuat status kursi: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try

        ' 2. Bikin kotak-kotak kursinya di layar
        Dim baris As String() = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"}
        Dim jumlahKolom As Integer = 10

        For Each b In baris
            For i As Integer = 1 To jumlahKolom
                Dim nomorKursi As String = b & i.ToString()

                Dim btnKursi As New Button With {
                    .Text = nomorKursi,
                    .Size = New Size(45, 45),
                    .FlatStyle = FlatStyle.Flat,
                    .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
                    .Margin = New Padding(5),
                    .Cursor = Cursors.Hand
                }
                btnKursi.FlatAppearance.BorderColor = Color.LightGray

                ' 3. Cek apakah nomor kursi ini ada di dalam List kursiSudahTerisi
                If kursiSudahTerisi.Contains(nomorKursi) Then
                    ' Tampilan jika kursi SUDAH DIAMBIL
                    btnKursi.BackColor = Color.Silver
                    btnKursi.ForeColor = Color.White
                    btnKursi.Enabled = False ' Dimatikan agar tidak bisa diklik
                    btnKursi.Tag = "Terjual"
                Else
                    ' Tampilan jika kursi TERSEDIA
                    btnKursi.BackColor = Color.WhiteSmoke
                    btnKursi.ForeColor = Color.DimGray
                    btnKursi.Tag = "Tersedia"
                End If

                ' Memberi jarak di tengah untuk lorong (setelah kolom ke-5)
                If i = 5 Then
                    btnKursi.Margin = New Padding(5, 5, 40, 5)
                End If

                AddHandler btnKursi.Click, AddressOf TombolKursi_Click
                FlpKursi.Controls.Add(btnKursi)
            Next
        Next
    End Sub

    ' --- FUNGSI 3: LOGIKA KLIK KURSI ---
    Private Sub TombolKursi_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim nomor As String = btn.Text

        If btn.Tag.ToString() = "Tersedia" Then
            ' Tandai Terpilih (Hijau/Teal)
            btn.BackColor = Color.Teal
            btn.ForeColor = Color.White
            btn.Tag = "Terpilih"
            listKursiTerpilih.Add(nomor)
        ElseIf btn.Tag.ToString() = "Terpilih" Then
            ' Batalkan pilihan (Kembali ke Abu-abu)
            btn.BackColor = Color.WhiteSmoke
            btn.ForeColor = Color.DimGray
            btn.Tag = "Tersedia"
            listKursiTerpilih.Remove(nomor)
        End If

        UpdateTotalHarga()
    End Sub

    ' --- FUNGSI 4: MENGHITUNG TOTAL & UPDATE PANEL KANAN ---
    Private Sub UpdateTotalHarga()
        If listKursiTerpilih.Count = 0 Then
            LblKursiTerpilih.Text = "-"
            LblTotalHarga.Text = "Rp0"
        Else
            LblKursiTerpilih.Text = String.Join(", ", listKursiTerpilih)
            Dim total As Decimal = listKursiTerpilih.Count * hargaPerTiket
            ' Pastikan kamu punya Function FormatRupiah di Module1
            LblTotalHarga.Text = FormatRupiah(total)
        End If
    End Sub

    'TOMBOL KEMBALI DI ATAS TOMBOL LANJUT BAYAR'
    ' =====================================================================
    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        ' Kembali ke halaman Pilih Studio (sesuaikan dengan nama form sebelumnya jika berbeda)
        Dim formStudio As New Pilih_Studio()
        formStudio.Show()
        Me.Close()
    End Sub

    ' --- FUNGSI 5: TOMBOL LANJUT BAYAR ---
    Private Sub BtnLanjutBayar_Click(sender As Object, e As EventArgs) Handles BtnLanjutBayar.Click
        If listKursiTerpilih.Count = 0 Then
            MessageBox.Show("Silakan pilih minimal 1 kursi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 1. Simpan data kursi dan total harga ke variabel global (Module1)
        Transisi_Daftar_Kursi = String.Join(", ", listKursiTerpilih)
        Transisi_Total_Bayar = listKursiTerpilih.Count * hargaPerTiket

        ' 2. Pindah ke form pembayaran
        ' (Ganti "FormPembayaran" dengan nama form pembayaran aslimu yang sebenarnya)
        Dim formBayar As New FormPembayaran()
        formBayar.Show()
        Me.Close() ' Tutup form kursi ini
    End Sub
End Class