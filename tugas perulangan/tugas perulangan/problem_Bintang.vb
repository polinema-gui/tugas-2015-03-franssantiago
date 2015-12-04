Public Class problem_Bintang
    Dim hasil As String = " "

    Private Sub ComboBox1_Click(sender As System.Object, e As System.EventArgs) Handles ComboBox1.Click
        Try
            Select Case ComboBox1.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(barisTextBox.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(barisTextBox.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(barisTextBox.Text))
                Case "Hollow Inverted Pyramid"
                    hollowInvertedPyramid(Convert.ToInt32(barisTextBox.Text))
                Case Else
                    TextBox2.Text = "Anda Belum Memilih Pola"
            End Select
        Catch ex As Exception
            TextBox2.Text = "Masukan Bukan Angka"
        End Try
    End Sub
End Class