<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TransactionController
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.components = New System.ComponentModel.Container()
        Me.DGV_Transactions = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Nbr_Product_Qty = New System.Windows.Forms.NumericUpDown()
        Me.CBox_Products = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBox_Customers = New System.Windows.Forms.ComboBox()
        Me.DGV_Products = New System.Windows.Forms.DataGridView()
        Me.Col_Product_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Product_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQUESTED_QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SELL_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMS_Products = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Product_Add = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialFlatButton()
        CType(Me.DGV_Transactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nbr_Product_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMS_Products.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Transactions
        '
        Me.DGV_Transactions.AllowUserToAddRows = False
        Me.DGV_Transactions.AllowUserToDeleteRows = False
        Me.DGV_Transactions.AllowUserToResizeRows = False
        Me.DGV_Transactions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Transactions.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Transactions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Transactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Transactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Transactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Transactions.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Transactions.Location = New System.Drawing.Point(272, 89)
        Me.DGV_Transactions.MultiSelect = False
        Me.DGV_Transactions.Name = "DGV_Transactions"
        Me.DGV_Transactions.ReadOnly = True
        Me.DGV_Transactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Transactions.RowHeadersVisible = False
        Me.DGV_Transactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Transactions.Size = New System.Drawing.Size(528, 520)
        Me.DGV_Transactions.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(162, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Qty"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Product"
        '
        'Nbr_Product_Qty
        '
        Me.Nbr_Product_Qty.DecimalPlaces = 2
        Me.Nbr_Product_Qty.Location = New System.Drawing.Point(165, 130)
        Me.Nbr_Product_Qty.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Nbr_Product_Qty.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Nbr_Product_Qty.Name = "Nbr_Product_Qty"
        Me.Nbr_Product_Qty.Size = New System.Drawing.Size(63, 20)
        Me.Nbr_Product_Qty.TabIndex = 25
        Me.Nbr_Product_Qty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CBox_Products
        '
        Me.CBox_Products.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBox_Products.FormattingEnabled = True
        Me.CBox_Products.Location = New System.Drawing.Point(12, 129)
        Me.CBox_Products.Name = "CBox_Products"
        Me.CBox_Products.Size = New System.Drawing.Size(147, 21)
        Me.CBox_Products.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Customer"
        '
        'CBox_Customers
        '
        Me.CBox_Customers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBox_Customers.FormattingEnabled = True
        Me.CBox_Customers.Location = New System.Drawing.Point(12, 89)
        Me.CBox_Customers.Name = "CBox_Customers"
        Me.CBox_Customers.Size = New System.Drawing.Size(251, 21)
        Me.CBox_Customers.TabIndex = 29
        '
        'DGV_Products
        '
        Me.DGV_Products.AllowUserToAddRows = False
        Me.DGV_Products.AllowUserToDeleteRows = False
        Me.DGV_Products.AllowUserToResizeRows = False
        Me.DGV_Products.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGV_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Products.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Products.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Product_Id, Me.Col_Product_Name, Me.Col_Product_Qty, Me.REQUESTED_QTY, Me.SELL_PRICE})
        Me.DGV_Products.ContextMenuStrip = Me.CMS_Products
        Me.DGV_Products.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Products.DataMember = "Part"
        Me.DGV_Products.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Products.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Products.Location = New System.Drawing.Point(12, 172)
        Me.DGV_Products.MultiSelect = False
        Me.DGV_Products.Name = "DGV_Products"
        Me.DGV_Products.ReadOnly = True
        Me.DGV_Products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Products.RowHeadersVisible = False
        Me.DGV_Products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Products.Size = New System.Drawing.Size(254, 377)
        Me.DGV_Products.TabIndex = 31
        '
        'Col_Product_Id
        '
        Me.Col_Product_Id.DataPropertyName = "ID"
        Me.Col_Product_Id.HeaderText = "ID"
        Me.Col_Product_Id.Name = "Col_Product_Id"
        Me.Col_Product_Id.ReadOnly = True
        Me.Col_Product_Id.Visible = False
        '
        'Col_Product_Name
        '
        Me.Col_Product_Name.DataPropertyName = "Name"
        Me.Col_Product_Name.HeaderText = "Product"
        Me.Col_Product_Name.Name = "Col_Product_Name"
        Me.Col_Product_Name.ReadOnly = True
        '
        'Col_Product_Qty
        '
        Me.Col_Product_Qty.DataPropertyName = "Qty"
        Me.Col_Product_Qty.HeaderText = "Available Qty"
        Me.Col_Product_Qty.Name = "Col_Product_Qty"
        Me.Col_Product_Qty.ReadOnly = True
        Me.Col_Product_Qty.Visible = False
        '
        'REQUESTED_QTY
        '
        Me.REQUESTED_QTY.DataPropertyName = "REQUESTED_QTY"
        Me.REQUESTED_QTY.HeaderText = "Qty"
        Me.REQUESTED_QTY.Name = "REQUESTED_QTY"
        Me.REQUESTED_QTY.ReadOnly = True
        '
        'SELL_PRICE
        '
        Me.SELL_PRICE.DataPropertyName = "SELL_PRICE"
        Me.SELL_PRICE.HeaderText = "Sell Price"
        Me.SELL_PRICE.Name = "SELL_PRICE"
        Me.SELL_PRICE.ReadOnly = True
        Me.SELL_PRICE.Visible = False
        '
        'CMS_Products
        '
        Me.CMS_Products.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSelectedToolStripMenuItem})
        Me.CMS_Products.Name = "CMS_Products"
        Me.CMS_Products.Size = New System.Drawing.Size(155, 26)
        '
        'DeleteSelectedToolStripMenuItem
        '
        Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
        Me.DeleteSelectedToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DeleteSelectedToolStripMenuItem.Text = "Delete Selected"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Transactions"
        '
        'Btn_Product_Add
        '
        Me.Btn_Product_Add.AutoSize = True
        Me.Btn_Product_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Product_Add.Depth = 0
        Me.Btn_Product_Add.Icon = Nothing
        Me.Btn_Product_Add.Location = New System.Drawing.Point(234, 120)
        Me.Btn_Product_Add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Product_Add.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Product_Add.Name = "Btn_Product_Add"
        Me.Btn_Product_Add.Primary = True
        Me.Btn_Product_Add.Size = New System.Drawing.Size(29, 36)
        Me.Btn_Product_Add.TabIndex = 26
        Me.Btn_Product_Add.Text = "+"
        Me.Btn_Product_Add.UseVisualStyleBackColor = True
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Submit.AutoSize = True
        Me.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Submit.Depth = 0
        Me.Btn_Submit.Icon = Nothing
        Me.Btn_Submit.Location = New System.Drawing.Point(12, 558)
        Me.Btn_Submit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = True
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 33
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Frm_TransactionController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 609)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV_Products)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBox_Customers)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Btn_Product_Add)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Nbr_Product_Qty)
        Me.Controls.Add(Me.CBox_Products)
        Me.Controls.Add(Me.DGV_Transactions)
        Me.Name = "Frm_TransactionController"
        Me.Text = "Transactions Controller POS"
        CType(Me.DGV_Transactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nbr_Product_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMS_Products.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Transactions As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Nbr_Product_Qty As NumericUpDown
    Friend WithEvents CBox_Products As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBox_Customers As ComboBox
    Friend WithEvents DGV_Products As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Product_Add As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Btn_Submit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Col_Product_Id As DataGridViewTextBoxColumn
    Friend WithEvents Col_Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents Col_Product_Qty As DataGridViewTextBoxColumn
    Friend WithEvents REQUESTED_QTY As DataGridViewTextBoxColumn
    Friend WithEvents SELL_PRICE As DataGridViewTextBoxColumn
    Friend WithEvents CMS_Products As ContextMenuStrip
    Friend WithEvents DeleteSelectedToolStripMenuItem As ToolStripMenuItem
End Class
