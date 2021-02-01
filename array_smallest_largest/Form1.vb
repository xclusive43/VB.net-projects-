'WAP to store ‘n’ number of numeric values in an array and display the smallest as well as the largest elements in the array.

Public Class Form1
    Dim n, a1, a() As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a2 As Integer
        ReDim Preserve a(n)
        a2 = Val(TextBox2.Text)

        If a1 = n Then
            MsgBox("array is full!")
            Button2.Enabled = False
            TextBox2.Enabled = False
        Else
            a1 += 1
            a(a1) = a2

            TextBox2.Text = ""
            TextBox2.Focus()

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button2.Enabled = False
        Dim a3, min, max As Integer

        min = a(1)
        max = a(1)

        ListBox1.Items.Clear()

        For a3 = 1 To n
            ListBox1.Items.Add(a(a3))
        Next a3

        For a3 = 1 To n
            If a(a3) < min Then
                min = a(a3)
            End If
        Next a3
        For a3 = 1 To n
            If a(a3) > max Then
                max = a(a3)
            End If
        Next a3

        Label3.Text = "the smallest element in array is " & min
        Label4.Text = "the largest element in array is " & max

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a1 = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = TextBox1.Text
        Button1.Enabled = False
        Label2.Text = n & " elements to enter in the array"
        TextBox2.Focus()

    End Sub
End Class
