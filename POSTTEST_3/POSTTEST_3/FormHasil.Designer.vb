<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHasil))
        btnTutup = New Button()
        btnPrint = New Button()
        lblHasilNama = New Label()
        txtHasilNama = New TextBox()
        lblHasilUmur = New Label()
        txtHasilUmur = New TextBox()
        lblHasilTglLahir = New Label()
        txtHasilTglLahir = New TextBox()
        lblHasilTelp = New Label()
        txtHasilTelp = New TextBox()
        lblHasilJK = New Label()
        txtHasilJK = New TextBox()
        lblHasilHobby = New Label()
        txtHasilHobby = New TextBox()
        lblHasilAlamat = New Label()
        txtHasilAlamat = New TextBox()
        lblTglCetak = New Label()
        panelData = New Panel()
        pbFoto = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        panelData.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.LightYellow
        btnTutup.Font = New Font("Sitka Small", 10.0F, FontStyle.Bold)
        btnTutup.ForeColor = Color.DarkGoldenrod
        btnTutup.Location = New Point(684, 471)
        btnTutup.Margin = New Padding(2, 4, 2, 4)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(175, 40)
        btnTutup.TabIndex = 3
        btnTutup.Text = "❌ Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.LightYellow
        btnPrint.Font = New Font("Sitka Small", 10.0F, FontStyle.Bold)
        btnPrint.ForeColor = Color.DarkGoldenrod
        btnPrint.Location = New Point(505, 471)
        btnPrint.Margin = New Padding(2, 4, 2, 4)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(175, 40)
        btnPrint.TabIndex = 4
        btnPrint.Text = "🖨️ Print"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' lblHasilNama
        ' 
        lblHasilNama.AutoSize = True
        lblHasilNama.BackColor = Color.Transparent
        lblHasilNama.Font = New Font("Sitka Heading", 10.0F, FontStyle.Bold Or FontStyle.Italic)
        lblHasilNama.Location = New Point(32, 20)
        lblHasilNama.Margin = New Padding(2, 0, 2, 0)
        lblHasilNama.Name = "lblHasilNama"
        lblHasilNama.Size = New Size(71, 29)
        lblHasilNama.TabIndex = 0
        lblHasilNama.Text = "Nama:"
        ' 
        ' txtHasilNama
        ' 
        txtHasilNama.BackColor = Color.White
        txtHasilNama.Font = New Font("Sitka Banner", 10.0F, FontStyle.Bold)
        txtHasilNama.ForeColor = Color.DarkGoldenrod
        txtHasilNama.Location = New Point(196, 20)
        txtHasilNama.Margin = New Padding(2, 4, 2, 4)
        txtHasilNama.Name = "txtHasilNama"
        txtHasilNama.ReadOnly = True
        txtHasilNama.Size = New Size(300, 33)
        txtHasilNama.TabIndex = 1
        ' 
        ' lblHasilUmur
        ' 
        lblHasilUmur.AutoSize = True
        lblHasilUmur.BackColor = Color.Transparent
        lblHasilUmur.Font = New Font("Sitka Heading", 10.0F, FontStyle.Bold Or FontStyle.Italic)
        lblHasilUmur.Location = New Point(32, 69)
        lblHasilUmur.Margin = New Padding(2, 0, 2, 0)
        lblHasilUmur.Name = "lblHasilUmur"
        lblHasilUmur.Size = New Size(71, 29)
        lblHasilUmur.TabIndex = 2
        lblHasilUmur.Text = "Umur:"
        ' 
        ' txtHasilUmur
        ' 
        txtHasilUmur.BackColor = Color.White
        txtHasilUmur.ForeColor = Color.DarkGoldenrod
        txtHasilUmur.Location = New Point(196, 68)
        txtHasilUmur.Margin = New Padding(2, 4, 2, 4)
        txtHasilUmur.Name = "txtHasilUmur"
        txtHasilUmur.ReadOnly = True
        txtHasilUmur.Size = New Size(300, 30)
        txtHasilUmur.TabIndex = 3
        ' 
        ' lblHasilTglLahir
        ' 
        lblHasilTglLahir.AutoSize = True
        lblHasilTglLahir.BackColor = Color.Transparent
        lblHasilTglLahir.Font = New Font("Sitka Heading", 10.0F, FontStyle.Bold Or FontStyle.Italic)
        lblHasilTglLahir.Location = New Point(32, 109)
        lblHasilTglLahir.Margin = New Padding(2, 0, 2, 0)
        lblHasilTglLahir.Name = "lblHasilTglLahir"
        lblHasilTglLahir.Size = New Size(142, 29)
        lblHasilTglLahir.TabIndex = 4
        lblHasilTglLahir.Text = "Tanggal Lahir:"
        ' 
        ' txtHasilTglLahir
        ' 
        txtHasilTglLahir.BackColor = Color.White
        txtHasilTglLahir.ForeColor = Color.DarkGoldenrod
        txtHasilTglLahir.Location = New Point(196, 108)
        txtHasilTglLahir.Margin = New Padding(2, 4, 2, 4)
        txtHasilTglLahir.Name = "txtHasilTglLahir"
        txtHasilTglLahir.ReadOnly = True
        txtHasilTglLahir.Size = New Size(300, 30)
        txtHasilTglLahir.TabIndex = 5
        ' 
        ' lblHasilTelp
        ' 
        lblHasilTelp.AutoSize = True
        lblHasilTelp.BackColor = Color.Transparent
        lblHasilTelp.Font = New Font("Sitka Heading", 10.0F, FontStyle.Bold Or FontStyle.Italic)
        lblHasilTelp.Location = New Point(32, 155)
        lblHasilTelp.Margin = New Padding(2, 0, 2, 0)
        lblHasilTelp.Name = "lblHasilTelp"
        lblHasilTelp.Size = New Size(122, 29)
        lblHasilTelp.TabIndex = 6
        lblHasilTelp.Text = "No. Telepon:"
        ' 
        ' txtHasilTelp
        ' 
        txtHasilTelp.BackColor = Color.White
        txtHasilTelp.ForeColor = Color.DarkGoldenrod
        txtHasilTelp.Location = New Point(196, 155)
        txtHasilTelp.Margin = New Padding(2, 4, 2, 4)
        txtHasilTelp.Name = "txtHasilTelp"
        txtHasilTelp.ReadOnly = True
        txtHasilTelp.Size = New Size(300, 30)
        txtHasilTelp.TabIndex = 7
        ' 
        ' lblHasilJK
        ' 
        lblHasilJK.AutoSize = True
        lblHasilJK.BackColor = Color.Transparent
        lblHasilJK.Font = New Font("Sitka Heading", 10.0F, FontStyle.Bold Or FontStyle.Italic)
        lblHasilJK.Location = New Point(32, 202)
        lblHasilJK.Margin = New Padding(2, 0, 2, 0)
        lblHasilJK.Name = "lblHasilJK"
        lblHasilJK.Size = New Size(138, 29)
        lblHasilJK.TabIndex = 8
        lblHasilJK.Text = "Jenis Kelamin:"
        ' 
        ' txtHasilJK
        ' 
        txtHasilJK.BackColor = Color.White
        txtHasilJK.ForeColor = Color.DarkGoldenrod
        txtHasilJK.Location = New Point(196, 202)
        txtHasilJK.Margin = New Padding(2, 4, 2, 4)
        txtHasilJK.Name = "txtHasilJK"
        txtHasilJK.ReadOnly = True
        txtHasilJK.Size = New Size(300, 30)
        txtHasilJK.TabIndex = 9
        ' 
        ' lblHasilHobby
        ' 
        lblHasilHobby.AutoSize = True
        lblHasilHobby.BackColor = Color.Transparent
        lblHasilHobby.Font = New Font("Sitka Heading", 10.0F, FontStyle.Bold Or FontStyle.Italic)
        lblHasilHobby.Location = New Point(32, 243)
        lblHasilHobby.Margin = New Padding(2, 0, 2, 0)
        lblHasilHobby.Name = "lblHasilHobby"
        lblHasilHobby.Size = New Size(62, 29)
        lblHasilHobby.TabIndex = 10
        lblHasilHobby.Text = "Hobi:"
        ' 
        ' txtHasilHobby
        ' 
        txtHasilHobby.BackColor = Color.White
        txtHasilHobby.ForeColor = Color.DarkGoldenrod
        txtHasilHobby.Location = New Point(196, 242)
        txtHasilHobby.Margin = New Padding(2, 4, 2, 4)
        txtHasilHobby.Multiline = True
        txtHasilHobby.Name = "txtHasilHobby"
        txtHasilHobby.ReadOnly = True
        txtHasilHobby.ScrollBars = ScrollBars.Vertical
        txtHasilHobby.Size = New Size(300, 50)
        txtHasilHobby.TabIndex = 11
        ' 
        ' lblHasilAlamat
        ' 
        lblHasilAlamat.AutoSize = True
        lblHasilAlamat.BackColor = Color.Transparent
        lblHasilAlamat.Font = New Font("Sitka Heading", 10.0F, FontStyle.Bold Or FontStyle.Italic)
        lblHasilAlamat.Location = New Point(32, 301)
        lblHasilAlamat.Margin = New Padding(2, 0, 2, 0)
        lblHasilAlamat.Name = "lblHasilAlamat"
        lblHasilAlamat.Size = New Size(83, 29)
        lblHasilAlamat.TabIndex = 12
        lblHasilAlamat.Text = "Alamat:"
        ' 
        ' txtHasilAlamat
        ' 
        txtHasilAlamat.BackColor = Color.White
        txtHasilAlamat.ForeColor = Color.DarkGoldenrod
        txtHasilAlamat.Location = New Point(196, 300)
        txtHasilAlamat.Margin = New Padding(2, 4, 2, 4)
        txtHasilAlamat.Multiline = True
        txtHasilAlamat.Name = "txtHasilAlamat"
        txtHasilAlamat.ReadOnly = True
        txtHasilAlamat.ScrollBars = ScrollBars.Vertical
        txtHasilAlamat.Size = New Size(300, 80)
        txtHasilAlamat.TabIndex = 13
        ' 
        ' lblTglCetak
        ' 
        lblTglCetak.AutoSize = True
        lblTglCetak.BackColor = Color.Transparent
        lblTglCetak.Font = New Font("Sitka Banner", 8.0F, FontStyle.Italic)
        lblTglCetak.ForeColor = Color.Gray
        lblTglCetak.Location = New Point(20, 390)
        lblTglCetak.Margin = New Padding(2, 0, 2, 0)
        lblTglCetak.Name = "lblTglCetak"
        lblTglCetak.Size = New Size(0, 23)
        lblTglCetak.TabIndex = 16
        ' 
        ' panelData
        ' 
        panelData.BackColor = Color.FloralWhite
        panelData.Controls.Add(lblTglCetak)
        panelData.Controls.Add(txtHasilAlamat)
        panelData.Controls.Add(lblHasilAlamat)
        panelData.Controls.Add(txtHasilHobby)
        panelData.Controls.Add(lblHasilHobby)
        panelData.Controls.Add(lblHasilNama)
        panelData.Controls.Add(txtHasilJK)
        panelData.Controls.Add(lblHasilJK)
        panelData.Controls.Add(txtHasilTelp)
        panelData.Controls.Add(lblHasilTelp)
        panelData.Controls.Add(txtHasilTglLahir)
        panelData.Controls.Add(lblHasilTglLahir)
        panelData.Controls.Add(txtHasilUmur)
        panelData.Controls.Add(lblHasilUmur)
        panelData.Controls.Add(txtHasilNama)
        panelData.ForeColor = Color.DarkGoldenrod
        panelData.Location = New Point(347, 68)
        panelData.Margin = New Padding(2, 4, 2, 4)
        panelData.Name = "panelData"
        panelData.Size = New Size(512, 395)
        panelData.TabIndex = 2
        ' 
        ' pbFoto
        ' 
        pbFoto.BackColor = Color.White
        pbFoto.BorderStyle = BorderStyle.Fixed3D
        pbFoto.Location = New Point(90, 140)
        pbFoto.Margin = New Padding(2, 4, 2, 4)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(182, 239)
        pbFoto.TabIndex = 5
        pbFoto.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 16.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Olive
        Label1.Location = New Point(63, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 40)
        Label1.TabIndex = 6
        Label1.Text = "KARTU MEMBER"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 16.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Olive
        Label2.Location = New Point(98, 391)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 40)
        Label2.TabIndex = 7
        Label2.Text = "PawPatrol"
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 26.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1015, 529)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pbFoto)
        Controls.Add(btnPrint)
        Controls.Add(btnTutup)
        Controls.Add(panelData)
        Font = New Font("Sitka Banner", 9.0F)
        ForeColor = Color.DarkGoldenrod
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2, 4, 2, 4)
        Name = "FormHasil"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kartu Komunitas PawPatrol"
        panelData.ResumeLayout(False)
        panelData.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnPrint As Button

    Private Sub lblJudulKartu_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblSubJudul_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblHasilHobby_Click(sender As Object, e As EventArgs) Handles lblHasilHobby.Click

    End Sub

    Friend WithEvents lblHasilNama As Label
    Friend WithEvents txtHasilNama As TextBox
    Friend WithEvents lblHasilUmur As Label
    Friend WithEvents txtHasilUmur As TextBox
    Friend WithEvents lblHasilTglLahir As Label
    Friend WithEvents txtHasilTglLahir As TextBox
    Friend WithEvents lblHasilTelp As Label
    Friend WithEvents txtHasilTelp As TextBox
    Friend WithEvents lblHasilJK As Label
    Friend WithEvents txtHasilJK As TextBox
    Friend WithEvents lblHasilHobby As Label
    Friend WithEvents txtHasilHobby As TextBox
    Friend WithEvents lblHasilAlamat As Label
    Friend WithEvents txtHasilAlamat As TextBox
    Friend WithEvents lblTglCetak As Label
    Friend WithEvents panelData As Panel
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents Label1 As Label

    Private Sub txtHasilHobby_TextChanged(sender As Object, e As EventArgs) Handles txtHasilHobby.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Friend WithEvents Label2 As Label
End Class