Imports System.Data.SQLite

Imports System.Xml

Public Class ActivityLogFrm
    Private DataBase_Path As String = "Data Source=" & Application.StartupPath & "\IntegratedDataBase.db;"
    Private TableName As String = "LogData"
    Dim store As New Store
    Public Sub RefreshActivityLog()
        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)
        DataGridViewTable.Rows.Clear()

        'Connects to the DataBase
        Try
            DataBaseConnection.Open()

        Catch ex As Exception
            DataBaseConnection.Close()
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Makes an SQL Query
        Dim insertCMD = New SQLiteCommand("SELECT * FROM " & TableName & " ORDER BY DateTime", DataBaseConnection)
        Dim dataReader = insertCMD.ExecuteReader

        'Putting the data into the table while following the format
        While dataReader.Read
            DataGridViewTable.Rows.Add(dataReader.Item("DateTime").ToString, dataReader.Item("Activity").ToString)
        End While

        dataReader.Close()
        DataBaseConnection.Close() 'To avoid Conflicts
    End Sub

    Private Sub ActivityLogFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshActivityLog()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click

        If MsgBox("Do you really want to DELETE the data in Activity Log?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)

        Try
            DataBaseConnection.Open()
            store.ExecuteNonQuery("DELETE FROM LogData;", DataBaseConnection)
        Catch ex As Exception
            DataBaseConnection.Close()
            DataBaseConnection.Dispose()
            MsgBox(ex.Message)
        End Try


        DataBaseConnection.Close()
        DataBaseConnection.Dispose()
        RefreshActivityLog()

    End Sub

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        ' Create a DataSet to hold the data
        Dim dataSet As New DataSet()

        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)

        Try
            DataBaseConnection.Open()
        Catch ex As Exception
            DataBaseConnection.Close()
            DataBaseConnection.Dispose()
        End Try

        ' Open the database connection


        Try
            ' Execute a SQL query to fetch data from the LogData table
            Dim query As String = "SELECT DateTime, Activity FROM LogData"
            Dim dataAdapter As New SQLiteDataAdapter(query, DataBaseConnection)

            ' Fill the DataSet with the data from the query
            dataAdapter.Fill(dataSet, "LogData")

            ' Prompt the user to choose the file path to save the XML file
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Get the file path chosen by the user
                Dim filePath As String = saveFileDialog.FileName

                ' Write the data to an XML file
                WriteToXml(dataSet, filePath)

                MessageBox.Show("Export Complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            DataBaseConnection.Close()
            DataBaseConnection.Dispose()
        End Try
    End Sub

    Private Sub WriteToXml(dataSet As DataSet, filePath As String)
        ' Create an XmlTextWriter to write the XML file
        Dim xmlWriter As New XmlTextWriter(filePath, System.Text.Encoding.UTF8)

        ' Start writing the XML document
        xmlWriter.WriteStartDocument(True)
        xmlWriter.Formatting = Formatting.Indented
        xmlWriter.Indentation = 2

        ' Write the DataSet to the XML file
        dataSet.WriteXml(xmlWriter)

        ' Close the XmlTextWriter
        xmlWriter.WriteEndDocument()
        xmlWriter.Close()
    End Sub
End Class