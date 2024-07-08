<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBuku
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBuku = New TextBox()
        TextJudul = New TextBox()
        TextTahun = New TextBox()
        TextPenulis = New TextBox()
        BtnTambah = New Button()
        BtnUbah = New Button()
        BtnHapus = New Button()
        BtnBack = New Button()
        Data_Buku = New DataGridView()
        Buku = New DataGridViewTextBoxColumn()
        Judul = New DataGridViewTextBoxColumn()
        Tahun = New DataGridViewTextBoxColumn()
        Penulis = New DataGridViewTextBoxColumn()
        Penerbit = New DataGridViewTextBoxColumn()
        Stock = New DataGridViewTextBoxColumn()
        TextPenerbit = New TextBox()
        Label6 = New Label()
        TextStock = New TextBox()
        Label7 = New Label()
        CType(Data_Buku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(382, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 26)
        Label1.TabIndex = 0
        Label1.Text = "Data Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(49, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 25)
        Label2.TabIndex = 1
        Label2.Text = "Id Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(49, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 25)
        Label3.TabIndex = 2
        Label3.Text = "Judul Buku"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(49, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 25)
        Label4.TabIndex = 3
        Label4.Text = "Tahun Terbit"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(49, 212)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 25)
        Label5.TabIndex = 5
        Label5.Text = "Penulis"
        ' 
        ' TextBuku
        ' 
        TextBuku.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBuku.Location = New Point(197, 92)
        TextBuku.Name = "TextBuku"
        TextBuku.Size = New Size(150, 33)
        TextBuku.TabIndex = 7
        ' 
        ' TextJudul
        ' 
        TextJudul.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextJudul.Location = New Point(197, 131)
        TextJudul.Name = "TextJudul"
        TextJudul.Size = New Size(150, 33)
        TextJudul.TabIndex = 8
        ' 
        ' TextTahun
        ' 
        TextTahun.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextTahun.Location = New Point(197, 170)
        TextTahun.Name = "TextTahun"
        TextTahun.Size = New Size(150, 33)
        TextTahun.TabIndex = 9
        ' 
        ' TextPenulis
        ' 
        TextPenulis.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextPenulis.Location = New Point(197, 209)
        TextPenulis.Name = "TextPenulis"
        TextPenulis.Size = New Size(150, 33)
        TextPenulis.TabIndex = 10
        ' 
        ' BtnTambah
        ' 
        BtnTambah.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnTambah.Location = New Point(492, 156)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(112, 34)
        BtnTambah.TabIndex = 13
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = True
        ' 
        ' BtnUbah
        ' 
        BtnUbah.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnUbah.Location = New Point(610, 156)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(112, 34)
        BtnUbah.TabIndex = 14
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = True
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnHapus.Location = New Point(492, 212)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(112, 34)
        BtnHapus.TabIndex = 15
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' BtnBack
        ' 
        BtnBack.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnBack.Location = New Point(610, 212)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(112, 34)
        BtnBack.TabIndex = 16
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' Data_Buku
        ' 
        Data_Buku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_Buku.Columns.AddRange(New DataGridViewColumn() {Buku, Judul, Tahun, Penulis, Penerbit, Stock})
        Data_Buku.Location = New Point(49, 376)
        Data_Buku.Name = "Data_Buku"
        Data_Buku.RowHeadersWidth = 62
        Data_Buku.RowTemplate.Height = 33
        Data_Buku.Size = New Size(965, 354)
        Data_Buku.TabIndex = 50
        ' 
        ' Buku
        ' 
        Buku.HeaderText = "Id Buku"
        Buku.MinimumWidth = 8
        Buku.Name = "Buku"
        Buku.Width = 150
        ' 
        ' Judul
        ' 
        Judul.HeaderText = "Judul Buku"
        Judul.MinimumWidth = 8
        Judul.Name = "Judul"
        Judul.Width = 150
        ' 
        ' Tahun
        ' 
        Tahun.HeaderText = "Tahun Terbit"
        Tahun.MinimumWidth = 8
        Tahun.Name = "Tahun"
        Tahun.Width = 150
        ' 
        ' Penulis
        ' 
        Penulis.HeaderText = "Penulis"
        Penulis.MinimumWidth = 8
        Penulis.Name = "Penulis"
        Penulis.Width = 150
        ' 
        ' Penerbit
        ' 
        Penerbit.HeaderText = "Penerbit"
        Penerbit.MinimumWidth = 8
        Penerbit.Name = "Penerbit"
        Penerbit.Width = 150
        ' 
        ' Stock
        ' 
        Stock.HeaderText = "Stock"
        Stock.MinimumWidth = 8
        Stock.Name = "Stock"
        Stock.Width = 150
        ' 
        ' TextPenerbit
        ' 
        TextPenerbit.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextPenerbit.Location = New Point(197, 248)
        TextPenerbit.Name = "TextPenerbit"
        TextPenerbit.Size = New Size(150, 33)
        TextPenerbit.TabIndex = 52
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(49, 251)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 25)
        Label6.TabIndex = 51
        Label6.Text = "Penerbit"
        ' 
        ' TextStock
        ' 
        TextStock.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextStock.Location = New Point(197, 287)
        TextStock.Name = "TextStock"
        TextStock.Size = New Size(150, 33)
        TextStock.TabIndex = 54
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(49, 290)
        Label7.Name = "Label7"
        Label7.Size = New Size(62, 25)
        Label7.TabIndex = 53
        Label7.Text = "Stock"
        ' 
        ' DataBuku
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 769)
        Controls.Add(TextStock)
        Controls.Add(Label7)
        Controls.Add(TextPenerbit)
        Controls.Add(Label6)
        Controls.Add(Data_Buku)
        Controls.Add(BtnBack)
        Controls.Add(BtnHapus)
        Controls.Add(BtnUbah)
        Controls.Add(BtnTambah)
        Controls.Add(TextPenulis)
        Controls.Add(TextTahun)
        Controls.Add(TextJudul)
        Controls.Add(TextBuku)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "DataBuku"
        Text = "DataBuku"
        CType(Data_Buku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBuku As TextBox
    Friend WithEvents TextJudul As TextBox
    Friend WithEvents TextTahun As TextBox
    Friend WithEvents TextPenulis As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Data_Buku As DataGridView
    Friend WithEvents TextPenerbit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextStock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Buku As DataGridViewTextBoxColumn
    Friend WithEvents Judul As DataGridViewTextBoxColumn
    Friend WithEvents Tahun As DataGridViewTextBoxColumn
    Friend WithEvents Penulis As DataGridViewTextBoxColumn
    Friend WithEvents Penerbit As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
End Class
