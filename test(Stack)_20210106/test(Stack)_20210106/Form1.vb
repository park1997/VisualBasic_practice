
Public Class Form1

    Private Function GetRanking(ByVal input_연산자 As Char) As Integer
        Dim i As Integer
        Select Case input_연산자
            Case "+", "-"
                i = 1
            Case "*", "/"
                i = 2
        End Select
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input_수식_한글자씩 As Char
        Dim iCount As Integer = 0
        Dim input_수식 As String = TextBox1.Text
        Dim input_수식_길이 As Integer = TextBox1.TextLength
        Dim output_후위표기법변수 As String = ""

        Dim stackOperator As New Stack

        Do While iCount < input_수식_길이
            input_수식_한글자씩 = input_수식(iCount)

            Select Case input_수식_한글자씩
                Case "0" To "9"

                    Dim input_숫자임시저장 As String = Nothing

                    Do
                        output_후위표기법변수 += input_수식_한글자씩
                        iCount += 1
                        If iCount >= input_수식_길이 Then
                            Exit Select

                        End If
                        input_수식_한글자씩 = input_수식(iCount)

                    Loop While (input_수식_한글자씩 >= "0" And input_수식_한글자씩 <= "9")
                    output_후위표기법변수 += ""

                Case "+", "-", "*", "/"
                    Do While (stackOperator.Count > 0)
                        If GetRanking(stackOperator.Peek) >= GetRanking(input_수식_한글자씩) Then
                            output_후위표기법변수 += stackOperator.Pop
                            output_후위표기법변수 += ""
                        Else
                            Exit Do

                        End If
                    Loop
                    stackOperator.Push(input_수식_한글자씩)
                    iCount += 1
            End Select


        Loop
        Do While (stackOperator.Count > 0)
            output_후위표기법변수 += ""
            output_후위표기법변수 += stackOperator.Pop
        Loop
        TextBox2.Text = output_후위표기법변수
    End Sub
End Class
