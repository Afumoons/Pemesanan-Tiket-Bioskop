Imports MySql.Data.MySqlClient

Public Class Tambahfilm
    Private Sub Tambahfilm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Try
            Dim bant As String = ""
            cmd = New MySqlCommand("SELECT max(cast(substr(ID_FILM,3,5) as unsigned))+1 FROM film", conn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                TxtKode.Text = dr.Item(0)
                For i As Integer = 1 To 3 - TxtKode.TextLength
                    bant += "0"
                Next
            End If
            CloseConn("all")
            TxtKode.Text = "FL" & bant & TxtKode.Text
        Catch ex As Exception 'ID Film masih kosong
            CloseConn("all")
            TxtKode.Text = "FL" & "001"
        End Try
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        MessageBox.Show("Pilih file di bawah 1MB", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Try
            With OpenFileDialog1
                .CheckFileExists = True                                             'CHECK THE SELECTED FILE IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckPathExists = True                                             'CHECK THE SELECTED PATH IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .DefaultExt = "jpg"                                                 'GET AND SET THE DEFAULT EXTENSION
                .DereferenceLinks = True                                            'RETURN THE FILE LINKED TO THE LNK FILE
                .FileName = ""                                                      'SET THE FILE NAME TO EMPTY 
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg|All files|*.*" 'FILTERING THE FILES
                .Multiselect = False                                                'SET THIS FOR ONE FILE SELECTION ONLY.
                .RestoreDirectory = True                                            'SET THIS TO PUT THE CURRENT FOLDER BACK TO WHERE IT HAS STARTED.
                .Title = "Select a file to open"                                    'SET THE TITLE OF THE DIALOG BOX.
                .ValidateNames = True                                               'ACCEPT ONLY THE VALID WIN32 FILE NAMES.
                If .ShowDialog = DialogResult.OK Then
                    Try
                        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim sql, caption As String
        Dim result As Integer
        Dim arrImage() As Byte
        Dim mstream As New System.IO.MemoryStream()
        caption = System.IO.Path.GetFileName(OpenFileDialog1.FileName)                  'GET FILENAME FOR CAPTION
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)        'SPECIFIES THE FILE FORMAT OF THE IMAGE
        arrImage = mstream.GetBuffer()                                                  'RETURNS THE ARRAY OF UNSIGNED BYTES FROM WHICH THIS STREAM WAS CREATED
        Dim FileSize As UInt32                                                          'GET THE SIZE OF THE STREAM IN BYTES
        FileSize = mstream.Length
        mstream.Close()                                                                 'CLOSES THE CURRENT STREAM AND RELEASE ANY RESOURCES ASSOCIATED WITH THE CURRENT STREAM
        Try
            sql = "INSERT INTO  `film` VALUES (@ID, @Judul, @Genre, @Produsen, @Sutradara, @Penulis, @Produksi, @Cast, @Sinopsis, @Trailer, @BatasU, @ImageFile)"
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                '.Parameters.AddWithValue("@Caption", caption)
                .Parameters.AddWithValue("@ID", TxtKode.Text)
                .Parameters.AddWithValue("@Judul", TxtJudul.Text)
                .Parameters.AddWithValue("@Genre", TxtGenre.Text)
                .Parameters.AddWithValue("@Produsen", TxtProdusen.Text)
                .Parameters.AddWithValue("@Sutradara", TxtSutradara.Text)
                .Parameters.AddWithValue("@Penulis", TxtPenulis.Text)
                .Parameters.AddWithValue("@Produksi", TxtProduksi.Text)
                .Parameters.AddWithValue("@Cast", TxtCast.Text)
                .Parameters.AddWithValue("@Sinopsis", TxtSinopsis.Text)
                .Parameters.AddWithValue("@Trailer", TxtTrailer.Text)
                .Parameters.AddWithValue("@BatasU", TxtBatasU.Text)
                .Parameters.AddWithValue("@ImageFile", arrImage)
                result = .ExecuteNonQuery()
            End With
            If result > 0 Then
                MsgBox("Data Film telah tersimpan")
            Else
                MsgBox("Error query", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            CloseConn("cmd")
            Form1.Show()
            Me.Close()
        End Try
    End Sub
End Class