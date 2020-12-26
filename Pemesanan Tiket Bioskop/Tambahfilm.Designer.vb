<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambahfilm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtJudul = New System.Windows.Forms.TextBox()
        Me.TxtGenre = New System.Windows.Forms.TextBox()
        Me.TxtProdusen = New System.Windows.Forms.TextBox()
        Me.TxtSutradara = New System.Windows.Forms.TextBox()
        Me.TxtPenulis = New System.Windows.Forms.TextBox()
        Me.TxtProduksi = New System.Windows.Forms.TextBox()
        Me.TxtCast = New System.Windows.Forms.TextBox()
        Me.TxtSinopsis = New System.Windows.Forms.TextBox()
        Me.TxtTrailer = New System.Windows.Forms.TextBox()
        Me.TxtBatasU = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtHargaT = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(12, 12)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.ReadOnly = True
        Me.TxtKode.Size = New System.Drawing.Size(100, 20)
        Me.TxtKode.TabIndex = 25
        '
        'TxtJudul
        '
        Me.TxtJudul.Location = New System.Drawing.Point(12, 38)
        Me.TxtJudul.Name = "TxtJudul"
        Me.TxtJudul.Size = New System.Drawing.Size(100, 20)
        Me.TxtJudul.TabIndex = 1
        '
        'TxtGenre
        '
        Me.TxtGenre.Location = New System.Drawing.Point(12, 64)
        Me.TxtGenre.Name = "TxtGenre"
        Me.TxtGenre.Size = New System.Drawing.Size(100, 20)
        Me.TxtGenre.TabIndex = 2
        '
        'TxtProdusen
        '
        Me.TxtProdusen.Location = New System.Drawing.Point(12, 90)
        Me.TxtProdusen.Name = "TxtProdusen"
        Me.TxtProdusen.Size = New System.Drawing.Size(100, 20)
        Me.TxtProdusen.TabIndex = 3
        '
        'TxtSutradara
        '
        Me.TxtSutradara.Location = New System.Drawing.Point(12, 116)
        Me.TxtSutradara.Name = "TxtSutradara"
        Me.TxtSutradara.Size = New System.Drawing.Size(100, 20)
        Me.TxtSutradara.TabIndex = 4
        '
        'TxtPenulis
        '
        Me.TxtPenulis.Location = New System.Drawing.Point(12, 142)
        Me.TxtPenulis.Name = "TxtPenulis"
        Me.TxtPenulis.Size = New System.Drawing.Size(100, 20)
        Me.TxtPenulis.TabIndex = 5
        '
        'TxtProduksi
        '
        Me.TxtProduksi.Location = New System.Drawing.Point(12, 168)
        Me.TxtProduksi.Name = "TxtProduksi"
        Me.TxtProduksi.Size = New System.Drawing.Size(100, 20)
        Me.TxtProduksi.TabIndex = 6
        '
        'TxtCast
        '
        Me.TxtCast.Location = New System.Drawing.Point(12, 194)
        Me.TxtCast.Name = "TxtCast"
        Me.TxtCast.Size = New System.Drawing.Size(100, 20)
        Me.TxtCast.TabIndex = 7
        '
        'TxtSinopsis
        '
        Me.TxtSinopsis.Location = New System.Drawing.Point(12, 220)
        Me.TxtSinopsis.Name = "TxtSinopsis"
        Me.TxtSinopsis.Size = New System.Drawing.Size(100, 20)
        Me.TxtSinopsis.TabIndex = 8
        '
        'TxtTrailer
        '
        Me.TxtTrailer.Location = New System.Drawing.Point(12, 246)
        Me.TxtTrailer.Name = "TxtTrailer"
        Me.TxtTrailer.Size = New System.Drawing.Size(100, 20)
        Me.TxtTrailer.TabIndex = 9
        '
        'TxtBatasU
        '
        Me.TxtBatasU.Location = New System.Drawing.Point(12, 272)
        Me.TxtBatasU.Name = "TxtBatasU"
        Me.TxtBatasU.Size = New System.Drawing.Size(100, 20)
        Me.TxtBatasU.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID Film"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Judul Film"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Genre Film"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Produsen Film"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Sutradara Film"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(118, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Penulis Film"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(118, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Produksi Film"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(118, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Cast Film"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(118, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Sinopsis Film"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(118, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Trailer Film"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(118, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Batas Usia Film"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(118, 301)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Harga Tiket Film"
        '
        'TxtHargaT
        '
        Me.TxtHargaT.Location = New System.Drawing.Point(12, 298)
        Me.TxtHargaT.Name = "TxtHargaT"
        Me.TxtHargaT.Size = New System.Drawing.Size(100, 20)
        Me.TxtHargaT.TabIndex = 23
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(432, 9)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 24
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(351, 9)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BtnBrowse.TabIndex = 27
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(321, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 304)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Tambahfilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 371)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TxtHargaT)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBatasU)
        Me.Controls.Add(Me.TxtTrailer)
        Me.Controls.Add(Me.TxtSinopsis)
        Me.Controls.Add(Me.TxtCast)
        Me.Controls.Add(Me.TxtProduksi)
        Me.Controls.Add(Me.TxtPenulis)
        Me.Controls.Add(Me.TxtSutradara)
        Me.Controls.Add(Me.TxtProdusen)
        Me.Controls.Add(Me.TxtGenre)
        Me.Controls.Add(Me.TxtJudul)
        Me.Controls.Add(Me.TxtKode)
        Me.Name = "Tambahfilm"
        Me.Text = "Tambahfilm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtKode As TextBox
    Friend WithEvents TxtJudul As TextBox
    Friend WithEvents TxtGenre As TextBox
    Friend WithEvents TxtProdusen As TextBox
    Friend WithEvents TxtSutradara As TextBox
    Friend WithEvents TxtPenulis As TextBox
    Friend WithEvents TxtProduksi As TextBox
    Friend WithEvents TxtCast As TextBox
    Friend WithEvents TxtSinopsis As TextBox
    Friend WithEvents TxtTrailer As TextBox
    Friend WithEvents TxtBatasU As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtHargaT As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
