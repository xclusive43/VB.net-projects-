'WAP to store 'n’ number of numeric values in an array and search for an element and its position in the array using the concept of:
'	(a) linear search (b) binary search

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num, q As Integer
        num = Val(TextBox3.Text)

        For q = 1 To n
            If a(q) = num Then
                Label2.Text = num & "found at position " & q

            End If

        Next q
        Button3.Enabled = False
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num1, k, l, h As Integer
        num1 = Val(TextBox4.Text)
        l = 1
        h = n
        k = bin1(a, l, h, num1)

        If k = -1 Then
            Label4.Text = num1 & "not found"
        Else
            Label4.Text = num1 & " found at position " & k
        End If
    End Sub

    Function bin1(ByVal a() As Integer, ByVal l As Integer, ByVal h As Integer, a1 As Integer) As Integer
        Dim Mid1 As Integer

        If h >= l Then
            Mid1 = (l + h) / 2

            If a(Mid1) = a1 Then
                Return Mid1

                If a(Mid1) > a1 Then
                    Return bin1(a, l, Mid1 - 1, a1)
                    If a(Mid1) < a1 Then
                        Return bin1(a, Mid1 + 1, h, a1)
                    End If

                End If
            End If
        Else
            Return -1
        End If



    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Hide()
        a1 = 0
        Label3.Hide()
        TextBox2.Hide()
        Button2.Hide()
        ListBox1.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label5.Show()
        ListBox1.Show()
        ListBox1.Items.Clear()
        Dim a2 As Integer


        For a2 = 1 To n
            ListBox1.Items.Add(a(a2))

        Next a2





    End Sub
End Class

