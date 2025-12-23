Imports System.Runtime.InteropServices
Imports DevExpress.XtraReports.UI

Public Interface ITSC_Reports_Client
    Function PrintOrder(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer) As Integer

    Function PrintProforma(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer, aCurr As Integer, aRateType As Integer, aRateDate As DateTime, aShowAll As Integer, aBankAcc As Integer, aShowCodes As Integer, aOrder_Type As Integer) As Integer
    Function PrintInvoice(aConnStr As String, aInvNo As Double) As Integer
    Function PreviewInvoice(aConnStr As String, aInvNo As Double) As Integer

End Interface

<ClassInterface(ClassInterfaceType.None)> Public Class TSC_Reports
    Implements ITSC_Reports_Client

    Function PrintOrder(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer) As Integer Implements ITSC_Reports_Client.PrintOrder
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

        Dim Form1 = New FormPrintOrder
        Form1.ShowDialog()
        'ReportOrder.ShowPreview()
        'Using ReportOrder As New Order_Print
        '    gForClient = True
        '    Using printTool As New ReportPrintTool(ReportOrder)
        '        ' Invoke the Ribbon Print Preview form modally, 
        '        ' and load the report document into it.
        '        Try
        '            printTool.ShowRibbonPreviewDialog()
        '        Catch ex As Exception
        '            printTool.ShowRibbonPreviewDialog()
        '        End Try

        '    End Using
        'End Using
        'Using ReportOrder As New Order_Print
        '    gForClient = False
        '    Using printTool As New ReportPrintTool(ReportOrder)
        '        ' Invoke the Ribbon Print Preview form modally, 
        '        ' and load the report document into it.

        '        Try
        '            printTool.ShowRibbonPreviewDialog()
        '        Catch ex As Exception
        '            printTool.ShowRibbonPreviewDialog()
        '        End Try
        '    End Using
        'End Using
        'PrintOrder = 1
        Return PrintOrder
    End Function



    Function PrintInvoice(aConnStr As String, aInvNo As Double) As Integer Implements ITSC_Reports_Client.PrintInvoice
        PrintInvoice = 0
        gInv_No = aInvNo
        gConnStr = aConnStr
        Dim DataSet11 As New DataSet1
        Dim GetInvTA1 As New DataSet1TableAdapters.Get_InvoiceTableAdapter
        GetInvTA1.Connection.ConnectionString = gConnStr
        GetInvTA1.Fill(DataSet11.Get_Invoice, aInvNo)
        If DataSet11.Get_Invoice.First.Inv_Type.ToUpper = "СМЕТКА" Then
            Dim ReportInv As New Smetka_Deal
            Using printtool As New ReportPrintTool(ReportInv)
                Try
                    printtool.Print()
                Catch ex As Exception
                    printtool.Print()
                End Try
            End Using
            PrintInvoice = 1
            Return PrintInvoice

        Else
            Dim ReportInv As New Invoice_Deal
            If DataSet11.Get_Invoice.First.Service = 7 Then
                ReportInv.ShortPrint.Value = MsgBox("Съкратен печат?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Печат фактура") = MsgBoxResult.Yes
                ReportInv.ShowPArts.Value = True
            Else
                ReportInv.ShortPrint.Value = False
            End If
            Using printtool As New ReportPrintTool(ReportInv)
                Try
                    printtool.Print()
                Catch ex As Exception
                    printtool.Print()
                End Try
            End Using
            PrintInvoice = 1
            Return PrintInvoice
        End If
    End Function

    Function PreviewInvoice(aConnStr As String, aInvNo As Double) As Integer Implements ITSC_Reports_Client.PreviewInvoice
        PreviewInvoice = 0
        gInv_No = aInvNo
        gConnStr = aConnStr
        Dim DataSet11 As New DataSet1
        Dim GetInvTA1 As New DataSet1TableAdapters.Get_InvoiceTableAdapter
        GetInvTA1.Connection.ConnectionString = gConnStr
        GetInvTA1.Fill(DataSet11.Get_Invoice, aInvNo)
        If DataSet11.Get_Invoice.First.Inv_Type.ToUpper = "СМЕТКА" Then
            Dim ReportInv As New Smetka_Deal

            Using printtool As New ReportPrintTool(ReportInv)
                Try
                    printtool.ShowRibbonPreviewDialog()
                Catch ex As Exception
                    printtool.ShowRibbonPreviewDialog()
                End Try
            End Using
            PreviewInvoice = 1
            Return PreviewInvoice

        Else
            Dim ReportInv As New Invoice_Deal
            If DataSet11.Get_Invoice.First.Service = 7 Then
                ReportInv.ShortPrint.Value = MsgBox("Съкратен печат?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Печат фактура") = MsgBoxResult.Yes
                ReportInv.ShowPArts.Value = True
            Else
                ReportInv.ShortPrint.Value = False
            End If
            Using printtool As New ReportPrintTool(ReportInv)
                Try
                    printtool.ShowRibbonPreviewDialog()
                Catch ex As Exception
                    printtool.ShowRibbonPreviewDialog()
                End Try
            End Using
            PreviewInvoice = 1
            Return PreviewInvoice
        End If
    End Function

    Function PrintProforma(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer, aCurr As Integer, aRateType As Integer, aRateDate As DateTime, aShowAll As Integer, aBankAcc As Integer, aShowCodes As Integer, aOrder_Type As Integer) As Integer Implements ITSC_Reports_Client.PrintProforma
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
        If aSplit = 5 Then
            ReportInv.bHideSums.Value = (MsgBox("Скриване на сумите?", MsgBoxStyle.YesNo, "Печат гаранция") = MsgBoxResult.Yes)
        End If
        ReportInv.DisplayName = "Proforma" + aOrder_No.ToString
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

