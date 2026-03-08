Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDataGridView()
        TambahBukuData("Harry Potter", "Fantasi")
        TambahBukuData("Sherlock Holmes", "Misteri")
        TampilkanBukuKeGrid(DataGridView1)
    End Sub

    ' procedure setup gridview
    Private Sub SetupDataGridView()
        ' berisihkan kolom lama
        DataGridView1.Columns.Clear()

        ' tambah kolom
        DataGridView1.ColumnCount = 2
        DataGridView1.Columns(0).Name = "Judul Buku"
        DataGridView1.Columns(1).Name = "Genre"

        ' set lebar kolom
        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 150

        ' set biar ga addrow manual
        DataGridView1.AllowUserToAddRows = False

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DataGridView1.ReadOnly = True
    End Sub

    ' event button tambah
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' validasi input ga boleh kosong
        If String.IsNullOrWhiteSpace(txtJudul.Text) OrElse
           String.IsNullOrWhiteSpace(txtGenre.Text) Then
            MessageBox.Show("Judul dan Genre ga boleh kosong", "Peringatan",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' validasi judul min 3 karakter
        If Not ValidasiJudul(txtJudul.Text) Then
            MessageBox.Show("Judul buku minimal 3 karakter!", "Peringatan",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' cek buku dah ada apa belum
        If CariIndexBuku(txtJudul.Text) <> -1 Then
            MessageBox.Show("Buku judul ini udah ada", "Peringatan",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' tambah buku 
        TambahBukuData(txtJudul.Text, txtGenre.Text)

        ' tampilkan ke gridview
        TampilkanBukuKeGrid(DataGridView1)

        ' clear textbox
        txtJudul.Clear()
        txtGenre.Clear()
        txtJudul.Focus()

        MessageBox.Show("Buku dah ditambahkan", "Informasi",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' event button hapus
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' validasi input ga boleh kosong
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Masukkan judul yang mau dihapus!", "Peringatan",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' cek buku ada apa ga
        Dim index As Integer = CariIndexBuku(TextBox1.Text)
        If index = -1 Then
            MessageBox.Show("Buku ga ada!", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' konfir hapus
        Dim result As DialogResult = MessageBox.Show(
            "yakin hapus buku? '" & TextBox1.Text & "'?",
            "konfirmasi hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' hapus buku
            Dim judul As String = TextBox1.Text
            HapusBukuData(judul)

            ' refresh tampilan DataGridView
            TampilkanBukuKeGrid(DataGridView1)
            TextBox1.Clear()
            TextBox1.Focus()

            MessageBox.Show("Buku dah dihapus", "Informasi",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' event double click di gridview buat masukin judul ke textbox hapus
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        End If
    End Sub

End Class