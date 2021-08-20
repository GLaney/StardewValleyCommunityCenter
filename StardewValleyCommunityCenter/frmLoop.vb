Public Class frmLoop

    Private Sub frmLoop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkItems.Items.Clear()
        dropDay.SelectedItem = frmTitle.currentSave.gameDay
        dropSeason.SelectedItem = frmTitle.currentSave.gameSeason
        dropWeather.SelectedItem = frmTitle.currentSave.gameWeather
        updateDailyInfo()


    End Sub
    Private Sub dropSeason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropSeason.SelectedIndexChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveData()
        MsgBox("Data Saved.")

    End Sub

    Private Function updateDailyInfo() As Integer
        chkItems.Items.Clear()

        frmTitle.currentSave = New OpenSave(frmTitle.currentSave.saveName)



        For i As Integer = 1 To frmTitle.currentSave.arrItemList.Length - 1
            Try
                If ((frmTitle.currentSave.arrItemList(i).seasons.Contains(frmTitle.currentSave.gameSeason) Or (frmTitle.currentSave.arrItemList(i).seasons.Contains("Any"))) And ((frmTitle.currentSave.arrItemList(i).weathers.Contains(frmTitle.currentSave.gameWeather)) Or (frmTitle.currentSave.arrItemList(i).weathers.Contains("Any")))) Then
                    chkItems.Items.Add(frmTitle.currentSave.arrItemList(i).itemType)
                End If
            Catch ex As Exception

            End Try

        Next


        Return 1
    End Function

    Private Sub btnNewDay_Click(sender As Object, e As EventArgs) Handles btnNewDay.Click


        saveData()
        updateDailyInfo()
    End Sub

    Private Function saveData() As Integer
        System.IO.File.WriteAllText(frmTitle.currentSave.saveName, "")
        Dim afile As System.IO.StreamWriter
        afile = My.Computer.FileSystem.OpenTextFileWriter(frmTitle.currentSave.saveName, True)

        afile.WriteLine(dropSeason.Text & " " & dropDay.Text & " " & dropWeather.Text)

        For num As Integer = 0 To chkItems.Items.Count - 1
            If (Not chkItems.CheckedIndices.Contains(num)) Then
                afile.WriteLine(chkItems.Items(num))
            End If
        Next
        afile.Close()
        Return 1
    End Function
End Class