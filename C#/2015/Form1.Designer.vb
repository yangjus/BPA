<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpFileContents = New System.Windows.Forms.GroupBox()
        Me.grpActions = New System.Windows.Forms.GroupBox()
        Me.cmdProcess = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.LblFileName = New System.Windows.Forms.Label()
        Me.txtFileContents = New System.Windows.Forms.TextBox()
        Me.LblFileContents = New System.Windows.Forms.Label()
        Me.LblCharacters = New System.Windows.Forms.Label()
        Me.LblWords = New System.Windows.Forms.Label()
        Me.LblSentences = New System.Windows.Forms.Label()
        Me.LblVowels = New System.Windows.Forms.Label()
        Me.txtCharacterCount = New System.Windows.Forms.TextBox()
        Me.txtWordCount = New System.Windows.Forms.TextBox()
        Me.txtSentenceCount = New System.Windows.Forms.TextBox()
        Me.txtVowelCount = New System.Windows.Forms.TextBox()
        Me.grpFileContents.SuspendLayout()
        Me.grpActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFileContents
        '
        Me.grpFileContents.Controls.Add(Me.txtVowelCount)
        Me.grpFileContents.Controls.Add(Me.txtSentenceCount)
        Me.grpFileContents.Controls.Add(Me.txtWordCount)
        Me.grpFileContents.Controls.Add(Me.txtCharacterCount)
        Me.grpFileContents.Controls.Add(Me.LblVowels)
        Me.grpFileContents.Controls.Add(Me.LblSentences)
        Me.grpFileContents.Controls.Add(Me.LblWords)
        Me.grpFileContents.Controls.Add(Me.LblCharacters)
        Me.grpFileContents.Location = New System.Drawing.Point(23, 82)
        Me.grpFileContents.Name = "grpFileContents"
        Me.grpFileContents.Size = New System.Drawing.Size(254, 152)
        Me.grpFileContents.TabIndex = 0
        Me.grpFileContents.TabStop = False
        Me.grpFileContents.Text = "File Details"
        '
        'grpActions
        '
        Me.grpActions.Controls.Add(Me.cmdExit)
        Me.grpActions.Controls.Add(Me.cmdClear)
        Me.grpActions.Controls.Add(Me.cmdProcess)
        Me.grpActions.Location = New System.Drawing.Point(349, 82)
        Me.grpActions.Name = "grpActions"
        Me.grpActions.Size = New System.Drawing.Size(229, 152)
        Me.grpActions.TabIndex = 1
        Me.grpActions.TabStop = False
        Me.grpActions.Text = "Actions"
        '
        'cmdProcess
        '
        Me.cmdProcess.Enabled = False
        Me.cmdProcess.Location = New System.Drawing.Point(77, 19)
        Me.cmdProcess.Name = "cmdProcess"
        Me.cmdProcess.Size = New System.Drawing.Size(75, 23)
        Me.cmdProcess.TabIndex = 0
        Me.cmdProcess.Text = "Process"
        Me.cmdProcess.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Enabled = False
        Me.cmdClear.Location = New System.Drawing.Point(77, 65)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 1
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(77, 110)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.Location = New System.Drawing.Point(491, 39)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(75, 23)
        Me.cmdChooseFile.TabIndex = 2
        Me.cmdChooseFile.Text = "Choose File"
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(33, 39)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(437, 20)
        Me.txtFileName.TabIndex = 3
        '
        'LblFileName
        '
        Me.LblFileName.AutoSize = True
        Me.LblFileName.Location = New System.Drawing.Point(33, 20)
        Me.LblFileName.Name = "LblFileName"
        Me.LblFileName.Size = New System.Drawing.Size(57, 13)
        Me.LblFileName.TabIndex = 4
        Me.LblFileName.Text = "File Name:"
        '
        'txtFileContents
        '
        Me.txtFileContents.Location = New System.Drawing.Point(23, 279)
        Me.txtFileContents.Multiline = True
        Me.txtFileContents.Name = "txtFileContents"
        Me.txtFileContents.ReadOnly = True
        Me.txtFileContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFileContents.Size = New System.Drawing.Size(555, 170)
        Me.txtFileContents.TabIndex = 5
        '
        'LblFileContents
        '
        Me.LblFileContents.AutoSize = True
        Me.LblFileContents.Location = New System.Drawing.Point(23, 260)
        Me.LblFileContents.Name = "LblFileContents"
        Me.LblFileContents.Size = New System.Drawing.Size(71, 13)
        Me.LblFileContents.TabIndex = 6
        Me.LblFileContents.Text = "File Contents:"
        '
        'LblCharacters
        '
        Me.LblCharacters.AutoSize = True
        Me.LblCharacters.Location = New System.Drawing.Point(13, 28)
        Me.LblCharacters.Name = "LblCharacters"
        Me.LblCharacters.Size = New System.Drawing.Size(61, 13)
        Me.LblCharacters.TabIndex = 0
        Me.LblCharacters.Text = "Characters:"
        '
        'LblWords
        '
        Me.LblWords.AutoSize = True
        Me.LblWords.Location = New System.Drawing.Point(13, 59)
        Me.LblWords.Name = "LblWords"
        Me.LblWords.Size = New System.Drawing.Size(41, 13)
        Me.LblWords.TabIndex = 1
        Me.LblWords.Text = "Words:"
        '
        'LblSentences
        '
        Me.LblSentences.AutoSize = True
        Me.LblSentences.Location = New System.Drawing.Point(13, 89)
        Me.LblSentences.Name = "LblSentences"
        Me.LblSentences.Size = New System.Drawing.Size(61, 13)
        Me.LblSentences.TabIndex = 2
        Me.LblSentences.Text = "Sentences:"
        '
        'LblVowels
        '
        Me.LblVowels.AutoSize = True
        Me.LblVowels.Location = New System.Drawing.Point(13, 122)
        Me.LblVowels.Name = "LblVowels"
        Me.LblVowels.Size = New System.Drawing.Size(44, 13)
        Me.LblVowels.TabIndex = 3
        Me.LblVowels.Text = "Vowels:"
        '
        'txtCharacterCount
        '
        Me.txtCharacterCount.Location = New System.Drawing.Point(139, 25)
        Me.txtCharacterCount.Name = "txtCharacterCount"
        Me.txtCharacterCount.ReadOnly = True
        Me.txtCharacterCount.Size = New System.Drawing.Size(100, 20)
        Me.txtCharacterCount.TabIndex = 4
        '
        'txtWordCount
        '
        Me.txtWordCount.Location = New System.Drawing.Point(139, 56)
        Me.txtWordCount.Name = "txtWordCount"
        Me.txtWordCount.ReadOnly = True
        Me.txtWordCount.Size = New System.Drawing.Size(100, 20)
        Me.txtWordCount.TabIndex = 5
        '
        'txtSentenceCount
        '
        Me.txtSentenceCount.Location = New System.Drawing.Point(139, 86)
        Me.txtSentenceCount.Name = "txtSentenceCount"
        Me.txtSentenceCount.ReadOnly = True
        Me.txtSentenceCount.Size = New System.Drawing.Size(100, 20)
        Me.txtSentenceCount.TabIndex = 6
        '
        'txtVowelCount
        '
        Me.txtVowelCount.Location = New System.Drawing.Point(139, 119)
        Me.txtVowelCount.Name = "txtVowelCount"
        Me.txtVowelCount.ReadOnly = True
        Me.txtVowelCount.Size = New System.Drawing.Size(100, 20)
        Me.txtVowelCount.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 461)
        Me.Controls.Add(Me.LblFileContents)
        Me.Controls.Add(Me.txtFileContents)
        Me.Controls.Add(Me.LblFileName)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.grpActions)
        Me.Controls.Add(Me.grpFileContents)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Submission Statistics: Contestant #ABC"
        Me.grpFileContents.ResumeLayout(False)
        Me.grpFileContents.PerformLayout()
        Me.grpActions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpFileContents As GroupBox
    Friend WithEvents txtVowelCount As TextBox
    Friend WithEvents txtSentenceCount As TextBox
    Friend WithEvents txtWordCount As TextBox
    Friend WithEvents txtCharacterCount As TextBox
    Friend WithEvents LblVowels As Label
    Friend WithEvents LblSentences As Label
    Friend WithEvents LblWords As Label
    Friend WithEvents LblCharacters As Label
    Friend WithEvents grpActions As GroupBox
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdProcess As Button
    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents LblFileName As Label
    Friend WithEvents txtFileContents As TextBox
    Friend WithEvents LblFileContents As Label
End Class
