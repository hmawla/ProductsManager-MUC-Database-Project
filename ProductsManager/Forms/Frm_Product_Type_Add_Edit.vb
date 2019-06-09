Imports MaterialSkin

Public Class Frm_Product_Type_Add_Edit
    Dim ID As Integer = 0

    Public Overloads Sub ShowDialog(ByVal ID As Integer)
        Me.ID = ID
        Me.ShowDialog()
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        If ID = 0 Then
            If Txt_Product_Type_Name.Text.Length > 0 And Txt_Product_Type_Description.Text.Length > 0 Then
                Dim name As String = Txt_Product_Type_Name.Text
                Dim description As String = Txt_Product_Type_Description.Text

                ExecuteQuery($"INSERT INTO ProductType(name, description) VALUES('{name}', '{description}')")
                Close()
            Else
                MessageBox.Show("Please fill all needed information!")
            End If
        Else
            If Txt_Product_Type_Name.Text.Length > 0 And Txt_Product_Type_Description.Text.Length > 0 Then
                Dim name As String = Txt_Product_Type_Name.Text
                Dim description As String = Txt_Product_Type_Description.Text

                ExecuteQuery($"UPDATE ProductType SET name = '{name}', description = '{description}' WHERE id = {ID}")
                Close()
            Else
                MessageBox.Show("Please fill all needed information!")
            End If
        End If
    End Sub

    Private Sub Frm_Product_Types_Add_Edit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)

        Txt_Product_Type_Name.Text = ""
        Txt_Product_Type_Description.Text = ""

        If Not ID = 0 Then
            'Old Record
            Dim productTable As DataRow = ReadQueryOut($"SELECT * FROM ProductType WHERE id = {ID}").Rows(0)
            Txt_Product_Type_Name.Text = productTable.Item("name")
            Txt_Product_Type_Description.Text = productTable.Item("description")
        End If
    End Sub
End Class