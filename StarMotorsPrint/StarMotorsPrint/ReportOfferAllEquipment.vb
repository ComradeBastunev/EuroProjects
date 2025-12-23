Public Class ReportOfferAllEquipment
    Private Sub ReportOfferAllEquipment_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        ZReportOfferAllOptionsTableAdapter1.Connection.ConnectionString = gConnStr
        ZReportOfferAllOptionsTableAdapter1.Fill(DataSet11.zReportOfferAllOptions, gOfferN)
    End Sub

    Private Sub XrPictureBox1_EvaluateBinding(sender As Object, e As DevExpress.XtraReports.UI.BindingEventArgs) Handles XrPictureBox1.EvaluateBinding
        Try
            Dim Image As Byte() = e.Value
            Image = DecompressGZip(Image)
            e.Value = Image
        Catch ex As Exception
        End Try
    End Sub
End Class