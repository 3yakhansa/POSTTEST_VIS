Public Class FormHasil
    Public Sub New(nama As String, id As String, komunitas As String, kontak As String, aktivitas As String, foto As Image)
        InitializeComponent()

        lblNama.Text = nama
        lblID.Text = "ID: " & id
        lblKomunitas.Text = "Komunitas: " & komunitas
        lblKontak.Text = "Kontak: " & kontak
        lblAktivitas.Text = "Aktivitas: " & aktivitas

        If foto IsNot Nothing Then
            PictureBox2.Image = foto
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click, PictureBox2.Click
        Me.Close()
    End Sub
End Class