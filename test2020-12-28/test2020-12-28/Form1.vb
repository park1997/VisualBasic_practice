Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String

        If CheckBox1.Checked = True Then str = CheckBox1.Text & Chr(13)
        If CheckBox2.Checked = True Then str = str & CheckBox2.Text & Chr(13)
        If CheckBox3.Checked = True Then str = str & CheckBox3.Text & Chr(13)
        If CheckBox4.Checked = True Then str = str & CheckBox4.Text & Chr(13)
        If CheckBox5.Checked = True Then str = str & CheckBox5.Text & Chr(13)
        If CheckBox6.Checked = True Then str = str & CheckBox6.Text & Chr(13)

        Label2.Text = str
    End Sub
End Class
