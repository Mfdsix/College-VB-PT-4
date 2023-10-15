Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum, n As Integer

        ListBox1.Items.Add("n" & vbTab & "sum")
        ListBox1.Items.Add("------------")

        Do
            n += 1
            sum += n
            ListBox1.Items.Add(n & vbTab & sum)
            If n = 100 Then
                Exit Do
            End If
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class