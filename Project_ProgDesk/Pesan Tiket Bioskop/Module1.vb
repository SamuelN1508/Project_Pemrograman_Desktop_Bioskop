Imports MySql.Data.MySqlClient ' Ini library khusus untuk MySQL / XAMPP

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

End Module