Module Module1
    ' arr daftarBuku untuk nyimpan data buku
    Public daftarBuku(100, 1) As String
    Public jumlahBuku As Integer = 0

    ' function nyari indeks dari judul buku
    Public Function CariIndexBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judul.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function

    ' function validasi judul minimal 3 karakter 
    Public Function ValidasiJudul(ByVal judul As String) As Boolean
        Return judul.Trim().Length >= 3
    End Function

    ' procedure nambah buku ke arr
    Public Sub TambahBukuData(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul.Trim()
            daftarBuku(jumlahBuku, 1) = genre.Trim()
            jumlahBuku += 1
        End If
    End Sub

    ' procedure hapus buku
    Public Sub HapusBukuData(ByRef judul As String)
        Dim index As Integer = CariIndexBuku(judul)
        If index <> -1 Then
            For i As Integer = index To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next
            jumlahBuku -= 1
        End If
    End Sub

    ' procedure nampilin data ke gridview
    Public Sub TampilkanBukuKeGrid(ByRef dgv As DataGridView)
        dgv.Rows.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            dgv.Rows.Add(daftarBuku(i, 0), daftarBuku(i, 1))
        Next
    End Sub

End Module