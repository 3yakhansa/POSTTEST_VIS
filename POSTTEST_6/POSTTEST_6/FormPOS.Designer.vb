<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPOS
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        gbProduk = New GroupBox()
        dgvProduk = New DataGridView()
        txtCariProduk = New TextBox()
        lblCariProduk = New Label()
        gbDetail = New GroupBox()
        btnTambah = New Button()
        txtQty = New TextBox()
        lblQty = New Label()
        txtHarga = New TextBox()
        lblHarga = New Label()
        txtNama = New TextBox()
        lblNama = New Label()
        txtKode = New TextBox()
        lblKode = New Label()
        gbKeranjang = New GroupBox()
        dgvKeranjang = New DataGridView()
        gbPembayaran = New GroupBox()
        btnProses = New Button()
        btnBatal = New Button()
        txtBayar = New TextBox()
        lblBayar = New Label()
        lblKembalian = New Label()
        txtKembalian = New Label()
        lblTotal = New Label()
        txtTotal = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        btnKembali = New Button()
        gbProduk.SuspendLayout()
        CType(dgvProduk, ComponentModel.ISupportInitialize).BeginInit()
        gbDetail.SuspendLayout()
        gbKeranjang.SuspendLayout()
        CType(dgvKeranjang, ComponentModel.ISupportInitialize).BeginInit()
        gbPembayaran.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gbProduk
        ' 
        gbProduk.Controls.Add(dgvProduk)
        gbProduk.Controls.Add(txtCariProduk)
        gbProduk.Controls.Add(lblCariProduk)
        gbProduk.Font = New Font("Sitka Banner", 10.0F)
        gbProduk.Location = New Point(15, 15)
        gbProduk.Name = "gbProduk"
        gbProduk.Size = New Size(780, 320)
        gbProduk.TabIndex = 0
        gbProduk.TabStop = False
        gbProduk.Text = "Pilih Produk"
        ' 
        ' dgvProduk
        ' 
        dgvProduk.AllowUserToAddRows = False
        dgvProduk.AllowUserToDeleteRows = False
        dgvProduk.BackgroundColor = SystemColors.ButtonHighlight
        dgvProduk.ColumnHeadersHeight = 34
        dgvProduk.Location = New Point(15, 85)
        dgvProduk.Name = "dgvProduk"
        dgvProduk.ReadOnly = True
        dgvProduk.RowHeadersWidth = 62
        dgvProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProduk.Size = New Size(750, 220)
        dgvProduk.TabIndex = 2
        ' 
        ' txtCariProduk
        ' 
        txtCariProduk.Location = New Point(85, 45)
        txtCariProduk.Name = "txtCariProduk"
        txtCariProduk.Size = New Size(680, 33)
        txtCariProduk.TabIndex = 1
        ' 
        ' lblCariProduk
        ' 
        lblCariProduk.AutoSize = True
        lblCariProduk.Font = New Font("Sitka Banner", 10.0F)
        lblCariProduk.Location = New Point(20, 42)
        lblCariProduk.Name = "lblCariProduk"
        lblCariProduk.Size = New Size(50, 29)
        lblCariProduk.TabIndex = 0
        lblCariProduk.Text = "Cari:"
        ' 
        ' gbDetail
        ' 
        gbDetail.Controls.Add(btnTambah)
        gbDetail.Controls.Add(txtQty)
        gbDetail.Controls.Add(lblQty)
        gbDetail.Controls.Add(txtHarga)
        gbDetail.Controls.Add(lblHarga)
        gbDetail.Controls.Add(txtNama)
        gbDetail.Controls.Add(lblNama)
        gbDetail.Controls.Add(txtKode)
        gbDetail.Controls.Add(lblKode)
        gbDetail.Font = New Font("Sitka Banner", 10.0F)
        gbDetail.Location = New Point(15, 350)
        gbDetail.Name = "gbDetail"
        gbDetail.Size = New Size(780, 110)
        gbDetail.TabIndex = 1
        gbDetail.TabStop = False
        gbDetail.Text = "Detail Penambahan"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.SteelBlue
        btnTambah.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnTambah.ForeColor = SystemColors.Control
        btnTambah.Location = New Point(650, 60)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(115, 40)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtQty
        ' 
        txtQty.Location = New Point(520, 65)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(100, 33)
        txtQty.TabIndex = 7
        txtQty.Text = "1"
        ' 
        ' lblQty
        ' 
        lblQty.AutoSize = True
        lblQty.Font = New Font("Sitka Banner", 10.0F)
        lblQty.Location = New Point(520, 35)
        lblQty.Name = "lblQty"
        lblQty.Size = New Size(45, 29)
        lblQty.TabIndex = 6
        lblQty.Text = "Qty:"
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(380, 65)
        txtHarga.Name = "txtHarga"
        txtHarga.ReadOnly = True
        txtHarga.Size = New Size(120, 33)
        txtHarga.TabIndex = 5
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Sitka Banner", 10.0F)
        lblHarga.Location = New Point(380, 35)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(65, 29)
        lblHarga.TabIndex = 4
        lblHarga.Text = "Harga:"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(164, 65)
        txtNama.Name = "txtNama"
        txtNama.ReadOnly = True
        txtNama.Size = New Size(196, 33)
        txtNama.TabIndex = 3
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Sitka Banner", 10.0F)
        lblNama.Location = New Point(164, 29)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(142, 29)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama Furniture:"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(15, 65)
        txtKode.Name = "txtKode"
        txtKode.ReadOnly = True
        txtKode.Size = New Size(134, 33)
        txtKode.TabIndex = 1
        ' 
        ' lblKode
        ' 
        lblKode.AutoSize = True
        lblKode.Font = New Font("Sitka Banner", 10.0F)
        lblKode.Location = New Point(11, 31)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(134, 29)
        lblKode.TabIndex = 0
        lblKode.Text = "Kode Furniture:"
        ' 
        ' gbKeranjang
        ' 
        gbKeranjang.Controls.Add(dgvKeranjang)
        gbKeranjang.Font = New Font("Sitka Banner", 10.0F)
        gbKeranjang.Location = New Point(15, 467)
        gbKeranjang.Name = "gbKeranjang"
        gbKeranjang.Size = New Size(780, 180)
        gbKeranjang.TabIndex = 2
        gbKeranjang.TabStop = False
        gbKeranjang.Text = "Keranjang Belanja"
        ' 
        ' dgvKeranjang
        ' 
        dgvKeranjang.AllowUserToAddRows = False
        dgvKeranjang.AllowUserToDeleteRows = False
        dgvKeranjang.BackgroundColor = SystemColors.ButtonHighlight
        dgvKeranjang.ColumnHeadersHeight = 34
        dgvKeranjang.Location = New Point(15, 40)
        dgvKeranjang.Name = "dgvKeranjang"
        dgvKeranjang.ReadOnly = True
        dgvKeranjang.RowHeadersWidth = 62
        dgvKeranjang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKeranjang.Size = New Size(750, 125)
        dgvKeranjang.TabIndex = 0
        ' 
        ' gbPembayaran
        ' 
        gbPembayaran.Controls.Add(btnProses)
        gbPembayaran.Controls.Add(btnBatal)
        gbPembayaran.Controls.Add(txtBayar)
        gbPembayaran.Controls.Add(lblBayar)
        gbPembayaran.Controls.Add(lblKembalian)
        gbPembayaran.Controls.Add(txtKembalian)
        gbPembayaran.Controls.Add(lblTotal)
        gbPembayaran.Controls.Add(txtTotal)
        gbPembayaran.Font = New Font("Sitka Banner", 10.0F)
        gbPembayaran.Location = New Point(15, 657)
        gbPembayaran.Name = "gbPembayaran"
        gbPembayaran.Size = New Size(780, 90)
        gbPembayaran.TabIndex = 3
        gbPembayaran.TabStop = False
        gbPembayaran.Text = "Pembayaran"
        ' 
        ' btnProses
        ' 
        btnProses.BackColor = Color.DarkGreen
        btnProses.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnProses.ForeColor = SystemColors.Control
        btnProses.Location = New Point(589, 44)
        btnProses.Name = "btnProses"
        btnProses.Size = New Size(100, 40)
        btnProses.TabIndex = 7
        btnProses.Text = "Proses"
        btnProses.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Firebrick
        btnBatal.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnBatal.ForeColor = SystemColors.Control
        btnBatal.Location = New Point(695, 44)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(70, 40)
        btnBatal.TabIndex = 6
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' txtBayar
        ' 
        txtBayar.Location = New Point(425, 48)
        txtBayar.Name = "txtBayar"
        txtBayar.Size = New Size(120, 33)
        txtBayar.TabIndex = 5
        ' 
        ' lblBayar
        ' 
        lblBayar.AutoSize = True
        lblBayar.Font = New Font("Sitka Banner", 10.0F)
        lblBayar.Location = New Point(425, 19)
        lblBayar.Name = "lblBayar"
        lblBayar.Size = New Size(63, 29)
        lblBayar.TabIndex = 4
        lblBayar.Text = "Bayar:"
        ' 
        ' lblKembalian
        ' 
        lblKembalian.AutoSize = True
        lblKembalian.Font = New Font("Sitka Banner", 10.0F, FontStyle.Bold)
        lblKembalian.ForeColor = Color.DarkGreen
        lblKembalian.Location = New Point(204, 19)
        lblKembalian.Name = "lblKembalian"
        lblKembalian.Size = New Size(106, 29)
        lblKembalian.TabIndex = 3
        lblKembalian.Text = "Kembalian:"
        ' 
        ' txtKembalian
        ' 
        txtKembalian.AutoSize = True
        txtKembalian.Font = New Font("Sitka Banner", 10.0F, FontStyle.Bold)
        txtKembalian.ForeColor = Color.DarkGreen
        txtKembalian.Location = New Point(211, 48)
        txtKembalian.Name = "txtKembalian"
        txtKembalian.Size = New Size(24, 29)
        txtKembalian.TabIndex = 2
        txtKembalian.Text = "0"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Sitka Banner", 10.0F, FontStyle.Bold)
        lblTotal.ForeColor = Color.DarkBlue
        lblTotal.Location = New Point(15, 38)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(93, 29)
        lblTotal.TabIndex = 1
        lblTotal.Text = "Total: Rp "
        ' 
        ' txtTotal
        ' 
        txtTotal.AutoSize = True
        txtTotal.Font = New Font("Sitka Banner", 10.0F, FontStyle.Bold)
        txtTotal.ForeColor = Color.DarkBlue
        txtTotal.Location = New Point(105, 38)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(24, 29)
        txtTotal.TabIndex = 0
        txtTotal.Text = "0"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.SteelBlue
        btnKembali.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnKembali.ForeColor = SystemColors.Control
        btnKembali.Location = New Point(20, 766)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(124, 35)
        btnKembali.TabIndex = 8
        btnKembali.Text = "<< Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' FormPOS
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(815, 825)
        Controls.Add(btnKembali)
        Controls.Add(gbPembayaran)
        Controls.Add(gbKeranjang)
        Controls.Add(gbDetail)
        Controls.Add(gbProduk)
        Name = "FormPOS"
        Text = "Point of Sale "
        gbProduk.ResumeLayout(False)
        gbProduk.PerformLayout()
        CType(dgvProduk, ComponentModel.ISupportInitialize).EndInit()
        gbDetail.ResumeLayout(False)
        gbDetail.PerformLayout()
        gbKeranjang.ResumeLayout(False)
        CType(dgvKeranjang, ComponentModel.ISupportInitialize).EndInit()
        gbPembayaran.ResumeLayout(False)
        gbPembayaran.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gbProduk As GroupBox
    Friend WithEvents dgvProduk As DataGridView
    Friend WithEvents txtCariProduk As TextBox
    Friend WithEvents lblCariProduk As Label
    Friend WithEvents gbDetail As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblQty As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents lblHarga As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents lblKode As Label
    Friend WithEvents gbKeranjang As GroupBox
    Friend WithEvents dgvKeranjang As DataGridView
    Friend WithEvents gbPembayaran As GroupBox
    Friend WithEvents btnProses As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents lblBayar As Label
    Friend WithEvents lblKembalian As Label
    Friend WithEvents txtKembalian As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnKembali As Button
End Class