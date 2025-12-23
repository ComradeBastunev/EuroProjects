<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ReportInvoicePayments
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
        Me.Summ_Total = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CurrDate = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ReportHeader2 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCellPaymentTypeLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCellPaymentSummLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCellPaymTypeName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCellPaymentSum = New DevExpress.XtraReports.UI.XRTableCell()
        Me.DiscountPercent = New DevExpress.XtraReports.UI.CalculatedField()
        Me.Sum_VAT = New DevExpress.XtraReports.UI.CalculatedField()
        Me.NoRefNo = New DevExpress.XtraReports.UI.FormattingRule()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.DataSet11 = New StarMotorsPrint.DataSet1()
        Me.Invoices_PaymentsTableAdapter1 = New StarMotorsPrint.DataSet1TableAdapters.Invoices_PaymentsTableAdapter()
        Me.ZInvoice_Rows_PrintTableAdapter = New StarMotorsPrint.DataSet1TableAdapters.zInvoice_Rows_PrintTableAdapter()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Summ_Total
        '
        Me.Summ_Total.DataMember = "zPrint_Proforma"
        Me.Summ_Total.Expression = "[Summ_Curr]+Round([BaseVat_Curr]*[VAT_PERC],2)"
        Me.Summ_Total.Name = "Summ_Total"
        '
        'CurrDate
        '
        Me.CurrDate.DataMember = "zPrint_Proforma"
        Me.CurrDate.Expression = "Today()"
        Me.CurrDate.Name = "CurrDate"
        '
        'ReportHeader2
        '
        Me.ReportHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.ReportHeader2.Dpi = 254.0!
        Me.ReportHeader2.HeightF = 50.00001!
        Me.ReportHeader2.Name = "ReportHeader2"
        '
        'XrTable3
        '
        Me.XrTable3.Dpi = 254.0!
        Me.XrTable3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTable3.KeepTogether = True
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(1939.0!, 50.00001!)
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UsePadding = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCellPaymentTypeLabel, Me.XrTableCellPaymentSummLabel})
        Me.XrTableRow2.Dpi = 254.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 0.78770158802553381R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.BorderWidth = 0.5!
        Me.XrTableCell4.Dpi = 254.0!
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.StylePriority.UseBorderWidth = False
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell4.Weight = 0.37012157086818637R
        '
        'XrTableCellPaymentTypeLabel
        '
        Me.XrTableCellPaymentTypeLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCellPaymentTypeLabel.BorderWidth = 0.5!
        Me.XrTableCellPaymentTypeLabel.Dpi = 254.0!
        Me.XrTableCellPaymentTypeLabel.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCellPaymentTypeLabel.Multiline = True
        Me.XrTableCellPaymentTypeLabel.Name = "XrTableCellPaymentTypeLabel"
        Me.XrTableCellPaymentTypeLabel.StylePriority.UseBorders = False
        Me.XrTableCellPaymentTypeLabel.StylePriority.UseBorderWidth = False
        Me.XrTableCellPaymentTypeLabel.StylePriority.UseFont = False
        Me.XrTableCellPaymentTypeLabel.StylePriority.UseTextAlignment = False
        Me.XrTableCellPaymentTypeLabel.Text = "Вид плащане"
        Me.XrTableCellPaymentTypeLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCellPaymentTypeLabel.Weight = 0.26704497445723718R
        '
        'XrTableCellPaymentSummLabel
        '
        Me.XrTableCellPaymentSummLabel.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCellPaymentSummLabel.BorderWidth = 0.5!
        Me.XrTableCellPaymentSummLabel.Dpi = 254.0!
        Me.XrTableCellPaymentSummLabel.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCellPaymentSummLabel.Name = "XrTableCellPaymentSummLabel"
        Me.XrTableCellPaymentSummLabel.StylePriority.UseBorders = False
        Me.XrTableCellPaymentSummLabel.StylePriority.UseBorderWidth = False
        Me.XrTableCellPaymentSummLabel.StylePriority.UseFont = False
        Me.XrTableCellPaymentSummLabel.StylePriority.UseTextAlignment = False
        Me.XrTableCellPaymentSummLabel.Text = "Сума"
        Me.XrTableCellPaymentSummLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCellPaymentSummLabel.Weight = 0.10307679232013758R
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 50.00001!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Dpi = 254.0!
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTable1.KeepTogether = True
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.5!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1939.0!, 50.00001!)
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UsePadding = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCellPaymTypeName, Me.XrTableCellPaymentSum})
        Me.XrTableRow1.Dpi = 254.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 0.78770158802553381R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.BorderWidth = 0.5!
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UseBorderWidth = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell1.Weight = 0.36993072769501073R
        '
        'XrTableCellPaymTypeName
        '
        Me.XrTableCellPaymTypeName.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCellPaymTypeName.BorderWidth = 0.5!
        Me.XrTableCellPaymTypeName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices_Payments.PaymTName")})
        Me.XrTableCellPaymTypeName.Dpi = 254.0!
        Me.XrTableCellPaymTypeName.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCellPaymTypeName.Multiline = True
        Me.XrTableCellPaymTypeName.Name = "XrTableCellPaymTypeName"
        Me.XrTableCellPaymTypeName.StylePriority.UseBorders = False
        Me.XrTableCellPaymTypeName.StylePriority.UseBorderWidth = False
        Me.XrTableCellPaymTypeName.StylePriority.UseFont = False
        Me.XrTableCellPaymTypeName.StylePriority.UseTextAlignment = False
        Me.XrTableCellPaymTypeName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCellPaymTypeName.Weight = 0.26704498147410172R
        '
        'XrTableCellPaymentSum
        '
        Me.XrTableCellPaymentSum.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCellPaymentSum.BorderWidth = 0.5!
        Me.XrTableCellPaymentSum.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices_Payments.Paym_Summ", "{0:#.00}")})
        Me.XrTableCellPaymentSum.Dpi = 254.0!
        Me.XrTableCellPaymentSum.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCellPaymentSum.Name = "XrTableCellPaymentSum"
        Me.XrTableCellPaymentSum.StylePriority.UseBorders = False
        Me.XrTableCellPaymentSum.StylePriority.UseBorderWidth = False
        Me.XrTableCellPaymentSum.StylePriority.UseFont = False
        Me.XrTableCellPaymentSum.StylePriority.UseTextAlignment = False
        Me.XrTableCellPaymentSum.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCellPaymentSum.Weight = 0.10326762847644869R
        '
        'DiscountPercent
        '
        Me.DiscountPercent.DataMember = "zPrint_Proforma"
        Me.DiscountPercent.Expression = "[Discount]*100"
        Me.DiscountPercent.Name = "DiscountPercent"
        '
        'Sum_VAT
        '
        Me.Sum_VAT.DataMember = "zPrint_Proforma"
        Me.Sum_VAT.DisplayName = "Sum_VAT"
        Me.Sum_VAT.Expression = "Round([BaseVat_Curr]*[VAT_PERC],2)"
        Me.Sum_VAT.Name = "Sum_VAT"
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
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 79.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 87.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Invoices_PaymentsTableAdapter1
        '
        Me.Invoices_PaymentsTableAdapter1.ClearBeforeFill = True
        '
        'ZInvoice_Rows_PrintTableAdapter
        '
        Me.ZInvoice_Rows_PrintTableAdapter.ClearBeforeFill = True
        '
        'ReportInvoicePayments
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader2})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CurrDate, Me.Sum_VAT, Me.Summ_Total, Me.DiscountPercent})
        Me.DataMember = "Invoices_Payments"
        Me.DataSource = Me.DataSet11
        Me.Dpi = 254.0!
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.NoRefNo})
        Me.Margins = New System.Drawing.Printing.Margins(100, 60, 87, 79)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ReportPrintOptions.DetailCountOnEmptyDataSource = 0
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 25.0!
        Me.Version = "16.2"
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Summ_Total As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CurrDate As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents ReportHeader2 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents NoRefNo As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents DiscountPercent As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Sum_VAT As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCellPaymentTypeLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCellPaymentSummLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCellPaymTypeName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCellPaymentSum As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents Invoices_PaymentsTableAdapter1 As DataSet1TableAdapters.Invoices_PaymentsTableAdapter
    Friend WithEvents ZInvoice_Rows_PrintTableAdapter As DataSet1TableAdapters.zInvoice_Rows_PrintTableAdapter
End Class
