
Public Class Form1
    Public Poster As Integer

    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load

        Poster = 1
        Timer1.Start()
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("Poster" & Poster)
        Judul.Text = My.Resources.ResourceManager.GetObject("Judul" & Poster)
        Genre.Text = My.Resources.ResourceManager.GetObject("Genre" & Poster)
        Produsen.Text = My.Resources.ResourceManager.GetObject("Produsen" & Poster)
        Sutradara.Text = My.Resources.ResourceManager.GetObject("Sutradara" & Poster)
        Penulis.Text = My.Resources.ResourceManager.GetObject("Penulis" & Poster)
        Produksi.Text = My.Resources.ResourceManager.GetObject("Produksi" & Poster)
        Casts.Text = My.Resources.ResourceManager.GetObject("Casts" & Poster)
        Sinopsis.Text = My.Resources.ResourceManager.GetObject("Sinopsis" & Poster)
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

    Private Sub Poster2_Click(sender As Object, e As EventArgs) Handles Poster2.Click
        Timer1.Stop()
        Poster = 2
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("Poster2")
        Judul.Text = My.Resources.ResourceManager.GetObject("Judul2")
        Genre.Text = My.Resources.ResourceManager.GetObject("Genre2")
        Produsen.Text = My.Resources.ResourceManager.GetObject("Produsen2")
        Sutradara.Text = My.Resources.ResourceManager.GetObject("Sutradara2")
        Penulis.Text = My.Resources.ResourceManager.GetObject("Penulis2")
        Produksi.Text = My.Resources.ResourceManager.GetObject("Produksi2")
        Casts.Text = My.Resources.ResourceManager.GetObject("Casts2")
        Sinopsis.Text = My.Resources.ResourceManager.GetObject("Sinopsis2")
    End Sub

    Private Sub Poster3_Click(sender As Object, e As EventArgs) Handles Poster3.Click
        Timer1.Stop()
        Poster = 3
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("Poster3")
        Judul.Text = My.Resources.ResourceManager.GetObject("Judul3")
        Genre.Text = My.Resources.ResourceManager.GetObject("Genre3")
        Produsen.Text = My.Resources.ResourceManager.GetObject("Produsen3")
        Sutradara.Text = My.Resources.ResourceManager.GetObject("Sutradara3")
        Penulis.Text = My.Resources.ResourceManager.GetObject("Penulis3")
        Produksi.Text = My.Resources.ResourceManager.GetObject("Produksi3")
        Casts.Text = My.Resources.ResourceManager.GetObject("Casts3")
        Sinopsis.Text = My.Resources.ResourceManager.GetObject("Sinopsis3")
    End Sub

    Private Sub Poster1_Click(sender As Object, e As EventArgs) Handles Poster1.Click
        Timer1.Stop()
        Poster = 1
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("Poster1")
        Judul.Text = My.Resources.ResourceManager.GetObject("Judul1")
        Genre.Text = My.Resources.ResourceManager.GetObject("Genre1")
        Produsen.Text = My.Resources.ResourceManager.GetObject("Produsen1")
        Sutradara.Text = My.Resources.ResourceManager.GetObject("Sutradara1")
        Penulis.Text = My.Resources.ResourceManager.GetObject("Penulis1")
        Produksi.Text = My.Resources.ResourceManager.GetObject("Produksi1")
        Casts.Text = My.Resources.ResourceManager.GetObject("Casts1")
        Sinopsis.Text = My.Resources.ResourceManager.GetObject("Sinopsis1")
    End Sub

    Private Sub Pesan_Click(sender As Object, e As EventArgs) Handles Pesan.Click
        Form2.Show()
        Form2.Refresh()
        Me.Hide()
    End Sub


    Private Sub Pesan_KeyDown(sender As Object, e As KeyEventArgs) Handles Pesan.KeyDown
        'handle keyboard ketika fokus pada btn pesan
        If e.Control And e.KeyCode = Keys.S Then 'tekan ctrl + s
            LoginForm1.Show()
            Me.Hide()
        End If
    End Sub
End Class
