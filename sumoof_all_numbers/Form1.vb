Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum = 0, n, i As Integer

        n = Val(TextBox1.Text)
        For i = 0 To n
            sum += i
        Next
        Label2.Text = "sum is :" & sum

    End Sub
End Class
