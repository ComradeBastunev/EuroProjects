Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Invoice_Deal

    Private Sub Invoice_Deal_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Get_InvoiceTableAdapter.Connection.ConnectionString = gConnStr
        Get_InvoiceTableAdapter.Fill(DataSet11.Get_Invoice, CDec(gInv_No))

        Dim dt = Get_InvoiceTableAdapter.GetData(gInv_No)
        Dim ir = dt.ToList.First
        XrTableCellSlov.Text = "Словом Всичко: " + Slov(ir.Summ_Local)
        If ir.Service = 5 Then
            XrTableRowClientNo.Visible = True
            XrTableRowClientNo.HeightF = 63.5
            XrTableColumnHeader.TopF = XrTableCons.LocationF.Y + XrTableCons.SizeF.Height + XrTableColumnHeader.SizeF.Height / 5
            XrTableOrder.Visible = False
            XrTableOrder.TopF = 0
            ReportHeader.HeightF = XrTableColumnHeader.TopF + XrTableColumnHeader.HeightF
        End If
        Dim dsaler As Decimal = ir.Saler
        Dim dservice As Decimal = Nothing
        If ir.Service <> 0 Then dservice = ir.Service
        Get_EmblemTableAdapter1.Connection.ConnectionString = gConnStr
        Get_EmblemTableAdapter1.Fill(DataSet11.Get_Emblem, dservice, dsaler)

        ZInvoice_Rows_PrintTableAdapter1.Connection.ConnectionString = gConnStr
        ZInvoice_Rows_PrintTableAdapter1.Fill(DataSet11.zInvoice_Rows_Print, CDec(gInv_No))
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
End Class