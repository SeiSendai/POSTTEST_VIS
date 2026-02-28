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
        Submit = New Button()
        Reset = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Hasil = New Label()
        lIPK = New Label()
        MaskedTextBox1 = New MaskedTextBox()
        SuspendLayout()
        ' 
        ' Submit
        ' 
        Submit.Location = New Point(384, 195)
        Submit.Name = "Submit"
        Submit.Size = New Size(94, 29)
        Submit.TabIndex = 1
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = True
        ' 
        ' Reset
        ' 
        Reset.Location = New Point(484, 195)
        Reset.Name = "Reset"
        Reset.Size = New Size(94, 29)
        Reset.TabIndex = 2
        Reset.Text = "Reset"
        Reset.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(384, 159)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(194, 30)
        TextBox1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(274, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 23)
        Label1.TabIndex = 5
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(268, 237)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 23)
        Label2.TabIndex = 6
        Label2.Text = "IP Kumulatif"
        ' 
        ' Hasil
        ' 
        Hasil.AutoSize = True
        Hasil.Location = New Point(384, 273)
        Hasil.Name = "Hasil"
        Hasil.Size = New Size(49, 23)
        Hasil.TabIndex = 7
        Hasil.Text = "Hasil"
        ' 
        ' lIPK
        ' 
        lIPK.AutoSize = True
        lIPK.Location = New Point(388, 237)
        lIPK.Name = "lIPK"
        lIPK.Size = New Size(45, 23)
        lIPK.TabIndex = 8
        lIPK.Text = "0,00"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(384, 234)
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(194, 30)
        MaskedTextBox1.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 517)
        Controls.Add(lIPK)
        Controls.Add(MaskedTextBox1)
        Controls.Add(Hasil)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Reset)
        Controls.Add(Submit)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "Kalkulator Indeks Prestasi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Submit As Button
    Friend WithEvents Reset As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Hasil As Label
    Friend WithEvents lIPK As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox

End Class
