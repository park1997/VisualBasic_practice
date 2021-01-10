Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim digmessage As DialogResult
        digmessage = MessageBox.Show("종료할까요?", "종료 확인", MessageBoxButtons.YesNo)
        If digmessage = DialogResult.No Then
            e.Cancel = True

        End If
    End Sub
End Class
