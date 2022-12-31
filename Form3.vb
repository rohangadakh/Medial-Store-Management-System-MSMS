Public Class Form3

    Dim a, b, c As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        a = TextBox1.Text
        b = TextBox2.Text
        c = a * b
        TextBox3.Text = c

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        a = TextBox1.Text
        b = TextBox2.Text
        c = a / b
        TextBox3.Text = c

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        a = TextBox1.Text
        b = TextBox2.Text
        c = a - b
        TextBox3.Text = c

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        a = TextBox1.Text
        b = TextBox2.Text
        c = a + b
        TextBox3.Text = c

    End Sub

End Class