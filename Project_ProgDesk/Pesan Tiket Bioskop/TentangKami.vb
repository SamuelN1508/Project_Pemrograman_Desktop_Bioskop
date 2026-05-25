Public Class TentangKami

    Private Sub TentangKami_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Nama Aplikasi
        LblNamaAplikasi.Text = "CinemaHub"
        LblNamaAplikasi.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        LblNamaAplikasi.ForeColor = Color.Teal

        ' Deskripsi
        LblDeskripsi.Text =
            "CinemaHub adalah aplikasi pemesanan tiket bioskop berbasis desktop " &
            "yang memudahkan pengguna dalam memilih film, studio, jadwal, " &
            "dan kursi secara praktis. Dilengkapi dengan e-ticket digital " &
            "dan kode QR untuk kemudahan akses di bioskop."

        ' Anggota Kelompok
        LblAnggota.Text =
            "Dikembangkan oleh:" & Environment.NewLine &
            Environment.NewLine &
            "1. Cynthia Angeline           - 71220858" & Environment.NewLine &
            "2. Fransina Riyanty Batlayar  - 71231014" & Environment.NewLine &
            "3. Amelia Agustin             - 71231038" & Environment.NewLine &
            "4. Nengah Yesi Putri          - 71231047" & Environment.NewLine &
            "5. Samuel Natanael            - 71231050"
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
    End Sub

End Class