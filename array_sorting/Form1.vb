'WAP to store 'n’ number of numeric values in an array and display the sorted array (in ascending order) in a list box using 
'Selection Sort	b) Bubble Sort		c) Insertion Sort


Public Class Form1
    Dim n, a1, a() As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReDim Preserve a(n)
        Dim a2 As Integer
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
        Dim i, j, temp, min, max As Integer
        a1 = 1
        temp = 0
        Button3.Enabled = False
        For i = 1 To n
            ListBox4.Items.Add(a(i))
        Next i
        'selection sort

        For i = 1 To n
            min = i
            For j = i + 1 To n
                If a(min) < a(j) Then
                    min = j

                Else
                    temp = a(min)
                    a(min) = a(j)
                    a(j) = temp

                End If



            Next j
        Next i

        Dim w As Integer
        For w = 1 To n
            ListBox1.Items.Add(a(w))
        Next
        'bubble sort
        min = 0
        max = 0
        temp = 0
        For i = 1 To n
            For j = 1 To n
                If a(i) < a(j) Then
                    temp = a(i)
                    a(i) = a(j)
                    a(j) = temp
                End If
            Next
        Next

        For w = 1 To n
            ListBox2.Items.Add(a(w))
        Next

        'insertion sort
        min = 0
        temp = 0
        For i = 1 To n
            min = a(i)
            While i > 0 & a(i - 1) > min
                temp = a(i)
                a(i) = a(i - 1)
                a(i - 1) = temp
            End While


        Next i

        For w = 1 To n
            ListBox3.Items.Add(a(w))
        Next

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = Val(TextBox1.Text)
        Button1.Enabled = False
        Label2.Text = n & " elements to be insert"
        TextBox2.Focus()

    End Sub
End Class
