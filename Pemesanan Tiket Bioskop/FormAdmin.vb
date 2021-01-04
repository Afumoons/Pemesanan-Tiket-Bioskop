Public Class FormAdmin
    Private Sub BtnTambahFilm_Click(sender As Object, e As EventArgs) Handles BtnTambahFilm.Click
        Tambahfilm.Show()
        Me.Close()
    End Sub

    Private Sub BtnTambahStudio_Click(sender As Object, e As EventArgs) Handles BtnTambahStudio.Click
        TambahStudio.Show()
        Me.Close()
    End Sub

    Private Sub BtnLaporan_Click(sender As Object, e As EventArgs) Handles BtnLaporan.Click
        TiketRV.Show()
        Me.Close()
    End Sub
End Class