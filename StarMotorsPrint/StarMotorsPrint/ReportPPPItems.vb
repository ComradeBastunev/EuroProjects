Public Class ReportPPPItems
    Private Sub ReportPPPItems_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Cars_Det_ItemsTableAdapter1.Connection.ConnectionString = gConnStr
        Cars_Det_ItemsTableAdapter1.Fill(DataSet11.Cars_Det_Items, gCarsDetID)

    End Sub
End Class