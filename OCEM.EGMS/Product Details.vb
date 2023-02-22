Imports System.Data
Imports System.Data.SqlClient

Public Class Product_Details
    Public Sub fillProductData()
        Dim sqlcmd As New SqlCommand()
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select * from product_add"
        sqlcmd.CommandText = sqlstring
        Dim sdap As New SqlDataAdapter(sqlcmd)
        Dim dtblproduct As New DataTable()
        sdap.Fill(dtblproduct)
        Me.DataGridView1.DataSource = dtblproduct
    End Sub
    Public Sub getproductResult(ByVal query As String)
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select * from product_add where Brand  like '%" + TextBox1.Text + "%'"
        sqlcmd.CommandText = sqlstring
        Dim sda As New SqlDataAdapter(sqlcmd)
        Dim dataproduct As New DataTable
        sda.Fill(dataproduct)
        Me.DataGridView1.DataSource = dataproduct
    End Sub

    Private Sub Product_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        fillProductData()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            If TextBox1.Text = "" Then
                MsgBox("Empty textbox !")
            Else
                getproductResult(TextBox1.Text)
            End If
        Catch ex As Exception
        End Try
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
                sqlstring = "delete from product_add where Productid=" + id.ToString
                sqlcmd.CommandText = sqlstring
                sqlcmd.ExecuteNonQuery()
                MsgBox("deleted")
                fillProductData()
        End Select
    End Sub
    Public Sub loadproduct(ByVal productid As Integer)
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String = "select * from Product_add where Productid=" + productid.ToString
        sqlcmd.CommandText = sqlstring
        Dim dtable As New DataTable
        Dim adp As New SqlDataAdapter(sqlcmd)
        adp.Fill(dtable)
        Product_Add.TextBox1.Text = dtable.Rows(0)("Productid").ToString
        Product_Add.txtproductname.Text = dtable.Rows(0)("Productname").ToString
        Product_Add.cbobrand.Text = dtable.Rows(0)("Brand").ToString
        Product_Add.txtquantity.Text = dtable.Rows(0)("Quantity").ToString
        Product_Add.txtprice.Text = dtable.Rows(0)("Price").ToString
    End Sub
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If (IsNothing(Me.DataGridView1.SelectedRows(0))) Then
            Return
        End If
        Dim productid As Integer
        productid = Integer.Parse(Me.DataGridView1.SelectedRows(0).Cells(0).Value.ToString)
        loadproduct(productid)
        Product_Add.ShowDialog()
        fillProductData()
    End Sub
End Class