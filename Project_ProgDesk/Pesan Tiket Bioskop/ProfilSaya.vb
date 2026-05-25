Imports MySql.Data.MySqlClient

Public Class ProfilSaya

    Dim connectionString As String = "server=localhost;user id=root;password=;database=bioskop_db"

    Private Sub ProfilSaya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MuatDataProfil()
    End Sub

    Private Sub MuatDataProfil()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' DI SINI PERUBAHANNYA: Menggunakan kolom 'Nama' sesuai database Anda
                Dim query As String = "SELECT Nama, Email FROM users WHERE ID_User = @id"
                Using cmd As New MySqlCommand(query, conn)
                    ' Mengambil ID user dari variabel global
                    cmd.Parameters.AddWithValue("@id", Sesi_ID_User)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' DI SINI JUGA: Mengambil data dari kolom 'Nama'
                            LblNama.Text = reader("Nama").ToString()
                            LblEmail.Text = reader("Email").ToString()
                        Else
                            MessageBox.Show("Data profil tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat profil: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
    End Sub

End Class