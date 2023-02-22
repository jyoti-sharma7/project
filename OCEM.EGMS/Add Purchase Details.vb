Imports System.Data.SqlClient

Public Class Add_Purchase_Details
    Public Sub clear()
        txtphonenumber.Clear()
        txtsuppliername.Clear()
        txtquantitys.Clear()
        txtprice.Clear()
        txtitems.Clear()

    End Sub

    Public Sub getquantity(ByVal a As Integer)
        Dim sqlcmd As New SqlCommand
        sqlcmd.CommandText = "select Quantity as qty, Productname as p from product_add where Productid=" + a.ToString
        sqlcmd.Connection = dbconnection.getServerconnection()
        Using rdr As SqlDataReader = sqlcmd.ExecuteReader()
            rdr.Read()
            qty.Text = rdr("qty").ToString
            txtitems.Text = rdr("p").ToString
            rdr.Close()
        End Using
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If txtsuppliername.Text = "" Or txtphonenumber.Text = "" Or txtprice.Text = "" Or cboproductid.Text = "" Or txtitems.Text = "" Or cbobrand.Text = "" Or txtquantitys.Text = "" Then
                MsgBox("All information are mandetory to fill.")
            ElseIf IsNumeric(txtquantitys.Text) = False Then
                MsgBox("Only numbers are accepted on quantity.")
                txtquantitys.Text = ""
            ElseIf IsNumeric(txtprice.Text) = False Then
                MsgBox("Only numbers are accepted on price ")
                txtprice.Text = ""
            ElseIf IsNumeric(txtphonenumber.Text) = False Then
                MsgBox("Only numbers are accepted on contact")
            ElseIf txtphonenumber.TextLength < 10 Then
                MsgBox("Must be up to 10 digits")
            ElseIf txtphonenumber.TextLength > 10 Then
                MsgBox("Only 10 digits are allowed on contact")
            Else
                Dim sqlcmd As New SqlCommand()
                sqlcmd.Connection = dbconnection.getServerconnection()
                Dim sqlstring As String
                If txtpurchaseid.Text = "" Then
                    sqlstring = "insert into purchase_add(SupplierName,pPhone,pItems,pBrand,pQuantity,pPrice)
values('" & txtsuppliername.Text & "','" & txtphonenumber.Text & "','" & txtitems.Text & "','" & cbobrand.Text & "','" & txtquantitys.Text & "','" & txtprice.Text & "')"
                    Dim cmd As New SqlCommand()
                    cmd.Connection = dbconnection.getServerconnection()
                    Dim tq As String
                    Dim sqlstring1 As String
                    tq = Val(qty.Text) + Val(txtquantitys.Text)

                    sqlstring1 = "update product_add set Quantity='" & tq & "' where Productid= '" & Convert.ToInt32(cboproductid.Text) & "' "

                    cmd.CommandText = sqlstring1
                    cmd.ExecuteNonQuery()
                Else
                    sqlstring = "update purchase_add Set SupplierName=('" & Me.txtsuppliername.Text & "'),pPhone=('" & Me.txtphonenumber.Text & "'),pItems=('" & Me.txtitems.Text & "'),pBrand=('" & Me.cbobrand.Text & "'),pQuantity=('" & Me.txtquantitys.Text & "'),pPrice=('" & Me.txtprice.Text & "') where Purchaseid=" + txtpurchaseid.Text

                    Dim cmd1 As New SqlCommand()
                    cmd1.Connection = dbconnection.getServerconnection()
                    Dim tq1 As String
                    Dim sqlstring2 As String
                    tq1 = Val(qty.Text) + Val(txtquantitys.Text)

                    sqlstring2 = "update product_add set Quantity='" & tq1 & "' where Productid= '" & Convert.ToInt32(cboproductid.Text) & "' "

                    cmd1.CommandText = sqlstring2
                    cmd1.ExecuteNonQuery()
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



    Private Sub Add_Purchase_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection.connectToServer()
        cbobrand.Items.Add("Dell")
        cbobrand.Items.Add("HP")
        cbobrand.Items.Add("Bajaj")
        cbobrand.Items.Add("Usha")
        cbobrand.Items.Add("Lenovo")
        cbobrand.Items.Add("Acer")
        cbobrand.Items.Add("Daikin")
        cbobrand.Items.Add("Sony")
        cbobrand.Items.Add("HyperX")
        cbobrand.Items.Add("Casio")
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = dbconnection.getServerconnection()
            Dim sqlstring As String
            sqlstring = "select * from product_add"
            cmd.CommandText = sqlstring
            Dim adp As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim spa As DataSet = New DataSet
            adp.Fill(spa, "product_add")
            cboproductid.DataSource = spa.Tables("product_add")
            cboproductid.DisplayMember = "Productid"
            cboproductid.ValueMember = "Productid"
        Catch ex As Exception
        End Try


    End Sub

    Private Sub cboelectronicitem_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Select Case MessageBox.Show("Are you sure you want to cancel?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Me.Close()
        End Select
    End Sub

    Private Sub txtproductid_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub txtproductid_TabIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboproductid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboproductid.SelectedIndexChanged
        Try
            getquantity(cboproductid.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class