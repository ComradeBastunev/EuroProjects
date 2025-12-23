Imports DevExpress.XtraReports.UI

Public Class ReportOrderUsed
    Private Sub XrTableCellPaymTerm_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs)
    End Sub

    Private Sub ReportOrderUsed_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        CarOrdersListTableAdapter1.Connection.ConnectionString = gConnStr
        CarOrdersListTableAdapter1.FillByCode(DataSet11.CarOrdersList, CDec(gStore), gCode)

        If Not DataSet11.CarOrdersList.First.IsContr_TypeNull AndAlso DataSet11.CarOrdersList.First.Contr_Type = 2 Then
            XrTableCellEIK.Text = "ЕИК: [VAT_NO]"
        Else
            XrTableCellRepr.Text = " "
            XrTableCellOfferNo.Text = "ПОРЪЧКА S-[ORDER_NO]"
        End If

        If DataSet11.CarOrdersList.First.Service = 33 OrElse DataSet11.CarOrdersList.First.Service = 43 Then
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

        gTemplNr = DataSet11.CarOrdersList.First.TemplNr
        SummaryTableAdapter1.Connection.ConnectionString = gConnStr
        SummaryTableAdapter1.Fill(DataSet11.SUMMARY)

        Employees_LookupTableAdapter1.Connection.ConnectionString = gConnStr
        Employees_LookupTableAdapter1.Fill(DataSet11.Employees_Lookup, DataSet11.CarOrdersList.First.Dealer_Code)

    End Sub
End Class