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

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

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
        Dim a2 As Integer
        Dim od(), ev() As Decimal
        ReDim Preserve od(n), ev(n)

        For a2 = 1 To n
            ListBox1.Items.Add(a(a2))
            If a(a2) Mod 2 = 0 Then
                ev(a2) = a(a2)
            Else
                od(a2) = a(a2)
            End If

        Next a2

        For a2 = 1 To n
            ListBox2.Items.Add(od(a2))
            ListBox3.Items.Add(ev(a2))
        Next




    End Sub
End Class
