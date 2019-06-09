Imports MaterialSkin

Public Class Frm_Main


    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
        InitCon()
    End Sub

    Private Sub Btn_Product_Type_Manage_Click(sender As Object, e As EventArgs) Handles Btn_Product_Types_Manage.Click
        Frm_ProductTypesController.ShowDialog()
    End Sub

    Private Sub Btn_Products_Manage_Click(sender As Object, e As EventArgs) Handles Btn_Products_Manage.Click
        Frm_ProductsController.ShowDialog()
    End Sub

    Private Sub Btn_Customers_Manage_Click(sender As Object, e As EventArgs) Handles Btn_Customers_Manage.Click
        Frm_CustomersController.ShowDialog()
    End Sub

    Private Sub Btn_Parts_Manage_Click(sender As Object, e As EventArgs) Handles Btn_Parts_Manage.Click
        Frm_PartsController.ShowDialog()
    End Sub

    Private Sub Btn_Manufacure_Go_Click(sender As Object, e As EventArgs) Handles Btn_Manufacure_Go.Click
        MessageBox.Show("Sorry this is planned for another project!")
    End Sub

    Private Sub Btn_Sell_Go_Click(sender As Object, e As EventArgs) Handles Btn_Sell_Go.Click
        Frm_TransactionController.ShowDialog()
    End Sub
End Class