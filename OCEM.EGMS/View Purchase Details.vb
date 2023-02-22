Imports System.Data
Imports System.Data.SqlClient

Public Class View_Purchase_Details
    Public Sub fillpurchasedata()
        Dim sqlcmd As New SqlCommand()
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select * from purchase_add"
        sqlcmd.CommandText = sqlstring
        Dim sda As New SqlDataAdapter(sqlcmd)
        Dim dtlpurchase As New DataTable()
        sda.Fill(dtlpurchase)
        Me.DataGridView1.DataSource = dtlpurchase
    End Sub
    Public Sub getsearch(ByVal query As String)
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select * from purchase_add where SupplierName like '%" + TextBox1.Text + "%'"
        sqlcmd.CommandText = sqlstring
        Dim sda As New SqlDataAdapter(sqlcmd)
        Dim datapurchase As New DataTable
        sda.Fill(datapurchase)
        Me.DataGridView1.DataSource = datapurchase
    End Sub
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            If TextBox1.Text = "" Then
                MsgBox("Textbox is empty!")

            Else

                getsearch(TextBox1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub View_Purchase_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        fillpurchasedata()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Select Case MessageBox.Show("Are you sure you wwant to delete?", "confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Dim sqlcmd As New SqlCommand
                If (IsNothing(Me.DataGridView1.SelectedRows(0))) Then
                    Return
                End If
                Dim id As Integer
                id = Integer.Parse(Me.DataGridView1.SelectedRows(0).Cells(0).Value.ToString)
                sqlcmd.Connection = dbconnection.getServerconnection()
                Dim sqlstring As String
                sqlstring = "delete from purchase_add where Purchaseid=" + id.ToString
                sqlcmd.CommandText = sqlstring
                sqlcmd.ExecuteNonQuery()
                MsgBox("deleted")
                fillpurchasedata()
        End Select
    End Sub
    Public Sub loadpurchase(ByVal purchaseid As Integer)
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String = "select * from purchase_add where Purchaseid=" + purchaseid.ToString
        sqlcmd.CommandText = sqlstring
        Dim ptable As New DataTable
        Dim adp As New SqlDataAdapter(sqlcmd)
        adp.Fill(ptable)
        Add_Purchase_Details.txtpurchaseid.Text = ptable.Rows(0)("Purchaseid").ToString
        Add_Purchase_Details.txtsuppliername.Text = ptable.Rows(0)("SupplierName").ToString
        Add_Purchase_Details.txtphonenumber.Text = ptable.Rows(0)("pPhone").ToString
        Add_Purchase_Details.txtitems.Text = ptable.Rows(0)("pItems").ToString
        Add_Purchase_Details.cbobrand.Text = ptable.Rows(0)("pBrand").ToString
        Add_Purchase_Details.txtquantitys.Text = ptable.Rows(0)("pQuantity").ToString
        Add_Purchase_Details.txtprice.Text = ptable.Rows(0)("pPrice").ToString

    End Sub
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If (IsNothing(Me.DataGridView1.SelectedRows(0))) Then
            Return
        End If
        Dim purchaseid As Integer
        purchaseid = Integer.Parse(Me.DataGridView1.SelectedRows(0).Cells(0).Value.ToString)
        loadpurchase(purchaseid)
        Add_Purchase_Details.ShowDialog()
        fillpurchasedata()
    End Sub
End Class