<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Purchase_Return
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
        Me.txteitems = New System.Windows.Forms.TextBox()
        Me.cbobrand = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpurchasereturnid = New System.Windows.Forms.TextBox()
        Me.cbosuppliername = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.cboproductid = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Return"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Supplier Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Electronic Items:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(300, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Brand:"
        '
        'txteitems
        '
        Me.txteitems.Location = New System.Drawing.Point(165, 201)
        Me.txteitems.Name = "txteitems"
        Me.txteitems.Size = New System.Drawing.Size(100, 20)
        Me.txteitems.TabIndex = 4
        '
        'cbobrand
        '
        Me.cbobrand.FormattingEnabled = True
        Me.cbobrand.Location = New System.Drawing.Point(344, 200)
        Me.cbobrand.Name = "cbobrand"
        Me.cbobrand.Size = New System.Drawing.Size(114, 21)
        Me.cbobrand.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Quantity:"
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(165, 242)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(100, 20)
        Me.txtquantity.TabIndex = 6
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(344, 242)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(114, 20)
        Me.txtprice.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Price:"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(165, 317)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 8
        Me.btnadd.Text = "Save"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(284, 317)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 9
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Purchase Return Id:"
        '
        'txtpurchasereturnid
        '
        Me.txtpurchasereturnid.Enabled = False
        Me.txtpurchasereturnid.Location = New System.Drawing.Point(165, 91)
        Me.txtpurchasereturnid.Name = "txtpurchasereturnid"
        Me.txtpurchasereturnid.Size = New System.Drawing.Size(100, 20)
        Me.txtpurchasereturnid.TabIndex = 1
        '
        'cbosuppliername
        '
        Me.cbosuppliername.FormattingEnabled = True
        Me.cbosuppliername.Location = New System.Drawing.Point(165, 158)
        Me.cbosuppliername.Name = "cbosuppliername"
        Me.cbosuppliername.Size = New System.Drawing.Size(293, 21)
        Me.cbosuppliername.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(271, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Purchase Id:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(344, 124)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(100, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Product Id:"
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(634, 124)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(100, 20)
        Me.qty.TabIndex = 14
        '
        'cboproductid
        '
        Me.cboproductid.FormattingEnabled = True
        Me.cboproductid.Location = New System.Drawing.Point(166, 127)
        Me.cboproductid.Name = "cboproductid"
        Me.cboproductid.Size = New System.Drawing.Size(99, 21)
        Me.cboproductid.TabIndex = 15
        '
        'Add_Purchase_Return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboproductid)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbosuppliername)
        Me.Controls.Add(Me.txtpurchasereturnid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbobrand)
        Me.Controls.Add(Me.txteitems)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Add_Purchase_Return"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_Purchase_Return"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txteitems As TextBox
    Friend WithEvents cbobrand As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtpurchasereturnid As TextBox
    Friend WithEvents cbosuppliername As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents qty As TextBox
    Friend WithEvents cboproductid As ComboBox
End Class
