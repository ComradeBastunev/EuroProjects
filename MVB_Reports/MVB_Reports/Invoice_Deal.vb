Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Invoice_Deal

    Public SumTotal As Decimal
    Public SumTotalEur As Decimal
    Public bPrintSing As Boolean
    Public bTransl As Boolean
    Public bEUR As Boolean
    Public bAutom As Boolean
    Private ir As DataSet1.Get_InvoiceRow
    Private Sub Invoice_Deal_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            Dim PrinterName1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Boiko Dimitrov\Information System", "InvPrinter", "")
            Dim SelPrinter As String = PrinterName
            For Each printer1 In System.Drawing.Printing.PrinterSettings.InstalledPrinters
                If printer1.ToString.Contains(PrinterName1.ToString) Then SelPrinter = printer1.ToString
            Next
            PrinterName = SelPrinter
        Catch ex As Exception
        End Try
        Get_InvoiceTableAdapter.Connection.ConnectionString = gConnStr
        Dim dt = Get_InvoiceTableAdapter.GetData(CDec(gInv_No), bTransl)
        ir = dt.ToList.First
        'Засега не се показва информация за телефон и факс
        XrTableCellSuppMailWWW.Text = " "
        XrTableCellSupplPhone.Text = " "
        If bAutom Then
            If {7, 8, 17, 18, 30, 33}.Contains(CInt(ir.Split)) Then
                bTransl = True
            Else
                bTransl = False
            End If
        Else
            bTransl = MsgBox("Печат на английски ?", MsgBoxStyle.YesNo, "Печат фактура") = MsgBoxResult.Yes
        End If

        If Not ir.IsPaym_TermNull AndAlso ir.Paym_Term <> Nothing AndAlso ir.Paym_Term <= ir.Inv_Date AndAlso (ir.PaymType = 2 OrElse ir.PaymType = 3) Then
            If Not bTransl Then
                XrTableCellPaym_Term.DataBindings.First.FormatString = "{0:dd.MM.yyyy 'ИЗИСКВА СЕ ПРЕДВАРИТЕЛНО ПЛАЩАНЕ'}"
            Else
                XrTableCellPaym_Term.DataBindings.First.FormatString = "{0:dd.MM.yyyy 'PAYMENT IN ADVANCE IS REQUIRED'}"
            End If

            XrTableCellPaym_Type.WidthF = XrTableCellBankName.WidthF
            XrTableCellPaymTerm.WidthF = XrTableCellSummLabel.LeftF - XrTableCellPaymTerm.LeftF
            XrTableCellPaym_Term.WidthF = XrTableSumm.WidthF - XrTableCellPaym_Term.LeftF
        End If


        Get_InvoiceTableAdapter.Fill(DataSet11.Get_Invoice, CDec(gInv_No), bTransl)
        SumTotal = 0
        SumTotalEur = 0
        dt = Get_InvoiceTableAdapter.GetData(CDec(gInv_No), bTransl)
        ir = dt.ToList.First

        XrTableCellSlov.Text = "Словом Всичко: " + Slov(ir.Summ_Local)
        SumTotal = ir.Sum_Local
        SumTotalEur = CDec(CDbl(ir.Sum_Local) / 1.95583)
        If ir.Service = 5 Then
            XrTableColumnHeader.TopF = XrTableCons.LocationF.Y + XrTableCons.SizeF.Height + XrTableColumnHeader.SizeF.Height / 5
            'XrTableOrder.Visible = False
            'XrTableOrder.TopF = 0
            ReportHeader.HeightF = XrTableColumnHeader.TopF + XrTableColumnHeader.HeightF
        End If
        bEUR = True
        If bAutom Then
            ZClient_Sing_InvTableAdapter1.Connection.ConnectionString = gConnStr
            Dim dtClientSing = ZClient_Sing_InvTableAdapter1.GetData(ir.Client_No).ToList
            If dtClientSing.Count <> 0 Then
                bPrintSing = True
            End If
        Else
            bPrintSing = MsgBox("Отпечатване съкратена фактура?", MsgBoxStyle.YesNo, "Печат фактура") = MsgBoxResult.Yes
        End If
        If 1 = 0 Then
            XrTableCellLabelSumEUR.Visible = False
            XrTableCellLabelSumEUR1.Visible = False
            XrTableCellSumEur.Visible = False
            XrTableCellInvBaseVATEUR.Visible = False
            XrTableCellInvSumDiscEUR.Visible = False
            XrTableCellInvSummEUR.Visible = False
            XrTableCellInvSumNoDiscEUR.Visible = False
            XrTableCellInvVatEUR.Visible = False
            XrTableCellInvSumEUR.Visible = False
            XrTableCellLabelSumEUR.WidthF = 0
            XrTableCellLabelSumEUR1.WidthF = 0
            XrTableCellSumEur.WidthF = 0
            XrTableCellInvBaseVATEUR.WidthF = 0
            XrTableCellInvSumDiscEUR.WidthF = 0
            XrTableCellInvSummEUR.WidthF = 0
            XrTableCellInvSumNoDiscEUR.WidthF = 0
            XrTableCellInvVatEUR.WidthF = 0
            XrTableCellInvSumEUR.WidthF = 0
        End If
        If ir.Split = 34 Then
            XrTableRowBaseVat.Visible = False
            XrTableRowVat.Visible = False
            XrTableRowSumLocal.Visible = False
            XrTableRowBaseVat.Visible = False
        End If

        If bTransl Then
            Dim tmpwidth = XrTable4.WidthF - XrTableCellSumEur.LeftF
            XrTableCellLabelSumEUR1.WidthF = tmpwidth
            XrTableCellLabelSumEUR.WidthF = tmpwidth
            XrTableCellSumEur.WidthF = tmpwidth
            XrTableCellInvBaseVATEUR.WidthF = tmpwidth
            XrTableCellInvSumDiscEUR.WidthF = tmpwidth
            XrTableCellInvSumEUR.WidthF = tmpwidth
            XrTableCellInvSummEUR.WidthF = tmpwidth
            XrTableCellInvSumNoDiscEUR.WidthF = tmpwidth
            XrTableCellInvVatEUR.WidthF = tmpwidth
            XrTableCellSumEur.WidthF = tmpwidth

            XrTableGroupFooter.Visible = False

            XrTableCellBaseVATBGN.WidthF = 0
            XrTableCellDiscBGN.WidthF = 0
            XrTableCellSumBGN.WidthF = 0
            XrTableCellSummBGN.WidthF = 0
            XrTableCellSumNoDiscBGN.WidthF = 0
            XrTableCellSumRowBGN.WidthF = 0
            XrTableCellSumRowBGN1.WidthF = 0
            XrTableCellVATBGN.WidthF = 0
            XrTableCellSumDetailBGN.WidthF = 0
            XrTableCellBaseVATBGN.Visible = False
            XrTableCellDiscBGN.Visible = False
            XrTableCellSumBGN.Visible = False
            XrTableCellSummBGN.Visible = False
            XrTableCellSumNoDiscBGN.Visible = False
            XrTableCellSumRowBGN.Visible = False
            XrTableCellSumRowBGN1.Visible = False
            XrTableCellVATBGN.Visible = False
            XrTableCellSummPassed.Visible = False
            XrTableCellSumPassed.Visible = False
            XrTableCellSumtobePassed.Visible = False
            XrTableCellCarryOverSum.Visible = False
            XrTableCellSumDetailBGN.Visible = False

            XrTableCellSuppFirm.DataBindings.Clear()
            XrTableCellSuppFirm.DataBindings.Add("Text", DataSet11, "Summary_Transcr.FIRM")
            XrTableCellSuppAddress1.DataBindings.Clear()
            XrTableCellSuppAddress1.DataBindings.Add("Text", DataSet11, "Summary_Transcr.ADDRESS1")
            XrTableCellSuppAddress2.DataBindings.Clear()
            XrTableCellSuppAddress2.DataBindings.Add("Text", DataSet11, "Summary_Transcr.ADDRESS2")
            XrTableCellSuppBulstat.DataBindings.Clear()
            XrTableCellSuppBulstat.Text = "ID NO:[Summary_Transcr.VAT_NO] VAT No: [Summary_Transcr.BULSTAT]"
            XrTableCellSuppCity.DataBindings.Clear()
            XrTableCellSuppCity.Text = "SOFIA"
            'XrTableCellSuppCity.DataBindings.Add("Text", DataSet11, "Summary_Transcr.City")
            XrTableCellSuppFirm1.DataBindings.Clear()
            XrTableCellSuppFirm1.DataBindings.Add("Text", DataSet11, "Summary_Transcr.FIRM")
            XrTableCellDescr.DataBindings.Clear()
            XrTableCellDescr.DataBindings.Add("Text", DataSet11, "zInvoice_Rows_Print.Description_Transl")
            XrTableCellQtypValue.DataBindings.Clear()
            XrTableCellQtypValue.DataBindings.Add("Text", DataSet11, "zInvoice_Rows_Print.QTYP_Transl")
            XrTableCellPriceLocal.DataBindings.Clear()
            XrTableCellPriceLocal.DataBindings.Add("Text", DataSet11, "zInvoice_Rows_Print.PRICE_EUR")
            XrTableCellPriceLocal.DataBindings.First.FormatString = "{0:0.00;;#}"

            XrTableCellDescrPack.DataBindings.Clear()
            XrTableCellDescrPack.DataBindings.Add("Text", DataSet11, "Rep_Invoice_Rows_SubDetail.Description_Transl")
            'XrTableCellSuppMailWWW.Text = "email: [Summary_Transcr.EMAIL], WWW : [Summary_Transcr.Web_Site]"
            'XrTableCellSupplPhone.Text = "Phone: [Get_Emblem.Phone] , FAX: [Get_Emblem.Fax]"
            XrTableCellSuppMailWWW.Text = " "
            XrTableCellSupplPhone.Text = " "
            XrTableCellRecBulstat.Text = "ID No: [Get_Invoice.Vat_No] VAT No: [Get_Invoice.Bulstat]"
            XrTableCellClientNo1.Text = "Customer No"
            XrTableCellClientNo.Text = "Cutomer No [Get_Invoice.Client_No]"
            'QRLabelPage.Caption := 'Page';
            XrTableCellRecip.Text = "Customer"
            XrTableCellRecip1.Text = "Customer"
            XrTableCellCode.Text = "Article Code"
            XrTableCellCode1.Text = "Article Code"
            XrTableCellContractNo.Text = "Contract No"
            XrTableCellDateTax.Text = "Tax Date"
            XrTableCellDescription.Text = "Description"
            XrTableCellDescription1.Text = "Description"
            XrTableCellDiscount.Text = "Discount"
            XrTableCellDiscount1.Text = "Discount"
            XrTableCellInvDate.Text = "Invoice Date"
            XrTableCellInvNo.Text = "Invoice No"
            XrTableCellKM.Text = "KM"
            XrTableCellLabelSumEUR.Text = "Sum EUR"
            XrTableCellLabelSumEUR1.Text = "Sum EUR"
            XrTableCellModel.Text = "Model"
            XrTableCellOrderNo.Text = "Order No"
            XrTableCellOrderNo1.Text = "Order No"
            XrTableCellPlace.Text = "Place"
            XrTableCellPlaceValue.DataBindings.Clear()
            XrTableCellPlaceValue.Text = "SOFIA"
            XrTableCellPlaceValue1.Text = "SOFIA, [Get_Invoice.Inv_Date!dd.MM.yyyy]"
            XrTableCellPlateNr.Text = "Plate Nr"
            XrTableCellPrevInvNo.Text = "Prior Invoice No"
            XrTableCellPrice.Text = "Price"
            XrTableCellPrice1.Text = "Price"
            XrTableCellQtyp.Text = "Unit"
            XrTableCellQtyp1.Text = "Unit"
            XrTableCellQuant.Text = "Qty"
            XrTableCellQuant1.Text = "Qty"
            XrTableCellRecip.Text = "Customer"
            XrTableCellRecip1.Text = "Customer"
            XrTableCellRefNo.Text = "Ref No"
            XrTableCellRegDate.Text = "Registr. date"
            XrTableCellSummPassed.Text = "Carried over sum"
            XrTableCellSumRowBGN.Text = "Sum BGN"
            XrTableCellSumRowBGN1.Text = "Sum BGN"
            XrTableCellSuppl.Text = "Supplier"
            XrTableCellSuppl1.Text = "Supplier"
            XrTableCellVinNr.Text = "VIN"
            XrTableCellVinNr1.Text = "VIN"
            XrTableCellBank.Text = "Bank"
            XrTableCellBaseVatLabel.Text = "Base VAT"
            XrTableCellBIC.Text = "BIC"
            XrTableCellCarryOverSum.Text = "Carry over sum"
            XrTableCellIBAN.Text = "IBAN"
            XrTableCellPaymT.Text = "Payment"
            XrTableCellPaymTerm.Text = "Payment Term"
            XrTableCellPrepared.Text = "Prepared by"
            XrTableCellPreparedCode.Text = "Code"
            XrTableCellRecieved.Text = "Consignee"
            XrTableCellSlov.Visible = False
            XrTableCellReasonNullVAT.Text = "Reason zero VAT : [Get_Invoice.ReasonNullVat]"
            XrTableCellSubTotal.Text = "Subtotal"
            XrTableCellSumDiscLabel.Text = "Discount"
            XrTableCellSumLabel.Text = "Sum EUR"
            XrTableCellSummLabel.Text = "Total EUR"
            XrTableCellSumNoDiscLabel.Text = "Sum before discount"
            XrTableCellVATLabel.Text = "VAT [Get_Invoice.Vat_Perc!0%] EUR"
            XrLabelInvType.Text = "[Get_Invoice.Inv_Type_Transcr] [Get_Invoice.PrintedName]"
            XrTableCellInvType.Text = "[Get_Invoice.Inv_Type_Transcr]"
            XrPageInfo1.Format = "Page {0} / {1}"
            XrTableCellAddText.Text = "According to the Accounting Act, the company stamp is not a mandatory requisite of the primary accounting documents, and the signature may be replaced by identification codes."
            'Съгласно Закона за счетоводството печатът не е задължителен реквизит на първичните счетоводни документи, а подписът може да се замени с идентификационни шифри.
            'QRDBTextDescr.DataField := 'Description_Translated';
            'QRLabelOrderNo1.Caption := 'Order No';
            'QRLabelCustCode1.Caption := 'Customer No';
            'QRLabelVinNr.Caption := 'VIN';
            'QRLabelCarrySum.Caption := 'Carried over sum';
            'QRLabelDescr.Caption := 'Description';
            'QRLabelQtyp.Caption := 'Unit';
            'QRLabelQuant.Caption := 'Qty';
            'QRLabelPrice.Caption := 'Price';
            'QRLabelDiscount.Caption := 'Discount %';
            'QRLabelSumBGN.Caption := 'Sum BGN';
            'QRLabelSumCurr.Caption := 'Sum EUR';
            'QRLabelCons2.Caption := 'Consignee';
            'QRLabelPrepared.Caption := 'Prepared by';
            'QRLabelBase_VAT.Caption := 'VAT Base';
            'QRLabelSum.Caption := 'Sum';
            'QRLabelTotal.Caption := 'Total';
            'QRLabelCarryOver.Caption := 'Carry over sum';
            'QRLabelPaymT.Caption := 'Payment';
            'QRLabelBank.Caption := 'Bank';
            'QRLabelBIC.Caption := 'BIC';
            'QRLabelIBAN_Code.Caption := 'IBAN';
            'QRLabelTimeInv.Caption := 'Date/Time';
            'QRLabelTimePrint.Caption := 'Date/Time Printed';
            'QRLabelSupp1.Caption := 'Supplier';
            'QRLabelCons.Caption := 'Customer';
            'QRLabelSubTotal.Caption := 'Subtotal';
            'QRLabelSubTotalJob.Caption := 'Subtotal labor';
            'QRLabelSubTotalParts.Caption := 'Subtotal parts';
            'QRLabelSubTotalOther.Caption := 'Subtotal Other';
            'QRLabelTotalJob.Caption := 'Total labor';
            'QRLabelTotalParts.Caption := 'Total Parts';
            'QRLabelTotal.Caption := 'Total';
            'QRLabelTotalOthers.Caption := 'Total Other';
            'QRLabelOrderNo.Caption := 'Order No';
            'QRLabelVin.Caption := 'VIN';
            'QRLabelPlateNr.Caption := 'Plate No';
            'QRLabelModel.Caption := 'Model';
            'QRLabelKM.Caption := 'KM';
            'QRLabelRegDate.Caption := 'Registr.date';
            'QRLabelCurr.Caption := 'Currency';
            'QRLabelRate.Caption := 'Exch.Rate';
            'QRLabelContract_No.Caption := 'Contract No';
            'QRLabelInv_No.Caption := 'Invoice No';
            'QRLabelRef_No.Caption := 'Ref No';
            'QRLabelDate.Caption := 'Date';
            'QRLabelPlace.Caption := 'Place';
            'QRLabelPrevInvNo.Caption := 'Prior Invoice No';
            'QRLabelPaymSrok.Caption := 'Payment term';
            'QRLabelService_Adv.Caption := 'Service Advisor';
            'QRDBTextDescr.DataField := 'Description_Translated';
            'QRExprDateDeal.Expression := 'if(Invoice.DateDeal<>'''',''Date of deal/payment'','' '')';
            'QRExprCustVatNo.Expression := ''' Vat No '' + Invoice.Bulstat';
            'QRExprCustIdent.Expression := ''' ID No '' + Invoice.VAT_NO';
            'QRExprFirmIdent.Expression := '''ID No '' + Summary.VAT_NO + '', VAT No '' + Summary.Bulstat';
            'QRExprFirmPhone.Expression := '''Phone: '' + Summary.PHONE + '' ; FAX: '' + Summary.FAX';
            'QRExprLabelVAT.Expression := '''VAT '' + Invoice.Vat_Perc*100 + ''%''';
            'Else
            '    XrTableCellLabelSumEUR.Visible = False
            '    XrTableCellLabelSumEUR1.Visible = False
            '    XrTableCellSumEur.Visible = False
            '    XrTableCellInvBaseVATEUR.Visible = False
            '    XrTableCellInvSumDiscEUR.Visible = False
            '    XrTableCellInvSummEUR.Visible = False
            '    XrTableCellInvSumNoDiscEUR.Visible = False
            '    XrTableCellInvVatEUR.Visible = False
            '    XrTableCellInvSumEUR.Visible = False
            '    XrTableCellLabelSumEUR.WidthF = 0
            '    XrTableCellLabelSumEUR1.WidthF = 0
            '    XrTableCellSumEur.WidthF = 0
            '    XrTableCellInvBaseVATEUR.WidthF = 0
            '    XrTableCellInvSumDiscEUR.WidthF = 0
            '    XrTableCellInvSummEUR.WidthF = 0
            '    XrTableCellInvSumNoDiscEUR.WidthF = 0
            '    XrTableCellInvVatEUR.WidthF = 0
            '    XrTableCellInvSumEUR.WidthF = 0
        End If


        Dim dsaler As Decimal = ir.Saler
        Dim dservice As Decimal = Nothing
        If ir.Service <> 0 Then dservice = ir.Service
        Get_EmblemTableAdapter1.Connection.ConnectionString = gConnStr
        Get_EmblemTableAdapter1.Fill(DataSet11.Get_Emblem, dservice, dsaler)

        If bTransl Then
            Summary_TranscrTableAdapter1.Connection.ConnectionString = gConnStr
            Summary_TranscrTableAdapter1.Fill(DataSet11.Summary_Transcr)
        Else
            SummaryTableAdapter1.Connection.ConnectionString = gConnStr
            SummaryTableAdapter1.Fill(DataSet11.SUMMARY)

        End If

        Rep_Invoice_Rows_SubDetailTableAdapter.Connection.ConnectionString = gConnStr
        ZInvoice_Rows_PrintTableAdapter1.Connection.ConnectionString = gConnStr
        Rep_Invoice_Rows_SubDetailTableAdapter.Fill(DataSet11.Rep_Invoice_Rows_SubDetail, CDec(gInv_No))
        ZInvoice_Rows_PrintTableAdapter1.Fill(DataSet11.zInvoice_Rows_Print, CDec(gInv_No), 1, bPrintSing)
        Dim ShowPacksDetail As Boolean = True
        If Not bAutom AndAlso DataSet11.zInvoice_Rows_Print.Where(Function(n) n.INVR_TYPE = 3 Or n.INVR_TYPE = 4).ToList.Count <> 0 Then
            ShowPacksDetail = MsgBox("Показване детайли за пакетите?", CType(MsgBoxStyle.YesNo + MsgBoxStyle.Question, Global.Microsoft.VisualBasic.MsgBoxStyle), "Печат фактура") = MsgBoxResult.Yes
        End If
        DetailReport.Visible = ShowPacksDetail
    End Sub

    Private Sub Invoice_Deal_AfterPrint(sender As Object, e As EventArgs) Handles MyBase.AfterPrint

        Dim PubsConn As SqlConnection = New SqlConnection(gConnStr)
        Dim testCMD As SqlCommand = New SqlCommand("Set_Inv_Printed", PubsConn)
        testCMD.CommandType = CommandType.StoredProcedure
        Dim aInvNo As SqlParameter = testCMD.Parameters.Add("@Inv_No", SqlDbType.Decimal, 10)
        aInvNo.Direction = ParameterDirection.Input
        aInvNo.Value = gInv_No
        PubsConn.Open()
        Dim rvRows As Integer = testCMD.ExecuteNonQuery
    End Sub

    Private Sub ReportHeader_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles ReportHeader.BeforePrint
        If SumTotal = 0 Then
            SumTotal = ir.Sum_Local
            SumTotalEur = CDec(CDbl(ir.Sum_Local) / 1.95583)
        End If
    End Sub

    Private Sub XrTableCellSumEur_EvaluateBinding(sender As Object, e As DevExpress.XtraReports.UI.BindingEventArgs) Handles XrTableCellSumEur.EvaluateBinding
        Dim TmpSum As Decimal = 0
        Dim CurrSum As Decimal = 0
        CurrSum = CDec(e.Value)
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

    Private Sub XrTableCell53_EvaluateBinding(sender As Object, e As DevExpress.XtraReports.UI.BindingEventArgs) Handles XrTableCell53.EvaluateBinding

        If New Decimal() {6, 7, 15, 28}.Contains(ir.Service) Then
            If bTransl Then
                e.Value = "I accept executed repair without remarks/with following remarks:" & vbCrLf & "________________________________________________________________. Signature.................."
            Else
                e.Value = "Приемам извършеният ремонт без забележки/със следните забележки:" & vbCrLf & "________________________________________________________________. Подпис.................."
            End If

        ElseIf New Decimal() {8, 16, 29}.Contains(ir.Service) Then
            If bTransl Then
                e.Value = "  " & vbCrLf & "Получих фактурираните резервни части в пълна окомплектовка. Подпис........."
            Else
                e.Value = "  " & vbCrLf & "I've received all invoiced spare parts. Signature........."
            End If

        End If
    End Sub

    Private Sub DetailReport_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles DetailReport.BeforePrint
    End Sub
End Class