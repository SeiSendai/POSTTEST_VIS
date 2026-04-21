Public Class Form1
    Sub Tampil()
        dgvFaksi.DataSource = GetAllFaksi()
    End Sub

    Sub Kosongkan()
        txtIdFaksi.Clear()
        txtNamaFaksi.Clear()
        txtIdFaksi.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        SimpanFaksi(txtIdFaksi.Text, txtNamaFaksi.Text)
        Tampil() : Kosongkan()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        UbahFaksi(txtIdFaksi.Text, txtNamaFaksi.Text)
        Tampil() : Kosongkan()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        HapusFaksi(txtIdFaksi.Text)
        Tampil() : Kosongkan()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Kosongkan()
    End Sub

    Private Sub btnBukaOperator_Click(sender As Object, e As EventArgs) Handles btnBukaOperator.Click
        Form2.Show()
    End Sub

    Private Sub dgvFaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFaksi.CellClick
        If e.RowIndex >= 0 Then
            txtIdFaksi.Text = dgvFaksi.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNamaFaksi.Text = dgvFaksi.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
    End Sub
End Class