<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RiwayatTiket
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PnlHeader = New Panel()
        LblTitle = New Label()
        PnlBody = New Panel()
        BtnKembali = New Button()
        LblKosong = New Label()
        DgvRiwayat = New DataGridView()
        PnlHeader.SuspendLayout()
        PnlBody.SuspendLayout()
        CType(DgvRiwayat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlHeader
        ' 
        PnlHeader.BackColor = Color.Teal
        PnlHeader.Controls.Add(LblTitle)
        PnlHeader.Dock = DockStyle.Top
        PnlHeader.Location = New Point(0, 0)
        PnlHeader.Name = "PnlHeader"
        PnlHeader.Size = New Size(686, 60)
        PnlHeader.TabIndex = 1
        ' 
        ' LblTitle
        ' 
        LblTitle.Dock = DockStyle.Fill
        LblTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LblTitle.ForeColor = Color.White
        LblTitle.Location = New Point(0, 0)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(686, 60)
        LblTitle.TabIndex = 0
        LblTitle.Text = "Riwayat Tiket"
        LblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PnlBody
        ' 
        PnlBody.Controls.Add(BtnKembali)
        PnlBody.Controls.Add(LblKosong)
        PnlBody.Controls.Add(DgvRiwayat)
        PnlBody.Dock = DockStyle.Fill
        PnlBody.Location = New Point(0, 60)
        PnlBody.Name = "PnlBody"
        PnlBody.Padding = New Padding(20)
        PnlBody.Size = New Size(686, 418)
        PnlBody.TabIndex = 0
        ' 
        ' BtnKembali
        ' 
        BtnKembali.BackColor = Color.Teal
        BtnKembali.Cursor = Cursors.Hand
        BtnKembali.FlatAppearance.BorderSize = 0
        BtnKembali.FlatStyle = FlatStyle.Flat
        BtnKembali.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        BtnKembali.ForeColor = Color.White
        BtnKembali.Location = New Point(20, 360)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(640, 40)
        BtnKembali.TabIndex = 0
        BtnKembali.Text = "Kembali"
        BtnKembali.UseVisualStyleBackColor = False
        ' 
        ' LblKosong
        ' 
        LblKosong.Font = New Font("Segoe UI", 10.0F)
        LblKosong.ForeColor = Color.Gray
        LblKosong.Location = New Point(19, 143)
        LblKosong.Name = "LblKosong"
        LblKosong.Size = New Size(640, 25)
        LblKosong.TabIndex = 1
        LblKosong.Text = "Belum ada riwayat pemesanan tiket."
        LblKosong.TextAlign = ContentAlignment.MiddleCenter
        LblKosong.Visible = False
        ' 
        ' DgvRiwayat
        ' 
        DgvRiwayat.AllowUserToAddRows = False
        DgvRiwayat.BackgroundColor = Color.White
        DgvRiwayat.ColumnHeadersHeight = 29
        DgvRiwayat.Font = New Font("Segoe UI", 9.0F)
        DgvRiwayat.Location = New Point(20, 20)
        DgvRiwayat.Name = "DgvRiwayat"
        DgvRiwayat.ReadOnly = True
        DgvRiwayat.RowHeadersVisible = False
        DgvRiwayat.RowHeadersWidth = 51
        DgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvRiwayat.Size = New Size(640, 320)
        DgvRiwayat.TabIndex = 2
        ' 
        ' RiwayatTiket
        ' 
        BackColor = Color.White
        ClientSize = New Size(686, 478)
        Controls.Add(PnlBody)
        Controls.Add(PnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "RiwayatTiket"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Riwayat Tiket"
        PnlHeader.ResumeLayout(False)
        PnlBody.ResumeLayout(False)
        CType(DgvRiwayat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents PnlBody As System.Windows.Forms.Panel
    Friend WithEvents DgvRiwayat As System.Windows.Forms.DataGridView
    Friend WithEvents LblKosong As System.Windows.Forms.Label
    Friend WithEvents BtnKembali As System.Windows.Forms.Button

End Class