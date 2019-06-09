<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Product_Type_Add_Edit
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
        Me.Txt_Product_Type_Name = New System.Windows.Forms.TextBox()
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Product_Type_Description = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt_Product_Type_Name
        '
        Me.Txt_Product_Type_Name.Location = New System.Drawing.Point(15, 90)
        Me.Txt_Product_Type_Name.Name = "Txt_Product_Type_Name"
        Me.Txt_Product_Type_Name.Size = New System.Drawing.Size(149, 20)
        Me.Txt_Product_Type_Name.TabIndex = 0
        '
        'Btn_Submit
        '
        Me.Btn_Submit.AutoSize = True
        Me.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Submit.Depth = 0
        Me.Btn_Submit.Icon = Nothing
        Me.Btn_Submit.Location = New System.Drawing.Point(93, 193)
        Me.Btn_Submit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = True
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 2
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Type Name"
        '
        'Txt_Product_Type_Description
        '
        Me.Txt_Product_Type_Description.Location = New System.Drawing.Point(15, 129)
        Me.Txt_Product_Type_Description.Multiline = True
        Me.Txt_Product_Type_Description.Name = "Txt_Product_Type_Description"
        Me.Txt_Product_Type_Description.Size = New System.Drawing.Size(149, 55)
        Me.Txt_Product_Type_Description.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Type Description"
        '
        'Frm_Product_Type_Add_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(179, 240)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Product_Type_Description)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.Txt_Product_Type_Name)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Product_Type_Add_Edit"
        Me.Sizable = False
        Me.Text = "Product Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Product_Type_Name As TextBox
    Friend WithEvents Btn_Submit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Product_Type_Description As TextBox
    Friend WithEvents Label2 As Label
End Class
