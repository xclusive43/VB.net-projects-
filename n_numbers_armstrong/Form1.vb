Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, a, res As Integer

        a = Val(TextBox1.Text)
        n = Val(TextBox2.Text)

        res = arm(a, n)




    End Sub

    Function arm(a As Integer, n As Integer) As Integer
        Dim r, s, temp As Integer

        For i = a To n
            temp = i
            s = 0
            While temp <> 0
                r = temp Mod 10
                s += Math.Pow(r, 3)
                temp \= 10

            End While
            If s = i Then
                ListBox1.Items.Add(s)

            End If
        Next



    End Function
End Class



