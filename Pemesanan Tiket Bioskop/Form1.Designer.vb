﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Poster1 = New System.Windows.Forms.PictureBox()
        Me.Poster2 = New System.Windows.Forms.PictureBox()
        Me.Poster3 = New System.Windows.Forms.PictureBox()
        Me.Judul = New System.Windows.Forms.Label()
        Me.Produsen = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Sutradara = New System.Windows.Forms.Label()
        Me.Penulis = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Genre = New System.Windows.Forms.Label()
        Me.Produksi = New System.Windows.Forms.Label()
        Me.Casts = New System.Windows.Forms.Label()
        Me.Sinopsis = New System.Windows.Forms.Label()
        Me.Pesan = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poster1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poster2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poster3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 304)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Poster1
        '
        Me.Poster1.Image = Global.Pemesanan_Tiket_Bioskop.My.Resources.Resources.Poster1
        Me.Poster1.Location = New System.Drawing.Point(55, 338)
        Me.Poster1.Name = "Poster1"
        Me.Poster1.Size = New System.Drawing.Size(127, 185)
        Me.Poster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Poster1.TabIndex = 1
        Me.Poster1.TabStop = False
        '
        'Poster2
        '
        Me.Poster2.Image = Global.Pemesanan_Tiket_Bioskop.My.Resources.Resources.Poster2
        Me.Poster2.Location = New System.Drawing.Point(239, 338)
        Me.Poster2.Name = "Poster2"
        Me.Poster2.Size = New System.Drawing.Size(127, 185)
        Me.Poster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Poster2.TabIndex = 3
        Me.Poster2.TabStop = False
        '
        'Poster3
        '
        Me.Poster3.Image = Global.Pemesanan_Tiket_Bioskop.My.Resources.Resources.Poster3
        Me.Poster3.Location = New System.Drawing.Point(420, 338)
        Me.Poster3.Name = "Poster3"
        Me.Poster3.Size = New System.Drawing.Size(127, 185)
        Me.Poster3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Poster3.TabIndex = 4
        Me.Poster3.TabStop = False
        '
        'Judul
        '
        Me.Judul.AutoSize = True
        Me.Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Judul.Location = New System.Drawing.Point(204, 12)
        Me.Judul.Name = "Judul"
        Me.Judul.Size = New System.Drawing.Size(79, 29)
        Me.Judul.TabIndex = 6
        Me.Judul.Text = "Judul"
        '
        'Produsen
        '
        Me.Produsen.AutoSize = True
        Me.Produsen.Location = New System.Drawing.Point(282, 65)
        Me.Produsen.Name = "Produsen"
        Me.Produsen.Size = New System.Drawing.Size(52, 13)
        Me.Produsen.TabIndex = 7
        Me.Produsen.Text = "Produsen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Produsen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sutradara"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(206, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Penulis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(206, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Produksi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Casts"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(206, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Sinopsis"
        '
        'Sutradara
        '
        Me.Sutradara.AutoSize = True
        Me.Sutradara.Location = New System.Drawing.Point(282, 81)
        Me.Sutradara.Name = "Sutradara"
        Me.Sutradara.Size = New System.Drawing.Size(53, 13)
        Me.Sutradara.TabIndex = 14
        Me.Sutradara.Text = "Sutradara"
        '
        'Penulis
        '
        Me.Penulis.AutoSize = True
        Me.Penulis.Location = New System.Drawing.Point(282, 97)
        Me.Penulis.Name = "Penulis"
        Me.Penulis.Size = New System.Drawing.Size(41, 13)
        Me.Penulis.TabIndex = 15
        Me.Penulis.Text = "Penulis"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(206, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Genre"
        '
        'Genre
        '
        Me.Genre.AutoSize = True
        Me.Genre.Location = New System.Drawing.Point(282, 49)
        Me.Genre.Name = "Genre"
        Me.Genre.Size = New System.Drawing.Size(36, 13)
        Me.Genre.TabIndex = 17
        Me.Genre.Text = "Genre"
        '
        'Produksi
        '
        Me.Produksi.AutoSize = True
        Me.Produksi.Location = New System.Drawing.Point(282, 113)
        Me.Produksi.Name = "Produksi"
        Me.Produksi.Size = New System.Drawing.Size(48, 13)
        Me.Produksi.TabIndex = 18
        Me.Produksi.Text = "Produksi"
        '
        'Casts
        '
        Me.Casts.Location = New System.Drawing.Point(282, 129)
        Me.Casts.Name = "Casts"
        Me.Casts.Size = New System.Drawing.Size(265, 29)
        Me.Casts.TabIndex = 19
        Me.Casts.Text = "Casts"
        '
        'Sinopsis
        '
        Me.Sinopsis.Location = New System.Drawing.Point(206, 173)
        Me.Sinopsis.Name = "Sinopsis"
        Me.Sinopsis.Size = New System.Drawing.Size(341, 98)
        Me.Sinopsis.TabIndex = 20
        Me.Sinopsis.Text = "Sinopsis"
        '
        'Pesan
        '
        Me.Pesan.Location = New System.Drawing.Point(321, 274)
        Me.Pesan.Name = "Pesan"
        Me.Pesan.Size = New System.Drawing.Size(130, 42)
        Me.Pesan.TabIndex = 22
        Me.Pesan.Text = "PESAN TIKET"
        Me.Pesan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(599, 535)
        Me.Controls.Add(Me.Pesan)
        Me.Controls.Add(Me.Sinopsis)
        Me.Controls.Add(Me.Casts)
        Me.Controls.Add(Me.Produksi)
        Me.Controls.Add(Me.Genre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Penulis)
        Me.Controls.Add(Me.Sutradara)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Produsen)
        Me.Controls.Add(Me.Judul)
        Me.Controls.Add(Me.Poster3)
        Me.Controls.Add(Me.Poster2)
        Me.Controls.Add(Me.Poster1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Now Playing"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poster1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poster2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poster3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Poster1 As PictureBox
    Friend WithEvents Poster2 As PictureBox
    Friend WithEvents Poster3 As PictureBox
    Friend WithEvents Judul As Label
    Friend WithEvents Produsen As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Sutradara As Label
    Friend WithEvents Penulis As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Genre As Label
    Friend WithEvents Produksi As Label
    Friend WithEvents Casts As Label
    Friend WithEvents Sinopsis As Label
    Friend WithEvents Pesan As Button
End Class
