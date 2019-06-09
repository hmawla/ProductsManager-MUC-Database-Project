Imports MaterialSkin

Public Class Frm_ProductTypesController

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
        RefreshData()
    End Sub

    Private Sub Btn_Products_Type_Add_Click(sender As Object, e As EventArgs) Handles Btn_Products_Type_Add.Click

        Frm_Product_Type_Add_Edit.ShowDialog(0)
        RefreshData()
    End Sub

    Private Sub Btn_Product_Type_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Product_Type_Edit.Click
        Try
            Frm_Product_Type_Add_Edit.ShowDialog(Integer.Parse(DGV_Product_Types.SelectedRows(0).Cells(0).Value.ToString))
            RefreshData()
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("No rows selected!")
        End Try

    End Sub

    Private Sub Btn_Product_Type_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Product_Type_Delete.Click
        Try
            ExecuteQuery($"UPDATE ProductType SET is_deleted = 1 WHERE id = {Integer.Parse(DGV_Product_Types.SelectedRows(0).Cells(0).Value.ToString)}")
            RefreshData()
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("No rows selected!")
        End Try

    End Sub

    Private Sub RefreshData()
        FillDGV(DGV_Product_Types, "SELECT id, name, description FROM ProductType WHERE is_deleted = 0")
    End Sub
End Class