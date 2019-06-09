<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Customer_Add_Edit
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
        Me.Txt_Customer_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Customer_Name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Submit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Txt_Contact_Phone = New System.Windows.Forms.MaskedTextBox()
        Me.Txt_Other_Phone = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout
        '
        'Txt_Customer_Name
        '
        Me.Txt_Customer_Name.Location = New System.Drawing.Point(12, 93)
        Me.Txt_Customer_Name.Name = "Txt_Customer_Name"
        Me.Txt_Customer_Name.Size = New System.Drawing.Size(179, 20)
        Me.Txt_Customer_Name.TabIndex = 0
        '
        'Lbl_Customer_Name
        '
        Me.Lbl_Customer_Name.AutoSize = True
        Me.Lbl_Customer_Name.Location = New System.Drawing.Point(9, 77)
        Me.Lbl_Customer_Name.Name = "Lbl_Customer_Name"
        Me.Lbl_Customer_Name.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_Customer_Name.TabIndex = 1
        Me.Lbl_Customer_Name.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contact Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Other Phone"
        '
        'Btn_Submit
        '
        Me.Btn_Submit.AutoSize = True
        Me.Btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Submit.Depth = 0
        Me.Btn_Submit.Icon = Nothing
        Me.Btn_Submit.Location = New System.Drawing.Point(120, 201)
        Me.Btn_Submit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Submit.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Primary = True
        Me.Btn_Submit.Size = New System.Drawing.Size(71, 36)
        Me.Btn_Submit.TabIndex = 5
        Me.Btn_Submit.Text = "Submit"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Txt_Contact_Phone
        '
        Me.Txt_Contact_Phone.Location = New System.Drawing.Point(12, 132)
        Me.Txt_Contact_Phone.Mask = "(00) 000 000"
        Me.Txt_Contact_Phone.Name = "Txt_Contact_Phone"
        Me.Txt_Contact_Phone.Size = New System.Drawing.Size(179, 20)
        Me.Txt_Contact_Phone.TabIndex = 7
        '
        'Txt_Other_Phone
        '
        Me.Txt_Other_Phone.Location = New System.Drawing.Point(12, 172)
        Me.Txt_Other_Phone.Mask = "(00) 000 000"
        Me.Txt_Other_Phone.Name = "Txt_Other_Phone"
        Me.Txt_Other_Phone.Size = New System.Drawing.Size(179, 20)
        Me.Txt_Other_Phone.TabIndex = 8
        '
        'Frm_Customer_Add_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 246)
        Me.Controls.Add(Me.Txt_Other_Phone)
        Me.Controls.Add(Me.Txt_Contact_Phone)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_Customer_Name)
        Me.Controls.Add(Me.Txt_Customer_Name)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Customer_Add_Edit"
        Me.Sizable = False
        Me.Text = "Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Customer_Name As TextBox
    Friend WithEvents Lbl_Customer_Name As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Submit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Txt_Contact_Phone As MaskedTextBox
    Friend WithEvents Txt_Other_Phone As MaskedTextBox
End Class
