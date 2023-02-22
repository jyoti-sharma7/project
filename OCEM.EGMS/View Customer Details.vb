Imports System.Data
Imports System.Data.SqlClient

Public Class View_Customer_Details
    Public Sub fillcustomerdata()
        Dim sqlcmd As New SqlCommand()
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select * from customer_add"
        sqlcmd.CommandText = sqlstring
        Dim sda As New SqlDataAdapter(sqlcmd)
        Dim dtblcustomer As New DataTable()
        sda.Fill(dtblcustomer)
        Me.DataGridView1.DataSource = dtblcustomer
    End Sub
    Public Sub getcustomerresult(ByVal query As String)
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select * from customer_add where CustomerName like '%" + TextBox1.Text + "%'"
        sqlcmd.CommandText = sqlstring
        Dim sda As New SqlDataAdapter(sqlcmd)
        Dim datacustomer As New DataTable
        sda.Fill(datacustomer)
        Me.DataGridView1.DataSource = datacustomer
    End Sub
    Private Sub View_Customer_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillcustomerdata()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            If TextBox1.Text = "" Then
                MsgBox("Empty textbox!")
            Else
                getcustomerresult(TextBox1.Text)
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
                sqlstring = "delete from customer_add where Customerid =" + id.ToString
                sqlcmd.CommandText = sqlstring
                sqlcmd.ExecuteNonQuery()
                MsgBox("deleted")
                fillcustomerdata()
        End Select
    End Sub
    Public Sub loadcustomer(ByVal customerid As Integer)
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String = "select * from customer_add where Customerid=" + customerid.ToString
        sqlcmd.CommandText = sqlstring
        Dim ctable As New DataTable
        Dim cadp As New SqlDataAdapter(sqlcmd)
        cadp.Fill(ctable)
        Add_Customer_Details.txtcustomerid.Text = ctable.Rows(0)("Customerid").ToString
        Add_Customer_Details.txtcustomername.Text = ctable.Rows(0)("CustomerName").ToString
        Add_Customer_Details.txtaddress.Text = ctable.Rows(0)("Address").ToString
        Add_Customer_Details.txtphonenumber.Text = ctable.Rows(0)("Phone").ToString

    End Sub
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If (IsNothing(Me.DataGridView1.SelectedRows(0))) Then
            Return
        End If
        Dim customerid As Integer
        customerid = Integer.Parse(Me.DataGridView1.SelectedRows(0).Cells(0).Value.ToString)
        loadcustomer(customerid)
        Add_Customer_Details.ShowDialog()
        fillcustomerdata()
    End Sub
End Class