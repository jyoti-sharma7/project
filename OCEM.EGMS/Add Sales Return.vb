Imports System.Data.SqlClient
Public Class Add_Sales_Return
    Public Sub clear()
        txtsalerid.Clear()
        txtsalesid.Clear()
        txtitems.Clear()
        txtquantity.Clear()
        txtprice.Clear()
    End Sub
    Public Sub getquantity(ByVal a As Integer)
        Dim cmd As New SqlCommand
        cmd.CommandText = "select Quantity as qty , Productname as p from product_add where Productid=" + a.ToString
        cmd.Connection = dbconnection.getServerconnection()
        Using rdr As SqlDataReader = cmd.ExecuteReader()
            rdr.Read()
            qty.Text = rdr("qty").ToString
            txtitems.Text = rdr("p").ToString
            rdr.Close()

        End Using
    End Sub


    Private Sub Add_Sales_Return_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbobrand.Items.Add("Bajaj")
        cbobrand.Items.Add("Usha")
        cbobrand.Items.Add("Dell")
        cbobrand.Items.Add("Acer")
        cbobrand.Items.Add("Daikin")
        cbobrand.Items.Add("Samsung")
        cbobrand.Items.Add("Casio")
        cbobrand.Items.Add("Sony")


        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select * from customer_add"
        sqlcmd.CommandText = sqlstring
        Dim adp As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim ds As DataSet = New DataSet
        adp.Fill(ds, "customer_add")
        cbocustomername.DataSource = ds.Tables("customer_add")
        cbocustomername.DisplayMember = "CustomerName"
        cbocustomername.ValueMember = "Customerid"
    End Sub




    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Select Case MessageBox.Show("Are you sure you want to exit?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Me.Close()
        End Select
    End Sub
    Public Sub updateproduct()
        Dim cmd As New SqlCommand()
        cmd.Connection = dbconnection.getServerconnection()
        Dim tq As String
        Dim sqlstring2 As String
        tq = Val(qty.Text) + Val(txtquantity.Text)
        sqlstring2 = "update product_add set Quantity ='" & tq & "' where Productid= '" & Convert.ToInt32(txtproductid.Text) & "'"
        cmd.CommandText = sqlstring2
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If (txtitems.Text = "" Or txtprice.Text = "" Or txtquantity.Text = "" Or txtsalesid.Text = "" Or cbobrand.Text = "" Or cbocustomername.Text = "") Then
            MsgBox("All information is mandetory to fill.")
        ElseIf IsNumeric(txtprice.Text) = False Then
            MsgBox("Only numbers are accepted on price")
        ElseIf IsNumeric(txtquantity.Text) = False Then
            MsgBox("Only numbers are accepted on Quantity")

        Else
            Dim sqlcmd As New SqlCommand()
            sqlcmd.Connection = dbconnection.getServerconnection()
            Dim sqlstring As String
            If txtsalerid.Text = "" Then
                sqlstring = "insert into Sales_Return (salesid,DateOfReturn,rItems,rBrand,rQuantity,rPrice) 
values('" & txtsalesid.Text & "','" & Dateofreturn.Value & "','" & txtitems.Text & "','" & cbobrand.Text & "','" & txtquantity.Text & "','" & txtprice.Text & "')"
                updateproduct()
            Else
                sqlstring = "update Sales_Return set salesid=('" & Me.txtsalesid.Text & "'),DateOfReturn=('" & Me.Dateofreturn.Value & "'),rItems=('" & Me.txtitems.Text & "'),rBrand=('" & Me.cbobrand.Text & "'),rQuantity=('" & Me.txtquantity.Text & "'),rPrice=('" & Me.txtprice.Text & "')where SalesReturnid=" + txtsalerid.Text
                updateproduct()
            End If
            sqlcmd.CommandText = sqlstring
            sqlcmd.ExecuteNonQuery()
            MsgBox("success")
            clear()
        End If
    End Sub

    Private Sub txtproductid_TextChanged(sender As Object, e As EventArgs) Handles txtproductid.TextChanged
        Try
            getquantity(txtproductid.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class