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
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblScanTop = New System.Windows.Forms.Label()
        Me.picQR = New System.Windows.Forms.PictureBox()
        Me.lblScanBottom = New System.Windows.Forms.Label()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.picPoster = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSummary.SuspendLayout()
        CType(Me.picPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.LightGray
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(130, 420)
        Me.PanelLeft.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(150, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(269, 25)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Halaman E-Ticket & Kode QR"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.Location = New System.Drawing.Point(150, 55)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(287, 21)
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Terima kasih atas Pemesanan Anda!"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(151, 85)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(117, 15)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Status Tiket: ISSUED"
        '
        'lblScanTop
        '
        Me.lblScanTop.AutoSize = True
        Me.lblScanTop.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScanTop.Location = New System.Drawing.Point(151, 105)
        Me.lblScanTop.Name = "lblScanTop"
        Me.lblScanTop.Size = New System.Drawing.Size(120, 15)
        Me.lblScanTop.TabIndex = 4
        Me.lblScanTop.Text = "Pindai Kode QR Anda"
        '
        'picQR
        '
        Me.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picQR.Location = New System.Drawing.Point(180, 135)
        Me.picQR.Name = "picQR"
        Me.picQR.Size = New System.Drawing.Size(180, 180)
        Me.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQR.TabIndex = 5
        Me.picQR.TabStop = False
        '
        'lblScanBottom
        '
        Me.lblScanBottom.AutoSize = True
        Me.lblScanBottom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScanBottom.Location = New System.Drawing.Point(210, 325)
        Me.lblScanBottom.Name = "lblScanBottom"
        Me.lblScanBottom.Size = New System.Drawing.Size(126, 15)
        Me.lblScanBottom.TabIndex = 6
        Me.lblScanBottom.Text = "Pindai Kode QR Anda"
        '
        'grpSummary
        '
        Me.grpSummary.BackColor = System.Drawing.Color.LightGray
        Me.grpSummary.Controls.Add(Me.lblDetails)
        Me.grpSummary.Controls.Add(Me.picPoster)
        Me.grpSummary.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSummary.Location = New System.Drawing.Point(400, 135)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Size = New System.Drawing.Size(230, 120)
        Me.grpSummary.TabIndex = 7
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Tiket Summary"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(85, 25)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(89, 65)
        Me.lblDetails.TabIndex = 1
        Me.lblDetails.Text = "The Film" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "01 Okt 11:30" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Studio 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kursi F12, F13"
        '
        'picPoster
        '
        Me.picPoster.BackColor = System.Drawing.Color.DarkGray
        Me.picPoster.Location = New System.Drawing.Point(15, 25)
        Me.picPoster.Name = "picPoster"
        Me.picPoster.Size = New System.Drawing.Size(60, 80)
        Me.picPoster.TabIndex = 0
        Me.picPoster.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.CadetBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(400, 270)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(230, 35)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Simpan ke Memori Perangkat"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(400, 315)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(230, 35)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Keluar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(660, 420)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.lblScanBottom)
        Me.Controls.Add(Me.picQR)
        Me.Controls.Add(Me.lblScanTop)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PanelLeft)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "E-Ticket & Kode QR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Halaman E-Ticket & Kode QR"
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSummary.ResumeLayout(False)
        Me.grpSummary.PerformLayout()
        CType(Me.picPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class