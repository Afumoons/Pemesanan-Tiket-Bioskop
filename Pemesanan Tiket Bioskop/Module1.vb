Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Module Module1
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Sub Koneksi() 'Untuk membuak koneksi
        Try
            conn.Close()
            conn = New MySqlConnection("server=localhost;user id=root;database=pesantiket")
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Tidak dapat terhubung ke Server", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub CloseConn(Type As String)  'Untuk close data reader dan command
        If Type = "dr" Then
            dr.Close()
        ElseIf Type = "cmd" Then
            cmd.Dispose()
        ElseIf Type = "all" Then
            dr.Close()
            cmd.Dispose()
        End If
    End Sub
End Module
