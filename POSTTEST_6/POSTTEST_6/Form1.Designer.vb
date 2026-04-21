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
        lblJudul = New Label()
        btnMasuk = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Britannic Bold", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(159, 283)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(509, 27)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Sisten Manajemen Inventaris Furnitur Informa"
        ' 
        ' btnMasuk
        ' 
        btnMasuk.BackColor = Color.White
        btnMasuk.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMasuk.ForeColor = Color.Navy
        btnMasuk.Location = New Point(556, 332)
        btnMasuk.Name = "btnMasuk"
        btnMasuk.Size = New Size(112, 34)
        btnMasuk.TabIndex = 2
        btnMasuk.Text = "Masuk >>"
        btnMasuk.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(307, 67)
        PictureBox1.MaximumSize = New Size(200, 200)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 200)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(70), CByte(120))
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(btnMasuk)
        Controls.Add(lblJudul)
        Name = "Form1"
        Text = "Sistem Manajemen Inventaris Furnitur"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents btnMasuk As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
