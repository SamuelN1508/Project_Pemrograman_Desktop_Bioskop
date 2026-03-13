Imports System.Windows.Forms

Public Class FormPembayaran

    ' ==========================================================
    ' 1. VARIABEL PENAMPUNG DATA (Tanpa kata 'Property' agar tidak error)
    ' ==========================================================
    Public JudulFilm As String = "The Film"
    Public WaktuTayang As String = "Selasa, 12 Nov 2024 | 14:00"
    Public NamaStudio As String = "Studio 1 (Normal)"
    Public NomorKursi As String = "F12, F13"
    Public HargaTiket As Integer = 120000

    ' ==========================================================
    ' 2. EVENT SAAT TOMBOL "LANJUT KE PEMBAYARAN" DIKLIK
    ' ==========================================================
    Private Sub btnLanjut_Click(sender As Object, e As EventArgs) Handles btnLanjut.Click

        ' Mengecek metode pembayaran yang dipilih
        Dim metodePembayaran As String = ""
        If rbTransfer.Checked Then
            metodePembayaran = "Transfer Bank"
        ElseIf rbOvo.Checked Then
            metodePembayaran = "OVO (E-Wallet)"
        ElseIf rbKredit.Checked Then
            metodePembayaran = "Kartu Kredit"
        End If

        ' Memunculkan pesan sukses
        MessageBox.Show("Pembayaran menggunakan " & metodePembayaran & " berhasil diproses!" & vbCrLf & "Sistem sedang mencetak E-Ticket Anda.", "Pembayaran Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Membuka Halaman E-Ticket (Ganti 'Form1' jika nama form E-Ticket Anda berbeda)
        Dim halamanTiket As New FormPembayaran()

        ' MELEMPAR DATA KE HALAMAN E-TICKET
        ' Membuat kode booking acak berdasarkan tanggal & jam saat ini
        Dim kodeBooking As String = ""
        kodeBooking = "TIX-" & DateTime.Now.ToString("ddMMyyHHmmss")

        ' Melempar detail film ke E-Ticket
        halamanTiket.JudulFilm = Me.JudulFilm
        halamanTiket.WaktuTayang = Me.WaktuTayang
        halamanTiket.NamaStudio = Me.NamaStudio
        halamanTiket.NomorKursi = Me.NomorKursi

        ' Menampilkan E-Ticket di layar
        halamanTiket.Show()

        ' Menutup Halaman Pembayaran ini
        Me.Close()

    End Sub

    Private Sub PanelLeft_Paint(sender As Object, e As PaintEventArgs) Handles PanelLeft.Paint

    End Sub

    Private Sub rbTransfer_CheckedChanged(sender As Object, e As EventArgs) Handles rbTransfer.CheckedChanged

    End Sub

    Private Sub lblMovieDetails_Click(sender As Object, e As EventArgs) Handles lblMovieDetails.Click

    End Sub

    Private Sub lblDetailHargaTitle_Click(sender As Object, e As EventArgs) Handles lblDetailHargaTitle.Click

    End Sub

    Private Sub lblRingkasanTitle_Click(sender As Object, e As EventArgs) Handles lblRingkasanTitle.Click

    End Sub

    Private Sub lblHargaValues_Click(sender As Object, e As EventArgs) Handles lblHargaValues.Click

    End Sub

    Private Sub lblMetodeTitle_Click(sender As Object, e As EventArgs) Handles lblMetodeTitle.Click

    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub picPoster_Click(sender As Object, e As EventArgs) Handles picPoster.Click

    End Sub
End Class