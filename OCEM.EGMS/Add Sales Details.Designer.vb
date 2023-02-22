<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Sales_Details
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtitems = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Dateofsale = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcustomerid = New System.Windows.Forms.TextBox()
        Me.cbobrand = New System.Windows.Forms.ComboBox()
        Me.cbocustomername = New System.Windows.Forms.ComboBox()
        Me.txtsalesid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.cboproductid = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Electronic Items:"
        '
        'txtitems
        '
        Me.txtitems.Location = New System.Drawing.Point(349, 150)
        Me.txtitems.Name = "txtitems"
        Me.txtitems.Size = New System.Drawing.Size(100, 20)
        Me.txtitems.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Date Of Sales:"
        '
        'Dateofsale
        '
        Me.Dateofsale.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dateofsale.Location = New System.Drawing.Point(157, 190)
        Me.Dateofsale.Name = "Dateofsale"
        Me.Dateofsale.Size = New System.Drawing.Size(97, 20)
        Me.Dateofsale.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(305, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Brand:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(98, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Quantity:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(309, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Price:"
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(157, 228)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(100, 20)
        Me.txtquantity.TabIndex = 7
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(349, 225)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(100, 20)
        Me.txtprice.TabIndex = 8
        '
        'Btnsave
        '
        Me.Btnsave.Location = New System.Drawing.Point(179, 275)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(75, 23)
        Me.Btnsave.TabIndex = 9
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(291, 275)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 10
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(81, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Customer Id:"
        '
        'txtcustomerid
        '
        Me.txtcustomerid.Location = New System.Drawing.Point(154, 114)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.Size = New System.Drawing.Size(100, 20)
        Me.txtcustomerid.TabIndex = 1
        '
        'cbobrand
        '
        Me.cbobrand.FormattingEnabled = True
        Me.cbobrand.Location = New System.Drawing.Point(349, 190)
        Me.cbobrand.Name = "cbobrand"
        Me.cbobrand.Size = New System.Drawing.Size(100, 21)
        Me.cbobrand.TabIndex = 6
        '
        'cbocustomername
        '
        Me.cbocustomername.FormattingEnabled = True
        Me.cbocustomername.Location = New System.Drawing.Point(157, 152)
        Me.cbocustomername.Name = "cbocustomername"
        Me.cbocustomername.Size = New System.Drawing.Size(97, 21)
        Me.cbocustomername.TabIndex = 3
        '
        'txtsalesid
        '
        Me.txtsalesid.Enabled = False
        Me.txtsalesid.Location = New System.Drawing.Point(349, 113)
        Me.txtsalesid.Name = "txtsalesid"
        Me.txtsalesid.Size = New System.Drawing.Size(100, 20)
        Me.txtsalesid.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(295, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Sales Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Product id:"
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(624, 72)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(100, 20)
        Me.qty.TabIndex = 23
        '
        'cboproductid
        '
        Me.cboproductid.FormattingEnabled = True
        Me.cboproductid.Location = New System.Drawing.Point(157, 66)
        Me.cboproductid.Name = "cboproductid"
        Me.cboproductid.Size = New System.Drawing.Size(97, 21)
        Me.cboproductid.TabIndex = 24
        '
        'Add_Sales_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 332)
        Me.Controls.Add(Me.cboproductid)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtsalesid)
        Me.Controls.Add(Me.cbocustomername)
        Me.Controls.Add(Me.cbobrand)
        Me.Controls.Add(Me.txtcustomerid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Dateofsale)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtitems)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Add_Sales_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_Sales_Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtitems As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Dateofsale As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Btnsave As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcustomerid As TextBox
    Friend WithEvents cbobrand As ComboBox
    Friend WithEvents cbocustomername As ComboBox
    Friend WithEvents txtsalesid As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents qty As TextBox
    Friend WithEvents cboproductid As ComboBox
End Class
