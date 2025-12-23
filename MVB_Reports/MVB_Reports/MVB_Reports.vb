Imports System.Runtime.InteropServices
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System.IO

Public Interface IMVB_Reports_Client
    Function PrintOrder(aConnStr As String, aOrder_No As Long, aService As Integer, aSplit As Integer, aPrinterName As String) As Integer
    Function PrintWorkCard(aConnStr As String, aOrder_No As Long, aService As Integer, aSplit As Integer, aPrinterName As String) As Integer
    Function PrintPS(aConnStr As String, aOrder_No As Long, aService As Integer, aSplit As Integer, aPrinterName As String) As Integer
    Function PrintProtocol(aConnStr As String, aOrder_No As Long, aService As Integer, aSplit As Integer, aPrinterName As String) As Integer

    Function PrintOrderNew(aConnStr As String, aOrder_No As Long, aService As Integer, aSplit As Integer, aPrinterName As String) As Integer

    Function PreviewInvoice(aConnStr As String, aInvNo As Double) As Integer
    Function PrintInvoice(aConnStr As String, aInvNo As Double, Optional aCopyNum As Integer = 1) As Integer
    Function ExportInvoice(aConnStr As String, aInvNo As Double, FileName As String) As Integer
End Interface

<ClassInterface(ClassInterfaceType.None)> Public Class MVB_Reports_Client
    Implements IMVB_Reports_Client

    Private Sub PrintingSystem_StartPrint(sender As Object, e As DevExpress.XtraPrinting.PrintDocumentEventArgs)
        e.PrintDocument.PrinterSettings.Duplex = System.Drawing.Printing.Duplex.Vertical
    End Sub



    Public Function PrintOrder(aConnStr As String, aOrder_No As Long, aService As Integer, aSplit As Integer, aPrinterName As String) As Integer Implements IMVB_Reports_Client.PrintOrder
        Dim SpreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl
        With SpreadsheetControl1
            .LoadDocument("CSP.xls")
            .Document.Unit = DevExpress.Office.DocumentUnit.Millimeter
            '.ActiveWorksheet.ActiveView.Margins.Bottom = 5
            '.ActiveWorksheet.ActiveView.Margins.Top = 5
            .Document.Worksheets.RemoveAt(1)
            .Document.Worksheets.RemoveAt(1)
            .Document.Worksheets.RemoveAt(1)
            .ActiveWorksheet.PrintOptions.FitToPage = True
            .ActiveWorksheet.PrintOptions.FitToHeight = 2
            .ActiveWorksheet.PrintOptions.FitToWidth = 0
            With .Document.Worksheets(0)
                Using storeentitiesMVB = New StoreEntities1(EntityConnBuild(aConnStr))
                    Dim o = (From o1 In storeentitiesMVB.Order_Print_Header Where o1.Order_No = aOrder_No And o1.Split = aSplit And o1.Service = aService).ToList.First
                    .Cells("K7").SetValue(o.Order_No)
                    .Cells("U7").SetValue(o.Date_Created.ToString("dd.MM.yyyy hh:mm"))
                    .Cells("U8").SetValue(o.Empl_Name)
                    .Cells("U9").SetValue(o.Date_End_Plan.Value.ToString("dd.MM.yyyy hh:mm"))
                    .Cells("D13").SetValue(o.Firm)
                    .Cells("D14").SetValue(o.Represent + " " + o.Phone)
                    If If(o.Contact_Names, "") <> "" Then .Cells("D15").SetValue(o.Contact_Names + " " + o.Contact_Mobile)
                    .Cells("T13").SetValue(o.Plate_Nr)
                    .Cells("T14").SetValue(o.Vin_Nr)
                    .Cells("T15").SetValue(o.Last_KM)
                    .Cells("T16").SetValue(o.Reg_Date)

                    .Cells("X13").SetValue(storeentitiesMVB.Cars_List.Where(Function(p) If(p.Vin_Typ, "") + p.Vin_Nr = o.Vin_Nr).ToList.First.Model_Index)

                    .Cells("U78").SetValue(o.Date_Created.ToString("dd.MM.yyy hh:mm"))
                    .Cells("U79").SetValue(o.Empl_Name)
                    .Cells("U80").SetValue(o.Date_End_Plan.Value.ToString("dd.MM.yyy hh:mm"))
                    .Cells("D84").SetValue(o.Firm)
                    .Cells("T84").SetValue(o.Plate_Nr)
                    Dim op = (From op1 In storeentitiesMVB.zMVBOrders_p Where op1.SERVICE = aService And op1.ORDER_NO = aOrder_No And op1.SPLIT = aSplit And op1.ORDERP_TYPE = 8 Order By op1.ID Select op1.DESCRIPTION).ToList
                    Dim i = 21
                    For Each op1 In op
                        .Cells("M" + i.ToString).SetValue(op1)
                        i = i + 1
                        If i > 29 Then Exit For
                    Next
                End Using
            End With
            Using printingSystem As New PrintingSystem
                Using link As New PrintableComponentLink(printingSystem)
                    link.Component = SpreadsheetControl1
                    link.CreateDocument()
                    AddHandler link.PrintingSystem.StartPrint, AddressOf PrintingSystem_StartPrint
                    link.EnablePageDialog = False
                    Dim ps As PrintingSystemBase = link.PrintingSystem
                    ps.SetCommandVisibility(PrintingSystemCommand.Find, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.EditPageHF, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.Magnifier, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.MultiplePages, CommandVisibility.None)

                    link.PrintingSystem.PreviewFormEx.ShowDialog()
                    'link.PrintingSystem.Print()

                End Using
            End Using

        End With
        Return 0
    End Function
    Public Function PrintWorkCard(aConnStr As String, aOrder_No As Long, aService As Integer, aSplit As Integer, aPrinterName As String) As Integer Implements IMVB_Reports_Client.PrintWorkCard
        PrintWorkCard = 0
        Dim PrintWorkCard1 As New Report_Work_Card
        PrintWorkCard1.ConnStr.Value = aConnStr
        PrintWorkCard1.Order_No.Value = CDec(aOrder_No)
        PrintWorkCard1.Service.Value = CDec(aService)
        PrintWorkCard1.Split.Value = CDec(aSplit)
        Try
            PrintWorkCard1.ShowRibbonPreviewDialog()
        Catch ex As Exception
            PrintWorkCard1.ShowRibbonPreviewDialog()
        End Try
        PrintWorkCard = 1
        Return PrintWorkCard

    End Function
    Public Function PrintWorkCard1(aConnStr As String, aOrder_No As Long, aService As Integer, aSplit As Integer, aPrinterName As String) As Integer
        Dim SpreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl
        With SpreadsheetControl1
            .LoadDocument("CSP.xls")
            .Document.Unit = DevExpress.Office.DocumentUnit.Millimeter
            .Document.Worksheets.RemoveAt(2)
            .Document.Worksheets.RemoveAt(2)
            .Document.Worksheets.RemoveAt(0)
            .ActiveWorksheet.PrintOptions.FitToPage = True
            .ActiveWorksheet.PrintOptions.FitToHeight = 1
            .ActiveWorksheet.PrintOptions.FitToWidth = 0
            With .Document.Worksheets(0)
                Using storeentitiesMVB = New StoreEntities1(EntityConnBuild(aConnStr))
                    Dim o = (From o1 In storeentitiesMVB.Order_Print_Header Where o1.Order_No = aOrder_No And o1.Split = aSplit And o1.Service = aService).ToList.First
                    .Cells("K7").SetValue(o.Order_No)
                    .Cells("U7").SetValue(o.Date_Created.ToString("dd.MM.yyyy hh:mm"))
                    .Cells("U8").SetValue(o.Empl_Name)
                    .Cells("U9").SetValue(o.Date_End_Plan.Value.ToString("dd.MM.yyyy hh:mm"))
                    .Cells("D13").SetValue(o.Firm)
                    .Cells("T13").SetValue(o.Plate_Nr)
                    Dim op = (From op1 In storeentitiesMVB.zMVBOrders_p Where op1.SERVICE = aService And op1.ORDER_NO = aOrder_No And op1.SPLIT = aSplit And op1.ORDERP_TYPE = 1 Order By op1.ID).ToList
                    Dim i = 18
                    For Each op1 In op
                        .Cells("A" + i.ToString).SetValue(op1.CODE)
                        .Cells("E" + i.ToString).SetValue(op1.DESCRIPTION)
                        .Cells("P" + i.ToString).SetValue(op1.QUANT.ToString("0.0"))
                        i = i + 1
                        If i > 37 Then
                            Using printingSystem As New PrintingSystem
                                Using link As New PrintableComponentLink(printingSystem)
                                    link.Component = SpreadsheetControl1
                                    link.CreateDocument()
                                    Dim ps As PrintingSystemBase = link.PrintingSystem
                                    ps.SetCommandVisibility(PrintingSystemCommand.Find, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.EditPageHF, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.Magnifier, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.MultiplePages, CommandVisibility.None)
                                    link.PrintingSystem.PreviewFormEx.ShowDialog()
                                    'link.PrintingSystem.Print()
                                    .Range("A18:P37").Value = Nothing
                                End Using
                            End Using
                            i = 18
                        End If
                    Next
                End Using
            End With
            Using printingSystem As New PrintingSystem
                Using link As New PrintableComponentLink(printingSystem)
                    link.Component = SpreadsheetControl1
                    link.CreateDocument()
                    link.PrintingSystem.PreviewFormEx.ShowDialog()
                    'link.PrintingSystem.Print()

                End Using
            End Using

        End With
        Return 0
    End Function
    Public Function PrintPS(aConnStr As String, aOrder_No As Long, aService As Integer, aSplit As Integer, aPrinterName As String) As Integer Implements IMVB_Reports_Client.PrintPS
        Dim SpreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl
        With SpreadsheetControl1
            .LoadDocument("CSP.xls")
            .Document.Unit = DevExpress.Office.DocumentUnit.Millimeter
            .Document.Worksheets.RemoveAt(0)
            .Document.Worksheets.RemoveAt(0)
            .Document.Worksheets.RemoveAt(1)
            .ActiveWorksheet.PrintOptions.FitToPage = True
            .ActiveWorksheet.PrintOptions.FitToHeight = 1
            .ActiveWorksheet.PrintOptions.FitToWidth = 0
            With .Document.Worksheets(0)
                Using storeentitiesMVB = New StoreEntities1(EntityConnBuild(aConnStr))
                    Dim o = (From o1 In storeentitiesMVB.Order_Print_Header Where o1.Order_No = aOrder_No And o1.Split = aSplit And o1.Service = aService).ToList.First
                    .Cells("K7").SetValue(o.Order_No)
                    .Cells("U7").SetValue(o.Date_Created.ToString("dd.MM.yyyy hh:mm"))
                    .Cells("U8").SetValue(o.Empl_Name)
                    .Cells("U9").SetValue(o.Date_End_Plan.Value.ToString("dd.MM.yyyy hh:mm"))
                    .Cells("D13").SetValue(o.Firm)
                    .Cells("T13").SetValue(o.Plate_Nr)
                    Dim op = storeentitiesMVB.zMVB_Print_PS(aService, aOrder_No).ToList
                    Dim i = 18
                    For Each op1 In op
                        .Cells("A" + i.ToString).SetValue(op1.Split)
                        .Cells("B" + i.ToString).SetValue(op1.CODE)
                        .Cells("G" + i.ToString).SetValue(op1.DESCRIPTION)
                        .Cells("O" + i.ToString).SetValue(op1.QUANT.ToString("0.#"))
                        .Cells("Q" + i.ToString).SetValue(op1.CONS)
                        i = i + 1
                        If i > 51 Then
                            Using printingSystem As New PrintingSystem
                                Using link As New PrintableComponentLink(printingSystem)
                                    link.Component = SpreadsheetControl1
                                    link.CreateDocument()
                                    Dim ps As PrintingSystemBase = link.PrintingSystem
                                    ps.SetCommandVisibility(PrintingSystemCommand.Find, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.EditPageHF, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.Magnifier, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.MultiplePages, CommandVisibility.None)

                                    link.PrintingSystem.PreviewFormEx.ShowDialog()
                                    'link.PrintingSystem.Print()
                                    .Range("A18:Q51").Value = Nothing
                                End Using
                            End Using
                            i = 18
                        End If
                    Next
                End Using
            End With
            Using printingSystem As New PrintingSystem
                Using link As New PrintableComponentLink(printingSystem)
                    link.Component = SpreadsheetControl1
                    link.CreateDocument()
                    Dim ps As PrintingSystemBase = link.PrintingSystem
                    ps.SetCommandVisibility(PrintingSystemCommand.Find, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.EditPageHF, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.Magnifier, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.MultiplePages, CommandVisibility.None)
                    link.PrintingSystem.PreviewFormEx.ShowDialog()
                    'link.PrintingSystem.Print()

                End Using
            End Using

        End With
        Return 0
    End Function


        Public Function PrintProtocol(aConnStr As String, aOrder_No As Long, aService As Integer, aSplit As Integer, aPrinterName As String) As Integer Implements IMVB_Reports_Client.PrintProtocol
        Dim SpreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl
        With SpreadsheetControl1
            .LoadDocument("CSP.xls")
            .Document.Unit = DevExpress.Office.DocumentUnit.Millimeter
            .Document.Worksheets.RemoveAt(0)
            .Document.Worksheets.RemoveAt(0)
            .Document.Worksheets.RemoveAt(0)
            .ActiveWorksheet.PrintOptions.FitToPage = True
            .ActiveWorksheet.PrintOptions.FitToHeight = 1
            .ActiveWorksheet.PrintOptions.FitToWidth = 0
            With .Document.Worksheets(0)
                Using storeentitiesMVB = New StoreEntities1(EntityConnBuild(aConnStr))
                    Dim o = (From o1 In storeentitiesMVB.Order_Print_Header Where o1.Order_No = aOrder_No And o1.Split = aSplit And o1.Service = aService).ToList.First
                    .Cells("K7").SetValue(o.Order_No)
                    .Cells("U7").SetValue(o.Date_Created.ToString("dd.MM.yyyy hh:mm"))
                    .Cells("U8").SetValue(o.Empl_Name)
                    .Cells("U9").SetValue(o.Date_End_Plan.Value.ToString("dd.MM.yyyy hh:mm"))
                    .Cells("D13").SetValue(o.Firm)
                    .Cells("T13").SetValue(o.Plate_Nr)
                    Dim op = storeentitiesMVB.zMVB_Print_PS(aService, aOrder_No).ToList
                    Dim i = 18
                    Dim j = 1
                    For Each op1 In op
                        .Cells("A" + i.ToString).SetValue(j)
                        .Cells("B" + i.ToString).SetValue(op1.CODE)
                        .Cells("G" + i.ToString).SetValue(op1.DESCRIPTION)
                        .Cells("O" + i.ToString).SetValue(op1.QUANT.ToString("0.#"))
                        j = j + 1
                        i = i + 1
                        If i > 51 Then
                            Using printingSystem As New PrintingSystem
                                Using link As New PrintableComponentLink(printingSystem)
                                    link.Component = SpreadsheetControl1
                                    link.CreateDocument()
                                    Dim ps As PrintingSystemBase = link.PrintingSystem
                                    ps.SetCommandVisibility(PrintingSystemCommand.Find, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.EditPageHF, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.Magnifier, CommandVisibility.None)
                                    ps.SetCommandVisibility(PrintingSystemCommand.MultiplePages, CommandVisibility.None)
                                    link.PrintingSystem.PreviewFormEx.ShowDialog()
                                    'link.PrintingSystem.Print()
                                    .Range("A18:Q51").Value = Nothing
                                End Using
                            End Using
                            i = 18
                        End If
                    Next
                End Using
            End With
            Using printingSystem As New PrintingSystem
                Using link As New PrintableComponentLink(printingSystem)
                    link.Component = SpreadsheetControl1
                    link.CreateDocument()
                    Dim ps As PrintingSystemBase = link.PrintingSystem
                    ps.SetCommandVisibility(PrintingSystemCommand.Find, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.EditPageHF, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.Magnifier, CommandVisibility.None)
                    ps.SetCommandVisibility(PrintingSystemCommand.MultiplePages, CommandVisibility.None)
                    link.PrintingSystem.PreviewFormEx.ShowDialog()
                    'link.PrintingSystem.Print()

                End Using
            End Using

        End With
        Return 0
    End Function


    Function PreviewInvoice(aConnStr As String, aInvNo As Double) As Integer Implements IMVB_Reports_Client.PreviewInvoice
        PreviewInvoice = 0
        gInv_No = aInvNo
        gConnStr = aConnStr

        Using XtraReportOrder1 As New Invoice_Deal
            XtraReportOrder1.bAutom = False
            Using printTool As New ReportPrintTool(XtraReportOrder1)
                Try
                    printTool.ShowRibbonPreviewDialog()
                Catch ex As Exception
                    printTool.ShowRibbonPreviewDialog()
                End Try
            End Using
        End Using

        PreviewInvoice = 1
        Return PreviewInvoice
    End Function


    Function PrintInvoice(aConnStr As String, aInvNo As Double, Optional aCopyNum As Integer = 1) As Integer Implements IMVB_Reports_Client.PrintInvoice
        PrintInvoice = 0
        gInv_No = aInvNo
        gConnStr = aConnStr

        Using XtraReportOrder1 As New Invoice_Deal
            XtraReportOrder1.bAutom = True
            Using printTool As New ReportPrintTool(XtraReportOrder1)
                Try
                    printTool.Print()
                Catch ex As Exception
                    printTool.Print()
                End Try
            End Using
        End Using
        If aCopyNum > 1 Then
            Using XtraReportOrder1 As New Invoice_Deal
                XtraReportOrder1.bAutom = True
                Using printTool As New ReportPrintTool(XtraReportOrder1)
                    printTool.PrinterSettings.Copies = CShort(aCopyNum - 1)
                    Try
                        printTool.Print()
                    Catch ex As Exception
                        printTool.Print()
                    End Try
                End Using
            End Using
        End If

        PrintInvoice = 1
        Return PrintInvoice
    End Function

    Function ExportInvoice(aConnStr As String, aInvNo As Double, FileName As String) As Integer Implements IMVB_Reports_Client.ExportInvoice
        ExportInvoice = 0
        gInv_No = aInvNo
        gConnStr = aConnStr
        Using XtraReportOrder1 As New Invoice_Deal
            XtraReportOrder1.bAutom = True
            Try
                XtraReportOrder1.ExportToPdf(FileName)
            Catch ex As Exception
                XtraReportOrder1.ExportToPdf(FileName)
            End Try
        End Using
        ExportInvoice = 1
        Return ExportInvoice
    End Function


    Public Function PrintOrderNew(aConnStr As String, aOrder_No As Long, aService As Integer, aSplit As Integer, aPrinterName As String) As Integer Implements IMVB_Reports_Client.PrintOrderNew

        gOrderNo = aOrder_No
        gService = aService
        gSplit = aSplit
        gConnStr = aConnStr
        gPrinterName = aPrinterName

        Dim NewForm = New FormPrintOrderOptions
        NewForm.ShowDialog()
        Return 0
    End Function






End Class
