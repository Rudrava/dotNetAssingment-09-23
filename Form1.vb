Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Greet.Visible = True
        EnterName.Visible = False
        userName.Visible = False
        Button1.Visible = False
        Greet.Text += " " + userName.Text + "!!!"

    End Sub

    Private Sub userName_TextChanged(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles userName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Greet.Visible = True
            EnterName.Visible = False
            userName.Visible = False
            Button1.Visible = False
            Greet.Text += " " + userName.Text + "!!!"


        End If

    End Sub

End Class
