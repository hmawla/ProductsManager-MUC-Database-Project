Imports MaterialSkin

Public Class Frm_CustomersController

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
        RefreshData()
    End Sub
    Private Sub Btn_Customers_Add_Click(sender As Object, e As EventArgs) Handles Btn_Customers_Add.Click
        Frm_Customer_Add_Edit.ShowDialog(0)
        RefreshData()
    End Sub

    Private Sub Btn_Customers_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Customers_Edit.Click
        Try
            Frm_Customer_Add_Edit.ShowDialog(Integer.Parse(DGV_Customers.SelectedRows(0).Cells(0).Value.ToString))
            RefreshData()
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("No rows selected!")
        End Try
    End Sub

    Private Sub Btn_Customers_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Customers_Delete.Click
        Try
            ExecuteQuery($"UPDATE Customer SET is_deleted = 1 WHERE id = {Integer.Parse(DGV_Customers.SelectedRows(0).Cells(0).Value.ToString)}")
            RefreshData()
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("No rows selected!")
        End Try
    End Sub

    Private Sub RefreshData()
        FillDGV(DGV_Customers, "SELECT id, name, contact_phone, other_phone FROM Customer WHERE is_deleted = 0")
    End Sub
End Class