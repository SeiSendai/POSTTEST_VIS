<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        TabControl1 = New TabControl()
        tabData = New TabPage()
        cbDivisi = New ComboBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TabKontak = New TabPage()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        mtbTelepon = New MaskedTextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        TabProfil = New TabPage()
        GroupBoxHobi = New GroupBox()
        CheckBox3 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox1 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        GroupBox1 = New GroupBox()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        btnCetak = New Button()
        btnBrowse = New Button()
        picProfil = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        TabControl1.SuspendLayout()
        tabData.SuspendLayout()
        TabKontak.SuspendLayout()
        TabProfil.SuspendLayout()
        GroupBoxHobi.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabData)
        TabControl1.Controls.Add(TabKontak)
        TabControl1.Controls.Add(TabProfil)
        TabControl1.Location = New Point(106, 81)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(649, 342)
        TabControl1.TabIndex = 1
        ' 
        ' tabData
        ' 
        tabData.Controls.Add(cbDivisi)
        tabData.Controls.Add(RadioButton2)
        tabData.Controls.Add(RadioButton1)
        tabData.Controls.Add(DateTimePicker1)
        tabData.Controls.Add(txtID)
        tabData.Controls.Add(txtNama)
        tabData.Controls.Add(Label6)
        tabData.Controls.Add(Label5)
        tabData.Controls.Add(Label4)
        tabData.Controls.Add(Label3)
        tabData.Controls.Add(Label2)
        tabData.Location = New Point(4, 29)
        tabData.Name = "tabData"
        tabData.Padding = New Padding(3)
        tabData.Size = New Size(641, 309)
        tabData.TabIndex = 0
        tabData.Text = "Data Utama"
        tabData.UseVisualStyleBackColor = True
        ' 
        ' cbDivisi
        ' 
        cbDivisi.FormattingEnabled = True
        cbDivisi.Items.AddRange(New Object() {"Specialist Tech Division", "Engineering Division", "Logistics Division", "Procurement Division", "Medical Division", "HR Division", "Intern Division", "Security Division"})
        cbDivisi.Location = New Point(192, 204)
        cbDivisi.Name = "cbDivisi"
        cbDivisi.Size = New Size(256, 28)
        cbDivisi.TabIndex = 10
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(327, 163)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(104, 24)
        RadioButton2.TabIndex = 9
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(192, 163)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(85, 24)
        RadioButton1.TabIndex = 8
        RadioButton1.TabStop = True
        RadioButton1.Text = "Laki-laki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(192, 119)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(256, 27)
        DateTimePicker1.TabIndex = 7
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(192, 75)
        txtID.Name = "txtID"
        txtID.Size = New Size(256, 27)
        txtID.TabIndex = 6
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(192, 40)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(256, 27)
        txtNama.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(58, 207)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 20)
        Label6.TabIndex = 4
        Label6.Text = "Divisi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(58, 163)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 20)
        Label5.TabIndex = 3
        Label5.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(58, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 2
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(58, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 1
        Label3.Text = "ID Anggota"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(58, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 0
        Label2.Text = "Nama"
        ' 
        ' TabKontak
        ' 
        TabKontak.Controls.Add(TextBox2)
        TabKontak.Controls.Add(TextBox1)
        TabKontak.Controls.Add(mtbTelepon)
        TabKontak.Controls.Add(Label9)
        TabKontak.Controls.Add(Label8)
        TabKontak.Controls.Add(Label7)
        TabKontak.Location = New Point(4, 29)
        TabKontak.Name = "TabKontak"
        TabKontak.Padding = New Padding(3)
        TabKontak.Size = New Size(641, 309)
        TabKontak.TabIndex = 1
        TabKontak.Text = "Kontak & Info"
        TabKontak.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(214, 163)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(268, 27)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(214, 105)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(268, 27)
        TextBox1.TabIndex = 4
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(214, 60)
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(268, 27)
        mtbTelepon.TabIndex = 3
        mtbTelepon.Text = "0000-0000-0000"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(76, 166)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 20)
        Label9.TabIndex = 2
        Label9.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(76, 112)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 20)
        Label8.TabIndex = 1
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(76, 60)
        Label7.Name = "Label7"
        Label7.Size = New Size(113, 20)
        Label7.TabIndex = 0
        Label7.Text = "Nomor Telepon"
        ' 
        ' TabProfil
        ' 
        TabProfil.Controls.Add(GroupBoxHobi)
        TabProfil.Controls.Add(GroupBox1)
        TabProfil.Controls.Add(btnCetak)
        TabProfil.Controls.Add(btnBrowse)
        TabProfil.Controls.Add(picProfil)
        TabProfil.Location = New Point(4, 29)
        TabProfil.Name = "TabProfil"
        TabProfil.Padding = New Padding(3)
        TabProfil.Size = New Size(641, 309)
        TabProfil.TabIndex = 2
        TabProfil.Text = "Profil & Aktivitas"
        TabProfil.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxHobi
        ' 
        GroupBoxHobi.Controls.Add(CheckBox3)
        GroupBoxHobi.Controls.Add(CheckBox9)
        GroupBoxHobi.Controls.Add(CheckBox1)
        GroupBoxHobi.Controls.Add(CheckBox8)
        GroupBoxHobi.Controls.Add(CheckBox2)
        GroupBoxHobi.Controls.Add(CheckBox7)
        GroupBoxHobi.Controls.Add(CheckBox4)
        GroupBoxHobi.Controls.Add(CheckBox6)
        GroupBoxHobi.Controls.Add(CheckBox5)
        GroupBoxHobi.Location = New Point(223, 110)
        GroupBoxHobi.Name = "GroupBoxHobi"
        GroupBoxHobi.Size = New Size(372, 129)
        GroupBoxHobi.TabIndex = 15
        GroupBoxHobi.TabStop = False
        GroupBoxHobi.Text = "Hobi"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(141, 26)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(92, 24)
        CheckBox3.TabIndex = 8
        CheckBox3.Text = "Olahraga"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(250, 86)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(69, 24)
        CheckBox9.TabIndex = 14
        CheckBox9.Text = "Musik"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(32, 26)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(88, 24)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Bela Diri"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(141, 86)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(93, 24)
        CheckBox8.TabIndex = 13
        CheckBox8.Text = "Berkebun"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(32, 56)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(88, 24)
        CheckBox2.TabIndex = 7
        CheckBox2.Text = "Meditasi"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(32, 86)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(70, 24)
        CheckBox7.TabIndex = 12
        CheckBox7.Text = "Game"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(141, 56)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(77, 24)
        CheckBox4.TabIndex = 9
        CheckBox4.Text = "Belajar"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(250, 56)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(91, 24)
        CheckBox6.TabIndex = 11
        CheckBox6.Text = "Traveling"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(250, 26)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(82, 24)
        CheckBox5.TabIndex = 10
        CheckBox5.Text = "Menulis"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton6)
        GroupBox1.Controls.Add(RadioButton5)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Location = New Point(223, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(372, 76)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran"
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(239, 35)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(88, 24)
        RadioButton6.TabIndex = 3
        RadioButton6.TabStop = True
        RadioButton6.Text = "Anggota"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(159, 35)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(74, 24)
        RadioButton5.TabIndex = 2
        RadioButton5.TabStop = True
        RadioButton5.Text = "Admin"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(79, 35)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(66, 24)
        RadioButton4.TabIndex = 1
        RadioButton4.TabStop = True
        RadioButton4.Text = "Wakil"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(6, 35)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(68, 24)
        RadioButton3.TabIndex = 0
        RadioButton3.TabStop = True
        RadioButton3.Text = "Ketua"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(302, 263)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(174, 29)
        btnCetak.TabIndex = 2
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(27, 226)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(174, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picProfil
        ' 
        picProfil.Location = New Point(27, 28)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(174, 192)
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(106, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(314, 31)
        Label1.TabIndex = 4
        Label1.Text = "Sistem Pendataan Kartu Kru"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.endfield_industries_1__1__1_
        PictureBox1.Location = New Point(12, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(88, 79)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._1
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(TabControl1)
        Name = "Form2"
        Text = "Form2"
        TabControl1.ResumeLayout(False)
        tabData.ResumeLayout(False)
        tabData.PerformLayout()
        TabKontak.ResumeLayout(False)
        TabKontak.PerformLayout()
        TabProfil.ResumeLayout(False)
        GroupBoxHobi.ResumeLayout(False)
        GroupBoxHobi.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabData As TabPage
    Friend WithEvents TabKontak As TabPage
    Friend WithEvents TabProfil As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbDivisi As ComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents GroupBoxHobi As GroupBox
End Class
