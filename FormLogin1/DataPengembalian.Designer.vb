<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPengembalian
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
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
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
        CType(Data_Peminjaman, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker2.Location = New Point(210, 198)
        DateTimePicker2.Margin = New Padding(2, 2, 2, 2)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(266, 29)
        DateTimePicker2.TabIndex = 87
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(210, 168)
        DateTimePicker1.Margin = New Padding(2, 2, 2, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(266, 29)
        DateTimePicker1.TabIndex = 86
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(40, 202)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(175, 21)
        Label6.TabIndex = 85
        Label6.Text = "Tanggal Pengembalian"
        ' 
        ' Data_Peminjaman
        ' 
        Data_Peminjaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_Peminjaman.Columns.AddRange(New DataGridViewColumn() {Peminjaman, Nama, Judul, Pinjam, Pengembalian})
        Data_Peminjaman.Location = New Point(40, 261)
        Data_Peminjaman.Margin = New Padding(2, 2, 2, 2)
        Data_Peminjaman.Name = "Data_Peminjaman"
        Data_Peminjaman.RowHeadersWidth = 62
        Data_Peminjaman.RowTemplate.Height = 33
        Data_Peminjaman.Size = New Size(772, 283)
        Data_Peminjaman.TabIndex = 84
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
        BtnBack.Location = New Point(693, 172)
        BtnBack.Margin = New Padding(2, 2, 2, 2)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(90, 27)
        BtnBack.TabIndex = 83
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnHapus.Location = New Point(598, 172)
        BtnHapus.Margin = New Padding(2, 2, 2, 2)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(90, 27)
        BtnHapus.TabIndex = 82
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' BtnUbah
        ' 
        BtnUbah.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnUbah.Location = New Point(693, 127)
        BtnUbah.Margin = New Padding(2, 2, 2, 2)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(90, 27)
        BtnUbah.TabIndex = 81
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = True
        ' 
        ' BtnTambah
        ' 
        BtnTambah.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnTambah.Location = New Point(598, 127)
        BtnTambah.Margin = New Padding(2, 2, 2, 2)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(90, 27)
        BtnTambah.TabIndex = 80
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = True
        ' 
        ' TextJudul
        ' 
        TextJudul.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextJudul.Location = New Point(210, 137)
        TextJudul.Margin = New Padding(2, 2, 2, 2)
        TextJudul.Name = "TextJudul"
        TextJudul.Size = New Size(266, 29)
        TextJudul.TabIndex = 79
        ' 
        ' TextNama
        ' 
        TextNama.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextNama.Location = New Point(210, 106)
        TextNama.Margin = New Padding(2, 2, 2, 2)
        TextNama.Name = "TextNama"
        TextNama.Size = New Size(266, 29)
        TextNama.TabIndex = 78
        ' 
        ' TextPeminjaman
        ' 
        TextPeminjaman.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextPeminjaman.Location = New Point(210, 74)
        TextPeminjaman.Margin = New Padding(2, 2, 2, 2)
        TextPeminjaman.Name = "TextPeminjaman"
        TextPeminjaman.Size = New Size(266, 29)
        TextPeminjaman.TabIndex = 77
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(40, 172)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 21)
        Label5.TabIndex = 76
        Label5.Text = "Tanggal Pinjam"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(40, 139)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 21)
        Label4.TabIndex = 75
        Label4.Text = "Judul Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(40, 108)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 21)
        Label3.TabIndex = 74
        Label3.Text = "Nama Peminjam"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(40, 77)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 21)
        Label2.TabIndex = 73
        Label2.Text = "Id Peminjaman"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(322, 27)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 23)
        Label1.TabIndex = 72
        Label1.Text = "Data Pengembalian"
        ' 
        ' DataPengembalian
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(852, 578)
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
        Margin = New Padding(2, 2, 2, 2)
        Name = "DataPengembalian"
        Text = "DataPengembalian"
        CType(Data_Peminjaman, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Data_Peminjaman As DataGridView
    Friend WithEvents Peminjaman As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Judul As DataGridViewTextBoxColumn
    Friend WithEvents Pinjam As DataGridViewTextBoxColumn
    Friend WithEvents Pengembalian As DataGridViewTextBoxColumn
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
End Class
