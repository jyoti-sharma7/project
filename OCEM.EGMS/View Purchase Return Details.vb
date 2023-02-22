Imports System.Data
Imports System.Data.SqlClient
Public Class View_Purchase_Return_Details
    Public Sub fillpurchasereturn()
        Dim sqlcmd As New SqlCommand()
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select PurchaseReturnid,Purchaseid, SupplierName,rItems as Items ,rBrand as Brand, rQuantity as Quantity, rPrice as Price from purchase_add join Purchase_return on purchase_add.Purchaseid=Purchase_return.rPurchaseid"
        sqlcmd.CommandText = sqlstring
        Dim sda As New SqlDataAdapter(sqlcmd)
        Dim dtbpruchasereturn As New DataTable()
        sda.Fill(dtbpruchasereturn)
        Me.DataGridView1.DataSource = dtbpruchasereturn
    End Sub

    Private Sub View_Purchase_Return_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillpurchasereturn()
    End Sub
    Public Sub getsearchp(ByVal query As String)
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select  PurchaseReturnid ,rPurchaseid as PurchaseId,SupplierName,rItems as Items ,rBrand as Brand, rQuantity as Quantity, rPrice as Price from purchase_add join Purchase_return on purchase_add.Purchaseid=Purchase_return.rPurchaseid where SupplierName like '%" + TextBox1.Text + "%'"
        sqlcmd.CommandText = sqlstring
        Dim sdas As New SqlDataAdapter(sqlcmd)
        Dim datapurchaser As New DataTable
        sdas.Fill(datapurchaser)
        Me.DataGridView1.DataSource = datapurchaser
    End Sub
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If TextBox1.Text = "" Then
            MsgBox("Textbox is empty!")
        Else

            getsearchp(TextBox1.Text)
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
                sqlstring = "delete from Purchase_return where PurchaseReturnid=" + id.ToString
                sqlcmd.CommandText = sqlstring
                sqlcmd.ExecuteNonQuery()
                MsgBox("Deleted")
                fillpurchasereturn()
        End Select
    End Sub
    Public Sub loadreturn(ByVal returnid As Integer)
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select PurchaseReturnid,rPurchaseid , SupplierName,rItems,rBrand, rQuantity,rPrice from purchase_add join Purchase_return on purchase_add.Purchaseid=Purchase_return.rPurchaseid where PurchaseReturnid= " + returnid.ToString
        sqlcmd.CommandText = sqlstring
        Dim rtable As New DataTable
        Dim adp As New SqlDataAdapter(sqlcmd)
        adp.Fill(rtable)
        Add_Purchase_Return.txtpurchasereturnid.Text = rtable.Rows(0)("PurchaseReturnid").ToString
        Add_Purchase_Return.TextBox1.Text = rtable.Rows(0)("rPurchaseid").ToString
        Add_Purchase_Return.cbosuppliername.Text = rtable.Rows(0)("SupplierName").ToString
        Add_Purchase_Return.txteitems.Text = rtable.Rows(0)("rItems").ToString
        Add_Purchase_Return.cbobrand.Text = rtable.Rows(0)("rBrand").ToString
        Add_Purchase_Return.txtquantity.Text = rtable.Rows(0)("rQuantity").ToString
        Add_Purchase_Return.txtprice.Text = rtable.Rows(0)("rPrice").ToString

    End Sub
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If (IsNothing(Me.DataGridView1.SelectedRows(0))) Then
            Return
        End If
        Dim returnid As Integer
        returnid = Integer.Parse(Me.DataGridView1.SelectedRows(0).Cells(0).Value.ToString())
        loadreturn(returnid)
        Add_Purchase_Return.ShowDialog()
        fillpurchasereturn()
    End Sub
End Class