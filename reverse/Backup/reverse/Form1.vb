Public Class Form1
 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num, i, r(10), mo As Integer

        num = Val(TextBox2.Text)

        While num > 0
            r(i) = num Mod 10
            mo = mo * 10 + r(i)
            num = num \ 10
        End While
      


        TextBox1.Enabled = False
        TextBox1.Text = mo

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Clear()
        TextBox2.Clear()

        TextBox2.Focus()




    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
