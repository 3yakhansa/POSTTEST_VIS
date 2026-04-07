<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        menuStrip = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TabControl1 = New TabControl()
        dataUtama = New TabPage()
        cbKomunitas = New ComboBox()
        lblJenisKelamin = New Label()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        lblTtl = New Label()
        dateTgl = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        kontakInfo = New TabPage()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtbTelepon = New MaskedTextBox()
        profilAktivitas = New TabPage()
        btnCetak = New Button()
        gbAktivitas = New GroupBox()
        CheckBox5 = New CheckBox()
        cbMod = New CheckBox()
        cbChallenge = New CheckBox()
        CheckBox8 = New CheckBox()
        cbScreenshot = New CheckBox()
        cbUrban = New CheckBox()
        cbPlugin = New CheckBox()
        cbCityBuild = New CheckBox()
        gbPeran = New GroupBox()
        cbAnggota = New CheckBox()
        cbAdmin = New CheckBox()
        cbKetua = New CheckBox()
        btnBrowse = New Button()
        PictureBox2 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        menuStrip.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        dataUtama.SuspendLayout()
        kontakInfo.SuspendLayout()
        profilAktivitas.SuspendLayout()
        gbAktivitas.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' menuStrip
        ' 
        menuStrip.ImageScalingSize = New Size(24, 24)
        menuStrip.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        menuStrip.Location = New Point(0, 0)
        menuStrip.Name = "menuStrip"
        menuStrip.Size = New Size(933, 33)
        menuStrip.TabIndex = 0
        menuStrip.Text = "menuStrip"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(112, 29)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKToolStripMenuItem
        ' 
        LihatKToolStripMenuItem.Name = "LihatKToolStripMenuItem"
        LihatKToolStripMenuItem.Size = New Size(111, 29)
        LihatKToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(130, 29)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(108, 29)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(76, 29)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FloralWhite
        Label1.Location = New Point(283, 232)
        Label1.Name = "Label1"
        Label1.Size = New Size(380, 35)
        Label1.TabIndex = 1
        Label1.Text = "Komunitas Player TheoTown"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(254, 50)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(448, 170)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(dataUtama)
        TabControl1.Controls.Add(kontakInfo)
        TabControl1.Controls.Add(profilAktivitas)
        TabControl1.Location = New Point(34, 278)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(866, 294)
        TabControl1.TabIndex = 3
        ' 
        ' dataUtama
        ' 
        dataUtama.Controls.Add(cbKomunitas)
        dataUtama.Controls.Add(lblJenisKelamin)
        dataUtama.Controls.Add(rbPerempuan)
        dataUtama.Controls.Add(rbLaki)
        dataUtama.Controls.Add(lblTtl)
        dataUtama.Controls.Add(dateTgl)
        dataUtama.Controls.Add(txtID)
        dataUtama.Controls.Add(txtNama)
        dataUtama.Location = New Point(4, 34)
        dataUtama.Name = "dataUtama"
        dataUtama.Padding = New Padding(3)
        dataUtama.Size = New Size(858, 256)
        dataUtama.TabIndex = 0
        dataUtama.Text = "Data Utama"
        dataUtama.UseVisualStyleBackColor = True
        ' 
        ' cbKomunitas
        ' 
        cbKomunitas.FormattingEnabled = True
        cbKomunitas.Items.AddRange(New Object() {"Plugin Creator Community", "City Builder & Sharing Community", "Beta Tester Community"})
        cbKomunitas.Location = New Point(369, 101)
        cbKomunitas.Name = "cbKomunitas"
        cbKomunitas.Size = New Size(340, 33)
        cbKomunitas.TabIndex = 7
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.Location = New Point(365, 13)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(120, 25)
        lblJenisKelamin.TabIndex = 6
        lblJenisKelamin.Text = "Jenis Kelamin:"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(517, 44)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(126, 29)
        rbPerempuan.TabIndex = 5
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(373, 44)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(100, 29)
        rbLaki.TabIndex = 4
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' lblTtl
        ' 
        lblTtl.AutoSize = True
        lblTtl.Location = New Point(11, 112)
        lblTtl.Name = "lblTtl"
        lblTtl.Size = New Size(119, 25)
        lblTtl.TabIndex = 3
        lblTtl.Text = "Tanggal Lahir:"
        ' 
        ' dateTgl
        ' 
        dateTgl.Location = New Point(16, 142)
        dateTgl.Name = "dateTgl"
        dateTgl.Size = New Size(300, 31)
        dateTgl.TabIndex = 2
        ' 
        ' txtID
        ' 
        txtID.BackColor = SystemColors.ButtonFace
        txtID.Location = New Point(16, 62)
        txtID.Name = "txtID"
        txtID.Size = New Size(300, 31)
        txtID.TabIndex = 1
        txtID.Text = "ID Anggota:"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = SystemColors.ButtonFace
        txtNama.Location = New Point(16, 13)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(300, 31)
        txtNama.TabIndex = 0
        txtNama.Text = "Nama: "
        ' 
        ' kontakInfo
        ' 
        kontakInfo.Controls.Add(txtAlamat)
        kontakInfo.Controls.Add(txtEmail)
        kontakInfo.Controls.Add(mtbTelepon)
        kontakInfo.Location = New Point(4, 34)
        kontakInfo.Name = "kontakInfo"
        kontakInfo.Padding = New Padding(3)
        kontakInfo.Size = New Size(858, 256)
        kontakInfo.TabIndex = 1
        kontakInfo.Text = "Kontak & Info"
        kontakInfo.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(36, 157)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(273, 77)
        txtAlamat.TabIndex = 2
        txtAlamat.Text = "Alamat:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(38, 101)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(273, 31)
        txtEmail.TabIndex = 1
        txtEmail.Text = "Email:"
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(36, 40)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(275, 31)
        mtbTelepon.TabIndex = 0
        ' 
        ' profilAktivitas
        ' 
        profilAktivitas.Controls.Add(btnCetak)
        profilAktivitas.Controls.Add(gbAktivitas)
        profilAktivitas.Controls.Add(gbPeran)
        profilAktivitas.Controls.Add(btnBrowse)
        profilAktivitas.Controls.Add(PictureBox2)
        profilAktivitas.Location = New Point(4, 34)
        profilAktivitas.Name = "profilAktivitas"
        profilAktivitas.Size = New Size(858, 256)
        profilAktivitas.TabIndex = 2
        profilAktivitas.Text = "Profil & Aktivitas"
        profilAktivitas.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.Teal
        btnCetak.ForeColor = SystemColors.ButtonHighlight
        btnCetak.Location = New Point(640, 202)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(170, 34)
        btnCetak.TabIndex = 4
        btnCetak.Text = "Simpam dan Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' gbAktivitas
        ' 
        gbAktivitas.Controls.Add(CheckBox5)
        gbAktivitas.Controls.Add(cbMod)
        gbAktivitas.Controls.Add(cbChallenge)
        gbAktivitas.Controls.Add(CheckBox8)
        gbAktivitas.Controls.Add(cbScreenshot)
        gbAktivitas.Controls.Add(cbUrban)
        gbAktivitas.Controls.Add(cbPlugin)
        gbAktivitas.Controls.Add(cbCityBuild)
        gbAktivitas.Location = New Point(420, 14)
        gbAktivitas.Name = "gbAktivitas"
        gbAktivitas.Size = New Size(390, 182)
        gbAktivitas.TabIndex = 3
        gbAktivitas.TabStop = False
        gbAktivitas.Text = "Aktivitas"
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(191, 140)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(145, 29)
        CheckBox5.TabIndex = 7
        CheckBox5.Text = "Eco City Build"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' cbMod
        ' 
        cbMod.AutoSize = True
        cbMod.Location = New Point(191, 105)
        cbMod.Name = "cbMod"
        cbMod.Size = New Size(112, 29)
        cbMod.TabIndex = 6
        cbMod.Text = "Modding"
        cbMod.UseVisualStyleBackColor = True
        ' 
        ' cbChallenge
        ' 
        cbChallenge.AutoSize = True
        cbChallenge.Location = New Point(191, 70)
        cbChallenge.Name = "cbChallenge"
        cbChallenge.Size = New Size(120, 29)
        cbChallenge.TabIndex = 5
        cbChallenge.Text = "Challenge "
        cbChallenge.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(191, 35)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(186, 29)
        CheckBox8.TabIndex = 4
        CheckBox8.Text = "Multiplayer Region"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' cbScreenshot
        ' 
        cbScreenshot.AutoSize = True
        cbScreenshot.Location = New Point(18, 140)
        cbScreenshot.Name = "cbScreenshot"
        cbScreenshot.Size = New Size(98, 29)
        cbScreenshot.TabIndex = 3
        cbScreenshot.Text = "Sharing"
        cbScreenshot.UseVisualStyleBackColor = True
        ' 
        ' cbUrban
        ' 
        cbUrban.AutoSize = True
        cbUrban.Location = New Point(18, 105)
        cbUrban.Name = "cbUrban"
        cbUrban.Size = New Size(159, 29)
        cbUrban.TabIndex = 2
        cbUrban.Text = "Urban Planning"
        cbUrban.UseVisualStyleBackColor = True
        ' 
        ' cbPlugin
        ' 
        cbPlugin.AutoSize = True
        cbPlugin.Location = New Point(18, 70)
        cbPlugin.Name = "cbPlugin"
        cbPlugin.Size = New Size(158, 29)
        cbPlugin.TabIndex = 1
        cbPlugin.Text = "Plugin Creation"
        cbPlugin.UseVisualStyleBackColor = True
        ' 
        ' cbCityBuild
        ' 
        cbCityBuild.AutoSize = True
        cbCityBuild.Location = New Point(18, 35)
        cbCityBuild.Name = "cbCityBuild"
        cbCityBuild.Size = New Size(137, 29)
        cbCityBuild.TabIndex = 0
        cbCityBuild.Text = "City Building"
        cbCityBuild.UseVisualStyleBackColor = True
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(cbAnggota)
        gbPeran.Controls.Add(cbAdmin)
        gbPeran.Controls.Add(cbKetua)
        gbPeran.Location = New Point(216, 14)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(197, 180)
        gbPeran.TabIndex = 2
        gbPeran.TabStop = False
        gbPeran.Text = "Peran"
        ' 
        ' cbAnggota
        ' 
        cbAnggota.AutoSize = True
        cbAnggota.Location = New Point(18, 111)
        cbAnggota.Name = "cbAnggota"
        cbAnggota.Size = New Size(108, 29)
        cbAnggota.TabIndex = 2
        cbAnggota.Text = "Anggota"
        cbAnggota.UseVisualStyleBackColor = True
        ' 
        ' cbAdmin
        ' 
        cbAdmin.AutoSize = True
        cbAdmin.Location = New Point(18, 76)
        cbAdmin.Name = "cbAdmin"
        cbAdmin.Size = New Size(91, 29)
        cbAdmin.TabIndex = 1
        cbAdmin.Text = "Admin"
        cbAdmin.UseVisualStyleBackColor = True
        ' 
        ' cbKetua
        ' 
        cbKetua.AutoSize = True
        cbKetua.Location = New Point(18, 41)
        cbKetua.Name = "cbKetua"
        cbKetua.Size = New Size(82, 29)
        cbKetua.TabIndex = 0
        cbKetua.Text = "Ketua"
        cbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.DarkCyan
        btnBrowse.ForeColor = SystemColors.ButtonHighlight
        btnBrowse.Location = New Point(48, 201)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(112, 34)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.InactiveCaption
        PictureBox2.Location = New Point(28, 9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(150, 185)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(933, 616)
        Controls.Add(TabControl1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(menuStrip)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = menuStrip
        Name = "Form1"
        Text = "Form1"
        menuStrip.ResumeLayout(False)
        menuStrip.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        dataUtama.ResumeLayout(False)
        dataUtama.PerformLayout()
        kontakInfo.ResumeLayout(False)
        kontakInfo.PerformLayout()
        profilAktivitas.ResumeLayout(False)
        gbAktivitas.ResumeLayout(False)
        gbAktivitas.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents menuStrip As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents dataUtama As TabPage
    Friend WithEvents kontakInfo As TabPage
    Friend WithEvents profilAktivitas As TabPage
    Friend WithEvents dateTgl As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cbKomunitas As ComboBox
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents lblTtl As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents gbAktivitas As GroupBox
    Friend WithEvents cbScreenshot As CheckBox
    Friend WithEvents cbUrban As CheckBox
    Friend WithEvents cbPlugin As CheckBox
    Friend WithEvents cbCityBuild As CheckBox
    Friend WithEvents cbAnggota As CheckBox
    Friend WithEvents cbAdmin As CheckBox
    Friend WithEvents cbKetua As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents cbMod As CheckBox
    Friend WithEvents cbChallenge As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class
