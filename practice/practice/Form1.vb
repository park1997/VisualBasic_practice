Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum, i As Integer
        For i = 1 To 20 Step 1
            If i Mod 5 = 0 Then
                sum += i
            End If
        Next i
        TextBox1.Text = sum

    End Sub
End Class
