Imports System.Data.SQLite
Imports System.Security.Principal

Public Structure ItemTempDetails
    Dim InventoryID_RAM As String
    Dim ProductName_RAM As String
    Dim Category_RAM As String
    Dim Description_RAM As String
    Dim Amount_RAM As Integer
End Structure

Public Class Store
    Public Shared adminAccount As AccountDetails
    Public Shared userAccount As AccountDetails
    Public Shared loggedInAccount As String
    Public Shared loggedInName As String
    Public Sub ReloadAccountDetails()

        Dim DataBase_Path As String = "Data Source=" & Application.StartupPath & "\IntegratedDataBase.db;"
        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)
        Dim adminRowQuery As String = "select * from AccountData WHERE Num = '1';"
        Dim userRowQuery As String = "select * from AccountData WHERE Num = '2';"

        Try
            DataBaseConnection.Open()

        Catch ex As Exception
            DataBaseConnection.Close()
            DataBaseConnection.Dispose()
            MsgBox(ex.Message)
        End Try

        'retrieving the admin account details from database to specific structure
        Dim adminCMD = New SQLiteCommand(adminRowQuery, DataBaseConnection)
        Dim adminReader As SQLiteDataReader = adminCMD.ExecuteReader()

        adminReader.Read()
        adminAccount.index = adminReader("Num").ToString()
        adminAccount.username = adminReader("Username").ToString()
        adminAccount.password = adminReader("Password").ToString()
        adminAccount.recoveryQuest = adminReader("RecoveryQuest").ToString()
        adminAccount.recoveryAns = adminReader("RecoveryAns").ToString()
        adminAccount.recoveryClue = adminReader("RecoveryClue").ToString()
        adminAccount.name = adminReader("name").ToString()
        adminReader.Close()


        'retrieving the user account details from database to specific structure
        Dim userCMD = New SQLiteCommand(userRowQuery, DataBaseConnection)
        Dim userReader As SQLiteDataReader = userCMD.ExecuteReader()

        userReader.Read()
        userAccount.index = userReader("Num").ToString()
        userAccount.username = userReader("Username").ToString()
        userAccount.password = userReader("Password").ToString()
        userAccount.recoveryQuest = userReader("RecoveryQuest").ToString()
        userAccount.recoveryAns = userReader("RecoveryAns").ToString()
        userAccount.recoveryClue = userReader("RecoveryClue").ToString()
        userAccount.name = userReader("name").ToString()
        userReader.Close()
    End Sub

    Public Sub LoadDataBase(ByVal q As String, ByVal table As DataTable, ByVal connection As SQLiteConnection)
        Dim SQLiteDataAdapter As New SQLiteDataAdapter(q, connection)
        SQLiteDataAdapter.Fill(table)
        SQLiteDataAdapter.Dispose()
        SQLiteDataAdapter = Nothing
    End Sub

    Public Sub ExecuteNonQuery(ByVal query As String, ByVal connection As SQLiteConnection)
        Try
            Dim SQLiteCMD As New SQLiteCommand(query, connection)
            SQLiteCMD.ExecuteNonQuery()
            SQLiteCMD.Dispose()
            SQLiteCMD = Nothing
        Catch ex As Exception

        End Try

    End Sub

    Public Sub WriteToLog(ByVal logDescription As String)

        Dim DataBaseConnection As New SQLiteConnection("Data Source=" & Application.StartupPath & "\IntegratedDataBase.db;")
        Try
            DataBaseConnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            DataBaseConnection.Close()
            DataBaseConnection.Dispose()
        End Try
        Dim currentDateTime As DateTime = DateTime.Now
        Dim dateTimeNow As String = currentDateTime.ToString("MM/dd/yy_HH:mm:ss")
        ExecuteNonQuery("INSERT INTO LogData (DateTime, Activity) VALUES ('" & dateTimeNow & "','" & logDescription & "');", DataBaseConnection)
        DataBaseConnection.Close()
        DataBaseConnection.Dispose()

    End Sub
End Class
