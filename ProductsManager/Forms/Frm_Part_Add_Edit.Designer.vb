<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Part_Add_Edit
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
        Me.Txt_Part_Name = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Nbr_Part_Cost = New System.Windows.Forms.NumericUpDown()
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Part_Description = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nbr_Part_Qty = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Nbr_Part_Cost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nbr_Part_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Part_Name
        '
        Me.Txt_Part_Name.Location = New System.Drawing.Point(15, 90)
        Me.Txt_Part_Name.Name = "Txt_Part_Name"
        Me.Txt_Part_Name.Size = New System.Drawing.Size(163, 20)
        Me.Txt_Part_Name.TabIndex = 0
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(12, 74)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(57, 13)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Part Name"
        '
        'Nbr_Part_Cost
        '
        Me.Nbr_Part_Cost.DecimalPlaces = 3
        Me.Nbr_Part_Cost.Location = New System.Drawing.Point(15, 208)
        Me.Nbr_Part_Cost.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.Nbr_Part_Cost.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.Nbr_Part_Cost.Name = "Nbr_Part_Cost"
        Me.Nbr_Part_Cost.Size = New System.Drawing.Size(79, 20)
        Me.Nbr_Part_Cost.TabIndex = 2
        Me.Nbr_Part_Cost.Value = New Decimal(New Integer() {1, 0, 0, 196608})
        '
        'Btn_Submit
        '
        Me.Btn_Submit.AutoSize = True
        Me.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Submit.Depth = 0
        Me.Btn_Submit.Icon = Nothing
        Me.Btn_Submit.Location = New System.Drawing.Point(107, 237)
        Me.Btn_Submit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = True
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 4
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Part Description"
        '
        'Txt_Part_Description
        '
        Me.Txt_Part_Description.Location = New System.Drawing.Point(15, 129)
        Me.Txt_Part_Description.Multiline = True
        Me.Txt_Part_Description.Name = "Txt_Part_Description"
        Me.Txt_Part_Description.Size = New System.Drawing.Size(163, 60)
        Me.Txt_Part_Description.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cost $"
        '
        'Nbr_Part_Qty
        '
        Me.Nbr_Part_Qty.DecimalPlaces = 2
        Me.Nbr_Part_Qty.Location = New System.Drawing.Point(100, 208)
        Me.Nbr_Part_Qty.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.Nbr_Part_Qty.Name = "Nbr_Part_Qty"
        Me.Nbr_Part_Qty.Size = New System.Drawing.Size(78, 20)
        Me.Nbr_Part_Qty.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Qty"
        '
        'Frm_Part_Add_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(194, 281)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Nbr_Part_Qty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Part_Description)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.Nbr_Part_Cost)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Txt_Part_Name)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Part_Add_Edit"
        Me.Sizable = False
        Me.Text = "Part"
        CType(Me.Nbr_Part_Cost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nbr_Part_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Part_Name As TextBox
    Friend WithEvents lbl As Label
    Friend WithEvents Nbr_Part_Cost As NumericUpDown
    Friend WithEvents Btn_Submit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Part_Description As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Nbr_Part_Qty As NumericUpDown
    Friend WithEvents Label3 As Label
End Class
