Public Class Form6

    Dim password As Integer
    Dim crackpass As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Sub generate()
        crackpass = Int(Rnd() * 100) + 100
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        generate()

        If crackpass = password Then
            Timer1.Enabled = False
            TextBox1.Text = crackpass

            MsgBox("Password Benar! Login Sukses !")
        Else TextBox1.Text = crackpass
            Label1.Text = "Loading..."
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password = 123
    End Sub
End Class