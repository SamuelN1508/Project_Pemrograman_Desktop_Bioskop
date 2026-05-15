Imports MySql.Data.MySqlClient

Public Class Pilih_Studio

    Private Sub Pilih_Studio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cek apakah ada film yang dipilih dari Beranda (menggunakan variabel global Module1)
        If String.IsNullOrEmpty(Transisi_ID_Film) Then
            MessageBox.Show("Error: Tidak ada film yang dipilih!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End If

        ' 1. Muat info detail film di panel kiri
        LoadDetailFilm()

        ' 2. Muat daftar jadwal/studio di panel kanan
        LoadJadwalStudio()
    End Sub

    ' --- FUNGSI UNTUK MENGAMBIL DETAIL FILM (PANEL KIRI) ---
    Private Sub LoadDetailFilm()
        Dim query As String = "SELECT Judul_Film, Genre, Durasi_Menit, Sinopsis FROM movies WHERE ID_Film = @ID_Film"

        Try
            ' Gunakan fungsi buka koneksi dari Module1.vb
            BukaKoneksi()
            Dim cmd As New MySqlCommand(query, KoneksiDB)
            cmd.Parameters.AddWithValue("@ID_Film", Transisi_ID_Film)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Ubah teks label di panel kiri sesuai data dari database
                LblFilmInfo.Text = "Film: " & reader("Judul_Film").ToString()
                LblGenre.Text = "Genre: " & reader("Genre").ToString()
                LblDurasi.Text = "Durasi: " & reader("Durasi_Menit").ToString() & " Menit"

                ' Jika sinopsis kosong/null di database, beri teks default
                If IsDBNull(reader("Sinopsis")) OrElse String.IsNullOrWhiteSpace(reader("Sinopsis").ToString()) Then
                    LblSinopsisText.Text = "Sinopsis belum tersedia untuk film ini."
                Else
                    LblSinopsisText.Text = reader("Sinopsis").ToString()
                End If

                ' Jangan lupa ubah juga judul film di panel kanan atas
                LblFilmTitleRight.Text = "Film: " & reader("Judul_Film").ToString()

                ' Simpan Judul Film ke global untuk dicetak di E-Ticket nanti
                Transisi_Judul_Film = reader("Judul_Film").ToString()
            End If
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error memuat detail film: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' --- FUNGSI UNTUK MENGAMBIL JADWAL & STUDIO (PANEL KANAN) ---
    ' --- FUNGSI UNTUK MENGAMBIL JADWAL & STUDIO (PANEL KANAN) ---
    Private Sub LoadJadwalStudio()
        FlowLayoutStudios.Controls.Clear()

        ' PENTING: Menggunakan tabel schedules dan studios milikmu yang sudah berelasi
        Dim query As String = "SELECT j.ID_Jadwal, s.Nama_Studio, j.Waktu_Mulai, j.Harga_Tiket " &
                              "FROM schedules j " &
                              "JOIN studios s ON j.ID_Studio = s.ID_Studio " &
                              "WHERE j.ID_Film = @ID_Film"

        Try
            BukaKoneksi()
            Dim cmd As New MySqlCommand(query, KoneksiDB)
            cmd.Parameters.AddWithValue("@ID_Film", Transisi_ID_Film)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim dt As New DataTable()
            dt.Load(reader)

            Dim adaJadwal As Boolean = False
            For Each row As DataRow In dt.Rows
                adaJadwal = True
                Dim idJadwal As String = row("ID_Jadwal").ToString()
                Dim namaStudio As String = row("Nama_Studio").ToString()
                Dim waktu As String = row("Waktu_Mulai").ToString()
                Dim harga As Decimal = Convert.ToDecimal(row("Harga_Tiket"))

                BuatKartuStudio(idJadwal, namaStudio, waktu, harga)
            Next

            If Not adaJadwal Then
                Dim lblKosong As New Label With {
                    .Text = "Maaf, belum ada jadwal tayang untuk film ini.",
                    .AutoSize = True,
                    .Font = New Font("Segoe UI", 10, FontStyle.Italic),
                    .ForeColor = Color.Gray,
                    .Margin = New Padding(10)
                }
                FlowLayoutStudios.Controls.Add(lblKosong)
            End If

        Catch ex As Exception
            MessageBox.Show("Error memuat jadwal studio: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    ' --- FUNGSI MEMBUAT KARTU STUDIO SECARA OTOMATIS ---
    Private Sub BuatKartuStudio(idJadwal As String, namaStudio As String, waktu As String, harga As Decimal)
        Dim pnl As New Panel With {
            .Size = New Size(170, 160),
            .BackColor = Color.White,
            .BorderStyle = BorderStyle.FixedSingle,
            .Margin = New Padding(10)
        }

        Dim lblTitle As New Label With {
            .Text = namaStudio,
            .Font = New Font("Segoe UI", 9.75F, FontStyle.Bold),
            .Location = New Point(10, 15),
            .AutoSize = True
        }

        ' Gunakan FormatRupiah dari Module1.vb
        Dim lblDesc As New Label With {
            .Text = "Jam: " & waktu & vbCrLf & "Harga: " & FormatRupiah(harga),
            .Font = New Font("Segoe UI", 8.25F, FontStyle.Regular),
            .Location = New Point(10, 45),
            .Size = New Size(145, 60)
        }

        ' Simpan ID Jadwal dan Harga sekaligus dipisahkan garis vertikal
        Dim btn As New Button With {
            .Text = "Pilih Jadwal",
            .BackColor = Color.CadetBlue,
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
            .Size = New Size(110, 30),
            .Location = New Point(30, 115),
            .Tag = idJadwal & "|" & harga.ToString()
        }
        btn.FlatAppearance.BorderSize = 0

        AddHandler btn.Click, AddressOf TombolPilih_Click

        pnl.Controls.Add(lblTitle)
        pnl.Controls.Add(lblDesc)
        pnl.Controls.Add(btn)

        FlowLayoutStudios.Controls.Add(pnl)
    End Sub

    ' --- EVENT SAAT TOMBOL PILIH JADWAL DIKLIK ---
    Private Sub TombolPilih_Click(sender As Object, e As EventArgs)
        Dim btnTerpilih As Button = CType(sender, Button)

        ' Pecah data yang disimpan di Tag (Index 0 = ID_Jadwal, Index 1 = Harga)
        Dim dataTag() As String = btnTerpilih.Tag.ToString().Split("|")

        ' 1. Simpan Data ke Global Module1 agar bisa diakses saat bayar
        Transisi_ID_Jadwal = dataTag(0)
        Transisi_Harga_Tiket = Convert.ToDecimal(dataTag(1))

        ' 2. Buka halaman Pilih_Kursi (Pastikan namamu Pilih_Kursi)
        Dim formKursi As New PilihKursi()
        formKursi.Show()

        ' 3. Tutup halaman Pilih Studio saat ini agar tidak menumpuk
        Me.Close()
    End Sub

End Class