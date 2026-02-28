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
        lblIPSemester = New Label()
        txtIPSemester = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        lblIPKumulatif = New Label()
        txtIPKumulatif = New TextBox()
        lblStatus = New Label()
        SuspendLayout()
        ' 
        ' lblIPSemester
        ' 
        lblIPSemester.AutoSize = True
        lblIPSemester.Location = New Point(235, 117)
        lblIPSemester.Name = "lblIPSemester"
        lblIPSemester.Size = New Size(106, 21)
        lblIPSemester.TabIndex = 0
        lblIPSemester.Text = "IP Semester"
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.ForeColor = SystemColors.Menu
        txtIPSemester.Location = New Point(362, 117)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(253, 28)
        txtIPSemester.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(362, 159)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(123, 29)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(492, 159)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(123, 29)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblIPKumulatif
        ' 
        lblIPKumulatif.AutoSize = True
        lblIPKumulatif.Location = New Point(235, 198)
        lblIPKumulatif.Name = "lblIPKumulatif"
        lblIPKumulatif.Size = New Size(114, 21)
        lblIPKumulatif.TabIndex = 4
        lblIPKumulatif.Text = "IP Kumulatif"
        ' 
        ' txtIPKumulatif
        ' 
        txtIPKumulatif.Location = New Point(362, 197)
        txtIPKumulatif.Name = "txtIPKumulatif"
        txtIPKumulatif.Size = New Size(253, 28)
        txtIPKumulatif.TabIndex = 5
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(362, 236)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(16, 21)
        lblStatus.TabIndex = 6
        lblStatus.Text = "-"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(880, 378)
        Controls.Add(lblStatus)
        Controls.Add(txtIPKumulatif)
        Controls.Add(lblIPKumulatif)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPSemester)
        Controls.Add(lblIPSemester)
        Font = New Font("Baskerville Old Face", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.MidnightBlue
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIPSemester As Label
    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblIPKumulatif As Label
    Friend WithEvents txtIPKumulatif As TextBox
    Friend WithEvents lblStatus As Label

End Class
