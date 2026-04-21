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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        txtIdFaksi = New TextBox()
        txtNamaFaksi = New TextBox()
        btnCancel = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        dgvFaksi = New DataGridView()
        btnBukaOperator = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvFaksi, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources._2407dc29cf2ab352752d288c15d812b2_1_
        PictureBox1.Location = New Point(53, 41)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(279, 74)
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(53, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 28
        Label1.Text = "Faction ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(53, 187)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 29
        Label2.Text = "Faction Name"
        ' 
        ' txtIdFaksi
        ' 
        txtIdFaksi.Location = New Point(159, 148)
        txtIdFaksi.Name = "txtIdFaksi"
        txtIdFaksi.Size = New Size(173, 27)
        txtIdFaksi.TabIndex = 30
        ' 
        ' txtNamaFaksi
        ' 
        txtNamaFaksi.Location = New Point(159, 184)
        txtNamaFaksi.Name = "txtNamaFaksi"
        txtNamaFaksi.Size = New Size(173, 27)
        txtNamaFaksi.TabIndex = 31
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(280, 234)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(69, 29)
        btnCancel.TabIndex = 35
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(200, 234)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(74, 29)
        btnHapus.TabIndex = 34
        btnHapus.Text = "Delete"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(111, 234)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 29)
        btnUbah.TabIndex = 33
        btnUbah.Text = "Change"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(29, 234)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(76, 29)
        btnSimpan.TabIndex = 32
        btnSimpan.Text = "Add"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' dgvFaksi
        ' 
        dgvFaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFaksi.Location = New Point(32, 278)
        dgvFaksi.Name = "dgvFaksi"
        dgvFaksi.RowHeadersWidth = 51
        dgvFaksi.Size = New Size(317, 117)
        dgvFaksi.TabIndex = 36
        ' 
        ' btnBukaOperator
        ' 
        btnBukaOperator.Location = New Point(32, 409)
        btnBukaOperator.Name = "btnBukaOperator"
        btnBukaOperator.Size = New Size(317, 29)
        btnBukaOperator.TabIndex = 38
        btnBukaOperator.Text = "Operator"
        btnBukaOperator.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.zone_1_1
        ClientSize = New Size(381, 450)
        Controls.Add(btnBukaOperator)
        Controls.Add(dgvFaksi)
        Controls.Add(btnCancel)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtNamaFaksi)
        Controls.Add(txtIdFaksi)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvFaksi, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdFaksi As TextBox
    Friend WithEvents txtNamaFaksi As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents dgvFaksi As DataGridView
    Friend WithEvents btnBukaOperator As Button

End Class
