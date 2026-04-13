<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
        lblKode = New Label()
        lblNama = New Label()
        lblKategori = New Label()
        lblStok = New Label()
        lblHarga = New Label()
        lblCari = New Label()
        txtKode = New TextBox()
        txtNama = New TextBox()
        txtKategori = New TextBox()
        txtStok = New TextBox()
        txtHarga = New TextBox()
        txtCari = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvInventaris = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvInventaris, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblKode
        ' 
        lblKode.AutoSize = True
        lblKode.Font = New Font("Sitka Banner", 10F)
        lblKode.Location = New Point(39, 80)
        lblKode.Margin = New Padding(4, 0, 4, 0)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(134, 29)
        lblKode.TabIndex = 16
        lblKode.Text = "Kode Furniture:"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Sitka Banner", 10F)
        lblNama.Location = New Point(39, 138)
        lblNama.Margin = New Padding(4, 0, 4, 0)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(142, 29)
        lblNama.TabIndex = 15
        lblNama.Text = "Nama Furniture:"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Font = New Font("Sitka Banner", 10F)
        lblKategori.Location = New Point(39, 194)
        lblKategori.Margin = New Padding(4, 0, 4, 0)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(82, 29)
        lblKategori.TabIndex = 14
        lblKategori.Text = "Kategori:"
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Font = New Font("Sitka Banner", 10F)
        lblStok.Location = New Point(432, 80)
        lblStok.Margin = New Padding(4, 0, 4, 0)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(52, 29)
        lblStok.TabIndex = 13
        lblStok.Text = "Stok:"
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Sitka Banner", 10F)
        lblHarga.Location = New Point(433, 139)
        lblHarga.Margin = New Padding(4, 0, 4, 0)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(65, 29)
        lblHarga.TabIndex = 12
        lblHarga.Text = "Harga:"
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Font = New Font("Sitka Banner", 10F)
        lblCari.Location = New Point(432, 198)
        lblCari.Margin = New Padding(4, 0, 4, 0)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(50, 29)
        lblCari.TabIndex = 11
        lblCari.Text = "Cari:"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(186, 80)
        txtKode.Margin = New Padding(4, 5, 4, 5)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(202, 31)
        txtKode.TabIndex = 10
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(186, 138)
        txtNama.Margin = New Padding(4, 5, 4, 5)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(202, 31)
        txtNama.TabIndex = 9
        ' 
        ' txtKategori
        ' 
        txtKategori.Location = New Point(186, 197)
        txtKategori.Margin = New Padding(4, 5, 4, 5)
        txtKategori.Name = "txtKategori"
        txtKategori.Size = New Size(202, 31)
        txtKategori.TabIndex = 8
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(509, 80)
        txtStok.Margin = New Padding(4, 5, 4, 5)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(267, 31)
        txtStok.TabIndex = 7
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(509, 138)
        txtHarga.Margin = New Padding(4, 5, 4, 5)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(267, 31)
        txtHarga.TabIndex = 6
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(509, 197)
        txtCari.Margin = New Padding(4, 5, 4, 5)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(267, 31)
        txtCari.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.SteelBlue
        btnSimpan.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnSimpan.ForeColor = SystemColors.Control
        btnSimpan.Location = New Point(39, 273)
        btnSimpan.Margin = New Padding(4, 5, 4, 5)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(155, 50)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.SteelBlue
        btnUbah.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnUbah.ForeColor = SystemColors.Control
        btnUbah.Location = New Point(242, 273)
        btnUbah.Margin = New Padding(4, 5, 4, 5)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(155, 50)
        btnUbah.TabIndex = 3
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.SteelBlue
        btnHapus.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnHapus.ForeColor = SystemColors.Control
        btnHapus.Location = New Point(433, 273)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(153, 50)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.SteelBlue
        btnBatal.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnBatal.ForeColor = SystemColors.Control
        btnBatal.Location = New Point(624, 273)
        btnBatal.Margin = New Padding(4, 5, 4, 5)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(152, 50)
        btnBatal.TabIndex = 1
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvInventaris
        ' 
        dgvInventaris.AllowUserToAddRows = False
        dgvInventaris.AllowUserToDeleteRows = False
        dgvInventaris.BackgroundColor = SystemColors.ButtonHighlight
        dgvInventaris.ColumnHeadersHeight = 34
        dgvInventaris.Location = New Point(39, 352)
        dgvInventaris.Margin = New Padding(4, 5, 4, 5)
        dgvInventaris.Name = "dgvInventaris"
        dgvInventaris.ReadOnly = True
        dgvInventaris.RowHeadersWidth = 62
        dgvInventaris.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvInventaris.Size = New Size(737, 333)
        dgvInventaris.TabIndex = 0
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(829, 817)
        Controls.Add(dgvInventaris)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtCari)
        Controls.Add(txtHarga)
        Controls.Add(txtStok)
        Controls.Add(txtKategori)
        Controls.Add(txtNama)
        Controls.Add(txtKode)
        Controls.Add(lblCari)
        Controls.Add(lblHarga)
        Controls.Add(lblStok)
        Controls.Add(lblKategori)
        Controls.Add(lblNama)
        Controls.Add(lblKode)
        Margin = New Padding(4, 5, 4, 5)
        Name = "FormUtama"
        Text = "Sistem Inventaris Furnitur Informa"
        CType(dgvInventaris, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblKode As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents lblStok As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblCari As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvInventaris As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class