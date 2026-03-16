Imports MySql.Data.MySqlClient

Public Class Pilih_Studio
    ' Variabel untuk menerima ID Film dari Beranda
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedFilmID As String

    ' Sesuaikan connection string dengan yang ada di Beranda
    Dim connectionString As String = "server=localhost;user id=root;password=;database=bioskop_db"

    Private Sub Pilih_Studio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Muat info detail film di panel kiri
        LoadDetailFilm()

        ' 2. Muat daftar jadwal/studio di panel kanan
        LoadJadwalStudio()
    End Sub

    ' --- FUNGSI UNTUK MENGAMBIL DETAIL FILM (PANEL KIRI) ---
    Private Sub LoadDetailFilm()
        Dim query As String = "SELECT Judul_Film, Genre, Durasi_Menit, Sinopsis FROM movies WHERE ID_Film = @ID_Film"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID_Film", SelectedFilmID)

                Try
                    conn.Open()
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
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error memuat detail film: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' --- FUNGSI UNTUK MENGAMBIL JADWAL & STUDIO (PANEL KANAN) ---
    Private Sub LoadJadwalStudio()
        FlowLayoutStudios.Controls.Clear()

        Dim query As String = "SELECT j.ID_Jadwal, s.Nama_Studio, j.Waktu_Mulai, j.Harga_Tiket " &
                              "FROM Schedules j " &
                              "JOIN Studios s ON j.ID_Studio = s.ID_Studio " &
                              "WHERE j.ID_Film = @ID_Film"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID_Film", SelectedFilmID)

                Try
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim idJadwal As String = reader("ID_Jadwal").ToString()
                        Dim namaStudio As String = reader("Nama_Studio").ToString()
                        Dim waktu As String = reader("Waktu_Mulai").ToString()
                        Dim harga As Decimal = Convert.ToDecimal(reader("Harga_Tiket"))

                        BuatKartuStudio(idJadwal, namaStudio, waktu, harga)
                    End While

                    ' Jika tidak ada jadwal
                    If FlowLayoutStudios.Controls.Count = 0 Then
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
                End Try
            End Using
        End Using
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

        Dim lblDesc As New Label With {
            .Text = "Jam: " & waktu & vbCrLf & "Harga: Rp " & harga.ToString("N0"),
            .Font = New Font("Segoe UI", 8.25F, FontStyle.Regular),
            .Location = New Point(10, 45),
            .Size = New Size(145, 60)
        }

        Dim btn As New Button With {
            .Text = "Pilih Jadwal",
            .BackColor = Color.CadetBlue,
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
            .Size = New Size(110, 30),
            .Location = New Point(30, 115),
            .Tag = idJadwal ' Simpan ID Jadwal di tombol
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
        Dim idJadwalTerpilih As String = btnTerpilih.Tag.ToString()

        ' 1. Buat instance dari form Pilih_Kursi
        Dim formKursi As New PilihKursi()

        ' 2. Kirimkan ID Jadwal ke form Pilih_Kursi
        formKursi.SelectedJadwalID = idJadwalTerpilih

        ' 3. Tampilkan form Pilih_Kursi
        formKursi.Show()

        ' 4. Tutup halaman Pilih Studio saat ini agar tidak menumpuk
        Me.Close()
    End Sub

End Class