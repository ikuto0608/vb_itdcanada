Public Class Assignment2
    Private seatAlphabets As Array = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"}

    Private Sub Assignment2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createBusinessSeatButtons()
        createEconomySeatButtons()

        picWhite.SendToBack()
        picPlane.SendToBack()

    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox(sender.Name)
        sender.BackColor = Color.IndianRed
    End Sub

    Private Sub createBusinessSeatButtons()
        Dim businessLocationsList As Array = {{172, 163}, {204, 163}, {253, 163}, {290, 163}, {383, 163}}

        For x As Integer = 0 To businessLocationsList.GetUpperBound(0)
            For y As Integer = 0 To 3
                Dim btn As New Button
                btn.Width = 28
                btn.Height = 28
                btn.Text = seatAlphabets(y)
                btn.Visible = True
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderColor = Color.White
                btn.BackColor = Color.PowderBlue
                btn.Name = seatAlphabets(y) & (x + 1)
                btn.Location = New System.Drawing.Point(businessLocationsList(x, 0), businessLocationsList(x, 1) + (44 * y))
                AddHandler btn.Click, AddressOf Me.Button_Click
                Controls.Add(btn)
            Next
        Next

    End Sub

    Private Sub createEconomySeatButtons()
        Dim economyLocationsList(29, 1) As Integer
        Dim distanceOfEconomy As Integer = 17
        Dim initLocation = {417, 160}
        economyLocationsList(0, 0) = initLocation(0)
        economyLocationsList(0, 1) = initLocation(1)

        Dim index As Integer = 0
        For x As Integer = 0 To 29
            If index <> 0 Then
                economyLocationsList(x, 0) = economyLocationsList(x - 1, 0) + distanceOfEconomy
                economyLocationsList(x, 1) = economyLocationsList(x - 1, 1)
            End If
            index += 1
        Next

        For x As Integer = 0 To economyLocationsList.GetUpperBound(0)
            For y As Integer = 0 To 9
                Dim btn As New Button
                btn.Width = 16
                btn.Height = 16
                btn.Font = New Font("Microsoft Sans Serif", 5)
                btn.Text = seatAlphabets(y)
                btn.Visible = True
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderColor = Color.White
                btn.BackColor = Color.PowderBlue
                btn.Name = seatAlphabets(y) & (x + 1 + 5)
                btn.Location = New System.Drawing.Point(economyLocationsList(x, 0), economyLocationsList(x, 1) + (16.5 * y))
                AddHandler btn.Click, AddressOf Me.Button_Click
                Controls.Add(btn)
            Next
        Next
    End Sub

End Class