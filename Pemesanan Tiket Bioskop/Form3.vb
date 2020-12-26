Imports MySql.Data.MySqlClient
Public Class Form3
    Public JTiket, HTiket As Integer
    Public Kursi() As Boolean = {True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True}
    Public status() As Boolean = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public k() As Button = {A1, A2, A3, A4, A5, B1, B2, B3, B4, B5, C1, C2, C3, C4, C5, D1, D2, D3, D4, D5, E1, E2, E3, E4, E5, F1, F2, F3, F4, F5, G1, G2, G3, G4, G5, H1, H2, H3, H4, H5, I1, I2, I3, I4, I5}


    Private Sub Form2_load(sender As Object, e As EventArgs) Handles MyBase.Load
        JTiket = 0
        HTiket = 0
        Jumlah_Tiket.Text = JTiket
        Total_Harga.Text = "IDR " + HTiket.ToString

        'select from db
        Try
            cmd = New MySqlCommand("select status_kursi from kursi", conn) 'INI
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                For i As Integer = 0 To 44
                    If dr.Item(0) = 0 Then
                        k(i).BackColor = Color.LimeGreen
                        status(i) = 0
                    ElseIf dr.Item(0) = 2 Then
                        k(i).BackColor = Color.Red
                        status(i) = 1
                    End If
                Next
            End If
            CloseConn("all")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()


        'simpan
        'isian status ijo ato merah = untuk nganu statusnya ke db
        'pembeda antar kursi = id kursi untuk pembeda kursi + pembeda kursi di film lain
        Try
            Dim sql As String
            For baris = 0 To 44
                'sql = "update kursi set status_kursi = '" & isian_status_ijo_ato_merah & "' where id_kursi='" & pembeda_antar_kursi & "'"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.ExecuteNonQuery()
                CloseConn("cmd")
            Next
            MessageBox.Show("Berhasil menyimpan data!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Maaf, tidak dapat menyimpan data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
        If Kursi(1) = True Then
            A1.BackColor = Color.Red
            JTiket = JTiket + 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(1) = False
            'status(1)
        ElseIf Kursi(1) = False Then
            A1.BackColor = Color.LimeGreen
            JTiket = JTiket - 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(1) = True
        End If
    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
        If Kursi(2) = True Then
            A2.BackColor = Color.Red
            JTiket = JTiket + 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(2) = False
        ElseIf Kursi(2) = False Then
            A2.BackColor = Color.LimeGreen
            JTiket = JTiket - 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(2) = True
        End If
    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click
        If Kursi(3) = True Then
            A3.BackColor = Color.Red
            JTiket = JTiket + 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(3) = False
        ElseIf Kursi(3) = False Then
            A3.BackColor = Color.LimeGreen
            JTiket = JTiket - 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(3) = True
        End If
    End Sub

    Private Sub A4_Click(sender As Object, e As EventArgs) Handles A4.Click
        If Kursi(4) = True Then
            A4.BackColor = Color.Red
            JTiket = JTiket + 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(4) = False
        ElseIf Kursi(4) = False Then
            A4.BackColor = Color.LimeGreen
            JTiket = JTiket - 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(4) = True
        End If
    End Sub

    Private Sub A5_Click(sender As Object, e As EventArgs) Handles A5.Click
        If Kursi(5) = True Then
            A5.BackColor = Color.Red
            JTiket = JTiket + 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(5) = False
        ElseIf Kursi(5) = False Then
            A5.BackColor = Color.LimeGreen
            JTiket = JTiket - 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(5) = True
        End If
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        If Kursi(6) = True Then
            B1.BackColor = Color.Red
            JTiket = JTiket + 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(6) = False
        ElseIf Kursi(6) = False Then
            B1.BackColor = Color.LimeGreen
            JTiket = JTiket - 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(6) = True
        End If
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        If Kursi(7) = True Then
            B2.BackColor = Color.Red
            JTiket = JTiket + 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(7) = False
        ElseIf Kursi(7) = False Then
            B2.BackColor = Color.LimeGreen
            JTiket = JTiket - 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(7) = True
        End If
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If Kursi(8) = True Then
            B3.BackColor = Color.Red
            JTiket = JTiket + 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(8) = False
        ElseIf Kursi(8) = False Then
            B3.BackColor = Color.LimeGreen
            JTiket = JTiket - 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(8) = True
        End If
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        If Kursi(9) = True Then
            B4.BackColor = Color.Red
            JTiket = JTiket + 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(9) = False
        ElseIf Kursi(9) = False Then
            B4.BackColor = Color.LimeGreen
            JTiket = JTiket - 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(9) = True
        End If
    End Sub


    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        If Kursi(10) = True Then
            B5.BackColor = Color.Red
            JTiket = JTiket + 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(10) = False
        ElseIf Kursi(10) = False Then
            B5.BackColor = Color.LimeGreen
            JTiket = JTiket - 1
            HTiket = JTiket * Form2.HHari
            Jumlah_Tiket.Text = JTiket
            Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
            Kursi(10) = True
        End If
    End Sub

End Class