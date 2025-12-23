<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Order_Print
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order_Print))
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Dim EaN13Generator1 As DevExpress.XtraPrinting.BarCode.EAN13Generator = New DevExpress.XtraPrinting.BarCode.EAN13Generator()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim ShapeRectangle2 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Dim ShapeRectangle3 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Dim ShapeRectangle4 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell78 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell76 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell77 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell101 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell75 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DataSet11 = New MototomPrint.DataSet1()
        Me.NoRefNo = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Get_InvoiceTableAdapter = New MototomPrint.DataSet1TableAdapters.Get_InvoiceTableAdapter()
        Me.ZOrder_ComplaintsTableAdapter = New MototomPrint.DataSet1TableAdapters.zOrder_ComplaintsTableAdapter()
        Me.Empl_SummaryTableAdapter1 = New MototomPrint.DataSet1TableAdapters.Empl_SummaryTableAdapter()
        Me.ZOrder_JobsTableAdapter = New MototomPrint.DataSet1TableAdapters.zOrder_JobsTableAdapter()
        Me.Get_EmblemTableAdapter1 = New MototomPrint.DataSet1TableAdapters.Get_EmblemTableAdapter()
        Me.SummaryTableAdapter1 = New MototomPrint.DataSet1TableAdapters.SUMMARYTableAdapter()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow28 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell82 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrTableCell86 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell87 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ReportHeader2 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTable8 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow34 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell94 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell95 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell134 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell96 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrPictureBoxToyota = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrBarCode2 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrTableCell127 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow21 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell128 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell114 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell108 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell115 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell109 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell116 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell110 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell117 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell111 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell118 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell112 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell119 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell113 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow22 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell120 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell121 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell122 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell123 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell92 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell124 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell98 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell125 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow25 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell97 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell93 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow24 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell126 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell91 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell100 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell99 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow26 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell89 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow27 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell85 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell102 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell90 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow23 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell79 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow36 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCellComplaints = New DevExpress.XtraReports.UI.XRTableCell()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrPageBreak2 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.XrRichText3 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape3 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape4 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow20 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow31 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrRichText2 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrTableRow32 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrShape5 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow33 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.OrderS_PTableAdapter1 = New MototomPrint.DataSet1TableAdapters.ORDERS_PTableAdapter()
        Me.OrderS_PTableAdapter2 = New MototomPrint.DataSet1TableAdapters.ORDERS_PTableAdapter()
        Me.CalculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 38.49999!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable3
        '
        Me.XrTable3.Dpi = 254.0!
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(9.074381!, 0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(1929.92505!, 38.49999!)
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell10, Me.XrTableCell78, Me.XrTableCell76, Me.XrTableCell77, Me.XrTableCell101, Me.XrTableCell75})
        Me.XrTableRow4.Dpi = 254.0!
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 0.60629909245047986R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zOrder_Jobs.Code")})
        Me.XrTableCell4.Dpi = 254.0!
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.Weight = 0.49239293837992215R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zOrder_Jobs.DESCRIPTION")})
        Me.XrTableCell10.Dpi = 254.0!
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.Weight = 0.98189781137795451R
        '
        'XrTableCell78
        '
        Me.XrTableCell78.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zOrder_Jobs.Row_Type")})
        Me.XrTableCell78.Dpi = 254.0!
        Me.XrTableCell78.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrTableCell78.Name = "XrTableCell78"
        Me.XrTableCell78.StylePriority.UseFont = False
        Me.XrTableCell78.Weight = 0.39869426191273127R
        '
        'XrTableCell76
        '
        Me.XrTableCell76.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zOrder_Jobs.QUANT", "{0:0.00;;#}")})
        Me.XrTableCell76.Dpi = 254.0!
        Me.XrTableCell76.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrTableCell76.Name = "XrTableCell76"
        Me.XrTableCell76.StylePriority.UseFont = False
        Me.XrTableCell76.StylePriority.UseTextAlignment = False
        Me.XrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell76.Weight = 0.20640358493435518R
        '
        'XrTableCell77
        '
        Me.XrTableCell77.Dpi = 254.0!
        Me.XrTableCell77.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrTableCell77.Name = "XrTableCell77"
        Me.XrTableCell77.StylePriority.UseFont = False
        Me.XrTableCell77.StylePriority.UseTextAlignment = False
        Me.XrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell77.Weight = 0.21410301170340454R
        '
        'XrTableCell101
        '
        Me.XrTableCell101.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zOrder_Jobs.Summ_Vat", "{0:0.00;;#}")})
        Me.XrTableCell101.Dpi = 254.0!
        Me.XrTableCell101.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrTableCell101.Name = "XrTableCell101"
        Me.XrTableCell101.StylePriority.UseFont = False
        Me.XrTableCell101.StylePriority.UseTextAlignment = False
        Me.XrTableCell101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell101.Weight = 0.34327826044413917R
        '
        'XrTableCell75
        '
        Me.XrTableCell75.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zOrder_Jobs.CalculatedField1", "{0:0.00;;#}")})
        Me.XrTableCell75.Dpi = 254.0!
        Me.XrTableCell75.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrTableCell75.Name = "XrTableCell75"
        Me.XrTableCell75.StylePriority.UseFont = False
        Me.XrTableCell75.StylePriority.UseTextAlignment = False
        Me.XrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell75.Weight = 0.36323013124749293R
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 87.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 79.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NoRefNo
        '
        Me.NoRefNo.Condition = "IsNullOrEmpty([Ref_No])"
        Me.NoRefNo.DataMember = "zOrder_Complaints"
        '
        '
        '
        Me.NoRefNo.Formatting.ForeColor = System.Drawing.Color.Transparent
        Me.NoRefNo.Name = "NoRefNo"
        '
        'Get_InvoiceTableAdapter
        '
        Me.Get_InvoiceTableAdapter.ClearBeforeFill = True
        '
        'ZOrder_ComplaintsTableAdapter
        '
        Me.ZOrder_ComplaintsTableAdapter.ClearBeforeFill = True
        '
        'Empl_SummaryTableAdapter1
        '
        Me.Empl_SummaryTableAdapter1.ClearBeforeFill = True
        '
        'ZOrder_JobsTableAdapter
        '
        Me.ZOrder_JobsTableAdapter.ClearBeforeFill = True
        '
        'Get_EmblemTableAdapter1
        '
        Me.Get_EmblemTableAdapter1.ClearBeforeFill = True
        '
        'SummaryTableAdapter1
        '
        Me.SummaryTableAdapter1.ClearBeforeFill = True
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable6})
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 63.5!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrTable6
        '
        Me.XrTable6.BackColor = System.Drawing.Color.Gainsboro
        Me.XrTable6.Dpi = 254.0!
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow28})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(1939.0!, 63.5!)
        Me.XrTable6.StylePriority.UseBackColor = False
        '
        'XrTableRow28
        '
        Me.XrTableRow28.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell82, Me.XrTableCell86, Me.XrTableCell87})
        Me.XrTableRow28.Dpi = 254.0!
        Me.XrTableRow28.Name = "XrTableRow28"
        Me.XrTableRow28.Weight = 1.0R
        '
        'XrTableCell82
        '
        Me.XrTableCell82.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.XrTableCell82.Dpi = 254.0!
        Me.XrTableCell82.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell82.Name = "XrTableCell82"
        Me.XrTableCell82.StylePriority.UseFont = False
        Me.XrTableCell82.Text = "XrTableCell82"
        Me.XrTableCell82.Weight = 1.106868710773921R
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 254.0!
        Me.XrPageInfo1.Format = "{0:'Дата и час:' dd.MM.yyyy HH:mm}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(4.53751421!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(613.6271!, 58.42!)
        '
        'XrTableCell86
        '
        Me.XrTableCell86.Dpi = 254.0!
        Me.XrTableCell86.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell86.Name = "XrTableCell86"
        Me.XrTableCell86.StylePriority.UseFont = False
        Me.XrTableCell86.Text = "Поръчка [Order_No]"
        Me.XrTableCell86.Weight = 1.106868710773921R
        '
        'XrTableCell87
        '
        Me.XrTableCell87.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2})
        Me.XrTableCell87.Dpi = 254.0!
        Me.XrTableCell87.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell87.Name = "XrTableCell87"
        Me.XrTableCell87.StylePriority.UseFont = False
        Me.XrTableCell87.StylePriority.UseTextAlignment = False
        Me.XrTableCell87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell87.Weight = 0.786262744990678R
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Dpi = 254.0!
        Me.XrPageInfo2.Format = "{0:Стр\. 0}{1: от 0}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(499.112915!, 58.42!)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 134.9375!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportHeader
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Dpi = 254.0!
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(212.4731!, 134.9375!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'ReportHeader2
        '
        Me.ReportHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable8, Me.XrPictureBoxToyota, Me.XrTable1, Me.XrLabel1})
        Me.ReportHeader2.Dpi = 254.0!
        Me.ReportHeader2.HeightF = 1330.854!
        Me.ReportHeader2.Name = "ReportHeader2"
        '
        'XrTable8
        '
        Me.XrTable8.BackColor = System.Drawing.Color.Gainsboro
        Me.XrTable8.Dpi = 254.0!
        Me.XrTable8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1267.354!)
        Me.XrTable8.Name = "XrTable8"
        Me.XrTable8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow34})
        Me.XrTable8.SizeF = New System.Drawing.SizeF(1929.92505!, 63.5!)
        Me.XrTable8.StylePriority.UseBackColor = False
        Me.XrTable8.StylePriority.UseFont = False
        '
        'XrTableRow34
        '
        Me.XrTableRow34.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell32, Me.XrTableCell51, Me.XrTableCell52, Me.XrTableCell94, Me.XrTableCell95, Me.XrTableCell134, Me.XrTableCell96})
        Me.XrTableRow34.Dpi = 254.0!
        Me.XrTableRow34.Name = "XrTableRow34"
        Me.XrTableRow34.Weight = 1.0R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Dpi = 254.0!
        Me.XrTableCell32.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.StylePriority.UseFont = False
        Me.XrTableCell32.Text = "Код"
        Me.XrTableCell32.Weight = 0.50769214663196094R
        '
        'XrTableCell51
        '
        Me.XrTableCell51.Dpi = 254.0!
        Me.XrTableCell51.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell51.Name = "XrTableCell51"
        Me.XrTableCell51.StylePriority.UseFont = False
        Me.XrTableCell51.Text = "Описание"
        Me.XrTableCell51.Weight = 0.97714221007070423R
        '
        'XrTableCell52
        '
        Me.XrTableCell52.Dpi = 254.0!
        Me.XrTableCell52.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell52.Name = "XrTableCell52"
        Me.XrTableCell52.StylePriority.UseFont = False
        Me.XrTableCell52.Text = "Тип"
        Me.XrTableCell52.Weight = 0.40670343916894997R
        '
        'XrTableCell94
        '
        Me.XrTableCell94.Dpi = 254.0!
        Me.XrTableCell94.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell94.Name = "XrTableCell94"
        Me.XrTableCell94.StylePriority.UseFont = False
        Me.XrTableCell94.StylePriority.UseTextAlignment = False
        Me.XrTableCell94.Text = "к-во"
        Me.XrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell94.Weight = 0.20688994808015168R
        '
        'XrTableCell95
        '
        Me.XrTableCell95.Dpi = 254.0!
        Me.XrTableCell95.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell95.Name = "XrTableCell95"
        Me.XrTableCell95.StylePriority.UseFont = False
        Me.XrTableCell95.StylePriority.UseTextAlignment = False
        Me.XrTableCell95.Text = "к-во в ВО"
        Me.XrTableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell95.Weight = 0.2004678294118635R
        '
        'XrTableCell134
        '
        Me.XrTableCell134.Dpi = 254.0!
        Me.XrTableCell134.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell134.Name = "XrTableCell134"
        Me.XrTableCell134.StylePriority.UseFont = False
        Me.XrTableCell134.StylePriority.UseTextAlignment = False
        Me.XrTableCell134.Text = "Ст-ст BGN с ДДС"
        Me.XrTableCell134.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell134.Weight = 0.3582269004417345R
        '
        'XrTableCell96
        '
        Me.XrTableCell96.Dpi = 254.0!
        Me.XrTableCell96.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell96.Name = "XrTableCell96"
        Me.XrTableCell96.StylePriority.UseFont = False
        Me.XrTableCell96.StylePriority.UseTextAlignment = False
        Me.XrTableCell96.Text = "Ст-ст EUR с ДДС"
        Me.XrTableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell96.Weight = 0.34994711242346316R
        '
        'XrPictureBoxToyota
        '
        Me.XrPictureBoxToyota.Dpi = 254.0!
        Me.XrPictureBoxToyota.Image = CType(resources.GetObject("XrPictureBoxToyota.Image"), System.Drawing.Image)
        Me.XrPictureBoxToyota.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPictureBoxToyota.Name = "XrPictureBoxToyota"
        Me.XrPictureBoxToyota.SizeF = New System.Drawing.SizeF(212.4731!, 134.9375!)
        Me.XrPictureBoxToyota.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrTable1
        '
        Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable1.Dpi = 254.0!
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(4.53751421!, 216.078003!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow14, Me.XrTableRow8, Me.XrTableRow21, Me.XrTableRow18, Me.XrTableRow17, Me.XrTableRow16, Me.XrTableRow15, Me.XrTableRow12, Me.XrTableRow9, Me.XrTableRow7, Me.XrTableRow22, Me.XrTableRow6, Me.XrTableRow1, Me.XrTableRow2, Me.XrTableRow3, Me.XrTableRow25, Me.XrTableRow24, Me.XrTableRow26, Me.XrTableRow5})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1929.92505!, 1051.276!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UsePadding = False
        '
        'XrTableRow14
        '
        Me.XrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell41, Me.XrTableCell43})
        Me.XrTableRow14.Dpi = 254.0!
        Me.XrTableRow14.Name = "XrTableRow14"
        Me.XrTableRow14.Weight = 0.83412012966708837R
        '
        'XrTableCell41
        '
        Me.XrTableCell41.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell41.Dpi = 254.0!
        Me.XrTableCell41.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.StylePriority.UseBorders = False
        Me.XrTableCell41.StylePriority.UseFont = False
        Me.XrTableCell41.Text = "Дата издаване поръчка:[Date_Created!dd.MM.yyyy]"
        Me.XrTableCell41.Weight = 2.0368245825810241R
        '
        'XrTableCell43
        '
        Me.XrTableCell43.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell43.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrShape1})
        Me.XrTableCell43.Dpi = 254.0!
        Me.XrTableCell43.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.StylePriority.UseBorders = False
        Me.XrTableCell43.StylePriority.UseFont = False
        Me.XrTableCell43.Weight = 0.96317541741897617R
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 13.21641!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(437.9048!, 53.3071518!)
        Me.XrLabel4.Text = "Повторен ремонт"
        '
        'XrShape1
        '
        Me.XrShape1.Dpi = 254.0!
        Me.XrShape1.LocationFloat = New DevExpress.Utils.PointFloat(492.568512!, 13.21641!)
        Me.XrShape1.Name = "XrShape1"
        Me.XrShape1.Shape = ShapeRectangle1
        Me.XrShape1.SizeF = New System.Drawing.SizeF(111.125!, 53.3071518!)
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell21, Me.XrTableCell22, Me.XrTableCell127, Me.XrTableCell23})
        Me.XrTableRow8.Dpi = 254.0!
        Me.XrTableRow8.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.StylePriority.UseFont = False
        Me.XrTableRow8.Weight = 0.99999674746429723R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell21.Dpi = 254.0!
        Me.XrTableCell21.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseBorders = False
        Me.XrTableCell21.StylePriority.UseFont = False
        Me.XrTableCell21.Text = "Поръчка № [Order_No]"
        Me.XrTableCell21.Weight = 0.94680843072319987R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell22.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode2})
        Me.XrTableCell22.Dpi = 254.0!
        Me.XrTableCell22.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseBorders = False
        Me.XrTableCell22.StylePriority.UseFont = False
        Me.XrTableCell22.Weight = 0.96865678154163626R
        '
        'XrBarCode2
        '
        Me.XrBarCode2.AutoModule = True
        Me.XrBarCode2.Dpi = 254.0!
        Me.XrBarCode2.LocationFloat = New DevExpress.Utils.PointFloat(137.6187!, 10.66634!)
        Me.XrBarCode2.Name = "XrBarCode2"
        Me.XrBarCode2.Padding = New DevExpress.XtraPrinting.PaddingInfo(25, 25, 0, 0, 254.0!)
        Me.XrBarCode2.ShowText = False
        Me.XrBarCode2.SizeF = New System.Drawing.SizeF(325.4375!, 58.41998!)
        Me.XrBarCode2.Symbology = EaN13Generator1
        '
        'XrTableCell127
        '
        Me.XrTableCell127.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell127.Dpi = 254.0!
        Me.XrTableCell127.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell127.Name = "XrTableCell127"
        Me.XrTableCell127.StylePriority.UseBorders = False
        Me.XrTableCell127.StylePriority.UseFont = False
        Me.XrTableCell127.Text = "Приемчик:"
        Me.XrTableCell127.Weight = 0.30162817062165814R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell23.Dpi = 254.0!
        Me.XrTableCell23.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell23.FormattingRules.Add(Me.NoRefNo)
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.StylePriority.UseBorders = False
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.Text = "[Empl_Name]"
        Me.XrTableCell23.Weight = 0.78290661711350584R
        '
        'XrTableRow21
        '
        Me.XrTableRow21.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell128, Me.XrTableCell42, Me.XrTableCell54, Me.XrTableCell55})
        Me.XrTableRow21.Dpi = 254.0!
        Me.XrTableRow21.Name = "XrTableRow21"
        Me.XrTableRow21.Weight = 0.68962941678731582R
        '
        'XrTableCell128
        '
        Me.XrTableCell128.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell128.Dpi = 254.0!
        Me.XrTableCell128.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell128.Name = "XrTableCell128"
        Me.XrTableCell128.StylePriority.UseBorders = False
        Me.XrTableCell128.StylePriority.UseFont = False
        Me.XrTableCell128.Text = "Планиран дата/час: "
        Me.XrTableCell128.Weight = 0.51295710187999788R
        '
        'XrTableCell42
        '
        Me.XrTableCell42.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell42.Dpi = 254.0!
        Me.XrTableCell42.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.StylePriority.UseBorders = False
        Me.XrTableCell42.StylePriority.UseFont = False
        Me.XrTableCell42.Text = "[Date_Created!dd.MM.yyyy]"
        Me.XrTableCell42.Weight = 0.73620131789439791R
        '
        'XrTableCell54
        '
        Me.XrTableCell54.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell54.Dpi = 254.0!
        Me.XrTableCell54.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.XrTableCell54.Name = "XrTableCell54"
        Me.XrTableCell54.StylePriority.UseBorders = False
        Me.XrTableCell54.StylePriority.UseFont = False
        Me.XrTableCell54.Weight = 0.66630683992893258R
        '
        'XrTableCell55
        '
        Me.XrTableCell55.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell55.Dpi = 254.0!
        Me.XrTableCell55.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.XrTableCell55.Name = "XrTableCell55"
        Me.XrTableCell55.StylePriority.UseBorders = False
        Me.XrTableCell55.StylePriority.UseFont = False
        Me.XrTableCell55.Weight = 1.0845347402966719R
        '
        'XrTableRow18
        '
        Me.XrTableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell71, Me.XrTableCell72, Me.XrTableCell73})
        Me.XrTableRow18.Dpi = 254.0!
        Me.XrTableRow18.Name = "XrTableRow18"
        Me.XrTableRow18.Weight = 0.62693577301788683R
        '
        'XrTableCell71
        '
        Me.XrTableCell71.BackColor = System.Drawing.Color.Gainsboro
        Me.XrTableCell71.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell71.Dpi = 254.0!
        Me.XrTableCell71.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell71.Name = "XrTableCell71"
        Me.XrTableCell71.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell71.StylePriority.UseBackColor = False
        Me.XrTableCell71.StylePriority.UseBorders = False
        Me.XrTableCell71.StylePriority.UseFont = False
        Me.XrTableCell71.StylePriority.UsePadding = False
        Me.XrTableCell71.StylePriority.UseTextAlignment = False
        Me.XrTableCell71.Text = "Данни клиент"
        Me.XrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell71.Weight = 0.75R
        '
        'XrTableCell72
        '
        Me.XrTableCell72.BackColor = System.Drawing.Color.Gainsboro
        Me.XrTableCell72.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell72.Dpi = 254.0!
        Me.XrTableCell72.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell72.Name = "XrTableCell72"
        Me.XrTableCell72.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell72.StylePriority.UseBackColor = False
        Me.XrTableCell72.StylePriority.UseBorders = False
        Me.XrTableCell72.StylePriority.UseFont = False
        Me.XrTableCell72.StylePriority.UsePadding = False
        Me.XrTableCell72.StylePriority.UseTextAlignment = False
        Me.XrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell72.Weight = 1.1654651761618919R
        '
        'XrTableCell73
        '
        Me.XrTableCell73.BackColor = System.Drawing.Color.Gainsboro
        Me.XrTableCell73.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell73.Dpi = 254.0!
        Me.XrTableCell73.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell73.Name = "XrTableCell73"
        Me.XrTableCell73.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell73.StylePriority.UseBackColor = False
        Me.XrTableCell73.StylePriority.UseBorders = False
        Me.XrTableCell73.StylePriority.UseFont = False
        Me.XrTableCell73.StylePriority.UsePadding = False
        Me.XrTableCell73.StylePriority.UseTextAlignment = False
        Me.XrTableCell73.Text = "Доставчик"
        Me.XrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell73.Weight = 1.0845348238381081R
        '
        'XrTableRow17
        '
        Me.XrTableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell114, Me.XrTableCell67, Me.XrTableCell68, Me.XrTableCell108, Me.XrTableCell69})
        Me.XrTableRow17.Dpi = 254.0!
        Me.XrTableRow17.Name = "XrTableRow17"
        Me.XrTableRow17.Weight = 0.62693582084929322R
        '
        'XrTableCell114
        '
        Me.XrTableCell114.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell114.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell114.Dpi = 254.0!
        Me.XrTableCell114.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell114.Name = "XrTableCell114"
        Me.XrTableCell114.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell114.StylePriority.UseBorderColor = False
        Me.XrTableCell114.StylePriority.UseBorders = False
        Me.XrTableCell114.StylePriority.UseFont = False
        Me.XrTableCell114.StylePriority.UsePadding = False
        Me.XrTableCell114.StylePriority.UseTextAlignment = False
        Me.XrTableCell114.Text = "Фирма: "
        Me.XrTableCell114.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell114.Weight = 0.5129570651284957R
        '
        'XrTableCell67
        '
        Me.XrTableCell67.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell67.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell67.Dpi = 254.0!
        Me.XrTableCell67.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell67.Name = "XrTableCell67"
        Me.XrTableCell67.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell67.StylePriority.UseBorderColor = False
        Me.XrTableCell67.StylePriority.UseBorders = False
        Me.XrTableCell67.StylePriority.UseFont = False
        Me.XrTableCell67.StylePriority.UsePadding = False
        Me.XrTableCell67.StylePriority.UseTextAlignment = False
        Me.XrTableCell67.Text = "[Client_No]"
        Me.XrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell67.Weight = 1.3222822677572714R
        '
        'XrTableCell68
        '
        Me.XrTableCell68.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell68.Dpi = 254.0!
        Me.XrTableCell68.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell68.Name = "XrTableCell68"
        Me.XrTableCell68.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell68.StylePriority.UseBorders = False
        Me.XrTableCell68.StylePriority.UseFont = False
        Me.XrTableCell68.StylePriority.UsePadding = False
        Me.XrTableCell68.StylePriority.UseTextAlignment = False
        Me.XrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell68.Weight = 0.080226127907078226R
        '
        'XrTableCell108
        '
        Me.XrTableCell108.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell108.Dpi = 254.0!
        Me.XrTableCell108.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell108.Name = "XrTableCell108"
        Me.XrTableCell108.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell108.StylePriority.UseBorders = False
        Me.XrTableCell108.StylePriority.UseFont = False
        Me.XrTableCell108.StylePriority.UsePadding = False
        Me.XrTableCell108.StylePriority.UseTextAlignment = False
        Me.XrTableCell108.Text = "Код :"
        Me.XrTableCell108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell108.Weight = 0.2257081712992568R
        '
        'XrTableCell69
        '
        Me.XrTableCell69.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell69.Dpi = 254.0!
        Me.XrTableCell69.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell69.Name = "XrTableCell69"
        Me.XrTableCell69.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell69.StylePriority.UseBorders = False
        Me.XrTableCell69.StylePriority.UseFont = False
        Me.XrTableCell69.StylePriority.UsePadding = False
        Me.XrTableCell69.StylePriority.UseTextAlignment = False
        Me.XrTableCell69.Text = "0001"
        Me.XrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell69.Weight = 0.858826367907898R
        '
        'XrTableRow16
        '
        Me.XrTableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell115, Me.XrTableCell48, Me.XrTableCell50, Me.XrTableCell109, Me.XrTableCell53})
        Me.XrTableRow16.Dpi = 254.0!
        Me.XrTableRow16.Name = "XrTableRow16"
        Me.XrTableRow16.Weight = 0.62693582084929322R
        '
        'XrTableCell115
        '
        Me.XrTableCell115.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell115.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell115.Dpi = 254.0!
        Me.XrTableCell115.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell115.Name = "XrTableCell115"
        Me.XrTableCell115.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell115.StylePriority.UseBorderColor = False
        Me.XrTableCell115.StylePriority.UseBorders = False
        Me.XrTableCell115.StylePriority.UseFont = False
        Me.XrTableCell115.StylePriority.UsePadding = False
        Me.XrTableCell115.StylePriority.UseTextAlignment = False
        Me.XrTableCell115.Text = "Име на клиента:"
        Me.XrTableCell115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell115.Weight = 0.5129570651284957R
        '
        'XrTableCell48
        '
        Me.XrTableCell48.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell48.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell48.Dpi = 254.0!
        Me.XrTableCell48.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell48.Name = "XrTableCell48"
        Me.XrTableCell48.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell48.StylePriority.UseBorderColor = False
        Me.XrTableCell48.StylePriority.UseBorders = False
        Me.XrTableCell48.StylePriority.UseFont = False
        Me.XrTableCell48.StylePriority.UsePadding = False
        Me.XrTableCell48.StylePriority.UseTextAlignment = False
        Me.XrTableCell48.Text = "[Firm]"
        Me.XrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell48.Weight = 1.32228245751124R
        '
        'XrTableCell50
        '
        Me.XrTableCell50.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell50.Dpi = 254.0!
        Me.XrTableCell50.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell50.StylePriority.UseBorders = False
        Me.XrTableCell50.StylePriority.UseFont = False
        Me.XrTableCell50.StylePriority.UsePadding = False
        Me.XrTableCell50.StylePriority.UseTextAlignment = False
        Me.XrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell50.Weight = 0.080225938153109425R
        '
        'XrTableCell109
        '
        Me.XrTableCell109.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell109.Dpi = 254.0!
        Me.XrTableCell109.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell109.Name = "XrTableCell109"
        Me.XrTableCell109.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell109.StylePriority.UseBorders = False
        Me.XrTableCell109.StylePriority.UseFont = False
        Me.XrTableCell109.StylePriority.UsePadding = False
        Me.XrTableCell109.StylePriority.UseTextAlignment = False
        Me.XrTableCell109.Text = "Фирма: "
        Me.XrTableCell109.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell109.Weight = 0.22570817129925686R
        '
        'XrTableCell53
        '
        Me.XrTableCell53.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell53.Dpi = 254.0!
        Me.XrTableCell53.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell53.Name = "XrTableCell53"
        Me.XrTableCell53.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell53.StylePriority.UseBorders = False
        Me.XrTableCell53.StylePriority.UseFont = False
        Me.XrTableCell53.StylePriority.UsePadding = False
        Me.XrTableCell53.StylePriority.UseTextAlignment = False
        Me.XrTableCell53.Text = "[SUMMARY.FIRM]"
        Me.XrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell53.Weight = 0.858826367907898R
        '
        'XrTableRow15
        '
        Me.XrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell116, Me.XrTableCell44, Me.XrTableCell45, Me.XrTableCell110, Me.XrTableCell46})
        Me.XrTableRow15.Dpi = 254.0!
        Me.XrTableRow15.Name = "XrTableRow15"
        Me.XrTableRow15.Weight = 0.62693582084929322R
        '
        'XrTableCell116
        '
        Me.XrTableCell116.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell116.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell116.Dpi = 254.0!
        Me.XrTableCell116.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell116.Name = "XrTableCell116"
        Me.XrTableCell116.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell116.StylePriority.UseBorderColor = False
        Me.XrTableCell116.StylePriority.UseBorders = False
        Me.XrTableCell116.StylePriority.UseFont = False
        Me.XrTableCell116.StylePriority.UsePadding = False
        Me.XrTableCell116.StylePriority.UseTextAlignment = False
        Me.XrTableCell116.Text = "Мол:"
        Me.XrTableCell116.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell116.Weight = 0.5129570651284957R
        '
        'XrTableCell44
        '
        Me.XrTableCell44.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell44.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell44.Dpi = 254.0!
        Me.XrTableCell44.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell44.StylePriority.UseBorderColor = False
        Me.XrTableCell44.StylePriority.UseBorders = False
        Me.XrTableCell44.StylePriority.UseFont = False
        Me.XrTableCell44.StylePriority.UsePadding = False
        Me.XrTableCell44.StylePriority.UseTextAlignment = False
        Me.XrTableCell44.Text = "[REPRESENT]"
        Me.XrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell44.Weight = 1.3222822677572714R
        '
        'XrTableCell45
        '
        Me.XrTableCell45.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell45.Dpi = 254.0!
        Me.XrTableCell45.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell45.Name = "XrTableCell45"
        Me.XrTableCell45.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell45.StylePriority.UseBorders = False
        Me.XrTableCell45.StylePriority.UseFont = False
        Me.XrTableCell45.StylePriority.UsePadding = False
        Me.XrTableCell45.StylePriority.UseTextAlignment = False
        Me.XrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell45.Weight = 0.080226127907078157R
        '
        'XrTableCell110
        '
        Me.XrTableCell110.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell110.Dpi = 254.0!
        Me.XrTableCell110.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell110.Name = "XrTableCell110"
        Me.XrTableCell110.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell110.StylePriority.UseBorders = False
        Me.XrTableCell110.StylePriority.UseFont = False
        Me.XrTableCell110.StylePriority.UsePadding = False
        Me.XrTableCell110.StylePriority.UseTextAlignment = False
        Me.XrTableCell110.Text = "Сервиз:"
        Me.XrTableCell110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell110.Weight = 0.2257085508071944R
        '
        'XrTableCell46
        '
        Me.XrTableCell46.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zOrder_Jobs.Service_Name")})
        Me.XrTableCell46.Dpi = 254.0!
        Me.XrTableCell46.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell46.StylePriority.UseBorders = False
        Me.XrTableCell46.StylePriority.UseFont = False
        Me.XrTableCell46.StylePriority.UsePadding = False
        Me.XrTableCell46.StylePriority.UseTextAlignment = False
        Me.XrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell46.Weight = 0.85882598839996038R
        '
        'XrTableRow12
        '
        Me.XrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell117, Me.XrTableCell36, Me.XrTableCell37, Me.XrTableCell111, Me.XrTableCell38})
        Me.XrTableRow12.Dpi = 254.0!
        Me.XrTableRow12.Name = "XrTableRow12"
        Me.XrTableRow12.Weight = 0.62693582084929322R
        '
        'XrTableCell117
        '
        Me.XrTableCell117.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell117.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell117.Dpi = 254.0!
        Me.XrTableCell117.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell117.Name = "XrTableCell117"
        Me.XrTableCell117.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell117.StylePriority.UseBorderColor = False
        Me.XrTableCell117.StylePriority.UseBorders = False
        Me.XrTableCell117.StylePriority.UseFont = False
        Me.XrTableCell117.StylePriority.UsePadding = False
        Me.XrTableCell117.StylePriority.UseTextAlignment = False
        Me.XrTableCell117.Text = "Пълен адрес: "
        Me.XrTableCell117.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell117.Weight = 0.5129570651284957R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell36.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell36.Dpi = 254.0!
        Me.XrTableCell36.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell36.StylePriority.UseBorderColor = False
        Me.XrTableCell36.StylePriority.UseBorders = False
        Me.XrTableCell36.StylePriority.UseFont = False
        Me.XrTableCell36.StylePriority.UsePadding = False
        Me.XrTableCell36.StylePriority.UseTextAlignment = False
        Me.XrTableCell36.Text = "[ADDRESS1]"
        Me.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell36.Weight = 1.3222823626342555R
        '
        'XrTableCell37
        '
        Me.XrTableCell37.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell37.Dpi = 254.0!
        Me.XrTableCell37.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell37.StylePriority.UseBorders = False
        Me.XrTableCell37.StylePriority.UseFont = False
        Me.XrTableCell37.StylePriority.UsePadding = False
        Me.XrTableCell37.StylePriority.UseTextAlignment = False
        Me.XrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell37.Weight = 0.080226033030093818R
        '
        'XrTableCell111
        '
        Me.XrTableCell111.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell111.Dpi = 254.0!
        Me.XrTableCell111.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell111.Name = "XrTableCell111"
        Me.XrTableCell111.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell111.StylePriority.UseBorders = False
        Me.XrTableCell111.StylePriority.UseFont = False
        Me.XrTableCell111.StylePriority.UsePadding = False
        Me.XrTableCell111.StylePriority.UseTextAlignment = False
        Me.XrTableCell111.Text = "Адрес: "
        Me.XrTableCell111.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell111.Weight = 0.22570855080719443R
        '
        'XrTableCell38
        '
        Me.XrTableCell38.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell38.Dpi = 254.0!
        Me.XrTableCell38.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell38.StylePriority.UseBorders = False
        Me.XrTableCell38.StylePriority.UseFont = False
        Me.XrTableCell38.StylePriority.UsePadding = False
        Me.XrTableCell38.StylePriority.UseTextAlignment = False
        Me.XrTableCell38.Text = "[SUMMARY.CITY], [SUMMARY.ADDRESS1]"
        Me.XrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell38.Weight = 0.85882598839996038R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell118, Me.XrTableCell24, Me.XrTableCell28, Me.XrTableCell112, Me.XrTableCell29})
        Me.XrTableRow9.Dpi = 254.0!
        Me.XrTableRow9.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.StylePriority.UseFont = False
        Me.XrTableRow9.Weight = 0.62693582084929322R
        '
        'XrTableCell118
        '
        Me.XrTableCell118.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell118.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell118.Dpi = 254.0!
        Me.XrTableCell118.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell118.Name = "XrTableCell118"
        Me.XrTableCell118.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell118.StylePriority.UseBorderColor = False
        Me.XrTableCell118.StylePriority.UseBorders = False
        Me.XrTableCell118.StylePriority.UseFont = False
        Me.XrTableCell118.StylePriority.UsePadding = False
        Me.XrTableCell118.StylePriority.UseTextAlignment = False
        Me.XrTableCell118.Text = "Нас.място/Пощ.код: "
        Me.XrTableCell118.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell118.Weight = 0.5129570651284957R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell24.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell24.Dpi = 254.0!
        Me.XrTableCell24.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell24.StylePriority.UseBorderColor = False
        Me.XrTableCell24.StylePriority.UseBorders = False
        Me.XrTableCell24.StylePriority.UseFont = False
        Me.XrTableCell24.StylePriority.UsePadding = False
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        Me.XrTableCell24.Text = "[CITY] [POSTAL_CODE]"
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell24.Weight = 1.3222822677572714R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell28.Dpi = 254.0!
        Me.XrTableCell28.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell28.StylePriority.UseBorders = False
        Me.XrTableCell28.StylePriority.UseFont = False
        Me.XrTableCell28.StylePriority.UsePadding = False
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell28.Weight = 0.080226127907078129R
        '
        'XrTableCell112
        '
        Me.XrTableCell112.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell112.Dpi = 254.0!
        Me.XrTableCell112.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell112.Name = "XrTableCell112"
        Me.XrTableCell112.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell112.StylePriority.UseBorders = False
        Me.XrTableCell112.StylePriority.UseFont = False
        Me.XrTableCell112.StylePriority.UsePadding = False
        Me.XrTableCell112.StylePriority.UseTextAlignment = False
        Me.XrTableCell112.Text = "Тел.: "
        Me.XrTableCell112.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell112.Weight = 0.22570874056116319R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell29.Dpi = 254.0!
        Me.XrTableCell29.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell29.StylePriority.UseBorders = False
        Me.XrTableCell29.StylePriority.UseFont = False
        Me.XrTableCell29.StylePriority.UsePadding = False
        Me.XrTableCell29.StylePriority.UseTextAlignment = False
        Me.XrTableCell29.Text = "[SUMMARY.PHONE]"
        Me.XrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell29.Weight = 0.85882579864599162R
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell119, Me.XrTableCell20, Me.XrTableCell18, Me.XrTableCell113, Me.XrTableCell19})
        Me.XrTableRow7.Dpi = 254.0!
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 0.62693582084929345R
        '
        'XrTableCell119
        '
        Me.XrTableCell119.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell119.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell119.Dpi = 254.0!
        Me.XrTableCell119.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell119.Name = "XrTableCell119"
        Me.XrTableCell119.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell119.StylePriority.UseBorderColor = False
        Me.XrTableCell119.StylePriority.UseBorders = False
        Me.XrTableCell119.StylePriority.UseFont = False
        Me.XrTableCell119.StylePriority.UsePadding = False
        Me.XrTableCell119.StylePriority.UseTextAlignment = False
        Me.XrTableCell119.Text = "Телефон: "
        Me.XrTableCell119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell119.Weight = 0.5129570651284957R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell20.Dpi = 254.0!
        Me.XrTableCell20.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell20.StylePriority.UseBorderColor = False
        Me.XrTableCell20.StylePriority.UseBorders = False
        Me.XrTableCell20.StylePriority.UseFont = False
        Me.XrTableCell20.StylePriority.UsePadding = False
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        Me.XrTableCell20.Text = "[Phone]"
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell20.Weight = 1.3222822677572714R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell18.Dpi = 254.0!
        Me.XrTableCell18.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell18.StylePriority.UseBorders = False
        Me.XrTableCell18.StylePriority.UseFont = False
        Me.XrTableCell18.StylePriority.UsePadding = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell18.Weight = 0.080225748399140623R
        '
        'XrTableCell113
        '
        Me.XrTableCell113.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell113.Dpi = 254.0!
        Me.XrTableCell113.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell113.Name = "XrTableCell113"
        Me.XrTableCell113.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell113.StylePriority.UseBorders = False
        Me.XrTableCell113.StylePriority.UseFont = False
        Me.XrTableCell113.StylePriority.UsePadding = False
        Me.XrTableCell113.StylePriority.UseTextAlignment = False
        Me.XrTableCell113.Text = "email:"
        Me.XrTableCell113.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell113.Weight = 0.22570930982306967R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell19.Dpi = 254.0!
        Me.XrTableCell19.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell19.StylePriority.UseBorders = False
        Me.XrTableCell19.StylePriority.UseFont = False
        Me.XrTableCell19.StylePriority.UsePadding = False
        Me.XrTableCell19.StylePriority.UseTextAlignment = False
        Me.XrTableCell19.Text = "[SUMMARY.EMAIL]"
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell19.Weight = 0.85882560889202275R
        '
        'XrTableRow22
        '
        Me.XrTableRow22.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell120, Me.XrTableCell56, Me.XrTableCell58})
        Me.XrTableRow22.Dpi = 254.0!
        Me.XrTableRow22.Name = "XrTableRow22"
        Me.XrTableRow22.Weight = 0.62693582084929345R
        '
        'XrTableCell120
        '
        Me.XrTableCell120.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell120.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell120.Dpi = 254.0!
        Me.XrTableCell120.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell120.Name = "XrTableCell120"
        Me.XrTableCell120.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell120.StylePriority.UseBorderColor = False
        Me.XrTableCell120.StylePriority.UseBorders = False
        Me.XrTableCell120.StylePriority.UseFont = False
        Me.XrTableCell120.StylePriority.UsePadding = False
        Me.XrTableCell120.StylePriority.UseTextAlignment = False
        Me.XrTableCell120.Text = "Ползвател:"
        Me.XrTableCell120.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell120.Weight = 0.5129570651284957R
        '
        'XrTableCell56
        '
        Me.XrTableCell56.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.XrTableCell56.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell56.Dpi = 254.0!
        Me.XrTableCell56.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell56.Name = "XrTableCell56"
        Me.XrTableCell56.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell56.StylePriority.UseBorderColor = False
        Me.XrTableCell56.StylePriority.UseBorders = False
        Me.XrTableCell56.StylePriority.UseFont = False
        Me.XrTableCell56.StylePriority.UsePadding = False
        Me.XrTableCell56.StylePriority.UseTextAlignment = False
        Me.XrTableCell56.Text = "[Con_Names] [Con_Phone][Con_Mobile]"
        Me.XrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell56.Weight = 1.3222818882493337R
        '
        'XrTableCell58
        '
        Me.XrTableCell58.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell58.Dpi = 254.0!
        Me.XrTableCell58.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell58.Name = "XrTableCell58"
        Me.XrTableCell58.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell58.StylePriority.UseBorders = False
        Me.XrTableCell58.StylePriority.UseFont = False
        Me.XrTableCell58.StylePriority.UsePadding = False
        Me.XrTableCell58.StylePriority.UseTextAlignment = False
        Me.XrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell58.Weight = 1.1647610466221705R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell15})
        Me.XrTableRow6.Dpi = 254.0!
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 0.62693582084929322R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.BackColor = System.Drawing.Color.Gainsboro
        Me.XrTableCell15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell15.Dpi = 254.0!
        Me.XrTableCell15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell15.StylePriority.UseBackColor = False
        Me.XrTableCell15.StylePriority.UseBorders = False
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.StylePriority.UsePadding = False
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.Text = "Данни за автомобила:"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell15.Weight = 3.0R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell57, Me.XrTableCell1, Me.XrTableCell121, Me.XrTableCell2, Me.XrTableCell122, Me.XrTableCell3})
        Me.XrTableRow1.Dpi = 254.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.StylePriority.UseBorders = False
        Me.XrTableRow1.Weight = 0.62693583517404772R
        '
        'XrTableCell57
        '
        Me.XrTableCell57.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell57.Dpi = 254.0!
        Me.XrTableCell57.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell57.Name = "XrTableCell57"
        Me.XrTableCell57.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell57.StylePriority.UseBorders = False
        Me.XrTableCell57.StylePriority.UseFont = False
        Me.XrTableCell57.StylePriority.UsePadding = False
        Me.XrTableCell57.Text = "Рег . №: "
        Me.XrTableCell57.Weight = 0.33356716408085119R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell1.CanGrow = False
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.Text = "[Plate_Nr]"
        Me.XrTableCell1.Weight = 0.613241174352613R
        '
        'XrTableCell121
        '
        Me.XrTableCell121.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell121.Dpi = 254.0!
        Me.XrTableCell121.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell121.Name = "XrTableCell121"
        Me.XrTableCell121.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell121.StylePriority.UseBorders = False
        Me.XrTableCell121.StylePriority.UseFont = False
        Me.XrTableCell121.StylePriority.UsePadding = False
        Me.XrTableCell121.Text = "Шаси  №: "
        Me.XrTableCell121.Weight = 0.37638127177814684R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell2.CanGrow = False
        Me.XrTableCell2.Dpi = 254.0!
        Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UsePadding = False
        Me.XrTableCell2.Text = "[Full_Vin_Nr]"
        Me.XrTableCell2.Weight = 0.59227536781111234R
        '
        'XrTableCell122
        '
        Me.XrTableCell122.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell122.Dpi = 254.0!
        Me.XrTableCell122.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell122.Name = "XrTableCell122"
        Me.XrTableCell122.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell122.StylePriority.UseBorders = False
        Me.XrTableCell122.StylePriority.UseFont = False
        Me.XrTableCell122.StylePriority.UsePadding = False
        Me.XrTableCell122.Text = "Дата 1 рег.: "
        Me.XrTableCell122.Weight = 0.22570931401566954R
        Me.XrTableCell122.WordWrap = False
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell3.Dpi = 254.0!
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UsePadding = False
        Me.XrTableCell3.Text = "[Reg_Date!dd.MM.yyyy]"
        Me.XrTableCell3.Weight = 0.85882570796160729R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell123, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell92, Me.XrTableCell7})
        Me.XrTableRow2.Dpi = 254.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 0.62693585947240527R
        '
        'XrTableCell123
        '
        Me.XrTableCell123.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell123.Dpi = 254.0!
        Me.XrTableCell123.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell123.Name = "XrTableCell123"
        Me.XrTableCell123.StylePriority.UseBorders = False
        Me.XrTableCell123.StylePriority.UseFont = False
        Me.XrTableCell123.Text = "Модел: "
        Me.XrTableCell123.Weight = 0.33356716408085113R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell5.CanGrow = False
        Me.XrTableCell5.Dpi = 254.0!
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.Text = "[Main_Model_Name]"
        Me.XrTableCell5.Weight = 0.61324126922959743R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell6.CanGrow = False
        Me.XrTableCell6.Dpi = 254.0!
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.Text = "Цвят: "
        Me.XrTableCell6.Weight = 0.96865692422021243R
        '
        'XrTableCell92
        '
        Me.XrTableCell92.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell92.Dpi = 254.0!
        Me.XrTableCell92.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell92.Name = "XrTableCell92"
        Me.XrTableCell92.StylePriority.UseBorders = False
        Me.XrTableCell92.StylePriority.UseFont = False
        Me.XrTableCell92.Text = "Пробег : "
        Me.XrTableCell92.Weight = 0.22570893450773194R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell7.CanGrow = False
        Me.XrTableCell7.Dpi = 254.0!
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.Text = "[km]"
        Me.XrTableCell7.Weight = 0.85882570796160707R
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell60, Me.XrTableCell124, Me.XrTableCell59, Me.XrTableCell98, Me.XrTableCell125})
        Me.XrTableRow3.Dpi = 254.0!
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 0.62693585947240527R
        '
        'XrTableCell60
        '
        Me.XrTableCell60.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell60.Dpi = 254.0!
        Me.XrTableCell60.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell60.Name = "XrTableCell60"
        Me.XrTableCell60.StylePriority.UseBorders = False
        Me.XrTableCell60.StylePriority.UseFont = False
        Me.XrTableCell60.Text = "Код модел:"
        Me.XrTableCell60.Weight = 0.94680845209717979R
        '
        'XrTableCell124
        '
        Me.XrTableCell124.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell124.Dpi = 254.0!
        Me.XrTableCell124.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell124.Name = "XrTableCell124"
        Me.XrTableCell124.StylePriority.UseBorders = False
        Me.XrTableCell124.StylePriority.UseFont = False
        Me.XrTableCell124.Text = "Гаранция до : "
        Me.XrTableCell124.Weight = 0.37638136145436546R
        '
        'XrTableCell59
        '
        Me.XrTableCell59.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell59.Dpi = 254.0!
        Me.XrTableCell59.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell59.Name = "XrTableCell59"
        Me.XrTableCell59.StylePriority.UseBorders = False
        Me.XrTableCell59.StylePriority.UseFont = False
        Me.XrTableCell59.Text = "[Warranty_End_Date]"
        Me.XrTableCell59.Weight = 0.59227555236431517R
        '
        'XrTableCell98
        '
        Me.XrTableCell98.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell98.Dpi = 254.0!
        Me.XrTableCell98.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrTableCell98.Name = "XrTableCell98"
        Me.XrTableCell98.StylePriority.UseBorders = False
        Me.XrTableCell98.StylePriority.UseFont = False
        Me.XrTableCell98.Weight = 0.22570893031513206R
        '
        'XrTableCell125
        '
        Me.XrTableCell125.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell125.Dpi = 254.0!
        Me.XrTableCell125.Font = New System.Drawing.Font("Arial Narrow", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrTableCell125.Name = "XrTableCell125"
        Me.XrTableCell125.StylePriority.UseBorders = False
        Me.XrTableCell125.StylePriority.UseFont = False
        Me.XrTableCell125.Text = "Стелки"
        Me.XrTableCell125.Weight = 0.85882570376900724R
        '
        'XrTableRow25
        '
        Me.XrTableRow25.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell97, Me.XrTableCell93, Me.XrTableCell63})
        Me.XrTableRow25.Dpi = 254.0!
        Me.XrTableRow25.Name = "XrTableRow25"
        Me.XrTableRow25.Weight = 1.2538720059355724R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell9.Dpi = 254.0!
        Me.XrTableCell9.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Застраховател: "
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.XrTableCell9.Weight = 2.141174296230993R
        '
        'XrTableCell97
        '
        Me.XrTableCell97.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell97.Dpi = 254.0!
        Me.XrTableCell97.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrTableCell97.Name = "XrTableCell97"
        Me.XrTableCell97.StylePriority.UseBorders = False
        Me.XrTableCell97.StylePriority.UseFont = False
        Me.XrTableCell97.StylePriority.UseTextAlignment = False
        Me.XrTableCell97.Text = "Правилно монтирани"
        Me.XrTableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell97.Weight = 0.27980361223245165R
        '
        'XrTableCell93
        '
        Me.XrTableCell93.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell93.Dpi = 254.0!
        Me.XrTableCell93.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrTableCell93.Name = "XrTableCell93"
        Me.XrTableCell93.StylePriority.UseBorders = False
        Me.XrTableCell93.StylePriority.UseFont = False
        Me.XrTableCell93.StylePriority.UseTextAlignment = False
        Me.XrTableCell93.Text = "Една върху друга"
        Me.XrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell93.Weight = 0.27980361223245165R
        '
        'XrTableCell63
        '
        Me.XrTableCell63.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell63.Dpi = 254.0!
        Me.XrTableCell63.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrTableCell63.Name = "XrTableCell63"
        Me.XrTableCell63.StylePriority.UseBorders = False
        Me.XrTableCell63.StylePriority.UseFont = False
        Me.XrTableCell63.StylePriority.UseTextAlignment = False
        Me.XrTableCell63.Text = "Износени / Повредени"
        Me.XrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell63.Weight = 0.29921847930410395R
        '
        'XrTableRow24
        '
        Me.XrTableRow24.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell126, Me.XrTableCell8, Me.XrTableCell70, Me.XrTableCell61, Me.XrTableCell91, Me.XrTableCell100, Me.XrTableCell99, Me.XrTableCell62})
        Me.XrTableRow24.Dpi = 254.0!
        Me.XrTableRow24.Name = "XrTableRow24"
        Me.XrTableRow24.Weight = 0.62693600296666863R
        '
        'XrTableCell126
        '
        Me.XrTableCell126.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell126.Dpi = 254.0!
        Me.XrTableCell126.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell126.FormattingRules.Add(Me.NoRefNo)
        Me.XrTableCell126.Name = "XrTableCell126"
        Me.XrTableCell126.StylePriority.UseBorders = False
        Me.XrTableCell126.StylePriority.UseFont = False
        Me.XrTableCell126.Text = "Номер щета:"
        Me.XrTableCell126.Weight = 0.33356717347421677R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell8.Dpi = 254.0!
        Me.XrTableCell8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.Text = "[Ref_No]"
        Me.XrTableCell8.Weight = 0.61324127862296307R
        '
        'XrTableCell70
        '
        Me.XrTableCell70.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell70.Dpi = 254.0!
        Me.XrTableCell70.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell70.Name = "XrTableCell70"
        Me.XrTableCell70.StylePriority.UseBorders = False
        Me.XrTableCell70.StylePriority.UseFont = False
        Me.XrTableCell70.Text = "Дата:"
        Me.XrTableCell70.Weight = 0.37638136145436546R
        '
        'XrTableCell61
        '
        Me.XrTableCell61.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell61.Dpi = 254.0!
        Me.XrTableCell61.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell61.Name = "XrTableCell61"
        Me.XrTableCell61.StylePriority.UseBorders = False
        Me.XrTableCell61.StylePriority.UseFont = False
        Me.XrTableCell61.Text = "Прот.оглед:"
        Me.XrTableCell61.Weight = 0.51204966164969823R
        '
        'XrTableCell91
        '
        Me.XrTableCell91.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell91.Dpi = 254.0!
        Me.XrTableCell91.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell91.Name = "XrTableCell91"
        Me.XrTableCell91.StylePriority.UseBorders = False
        Me.XrTableCell91.StylePriority.UseFont = False
        Me.XrTableCell91.Text = "Дата:"
        Me.XrTableCell91.Weight = 0.3059352005376868R
        '
        'XrTableCell100
        '
        Me.XrTableCell100.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell100.Dpi = 254.0!
        Me.XrTableCell100.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrTableCell100.Name = "XrTableCell100"
        Me.XrTableCell100.StylePriority.UseBorders = False
        Me.XrTableCell100.StylePriority.UseFont = False
        Me.XrTableCell100.StylePriority.UseTextAlignment = False
        Me.XrTableCell100.Text = "[  ]Да/[  ]Не"
        Me.XrTableCell100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell100.Weight = 0.279803232724514R
        Me.XrTableCell100.WordWrap = False
        '
        'XrTableCell99
        '
        Me.XrTableCell99.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell99.Dpi = 254.0!
        Me.XrTableCell99.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrTableCell99.Name = "XrTableCell99"
        Me.XrTableCell99.StylePriority.UseBorders = False
        Me.XrTableCell99.StylePriority.UseFont = False
        Me.XrTableCell99.StylePriority.UseTextAlignment = False
        Me.XrTableCell99.Text = "[  ]Да/[  ]Не"
        Me.XrTableCell99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell99.Weight = 0.27980361223245165R
        Me.XrTableCell99.WordWrap = False
        '
        'XrTableCell62
        '
        Me.XrTableCell62.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell62.Dpi = 254.0!
        Me.XrTableCell62.Font = New System.Drawing.Font("Arial Narrow", 9.0!)
        Me.XrTableCell62.Name = "XrTableCell62"
        Me.XrTableCell62.StylePriority.UseBorders = False
        Me.XrTableCell62.StylePriority.UseFont = False
        Me.XrTableCell62.StylePriority.UseTextAlignment = False
        Me.XrTableCell62.Text = "[  ]Да/[  ]Не"
        Me.XrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell62.Weight = 0.29921847930410389R
        Me.XrTableCell62.WordWrap = False
        '
        'XrTableRow26
        '
        Me.XrTableRow26.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell64, Me.XrTableCell74, Me.XrTableCell65, Me.XrTableCell89, Me.XrTableCell66})
        Me.XrTableRow26.Dpi = 254.0!
        Me.XrTableRow26.Name = "XrTableRow26"
        Me.XrTableRow26.Weight = 0.62693600296666852R
        '
        'XrTableCell64
        '
        Me.XrTableCell64.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell64.Dpi = 254.0!
        Me.XrTableCell64.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell64.Name = "XrTableCell64"
        Me.XrTableCell64.StylePriority.UseBorders = False
        Me.XrTableCell64.StylePriority.UseFont = False
        Me.XrTableCell64.Text = "Протокол доп. оглед:"
        Me.XrTableCell64.Weight = 0.94680845209717979R
        '
        'XrTableCell74
        '
        Me.XrTableCell74.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell74.Dpi = 254.0!
        Me.XrTableCell74.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell74.Name = "XrTableCell74"
        Me.XrTableCell74.StylePriority.UseBorders = False
        Me.XrTableCell74.StylePriority.UseFont = False
        Me.XrTableCell74.Text = "Дата:"
        Me.XrTableCell74.Weight = 0.37638136145436546R
        '
        'XrTableCell65
        '
        Me.XrTableCell65.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell65.Dpi = 254.0!
        Me.XrTableCell65.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell65.Name = "XrTableCell65"
        Me.XrTableCell65.StylePriority.UseBorders = False
        Me.XrTableCell65.StylePriority.UseFont = False
        Me.XrTableCell65.Text = "Прот.доп. оглед:"
        Me.XrTableCell65.Weight = 0.51204966164969834R
        '
        'XrTableCell89
        '
        Me.XrTableCell89.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell89.Dpi = 254.0!
        Me.XrTableCell89.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell89.Name = "XrTableCell89"
        Me.XrTableCell89.StylePriority.UseBorders = False
        Me.XrTableCell89.StylePriority.UseFont = False
        Me.XrTableCell89.Text = "Дата:"
        Me.XrTableCell89.Weight = 0.305934062013874R
        '
        'XrTableCell66
        '
        Me.XrTableCell66.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell66.Dpi = 254.0!
        Me.XrTableCell66.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell66.Name = "XrTableCell66"
        Me.XrTableCell66.StylePriority.UseBorders = False
        Me.XrTableCell66.StylePriority.UseFont = False
        Me.XrTableCell66.Weight = 0.8588264627848825R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell14})
        Me.XrTableRow5.Dpi = 254.0!
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 0.62693757757709923R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell14.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell14.Dpi = 254.0!
        Me.XrTableCell14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseBackColor = False
        Me.XrTableCell14.StylePriority.UseBorders = False
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.Text = "КЛИЕНТЪТ ВЪЗЛАГА НА [SUMMARY.FIRM], ЦИТИРАНА ПО-ДОЛУ КАТО ""ДРУЖЕСТВОТО""  ИЗВЪРШВА" &
    "НЕ НА СЛЕДНОТО:"
        Me.XrTableCell14.Weight = 3.0R
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.BorderColor = System.Drawing.Color.Black
        Me.XrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.BorderWidth = 1.0!
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.XrLabel1.ForeColor = System.Drawing.Color.Black
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 134.9375!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 2, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1929.92505!, 81.14046!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorderDashStyle = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "СЕРВИЗНА ПОРЪЧКА (ДОГОВОР)"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5, Me.XrPageBreak1, Me.XrTable4})
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.HeightF = 241.6771!
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
        '
        'XrTable5
        '
        Me.XrTable5.BackColor = System.Drawing.Color.Gainsboro
        Me.XrTable5.Dpi = 254.0!
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(0.000080744423!, 1.999959!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow27})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(1929.92505!, 63.5!)
        Me.XrTable5.StylePriority.UseBackColor = False
        '
        'XrTableRow27
        '
        Me.XrTableRow27.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell85, Me.XrTableCell102, Me.XrTableCell90})
        Me.XrTableRow27.Dpi = 254.0!
        Me.XrTableRow27.Name = "XrTableRow27"
        Me.XrTableRow27.Weight = 1.0R
        '
        'XrTableCell85
        '
        Me.XrTableCell85.Dpi = 254.0!
        Me.XrTableCell85.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell85.Name = "XrTableCell85"
        Me.XrTableCell85.StylePriority.UseFont = False
        Me.XrTableCell85.Text = "ОЧАКВАНА СТОЙНОСТ С ДДС (BGN/EUR)"
        Me.XrTableCell85.Weight = 2.2827568222798411R
        '
        'XrTableCell102
        '
        Me.XrTableCell102.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zOrder_Jobs.Summ_Vat")})
        Me.XrTableCell102.Dpi = 254.0!
        Me.XrTableCell102.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell102.Name = "XrTableCell102"
        Me.XrTableCell102.StylePriority.UseFont = False
        Me.XrTableCell102.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:0.00;;#}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell102.Summary = XrSummary1
        Me.XrTableCell102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell102.Weight = 0.34167159668560954R
        '
        'XrTableCell90
        '
        Me.XrTableCell90.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zOrder_Jobs.CalculatedField1")})
        Me.XrTableCell90.Dpi = 254.0!
        Me.XrTableCell90.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell90.Name = "XrTableCell90"
        Me.XrTableCell90.StylePriority.UseFont = False
        Me.XrTableCell90.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:0.00;;#}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell90.Summary = XrSummary2
        Me.XrTableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell90.Weight = 0.36153089082324347R
        '
        'XrPageBreak1
        '
        Me.XrPageBreak1.Dpi = 254.0!
        Me.XrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 85.0!)
        Me.XrPageBreak1.Name = "XrPageBreak1"
        '
        'XrTable4
        '
        Me.XrTable4.BackColor = System.Drawing.Color.Gainsboro
        Me.XrTable4.Dpi = 254.0!
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(4.53751421!, 114.677101!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow23, Me.XrTableRow36})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(1929.92505!, 127.0!)
        Me.XrTable4.StylePriority.UseBackColor = False
        '
        'XrTableRow23
        '
        Me.XrTableRow23.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell79})
        Me.XrTableRow23.Dpi = 254.0!
        Me.XrTableRow23.Name = "XrTableRow23"
        Me.XrTableRow23.Weight = 1.0R
        '
        'XrTableCell79
        '
        Me.XrTableCell79.Dpi = 254.0!
        Me.XrTableCell79.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell79.Name = "XrTableCell79"
        Me.XrTableCell79.StylePriority.UseFont = False
        Me.XrTableCell79.StylePriority.UseTextAlignment = False
        Me.XrTableCell79.Text = "СЪОБЩЕНИЯ И ИЗИСКВАНИЯ"
        Me.XrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell79.Weight = 2.5096443744389876R
        '
        'XrTableRow36
        '
        Me.XrTableRow36.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCellComplaints})
        Me.XrTableRow36.Dpi = 254.0!
        Me.XrTableRow36.Name = "XrTableRow36"
        Me.XrTableRow36.Weight = 1.0R
        '
        'XrTableCellComplaints
        '
        Me.XrTableCellComplaints.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCellComplaints.Dpi = 254.0!
        Me.XrTableCellComplaints.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCellComplaints.Multiline = True
        Me.XrTableCellComplaints.Name = "XrTableCellComplaints"
        Me.XrTableCellComplaints.StylePriority.UseBackColor = False
        Me.XrTableCellComplaints.StylePriority.UseFont = False
        Me.XrTableCellComplaints.StylePriority.UseTextAlignment = False
        Me.XrTableCellComplaints.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCellComplaints.Weight = 2.5096443744389876R
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageBreak2, Me.XrRichText3, Me.XrTable2, Me.XrRichText1})
        Me.SubBand1.Dpi = 254.0!
        Me.SubBand1.HeightF = 4237.834!
        Me.SubBand1.Name = "SubBand1"
        '
        'XrPageBreak2
        '
        Me.XrPageBreak2.Dpi = 254.0!
        Me.XrPageBreak2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1648.417!)
        Me.XrPageBreak2.Name = "XrPageBreak2"
        '
        'XrRichText3
        '
        Me.XrRichText3.Dpi = 254.0!
        Me.XrRichText3.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.XrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 1650.417!)
        Me.XrRichText3.Name = "XrRichText3"
        Me.XrRichText3.SerializableRtfString = resources.GetString("XrRichText3.SerializableRtfString")
        Me.XrRichText3.SizeF = New System.Drawing.SizeF(1939.0!, 2562.417!)
        '
        'XrTable2
        '
        Me.XrTable2.Dpi = 254.0!
        Me.XrTable2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(4.53743315!, 837.376526!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow10, Me.XrTableRow11, Me.XrTableRow13, Me.XrTableRow19, Me.XrTableRow20, Me.XrTableRow31, Me.XrTableRow32, Me.XrTableRow33})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(1934.46204!, 784.978821!)
        Me.XrTable2.StylePriority.UseFont = False
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell11, Me.XrTableCell47, Me.XrTableCell49, Me.XrTableCell17})
        Me.XrTableRow10.Dpi = 254.0!
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 1.0R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Dpi = 254.0!
        Me.XrTableCell11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.Text = "Връщане на старите части:"
        Me.XrTableCell11.Weight = 0.18462677353446427R
        '
        'XrTableCell47
        '
        Me.XrTableCell47.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrShape3})
        Me.XrTableCell47.Dpi = 254.0!
        Me.XrTableCell47.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell47.Name = "XrTableCell47"
        Me.XrTableCell47.StylePriority.UseFont = False
        Me.XrTableCell47.StylePriority.UseTextAlignment = False
        Me.XrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell47.Weight = 0.083203326170637665R
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(23.53571!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(68.79169!, 53.3071518!)
        Me.XrLabel3.Text = "ДА"
        '
        'XrShape3
        '
        Me.XrShape3.Dpi = 254.0!
        Me.XrShape3.LocationFloat = New DevExpress.Utils.PointFloat(116.4713!, 0!)
        Me.XrShape3.Name = "XrShape3"
        Me.XrShape3.Shape = ShapeRectangle2
        Me.XrShape3.SizeF = New System.Drawing.SizeF(58.20834!, 53.3071518!)
        '
        'XrTableCell49
        '
        Me.XrTableCell49.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrShape4})
        Me.XrTableCell49.Dpi = 254.0!
        Me.XrTableCell49.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.StylePriority.UseFont = False
        Me.XrTableCell49.StylePriority.UseTextAlignment = False
        Me.XrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell49.Weight = 0.094361234279045358R
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(33.9207306!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(68.79169!, 53.3071518!)
        Me.XrLabel6.Text = "НЕ"
        '
        'XrShape4
        '
        Me.XrShape4.Dpi = 254.0!
        Me.XrShape4.LocationFloat = New DevExpress.Utils.PointFloat(142.4547!, 0!)
        Me.XrShape4.Name = "XrShape4"
        Me.XrShape4.Shape = ShapeRectangle3
        Me.XrShape4.SizeF = New System.Drawing.SizeF(58.20834!, 53.3071518!)
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Dpi = 254.0!
        Me.XrTableCell17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        Me.XrTableCell17.Text = "Начин на плащане:. . . . . . . . . . . ."
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell17.Weight = 0.37805200366141389R
        '
        'XrTableRow11
        '
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell12, Me.XrTableCell13})
        Me.XrTableRow11.Dpi = 254.0!
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.Weight = 1.0R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Dpi = 254.0!
        Me.XrTableCell12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.Text = "Факс на клиента: [zOrder_Complaints.FAX]"
        Me.XrTableCell12.Weight = 0.36219133712192847R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Dpi = 254.0!
        Me.XrTableCell13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "email на клиента: [zOrder_Complaints.EMAIL]"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell13.Weight = 0.37805200052363275R
        '
        'XrTableRow13
        '
        Me.XrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell16, Me.XrTableCell25})
        Me.XrTableRow13.Dpi = 254.0!
        Me.XrTableRow13.Name = "XrTableRow13"
        Me.XrTableRow13.Weight = 1.0R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Dpi = 254.0!
        Me.XrTableCell16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.Text = "ПРИЕМЧИК . . . . . . . . . . . . . ."
        Me.XrTableCell16.Weight = 0.36219133712192847R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Dpi = 254.0!
        Me.XrTableCell25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseFont = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        Me.XrTableCell25.Text = "КЛИЕНТ . . . . . . . . . . . . . ."
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell25.Weight = 0.37805200052363275R
        '
        'XrTableRow19
        '
        Me.XrTableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27})
        Me.XrTableRow19.Dpi = 254.0!
        Me.XrTableRow19.Name = "XrTableRow19"
        Me.XrTableRow19.Weight = 1.0R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.BackColor = System.Drawing.Color.Gainsboro
        Me.XrTableCell27.Dpi = 254.0!
        Me.XrTableCell27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.StylePriority.UseBackColor = False
        Me.XrTableCell27.StylePriority.UseFont = False
        Me.XrTableCell27.StylePriority.UseTextAlignment = False
        Me.XrTableCell27.Text = "Работили по автомобила:"
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell27.Weight = 0.74024333764556127R
        '
        'XrTableRow20
        '
        Me.XrTableRow20.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell30, Me.XrTableCell26, Me.XrTableCell31})
        Me.XrTableRow20.Dpi = 254.0!
        Me.XrTableRow20.Name = "XrTableRow20"
        Me.XrTableRow20.Weight = 0.70866180502274R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Dpi = 254.0!
        Me.XrTableCell30.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.StylePriority.UseFont = False
        Me.XrTableCell30.Text = "Механик 1 . . . . . . . . . . . . . ."
        Me.XrTableCell30.Weight = 0.36219133712192847R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Dpi = 254.0!
        Me.XrTableCell26.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.StylePriority.UseTextAlignment = False
        Me.XrTableCell26.Text = "Механик 2 . . . . . . . . . . . . . ."
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell26.Weight = 0.18902600026181637R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Dpi = 254.0!
        Me.XrTableCell31.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.StylePriority.UseFont = False
        Me.XrTableCell31.StylePriority.UseTextAlignment = False
        Me.XrTableCell31.Text = "Контрол . . . . . . . . . . . . . ."
        Me.XrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell31.Weight = 0.18902600026181637R
        '
        'XrTableRow31
        '
        Me.XrTableRow31.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell33})
        Me.XrTableRow31.Dpi = 254.0!
        Me.XrTableRow31.Name = "XrTableRow31"
        Me.XrTableRow31.Weight = 5.9150262041020918R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText2})
        Me.XrTableCell33.Dpi = 254.0!
        Me.XrTableCell33.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.StylePriority.UseFont = False
        Me.XrTableCell33.StylePriority.UseTextAlignment = False
        Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell33.Weight = 0.74024333764556127R
        '
        'XrRichText2
        '
        Me.XrRichText2.Dpi = 254.0!
        Me.XrRichText2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrRichText2.Name = "XrRichText2"
        Me.XrRichText2.SerializableRtfString = resources.GetString("XrRichText2.SerializableRtfString")
        Me.XrRichText2.SizeF = New System.Drawing.SizeF(1934.46204!, 373.0619!)
        '
        'XrTableRow32
        '
        Me.XrTableRow32.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell34, Me.XrTableCell35})
        Me.XrTableRow32.Dpi = 254.0!
        Me.XrTableRow32.Name = "XrTableRow32"
        Me.XrTableRow32.Weight = 0.862854933685937R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8, Me.XrLabel7, Me.XrShape5})
        Me.XrTableCell34.Dpi = 254.0!
        Me.XrTableCell34.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.StylePriority.UseFont = False
        Me.XrTableCell34.Weight = 0.48460056298998866R
        '
        'XrLabel8
        '
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(733.8354!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(319.060608!, 53.3071404!)
        Me.XrLabel8.Text = "Получена обратна връзка"
        '
        'XrLabel7
        '
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(4.53751421!, 0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(247.6231!, 53.3071518!)
        Me.XrLabel7.Text = "Предал за фирмата:"
        '
        'XrShape5
        '
        Me.XrShape5.Dpi = 254.0!
        Me.XrShape5.LocationFloat = New DevExpress.Utils.PointFloat(598.952515!, 0.0003229777!)
        Me.XrShape5.Name = "XrShape5"
        Me.XrShape5.Shape = ShapeRectangle4
        Me.XrShape5.SizeF = New System.Drawing.SizeF(100.9622!, 53.3071404!)
        '
        'XrTableCell35
        '
        Me.XrTableCell35.Dpi = 254.0!
        Me.XrTableCell35.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.StylePriority.UseFont = False
        Me.XrTableCell35.StylePriority.UseTextAlignment = False
        Me.XrTableCell35.Text = "Приел за клиента:"
        Me.XrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell35.Weight = 0.25564277465557256R
        '
        'XrTableRow33
        '
        Me.XrTableRow33.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell39, Me.XrTableCell40})
        Me.XrTableRow33.Dpi = 254.0!
        Me.XrTableRow33.Name = "XrTableRow33"
        Me.XrTableRow33.Weight = 0.8753347414522864R
        '
        'XrTableCell39
        '
        Me.XrTableCell39.Dpi = 254.0!
        Me.XrTableCell39.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.StylePriority.UseFont = False
        Me.XrTableCell39.Text = "Дата:"
        Me.XrTableCell39.Weight = 0.36219133712192847R
        '
        'XrTableCell40
        '
        Me.XrTableCell40.Dpi = 254.0!
        Me.XrTableCell40.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.StylePriority.UseFont = False
        Me.XrTableCell40.StylePriority.UseTextAlignment = False
        Me.XrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell40.Weight = 0.37805200052363275R
        '
        'XrRichText1
        '
        Me.XrRichText1.Dpi = 254.0!
        Me.XrRichText1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(1939.0!, 817.773926!)
        '
        'OrderS_PTableAdapter1
        '
        Me.OrderS_PTableAdapter1.ClearBeforeFill = True
        '
        'OrderS_PTableAdapter2
        '
        Me.OrderS_PTableAdapter2.ClearBeforeFill = True
        '
        'CalculatedField1
        '
        Me.CalculatedField1.DataMember = "zOrder_Jobs"
        Me.CalculatedField1.DisplayName = "Summ_EUR"
        Me.CalculatedField1.Expression = "[Summ_Vat]/1.95583"
        Me.CalculatedField1.Name = "CalculatedField1"
        '
        'Order_Print
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.PageHeader, Me.ReportHeader2, Me.ReportFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedField1})
        Me.DataMember = "zOrder_Jobs"
        Me.DataSource = Me.DataSet11
        Me.Dpi = 254.0!
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.NoRefNo})
        Me.Margins = New System.Drawing.Printing.Margins(101, 60, 87, 79)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ReportPrintOptions.DetailCountOnEmptyDataSource = 0
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 25.0!
        Me.Version = "16.2"
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Get_InvoiceTableAdapter As MototomPrint.DataSet1TableAdapters.Get_InvoiceTableAdapter
    Friend WithEvents DataSet11 As MototomPrint.DataSet1
    Friend WithEvents ZOrder_ComplaintsTableAdapter As MototomPrint.DataSet1TableAdapters.zOrder_ComplaintsTableAdapter
    Friend WithEvents Empl_SummaryTableAdapter1 As MototomPrint.DataSet1TableAdapters.Empl_SummaryTableAdapter
    Friend WithEvents ZOrder_JobsTableAdapter As MototomPrint.DataSet1TableAdapters.zOrder_JobsTableAdapter
    Friend WithEvents NoRefNo As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents Get_EmblemTableAdapter1 As MototomPrint.DataSet1TableAdapters.Get_EmblemTableAdapter
    Friend WithEvents SummaryTableAdapter1 As DataSet1TableAdapters.SUMMARYTableAdapter
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ReportHeader2 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape3 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape4 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow13 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow19 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow20 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow31 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrTableRow32 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape5 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow33 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow23 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell79 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow36 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCellComplaints As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents OrderS_PTableAdapter1 As DataSet1TableAdapters.ORDERS_PTableAdapter
    Friend WithEvents OrderS_PTableAdapter2 As DataSet1TableAdapters.ORDERS_PTableAdapter
    Friend WithEvents XrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow28 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell82 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrTableCell86 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell87 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageBreak2 As DevExpress.XtraReports.UI.XRPageBreak
    Friend WithEvents XrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBoxToyota As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow14 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrBarCode2 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrTableCell127 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow21 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell128 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell54 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell55 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow18 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell71 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell72 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell73 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow17 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell114 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell67 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell68 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell108 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell69 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow16 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell115 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell109 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell53 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow15 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell116 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell110 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow12 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell117 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell111 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell118 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell112 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell119 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell113 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow22 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell120 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell56 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell58 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell57 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell121 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell122 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell123 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell92 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell60 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell124 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell59 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell98 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell125 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow25 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell97 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell93 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell63 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow24 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell126 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell70 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell61 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell91 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell100 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell99 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell62 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow26 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell64 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell74 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell65 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell89 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell66 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents CalculatedField1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell78 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell76 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell77 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell101 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell75 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable8 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow34 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell94 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell95 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell134 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell96 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow27 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell85 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell102 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell90 As DevExpress.XtraReports.UI.XRTableCell
End Class
