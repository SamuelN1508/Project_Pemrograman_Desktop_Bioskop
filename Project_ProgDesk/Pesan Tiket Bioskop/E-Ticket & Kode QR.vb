Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Net
Imports System.Net.Mail

Public Class E_Ticket___Kode_QR

    Dim daftarKursi() As String
    Dim indeksTiketSekarang As Integer = 0
    Dim connectionString As String = "server=localhost;user id=root;password=;database=bioskop_db"

    Private Sub E_Ticket___Kode_QR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim teksKursi As String = Transisi_Daftar_Kursi.Replace(" ", "")
        daftarKursi = teksKursi.Split(","c)

        If daftarKursi.Length <= 1 Then
            BtnNext.Visible = False
            BtnPrev.Visible = False
            LblHalamanTiket.Visible = False
        Else
            BtnNext.Visible = True
            BtnPrev.Visible = True
            LblHalamanTiket.Visible = True
        End If

        LblHarga.Visible = False
        TampilkanTiket(0)
    End Sub

    Private Sub TampilkanTiket(indeks As Integer)
        Dim judul As String = If(Transisi_Judul_Film <> "", Transisi_Judul_Film, "The Film")

        LblJudulFilm.Text = "🎬 " & judul
        LblKursi.Text = "💺 Kursi: " & daftarKursi(indeks)
        LblStudio.Text = "📍 " & Transisi_Nama_Studio

        Dim waktuData() As String = Transisi_Waktu_Tayang.Split("|")
        If waktuData.Length > 1 Then
            LblWaktu.Text = "📅 " & waktuData(0).Trim() & "  |  🕒 " & waktuData(1).Trim()
        Else
            LblWaktu.Text = "📅 " & Transisi_Waktu_Tayang
        End If

        Dim dataQR As String = "CinemaHub|" & judul & "|" & daftarKursi(indeks)
        Dim urlQR As String = "https://api.qrserver.com/v1/create-qr-code/?size=200x200&data=" & Uri.EscapeDataString(dataQR)
        Try
            PicQR.Load(urlQR)
        Catch
            PicQR.BackColor = Color.LightGray
        End Try

        LblHalamanTiket.Text = "Tiket " & (indeks + 1) & " dari " & daftarKursi.Length
        BtnPrev.Enabled = (indeks > 0)
        BtnNext.Enabled = (indeks < daftarKursi.Length - 1)
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If indeksTiketSekarang < daftarKursi.Length - 1 Then
            indeksTiketSekarang += 1
            TampilkanTiket(indeksTiketSekarang)
        End If
    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
        If indeksTiketSekarang > 0 Then
            indeksTiketSekarang -= 1
            TampilkanTiket(indeksTiketSekarang)
        End If
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Application.Exit()
    End Sub

    ' ==============================================================
    ' LOGIKA TOMBOL KIRIM EMAIL (GAMBAR MUNCUL LANGSUNG DI DALAM PESAN)
    ' ==============================================================
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click

        Dim emailPenerima As String = ""

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT Email FROM users WHERE ID_User = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Sesi_ID_User)
                    emailPenerima = Convert.ToString(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data email: " & ex.Message, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        If String.IsNullOrEmpty(emailPenerima) Then
            MessageBox.Show("Email user tidak ditemukan di database!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor

            ' -------------------------------------------------------------
            ' !!! JANGAN LUPA UBAH 2 BARIS INI DENGAN DATA GMAIL ANDA !!!
            ' -------------------------------------------------------------
            Dim emailPengirim As String = "ameliagustin02@gmail.com"
            Dim passwordApp As String = "pprh pthi zveu xprv"
            ' -------------------------------------------------------------

            Dim mail As New MailMessage()
            mail.From = New MailAddress(emailPengirim, "CinemaHub E-Ticket")
            mail.To.Add(emailPenerima)
            mail.Subject = "E-Ticket CinemaHub - Tiket Dikonfirmasi!"

            ' Aktifkan mode HTML untuk Email
            mail.IsBodyHtml = True

            ' Membangun struktur desain email HTML
            Dim htmlBody As String = "<div style='font-family: Arial, sans-serif; color: #333; max-width: 800px; margin: auto;'>" &
                                     "<h2 style='color: #008080;'>Pemesanan Berhasil!</h2>" &
                                     "<p>Terima kasih telah memesan tiket di <b>CinemaHub</b>. Berikut adalah E-Ticket Anda:</p>"

            Dim listStreams As New List(Of MemoryStream)
            Dim linkedResources As New List(Of LinkedResource)

            For i As Integer = 0 To daftarKursi.Length - 1
                Dim kursiSatuan As String = daftarKursi(i)
                Dim bmp As New Bitmap(800, 400)

                ' --- KODE MENGGAMBAR TIKET ANDA ---
                Using g As Graphics = Graphics.FromImage(bmp)
                    g.SmoothingMode = SmoothingMode.AntiAlias
                    g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

                    g.Clear(Color.FromArgb(80, 80, 80))
                    Dim ticketRect As New Rectangle(30, 30, 740, 340)
                    g.FillRectangle(Brushes.White, ticketRect)

                    Dim penDashed As New Pen(Color.LightGray, 3)
                    penDashed.DashStyle = DashStyle.Dash
                    g.DrawLine(penDashed, 550, 30, 550, 370)
                    g.FillEllipse(New SolidBrush(Color.FromArgb(80, 80, 80)), 535, 15, 30, 30)
                    g.FillEllipse(New SolidBrush(Color.FromArgb(80, 80, 80)), 535, 355, 30, 30)

                    Dim t_film As String = If(Transisi_Judul_Film <> "", Transisi_Judul_Film.ToUpper(), "THE FILM")
                    Dim t_studio As String = Transisi_Nama_Studio.ToUpper()
                    Dim t_seat As String = kursiSatuan.ToUpper()

                    Dim dataWaktu As String() = Transisi_Waktu_Tayang.Split("|")
                    Dim t_date As String = "15 MEI 2026"
                    Dim t_time As String = "10:00"
                    If dataWaktu.Length > 1 Then
                        t_date = dataWaktu(0).Trim().ToUpper()
                        t_time = dataWaktu(1).Trim().ToUpper()
                    End If

                    Dim t_price As String = "Rp " & Transisi_Harga_Tiket.ToString("N0", New Globalization.CultureInfo("id-ID"))

                    g.FillRectangle(New SolidBrush(Color.Teal), 180, 60, 280, 40)
                    g.DrawString("CINEMA TICKET", New Font("Segoe UI", 16, FontStyle.Bold), Brushes.White, 220, 65)

                    Dim fontLabel As New Font("Segoe UI", 12, FontStyle.Regular)
                    Dim fontValue As New Font("Segoe UI", 12, FontStyle.Bold)
                    Dim startY As Integer = 130
                    Dim gapY As Integer = 35

                    g.DrawString("FILM", fontLabel, Brushes.DimGray, 180, startY)
                    g.DrawString(":  " & t_film, fontValue, Brushes.Black, 280, startY)
                    g.DrawString("STUDIO", fontLabel, Brushes.DimGray, 180, startY + gapY)
                    g.DrawString(":  " & t_studio, fontValue, Brushes.Black, 280, startY + gapY)
                    g.DrawString("DATE", fontLabel, Brushes.DimGray, 180, startY + gapY * 2)
                    g.DrawString(":  " & t_date, fontValue, Brushes.Black, 280, startY + gapY * 2)
                    g.DrawString("TIME", fontLabel, Brushes.DimGray, 180, startY + gapY * 3)
                    g.DrawString(":  " & t_time, fontValue, Brushes.Black, 280, startY + gapY * 3)
                    g.DrawString("SEAT", fontLabel, Brushes.DimGray, 180, startY + gapY * 4)
                    g.DrawString(":  " & t_seat, fontValue, Brushes.Black, 280, startY + gapY * 4)
                    g.DrawString("PRICE", fontLabel, Brushes.DimGray, 180, startY + gapY * 5)
                    g.DrawString(":  " & t_price, fontValue, Brushes.Black, 280, startY + gapY * 5)

                    g.DrawString("🎬 ENJOY YOUR MOVIE!", New Font("Segoe UI", 12, FontStyle.Bold), New SolidBrush(Color.Teal), 230, 330)

                    Dim fontRightTitle As New Font("Segoe UI", 14, FontStyle.Bold)
                    Dim fontRightVal As New Font("Segoe UI", 10, FontStyle.Bold)
                    g.DrawString("CINEMA HUB", fontRightTitle, New SolidBrush(Color.Teal), 600, 60)
                    g.DrawString(t_film, fontRightVal, Brushes.Black, 580, 100)
                    g.DrawString(t_studio, fontRightVal, Brushes.Black, 610, 125)
                    g.DrawString("SEAT: " & t_seat, fontRightVal, Brushes.Black, 600, 150)

                    Dim rand As New Random(t_film.Length + i)
                    For j As Integer = 0 To 80 Step 4
                        Dim lebarGaris As Integer = rand.Next(1, 4)
                        g.FillRectangle(Brushes.Black, 80 + j, 60, lebarGaris, 250)
                        g.FillRectangle(Brushes.Black, CInt(580 + (j * 1.5)), 190, lebarGaris, 50)
                    Next

                    Dim noBarcode As String = "NO. 20260515" & (i + 1).ToString("0000")
                    Dim fontBarcode As New Font("Consolas", 10, FontStyle.Regular)
                    g.DrawString(noBarcode, fontBarcode, Brushes.Black, 590, 245)
                    g.DrawString(t_date, fontRightVal, Brushes.DimGray, 605, 280)
                    g.DrawString(t_time, fontRightTitle, Brushes.Black, 625, 305)

                    g.TranslateTransform(70, 310)
                    g.RotateTransform(-90)
                    g.DrawString(noBarcode, fontBarcode, Brushes.Black, 0, 0)
                    g.ResetTransform()
                End Using
                ' ---------------------------------------

                Dim ms As New MemoryStream()
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                ms.Position = 0

                ' Hubungkan gambar tiket secara virtual ke HTML email
                Dim contentId As String = "tiket_" & i.ToString()
                htmlBody &= "<div style='margin-bottom: 25px; text-align: center;'><img src='cid:" & contentId & "' alt='Tiket CinemaHub' style='max-width: 100%; border-radius: 8px; box-shadow: 0 4px 8px rgba(0,0,0,0.2);' /></div>"

                Dim inlineImg As New LinkedResource(ms, "image/png")
                inlineImg.ContentId = contentId
                linkedResources.Add(inlineImg)

                listStreams.Add(ms)
                bmp.Dispose()
            Next

            htmlBody &= "<p>Harap tunjukkan gambar tiket di atas kepada petugas saat memasuki studio.<br/>Selamat menonton!</p></div>"

            Dim altView As AlternateView = AlternateView.CreateAlternateViewFromString(htmlBody, Nothing, "text/html")
            For Each res In linkedResources
                altView.LinkedResources.Add(res)
            Next
            mail.AlternateViews.Add(altView)

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential(emailPengirim, passwordApp)

            smtp.Send(mail)

            ' Bersihkan memori
            For Each ms In listStreams
                ms.Close()
                ms.Dispose()
            Next

            MessageBox.Show("E-Ticket berhasil dikirim dan ditampilkan di dalam email: " & emailPenerima, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Gagal mengirim email. Pastikan internet aktif dan Password App benar. Pesan Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

End Class