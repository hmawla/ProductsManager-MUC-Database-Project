<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PartsController
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
        Me.Btn_Parts_Add = New MaterialSkin.Controls.MaterialFlatButton()
        Me.DGV_Parts = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Parts_Edit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Parts_Delete = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Parts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Btn_Parts_Add)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 112)
        Me.GroupBox1.TabIndex = 14
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
        'Btn_Parts_Add
        '
        Me.Btn_Parts_Add.AutoSize = True
        Me.Btn_Parts_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Parts_Add.Depth = 0
        Me.Btn_Parts_Add.Icon = Nothing
        Me.Btn_Parts_Add.Location = New System.Drawing.Point(200, 67)
        Me.Btn_Parts_Add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Parts_Add.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Parts_Add.Name = "Btn_Parts_Add"
        Me.Btn_Parts_Add.Primary = True
        Me.Btn_Parts_Add.Size = New System.Drawing.Size(51, 36)
        Me.Btn_Parts_Add.TabIndex = 1
        Me.Btn_Parts_Add.Text = "New"
        Me.Btn_Parts_Add.UseVisualStyleBackColor = True
        '
        'DGV_Parts
        '
        Me.DGV_Parts.AllowUserToAddRows = False
        Me.DGV_Parts.AllowUserToDeleteRows = False
        Me.DGV_Parts.AllowUserToResizeRows = False
        Me.DGV_Parts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Parts.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Parts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Parts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Parts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Parts.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_Parts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Parts.GridColor = System.Drawing.Color.PowderBlue
        Me.DGV_Parts.Location = New System.Drawing.Point(0, 196)
        Me.DGV_Parts.MultiSelect = False
        Me.DGV_Parts.Name = "DGV_Parts"
        Me.DGV_Parts.ReadOnly = True
        Me.DGV_Parts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_Parts.RowHeadersVisible = False
        Me.DGV_Parts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_Parts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Parts.Size = New System.Drawing.Size(809, 322)
        Me.DGV_Parts.TabIndex = 13
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Btn_Parts_Edit)
        Me.GroupBox3.Location = New System.Drawing.Point(276, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 112)
        Me.GroupBox3.TabIndex = 16
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
        'Btn_Parts_Edit
        '
        Me.Btn_Parts_Edit.AutoSize = True
        Me.Btn_Parts_Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Parts_Edit.Depth = 0
        Me.Btn_Parts_Edit.Icon = Nothing
        Me.Btn_Parts_Edit.Location = New System.Drawing.Point(201, 67)
        Me.Btn_Parts_Edit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Parts_Edit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Parts_Edit.Name = "Btn_Parts_Edit"
        Me.Btn_Parts_Edit.Primary = True
        Me.Btn_Parts_Edit.Size = New System.Drawing.Size(50, 36)
        Me.Btn_Parts_Edit.TabIndex = 1
        Me.Btn_Parts_Edit.Text = "Edit"
        Me.Btn_Parts_Edit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Btn_Parts_Delete)
        Me.GroupBox2.Location = New System.Drawing.Point(540, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 112)
        Me.GroupBox2.TabIndex = 15
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
        'Btn_Parts_Delete
        '
        Me.Btn_Parts_Delete.AutoSize = True
        Me.Btn_Parts_Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Parts_Delete.Depth = 0
        Me.Btn_Parts_Delete.Icon = Nothing
        Me.Btn_Parts_Delete.Location = New System.Drawing.Point(182, 67)
        Me.Btn_Parts_Delete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Parts_Delete.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Parts_Delete.Name = "Btn_Parts_Delete"
        Me.Btn_Parts_Delete.Primary = True
        Me.Btn_Parts_Delete.Size = New System.Drawing.Size(69, 36)
        Me.Btn_Parts_Delete.TabIndex = 1
        Me.Btn_Parts_Delete.Text = "Delete"
        Me.Btn_Parts_Delete.UseVisualStyleBackColor = True
        '
        'Frm_PartsController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 518)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV_Parts)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frm_PartsController"
        Me.Text = "Parts Controller"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Parts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Parts_Add As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents DGV_Parts As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Parts_Edit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Parts_Delete As MaterialSkin.Controls.MaterialFlatButton
End Class
