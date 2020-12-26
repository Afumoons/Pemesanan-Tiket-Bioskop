Public Class Form4
    Public Seat As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Judul.Text = Form2.Judul.Text
        Seat = ""
        If Form3.Kursi(1) = False Then
            Seat = Seat + "A1 "
        End If
        If Form3.Kursi(2) = False Then
            Seat = Seat + "A2 "
        End If
        If Form3.Kursi(3) = False Then
            Seat = Seat + "A3 "
        End If
        If Form3.Kursi(4) = False Then
            Seat = Seat + "A4 "
        End If
        If Form3.Kursi(5) = False Then
            Seat = Seat + "A5 "
        End If
        If Form3.Kursi(6) = False Then
            Seat = Seat + "B1 "
        End If
        If Form3.Kursi(7) = False Then
            Seat = Seat + "B2 "
        End If
        If Form3.Kursi(8) = False Then
            Seat = Seat + "B3 "
        End If
        If Form3.Kursi(9) = False Then
            Seat = Seat + "B4 "
        End If
        If Form3.Kursi(10) = False Then
            Seat = Seat + "B10 "
        End If
        Kursi.Text = Seat
        Tiket.Text = Form3.JTiket
        Studio.Text = Form2.ComboBox1.Text
        Alamat.Text = Form2.Alamat_Studio.Text
        Hari.Text = Form2.ComboBox3.Text
        Jam.Text = Form2.ComboBox2.Text
        HTiket.Text = "IDR " + Form2.HHari.ToString + ".000 / Tiket"
        HAdmin.Text = "IDR 1.000 / Tiket"
        HTotal.Text = "IDR " + ((Form2.HHari * Form3.JTiket) + Form3.JTiket).ToString + ".000"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Success!")
        Form1.Show()
        Form2.Close()
        Form3.Close()
        Me.Close()
    End Sub
End Class