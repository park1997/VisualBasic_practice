Public Class Form1

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim str As String
        str = "연령은 " & Chr(13)
        If RadioButton1.Checked = True Then str = str & RadioButton1.Text
        If RadioButton2.Checked = True Then str = str & RadioButton2.Text
        If RadioButton3.Checked = True Then str = str & RadioButton3.Text
        If RadioButton4.Checked = True Then str = str & RadioButton4.Text
        If RadioButton5.Checked = True Then str = str & RadioButton5.Text
        If RadioButton6.Checked = True Then str = str & RadioButton6.Text

        str = str & Chr(13) & "좋아하는 색은 " & Chr(13)

        If CheckBox1.Checked = True Then str = str & CheckBox1.Text & Chr(13)
        If CheckBox2.Checked = True Then str = str & CheckBox2.Text & Chr(13)
        If CheckBox3.Checked = True Then str = str & CheckBox3.Text & Chr(13)
        If CheckBox4.Checked = True Then str = str & CheckBox4.Text & Chr(13)
        If CheckBox5.Checked = True Then str = str & CheckBox5.Text & Chr(13)
        If CheckBox6.Checked = True Then str = str & CheckBox6.Text & Chr(13)


        str = str & "입니다. "

        Label1.Text = str



    End Sub
End Class
