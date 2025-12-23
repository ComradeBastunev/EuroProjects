Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Public Class Smetka_Deal

    Private Sub Invoice_Deal_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Get_InvoiceTableAdapter.Connection.ConnectionString = gConnStr
        Get_InvoiceTableAdapter.Fill(DataSet11.Get_Invoice, CDec(gInv_No))

        SummaryTableAdapter1.Connection.ConnectionString = gConnStr
        SummaryTableAdapter1.Fill(DataSet11.SUMMARY)

        Dim dt = Get_InvoiceTableAdapter.GetData(gInv_No)
        Dim ir = dt.ToList.First
        XrTableCellSlov.Text = "Словом Всичко: " + Slov(ir.Summ_Local)
        If ir.Printed = 0D Then
            Me.Watermark.Text = "ОРИГИНАЛ"
        Else
            Me.Watermark.Text = " "
        End If
        Dim dsaler As Decimal = ir.Saler
        Dim dservice As Decimal = Nothing
        If ir.Service <> 0 Then dservice = ir.Service
        Get_EmblemTableAdapter1.Connection.ConnectionString = gConnStr
        Get_EmblemTableAdapter1.Fill(DataSet11.Get_Emblem, dservice, dsaler)

        ZInvoice_Rows_PrintTableAdapter1.Connection.ConnectionString = gConnStr
        ZInvoice_Rows_PrintTableAdapter1.Fill(DataSet11.zInvoice_Rows_Print, CDec(gInv_No), 0, 0, 0)
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
        'Dim bandHeight As Integer = GraphicsUnitConverter.Convert(e.Band.Height, ReportUnit.ToDpi(), ReportUnit.HundredthsOfAnInch.ToDpi())
        'Dim bandWidth As Integer = GraphicsUnitConverter.Convert(XrTable4.Width, ReportUnit.ToDpi(), ReportUnit.HundredthsOfAnInch.ToDpi())
        'If bandHeight <= 30 Then
        '    Return
        'End If

        '' Obtain the empty space dimensions.
        'Dim size As New Size(bandWidth, bandHeight)
        'Dim sizeInPixels As Size = XRConvert.Convert(size, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel)

        'Dim XRlabelFiller As New XRLabel()
        'XRlabelFiller.BackColor = Color.Transparent
        'XRlabelFiller.Size = size
        'XRlabelFiller.Location = New Point(0, 0)
        'XRlabelFiller.Borders = BorderSide.Left + BorderSide.Right
        'e.Band.Controls.Add(XRlabelFiller)
    End Sub
End Class