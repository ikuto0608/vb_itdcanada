Public Class July11_2
    Const MAX As String = "max"
    Const MIN As String = "min"

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim firstNumber As Integer = Val(tbxFirst.Text)
        Dim secondNumber As Integer = Val(tbxSecond.Text)

        lbxAll.Items.Add("Multiply List")

        plusNumbersList(firstNumber)
        plusNumbersList(secondNumber)

    End Sub

    Private Sub plusNumbersList(ByVal number As Integer)
        lbxAll.Items.Add("Number: " & number)
        For index As Integer = 1 To 10
            lbxAll.Items.Add(index * number)
        Next
    End Sub

    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        Dim numMap As New Dictionary(Of String, Integer)
        numMap = setNumbers()

        lbxAll.Items.Add("Reverse List")
        For index As Integer = numMap.Item(MAX) To numMap.Item(MIN) Step -1
            lbxAll.Items.Add(index)
        Next
    End Sub

    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        Dim numMap As New Dictionary(Of String, Integer)
        numMap = setNumbers()

        lbxAll.Items.Add("Square List")

        For index As Integer = numMap.Item(MIN) To numMap.Item(MAX)
            lbxAll.Items.Add(index * index)
        Next
    End Sub

    Private Sub btnEvenAndOdd_Click(sender As Object, e As EventArgs) Handles btnEvenAndOdd.Click
        Dim numMap As New Dictionary(Of String, Integer)
        numMap = setNumbers()

        lbxAll.Items.Add("Even and Odd List")

        lbxAll.Items.Add("Even List")
        For index As Integer = numMap.Item(MIN) To numMap.Item(MAX)
            If (index Mod 2) = 0 Then
                lbxAll.Items.Add(index)
            End If
        Next

        lbxAll.Items.Add("Odd List")
        For index As Integer = numMap.Item(MIN) To numMap.Item(MAX)
            If (index Mod 2) <> 0 Then
                lbxAll.Items.Add(index)
            End If
        Next
    End Sub

    Private Function setNumbers() As Dictionary(Of String, Integer)
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbxAll.Items.Clear()
        tbxFirst.Clear()
        tbxSecond.Clear()
    End Sub
End Class