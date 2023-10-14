Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nilai As Single

        Nilai = TextBox1.Text

        Select Case Nilai
            Case 0 To 49
                Label3.Text = "E"
            Case 50 To 59
                Label3.Text = "D"
            Case 60 To 69
                Label3.Text = "C"
            Case 70 To 79
                Label3.Text = "B"
            Case 80 To 100
                Label3.Text = "A"
            Case Else
                Label3.Text = "Error, Masukan Nilai"
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class