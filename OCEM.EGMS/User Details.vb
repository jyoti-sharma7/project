Imports System.Data
Imports System.Data.SqlClient
Public Class User_Details
    Public Sub filldata()
        Dim sqlcmd As New SqlCommand()
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select * from user_registration"
        sqlcmd.CommandText = sqlstring
        Dim sda As New SqlDataAdapter(sqlcmd)
        Dim dtbluser As New DataTable()
        sda.Fill(dtbluser)
        Me.DataGridView1.DataSource = dtbluser
    End Sub
    Public Sub getresult(ByVal query As String)
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String
        sqlstring = "select * from user_registration where Username like '%" + TextBox1.Text + "%'"
        sqlcmd.CommandText = sqlstring
        Dim sda As New SqlDataAdapter(sqlcmd)
        Dim dataproduct As New DataTable
        sda.Fill(dataproduct)
        Me.DataGridView1.DataSource = dataproduct

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
                sqlstring = "delete from user_registration where userid=" + id.ToString
                sqlcmd.CommandText = sqlstring
                sqlcmd.ExecuteNonQuery()
                MsgBox("deleted")
                filldata()
        End Select
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub User_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldata()
    End Sub
    Public Sub loaduser(ByVal userid As Integer)
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = dbconnection.getServerconnection()
        Dim sqlstring As String = "select * from user_registration where Userid=" + userid.ToString
        sqlcmd.CommandText = sqlstring
        Dim utable As New DataTable
        Dim sdap As New SqlDataAdapter(sqlcmd)
        sdap.Fill(utable)
        User_Registration.txtuserid.Text = utable.Rows(0)("Userid").ToString
        User_Registration.txtfullname.Text = utable.Rows(0)("Fullname").ToString
        User_Registration.txtusername.Text = utable.Rows(0)("Username").ToString
        User_Registration.txtpassword.Text = utable.Rows(0)("Password").ToString
        User_Registration.txtcontact.Text = utable.Rows(0)("Contact").ToString
        User_Registration.txtaddress.Text = utable.Rows(0)("Address").ToString
        User_Registration.txtemail.Text = utable.Rows(0)("Email").ToString
        User_Registration.cbogender.Text = utable.Rows(0)("Gender").ToString
        User_Registration.txtage.Text = utable.Rows(0)("Age").ToString
    End Sub
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If (IsNothing(Me.DataGridView1.SelectedRows(0))) Then
            Return
        End If
        Dim userid As Integer
        userid = Integer.Parse(Me.DataGridView1.SelectedRows(0).Cells(0).Value.ToString)
        loaduser(userid)
        User_Registration.ShowDialog()
        filldata()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        getresult(TextBox1.Text)
    End Sub
End Class