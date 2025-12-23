
Public Class Report_Order_Jobs
    Private Sub Report_Order_Jobs_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        OrderS_PTableAdapter1.Connection.ConnectionString = gConnStr
        OrderS_PTableAdapter1.FillJobs(DataSet11.ORDERS_P, CDec(gService), CDec(gOrderNo), CDec(gSplit))
    End Sub
End Class