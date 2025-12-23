Imports DevExpress.XtraPrinting
Imports MVB_Reports

Public Class Form1


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim mvb_reports1 As New MVB_Reports.MVB_Reports_Client
        mvb_reports1.PrintOrder("Data Source=BDSOFT-SERVER\SQL2008;Initial Catalog=Store;Integrated Security=True", 100039, 8, 1, "")

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim mvb_reports1 As New MVB_Reports.MVB_Reports_Client
        mvb_reports1.PrintWorkCard("Data Source=BDSOFT-SERVER\SQL2008;Initial Catalog=Store;Integrated Security=True", 100039, 8, 1, "")

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim mvb_reports1 As New MVB_Reports.MVB_Reports_Client
        mvb_reports1.PrintPS("Data Source=BDSOFT-SERVER\SQL2008;Initial Catalog=Store;Integrated Security=True", 100039, 8, 1, "")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim mvb_reports1 As New MVB_Reports.MVB_Reports_Client
        mvb_reports1.PreviewInvoice("Data Source=BDSOFT-SERVER\SQL2008;Initial Catalog=Store;Integrated Security=False;User ID = cust_reports;password=", 9000000485)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim mvb_reports1 As New MVB_Reports.MVB_Reports_Client
        mvb_reports1.PrintOrderNew("Data Source=BDSOFT-SERVER\SQL2008;Initial Catalog=Store;Integrated Security=False;User ID = cust_reports;password=", SpinEditOrderNo.Value, SpinEditService.Value, 1, "")

    End Sub
End Class
