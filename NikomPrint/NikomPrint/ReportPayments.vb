Public Class ReportPayments
    Private Sub ReportPayments_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Invoices_PaymentsTableAdapter1.Connection.ConnectionString = gConnStr
        Invoices_PaymentsTableAdapter1.Fill(DataSet11.Invoices_Payments, Me.Inv_No.Value)
    End Sub
End Class