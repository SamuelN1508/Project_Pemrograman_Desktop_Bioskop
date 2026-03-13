Imports MySql.Data.MySqlClient

Public Class Register

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click

        ' ── Validasi Input Kosong ──────────────────────────
        If TxtNama.Text = "" Or TxtEmail.Text = "" Or TxtPassword.Text = "" Or TxtConfirmPassword.Text = "" Then
            MessageBox.Show("Semua field harus diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ── Validasi Format Email ──────────────────────────
        If Not TxtEmail.Text.Contains("@") Or Not TxtEmail.Text.Contains(".") Then
            MessageBox.Show("Format email tidak valid!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEmail.Focus()
            Exit Sub
        End If

        ' ── Validasi Password Minimal 5 Karakter ──────────
        If TxtPassword.Text.Length <= 5 Then
            MessageBox.Show("Kata sandi minimal 5 karakter!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPassword.Focus()
            Exit Sub
        End If

        ' ── Validasi Konfirmasi Password ──────────────────
        If TxtPassword.Text <> TxtConfirmPassword.Text Then
            MessageBox.Show("Kata sandi dan konfirmasi tidak cocok!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtConfirmPassword.Clear()
            TxtConfirmPassword.Focus()
            Exit Sub
        End If

        Try
            BukaKoneksi()

            ' ── Cek apakah Email sudah terdaftar ──────────
            Dim queryCek As String = "SELECT COUNT(*) FROM Users WHERE Email = @email"
            Dim cmdCek As New MySqlCommand(queryCek, KoneksiDB)
            cmdCek.Parameters.AddWithValue("@email", TxtEmail.Text.Trim())

            Dim jumlah As Integer = Convert.ToInt32(cmdCek.ExecuteScalar())

            If jumlah > 0 Then
                MessageBox.Show("Email sudah terdaftar! Gunakan email lain.",
                                "Registrasi Gagal",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtEmail.Focus()
                Exit Sub
            End If

            ' ── Insert Data User Baru ─────────────────────
            Dim queryInsert As String =
                "INSERT INTO Users (Nama, Email, Password, Role) " &
                "VALUES (@nama, @email, @password, @role)"

            Dim cmdInsert As New MySqlCommand(queryInsert, KoneksiDB)
            cmdInsert.Parameters.AddWithValue("@nama", TxtNama.Text.Trim())
            cmdInsert.Parameters.AddWithValue("@email", TxtEmail.Text.Trim())
            cmdInsert.Parameters.AddWithValue("@password", TxtPassword.Text)  ' Ganti MD5() jika perlu hash
            cmdInsert.Parameters.AddWithValue("@role", "Penonton")            ' Default role = Penonton

            Dim hasil As Integer = cmdInsert.ExecuteNonQuery()

            If hasil > 0 Then
                MessageBox.Show("Registrasi berhasil! Silakan login.", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Kembali ke Form Login
                Dim halLogin As New Login()
                halLogin.Show()
                Me.Close()
            Else
                MessageBox.Show("Registrasi gagal, coba lagi.", "Gagal",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan sistem: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            TutupKoneksi()
        End Try

    End Sub

    ' ── Tombol Batal → Kembali ke Login ───────────────────
    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Dim halLogin As New Login()
        halLogin.Show()
        Me.Close()
    End Sub

End Class