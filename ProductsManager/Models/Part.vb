Public Class Part
    Public Property ID As String
    Public Property Name As String
    Public Property Qty As Double

    Public Sub New(iD As String, name As String, qty As Double)
        Me.ID = iD
        Me.Name = name
        Me.Qty = qty
    End Sub
End Class
