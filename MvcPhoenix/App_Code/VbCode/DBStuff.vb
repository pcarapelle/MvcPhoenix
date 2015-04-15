Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class dbsql

    'skeleton ... 

    Private dbconn As New SqlConnection
    Private Connstring As String = CMCMisc.fnSQLConnectionString

    Public Sub New()
        'default
    End Sub
    Public Sub close()
        dbconn.Close()
    End Sub
    Public Function ExecuteReader(vSelect As String) As SqlDataReader
        'Good
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(Connstring)
        cmd = New SqlCommand(vSelect, cn)
        cn.Open()
        Return cmd.ExecuteReader(Data.CommandBehavior.CloseConnection)

        cn.Close()
    End Function

    Public Function InsertAndReturnPK(vSelect As String) As Integer
        'quick and dirty, insert a blank record and return a new PK to be used by calling code
        Dim rv As Integer
        Dim MyConn As SqlConnection = New SqlConnection()
        MyConn.ConnectionString = Connstring
        Dim MyCommand As SqlCommand = New SqlCommand
        MyCommand.Connection = MyConn
        MyCommand.CommandText = vSelect
        MyConn.Open()
        rv = MyCommand.ExecuteScalar()
        MyConn.Close()
        Return rv
    End Function

    Public Function ExecuteSQL(sql As String) As Integer
        'Push a sql statement and return the records affected
        Dim cmd As New SqlCommand
        cmd.CommandText = sql
        cmd.CommandType = Data.CommandType.Text
        cmd.Connection = dbconn
        Dim lngrecs As Integer
        cmd.Connection.Open()
        lngrecs = cmd.ExecuteNonQuery
        cmd.Connection.Close()
        Return lngrecs
    End Function
    Public Function ExecuteSQLCommand(vCommand As String) As Integer
        'dumb function to push a command to SQL server
        'Add trapping later
        Dim MyConn As SqlConnection = New SqlConnection() : MyConn.ConnectionString = Connstring
        Dim MyCommand As SqlCommand = New SqlCommand : MyCommand.Connection = MyConn

        Dim recordsAffected As Int32 = 0
        MyCommand.Connection.Open()

        MyCommand.CommandText = vCommand
        recordsAffected = MyCommand.ExecuteNonQuery()
        MyConn.Close()
        MyConn = Nothing
        Return recordsAffected

    End Function


End Class

Public Class dbmdb
    'For MDB access

End Class

'Connecting and doing SQL work
'1. Create conn object and specify which Connection to use.
'2. Create the Command object.
'3. Specify the query to execute and pass it to the Command object.
'4. Open the Connection to the sata source.
'5. Execute a query against the data source.
'6. Do something with the results.
'7. Close the connection.