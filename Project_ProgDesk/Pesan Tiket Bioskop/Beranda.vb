Imports MySql.Data.MySqlClient

Public Class Beranda

    ' Sesuaikan database_name dengan nama database kamu di XAMPP
    Dim connectionString As String = "server=localhost;user id=root;password=;database=bioskop_db"
    Dim conn As MySqlConnection

    Private Sub Beranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi ComboBox
        CmbGenre.SelectedIndex = 0
        ' Load data pertama kali
        MuatDaftarFilmDariDB()
    End Sub

    ''' <summary>
    ''' Mengambil data film dari tabel sesuai screenshot (ID_Film, Judul_Film, Genre, Durasi_Menit)
    ''' </summary>
    Private Sub MuatDaftarFilmDariDB(Optional kataKunci As String = "", Optional filterGenre As String = "Semua")
        FlpMovies.Controls.Clear()

        Try
            conn = New MySqlConnection(connectionString)
            conn.Open()

            ' Query SQL menyesuaikan nama kolom di gambar
            Dim query As String = "SELECT * FROM movies WHERE Judul_Film LIKE @cari"

            ' Logika filter genre
            If filterGenre <> "Semua" Then
                query &= " AND Genre = @genre"
            End If

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@cari", "%" & kataKunci & "%")

            If filterGenre <> "Semua" Then
                cmd.Parameters.AddWithValue("@genre", filterGenre)
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Render setiap baris database menjadi kartu film
            For Each row As DataRow In table.Rows
                BuatCardFilm(
                    row("ID_Film").ToString(),
                    row("Judul_Film").ToString(),
                    row("Genre").ToString(),
                    row("Durasi_Menit").ToString()
                )
            Next

            ' Jika data kosong
            If table.Rows.Count = 0 Then
                Dim lblEmpty As New Label With {.Text = "Film tidak ditemukan.", .AutoSize = True, .ForeColor = Color.Gray}
                FlpMovies.Controls.Add(lblEmpty)
            End If

        Catch ex As Exception
            MessageBox.Show("Koneksi XAMPP Gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Membuat kartu film secara dinamis
    ''' </summary>
    Private Sub BuatCardFilm(id As String, judul As String, genre As String, durasi As String)
        ' Container utama kartu
        Dim pnlCard As New Panel With {
            .Size = New Size(200, 250),
            .BackColor = Color.White,
            .Margin = New Padding(15),
            .Cursor = Cursors.Default
        }

        ' Judul Film
        Dim lblJudul As New Label With {
            .Text = judul,
            .Font = New Font("Segoe UI", 11, FontStyle.Bold),
            .ForeColor = Color.FromArgb(40, 40, 40),
            .Dock = DockStyle.Top,
            .Height = 60,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Padding = New Padding(5)
        }

        ' Info Genre & Durasi
        Dim lblDetail As New Label With {
            .Text = genre & " • " & durasi & " Menit",
            .Font = New Font("Segoe UI", 8, FontStyle.Regular),
            .ForeColor = Color.DimGray,
            .Dock = DockStyle.Top,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Height = 30
        }

        ' Tombol Pesan
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

        ' Simpan ID Film di tag tombol agar bisa digunakan saat pindah form
        btnPesan.Tag = id

        ' Event klik tombol pesan
        AddHandler btnPesan.Click, Sub(sender As Object, e As EventArgs)
                                       Dim idFilm = DirectCast(sender, Button).Tag
                                       MessageBox.Show("Membuka jadwal untuk film ID: " & idFilm.ToString(), "Info")
                                       ' Contoh: FormPesan.ShowID(idFilm)
                                   End Sub

        ' Tambahkan ke panel kartu
        pnlCard.Controls.Add(lblDetail)
        pnlCard.Controls.Add(lblJudul)
        pnlCard.Controls.Add(btnPesan)

        ' Tambahkan ke FlowLayoutPanel
        FlpMovies.Controls.Add(pnlCard)
    End Sub

    ' --- EVENT HANDLERS UI ---

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        MuatDaftarFilmDariDB(TxtCari.Text, CmbGenre.SelectedItem.ToString())
    End Sub

    Private Sub CmbGenre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGenre.SelectedIndexChanged
        If CmbGenre.SelectedItem IsNot Nothing Then
            MuatDaftarFilmDariDB(TxtCari.Text, CmbGenre.SelectedItem.ToString())
        End If
    End Sub

    ' Logout & Menu Handlers
    Private Sub MenuLogout_Click(sender As Object, e As EventArgs) Handles MenuLogout.Click
        Me.Hide()
        ' FormLogin.Show()
    End Sub

    Private Sub MenuProfil_Click(sender As Object, e As EventArgs) Handles MenuProfil.Click
        MessageBox.Show("Halaman Profil Belum Tersedia", "Info")
    End Sub

End Class