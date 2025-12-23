Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MototomPrint1 = New MototomPrint.Mototom_Reports
        'MototomPrint1.PreviewInvoice("Data Source=bdsoft-server\sql2008;Initial Catalog=Store;User ID=cust_reports;password=;", SpinEdit1.Value)
        MototomPrint1.PrintProforma("Data Source=10.172.34.21;Initial Catalog=Store;User ID=cust_reports;password=;", 3, SpinEdit1.Value, 1, 1, 1, #10/01/2018#, 1, 1, 1, 1)
        'MototomPrint1.PrintOrder("Data Source=bdsoft-server\sql2008;Initial Catalog=Store;User ID=cust_reports;password=;", SpinEdit2.Value, SpinEdit1.Value, SpinEdit3.Value)
    End Sub
End Class
