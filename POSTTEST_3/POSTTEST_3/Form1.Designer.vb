<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCetak))
        pbFoto = New PictureBox()
        btnBrowse = New Button()
        lblNama = New Label()
        lblUmur = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        lblNomor = New Label()
        txtNomor = New TextBox()
        lbTgl = New Label()
        dtpTgl = New DateTimePicker()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        gbJenisKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        gbHobi = New GroupBox()
        btnCetak = New Button()
        cbLainnya = New CheckBox()
        cbMenari = New CheckBox()
        cbFotografi = New CheckBox()
        cbTraveling = New CheckBox()
        cbGaming = New CheckBox()
        cbMusik = New CheckBox()
        cbMemasak = New CheckBox()
        cbMenulis = New CheckBox()
        cbMembaca = New CheckBox()
        cbOlahraga = New CheckBox()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        gbJenisKelamin.SuspendLayout()
        gbHobi.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbFoto
        ' 
        pbFoto.BackColor = Color.White
        pbFoto.BorderStyle = BorderStyle.Fixed3D
        pbFoto.Location = New Point(49, 72)
        pbFoto.Margin = New Padding(2, 4, 2, 4)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(182, 239)
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.SteelBlue
        btnBrowse.Font = New Font("Sitka Small", 9F, FontStyle.Bold)
        btnBrowse.ForeColor = SystemColors.ControlLightLight
        btnBrowse.Location = New Point(76, 336)
        btnBrowse.Margin = New Padding(2, 4, 2, 4)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(140, 35)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Pilih Foto"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Sitka Heading", 9F, FontStyle.Bold Or FontStyle.Italic)
        lblNama.Location = New Point(244, 72)
        lblNama.Margin = New Padding(2, 0, 2, 0)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(58, 26)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.Font = New Font("Sitka Heading", 9F, FontStyle.Bold Or FontStyle.Italic)
        lblUmur.Location = New Point(244, 126)
        lblUmur.Margin = New Padding(2, 0, 2, 0)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(57, 26)
        lblUmur.TabIndex = 3
        lblUmur.Text = "Umur"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(362, 73)
        txtNama.Margin = New Padding(2, 4, 2, 4)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(255, 30)
        txtNama.TabIndex = 4
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(362, 122)
        txtUmur.Margin = New Padding(2, 4, 2, 4)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(255, 30)
        txtUmur.TabIndex = 5
        ' 
        ' lblNomor
        ' 
        lblNomor.AutoSize = True
        lblNomor.BackColor = Color.Transparent
        lblNomor.Font = New Font("Sitka Heading", 9F, FontStyle.Bold Or FontStyle.Italic)
        lblNomor.Location = New Point(244, 233)
        lblNomor.Margin = New Padding(2, 0, 2, 0)
        lblNomor.Name = "lblNomor"
        lblNomor.Size = New Size(103, 26)
        lblNomor.TabIndex = 6
        lblNomor.Text = "No. Telepon"
        ' 
        ' txtNomor
        ' 
        txtNomor.ForeColor = SystemColors.WindowText
        txtNomor.Location = New Point(362, 230)
        txtNomor.Margin = New Padding(2, 4, 2, 4)
        txtNomor.Name = "txtNomor"
        txtNomor.Size = New Size(255, 30)
        txtNomor.TabIndex = 7
        ' 
        ' lbTgl
        ' 
        lbTgl.AutoSize = True
        lbTgl.BackColor = Color.Transparent
        lbTgl.Font = New Font("Sitka Heading", 9F, FontStyle.Bold Or FontStyle.Italic)
        lbTgl.Location = New Point(244, 182)
        lbTgl.Margin = New Padding(2, 0, 2, 0)
        lbTgl.Name = "lbTgl"
        lbTgl.Size = New Size(121, 26)
        lbTgl.TabIndex = 8
        lbTgl.Text = "Tanggal Lahir"
        ' 
        ' dtpTgl
        ' 
        dtpTgl.Format = DateTimePickerFormat.Short
        dtpTgl.Location = New Point(383, 178)
        dtpTgl.Margin = New Padding(2, 4, 2, 4)
        dtpTgl.Name = "dtpTgl"
        dtpTgl.Size = New Size(234, 30)
        dtpTgl.TabIndex = 10
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Font = New Font("Sitka Heading", 9F, FontStyle.Bold Or FontStyle.Italic)
        lblAlamat.Location = New Point(244, 284)
        lblAlamat.Margin = New Padding(2, 0, 2, 0)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(68, 26)
        lblAlamat.TabIndex = 11
        lblAlamat.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.ForeColor = SystemColors.WindowText
        txtAlamat.Location = New Point(362, 281)
        txtAlamat.Margin = New Padding(2, 4, 2, 4)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(255, 30)
        txtAlamat.TabIndex = 12
        ' 
        ' gbJenisKelamin
        ' 
        gbJenisKelamin.BackColor = SystemColors.ButtonHighlight
        gbJenisKelamin.Controls.Add(rbPerempuan)
        gbJenisKelamin.Controls.Add(rbLaki)
        gbJenisKelamin.Font = New Font("Sitka Subheading", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbJenisKelamin.Location = New Point(244, 319)
        gbJenisKelamin.Margin = New Padding(2, 4, 2, 4)
        gbJenisKelamin.Name = "gbJenisKelamin"
        gbJenisKelamin.Padding = New Padding(2, 4, 2, 4)
        gbJenisKelamin.Size = New Size(373, 67)
        gbJenisKelamin.TabIndex = 13
        gbJenisKelamin.TabStop = False
        gbJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.BackColor = SystemColors.ButtonHighlight
        rbPerempuan.BackgroundImageLayout = ImageLayout.Center
        rbPerempuan.Font = New Font("Sitka Banner", 9F)
        rbPerempuan.Location = New Point(213, 27)
        rbPerempuan.Margin = New Padding(2, 4, 2, 4)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(116, 30)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = False
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.BackColor = SystemColors.ButtonHighlight
        rbLaki.BackgroundImageLayout = ImageLayout.Center
        rbLaki.Font = New Font("Sitka Banner", 9F)
        rbLaki.Location = New Point(11, 30)
        rbLaki.Margin = New Padding(2, 4, 2, 4)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(101, 30)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = False
        ' 
        ' gbHobi
        ' 
        gbHobi.BackColor = SystemColors.ButtonHighlight
        gbHobi.BackgroundImageLayout = ImageLayout.Center
        gbHobi.Controls.Add(btnCetak)
        gbHobi.Controls.Add(cbLainnya)
        gbHobi.Controls.Add(cbMenari)
        gbHobi.Controls.Add(cbFotografi)
        gbHobi.Controls.Add(cbTraveling)
        gbHobi.Controls.Add(cbGaming)
        gbHobi.Controls.Add(cbMusik)
        gbHobi.Controls.Add(cbMemasak)
        gbHobi.Controls.Add(cbMenulis)
        gbHobi.Controls.Add(cbMembaca)
        gbHobi.Controls.Add(cbOlahraga)
        gbHobi.Font = New Font("Sitka Subheading", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbHobi.Location = New Point(634, 72)
        gbHobi.Margin = New Padding(2, 4, 2, 4)
        gbHobi.Name = "gbHobi"
        gbHobi.Padding = New Padding(2, 4, 2, 4)
        gbHobi.Size = New Size(263, 314)
        gbHobi.TabIndex = 14
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.SteelBlue
        btnCetak.Font = New Font("Sitka Small", 9F, FontStyle.Bold)
        btnCetak.ForeColor = SystemColors.ControlLightLight
        btnCetak.Location = New Point(45, 247)
        btnCetak.Margin = New Padding(2, 4, 2, 4)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(173, 43)
        btnCetak.TabIndex = 15
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' cbLainnya
        ' 
        cbLainnya.AutoSize = True
        cbLainnya.Font = New Font("Sitka Banner", 9F)
        cbLainnya.Location = New Point(145, 178)
        cbLainnya.Margin = New Padding(2, 4, 2, 4)
        cbLainnya.Name = "cbLainnya"
        cbLainnya.Size = New Size(93, 30)
        cbLainnya.TabIndex = 9
        cbLainnya.Text = "Lainnya"
        cbLainnya.UseVisualStyleBackColor = True
        ' 
        ' cbMenari
        ' 
        cbMenari.AutoSize = True
        cbMenari.Font = New Font("Sitka Banner", 9F)
        cbMenari.Location = New Point(145, 138)
        cbMenari.Margin = New Padding(2, 4, 2, 4)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(87, 30)
        cbMenari.TabIndex = 8
        cbMenari.Text = "Menari"
        cbMenari.UseVisualStyleBackColor = True
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.Font = New Font("Sitka Banner", 9F)
        cbFotografi.Location = New Point(145, 102)
        cbFotografi.Margin = New Padding(2, 4, 2, 4)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(99, 30)
        cbFotografi.TabIndex = 7
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = True
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Font = New Font("Sitka Banner", 9F)
        cbTraveling.Location = New Point(145, 65)
        cbTraveling.Margin = New Padding(2, 4, 2, 4)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(102, 30)
        cbTraveling.TabIndex = 6
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Font = New Font("Sitka Banner", 9F)
        cbGaming.Location = New Point(145, 30)
        cbGaming.Margin = New Padding(2, 4, 2, 4)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(92, 30)
        cbGaming.TabIndex = 5
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Font = New Font("Sitka Banner", 9F)
        cbMusik.Location = New Point(11, 178)
        cbMusik.Margin = New Padding(2, 4, 2, 4)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(80, 30)
        cbMusik.TabIndex = 4
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbMemasak
        ' 
        cbMemasak.AutoSize = True
        cbMemasak.Font = New Font("Sitka Banner", 9F)
        cbMemasak.Location = New Point(11, 138)
        cbMemasak.Margin = New Padding(2, 4, 2, 4)
        cbMemasak.Name = "cbMemasak"
        cbMemasak.Size = New Size(104, 30)
        cbMemasak.TabIndex = 3
        cbMemasak.Text = "Memasak"
        cbMemasak.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Font = New Font("Sitka Banner", 9F)
        cbMenulis.Location = New Point(11, 102)
        cbMenulis.Margin = New Padding(2, 4, 2, 4)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(92, 30)
        cbMenulis.TabIndex = 2
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Font = New Font("Sitka Banner", 9F)
        cbMembaca.Location = New Point(11, 65)
        cbMembaca.Margin = New Padding(2, 4, 2, 4)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(105, 30)
        cbMembaca.TabIndex = 1
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Font = New Font("Sitka Banner", 9F)
        cbOlahraga.Location = New Point(11, 30)
        cbOlahraga.Margin = New Padding(2, 4, 2, 4)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(101, 30)
        cbOlahraga.TabIndex = 0
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' FormCetak
        ' 
        AutoScaleDimensions = New SizeF(9F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(924, 468)
        Controls.Add(gbHobi)
        Controls.Add(gbJenisKelamin)
        Controls.Add(txtAlamat)
        Controls.Add(lblAlamat)
        Controls.Add(dtpTgl)
        Controls.Add(lbTgl)
        Controls.Add(txtNomor)
        Controls.Add(lblNomor)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(btnBrowse)
        Controls.Add(pbFoto)
        Font = New Font("Sitka Banner", 9F)
        Margin = New Padding(2, 4, 2, 4)
        Name = "FormCetak"
        Text = "Form Cetak Kartu"
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        gbJenisKelamin.ResumeLayout(False)
        gbJenisKelamin.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents lblNomor As Label
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents lbTgl As Label
    Friend WithEvents dtpTgl As DateTimePicker
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents gbJenisKelamin As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents cbLainnya As CheckBox
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cbMenulis As CheckBox

End Class
