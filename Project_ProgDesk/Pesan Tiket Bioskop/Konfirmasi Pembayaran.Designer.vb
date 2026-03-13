<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPembayaran
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' Deklarasi Komponen UI
    Friend WithEvents PanelLeft As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblRingkasanTitle As System.Windows.Forms.Label
    Friend WithEvents picPoster As System.Windows.Forms.PictureBox
    Friend WithEvents lblMovieDetails As System.Windows.Forms.Label
    Friend WithEvents lblDetailHargaTitle As System.Windows.Forms.Label
    Friend WithEvents lblHargaValues As System.Windows.Forms.Label
    Friend WithEvents lblMetodeTitle As System.Windows.Forms.Label
    Friend WithEvents rbTransfer As System.Windows.Forms.RadioButton
    Friend WithEvents rbOvo As System.Windows.Forms.RadioButton
    Friend WithEvents rbKredit As System.Windows.Forms.RadioButton
    Friend WithEvents btnLanjut As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelLeft = New Panel()
        lblTitle = New Label()
        lblRingkasanTitle = New Label()
        picPoster = New PictureBox()
        lblMovieDetails = New Label()
        lblDetailHargaTitle = New Label()
        lblHargaValues = New Label()
        lblMetodeTitle = New Label()
        rbTransfer = New RadioButton()
        rbOvo = New RadioButton()
        rbKredit = New RadioButton()
        btnLanjut = New Button()
        Label1 = New Label()
        CType(picPoster, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = Color.LightGray
        PanelLeft.Dock = DockStyle.Left
        PanelLeft.Location = New Point(0, 0)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(177, 583)
        PanelLeft.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(198, 18)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(695, 59)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Halaman Konfirmasi Pembayaran"
        ' 
        ' lblRingkasanTitle
        ' 
        lblRingkasanTitle.AutoSize = True
        lblRingkasanTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRingkasanTitle.Location = New Point(198, 77)
        lblRingkasanTitle.Name = "lblRingkasanTitle"
        lblRingkasanTitle.Size = New Size(286, 41)
        lblRingkasanTitle.TabIndex = 2
        lblRingkasanTitle.Text = "Ringkasan Pesanan"
        ' 
        ' picPoster
        ' 
        picPoster.BackColor = Color.DarkSlateGray
        picPoster.Location = New Point(198, 123)
        picPoster.Name = "picPoster"
        picPoster.Size = New Size(138, 194)
        picPoster.TabIndex = 3
        picPoster.TabStop = False
        ' 
        ' lblMovieDetails
        ' 
        lblMovieDetails.AutoSize = True
        lblMovieDetails.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMovieDetails.Location = New Point(342, 118)
        lblMovieDetails.Name = "lblMovieDetails"
        lblMovieDetails.Size = New Size(387, 128)
        lblMovieDetails.TabIndex = 4
        lblMovieDetails.Text = "Film: The Film" & vbCrLf & "Studio: Studio 1 (Normal)" & vbCrLf & "Jadwal: Selasa, 12 Nov 2024 | 14:00" & vbCrLf & "Kursi: F12, F13"
        ' 
        ' lblDetailHargaTitle
        ' 
        lblDetailHargaTitle.AutoSize = True
        lblDetailHargaTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDetailHargaTitle.Location = New Point(705, 267)
        lblDetailHargaTitle.Name = "lblDetailHargaTitle"
        lblDetailHargaTitle.Size = New Size(196, 41)
        lblDetailHargaTitle.TabIndex = 5
        lblDetailHargaTitle.Text = "Detail Harga"
        ' 
        ' lblHargaValues
        ' 
        lblHargaValues.AutoSize = True
        lblHargaValues.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHargaValues.Location = New Point(705, 308)
        lblHargaValues.Name = "lblHargaValues"
        lblHargaValues.Size = New Size(319, 96)
        lblHargaValues.TabIndex = 6
        lblHargaValues.Text = "Harga:                 Rp 120.000" & vbCrLf & "Pajak:                  Rp  15.000" & vbCrLf & "Total Harga:        Rp 135.000"
        ' 
        ' lblMetodeTitle
        ' 
        lblMetodeTitle.AutoSize = True
        lblMetodeTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMetodeTitle.Location = New Point(198, 386)
        lblMetodeTitle.Name = "lblMetodeTitle"
        lblMetodeTitle.Size = New Size(309, 41)
        lblMetodeTitle.TabIndex = 7
        lblMetodeTitle.Text = "Metode Pembayaran"
        ' 
        ' rbTransfer
        ' 
        rbTransfer.AutoSize = True
        rbTransfer.Location = New Point(198, 466)
        rbTransfer.Name = "rbTransfer"
        rbTransfer.Size = New Size(188, 36)
        rbTransfer.TabIndex = 8
        rbTransfer.Text = "Transfer Bank"
        rbTransfer.UseVisualStyleBackColor = True
        ' 
        ' rbOvo
        ' 
        rbOvo.AutoSize = True
        rbOvo.Location = New Point(469, 466)
        rbOvo.Name = "rbOvo"
        rbOvo.Size = New Size(203, 36)
        rbOvo.TabIndex = 9
        rbOvo.Text = "OVO (E-Wallet)"
        rbOvo.UseVisualStyleBackColor = True
        ' 
        ' rbKredit
        ' 
        rbKredit.AutoSize = True
        rbKredit.Checked = True
        rbKredit.Location = New Point(754, 466)
        rbKredit.Name = "rbKredit"
        rbKredit.Size = New Size(171, 36)
        rbKredit.TabIndex = 10
        rbKredit.TabStop = True
        rbKredit.Text = "Kartu Kredit"
        rbKredit.UseVisualStyleBackColor = True
        ' 
        ' btnLanjut
        ' 
        btnLanjut.BackColor = Color.Teal
        btnLanjut.FlatAppearance.BorderColor = Color.Black
        btnLanjut.FlatAppearance.BorderSize = 2
        btnLanjut.FlatStyle = FlatStyle.Flat
        btnLanjut.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLanjut.ForeColor = Color.White
        btnLanjut.Location = New Point(198, 521)
        btnLanjut.Name = "btnLanjut"
        btnLanjut.Size = New Size(835, 50)
        btnLanjut.TabIndex = 11
        btnLanjut.Text = "Lanjut ke Pembayaran"
        btnLanjut.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoEllipsis = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Location = New Point(704, 373)
        Label1.Margin = New Padding(0)
        Label1.MaximumSize = New Size(0, 300)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 2)
        Label1.TabIndex = 12
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' FormPembayaran
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1083, 583)
        Controls.Add(Label1)
        Controls.Add(btnLanjut)
        Controls.Add(rbKredit)
        Controls.Add(rbOvo)
        Controls.Add(rbTransfer)
        Controls.Add(lblMetodeTitle)
        Controls.Add(lblHargaValues)
        Controls.Add(lblDetailHargaTitle)
        Controls.Add(lblMovieDetails)
        Controls.Add(picPoster)
        Controls.Add(lblRingkasanTitle)
        Controls.Add(lblTitle)
        Controls.Add(PanelLeft)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "FormPembayaran"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Konfirmasi Pembayaran"
        CType(picPoster, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
End Class