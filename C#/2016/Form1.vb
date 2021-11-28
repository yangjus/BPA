Public Class frmMain
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Dim result = MessageBox.Show("Do you wish to exit this application?",
            "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnHero_Click(sender As Object, e As EventArgs) Handles btnHero.Click
        Dim heroform = New frmHero()
        heroform.Show()
    End Sub

    Private Sub btnVillan_Click(sender As Object, e As EventArgs) Handles btnVillan.Click
        Dim result = MessageBox.Show("Coming soon: Select a villan.",
                                       "Confirm", MessageBoxButtons.OK)
    End Sub
End Class
