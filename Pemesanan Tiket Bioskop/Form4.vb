Imports MySql.Data.MySqlClient

Public Class Form4
    Public Seat As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Judul.Text = Form2.Judul.Text
        Studio.Text = Form2.TxtPilihStudio.Text


        Tiket.Text = Form3.JTiket
        'Studio.Text = Form2.ComboBox1.Text
        Alamat.Text = Form2.Alamat_Studio.Text
        'Hari.Text = Form2.ComboBox3.Text
        Jam.Text = Form2.ComboBox2.Text
        HTiket.Text = "IDR " + Form2.hargatiket.ToString + " / Tiket"
        HAdmin.Text = "IDR 1000 / Tiket"
        HTotal.Text = "IDR " + ((Form2.hargatiket * Form3.JTiket) + 1000 * Form3.JTiket).ToString + ""

        If Form2.DateTimePicker1.Value.DayOfWeek = 0 Then 'Ngecek hari
            Hari.Text = "Minggu"
        ElseIf Form2.DateTimePicker1.Value.DayOfWeek = 1 Then
            Hari.Text = "Senin"
        ElseIf Form2.DateTimePicker1.Value.DayOfWeek = 2 Then
            Hari.Text = "Selasa"
        ElseIf Form2.DateTimePicker1.Value.DayOfWeek = 3 Then
            Hari.Text = "Rabu"
        ElseIf Form2.DateTimePicker1.Value.DayOfWeek = 4 Then
            Hari.Text = "Kamis"
        ElseIf Form2.DateTimePicker1.Value.DayOfWeek = 5 Then
            Hari.Text = "Jum'at"
        ElseIf Form2.DateTimePicker1.Value.DayOfWeek = 6 Then
            Hari.Text = "Sabtu"
        End If

        Seat = ""
        For index = 0 To 44 'Ngecek kursi apa aja yang di pesan
            If Form3.Kursi(index) = False Then
                Seat += Form3.Sk(index) + " "
            End If
        Next
        Kursi.Text = Seat

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'simpan
        'Try
        '    Dim sql As String
        '    For baris = 0 To 44
        '        'sql = "update kursi set status_kursi = '" & isian_status_ijo_ato_merah & "' where id_kursi='" & pembeda_antar_kursi & "'"
        '        Dim cmd As New MySqlCommand(sql, conn)
        '        cmd.ExecuteNonQuery()
        '        CloseConn("cmd")
        '    Next
        '    MessageBox.Show("Berhasil menyimpan data!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Maaf, tidak dapat menyimpan data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try

        For index = 0 To 44 'Ngecek kursi apa aja yang di pesan
            If Form3.Kursi(index) = False Then 'Jika kursi false (dipesan)
                Try 'Lihat id tiket terbaru
                    Dim bant As String = ""
                    cmd = New MySqlCommand("SELECT max(cast(substr(ID_Tiket,2,5) as unsigned))+1 FROM tiket", conn)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        dr.Read()
                        KodeTiket.Text = dr.Item(0)
                        For i As Integer = 1 To 4 - KodeTiket.TextLength
                            bant += "0"
                        Next
                    End If
                    CloseConn("all")
                    KodeTiket.Text = "T" & bant & KodeTiket.Text
                Catch ex As Exception 'ID Studio masih kosong
                    CloseConn("all")
                    KodeTiket.Text = "T" & "0001"
                End Try

                Try 'Menyimpan tiket ke db
                    cmd = New MySqlCommand("insert into tiket values('" & KodeTiket.Text & "','" & Form3.Sk(index) & "','" & Form2.idstudio & "','P0001','" & Form1.idfilm & "','" & Form2.DateTimePicker1.Value.Date & "','" & Form2.waktu & "','" & Form2.waktuakhir & "')", conn)
                    cmd.ExecuteNonQuery()
                    CloseConn("cmd")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CloseConn("cmd")
                End Try
            End If
        Next
        MessageBox.Show("Success", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form1.Show()
        Form2.Close()
        Form3.Close()
        Me.Close()
    End Sub
End Class