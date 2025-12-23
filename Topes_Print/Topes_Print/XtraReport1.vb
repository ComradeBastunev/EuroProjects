Public Class XtraReport1
    Private Sub XtraReport1_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        aDate.Value = Today
        ZPRotokol_TopesTableAdapter.Connection.ConnectionString = ConnStr.Value
        ZPRotokol_TopesTableAdapter.Fill(DataSet11.zPRotokol_Topes, Inv_No.Value)
    End Sub
End Class