<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Electronic_Gadget_Management_System
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Electronic_Gadget_Management_System))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProductDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProductDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPurchaseDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPurchaseDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPurchaseReturnDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPurchaseReturnDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSalesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSalesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSalesReturnDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSalesReturnDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUserDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserDetailsToolStripMenuItem, Me.CustomerDetailsToolStripMenuItem, Me.PurchaseToolStripMenuItem, Me.SalesToolStripMenuItem, Me.UserManagementToolStripMenuItem, Me.ToolStripMenuItem1, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(740, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserDetailsToolStripMenuItem
        '
        Me.UserDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProductDetailsToolStripMenuItem, Me.ViewProductDetailsToolStripMenuItem})
        Me.UserDetailsToolStripMenuItem.Name = "UserDetailsToolStripMenuItem"
        Me.UserDetailsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UserDetailsToolStripMenuItem.Text = "Product "
        '
        'AddProductDetailsToolStripMenuItem
        '
        Me.AddProductDetailsToolStripMenuItem.Name = "AddProductDetailsToolStripMenuItem"
        Me.AddProductDetailsToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AddProductDetailsToolStripMenuItem.Text = "Add Product Details"
        '
        'ViewProductDetailsToolStripMenuItem
        '
        Me.ViewProductDetailsToolStripMenuItem.Name = "ViewProductDetailsToolStripMenuItem"
        Me.ViewProductDetailsToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ViewProductDetailsToolStripMenuItem.Text = "View Product Details"
        '
        'CustomerDetailsToolStripMenuItem
        '
        Me.CustomerDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCustomerDetailsToolStripMenuItem, Me.ViewCustomerDetailsToolStripMenuItem})
        Me.CustomerDetailsToolStripMenuItem.Name = "CustomerDetailsToolStripMenuItem"
        Me.CustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.CustomerDetailsToolStripMenuItem.Text = "Customer Details"
        '
        'AddCustomerDetailsToolStripMenuItem
        '
        Me.AddCustomerDetailsToolStripMenuItem.Name = "AddCustomerDetailsToolStripMenuItem"
        Me.AddCustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AddCustomerDetailsToolStripMenuItem.Text = "Add Customer Details"
        '
        'ViewCustomerDetailsToolStripMenuItem
        '
        Me.ViewCustomerDetailsToolStripMenuItem.Name = "ViewCustomerDetailsToolStripMenuItem"
        Me.ViewCustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ViewCustomerDetailsToolStripMenuItem.Text = "View Customer Details"
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPurchaseDetailsToolStripMenuItem, Me.ViewPurchaseDetailsToolStripMenuItem, Me.AddPurchaseReturnDetailsToolStripMenuItem, Me.ViewPurchaseReturnDetailsToolStripMenuItem})
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.PurchaseToolStripMenuItem.Text = "Purchase"
        '
        'AddPurchaseDetailsToolStripMenuItem
        '
        Me.AddPurchaseDetailsToolStripMenuItem.Name = "AddPurchaseDetailsToolStripMenuItem"
        Me.AddPurchaseDetailsToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.AddPurchaseDetailsToolStripMenuItem.Text = "Add Purchase Details"
        '
        'ViewPurchaseDetailsToolStripMenuItem
        '
        Me.ViewPurchaseDetailsToolStripMenuItem.Name = "ViewPurchaseDetailsToolStripMenuItem"
        Me.ViewPurchaseDetailsToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.ViewPurchaseDetailsToolStripMenuItem.Text = "View Purchase Details"
        '
        'AddPurchaseReturnDetailsToolStripMenuItem
        '
        Me.AddPurchaseReturnDetailsToolStripMenuItem.Name = "AddPurchaseReturnDetailsToolStripMenuItem"
        Me.AddPurchaseReturnDetailsToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.AddPurchaseReturnDetailsToolStripMenuItem.Text = "Add Purchase Return Details"
        '
        'ViewPurchaseReturnDetailsToolStripMenuItem
        '
        Me.ViewPurchaseReturnDetailsToolStripMenuItem.Name = "ViewPurchaseReturnDetailsToolStripMenuItem"
        Me.ViewPurchaseReturnDetailsToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.ViewPurchaseReturnDetailsToolStripMenuItem.Text = "View Purchase Return Details"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSalesDetailsToolStripMenuItem, Me.ViewSalesDetailsToolStripMenuItem, Me.AddSalesReturnDToolStripMenuItem, Me.ViewSalesReturnDetailsToolStripMenuItem})
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'AddSalesDetailsToolStripMenuItem
        '
        Me.AddSalesDetailsToolStripMenuItem.Name = "AddSalesDetailsToolStripMenuItem"
        Me.AddSalesDetailsToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AddSalesDetailsToolStripMenuItem.Text = "Add Sales Details"
        '
        'ViewSalesDetailsToolStripMenuItem
        '
        Me.ViewSalesDetailsToolStripMenuItem.Name = "ViewSalesDetailsToolStripMenuItem"
        Me.ViewSalesDetailsToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ViewSalesDetailsToolStripMenuItem.Text = "View Sales Details"
        '
        'AddSalesReturnDToolStripMenuItem
        '
        Me.AddSalesReturnDToolStripMenuItem.Name = "AddSalesReturnDToolStripMenuItem"
        Me.AddSalesReturnDToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AddSalesReturnDToolStripMenuItem.Text = "Add Sales Return Details"
        '
        'ViewSalesReturnDetailsToolStripMenuItem
        '
        Me.ViewSalesReturnDetailsToolStripMenuItem.Name = "ViewSalesReturnDetailsToolStripMenuItem"
        Me.ViewSalesReturnDetailsToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ViewSalesReturnDetailsToolStripMenuItem.Text = "View Sales Return Details"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserDetailsToolStripMenuItem, Me.ViewUserDetailsToolStripMenuItem})
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.UserManagementToolStripMenuItem.Text = "User Management"
        '
        'AddUserDetailsToolStripMenuItem
        '
        Me.AddUserDetailsToolStripMenuItem.Name = "AddUserDetailsToolStripMenuItem"
        Me.AddUserDetailsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AddUserDetailsToolStripMenuItem.Text = "Add User Details"
        '
        'ViewUserDetailsToolStripMenuItem
        '
        Me.ViewUserDetailsToolStripMenuItem.Name = "ViewUserDetailsToolStripMenuItem"
        Me.ViewUserDetailsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ViewUserDetailsToolStripMenuItem.Text = "View User Details"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'Electronic_Gadget_Management_System
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(740, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Electronic_Gadget_Management_System"
        Me.Text = "Electronic_Gadget_Management_System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UserDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddUserDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewUserDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddProductDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProductDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCustomerDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCustomerDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPurchaseDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewPurchaseDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddPurchaseReturnDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewPurchaseReturnDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddSalesDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewSalesDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddSalesReturnDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewSalesReturnDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
End Class
