<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Beranda
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        LblTitle = New Label()
        FlpMovies = New FlowLayoutPanel()
        PnlTop = New Panel()
        MenuStripUser = New MenuStrip()
        MenuAkun = New ToolStripMenuItem()
        MenuProfil = New ToolStripMenuItem()
        MenuHistory = New ToolStripMenuItem()
        MenuAbout = New ToolStripMenuItem()
        SepLogout = New ToolStripSeparator()
        MenuLogout = New ToolStripMenuItem()
        PnlSearch = New Panel()
        TxtCari = New TextBox()
        BtnCari = New Button()
        LblFilter = New Label()
        CmbGenre = New ComboBox()
        PnlTop.SuspendLayout()
        MenuStripUser.SuspendLayout()
        PnlSearch.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold)
        LblTitle.ForeColor = Color.FromArgb(45, 45, 45)
        LblTitle.Location = New Point(25, 20)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(224, 41)
        LblTitle.TabIndex = 0
        LblTitle.Text = "Sedang Tayang"
        ' 
        ' FlpMovies
        ' 
        FlpMovies.AutoScroll = True
        FlpMovies.BackColor = Color.FromArgb(245, 247, 250)
        FlpMovies.Dock = DockStyle.Fill
        FlpMovies.Location = New Point(0, 90)
        FlpMovies.Name = "FlpMovies"
        FlpMovies.Padding = New Padding(30, 20, 30, 20)
        FlpMovies.Size = New Size(1000, 610)
        FlpMovies.TabIndex = 1
        ' 
        ' PnlTop
        ' 
        PnlTop.BackColor = Color.White
        PnlTop.Controls.Add(MenuStripUser)
        PnlTop.Controls.Add(PnlSearch)
        PnlTop.Controls.Add(LblFilter)
        PnlTop.Controls.Add(CmbGenre)
        PnlTop.Controls.Add(LblTitle)
        PnlTop.Dock = DockStyle.Top
        PnlTop.Location = New Point(0, 0)
        PnlTop.Name = "PnlTop"
        PnlTop.Size = New Size(1000, 90)
        PnlTop.TabIndex = 0
        ' 
        ' MenuStripUser
        ' 
        MenuStripUser.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MenuStripUser.BackColor = Color.Transparent
        MenuStripUser.Dock = DockStyle.None
        MenuStripUser.ImageScalingSize = New Size(20, 20)
        MenuStripUser.Items.AddRange(New ToolStripItem() {MenuAkun})
        MenuStripUser.Location = New Point(860, 28)
        MenuStripUser.Name = "MenuStripUser"
        MenuStripUser.Size = New Size(116, 31)
        MenuStripUser.TabIndex = 5
        ' 
        ' MenuAkun
        ' 
        MenuAkun.BackColor = Color.FromArgb(235, 235, 235)
        MenuAkun.DropDownItems.AddRange(New ToolStripItem() {MenuProfil, MenuHistory, MenuAbout, SepLogout, MenuLogout})
        MenuAkun.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        MenuAkun.ForeColor = Color.FromArgb(64, 64, 64)
        MenuAkun.Margin = New Padding(0, 0, 10, 0)
        MenuAkun.Name = "MenuAkun"
        MenuAkun.Padding = New Padding(10, 4, 10, 4)
        MenuAkun.Size = New Size(108, 31)
        MenuAkun.Text = "Akun 👤"
        ' 
        ' MenuProfil
        ' 
        MenuProfil.Name = "MenuProfil"
        MenuProfil.Size = New Size(224, 28)
        MenuProfil.Text = "Profil Saya"
        ' 
        ' MenuHistory
        ' 
        MenuHistory.Name = "MenuHistory"
        MenuHistory.Size = New Size(224, 28)
        MenuHistory.Text = "Riwayat Tiket"
        ' 
        ' MenuAbout
        ' 
        MenuAbout.Name = "MenuAbout"
        MenuAbout.Size = New Size(224, 28)
        MenuAbout.Text = "Tentang Kami"
        ' 
        ' SepLogout
        ' 
        SepLogout.Name = "SepLogout"
        SepLogout.Size = New Size(221, 6)
        ' 
        ' MenuLogout
        ' 
        MenuLogout.ForeColor = Color.Crimson
        MenuLogout.Name = "MenuLogout"
        MenuLogout.Size = New Size(224, 28)
        MenuLogout.Text = "Logout"
        ' 
        ' PnlSearch
        ' 
        PnlSearch.BackColor = Color.FromArgb(240, 240, 240)
        PnlSearch.Controls.Add(TxtCari)
        PnlSearch.Controls.Add(BtnCari)
        PnlSearch.Location = New Point(270, 25)
        PnlSearch.Name = "PnlSearch"
        PnlSearch.Size = New Size(300, 36)
        PnlSearch.TabIndex = 1
        ' 
        ' TxtCari
        ' 
        TxtCari.BackColor = Color.FromArgb(240, 240, 240)
        TxtCari.BorderStyle = BorderStyle.None
        TxtCari.Font = New Font("Segoe UI", 10.0F)
        TxtCari.Location = New Point(10, 7)
        TxtCari.Name = "TxtCari"
        TxtCari.PlaceholderText = "Cari film favorit..."
        TxtCari.Size = New Size(215, 23)
        TxtCari.TabIndex = 1
        ' 
        ' BtnCari
        ' 
        BtnCari.BackColor = Color.FromArgb(0, 150, 136)
        BtnCari.Cursor = Cursors.Hand
        BtnCari.Dock = DockStyle.Right
        BtnCari.FlatAppearance.BorderSize = 0
        BtnCari.FlatStyle = FlatStyle.Flat
        BtnCari.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        BtnCari.ForeColor = Color.White
        BtnCari.Location = New Point(230, 0)
        BtnCari.Name = "BtnCari"
        BtnCari.Size = New Size(70, 36)
        BtnCari.TabIndex = 2
        BtnCari.Text = "Cari"
        BtnCari.UseVisualStyleBackColor = False
        ' 
        ' LblFilter
        ' 
        LblFilter.AutoSize = True
        LblFilter.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        LblFilter.ForeColor = Color.Gray
        LblFilter.Location = New Point(590, 33)
        LblFilter.Name = "LblFilter"
        LblFilter.Size = New Size(51, 20)
        LblFilter.TabIndex = 3
        LblFilter.Text = "Genre:"
        ' 
        ' CmbGenre
        ' 
        CmbGenre.BackColor = Color.White
        CmbGenre.DropDownStyle = ComboBoxStyle.DropDownList
        CmbGenre.FlatStyle = FlatStyle.Flat
        CmbGenre.Font = New Font("Segoe UI", 10.0F)
        CmbGenre.FormattingEnabled = True
        CmbGenre.Items.AddRange(New Object() {"Semua", "Action", "Horror", "Drama", "Sci-Fi"})
        CmbGenre.Location = New Point(647, 28)
        CmbGenre.Name = "CmbGenre"
        CmbGenre.Size = New Size(140, 31)
        CmbGenre.TabIndex = 4
        ' 
        ' Beranda
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1000, 700)
        Controls.Add(FlpMovies)
        Controls.Add(PnlTop)
        MainMenuStrip = MenuStripUser
        Name = "Beranda"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CinemaHub - Dashboard"
        PnlTop.ResumeLayout(False)
        PnlTop.PerformLayout()
        MenuStripUser.ResumeLayout(False)
        MenuStripUser.PerformLayout()
        PnlSearch.ResumeLayout(False)
        PnlSearch.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PnlTop As Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents PnlSearch As Panel
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents BtnCari As Button
    Friend WithEvents LblFilter As Label
    Friend WithEvents CmbGenre As ComboBox
    Friend WithEvents FlpMovies As FlowLayoutPanel
    Friend WithEvents MenuStripUser As MenuStrip
    Friend WithEvents MenuAkun As ToolStripMenuItem
    Friend WithEvents MenuProfil As ToolStripMenuItem
    Friend WithEvents MenuHistory As ToolStripMenuItem
    Friend WithEvents MenuAbout As ToolStripMenuItem
    Friend WithEvents SepLogout As ToolStripSeparator
    Friend WithEvents MenuLogout As ToolStripMenuItem
End Class