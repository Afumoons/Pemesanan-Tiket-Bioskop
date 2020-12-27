Imports MySql.Data.MySqlClient
Public Class Form3
    Public JTiket, HTiket As Integer
    Public Kursi() As Boolean = {True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True}
    Public status() As Boolean = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    'Public Bk() = {A1, A2, A3, A4, A5, B1, B2, B3, B4, B5, C1, C2, C3, C4, C5, D1, D2, D3, D4, D5, E1, E2, E3, E4, E5, F1, F2, F3, F4, F5, G1, G2, G3, G4, G5, H1, H2, H3, H4, H5, I1, I2, I3, I4, I5}
    Public Sk() As String = {"A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5", "D1", "D2", "D3", "D4", "D5", "E1", "E2", "E3", "E4", "E5", "F1", "F2", "F3", "F4", "F5", "G1", "G2", "G3", "G4", "G5", "H1", "H2", "H3", "H4", "H5", "I1", "I2", "I3", "I4", "I5"}

    Private Sub Form3_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label14.Text = "IDR " + Form2.harga.ToString
        Label15.Text = "IDR " + Form2.hargaweekend.ToString
        JTiket = 0
        HTiket = 0
        Jumlah_Tiket.Text = JTiket
        Total_Harga.Text = "IDR " + HTiket.ToString
        'For index = 0 To 44 'Untuk membuat hijau semua kursi di awal
        '    Bk(index).enabled = True
        '    Bk(index).backcolor = Color.LimeGreen
        'Next
        Try 'Select data Tiket
            'MsgBox(Form2.DateTimePicker1.Value.Date)
            cmd = New MySqlCommand("select * from tiket where id_film = '" & Form1.idfilm & "' and id_studio = '" & Form2.idstudio & "' and tanggal_tiket = '" & Form2.DateTimePicker1.Value.Date & "' and jammulai_tiket = '" & Form2.waktu & "'", conn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read()
                    'MsgBox(dr.Item(1))
                    'Mengecek isi kode kursi
                    If dr.Item(1) = "A1" Then 'Jika kode kursi = A1 maka tombol A1 disable dan warna merah
                        A1.Enabled = False
                        A1.BackColor = Color.Red
                    ElseIf dr.Item(1) = "A2" Then
                        A2.Enabled = False
                        A2.BackColor = Color.Red
                    ElseIf dr.Item(1) = "A3" Then
                        A3.Enabled = False
                        A3.BackColor = Color.Red
                    ElseIf dr.Item(1) = "A4" Then
                        A4.Enabled = False
                        A4.BackColor = Color.Red
                    ElseIf dr.Item(1) = "A5" Then
                        A5.Enabled = False
                        A5.BackColor = Color.Red
                    ElseIf dr.Item(1) = "B1" Then
                        B1.Enabled = False
                        B1.BackColor = Color.Red
                    ElseIf dr.Item(1) = "B2" Then
                        B2.Enabled = False
                        B2.BackColor = Color.Red
                    ElseIf dr.Item(1) = "B3" Then
                        B3.Enabled = False
                        B3.BackColor = Color.Red
                    ElseIf dr.Item(1) = "B4" Then
                        B4.Enabled = False
                        B4.BackColor = Color.Red
                    ElseIf dr.Item(1) = "B5" Then
                        B5.Enabled = False
                        B5.BackColor = Color.Red
                    ElseIf dr.Item(1) = "C1" Then
                        C1.Enabled = False
                        C1.BackColor = Color.Red
                    ElseIf dr.Item(1) = "C2" Then
                        C2.Enabled = False
                        C2.BackColor = Color.Red
                    ElseIf dr.Item(1) = "C3" Then
                        C3.Enabled = False
                        C3.BackColor = Color.Red
                    ElseIf dr.Item(1) = "C4" Then
                        C4.Enabled = False
                        C4.BackColor = Color.Red
                    ElseIf dr.Item(1) = "C5" Then
                        C5.Enabled = False
                        C5.BackColor = Color.Red
                    ElseIf dr.Item(1) = "D1" Then
                        D1.Enabled = False
                        D1.BackColor = Color.Red
                    ElseIf dr.Item(1) = "D2" Then
                        D2.Enabled = False
                        D2.BackColor = Color.Red
                    ElseIf dr.Item(1) = "D3" Then
                        D3.Enabled = False
                        D3.BackColor = Color.Red
                    ElseIf dr.Item(1) = "D4" Then
                        D4.Enabled = False
                        D4.BackColor = Color.Red
                    ElseIf dr.Item(1) = "D5" Then
                        D5.Enabled = False
                        D5.BackColor = Color.Red
                    ElseIf dr.Item(1) = "E1" Then
                        E1.Enabled = False
                        E1.BackColor = Color.Red
                    ElseIf dr.Item(1) = "E2" Then
                        E2.Enabled = False
                        E2.BackColor = Color.Red
                    ElseIf dr.Item(1) = "E3" Then
                        E3.Enabled = False
                        E3.BackColor = Color.Red
                    ElseIf dr.Item(1) = "E4" Then
                        E4.Enabled = False
                        E4.BackColor = Color.Red
                    ElseIf dr.Item(1) = "E5" Then
                        E5.Enabled = False
                        E5.BackColor = Color.Red
                    ElseIf dr.Item(1) = "F1" Then
                        F1.Enabled = False
                        F1.BackColor = Color.Red
                    ElseIf dr.Item(1) = "F2" Then
                        F2.Enabled = False
                        F2.BackColor = Color.Red
                    ElseIf dr.Item(1) = "F3" Then
                        F3.Enabled = False
                        F3.BackColor = Color.Red
                    ElseIf dr.Item(1) = "F4" Then
                        F4.Enabled = False
                        F4.BackColor = Color.Red
                    ElseIf dr.Item(1) = "F5" Then
                        F5.Enabled = False
                        F5.BackColor = Color.Red
                    ElseIf dr.Item(1) = "G1" Then
                        G1.Enabled = False
                        G1.BackColor = Color.Red
                    ElseIf dr.Item(1) = "G2" Then
                        G2.Enabled = False
                        G2.BackColor = Color.Red
                    ElseIf dr.Item(1) = "G3" Then
                        G3.Enabled = False
                        G3.BackColor = Color.Red
                    ElseIf dr.Item(1) = "G4" Then
                        G4.Enabled = False
                        G4.BackColor = Color.Red
                    ElseIf dr.Item(1) = "G5" Then
                        G5.Enabled = False
                        G5.BackColor = Color.Red
                    ElseIf dr.Item(1) = "H1" Then
                        H1.Enabled = False
                        H1.BackColor = Color.Red
                    ElseIf dr.Item(1) = "H2" Then
                        H2.Enabled = False
                        H2.BackColor = Color.Red
                    ElseIf dr.Item(1) = "H3" Then
                        H3.Enabled = False
                        H3.BackColor = Color.Red
                    ElseIf dr.Item(1) = "H4" Then
                        H4.Enabled = False
                        H4.BackColor = Color.Red
                    ElseIf dr.Item(1) = "H5" Then
                        H5.Enabled = False
                        H5.BackColor = Color.Red
                    ElseIf dr.Item(1) = "I1" Then
                        I1.Enabled = False
                        I1.BackColor = Color.Red
                    ElseIf dr.Item(1) = "I2" Then
                        I2.Enabled = False
                        I2.BackColor = Color.Red
                    ElseIf dr.Item(1) = "I3" Then
                        I3.Enabled = False
                        I3.BackColor = Color.Red
                    ElseIf dr.Item(1) = "I4" Then
                        I4.Enabled = False
                        I4.BackColor = Color.Red
                    ElseIf dr.Item(1) = "I5" Then
                        I5.Enabled = False
                        I5.BackColor = Color.Red
                    End If
                End While
            End If
            CloseConn("all")
        Catch ex As Exception
            CloseConn("all")
            MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Form2.Show()
        Me.Close()
    End Sub



    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
        If Kursi(0) = True Then
            A1.BackColor = Color.Yellow
            JTiket += 1
            Kursi(0) = False
            'status(1)
        ElseIf kursi(0) = False Then
            A1.BackColor = Color.LimeGreen
            JTiket -= 1
            Kursi(0) = True
        End If
        HTiket = JTiket * Form2.hargatiket
        Jumlah_Tiket.Text = JTiket
        Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
        If Kursi(1) = True Then
            A2.BackColor = Color.Yellow
            JTiket += 1
            Kursi(1) = False
            'status(1)
        ElseIf kursi(1) = False Then
            A2.BackColor = Color.LimeGreen
            JTiket -= 1
            Kursi(1) = True
        End If
        HTiket = JTiket * Form2.hargatiket
        Jumlah_Tiket.Text = JTiket
        Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click
        If Kursi(2) = True Then
            A3.BackColor = Color.Yellow
            JTiket += 1
            Kursi(2) = False
            'status(1)
        ElseIf kursi(2) = False Then
            A3.BackColor = Color.LimeGreen
            JTiket -= 1
            Kursi(2) = True
        End If
        HTiket = JTiket * Form2.hargatiket
        Jumlah_Tiket.Text = JTiket
        Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
    End Sub

    Private Sub A4_Click(sender As Object, e As EventArgs) Handles A4.Click
        If Kursi(3) = True Then
            A4.BackColor = Color.Yellow
            JTiket += 1
            Kursi(3) = False
            'status(1)
        ElseIf kursi(3) = False Then
            A4.BackColor = Color.LimeGreen
            JTiket -= 1
            Kursi(3) = True
        End If
        HTiket = JTiket * Form2.hargatiket
        Jumlah_Tiket.Text = JTiket
        Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
    End Sub

    Private Sub A5_Click(sender As Object, e As EventArgs) Handles A5.Click
        If Kursi(4) = True Then
            A5.BackColor = Color.Yellow
            JTiket += 1
            Kursi(4) = False
            'status(1)
        ElseIf kursi(4) = False Then
            A5.BackColor = Color.LimeGreen
            JTiket -= 1
            Kursi(4) = True
        End If
        HTiket = JTiket * Form2.hargatiket
        Jumlah_Tiket.Text = JTiket
        Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        If Kursi(5) = True Then
            B1.BackColor = Color.Yellow
            JTiket += 1
            Kursi(5) = False
            'status(1)
        ElseIf kursi(5) = False Then
            B1.BackColor = Color.LimeGreen
            JTiket -= 1
            Kursi(5) = True
        End If
        HTiket = JTiket * Form2.hargatiket
        Jumlah_Tiket.Text = JTiket
        Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        If Kursi(6) = True Then
            B2.BackColor = Color.Yellow
            JTiket += 1
            Kursi(6) = False
            'status(1)
        ElseIf kursi(6) = False Then
            B2.BackColor = Color.LimeGreen
            JTiket -= 1
            Kursi(6) = True
        End If
        HTiket = JTiket * Form2.hargatiket
        Jumlah_Tiket.Text = JTiket
        Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If Kursi(7) = True Then
            B3.BackColor = Color.Yellow
            JTiket += 1
            Kursi(7) = False
            'status(1)
        ElseIf kursi(7) = False Then
            B3.BackColor = Color.LimeGreen
            JTiket -= 1
            Kursi(7) = True
        End If
        HTiket = JTiket * Form2.hargatiket
        Jumlah_Tiket.Text = JTiket
        Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        If Kursi(8) = True Then
            B4.BackColor = Color.Yellow
            JTiket += 1
            Kursi(8) = False
            'status(1)
        ElseIf kursi(8) = False Then
            B4.BackColor = Color.LimeGreen
            JTiket -= 1
            Kursi(8) = True
        End If
        HTiket = JTiket * Form2.hargatiket
        Jumlah_Tiket.Text = JTiket
        Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        If Kursi(9) = True Then
            B5.BackColor = Color.Yellow
            JTiket += 1
            Kursi(9) = False
            'status(1)
        ElseIf kursi(9) = False Then
            B5.BackColor = Color.LimeGreen
            JTiket -= 1
            Kursi(9) = True
        End If
        HTiket = JTiket * Form2.hargatiket
        Jumlah_Tiket.Text = JTiket
        Total_Harga.Text = "IDR " + HTiket.ToString + ".000"
    End Sub
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Form4.Show()
        Me.Hide()


    End Sub
End Class