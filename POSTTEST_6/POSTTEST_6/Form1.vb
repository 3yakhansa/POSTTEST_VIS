Public Class Form1
    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        Me.Hide()
        FormUtama.ShowDialog()
        Application.Exit()
    End Sub
End Class