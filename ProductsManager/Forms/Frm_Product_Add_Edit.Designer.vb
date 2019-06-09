<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Product_Add_Edit
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
        Me.Txt_Product_name = New System.Windows.Forms.TextBox()
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV_Composition_Parts = New System.Windows.Forms.DataGridView()
        Me.Col_Part_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Part_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Part_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMS_Parts = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Btn_Composition_Part_Add = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Nbr_Composition_Part_Qty = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBox_Compostition_Part = New System.Windows.Forms.ComboBox()
        Me.CBox_Product_Type = New System.Windows.Forms.ComboBox()
        Me.Lbl_Product_name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Product_Description = New System.Windows.Forms.TextBox()
        Me.Nbr_Product_Cost = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Nbr_Product_Price = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Nbr_Time_To_Manufacture = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Nbr_Product_Qty = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_Composition_Products = New System.Windows.Forms.DataGridView()
        Me.Col_Product_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Product_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMS_Products = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btn_Composition_Product_Add = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Nbr_Composition_Product_Qty = New System.Windows.Forms.NumericUpDown()
        Me.CBox_Composition_Product = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Composition_Parts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMS_Parts.SuspendLayout()
        CType(Me.Nbr_Composition_Part_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nbr_Product_Cost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nbr_Product_Price, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nbr_Time_To_Manufacture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nbr_Product_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Composition_Products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMS_Products.SuspendLayout()
        CType(Me.Nbr_Composition_Product_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Product_name
        '
        Me.Txt_Product_name.Location = New System.Drawing.Point(15, 94)
        Me.Txt_Product_name.Name = "Txt_Product_name"
        Me.Txt_Product_name.Size = New System.Drawing.Size(160, 20)
        Me.Txt_Product_name.TabIndex = 0
        '
        'Btn_Submit
        '
        Me.Btn_Submit.AutoSize = True
        Me.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Submit.Depth = 0
        Me.Btn_Submit.Icon = Nothing
        Me.Btn_Submit.Location = New System.Drawing.Point(575, 320)
        Me.Btn_Submit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = True
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 13
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.DGV_Composition_Parts)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Btn_Composition_Part_Add)
        Me.GroupBox1.Controls.Add(Me.Nbr_Composition_Part_Qty)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CBox_Compostition_Part)
        Me.GroupBox1.Location = New System.Drawing.Point(194, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 220)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parts Compostition"
        '
        'DGV_Composition_Parts
        '
        Me.DGV_Composition_Parts.AllowUserToAddRows = False
        Me.DGV_Composition_Parts.AllowUserToDeleteRows = False
        Me.DGV_Composition_Parts.AllowUserToResizeRows = False
        Me.DGV_Composition_Parts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Composition_Parts.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Composition_Parts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Composition_Parts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Composition_Parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Composition_Parts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Part_Id, Me.Col_Part_Name, Me.Col_Part_Qty})
        Me.DGV_Composition_Parts.ContextMenuStrip = Me.CMS_Parts
        Me.DGV_Composition_Parts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Composition_Parts.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_Composition_Parts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Composition_Parts.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Composition_Parts.Location = New System.Drawing.Point(3, 67)
        Me.DGV_Composition_Parts.MultiSelect = False
        Me.DGV_Composition_Parts.Name = "DGV_Composition_Parts"
        Me.DGV_Composition_Parts.ReadOnly = True
        Me.DGV_Composition_Parts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Composition_Parts.RowHeadersVisible = False
        Me.DGV_Composition_Parts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Composition_Parts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Composition_Parts.Size = New System.Drawing.Size(217, 150)
        Me.DGV_Composition_Parts.TabIndex = 22
        '
        'Col_Part_Id
        '
        Me.Col_Part_Id.DataPropertyName = "ID"
        Me.Col_Part_Id.HeaderText = "ID"
        Me.Col_Part_Id.Name = "Col_Part_Id"
        Me.Col_Part_Id.ReadOnly = True
        Me.Col_Part_Id.Visible = False
        '
        'Col_Part_Name
        '
        Me.Col_Part_Name.DataPropertyName = "Name"
        Me.Col_Part_Name.HeaderText = "Part"
        Me.Col_Part_Name.Name = "Col_Part_Name"
        Me.Col_Part_Name.ReadOnly = True
        '
        'Col_Part_Qty
        '
        Me.Col_Part_Qty.DataPropertyName = "Qty"
        Me.Col_Part_Qty.HeaderText = "Qty"
        Me.Col_Part_Qty.Name = "Col_Part_Qty"
        Me.Col_Part_Qty.ReadOnly = True
        '
        'CMS_Parts
        '
        Me.CMS_Parts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSelectedToolStripMenuItem})
        Me.CMS_Parts.Name = "ContextMenuStrip1"
        Me.CMS_Parts.Size = New System.Drawing.Size(155, 26)
        '
        'DeleteSelectedToolStripMenuItem
        '
        Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
        Me.DeleteSelectedToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DeleteSelectedToolStripMenuItem.Text = "Delete Selected"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(116, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Qty"
        '
        'Btn_Composition_Part_Add
        '
        Me.Btn_Composition_Part_Add.AutoSize = True
        Me.Btn_Composition_Part_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Composition_Part_Add.Depth = 0
        Me.Btn_Composition_Part_Add.Icon = Nothing
        Me.Btn_Composition_Part_Add.Location = New System.Drawing.Point(187, 30)
        Me.Btn_Composition_Part_Add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Composition_Part_Add.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Composition_Part_Add.Name = "Btn_Composition_Part_Add"
        Me.Btn_Composition_Part_Add.Primary = False
        Me.Btn_Composition_Part_Add.Size = New System.Drawing.Size(29, 36)
        Me.Btn_Composition_Part_Add.TabIndex = 9
        Me.Btn_Composition_Part_Add.Text = "+"
        Me.Btn_Composition_Part_Add.UseVisualStyleBackColor = True
        '
        'Nbr_Composition_Part_Qty
        '
        Me.Nbr_Composition_Part_Qty.DecimalPlaces = 2
        Me.Nbr_Composition_Part_Qty.Location = New System.Drawing.Point(119, 40)
        Me.Nbr_Composition_Part_Qty.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Nbr_Composition_Part_Qty.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Nbr_Composition_Part_Qty.Name = "Nbr_Composition_Part_Qty"
        Me.Nbr_Composition_Part_Qty.Size = New System.Drawing.Size(63, 20)
        Me.Nbr_Composition_Part_Qty.TabIndex = 8
        Me.Nbr_Composition_Part_Qty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Part"
        '
        'CBox_Compostition_Part
        '
        Me.CBox_Compostition_Part.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBox_Compostition_Part.FormattingEnabled = True
        Me.CBox_Compostition_Part.Location = New System.Drawing.Point(6, 39)
        Me.CBox_Compostition_Part.Name = "CBox_Compostition_Part"
        Me.CBox_Compostition_Part.Size = New System.Drawing.Size(107, 21)
        Me.CBox_Compostition_Part.TabIndex = 7
        '
        'CBox_Product_Type
        '
        Me.CBox_Product_Type.FormattingEnabled = True
        Me.CBox_Product_Type.Location = New System.Drawing.Point(15, 248)
        Me.CBox_Product_Type.Name = "CBox_Product_Type"
        Me.CBox_Product_Type.Size = New System.Drawing.Size(156, 21)
        Me.CBox_Product_Type.TabIndex = 4
        '
        'Lbl_Product_name
        '
        Me.Lbl_Product_name.AutoSize = True
        Me.Lbl_Product_name.Location = New System.Drawing.Point(12, 78)
        Me.Lbl_Product_name.Name = "Lbl_Product_name"
        Me.Lbl_Product_name.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_Product_name.TabIndex = 5
        Me.Lbl_Product_name.Text = "Product Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Product Description"
        '
        'Txt_Product_Description
        '
        Me.Txt_Product_Description.Location = New System.Drawing.Point(15, 133)
        Me.Txt_Product_Description.Multiline = True
        Me.Txt_Product_Description.Name = "Txt_Product_Description"
        Me.Txt_Product_Description.Size = New System.Drawing.Size(160, 54)
        Me.Txt_Product_Description.TabIndex = 1
        '
        'Nbr_Product_Cost
        '
        Me.Nbr_Product_Cost.DecimalPlaces = 3
        Me.Nbr_Product_Cost.Location = New System.Drawing.Point(15, 209)
        Me.Nbr_Product_Cost.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Nbr_Product_Cost.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.Nbr_Product_Cost.Name = "Nbr_Product_Cost"
        Me.Nbr_Product_Cost.Size = New System.Drawing.Size(75, 20)
        Me.Nbr_Product_Cost.TabIndex = 2
        Me.Nbr_Product_Cost.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Cost $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Sell Price $"
        '
        'Nbr_Product_Price
        '
        Me.Nbr_Product_Price.DecimalPlaces = 3
        Me.Nbr_Product_Price.Location = New System.Drawing.Point(96, 209)
        Me.Nbr_Product_Price.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Nbr_Product_Price.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.Nbr_Product_Price.Name = "Nbr_Product_Price"
        Me.Nbr_Product_Price.Size = New System.Drawing.Size(75, 20)
        Me.Nbr_Product_Price.TabIndex = 3
        Me.Nbr_Product_Price.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Product Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "TTM (Hrs)"
        '
        'Nbr_Time_To_Manufacture
        '
        Me.Nbr_Time_To_Manufacture.DecimalPlaces = 3
        Me.Nbr_Time_To_Manufacture.Location = New System.Drawing.Point(15, 294)
        Me.Nbr_Time_To_Manufacture.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Nbr_Time_To_Manufacture.Name = "Nbr_Time_To_Manufacture"
        Me.Nbr_Time_To_Manufacture.Size = New System.Drawing.Size(75, 20)
        Me.Nbr_Time_To_Manufacture.TabIndex = 5
        Me.Nbr_Time_To_Manufacture.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Qty"
        '
        'Nbr_Product_Qty
        '
        Me.Nbr_Product_Qty.DecimalPlaces = 2
        Me.Nbr_Product_Qty.Location = New System.Drawing.Point(96, 294)
        Me.Nbr_Product_Qty.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Nbr_Product_Qty.Name = "Nbr_Product_Qty"
        Me.Nbr_Product_Qty.Size = New System.Drawing.Size(75, 20)
        Me.Nbr_Product_Qty.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.DGV_Composition_Products)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Btn_Composition_Product_Add)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Nbr_Composition_Product_Qty)
        Me.GroupBox2.Controls.Add(Me.CBox_Composition_Product)
        Me.GroupBox2.Location = New System.Drawing.Point(423, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 220)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Products Compostition"
        '
        'DGV_Composition_Products
        '
        Me.DGV_Composition_Products.AllowUserToAddRows = False
        Me.DGV_Composition_Products.AllowUserToDeleteRows = False
        Me.DGV_Composition_Products.AllowUserToResizeRows = False
        Me.DGV_Composition_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Composition_Products.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Composition_Products.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Composition_Products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Composition_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Composition_Products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Product_Id, Me.Col_Product_Name, Me.Col_Product_Qty})
        Me.DGV_Composition_Products.ContextMenuStrip = Me.CMS_Products
        Me.DGV_Composition_Products.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Composition_Products.DataMember = "Part"
        Me.DGV_Composition_Products.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_Composition_Products.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Composition_Products.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Composition_Products.Location = New System.Drawing.Point(3, 67)
        Me.DGV_Composition_Products.MultiSelect = False
        Me.DGV_Composition_Products.Name = "DGV_Composition_Products"
        Me.DGV_Composition_Products.ReadOnly = True
        Me.DGV_Composition_Products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Composition_Products.RowHeadersVisible = False
        Me.DGV_Composition_Products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Composition_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Composition_Products.Size = New System.Drawing.Size(217, 150)
        Me.DGV_Composition_Products.TabIndex = 24
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
        Me.Col_Product_Qty.HeaderText = "Qty"
        Me.Col_Product_Qty.Name = "Col_Product_Qty"
        Me.Col_Product_Qty.ReadOnly = True
        '
        'CMS_Products
        '
        Me.CMS_Products.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.CMS_Products.Name = "ContextMenuStrip1"
        Me.CMS_Products.Size = New System.Drawing.Size(155, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.ToolStripMenuItem1.Text = "Delete Selected"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(116, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Qty"
        '
        'Btn_Composition_Product_Add
        '
        Me.Btn_Composition_Product_Add.AutoSize = True
        Me.Btn_Composition_Product_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Composition_Product_Add.Depth = 0
        Me.Btn_Composition_Product_Add.Icon = Nothing
        Me.Btn_Composition_Product_Add.Location = New System.Drawing.Point(189, 30)
        Me.Btn_Composition_Product_Add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Composition_Product_Add.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Composition_Product_Add.Name = "Btn_Composition_Product_Add"
        Me.Btn_Composition_Product_Add.Primary = False
        Me.Btn_Composition_Product_Add.Size = New System.Drawing.Size(29, 36)
        Me.Btn_Composition_Product_Add.TabIndex = 12
        Me.Btn_Composition_Product_Add.Text = "+"
        Me.Btn_Composition_Product_Add.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Product"
        '
        'Nbr_Composition_Product_Qty
        '
        Me.Nbr_Composition_Product_Qty.DecimalPlaces = 2
        Me.Nbr_Composition_Product_Qty.Location = New System.Drawing.Point(119, 40)
        Me.Nbr_Composition_Product_Qty.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Nbr_Composition_Product_Qty.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Nbr_Composition_Product_Qty.Name = "Nbr_Composition_Product_Qty"
        Me.Nbr_Composition_Product_Qty.Size = New System.Drawing.Size(63, 20)
        Me.Nbr_Composition_Product_Qty.TabIndex = 11
        Me.Nbr_Composition_Product_Qty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CBox_Composition_Product
        '
        Me.CBox_Composition_Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBox_Composition_Product.FormattingEnabled = True
        Me.CBox_Composition_Product.Location = New System.Drawing.Point(6, 39)
        Me.CBox_Composition_Product.Name = "CBox_Composition_Product"
        Me.CBox_Composition_Product.Size = New System.Drawing.Size(107, 21)
        Me.CBox_Composition_Product.TabIndex = 10
        '
        'Frm_Product_Add_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 366)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Nbr_Product_Qty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Nbr_Time_To_Manufacture)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Nbr_Product_Price)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Nbr_Product_Cost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Product_Description)
        Me.Controls.Add(Me.Lbl_Product_name)
        Me.Controls.Add(Me.CBox_Product_Type)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.Txt_Product_name)
        Me.Name = "Frm_Product_Add_Edit"
        Me.Text = "Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Composition_Parts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMS_Parts.ResumeLayout(False)
        CType(Me.Nbr_Composition_Part_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nbr_Product_Cost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nbr_Product_Price, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nbr_Time_To_Manufacture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nbr_Product_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV_Composition_Products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMS_Products.ResumeLayout(False)
        CType(Me.Nbr_Composition_Product_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Product_name As TextBox
    Friend WithEvents Btn_Submit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_Composition_Part_Add As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label7 As Label
    Friend WithEvents CBox_Compostition_Part As ComboBox
    Friend WithEvents CBox_Product_Type As ComboBox
    Friend WithEvents Lbl_Product_name As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Product_Description As TextBox
    Friend WithEvents Nbr_Product_Cost As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Nbr_Product_Price As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Nbr_Time_To_Manufacture As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Nbr_Product_Qty As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Composition_Product_Add As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label8 As Label
    Friend WithEvents CBox_Composition_Product As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Nbr_Composition_Part_Qty As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Nbr_Composition_Product_Qty As NumericUpDown
    Friend WithEvents DGV_Composition_Parts As DataGridView
    Friend WithEvents DGV_Composition_Products As DataGridView
    Friend WithEvents Col_Part_Id As DataGridViewTextBoxColumn
    Friend WithEvents Col_Part_Name As DataGridViewTextBoxColumn
    Friend WithEvents Col_Part_Qty As DataGridViewTextBoxColumn
    Friend WithEvents Col_Product_Id As DataGridViewTextBoxColumn
    Friend WithEvents Col_Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents Col_Product_Qty As DataGridViewTextBoxColumn
    Friend WithEvents CMS_Parts As ContextMenuStrip
    Friend WithEvents DeleteSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CMS_Products As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
