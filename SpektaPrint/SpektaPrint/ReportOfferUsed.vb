Imports DevExpress.XtraReports.UI

Public Class ReportOfferUsed
    Private Sub ReportOfferUsed_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Rep_Offer_Print_ContractTableAdapter1.Connection.ConnectionString = gConnStr
        Rep_Offer_Print_ContractTableAdapter1.Fill(DataSet11.Rep_Offer_Print_Contract, CDec(gOfferN))

        Employees_LookupTableAdapter1.Connection.ConnectionString = gConnStr
        Employees_LookupTableAdapter1.Fill(DataSet11.Employees_Lookup, DataSet11.Rep_Offer_Print_Contract.First.PreparedBy)



        If Not DataSet11.Rep_Offer_Print_Contract.First.IsContr_TypeNull AndAlso DataSet11.Rep_Offer_Print_Contract.First.Contr_Type = 2 Then
            XrTableCellEIK.Text = "ЕИК: [FirmBulstat]"
        Else
            XrTableCellRepr.Text = " "
            XrTableCellOfferNo.Text = "ОФЕРТА S-[OfferN]"
        End If

        If DataSet11.Rep_Offer_Print_Contract.First.OfferN >= 900000 Then
            XrPictureBoxSpektaFooterImage.TopF = 0
            XrPictureBoxSpektaFooterImage.HeightF = 0
            XrPictureBoxSpektaFooterImage.Visible = False
            XrPictureBoxFooterRowImage.TopF = 0
            XrPictureBoxFooterRowImage.HeightF = 0
            XrPictureBoxFooterRowImage.Visible = False
            XrLineFooter.TopF = 0
            XrLineFooter.TopF = 0
            XrLineFooter.Visible = False
            For Each tablerow1 As XRTableRow In XrTableFooter.Rows
                tablerow1.HeightF = 0
            Next
            XrTableFooter.TopF = 0
            XrTableFooter.HeightF = 0
            XrTableFooter.Visible = False
            PageFooter.HeightF = 0.01
            SubBandFooter.Visible = True





            XrPictureBoxHeader.TopF = 0
            XrPictureBoxHeader.HeightF = 0
            XrPictureBoxHeader.Visible = False
            XrLineHeader.TopF = 0
            XrLineHeader.TopF = 0
            XrLineHeader.Visible = False
            For Each tablerow1 As XRTableRow In XrTableHeader.Rows
                tablerow1.HeightF = 0
            Next
            XrTableHeader.TopF = 0
            XrTableHeader.HeightF = 0
            XrTableHeader.Visible = False
            ReportHeader.HeightF = 0.01
            SubBandHeader.Visible = True
        End If









        SummaryTableAdapter1.Connection.ConnectionString = gConnStr
        SummaryTableAdapter1.Fill(DataSet11.SUMMARY)

        gTemplNr = DataSet11.Rep_Offer_Print_Contract.First.TemplNr

    End Sub
End Class