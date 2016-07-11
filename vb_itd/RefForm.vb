Public Class RefForm

    Private Sub btnRef_Click(sender As Object, e As EventArgs) Handles btnRef.Click
        Dim firstNumber As Integer = Val(tbxFirst.Text())
        Dim secondNumber As Integer = Val(tbxSecond.Text())
        ChangeNumbers(firstNumber, secondNumber)

        MessageBox.Show("first" & firstNumber & "second" & secondNumber)
    End Sub

    Sub ChangeNumbers(ByRef first As Integer, ByRef second As Integer)
        second = first
    End Sub

End Class