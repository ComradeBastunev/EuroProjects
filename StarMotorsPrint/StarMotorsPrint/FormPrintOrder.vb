Imports System.Reflection
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSpreadsheet

Friend Class FormPrintOrder

    Private Sub SimpleButtonOrder_Click(sender As Object, e As EventArgs) Handles SimpleButtonOrder.Click
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

    End Sub

    Private Sub SimpleButtonbodyCheck_Click(sender As Object, e As EventArgs) Handles SimpleButtonbodyCheck.Click
        Using SpreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl
            With SpreadsheetControl1
                .LoadDocument(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\ProtocolBodyCheck.xlsx")
                .Document.Unit = DevExpress.Office.DocumentUnit.Millimeter
                '.ActiveWorksheet.ActiveView.Margins.Bottom = 5
                '.ActiveWorksheet.ActiveView.Margins.Top = 5
                With .Document.Worksheets(0)
                    Dim DataSet11 As New DataSet1
                    Dim GetOrder1 As New DataSet1TableAdapters.zOrder_JobsTableAdapter
                    GetOrder1.Connection.ConnectionString = gConnStr
                    Dim Order1 = GetOrder1.GetData(gService, gOrderNo, gSplit).ToList.First
                    Dim i As Integer = 0
                    For i = 0 To Order1.Plate_Nr.Length - 1
                        .Cells(2, 2 + i).SetValue(Order1.Plate_Nr.Substring(i, 1))
                        If i > 10 Then Exit For
                    Next
                    i = 0
                    For i = 0 To Order1.Full_Vin_Nr.Length - 1
                        .Cells(3, 2 + i).SetValue(Order1.Full_Vin_Nr.Substring(i, 1))
                        If i > 17 Then Exit For
                    Next
                    Dim Date1 = Now().ToString("ddMMyyyy")
                    For i = 0 To Date1.Length - 1
                        .Cells(4, 2 + i).SetValue(Date1.Substring(i, 1))
                        If i > 8 Then Exit For
                    Next
                    Dim Km1 = Order1.km.ToString
                    If Km1.Length > 6 Then Km1 = Km1.Substring(0, 6)
                    For i = 0 To Km1.Length - 1
                        .Cells(6, 2 + i + 6 - Km1.Length).SetValue(Km1.Substring(i, 1))
                        If i > 6 Then Exit For
                    Next

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
        End Using
    End Sub

    Private Sub SimpleButtonPrint_Click(sender As Object, e As EventArgs) Handles SimpleButtonPrint.Click
        If CheckEditOrder.Checked Then SimpleButtonOrder.PerformClick()
        If CheckEditBodyCheck.Checked Then SimpleButtonbodyCheck.PerformClick()
    End Sub
End Class