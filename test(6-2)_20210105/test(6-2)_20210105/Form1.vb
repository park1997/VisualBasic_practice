﻿Public Class Form1
    Dim student(3, 3) As String
    Dim i As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If i <= 3 Then
            TextBox1.Text = i
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox2.Focus()
        Else
            TextBox1.Text = i
            MessageBox.Show("입력이 불가능 합니다. ", "입력")
            TextBox1.Text = ""
        End If
        i += 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If i <= 4 Then
            student(TextBox1.Text, 1) = TextBox1.Text
            student(TextBox1.Text, 2) = TextBox2.Text
            student(TextBox1.Text, 3) = TextBox3.Text
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        Else

            MessageBox.Show("저장이 불가능 합니다. ", "저장")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox4.Text Like "[0-3]" Then
            TextBox1.Text = student(TextBox4.Text, 1)
            TextBox2.Text = student(TextBox4.Text, 2)
            TextBox3.Text = student(TextBox4.Text, 3)
            TextBox4.Focus()
        Else
            MessageBox.Show("찾는 데이터가 없습니다. ", "검색")
            TextBox4.Focus()

        End If
    End Sub
End Class
