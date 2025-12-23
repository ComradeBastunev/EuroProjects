Imports System.Data.SqlClient

Public Class ReportInvoice
    Private SumTotal As Decimal
    Private SumTotalEur As Decimal
    Private SumNoDiscEur As Decimal
    Private ir As DataSet1.Get_InvoiceRow


    Private Sub ReportInvoice_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint

        Try
            Dim PrinterName1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Boiko Dimitrov\Information System", "InvPrinter", "")
            Dim SelPrinter As String = PrinterName
            For Each printer1 In System.Drawing.Printing.PrinterSettings.InstalledPrinters
                If printer1.ToString.Contains(PrinterName1.ToString) Then SelPrinter = printer1.ToString
            Next
            PrinterName = SelPrinter
        Catch ex As Exception
        End Try


        Invoices_PaymentsTableAdapter1.Connection.ConnectionString = gConnStr
        Invoices_PaymentsTableAdapter1.Fill(DataSet11.Invoices_Payments, CDec(gInv_No))
        If DataSet11.Invoices_Payments.Count = 0 Then
            XrSubreport1.Visible = False
            ReportFooter.HeightF = XrTableReportFooter.HeightF
        End If
        Get_InvoiceTableAdapter1.Connection.ConnectionString = gConnStr
        Get_InvoiceTableAdapter1.Fill(DataSet11.Get_Invoice, CDec(gInv_No), gTransl)
        ir = DataSet11.Get_Invoice.ToList.First


        If Not gTransl Then XrTableCellSlov.Text = "Словом: " + Slov(DataSet11.Get_Invoice.ToList.First.Summ_Local)

        ZInvoice_Rows_PrintTableAdapter1.Connection.ConnectionString = gConnStr
        ZInvoice_Rows_PrintTableAdapter1.Fill(DataSet11.zInvoice_Rows_Print, CDec(gInv_No), gOrderType, gShort, True, True)

        SumNoDiscEur = Math.Round(DataSet11.zInvoice_Rows_Print.ToList.Sum(Function(f) f.PRICE_LOCAL * f.QUANT / 1.95583), 2)

        SummaryTableAdapter1.Connection.ConnectionString = gConnStr
        SummaryTableAdapter1.Fill(DataSet11.SUMMARY)

        If gTransl Then
            Summary_TranscrTableAdapter1.Connection.ConnectionString = gConnStr
            Summary_TranscrTableAdapter1.Fill(DataSet11.Summary_Transcr)
            XrTableCellCipherLabel.Text = "Employee Cipher:"
            XrTableCellClientEIKLabel.Text = "Ident.No:"
            XrTableCellClientLabel.Text = "Customer:"
            XrTableCellClientReprLabel.Text = "Representative:"
            XrTableCellClientVATNoLabel.Text = "VAT No:"
            XrTableCellCodeLabel.Text = "Code"
            XrTableCellConsigneeLabel.Text = "Consignee:"
            XrTableCellDescrLabel.Text = "Description"
            XrTableCellDiscPercLabel.Text = "Discount %"
            XrTableCellDiscSumLabel.Text = "Disount"
            XrTableCellDiscTotalLabel.Text = "Discount:"
            XrTableCellInvDateLabel.Text = "Date:"
            XrTableCellInvFooter.Text = "[Get_Invoice.Inv_Type_Transcr] [Get_Invoice.Inv_No!0000000000] / [Get_Invoice.Inv_Date!dd.MM.yyyy]"
            XrTableCellInvType.Text = "[Get_Invoice.Inv_Type_Transcr] [Get_Invoice.PrintedName]"
            XrTableCellModelLabel.Text = "Model:"
            XrTableCellNoLabel.Text = "No"
            XrTableCellNoSignTextLabel.Text = "According to art.7(1) Accounting Law,art.114 VAT Law and art.78 Regulations for the implementation of the VAT law, stamp is not obligatory for invoices and identification ciphers replace signatures."
            XrTableCellOrderNoLabel.Text = "Order No:"
            XrTableCellPaymTLabel.Text = "Payment Type:"
            XrTableCellPlaceLabel.Text = "Place:"
            XrTableCellPlaceLabel1.Text = "Place:"
            XrTableCellPlateNrLabel.Text = "Plate No:"
            XrTableCellPlateNrLabel1.Text = "Plate No:"
            XrTableCellPreparedLabel.Text = "Prepared by:"
            XrTableCellPriceLabel.Text = "Price EUR"
            XrTableCellQTYPLabel.Text = "Unit"
            XrTableCellQuantLabel.Text = "Qty"
            XrTableCellRefNoLabel.Text = "Ref No:"
            XrTableCellRespLabel.Text = "Responsible:"
            XrTableCellSignatureLabel1.Text = "Signature:................................"
            XrTableCellSignatureLabel2.Text = "Signature:................................"
            XrTableCellSlov.Text = Slov(0)
            XrTableCellSumNoDiscLabel.Text = "Amount without discount EUR:"
            XrTableCellSumRowLabel.Text = "Amount EUR"
            XrTableCellSuppBankLabel.Text = "Bank:"
            XrTableCellSuppBICLabel.Text = "BIC:"
            XrTableCellSuppEIKLabel.Text = "Ident. No:"
            XrTableCellSuppIBANLabel.Text = "IBAN:"
            XrTableCellSuppLabel.Text = "Supplier:"
            XrTableCellSuppPhoneLabel.Text = "Phone:"
            XrTableCellSuppReprLabel.Text = "Representative:"
            XrTableCellSUPPVatNoLabel.Text = "VAT No:"
            XrTableCellTaxDateLabel.Text = "Tax Date:"
            XrTableCellToInvNo.Text = "Prior invoice No [Get_Invoice.Prev_Inv_No]/[Get_Invoice.Prev_Inv_Date!dd.MM.yyyy]"
            XrTableCellTotalLabel.Text = "Total EUR:"
            XrTableCellVATBaseLabel.Text = "Base VAT EUR:"
            XrTableCellVATPercLabel.Text = "VAT %:"
            XrTableCellVATSummLabel.Text = "VAT Amount EUR:"
            XrTableCellVinLabel.Text = "Vin Nr:"
            XrTableCellReasonNullVATLabel.Text = "VAT Subject:"

            XrTableCellDescription.Text = "[DESCRIPTION_Transl]"
            XrTableCellQtyp.Text = "[QTYP_Transl]"


            XrTableCellSuppFirm.DataBindings.Clear()
            XrTableCellSuppFirm.DataBindings.Add("Text", DataSet11, "Summary_Transcr.FIRM")

            XrTableCellSuppAddress1.DataBindings.Clear()
            XrTableCellSuppAddress1.DataBindings.Add("Text", DataSet11, "Summary_Transcr.ADDRESS1")

            XrTableCellSuppCity.DataBindings.Clear()
            XrTableCellSuppCity.Text = "[Summary_Transcr.POSTAL_CODE] [Summary_Transcr.CITY]"

            XrLabelSuppAddressHeader.DataBindings.Clear()
            XrLabelSuppAddressHeader.Text = "[Summary_Transcr.CITY], [Summary_Transcr.ADDRESS1], [Summary_Transcr.POSTAL_CODE], [Summary_Transcr.ADDRESS2], Phone: [Summary_Transcr.PHONE], email: [Summary_Transcr.EMAIL]"

            XrLabelSuppFirmHeader.DataBindings.Clear()
            XrLabelSuppFirmHeader.Text = "[Summary_Transcr.FIRM]"

            XrTableCellPrice.DataBindings.Clear()
            XrTableCellPrice.Text = "[zInvoice_Rows_Print.PRICE_EUR!0.00; ; ]"

            XrTableCellAmountDisc.DataBindings.Clear()
            XrTableCellAmountDisc.Text = "[zInvoice_Rows_Print.SumDiscount_EUR!0.00; ; ]"


            XrTableCellAmountNoDisc.DataBindings.Clear()
            'XrTableCellAmountNoDisc.DataBindings.Add("Text", DataSet11, "zInvoice_Rows_Print.SumNoDiscount_EUR")
            'XrTableCellAmountNoDisc.Summary.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            'XrTableCellAmountNoDisc.Summary.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
            'XrTableCellAmountNoDisc.Summary.FormatString = "{0:0.00}"

            XrTableCellBaseVAT.DataBindings.Clear()
            XrTableCellDiscount.DataBindings.Clear()
            XrTableCellVATSumm.DataBindings.Clear()
            XrTableCellTotal.DataBindings.Clear()


        End If



    End Sub

    Private Sub ReportInvoice_AfterPrint(sender As Object, e As EventArgs) Handles MyBase.AfterPrint
        Dim PubsConn As SqlConnection = New SqlConnection(gConnStr)
        Dim testCMD As SqlCommand = New SqlCommand("Set_Inv_Printed", PubsConn)
        testCMD.CommandType = CommandType.StoredProcedure
        Dim aInvNo As SqlParameter = testCMD.Parameters.Add("@Inv_No", SqlDbType.Decimal, 10)
        aInvNo.Direction = ParameterDirection.Input
        aInvNo.Value = gInv_No
        PubsConn.Open()
        Dim rvRows As Integer = testCMD.ExecuteNonQuery

    End Sub

    Private Sub ReportHeader2_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles ReportHeader2.BeforePrint
        If SumTotal = 0 Then
            SumTotal = ir.Sum_Local
            SumTotalEur = CDec(CDbl(ir.Sum_Local) / 1.95583)
        End If

    End Sub

    Private Sub XrTableCellAmount_EvaluateBinding(sender As Object, e As DevExpress.XtraReports.UI.BindingEventArgs) Handles XrTableCellAmount.EvaluateBinding
        Dim TmpSum As Decimal = 0
        Dim CurrSum As Decimal = 0

        If Not gTransl Then Exit Sub

        CurrSum = e.Value
        If SumTotal = 0 Then
            TmpSum = 0
        Else
            TmpSum = Math.Round(CurrSum / SumTotal * SumTotalEur, 2)
            SumTotal = SumTotal - CurrSum
            SumTotalEur = SumTotalEur - TmpSum
            If (Math.Round(SumTotal, 2) = 0) And (Math.Round(SumTotalEur, 2) <> 0) Then TmpSum = TmpSum + SumTotalEur
        End If
        e.Value = TmpSum
    End Sub

    Private Sub XrTableCellAmountNoDisc_EvaluateBinding(sender As Object, e As DevExpress.XtraReports.UI.BindingEventArgs) Handles XrTableCellAmountNoDisc.EvaluateBinding

    End Sub

    Private Sub ReportFooter_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles ReportFooter.BeforePrint
        Dim SummTotal As Decimal
        Dim VATSumm As Decimal
        Dim BaseVAT As Decimal
        Dim Discount As Decimal

        If Not gTransl Then Exit Sub

        XrTableCellDiscount.DataBindings.Clear()
        XrTableCellDiscount.Summary.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        XrTableCellAmountNoDisc.Summary.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        SummTotal = Math.Round(ir.Summ_Local / 1.95583, 2)
        BaseVAT = Math.Round(ir.Sum_Local / 1.95583, 2)
        VATSumm = SummTotal - BaseVAT
        Discount = SumNoDiscEur - BaseVAT
        XrTableCellAmountNoDisc.Text = FormatNumber(SumNoDiscEur, 2, TriState.True, TriState.False, TriState.False)
        XrTableCellBaseVAT.Text = FormatNumber(BaseVAT, 2, TriState.True, TriState.False, TriState.False)
        XrTableCellDiscount.Text = FormatNumber(Discount, 2, TriState.True, TriState.False, TriState.False)
        XrTableCellVATSumm.Text = FormatNumber(VATSumm, 2, TriState.True, TriState.False, TriState.False)
        XrTableCellTotal.Text = FormatNumber(SummTotal, 2, TriState.True, TriState.False, TriState.False)
    End Sub
End Class