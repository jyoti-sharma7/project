Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class dbconnection
    Private Shared dbCon As New SqlConnection
    Public Shared Function connectToServer() As Boolean
        Dim con As String
        con = ConfigurationManager.ConnectionStrings("Edbconnection").ConnectionString
        Try
            dbCon.ConnectionString = con
            dbCon.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function getServerconnection()


        Return dbCon
    End Function
End Class
