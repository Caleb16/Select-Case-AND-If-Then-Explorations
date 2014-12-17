Public Class Form1

    Private Sub btnThrow_Click(sender As Object, e As EventArgs) Handles btnThrow.Click
        Dim intRock As Integer = 1
        Dim intPaper As Integer = 2
        Dim intScissors As Integer = 3
        Dim intComThrow As Integer
        Dim strName As String = Me.txtName.Text
        Dim intUserScore As Integer = 0
        Dim intComScore As Integer = 0
        Dim intTieScore As Integer = 0

        Me.lblUser.Text = strName & "'s" & " Score"

        Randomize()
        intComThrow = Int((3 - 1 + 1) * Rnd() + 1)

        If intComThrow = intRock And Me.rdoRock.Checked = True Then
            Me.lblResult.Text = "Rock Vs. Rock, Tie"
            intTieScore += 1
        ElseIf intComThrow = intRock And Me.rdoPaper.Checked = True Then
            Me.lblResult.Text = "Paper Covers Rock, " & strName & " Wins"
            intUserScore += 1
        ElseIf intComThrow = intRock And Me.rdoScissors.Checked = True Then
            Me.lblResult.Text = "Rock Smashes Scissors, Computer Wins"
            intComScore += 1
        End If

        If intComThrow = intPaper And Me.rdoRock.Checked = True Then
            Me.lblResult.Text = "Paper Covers Rock, Computer Wins"
            intComScore += 1
        ElseIf intComThrow = intPaper And Me.rdoPaper.Checked = True Then
            Me.lblResult.Text = "Paper Vs. Paper, Tie"
            intTieScore += 1
        ElseIf intComThrow = intPaper And Me.rdoScissors.Checked = True Then
            Me.lblResult.Text = "Scissors Cuts Paper, " & strName & " Wins"
            intUserScore += 1
        End If

        If intComThrow = intScissors And Me.rdoRock.Checked = True Then
            Me.lblResult.Text = "Rock Smashes Scissors, " & strName & " Wins"
            intUserScore += 1
        ElseIf intComThrow = intScissors And Me.rdoPaper.Checked = True Then
            Me.lblResult.Text = "Scissors Cut Paper, Computer Wins"
            intComScore += 1
        ElseIf intComThrow = intScissors And Me.rdoScissors.Checked = True Then
            Me.lblResult.Text = "Scissors Vs. Scissors, Tie"
            intTieScore += 1
        End If

        'Update scores on Game Board
        Me.lblTieScore.Text = intTieScore
        Me.lblUserScore.Text = intUserScore
        Me.lblComputerScore.Text = intComScore
    End Sub
End Class
