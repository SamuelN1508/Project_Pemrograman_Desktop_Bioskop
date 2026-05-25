Imports MySql.Data.MySqlClient

Public Class RiwayatTiket

    Dim connectionString As String = "server=localhost;user id=root;password=;database=bioskop_db"

    Private Sub RiwayatTiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDataGridView()
        MuatRiwayatTiket()
    End Sub

    Private Sub SetupDataGridView()
        DgvRiwayat.Columns.Clear()
        DgvRiwayat.AutoGenerateColumns = False
        DgvRiwayat.ReadOnly = True
        DgvRiwayat.AllowUserToAddRows = False
        DgvRiwayat.RowHeadersVisible = False
        DgvRiwayat.BackgroundColor = Color.White
        DgvRiwayat.BorderStyle = BorderStyle.None
        DgvRiwayat.DefaultCellStyle.Font = New Font("Segoe UI", 9)
        DgvRiwayat.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        DgvRiwayat.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        DgvRiwayat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DgvRiwayat.EnableHeadersVisualStyles = False
        DgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        DgvRiwayat.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Nama Film",
            .DataPropertyName = "Judul_Film",
            .FillWeight = 30
        })
        DgvRiwayat.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Tanggal",
            .DataPropertyName = "Tanggal_Tayang",
            .FillWeight = 20
        })
        DgvRiwayat.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Kursi",
            .DataPropertyName = "Kode_Kursi",
            .FillWeight = 20
        })
        DgvRiwayat.Columns.Add(New DataGridViewTextBoxColumn With {
            .HeaderText = "Status",
            .DataPropertyName = "Status",
            .FillWeight = 15
        })
    End Sub

    Private Sub MuatRiwayatTiket()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' --- PERUBAHAN DI SINI: Alur JOIN diperbaiki ---
                ' Bookings -> Schedules -> Movies
                Dim query As String =
                    "SELECT m.Judul_Film, s.Tanggal_Tayang, b.Status, " &
                    "GROUP_CONCAT(st.Kode_Kursi SEPARATOR ', ') AS Kode_Kursi " &
                    "FROM bookings b " &
                    "JOIN schedules s ON b.ID_Jadwal = s.ID_Jadwal " &
                    "JOIN movies m ON s.ID_Film = m.ID_Film " &
                    "LEFT JOIN booking_details bd ON b.ID_Booking = bd.ID_Booking " &
                    "LEFT JOIN seats st ON bd.ID_Kursi = st.ID_Kursi " &
                    "WHERE b.ID_User = @id " &
                    "GROUP BY b.ID_Booking, m.Judul_Film, s.Tanggal_Tayang, b.Status " &
                    "ORDER BY b.ID_Booking DESC"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Sesi_ID_User)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        DgvRiwayat.DataSource = table

                        ' Warna baris berdasarkan status
                        For Each row As DataGridViewRow In DgvRiwayat.Rows
                            Dim status As String = row.Cells("Status").Value?.ToString()
                            If status = "ISSUED" Then
                                row.DefaultCellStyle.ForeColor = Color.Green
                            ElseIf status = "CANCELLED" Then
                                row.DefaultCellStyle.ForeColor = Color.Red
                            End If
                        Next

                        If table.Rows.Count = 0 Then
                            LblKosong.Visible = True
                        Else
                            LblKosong.Visible = False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat riwayat: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
    End Sub

End Class