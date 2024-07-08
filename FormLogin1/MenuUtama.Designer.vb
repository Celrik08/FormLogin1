<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MainMenu = New MenuStrip()
        DataMaster = New ToolStripMenuItem()
        DataAnggota = New ToolStripMenuItem()
        DataBuku = New ToolStripMenuItem()
        DataUser = New ToolStripMenuItem()
        Transaksi = New ToolStripMenuItem()
        Peminjaman = New ToolStripMenuItem()
        Pengembalian = New ToolStripMenuItem()
        Back = New ToolStripMenuItem()
        Label1 = New Label()
        User = New Label()
        Label3 = New Label()
        MainMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainMenu
        ' 
        MainMenu.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        MainMenu.ImageScalingSize = New Size(24, 24)
        MainMenu.Items.AddRange(New ToolStripItem() {DataMaster, Transaksi, Back})
        MainMenu.Location = New Point(0, 0)
        MainMenu.Name = "MainMenu"
        MainMenu.Padding = New Padding(5, 2, 0, 2)
        MainMenu.Size = New Size(430, 29)
        MainMenu.TabIndex = 0
        MainMenu.Text = "MenuStrip1"
        ' 
        ' DataMaster
        ' 
        DataMaster.DropDownItems.AddRange(New ToolStripItem() {DataAnggota, DataBuku, DataUser})
        DataMaster.Name = "DataMaster"
        DataMaster.Size = New Size(114, 25)
        DataMaster.Text = "Data Master"
        ' 
        ' DataAnggota
        ' 
        DataAnggota.Name = "DataAnggota"
        DataAnggota.Size = New Size(224, 26)
        DataAnggota.Text = "Data Anggota"
        ' 
        ' DataBuku
        ' 
        DataBuku.Name = "DataBuku"
        DataBuku.Size = New Size(224, 26)
        DataBuku.Text = "Data Buku"
        ' 
        ' DataUser
        ' 
        DataUser.Name = "DataUser"
        DataUser.Size = New Size(224, 26)
        DataUser.Text = "Data User"
        ' 
        ' Transaksi
        ' 
        Transaksi.DropDownItems.AddRange(New ToolStripItem() {Peminjaman, Pengembalian})
        Transaksi.Name = "Transaksi"
        Transaksi.Size = New Size(95, 25)
        Transaksi.Text = "Transaksi"
        ' 
        ' Peminjaman
        ' 
        Peminjaman.Name = "Peminjaman"
        Peminjaman.Size = New Size(224, 26)
        Peminjaman.Text = "Peminjaman"
        ' 
        ' Pengembalian
        ' 
        Pengembalian.Name = "Pengembalian"
        Pengembalian.Size = New Size(224, 26)
        Pengembalian.Text = "Pengembalian"
        ' 
        ' Back
        ' 
        Back.Name = "Back"
        Back.Size = New Size(62, 25)
        Back.Text = "Back"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(151, 120)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 21)
        Label1.TabIndex = 1
        Label1.Text = "Selamat Datang"
        ' 
        ' User
        ' 
        User.AutoSize = True
        User.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        User.Location = New Point(151, 160)
        User.Margin = New Padding(2, 0, 2, 0)
        User.Name = "User"
        User.Size = New Size(140, 21)
        User.TabIndex = 2
        User.Text = "_____________"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(151, 41)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 23)
        Label3.TabIndex = 3
        Label3.Text = "MenuUtama"
        ' 
        ' MenuUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(430, 297)
        Controls.Add(Label3)
        Controls.Add(User)
        Controls.Add(Label1)
        Controls.Add(MainMenu)
        MainMenuStrip = MainMenu
        Margin = New Padding(2, 2, 2, 2)
        Name = "MenuUtama"
        Text = "MenuUtama"
        MainMenu.ResumeLayout(False)
        MainMenu.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents DataMaster As ToolStripMenuItem
    Friend WithEvents Transaksi As ToolStripMenuItem
    Friend WithEvents Back As ToolStripMenuItem
    Friend WithEvents DataAnggota As ToolStripMenuItem
    Friend WithEvents DataBuku As ToolStripMenuItem
    Friend WithEvents DataUser As ToolStripMenuItem
    Friend WithEvents Peminjaman As ToolStripMenuItem
    Friend WithEvents Pengembalian As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents User As Label
    Friend WithEvents Label3 As Label
End Class
