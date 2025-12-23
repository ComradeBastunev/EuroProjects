Public Class ReportProforma
    Private Sub ReportProforma_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint

        SummaryTableAdapter1.Connection.ConnectionString = gConnStr
        SummaryTableAdapter1.Fill(DataSet11.SUMMARY)

        Bank_accTableAdapter1.Connection.ConnectionString = gConnStr
        Bank_accTableAdapter1.Fill(DataSet11.bank_acc, CDec(gBankAcc))

        ZPrint_ProformaTableAdapter1.Connection.ConnectionString = gConnStr
        ZPrint_ProformaTableAdapter1.Fill(DataSet11.zPrint_Proforma, CDec(gOrderNo), CDec(gService), CDec(gSplit), CDec(gCurr), CDec(gRateType), gRateDate, CDec(gShowAll), CDec(gOrderType), True)
        Dim SummVAT As Decimal = 0
        For Each ProfRow In DataSet11.zPrint_Proforma.ToList
            SummVAT = SummVAT + ProfRow.Summ_Curr + Math.Round(ProfRow.BaseVat_Curr * ProfRow.VAT_PERC, 2)
        Next
        XrTableCellSlov.Text = Slov(SummVAT)

        'If DataSet11.zPrint_Proforma.Count <> 0 AndAlso DataSet11.zPrint_Proforma.First.Order_Type.ToUpperInvariant = "ОФЕРТА" Then
        If DataSet11.zPrint_Proforma.Count <> 0 Then
            XrTableCellOfferText.Text = "Срокът на валидност на настоящата Оферта е 30 (тридесет) календарни дни, считано от датата на издаването."
        End If
    End Sub
End Class