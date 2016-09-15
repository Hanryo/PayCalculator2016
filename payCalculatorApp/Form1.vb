Public Class MainWindow
    'Variables are stated here
    Dim payRate, maximumHours, taxEnabled As Decimal
    Dim netPay, taxPaid, grossPay, totalAvgHoursWorked, totalHoursWorked, hoursWorked, minutesWorked As Decimal
    Dim path As String

    'Partial Code of the BMP Function
    Declare Auto Function SendMessage Lib "user32" (
         ByVal hWnd As IntPtr,
         ByVal Msg As Integer,
         ByVal wParam As IntPtr,
         ByVal lParam As Integer) As Integer

    'Partial Code of the BMP Function
    Private Enum EDrawingOptions As Integer
        PRF_CHECKVISIBLE = &H1
        PRF_NONCLIENT = &H2
        PRF_CLIENT = &H4
        PRF_ERASEBKGND = &H8
        PRF_CHILDREN = &H10
        PRF_OWNED = &H20
    End Enum

    'Creating Printing BMP Function
    Private Function PrintPanel()
        Const WM_PRINT As Integer = &H317
        Dim myBmp As Bitmap
        Dim myGraphics As Graphics
        Dim hdc As System.IntPtr
        myBmp = New Bitmap(
        Me.calculatorOutput.DisplayRectangle.Width,
        Me.calculatorOutput.DisplayRectangle.Height)
        myGraphics = Graphics.FromImage(myBmp)
        myGraphics.DrawRectangle(Pens.White, New Rectangle(0, 0,
  Me.calculatorOutput.DisplayRectangle.Width, Me.calculatorOutput.DisplayRectangle.Height))
        hdc = myGraphics.GetHdc
        Call SendMessage(calculatorOutput.Handle, WM_PRINT, hdc,
        EDrawingOptions.PRF_CHILDREN Or
        EDrawingOptions.PRF_CLIENT Or
        EDrawingOptions.PRF_NONCLIENT Or
        EDrawingOptions.PRF_OWNED)
        myGraphics.ReleaseHdc(hdc)
        My.Computer.FileSystem.CreateDirectory(System.Windows.Forms.Application.UserAppDataPath & "\Hanryos Calculator\Employees Pays")
        myBmp.Save(System.Windows.Forms.Application.UserAppDataPath & "\Hanryos Calculator\Employees Pays\" & nameEmployeeDisplay.Text & "_" & payRate & "_" & maximumHours & ".bmp")
        myGraphics.Dispose()
        myGraphics = Nothing
        myBmp = Nothing
    End Function

    'Reset the Edit Values page back to default
    Private Sub defaultReset_Click(sender As Object, e As EventArgs) Handles defaultReset.Click
        taxEnabler.CheckState = 1
        taxEnabled = 1
        taxEnabler.Font = New Font(taxEnabler.Font, FontStyle.Bold)
        payRateEditbox.Text = "15"
        payRateEditbox2.Text = "5"
        payRate = payRateEditbox.Text + (payRateEditbox2.Text / 10)
        payRateEditbox.Font = New Font(payRateEditbox.Font, FontStyle.Bold)
        payRateEditbox2.Font = New Font(payRateEditbox2.Font, FontStyle.Bold)
        maximumHoursEditbox2.Text = "00"
        maximumHoursEditbox.Text = "38"
        maximumHours = maximumHoursEditbox.Text + Math.Round((maximumHoursEditbox2.Text / 60), 2, MidpointRounding.AwayFromZero)
        maximumHoursEditbox.Font = New Font(maximumHoursEditbox.Font, FontStyle.Bold)
        maximumHoursEditbox2.Font = New Font(maximumHoursEditbox2.Font, FontStyle.Bold)
        savedLabel.Text = "Default Settings"
        nameEmployeeEditbox.Text = "John Smith"
        hoursWorkedEditbox.Text = "0"
        minutesWorkedEditbox.Text = "00"
        payRateDisplay.Text = ("$" & payRate & "/Hr")
        maximumHoursDisplay.Text = (maximumHours & " Hours")
        nameEmployeeDisplay.Text = "John Smith"
        hoursWorkedDisplay.Text = "-.- Hours"
        grossPayDisplay.Text = "$--"
        taxDisplay.Text = "$--"
        netPayDisplay.Text = "$--"
        nameEmployeeEditbox.Text = "John Smith"
        hoursWorkedEditbox.Text = "0"
        minutesWorkedEditbox.Text = "00"
        MsgBox("Reset Complete", 0 + 64, "Reset")
    End Sub

    'Save the changes made on the Edit Values page
    Private Sub saveChanges_Click(sender As Object, e As EventArgs) Handles saveChanges.Click
        If payRateEditbox.Text = "" Then
            payRateEditbox.Text = "0"
        End If
        If payRateEditbox2.Text = "" Then
            payRateEditbox2.Text = "00"
        End If
        payRate = payRateEditbox.Text + (payRateEditbox2.Text / 10)
        If maximumHoursEditbox.Text = "" Then
            maximumHoursEditbox.Text = "0"
        End If
        If maximumHoursEditbox2.Text = "" Then
            maximumHoursEditbox2.Text = "00"
        End If
        maximumHours = maximumHoursEditbox.Text + Math.Round((maximumHoursEditbox2.Text / 60), 2, MidpointRounding.AwayFromZero)
        taxEnabled = taxEnabler.CheckState
        savedLabel.Text = "Saved!"
        payRateDisplay.Text = ("$" & payRate & "/Hr")
        maximumHoursDisplay.Text = (maximumHours & " Hours")
        nameEmployeeDisplay.Text = ""
        hoursWorkedDisplay.Text = "-.- Hours"
        grossPayDisplay.Text = "$--"
        taxDisplay.Text = "$--"
        netPayDisplay.Text = "$--"
        nameEmployeeEditbox.Text = ""
        hoursWorkedEditbox.Text = "0"
        minutesWorkedEditbox.Text = "00"
    End Sub

    'Opens the About form
    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles HelpToolStripButton.Click
        About.Show()
    End Sub

    'Sets text to bold if it matches the default value
    Private Sub payRateEditbox2_TextChanged(sender As Object, e As EventArgs) Handles payRateEditbox2.TextChanged
        If payRateEditbox.Text = "15" And payRateEditbox2.Text = "5" Or payRateEditbox2.Text = "50" And payRateEditbox.Text = "15" Then
            payRateEditbox.Font = New Font(payRateEditbox.Font, FontStyle.Bold)
            payRateEditbox2.Font = New Font(payRateEditbox2.Font, FontStyle.Bold)
        Else payRateEditbox.Font = New Font(payRateEditbox.Font, FontStyle.Regular)
            payRateEditbox2.Font = New Font(payRateEditbox2.Font, FontStyle.Regular)
        End If
        savedLabel.Text = ""
    End Sub

    'Prevents characters other than numerical values from being entered
    Private Sub payRateEditbox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles payRateEditbox2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Sets text to bold if it matches the default value
    Private Sub payRateEditbox_TextChanged(sender As Object, e As EventArgs) Handles payRateEditbox.TextChanged
        If payRateEditbox.Text = "15" And payRateEditbox2.Text = "5" Or payRateEditbox2.Text = "50" And payRateEditbox.Text = "15" Then
            payRateEditbox.Font = New Font(payRateEditbox.Font, FontStyle.Bold)
            payRateEditbox2.Font = New Font(payRateEditbox2.Font, FontStyle.Bold)
        Else payRateEditbox.Font = New Font(payRateEditbox.Font, FontStyle.Regular)
            payRateEditbox2.Font = New Font(payRateEditbox2.Font, FontStyle.Regular)
        End If
        savedLabel.Text = ""
    End Sub

    'Prevents characters other than numerical values from being entered
    Private Sub hoursWorkedEditbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles hoursWorkedEditbox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Prevents characters other than numerical values from being entered
    Private Sub minutesWorkedEditbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles minutesWorkedEditbox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Clears the Calculator Page's values and visual elements
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        nameEmployeeDisplay.Text = ""
        hoursWorkedDisplay.Text = "-.- Hours"
        grossPayDisplay.Text = "$--"
        taxDisplay.Text = "$--"
        netPayDisplay.Text = "$--"
        nameEmployeeEditbox.Text = ""
        hoursWorkedEditbox.Text = "0"
        minutesWorkedEditbox.Text = "00"
    End Sub

    'Executes the Print Function created earlier
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        PrintPanel()
        Process.Start("explorer.exe", System.Windows.Forms.Application.UserAppDataPath & "\Hanryos Calculator\Employees Pays")
        MsgBox("Saved As " & nameEmployeeDisplay.Text & "_" & payRate & "_" & maximumHours & ".bmp", 0 + 64, "Saved to File")
    End Sub

    'Opens the folder that contains the saved bitmaps from the Print Function
    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        My.Computer.FileSystem.CreateDirectory(System.Windows.Forms.Application.UserAppDataPath & "\Hanryos Calculator\Employees Pays")
        Process.Start("explorer.exe", System.Windows.Forms.Application.UserAppDataPath & "\Hanryos Calculator\Employees Pays")
    End Sub

    'Prevents characters other than numerical values from being entered
    Private Sub maximumHoursEditbox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles maximumHoursEditbox2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Prevents characters other than numerical values from being entered
    Private Sub maximumHoursEditbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles maximumHoursEditbox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Sets text to bold if it matches the default value
    Private Sub maximumHoursEditbox2_TextChanged(sender As Object, e As EventArgs) Handles maximumHoursEditbox2.TextChanged
        If maximumHoursEditbox.Text = "38" And maximumHoursEditbox2.Text = "" Or maximumHoursEditbox.Text = "38" And maximumHoursEditbox2.Text = "00" Or maximumHoursEditbox.Text = "38" And maximumHoursEditbox2.Text = "0" Then
            maximumHoursEditbox.Font = New Font(maximumHoursEditbox.Font, FontStyle.Bold)
            maximumHoursEditbox2.Font = New Font(maximumHoursEditbox2.Font, FontStyle.Bold)
        Else
            maximumHoursEditbox.Font = New Font(maximumHoursEditbox.Font, FontStyle.Regular)
            maximumHoursEditbox2.Font = New Font(maximumHoursEditbox2.Font, FontStyle.Regular)
        End If
        savedLabel.Text = ""
    End Sub

    'This is the main calculator code, when the calculate button is clicked the code below executes and calculates the nessecary values
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        If nameEmployeeEditbox.Text = "" Then
            nameEmployeeEditbox.Text = "Unknown"
        End If
        nameEmployeeDisplay.Text = nameEmployeeEditbox.Text
        If hoursWorkedEditbox.Text = "" Then
            hoursWorkedEditbox.Text = "0"
        End If
        hoursWorked = hoursWorkedEditbox.Text
        If minutesWorkedEditbox.Text = "" Then
            minutesWorkedEditbox.Text = "00"
        End If
        'Equates the small things used for the larger calculations
        minutesWorked = minutesWorkedEditbox.Text
        totalHoursWorked = Convert.ToDecimal(hoursWorkedEditbox.Text + (minutesWorkedEditbox.Text / 60))
        totalAvgHoursWorked = Math.Floor(Convert.ToDecimal(hoursWorkedEditbox.Text + (minutesWorkedEditbox.Text / 60)))
        hoursWorkedDisplay.Text = (hoursWorked + Math.Round((minutesWorked / 60), 2, MidpointRounding.AwayFromZero) & " Hours")
        'Calculates the Gross Pay after checking that the Hours Worked for the week don't exceed the Maximum Hours set
        If totalHoursWorked < maximumHours Then
            grossPay = Math.Round((totalAvgHoursWorked * payRate), 2, MidpointRounding.AwayFromZero)
            grossPayDisplay.Text = ("$" & grossPay)
        Else
            grossPay = Math.Round((maximumHours * payRate), 2, MidpointRounding.AwayFromZero)
            grossPayDisplay.Text = ("$" & grossPay)
        End If
        'Checks if Tax is Enabled before calculating the Tax Paid, if it's not Enabled then the Tax Paid is set to N/A
        If taxEnabled = 1 Then
            If grossPay < (18200 / 52) Then
                taxPaid = 0
            ElseIf grossPay > (18201 / 52) And grossPay < (37000 / 52) Then
                taxPaid = 0.19 * (grossPay - (18200 / 52))
            ElseIf grossPay > (37001 / 52) And grossPay < (80000 / 52) Then
                taxPaid = (3572 / 52) + 0.325 * (grossPay - (37000 / 52))
            ElseIf grossPay > (80001 / 52) And grossPay < (180000 / 52) Then
                taxPaid = (17547 / 52) + 0.37 * (grossPay - (80000 / 52))
            ElseIf grossPay > (180001 / 52) Then
                taxPaid = (54547 / 52) + 0.45 * (grossPay - (180000 / 52))
            End If
            taxDisplay.Text = "$" & Math.Round(taxPaid, 2, MidpointRounding.AwayFromZero)
        Else
            taxDisplay.Text = "N/A"
        End If
        'Checks if Tax is Enabled before displaying the Net Pay
        If taxEnabled = 1 Then
            netPayDisplay.Text = "$" & Math.Round((grossPay - taxPaid), 2, MidpointRounding.AwayFromZero)
        Else
            netPayDisplay.Text = "$" & grossPay
        End If
    End Sub

    'Prevents characters other than numerical values from being entered
    Private Sub payRateEditbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles payRateEditbox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Sets text to bold if it matches the default value
    Private Sub maximumHoursEditbox_TextChanged(sender As Object, e As EventArgs) Handles maximumHoursEditbox.TextChanged
        If maximumHoursEditbox.Text = "38" And maximumHoursEditbox2.Text = "" Or maximumHoursEditbox.Text = "38" And maximumHoursEditbox2.Text = "00" Or maximumHoursEditbox.Text = "38" And maximumHoursEditbox2.Text = "0" Then
            maximumHoursEditbox.Font = New Font(maximumHoursEditbox.Font, FontStyle.Bold)
            maximumHoursEditbox2.Font = New Font(maximumHoursEditbox2.Font, FontStyle.Bold)
        Else
            maximumHoursEditbox.Font = New Font(maximumHoursEditbox.Font, FontStyle.Regular)
            maximumHoursEditbox2.Font = New Font(maximumHoursEditbox2.Font, FontStyle.Regular)
        End If
        savedLabel.Text = ""
    End Sub

    'Sets text to bold if it matches the default value
    Private Sub taxEnabler_CheckedChanged(sender As Object, e As EventArgs) Handles taxEnabler.CheckedChanged
        If taxEnabler.CheckState = 1 Then
            taxEnabler.Text = "Tax Enabled"
            taxEnabled = 1
            taxEnabler.Font = New Font(taxEnabler.Font, FontStyle.Bold)
        ElseIf taxEnabler.CheckState = 0 Then
            taxEnabler.Text = "Tax Disabled"
            taxEnabled = 0
            taxEnabler.Font = New Font(taxEnabler.Font, FontStyle.Regular)
        End If
        savedLabel.Text = ""
    End Sub

    'Upon loading the program, this code below sets up the main variables making sure the defaults are in place and that the visual elements are displaying the start up values
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        taxEnabler.CheckState = 1
        taxEnabled = 1
        taxEnabler.Font = New Font(taxEnabler.Font, FontStyle.Bold)
        payRateEditbox.Text = "15"
        payRateEditbox2.Text = "5"
        payRate = payRateEditbox.Text + (payRateEditbox2.Text / 10)
        payRateEditbox.Font = New Font(payRateEditbox.Font, FontStyle.Bold)
        payRateEditbox2.Font = New Font(payRateEditbox2.Font, FontStyle.Bold)
        maximumHoursEditbox2.Text = "00"
        maximumHoursEditbox.Text = "38"
        maximumHours = maximumHoursEditbox.Text + Math.Round((maximumHoursEditbox2.Text / 60), 2, MidpointRounding.AwayFromZero)
        maximumHoursEditbox.Font = New Font(maximumHoursEditbox.Font, FontStyle.Bold)
        maximumHoursEditbox2.Font = New Font(maximumHoursEditbox2.Font, FontStyle.Bold)
        savedLabel.Text = "Default Settings"
        nameEmployeeEditbox.Text = "John Smith"
        hoursWorkedEditbox.Text = "0"
        minutesWorkedEditbox.Text = "00"
        payRateDisplay.Text = ("$" & payRate & "/Hr")
        maximumHoursDisplay.Text = (maximumHours & " Hours")
    End Sub
End Class
