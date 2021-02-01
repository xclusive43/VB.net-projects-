Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum = 0, q, temp, n, i As Integer

        n = Val(TextBox1.Text)
        temp = n
        While n <> 0
            q = n Mod 10
            sum += Math.Pow(q, 3)
            n \= 10
        End While
        If sum = temp Then
            Label3.Text = temp & " is a armstrong number"

        Else
            Label3.Text = temp & " is not a armstrong number!"

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
