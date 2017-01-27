Module Module1
    Public frmTitle As New frmTitleScreen
    Public frmZalgo As New frmZalgoHunt
    Public frmShop As New frmShoppe
    Public attempts As Integer
    Public souls As Integer = 10
    Public random As New Random
    Public munitions As Integer = 5
    Public reload As Decimal = 5
    Public slain As Integer = 100
    Public shootOrNah As Boolean = False
    Public countdown As Integer = 60
    Public shopMunitions As Integer
    Public shopTime As Integer
    Public totalMunitions As Integer = (munitions + shopMunitions)
    Public totalTime As Integer = (countdown + shopTime)
    Public shopPrice As Integer
End Module
