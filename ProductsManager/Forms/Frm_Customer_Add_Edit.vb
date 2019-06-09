Imports MaterialSkin

Public Class Frm_Customer_Add_Edit
    Dim ID As Integer = 0

    Public Overloads Sub ShowDialog(ByVal ID As Integer)
        Me.ID = ID
        ShowDialog()
    End Sub

    Private Sub Frm_Customer_Add_Edit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE)

        Txt_Customer_Name.Text = ""
        Dim sMask As String = Txt_Contact_Phone.Mask
        Txt_Contact_Phone.Mask = ""
        Txt_Contact_Phone.Text = ""
        Txt_Contact_Phone.Mask = sMask

        sMask = Txt_Other_Phone.Mask
        Txt_Other_Phone.Mask = ""
        Txt_Other_Phone.Text = ""
        Txt_Other_Phone.Mask = sMask

        If Not ID = 0 Then
            Dim customer As DataRow = ReadQueryOut($"SELECT * FROM Customer WHERE id = {ID}").Rows(0)
            Txt_Customer_Name.Text = customer.Item("name")
            Dim contactPhone As String = customer.Item("contact_phone")
            Txt_Contact_Phone.Text = contactPhone

            Try
                Dim otherPhone As String = customer.Item("other_phone")
                Txt_Other_Phone.Text = otherPhone
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        If ID = 0 Then
            'New Record
            If Txt_Customer_Name.Text.Length > 0 And Txt_Contact_Phone.Text.Length = 12 Then
                Dim name As String = Txt_Customer_Name.Text
                Dim contactPhone As String = Txt_Contact_Phone.Text
                Dim otherPhone As String = If(Txt_Other_Phone.Text.Length = 12, Txt_Other_Phone.Text, "")
                MessageBox.Show(otherPhone)

                If otherPhone.Length > 0 Then
                    ExecuteQuery($"INSERT INTO Customer(name, contact_phone, other_phone) VALUES('{name}', '{contactPhone}', '{otherPhone}')")

                Else
                    ExecuteQuery($"INSERT INTO Customer(name, contact_phone) VALUES('{name}', '{contactPhone}')")

                End If
                Close()
            Else
                MessageBox.Show("Please fill all required data!")
            End If
        Else
            'Old Record
            If Txt_Customer_Name.Text.Length > 0 And Txt_Contact_Phone.Text.Length = 12 Then
                Dim name As String = Txt_Customer_Name.Text
                Dim contactPhone As String = Txt_Contact_Phone.Text
                Dim otherPhone As String = If(Txt_Other_Phone.Text.Length = 12, Txt_Other_Phone.Text, "")

                If otherPhone.Length > 0 Then
                    ExecuteQuery($"UPDATE Customer SET name = '{name}', contact_phone = '{contactPhone}', other_phone = '{otherPhone}' WHERE id = {ID}")

                Else
                    ExecuteQuery($"UPDATE Customer SET name = '{name}', contact_phone = '{contactPhone}', other_phone = NULL WHERE id = {ID}")

                End If
                Close()
            Else
                MessageBox.Show("Please fill all required data!")
            End If
        End If
    End Sub
End Class