Public Class Assignment2
    Private Sub Assignment2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer

        For i = 1 To 10
            Dim btn As New Button
            btn.Width = 28
            btn.Height = 28
            btn.Location = New System.Drawing.Point(12, 24)
            btn.Text = i
            btn.Visible = True
            btn.Name = i

            Controls.Add(btn)
        Next
    End Sub
End Class