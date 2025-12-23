Public Class ReportSupp163
    Private Sub ReportSupp163_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Supp_HeaderTableAdapter1.Connection.ConnectionString = gConnStr
        Supp_HeaderTableAdapter1.Fill(DataSet11.Supp_Header, CDec(gDocNo), CDec(gStore))

        Supp_DetailTableAdapter1.Connection.ConnectionString = gConnStr
        Supp_DetailTableAdapter1.Fill(DataSet11.Supp_Detail, CDec(gDocNo), CDec(gStore))

        SummaryTableAdapter1.Connection.ConnectionString = gConnStr
        SummaryTableAdapter1.Fill(DataSet11.SUMMARY)
        Dim lService As Decimal
        If gStore = 1 Then
            lService = 11
        ElseIf gStore = 2 Then
            lService = 12
        ElseIf gStore = 3 Then
            lService = 13
        ElseIf gStore = 4 Then
            lService = 14
        ElseIf gStore = 5 Then
            lService = 14
        ElseIf gStore = 6 Then
            lService = 15
        ElseIf gStore = 7 Then
            lService = 15
        ElseIf gStore = 8 Then
            lService = 16
        ElseIf gStore = 9 Then
            lService = 16
        ElseIf gStore = 10 Then
            lService = 18
        Else
            lService = 11
        End If
        StoresTableAdapter1.Connection.ConnectionString = gConnStr
        StoresTableAdapter1.Fill(DataSet11.STORES, lService, False)

        If DataSet11.Supp_Header.ToList.Count > 0 Then
            Dim sh1 = DataSet11.Supp_Header.ToList.First
            Dim SumText As Double
            SumText = sh1.Sum_Local - sh1.TaxIncomePerson
            XrTableCellSlov.Text = "Словом: " + Slov(SumText)
            If sh1.Contr_Type = 1 Then
                XrTableCellDocName.Text = "ФИЗИЧЕСКО ЛИЦЕ ПРИЕМО-ПРЕДАВАТЕЛНА БЕЛЕЖКА СКРАП"
            Else
                XrTableCellDocName.Text = "ЮРИД. ЛИЦЕ СКЛАДОВА РАЗПИСКА /СКРАП И ОТРАБ.МАСЛО/"
            End If
        End If
    End Sub
End Class