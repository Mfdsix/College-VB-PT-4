Public Class Form10
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim warna As String

        If CheckBox1.Checked Then
            warna = "Merah"
            Me.BackColor = Color.Red
        ElseIf CheckBox2.Checked Then
            warna = "Biru"
            Me.BackColor = Color.Blue
        ElseIf CheckBox3.Checked Then
            warna = "Kuning"
            Me.BackColor = Color.Yellow
        End If

        Label1.Text = warna
    End Sub
End Class