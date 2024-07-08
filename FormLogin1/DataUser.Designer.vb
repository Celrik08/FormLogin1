<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataUser
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
        Data_User = New DataGridView()
        User = New DataGridViewTextBoxColumn()
        Pass = New DataGridViewTextBoxColumn()
        Lev = New DataGridViewTextBoxColumn()
        BtnBack = New Button()
        BtnHapus = New Button()
        BtnUbah = New Button()
        BtnTambah = New Button()
        TextPass = New TextBox()
        TextUser = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        ComboBox1 = New ComboBox()
        CType(Data_User, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Data_User
        ' 
        Data_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_User.Columns.AddRange(New DataGridViewColumn() {User, Pass, Lev})
        Data_User.Location = New Point(50, 246)
        Data_User.Name = "Data_User"
        Data_User.RowHeadersWidth = 62
        Data_User.RowTemplate.Height = 33
        Data_User.Size = New Size(948, 354)
        Data_User.TabIndex = 64
        ' 
        ' User
        ' 
        User.HeaderText = "UserName"
        User.MinimumWidth = 8
        User.Name = "User"
        User.Width = 150
        ' 
        ' Pass
        ' 
        Pass.HeaderText = "Password"
        Pass.MinimumWidth = 8
        Pass.Name = "Pass"
        Pass.Width = 150
        ' 
        ' Lev
        ' 
        Lev.HeaderText = "Level"
        Lev.MinimumWidth = 8
        Lev.Name = "Lev"
        Lev.Width = 150
        ' 
        ' BtnBack
        ' 
        BtnBack.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnBack.Location = New Point(610, 169)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(112, 34)
        BtnBack.TabIndex = 63
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnHapus.Location = New Point(492, 169)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(112, 34)
        BtnHapus.TabIndex = 62
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' BtnUbah
        ' 
        BtnUbah.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnUbah.Location = New Point(610, 113)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(112, 34)
        BtnUbah.TabIndex = 61
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = True
        ' 
        ' BtnTambah
        ' 
        BtnTambah.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        BtnTambah.Location = New Point(492, 113)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(112, 34)
        BtnTambah.TabIndex = 60
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = True
        ' 
        ' TextPass
        ' 
        TextPass.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextPass.Location = New Point(198, 130)
        TextPass.Name = "TextPass"
        TextPass.Size = New Size(150, 33)
        TextPass.TabIndex = 57
        ' 
        ' TextUser
        ' 
        TextUser.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextUser.Location = New Point(198, 91)
        TextUser.Name = "TextUser"
        TextUser.Size = New Size(150, 33)
        TextUser.TabIndex = 56
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(50, 172)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 25)
        Label9.TabIndex = 54
        Label9.Text = "Level"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(50, 133)
        Label10.Name = "Label10"
        Label10.Size = New Size(96, 25)
        Label10.TabIndex = 53
        Label10.Text = "Password"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(50, 94)
        Label11.Name = "Label11"
        Label11.Size = New Size(105, 25)
        Label11.TabIndex = 52
        Label11.Text = "UserName"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(383, 38)
        Label12.Name = "Label12"
        Label12.Size = New Size(115, 26)
        Label12.TabIndex = 51
        Label12.Text = "Data User"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(198, 169)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(150, 33)
        ComboBox1.TabIndex = 65
        ' 
        ' DataUser
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1051, 646)
        Controls.Add(ComboBox1)
        Controls.Add(Data_User)
        Controls.Add(BtnBack)
        Controls.Add(BtnHapus)
        Controls.Add(BtnUbah)
        Controls.Add(BtnTambah)
        Controls.Add(TextPass)
        Controls.Add(TextUser)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Name = "DataUser"
        Text = "DataUser"
        CType(Data_User, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Data_User As DataGridView
    Friend WithEvents User As DataGridViewTextBoxColumn
    Friend WithEvents Pass As DataGridViewTextBoxColumn
    Friend WithEvents Lev As DataGridViewTextBoxColumn
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TextPass As TextBox
    Friend WithEvents TextUser As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
