Public Class Print_Warr_Card
    Private Sub Print_Warr_Card_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Get_InvoiceTableAdapter1.Connection.ConnectionString = gConnStr
        Get_InvoiceTableAdapter1.Fill(DataSet11.Get_Invoice, gInv_No, False)

        Inv_Rows_ListTableAdapter1.Connection.ConnectionString = gConnStr
        Inv_Rows_ListTableAdapter1.FillBy(DataSet11.Inv_Rows_List, CDec(gInv_No), Code.Value)



        If DataSet11.Inv_Rows_List.Count <> 0 Then
            StoresTableAdapter1.Connection.ConnectionString = gConnStr
            Dim bLexus As Boolean = False
            If Not DataSet11.Inv_Rows_List.First.IsModelNull AndAlso DataSet11.Inv_Rows_List.First.Model.ToUpper.Contains("LEXUS") Then bLexus = True
            StoresTableAdapter1.Fill(DataSet11.STORES, DataSet11.Inv_Rows_List.First.Service, bLexus)
        End If
    End Sub

    Private Sub Print_Warr_Card_ParametersRequestBeforeShow(sender As Object, e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestBeforeShow
        Inv_Rows_ListTableAdapter1.Connection.ConnectionString = gConnStr
        Inv_Rows_ListTableAdapter1.FillBy(DataSet11.Inv_Rows_List, CDec(gInv_No), Code.Value)
    End Sub
End Class