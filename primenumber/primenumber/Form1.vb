Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, n, e1 As Integer
        Dim s As String
        e1 = 0
        s = "yes it is a prime number"
        n = TextBox1.Text
        For i = 1 To n
            If n Mod i = 0 Then
                e1 += 1


            End If


        Next
        If e1 = 2 Then
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
