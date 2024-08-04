Imports System.Data.SQLite
Imports JRPS_IMS.Store
Public Class AddEditDialogueFrm


    Public tempData As ItemTempDetails
    Dim store As New Store
    Private DataBase_Path As String = "Data Source=" & Application.StartupPath & "\IntegratedDataBase.db;"
    Private TableName As String = "ProductData"
    Dim frmOperation As String
    Dim row As DataGridViewRow

    ' <FRONTEND>
    Dim isDragging As Boolean
    Dim clickOffset As Point
    Private Sub TitlePnl_MouseDown(sender As Object, e As MouseEventArgs) Handles TitlePnl.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            clickOffset = e.Location
        End If
    End Sub

    Private Sub TitlePnl_MouseMove(sender As Object, e As MouseEventArgs) Handles TitlePnl.MouseMove
        If isDragging Then
            Dim newLocation As Point = Me.PointToScreen(e.Location)
            newLocation.Offset(-clickOffset.X, -clickOffset.Y)
            Me.Location = newLocation
        End If
    End Sub

    Private Sub TitlePnl_MouseUp(sender As Object, e As MouseEventArgs) Handles TitlePnl.MouseUp
        isDragging = False
    End Sub
    ' </FRONTEND>


    Public Sub CustomShowDialog(ByVal operation As String, Optional ByVal selectedRow As DataGridViewRow = Nothing)

        If operation = "Add" Then
            frmOperation = operation
            GenerateBtn.Visible = True
            AmountTxtBox.Text = "0"
            CategoryComboBox.SelectedIndex = 0
            InventoryIDTxtBox.Text = ""
            ProductNameTxtBox.Text = ""
            TitleLbl.Text = "Adding New Item"
            DirectionLbl.Text = "Note: Do not leave the required fields with '*' Empty in order to add new item."
            ClearResetBtn.Text = "Clear"
            AddSaveBtn.Text = "Add"
            Me.ShowDialog()
        Else
            row = selectedRow
            frmOperation = operation
            GenerateBtn.Visible = False

            tempData.InventoryID_RAM = selectedRow.Cells("Column1").Value.ToString()
            tempData.ProductName_RAM = selectedRow.Cells("Column2").Value.ToString()
            tempData.Description_RAM = selectedRow.Cells("Column4").Value.ToString()
            tempData.Amount_RAM = selectedRow.Cells("Column5").Value
            tempData.Category_RAM = selectedRow.Cells("Column3").Value.ToString()

            If selectedRow.Cells("Column1").Value IsNot Nothing Then
                InventoryIDTxtBox.Text = selectedRow.Cells("Column1").Value.ToString()
            End If

            If selectedRow.Cells("Column2").Value IsNot Nothing Then
                ProductNameTxtBox.Text = selectedRow.Cells("Column2").Value.ToString()
            End If

            If selectedRow.Cells("Column4").Value IsNot Nothing Then
                DescriptionTxtBox.Text = selectedRow.Cells("Column4").Value.ToString()
            End If

            If selectedRow.Cells("Column5").Value IsNot Nothing Then
                AmountTxtBox.Text = selectedRow.Cells("Column5").Value.ToString()
            End If

            Dim categoryIndex As Integer = 0
            Select Case tempData.Category_RAM
                Case "Paper/Medium"
                    categoryIndex = 1
                Case "Printed Materials"
                    categoryIndex = 2
                Case "Essential Office Supply"
                    categoryIndex = 3
                Case "Inks and Cartridges"
                    categoryIndex = 4
                Case "Printer Maintenance"
                    categoryIndex = 5
            End Select

            CategoryComboBox.SelectedIndex = categoryIndex

            TitleLbl.Text = "Editing Existing Item"
            DirectionLbl.Text = "Note: Do not leave the required fields with '*' empty in order to save changes."
            ClearResetBtn.Text = "Reset"
            AddSaveBtn.Text = "Save"
            Me.ShowDialog()
        End If

    End Sub
    Private Sub GenerateBtn_Click(sender As Object, e As EventArgs) Handles GenerateBtn.Click
        Dim r As Random = New Random
        Dim num As Integer = (r.Next(10000, 99999))
        Dim currentDate As Date = DateTime.Now
        tempData.InventoryID_RAM = currentDate.ToString("yyyyMMddHHmmss") & Strings.Right("00000" & num.ToString(), 5)
        InventoryIDTxtBox.Text = tempData.InventoryID_RAM

        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)

        'Connecting to DataBase
        Try
            DataBaseConnection.Open()

        Catch ex As Exception
            DataBaseConnection.Close()
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Checking if the generated InventoryID Exist in DataBase

        Dim TableDB As New DataTable

        Try
            store.LoadDataBase("select InventoryID from " & TableName & " where InventoryID='" & tempData.InventoryID_RAM & "'", TableDB, DataBaseConnection)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'If there's a match, This subroutine will recurse
        If TableDB.Rows.Count > 0 Then
            GenerateBtn_Click(sender, e)
        End If

        DataBaseConnection.Close()
    End Sub



    Private Sub ClearResetBtn_Click(sender As Object, e As EventArgs) Handles ClearResetBtn.Click

        If frmOperation = "Add" Then
            frmClear()
        Else
            InventoryIDTxtBox.Text = tempData.InventoryID_RAM
            ProductNameTxtBox.Text = tempData.ProductName_RAM
            DescriptionTxtBox.Text = tempData.Description_RAM
            AmountTxtBox.Text = tempData.Amount_RAM
            Dim categoryIndex As Integer = 0
            Select Case row.Cells("Column3").Value.ToString()
                Case "Paper/Medium"
                    categoryIndex = 1
                Case "Printed Materials"
                    categoryIndex = 2
                Case "Essential Office Supply"
                    categoryIndex = 3
                Case "Inks And Cartridges"
                    categoryIndex = 4
                Case "Printer Maintenance"
                    categoryIndex = 5
            End Select
            CategoryComboBox.SelectedIndex = categoryIndex
        End If


    End Sub
    Private Sub frmClear()
        'Clears temporary data; both in front end and back end
        InventoryIDTxtBox.Text = ""
        AmountTxtBox.Text = "0"
        CategoryComboBox.SelectedIndex = 0
        ProductNameTxtBox.Text = ""
        DescriptionTxtBox.Text = ""
        tempData.InventoryID_RAM = String.Empty
        tempData.ProductName_RAM = String.Empty
        tempData.Category_RAM = String.Empty
        tempData.Description_RAM = String.Empty
        tempData.Amount_RAM = 0
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click

        MainFrm.ManageBtn.PerformClick()
        frmClear()
        Me.Hide()

    End Sub

    Private Sub AddSaveBtn_Click(sender As Object, e As EventArgs) Handles AddSaveBtn.Click
        'Check if there is a null in any of the required fields
        If String.IsNullOrEmpty(InventoryIDTxtBox.Text) Or String.IsNullOrEmpty(ProductNameTxtBox.Text) Or CategoryComboBox.SelectedIndex = 0 Or CInt(AmountTxtBox.Text) = 0 Then
            MsgBox("Fill in the required fields", vbCritical, "Input Error")
            Exit Sub
        End If

        'Converts front end data to backend data
        tempData.ProductName_RAM = ProductNameTxtBox.Text
        tempData.Category_RAM = CategoryComboBox.SelectedItem.ToString
        tempData.Amount_RAM = CInt(AmountTxtBox.Text)
        tempData.Description_RAM = DescriptionTxtBox.Text

        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)

        If frmOperation = "Add" Then

            'Connecting to DataBase
            Try
                DataBaseConnection.Open()
            Catch ex As Exception
                DataBaseConnection.Close()
                DataBaseConnection.Dispose()
                MsgBox(ex.Message)
                Exit Sub
            End Try

            'Inserting data into table in the database
            Dim insertQuery As String = "INSERT INTO ProductData (InventoryID, ProductName, Category, Description, Amount) VALUES (@InventoryID, @ProductName, @Category, @Description, @Amount);"

            Using insertCommand As New SQLiteCommand(insertQuery, DataBaseConnection)
                insertCommand.Parameters.AddWithValue("@InventoryID", tempData.InventoryID_RAM)
                insertCommand.Parameters.AddWithValue("@ProductName", tempData.ProductName_RAM)
                insertCommand.Parameters.AddWithValue("@Category", tempData.Category_RAM)
                insertCommand.Parameters.AddWithValue("@Description", tempData.Description_RAM)
                insertCommand.Parameters.AddWithValue("@Amount", tempData.Amount_RAM)
                insertCommand.ExecuteNonQuery()
            End Using
            'Closing connection to avoid conflicts
            DataBaseConnection.Close()
            DataBaseConnection.Dispose()
            ClearResetBtn.PerformClick()
            MsgBox("Item added to Database", vbInformation, "Notice")
            store.WriteToLog(Store.loggedInAccount & " : Adds an Item.")
            MainFrm.ManageBtn.PerformClick()
        Else ' "edit"
            'Connecting to DataBase
            Try
                DataBaseConnection.Open()
                Dim updateCMD As String = "UPDATE " & TableName & " SET ProductName = @ProductName, Category = @Category, Description = @Description, Amount = @Amount WHERE InventoryID = @InventoryID"
                Using command As New SQLiteCommand(updateCMD, DataBaseConnection)
                    command.Parameters.AddWithValue("@ProductName", tempData.ProductName_RAM)
                    command.Parameters.AddWithValue("@Category", tempData.Category_RAM)
                    command.Parameters.AddWithValue("@Description", tempData.Description_RAM)
                    command.Parameters.AddWithValue("@Amount", tempData.Amount_RAM)
                    command.Parameters.AddWithValue("@InventoryID", tempData.InventoryID_RAM)

                    ' Execute the query
                    command.ExecuteNonQuery()
                End Using

                MsgBox("Modification is Saved.", vbInformation)
                store.WriteToLog(Store.loggedInAccount & " : Modified an Item.")
            Catch ex As Exception
                ' Handle exceptions here
                MessageBox.Show(ex.Message)

            Finally
                ' Close connection to avoid conflicts
                If DataBaseConnection.State <> ConnectionState.Closed Then
                    DataBaseConnection.Close()
                End If

                DataBaseConnection.Dispose()
                store.WriteToLog(Store.loggedInAccount & " : Modified an Item.")
            End Try
            CloseBtn.PerformClick()
        End If

    End Sub

    Private Sub IncrementBtn_Click(sender As Object, e As EventArgs) Handles IncrementBtn.Click
        Dim i As Integer = CInt(AmountTxtBox.Text) + 1
        AmountTxtBox.Text = CStr(i)
    End Sub

    Private Sub DecrementBtn_Click(sender As Object, e As EventArgs) Handles DecrementBtn.Click
        If AmountTxtBox.Text = "0" Then
            Exit Sub
        Else
            Dim d As Integer = CInt(AmountTxtBox.Text) - 1
            AmountTxtBox.Text = CStr(d)
        End If
    End Sub

    Private Sub AmountTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AmountTxtBox.KeyPress

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MsgBox("Invalid Input! Numbers Only.", vbCritical, "Input Error")
        End If


    End Sub

End Class