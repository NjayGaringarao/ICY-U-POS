Imports System.Data.SQLite
Imports System.IO
Imports System.Xml


Public Class BackupFrm


    Dim store As New Store
    Private DataBase_Path As String = "Data Source=" & Application.StartupPath & "\IntegratedDataBase.db;"

    Private Sub BackupFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MergeRadBtn.Checked = True
        TxtTypeRadBtn.Checked = True

    End Sub

    '/////// IMPORT ////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportBtn.Click
        ImportFromXmlFile()
    End Sub

    Private Sub ImportFromXmlFile()
        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)

        Try
            DataBaseConnection.Open()
        Catch ex As Exception
            MessageBox.Show($"Error connecting to the database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DataBaseConnection.Dispose()
            DataBaseConnection.Close()
            Return
        End Try

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "XML Files (*.xml)|*.xml"
        openFileDialog.Title = "Open XML File"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim xmlDocument As New XmlDocument()
            xmlDocument.Load(openFileDialog.FileName)

            Dim insertNodes As XmlNodeList = xmlDocument.SelectNodes("/Transactions/Transaction")

            Using cmd As New SQLiteCommand("", DataBaseConnection)
                For Each node As XmlNode In insertNodes
                    Try
                        Dim insertCommand As String = $"INSERT INTO TransactionData (TransID, PandanAmount, MelonAmount, UbeAmount, ChocoAmount, TransactionTotal, Status) VALUES ('{node.SelectSingleNode("TransID").InnerText}', '{node.SelectSingleNode("PandanAmount").InnerText}', '{node.SelectSingleNode("MelonAmount").InnerText}', '{node.SelectSingleNode("UbeAmount").InnerText}', '{node.SelectSingleNode("ChocoAmount").InnerText}', '{node.SelectSingleNode("TransactionTotal").InnerText}', '{node.SelectSingleNode("Status").InnerText}');"
                        cmd.CommandText = insertCommand
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show($"Error importing data: {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Next

                MessageBox.Show("Data imported successfully!", "Import Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                store.WriteToLog(Store.loggedInAccount & " : Adds an item/s in the Database")
            End Using
        End If

        DataBaseConnection.Close()
        DataBaseConnection.Dispose()
    End Sub







    '//////////////////////////////////////////////////////////////////////////////////////////////// IMPORT ///////

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        If TxtTypeRadBtn.Checked = True Then
            ExportTxtFile()

        ElseIf TxtimpRadBtn.Checked = True Then
            ExportXmlFile()
        Else
            MsgBox("Sorry, PDF Export is not supported yet. Please wait for another release", vbInformation, "Apologies")
        End If
    End Sub



    Private Sub ExportToPDF()
        'Dim saveFileDialog As New SaveFileDialog()
        'saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        'saveFileDialog.Title = "Save PDF File"
        'saveFileDialog.FileName = "ExportedData.pdf"

        'If saveFileDialog.ShowDialog() = DialogResult.OK Then
        '    Dim DataBaseConnection = New SQLiteConnection(DataBase_Path)
        '    DataBaseConnection.Open()

        '    Dim selectCommand As New SQLiteCommand("SELECT * FROM ProductData", DataBaseConnection)
        '    Dim dataReader As SQLiteDataReader = selectCommand.ExecuteReader()

        '    If dataReader.HasRows Then
        '        Dim pdfDocument As New PdfDocument()
        '        Dim page As PdfPageBase = pdfDocument.Pages.Add()

        '        Dim pdfTable As New PdfTable()
        '        pdfTable.Style.CellPadding = 2
        '        pdfTable.Style.HeaderSource = PdfHeaderSource.ColumnCaptions
        '        pdfTable.Style.HeaderStyle.BackgroundBrush = PdfBrushes.LightGray
        '        pdfTable.Style.HeaderStyle.TextBrush = PdfBrushes.Black
        '        pdfTable.Style.DefaultStyle.BackgroundBrush = PdfBrushes.White
        '        pdfTable.Style.DefaultStyle.TextBrush = PdfBrushes.Black

        '        pdfTable.DataSource = dataReader

        '        For i As Integer = 0 To dataReader.FieldCount - 1
        '            Dim column As New PdfColumn(dataReader.GetName(i))
        '            pdfTable.Columns.Add(column)
        '        Next

        '        pdfTable.Draw(page, New PointF(10, 10))

        '        pdfDocument.SaveToFile(saveFileDialog.FileName)
        '        pdfDocument.Close()

        '        dataReader.Close()
        '        DataBaseConnection.Close()

        '        MessageBox.Show("Data exported successfully to PDF!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Else
        '        MessageBox.Show("No data found to export!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'End If
    End Sub




    Private Sub ExportXmlFile()
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "XML Files (*.xml)|*.xml"
        saveFileDialog.Title = "Save XML File"
        saveFileDialog.FileName = "ExportedData.xml"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Using xmlWriter As XmlWriter = XmlWriter.Create(saveFileDialog.FileName)
                xmlWriter.WriteStartDocument()
                xmlWriter.WriteStartElement("Transactions") ' Use "Transactions" instead of "Transaction" as the root element

                Try
                    Using DataBaseConnection As New SQLiteConnection(DataBase_Path)
                        DataBaseConnection.Open()

                        Dim selectCommand As New SQLiteCommand("SELECT * FROM TransactionData", DataBaseConnection)
                        Dim dataReader As SQLiteDataReader = selectCommand.ExecuteReader()

                        While dataReader.Read()
                            xmlWriter.WriteStartElement("Transaction")
                            xmlWriter.WriteElementString("TransID", dataReader("TransID").ToString())
                            xmlWriter.WriteElementString("PandanAmount", dataReader("PandanAmount").ToString())
                            xmlWriter.WriteElementString("MelonAmount", dataReader("MelonAmount").ToString())
                            xmlWriter.WriteElementString("UbeAmount", dataReader("UbeAmount").ToString())
                            xmlWriter.WriteElementString("ChocoAmount", dataReader("ChocoAmount").ToString())
                            xmlWriter.WriteElementString("TransactionTotal", dataReader("TransactionTotal").ToString())
                            xmlWriter.WriteElementString("Status", dataReader("Status").ToString())
                            xmlWriter.WriteEndElement()
                        End While

                        dataReader.Close()
                        DataBaseConnection.Close()
                    End Using

                    xmlWriter.WriteEndElement()
                    xmlWriter.WriteEndDocument()
                Catch ex As Exception
                    MessageBox.Show($"Error exporting data: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using

            MessageBox.Show("Data exported successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            store.WriteToLog(Store.loggedInAccount & " : Exports importable XML file from the data in the database.")
        End If
    End Sub


    Private Sub ExportTxtFile()
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt"
        saveFileDialog.Title = "Save Text File"
        saveFileDialog.FileName = "ExportedData.txt"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Using DataBaseConnection As New SQLiteConnection(DataBase_Path)
                    DataBaseConnection.Open()

                    Dim selectCommand As New SQLiteCommand("SELECT * FROM TransactionData", DataBaseConnection)
                    Dim dataReader As SQLiteDataReader = selectCommand.ExecuteReader()

                    Using writer As New StreamWriter(saveFileDialog.FileName)
                        ' Write header with column names
                        For i As Integer = 0 To dataReader.FieldCount - 1
                            writer.Write(dataReader.GetName(i))
                            If i < dataReader.FieldCount - 1 Then writer.Write(vbTab)
                        Next
                        writer.WriteLine()

                        ' Write data rows
                        While dataReader.Read()
                            For i As Integer = 0 To dataReader.FieldCount - 1
                                writer.Write(dataReader(i).ToString())
                                If i < dataReader.FieldCount - 1 Then writer.Write(vbTab)
                            Next
                            writer.WriteLine()
                        End While
                    End Using

                    dataReader.Close()
                    DataBaseConnection.Close()
                End Using

                MessageBox.Show("Data exported successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                store.WriteToLog(Store.loggedInAccount & " : Exports data to a text file.")
            Catch ex As Exception
                MessageBox.Show($"Error exporting data: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



End Class