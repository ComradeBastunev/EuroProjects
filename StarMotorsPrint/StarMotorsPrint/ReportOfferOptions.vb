Public Class ReportOfferOptions
    Private Sub ReportOfferOptions_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        ZReportOfferOptionsTableAdapter1.Connection.ConnectionString = gConnStr
        ZReportOfferOptionsTableAdapter1.Fill(DataSet11.zReportOfferOptions, gOfferN)
    End Sub
End Class