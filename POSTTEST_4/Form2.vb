Public Class Form2
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = " ") Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picProfil.ImageLocation = OpenFileDialog1.FileName
            picProfil.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        ErrorProvider1.Clear()
        Dim isKosong As Boolean = False

        If txtNama.Text.Trim = "" Then ErrorProvider1.SetError(txtNama, "Inputan tidak boleh kosong") : isKosong = True
        If txtID.Text.Trim = "" Then ErrorProvider1.SetError(txtID, "Inputan tidak boleh kosong") : isKosong = True
        If Not mtbTelepon.MaskCompleted Then ErrorProvider1.SetError(mtbTelepon, "Format tidak sesuai") : isKosong = True
        Dim hobiTerpilih As String = ""
        Dim countHobi As Integer = 0
        For Each ctrl As Control In GroupBoxHobi.Controls
            If TypeOf ctrl Is CheckBox Then
                If DirectCast(ctrl, CheckBox).Checked Then
                    hobiTerpilih &= DirectCast(ctrl, CheckBox).Text & ", "
                    countHobi += 1
                End If
            End If
        Next

        If isKosong Or countHobi = 0 Then
            MessageBox.Show("Inputan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda ingin menyimpan dan mencetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            SaveFileDialog1.Filter = "Text File *.txt|CSV File *.csv"
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim isiFile As String = "--- DATA KARTU KOMUNITAS ---" & vbCrLf &
                                      "Nama: " & txtNama.Text & vbCrLf &
                                      "ID: " & txtID.Text & vbCrLf &
                                      "Hobi: " & hobiTerpilih
                IO.File.WriteAllText(SaveFileDialog1.FileName, isiFile)
                MessageBox.Show("File berhasil disimpan!", "Sukses")
            End If

            Form3.lblNama.Text = txtNama.Text
            Form3.lblID.Text = txtID.Text
            Form3.lblDivisi.Text = cbDivisi.Text
            Form3.lblKontak.Text = mtbTelepon.Text
            Form3.lblHobi.Text = hobiTerpilih.TrimEnd(",", " ")
            Form3.pic.Image = picProfil.Image

            Form3.Show()
        End If
    End Sub

End Class