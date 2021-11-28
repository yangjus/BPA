<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstTours = New System.Windows.Forms.ListBox()
        Me.cboTickets = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.chkRefund = New System.Windows.Forms.CheckBox()
        Me.chkVoucher = New System.Windows.Forms.CheckBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtBalanceDue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(42, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select all Indianapolis Tours to Purchase"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstTours
        '
        Me.lstTours.FormattingEnabled = True
        Me.lstTours.Location = New System.Drawing.Point(29, 80)
        Me.lstTours.Name = "lstTours"
        Me.lstTours.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstTours.Size = New System.Drawing.Size(149, 108)
        Me.lstTours.TabIndex = 1
        '
        'cboTickets
        '
        Me.cboTickets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTickets.FormattingEnabled = True
        Me.cboTickets.Location = New System.Drawing.Point(220, 80)
        Me.cboTickets.Name = "cboTickets"
        Me.cboTickets.Size = New System.Drawing.Size(121, 21)
        Me.cboTickets.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number of Tickets"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(26, 251)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(151, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Indianapolis Weather Forecast"
        '
        'chkRefund
        '
        Me.chkRefund.AutoSize = True
        Me.chkRefund.Location = New System.Drawing.Point(220, 120)
        Me.chkRefund.Name = "chkRefund"
        Me.chkRefund.Size = New System.Drawing.Size(144, 17)
        Me.chkRefund.TabIndex = 5
        Me.chkRefund.Text = "Ticket Refund Insurance"
        Me.chkRefund.UseVisualStyleBackColor = True
        '
        'chkVoucher
        '
        Me.chkVoucher.AutoSize = True
        Me.chkVoucher.Location = New System.Drawing.Point(220, 152)
        Me.chkVoucher.Name = "chkVoucher"
        Me.chkVoucher.Size = New System.Drawing.Size(158, 17)
        Me.chkVoucher.TabIndex = 6
        Me.chkVoucher.Text = "No Expiration Date Voucher"
        Me.chkVoucher.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(458, 23)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 13)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(397, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Subtotal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(397, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tax"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Deposit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(397, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Balance due"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(470, 113)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(100, 20)
        Me.txtTax.TabIndex = 12
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(220, 241)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(83, 29)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(341, 239)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 31)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(470, 77)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 18
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(470, 152)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 20)
        Me.txtDeposit.TabIndex = 19
        Me.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBalanceDue
        '
        Me.txtBalanceDue.Location = New System.Drawing.Point(470, 190)
        Me.txtBalanceDue.Name = "txtBalanceDue"
        Me.txtBalanceDue.ReadOnly = True
        Me.txtBalanceDue.Size = New System.Drawing.Size(100, 20)
        Me.txtBalanceDue.TabIndex = 20
        Me.txtBalanceDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 307)
        Me.Controls.Add(Me.txtBalanceDue)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.chkVoucher)
        Me.Controls.Add(Me.chkRefund)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTickets)
        Me.Controls.Add(Me.lstTours)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Indianapolis Tour Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstTours As ListBox
    Friend WithEvents cboTickets As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents chkRefund As CheckBox
    Friend WithEvents chkVoucher As CheckBox
    Friend WithEvents lblDate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents txtBalanceDue As TextBox
End Class
