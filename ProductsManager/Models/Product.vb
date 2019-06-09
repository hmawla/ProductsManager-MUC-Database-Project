Public Class Product

    Public Property ID As Integer
    Public Property NAME As String
    Public Property QTY As Double
    Public Property SELL_PRICE As Double
    Public Property REQUESTED_QTY As Double

    Public Sub New(iD As Integer, nAME As String, qTY As Double, sELL_PRICE As Double)
        Me.ID = iD
        Me.NAME = nAME
        Me.QTY = qTY
        Me.SELL_PRICE = sELL_PRICE
        Me.REQUESTED_QTY = 0
    End Sub
End Class
