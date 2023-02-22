<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Sales_Return
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtitems = New System.Windows.Forms.TextBox()
        Me.cbocustomername = New System.Windows.Forms.ComboBox()
        Me.txtsalerid = New System.Windows.Forms.TextBox()
        Me.txtsalesid = New System.Windows.Forms.TextBox()
        Me.Dateofreturn = New System.Windows.Forms.DateTimePicker()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.cbobrand = New System.Windows.Forms.ComboBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtproductid = New System.Windows.Forms.TextBox()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Return"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sales Return Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sales Id:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Customer Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(266, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Brand:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(98, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Items:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Date Of Return:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(84, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Quantity:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(271, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Price:"
        '
        'txtitems
        '
        Me.txtitems.Location = New System.Drawing.Point(139, 210)
        Me.txtitems.Name = "txtitems"
        Me.txtitems.Size = New System.Drawing.Size(100, 20)
        Me.txtitems.TabIndex = 4
        '
        'cbocustomername
        '
        Me.cbocustomername.FormattingEnabled = True
        Me.cbocustomername.Location = New System.Drawing.Point(140, 167)
        Me.cbocustomername.Name = "cbocustomername"
        Me.cbocustomername.Size = New System.Drawing.Size(271, 21)
        Me.cbocustomername.TabIndex = 3
        '
        'txtsalerid
        '
        Me.txtsalerid.Enabled = False
        Me.txtsalerid.Location = New System.Drawing.Point(139, 124)
        Me.txtsalerid.Name = "txtsalerid"
        Me.txtsalerid.Size = New System.Drawing.Size(100, 20)
        Me.txtsalerid.TabIndex = 1
        '
        'txtsalesid
        '
        Me.txtsalesid.Location = New System.Drawing.Point(311, 124)
        Me.txtsalesid.Name = "txtsalesid"
        Me.txtsalesid.Size = New System.Drawing.Size(100, 20)
        Me.txtsalesid.TabIndex = 2
        '
        'Dateofreturn
        '
        Me.Dateofreturn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dateofreturn.Location = New System.Drawing.Point(140, 252)
        Me.Dateofreturn.Name = "Dateofreturn"
        Me.Dateofreturn.Size = New System.Drawing.Size(99, 20)
        Me.Dateofreturn.TabIndex = 5
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(311, 291)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(100, 20)
        Me.txtprice.TabIndex = 8
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(140, 291)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(100, 20)
        Me.txtquantity.TabIndex = 7
        '
        'cbobrand
        '
        Me.cbobrand.FormattingEnabled = True
        Me.cbobrand.Location = New System.Drawing.Point(310, 250)
        Me.cbobrand.Name = "cbobrand"
        Me.cbobrand.Size = New System.Drawing.Size(100, 21)
        Me.cbobrand.TabIndex = 6
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(139, 341)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 9
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(310, 341)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 10
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Product Id:"
        '
        'txtproductid
        '
        Me.txtproductid.Location = New System.Drawing.Point(140, 87)
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.Size = New System.Drawing.Size(100, 20)
        Me.txtproductid.TabIndex = 12
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(579, 68)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(100, 20)
        Me.qty.TabIndex = 13
        '
        'Add_Sales_Return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.txtproductid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cbobrand)
        Me.Controls.Add(Me.Dateofreturn)
        Me.Controls.Add(Me.cbocustomername)
        Me.Controls.Add(Me.txtsalesid)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txtitems)
        Me.Controls.Add(Me.txtsalerid)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Add_Sales_Return"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_Sales_Return"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtitems As TextBox
    Friend WithEvents cbocustomername As ComboBox
    Friend WithEvents txtsalerid As TextBox
    Friend WithEvents txtsalesid As TextBox
    Friend WithEvents Dateofreturn As DateTimePicker
    Friend WithEvents txtprice As TextBox
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents cbobrand As ComboBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtproductid As TextBox
    Friend WithEvents qty As TextBox
End Class
