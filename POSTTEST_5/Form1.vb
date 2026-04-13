Public Class Form1
    Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperators.DataSource = GetAllOperators()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ValidasiInput(txtID.Text, txtName.Text, txtRarity.Text) Then
            If SimpanOperator(txtID.Text, txtName.Text, txtClass.Text, CInt(txtRarity.Text)) Then
                MsgBox("Data Berhasil Disimpan!")
                dgvOperators.DataSource = GetAllOperators()
            End If
        Else
            MsgBox("Input Tidak Valid! (ID harus ada, Rarity 1-6)")
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If ValidasiInput(txtID.Text, txtName.Text, txtRarity.Text) Then
            If UpdateOperator(txtID.Text, txtName.Text, txtClass.Text, CInt(txtRarity.Text)) Then
                MsgBox("Data Berhasil Diperbarui!")
                dgvOperators.DataSource = GetAllOperators()
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim tanya = MsgBox("Hapus operator ini?", MsgBoxStyle.YesNo)
        If tanya = MsgBoxResult.Yes Then
            If HapusOperator(txtID.Text) Then
                dgvOperators.DataSource = GetAllOperators()
            End If
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvOperators.DataSource = CariOperator(txtSearch.Text)
    End Sub
    Private Sub dgvOperators_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOperators.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvOperators.Rows(e.RowIndex)
            txtID.Text = row.Cells(0).Value.ToString()
            txtName.Text = row.Cells(1).Value.ToString()
            txtClass.Text = row.Cells(2).Value.ToString()

            txtRarity.Text = row.Cells(3).Value.ToString().Length.ToString()
        End If
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class