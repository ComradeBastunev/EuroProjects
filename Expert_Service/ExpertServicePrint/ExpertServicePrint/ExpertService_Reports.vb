Imports System.Runtime.InteropServices
Imports DevExpress.XtraReports.UI

Public Interface IExpertService_Reports_Client
    Function PrintOrder(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer) As Integer
    Function PrintCheckList(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer) As Integer

    Function PrintCombinedOrder(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer) As Integer

    Function PrintProforma(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer, aCurr As Integer, aRateType As Integer, aRateDate As DateTime, aShowAll As Integer, aBankAcc As Integer, aShowCodes As Integer, aOrder_Type As Integer) As Integer
    Function PrintInvoice(aConnStr As String, aInvNo As Double, aCopyNum As Double) As Integer
    Function PreviewInvoice(aConnStr As String, aInvNo As Double) As Integer

End Interface

<ClassInterface(ClassInterfaceType.None)> Public Class ExpertService_Reports
    Implements IExpertService_Reports_Client

    Function PrintOrder(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer) As Integer Implements IExpertService_Reports_Client.PrintOrder
    PrintOrder = 0
    'Dim ReportOrder As New XtraReport1
    'ReportOrder.ConnStr.Value = aConnStr
    'ReportOrder.Order_No.Value = CDec(aOrder_No)
    'ReportOrder.Service.Value = CDec(aService)
    'ReportOrder.Split.Value = CDec(aSplit)
    gOrderNo = aOrder_No
    gService = aService
    gSplit = aSplit
    gConnStr = aConnStr

    'ReportOrder.ShowPreview()
    Using ReportOrder As New Order_Print
        gForClient = True
        Using printTool As New ReportPrintTool(ReportOrder)
            ' Invoke the Ribbon Print Preview form modally, 
                ' and load the report document into it.
                Try
                    printTool.ShowRibbonPreviewDialog()
                Catch ex As Exception
                    printTool.ShowRibbonPreviewDialog()
                End Try

        End Using
    End Using
    Using ReportOrder As New Order_Print
        gForClient = False
        Using printTool As New ReportPrintTool(ReportOrder)
            ' Invoke the Ribbon Print Preview form modally, 
            ' and load the report document into it.

                Try
                    printTool.ShowRibbonPreviewDialog()
                Catch ex As Exception
                    printTool.ShowRibbonPreviewDialog()
                End Try
        End Using
    End Using
    PrintOrder = 1
    Return PrintOrder
End Function

    Function PrintCheckList(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer) As Integer Implements IExpertService_Reports_Client.PrintCheckList
        PrintCheckList = 0
        gOrderNo = aOrder_No
        gService = aService
        gSplit = aSplit
        gConnStr = aConnStr

        Using ReportCheckList As New Check_LIst
            gForClient = True
            Using printTool As New ReportPrintTool(ReportCheckList)
                ' Invoke the Ribbon Print Preview form modally, 
                ' and load the report document into it.

                Try
                    printTool.ShowRibbonPreviewDialog()
                Catch ex As Exception
                    printTool.ShowRibbonPreviewDialog()
                End Try
            End Using
        End Using
        PrintCheckList = 1
        Return PrintCheckList
    End Function


    Function PrintCombinedOrder(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer) As Integer Implements IExpertService_Reports_Client.PrintCombinedOrder
        PrintCombinedOrder = 0
        'Dim ReportOrder As New XtraReport1
        'ReportOrder.ConnStr.Value = aConnStr
        'ReportOrder.Order_No.Value = CDec(aOrder_No)
        'ReportOrder.Service.Value = CDec(aService)
        'ReportOrder.Split.Value = CDec(aSplit)
        gOrderNo = aOrder_No
        gService = aService
        gSplit = aSplit
        gConnStr = aConnStr

        'ReportOrder.ShowPreview()
        Using ReportOrder As New Order_Print
            gForClient = True
            Using printTool As New ReportPrintTool(ReportOrder)
                ' Invoke the Ribbon Print Preview form modally, 
                ' and load the report document into it.
                Try
                    printTool.ShowRibbonPreviewDialog()
                Catch ex As Exception
                    printTool.ShowRibbonPreviewDialog()
                End Try

            End Using
        End Using
        Using ReportOrder As New CombinedOrder
            gForClient = False
            Using printTool As New ReportPrintTool(ReportOrder)
                ' Invoke the Ribbon Print Preview form modally, 
                ' and load the report document into it.
                printTool.PrinterSettings.Duplex = Drawing.Printing.Duplex.Vertical
                Try
                    printTool.ShowRibbonPreviewDialog()
                Catch ex As Exception
                    printTool.ShowRibbonPreviewDialog()
                End Try
            End Using
        End Using
        PrintCombinedOrder = 1
        Return PrintCombinedOrder
    End Function



    Function PrintInvoice(aConnStr As String, aInvNo As Double, aCopyNum As Double) As Integer Implements IExpertService_Reports_Client.PrintInvoice
        PrintInvoice = 0
        gInv_No = aInvNo
        gConnStr = aConnStr
        Dim ReportInv As New Invoice_Deal
        Using printtool As New ReportPrintTool(ReportInv)
            Try
                printtool.Print()
            Catch ex As Exception
                printtool.Print()
            End Try
        End Using
        If aCopyNum > 1 Then
            ReportInv = New Invoice_Deal

            Using printtool As New ReportPrintTool(ReportInv)
                printtool.PrinterSettings.Copies = aCopyNum - 1
                Try
                    printtool.Print()
                Catch ex As Exception
                    printtool.Print()
                End Try
            End Using
        End If
        PrintInvoice = 1
        Return PrintInvoice
    End Function

    Function PreviewInvoice(aConnStr As String, aInvNo As Double) As Integer Implements IExpertService_Reports_Client.PreviewInvoice
        PreviewInvoice = 0
        gInv_No = aInvNo
        gConnStr = aConnStr
        Dim ReportInv As New Invoice_Deal
        Using printtool As New ReportPrintTool(ReportInv)
            Try
                printtool.ShowRibbonPreviewDialog()
            Catch ex As Exception
                printtool.ShowRibbonPreviewDialog()
            End Try
        End Using
        PreviewInvoice = 1
        Return PreviewInvoice
    End Function

    Function PrintProforma(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer, aCurr As Integer, aRateType As Integer, aRateDate As DateTime, aShowAll As Integer, aBankAcc As Integer, aShowCodes As Integer, aOrder_Type As Integer) As Integer Implements IExpertService_Reports_Client.PrintProforma
        PrintProforma = 0
        gOrderNo = aOrder_No
        gService = aService
        gSplit = aSplit
        gConnStr = aConnStr
        gCurr = aCurr
        gRateType = aRateType
        gRateDate = aRateDate

        gShowAll = aShowAll
        gBankAcc = aBankAcc
        gShowCodes = aShowCodes
        gOrderType = aOrder_Type


        Dim ReportInv As New Proforma1
        Using printtool As New ReportPrintTool(ReportInv)
            Try
                printtool.ShowRibbonPreviewDialog()
            Catch
                printtool.ShowRibbonPreviewDialog()
            End Try
        End Using
        PrintProforma = 1
        Return PrintProforma

    End Function

End Class

