Public Class Form2
    Sub TampilOp()
        If cbFaksi.SelectedValue IsNot Nothing AndAlso Not TypeOf cbFaksi.SelectedValue Is DataRowView Then
            dgvOperator.DataSource = GetOperatorByFaksi(cbFaksi.SelectedValue.ToString())
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbFaksi.DataSource = GetAllFaksi()
        cbFaksi.DisplayMember = "nama_faksi"
        cbFaksi.ValueMember = "id_faksi"
        TampilOp()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        dgvOperator.DataSource = CariOperator(cbFaksi.SelectedValue.ToString(), txtSearch.Text)
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Try
            Dim rar As Integer = If(IsNumeric(txtRarity.Text), CInt(txtRarity.Text), 0)

            UbahOp(txtIdOp.Text, txtNamaOp.Text, txtKelas.Text, rar, cbFaksi.SelectedValue.ToString(), txtDeskripsi.Text)

            MsgBox("Data Berhasil Diperbarui!")
            TampilOp()
        Catch ex As Exception
            MsgBox("Gagal Update: " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        btnSearch.PerformClick()
    End Sub

    Private Sub dgvOperator_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOperator.CellClick
        If e.RowIndex >= 0 Then
            Dim r = dgvOperator.Rows(e.RowIndex)
            txtIdOp.Text = r.Cells(0).Value.ToString()
            txtNamaOp.Text = r.Cells(1).Value.ToString()
            txtKelas.Text = r.Cells(2).Value.ToString()
            ' Kembalikan bintang ke angka
            txtRarity.Text = r.Cells(3).Value.ToString().Length.ToString()
            txtDeskripsi.Text = r.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class