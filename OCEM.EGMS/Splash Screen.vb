Public Class Splash_Screen
    Private Sub Splash_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbconnection.connectToServer() <> True Then

            MsgBox("connection failed")
        End If
    End Sub

    Private Sub Splash_Screen_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Electronic_Gadget_Management_System.Show()
        Me.Hide()

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Electronic_Gadget_Management_System.Show()
        Me.Hide()
    End Sub
End Class