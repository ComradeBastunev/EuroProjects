<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Report_Order_Jobs
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DataSet11 = New StarMotorsPrint.DataSet1()
        Me.Get_InvoiceTableAdapter = New StarMotorsPrint.DataSet1TableAdapters.Get_InvoiceTableAdapter()
        Me.OrderS_PTableAdapter1 = New StarMotorsPrint.DataSet1TableAdapters.ORDERS_PTableAdapter()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.SUMMEUR = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ZOrder_JobsTableAdapter = New StarMotorsPrint.DataSet1TableAdapters.zOrder_JobsTableAdapter()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 50.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.BorderWidth = 0.5!
        Me.XrTable2.Dpi = 254.0!
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(1940.0!, 50.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseBorderWidth = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UsePadding = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell13, Me.XrTableCell12})
        Me.XrTableRow4.Dpi = 254.0!
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.StylePriority.UseTextAlignment = False
        Me.XrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableRow4.Weight = 0.78740171671019721R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Dpi = 254.0!
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell8.Summary = XrSummary1
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell8.Weight = 0.24307335135862992R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Dpi = 254.0!
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "[DESCRIPTION]"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell9.Weight = 1.3968751337110383R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Dpi = 254.0!
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "[empl_id]-[Empl_Name]"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell10.Weight = 0.47954228194718507R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Dpi = 254.0!
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "[QUANT!0.####]"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell11.Weight = 0.266365971516088R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORDERS_P.SUMMEUR", "{0:0.00}")})
        Me.XrTableCell12.Dpi = 254.0!
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell12.Weight = 0.302980072965327R
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 100.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Get_InvoiceTableAdapter
        '
        Me.Get_InvoiceTableAdapter.ClearBeforeFill = True
        '
        'OrderS_PTableAdapter1
        '
        Me.OrderS_PTableAdapter1.ClearBeforeFill = True
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 100.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.BorderWidth = 0.5!
        Me.XrTable1.Dpi = 254.0!
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2, Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1940.0!, 100.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseBorderWidth = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UsePadding = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4})
        Me.XrTableRow2.Dpi = 254.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 0.78740171671019721R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Dpi = 254.0!
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.Text = "1. Труд"
        Me.XrTableCell4.Weight = 3.0R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell3})
        Me.XrTableRow1.Dpi = 254.0!
        Me.XrTableRow1.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.StylePriority.UseBorders = False
        Me.XrTableRow1.StylePriority.UseFont = False
        Me.XrTableRow1.StylePriority.UseTextAlignment = False
        Me.XrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableRow1.Weight = 0.78740171671019721R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "No."
        Me.XrTableCell1.Weight = 0.24307335135862992R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Dpi = 254.0!
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "Операции"
        Me.XrTableCell2.Weight = 1.3968751337110383R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Dpi = 254.0!
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "Извършил"
        Me.XrTableCell5.Weight = 0.47954228194718507R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Dpi = 254.0!
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "Количество"
        Me.XrTableCell6.Weight = 0.266365971516088R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Dpi = 254.0!
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "Стойност EUR"
        Me.XrTableCell3.Weight = 0.30298023813778596R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.HeightF = 50.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.BorderWidth = 0.5!
        Me.XrTable3.Dpi = 254.0!
        Me.XrTable3.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(1060.5!, 0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(879.5002!, 50.0!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseBorderWidth = False
        Me.XrTable3.StylePriority.UseFont = False
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell23, Me.XrTableCell14, Me.XrTableCell24})
        Me.XrTableRow3.Dpi = 254.0!
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.StylePriority.UseTextAlignment = False
        Me.XrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableRow3.Weight = 0.78740171671019721R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Dpi = 254.0!
        Me.XrTableCell23.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.StylePriority.UsePadding = False
        Me.XrTableCell23.StylePriority.UseTextAlignment = False
        Me.XrTableCell23.Text = "Общо труд:"
        Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell23.Weight = 0.74590826448719094R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORDERS_P.SUMMEUR")})
        Me.XrTableCell24.Dpi = 254.0!
        Me.XrTableCell24.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell24.StylePriority.UseFont = False
        Me.XrTableCell24.StylePriority.UsePadding = False
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:0.00}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell24.Summary = XrSummary3
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell24.Weight = 0.30298056093023717R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Dpi = 254.0!
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "Стойност BGN"
        Me.XrTableCell7.Weight = 0.31116302332927281R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORDERS_P.SUMM", "{0:0.00}")})
        Me.XrTableCell13.Dpi = 254.0!
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell13.Weight = 0.31116318850173169R
        '
        'SUMMEUR
        '
        Me.SUMMEUR.DataMember = "ORDERS_P"
        Me.SUMMEUR.Expression = "[SUMM]/1.95583"
        Me.SUMMEUR.Name = "SUMMEUR"
        '
        'XrTableCell14
        '
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ORDERS_P.SUMM")})
        Me.XrTableCell14.Dpi = 254.0!
        Me.XrTableCell14.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.StylePriority.UsePadding = False
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell14.Summary = XrSummary2
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell14.Weight = 0.31116344257608364R
        '
        'ZOrder_JobsTableAdapter
        '
        Me.ZOrder_JobsTableAdapter.ClearBeforeFill = True
        '
        'Report_Order_Jobs
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.SUMMEUR})
        Me.DataMember = "ORDERS_P"
        Me.DataSource = Me.DataSet11
        Me.Dpi = 254.0!
        Me.Margins = New System.Drawing.Printing.Margins(100, 60, 100, 100)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 25.0!
        Me.Version = "16.2"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents Get_InvoiceTableAdapter As DataSet1TableAdapters.Get_InvoiceTableAdapter
    Friend WithEvents OrderS_PTableAdapter1 As DataSet1TableAdapters.ORDERS_PTableAdapter
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents SUMMEUR As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents ZOrder_JobsTableAdapter As DataSet1TableAdapters.zOrder_JobsTableAdapter
End Class
