Imports System.Data
Imports System.Data.SqlClient
Public Class Users
    Public Shared Function chkUser(ByVal username As String, ByVal password As String) As Boolean
        Dim sqlcmd As New SqlCommand
        sqlcmd.CommandText = String.Format("select username,password from   login_user where Username='{0}' and Password='{1}'", username, password)
        sqlcmd.Connection = dbconnection.getServerconnection
        Dim datardr As SqlDataReader = sqlcmd.ExecuteReader()
        If datardr.HasRows = True Then
            Return True
            datardr.Close()
        Else
            Return False
            datardr.Close()
        End If
    End Function
End Class
