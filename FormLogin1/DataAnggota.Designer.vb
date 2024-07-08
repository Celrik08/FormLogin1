<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataAnggota
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
        BtnBack = New Button()
        BtnHapus = New Button()
        BtnUbah = New Button()
        BtnTambah = New Button()
        TextHp = New TextBox()
        TextAlamat = New TextBox()
        TextNama = New TextBox()
        TextAnggota = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Data_Anggota = New DataGridView()
        Anggota = New DataGridViewTextBoxColumn()
        Nama = New DataGridViewTextBoxColumn()
        Alamat = New DataGridViewTextBoxColumn()
        Hp = New DataGridViewTextBoxColumn()
        CType(Data_Anggota, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnBack
        ' 
        BtnBack.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnBack.Location = New Point(611, 207)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(112, 34)
        BtnBack.TabIndex = 48
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnHapus.Location = New Point(493, 207)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(112, 34)
        BtnHapus.TabIndex = 47
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' BtnUbah
        ' 
        BtnUbah.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnUbah.Location = New Point(611, 151)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(112, 34)
        BtnUbah.TabIndex = 46
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = True
        ' 
        ' BtnTambah
        ' 
        BtnTambah.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnTambah.Location = New Point(493, 151)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(112, 34)
        BtnTambah.TabIndex = 45
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = True
        ' 
        ' TextHp
        ' 
        TextHp.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextHp.Location = New Point(198, 204)
        TextHp.Name = "TextHp"
        TextHp.Size = New Size(150, 33)
        TextHp.TabIndex = 44
        ' 
        ' TextAlamat
        ' 
        TextAlamat.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextAlamat.Location = New Point(198, 165)
        TextAlamat.Name = "TextAlamat"
        TextAlamat.Size = New Size(150, 33)
        TextAlamat.TabIndex = 43
        ' 
        ' TextNama
        ' 
        TextNama.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextNama.Location = New Point(198, 126)
        TextNama.Name = "TextNama"
        TextNama.Size = New Size(150, 33)
        TextNama.TabIndex = 42
        ' 
        ' TextAnggota
        ' 
        TextAnggota.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextAnggota.Location = New Point(198, 87)
        TextAnggota.Name = "TextAnggota"
        TextAnggota.Size = New Size(150, 33)
        TextAnggota.TabIndex = 41
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(50, 207)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 25)
        Label8.TabIndex = 40
        Label8.Text = "No Hp"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(50, 168)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 25)
        Label9.TabIndex = 39
        Label9.Text = "Alamat"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(50, 129)
        Label10.Name = "Label10"
        Label10.Size = New Size(142, 25)
        Label10.TabIndex = 38
        Label10.Text = "Nama Anggota"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(50, 90)
        Label11.Name = "Label11"
        Label11.Size = New Size(107, 25)
        Label11.TabIndex = 37
        Label11.Text = "Id Anggota"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(383, 34)
        Label12.Name = "Label12"
        Label12.Size = New Size(152, 26)
        Label12.TabIndex = 36
        Label12.Text = "Data Anggota"
        ' 
        ' Data_Anggota
        ' 
        Data_Anggota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_Anggota.Columns.AddRange(New DataGridViewColumn() {Anggota, Nama, Alamat, Hp})
        Data_Anggota.Location = New Point(50, 289)
        Data_Anggota.Name = "Data_Anggota"
        Data_Anggota.RowHeadersWidth = 62
        Data_Anggota.RowTemplate.Height = 33
        Data_Anggota.Size = New Size(965, 354)
        Data_Anggota.TabIndex = 50
        ' 
        ' Anggota
        ' 
        Anggota.HeaderText = "Id Anggota"
        Anggota.MinimumWidth = 8
        Anggota.Name = "Anggota"
        Anggota.Width = 150
        ' 
        ' Nama
        ' 
        Nama.HeaderText = "Nama Anggota"
        Nama.MinimumWidth = 8
        Nama.Name = "Nama"
        Nama.Width = 150
        ' 
        ' Alamat
        ' 
        Alamat.HeaderText = "Alamat"
        Alamat.MinimumWidth = 8
        Alamat.Name = "Alamat"
        Alamat.Width = 150
        ' 
        ' Hp
        ' 
        Hp.HeaderText = "No Hp"
        Hp.MinimumWidth = 8
        Hp.Name = "Hp"
        Hp.Width = 150
        ' 
        ' DataAnggota
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1069, 684)
        Controls.Add(Data_Anggota)
        Controls.Add(BtnBack)
        Controls.Add(BtnHapus)
        Controls.Add(BtnUbah)
        Controls.Add(BtnTambah)
        Controls.Add(TextHp)
        Controls.Add(TextAlamat)
        Controls.Add(TextNama)
        Controls.Add(TextAnggota)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Name = "DataAnggota"
        Text = "DataAnggota"
        CType(Data_Anggota, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TextHp As TextBox
    Friend WithEvents TextAlamat As TextBox
    Friend WithEvents TextNama As TextBox
    Friend WithEvents TextAnggota As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Data_Anggota As DataGridView
    Friend WithEvents Anggota As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Alamat As DataGridViewTextBoxColumn
    Friend WithEvents Hp As DataGridViewTextBoxColumn
End Class
