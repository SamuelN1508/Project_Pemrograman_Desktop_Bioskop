Imports MySql.Data.MySqlClient ' PENTING: Jangan lupa baris paling atas ini!

Public Class Login

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If TxtEmail.Text = "" Or TxtPassword.Text = "" Then
            MessageBox.Show("Email dan Kata Sandi tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Buka Koneksi ke XAMPP
            BukaKoneksi()

            ' Query ke tabel Users
            Dim query As String = "SELECT * FROM Users WHERE (Email = @input OR Nama = @input) AND Password = @password"
            Dim cmd As New MySqlCommand(query, KoneksiDB) ' Perhatikan penggunaan MySqlCommand

            cmd.Parameters.AddWithValue("@input", TxtEmail.Text)
            cmd.Parameters.AddWithValue("@password", TxtPassword.Text)

            ' Eksekusi pembacaan data
            Dim reader As MySqlDataReader = cmd.ExecuteReader() ' Perhatikan MySqlDataReader

            If reader.HasRows Then
                reader.Read()

                Sesi_ID_User = reader("ID_User").ToString()
                Sesi_Nama_User = reader("Nama").ToString()
                Sesi_Email = reader("Email").ToString()
                Sesi_Role = reader("Role").ToString()

                MessageBox.Show("Selamat datang, " & Sesi_Nama_User & "!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim halBeranda As New Beranda()
                halBeranda.Show()
                Me.Hide()
            Else
                MessageBox.Show("Email atau Kata Sandi salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtPassword.Clear()
                TxtPassword.Focus()
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan sistem: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

<<<<<<< Updated upstream
=======
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim halRegister As New Register()
        halRegister.Show()
        Me.Hide()
    End Sub

    Private Sub LblEmail_Click(sender As Object, e As EventArgs) Handles LblEmail.Click

    End Sub

>>>>>>> Stashed changes
    ' ... (Kode untuk BtnRegister_Click dan TxtPassword_KeyDown biarkan sama) ...

End Class