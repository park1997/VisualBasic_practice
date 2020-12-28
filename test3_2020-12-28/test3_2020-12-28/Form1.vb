Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("장갑")
        ListBox1.Items.Add("타월")
        ListBox1.Items.Add("양말")
        ListBox1.Items.Add("바지")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
        '커서가 깜빡이게 하도록 설정하는 부분
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.Add(ListBox1.Text)
        ListBox1.Items.Remove(ListBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Add(ListBox2.Text)
        ListBox2.Items.Remove(ListBox2.Text)

    End Sub
End Class
