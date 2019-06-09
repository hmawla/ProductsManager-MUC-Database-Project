Imports MaterialSkin

Public Class Frm_TransactionController
    Dim Products As List(Of Product)
    Dim InsertedProducts As List(Of Product)
    Private Sub Frm_TransactionController_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)
        RefreshData()
    End Sub

    Private Sub RefreshData()
        FillCBox(CBox_Customers, "SELECT id, name FROM Customer WHERE is_deleted = false", "id", "name")
        Products = ReadQueryOut("SELECT id, name, available_qty, sell_price FROM Product WHERE is_deleted = false AND available_qty > 0").Rows.Cast(Of DataRow).Select(Function(dr) New Product(dr(0), dr(1), dr(2), dr(3))).ToList()
        CBox_Products.DataSource = Products
        CBox_Products.ValueMember = "id"
        CBox_Products.DisplayMember = "name"
        DGV_Products.DataSource = New List(Of Product)
        InsertedProducts = New List(Of Product)
        FillDGV(DGV_Transactions, "SELECT SellTransaction.id AS [Trans#], customer_id AS [Customer#], name AS Customer, date_created AS [Date] FROM SellTransaction INNER JOIN Customer ON SellTransaction.customer_id = Customer.id")
    End Sub

    Private Sub CBox_Products_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBox_Products.SelectedValueChanged
        Nbr_Product_Qty.Value = Nbr_Product_Qty.Minimum
        Nbr_Product_Qty.Maximum = CType(CBox_Products.SelectedItem, Product).QTY
    End Sub

    Private Sub Btn_Product_Add_Click(sender As Object, e As EventArgs) Handles Btn_Product_Add.Click
        If Not CBox_Products.SelectedValue = 0 Then
            If InsertedProducts.Contains(CBox_Products.SelectedItem) Then
                MessageBox.Show("Already Exist!")
            Else
                CType(CBox_Products.SelectedItem, Product).REQUESTED_QTY = Nbr_Product_Qty.Value
                InsertedProducts.Add(CBox_Products.SelectedItem)
                DGV_Products.DataSource = New List(Of Product)
                DGV_Products.DataSource = InsertedProducts
            End If
        End If
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        If InsertedProducts.Count > 0 Then
            Dim CustomerId = CBox_Customers.SelectedValue
            ExecuteQuery($"INSERT INTO SellTransaction(customer_id) VALUES({CustomerId})")
            Dim inserted_id As Integer = ReadQueryOut("SELECT @@Identity").Rows(0).Item(0)

            For Each product As Product In InsertedProducts
                ExecuteQuery($"INSERT INTO ProductsInTransaction VALUES({inserted_id},{product.ID},{product.SELL_PRICE},{product.REQUESTED_QTY})")
                ExecuteQuery($"UPDATE Product SET available_qty = available_qty - {product.REQUESTED_QTY} WHERE id = {product.ID}")
            Next
            RefreshData()
        Else
            MessageBox.Show("Add at least one product!")
        End If
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If DGV_Products.Rows.Count > 0 Then
            InsertedProducts.Remove(CBox_Products.SelectedItem)
            DGV_Products.DataSource = New List(Of Product)
            DGV_Products.DataSource = InsertedProducts
        Else
            MessageBox.Show("Select a row!")
        End If

    End Sub
End Class