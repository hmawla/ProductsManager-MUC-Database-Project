Imports MaterialSkin

Public Class Frm_PartsController


    Private Sub Btn_Parts_Add_Click(sender As Object, e As EventArgs) Handles Btn_Parts_Add.Click
        Frm_Part_Add_Edit.ShowDialog(0)
        RefreshData()
    End Sub

    Private Sub Btn_Parts_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Parts_Edit.Click
        Try
            Frm_Part_Add_Edit.ShowDialog(Integer.Parse(DGV_Parts.SelectedRows(0).Cells(0).Value.ToString))
            RefreshData()
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("No rows selected!")
        End Try
    End Sub

    Private Sub Btn_Parts_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Parts_Delete.Click
        Try
            ExecuteQuery($"UPDATE Part SET is_deleted = 1 WHERE id = {Integer.Parse(DGV_Parts.SelectedRows(0).Cells(0).Value.ToString)}")
            RefreshData()
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("No rows selected!")
        End Try
    End Sub

    Private Sub Frm_PartsController_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
        RefreshData()
    End Sub

    Private Sub RefreshData()
        FillDGV(DGV_Parts, "SELECT id, name, description, cost_price, available_qty FROM Part WHERE is_deleted = 0")
    End Sub
End Class