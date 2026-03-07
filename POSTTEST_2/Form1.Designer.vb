<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        GBTambah = New GroupBox()
        btnTambah = New Button()
        boxTGenre = New TextBox()
        boxTJudul = New TextBox()
        TGenre = New Label()
        TJudul = New Label()
        GBHapus = New GroupBox()
        btnHapus = New Button()
        boxHJudul = New TextBox()
        HJudul = New Label()
        DGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        GBTambah.SuspendLayout()
        GBHapus.SuspendLayout()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GBTambah
        ' 
        GBTambah.Controls.Add(btnTambah)
        GBTambah.Controls.Add(boxTGenre)
        GBTambah.Controls.Add(boxTJudul)
        GBTambah.Controls.Add(TGenre)
        GBTambah.Controls.Add(TJudul)
        GBTambah.ForeColor = SystemColors.ActiveCaptionText
        GBTambah.Location = New Point(27, 32)
        GBTambah.Name = "GBTambah"
        GBTambah.RightToLeft = RightToLeft.No
        GBTambah.Size = New Size(250, 145)
        GBTambah.TabIndex = 0
        GBTambah.TabStop = False
        GBTambah.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(132, 110)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' boxTGenre
        ' 
        boxTGenre.Location = New Point(101, 74)
        boxTGenre.Name = "boxTGenre"
        boxTGenre.Size = New Size(125, 27)
        boxTGenre.TabIndex = 3
        ' 
        ' boxTJudul
        ' 
        boxTJudul.Location = New Point(101, 38)
        boxTJudul.Name = "boxTJudul"
        boxTJudul.Size = New Size(125, 27)
        boxTJudul.TabIndex = 3
        ' 
        ' TGenre
        ' 
        TGenre.AutoSize = True
        TGenre.Location = New Point(6, 74)
        TGenre.Name = "TGenre"
        TGenre.Size = New Size(48, 20)
        TGenre.TabIndex = 4
        TGenre.Text = "Genre"
        ' 
        ' TJudul
        ' 
        TJudul.AutoSize = True
        TJudul.Location = New Point(6, 38)
        TJudul.Name = "TJudul"
        TJudul.Size = New Size(79, 20)
        TJudul.TabIndex = 3
        TJudul.Text = "Judul Buku"
        ' 
        ' GBHapus
        ' 
        GBHapus.Controls.Add(btnHapus)
        GBHapus.Controls.Add(boxHJudul)
        GBHapus.Controls.Add(HJudul)
        GBHapus.Location = New Point(462, 32)
        GBHapus.Name = "GBHapus"
        GBHapus.Size = New Size(250, 145)
        GBHapus.TabIndex = 1
        GBHapus.TabStop = False
        GBHapus.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(134, 110)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 3
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' boxHJudul
        ' 
        boxHJudul.Location = New Point(103, 35)
        boxHJudul.Name = "boxHJudul"
        boxHJudul.Size = New Size(125, 27)
        boxHJudul.TabIndex = 3
        ' 
        ' HJudul
        ' 
        HJudul.AutoSize = True
        HJudul.Location = New Point(6, 38)
        HJudul.Name = "HJudul"
        HJudul.Size = New Size(79, 20)
        HJudul.TabIndex = 0
        HJudul.Text = "Judul Buku"
        ' 
        ' DGV
        ' 
        DGV.BackgroundColor = Color.White
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        DGV.Location = New Point(234, 220)
        DGV.Name = "DGV"
        DGV.RowHeadersWidth = 51
        DGV.Size = New Size(300, 188)
        DGV.TabIndex = 2
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Judul"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Genre"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(800, 450)
        Controls.Add(DGV)
        Controls.Add(GBHapus)
        Controls.Add(GBTambah)
        Name = "Form1"
        Text = "Form Buku"
        GBTambah.ResumeLayout(False)
        GBTambah.PerformLayout()
        GBHapus.ResumeLayout(False)
        GBHapus.PerformLayout()
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GBTambah As GroupBox
    Friend WithEvents TJudul As Label
    Friend WithEvents GBHapus As GroupBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents TGenre As Label
    Friend WithEvents HJudul As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents boxTGenre As TextBox
    Friend WithEvents boxTJudul As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents boxHJudul As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn

End Class
