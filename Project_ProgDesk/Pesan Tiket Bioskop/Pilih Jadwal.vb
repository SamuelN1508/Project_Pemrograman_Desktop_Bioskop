Imports MySql.Data.MySqlClient
Public Module ModulSesi
    Public Sesi_ID_Jadwal As String
End Module
Public Class Jadwal
    Private Sub Jadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MuatDataJadwal()
    End Sub
    Sub MuatDataJadwal()
        Try
            BukaKoneksi()
            Dim query As String = "SELECT ID_Jadwal, Waktu_Mulai, Harga_Tiket FROM Schedules WHERE ID_Film = 'M001' ORDER BY Waktu_Mulai ASC"
            Dim cmd As New MySqlCommand(query, KoneksiDB)
            Dim rd As MySqlDataReader = cmd.ExecuteReader()

            Dim i As Integer = 1
            While rd.Read()
                Dim jam As String = rd("Waktu_Mulai").ToString().Substring(0, 5)
                Dim harga As String = String.Format("{0:n0}", rd("Harga_Tiket"))

                If i = 1 Then
                    lbljam1.Text = jam
                    lblharga1.Text = "Rp " & harga
                ElseIf i = 2 Then
                    lbljam2.Text = jam
                    lblharga2.Text = "Rp " & harga
                ElseIf i = 3 Then
                    lbljam3.Text = jam
                    lblharga3.Text = "Rp " & harga
                End If
                i += 1
            End While
            rd.Close()
        Catch ex As Exception
            MsgBox("Gagal memuat jadwal: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub PilihJadwal(idJadwal As String)
        ModulSesi.Sesi_ID_Jadwal = idJadwal
        'Dim frmKursi As New FormPilihKursi()
        'frmKursi.Show()
        'Me.Hide()
    End Sub
    Private Sub btnpilih1_Click(sender As Object, e As EventArgs) Handles btnpilih1.Click
        PilihJadwal("SCH-001") ' Jam 14:00
    End Sub
    Private Sub btnpilih2_Click(sender As Object, e As EventArgs) Handles btnpilih2.Click
        PilihJadwal("SCH-002") ' Jam 16:30
    End Sub
    Private Sub btnpilih3_Click(sender As Object, e As EventArgs) Handles btnpilih3.Click
        PilihJadwal("SCH-003") ' Jam 19:00
    End Sub

    Private Sub lbljadwal_Click(sender As Object, e As EventArgs) Handles lbljadwal.Click

    End Sub
End Class