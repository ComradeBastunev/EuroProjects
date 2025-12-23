Public Class GDPRAvtoSpektar
    Private Sub GDPRAvtoSpektar_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        ZOrder_JobsTableAdapter1.Connection.ConnectionString = gConnStr
        ZOrder_JobsTableAdapter1.Fill(DataSet11.zOrder_Jobs, CDec(gService), CDec(gOrderNo), CDec(gSplit))
    End Sub
End Class