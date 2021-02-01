Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, fa(100), i As Integer
        n = Val(TextBox1.Text)


        For i = 1 To n
            If n Mod i = 0 Then

                fa(i) = i
                ListBox1.Items.Add(fa(i))



            End If
        Next
    End Sub


End Class
