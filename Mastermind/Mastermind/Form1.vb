Public Class Form1

    Dim intOne As Integer
    Dim intTwo As Integer
    Dim intThree As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Randomize()
        intOne = Int(Rnd() * 4 + 1)
        intTwo = Int(Rnd() * 4 + 1)
        intThree = Int(Rnd() * 4 + 1)

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        Dim str1 As String
        Dim str2 As String
        Dim str3 As String

        Dim intguess1 As Integer
        Dim intguess2 As Integer
        Dim intguess3 As Integer

        str1 = txtGuessOne.Text
        str2 = txtGuessTwo.Text
        str3 = txtGuessThree.Text

        If str1 = "R" Then
            intguess1 = 1
        ElseIf str1 = "G" Then
            intguess1 = 2
        ElseIf str1 = "B" Then
            intguess1 = 3
        ElseIf str1 = "Y" Then
            intguess1 = 4
        End If


        If str2 = "R" Then
            intguess2 = 1
        ElseIf str2 = "G" Then
            intguess2 = 2
        ElseIf str2 = "B" Then
            intguess2 = 3
        ElseIf str2 = "Y" Then
            intguess2 = 4
        End If


        If str3 = "R" Then
            intguess3 = 1
        ElseIf str3 = "G" Then
            intguess3 = 2
        ElseIf str3 = "B" Then
            intguess3 = 3
        ElseIf str3 = "Y" Then
            intguess3 = 4
        End If


        Dim intp As Integer = 0
        Dim intc As Integer = 0


        If (intOne = intguess1) Then
            intp = intp + 1
        End If
        If (intTwo = intguess2) Then
            intp = intp + 1
        End If
        If (intThree = intguess3) Then
            intp = intp + 1
        End If
        lblPositions.Text = intp


        Dim gflag1 As Boolean
        Dim gflag2 As Boolean
        Dim gflag3 As Boolean

        gflag1 = False
        gflag2 = False
        gflag3 = False

        If (intOne = intguess1) Then
            intc = intc + 1
            gflag1 = True
        ElseIf (intOne = intguess2) Then
            intc = intc + 1
            gflag2 = True
        ElseIf (intOne = intguess3) Then
            intc = intc + 1
            gflag3 = True
        End If

        If ((intTwo = intguess1) And (Not gflag1)) Then
            intc = intc + 1
            gflag1 = True
        ElseIf ((intTwo = intguess2) And (Not gflag2)) Then
            intc = intc + 1
            gflag2 = True
        ElseIf ((intTwo = intguess3) And (Not gflag3)) Then
            intc = intc + 1
            gflag3 = True
        End If

        If ((intThree = intguess1) And (Not gflag1)) Then
            intc = intc + 1
            gflag1 = True
        ElseIf ((intThree = intguess2) And (Not gflag2)) Then
            intc = intc + 1
            gflag2 = True
        ElseIf ((intThree = intguess3) And (Not gflag3)) Then
            intc = intc + 1
            gflag3 = True
        End If

        lblColors.Text = intc

    End Sub
End Class
