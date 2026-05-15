Imports System.Windows.Forms

Public Class FormPembayaran

    Public JudulFilm As String = "The Film"
    Public WaktuTayang As String = "Selasa, 12 Nov 2024 | 14:00"
    Public NamaStudio As String = "Studio 1 (Normal)"
    Public NomorKursi As String = "F12, F13"
    Public HargaTiket As Integer = 120000

    Private Sub btnLanjut_Click(sender As Object, e As EventArgs) Handles btnLanjut.Click
        Dim metodePembayaran As String = ""
        If rbTransfer.Checked Then
            metodePembayaran = "Transfer Bank"
        ElseIf rbOvo.Checked Then
            metodePembayaran = "OVO (E-Wallet)"
        ElseIf rbKredit.Checked Then
            metodePembayaran = "Kartu Kredit"
        Else
            MessageBox.Show("Silakan pilih metode pembayaran terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        MessageBox.Show("Pembayaran menggunakan " & metodePembayaran & " berhasil diproses!" & vbCrLf & "Sistem sedang mencetak E-Ticket Anda.", "Pembayaran Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim halamanTiket As New E_Ticket___Kode_QR()

        Dim kodeBooking As String = "TIX-" & DateTime.Now.ToString("ddMMyyHHmmss")

        halamanTiket.ID_Booking = kodeBooking
        halamanTiket.Waktu_Transaksi = DateTime.Now.ToString("dd MMM yyyy HH:mm")
        halamanTiket.Status = "Lunas (" & metodePembayaran & ")"

        halamanTiket.JudulFilm = Me.JudulFilm
        halamanTiket.NamaStudio = Me.NamaStudio
        halamanTiket.NomorKursi = Me.NomorKursi

        halamanTiket.Show()
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