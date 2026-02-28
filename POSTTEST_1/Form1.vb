Imports System.Diagnostics.Eventing.Reader
Imports System.Linq.Expressions
Imports System.Net.NetworkInformation

Public Class Form1
    Dim total_IP As Double = 0
    Dim Jml_Semester As String = 0

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim IP As Double = Val(TextBox1.Text.Replace(",", "."))
            If IP > 0 And IP <= 4 Then
                total_IP += IP
                Jml_Semester += 1

                Dim IPK As Double = total_IP / Jml_Semester

                lIPK.Text = IPK.ToString("0.00")
                If IP >= 3.01 Then
                    Hasil.Text = "Sangat Memuaskan"
                ElseIf IP >= 2.76 And IP <= 3.0 Then
                    Hasil.Text = "Memuaskan"
                ElseIf IP >= 2.0 And IP <= 2.75 Then
                    Hasil.Text = "Cukup"
                Else
                    Hasil.Text = "Tidak Lulus"
                End If
                TextBox1.Clear()
                TextBox1.Focus()

            Else
                MsgBox("Masukkan IP yang valid (0-4)")
            End If

        Catch ex As Exception
            MsgBox("Mohon masukkan angka yang valid")
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Hasil_Click(sender As Object, e As EventArgs) Handles Hasil.Click

    End Sub

    Private Sub IPK_Click(sender As Object, e As EventArgs) Handles lIPK.Click

    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        total_IP = 0
        Jml_Semester = 0
        lIPK.Text = "0,00"
        Hasil.Text = ""
        TextBox1.Focus()

    End Sub
End Class
