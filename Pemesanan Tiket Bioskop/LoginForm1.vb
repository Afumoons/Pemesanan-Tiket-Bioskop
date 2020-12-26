Imports MySql.Data.MySqlClient

Public Class LoginForm1

    'klik tombol ok -> melakukan login
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim user = UsernameTextBox.Text
            Dim pass = PasswordTextBox.Text
            cmd = New MySqlCommand("select * from user where username like '" & user & "' and password like '" & pass & "'", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then 'ada baris = user & password benar / ditemukan
                'dr.Read()
                FormAdmin.Show()
                Me.Close()
                CloseConn("all")
            Else 'user atu password salah
                MessageBox.Show("Mohon masukkan Username dan Password yang benar", "Username / Password tidak valid", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CloseConn("all")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Koneksi()
    End Sub
End Class
