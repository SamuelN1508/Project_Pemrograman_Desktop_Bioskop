Imports MySql.Data.MySqlClient

Public Class PilihKursi

    ' --- DATA DARI FORM SEBELUMNYA ---
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property SelectedJadwalID As String
    Public JudulFilmTerpilih As String = "Tim Tim"
    Public InfoJadwal As String = "Sindia, 11 12 Ster | 14:00"
    Public IdStudioTerpilih As String = "1"

    ' --- PENYIMPANAN SEMENTARA ---
    Private ListKursiDipilih As New List(Of String)

    ' --- PENGATURAN WARNA KURSI ---
    Private WarnaTersedia As Color = Color.White
    Private WarnaDipesan As Color = Color.IndianRed
    Private WarnaDipilih As Color = Color.FromArgb(46, 139, 135) ' Tosca Gelap
    Private WarnaTerblokir As Color = Color.Gray

    ' --- KONFIGURASI DATABASE ---
    ' Sesuaikan 'database=db_bioskop' dengan nama database Anda di phpMyAdmin
    Dim connectionString As String = "server=localhost;user id=root;password=;database=bioskop_db"
    Dim conn As MySqlConnection

    Private Sub PilihKursi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set label detail film
        LblDetailInfo.Text = JudulFilmTerpilih & " | " & InfoJadwal

        ' Buat Garis Layar
        Dim line As New Label With {.BorderStyle = BorderStyle.Fixed3D, .Height = 2, .Width = 540, .Top = 15, .Left = 0}
        PnlLayar.Controls.Add(line)
        LblLayar.BringToFront()

        ' 1. Bikin semua tombol kursi (A1 sampai H14)
        GenerateKursi()

        ' 2. Cek database untuk melihat kursi mana yang Aktif (Tersedia) atau Non-Aktif (Terblokir)
        MuatStatusKursiDariDB()
    End Sub

    Private Sub GenerateKursi()
        Dim baris As String() = {"A", "B", "C", "D", "E", "F", "G", "H"}
        Dim jumlahKolom As Integer = 14

        Dim ukuranKursi As Integer = 30
        Dim jarak As Integer = 6

        For i As Integer = 0 To baris.Length - 1
            Dim posisiX As Integer = 0

            For j As Integer = 1 To jumlahKolom
                ' Lorong (Jeda Kosong)
                If j = 3 Then posisiX += 20
                If j = 13 Then posisiX += 20

                Dim btnKursi As New Button() With {
                    .Name = "Btn_" & baris(i) & j.ToString(),
                    .Text = "",
                    .Tag = baris(i) & j.ToString(), ' Tag menyimpan Kode_Kursi (contoh: "A1")
                    .Size = New Size(ukuranKursi, ukuranKursi),
                    .Location = New Point(posisiX, i * (ukuranKursi + jarak)),
                    .BackColor = WarnaTersedia,
                    .FlatStyle = FlatStyle.Flat,
                    .Cursor = Cursors.Hand
                }
                btnKursi.FlatAppearance.BorderColor = Color.DarkGray

                ' Event Klik
                AddHandler btnKursi.Click, AddressOf Kursi_Click

                PnlKursi.Controls.Add(btnKursi)

                posisiX += ukuranKursi + jarak
            Next
        Next
    End Sub

    ''' <summary>
    ''' Mengambil status kursi dari tabel 'seats' berdasarkan ID_Studio
    ''' </summary>
    Private Sub MuatStatusKursiDariDB()
        Try
            conn = New MySqlConnection(connectionString)
            conn.Open()

            ' Ambil data kursi untuk studio yang dipilih
            Dim query As String = "SELECT Kode_Kursi, Status_Aktif FROM seats WHERE ID_Studio = @idStudio"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@idStudio", IdStudioTerpilih)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Looping data dari database
            While reader.Read()
                Dim kodeKursi As String = reader("Kode_Kursi").ToString()
                Dim statusAktif As Integer = Convert.ToInt32(reader("Status_Aktif"))

                ' Cari tombol di panel yang Tag-nya sama dengan Kode_Kursi di DB
                For Each ctrl As Control In PnlKursi.Controls
                    If TypeOf ctrl Is Button Then
                        Dim btn As Button = DirectCast(ctrl, Button)

                        If btn.Tag IsNot Nothing AndAlso btn.Tag.ToString() = kodeKursi Then
                            ' Update warna berdasarkan Status_Aktif
                            If statusAktif = 1 Then
                                btn.BackColor = WarnaTersedia
                            Else
                                btn.BackColor = WarnaTerblokir
                                btn.Cursor = Cursors.No ' Ubah kursor jadi tanda dilarang
                            End If
                            Exit For ' Lanjut ke data dari database berikutnya
                        End If
                    End If
                Next
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Gagal terhubung ke Database: " & ex.Message, "Error XAMPP", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub Kursi_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim nomorKursi As String = btn.Tag.ToString()

        ' Tolak klik jika kursi dipesan (merah) atau terblokir (abu-abu)
        If btn.BackColor = WarnaDipesan OrElse btn.BackColor = WarnaTerblokir Then
            Return
        End If

        ' Logika Pilih / Batal (Putih <-> Tosca)
        If btn.BackColor = WarnaTersedia Then
            btn.BackColor = WarnaDipilih
            ListKursiDipilih.Add(nomorKursi)
        Else
            btn.BackColor = WarnaTersedia
            ListKursiDipilih.Remove(nomorKursi)
        End If

        UpdateTeksBawah()
    End Sub

    Private Sub UpdateTeksBawah()
        If ListKursiDipilih.Count = 0 Then
            LblKursiDipilih.Text = "Kursi yang dipilih: -"
        Else
            ListKursiDipilih.Sort()
            LblKursiDipilih.Text = "Kursi yang dipilih: " & String.Join(", ", ListKursiDipilih)
        End If
    End Sub

    Private Sub BtnLanjut_Click(sender As Object, e As EventArgs) Handles BtnLanjut.Click
        If ListKursiDipilih.Count = 0 Then
            MessageBox.Show("Pilih minimal 1 kursi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        MessageBox.Show("Lanjut ke pembayaran. Kursi: " & String.Join(", ", ListKursiDipilih), "Sukses")
        FormPembayaran.Show() ' Uncomment ini jika form pembayaran sudah ada
    End Sub

    Private Sub PnlKursi_Paint(sender As Object, e As PaintEventArgs) Handles PnlKursi.Paint

    End Sub

    ' --- EVENT TOMBOL BACK ---
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        ' Membuka kembali halaman Pilih Studio
        Pilih_Studio.Show()
        ' Menutup halaman Pilih Kursi saat ini
        Me.Close()
    End Sub

End Class