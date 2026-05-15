<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_Ticket___Kode_QR
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
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblScanTop As System.Windows.Forms.Label
    Friend WithEvents picQR As System.Windows.Forms.PictureBox
    Friend WithEvents lblScanBottom As System.Windows.Forms.Label
    Friend WithEvents grpSummary As System.Windows.Forms.GroupBox
    Friend WithEvents picPoster As System.Windows.Forms.PictureBox
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelLeft = New Panel()
        lblTitle = New Label()
        lblSubtitle = New Label()
        lblStatus = New Label()
        lblScanTop = New Label()
        picQR = New PictureBox()
        lblScanBottom = New Label()
        grpSummary = New GroupBox()
        lblDetails = New Label()
        picPoster = New PictureBox()
        btnSave = New Button()
        btnCancel = New Button()
        CType(picQR, ComponentModel.ISupportInitialize).BeginInit()
        grpSummary.SuspendLayout()
        CType(picPoster, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = Color.LightGray
        PanelLeft.Dock = DockStyle.Left
        PanelLeft.Location = New Point(0, 0)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(130, 420)
        PanelLeft.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(150, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(377, 38)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Halaman E-Ticket & Kode QR"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubtitle.Location = New Point(150, 55)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(420, 32)
        lblSubtitle.TabIndex = 2
        lblSubtitle.Text = "Terima kasih atas Pemesanan Anda!"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(151, 85)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(170, 25)
        lblStatus.TabIndex = 3
        lblStatus.Text = "Status Tiket: ISSUED"
        ' 
        ' lblScanTop
        ' 
        lblScanTop.AutoSize = True
        lblScanTop.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblScanTop.Location = New Point(151, 105)
        lblScanTop.Name = "lblScanTop"
        lblScanTop.Size = New Size(183, 25)
        lblScanTop.TabIndex = 4
        lblScanTop.Text = "Pindai Kode QR Anda"
        ' 
        ' picQR
        ' 
        picQR.BorderStyle = BorderStyle.FixedSingle
        picQR.Location = New Point(180, 135)
        picQR.Name = "picQR"
        picQR.Size = New Size(180, 180)
        picQR.SizeMode = PictureBoxSizeMode.Zoom
        picQR.TabIndex = 5
        picQR.TabStop = False
        ' 
        ' lblScanBottom
        ' 
        lblScanBottom.AutoSize = True
        lblScanBottom.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScanBottom.Location = New Point(210, 325)
        lblScanBottom.Name = "lblScanBottom"
        lblScanBottom.Size = New Size(195, 25)
        lblScanBottom.TabIndex = 6
        lblScanBottom.Text = "Pindai Kode QR Anda"
        ' 
        ' grpSummary
        ' 
        grpSummary.BackColor = Color.LightGray
        grpSummary.Controls.Add(lblDetails)
        grpSummary.Controls.Add(picPoster)
        grpSummary.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpSummary.Location = New Point(400, 135)
        grpSummary.Name = "grpSummary"
        grpSummary.Size = New Size(230, 120)
        grpSummary.TabIndex = 7
        grpSummary.TabStop = False
        grpSummary.Text = "Tiket Summary"
        ' 
        ' lblDetails
        ' 
        lblDetails.AutoSize = True
        lblDetails.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDetails.Location = New Point(85, 25)
        lblDetails.Name = "lblDetails"
        lblDetails.Size = New Size(113, 92)
        lblDetails.TabIndex = 1
        lblDetails.Text = "The Film" & vbCrLf & "01 Okt 11:30" & vbCrLf & "Studio 1" & vbCrLf & "Kursi F12, F13"
        ' 
        ' picPoster
        ' 
        picPoster.BackColor = Color.DarkGray
        picPoster.Location = New Point(15, 25)
        picPoster.Name = "picPoster"
        picPoster.Size = New Size(60, 80)
        picPoster.TabIndex = 0
        picPoster.TabStop = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.CadetBlue
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(400, 270)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(230, 35)
        btnSave.TabIndex = 8
        btnSave.Text = "Simpan ke Memori Perangkat"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Gray
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(400, 315)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(230, 35)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Keluar"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' E_Ticket___Kode_QR
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(660, 420)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(grpSummary)
        Controls.Add(lblScanBottom)
        Controls.Add(picQR)
        Controls.Add(lblScanTop)
        Controls.Add(lblStatus)
        Controls.Add(lblSubtitle)
        Controls.Add(lblTitle)
        Controls.Add(PanelLeft)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "E_Ticket___Kode_QR"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Halaman E-Ticket & Kode QR"
        CType(picQR, ComponentModel.ISupportInitialize).EndInit()
        grpSummary.ResumeLayout(False)
        grpSummary.PerformLayout()
        CType(picPoster, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
End Class