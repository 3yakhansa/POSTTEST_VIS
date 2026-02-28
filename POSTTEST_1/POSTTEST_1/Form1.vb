Public Class Form1
    Private totalIPSemester As Double = 0
    Private jumlahSemester As Integer = 0

    Private Sub btnTambah_click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipSemester As Double
        If Double.TryParse(txtIPSemester.Text, ipSemester) Then
            If ipSemester < 0 Or ipSemester > 4 Then
                MessageBox.Show("Nilai IP Semester harus antara 0 dan 4.")
                Return
            End If

            totalIPSemester += ipSemester
            jumlahSemester += 1

            Dim ipKumulatif As Double = totalIPSemester / jumlahSemester
            txtIPKumulatif.Text = ipKumulatif.ToString("F2")

            If ipKumulatif >= 3.5 Then
                lblStatus.Text = "Cum Laude"
            ElseIf ipKumulatif >= 3.0 Then
                lblStatus.Text = "Sangat Memuaskan"
            ElseIf ipKumulatif >= 2.5 Then
                lblStatus.Text = "Memuaskan"
            Else
                lblStatus.Text = "Tidak Memuaskan"
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIPSemester = 0
        jumlahSemester = 0
        txtIPKumulatif.Text = ""
        lblStatus.Text = ""
        txtIPSemester.Text = ""
    End Sub
    Private Sub lblIPSemester_Click(sender As Object, e As EventArgs) Handles lblIPSemester.Click

    End Sub

    Private Sub txtIPSemester_TextChanged(sender As Object, e As EventArgs) Handles txtIPSemester.TextChanged, txtIPSemester.TextChanged

    End Sub

    Private Sub txtIPSemester_KeyPr(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtIPSemester_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIPSemester.KeyPress

    End Sub

    Private Sub txtIPKumulatif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIPKumulatif.KeyPress

    End Sub
End Class
