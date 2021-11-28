Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate the comboBox
        For month As Integer = 1 To 12 Step 1
            ComboBoxMonth.Items.Add(month)
        Next
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        'Initialize variables
        Dim year As Integer
        Dim month As Integer
        'From textbox selection
        year = TxtYear.Text
        'From combobox selection, + 1 since index starts at 0
        month = ComboBoxMonth.SelectedIndex + 1

        'Output selection in label
        LblMessage.Text = "Output for month: " & month & ", year: " & year

        'If invalid year selected
        If (year < 2010 Or year > 2300) Then
            LblOutput.Text = "ERROR: Must have valid month and year"

        ElseIf (CheckBoxPayday.Checked = False) AndAlso 'If no checkboxes checked
                (CheckBoxFirst.Checked = False) AndAlso
                (CheckBoxLast.Checked = False) Then
            MessageBox.Show("You must select something to calculate", "Application Warning",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Else 'If no errors, check which boxes are checked and output
            If (CheckBoxPayday.Checked) Then
                Dim firstFriday As New DateTime(year, month, 1)
                'If first day of month is a Friday, day = 1, else keep incrementing till Friday
                Do Until firstFriday.DayOfWeek = DayOfWeek.Friday
                    firstFriday = firstFriday.AddDays(1)
                Loop
                LblOutput.Text = "PAYDAY: " & firstFriday.Day & ", Friday" &
                Environment.NewLine & "PAYDAY: " & firstFriday.Day + 14 &
                ", Friday" & Environment.NewLine
            End If

            If (CheckBoxFirst.Checked) Then
                Dim firstDay As New DateTime(year, month, 1)
                'Keep incrementing days until it is not saturday or sunday
                While firstDay.DayOfWeek = DayOfWeek.Saturday OrElse firstDay.DayOfWeek = DayOfWeek.Sunday
                    firstDay = firstDay.AddDays(1)
                End While
                LblOutput.Text += "FIRST BUSINESS DAY: " & firstDay.Day & ", " & firstDay.ToString("dddd") & Environment.NewLine
            End If

            If (CheckBoxLast.Checked) Then
                Dim daysInMonth As Integer = System.DateTime.DaysInMonth(year, month)
                Dim lastDay As New DateTime(year, month, daysInMonth)
                'Keep decrementing days until it is not saturday or sunday
                While lastDay.DayOfWeek = DayOfWeek.Saturday OrElse lastDay.DayOfWeek = DayOfWeek.Sunday
                    lastDay = lastDay.AddDays(-1)
                End While
                LblOutput.Text += "LAST BUSINESS DAY: " & lastDay.Day & ", " & lastDay.ToString("dddd")
            End If
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtYear.Clear()
        ComboBoxMonth.SelectedIndex = -1
        CheckBoxPayday.Checked = False
        CheckBoxFirst.Checked = False
        CheckBoxLast.Checked = False
        LblMessage.Text = "Output"
        LblOutput.Text = " "
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
