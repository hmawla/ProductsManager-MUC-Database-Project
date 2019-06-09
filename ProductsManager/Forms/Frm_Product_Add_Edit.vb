Imports MaterialSkin

Public Class Frm_Product_Add_Edit
    Dim ID As Integer = 0
    Dim compositionParts As List(Of Part)
    Dim compositionProduct As List(Of Part)


    Public Overloads Sub ShowDialog(ByVal ID As Integer)
        Me.ID = ID
        Me.ShowDialog()
    End Sub

    Private Sub Btn_Composition_Part_Add_Click(sender As Object, e As EventArgs) Handles Btn_Composition_Part_Add.Click
        If Not CBox_Compostition_Part.SelectedValue = 0 Then
            For Each row As Part In compositionParts
                If row.ID = CBox_Compostition_Part.SelectedValue Then
                    MessageBox.Show("Already Exist!")
                    Return
                End If
            Next
            Dim part As New Part(CBox_Compostition_Part.SelectedValue, CBox_Compostition_Part.Text, Nbr_Composition_Part_Qty.Value)
            compositionParts.Add(part)
            DGV_Composition_Parts.Rows.Add({part.ID, part.Name, part.Qty})
        End If
    End Sub

    Private Sub Btn_Composition_Product_Add_Click(sender As Object, e As EventArgs) Handles Btn_Composition_Product_Add.Click
        If Not CBox_Composition_Product.SelectedValue = 0 Then
            For Each row As Part In compositionProduct
                If row.ID = CBox_Composition_Product.SelectedValue Then
                    MessageBox.Show("Already Exist!")
                    Return
                End If
            Next
            Dim part As New Part(CBox_Composition_Product.SelectedValue, CBox_Composition_Product.Text, Nbr_Composition_Product_Qty.Value)
            compositionProduct.Add(part)
            DGV_Composition_Products.Rows.Add({part.ID, part.Name, part.Qty})
        End If

    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        If ID = 0 Then
            If Txt_Product_name.Text.Length > 0 And Txt_Product_Description.Text.Length > 0 And CBox_Product_Type.Text.Length > 0 Then
                Dim name As String = Txt_Product_name.Text
                Dim description As String = Txt_Product_Description.Text
                Dim cost As Double = Nbr_Product_Cost.Value
                Dim price As Double = Nbr_Product_Price.Value
                Dim type As Integer = CBox_Product_Type.SelectedValue
                Dim ttm As Double = Nbr_Time_To_Manufacture.Value
                Dim qty As Double = Nbr_Product_Qty.Value

                ExecuteQuery($"INSERT INTO Product(name, description, cost_price, sell_price, product_type_id, unit_manufacture_time, available_qty) VALUES('{name}', '{description}', {cost}, {price}, {type}, {ttm}, {qty})")
                Dim inserted_id As Integer = ReadQueryOut("SELECT @@Identity").Rows(0).Item(0)

                If compositionParts.Count > 0 Then
                    For Each part As Part In compositionParts

                        ExecuteQuery($"INSERT INTO ManufactureParts VALUES({inserted_id}, {part.ID}, {part.Qty})")
                    Next
                End If

                If compositionProduct.Count > 0 Then
                    For Each part As Part In compositionProduct

                        ExecuteQuery($"INSERT INTO ManufactureComposite VALUES({inserted_id}, {part.ID}, {part.Qty})")
                    Next
                End If
                Me.Close()
            Else
                MessageBox.Show("Please fill all needed data!")
            End If
        Else
            If Txt_Product_name.Text.Length > 0 And Txt_Product_Description.Text.Length > 0 And CBox_Product_Type.Text.Length > 0 Then
                Dim name As String = Txt_Product_name.Text
                Dim description As String = Txt_Product_Description.Text
                Dim cost As Double = Nbr_Product_Cost.Value
                Dim price As Double = Nbr_Product_Price.Value
                Dim type As Integer = CBox_Product_Type.SelectedValue
                Dim ttm As Double = Nbr_Time_To_Manufacture.Value
                Dim qty As Double = Nbr_Product_Qty.Value

                ExecuteQuery($"UPDATE Product SET name = '{name}', description = '{description}', cost_price = {cost}, sell_price = {price}, product_type_id = {type}, unit_manufacture_time = {ttm}, available_qty = {qty}, date_updated = date() WHERE id = {ID}")

                If compositionParts.Count > 0 Then
                    ExecuteQuery($"DELETE FROM ManufactureParts WHERE product_id = {ID}")
                    For Each part As Part In compositionParts

                        ExecuteQuery($"INSERT INTO ManufactureParts VALUES({ID}, {part.ID}, {part.Qty})")
                    Next
                End If

                If compositionProduct.Count > 0 Then
                    ExecuteQuery($"DELETE FROM ManufactureComposite WHERE product_id = {ID}")
                    For Each part As Part In compositionProduct

                        ExecuteQuery($"INSERT INTO ManufactureComposite VALUES({ID}, {part.ID}, {part.Qty})")
                    Next
                End If
                Me.Close()
            Else
                MessageBox.Show("Please fill all needed data!")
            End If
        End If

    End Sub

    Private Sub Frm_Product_Add_Edit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)

        compositionParts = New List(Of Part)
        compositionProduct = New List(Of Part)

        FillCBox(CBox_Product_Type, "SELECT id, name FROM ProductType WHERE is_deleted = 0", "id", "name")
        FillCBox(CBox_Compostition_Part, "SELECT id, name FROM Part WHERE is_deleted = 0", "id", "name")
        FillCBox(CBox_Composition_Product, "SELECT id, name FROM Product WHERE is_deleted = 0", "id", "name")

        Txt_Product_name.ResetText()
        Txt_Product_Description.ResetText()
        Nbr_Product_Cost.Value = Nbr_Product_Cost.Minimum
        Nbr_Product_Price.Value = Nbr_Product_Price.Minimum
        Nbr_Time_To_Manufacture.Value = Nbr_Time_To_Manufacture.Minimum
        Nbr_Product_Qty.Value = Nbr_Product_Qty.Minimum
        DGV_Composition_Parts.Rows.Clear()
        DGV_Composition_Products.Rows.Clear()


        If Not ID = 0 Then
            'Old Record
            Dim productTable As DataRow = ReadQueryOut($"SELECT * FROM Product WHERE id = {ID}").Rows(0)
            Txt_Product_name.Text = productTable.Item("name")
            Txt_Product_Description.Text = productTable.Item("description")
            Nbr_Product_Cost.Value = productTable.Item("cost_price")
            Nbr_Product_Price.Value = productTable.Item("sell_price")
            Try
                CBox_Product_Type.SelectedValue = productTable.Item("product_type_id")
            Catch ex As Exception
                CBox_Product_Type.SelectedValue = 0
            End Try
            Nbr_Time_To_Manufacture.Value = productTable.Item("unit_manufacture_time")
            Nbr_Product_Qty.Value = productTable.Item("available_qty")

            Dim parts As DataTable = ReadQueryOut($"SELECT Part.id, Part.name, ManufactureParts.qty FROM Product INNER JOIN (Part INNER JOIN ManufactureParts ON Part.id = ManufactureParts.part_id) ON Product.id = ManufactureParts.product_id WHERE Product.id={ID}")
            If parts.Rows.Count > 0 Then
                'Fill Listbox
                For Each row As DataRow In parts.Rows
                    Dim part As New Part(row.Item("id"), row.Item("name"), row.Item("qty"))
                    compositionParts.Add(part)
                    DGV_Composition_Parts.Rows.Add({part.ID, part.Name, part.Qty})
                Next
            End If

            Dim composite_products As DataTable = ReadQueryOut($"SELECT Product_1.id, Product_1.name, ManufactureComposite.qty FROM (Product INNER JOIN ManufactureComposite ON Product.id = ManufactureComposite.product_id) INNER JOIN Product AS Product_1 ON ManufactureComposite.composite_product_id = Product_1.id WHERE Product.id={ID};")
            If composite_products.Rows.Count > 0 Then
                'Fill Listbox
                For Each row As DataRow In composite_products.Rows
                    Dim part As New Part(row.Item("id"), row.Item("name"), row.Item("qty"))
                    compositionProduct.Add(part)
                    DGV_Composition_Products.Rows.Add({part.ID, part.Name, part.Qty})

                Next
            End If
        End If
    End Sub

    Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedToolStripMenuItem.Click
        If DGV_Composition_Parts.Rows.Count > 0 Then
            For Each part As Part In compositionParts
                If part.ID = DGV_Composition_Parts.SelectedRows(0).Cells(0).Value Then
                    compositionParts.Remove(part)
                    Exit For
                End If
            Next
            DGV_Composition_Parts.Rows.Remove(DGV_Composition_Parts.SelectedRows(0))
        Else
            MessageBox.Show("Select a row!")
        End If

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If DGV_Composition_Products.Rows.Count > 0 Then
            For Each part As Part In compositionProduct
                If part.ID = DGV_Composition_Products.SelectedRows(0).Cells(0).Value Then
                    compositionProduct.Remove(part)
                    Exit For
                End If
            Next
            DGV_Composition_Products.Rows.Remove(DGV_Composition_Products.SelectedRows(0))
        Else
            MessageBox.Show("Select a row!")
        End If
    End Sub
End Class