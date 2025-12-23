<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ReportLabels180x90
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportLabels180x90))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DataSet11 = New SpektaPrint.DataSet1()
        Me.ZPrintLabelsTableAdapter1 = New SpektaPrint.DataSet1TableAdapters.zPrintLabelsTableAdapter()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.XrPictureBox1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 400.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable1.BorderWidth = 1.0!
        Me.XrTable1.Dpi = 254.0!
        Me.XrTable1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 132.5!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2, Me.XrTableRow3, Me.XrTableRow4})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1800.0!, 253.3889!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseBorderWidth = False
        Me.XrTable1.StylePriority.UseFont = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell13, Me.XrTableCell17, Me.XrTableCell6, Me.XrTableCell9, Me.XrTableCell8, Me.XrTableCell11, Me.XrTableCell3})
        Me.XrTableRow1.Dpi = 254.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 2.5646326330967453R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell1.CanGrow = False
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zPrintLabels.Description")})
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 0, 1, 0, 254.0!)
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.Weight = 1.01035599868842R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.CanGrow = False
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zPrintLabels.Price")})
        Me.XrTableCell2.Dpi = 254.0!
        Me.XrTableCell2.Font = New System.Drawing.Font("Arial Narrow", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell2.Weight = 0.35851341118962171R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zPrintLabels.PriceFract", "{0:00}")})
        Me.XrTableCell13.Dpi = 254.0!
        Me.XrTableCell13.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 1, 10, 0, 254.0!)
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UsePadding = False
        Me.XrTableCell13.Weight = 0.12222048659534482R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.CanGrow = False
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zPrintLabels.EcoPrice")})
        Me.XrTableCell17.Dpi = 254.0!
        Me.XrTableCell17.Font = New System.Drawing.Font("Arial Narrow", 28.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell17.ForeColor = System.Drawing.Color.Green
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.StylePriority.UseForeColor = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell17.Weight = 0.3585134334951956R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zPrintLabels.EcoPriceFract", "{0:00}")})
        Me.XrTableCell6.Dpi = 254.0!
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial Narrow", 14.0!)
        Me.XrTableCell6.ForeColor = System.Drawing.Color.Green
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 1, 10, 0, 254.0!)
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UseForeColor = False
        Me.XrTableCell6.StylePriority.UsePadding = False
        Me.XrTableCell6.Weight = 0.12222048200111935R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zPrintLabels.PriceEUR")})
        Me.XrTableCell9.Dpi = 254.0!
        Me.XrTableCell9.Font = New System.Drawing.Font("Arial Narrow", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell9.ForeColor = System.Drawing.Color.Red
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 1, 10, 0, 254.0!)
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseForeColor = False
        Me.XrTableCell9.StylePriority.UsePadding = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell9.Weight = 0.35851342585933371R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zPrintLabels.PriceEURFract", "{0:00}")})
        Me.XrTableCell8.Dpi = 254.0!
        Me.XrTableCell8.Font = New System.Drawing.Font("Arial Narrow", 14.0!)
        Me.XrTableCell8.ForeColor = System.Drawing.Color.Red
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 1, 10, 0, 254.0!)
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UseForeColor = False
        Me.XrTableCell8.StylePriority.UsePadding = False
        Me.XrTableCell8.Weight = 0.12222048576573072R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zPrintLabels.EcoPriceEUR")})
        Me.XrTableCell11.Dpi = 254.0!
        Me.XrTableCell11.Font = New System.Drawing.Font("Arial Narrow", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell11.ForeColor = System.Drawing.Color.Green
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 1, 10, 0, 254.0!)
        Me.XrTableCell11.StylePriority.UseBorders = False
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UseForeColor = False
        Me.XrTableCell11.StylePriority.UsePadding = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell11.Weight = 0.35851341129945918R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zPrintLabels.EcoPriceEURFract", "{0:00}")})
        Me.XrTableCell3.Dpi = 254.0!
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial Narrow", 14.0!)
        Me.XrTableCell3.ForeColor = System.Drawing.Color.Green
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 1, 10, 0, 254.0!)
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseForeColor = False
        Me.XrTableCell3.StylePriority.UsePadding = False
        Me.XrTableCell3.Weight = 0.12222009610828107R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell18})
        Me.XrTableRow2.Dpi = 254.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 0.46661753843107034R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell4.Dpi = 254.0!
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.Weight = 1.3307292175292969R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Dpi = 254.0!
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Weight = 0.44878420232530597R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCell18.Dpi = 254.0!
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseBorders = False
        Me.XrTableCell18.Weight = 1.1537778111479036R
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell14, Me.XrTableCell12, Me.XrTableCell19})
        Me.XrTableRow3.Dpi = 254.0!
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 0.63541669125069256R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell7.CanGrow = False
        Me.XrTableCell7.Dpi = 254.0!
        Me.XrTableCell7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 254.0!)
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UsePadding = False
        Me.XrTableCell7.Text = "Производител: [Supplier]"
        Me.XrTableCell7.Weight = 1.010355808241167R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell14.Dpi = 254.0!
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 1, 0, 0, 254.0!)
        Me.XrTableCell14.StylePriority.UseBorders = False
        Me.XrTableCell14.StylePriority.UsePadding = False
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.Text = "Вносител : Спекта Ауто ЕООД"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell14.Weight = 0.67302341341408556R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "zPrintLabels.code")})
        Me.XrTableCell12.Dpi = 254.0!
        Me.XrTableCell12.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 1, 0, 0, 254.0!)
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UsePadding = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "цената е в лева с ДДС за 1 бр."
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell12.Weight = 0.64695806849775406R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.XrTableCell19.CanGrow = False
        Me.XrTableCell19.Dpi = 254.0!
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 1, 0, 0, 254.0!)
        Me.XrTableCell19.StylePriority.UseBorders = False
        Me.XrTableCell19.StylePriority.UsePadding = False
        Me.XrTableCell19.StylePriority.UseTextAlignment = False
        Me.XrTableCell19.Text = "цената е в лева с ДДС за 1 бр."
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell19.Weight = 0.60295394084949971R
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell10, Me.XrTableCell20})
        Me.XrTableRow4.Dpi = 254.0!
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 0.32370869403802732R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell10.Dpi = 254.0!
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 254.0!)
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UsePadding = False
        Me.XrTableCell10.Weight = 1.4891485707136307R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell20.Dpi = 254.0!
        Me.XrTableCell20.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseBorders = False
        Me.XrTableCell20.StylePriority.UseFont = False
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell20.Weight = 1.4441426602888756R
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrPictureBox1.BorderWidth = 1.0!
        Me.XrPictureBox1.Dpi = 254.0!
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(1800.0!, 132.5!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        Me.XrPictureBox1.StylePriority.UseBorders = False
        Me.XrPictureBox1.StylePriority.UseBorderWidth = False
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 85.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 85.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZPrintLabelsTableAdapter1
        '
        Me.ZPrintLabelsTableAdapter1.ClearBeforeFill = True
        '
        'ReportLabels180x90
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DataMember = "zPrintLabels"
        Me.DataSource = Me.DataSet11
        Me.Dpi = 254.0!
        Me.Margins = New System.Drawing.Printing.Margins(150, 150, 85, 85)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 25.0!
        Me.Version = "16.2"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents ZPrintLabelsTableAdapter1 As DataSet1TableAdapters.zPrintLabelsTableAdapter
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
End Class
