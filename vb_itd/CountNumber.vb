Public Class CountNumber

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        For index As Integer = 100 To 1 Step -1
            If index <= 50 Then
                lbxSmaller.Items.Add(index)
            Else
                lbxGrater.Items.Add(index)
            End If
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Dim count As Integer = lbxSmaller.Items.Count
        Dim firstArray(count - 1) As Integer
        Dim secondArray(count - 1) As Integer

        For index As Integer = 0 To count - 1
            firstArray.SetValue(lbxSmaller.Items(index), index)
            secondArray.SetValue(lbxGrater.Items(index), index)
        Next
        multiplyNumbers(firstArray, secondArray)


    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim count As Integer = lbxSmaller.Items.Count
        Dim firstArray(count - 1) As Integer
        Dim secondArray(count - 1) As Integer

        For index As Integer = 0 To count - 1
            firstArray.SetValue(lbxSmaller.Items(index), index)
            secondArray.SetValue(lbxGrater.Items(index), index)
        Next
        plusNumbers(firstArray, secondArray)
    End Sub

    Private Sub multiplyNumbers(ByVal firstArray As Array, ByRef secondArray As Array)
        For index As Integer = 0 To firstArray.Length - 1
            lbxMulti.Items.Add(firstArray(index) * secondArray(index))
        Next
    End Sub

    Private Sub plusNumbers(ByVal firstArray As Array, ByRef secondArray As Array)
        For index As Integer = 0 To firstArray.Length - 1
            lbxPlus.Items.Add(firstArray(index) + secondArray(index))
        Next
    End Sub

End Class