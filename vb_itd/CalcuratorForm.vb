Public Class CalcuratorForm
    Const PLUS As String = "+"
    Const MINUS As String = "-"
    Const MULTIPLY As String = "*"
    Const DIVID As String = "/"
    Const EQUAL As String = "="

    Dim elementsArrayList As List(Of KeyValuePair(Of String, Integer)) =
        New List(Of KeyValuePair(Of String, Integer))

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        pushElement(PLUS, Val(tbxMultipleForm.Text()))
        displayProcesses()
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        pushElement(MINUS, Val(tbxMultipleForm.Text()))
        displayProcesses()
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        pushElement(MULTIPLY, Val(tbxMultipleForm.Text()))
        displayProcesses()
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        pushElement(DIVID, Val(tbxMultipleForm.Text()))
        displayProcesses()
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim result As Integer
        If elementsArrayList.Count = 0 Then
            Exit Sub
        End If
        pushElement(EQUAL, Val(tbxMultipleForm.Text()))
        displayProcesses()

        result = calculateAll()
        tbxMultipleForm.Text() = result
        elementsArrayList.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearAll()
    End Sub

    Private Sub pushElement(ByVal symbol As String, ByVal value As Integer)
        elementsArrayList.Add(New KeyValuePair(Of String, Integer)(
            symbol,
            value
            ))
    End Sub

    Private Sub displayProcesses()
        tbxMultipleForm.Clear()
        lblProcesses.Text() = ""
        lblProcesses.Visible = True

        For Each element As KeyValuePair(Of String, Integer) In elementsArrayList
            lblProcesses.Text() += element.Value & element.Key
        Next
    End Sub

    Private Function calculateAll() As Integer
        Dim result As Integer
        Dim index As Integer = 0

        For Each element As KeyValuePair(Of String, Integer) In elementsArrayList
            If index = 0 Then
                result += element.Value
                index += 1
                Continue For
            End If

            Select Case elementsArrayList(index - 1).Key
                Case PLUS
                    result += element.Value
                Case MINUS
                    result -= element.Value
                Case MULTIPLY
                    result *= element.Value
                Case DIVID
                    Try
                        result /= element.Value
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        clearAll()
                        Exit For
                    End Try
            End Select
            index += 1
        Next

        Return result
    End Function

    Sub clearAll()
        elementsArrayList.Clear()
        tbxMultipleForm.Clear()
        lblProcesses.Visible = False
    End Sub
End Class