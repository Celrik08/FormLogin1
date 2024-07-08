Imports MySql.Data.MySqlClient

Public Class DataAnggota
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        ' Ambil nilai dari TextBox ke variabel
        Dim anggota As String = TextAnggota.Text
        Dim nama As String = TextNama.Text
        Dim alamat As String = TextAlamat.Text
        Dim hp As String = TextHp.Text

        ' Validasi apakah ada isian di TextBox
        If String.IsNullOrWhiteSpace(anggota) Or String.IsNullOrWhiteSpace(nama) Or String.IsNullOrWhiteSpace(alamat) Or String.IsNullOrWhiteSpace(hp) Then
            MessageBox.Show("Semua kolom harus diisi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Tambahkan data ke DataGridView
        Data_Anggota.Rows.Add(anggota, nama, alamat, hp)

        ' Tambahkan data ke database
        Dim query As String = "INSERT INTO anggota (id_anggota, nama_petugas, alamat, phone) VALUES (@id_anggota, @nama_petugas, @alamat, @phone)"
        Using cmd As New MySqlCommand(query, Koneksi)
            cmd.Parameters.AddWithValue("@id_anggota", anggota)
            cmd.Parameters.AddWithValue("@nama_petugas", nama)
            cmd.Parameters.AddWithValue("@alamat", alamat)
            cmd.Parameters.AddWithValue("@phone", hp)
            Konek()
            cmd.ExecuteNonQuery()
            Diskonek()
        End Using

        ' Kosongkan TextBox setelah data ditambahkan
        TextAnggota.Clear()
        TextNama.Clear()
        TextAlamat.Clear()
        TextHp.Clear()
    End Sub

    ' Buat sebuah method untuk menampilkan data dari database ke DataGridView
    Private Sub LoadDataToDataGridView()
        ' Kosongkan DataGridView terlebih dahulu
        Data_Anggota.Rows.Clear()

        ' Tulis kueri SQL Anda untuk mengambil data dari database
        Dim query As String = "SELECT id_anggota, nama_petugas, alamat, phone FROM anggota"

        ' Buat MySqlCommand untuk menjalankan kueri
        Using cmd As New MySqlCommand(query, Koneksi)
            Konek()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Loop melalui hasil pembacaan dan tambahkan ke DataGridView
            While reader.Read()
                Dim anggota As String = reader("id_anggota").ToString()
                Dim nama As String = reader("nama_petugas").ToString()
                Dim alamat As String = reader("alamat").ToString()
                Dim hp As String = reader("phone").ToString()

                Data_Anggota.Rows.Add(anggota, nama, alamat, hp)
            End While

            Diskonek()
        End Using
    End Sub

    Private Sub Data_Anggota_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_Anggota.CellContentClick

    End Sub
End Class