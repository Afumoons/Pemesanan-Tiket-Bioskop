Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form2
    Public Poster As Integer
    Public idstudio As String
    Public tanggal As Date
    Public waktu, waktuakhir As String
    Public hargatiket, harga, hargaweekend
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try 'Tampil deskripsi film
            cmd = New MySqlCommand("SELECT * FROM film where id_film = '" & Form1.idfilm & "'", conn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                Judul.Text = dr.Item(1)
                Genre.Text = dr.Item(2)
                Produsen.Text = dr.Item(3)
                Sutradara.Text = dr.Item(4)
                Penulis.Text = dr.Item(5)
                Produksi.Text = dr.Item(6)
                Casts.Text = dr.Item(7)
                Sinopsis.Text = dr.Item(8)
                'trailer.Text = dr.Item(9)
                'batasusia.Text = dr.Item(10)
                Dim img() As Byte
                img = dr.Item(11)
                Dim ms As New MemoryStream(img) 'Untuk mengubah byte menjadi image untuk ditampilkan di picturebox1
                PictureBox1.Image = Image.FromStream(ms)
            End If
            CloseConn("all")
        Catch ex As Exception 'ID Film masih kosong
            CloseConn("all")
            MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        SelectStudioLV()
    End Sub

    Sub SelectStudioLV()
        Try 'Select data studio
            cmd = New MySqlCommand("select * from studio", conn)
            dr = cmd.ExecuteReader()
            ListView1.Items.Clear()
            If dr.HasRows Then
                While dr.Read()
                    ListView1.Items.Add(dr.Item(1))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(0))
                End While
            End If
            CloseConn("all")
        Catch ex As Exception
            CloseConn("all")
            MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub TxtPilihStudio_Click(sender As Object, e As EventArgs) Handles TxtPilihStudio.Click
        Panel1.Show()
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If (ListView1.SelectedItems.Count > 0) Then
            TxtPilihStudio.Text = ListView1.SelectedItems(0).SubItems(0).Text
            idstudio = ListView1.SelectedItems(0).SubItems(1).Text
        End If
        Panel1.Hide()
        TampilStudio()
    End Sub

    Private Sub TampilStudio()
        Try 'Tampil deskripsi film
            cmd = New MySqlCommand("SELECT * FROM studio where id_studio = '" & idstudio & "'", conn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                harga = dr.Item(2)
                hargaweekend = harga + 15000
                Label14.Text = "IDR " + harga.ToString
                Label15.Text = "IDR " + hargaweekend.ToString
                Alamat_Studio.Text = dr.Item(3)
            End If
            CloseConn("all")
        Catch ex As Exception 'ID Film masih kosong
            CloseConn("all")
            MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Form1.Refresh()
        Me.Close()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        tanggal = DateTimePicker1.Value.Date
        If DateTimePicker1.Value.DayOfWeek = 6 Or DateTimePicker1.Value.DayOfWeek = 0 Then
            hargatiket = hargaweekend
        Else
            hargatiket = harga
        End If
        'MsgBox(hargatiket)
        waktu = ComboBox2.Text
        If waktu = "13:30" Then
            waktuakhir = "15:30"
        ElseIf waktu = "16:00" Then
            waktuakhir = "17:00"
        ElseIf waktu = "18:30" Then
            waktuakhir = "20:30"
        End If
        'MsgBox("tgl " + tanggal + " waktu " + waktu)
        Form3.Show()
        Me.Hide()
    End Sub

    'Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If ComboBox3.Text = "Senin" Then
    '        HHari = 30
    '    ElseIf ComboBox3.Text = "Selasa" Then
    '        HHari = 30
    '    ElseIf ComboBox3.Text = "Rabu" Then
    '        HHari = 30
    '    ElseIf ComboBox3.Text = "Kamis" Then
    '        HHari = 30
    '    ElseIf ComboBox3.Text = "Jumat" Then
    '        HHari = 30
    '    ElseIf ComboBox3.Text = "Sabtu" Then
    '        HHari = 45
    '    ElseIf ComboBox3.Text = "Minggu" Then
    '        HHari = 45
    '    End If
    'End Sub

    Private Sub Form2KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.P Then
            LoginForm1.Show()
            MsgBox("p or P")
        End If
        If e.Control Then
            LoginForm1.Show()
            MsgBox("ctrl")
        End If
    End Sub


End Class