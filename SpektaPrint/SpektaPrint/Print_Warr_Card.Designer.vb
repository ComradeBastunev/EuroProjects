<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Print_Warr_Card
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
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Print_Warr_Card))
        Me.Inv_Rows_ListTableAdapter1 = New SpektaPrint.DataSet1TableAdapters.Inv_Rows_ListTableAdapter()
        Me.DataSet11 = New SpektaPrint.DataSet1()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Code = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Inv_No = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.StoresTableAdapter1 = New SpektaPrint.DataSet1TableAdapters.STORESTableAdapter()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Get_InvoiceTableAdapter1 = New SpektaPrint.DataSet1TableAdapters.Get_InvoiceTableAdapter()
        Me.ZInvoice_Rows_PrintTableAdapter = New SpektaPrint.DataSet1TableAdapters.zInvoice_Rows_PrintTableAdapter()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Inv_Rows_ListTableAdapter1
        '
        Me.Inv_Rows_ListTableAdapter1.ClearBeforeFill = True
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 71.4375!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Dpi = 254.0!
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1950.0!, 71.4375!)
        Me.XrTable1.StylePriority.UseFont = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRow1.Dpi = 254.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 0.62790704692255028R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Name = "XrTableCell1"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell1.Summary = XrSummary1
        Me.XrTableCell1.Weight = 0.15865385789137623R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Inv_Rows_List.Description")})
        Me.XrTableCell2.Dpi = 254.0!
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Weight = 2.38703834880272R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Inv_Rows_List.Quant", "{0:0}")})
        Me.XrTableCell3.Dpi = 254.0!
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "XrTableCell3"
        Me.XrTableCell3.Weight = 0.99761487992007691R
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 75.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 75.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Code
        '
        Me.Code.Description = "Артикул"
        DynamicListLookUpSettings1.DataAdapter = Me.Inv_Rows_ListTableAdapter1
        DynamicListLookUpSettings1.DataMember = "Inv_Rows_List"
        DynamicListLookUpSettings1.DataSource = Me.DataSet11
        DynamicListLookUpSettings1.DisplayMember = "Description"
        DynamicListLookUpSettings1.FilterString = "[Inv_No] = ?Inv_No And [Invr_Type] = 2.0m"
        DynamicListLookUpSettings1.ValueMember = "Code"
        Me.Code.LookUpSettings = DynamicListLookUpSettings1
        Me.Code.Name = "Code"
        '
        'Inv_No
        '
        Me.Inv_No.Name = "Inv_No"
        Me.Inv_No.Type = GetType(Decimal)
        Me.Inv_No.ValueInfo = "0"
        Me.Inv_No.Visible = False
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1, Me.XrTable2})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 580.7916!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrTable2
        '
        Me.XrTable2.Dpi = 254.0!
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0001614888!, 318.8542!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5, Me.XrTableRow4, Me.XrTableRow3, Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(1950.0!, 261.9374!)
        Me.XrTable2.StylePriority.UseFont = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow2.Dpi = 254.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.StylePriority.UseBorders = False
        Me.XrTableRow2.StylePriority.UseTextAlignment = False
        Me.XrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.XrTableRow2.Weight = 0.697674383515468R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Dpi = 254.0!
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseFont = False
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        Me.XrTableCell4.Summary = XrSummary2
        Me.XrTableCell4.Text = "No"
        Me.XrTableCell4.Weight = 0.15865385789137623R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Dpi = 254.0!
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.Text = "Наименование"
        Me.XrTableCell5.Weight = 2.3870374615563543R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Dpi = 254.0!
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.Text = "Кол-во"
        Me.XrTableCell6.Weight = 0.99761576716644274R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText1})
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.HeightF = 2095.5!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrRichText1
        '
        Me.XrRichText1.Dpi = 254.0!
        Me.XrRichText1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(1950.0!, 2095.5!)
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "STORES.zEmblemHeader")})
        Me.XrPictureBox1.Dpi = 254.0!
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(1941.037!, 290.0!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'StoresTableAdapter1
        '
        Me.StoresTableAdapter1.ClearBeforeFill = True
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell17, Me.XrTableCell9})
        Me.XrTableRow3.Dpi = 254.0!
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 0.4883714917506079R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Dpi = 254.0!
        Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.Text = "Клиент"
        Me.XrTableCell7.Weight = 0.28365382554385243R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Get_Invoice.Firm")})
        Me.XrTableCell8.Dpi = 254.0!
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Weight = 1.7221192447840261R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Dpi = 254.0!
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Text = "СПЕКТА АУТО ЕООД"
        Me.XrTableCell9.Weight = 0.99761512871874525R
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell15, Me.XrTableCell14, Me.XrTableCell16, Me.XrTableCell12})
        Me.XrTableRow4.Dpi = 254.0!
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 0.48837216234388658R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Dpi = 254.0!
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.Text = "Към фактура / касова бележка"
        Me.XrTableCell10.Weight = 1.0336540612186682R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Get_Invoice.Inv_No", "{0:0000000000}")})
        Me.XrTableCell11.Dpi = 254.0!
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Weight = 0.56730742031122827R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "STORES.STORE_NAME")})
        Me.XrTableCell12.Dpi = 254.0!
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Weight = 0.99761569674126238R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell13})
        Me.XrTableRow5.Dpi = 254.0!
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 0.62790706587071132R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Dpi = 254.0!
        Me.XrTableCell13.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "ГАРАНЦИОННА КАРТА"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell13.Weight = 3.5433070866141732R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Get_Invoice.Inv_Date", "{0:dd.MM.yyyy}")})
        Me.XrTableCell14.Dpi = 254.0!
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Weight = 0.46996161846158596R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Dpi = 254.0!
        Me.XrTableCell15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.Text = "Дата"
        Me.XrTableCell15.Weight = 0.22476922758993123R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Dpi = 254.0!
        Me.XrTableCell16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 254.0!)
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.StylePriority.UsePadding = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.Text = "Място"
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell16.Weight = 0.24999906229149704R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Dpi = 254.0!
        Me.XrTableCell17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 254.0!)
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.StylePriority.UsePadding = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        Me.XrTableCell17.Text = "Доставчик"
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell17.Weight = 0.53991888756754891R
        '
        'Get_InvoiceTableAdapter1
        '
        Me.Get_InvoiceTableAdapter1.ClearBeforeFill = True
        '
        'ZInvoice_Rows_PrintTableAdapter
        '
        Me.ZInvoice_Rows_PrintTableAdapter.ClearBeforeFill = True
        '
        'Print_Warr_Card
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
        Me.DataMember = "Inv_Rows_List"
        Me.DataSource = Me.DataSet11
        Me.Dpi = 254.0!
        Me.Margins = New System.Drawing.Printing.Margins(80, 70, 75, 75)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Inv_No, Me.Code})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 25.0!
        Me.Version = "16.2"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Code As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents Inv_Rows_ListTableAdapter1 As DataSet1TableAdapters.Inv_Rows_ListTableAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents Inv_No As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents StoresTableAdapter1 As DataSet1TableAdapters.STORESTableAdapter
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Get_InvoiceTableAdapter1 As DataSet1TableAdapters.Get_InvoiceTableAdapter
    Friend WithEvents ZInvoice_Rows_PrintTableAdapter As DataSet1TableAdapters.zInvoice_Rows_PrintTableAdapter
End Class
