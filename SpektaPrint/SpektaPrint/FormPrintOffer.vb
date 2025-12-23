Imports DevExpress.XtraReports.UI

Public Class FormPrintOffer
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Using ReportOffer As New ReportOfferUsed
            ReportOffer.XrPictureBoxCar.Image = ImageSlider1.CurrentImage
            Using printTool As New ReportPrintTool(ReportOffer)
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