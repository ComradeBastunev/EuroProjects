Public Class ReportInvoicePayments
    Private Sub ReportInvoicePayments_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Invoices_PaymentsTableAdapter1.Connection.ConnectionString = gConnStr
        Invoices_PaymentsTableAdapter1.Fill(DataSet11.Invoices_Payments, CDec(gInv_No))

        If gTransl Then
            XrTableCellPaymentSummLabel.Text = "Payment Amount"
            XrTableCellPaymentTypeLabel.Text = "Payment Type"
            XrTableCellPaymTypeName.DataBindings.Clear()
            XrTableCellPaymTypeName.DataBindings.Add("Text", DataSet11, "Invoices_Payments.PaymTName_Transl")
        End If

    End Sub

    Private Sub XrTableCell3_EvaluateBinding(sender As Object, e As DevExpress.XtraReports.UI.BindingEventArgs) Handles XrTableCellPaymentSum.EvaluateBinding
        If gTransl Then
            e.Value = Math.Round(e.Value / 1.95583, 2)
        End If
    End Sub
End Class