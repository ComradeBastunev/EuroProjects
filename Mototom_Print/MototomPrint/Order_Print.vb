Public Class Order_Print

    Private Sub Order_Print_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        'ZOrder_ComplaintsTableAdapter.Connection.ConnectionString = gConnStr
        'ZOrder_ComplaintsTableAdapter.Fill(DataSet11.zOrder_Complaints, CDec(gService), CDec(gOrderNo), CDec(gSplit))

        XrBarCode2.Text = "2" & gOrderNo.ToString("00000000000")
        'XrBarCode3.Text = "2" & gOrderNo.ToString("00000000000")
        ZOrder_JobsTableAdapter.Connection.ConnectionString = gConnStr
        ZOrder_JobsTableAdapter.Fill(DataSet11.zOrder_Jobs, CDec(gService), CDec(gOrderNo), CDec(gSplit))
        Empl_SummaryTableAdapter1.Connection.ConnectionString = gConnStr
        Empl_SummaryTableAdapter1.Fill(DataSet11.Empl_Summary)

        Get_EmblemTableAdapter1.Connection.ConnectionString = gConnStr
        Get_EmblemTableAdapter1.Fill(DataSet11.Get_Emblem, gService, Nothing)

        SummaryTableAdapter1.Connection.ConnectionString = gConnStr
        SummaryTableAdapter1.Fill(DataSet11.SUMMARY)

        OrderS_PTableAdapter1.Connection.ConnectionString = gConnStr
        Dim ordcompl = OrderS_PTableAdapter1.GetData(CDec(gService), CDec(gOrderNo)).ToList
        Dim tmpstr As String = ""
        For Each ordcomplrow In ordcompl
            If tmpstr <> "" Then tmpstr = tmpstr + vbCrLf
            tmpstr = tmpstr + ordcomplrow.DESCRIPTION
        Next
        XrTableCellComplaints.Text = tmpstr
        'Array.Resize(XrTableCellComplaints.Lines, 0)
        'For Each ordcomplrow In ordcompl
        '    Array.Resize(XrTableCellComplaints.Lines, XrTableCellComplaints.Lines.Length + 1)
        '    XrTableCellComplaints.Lines(XrTableCellComplaints.Lines.Length - 1) = ordcomplrow.DESCRIPTION
        'Next
        If gForClient Then
            'XrLabelOrderCaption.Text = "СЕРВИЗНА ПОРЪЧКА - ЗА КЛИЕНТА"
            'XrTableCellSumm.ForeColor = Drawing.Color.Black
            'XrTableCellSumm.BorderColor = Drawing.Color.Black
            'XrTableCellLabelSumm.ForeColor = Drawing.Color.Black
            'XrTableCellLabelSumm.BorderColor = Drawing.Color.Black
            'XrTableCellLabelQtyp.WidthF = XrTableCellLabelSumm.LeftF - XrTableCellLabelQtyp.LeftF
            'XrTableCellQtyp.WidthF = XrTableCellSumm.LeftF - XrTableCellQtyp.LeftF
            'XrLabelSumTotal.ForeColor = Drawing.Color.Black

        Else
            'XrLabelOrderCaption.Text = "СЕРВИЗНА ПОРЪЧКА - ЗА СЕРВИЗА"
            'XrTableCellSumm.ForeColor = Drawing.Color.Transparent
            'XrTableCellSumm.BorderColor = Drawing.Color.Transparent
            'XrTableCellLabelSumm.ForeColor = Drawing.Color.Transparent
            'XrTableCellLabelSumm.BorderColor = Drawing.Color.Transparent
            'XrTableCellLabelQtyp.WidthF = XrTableCellLabelSumm.LeftF + XrTableCellLabelSumm.WidthF - XrTableCellLabelQtyp.LeftF
            'XrTableCellQtyp.WidthF = XrTableCellSumm.LeftF + XrTableCellSumm.WidthF - XrTableCellQtyp.LeftF
            'XrLabelSumTotal.ForeColor = Drawing.Color.Transparent
        End If

    End Sub
End Class