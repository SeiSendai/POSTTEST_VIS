<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        pic = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblHobi = New Label()
        lblKontak = New Label()
        lblDivisi = New Label()
        lblID = New Label()
        lblNama = New Label()
        CType(pic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pic
        ' 
        pic.Location = New Point(52, 81)
        pic.Name = "pic"
        pic.Size = New Size(233, 259)
        pic.TabIndex = 0
        pic.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(312, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 25)
        Label2.TabIndex = 2
        Label2.Text = "Nama"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(312, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 25)
        Label1.TabIndex = 3
        Label1.Text = "ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(312, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 25)
        Label3.TabIndex = 4
        Label3.Text = "Divisi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(312, 220)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 25)
        Label4.TabIndex = 5
        Label4.Text = "Kontak"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(312, 269)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 25)
        Label5.TabIndex = 6
        Label5.Text = "Hobi"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.BackColor = Color.Transparent
        lblHobi.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHobi.ForeColor = SystemColors.ActiveCaptionText
        lblHobi.Location = New Point(404, 269)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(67, 25)
        lblHobi.TabIndex = 11
        lblHobi.Text = "Label6"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.BackColor = Color.Transparent
        lblKontak.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKontak.ForeColor = SystemColors.ActiveCaptionText
        lblKontak.Location = New Point(404, 220)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(67, 25)
        lblKontak.TabIndex = 10
        lblKontak.Text = "Label7"
        ' 
        ' lblDivisi
        ' 
        lblDivisi.AutoSize = True
        lblDivisi.BackColor = Color.Transparent
        lblDivisi.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDivisi.ForeColor = SystemColors.ActiveCaptionText
        lblDivisi.Location = New Point(404, 174)
        lblDivisi.Name = "lblDivisi"
        lblDivisi.Size = New Size(0, 25)
        lblDivisi.TabIndex = 9
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.Transparent
        lblID.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID.ForeColor = SystemColors.ActiveCaptionText
        lblID.Location = New Point(404, 129)
        lblID.Name = "lblID"
        lblID.Size = New Size(67, 25)
        lblID.TabIndex = 8
        lblID.Text = "Label9"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = SystemColors.ActiveCaptionText
        lblNama.Location = New Point(404, 81)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(77, 25)
        lblNama.TabIndex = 7
        lblNama.Text = "Label10"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(lblHobi)
        Controls.Add(lblKontak)
        Controls.Add(lblDivisi)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(pic)
        ForeColor = SystemColors.ControlLight
        Name = "Form3"
        Text = "Form3"
        CType(pic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pic As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblDivisi As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblNama As Label
End Class
