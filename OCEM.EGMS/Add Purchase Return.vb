Imports System.Data.SqlClient
Public Class Add_Purchase_Return

    Public Sub clear()
        TextBox1.Clear()
        txteitems.Clear()
        txtquantity.Clear()
        txtprice.Clear()

        txtpurchasereturnid.Clear()
    End Sub

    Public Sub getquantityp(ByVal a As Integer)
        Dim sqlcmd As New SqlCommand

        sqlcmd.CommandText = "select Quantity as qty,Productname as p from product_add where Productid=" + a.ToString
        sqlcmd.Connection = dbconnection.getServerconnection()
        Using rdr As SqlDataReader = sqlcmd.ExecuteReader()
            rdr.Read()
            qty.Text = rdr("qty").ToString
            txteitems.Text = rdr("p").ToString
            rdr.Close()
        End Using
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
        If Val(qty.Text) < Val(txtquantity.Text) Then
            MsgBox("Purchase quantity should not be greater than product quantity")

        Else
            tq = Val(qty.Text) - Val(txtquantity.Text)
            sqlstring2 = "update product_add set Quantity= '" & tq & "' where Productid= '" & Convert.ToInt32(cboproductid.Text) & "' "

            cmd.CommandText = sqlstring2
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        If (txteitems.Text = "" Or txtprice.Text = "" Or txtquantity.Text = "" Or cbobrand.Text = "" Or cbosuppliername.Text = "") Then
            MsgBox("All information is mandetory to fill.")
        ElseIf IsNumeric(txtquantity.Text) = False Then
            MsgBox("only numbers are accepted on contact.")
            txtquantity.Text = ""
        ElseIf IsNumeric(txtprice.Text) = False Then
            MsgBox("Only numbers are accepted on contact.")
            txtprice.Text = ""
        Else
            Dim sqlcmd As New SqlCommand()
                sqlcmd.Connection = dbconnection.getServerconnection()
                Dim sqlstring As String
                If txtpurchasereturnid.Text = "" Then
                    sqlstring = "insert into Purchase_return(rPurchaseid,rItems,rBrand,rQuantity,rPrice)
values('" & TextBox1.Text & "','" & txteitems.Text & "','" & cbobrand.Text & "','" & txtquantity.Text & "','" & txtprice.Text & "')"
                    updateproduct()
                Else
                    sqlstring = "update Purchase_return set rPurchaseid=('" & Me.TextBox1.Text & "'),rItems=('" & Me.txteitems.Text & "'),rBrand=('" & Me.cbobrand.Text & "'),rQuantity=('" & Me.txtquantity.Text & "'),rPrice=('" & Me.txtprice.Text & "') where PurchaseReturnid=" + txtpurchasereturnid.Text
                    updateproduct()
                End If
                sqlcmd.CommandText = sqlstring
                sqlcmd.ExecuteNonQuery()
                MsgBox("success")
                clear()
            End If

    End Sub

    Private Sub Add_Purchase_Return_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbobrand.Items.Add("Bajaj")
        cbobrand.Items.Add("Usha")
        cbobrand.Items.Add("Dell")
        cbobrand.Items.Add("Lenovo")
        cbobrand.Items.Add("HP")
        cbobrand.Items.Add("Daikin")
        cbobrand.Items.Add("Sony")
        cbobrand.Items.Add("HyperX")


        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select * from purchase_add"
        sqlcmd.CommandText = sqlstring
        Dim adp As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim dsp As DataSet = New DataSet
        adp.Fill(dsp, "purchase_add")
        cbosuppliername.DataSource = dsp.Tables("purchase_add")
        cbosuppliername.DisplayMember = "SupplierName"
        cbosuppliername.ValueMember = "Purchaseid"



        Dim cmd As New SqlCommand
        cmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring1 As String
        sqlstring1 = "select * from product_add"
        cmd.CommandText = sqlstring1
        Dim adpa As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dspa As DataSet = New DataSet
        adpa.Fill(dspa, "product_add")
        cboproductid.DataSource = dspa.Tables("product_add")
        cboproductid.DisplayMember = "Productid"
        cboproductid.ValueMember = "Productid"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosuppliername.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub txteitems_TextChanged(sender As Object, e As EventArgs) Handles txteitems.TextChanged

    End Sub

    Private Sub txtproductid_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboproductid.SelectedIndexChanged
        Try
            getquantityp(cboproductid.Text)
        Catch ex As Exception
        End Try
    End Sub
End Class