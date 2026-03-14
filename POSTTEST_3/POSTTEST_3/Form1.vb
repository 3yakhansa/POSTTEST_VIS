Public Class FormCetak

    Private imagePath As String = ""

    Private Sub FormCetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Cuma boleh huruf!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Input angka diks", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub txtNomor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomor.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "+"c Then
            e.Handled = True
            MessageBox.Show("Angka aja ya bolehnya", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Pilih Foto Profile"
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                pbFoto.Image = Image.FromFile(openFileDialog.FileName)
                imagePath = openFileDialog.FileName
                pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Using
    End Sub
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Inputan ga boleh kosong (Nama)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNama.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtUmur.Text) Then
            MessageBox.Show("Inputan ga boleh kosong (Umur)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUmur.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNomor.Text) OrElse txtNomor.Text = "+62" Then
            MessageBox.Show("Inputan ga boleh kosong (Nomor Telepon)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNomor.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            MessageBox.Show("Inputan ga boleh kosong (Alamat)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAlamat.Focus()
            Return
        End If

        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan ga boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            gbJenisKelamin.Focus()
            Return
        End If

        Dim hobbies As New List(Of String)
        If cbOlahraga.Checked Then hobbies.Add("Olahraga")
        If cbMembaca.Checked Then hobbies.Add("Membaca")
        If cbMenulis.Checked Then hobbies.Add("Menulis")
        If cbMemasak.Checked Then hobbies.Add("Memasak")
        If cbMusik.Checked Then hobbies.Add("Musik")
        If cbGaming.Checked Then hobbies.Add("Gaming")
        If cbTraveling.Checked Then hobbies.Add("Traveling")
        If cbFotografi.Checked Then hobbies.Add("Fotografi")
        If cbMenari.Checked Then hobbies.Add("Menari")
        If cbLainnya.Checked Then hobbies.Add("Lainnya")

        If hobbies.Count = 0 Then
            MessageBox.Show("Inputan ga boleh kosong (minimal 1 Hobi)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            gbHobi.Focus()
            Return
        End If

        If pbFoto.Image Is Nothing Then
            MessageBox.Show("Inputan ga boleh kosong (Upload Foto Profile)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim formHasil As New FormHasil()

        formHasil.DataNama = txtNama.Text
        formHasil.DataUmur = txtUmur.Text
        formHasil.DataTelp = txtNomor.Text
        formHasil.DataAlamat = txtAlamat.Text
        formHasil.DataTglLahir = dtpTgl.Value.ToString("dd MMMM yyyy")

        If rbLaki.Checked Then
            formHasil.DataJK = "Laki-Laki"
        Else
            formHasil.DataJK = "Perempuan"
        End If

        formHasil.DataHobi = String.Join(", ", hobbies)

        formHasil.DataFoto = pbFoto.Image

        formHasil.ShowDialog()
    End Sub
End Class