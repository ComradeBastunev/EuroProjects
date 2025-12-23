Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Public Class Invoice_Deal
    Private SumTotal As Decimal
    Private SumTotalEur As Decimal
    Private SumNoDiscEur As Decimal
    Private ir As DataSet1.Get_InvoiceRow
    Private Eur As Boolean
    Private Sub Invoice_Deal_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Get_InvoiceTableAdapter.Connection.ConnectionString = gConnStr
        Get_InvoiceTableAdapter.Fill(DataSet11.Get_Invoice, CDec(gInv_No))

        SummaryTableAdapter1.Connection.ConnectionString = gConnStr
        SummaryTableAdapter1.Fill(DataSet11.SUMMARY)

        Eur = DataSet11.SUMMARY.First.Eur_Change_Date <= DataSet11.Get_Invoice.First.Inv_Date


        Dim dt = Get_InvoiceTableAdapter.GetData(gInv_No)
        ir = dt.ToList.First
        XrTableCellSlov.Text = "Словом: " + Slov(ir.Summ_Local)
        If ir.Printed = 0D Then
            Me.Watermark.Text = "ОРИГИНАЛ"
        Else
            Me.Watermark.Text = " "
        End If
        If ir.Service = 8 Then
            XrTableColumnHeader.TopF = XrTableCons.LocationF.Y + XrTableCons.SizeF.Height + XrTableColumnHeader.SizeF.Height / 5
            XrTableOrder.Visible = False
            XrTableOrder.TopF = 0
            ReportHeader.HeightF = XrTableColumnHeader.TopF + XrTableColumnHeader.HeightF
        End If

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

        Dim dsaler As Decimal = ir.Saler
        Dim dservice As Decimal = Nothing
        If ir.Service <> 0 Then dservice = ir.Service

        Get_EmblemTableAdapter1.Connection.ConnectionString = gConnStr
        Get_EmblemTableAdapter1.Fill(DataSet11.Get_Emblem, dservice, dsaler)

        ZInvoice_Rows_PrintTableAdapter1.Connection.ConnectionString = gConnStr
        ZInvoice_Rows_PrintTableAdapter1.Fill(DataSet11.zInvoice_Rows_Print, CDec(gInv_No), 0, ShortPrint.Value, ShowPArts.Value)
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

    Private Sub Invoice_Deal_FillEmptySpace(sender As Object, e As DevExpress.XtraReports.UI.BandEventArgs) Handles MyBase.FillEmptySpace
        Dim bandHeight As Integer = GraphicsUnitConverter.Convert(e.Band.Height, ReportUnit.ToDpi(), ReportUnit.HundredthsOfAnInch.ToDpi())
        Dim bandWidth As Integer = GraphicsUnitConverter.Convert(XrTable4.Width, ReportUnit.ToDpi(), ReportUnit.HundredthsOfAnInch.ToDpi())
        If bandHeight <= 30 Then
            Return
        End If

        ' Obtain the empty space dimensions.
        Dim size As New Size(bandWidth, bandHeight)
        Dim sizeInPixels As Size = XRConvert.Convert(size, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)

        Dim XRlabelFiller As New XRLabel()
        XRlabelFiller.BackColor = Color.Transparent
        XRlabelFiller.Size = size
        XRlabelFiller.Location = New Point(0, 0)
        'XRlabelFiller.Borders = BorderSide.Left + BorderSide.Right
        e.Band.Controls.Add(XRlabelFiller)
    End Sub

    Private Sub ReportFooter_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles ReportFooter.BeforePrint
        Dim SummTotal As Decimal
        Dim VATSumm As Decimal
        Dim BaseVAT As Decimal
        Dim Discount As Decimal

        If ir Is Nothing Then
            Dim dt = Get_InvoiceTableAdapter.GetData(gInv_No)
            ir = dt.ToList.First
        End If
        XrTableCellSumNoVATEUR.DataBindings.Clear()
        XrTableCellBaseVATEUR.DataBindings.Clear()
        XrTableCellSumVATEUR.DataBindings.Clear()
        XrTableCellSumTotalEUR.DataBindings.Clear()
        SummTotal = Math.Round(ir.Summ_Local / 1.95583, 2)
        BaseVAT = Math.Round(ir.Sum_Local / 1.95583, 2)
        VATSumm = SummTotal - BaseVAT
        Discount = SumNoDiscEur - BaseVAT
        XrTableCellSumNoVATEUR.Text = FormatNumber(BaseVAT, 2, TriState.True, TriState.False, TriState.False)
        XrTableCellBaseVATEUR.Text = FormatNumber(BaseVAT, 2, TriState.True, TriState.False, TriState.False)
        XrTableCellSumVATEUR.Text = FormatNumber(VATSumm, 2, TriState.True, TriState.False, TriState.False)
        XrTableCellSumTotalEUR.Text = FormatNumber(SummTotal, 2, TriState.True, TriState.False, TriState.False)
        If 1 = 0 Then
            XrTableCellSumNoVATEUR.DataBindings.Clear()
            XrTableCellBaseVATEUR.DataBindings.Clear()
            XrTableCellSumVATEUR.DataBindings.Clear()
            XrTableCellSumTotalEUR.DataBindings.Clear()
            SummTotal = Math.Round(ir.Summ_Local / 1.95583, 2)
            BaseVAT = Math.Round(ir.Sum_Local / 1.95583, 2)
            VATSumm = SummTotal - BaseVAT
            Discount = SumNoDiscEur - BaseVAT
            XrTableCellSumNoVAT.Text = FormatNumber(BaseVAT, 2, TriState.True, TriState.False, TriState.False)
            XrTableCellBaseVAT.Text = FormatNumber(BaseVAT, 2, TriState.True, TriState.False, TriState.False)
            XrTableCellSumVAT.Text = FormatNumber(VATSumm, 2, TriState.True, TriState.False, TriState.False)
            XrTableCellSumTotal.Text = FormatNumber(SummTotal, 2, TriState.True, TriState.False, TriState.False)
        End If

    End Sub
End Class