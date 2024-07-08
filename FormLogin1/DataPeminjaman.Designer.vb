<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPeminjaman
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
        Label6 = New Label()
        Data_Peminjaman = New DataGridView()
        Peminjaman = New DataGridViewTextBoxColumn()
        Nama = New DataGridViewTextBoxColumn()
        Judul = New DataGridViewTextBoxColumn()
        Pinjam = New DataGridViewTextBoxColumn()
        Pengembalian = New DataGridViewTextBoxColumn()
        BtnBack = New Button()
        BtnHapus = New Button()
        BtnUbah = New Button()
        BtnTambah = New Button()
        TextJudul = New TextBox()
        TextNama = New TextBox()
        TextPeminjaman = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        CType(Data_Peminjaman, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(63, 244)
        Label6.Name = "Label6"
        Label6.Size = New Size(207, 25)
        Label6.TabIndex = 69
        Label6.Text = "Tanggal Pengembalian"
        ' 
        ' Data_Peminjaman
        ' 
        Data_Peminjaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_Peminjaman.Columns.AddRange(New DataGridViewColumn() {Peminjaman, Nama, Judul, Pinjam, Pengembalian})
        Data_Peminjaman.Location = New Point(63, 318)
        Data_Peminjaman.Name = "Data_Peminjaman"
        Data_Peminjaman.RowHeadersWidth = 62
        Data_Peminjaman.RowTemplate.Height = 33
        Data_Peminjaman.Size = New Size(965, 354)
        Data_Peminjaman.TabIndex = 68
        ' 
        ' Peminjaman
        ' 
        Peminjaman.HeaderText = "Id Peminjaman"
        Peminjaman.MinimumWidth = 8
        Peminjaman.Name = "Peminjaman"
        Peminjaman.Width = 150
        ' 
        ' Nama
        ' 
        Nama.HeaderText = "Nama Peminjam"
        Nama.MinimumWidth = 8
        Nama.Name = "Nama"
        Nama.Width = 150
        ' 
        ' Judul
        ' 
        Judul.HeaderText = "Judul Buku"
        Judul.MinimumWidth = 8
        Judul.Name = "Judul"
        Judul.Width = 150
        ' 
        ' Pinjam
        ' 
        Pinjam.HeaderText = "Tanggal Pinjam"
        Pinjam.MinimumWidth = 8
        Pinjam.Name = "Pinjam"
        Pinjam.Width = 150
        ' 
        ' Pengembalian
        ' 
        Pengembalian.HeaderText = "Tanggal Pengembalian"
        Pengembalian.MinimumWidth = 8
        Pengembalian.Name = "Pengembalian"
        Pengembalian.Width = 150
        ' 
        ' BtnBack
        ' 
        BtnBack.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnBack.Location = New Point(832, 198)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(112, 34)
        BtnBack.TabIndex = 67
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnHapus.Location = New Point(714, 198)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(112, 34)
        BtnHapus.TabIndex = 66
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' BtnUbah
        ' 
        BtnUbah.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnUbah.Location = New Point(832, 142)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(112, 34)
        BtnUbah.TabIndex = 65
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = True
        ' 
        ' BtnTambah
        ' 
        BtnTambah.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnTambah.Location = New Point(714, 142)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(112, 34)
        BtnTambah.TabIndex = 64
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = True
        ' 
        ' TextJudul
        ' 
        TextJudul.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextJudul.Location = New Point(276, 163)
        TextJudul.Name = "TextJudul"
        TextJudul.Size = New Size(316, 33)
        TextJudul.TabIndex = 62
        ' 
        ' TextNama
        ' 
        TextNama.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextNama.Location = New Point(276, 124)
        TextNama.Name = "TextNama"
        TextNama.Size = New Size(316, 33)
        TextNama.TabIndex = 61
        ' 
        ' TextPeminjaman
        ' 
        TextPeminjaman.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextPeminjaman.Location = New Point(276, 85)
        TextPeminjaman.Name = "TextPeminjaman"
        TextPeminjaman.Size = New Size(316, 33)
        TextPeminjaman.TabIndex = 60
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(63, 207)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 25)
        Label5.TabIndex = 59
        Label5.Text = "Tanggal Pinjam"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(63, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 25)
        Label4.TabIndex = 58
        Label4.Text = "Judul Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(63, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 25)
        Label3.TabIndex = 57
        Label3.Text = "Nama Peminjam"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(63, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 25)
        Label2.TabIndex = 56
        Label2.Text = "Id Peminjaman"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(396, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 26)
        Label1.TabIndex = 55
        Label1.Text = "Data Peminjaman"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(276, 202)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(316, 33)
        DateTimePicker1.TabIndex = 70
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker2.Location = New Point(276, 239)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(316, 33)
        DateTimePicker2.TabIndex = 71
        ' 
        ' DataPeminjaman
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1096, 729)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label6)
        Controls.Add(Data_Peminjaman)
        Controls.Add(BtnBack)
        Controls.Add(BtnHapus)
        Controls.Add(BtnUbah)
        Controls.Add(BtnTambah)
        Controls.Add(TextJudul)
        Controls.Add(TextNama)
        Controls.Add(TextPeminjaman)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "DataPeminjaman"
        Text = "DataPeminjaman"
        CType(Data_Peminjaman, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Data_Peminjaman As DataGridView
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TextJudul As TextBox
    Friend WithEvents TextNama As TextBox
    Friend WithEvents TextPeminjaman As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Peminjaman As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Judul As DataGridViewTextBoxColumn
    Friend WithEvents Pinjam As DataGridViewTextBoxColumn
    Friend WithEvents Pengembalian As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
