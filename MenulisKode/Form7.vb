Public Class Form7
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hasil As Single
        Dim nilaiAwal As Single
        Dim bunga As Single
        Dim tahun As Integer

        nilaiAwal = TextBox1.Text
        bunga = TextBox2.Text
        tahun = TextBox3.Text

        hasil = Bank(nilaiAwal, bunga, tahun)
        Label5.Text = Format(hasil, "Rp #,##0.00")

    End Sub

    Private Function Bank(pv As Single, i As Single, n As Integer) As Double
        Bank = pv * (1 + i / 100) ^ n
    End Function
End Class