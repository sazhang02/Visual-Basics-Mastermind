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
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.lblColorsC = New System.Windows.Forms.Label()
        Me.lblPositionsC = New System.Windows.Forms.Label()
        Me.lblColors = New System.Windows.Forms.Label()
        Me.lblPositions = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtGuessOne = New System.Windows.Forms.TextBox()
        Me.txtGuessTwo = New System.Windows.Forms.TextBox()
        Me.txtGuessThree = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(16, 42)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(67, 13)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Enter Colors:"
        '
        'lblColorsC
        '
        Me.lblColorsC.AutoSize = True
        Me.lblColorsC.Location = New System.Drawing.Point(16, 104)
        Me.lblColorsC.Name = "lblColorsC"
        Me.lblColorsC.Size = New System.Drawing.Size(81, 13)
        Me.lblColorsC.TabIndex = 1
        Me.lblColorsC.Text = "Colors correct ="
        '
        'lblPositionsC
        '
        Me.lblPositionsC.AutoSize = True
        Me.lblPositionsC.Location = New System.Drawing.Point(16, 136)
        Me.lblPositionsC.Name = "lblPositionsC"
        Me.lblPositionsC.Size = New System.Drawing.Size(95, 13)
        Me.lblPositionsC.TabIndex = 2
        Me.lblPositionsC.Text = "Positions Correct ="
        '
        'lblColors
        '
        Me.lblColors.AutoSize = True
        Me.lblColors.Location = New System.Drawing.Point(117, 104)
        Me.lblColors.Name = "lblColors"
        Me.lblColors.Size = New System.Drawing.Size(37, 13)
        Me.lblColors.TabIndex = 3
        Me.lblColors.Text = "_____"
        '
        'lblPositions
        '
        Me.lblPositions.AutoSize = True
        Me.lblPositions.Location = New System.Drawing.Point(117, 136)
        Me.lblPositions.Name = "lblPositions"
        Me.lblPositions.Size = New System.Drawing.Size(37, 13)
        Me.lblPositions.TabIndex = 4
        Me.lblPositions.Text = "_____"
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(167, 197)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(89, 23)
        Me.btnCheck.TabIndex = 5
        Me.btnCheck.Text = "Check Guess"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtGuessOne
        '
        Me.txtGuessOne.Location = New System.Drawing.Point(92, 39)
        Me.txtGuessOne.Name = "txtGuessOne"
        Me.txtGuessOne.Size = New System.Drawing.Size(47, 20)
        Me.txtGuessOne.TabIndex = 6
        '
        'txtGuessTwo
        '
        Me.txtGuessTwo.Location = New System.Drawing.Point(145, 39)
        Me.txtGuessTwo.Name = "txtGuessTwo"
        Me.txtGuessTwo.Size = New System.Drawing.Size(53, 20)
        Me.txtGuessTwo.TabIndex = 7
        '
        'txtGuessThree
        '
        Me.txtGuessThree.Location = New System.Drawing.Point(204, 39)
        Me.txtGuessThree.Name = "txtGuessThree"
        Me.txtGuessThree.Size = New System.Drawing.Size(53, 20)
        Me.txtGuessThree.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtGuessThree)
        Me.Controls.Add(Me.txtGuessTwo)
        Me.Controls.Add(Me.txtGuessOne)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblPositions)
        Me.Controls.Add(Me.lblColors)
        Me.Controls.Add(Me.lblPositionsC)
        Me.Controls.Add(Me.lblColorsC)
        Me.Controls.Add(Me.lblEnter)
        Me.Name = "Form1"
        Me.Text = "Mastermind"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    Friend WithEvents lblColorsC As System.Windows.Forms.Label
    Friend WithEvents lblPositionsC As System.Windows.Forms.Label
    Friend WithEvents lblColors As System.Windows.Forms.Label
    Friend WithEvents lblPositions As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents txtGuessOne As System.Windows.Forms.TextBox
    Friend WithEvents txtGuessTwo As System.Windows.Forms.TextBox
    Friend WithEvents txtGuessThree As System.Windows.Forms.TextBox

End Class
