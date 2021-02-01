Public Class Form1
    Dim a1, n, a() As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = Val(TextBox1.Text)
        Label3.Show()
        Label3.Text = n & "elements to enter "
        TextBox2.Show()
        Button2.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer

        ReDim Preserve a(n)

        i = Val(TextBox2.Text)

        If a1 = n Then
            MsgBox("the array is full!!")
            TextBox2.Text = ""
            TextBox2.Enabled = False
            Button2.Enabled = False

        Else

            a1 = a1 + 1
            a(a1) = i
            TextBox2.Text = ""
            TextBox2.Focus()

        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a1 = 0
        Label3.Hide()
        TextBox2.Hide()
        Button2.Hide()
        ListBox1.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Show()
        ListBox1.Items.Clear()
        Dim a2, sum As Integer
        Dim avg As Decimal
        sum = 0

        For a2 = 1 To n
            ListBox1.Items.Add(a(a2))
            sum += a(a2)
        Next a2

        avg = sum / n

        MsgBox("the average is:" & avg & "sum is: " & sum)



    End Sub
End Class
