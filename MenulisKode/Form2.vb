Public Class Form2
    Dim Nilai1, Nilai2 As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Nilai1 = TextBox1.Text
        Nilai2 = TextBox2.Text

        If RadioButton1.Checked = True Then
            TextBox3.Text = Nilai1 + Nilai2
        End If

        If RadioButton2.Checked = True Then
            TextBox3.Text = Nilai1 - Nilai2
        End If

        If RadioButton3.Checked = True Then
            TextBox3.Text = Nilai1 * Nilai2
        End If

        If RadioButton4.Checked = True Then
            TextBox3.Text = Nilai1 / Nilai2
        End If
    End Sub
End Class