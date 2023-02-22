Imports System.Data.SqlClient

Public Class Add_Sales_Details
    Public Sub clear()
        txtitems.Clear()
        txtquantity.Clear()
        txtprice.Clear()
        txtcustomerid.Clear()
    End Sub
    Public Sub getquantitys(ByVal a As Integer)
        Dim cmd As New SqlCommand
        cmd.CommandText = "select Quantity as qty, Productname as p from product_add where Productid=" + a.ToString
        cmd.Connection = dbconnection.getServerconnection()
        Using rdrs As SqlDataReader = cmd.ExecuteReader()
            rdrs.Read()
            qty.Text = rdrs("qty").ToString
            txtitems.Text = rdrs("p").ToString
            rdrs.Close()
        End Using
    End Sub
    Public Sub updatesalesp()
        Dim cmd As New SqlCommand()
        cmd.Connection = dbconnection.getServerconnection()
        Dim tq As String
        Dim sqlstring1 As String
        If Val(qty.Text) < Val(txtquantity.Text) Then
            MsgBox("sales quantity should not be greater than product quantity")
        Else
            tq = Val(qty.Text) - Val(txtquantity.Text)
            sqlstring1 = "update product_add set Quantity='" & tq & "' where Productid= '" & Convert.ToInt32(cboproductid.Text) & "'"
            cmd.CommandText = sqlstring1
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        Try
            If (txtcustomerid.Text = "" Or txtitems.Text = "" Or txtprice.Text = "" Or txtquantity.Text = "" Or cbocustomername.Text = "" Or cbobrand.Text = "") Then
                MsgBox(" All information is mandetory to fill.")
            ElseIf IsNumeric(txtprice.Text) = False Then
                MsgBox(" Only numbers are accepted on price")
                txtprice.Text = ""
            ElseIf IsNumeric(txtquantity.Text) = False Then
                MsgBox(" Only numbers are accepted on quantity")

            Else
                Dim sqlcmd As New SqlCommand()
                sqlcmd.Connection = dbconnection.getServerconnection()
                Dim sqlstring As String
                If txtsalesid.Text = "" Then
                    sqlstring = "insert into Sales(Cid,Items,Dateofsales,sBrand,sQuantity,sPrice)
values('" & txtcustomerid.Text & "','" & txtitems.Text & "','" & Dateofsale.Value & "','" & cbobrand.Text & "','" & txtquantity.Text & "','" & txtprice.Text & "')"
                    updatesalesp()
                Else
                    sqlstring = "update sales set  Cid=('" & Me.txtcustomerid.Text & "'),Items=('" & Me.txtitems.Text & "'),Dateofsales=('" & Me.Dateofsale.Value & "'),sBrand=('" & Me.cbobrand.Text & "'),sQuantity=('" & Me.txtquantity.Text & "'),sPrice=('" & Me.txtprice.Text & "')where Salesid=" + txtsalesid.Text
                    updatesalesp()
                End If
                sqlcmd.CommandText = sqlstring
                sqlcmd.ExecuteNonQuery()
                MsgBox("success")
                clear()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Select Case MessageBox.Show("Are you sure you want to exit?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Me.Close()
        End Select
    End Sub

    Private Sub Add_Sales_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbobrand.Items.Add("Bajaj")
        cbobrand.Items.Add("Usha")
        cbobrand.Items.Add("Dell")
        cbobrand.Items.Add("Casio")
        cbobrand.Items.Add("Sony")
        cbobrand.Items.Add("HyperX")
        cbobrand.Items.Add("Daikin")
        cbobrand.Items.Add("Acer")


        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select * from customer_add"
        sqlcmd.CommandText = sqlstring
        Dim adp As SqlDataAdapter = New SqlDataAdapter(sqlcmd)
        Dim dsp As DataSet = New DataSet
        adp.Fill(dsp, "customer_add")
        cbocustomername.DataSource = dsp.Tables("customer_add")
        cbocustomername.DisplayMember = "CustomerName"
        cbocustomername.ValueMember = "Customerid"


        Dim cmd As New SqlCommand
        cmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring1 As String
        sqlstring1 = "select * from product_add"
        cmd.CommandText = sqlstring1
        Dim adpa As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dspa As DataSet = New DataSet
        adpa.Fill(dspa, "product_add")
        cboproductid.DataSource = dspa.Tables("product_add")
        cboproductid.DisplayMember = "Proudctid"
        cboproductid.ValueMember = "Productid"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocustomername.SelectedIndexChanged

    End Sub

    Private Sub txtproductid_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboproductid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboproductid.SelectedIndexChanged
        Try
            getquantitys(cboproductid.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class