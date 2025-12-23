Imports DevExpress.XtraReports.UI

Public Class FormPrintOrderUsed
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Using ReportOrder As New ReportOrderUsed
            ReportOrder.XrPictureBoxCar.Image = ImageSlider1.CurrentImage
            ReportOrder.XrTableCellPaym.Text = ComboBoxEdit1.Text
            ReportOrder.XrTableCellDeposit.Text = CalcEdit1.Value.ToString("# ##0 лв.")
            ReportOrder.XrTableCellPaymTerm.Text = SpinEdit1.Value.ToString + " дни"
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
End Class