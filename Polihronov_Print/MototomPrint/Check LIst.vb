Public Class Check_LIst

    Private Sub Check_LIst_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        ZOrder_ComplaintsTableAdapter1.Connection.ConnectionString = gConnStr
        ZOrder_ComplaintsTableAdapter1.Fill(DataSet11.zOrder_Complaints, CDec(gService), CDec(gOrderNo), CDec(gSplit))

    End Sub
End Class