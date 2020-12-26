Public Class Form2
    Public Poster, HHari As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Poster = Form1.Poster
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Tunjungan 1 XXI" Then
            Alamat_Studio.Text = My.Resources.ResourceManager.GetObject("Alamat1")
        ElseIf ComboBox1.Text = "Tunjungan 3 XXI" Then
            Alamat_Studio.Text = My.Resources.ResourceManager.GetObject("Alamat2")
        ElseIf ComboBox1.Text = "Tunjungan 5 XXI" Then
            Alamat_Studio.Text = My.Resources.ResourceManager.GetObject("Alamat3")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Form1.Refresh()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub


    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "Senin" Then
            HHari = 30
        ElseIf ComboBox3.Text = "Selasa" Then
            HHari = 30
        ElseIf ComboBox3.Text = "Rabu" Then
            HHari = 30
        ElseIf ComboBox3.Text = "Kamis" Then
            HHari = 30
        ElseIf ComboBox3.Text = "Jumat" Then
            HHari = 30
        ElseIf ComboBox3.Text = "Sabtu" Then
            HHari = 45
        ElseIf ComboBox3.Text = "Minggu" Then
            HHari = 45
        End If
    End Sub

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