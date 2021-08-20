Option Strict On
Public Class Item

    Private itemTypeValue As String
    Private seasonsValue As String()
    Private timesValue As String()
    Private weathersValue As String()
    Private bundlesValue As String()

    Public Property itemType() As String
        Get
            Return itemTypeValue
        End Get
        Set(value As String)
            itemTypeValue = value
        End Set
    End Property

    Public Property seasons() As String()
        Get
            Return seasonsValue
        End Get
        Set(value As String())
            seasonsValue = value
        End Set
    End Property

    Public Property times() As String()
        Get
            Return timesValue
        End Get
        Set(value As String())
            timesValue = value
        End Set
    End Property

    Public Property weathers() As String()
        Get
            Return weathersValue
        End Get
        Set(value As String())
            weathersValue = value
        End Set
    End Property

    ' Constructor
    Public Sub New(ByVal item As String)

        itemTypeValue = item

        setSeasons(item)
        setTimes(item)
        setWeathers(item)

    End Sub

    Private Sub setWeathers(item As String)
        Select Case item
            Case "Sunfish"
                weathersValue = {"Sunny", "Raining"}
            Case "Catfish"
                weathersValue = {"Raining"}
            Case "Shad"
                weathersValue = {"Raining"}
            Case "Red Snapper"
                weathersValue = {"Raining"}
            Case "Walleye"
                weathersValue = {"Raining"}
            Case "Eel"
                weathersValue = {"Raining"}
            Case "Pufferfish"
                weathersValue = {"Sunny"}
            Case Else
                weathersValue = {"Any"}
        End Select


    End Sub

    Private Sub setSeasons(item As String)
        Select Case item

            Case "Wild Horseradish"
                seasonsValue = {"Spring"}
            Case "Daffodil"
                seasonsValue = {"Spring"}
            Case "Leek"
                seasonsValue = {"Spring"}
            Case "Dandelion"
                seasonsValue = {"Spring"}
            Case "Grape"
                seasonsValue = {"Summer", "Fall"}
            Case "Spice Berry"
                seasonsValue = {"Summer"}
            Case "Sweet Pea"
                seasonsValue = {"Summer"}
            Case "Common Mushroom"
                seasonsValue = {"Spring", "Fall"}
            Case "Wild Plum"
                seasonsValue = {"Fall"}
            Case "Hazelnut"
                seasonsValue = {"Fall"}
            Case "Blackberry"
                seasonsValue = {"Fall"}
            Case "Winter Root"
                seasonsValue = {"Winter"}
            Case "Crystal Fruit"
                seasonsValue = {"Winter"}
            Case "Snow Yam"
                seasonsValue = {"Winter"}
            Case "Crocus"
                seasonsValue = {"Winter"}
            Case "Red Mushroom"
                seasonsValue = {"Summer"}
            Case "Morel"
                seasonsValue = {"Spring"}
            Case "Parsnip"
                seasonsValue = {"Spring"}
            Case "Green Bean"
                seasonsValue = {"Spring"}
            Case "Cauliflower"
                seasonsValue = {"Spring"}
            Case "Potato"
                seasonsValue = {"Spring"}
            Case "Corn"
                seasonsValue = {"Fall", "Summer"}
            Case "Eggplant"
                seasonsValue = {"Fall"}
            Case "Pumpkin"
                seasonsValue = {"Fall"}
            Case "Yam"
                seasonsValue = {"Fall"}
            Case "Corn(G)"
                seasonsValue = {"Summer", "Fall"}
            Case "Melon(G)"
                seasonsValue = {"Summer"}
            Case "Pumpkin(G)"
                seasonsValue = {"Fall"}
            Case "Parsnip(G)"
                seasonsValue = {"Spring"}
            Case "tomato"
                seasonsValue = {"Summer"}
            Case "Melon"
                seasonsValue = {"Summer"}
            Case "Hot Pepper"
                seasonsValue = {"Summer"}
            Case "Blueberry"
                seasonsValue = {"Summer"}
            Case "Honey"
                seasonsValue = {"Spring", "Summer", "Fall"}
            Case "Apple"
                seasonsValue = {"Fall"}
            Case "Apricot"
                seasonsValue = {"Spring"}
            Case "Orange"
                seasonsValue = {"Summer"}
            Case "Peach"
                seasonsValue = {"Summer"}
            Case "Pomegranate"
                seasonsValue = {"Fall"}
            Case "Cherry"
                seasonsValue = {"Spring"}
            Case "Sunfish"
                seasonsValue = {"Spring", "Summer"}
            Case "Catfish"
                seasonsValue = {"Spring", "Fall"}
            Case "Shad"
                seasonsValue = {"Spring", "Summer", "Fall"}
            Case "Tiger Trout"
                seasonsValue = {"Fall", "Winter"}
            Case "Sturgeon"
                seasonsValue = {"Summer", "Winter"}
            Case "Sardine"
                seasonsValue = {"Spring", "Fall", "Winter"}
            Case "tuna"
                seasonsValue = {"Summer", "Winter"}
            Case "Red Snapper"
                seasonsValue = {"Summer", "Fall"}
            Case "Tilapia"
                seasonsValue = {"Summer", "Fall"}
            Case "Walleye"
                seasonsValue = {"Fall"}
            Case "Eel"
                seasonsValue = {"Spring", "Fall"}
            Case "Pufferfish"
                seasonsValue = {"Summer"}
            Case "Fiddlehead Fern"
                seasonsValue = {"Summer"}
            Case "Truffle"
                seasonsValue = {"Spring", "Summer", "Fall"}
            Case "Poppy"
                seasonsValue = {"Summer"}
            Case "Sunflower"
                seasonsValue = {"Summer", "Fall"}
            Case "Red Cabbage"
                seasonsValue = {"Summer"}
            Case "Nautilus Shell"
                seasonsValue = {"Winter"}
            Case "Wheat"
                seasonsValue = {"Summer", "Fall"}
            Case "Hay"
                seasonsValue = {"Spring", "Fall", "Summer"}
            Case "Ancient Fruit(G)"
                seasonsValue = {"Spring", "Fall", "Summer"}
            Case Else
                seasonsValue = {"Any"}

        End Select

    End Sub

    Private Sub setTimes(item As String)
        Select Case item
            Case "Sunfish"
                timesValue = {"6am-7pm"}
            Case "Catfish"
                timesValue = {"6am-Midnight"}
            Case "Shad"
                timesValue = {"9am-2am"}
            Case "Tiger Trout"
                timesValue = {"6am-7pm"}
            Case "Largemouth Bass"
                timesValue = {"6am-7pm"}
            Case "Sturgeon"
                timesValue = {"6am-7pm"}
            Case "Sardine"
                timesValue = {"6am-7pm"}
            Case "Tuna"
                timesValue = {"6am-7pm"}
            Case "Red Snapper"
                timesValue = {"6am-7pm"}
            Case "Tilapia"
                timesValue = {"6am-2pm"}
            Case "Walleye"
                timesValue = {"Noon-2am"}
            Case "Bream"
                timesValue = {"6pm-2am"}
            Case "Eel"
                timesValue = {"4pm-2am"}
            Case "Pufferfish"
                timesValue = {"Noon-4pm"}
            Case "Sandfish"
                timesValue = {"6am-8pm"}
            Case Else
                timesValue = {"Any"}
        End Select
    End Sub

    Private Sub setBundles(item As String)
        Select Case item
            Case "Wild Horseradish"
                bundlesValue = {"Spring Foraging"}
            Case "Daffodil"
                bundlesValue = {"Spring Foraging"}
            Case "Leek"
                bundlesValue = {"Spring Foraging"}
            Case "Dandelion"
                bundlesValue = {"Spring Foraging"}
            Case "Spice Berry"
                bundlesValue = {"Summer Foraging"}
            Case "Sweet Pea"
                bundlesValue = {"Summer Foraging"}
            Case "Grape"
                bundlesValue = {"Summer Foraging"}
            Case "Common Mushroom"
                bundlesValue = {"Fall Foraging"}
            Case "Wild Plum"
                bundlesValue = {"Fall Foraging"}
            Case "Hazelnut"
                bundlesValue = {"Fall Foraging"}
            Case "Blackberry"
                bundlesValue = {"Fall Foraging"}
            Case "Winter Root"
                bundlesValue = {"Winter Foraging"}
            Case "Crystal Fruit"
                bundlesValue = {"Winter Foraging"}
            Case "Snow Yam"
                bundlesValue = {"Winter Foraging"}
            Case "Crocus"
                bundlesValue = {"Winter Foraging"}
            Case "Wood"
                bundlesValue = {"Construction"}
            Case "Stone"
                bundlesValue = {"Construction"}
            Case "Hardwood"
                bundlesValue = {"Construction"}
            Case "Coconut"
                bundlesValue = {"Exotic Foraging"}
            Case "Cactus Fruit"
                bundlesValue = {"Exotic Foraging"}
            Case "Cave Carrot"
                bundlesValue = {"Exotic Foraging"}
            Case "Red Mushroom"
                bundlesValue = {"Exotic Foraging", "Dye"}
            Case "Purple Mushroom"
                bundlesValue = {"Exotic Foraging", "Field Research"}
            Case "Maple Syrup"
                bundlesValue = {"Exotic Foraging", "Chef's"}
            Case "Oak Resin"
                bundlesValue = {"Exotic Foraging", "Enchanter's"}
            Case "Pine Tar"
                bundlesValue = {"Exotic Foraging"}
            Case "Morel"
                bundlesValue = {"Exotic Foraging"}
            Case "Parsnip"
                bundlesValue = {"Spring Crops"}
            Case "Green Bean"
                bundlesValue = {"Spring Crops"}
            Case "Cauliflower"
                bundlesValue = {"Spring Crops"}
            Case "Potato"
                bundlesValue = {"Spring Crops"}
            Case "Corn"
                bundlesValue = {"Fall Crops"}
            Case "Eggplant"
                bundlesValue = {"Fall Crops"}
            Case "Pumpkin"
                bundlesValue = {"Fall Crops"}
            Case "Yam"
                bundlesValue = {"Fall Crops"}
            Case "Corn(G)"
                bundlesValue = {"Quality Crops"}
            Case "Melon(G)"
                bundlesValue = {"Quality Crops"}
            Case "Pumpkin(G)"
                bundlesValue = {"Quality Crops"}
            Case "Parsnip(G)"
                bundlesValue = {"Quality Crops"}
            Case "tomato"
                bundlesValue = {"Summer Crops"}
            Case "Melon"
                bundlesValue = {"Summer Crops"}
            Case "Hot Pepper"
                bundlesValue = {"Summer Crops"}
            Case "Blueberry"
                bundlesValue = {"Summer Crops"}
            Case "Large Milk"
                bundlesValue = {"Animal"}
            Case "Large Egg(Brown)"
                bundlesValue = {"Animal"}
            Case "Large Egg"
                bundlesValue = {"Animal"}
            Case "Large Goat Milk"
                bundlesValue = {"Animal"}
            Case "Wool"
                bundlesValue = {"Animal"}
            Case "Duck Egg"
                bundlesValue = {"Animal"}
            Case "Truffle Oil"
                bundlesValue = {"Artisan"}
            Case "Cloth"
                bundlesValue = {"Artisan"}
            Case "Goat Cheese"
                bundlesValue = {"Artisan"}
            Case "Cheese"
                bundlesValue = {"Artisan"}
            Case "Honey"
                bundlesValue = {"Artisan"}
            Case "Jelly"
                bundlesValue = {"Artisan"}
            Case "Apple"
                bundlesValue = {"Artisan", "Fodder"}
            Case "Apricot"
                bundlesValue = {"Artisan"}
            Case "Orange"
                bundlesValue = {"Artisan"}
            Case "Peach"
                bundlesValue = {"Artisan"}
            Case "Pomegranate"
                bundlesValue = {"Artisan", "Enchanter's"}
            Case "Cherry"
                bundlesValue = {"Artisan"}
            Case "Sunfish"
                bundlesValue = {"River Fish"}
            Case "Catfish"
                bundlesValue = {"River Fish"}
            Case "Shad"
                bundlesValue = {"River Fish"}
            Case "Tiger Trout"
                bundlesValue = {"River Fish"}
            Case "Largemouth Bass"
                bundlesValue = {"Lake Fish"}
            Case "Carp"
                bundlesValue = {"Lake Fish"}
            Case "Bullhead"
                bundlesValue = {"Lake Fish"}
            Case "Sturgeon"
                bundlesValue = {"Lake Fish"}
            Case "Sardine"
                bundlesValue = {"Ocean Fish"}
            Case "tuna"
                bundlesValue = {"Ocean Fish"}
            Case "Red Snapper"
                bundlesValue = {"Ocean Fish"}
            Case "Tilapia"
                bundlesValue = {"Ocean Fish"}
            Case "Walleye"
                bundlesValue = {"Night Fish"}
            Case "Bream"
                bundlesValue = {"Night Fish"}
            Case "Eel"
                bundlesValue = {"Night Fish"}
            Case "Lobster"
                bundlesValue = {"Crab Pot"}
            Case "Crayfish"
                bundlesValue = {"Crab Pot"}
            Case "Crab"
                bundlesValue = {"Crab Pot"}
            Case "Cockle"
                bundlesValue = {"Crab Pot"}
            Case "Mussel"
                bundlesValue = {"Crab Pot"}
            Case "Shrimp"
                bundlesValue = {"Crab Pot"}
            Case "Snail"
                bundlesValue = {"Crab Pot"}
            Case "Periwinkle"
                bundlesValue = {"Crab Pot"}
            Case "Oyster"
                bundlesValue = {"Crab Pot"}
            Case "Clam"
                bundlesValue = {"Crab Pot"}
            Case "Pufferfish"
                bundlesValue = {"Specialty Fish"}
            Case "Ghostfish"
                bundlesValue = {"Specialty Fish"}
            Case "Sandfish"
                bundlesValue = {"Specialty Fish"}
            Case "Woodskip"
                bundlesValue = {"Specialty Fish"}
            Case "Copper Bar"
                bundlesValue = {"Blacksmith's"}
            Case "Iron Bar"
                bundlesValue = {"Blacksmith's"}
            Case "Gold Bar"
                bundlesValue = {"Blacksmith's"}
            Case "Quartz"
                bundlesValue = {"Geologist's"}
            Case "Earth Crystal"
                bundlesValue = {"Geologist's"}
            Case "Frozen Tear"
                bundlesValue = {"Geologist's"}
            Case "Fire Quartz"
                bundlesValue = {"Geologist's"}
            Case "Slime"
                bundlesValue = {"Adventurer's"}
            Case "Bat Wing"
                bundlesValue = {"Adventurer's"}
            Case "Solar Essence"
                bundlesValue = {"Adventurer's"}
            Case "Void Essence"
                bundlesValue = {"Adventurer's"}
            Case "Fiddlehead Fern"
                bundlesValue = {"Chef's"}
            Case "Truffle"
                bundlesValue = {"Chef's"}
            Case "Poppy"
                bundlesValue = {"Chef's"}
            Case "Maki Roll"
                bundlesValue = {"Chef's"}
            Case "Fried Egg"
                bundlesValue = {"Chef's"}
            Case "Sea Urchin"
                bundlesValue = {"Dye"}
            Case "Sunflower"
                bundlesValue = {"Dye"}
            Case "Duck Feather"
                bundlesValue = {"Dye"}
            Case "Aquamarine"
                bundlesValue = {"Dye"}
            Case "Red Cabbage"
                bundlesValue = {"Dye"}
            Case "Nautilus Shell"
                bundlesValue = {"Field Research"}
            Case "Chub"
                bundlesValue = {"Field Research"}
            Case "Frozen Geode"
                bundlesValue = {"Field Research"}
            Case "Wheat"
                bundlesValue = {"Fodder"}
            Case "Hay"
                bundlesValue = {"Fodder"}
            Case "Wine"
                bundlesValue = {"Enchanter's"}
            Case "Rabbit's Foot"
                bundlesValue = {"Enchanter's"}
            Case "2,500g"
                bundlesValue = {"2,500"}
            Case "5,000g"
                bundlesValue = {"5,000"}
            Case "10,000g"
                bundlesValue = {"10,000"}
            Case "25,000g"
                bundlesValue = {"25,000"}
            Case "Wine(S)"
                bundlesValue = {"The Missing"}
            Case "Dinosaur Mayonnaise"
                bundlesValue = {"The Missing"}
            Case "Prismatic Shard"
                bundlesValue = {"The Missing"}
            Case "Ancient Fruit(G)"
                bundlesValue = {"The Missing"}
            Case "Void Salmon(G)"
                bundlesValue = {"The Missing"}
            Case "Caviar"
                bundlesValue = {"The Missing"}
        End Select
    End Sub


    Overrides Function ToString() As String
        Dim outputString As String = itemTypeValue

        For Each item In seasonsValue
            outputString = outputString & ", " & item
        Next

        For Each item In timesValue
            outputString = outputString & ", " & item
        Next

        For Each item In weathersValue
            outputString = outputString & ", " & item
        Next

        Return outputString
    End Function

End Class
