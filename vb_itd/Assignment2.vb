Public Class Assignment2
    Private SEAT_ALPHABET As Array = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"}

    Dim businessSeatsDictionary As New Dictionary(Of String, Array)
    Dim economySeatsDictionary As New Dictionary(Of String, Array)


    Private Sub Assignment2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createBusinessSeatButtons()
        createEconomySeatButtons()
        initBackground()
        generateStatusOfBusinessSeats()
        generateStatusOfEconomySeats()
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nameArray As Array
        If isBusinessSeat(sender.Name) Then
            nameArray = businessSeatsDictionary(sender.Name)
        End If

        If isEconomySeat(sender.Name) Then
            nameArray = economySeatsDictionary(sender.Name)
        End If

        tbxSeat.Text = sender.Name

        If isEpmtySeat(nameArray) Then
            btnReserve.Enabled = True
            btnCancel.Enabled = False
            btnReserve.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
            btnCancel.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        Else
            btnReserve.Enabled = False
            btnCancel.Enabled = True
            btnReserve.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
            btnCancel.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
        End If
        tbxFirstName.Text = nameArray(0)
        tbxLastName.Text = nameArray(1)

    End Sub

    Private Sub createBusinessSeatButtons()
        Dim businessLocationsList As Array = {{172, 163}, {204, 163}, {253, 163}, {290, 163}, {383, 163}}

        For x As Integer = 0 To businessLocationsList.GetUpperBound(0)
            For y As Integer = 0 To 3
                Dim btn As New Button
                btn.Width = 28
                btn.Height = 28
                btn.Text = SEAT_ALPHABET(y)
                btn.Visible = True
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderColor = Color.White
                btn.BackColor = Color.PowderBlue
                btn.Name = SEAT_ALPHABET(y) & (x + 1)
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
                btn.Text = SEAT_ALPHABET(y)
                btn.Visible = True
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderColor = Color.White
                btn.BackColor = Color.PowderBlue
                btn.Name = SEAT_ALPHABET(y) & (x + 1 + 5)
                btn.Location = New System.Drawing.Point(economyLocationsList(x, 0), economyLocationsList(x, 1) + (16.5 * y))
                AddHandler btn.Click, AddressOf Me.Button_Click
                Controls.Add(btn)
            Next
        Next
    End Sub

    Private Sub initBackground()
        picWhite.SendToBack()
        picPlane.SendToBack()
    End Sub

    Private Sub generateStatusOfBusinessSeats()
        Dim rand As New Random()

        For x As Integer = 0 To 4
            For y As Integer = 0 To 3
                Dim number = rand.Next(1, 100)
                If number > 70 Then
                    businessSeatsDictionary.Add(SEAT_ALPHABET(y) & (x + 1), {"Fisrt" & number, "Last" & number})
                    setReserveSeat(SEAT_ALPHABET(y) & (x + 1))
                Else
                    businessSeatsDictionary.Add(SEAT_ALPHABET(y) & (x + 1), {"", ""})
                    setEmptySeat(SEAT_ALPHABET(y) & (x + 1))
                End If
            Next
        Next
    End Sub

    Private Sub generateStatusOfEconomySeats()
        Dim rand As New Random()

        For x As Integer = 0 To 29
            For y As Integer = 0 To 9
                Dim number = rand.Next(1, 100)
                If number > 55 Then
                    economySeatsDictionary.Add(SEAT_ALPHABET(y) & (x + 1 + 5), {"Fisrt" & number, "Last" & number})
                    setReserveSeat(SEAT_ALPHABET(y) & (x + 1 + 5))
                Else
                    economySeatsDictionary.Add(SEAT_ALPHABET(y) & (x + 1 + 5), {"", ""})
                    setEmptySeat(SEAT_ALPHABET(y) & (x + 1 + 5))
                End If
            Next
        Next
    End Sub

    Private Sub setEmptySeat(ByVal seatNumber As String)
        Dim btnSeat As Button = CType(Me.Controls(seatNumber), Button)
        btnSeat.BackColor = Color.PowderBlue
    End Sub

    Private Sub setReserveSeat(ByVal seatNumber As String)
        Dim btnSeat As Button = CType(Me.Controls(seatNumber), Button)
        btnSeat.BackColor = Color.OrangeRed
    End Sub

    Private Function isBusinessSeat(ByVal seatNumber As String) As Boolean
        Dim row As String = Mid(seatNumber, 2)
        If Val(row) < 6 Then
            Return True
        End If
        Return False
    End Function

    Private Function isEconomySeat(ByVal seatNumber As String) As Boolean
        Dim row As String = Mid(seatNumber, 2)
        If Val(row) > 5 Then
            Return True
        End If
        Return False
    End Function

    Private Function isEpmtySeat(ByVal seatArray) As Boolean
        If seatArray(0) = "" And seatArray(1) = "" Then
            Return True
        End If

        Return False
    End Function

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        If validateForm().Equals(False) Then
            Exit Sub
        End If

        Dim seatNumber = tbxSeat.Text
        If isBusinessSeat(seatNumber) Then
            businessSeatsDictionary(seatNumber) = {tbxFirstName.Text, tbxLastName.Text}
            setReserveSeat(seatNumber)
            MsgBox("You reserved Business seat: " & seatNumber)
        End If

        If isEconomySeat(seatNumber) Then
            economySeatsDictionary(seatNumber) = {tbxFirstName.Text, tbxLastName.Text}
            setReserveSeat(seatNumber)
            MsgBox("You reserved Economy seat: " & seatNumber)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim seatNumber = tbxSeat.Text
        If isBusinessSeat(seatNumber) Then
            businessSeatsDictionary(seatNumber) = {"", ""}
            setEmptySeat(seatNumber)
            MsgBox("You canceled Business seat: " & seatNumber)
        End If

        If isEconomySeat(seatNumber) Then
            economySeatsDictionary(seatNumber) = {"", ""}
            setEmptySeat(seatNumber)
            MsgBox("You canceled Economy seat: " & seatNumber)
        End If
    End Sub

    Private Function validateForm() As Boolean
        If tbxFirstName.Text = "" Or tbxLastName.Text = "" Or tbxSeat.Text = "" Then
            MsgBox("Please fill in forms.")
            Return False
        End If

        Return True
    End Function
End Class