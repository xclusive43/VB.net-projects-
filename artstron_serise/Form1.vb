Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum, q, j, temp, n, i As Integer
        j = Val(TextBox2.Text)
        n = Val(TextBox1.Text)

        For i = j To n

            temp = i
            sum = 0

            While temp <> 0

                q = temp Mod 10
                sum += Math.Pow(q, 3)
                temp \= 10
            End While

            If sum = i Then

                ListBox1.Items.Add(i)


            End If


        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class