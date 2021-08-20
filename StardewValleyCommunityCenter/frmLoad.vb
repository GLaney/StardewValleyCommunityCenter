
Imports System.IO
Public Class frmLoad
    Dim strDirectory As String = "../../SaveFiles/"
    Private Sub frmLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(strDirectory)

            lstLoad.Items.Add(Path.GetFileName(foundFile))
        Next
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim frmLoopForm As New frmLoop
        frmTitle.currentSave = New OpenSave(strDirectory & lstLoad.SelectedItem)



        Hide()
        frmLoopForm.ShowDialog()
    End Sub
End Class