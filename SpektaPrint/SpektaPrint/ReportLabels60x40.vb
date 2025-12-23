Public Class ReportLabels60x40
    Private Sub ReportLabels60x40_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        ZPrintLabelsTableAdapter1.Connection.ConnectionString = gConnStr
        ZPrintLabelsTableAdapter1.Fill(DataSet11.zPrintLabels)

    End Sub
End Class