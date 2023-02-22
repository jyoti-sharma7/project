Imports System.Data
Imports System.Data.SqlClient

Public Class View_Sales_Return_Details
    Public Sub fillsalesreturn()
        Dim sqlcmd As New SqlCommand()
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select Sales_Return.SalesReturnid,customer_add.CustomerName,Sales_Return.DateOfReturn,Sales_Return.rItems as Items,Sales_Return.rBrand as Brand,Sales_Return.rQuantity as Quantity,Sales_Return.rPrice as Price from Sales_Return join Sales on Sales_Return.salesid=Sales.Salesid join customer_add on Sales.cid=customer_add.Customerid"
        sqlcmd.CommandText = sqlstring
        Dim sdap As New SqlDataAdapter(sqlcmd)
        Dim dtlsales As New DataTable()
        sdap.Fill(dtlsales)
        Me.DataGridView1.DataSource = dtlsales
    End Sub
    Private Sub View_Sales_Return_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillsalesreturn()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Select Case MessageBox.Show("Are you sure you want to delete?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Dim sqlcmd As New SqlCommand
                If (IsNothing(Me.DataGridView1.SelectedRows(0))) Then
                    Return
                End If
                Dim id As Integer
                id = Integer.Parse(Me.DataGridView1.SelectedRows(0).Cells(0).Value.ToString())
                sqlcmd.Connection = dbconnection.getServerconnection()
                Dim sqlstring As String
                sqlstring = "delete from Sales_Return where SalesReturnid=" + id.ToString
                sqlcmd.CommandText = sqlstring
                sqlcmd.ExecuteNonQuery()
                MsgBox("Deleted")
                fillsalesreturn()
        End Select
    End Sub
    Public Sub loadsalereturn(ByVal salesreturnid As Integer)
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select SalesReturnid,salesid,CustomerName,DateOfReturn,rItems,rBrand,rQuantity,rPrice from Sales_Return join Sales on Sales_Return.salesid=Sales.Salesid join customer_add on Sales.Cid=customer_add.Cid where SalesReturnid=" + salesreturnid.ToString
        sqlcmd.CommandText = sqlstring
        Dim rdtl As New DataTable
        Dim adp As New SqlDataAdapter(sqlcmd)
        adp.Fill(rdtl)
        Add_Sales_Return.txtsalerid.Text = rdtl.Rows(0)("SalesReturnid").ToString
        Add_Sales_Return.txtsalesid.Text = rdtl.Rows(0)("salesid").ToString
        Add_Sales_Return.cbocustomername.Text = rdtl.Rows(0)("CustomerName").ToString
        Add_Sales_Return.Dateofreturn.Text = rdtl.Rows(0)("DateOfReturn").ToString
        Add_Sales_Return.txtitems.Text = rdtl.Rows(0)("rItems").ToString
        Add_Sales_Return.cbobrand.Text = rdtl.Rows(0)("rBrand").ToString
        Add_Sales_Return.txtquantity.Text = rdtl.Rows(0)("rQuantity").ToString
        Add_Sales_Return.txtprice.Text = rdtl.Rows(0)("rPrice").ToString


    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If (IsNothing(Me.DataGridView1.SelectedRows(0))) Then
            Return
        End If
        Dim salesreturnid As Integer
        salesreturnid = Integer.Parse(Me.DataGridView1.SelectedRows(0).Cells(0).Value.ToString())
        loadsalereturn(salesreturnid)
        Add_Sales_Return.ShowDialog()
        fillsalesreturn()
    End Sub

End Class