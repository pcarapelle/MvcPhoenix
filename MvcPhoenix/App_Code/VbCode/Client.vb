Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

'Dont forget this
Imports MvcPhoenix.DataLayer    'for EF
Imports System.Web.Mvc
'Imports CMCMisc
'Imports DBStuff

' ---------------------------------------------------------------------------------------
' Client obj built from migrated tblDataSource into tblClient
' This should contain all props of a Client
' Try and keep everthing in here, including methods to initialize.. easier then a separate data layer
' If a skinnier version is needed for a View, then copy/paste this file and cleanup by NOT binding certain properties
'-----------------------------------------------------------------------------------------

'This will be a fix of EF and ADO methods until I can cleanly migrate to EF

Public Class Client
    'CMC Client object / Table maintained manually / no CRUD needed

    Public DBClient As CMCSQL03Entities2   'EF layer object to handle just the table columns
    ' Above prop not fully implemented.. how to do this and pull the table level properties from the EF table properties
    ' and still decorate the properties HERE for use with View helpers ??

    <Display(Name:="Client List")>
    Public Property ListClients As List(Of SelectListItem)

    <Display(Name:="Client Count")>
    Public Property ClientCount As Integer

    <Display(Name:="ClientID")>
    Public Property clientid As Integer

    'Might be better to convert this to a string; discuss with cd
    <Display(Name:="Global ClientID")>
    Public Property globalclientid As Integer

    <Display(Name:="Client Code")>
    Public Property clientcode As String

    <Display(Name:="Client Name")>
    Public Property clientname As String

    <Display(Name:="CMC Location")>
    Public Property cmclocation As String

    <Display(Name:="Customer Reference")>
    Public Property customerreference As String

    <Display(Name:="CMC Long Customer")>
    Public Property cmclongcustomer As String

    '** SQL table may need to be adjusted to a FIXED varchar (JET fields are memo)
    Public Property SP_Detail1 As String
    Public Property SP_Detail2 As String
    Public Property SP_Detail3 As String
    Public Property SP_Detail4 As String
    Public Property SP_Detail5 As String
    '**

    Public Property SP_RevDate As String    'keep as string
    Public Property SP_CommValue As String
    Public Property SP_COARequired As String
    Public Property SP_TDSRequired As String
    Public Property SP_MSDSLanguage As String
    Public Property SP_Freezable As String
    Public Property SP_LabelLanguage As String
    Public Property SP_Expedite As String

    '** SQL table may need to be adjusted to a FIXED varchar (JET field is memo)
    <Display(Name:="BOL Comment")>
    Public Property BOLComment As String
    '** 

    Public Sub New()
        'Call private methods to initialize
        clientid = 0

        ListClients = fnFillListClientADO()
        ClientCount = fnClientCount()

    End Sub
    Public Function tblClientByID(pk As Integer) As tblClient
        'This will return a populated tblclient object. Assumes the find method uses the table PK
        'Although this EF stuff looks cool, too many assumptions on how the model is built.
        Dim temp As tblClient
        Using mydb As CMCSQL03Entities2 = New CMCSQL03Entities2
            temp = mydb.tblClients.Find(pk)
        End Using
        Return temp
    End Function
    Public Function tblClientByLegacyID(pk As Integer) As tblClient
        Dim temp As tblClient
        Using mydb As CMCSQL03Entities2 = New CMCSQL03Entities2
            temp = (From c In mydb.tblClients Where c.LegacyID = pk Select c)
        End Using
        Return temp
    End Function
    Public Sub Save(c As Client)
        'untested / pull the DbClient(as a tblClient) out of the Client object ??
        'Dim myDB As New CMCSQL03Entities2
        'Dim myclient As New tblClient
        'myclient = myDB.tblClients
        Using db As CMCSQL03Entities2 = New CMCSQL03Entities2
            db.Entry(c).State = Data.Entity.EntityState.Modified
            db.SaveChanges()
        End Using
    End Sub
    Private Function fnClientCount() As Integer
        Dim mycount As Integer = 0
        mycount = 0
        'Dim db As New CMCSQL03Entities2
        Using db As CMCSQL03Entities2 = New CMCSQL03Entities2
            mycount = (From x In db.tblClients Select x.ClientID).Count
        End Using
        Return mycount
    End Function
    Private Function fnFillListClientsEF() As List(Of SelectListItem)
        'using EF
        Dim mylist As List(Of SelectListItem)
        Dim mylistitem As New SelectListItem
        Using db As CMCSQL03Entities2 = New CMCSQL03Entities2
            mylist = (From c In db.tblClients Order By clientname Select New SelectListItem With {.Text = c.ClientName, .Value = c.ClientID}).ToList
        End Using
        mylist.Insert(0, New SelectListItem With {.Text = "Please Select a Client", .Value = 0})
        Return mylist
    End Function
    Private Function fnFillListClientADO() As List(Of SelectListItem)
        'using ADO / why the fuss with EF?
        Dim temp As New List(Of SelectListItem)
        Dim db As New dbsql : Dim s As String
        s = "Select ClientID,ClientName from tblClient Order By ClientName"
        Dim dr As SqlDataReader = db.ExecuteReader(s)
        temp.Add(New SelectListItem With {.Text = "Please Select", .Value = 0})
        While dr.Read
            temp.Add(New SelectListItem With {.Text = dr("ClientName").ToString, .Value = dr("ClientID")})
        End While
        dr.Close() : db.close() : Return temp
    End Function
    Public Sub FillClientObjectEF(pk As Integer)
        'EF

    End Sub

    Public Sub FillClientObject(pk As Integer)
        'fill a BO for manually dealing with a client object
        'How to change this to pull EF table columns then add non-columns properties
        Dim db As New dbsql
        Dim dr As SqlDataReader = db.ExecuteReader("Select top 1 * from tblClient where ClientID=" & pk)
        If dr.HasRows Then
            dr.Read()
            clientid = dr("clientid")
            'globalclientid = IIf(IsDBNull(dr("globalclientid")), 0, dr("globalclientid"))
            globalclientid = 0
            clientcode = dr("clientcode").ToString
            clientname = dr("clientname").ToString
            cmclocation = dr("cmclocation").ToString
            customerreference = dr("customerreference")
            cmclongcustomer = dr("cmclongcustomer").ToString
            SP_Detail1 = dr("SP_Detail1").ToString
            SP_Detail2 = dr("SP_Detail2").ToString
            SP_Detail3 = dr("SP_Detail3").ToString
            SP_Detail4 = dr("SP_Detail4").ToString
            SP_Detail5 = dr("SP_Detail5").ToString
            SP_RevDate = dr("SP_RevDate").ToString
            SP_CommValue = dr("SP_CommValue").ToString
            SP_COARequired = dr("SP_COARequired").ToString
            SP_TDSRequired = dr("SP_TDSRequired").ToString
            SP_MSDSLanguage = dr("SP_MSDSLanguage").ToString
            SP_Freezable = dr("SP_Freezable").ToString
            SP_LabelLanguage = dr("SP_LabelLanguage").ToString
            SP_Expedite = dr("SP_Expedite").ToString
            BOLComment = dr("BOLComment").ToString
        Else
            clientid = 0  'calling method can check for success
            '?? Log
        End If
        db.close()
    End Sub
End Class
