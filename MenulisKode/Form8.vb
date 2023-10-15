Public Class Form8
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Format(Now, "m")
        Label2.Text = Format(Now, "mm")
        Label3.Text = Format(Now, "mmm")
        Label4.Text = Format(Now, "mmmm")
        Label5.Text = Format(Now, "dd/mm/yyyy")
        Label6.Text = Format(Now, "mmm,d,yyyy")
        Label7.Text = Format(Now, "h:mm:ss tt")
        Label8.Text = Format(Now, "MM/dd/yyyy h:mm:ss tt")
    End Sub
End Class