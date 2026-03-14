Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = Nama
        lblUmur.Text = Umur
        lblTgl.Text = TglLahir
        lblKelamin.Text = Kelamin
        lblNoTelp.Text = NoTelp
        lblHobi.Text = Hobi
        lblAlamat.Text = Alamat
        PicPfp.Image = Foto
        PicPfp.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class