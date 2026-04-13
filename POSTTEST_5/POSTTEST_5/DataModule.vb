Imports MySql.Data.MySqlClient
Imports System.Data

Module DataModule
    Public Function LoadData() As DataTable
        Dim dt As New DataTable()
        Using conn As New MySqlConnection(ConnectionModule.ConnectionString)
            Using cmd As New MySqlCommand("SELECT id, kode_furniture AS Kode, nama_furniture AS Nama, kategori AS Kategori, stok AS Stok, harga AS Harga FROM tb_inventaris ORDER BY id DESC", conn)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function SearchData(keyword As String) As DataTable
        Dim dt As New DataTable()
        Using conn As New MySqlConnection(ConnectionModule.ConnectionString)
            Using cmd As New MySqlCommand("SELECT id, kode_furniture AS Kode, nama_furniture AS Nama, kategori AS Kategori, stok AS Stok, harga AS Harga FROM tb_inventaris WHERE nama_furniture LIKE @kw OR kode_furniture LIKE @kw ORDER BY id DESC", conn)
                cmd.Parameters.AddWithValue("@kw", "%" & keyword.Trim() & "%")
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function InsertData(kode As String, nama As String, kategori As String, stok As Integer, harga As Decimal) As Boolean
        Using conn As New MySqlConnection(ConnectionModule.ConnectionString)
            Using cmd As New MySqlCommand("INSERT INTO tb_inventaris (kode_furniture, nama_furniture, kategori, stok, harga) VALUES (@kode, @nama, @kategori, @stok, @harga)", conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@kategori", kategori)
                cmd.Parameters.AddWithValue("@stok", stok)
                cmd.Parameters.AddWithValue("@harga", harga)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function UpdateData(id As Integer, kode As String, nama As String, kategori As String, stok As Integer, harga As Decimal) As Boolean
        Using conn As New MySqlConnection(ConnectionModule.ConnectionString)
            Using cmd As New MySqlCommand("UPDATE tb_inventaris SET kode_furniture=@kode, nama_furniture=@nama, kategori=@kategori, stok=@stok, harga=@harga WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@kode", kode)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@kategori", kategori)
                cmd.Parameters.AddWithValue("@stok", stok)
                cmd.Parameters.AddWithValue("@harga", harga)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function DeleteData(id As Integer) As Boolean
        Using conn As New MySqlConnection(ConnectionModule.ConnectionString)
            Using cmd As New MySqlCommand("DELETE FROM tb_inventaris WHERE id=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
End Module