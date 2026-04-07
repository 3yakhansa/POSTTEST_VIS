<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHasil))
        PictureBox2 = New PictureBox()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        lblAktivitas = New Label()
        Panel1 = New Panel()
        lblNama = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Azure
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox2.Location = New Point(294, 25)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(150, 185)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' lblID
        ' 
        lblID.BackColor = Color.Transparent
        lblID.Font = New Font("SimSun-ExtG", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID.ForeColor = Color.DarkSlateGray
        lblID.Location = New Point(12, 50)
        lblID.Name = "lblID"
        lblID.Size = New Size(320, 25)
        lblID.TabIndex = 3
        lblID.Text = "(ID Pengguna)"
        lblID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKomunitas.ForeColor = Color.DarkSlateGray
        lblKomunitas.Location = New Point(12, 80)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(320, 25)
        lblKomunitas.TabIndex = 4
        lblKomunitas.Text = "(Komunitas)"
        lblKomunitas.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblKontak
        ' 
        lblKontak.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKontak.ForeColor = Color.DarkSlateGray
        lblKontak.Location = New Point(12, 110)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(320, 25)
        lblKontak.TabIndex = 5
        lblKontak.Text = "(Kontak)"
        lblKontak.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAktivitas
        ' 
        lblAktivitas.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAktivitas.ForeColor = Color.DarkSlateGray
        lblAktivitas.Location = New Point(12, 140)
        lblAktivitas.Name = "lblAktivitas"
        lblAktivitas.Size = New Size(320, 25)
        lblAktivitas.TabIndex = 6
        lblAktivitas.Text = "(Aktivitas)"
        lblAktivitas.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Azure
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lblNama)
        Panel1.Controls.Add(lblAktivitas)
        Panel1.Controls.Add(lblKontak)
        Panel1.Controls.Add(lblKomunitas)
        Panel1.Controls.Add(lblID)
        Panel1.Location = New Point(197, 220)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(344, 180)
        Panel1.TabIndex = 7
        ' 
        ' lblNama
        ' 
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Sitka Banner", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = Color.DarkSlateGray
        lblNama.Location = New Point(12, 10)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(320, 35)
        lblNama.TabIndex = 7
        lblNama.Text = "(Nama)"
        lblNama.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(738, 430)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "FormHasil"
        Text = "FormHasil"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblAktivitas As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNama As Label
End Class