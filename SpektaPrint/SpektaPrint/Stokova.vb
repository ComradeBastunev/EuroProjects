Imports DevExpress.XtraEditors.Controls

Public Class Stokova
    Private Sub Stokova_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        If gShowCodes <> 0 Then XrTableCell31.DataBindings.Clear()

        If Not CBool(ShowCarData.Value) Then
            XrTableCarDetails.HeightF = 0
            XrTableCarDetails.Visible = False
            XrTableColumnHeader.TopF = XrTableCarDetails.TopF + 5
            PageHeader.HeightF = XrTableColumnHeader.TopF + XrTableColumnHeader.HeightF
        End If
        If Not CBool(ShowTO.Value) Then
            Dim TableWidth = XrTable4.WidthF
            Dim newW = XrTableCellDisc.WidthF + XrTableCellPrice.WidthF
            Dim PriceW = XrTableCellPriceDisc.WidthF
            Dim QuantW = XrTableCellQuant.WidthF
            Dim QTypW = XrTableCellQtyp.WidthF
            Dim SummW = XrTableCellSum.WidthF
            XrTableCellPriceDiscLabel.Text = XrTableCellPriceLabel.Text
            XrTableCellDiscountLabel.Borders = BorderSide.Bottom + BorderSide.Top
            XrTableCellDisc.Borders = BorderSide.Bottom + BorderSide.Top
            XrTableCellPrice.Borders = BorderSide.Bottom + BorderSide.Top
            XrTableCellPriceLabel.Borders = BorderSide.Bottom + BorderSide.Top
            XrTableCellDescription.WidthF = XrTableCellDescription.WidthF + newW
            XrTableCellDescrLabel.WidthF = XrTableCellDescription.WidthF
            XrTableCellQtyp.WidthF = QTypW
            XrTableCellQtypLabel.WidthF = QTypW
            XrTableCellQuant.WidthF = QuantW
            XrTableCellQuantLabel.WidthF = QuantW
            XrTableCellPriceLabel.WidthF = 0
            XrTableCellPriceLabel.Visible = False
            XrTableCellPrice.WidthF = 0
            XrTableCellPrice.Visible = False
            XrTableCellDiscountLabel.WidthF = 0
            XrTableCellDiscountLabel.Visible = False
            XrTableCellDisc.WidthF = 0
            XrTableCellDisc.Visible = False
            XrTable4.WidthF = TableWidth
            XrTableColumnHeader.WidthF = TableWidth
        End If



        ZPrint_PSTableAdapter1.Connection.ConnectionString = gConnStr
        ZPrint_PSTableAdapter1.Fill(DataSet11.zPrint_PS, CDec(gStore), CDec(gDocNo))
        If DataSet11.zPrint_PS.Count <> 0 Then
            If Not DataSet11.zPrint_PS.First.IsBank_AccNull Then
                Bank_accTableAdapter1.Connection.ConnectionString = gConnStr
                Bank_accTableAdapter1.Fill(DataSet11.bank_acc, CDec(gBankAcc))
            End If
        End If
        SummaryTableAdapter1.Connection.ConnectionString = gConnStr
        SummaryTableAdapter1.Fill(DataSet11.SUMMARY)
        If DataSet11.zPrint_PS.Count <> 0 Then
            gService = DataSet11.zPrint_PS.First.Service
            StoresTableAdapter1.Connection.ConnectionString = gConnStr
            StoresTableAdapter1.Fill(DataSet11.STORES, CDec(gService), False)
        End If

    End Sub
End Class