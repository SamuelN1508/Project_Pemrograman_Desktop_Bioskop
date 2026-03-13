<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jadwal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnpilih1 = New Button()
        lbljadwal = New Label()
        lbldetail = New Label()
        lbljam2 = New Label()
        lbljam3 = New Label()
        lbljam1 = New Label()
        btnpilih3 = New Button()
        btnpilih2 = New Button()
        lblharga1 = New Label()
        lblharga2 = New Label()
        lblharga3 = New Label()
        SuspendLayout()
        ' 
        ' btnpilih1
        ' 
        btnpilih1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnpilih1.Location = New Point(371, 99)
        btnpilih1.Name = "btnpilih1"
        btnpilih1.Size = New Size(109, 31)
        btnpilih1.TabIndex = 0
        btnpilih1.Text = "Pilih Waktu"
        btnpilih1.UseVisualStyleBackColor = True
        ' 
        ' lbljadwal
        ' 
        lbljadwal.AutoSize = True
        lbljadwal.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbljadwal.ForeColor = Color.RoyalBlue
        lbljadwal.Location = New Point(24, 24)
        lbljadwal.Name = "lbljadwal"
        lbljadwal.Size = New Size(168, 31)
        lbljadwal.TabIndex = 3
        lbljadwal.Text = "Jadwal Tayang"
        ' 
        ' lbldetail
        ' 
        lbldetail.AutoSize = True
        lbldetail.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbldetail.Location = New Point(35, 57)
        lbldetail.Name = "lbldetail"
        lbldetail.Size = New Size(157, 28)
        lbldetail.TabIndex = 4
        lbldetail.Text = "Detail Pesanan:"
        ' 
        ' lbljam2
        ' 
        lbljam2.AutoSize = True
        lbljam2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbljam2.Location = New Point(59, 169)
        lbljam2.Name = "lbljam2"
        lbljam2.Size = New Size(117, 28)
        lbljam2.TabIndex = 5
        lbljam2.Text = "Jam 16:30 - "
        ' 
        ' lbljam3
        ' 
        lbljam3.AutoSize = True
        lbljam3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbljam3.Location = New Point(59, 233)
        lbljam3.Name = "lbljam3"
        lbljam3.Size = New Size(117, 28)
        lbljam3.TabIndex = 6
        lbljam3.Text = "Jam 19:00 - "
        ' 
        ' lbljam1
        ' 
        lbljam1.AutoSize = True
        lbljam1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbljam1.Location = New Point(59, 102)
        lbljam1.Name = "lbljam1"
        lbljam1.Size = New Size(112, 28)
        lbljam1.TabIndex = 7
        lbljam1.Text = "Jam 14:00 -"
        ' 
        ' btnpilih3
        ' 
        btnpilih3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnpilih3.Location = New Point(371, 230)
        btnpilih3.Name = "btnpilih3"
        btnpilih3.Size = New Size(109, 31)
        btnpilih3.TabIndex = 8
        btnpilih3.Text = "Pilih Waktu"
        btnpilih3.UseVisualStyleBackColor = True
        ' 
        ' btnpilih2
        ' 
        btnpilih2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnpilih2.Location = New Point(371, 166)
        btnpilih2.Name = "btnpilih2"
        btnpilih2.Size = New Size(109, 31)
        btnpilih2.TabIndex = 9
        btnpilih2.Text = "Pilih Waktu"
        btnpilih2.UseVisualStyleBackColor = True
        ' 
        ' lblharga1
        ' 
        lblharga1.AutoSize = True
        lblharga1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblharga1.Location = New Point(177, 102)
        lblharga1.Name = "lblharga1"
        lblharga1.Size = New Size(100, 28)
        lblharga1.TabIndex = 10
        lblharga1.Text = "Rp 50.000"
        ' 
        ' lblharga2
        ' 
        lblharga2.AutoSize = True
        lblharga2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblharga2.Location = New Point(177, 169)
        lblharga2.Name = "lblharga2"
        lblharga2.Size = New Size(100, 28)
        lblharga2.TabIndex = 11
        lblharga2.Text = "Rp 50.000"
        ' 
        ' lblharga3
        ' 
        lblharga3.AutoSize = True
        lblharga3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblharga3.Location = New Point(177, 233)
        lblharga3.Name = "lblharga3"
        lblharga3.Size = New Size(100, 28)
        lblharga3.TabIndex = 12
        lblharga3.Text = "Rp 60.000"
        ' 
        ' Jadwal
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblharga3)
        Controls.Add(lblharga2)
        Controls.Add(lblharga1)
        Controls.Add(btnpilih2)
        Controls.Add(btnpilih3)
        Controls.Add(lbljam1)
        Controls.Add(lbljam3)
        Controls.Add(lbljam2)
        Controls.Add(lbldetail)
        Controls.Add(lbljadwal)
        Controls.Add(btnpilih1)
        Name = "Jadwal"
        Text = "Jadwal Tayang"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnpilih1 As Button
    Friend WithEvents lbljadwal As Label
    Friend WithEvents lbldetail As Label
    Friend WithEvents lbljam2 As Label
    Friend WithEvents lbljam3 As Label
    Friend WithEvents lbljam1 As Label
    Friend WithEvents btnpilih3 As Button
    Friend WithEvents btnpilih2 As Button
    Friend WithEvents lblharga1 As Label
    Friend WithEvents lblharga2 As Label
    Friend WithEvents lblharga3 As Label
End Class
