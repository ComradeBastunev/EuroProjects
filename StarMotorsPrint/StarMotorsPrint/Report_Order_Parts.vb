Public Class Report_Order_Parts
    Private Sub Report_Order_Parts_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        OrderS_PTableAdapter1.Connection.ConnectionString = gConnStr
        OrderS_PTableAdapter1.FillParts(DataSet11.ORDERS_P, CDec(gService), CDec(gOrderNo), CDec(gSplit))
    End Sub
End Class