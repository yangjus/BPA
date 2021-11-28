Imports System.Text.RegularExpressions
Public Class frmMain
    Dim fileName As String
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Dim result = MessageBox.Show("Do you wish to exit this application?",
                                     "Exit?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        txtFileName.Text = vbNullString
        txtCharacterCount.Text = vbNullString
        txtWordCount.Text = vbNullString
        txtSentenceCount.Text = vbNullString
        txtVowelCount.Text = vbNullString
        cmdClear.Enabled = False
        cmdProcess.Enabled = False
    End Sub

    Private Sub cmdProcess_Click(sender As Object, e As EventArgs) Handles cmdProcess.Click
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(fileName)
        txtFileContents.Text = fileReader

        txtCharacterCount.Text = fileReader.Length()
        txtWordCount.Text = fileReader.Split().Count
        txtSentenceCount.Text = fileReader.Split("."c, "!"c, "?"c).Length
        txtVowelCount.Text = Regex.Matches(fileReader, "[aeiouAEIOU]").Count
        cmdClear.Enabled = True
        cmdProcess.Enabled = True
    End Sub

    Private Sub cmdChooseFile_Click(sender As Object, e As EventArgs) Handles cmdChooseFile.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text files (*.txt)|*.txt"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            fileName = openFileDialog.FileName
            txtFileName.Text = fileName
        End If
        cmdProcess.Enabled = True
    End Sub
End Class
