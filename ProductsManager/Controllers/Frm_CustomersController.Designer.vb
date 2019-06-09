<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CustomersController
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Customers_Add = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Customers_Edit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.DGV_Customers = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Customers_Delete = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Btn_Customers_Add)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 112)
        Me.GroupBox1.TabIndex = 10
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
        'Btn_Customers_Add
        '
        Me.Btn_Customers_Add.AutoSize = True
        Me.Btn_Customers_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Customers_Add.Depth = 0
        Me.Btn_Customers_Add.Icon = Nothing
        Me.Btn_Customers_Add.Location = New System.Drawing.Point(200, 67)
        Me.Btn_Customers_Add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Customers_Add.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Customers_Add.Name = "Btn_Customers_Add"
        Me.Btn_Customers_Add.Primary = True
        Me.Btn_Customers_Add.Size = New System.Drawing.Size(51, 36)
        Me.Btn_Customers_Add.TabIndex = 1
        Me.Btn_Customers_Add.Text = "New"
        Me.Btn_Customers_Add.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Btn_Customers_Edit)
        Me.GroupBox3.Location = New System.Drawing.Point(276, 76)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 112)
        Me.GroupBox3.TabIndex = 12
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
        'Btn_Customers_Edit
        '
        Me.Btn_Customers_Edit.AutoSize = True
        Me.Btn_Customers_Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Customers_Edit.Depth = 0
        Me.Btn_Customers_Edit.Icon = Nothing
        Me.Btn_Customers_Edit.Location = New System.Drawing.Point(201, 67)
        Me.Btn_Customers_Edit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Customers_Edit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Customers_Edit.Name = "Btn_Customers_Edit"
        Me.Btn_Customers_Edit.Primary = True
        Me.Btn_Customers_Edit.Size = New System.Drawing.Size(50, 36)
        Me.Btn_Customers_Edit.TabIndex = 1
        Me.Btn_Customers_Edit.Text = "Edit"
        Me.Btn_Customers_Edit.UseVisualStyleBackColor = True
        '
        'DGV_Customers
        '
        Me.DGV_Customers.AllowUserToAddRows = False
        Me.DGV_Customers.AllowUserToDeleteRows = False
        Me.DGV_Customers.AllowUserToResizeRows = False
        Me.DGV_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Customers.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Customers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Customers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Customers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_Customers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Customers.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Customers.Location = New System.Drawing.Point(0, 268)
        Me.DGV_Customers.MultiSelect = False
        Me.DGV_Customers.Name = "DGV_Customers"
        Me.DGV_Customers.ReadOnly = True
        Me.DGV_Customers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Customers.RowHeadersVisible = False
        Me.DGV_Customers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Customers.Size = New System.Drawing.Size(830, 265)
        Me.DGV_Customers.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Btn_Customers_Delete)
        Me.GroupBox2.Location = New System.Drawing.Point(540, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 112)
        Me.GroupBox2.TabIndex = 11
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
        'Btn_Customers_Delete
        '
        Me.Btn_Customers_Delete.AutoSize = True
        Me.Btn_Customers_Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Customers_Delete.Depth = 0
        Me.Btn_Customers_Delete.Icon = Nothing
        Me.Btn_Customers_Delete.Location = New System.Drawing.Point(182, 67)
        Me.Btn_Customers_Delete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Customers_Delete.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Customers_Delete.Name = "Btn_Customers_Delete"
        Me.Btn_Customers_Delete.Primary = True
        Me.Btn_Customers_Delete.Size = New System.Drawing.Size(69, 36)
        Me.Btn_Customers_Delete.TabIndex = 1
        Me.Btn_Customers_Delete.Text = "Delete"
        Me.Btn_Customers_Delete.UseVisualStyleBackColor = True
        '
        'Frm_CustomersController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 533)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DGV_Customers)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frm_CustomersController"
        Me.Text = "Customers Controller"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGV_Customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Customers_Add As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Customers_Edit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents DGV_Customers As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Customers_Delete As MaterialSkin.Controls.MaterialFlatButton
End Class
