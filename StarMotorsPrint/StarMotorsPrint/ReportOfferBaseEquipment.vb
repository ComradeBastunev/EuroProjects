Public Class ReportOfferBaseEquipment
    Private Sub ReportOfferBaseEquipment_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        ZReportOfferBaseEquipmentTableAdapter1.Connection.ConnectionString = gConnStr
        ZReportOfferBaseEquipmentTableAdapter1.Fill(DataSet11.zReportOfferBaseEquipment, gOfferN)

    End Sub
End Class