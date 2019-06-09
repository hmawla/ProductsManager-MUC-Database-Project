<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ProductsController
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
        Me.DGV_Products = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Products_Add = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Product_Delete = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Product_Edit = New MaterialSkin.Controls.MaterialFlatButton()
        CType(Me.DGV_Products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Products
        '
        Me.DGV_Products.AllowUserToAddRows = False
        Me.DGV_Products.AllowUserToDeleteRows = False
        Me.DGV_Products.AllowUserToResizeRows = False
        Me.DGV_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Products.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Products.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Products.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Products.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_Products.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Products.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Products.Location = New System.Drawing.Point(0, 192)
        Me.DGV_Products.MultiSelect = False
        Me.DGV_Products.Name = "DGV_Products"
        Me.DGV_Products.ReadOnly = True
        Me.DGV_Products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Products.RowHeadersVisible = False
        Me.DGV_Products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Products.Size = New System.Drawing.Size(830, 258)
        Me.DGV_Products.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Btn_Products_Add)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 41)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add New"
        '
        'Btn_Products_Add
        '
        Me.Btn_Products_Add.AutoSize = True
        Me.Btn_Products_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Products_Add.Depth = 0
        Me.Btn_Products_Add.Icon = Nothing
        Me.Btn_Products_Add.Location = New System.Drawing.Point(200, 67)
        Me.Btn_Products_Add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Products_Add.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Products_Add.Name = "Btn_Products_Add"
        Me.Btn_Products_Add.Primary = True
        Me.Btn_Products_Add.Size = New System.Drawing.Size(51, 36)
        Me.Btn_Products_Add.TabIndex = 1
        Me.Btn_Products_Add.Text = "New"
        Me.Btn_Products_Add.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Btn_Product_Delete)
        Me.GroupBox2.Location = New System.Drawing.Point(540, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 112)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 41)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Delete"
        '
        'Btn_Product_Delete
        '
        Me.Btn_Product_Delete.AutoSize = True
        Me.Btn_Product_Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Product_Delete.Depth = 0
        Me.Btn_Product_Delete.Icon = Nothing
        Me.Btn_Product_Delete.Location = New System.Drawing.Point(182, 67)
        Me.Btn_Product_Delete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Product_Delete.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Product_Delete.Name = "Btn_Product_Delete"
        Me.Btn_Product_Delete.Primary = True
        Me.Btn_Product_Delete.Size = New System.Drawing.Size(69, 36)
        Me.Btn_Product_Delete.TabIndex = 1
        Me.Btn_Product_Delete.Text = "Delete"
        Me.Btn_Product_Delete.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Btn_Product_Edit)
        Me.GroupBox3.Location = New System.Drawing.Point(276, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 112)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 41)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Edit"
        '
        'Btn_Product_Edit
        '
        Me.Btn_Product_Edit.AutoSize = True
        Me.Btn_Product_Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Product_Edit.Depth = 0
        Me.Btn_Product_Edit.Icon = Nothing
        Me.Btn_Product_Edit.Location = New System.Drawing.Point(201, 67)
        Me.Btn_Product_Edit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Product_Edit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Product_Edit.Name = "Btn_Product_Edit"
        Me.Btn_Product_Edit.Primary = True
        Me.Btn_Product_Edit.Size = New System.Drawing.Size(50, 36)
        Me.Btn_Product_Edit.TabIndex = 1
        Me.Btn_Product_Edit.Text = "Edit"
        Me.Btn_Product_Edit.UseVisualStyleBackColor = True
        '
        'Frm_ProductsController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV_Products)
        Me.Name = "Frm_ProductsController"
        Me.Text = "Products Controller"
        CType(Me.DGV_Products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_Products As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Products_Add As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Product_Delete As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Product_Edit As MaterialSkin.Controls.MaterialFlatButton
End Class
