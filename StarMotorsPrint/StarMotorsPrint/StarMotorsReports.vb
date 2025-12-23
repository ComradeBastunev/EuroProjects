Imports System.Reflection
Imports System.Runtime.InteropServices
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.Spreadsheet
Imports System.IO
Imports StarMotorsPrint

Public Interface IStarMotorsReports
    Function PrintOrder(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer) As Integer
    Function PrintProforma(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer, aCurr As Integer, aRateType As Integer, aRateDate As DateTime, aShowAll As Integer, aBankAcc As Integer, aShowCodes As Integer, aOrder_Type As Integer) As Integer
    Function PrintInvoice(aConnStr As String, aInvNo As Double) As Integer
    Function PreviewInvoice(aConnStr As String, aInvNo As Double) As Integer
    Function PrintOffer(aConnStr As String, aOfferNo As Double) As Integer
    Function PrintCarDocs(aConnStr As String, aCode As String, aStore As Integer, aDocType As Integer) As Integer
    Function PrintProtocolPPP(aConnStr As String, aCode As String, aStore As Integer) As Integer
End Interface

<ClassInterface(ClassInterfaceType.None)> Public Class StarMotorsReports
    Implements IStarMotorsReports

    Public Function IStarMotorsReports_PrintOrder(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer) As Integer Implements IStarMotorsReports.PrintOrder
        gConnStr = aConnStr
        gService = aService
        gOrderNo = aOrder_No
        gSplit = aSplit
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
        Return 1
    End Function

    Public Function IStarMotorsReports_PrintProforma(aConnStr As String, aService As Integer, aOrder_No As Long, aSplit As Integer, aCurr As Integer, aRateType As Integer, aRateDate As Date, aShowAll As Integer, aBankAcc As Integer, aShowCodes As Integer, aOrder_Type As Integer) As Integer Implements IStarMotorsReports.PrintProforma
        gConnStr = aConnStr
        gOrderNo = aOrder_No
        gService = aService
        gSplit = aSplit
        gCurr = aCurr
        gRateDate = aRateDate
        gRateType = aRateType
        gShowAll = aShowAll
        gBankAcc = aBankAcc
        gShowCodes = aShowCodes
        gOrderType = aOrder_Type
        Using ReportOrder As New ReportProforma
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
        Return 1
    End Function

    Public Function IStarMotorsReports_PrintInvoice(aConnStr As String, aInvNo As Double) As Integer Implements IStarMotorsReports.PrintInvoice
        gConnStr = aConnStr
        gInv_No = aInvNo
        gOrderType = 2
        Using ReportOrder As New ReportInvoice
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
        Return 1

    End Function

    Public Function IStarMotorsReports_PreviewInvoice(aConnStr As String, aInvNo As Double) As Integer Implements IStarMotorsReports.PreviewInvoice
        gConnStr = aConnStr
        gInv_No = aInvNo
        gOrderType = 2
        gTransl = MsgBox("Отпечатване на английски ?", MsgBoxStyle.YesNo, "Печат фактура") = MsgBoxResult.Yes
        gShort = MsgBox("Съкратена фактура ?", MsgBoxStyle.YesNo, "Печат фактура") = MsgBoxResult.Yes

        Using ReportOrder As New ReportInvoice
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
        Return 1

    End Function

    Public Function IStarMotorsReports_PrintOffer(aConnStr As String, aOfferNo As Double) As Integer Implements IStarMotorsReports.PrintOffer
        gConnStr = aConnStr
        gOfferN = aOfferNo
        DocsByOfferNo = True
        Dim NewForm = New FormChooseContractType
        If gCode = Nothing Then NewForm.RadioGroup1.Properties.Items(3).Enabled = False
        Dim tmpTA = New DataSet1TableAdapters.Rep_Orders_OfferTableAdapter
        tmpTA.Connection.ConnectionString = aConnStr

        Dim Orders As New Dictionary(Of Long, String)()
        Dim ordlist = tmpTA.GetData(aOfferNo).ToList
        For Each ord In ordlist
            Orders.Add(ord.order_no, ord.Code)
        Next
        If Orders.Count <> 0 Then
            NewForm.LookUpEdit1.Properties.DataSource = Orders
            ' Change the column caption.
            'FormChooseContractType1.LookUpEdit1.Properties.PopulateColumns()
            NewForm.LookUpEdit1.Properties.Columns("Value").Caption = "Модел"
            NewForm.LookUpEdit1.Properties.Columns("Key").Caption = "Поръчка"
            NewForm.LookUpEdit1.Properties.Columns("Value").Visible = True
            NewForm.LookUpEdit1.EditValue = Orders.First.Key
        End If
        NewForm.ShowDialog()
        Return 1
    End Function

    Public Function IStarMotorsReports_PrintCarDocs(aConnStr As String, aCode As String, aStore As Integer, aDocType As Integer) As Integer Implements IStarMotorsReports.PrintCarDocs
        gConnStr = aConnStr
        gCode = aCode
        gStore = aStore
        Dim DataSet21 As New DataSet1
        Dim GetCar As New DataSet1TableAdapters.CarOrdersListTableAdapter
        GetCar.Connection.ConnectionString = gConnStr
        GetCar.Fill(DataSet21.CarOrdersList, aCode, CDec(aStore))
        If DataSet21.CarOrdersList.Count > 0 AndAlso Not DataSet21.CarOrdersList.First.IsTemplNrNull Then
            Dim GetOffer As New DataSet1TableAdapters.Cars_Offers_pTableAdapter
            GetOffer.Connection.ConnectionString = gConnStr
            GetOffer.Fill(DataSet21.Cars_Offers_p, DataSet21.CarOrdersList.First.TemplNr)
            If DataSet21.Cars_Offers_p.Count > 0 Then
                IStarMotorsReports_PrintOffer(aConnStr, CDbl(DataSet21.Cars_Offers_p.First.OfferN))
                Exit Function
            End If
        End If
        MsgBox("Няма поръчка към автомобила!")
    End Function

    Public Function IStarMotorsReports_PrintProtocolPPP(aConnStr As String, aCode As String, aStore As Integer) As Integer Implements IStarMotorsReports.PrintProtocolPPP
        gConnStr = aConnStr
        gCode = aCode
        gStore = aStore

        Using ReportOrder As New Report_PPP
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
        Return 1

    End Function
End Class
