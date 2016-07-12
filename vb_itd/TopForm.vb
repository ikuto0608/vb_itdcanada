Public Class TopForm

    Private Sub btnCount100_Click(sender As Object, e As EventArgs) Handles btnCount100.Click
        My.Forms.CountNumber.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnMultipleCalcurate_Click(sender As Object, e As EventArgs) Handles btnMultipleCalcurate.Click
        My.Forms.MultipleCalcurate.Show()
    End Sub

    Private Sub btnUseFunction_Click(sender As Object, e As EventArgs) Handles btnUseFunction.Click
        My.Forms.UseFunction.Show()
    End Sub

    Private Sub btnRef_Click(sender As Object, e As EventArgs) Handles btnRef.Click
        My.Forms.RefForm.Show()
    End Sub

    Private Sub btnCalcurator_Click(sender As Object, e As EventArgs) Handles btnCalcurator.Click
        My.Forms.Assignment1Form.Show()
    End Sub
End Class
