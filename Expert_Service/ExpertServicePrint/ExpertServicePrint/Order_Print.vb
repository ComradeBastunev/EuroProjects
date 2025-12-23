Public Class Order_Print

    Private Sub Order_Print_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        ZOrder_ComplaintsTableAdapter.Connection.ConnectionString = gConnStr
        ZOrder_ComplaintsTableAdapter.Fill(DataSet11.zOrder_Complaints, CDec(gService), CDec(gOrderNo), CDec(gSplit))

        ZOrder_JobsTableAdapter.Connection.ConnectionString = gConnStr
        ZOrder_JobsTableAdapter.Fill(DataSet11.zOrder_Jobs, CDec(gService), CDec(gOrderNo), CDec(gSplit))
        Empl_SummaryTableAdapter1.Connection.ConnectionString = gConnStr
        Empl_SummaryTableAdapter1.Fill(DataSet11.Empl_Summary)

        Get_EmblemTableAdapter1.Connection.ConnectionString = gConnStr
        Get_EmblemTableAdapter1.Fill(DataSet11.Get_Emblem, gService, Nothing)

        If gForClient Then
            XrLabelOrderCaption.Text = "СЕРВИЗНА ПОРЪЧКА - ЗА КЛИЕНТА"
            XrTableCellSumm.ForeColor = Drawing.Color.Black
            XrTableCellSumm.BorderColor = Drawing.Color.Black
            XrTableCellLabelSumm.ForeColor = Drawing.Color.Black
            XrTableCellLabelSumm.BorderColor = Drawing.Color.Black
            XrTableCellLabelQtyp.WidthF = XrTableCellLabelSumm.LeftF - XrTableCellLabelQtyp.LeftF
            XrTableCellQtyp.WidthF = XrTableCellSumm.LeftF - XrTableCellQtyp.LeftF
            XrLabelSumTotal.ForeColor = Drawing.Color.Black

        Else
            XrLabelOrderCaption.Text = "СЕРВИЗНА ПОРЪЧКА - ЗА СЕРВИЗА"
            XrTableCellSumm.ForeColor = Drawing.Color.Transparent
            XrTableCellSumm.BorderColor = Drawing.Color.Transparent
            XrTableCellLabelSumm.ForeColor = Drawing.Color.Transparent
            XrTableCellLabelSumm.BorderColor = Drawing.Color.Transparent
            XrTableCellLabelQtyp.WidthF = XrTableCellLabelSumm.LeftF + XrTableCellLabelSumm.WidthF - XrTableCellLabelQtyp.LeftF
            XrTableCellQtyp.WidthF = XrTableCellSumm.LeftF + XrTableCellSumm.WidthF - XrTableCellQtyp.LeftF
            XrLabelSumTotal.ForeColor = Drawing.Color.Transparent
        End If

    End Sub
End Class