Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Beranda

    ' Konfigurasi Database (Ganti nama database jika berbeda)
    Dim connectionString As String = "server=localhost;user id=root;password=;database=bioskop_db"
    Dim conn As MySqlConnection

    Private Sub Beranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default filter genre
        CmbGenre.SelectedIndex = 0
        ' Load data dari XAMPP
        MuatDaftarFilmDariDB()
    End Sub

    ''' <summary>
    ''' Mengambil data film dari tabel 'movies' (ID_Film, Judul_Film, Genre, Durasi_Menit, Poster_Path)
    ''' </summary>
    Private Sub MuatDaftarFilmDariDB(Optional kataKunci As String = "", Optional filterGenre As String = "Semua")
        FlpMovies.Controls.Clear()

        Try
            conn = New MySqlConnection(connectionString)
            conn.Open()

            ' 1. Pencarian Judul
            Dim query As String = "SELECT * FROM movies WHERE Judul_Film LIKE @cari"

            ' 2. PENTING: Gunakan LIKE untuk Genre, bukan tanda sama dengan (=)
            If filterGenre <> "Semua" Then
                query &= " AND Genre LIKE @genre"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@cari", "%" & kataKunci.Trim() & "%")

            ' 3. PENTING: Apit kata kunci genre dengan simbol % agar terbaca meskipun genrenya gabungan
            If filterGenre <> "Semua" Then
                cmd.Parameters.AddWithValue("@genre", "%" & filterGenre.Trim() & "%")
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Render setiap baris database menjadi kartu film
            For Each row As DataRow In table.Rows
                Dim poster As String = ""
                If Not IsDBNull(row("Poster_Path")) Then
                    poster = row("Poster_Path").ToString()
                End If

                BuatCardFilm(
                    row("ID_Film").ToString(),
                    row("Judul_Film").ToString(),
                    row("Genre").ToString(),
                    row("Durasi_Menit").ToString(),
                    poster
                )
            Next

            ' Notifikasi jika data tidak ada
            If table.Rows.Count = 0 Then
                Dim lblEmpty As New Label With {
                    .Text = "Film tidak ditemukan.",
                    .AutoSize = True,
                    .ForeColor = Color.Gray,
                    .Margin = New Padding(20)
                }
                FlpMovies.Controls.Add(lblEmpty)
            End If

        Catch ex As Exception
            MessageBox.Show("Koneksi XAMPP Gagal: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Membuat tampilan kartu film secara dinamis di FlowLayoutPanel
    ''' </summary>
    Private Sub BuatCardFilm(id As String, judul As String, genre As String, durasi As String, posterPath As String)
        ' <-- UBAH UKURAN: Tinggi diubah menjadi 320 agar poster muat
        Dim pnlCard As New Panel With {
            .Size = New Size(200, 320),
            .BackColor = Color.White,
            .Margin = New Padding(15)
        }

        Dim lblJudul As New Label With {
            .Text = judul,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .ForeColor = Color.FromArgb(40, 40, 40),
            .Dock = DockStyle.Top,
            .Height = 40,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Padding = New Padding(5)
        }

        Dim lblDetail As New Label With {
            .Text = genre & " • " & durasi & " Menit",
            .Font = New Font("Segoe UI", 8, FontStyle.Regular),
            .ForeColor = Color.DimGray,
            .Dock = DockStyle.Top,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Height = 30
        }

        ' <-- TAMBAHAN: Membuat elemen PictureBox untuk foto
        Dim picPoster As New PictureBox With {
            .Dock = DockStyle.Fill,
            .SizeMode = PictureBoxSizeMode.Zoom,
            .BackColor = Color.FromArgb(240, 240, 240) ' Warna abu-abu terang jika gambar gagal dimuat
        }

        ' <-- TAMBAHAN: Memuat file gambar dari folder Images
        If Not String.IsNullOrEmpty(posterPath) Then
            Dim folderImages As String = Path.Combine(Application.StartupPath, "Images")
            Dim pathLengkap As String = Path.Combine(folderImages, posterPath)

            If File.Exists(pathLengkap) Then
                picPoster.Image = Image.FromFile(pathLengkap)
            End If
        End If

        Dim btnPesan As New Button With {
            .Text = "PESAN TIKET",
            .Dock = DockStyle.Bottom,
            .Height = 40,
            .BackColor = Color.Teal,
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .Cursor = Cursors.Hand
        }
        btnPesan.FlatAppearance.BorderSize = 0
        btnPesan.Tag = id ' Menyimpan ID_Film

        ' =========================================================================
        ' PERUBAHAN DI SINI: Logika klik tombol pesan untuk berpindah ke Pilih_Studio
        ' =========================================================================
        AddHandler btnPesan.Click, Sub(sender As Object, e As EventArgs)
                                       Dim idFilm = DirectCast(sender, Button).Tag.ToString()

                                       ' 1. Simpan ID Film ke variabel global dari Module1
                                       Transisi_ID_Film = idFilm

                                       ' 2. Buka halaman Pilih Studio
                                       Dim formStudio As New Pilih_Studio()
                                       formStudio.Show()
                                       Me.Hide()
                                   End Sub

        ' <-- PENTING: Urutan penambahan ini mengatur posisinya (Docking)
        pnlCard.Controls.Add(picPoster) ' Masuk ke sisa ruang di tengah
        pnlCard.Controls.Add(lblDetail) ' Nempel di atas (di bawah judul)
        pnlCard.Controls.Add(lblJudul)  ' Nempel di atas sendiri
        pnlCard.Controls.Add(btnPesan)  ' Nempel di bawah

        FlpMovies.Controls.Add(pnlCard)
    End Sub

    ' --- EVENT HANDLERS ---

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        MuatDaftarFilmDariDB(TxtCari.Text, CmbGenre.SelectedItem.ToString())
    End Sub

    Private Sub CmbGenre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGenre.SelectedIndexChanged
        If CmbGenre.SelectedItem IsNot Nothing Then
            MuatDaftarFilmDariDB(TxtCari.Text, CmbGenre.SelectedItem.ToString())
        End If
    End Sub

    ' Logout Handler: Menutup Beranda dan membuka Login
    Private Sub MenuLogout_Click(sender As Object, e As EventArgs) Handles MenuLogout.Click
        Dim tanya = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tanya = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub MenuProfil_Click(sender As Object, e As EventArgs) Handles MenuProfil.Click
        MessageBox.Show("Halaman Profil sedang dalam pengembangan.", "Informasi")
    End Sub

End Class