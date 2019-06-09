Imports System.Data.OleDb
Imports System.IO

Module OleDb_Tools
    'Created and managed by Hussein Almawla
    'Open source @github.com
    'Copyright http://hmawla.com

    'Declare the connection string to be used later
    Private ReadOnly conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DATADIRECTORY|/DB/ProductManufacturing.accdb;"

    'Declare the connection using the connection string
    Private theCon As New OleDbConnection(conString)

    'Declare the command that will be executed as query
    Private theCommand As New OleDbCommand

    'Declare Data Adapter that will be used to get data tables from the database
    Private dbDataAdapter As New OleDbDataAdapter

    'Declare Data Set that will hold the data that is given by the Data Table
    Private dbDataTable As New DataTable

    'Used to initialize the connection at the main form load
    Public Sub InitCon()
        theCon.Open()
        System.Console.WriteLine("Connection Opened!")
    End Sub

    'This will be used with queries that has output tables like SELECT...
    'Mostly SELECT...
    '...Only SELECT :P
    Public Function ReadQueryOut(ByVal theQuery As String) As DataTable
        dbDataTable.Reset() 'Empty the Data Set in case it has any information
        theCommand.CommandText = theQuery 'Set the command text (set the query)
        theCommand.Connection = theCon 'Set the connection the will be used by the command
        dbDataAdapter.SelectCommand = theCommand 'Append the command to the data adapter and execute
        dbDataAdapter.Fill(dbDataTable) 'Fill the data from the data adapter to the data set to be readed
        dbDataAdapter.Dispose() 'Distroy the data adapter to conserve memory since it is not needed anymore
        Return dbDataTable 'Return the data set to be readed by the caller
    End Function

    'Execute a non-output query (DML,DDL)
    Public Sub ExecuteQuery(ByVal theQuery As String)
        theCommand.CommandText = theQuery 'Set the command text (set the query)
        theCommand.Connection = theCon 'Set the connection the will be used by the command
        theCommand.ExecuteNonQuery() 'Execute non SELECT query
    End Sub

    'Fills a data grid view with the given query
    Public Sub FillDGV(ByRef theDGV As DataGridView, ByVal theQuery As String)
        Dim dgvDbDataTable As New DataTable
        dgvDbDataTable = ReadQueryOut(theQuery).Copy() 'Activate the select query and fill dbDataSet with the output
        theDGV.DataSource = dgvDbDataTable 'Set the data source for the following DataGridView
    End Sub

    'Used to generate a new unique ID for any given table
    Public Function GenID(ByVal theTable As String, ByVal theColumn As String)
        dbDataTable = ReadQueryOut("SELECT MAX(" & theColumn & ") FROM " & theTable)
        If Not dbDataTable.Rows(0).Item(0).GetType.ToString().ToLower().Equals("system.dbnull") Then
            Return dbDataTable.Rows(0).Item(0) + 1
        Else
            Return 1
        End If

    End Function

    'Fills a Combobox with the given query
    Public Sub FillCBox(ByRef theCBox As ComboBox, ByVal theQuery As String, ByVal ValueMember As String, ByVal DisplayName As String)
        Dim cBoxDbDataTable As New DataTable
        theCBox.Text = ""
        cBoxDbDataTable = ReadQueryOut(theQuery).Copy() 'This is the new way to get data from the database into the Combo Box, but still has some issues, and currently declared as an issue in github
        theCBox.DataSource = cBoxDbDataTable 'lets's hope someone help fixing it.
        theCBox.ValueMember = ValueMember 'The problem is when I use this procedure the data is filled perfectly in the combo box but when I access the database using any query after that, it remove the data from the combo box
        theCBox.DisplayMember = DisplayName 'So now I have to refresh the combo box everytime using this function... Any Ideas?
    End Sub

    Public Sub FillCheckList(ByRef theCheckList As CheckedListBox, ByVal theQuery As String, ByVal ValueMember As String, ByVal DisplayName As String)
        Dim cBoxDbDataTable As New DataTable
        cBoxDbDataTable = ReadQueryOut(theQuery).Copy() 'This is the new way to get data from the database into the Combo Box, but still has some issues, and currently declared as an issue in github
        theCheckList.DataSource = cBoxDbDataTable 'lets's hope someone help fixing it.
        theCheckList.ValueMember = ValueMember 'The problem is when I use this procedure the data is filled perfectly in the combo box but when I access the database using any query after that, it remove the data from the combo box
        theCheckList.DisplayMember = DisplayName 'So now I have to refresh the combo box everytime using this function... Any Ideas?
    End Sub

    'Checks if the item exists in the database using a query
    Public Function Exists(ByVal theObj As String, ByVal theQuery As String) As Boolean
        Try
            dbDataTable = ReadQueryOut(theQuery)
        Catch ex As Exception
            Return False
        End Try

        Dim i As Integer
        For i = 0 To dbDataTable.Rows.Count - 1
            If dbDataTable.Rows(i).Item(0).ToString.Equals(theObj.ToString) Then
                Return True
            End If
        Next
        Return False

    End Function

    'Used to check textboxes for characters other than numbers
    Public Sub Only_Number(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    'Used to check textboxes for characters other than ASCII Characters
    Public Sub Only_char(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            MessageBox.Show("Please enter characters only")
            e.Handled = True
        End If
    End Sub

    'Toggles any control state
    Public Sub Toggle(ByRef theObj As Control)
        If theObj.Enabled Then
            theObj.Enabled = False
            theObj.Text = ""
        Else
            theObj.Enabled = True
        End If
    End Sub

End Module
