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
        PictureBox1 = New PictureBox()
        btnCancel = New Button()
        btnHapus = New Button()
        btnChange = New Button()
        btnSimpan = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        dgvOperator = New DataGridView()
        txtIdOp = New TextBox()
        txtNamaOp = New TextBox()
        txtKelas = New TextBox()
        txtRarity = New TextBox()
        cbFaksi = New ComboBox()
        Label5 = New Label()
        btnSearch = New Button()
        txtDeskripsi = New TextBox()
        Label6 = New Label()
        txtSearch = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOperator, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources._2407dc29cf2ab352752d288c15d812b2_1_
        PictureBox1.Location = New Point(54, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(279, 74)
        PictureBox1.TabIndex = 26
        PictureBox1.TabStop = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(322, 291)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(81, 29)
        btnCancel.TabIndex = 25
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(238, 291)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(73, 29)
        btnHapus.TabIndex = 24
        btnHapus.Text = "Delete"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnChange
        ' 
        btnChange.Location = New Point(157, 291)
        btnChange.Name = "btnChange"
        btnChange.Size = New Size(74, 29)
        btnChange.TabIndex = 23
        btnChange.Text = "Change"
        btnChange.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(68, 291)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(77, 29)
        btnSimpan.TabIndex = 22
        btnSimpan.Text = "Add"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(54, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 20)
        Label1.TabIndex = 27
        Label1.Text = "Operator ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(54, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 20)
        Label2.TabIndex = 28
        Label2.Text = "Operator Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(54, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 20)
        Label3.TabIndex = 30
        Label3.Text = "Rarity"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(54, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 20)
        Label4.TabIndex = 29
        Label4.Text = "Class"
        ' 
        ' dgvOperator
        ' 
        dgvOperator.BackgroundColor = Color.DimGray
        dgvOperator.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOperator.Location = New Point(54, 364)
        dgvOperator.Name = "dgvOperator"
        dgvOperator.RowHeadersWidth = 51
        dgvOperator.Size = New Size(668, 117)
        dgvOperator.TabIndex = 31
        ' 
        ' txtIdOp
        ' 
        txtIdOp.Location = New Point(171, 121)
        txtIdOp.Name = "txtIdOp"
        txtIdOp.Size = New Size(83, 27)
        txtIdOp.TabIndex = 32
        ' 
        ' txtNamaOp
        ' 
        txtNamaOp.Location = New Point(171, 158)
        txtNamaOp.Name = "txtNamaOp"
        txtNamaOp.Size = New Size(302, 27)
        txtNamaOp.TabIndex = 33
        ' 
        ' txtKelas
        ' 
        txtKelas.Location = New Point(171, 198)
        txtKelas.Name = "txtKelas"
        txtKelas.Size = New Size(302, 27)
        txtKelas.TabIndex = 34
        ' 
        ' txtRarity
        ' 
        txtRarity.Location = New Point(171, 239)
        txtRarity.Name = "txtRarity"
        txtRarity.Size = New Size(302, 27)
        txtRarity.TabIndex = 35
        ' 
        ' cbFaksi
        ' 
        cbFaksi.FormattingEnabled = True
        cbFaksi.Location = New Point(322, 120)
        cbFaksi.Name = "cbFaksi"
        cbFaksi.Size = New Size(151, 28)
        cbFaksi.TabIndex = 36
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(260, 126)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 20)
        Label5.TabIndex = 37
        Label5.Text = "Faction"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.AppWorkspace
        btnSearch.Location = New Point(409, 291)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(81, 29)
        btnSearch.TabIndex = 38
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(508, 119)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(214, 201)
        txtDeskripsi.TabIndex = 40
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(570, 83)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 23)
        Label6.TabIndex = 39
        Label6.Text = "Description"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(54, 331)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search......."
        txtSearch.Size = New Size(668, 27)
        txtSearch.TabIndex = 41
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.zone_1_1
        ClientSize = New Size(800, 493)
        Controls.Add(txtSearch)
        Controls.Add(txtDeskripsi)
        Controls.Add(Label6)
        Controls.Add(btnSearch)
        Controls.Add(Label5)
        Controls.Add(cbFaksi)
        Controls.Add(txtRarity)
        Controls.Add(txtKelas)
        Controls.Add(txtNamaOp)
        Controls.Add(txtIdOp)
        Controls.Add(dgvOperator)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(btnCancel)
        Controls.Add(btnHapus)
        Controls.Add(btnChange)
        Controls.Add(btnSimpan)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOperator, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnChange As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvOperator As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents cbFaksi As ComboBox
    Friend WithEvents txtRarity As TextBox
    Friend WithEvents txtKelas As TextBox
    Friend WithEvents txtNamaOp As TextBox
    Friend WithEvents txtIdOp As TextBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
End Class
