Public Class Form9
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const modem As Integer = 150000
        Const printer As Integer = 430000
        Const flashdisk As Integer = 55000
        Const lcd As Integer = 890000
        Const mouse As Integer = 60000
        Const keyboard As Integer = 50000

        Dim sum As Integer

        If CheckBox1.Checked = True Then
            sum += modem
        End If
        If CheckBox2.Checked = True Then
            sum += printer
        End If
        If CheckBox3.Checked = True Then
            sum += flashdisk
        End If
        If CheckBox4.Checked = True Then
            sum += lcd
        End If
        If CheckBox5.Checked = True Then
            sum += mouse
        End If
        If CheckBox6.Checked = True Then
            sum += keyboard
        End If

        Label1.Text = sum.ToString("c")
        Label1.Text = Format(sum, "Rp #,##0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False

        Button1.PerformClick()
    End Sub
End Class