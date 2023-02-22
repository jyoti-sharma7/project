Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection.connectToServer()

        Panel1.BackColor = Color.FromArgb(150, 0, 0, 0)
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If Users.chkUser(txtusername.Text, txtpassword.Text) = True Then
            Me.Close()
            Electronic_Gadget_Management_System.Show()

        Else
            MsgBox("login failed")
            Me.Show()
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Select Case MessageBox.Show("Are you sure you want to exit?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Me.Close()
                Electronic_Gadget_Management_System.Close()
        End Select
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
