Imports DevExpress.XtraReports.UI

Public Class PrintOptions
    Public PrintType As Integer
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If PrintType = 1 Then
            Dim DataSet11 As New DataSet1
            Dim GetInvTA1 As New DataSet1TableAdapters.Get_InvoiceTableAdapter
            GetInvTA1.Connection.ConnectionString = gConnStr
            GetInvTA1.Fill(DataSet11.Get_Invoice, CType(gInv_No, Decimal), False)
            Dim ReportInv As New Invoice_Deal
            ReportInv.ShowTO.Value = CheckEditTO.Checked
            ReportInv.ShowCarData.Value = CheckEditCarData.Checked
            ReportInv.ShortPrint.Value = False
            'End If
            Using printtool As New ReportPrintTool(ReportInv)
                Try
                    printtool.ShowRibbonPreviewDialog()
                Catch ex As Exception
                    printtool.ShowRibbonPreviewDialog()
                End Try
            End Using
        ElseIf PrintType = 2 Then
            Dim DataSet11 As New DataSet1
            Dim GetInvTA1 As New DataSet1TableAdapters.Get_InvoiceTableAdapter
            GetInvTA1.Connection.ConnectionString = gConnStr
            GetInvTA1.Fill(DataSet11.Get_Invoice, CType(gInv_No, Decimal), False)
            Dim ReportInv As New Invoice_Deal
            ReportInv.ShortPrint.Value = False
            ReportInv.ShowTO.Value = CheckEditTO.Checked
            ReportInv.ShowCarData.Value = CheckEditCarData.Checked
            'End If
            Using printtool As New ReportPrintTool(ReportInv)
                Try
                    printtool.Print()
                Catch ex As Exception
                    printtool.Print()
                End Try
            End Using
        ElseIf PrintType = 3 Then
            Dim ReportInv As New Proforma1
            ReportInv.ShowTO.Value = CheckEditTO.Checked
            ReportInv.ShowCarData.Value = CheckEditCarData.Checked
            ReportInv.DisplayName = "Proforma" + gOrderNo.ToString
            Using printtool As New ReportPrintTool(ReportInv)
                Try
                    printtool.ShowRibbonPreviewDialog()
                Catch
                    printtool.ShowRibbonPreviewDialog()
                End Try
            End Using
        ElseIf PrintType = 4 Then
            Dim ReportInv As New Stokova
            ReportInv.ShowTO.Value = CheckEditTO.Checked
            ReportInv.ShowCarData.Value = CheckEditCarData.Checked
            ReportInv.DisplayName = "Stokova" + gDocNo.ToString
            Using printtool As New ReportPrintTool(ReportInv)
                Try
                    printtool.ShowRibbonPreviewDialog()
                Catch
                    printtool.ShowRibbonPreviewDialog()
                End Try
            End Using

        End If
        Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim ReportWarr As New Print_Warr_Card
        ReportWarr.Inv_No.Value = gInv_No
        Using printtool As New ReportPrintTool(ReportWarr)
            Try
                printtool.ShowRibbonPreviewDialog()
            Catch ex As Exception
                printtool.ShowRibbonPreviewDialog()
            End Try
        End Using
    End Sub
End Class