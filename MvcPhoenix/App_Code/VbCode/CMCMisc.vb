Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Data.SqlClient
Imports System.Web.Mvc
'SHARED functions namespace
'
Public Class CMCMisc

    Public Shared Function fnSQLConnectionString() As String
        'Move to web.config later but leave this method
        'Return = ConfigurationManager.ConnectionStrings("CMC").ConnectionString

        'pc Win 7 dev box in FL
        Return "Data Source=.\sqlexpress;Initial Catalog=CMCSQL03;Integrated Security=True;"

        'VM in New Milford
        'Return "Data Source=192.168.0.27;Initial Catalog=CMCSQL03;Persist Security Info=True;User ID=sa;Password=xxxxxx"

    End Function
End Class
