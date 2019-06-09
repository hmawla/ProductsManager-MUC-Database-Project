Imports MaterialSkin

Public Class Frm_Part_Add_Edit
    Dim ID As Integer = 0

    Public Overloads Sub ShowDialog(ByVal ID As Integer)
        Me.ID = ID
        ShowDialog()
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        If ID = 0 Then
            'New Record
            If Txt_Part_Name.Text.Length > 0 AndAlso Txt_Part_Description.Text.Length > 0 Then
                Dim name As String = Txt_Part_Name.Text
                Dim description As String = Txt_Part_Description.Text
                Dim costPrice As String = Nbr_Part_Cost.Value
                Dim qty As String = Nbr_Part_Qty.Value

                ExecuteQuery($"INSERT INTO Part(name, description, cost_price, available_qty) VALUES('{name}', '{description}', {costPrice}, {qty})")
                Close()
            Else
                MessageBox.Show("Please fill all information!")
            End If
        Else
            'Old Record
            If Txt_Part_Name.Text.Length > 0 AndAlso Txt_Part_Description.Text.Length > 0 Then
                Dim name As String = Txt_Part_Name.Text
                Dim description As String = Txt_Part_Description.Text
                Dim costPrice As String = Nbr_Part_Cost.Value
                Dim qty As String = Nbr_Part_Qty.Value

                ExecuteQuery($"UPDATE Part SET name = '{name}', description = '{description}', cost_price = {costPrice}, available_qty = {qty} WHERE id = {ID}")
                Close()
            Else
                MessageBox.Show("Please fill all information!")
            End If
        End If
    End Sub

    Private Sub Frm_Part_Add_Edit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)

        Txt_Part_Name.ResetText()
        Txt_Part_Description.ResetText()
        Nbr_Part_Cost.Value = Nbr_Part_Cost.Minimum
        Nbr_Part_Qty.Value = Nbr_Part_Qty.Minimum

        If Not ID = 0 Then
            Dim part As DataRow = ReadQueryOut($"SELECT * FROM Part WHERE id = {ID}").Rows(0)
            Txt_Part_Name.Text = part.Item("name")
            Txt_Part_Description.Text = part.Item("description")
            Nbr_Part_Cost.Value = part.Item("cost_price")
            Nbr_Part_Qty.Value = part.Item("available_qty")
        End If
    End Sub
End Class