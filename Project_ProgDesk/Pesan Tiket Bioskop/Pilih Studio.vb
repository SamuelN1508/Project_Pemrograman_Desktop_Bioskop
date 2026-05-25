Imports MySql.Data.MySqlClient

Public Class Pilih_Studio

    Dim tanggalTerpilihUI As String = ""
    Dim tanggalTerpilihDB As String = ""

    Private Sub Pilih_Studio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Transisi_Judul_Film <> "" Then
            LblFilmInfo.Text = "Film: " & Transisi_Judul_Film
            LblFilmTitleRight.Text = "Film: " & Transisi_Judul_Film
        End If

        BuatPilihanTanggal()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim formAwal As New Beranda()
        formAwal.Show()
        Me.Close()
    End Sub

    ' ====================================================================
    ' MEMUAT JADWAL SESUAI KOLOM: ID_Studio, Tanggal_Tayang, Waktu_Mulai, Harga_Tiket
    ' ====================================================================
    Private Sub MuatJadwalDariDB(tanggalPencarian As String)
        FlowLayoutStudios.Controls.Clear()
        FlowLayoutStudios.FlowDirection = FlowDirection.TopDown
        FlowLayoutStudios.WrapContents = False

        If Val(Transisi_ID_Film) = 0 Then
            MessageBox.Show("ID Film belum dipilih dari Beranda!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            BukaKoneksi()

            ' FIX: Query menggunakan Tanggal_Tayang, ID_Studio, Waktu_Mulai, Harga_Tiket
            Dim query As String = "SELECT ID_Jadwal, ID_Studio, Waktu_Mulai, Harga_Tiket FROM schedules WHERE ID_Film = @idFilm AND Tanggal_Tayang = @tgl ORDER BY ID_Studio ASC, Waktu_Mulai ASC"
            Dim cmd As New MySqlCommand(query, KoneksiDB)

            cmd.Parameters.AddWithValue("@idFilm", Transisi_ID_Film)
            cmd.Parameters.AddWithValue("@tgl", tanggalPencarian)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If Not reader.HasRows Then
                Dim lblKosong As New Label With {
                    .Text = "Tidak ada jadwal tayang untuk tanggal ini.",
                    .Font = New Font("Segoe UI", 11, FontStyle.Italic),
                    .ForeColor = Color.Gray,
                    .AutoSize = True,
                    .Margin = New Padding(20)
                }
                FlowLayoutStudios.Controls.Add(lblKosong)
                reader.Close()
                Exit Sub
            End If

            Dim currentStudioID As String = ""
            Dim currentFlpWaktu As FlowLayoutPanel = Nothing

            While reader.Read()
                Dim idJadwal As String = reader("ID_Jadwal").ToString()
                Dim idStudio As String = reader("ID_Studio").ToString() ' Membaca ID Studio (1, 2, 3)
                Dim namaStudio As String = "Studio " & idStudio     ' Otomatis diubah jadi teks "Studio 1", dst.

                Dim waktuJadwal As TimeSpan = CType(reader("Waktu_Mulai"), TimeSpan)
                Dim stringWaktu As String = waktuJadwal.ToString("hh\:mm")
                Dim hargaTiket As Decimal = Convert.ToDecimal(reader("Harga_Tiket"))

                ' LOGIKA GROUPING: Membuat kartu baru jika ID Studio berubah
                If idStudio <> currentStudioID Then
                    currentStudioID = idStudio

                    Dim card As New Panel With {
                        .Size = New Size(530, 180),
                        .BackColor = Color.White,
                        .BorderStyle = BorderStyle.FixedSingle,
                        .Margin = New Padding(0, 0, 0, 15)
                    }

                    Dim lblJudul As New Label With {
                        .Text = namaStudio, ' Menampilkan teks "Studio 1 / 2 / 3"
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                        .Location = New Point(20, 15),
                        .AutoSize = True
                    }
                    card.Controls.Add(lblJudul)

                    Dim lblInfo As New Label With {
                        .Text = "Fasilitas: Layar Digital Standar & Dolby Audio System." & vbCrLf & "Kapasitas: Berdasarkan kursi tersedia.",
                        .Font = New Font("Segoe UI", 9),
                        .ForeColor = Color.Gray,
                        .Location = New Point(20, 45),
                        .Size = New Size(400, 40)
                    }
                    card.Controls.Add(lblInfo)

                    Dim lblHarga As New Label With {
                        .Text = "Rp " & hargaTiket.ToString("N0", New Globalization.CultureInfo("id-ID")),
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                        .ForeColor = Color.DimGray,
                        .Location = New Point(380, 15),
                        .Size = New Size(130, 25),
                        .TextAlign = ContentAlignment.TopRight
                    }
                    card.Controls.Add(lblHarga)

                    currentFlpWaktu = New FlowLayoutPanel With {
                        .Location = New Point(20, 100),
                        .Size = New Size(480, 60),
                        .BackColor = Color.Transparent
                    }
                    card.Controls.Add(currentFlpWaktu)

                    FlowLayoutStudios.Controls.Add(card)
                End If

                ' Membuat tombol Jam digital
                Dim btnJam As New Button With {
                    .Text = stringWaktu,
                    .Size = New Size(80, 40),
                    .FlatStyle = FlatStyle.Flat,
                    .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                    .Margin = New Padding(0, 0, 10, 0),
                    .BackColor = Color.Teal,
                    .ForeColor = Color.White,
                    .Cursor = Cursors.Hand
                }
                btnJam.FlatAppearance.BorderSize = 0

                ' Data dititipkan di properti Tag tombol (Nama Studio teks dikirim ke Form Kursi)
                btnJam.Tag = namaStudio & "|" & hargaTiket.ToString() & "|" & stringWaktu & "|" & idJadwal
                AddHandler btnJam.Click, AddressOf TombolJam_Click

                currentFlpWaktu.Controls.Add(btnJam)
            End While
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Gagal terhubung ke database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub TombolJam_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim dataData() As String = btn.Tag.ToString().Split("|"c)

        Transisi_Nama_Studio = dataData(0) ' Isinya "Studio 1", "Studio 2", dll
        Transisi_Harga_Tiket = Convert.ToDecimal(dataData(1))
        Transisi_Waktu_Tayang = tanggalTerpilihUI & " | " & dataData(2)
        Transisi_ID_Jadwal = dataData(3)
        Transisi_Daftar_Kursi = ""

        Dim formKursi As New Pilih_Kursi()
        formKursi.Show()
        Me.Close()
    End Sub

    ' ========================================================
    ' FUNGSI GENERATE TOMBOL TANGGAL 
    ' ========================================================
    Private Sub BuatPilihanTanggal()
        If FlpTanggal IsNot Nothing Then
            FlpTanggal.Controls.Clear()
            FlpTanggal.WrapContents = False

            Dim tanggalSekarang As DateTime = DateTime.Now

            For i As Integer = 0 To 29
                Dim tgl As DateTime = tanggalSekarang.AddDays(i)
                Dim formatDB As String = tgl.ToString("yyyy-MM-dd")
                Dim formatUI As String = tgl.ToString("dd MMM yyyy")

                Dim btnTgl As New Button With {
                    .Size = New Size(70, 70),
                    .FlatStyle = FlatStyle.Flat,
                    .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                    .Text = tgl.ToString("ddd") & vbCrLf & tgl.ToString("dd"),
                    .Tag = formatUI & "|" & formatDB,
                    .Cursor = Cursors.Hand,
                    .Margin = New Padding(5)
                }
                btnTgl.FlatAppearance.BorderSize = 0

                If i = 0 Then
                    btnTgl.BackColor = Color.Teal
                    btnTgl.ForeColor = Color.White
                    tanggalTerpilihUI = formatUI
                    tanggalTerpilihDB = formatDB
                Else
                    btnTgl.BackColor = Color.WhiteSmoke
                    btnTgl.ForeColor = Color.DimGray
                End If

                AddHandler btnTgl.Click, AddressOf TombolTanggal_Click
                FlpTanggal.Controls.Add(btnTgl)
            Next

            MuatJadwalDariDB(tanggalTerpilihDB)
        End If
    End Sub

    Private Sub TombolTanggal_Click(sender As Object, e As EventArgs)
        For Each ctrl As Control In FlpTanggal.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                btn.BackColor = Color.WhiteSmoke
                btn.ForeColor = Color.DimGray
            End If
        Next

        Dim btnClicked As Button = DirectCast(sender, Button)
        btnClicked.BackColor = Color.Teal
        btnClicked.ForeColor = Color.White

        Dim data() As String = btnClicked.Tag.ToString().Split("|"c)
        tanggalTerpilihUI = data(0)
        tanggalTerpilihDB = data(1)

        MuatJadwalDariDB(tanggalTerpilihDB)
    End Sub

End Class