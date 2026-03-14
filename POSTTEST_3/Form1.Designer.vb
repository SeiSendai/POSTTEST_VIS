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
        picProfile = New PictureBox()
        btnBrowse = New Button()
        btnCetak = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNoTelp = New TextBox()
        txtAlamat = New TextBox()
        dtpTanggalLahir = New DateTimePicker()
        gbKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        gbHobi = New GroupBox()
        cbTidur = New CheckBox()
        cbMancing = New CheckBox()
        cbCoding = New CheckBox()
        cbGame = New CheckBox()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        gbKelamin.SuspendLayout()
        gbHobi.SuspendLayout()
        SuspendLayout()
        ' 
        ' picProfile
        ' 
        picProfile.Location = New Point(56, 23)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(261, 329)
        picProfile.TabIndex = 0
        picProfile.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(112, 358)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(140, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(327, 358)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(501, 29)
        btnCetak.TabIndex = 2
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(323, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 3
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(327, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 4
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(327, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 5
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(327, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 6
        Label4.Text = "No. Telepon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(327, 185)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 7
        Label5.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = SystemColors.Window
        txtNama.Location = New Point(442, 43)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(261, 27)
        txtNama.TabIndex = 8
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(442, 77)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(261, 27)
        txtUmur.TabIndex = 9
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(442, 146)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(261, 27)
        txtNoTelp.TabIndex = 10
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(442, 182)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(261, 27)
        txtAlamat.TabIndex = 11
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(442, 113)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(261, 27)
        dtpTanggalLahir.TabIndex = 12
        ' 
        ' gbKelamin
        ' 
        gbKelamin.BackColor = SystemColors.Window
        gbKelamin.Controls.Add(rbPerempuan)
        gbKelamin.Controls.Add(rbLaki)
        gbKelamin.Location = New Point(327, 227)
        gbKelamin.Name = "gbKelamin"
        gbKelamin.Size = New Size(250, 125)
        gbKelamin.TabIndex = 13
        gbKelamin.TabStop = False
        gbKelamin.Text = "Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(15, 56)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(15, 26)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(85, 24)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' gbHobi
        ' 
        gbHobi.BackColor = SystemColors.Window
        gbHobi.Controls.Add(cbTidur)
        gbHobi.Controls.Add(cbMancing)
        gbHobi.Controls.Add(cbCoding)
        gbHobi.Controls.Add(cbGame)
        gbHobi.Location = New Point(583, 227)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(250, 125)
        gbHobi.TabIndex = 14
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' cbTidur
        ' 
        cbTidur.AutoSize = True
        cbTidur.Location = New Point(131, 56)
        cbTidur.Name = "cbTidur"
        cbTidur.Size = New Size(65, 24)
        cbTidur.TabIndex = 3
        cbTidur.Text = "Tidur"
        cbTidur.UseVisualStyleBackColor = True
        ' 
        ' cbMancing
        ' 
        cbMancing.AutoSize = True
        cbMancing.Location = New Point(131, 26)
        cbMancing.Name = "cbMancing"
        cbMancing.Size = New Size(88, 24)
        cbMancing.TabIndex = 2
        cbMancing.Text = "Mancing"
        cbMancing.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(6, 57)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(79, 24)
        cbCoding.TabIndex = 1
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbGame
        ' 
        cbGame.AutoSize = True
        cbGame.Location = New Point(6, 26)
        cbGame.Name = "cbGame"
        cbGame.Size = New Size(70, 24)
        cbGame.TabIndex = 0
        cbGame.Text = "Game"
        cbGame.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Desain_tanpa_judul_1_
        ClientSize = New Size(989, 417)
        Controls.Add(gbHobi)
        Controls.Add(gbKelamin)
        Controls.Add(dtpTanggalLahir)
        Controls.Add(txtAlamat)
        Controls.Add(txtNoTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCetak)
        Controls.Add(btnBrowse)
        Controls.Add(picProfile)
        Name = "Form1"
        Text = "Form1"
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        gbKelamin.ResumeLayout(False)
        gbKelamin.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents gbKelamin As GroupBox
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cbTidur As CheckBox
    Friend WithEvents cbMancing As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbGame As CheckBox

End Class
