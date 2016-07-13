Public Class SortArray

    Private Sub btnAddGrade_Click(sender As Object, e As EventArgs) Handles btnAddGrade.Click
        Dim grade As Integer = Val(tbxGrade.Text)
        If grade < 1 Or grade > 100 Then
            MsgBox("It's not correct grade.")
            tbxGrade.Text() = ""
            Exit Sub
        End If
        lbxGrade.Items.Add(grade)
        tbxGrade.Text() = ""
    End Sub

    Private Sub btnSortGrade_Click(sender As Object, e As EventArgs) Handles btnSortGrade.Click
        Dim gradesArray = getListBoxItemsArray(lbxGrade.Items)
        Array.Sort(gradesArray)
        Array.Reverse(gradesArray)
        Dim gradeA As New ArrayList
        Dim gradeB As New ArrayList
        Dim gradeC As New ArrayList
        Dim gradeD As New ArrayList
        Dim gradeF As New ArrayList

        For Each grade As Integer In gradesArray
            Select Case grade
                Case 90 To 100
                    gradeA.Add(grade)
                Case 80 To 89
                    gradeB.Add(grade)
                Case 70 To 79
                    gradeC.Add(grade)
                Case 60 To 69
                    gradeD.Add(grade)
                Case 0 To 59
                    gradeF.Add(grade)
            End Select
        Next

        lbxSort.Items.Add("------Grade A------")
        pushSortGrade(gradeA)
        lbxSort.Items.Add("------Grade B------")
        pushSortGrade(gradeB)
        lbxSort.Items.Add("------Grade C------")
        pushSortGrade(gradeC)
        lbxSort.Items.Add("------Grade D------")
        pushSortGrade(gradeD)
        lbxSort.Items.Add("------Grade F------")
        pushSortGrade(gradeF)
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

    Private Sub pushSortGrade(ByVal gradeArray)
        For Each grade As Integer In gradeArray
            lbxSort.Items.Add(grade)
        Next
    End Sub

    Private Function divideGrade(ByRef gradeArray)
        Dim gradeMapList As List(Of KeyValuePair(Of String, Integer)) =
            New List(Of KeyValuePair(Of String, Integer))
        For Each grade As Integer In gradeArray
            gradeMapList.Add(New KeyValuePair(Of String, Integer)(
                getGrade(grade),
                grade
                ))
        Next
    End Function

    Private Function getGrade(ByVal grade) As String
        Dim gradeAlpha As String = "F"
        Select Case grade
            Case 90 To 100
                gradeAlpha = "A"
            Case 80 To 89
                gradeAlpha = "B"
            Case 70 To 79
                gradeAlpha = "C"
            Case 60 To 69
                gradeAlpha = "D"
            Case 0 To 59
                gradeAlpha = "F"
        End Select

        Return gradeAlpha
    End Function

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        Dim count As Integer = 10000
        Dim number As New Random()
        lbxRandom.Items.Clear()
        lbxAscSort.Items.Clear()
        lbxDscSort.Items.Clear()

        For index As Integer = 1 To count
            lbxRandom.Items.Add(number.Next(1, 10000))
        Next
    End Sub

    Private Sub btnAscSort_Click(sender As Object, e As EventArgs) Handles btnAscSort.Click
        Dim numbers = getListBoxItemsArray(lbxRandom.Items)
        Array.Sort(numbers)
        For Each number As Integer In numbers
            lbxAscSort.Items.Add(number)
        Next
    End Sub

    Private Sub btnDesc_Click(sender As Object, e As EventArgs) Handles btnDesc.Click
        Dim numbers = getListBoxItemsArray(lbxRandom.Items)
        Array.Sort(numbers)
        Array.Reverse(numbers)
        For Each number As Integer In numbers
            lbxDscSort.Items.Add(number)
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim numbers = getListBoxItemsArray(lbxRandom.Items)
        Dim num As Integer = Val(tbxNo.Text())

        For Each number As Integer In numbers
            If num = number Then
                MsgBox("There is " & num & " in " & Array.IndexOf(numbers, number) + 1 & " of lines.")
            End If
        Next

    End Sub

    Private Sub btnDimention_Click(sender As Object, e As EventArgs) Handles btnDimention.Click
        Dim array2D(2, 3) As Integer
        Dim value As Integer = 0

        For row As Integer = 0 To 2
            For col As Integer = 0 To 3
                array2D(row, col) = value
                value += 1
            Next
        Next
        For row As Integer = 0 To array2D.GetUpperBound(0)
            lbxDimention.Items.Add("--------row" & (row + 1) & "------")
            For col As Integer = 0 To array2D.GetUpperBound(1)
                lbxDimention.Items.Add(array2D(row, col))
            Next
        Next
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim row As Integer = 3
        Dim col As Integer = 4
        Dim oneArray(row, col) As Integer
        Dim twoArray(row, col) As Integer

        Dim number As New Random()

        For x As Integer = 0 To row - 1
            Dim recordOne As String = ""
            Dim recordTwo As String = ""
            For y As Integer = 0 To col - 1
                If y <> col - 1 Then
                    recordOne += number.Next(1, 100) & ", "
                    recordTwo += number.Next(1, 100) & ", "
                Else
                    recordOne += Convert.ToString(number.Next(1, 100))
                    recordTwo += Convert.ToString(number.Next(1, 100))
                End If
            Next
            lbxOne.Items.Add(recordOne)
            lbxTwo.Items.Add(recordTwo)
        Next
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim arrayOne = getListBoxItemsArray(lbxOne.Items)
        Dim arrayTwo = getListBoxItemsArray(lbxTwo.Items)

        Dim row As Integer = 3
        Dim col As Integer = 4
        Dim resultArray(row, col) As Integer
        Dim oneArray(row, col) As Integer
        Dim twoArray(row, col) As Integer


        For x As Integer = 0 To row - 1
            For y As Integer = 0 To col - 1
                oneArray(x, y) = Val(Split(arrayOne(x), ",")(y))
                twoArray(x, y) = Val(Split(arrayTwo(x), ",")(y))

                resultArray(x, y) = oneArray(x, y) + twoArray(x, y)
            Next
        Next

        For x As Integer = 0 To row - 1
            Dim record As String = ""
            For y As Integer = 0 To col - 1
                If y <> col - 1 Then
                    record += Convert.ToString(resultArray(x, y)) + ", "
                Else
                    record += Convert.ToString(resultArray(x, y))
                End If
            Next
            lbxResult.Items.Add(record)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbxOne.Items.Clear()
        lbxTwo.Items.Clear()
        lbxResult.Items.Clear()
    End Sub
End Class