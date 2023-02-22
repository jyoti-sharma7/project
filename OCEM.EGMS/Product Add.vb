Imports System.Data.SqlClient
Public Class Product_Add
    Public Sub clear()
        txtprice.Clear()
        txtproductname.Clear()
        txtquantity.Clear()
        TextBox1.Clear()
    End Sub
    Public Sub getproduct()

    End Sub
    Private Sub Product_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbobrand.Items.Add("Dell")
        cbobrand.Items.Add("HP")
        cbobrand.Items.Add("Bajaj")
        cbobrand.Items.Add("Usha")
        cbobrand.Items.Add("Acer")
        cbobrand.Items.Add("lenovo")
        cbobrand.Items.Add("Daikin")
        cbobrand.Items.Add("Samsung")
        cbobrand.Items.Add("Hyper X")
        cbobrand.Items.Add("Casio")
        cbobrand.Items.Add("sony")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtproductname.TextChanged

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            If (txtprice.Text = "" Or txtproductname.Text = "" Or txtquantity.Text = "" Or cbobrand.Text = "") Then
                MsgBox("All form is mandetory fo fill!")
            ElseIf IsNumeric(txtquantity.Text) = False Then
                MsgBox("only numbers are accepted on quantiy")
                txtquantity.Text = ""
            ElseIf IsNumeric(txtprice.Text) = False Then
                MsgBox("only numbers are accepted on price")
            Else
                Dim sqlcmd As New SqlCommand()
                sqlcmd.Connection = dbconnection.getServerconnection()
                Dim sqlstring As String
                If TextBox1.Text = "" Then
                    sqlstring = "insert into product_add(Productname,Brand,Quantity,Price)
values('" & txtproductname.Text & "','" & cbobrand.Text & "','" & txtquantity.Text & "','" & txtprice.Text & "')"
                Else
                    sqlstring = "update product_add set Productname=('" & Me.txtproductname.Text & "') , Brand=('" & Me.cbobrand.Text & "'),Quantity=('" & Me.txtquantity.Text & "'),Price=('" & Me.txtprice.Text & "')where Productid=" + TextBox1.Text

                End If
                sqlcmd.CommandText = sqlstring
                sqlcmd.ExecuteNonQuery()
                MsgBox("success")
                clear()

            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cbobrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbobrand.SelectedIndexChanged

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Select Case MessageBox.Show("Are you sure you want to exit?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Me.Close()
        End Select
    End Sub

    Private Sub txtquantity_TextChanged(sender As Object, e As EventArgs) Handles txtquantity.TextChanged

    End Sub
End Class