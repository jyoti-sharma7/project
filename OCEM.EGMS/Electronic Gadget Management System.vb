Public Class Electronic_Gadget_Management_System
    Private Sub Electronic_Gadget_Management_System_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.ShowDialog()
    End Sub

    Private Sub AddProductToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddUserDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserDetailsToolStripMenuItem.Click
        User_Registration.ShowDialog()
    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManagementToolStripMenuItem.Click

    End Sub

    Private Sub ViewUserDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewUserDetailsToolStripMenuItem.Click
        User_Details.ShowDialog()
    End Sub

    Private Sub AddProductDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductDetailsToolStripMenuItem.Click
        Product_Add.ShowDialog()
    End Sub

    Private Sub ViewProductDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProductDetailsToolStripMenuItem.Click
        Product_Details.ShowDialog()
    End Sub

    Private Sub AddCustomerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCustomerDetailsToolStripMenuItem.Click
        Add_Customer_Details.ShowDialog()
    End Sub

    Private Sub ViewCustomerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCustomerDetailsToolStripMenuItem.Click
        View_Customer_Details.ShowDialog()
    End Sub

    Private Sub AddPurchaseDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPurchaseDetailsToolStripMenuItem.Click
        Add_Purchase_Details.ShowDialog()
    End Sub

    Private Sub ViewPurchaseDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPurchaseDetailsToolStripMenuItem.Click
        View_Purchase_Details.ShowDialog()
    End Sub

    Private Sub AddPurchaseReturnDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPurchaseReturnDetailsToolStripMenuItem.Click
        Add_Purchase_Return.ShowDialog()

    End Sub

    Private Sub ViewPurchaseReturnDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPurchaseReturnDetailsToolStripMenuItem.Click
        View_Purchase_Return_Details.ShowDialog()
    End Sub

    Private Sub AddSalesDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSalesDetailsToolStripMenuItem.Click
        Add_Sales_Details.ShowDialog()
    End Sub

    Private Sub ViewSalesDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSalesDetailsToolStripMenuItem.Click
        View_Sales_Details.ShowDialog()
    End Sub

    Private Sub AddSalesReturnDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSalesReturnDToolStripMenuItem.Click
        Add_Sales_Return.ShowDialog()
    End Sub

    Private Sub ViewSalesReturnDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSalesReturnDetailsToolStripMenuItem.Click
        View_Sales_Return_Details.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Select Case MessageBox.Show("Are you sure you want to exit?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case DialogResult.Yes
                Me.Close()

        End Select
    End Sub
End Class