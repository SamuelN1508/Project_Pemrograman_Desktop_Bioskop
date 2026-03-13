' 1. IMPORTS HARUS DI BARIS PALING ATAS
Imports System.Windows.Forms
Imports QRCoder

' 2. NAMA CLASS HARUS SESUAI NAMA FORM DAN TIDAK BOLEH BERTUMPUK
Public Class E_Ticket___Kode_QR

    ' KOTAK SURAT UNTUK MENERIMA DATA
    Public ID_Booking As String
    Public ID_User As String
    Public Waktu_Transaksi As String
    Public Status As String
    Public Total_Harga As Integer

    Public JudulFilm As String
    Public NamaStudio As String
    Public NomorKursi As String

    ' EVENT SAAT FORM DIBUKA
    Private Sub E_Ticket___Kode_QR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengupdate teks
        If Not String.IsNullOrEmpty(JudulFilm) Then
            lblDetails.Text = JudulFilm & vbCrLf &
                              Waktu_Transaksi & vbCrLf &
                              NamaStudio & vbCrLf &
                              "Kursi " & NomorKursi & vbCrLf &
                              "Status: " & Status
        End If

        ' Generate QR Code
        If Not String.IsNullOrEmpty(ID_Booking) Then
            Dim qrGenerator As New QRCodeGenerator()
            Dim qrData As QRCodeData = qrGenerator.CreateQrCode(ID_Booking, QRCodeGenerator.ECCLevel.Q)
            Dim qrCode As New QRCode(qrData)
            picQR.Image = qrCode.GetGraphic(20)
        Else
            ' Dummy untuk testing
            Dim qrGenerator As New QRCodeGenerator()
            Dim qrData As QRCodeData = qrGenerator.CreateQrCode("DUMMY-BOOKING-001", QRCodeGenerator.ECCLevel.Q)
            Dim qrCode As New QRCode(qrData)
            picQR.Image = qrCode.GetGraphic(20)
        End If
    End Sub

    ' TOMBOL KELUAR
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari halaman tiket?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ' TOMBOL SIMPAN
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If picQR.Image IsNot Nothing Then
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg"
            saveDialog.Title = "Simpan E-Ticket QR Code"
            saveDialog.FileName = "ETicket_" & ID_Booking & ".png"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                picQR.Image.Save(saveDialog.FileName)
                MessageBox.Show("E-Ticket berhasil disimpan ke perangkat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("QR Code belum tersedia untuk disimpan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class