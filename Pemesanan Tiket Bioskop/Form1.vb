Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Form1
    Public Poster As Integer
    Public idfilm As String

    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Try
            cmd = New MySqlCommand("select * from film", conn)
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


        'Poster = 1
        'Timer1.Start()
        'PictureBox1.Image = My.Resources.ResourceManager.GetObject("Poster" & Poster)
        'Judul.Text = My.Resources.ResourceManager.GetObject("Judul" & Poster)
        'Genre.Text = My.Resources.ResourceManager.GetObject("Genre" & Poster)
        'Produsen.Text = My.Resources.ResourceManager.GetObject("Produsen" & Poster)
        'Sutradara.Text = My.Resources.ResourceManager.GetObject("Sutradara" & Poster)
        'Penulis.Text = My.Resources.ResourceManager.GetObject("Penulis" & Poster)
        'Produksi.Text = My.Resources.ResourceManager.GetObject("Produksi" & Poster)
        'Casts.Text = My.Resources.ResourceManager.GetObject("Casts" & Poster)
        'Sinopsis.Text = My.Resources.ResourceManager.GetObject("Sinopsis" & Poster)
    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    If Poster > 2 Then
    '        Poster = 1
    '    Else Poster += 1
    '    End If
    '    PictureBox1.Image = My.Resources.ResourceManager.GetObject("Poster" & Poster)
    '    Judul.Text = My.Resources.ResourceManager.GetObject("Judul" & Poster)
    '    Genre.Text = My.Resources.ResourceManager.GetObject("Genre" & Poster)
    '    Produsen.Text = My.Resources.ResourceManager.GetObject("Produsen" & Poster)
    '    Sutradara.Text = My.Resources.ResourceManager.GetObject("Sutradara" & Poster)
    '    Penulis.Text = My.Resources.ResourceManager.GetObject("Penulis" & Poster)
    '    Produksi.Text = My.Resources.ResourceManager.GetObject("Produksi" & Poster)
    '    Casts.Text = My.Resources.ResourceManager.GetObject("Casts" & Poster)
    '    Sinopsis.Text = My.Resources.ResourceManager.GetObject("Sinopsis" & Poster)
    'End Sub

    'Private Sub Poster2_Click(sender As Object, e As EventArgs) Handles Poster2.Click
    '    Timer1.Stop()
    '    Poster = 2
    '    PictureBox1.Image = My.Resources.ResourceManager.GetObject("Poster2")
    '    Judul.Text = My.Resources.ResourceManager.GetObject("Judul2")
    '    Genre.Text = My.Resources.ResourceManager.GetObject("Genre2")
    '    Produsen.Text = My.Resources.ResourceManager.GetObject("Produsen2")
    '    Sutradara.Text = My.Resources.ResourceManager.GetObject("Sutradara2")
    '    Penulis.Text = My.Resources.ResourceManager.GetObject("Penulis2")
    '    Produksi.Text = My.Resources.ResourceManager.GetObject("Produksi2")
    '    Casts.Text = My.Resources.ResourceManager.GetObject("Casts2")
    '    Sinopsis.Text = My.Resources.ResourceManager.GetObject("Sinopsis2")
    'End Sub



    Private Sub Pesan_Click(sender As Object, e As EventArgs) Handles Pesan.Click
        Form2.Show()
        'Form2.Refresh()
        Me.Hide()
    End Sub


    Private Sub Pesan_KeyDown(sender As Object, e As KeyEventArgs) Handles Pesan.KeyDown
        'handle keyboard ketika fokus pada btn pesan
        If e.Control And e.KeyCode = Keys.S Then 'tekan ctrl + s
            LoginForm1.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub TxtJudul_Click(sender As Object, e As EventArgs) Handles TxtJudul.Click
        Form1_load(sender, e) 'form1 direload untuk select data film terbaru
        Panel1.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If (ListView1.SelectedItems.Count > 0) Then
            TxtJudul.Text = ListView1.SelectedItems(0).SubItems(0).Text
            idfilm = ListView1.SelectedItems(0).SubItems(1).Text
        End If
        Panel1.Hide()
        TampilFilm()
    End Sub

    Private Sub TampilFilm()
        Try
            cmd = New MySqlCommand("SELECT * FROM film where id_film = '" & idfilm & "'", conn)
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
    End Sub
End Class
