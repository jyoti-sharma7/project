Imports System.Data.SqlClient
Public Class User_Registration
    Public Sub clear()
        txtfullname.Clear()
        txtusername.Clear()
        txtpassword.Clear()
        txtconfimpassword.Clear()
        txtcontact.Clear()
        txtaddress.Clear()
        txtemail.Clear()
        txtage.Clear()


    End Sub

    Private Sub User_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbogender.Items.Add("Male")
        cbogender.Items.Add("Female")
        cbogender.Items.Add("Other")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        If txtpassword.Text <> txtconfimpassword.Text Then
            MsgBox("password doesnot match")

        ElseIf (txtfullname.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Or txtconfimpassword.Text = "" Or txtcontact.Text = "" Or txtaddress.Text = "" Or txtemail.Text = "" Or cbogender.Text = "" Or txtage.Text = "") Then
            MsgBox("All information is mandetory to fill")
        ElseIf IsNumeric(txtage.Text) = False Then
            MsgBox("Only numbers are accepted on age")
        ElseIf IsNumeric(txtcontact.Text) = False Then
            MsgBox("Only numbers are accepted on contact ")
            txtcontact.Text = ""
        ElseIf txtcontact.TextLength < 10 Then
            MsgBox("Must be up to 10 digits on contact")
        ElseIf txtcontact.TextLength > 10 Then
            MsgBox("Only 10 digits allowed on contact")
        Else
            Dim sqlcmd As New SqlCommand
            sqlcmd.Connection = dbconnection.getServerconnection()
            Dim sqlstring As String
            If txtuserid.Text = "" Then
                sqlstring = "insert into user_registration(Fullname,Username,Password,Contact,Address,Email,Gender,Age) 
values('" & txtfullname.Text & "','" & txtusername.Text & "','" & txtpassword.Text & "','" & txtcontact.Text & "','" & txtaddress.Text & "','" & txtemail.Text & "','" & cbogender.Text & "','" & txtage.Text & "')"
            Else
                sqlstring = "update user_registration set Fullname=('" & Me.txtfullname.Text & "'),Username=('" & Me.txtusername.Text & "'),Password=('" & Me.txtpassword.Text & "'),Contact=('" & Me.txtcontact.Text & "'),Address=('" & Me.txtaddress.Text & "'),Email=('" & Me.txtemail.Text & "'),Gender=('" & Me.cbogender.Text & "'),Age=('" & Me.txtage.Text & "')where Userid=" + txtuserid.Text

            End If
            sqlcmd.CommandText = sqlstring
            sqlcmd.ExecuteNonQuery()
                MsgBox("success")
                clear()
            End If
    End Sub

    Private Sub cbogender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbogender.SelectedIndexChanged

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Select Case MessageBox.Show("Are you sure you want to exit?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Me.Close()
        End Select
    End Sub

    Private Sub txtemail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtemail.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim letter As String = "abcdefghijklmnopqrstuvwxyz"
            Dim numbers As String = "1234567890"
            Dim symbol As String = "@."
            If Not letter.Contains(e.KeyChar.ToString.ToLower) And Not numbers.Contains(e.KeyChar.ToString.ToLower) And Not symbol.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("please enter a valid email")
                e.KeyChar = ChrW(0)
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub txtfullname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfullname.KeyPress

    End Sub

    Private Sub txtaddress_TextChanged(sender As Object, e As EventArgs) Handles txtaddress.TextChanged

    End Sub

    Private Sub txtfullname_TextChanged(sender As Object, e As EventArgs) Handles txtfullname.TextChanged

    End Sub

    Private Sub txtuserid_TextChanged(sender As Object, e As EventArgs) Handles txtuserid.TextChanged

    End Sub
End Class