Imports System.IO

Public Class Form1
    Private fotoPath As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtbTelepon.Clear()
        PictureBox2.Image = Nothing
        cbKomunitas.SelectedIndex = -1
        rbLaki.Checked = False : rbPerempuan.Checked = False
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtbTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtbTelepon_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles mtbTelepon.Validating
        If Not String.IsNullOrWhiteSpace(mtbTelepon.Text) AndAlso Not mtbTelepon.MaskCompleted Then
            MessageBox.Show("Format nomor telepon nggak sesuai, bro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        With OpenFileDialog1
            .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            .Title = "Pilih Foto Profil"
            If .ShowDialog() = DialogResult.OK Then
                PictureBox2.Image = Image.FromFile(.FileName)
                PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                fotoPath = .FileName
            End If
        End With
    End Sub

    Private Function ValidasiSemua() As Boolean
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse txtNama.Text = "Nama:" OrElse
           String.IsNullOrWhiteSpace(txtID.Text) OrElse txtID.Text = "ID Anggota:" Then
            MessageBox.Show("Inputan nggak boleh kosong, woy!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse txtEmail.Text = "Email:" OrElse
           String.IsNullOrWhiteSpace(txtAlamat.Text) OrElse txtAlamat.Text = "Alamat:" Then
            MessageBox.Show("Inputan nggak boleh kosong, woy!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not mtbTelepon.MaskCompleted Then
            MessageBox.Show("Inputan nggak boleh kosong, woy!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If cbKomunitas.SelectedIndex = -1 Then
            MessageBox.Show("Inputan nggak boleh kosong, woy!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan nggak boleh kosong, woy!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not cbKetua.Checked AndAlso Not cbAdmin.Checked AndAlso Not cbAnggota.Checked Then
            MessageBox.Show("Inputan nggak boleh kosong, woy!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Dim cekAktivitas As Boolean = cbCityBuild.Checked OrElse cbPlugin.Checked OrElse cbUrban.Checked OrElse
                                      cbScreenshot.Checked OrElse CheckBox8.Checked OrElse cbChallenge.Checked OrElse
                                      cbMod.Checked OrElse CheckBox5.Checked
        If Not cekAktivitas Then
            MessageBox.Show("Inputan nggak boleh kosong, woy!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Function GetAktivitas() As String
        Dim list As New List(Of String)
        If cbCityBuild.Checked Then list.Add("City Building")
        If cbPlugin.Checked Then list.Add("Plugin Creation")
        If cbUrban.Checked Then list.Add("Urban Planning")
        If cbScreenshot.Checked Then list.Add("Screenshot & Sharing")
        If CheckBox8.Checked Then list.Add("Multiplayer Region")
        If cbChallenge.Checked Then list.Add("Challenge & Event")
        If cbMod.Checked Then list.Add("Modding")
        If CheckBox5.Checked Then list.Add("Eco-City Building")
        Return String.Join(", ", list)
    End Function

    Private Function GetPeran() As String
        Dim p As String = ""
        If cbKetua.Checked Then p &= "Ketua, "
        If cbAdmin.Checked Then p &= "Admin, "
        If cbAnggota.Checked Then p &= "Anggota"
        Return p.TrimEnd(","c).Trim()
    End Function

    Private Function GetNamaBersih() As String
        Return If(txtNama.Text = "Nama:", "", txtNama.Text)
    End Function

    Private Function GetIDBersih() As String
        Return If(txtID.Text = "ID Anggota:", "", txtID.Text)
    End Function

    Private Function GetEmailBersih() As String
        Return If(txtEmail.Text = "Email:", "", txtEmail.Text)
    End Function

    Private Function GetAlamatBersih() As String
        Return If(txtAlamat.Text = "Alamat:", "", txtAlamat.Text)
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If Not ValidasiSemua() Then Exit Sub

        Dim konfirmasi = MessageBox.Show("Data oke. Lanjut cetak kartu?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            Dim formKartu As New FormHasil(
                GetNamaBersih(),
                GetIDBersih(),
                cbKomunitas.Text,
                mtbTelepon.Text & " | " & GetEmailBersih(),
                GetAktivitas(),
                PictureBox2.Image
            )
            formKartu.ShowDialog()
        End If
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub LihatKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKToolStripMenuItem.Click
        btnCetak.PerformClick()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        If Not ValidasiSemua() Then Exit Sub

        Dim konfirmasi = MessageBox.Show("Yakin mau simpan data ini?", "Konfirmasi Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            With SaveFileDialog1
                .Filter = "Text Files|*.txt|CSV Files|*.csv"
                .Title = "Simpan Data Anggota"
                If .ShowDialog() = DialogResult.OK Then
                    Dim lines As New List(Of String) From {
                        GetNamaBersih(),
                        GetIDBersih(),
                        dateTgl.Value.ToShortDateString(),
                        If(rbLaki.Checked, "Laki-laki", "Perempuan"),
                        cbKomunitas.Text,
                        mtbTelepon.Text,
                        GetEmailBersih(),
                        GetAlamatBersih(),
                        GetPeran(),
                        GetAktivitas(),
                        fotoPath
                    }
                    File.WriteAllLines(.FileName, lines)
                    MessageBox.Show("✅ Data udah disimpen, guys!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        With OpenFileDialog1
            .Filter = "Text/CSV Files|*.txt;*.csv"
            .Title = "Buka Data Anggota"
            If .ShowDialog() = DialogResult.OK Then
                Try
                    Dim lines As String() = File.ReadAllLines(.FileName)
                    If lines.Length >= 11 Then
                        txtNama.Text = If(String.IsNullOrWhiteSpace(lines(0)), "Nama:", lines(0))
                        txtID.Text = If(String.IsNullOrWhiteSpace(lines(1)), "ID Anggota:", lines(1))

                        dateTgl.Value = DateTime.Parse(lines(2))
                        If lines(3) = "Laki-laki" Then rbLaki.Checked = True Else rbPerempuan.Checked = True
                        cbKomunitas.Text = lines(4) : mtbTelepon.Text = lines(5)

                        txtEmail.Text = If(String.IsNullOrWhiteSpace(lines(6)), "Email:", lines(6))
                        txtAlamat.Text = If(String.IsNullOrWhiteSpace(lines(7)), "Alamat:", lines(7))

                        cbKetua.Checked = lines(8).Contains("Ketua")
                        cbAdmin.Checked = lines(8).Contains("Admin")
                        cbAnggota.Checked = lines(8).Contains("Anggota")

                        cbCityBuild.Checked = lines(9).Contains("City Building")
                        cbPlugin.Checked = lines(9).Contains("Plugin Creation")
                        cbUrban.Checked = lines(9).Contains("Urban Planning")
                        cbScreenshot.Checked = lines(9).Contains("Screenshot")
                        CheckBox8.Checked = lines(9).Contains("Multiplayer")
                        cbChallenge.Checked = lines(9).Contains("Challenge")
                        cbMod.Checked = lines(9).Contains("Modding")
                        CheckBox5.Checked = lines(9).Contains("Eco-City")

                        fotoPath = lines(10)
                        If Not String.IsNullOrEmpty(fotoPath) AndAlso File.Exists(fotoPath) Then
                            PictureBox2.Image = Image.FromFile(fotoPath)
                            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                        End If
                        MessageBox.Show("Data berhasil dibuka!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Format file nggak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("❌ Gagal buka file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End With
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim konfirmasi = MessageBox.Show("Yakin mau keluar, bro?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi <> DialogResult.Yes Then
            e.Cancel = True
        End If
    End Sub
End Class