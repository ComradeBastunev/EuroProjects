Public Class PartsReq
    Private Sub PartsReq_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        'ZOrder_ComplaintsTableAdapter.Connection.ConnectionString = gConnStr
        'ZOrder_ComplaintsTableAdapter.Fill(DataSet11.zOrder_Complaints, CDec(gService), CDec(gOrderNo), CDec(gSplit))

        XrBarCode2.Text = gOrderNo.ToString("00000000000")
        ZOrder_Parts_ReqTableAdapter1.Connection.ConnectionString = gConnStr
        ZOrder_Parts_ReqTableAdapter1.Fill(DataSet11.zOrder_Parts_Req, CDec(gService), CDec(gOrderNo), CDec(gSplit))

        SummaryTableAdapter1.Connection.ConnectionString = gConnStr
        SummaryTableAdapter1.Fill(DataSet11.SUMMARY)
    End Sub
End Class