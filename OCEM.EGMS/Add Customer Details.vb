Imports System.Data.SqlClient

Public Class Add_Customer_Details
    Public Sub clear()
        txtaddress.Clear()
        txtcustomername.Clear()
        txtphonenumber.Clear()
    End Sub


    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            If txtcustomername.Text = "" Or txtaddress.Text = "" Or txtphonenumber.Text = "" Then
                MsgBox("All information is mandetory to fill.")
            ElseIf txtphonenumber.TextLength < 10 Then
                MsgBox("Must be up to 10 digits on contact.")
            ElseIf txtphonenumber.TextLength > 10 Then
                MsgBox("Only 10 digits are allowed on contact")
            ElseIf IsNumeric(txtphonenumber.Text) = False Then
                MsgBox("Only numbers are accepted on contact")
            Else
                Dim sqlcmd As New SqlCommand()
                sqlcmd.Connection = dbconnection.getServerconnection()
                Dim sqlstring As String
                If txtcustomerid.Text = "" Then
                    sqlstring = "insert into customer_add(Customername,Address,Phone) 
values('" & txtcustomername.Text & "','" & txtaddress.Text & "','" & txtphonenumber.Text & "')"
                Else
                    sqlstring = "update customer_add set Customername=('" & Me.txtcustomername.Text & "'),Address=('" & Me.txtaddress.Text & "'),Phone=('" & Me.txtphonenumber.Text & "') where Customerid=" + txtcustomerid.Text
                End If
                sqlcmd.CommandText = sqlstring
                sqlcmd.ExecuteNonQuery()
                MsgBox("success")
                clear()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Select Case MessageBox.Show("Are you sure you want to exit?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Me.Close()
        End Select
    End Sub

    Private Sub Add_Customer_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class