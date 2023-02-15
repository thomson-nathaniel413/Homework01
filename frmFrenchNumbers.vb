'Program Name: French Numbers
Public Class frmFrenchNumbers
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'When this button is clicked, the program should close
        Close()
    End Sub

    Private Sub frmFrenchNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When program loads, lblFrench should be made invisible
        lblFrench.Visible = False
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        'When this button is clicked, lblFrench should become visible and have text 'un'
        lblFrench.Visible = True
        lblFrench.Text = "un"
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        'When this button is clicked, lblFrench should become visible and have text 'deux'
        lblFrench.Visible = True
        lblFrench.Text = "deux"
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        'When this button is clicked, lblFrench should become visible and have text 'trois'
        lblFrench.Visible = True
        lblFrench.Text = "trois"
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        'When this button is clicked, lblFrench should become visible and have text 'quatre'
        lblFrench.Visible = True
        lblFrench.Text = "quatre"
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        'When this button is clicked, lblFrench should become visible and have text 'cinq'
        lblFrench.Visible = True
        lblFrench.Text = "cinq"
    End Sub
End Class
