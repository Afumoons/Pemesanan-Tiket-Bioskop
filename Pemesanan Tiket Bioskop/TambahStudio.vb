Imports MySql.Data.MySqlClient

Public Class TambahStudio
    Dim k() As String = {"A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5", "D1", "D2", "D3", "D4", "D5", "E1", "E2", "E3", "E4", "E5", "F1", "F2", "F3", "F4", "F5", "G1", "G2", "G3", "G4", "G5", "H1", "H2", "H3", "H4", "H5", "I1", "I2", "I3", "I4", "I5"}

    Private Sub TambahStudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Try
            Dim bant As String = ""
            cmd = New MySqlCommand("SELECT max(cast(substr(ID_Studio,3,5) as unsigned))+1 FROM studio", conn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                TxtKode.Text = dr.Item(0)
                For i As Integer = 1 To 3 - TxtKode.TextLength
                    bant += "0"
                Next
            End If
            CloseConn("all")
            TxtKode.Text = "ST" & bant & TxtKode.Text
        Catch ex As Exception 'ID Studio masih kosong
            CloseConn("all")
            TxtKode.Text = "ST" & "001"
        End Try
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try 'Menyimpan studio ke db
            cmd = New MySqlCommand("insert into studio values('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtHargaT.Text & "','" & TxtAlamat.Text & "')", conn)
            cmd.ExecuteNonQuery()
            CloseConn("cmd")
            Try 'Setelah studio tersimpan, akan menginsert kursi ke db sesuai kode studio
                Dim status As Boolean = True
                For index = 0 To 44
                    Dim sql As String = "insert into kursi values('" & k(index) & "','" & TxtKode.Text & "','" & status & "')"
                    cmd = New MySqlCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                    CloseConn("cmd")
                Next
                MessageBox.Show("Berhasil menyimpan data studio dan kursi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1.Show()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class