' Purpose:  Handles all interactions with the frmNew Form.
Option Strict On
Imports System.IO



Public Class frmNew
    Dim strFileName As String
    Dim strDirectory As String = "../../SaveFiles/"
    Dim blnNameAvailable As Boolean = True

    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        ' Check that there is not already a file with the given name and create new save file with the given name.
        Dim strErrorFileExists As String = "A file already exists with that name."

        strFileName = txtFileName.Text & ".txt"

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(strDirectory)

            If (Path.GetFileName(foundFile) = strFileName) Then
                blnNameAvailable = False
            End If
        Next

        If (blnNameAvailable) Then
            Dim newFile As FileStream = File.Create(strDirectory & strFileName)
            Dim frmLoopForm As New frmLoop
            newFile.Close()
            createNewSave(strDirectory & strFileName)

            frmTitle.currentSave = New OpenSave(strDirectory & strFileName)





            Hide()
            frmLoopForm.ShowDialog()
        Else
            MsgBox(strErrorFileExists)
            txtFileName.Focus()
        End If
        blnNameAvailable = True


    End Sub

    Private Function createNewSave(path As String) As Integer
        Dim arrItems As String() = {"Wild Horseradish", "Daffodil", "Leek", "Dandelion", "Grape", "Spice Berry", "Sweet Pea", "Common Mushroom", "Wild Plum",
        "Hazelnut", "Blackberry", "Winter Root", "Crystal Fruit", "Snow Yam", "Crocus", "Wood", "Wood", "Stone", "Hardwood", "Coconut", "Cactus Fruit",
        "Cave Carrot", "Red Mushroom", "Purple Mushroom", "Maple Syrup", "Oak Resin", "Pine Tar", "Morel", "Parsnip", "Green Bean", "Cauliflower", "Potato",
        "Tomato", "Hot Pepper", "Blueberry", "Melon", "Corn", "Eggplant", "Pumpkin", "Yam", "Parsnip(G)", "Melon(G)", "Pumpkin(G)", "Corn(G)", "Large Milk",
        "Large Egg (Brown)", "Large Egg", "Large Goat Milk", "Wool", "Duck Egg", "Truffle Oil", "Cloth", "Goat Cheese", "Cheese", "Honey", "Jelly", "Apple",
        "Apricot", "Orange", "Peach", "Pomegranate", "Cherry", "Sunfish", "Catfish", "Shad", "Tiger Trout", "Largemouth Bass", "Carp", "Bullhead", "Sturgeon",
        "Sardine", "Tuna", "Red Snapper", "Tilapia", "Walleye", "Bream", "Eel", "Lobster", "Crayfish", "Crab", "Cockle", "Mussel", "Shrimp", "Snail",
        "Periwinkle", "Oyster", "Clam", "Pufferfish", "Ghostfish", "Sandfish", "Woodskip", "Copper Bar", "Iron Bar", "Gold Bar", "Quartz", "Earth Crystal",
        "Frozen Tear", "Fire Quartz", "Slime", "Bat Wing", "Solar Essence", "Void Essence", "Maple Syrup", "Fiddlehead Fern", "Truffle", "Poppy", "Maki Roll",
        "Fried Egg", "Red Mushroom", "Sea Urchin", "Sunflower", "Duck Feather", "Aquamarine", "Red Cabbage", "Purple Mushroom", "Nautilus Shell", "Chub",
        "Frozen Geode", "Wheat", "Hay", "Apple", "Oak Resin", "Wine", "Rabbit's Foot", "Pomegranate", "2,500g", "5,000g", "10,000g", "25,000g", "Wine(S)",
        "Dinosaur Mayonnaise", "Prismatic Shard", "Ancient Fruit(G)", "Void Slamon(G)", "Caviar"}
        Dim afile As System.IO.StreamWriter
        afile = My.Computer.FileSystem.OpenTextFileWriter(path, True)

        afile.WriteLine("Spring 1 Sunny")

        For Each item In arrItems
            afile.WriteLine(item)
        Next

        afile.Close()
        Return 1
    End Function
End Class