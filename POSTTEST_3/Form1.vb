Public Class Form1
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Angka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress, txtNoTelp.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim listHobby As New List(Of String)
        For Each ctrl In gbHobi.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                listHobby.Add(DirectCast(ctrl, CheckBox).Text)
            End If
        Next
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtNoTelp.Text = "" Or
           txtAlamat.Text = "" Or picProfile.Image Is Nothing Or
           (Not rbLaki.Checked And Not rbPerempuan.Checked) Or listHobby.Count = 0 Then

            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Nama = txtNama.Text
        Umur = txtUmur.Text
        NoTelp = txtNoTelp.Text
        Alamat = txtAlamat.Text
        TglLahir = dtpTanggalLahir.Value.ToString("dd/MM/yyyy")
        Kelamin = If(rbLaki.Checked, "Laki-Laki", "Perempuan")
        Hobi = String.Join(", ", listHobby)
        Foto = picProfile.Image
        Form2.Show()
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If ofd.ShowDialog() = DialogResult.OK Then
            picProfile.Image = Image.FromFile(ofd.FileName)
            imagePath = ofd.FileName
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class