Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = "RohanGadakh") And (TextBox2.Text = "RohanAdmin") Then
            Me.Hide()
            Form2.Show()
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            MsgBox("Invalid Login Credentials", , "Access Denied")
        End If

    End Sub

End Class
