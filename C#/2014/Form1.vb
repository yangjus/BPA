Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Now 'Recieves time of form load
        lstTours.Items.Add("Indianapolis Zoo")
        lstTours.Items.Add("Lucas Oil Stadium Tour")
        lstTours.Items.Add("Motor Speedway Tour")
        lstTours.Items.Add("NCAA Hall of Champions")
        For count As Integer = 1 To 10 Step 1
            cboTickets.Items.Add(count)
        Next
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Weather is currently unavailable; this will be in the next version build.")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim deposit As Integer = 0
        Integer.TryParse(txtDeposit.Text, deposit)
        'Error Checking before proceeding to CalculateBalance()
        If lstTours.SelectedIndex >= 0 And
            String.IsNullOrEmpty(cboTickets.SelectedText) And
            deposit >= 10 Then
            CalculateBalance()
        Else
            MessageBox.Show("You have not met the conditions to calculate.")
        End If
    End Sub

    Public Sub CalculateBalance()
        Dim subtotal As Double = 0
        Dim tax As Double = 0
        Dim balanceDue As Double = 0
        Dim deposit As Double
        Double.TryParse(txtDeposit.Text, deposit)
        Dim taxRate As Double = 0.06

        'If No Expiration Date voucher is selected, one-time fee of $50
        If chkVoucher.Checked = True Then
            subtotal += 50
        End If

        'Calculate tour item prices into subtotal
        If cboTickets.SelectedIndex <= 5 Then '1-5 tickets
            If lstTours.GetSelected(0) Then
                subtotal += 25
            End If
            If lstTours.GetSelected(1) Then
                subtotal += 20
            End If
            If lstTours.GetSelected(2) Then
                subtotal += 15
            End If
            If lstTours.GetSelected(3) Then
                subtotal += 15
            End If
        Else '6-10 tickets
            If lstTours.GetSelected(0) Then
                subtotal += 23
            End If
            If lstTours.GetSelected(1) Then
                subtotal += 18
            End If
            If lstTours.GetSelected(2) Then
                subtotal += 14
            End If
            If lstTours.GetSelected(3) Then
                subtotal += 14
            End If
        End If

        'If Ticket Refund Insurance is selected, 10% total tour charges (before tax)
        If chkRefund.Checked = True Then
            subtotal = subtotal * 1.1
        End If

        'Calculate Tax
        tax = subtotal * taxRate

        'Calculate Balance Due
        balanceDue = subtotal + tax - deposit

        'Output values
        txtSubtotal.Text = subtotal.ToString("C2")
        txtTax.Text = tax.ToString("C2")
        txtBalanceDue.Text = balanceDue.ToString("C2")
    End Sub
End Class
