Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Invoice_Deal

    Private Eur As Boolean
    Private WithEvents SummaryFieldAdaptor As DataSet1TableAdapters.SUMMARYTableAdapter
    Private Sub Invoice_Deal_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Get_InvoiceTableAdapter.Connection.ConnectionString = gConnStr
        Get_InvoiceTableAdapter.Fill(DataSet11.Get_Invoice, CDec(gInv_No))

        SummaryFieldAdaptor.Connection.ConnectionString = gConnStr
        SummaryFieldAdaptor.Fill(DataSet11.SUMMARY)
        Eur = DataSet11.SUMMARY.First.Eur_Change_Date <= DataSet11.Get_Invoice.First.Inv_Date



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


        If Eur Then
            XrTableCellSlov.Text = "Словом евро: " + Slov(ir.Summ_Local, 1)
            XrTableCellSlovEUR.Text = "Словом лева: " + Slov(Math.Round(ir.Summ_BGN, 2), 0)
            XrTableCellSumLabel1.Text = "Стойност €"
            XrTableCellSumLabel2.Text = "Стойност €"
            XrTableCellSumEURLabel1.Text = "Стойност лв."
            XrTableCellSumEURLabel2.Text = "Стойност лв."
            XrTableCellPriceLabel1.Text = "Ед. Цена €"
            XrTableCellPriceLabel2.Text = "Ед. Цена €"
            XrTableCellPriceDiscLabel1.Text = "Ед.цена с ТО €"
            XrTableCellPriceDiscLabel2.Text = "Ед.цена с ТО €"

            XrTableCellCurr1.Text = "€"
            XrTableCellCurr2.Text = "Лева"
            XrTableCellSumEUR.DataBindings.Clear()
            XrTableCellSumLocal.DataBindings.Clear()
            XrTableCellPriceLocal.DataBindings.Clear()
            XrTableCellPriceDiscount.DataBindings.Clear()
            XrTableCellSumEUR.Text = "[zInvoice_Rows_Print.Sum_BGN!0.00; ; ]"
            XrTableCellSumLocal.Text = "[zInvoice_Rows_Print.Sum_Local!0.00; ; ]"
            XrTableCellSumLocal.Text = "[zInvoice_Rows_Print.Price_Local!0.00; ; ]"
            XrTableCellSumLocal.Text = "[zInvoice_Rows_Print.Price_Discount!0.00; ; ]"

        Else
            XrTableCellSlov.Text = "Словом лева: " + Slov(ir.Summ_BGN, 0)
            XrTableCellSlovEUR.Text = "Словом евро: " + Slov(Math.Round(ir.Summ_BGN / 1.95583, 2), 1)
        End If

        If ir.Printed = 0D Then
            If gTransl Then Me.Watermark.Text = "ORIGINAL" Else Me.Watermark.Text = "ОРИГИНАЛ"
        ElseIf ir.PrintedName.Contains("АНУЛИ") Then
            If gTransl Then Me.Watermark.Text = "VOID" Else Me.Watermark.Text = "АНУЛИРАНА"
        Else
            Me.Watermark.Text = " "
        End If
        If (ir.Service = 8 Or ir.Service = 0) AndAlso (ir.IsVin_NrNull OrElse ir.Vin_Nr = "") Then
            XrTableColumnHeader.TopF = XrTableCons.LocationF.Y + XrTableCons.SizeF.Height + XrTableColumnHeader.SizeF.Height / 5
            XrTableOrder.Visible = False
            XrTableOrder.TopF = 0
            ReportHeader.HeightF = XrTableColumnHeader.TopF + XrTableColumnHeader.HeightF
        End If


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