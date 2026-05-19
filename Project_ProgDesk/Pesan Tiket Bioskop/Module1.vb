Imports MySql.Data.MySqlClient ' Ini library khusus untuk MySQL / XAMPP
Imports System.Drawing ' Tambahan agar bisa mengenali tipe data Image
Imports System.IO ' [TAMBAHAN] Wajib ditambahkan untuk memproses aliran data (Stream) gambar

Module Modul_Global

    ' ==========================================
    ' 1. PENGATURAN KONEKSI DATABASE XAMPP
    ' ==========================================
    ' Di XAMPP, default server adalah localhost, user adalah root, dan password kosong.
    Public StringKoneksi As String = "Server=localhost;User ID=root;Password=;Database=bioskop_db;"
    Public KoneksiDB As New MySqlConnection(StringKoneksi)

    ' ==========================================
    ' 2. VARIABEL SESI PENGGUNA (SESSION)
    ' ==========================================
    Public Sesi_ID_User As String = ""
    Public Sesi_Nama_User As String = ""
    Public Sesi_Email As String = ""
    Public Sesi_Role As String = ""

    ' ==========================================
    ' 3. VARIABEL TRANSISI ANTAR HALAMAN
    ' ==========================================
    Public Transisi_ID_Film As String = ""
    Public Transisi_Judul_Film As String = ""
    Public Transisi_ID_Jadwal As String = ""
    Public Transisi_Harga_Tiket As Decimal = 0

    ' Variabel untuk menyimpan daftar kursi dan studio
    Public Transisi_Daftar_Kursi As String = ""
    Public Transisi_Nama_Studio As String = ""
    Public Transisi_Waktu_Tayang As String = ""

    ' INI TAMBAHANNYA: Variabel untuk Total Bayar dan Gambar Poster
    Public Transisi_Total_Bayar As Decimal = 0
    Public Transisi_Poster_Film As Image = Nothing

    ' ==========================================
    ' 4. FUNGSI GLOBAL 
    ' ==========================================

    ' Fungsi Format Rupiah
    Public Function FormatRupiah(ByVal Angka As Decimal) As String
        Return "Rp " & Angka.ToString("N0", New Globalization.CultureInfo("id-ID"))
    End Function

    ' Fungsi Buka Koneksi MySQL
    Public Sub BukaKoneksi()
        Try
            If KoneksiDB.State = ConnectionState.Closed Then
                KoneksiDB.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal terhubung ke Database XAMPP. Pastikan XAMPP (Apache & MySQL) sudah menyala!" & vbCrLf & ex.Message, "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Fungsi Tutup Koneksi MySQL
    Public Sub TutupKoneksi()
        If KoneksiDB.State = ConnectionState.Open Then
            KoneksiDB.Close()
        End If
    End Sub

    ' ==========================================
    ' 5. FUNGSI TAMBAHAN (HELPER)
    ' ==========================================

    ' [TAMBAHAN] Fungsi untuk mengubah tipe data BLOB/Byte dari Database MySQL menjadi Gambar (Image)
    ' Ini sangat berguna saat kamu menarik Poster Film dari database untuk ditampilkan di PictureBox
    Public Function KonversiByteKeGambar(ByVal byteArrayIn As Byte()) As Image
        Try
            Using ms As New MemoryStream(byteArrayIn)
                Return Image.FromStream(ms)
            End Using
        Catch ex As Exception
            Return Nothing ' Mengembalikan nilai kosong jika gagal/gambar korup
        End Try
    End Function

    ' [TAMBAHAN] Fungsi untuk menjalankan query sederhana (Insert, Update, Delete)
    ' Ini membuat kodemu di form lain lebih bersih tanpa perlu menulis Try-Catch koneksi terus menerus
    Public Function EksekusiQuery(ByVal query As String) As Boolean
        Dim statusBerhasil As Boolean = False
        Try
            BukaKoneksi()
            Using cmd As New MySqlCommand(query, KoneksiDB)
                cmd.ExecuteNonQuery()
                statusBerhasil = True
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengeksekusi data: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try
        Return statusBerhasil
    End Function

End Module