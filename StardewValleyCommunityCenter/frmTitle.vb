Public Class frmTitle
    Public Shared currentSave As OpenSave

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the program

        Application.Exit()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ' Open the load file form
        Dim frmLoadForm As New frmLoad

        Hide()
        frmLoadForm.ShowDialog()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ' Open the new file form

        Dim frmNewForm As New frmNew

        Hide()
        frmNewForm.ShowDialog()
    End Sub
End Class
