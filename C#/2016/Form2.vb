Public Class frmHero
    Private Sub frmHero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstHero.Items.Add("Archer")
        lstHero.Items.Add("Warrior")
        lstHero.Items.Add("Wizard")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If lstHero.SelectedIndex >= 0 Then 'Something is selected
            If GroupBox1.Enabled = False Then
                MessageBox.Show("Please select a level.")
            Else
                CalcHeroLevels()
            End If
        Else
            MessageBox.Show("Please select a hero.")
        End If
    End Sub
    Private Sub lstHero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHero.SelectedIndexChanged
        ResetValues()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Public Sub CalcHeroLevels()
        Dim archer() As Integer = {100, 145, 80, 100}
        Dim warrior() As Integer = {150, 115, 120, 90}
        Dim wizard() As Integer = {200, 400, 100, 600}

        Dim multiplier As Integer
        If radLevel1.Checked Then
            multiplier = 1
        ElseIf radLevel10.Checked Then
            multiplier = 2
        ElseIf radLevel25.Checked Then
            multiplier = 3
        ElseIf radLevel50.Checked Then
            multiplier = 4
        ElseIf radLevel75.Checked Then
            multiplier = 5
        ElseIf radLevel99.Checked Then
            multiplier = 6
        End If

        If lstHero.SelectedItem = "Archer" Then 'archer
            lblStrength.Text = archer(0) * multiplier
            lblSpeed.Text = archer(1) * multiplier
            lblArmor.Text = archer(2) * multiplier
            lblMagic.Text = archer(3) * multiplier
            lblTotal.Text = (archer(0) + archer(1) + archer(2) + archer(3)) * multiplier
        ElseIf lstHero.SelectedItem = "Warrior" Then 'warrior
            lblStrength.Text = warrior(0) * multiplier
            lblSpeed.Text = warrior(1) * multiplier
            lblArmor.Text = warrior(2) * multiplier
            lblMagic.Text = warrior(3) * multiplier
            lblTotal.Text = (warrior(0) + warrior(1) + warrior(2) + warrior(3)) * multiplier
        ElseIf lstHero.SelectedItem = "Wizard" Then 'wizard
            lblStrength.Text = wizard(0) * multiplier
            lblSpeed.Text = wizard(1) * multiplier
            lblArmor.Text = wizard(2) * multiplier
            lblMagic.Text = wizard(3) * multiplier
            lblTotal.Text = (wizard(0) + wizard(1) + wizard(2) + wizard(3)) * multiplier
        End If
    End Sub

    Public Sub ResetValues() 'When hero is selected from list
        For Each choice As RadioButton In GroupBox1.Controls 'reset levelbox radiobuttons
            If choice.Checked = True Then
                choice.Checked = False
            End If
        Next
        radLevel1.Checked = True 'Default skill level to Level 1
        'Reset skill labels
        lblStrength.Text = ""
        lblArmor.Text = ""
        lblMagic.Text = ""
        lblSpeed.Text = ""
        lblTotal.Text = ""

        'Update picturebox
        If lstHero.SelectedItem = "Archer" Then
            'My.Application.Info.DirectoryPath goes to project\bin\Debug folder
            picHero.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\images\archer.jpg")
        ElseIf lstHero.SelectedItem = "Warrior" Then
            picHero.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\images\warrior.jpg")
        ElseIf lstHero.SelectedItem = "Wizard" Then
            picHero.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\images\wizard.jpg")
        End If
    End Sub
End Class