Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSpreadsheet

Public Class FormPrintOrder


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
        ShowBodyCheck()
    End Sub

    Private Sub SimpleButtonPrint_Click(sender As Object, e As EventArgs) Handles SimpleButtonPrint.Click
        If CheckEditOrder.Checked Then SimpleButtonOrder.PerformClick()
        If CheckEditBodyCheck.Checked Then SimpleButtonbodyCheck.PerformClick()
    End Sub
End Class