Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, res As Integer
        n = Val(TextBox1.Text)
        res = arm(n)

        If res = 1 Then
            Label3.Text = n & " is an armstrong number"
        ElseIf res = 0 Then
            Label3.Text = n & " is not a armstrong number"

        End If
    End Sub

    Function arm(a As Integer) As Integer
        Dim r, s, temp As Integer
        temp = a
        While a <> 0
            r = a Mod 10
            s += Math.Pow(r, 3)
            a \= 10

        End While
        If s = temp Then
            Return 1
        Else
            Return 0
        End If

    End Function
End Class



