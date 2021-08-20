Option Strict On
Imports System.IO.File
Public Class OpenSave
    Private arrItemListValue As Item()
    Private saveFilePath As String
    Private gameDayValue As String
    Private gameSeasonValue As String
    Private gameWeatherValue As String

    Public Property gameSeason() As String
        Get
            Return gameSeasonValue
        End Get
        Set(value As String)
            gameSeasonValue = value
        End Set
    End Property
    Public Property gameWeather() As String
        Get
            Return gameWeatherValue
        End Get
        Set(value As String)
            gameWeatherValue = value
        End Set
    End Property
    Public Property gameDay() As String
        Get
            Return gameDayValue
        End Get
        Set(value As String)
            gameDayValue = value
        End Set
    End Property
    Public Property arrItemList() As Item()
        Get
            Return arrItemListValue
        End Get
        Set(value() As Item)
            arrItemListValue = value
        End Set
    End Property

    Public Property saveName As String
        Get
            Return saveFilePath
        End Get
        Set(value As String)
            saveFilePath = value
        End Set
    End Property

    ' Constructor
    Public Sub New(ByVal path As String)
        saveFilePath = path
        populateItemList(path)

    End Sub

    Private Function populateItemList(path As String) As Integer
        Dim intNumItems As Integer = IO.File.ReadAllLines(path).Length + 1
        Dim objReader As New System.IO.StreamReader(path)
        Dim intItterationCount As Integer = 0
        Dim arrItemListValue(intNumItems) As Item
        Dim gameDate() As String = Split(objReader.ReadLine())

        gameSeason = gameDate(0)
        gameDay = gameDate(1)
        gameWeather = gameDate(2)

        Do While objReader.Peek() <> -1

            arrItemListValue(intItterationCount) = New Item(objReader.ReadLine())
            intItterationCount += 1

        Loop
        arrItemList = arrItemListValue
        objReader.Close()

        Return 1
    End Function




End Class
