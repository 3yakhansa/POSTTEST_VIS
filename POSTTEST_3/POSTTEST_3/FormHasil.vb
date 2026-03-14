Partial Class FormHasil
    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property DataNama As String

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property DataUmur As String

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property DataTelp As String

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property DataAlamat As String

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property DataTglLahir As String

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property DataJK As String

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property DataHobi As String

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
    Public Property DataFoto As Image

    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHasilNama.Text = DataNama
        txtHasilUmur.Text = DataUmur
        txtHasilTelp.Text = DataTelp
        txtHasilAlamat.Text = DataAlamat
        txtHasilTglLahir.Text = DataTglLahir
        txtHasilJK.Text = DataJK
        txtHasilHobby.Text = DataHobi

        If DataFoto IsNot Nothing Then
            pbFoto.Image = DataFoto
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        lblTglCetak.Text = "Dicetak pada: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm")
    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim printDoc As New Printing.PrintDocument()
        Dim printDlg As New PrintDialog()
        printDlg.Document = printDoc

        If printDlg.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("Kartu lagi dicetak...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class