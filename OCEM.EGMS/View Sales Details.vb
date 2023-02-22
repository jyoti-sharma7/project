Imports System.Data
Imports System.Data.SqlClient

Public Class View_Sales_Details
    Public Sub fillSales()
        Dim sqlcmd As New SqlCommand()
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select Salesid, CustomerName,Items,Dateofsales,sBrand as Brand,sQuantity as Quantity, sPrice as Price from Sales join customer_add on  sales.cid=customer_add.Customerid"
        sqlcmd.CommandText = sqlstring
        Dim sdap As New SqlDataAdapter(sqlcmd)
        Dim dtblsales As New DataTable()
        sdap.Fill(dtblsales)
        Me.DataGridView1.DataSource = dtblsales
    End Sub
    Private Sub View_Sales_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillSales()
    End Sub
    Public Sub getsearch(ByVal query As String)
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select * from Sales where Items like '%" + TextBox1.Text + "%'"
        sqlcmd.CommandText = sqlstring
        Dim sdas As New SqlDataAdapter(sqlcmd)
        Dim datasalessearch As New DataTable
        sdas.Fill(datasalessearch)
        Me.DataGridView1.DataSource = datasalessearch
    End Sub
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If TextBox1.Text = "" Then
            MsgBox("Textbox is empty!")
        Else
            getsearch(TextBox1.Text)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Select Case MessageBox.Show("Are you sure you want to delete?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Dim sqlcmd As New SqlCommand
                If (IsNothing(Me.DataGridView1.SelectedRows(0))) Then
                    Return

                End If
                Dim id As Integer
                id = Integer.Parse(Me.DataGridView1.SelectedRows(0).Cells(0).Value.ToString)
                sqlcmd.Connection = dbconnection.getServerconnection()
                Dim sqlstring As String
                sqlstring = "delete form Sales where Salesid=" + id.ToString
                sqlcmd.ExecuteNonQuery()
                MsgBox("Deleted")
                fillSales()
        End Select
    End Sub
    Public Sub loadsale(ByVal salesid As Integer)
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select Salesid,Cid,CustomerName,Items,Dateofsales,sBrand,sQuantity,sPrice from Sales join customer_add on Sales.Cid=customer_add.Customerid where Salesid=" + salesid.ToString
        sqlcmd.CommandText = sqlstring
        Dim stable As New DataTable
        Dim adp As New SqlDataAdapter(sqlcmd)
        adp.Fill(stable)
        Add_Sales_Details.txtsalesid.Text = stable.Rows(0)("Salesid").ToString
        Add_Sales_Details.txtcustomerid.Text = stable.Rows(0)("Cid").ToString
        Add_Sales_Details.cbocustomername.Text = stable.Rows(0)("CustomerName").ToString

        Add_Sales_Details.txtitems.Text = stable.Rows(0)("Items").ToString
        Add_Sales_Details.Dateofsale.Text = stable.Rows(0)("Dateofsales").ToString
        Add_Sales_Details.cbobrand.Text = stable.Rows(0)("sBrand").ToString
        Add_Sales_Details.txtquantity.Text = stable.Rows(0)("sQuantity").ToString
        Add_Sales_Details.txtprice.Text = stable.Rows(0)("sPrice").ToString
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If (IsNothing(Me.DataGridView1.SelectedRows(0))) Then
            Return

        End If
        Dim salesid As Integer
        salesid = Integer.Parse(Me.DataGridView1.SelectedRows(0).Cells(0).Value.ToString)
        loadsale(salesid)
        Add_Sales_Details.ShowDialog()
        fillSales()
    End Sub
End Class