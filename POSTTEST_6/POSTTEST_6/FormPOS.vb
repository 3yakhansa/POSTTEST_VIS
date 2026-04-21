Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FormPOS
    Private dtCart As New DataTable()
    Private selectedProductStok As Integer = 0
    Private totalTransaksi As Decimal = 0

    Private Sub FormPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitCartTable()
        RefreshProduk()
    End Sub

    Private Sub InitCartTable()
        dtCart.Columns.Add("Kode", GetType(String))
        dtCart.Columns.Add("Nama", GetType(String))
        dtCart.Columns.Add("Harga", GetType(Decimal))
        dtCart.Columns.Add("Qty", GetType(Integer))
        dtCart.Columns.Add("Subtotal", GetType(Decimal))
        dgvKeranjang.DataSource = dtCart
    End Sub

    Private Sub RefreshProduk()
        dgvProduk.DataSource = DataModule.SearchData(txtCariProduk.Text.Trim())
        FormatProdukGrid()
    End Sub

    Private Sub FormatProdukGrid()
        If dgvProduk.Columns.Count > 0 Then
            dgvProduk.Columns("id").Visible = False
            dgvProduk.Columns("Kategori").Visible = False
            dgvProduk.Columns("Kode").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProduk.Columns("Nama").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvProduk.Columns("Stok").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProduk.Columns("Harga").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProduk.Columns("Harga").DefaultCellStyle.Format = "C0"
        End If
    End Sub

    Private Sub txtCariProduk_TextChanged(sender As Object, e As EventArgs) Handles txtCariProduk.TextChanged
        RefreshProduk()
    End Sub

    Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvProduk.Rows(e.RowIndex)
            txtKode.Text = row.Cells("Kode").Value.ToString()
            txtNama.Text = row.Cells("Nama").Value.ToString()
            txtHarga.Text = row.Cells("Harga").Value.ToString()
            selectedProductStok = Convert.ToInt32(row.Cells("Stok").Value)
            txtQty.Text = "1"
            txtQty.Focus()
            txtQty.SelectAll()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If String.IsNullOrWhiteSpace(txtKode.Text) Then
            MessageBox.Show("Pilih produk terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim qty As Integer = 0
        If Not Integer.TryParse(txtQty.Text, qty) OrElse qty <= 0 Then
            ErrorProvider1.SetError(txtQty, "Qty harus angka > 0")
            Return
        End If
        ErrorProvider1.SetError(txtQty, "")

        If qty > selectedProductStok Then
            MessageBox.Show($"Stok tidak mencukupi! Stok tersedia: {selectedProductStok}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim existingRow = dtCart.Select($"Kode = '{txtKode.Text}'").FirstOrDefault()
        Dim harga As Decimal = Convert.ToDecimal(txtHarga.Text)

        If existingRow IsNot Nothing Then
            Dim currentQty As Integer = Convert.ToInt32(existingRow("Qty"))
            If currentQty + qty > selectedProductStok Then
                MessageBox.Show("Penambahan melebihi stok yang tersedia!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            existingRow("Qty") = currentQty + qty
            existingRow("Subtotal") = Convert.ToDecimal(existingRow("Subtotal")) + (harga * qty)
        Else
            dtCart.Rows.Add(txtKode.Text, txtNama.Text, harga, qty, harga * qty)
        End If

        UpdateTotal()
        ClearDetailFields()
    End Sub

    Private Sub ClearDetailFields()
        txtKode.Clear() : txtNama.Clear() : txtHarga.Clear() : txtQty.Text = "1"
        selectedProductStok = 0
    End Sub

    Private Sub UpdateTotal()
        totalTransaksi = 0
        For Each row As DataRow In dtCart.Rows
            totalTransaksi += Convert.ToDecimal(row("Subtotal"))
        Next
        txtTotal.Text = totalTransaksi.ToString("C0")
        CalculateKembalian()
    End Sub

    Private Sub txtBayar_TextChanged(sender As Object, e As EventArgs) Handles txtBayar.TextChanged
        CalculateKembalian()
    End Sub

    Private Sub CalculateKembalian()
        Dim bayar As Decimal = 0
        If Decimal.TryParse(txtBayar.Text, bayar) AndAlso bayar >= totalTransaksi Then
            txtKembalian.Text = (bayar - totalTransaksi).ToString("C0")
        Else
            txtKembalian.Text = "0"
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If MessageBox.Show("Batalkan transaksi nih?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            dtCart.Clear()
            txtTotal.Text = "0" : txtBayar.Clear() : txtKembalian.Text = "0"
            ClearDetailFields()
            ValidationModule.ClearErrors(ErrorProvider1)
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If dtCart.Rows.Count = 0 Then
            MessageBox.Show("Keranjang kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bayar As Decimal = 0
        If Not Decimal.TryParse(txtBayar.Text, bayar) OrElse bayar < totalTransaksi Then
            MessageBox.Show("Jumlah pembayaran kurang!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New MySqlConnection(ConnectionModule.ConnectionString)
                conn.Open()
                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim idPenjualan As Integer
                        Using cmdPenjualan As New MySqlCommand("INSERT INTO tb_penjualan (tanggal, total, metode_bayar) VALUES (@tgl, @total, 'Tunai')", conn, trans)
                            cmdPenjualan.Parameters.AddWithValue("@tgl", DateTime.Now)
                            cmdPenjualan.Parameters.AddWithValue("@total", totalTransaksi)
                            cmdPenjualan.ExecuteNonQuery()
                            cmdPenjualan.CommandText = "SELECT LAST_INSERT_ID()"
                            idPenjualan = Convert.ToInt32(cmdPenjualan.ExecuteScalar())
                        End Using

                        Using cmdDetail As New MySqlCommand("", conn, trans)
                            For Each row As DataRow In dtCart.Rows
                                Dim kode = row("Kode").ToString()
                                Dim harga = Convert.ToDecimal(row("Harga"))
                                Dim qty = Convert.ToInt32(row("Qty"))
                                Dim subtotal = Convert.ToDecimal(row("Subtotal"))

                                cmdDetail.CommandText = "INSERT INTO tb_detail_penjualan (id_penjualan, kode_furniture, nama, harga, qty, subtotal) 
                                                         VALUES (@idPen, @kode, @nama, @harga, @qty, @subtotal)"
                                cmdDetail.Parameters.Clear()
                                cmdDetail.Parameters.AddWithValue("@idPen", idPenjualan)
                                cmdDetail.Parameters.AddWithValue("@kode", kode)
                                cmdDetail.Parameters.AddWithValue("@nama", row("Nama").ToString())
                                cmdDetail.Parameters.AddWithValue("@harga", harga)
                                cmdDetail.Parameters.AddWithValue("@qty", qty)
                                cmdDetail.Parameters.AddWithValue("@subtotal", subtotal)
                                cmdDetail.ExecuteNonQuery()

                                cmdDetail.CommandText = "UPDATE tb_inventaris SET stok = stok - @qty WHERE kode_furniture = @kode"
                                cmdDetail.Parameters.Clear()
                                cmdDetail.Parameters.AddWithValue("@qty", qty)
                                cmdDetail.Parameters.AddWithValue("@kode", kode)
                                cmdDetail.ExecuteNonQuery()
                            Next
                        End Using

                        trans.Commit()
                        MessageBox.Show("Transaksi berhasil diproses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        dtCart.Clear()
                        txtTotal.Text = "0" : txtBayar.Clear() : txtKembalian.Text = "0"
                        ClearDetailFields()
                        RefreshProduk()

                    Catch ex As Exception
                        trans.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memproses transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

End Class