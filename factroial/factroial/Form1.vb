Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num, fact, i As Integer
        Dim ms As String

        ms = "can't compute negative numbers "
        num = Val(TextBox1.Text)

        fact = 1


        If num = 0 Then

            TextBox2.Text = 1
        End If

        If num < 0 Then

            MsgBox(" " & ms)
        End If


        For i = 1 To num
            fact = fact * i
        Next

        TextBox2.Text = fact


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
