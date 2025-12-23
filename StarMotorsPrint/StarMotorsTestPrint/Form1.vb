Imports StarMotorsPrint

Public Class Form1
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim newclass = New StarMotorsPrint.StarMotorsReports
        'newclass.IStarMotorsReports_PrintOffer(TextEdit1.Text, SpinEdit1.Value)
        'newclass.IStarMotorsReports_PrintProforma(TextEdit1.Text, 8, 100015, 1, 1, 1, Today(), 1, 1, 1, 1)
        newclass.IStarMotorsReports_PreviewInvoice(TextEdit1.Text, 202171)
    End Sub
End Class
