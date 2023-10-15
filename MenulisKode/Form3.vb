Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nilai As Integer
        Dim Grade As String

        Nilai = TextBox1.Text

        If Nilai >= 80 And Nilai <= 100 Then
            Grade = "A"
        ElseIf Nilai >= 60 And Nilai < 80 Then
            Grade = "B"
        ElseIf Nilai >= 40 And Nilai < 60 Then
            Grade = "C"
        ElseIf Nilai >= 0 And Nilai < 40 Then
            Grade = "D"
        Else
            Grade = "Out of Range"
        End If

        MsgBox("Grade Nilai anda  adalah " & Grade)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class