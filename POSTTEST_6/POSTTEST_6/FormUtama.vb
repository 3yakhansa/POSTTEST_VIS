Imports System.Windows.Forms

Public Class FormUtama
    Private selectedId As Integer = -1

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        ClearForm()
    End Sub

    Private Sub RefreshGrid()
        dgvInventaris.DataSource = DataModule.LoadData()
        FormatGrid()
    End Sub

    Private Sub FormatGrid()
        dgvInventaris.Columns("id").Visible = False
        dgvInventaris.Columns("Kode").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvInventaris.Columns("Nama").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvInventaris.Columns("Kategori").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvInventaris.Columns("Stok").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvInventaris.Columns("Harga").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvInventaris.Columns("Harga").DefaultCellStyle.Format = "C0"
    End Sub

    Private Sub ClearForm()
        txtKode.Clear() : txtNama.Clear() : txtKategori.Clear()
        txtStok.Clear() : txtHarga.Clear() : txtCari.Clear()
        ValidationModule.ClearErrors(ErrorProvider1)
        selectedId = -1
        txtKode.ReadOnly = False
        txtKode.Focus()
    End Sub

    Private Sub dgvInventaris_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventaris.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvInventaris.Rows(e.RowIndex)
            selectedId = Convert.ToInt32(row.Cells("id").Value)
            txtKode.Text = row.Cells("Kode").Value.ToString()
            txtNama.Text = row.Cells("Nama").Value.ToString()
            txtKategori.Text = row.Cells("Kategori").Value.ToString()
            txtStok.Text = row.Cells("Stok").Value.ToString()
            txtHarga.Text = Convert.ToDecimal(row.Cells("Harga").Value).ToString("0")
            txtKode.ReadOnly = True
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        dgvInventaris.DataSource = DataModule.SearchData(txtCari.Text)
        FormatGrid()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ValidateInputs() Then
            Try
                If DataModule.InsertData(txtKode.Text, txtNama.Text, txtKategori.Text, Integer.Parse(txtStok.Text), Decimal.Parse(txtHarga.Text)) Then
                    MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshGrid() : ClearForm()
                Else
                    MessageBox.Show("Gagal menyimpan. Kode mungkin sudah digunakan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data di tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ValidateInputs() Then
            Try
                If DataModule.UpdateData(selectedId, txtKode.Text, txtNama.Text, txtKategori.Text, Integer.Parse(txtStok.Text), Decimal.Parse(txtHarga.Text)) Then
                    MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshGrid() : ClearForm()
                Else
                    MessageBox.Show("Gagal memperbarui data.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Yakin hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                If DataModule.DeleteData(selectedId) Then
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshGrid() : ClearForm()
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim ok As Boolean = True
        ok = ValidationModule.ValidateField(txtKode, ErrorProvider1, "Kode") AndAlso ok
        ok = ValidationModule.ValidateField(txtNama, ErrorProvider1, "Nama") AndAlso ok
        ok = ValidationModule.IsNumericPositive(txtStok.Text, txtStok, ErrorProvider1, "Stok") AndAlso ok
        ok = ValidationModule.IsNumericPositive(txtHarga.Text, txtHarga, ErrorProvider1, "Harga") AndAlso ok
        Return ok
    End Function

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim frmPOS As New FormPOS()
        frmPOS.ShowDialog()
        RefreshGrid()
    End Sub

End Class