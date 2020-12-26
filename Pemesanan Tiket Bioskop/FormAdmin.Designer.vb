<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Me.BtnTambahFilm = New System.Windows.Forms.Button()
        Me.BtnTambahStudio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnTambahFilm
        '
        Me.BtnTambahFilm.Location = New System.Drawing.Point(40, 33)
        Me.BtnTambahFilm.Name = "BtnTambahFilm"
        Me.BtnTambahFilm.Size = New System.Drawing.Size(88, 23)
        Me.BtnTambahFilm.TabIndex = 0
        Me.BtnTambahFilm.Text = "Tambah Film"
        Me.BtnTambahFilm.UseVisualStyleBackColor = True
        '
        'BtnTambahStudio
        '
        Me.BtnTambahStudio.Location = New System.Drawing.Point(248, 33)
        Me.BtnTambahStudio.Name = "BtnTambahStudio"
        Me.BtnTambahStudio.Size = New System.Drawing.Size(89, 23)
        Me.BtnTambahStudio.TabIndex = 1
        Me.BtnTambahStudio.Text = "Tambah Studio"
        Me.BtnTambahStudio.UseVisualStyleBackColor = True
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 103)
        Me.Controls.Add(Me.BtnTambahStudio)
        Me.Controls.Add(Me.BtnTambahFilm)
        Me.Name = "FormAdmin"
        Me.Text = "FormAdmin"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnTambahFilm As Button
    Friend WithEvents BtnTambahStudio As Button
End Class
