Public Class UseFunction
    Const MAX As String = "max"
    Const MIN As String = "min"

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim firstNumber As Integer = tbxFirst.Text()
        Dim secondNumber As Integer = tbxSecond.Text()
        Dim sumNum As Integer

        sumNum = SumNumbers(firstNumber, secondNumber)
        MessageBox.Show("First: " & firstNumber & vbCrLf & "Second: " & secondNumber & vbCrLf & "Sum: " & sumNum)
    End Sub

    Private Function SumNumbers(ByVal first As Integer, ByRef second As Integer) As Integer
        Return first + second
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        Dim firstNumber As Integer = tbxFirst.Text()
        Dim secondNumber As Integer = tbxSecond.Text()
        Dim middleNumber As Integer

        Dim numMap As New Dictionary(Of String, Integer)
        numMap = setNumbers()

        middleNumber = (numMap.Item(MAX) + numMap.Item(MIN)) / 2

        For index As Integer = middleNumber To numMap.Item(MAX)
            If isPrime(index) Then
                MessageBox.Show("Smallest Prime: " & index)
                Exit Sub
            End If
        Next
        MessageBox.Show("There isn't any Prime number.")
    End Sub

    Function setNumbers() As Dictionary(Of String, Integer)
        Dim numMap As New Dictionary(Of String, Integer)
        Dim firstNumber As Integer = Val(tbxFirst.Text)
        Dim secondNumber As Integer = Val(tbxSecond.Text)

        If firstNumber < secondNumber Then
            numMap.Add(MAX, secondNumber)
            numMap.Add(MIN, firstNumber)
        Else
            numMap.Add(MAX, firstNumber)
            numMap.Add(MIN, secondNumber)
        End If

        Return numMap
    End Function

    Function isPrime(ByRef num) As Boolean
        For index As Integer = num To 1 Step -1
            If (num Mod index) = 0 Then
                If num = index Then
                    Continue For
                End If

                If index <> 1 Then
                    Return False
                Else
                    Return True
                End If
            End If
        Next

        Return False
    End Function

End Class