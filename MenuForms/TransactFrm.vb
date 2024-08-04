Imports System.Data.SQLite
Imports System.Drawing.Printing
Imports System.Security.Cryptography.X509Certificates

Public Class TransactFrm
    Private WithEvents timer0 As New Timer()
    Dim store As New Store
    Dim DataBase_Path As String = "Data Source=" & Application.StartupPath & "\IntegratedDataBase.db;"
    Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)
    Dim orderStats As String
    Dim transactionID As String
    Dim dataTable As New DataTable()
    Private printReciept As New PrintDocument
    Private printDialog As New PrintDialog

    Sub Step1UI()
        Next2Btn.Enabled = False
        PrintBtn.Enabled = False
        TextBox1.Text = ""
        PendingRadioButton.Checked = True
        CashTextBox.Text = ""
        ChangeTextBox.Text = ""
        PandanTextBox.Text = "0"
        MelonTextBox.Text = "0"
        UbeTextBox.Text = "0"
        ChocoTextBox.Text = "0"
    End Sub

    Sub Step2UI()
        Next2Btn.Enabled = True
        PrintBtn.Enabled = True
    End Sub

    Private Sub UpdateDisplayTime(sender As Object, e As EventArgs) Handles timer0.Tick
        Label2.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Greet()
        Dim currentTime As DateTime = DateTime.Now
        Dim greetMode As String = ""

        If currentTime.Hour >= 6 AndAlso currentTime.Hour < 12 Then
            greetMode = "Magandang Umaga"
        ElseIf currentTime.Hour >= 12 AndAlso currentTime.Hour < 18 Then
            greetMode = "Magandang Hapon"
        Else
            greetMode = "Magandang Gabi"
        End If

        Label1.Text = greetMode & " " & Store.loggedInName
    End Sub

    Private Sub TransactFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer0.Interval = 1000
        timer0.Start()
        Greet()

        Step1UI()
        InitializeDataTable()
        AddHandler printReciept.PrintPage, AddressOf PrintDocument_PrintPage
    End Sub



    Private Sub InitializeDataTable()
        dataTable.Clear()
        dataTable.Columns.Clear()
        DataGridView1.DataSource = Nothing
        ' Define columns for the DataTable
        dataTable.Columns.Add("ID", GetType(Integer))
        dataTable.Columns.Add("Flavor", GetType(String))
        dataTable.Columns.Add("Amount", GetType(Integer))
        dataTable.Columns.Add("Price", GetType(Double))


        Dim flavors As String() = {"ICY-U Buko Pandan", "ICY-U Melon       ", "ICY-U Ube        ", "ICY-U Chocolate  "}

        For i As Integer = 0 To flavors.Length - 1
            AddTables(i + 1, flavors(i), 0, 0.00)
        Next

        DataGridView1.DataSource = dataTable
        DataGridView1.Columns("ID").Width = 20
        DataGridView1.Columns("Amount").Width = 40
        DataGridView1.Columns("Price").Width = 40
    End Sub


    Sub SaveToDatabase()

        Dim DatabaseConnection As New SQLiteConnection(DataBase_Path)

        Try
            DatabaseConnection.Open()

            store.ExecuteNonQuery("INSERT INTO TransactionData (TransID) VALUES ('" & transactionID & "')", DatabaseConnection)
            store.ExecuteNonQuery("UPDATE TransactionData SET PandanAmount = " & CInt(PandanTextBox.Text) & " WHERE TransID='" & transactionID & "'", DatabaseConnection)
            store.ExecuteNonQuery("UPDATE TransactionData SET MelonAmount = " & CInt(MelonTextBox.Text) & " WHERE TransID='" & transactionID & "'", DatabaseConnection)
            store.ExecuteNonQuery("UPDATE TransactionData SET UbeAmount = " & CInt(UbeTextBox.Text) & " WHERE TransID='" & transactionID & "'", DatabaseConnection)
            store.ExecuteNonQuery("UPDATE TransactionData SET ChocoAmount = " & CInt(ChocoTextBox.Text) & " WHERE TransID='" & transactionID & "'", DatabaseConnection)
            store.ExecuteNonQuery("UPDATE TransactionData SET TransactionTotal = " & CDec(TotalTextBox.Text) & " WHERE TransID='" & transactionID & "'", DatabaseConnection)
            store.ExecuteNonQuery("UPDATE TransactionData SET Status = '" & orderStats & "' WHERE TransID='" & transactionID & "'", DatabaseConnection)

        Catch ex As SQLiteException
            MsgBox(ex.Message)
        Finally
            DatabaseConnection.Close()
            DatabaseConnection.Dispose()

        End Try

    End Sub

    Public Sub AddTables(ByVal id As Integer, ByVal flavor As String, ByVal Qty As Integer, ByVal Price As Double)
        ' Product already added check
        For Each row As DataRow In dataTable.Rows
            If flavor = row("Flavor").ToString() Then
                dataTable.Rows.Remove(row)
                Exit For
            End If
        Next

        Dim totPrice As Double = Price * Qty
        Dim totalPriceFormatted As String = String.Format("{0:0.00}", totPrice)

        Dim newRow As DataRow = dataTable.NewRow()
        newRow("ID") = id
        newRow("Flavor") = flavor
        newRow("Amount") = Qty
        newRow("Price") = totalPriceFormatted

        dataTable.Rows.Add(newRow)

        ' Refresh DataGridView to reflect changes
        DataGridView1.Refresh()

        Cal()
    End Sub

    Public Sub Cal()

        Dim tot As Double = 0.0

        For Each row As DataRow In dataTable.Rows
            tot += Double.Parse(row("Price").ToString())
        Next

        TotalTextBox.Text = String.Format("{0:0.00}", tot)
    End Sub



    Private Sub GenerateTransactionID()
        Dim r = New Random
        Dim num = r.Next(10000, 99999)
        Dim currentDate = Date.Now
        transactionID = currentDate.ToString("yyyyMMddHHmmss") & Strings.Right("00000" & num.ToString, 5)

        If PendingRadioButton.Checked = True Then
            orderStats = "Pending Payment"
        Else
            orderStats = "Payment Complete"
        End If

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        'DataGridView1.DataSource = Nothing
        'InitializeDataTable()
        PandanTextBox.Text = "0"
        UbeTextBox.Text = "0"
        MelonTextBox.Text = "0"
        ChocoTextBox.Text = "0"
        TotalTextBox.Text = "0"
        CashTextBox.Text = ""
        ChangeTextBox.Text = ""
        TextBox1.Text = ""
        InitializeDataTable()
    End Sub

    Private Sub PendingRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PendingRadioButton.CheckedChanged
        If PendingRadioButton.Checked = True Then
            PayedRadioButton.Checked = False
        End If
    End Sub

    Private Sub PayedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PayedRadioButton.CheckedChanged
        If PayedRadioButton.Checked = True Then
            PendingRadioButton.Checked = False
        End If
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click

        If Not CashTextBox.Text = "" Then
            Try
                Dim change0 As Double = CDbl(CashTextBox.Text) - CDbl(TotalTextBox.Text)
                ChangeTextBox.Text = CStr(change0)
            Catch ex As Exception
                MsgBox("Incorrect Input. Please Try again", vbCritical, "Input Error")
                Exit Sub
            End Try

        Else
            ChangeTextBox.Text = "0"
            CashTextBox.Text = TotalTextBox.Text
        End If
        'Dec conversion
        Dim cash As Double = CDbl(CashTextBox.Text)
        CashTextBox.Text = String.Format("{0:0.00}", cash)
        Dim change As Double = CDbl(ChangeTextBox.Text)
        ChangeTextBox.Text = String.Format("{0:0.00}", change)

        GenerateTransactionID()
        SaveToDatabase()
        Step2UI()
        GenerateReciept()
        store.WriteToLog(Store.loggedInAccount & " : Creates a " & orderStats & ".")
    End Sub

    Private Sub PandanBtn_Click(sender As Object, e As EventArgs) Handles PandanBtn.Click
        Try
            Dim num As Integer = CInt(PandanTextBox.Text)
            num += 1
            PandanTextBox.Text = CStr(num)
            AddTables(1, "ICY-U Buko Pandan", num, 15.0)
            Cal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NPandanBtn_Click(sender As Object, e As EventArgs) Handles NPandanBtn.Click
        Try
            Dim num As Integer = CInt(PandanTextBox.Text)

            If Not num <= 0 Then
                num -= 1
                PandanTextBox.Text = CStr(num)
            Else
                PandanTextBox.Text = "0"
            End If

            AddTables(1, "ICY-U Buko Pandan", num, 15.0)
            Cal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MelonBtn_Click(sender As Object, e As EventArgs) Handles MelonBtn.Click
        Try
            Dim num As Integer = CInt(MelonTextBox.Text)
            num += 1
            MelonTextBox.Text = CStr(num)
            AddTables(2, "ICY-U Melon       ", num, 15.0)
            Cal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NMelonBtn_Click(sender As Object, e As EventArgs) Handles NMelonBtn.Click
        Try
            Dim num As Integer = CInt(MelonTextBox.Text)

            If Not num <= 0 Then
                num -= 1
                MelonTextBox.Text = CStr(num)
            Else
                MelonTextBox.Text = "0"
            End If

            AddTables(2, "ICY-U Melon       ", num, 15.0)
            Cal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UbeBtn_Click(sender As Object, e As EventArgs) Handles UbeBtn.Click
        Try
            Dim num As Integer = CInt(UbeTextBox.Text)
            num += 1
            UbeTextBox.Text = CStr(num)
            AddTables(3, "ICY-U Ube        ", num, 15.0)
            Cal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NUbeBtn_Click(sender As Object, e As EventArgs) Handles NUbeBtn.Click
        Try
            Dim num As Integer = CInt(UbeTextBox.Text)

            If Not num <= 0 Then
                num -= 1
                UbeTextBox.Text = CStr(num)
            Else
                UbeTextBox.Text = "0"
            End If

            AddTables(3, "ICY-U Ube        ", num, 15.0)
            Cal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ChocolateBtn_Click(sender As Object, e As EventArgs) Handles ChocolateBtn.Click
        Try
            Dim num As Integer = CInt(ChocoTextBox.Text)
            num += 1
            ChocoTextBox.Text = CStr(num)
            AddTables(4, "ICY-U Chocolate  ", num, 15.0)
            Cal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NChocolateBtn_Click(sender As Object, e As EventArgs) Handles NChocolateBtn.Click
        Try
            Dim num As Integer = CInt(ChocoTextBox.Text)

            If Not num <= 0 Then
                num -= 1
                ChocoTextBox.Text = CStr(num)
            Else
                ChocoTextBox.Text = "0"
            End If

            AddTables(4, "ICY-U Chocolate  ", num, 15.0)
            Cal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PandanTextBox_TextChanged(sender As Object, e As EventArgs) Handles PandanTextBox.LostFocus
        Try
            AddTables(1, "ICY-U Buko Pandan", CDbl(PandanTextBox.Text), 15.0)
            Cal()
        Catch ex As Exception
            MsgBox("Invalid Input in Pandan Amount", vbCritical, "Input Error")
        End Try

    End Sub

    Private Sub Next2Btn_Click(sender As Object, e As EventArgs) Handles Next2Btn.Click
        Step1UI()
        InitializeDataTable()
    End Sub

    Private Sub GenerateReciept()

        Dim todaysDate As DateTime = DateTime.Now
        Dim dateToday As String = todaysDate.ToString("MMMM dd, yyyy")
        Try
            TextBox1.Text = "            ICY-U Corporation " & vbCrLf
            TextBox1.Text += "       Consuelo Sur San Marcelino" & vbCrLf
            TextBox1.Text += "       Zambales 2207, Philippines " & vbCrLf
            TextBox1.Text += "            +6396 1968 8611 " & vbCrLf
            TextBox1.Text += "----------------------------------------" & vbCrLf
            TextBox1.Text += "  Item" & vbTab & vbTab & vbTab & "Qty" & vbTab & "Price" & vbCrLf
            TextBox1.Text += "----------------------------------------" & vbCrLf

            Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)

            ' get table Product details

            For i As Integer = 0 To dt.Rows.Count - 1
                Dim name As String = dt.Rows(i)("Flavor").ToString()
                Dim qty As String = dt.Rows(i)("Amount").ToString()
                Dim price0 As String = dt.Rows(i)("Price").ToString()
                Dim price1 = CDbl(price0)
                Dim price = String.Format("{0:0.00}", price1)

                TextBox1.Text += "  " & name & vbTab & "  " & qty & vbTab & "P " & price & vbCrLf
            Next
            TextBox1.Text += "----------------------------------------" & vbCrLf
            TextBox1.Text += "    Sub Total : " & "P " & TotalTextBox.Text & vbCrLf
            TextBox1.Text += "    Cash      : " & "P " & CashTextBox.Text & vbCrLf
            TextBox1.Text += "    Balance   : " & "P " & ChangeTextBox.Text & vbCrLf
            TextBox1.Text += "    Status    : " & orderStats & vbCrLf
            TextBox1.Text += "----------------------------------------" & vbCrLf
            TextBox1.Text += "    Trans ID  : " & transactionID & vbCrLf
            TextBox1.Text += "    Date      : " & dateToday & vbCrLf
            TextBox1.Text += "    Time      : " & Label2.Text & vbCrLf
            TextBox1.Text += "    Status    : " & orderStats & vbCrLf
            TextBox1.Text += "----------------------------------------" & vbCrLf
            TextBox1.Text += "      Thank You For Your Purchase!" & vbCrLf
            TextBox1.Text += "----------------------------------------" & vbCrLf
            TextBox1.Text += "       Software by JR GARINGARAO" & vbCrLf

        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        printDialog.Document = printReciept
        If printDialog.ShowDialog() = DialogResult.OK Then
            printReciept.Print()
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim contentToPrint As String = TextBox1.Text

        Dim font As New Font("Consolas", 10)
        Dim brush As New SolidBrush(Color.Black)

        Dim rect As New RectangleF(30, 50, 400, 600)

        e.Graphics.DrawString(contentToPrint, font, brush, rect)

        e.HasMorePages = False
    End Sub





End Class
