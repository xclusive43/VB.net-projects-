Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim s As String
        s = "yes it si a prime number"
        i = TextBox1.Text
        If i / 2 = 1 And i / 1 = i Then
            Label3.Text = s.ToString
        Else
            Label3.Text = "not it is not a prime number"
        End If

    End Sub

     
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class
