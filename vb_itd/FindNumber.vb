Public Class FindNumber

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Dim max As Integer = 0
        getMaximumNumber(max)
        MessageBox.Show(max)

    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Dim min As Integer = 0
        getMinimumNumber(min)
        MessageBox.Show(min)
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Dim average As Decimal = 0
        getAverage(average)
        MessageBox.Show(average)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click, MyBase.Load
        createRandomNumbers()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub createRandomNumbers()
        Dim numbers(9) As Integer
        Dim number As New Random()
        lbxNumbers.Items.Clear()

        For index As Integer = 0 To 9
            numbers.SetValue(number.Next(1, 100), index)
            lbxNumbers.Items.Add(numbers(index))
        Next
    End Sub

    Private Sub getMaximumNumber(ByRef max)
        For index As Integer = 0 To lbxNumbers.Items.Count - 1
            If index = 0 Then
                max = lbxNumbers.Items(index)
                Continue For
            End If

            If max < lbxNumbers.Items(index) Then
                max = lbxNumbers.Items(index)
            End If
        Next
    End Sub

    Private Sub getMinimumNumber(ByRef min)
        For index As Integer = 0 To lbxNumbers.Items.Count - 1
            If index = 0 Then
                min = lbxNumbers.Items(index)
                Continue For
            End If

            If min > lbxNumbers.Items(index) Then
                min = lbxNumbers.Items(index)
            End If
        Next
    End Sub

    Private Sub getAverage(ByRef average)
        Dim sum As Integer

        For index As Integer = 0 To lbxNumbers.Items.Count - 1
            sum += lbxNumbers.Items(index)
        Next
        average = sum / (lbxNumbers.Items.Count)
    End Sub

End Class