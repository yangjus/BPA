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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComboBoxMonth = New System.Windows.Forms.ComboBox()
        Me.TxtYear = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBoxPayday = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFirst = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLast = New System.Windows.Forms.CheckBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.LblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxMonth
        '
        Me.ComboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMonth.FormattingEnabled = True
        Me.ComboBoxMonth.Location = New System.Drawing.Point(219, 71)
        Me.ComboBoxMonth.Name = "ComboBoxMonth"
        Me.ComboBoxMonth.Size = New System.Drawing.Size(60, 21)
        Me.ComboBoxMonth.TabIndex = 0
        '
        'TxtYear
        '
        Me.TxtYear.Location = New System.Drawing.Point(332, 72)
        Me.TxtYear.MaxLength = 4
        Me.TxtYear.Name = "TxtYear"
        Me.TxtYear.Size = New System.Drawing.Size(56, 20)
        Me.TxtYear.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Month"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(344, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Year"
        '
        'CheckBoxPayday
        '
        Me.CheckBoxPayday.AutoSize = True
        Me.CheckBoxPayday.Location = New System.Drawing.Point(64, 143)
        Me.CheckBoxPayday.Name = "CheckBoxPayday"
        Me.CheckBoxPayday.Size = New System.Drawing.Size(99, 17)
        Me.CheckBoxPayday.TabIndex = 7
        Me.CheckBoxPayday.Text = "Month Paydays"
        Me.CheckBoxPayday.UseVisualStyleBackColor = True
        '
        'CheckBoxFirst
        '
        Me.CheckBoxFirst.AutoSize = True
        Me.CheckBoxFirst.Location = New System.Drawing.Point(251, 143)
        Me.CheckBoxFirst.Name = "CheckBoxFirst"
        Me.CheckBoxFirst.Size = New System.Drawing.Size(112, 17)
        Me.CheckBoxFirst.TabIndex = 8
        Me.CheckBoxFirst.Text = "First Business Day"
        Me.CheckBoxFirst.UseVisualStyleBackColor = True
        '
        'CheckBoxLast
        '
        Me.CheckBoxLast.AutoSize = True
        Me.CheckBoxLast.Location = New System.Drawing.Point(429, 143)
        Me.CheckBoxLast.Name = "CheckBoxLast"
        Me.CheckBoxLast.Size = New System.Drawing.Size(113, 17)
        Me.CheckBoxLast.TabIndex = 9
        Me.CheckBoxLast.Text = "Last Business Day"
        Me.CheckBoxLast.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(268, 194)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 10
        Me.BtnStart.Text = "Calculate"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(177, 383)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 11
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(360, 383)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 12
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.Location = New System.Drawing.Point(107, 252)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(39, 13)
        Me.LblMessage.TabIndex = 13
        Me.LblMessage.Text = "Output"
        '
        'LblOutput
        '
        Me.LblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblOutput.Location = New System.Drawing.Point(110, 277)
        Me.LblOutput.Name = "LblOutput"
        Me.LblOutput.Size = New System.Drawing.Size(401, 87)
        Me.LblOutput.TabIndex = 14
        Me.LblOutput.Text = resources.GetString("LblOutput.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.LblOutput)
        Me.Controls.Add(Me.LblMessage)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.CheckBoxLast)
        Me.Controls.Add(Me.CheckBoxFirst)
        Me.Controls.Add(Me.CheckBoxPayday)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtYear)
        Me.Controls.Add(Me.ComboBoxMonth)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPA State - VB_2017_REG_ContestantNumber"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxMonth As ComboBox
    Friend WithEvents TxtYear As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBoxPayday As CheckBox
    Friend WithEvents CheckBoxFirst As CheckBox
    Friend WithEvents CheckBoxLast As CheckBox
    Friend WithEvents BtnStart As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblMessage As Label
    Friend WithEvents LblOutput As Label
End Class
