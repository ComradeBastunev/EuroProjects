Public Class ReportOffer
    Private Sub ReportOffer_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Rep_Offer_Print_ContractTableAdapter1.Connection.ConnectionString = gConnStr
        Rep_Offer_Print_ContractTableAdapter1.FillOfferNo(DataSet11.Rep_Offer_Print_Contract, gOfferN)
        ZGetOfferDetailsTableAdapter1.Connection.ConnectionString = gConnStr
        ZGetOfferDetailsTableAdapter1.Fill(DataSet11.zGetOfferDetails, gOfferN)
        If DataSet11.zGetOfferDetails.ToList.Count <> 0 Then
            If Not DataSet11.zGetOfferDetails.ToList.First.IsImageNull Then
                Dim Image1 = DataSet11.zGetOfferDetails.ToList.First.Image
                Try
                    Image1 = DecompressGZip(Image1)
                Catch ex As Exception
                End Try
                Dim stream1 = New System.IO.MemoryStream(Image1)
                XrPictureBox1.Image = Drawing.Image.FromStream(stream1)
            End If
        End If
    End Sub
End Class