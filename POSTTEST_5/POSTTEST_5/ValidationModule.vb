Imports System.Windows.Forms

Module ValidationModule
    Public Sub ClearErrors(ep As ErrorProvider)
        ep.Clear()
    End Sub

    Public Function ValidateField(ctrl As Control, ep As ErrorProvider, labelName As String) As Boolean
        If String.IsNullOrWhiteSpace(ctrl.Text) Then
            ep.SetError(ctrl, $"{labelName} wajib diisi!")
            Return False
        End If
        ep.SetError(ctrl, "")
        Return True
    End Function

    Public Function IsNumericPositive(text As String, ctrl As Control, ep As ErrorProvider, labelName As String) As Boolean
        If Not Decimal.TryParse(text, Nothing) OrElse Decimal.Parse(text) <= 0 Then
            ep.SetError(ctrl, $"{labelName} harus angka > 0!")
            Return False
        End If
        ep.SetError(ctrl, "")
        Return True
    End Function
End Module