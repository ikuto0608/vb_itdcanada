Public Class ArrayForm

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim numbers() As Integer = {10, 3, 44, 78, 30}

        For counter As Integer = 0 To numbers.GetUpperBound(0)
            lbxArray.Items.Add(numbers(counter) - 10)
        Next
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Dim randomArray = getListBoxItemsArray(lbxRandom.Items)
        For Each item As Integer In randomArray
            lbxArray.Items.Add(item)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click, MyBase.Shown
        createRandomNumbers()
        lbxArray.Items.Clear()
        lbxEven.Items.Clear()
        lbxOdd.Items.Clear()
    End Sub

    Private Sub createRandomNumbers()
        Dim numbers(9) As Integer
        Dim number As New Random()
        lbxRandom.Items.Clear()

        For index As Integer = 0 To numbers.GetUpperBound(0)
            numbers.SetValue(number.Next(1, 100), index)
            lbxRandom.Items.Add(numbers(index))
        Next
    End Sub

    Private Function getListBoxItemsArray(ByRef listItems As System.Windows.Forms.ListBox.ObjectCollection) As Array
        Dim itemsArray(listItems.Count - 1)
        Dim count As Integer = 0

        For Each item As Object In listItems
            itemsArray.SetValue(item, count)
            count += 1
        Next

        Return itemsArray
    End Function

    Private Sub btnEvenAndOdd_Click(sender As Object, e As EventArgs) Handles btnEvenAndOdd.Click
        Dim itemsArray = getListBoxItemsArray(lbxRandom.Items)

        For Each item As Integer In itemsArray
            If (item Mod 2) = 0 Then
                lbxEven.Items.Add(item)
            Else
                lbxOdd.Items.Add(item)
            End If
        Next
    End Sub

    Private Sub btnMaxMin_Click(sender As Object, e As EventArgs) Handles btnMaxMin.Click
        Dim itemsArray = getListBoxItemsArray(lbxRandom.Items)
        findMaxNumber(itemsArray)
        findMinNumber(itemsArray)
        getSum(itemsArray)
        getAverage(itemsArray)
    End Sub

    Private Sub findMaxNumber(ByVal array())
        Dim result As Integer = -9999999
        For Each item As Integer In array
            If item > result Then
                result = item
            End If
        Next
        MsgBox("Max number is " & result)
    End Sub

    Private Sub findMinNumber(ByVal array())
        Dim result As Integer = 9999999
        For Each item As Integer In array
            If item < result Then
                result = item
            End If
        Next
        MsgBox("Min number is " & result)
    End Sub

    Private Sub getSum(ByVal array())
        Dim result As Integer
        For Each item As Integer In array
            result += item
        Next
        MsgBox("Sum is " & result)
    End Sub

    Private Sub getAverage(ByVal array())
        Dim result As Decimal
        For Each item As Integer In array
            result += item
        Next
        result /= array.Length
        MsgBox("Average is " & result)
    End Sub
End Class