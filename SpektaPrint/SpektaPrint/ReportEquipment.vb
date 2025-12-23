Public Class ReportEquipment
    Private Sub ReportEquipment_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Equipment_Templates_pTableAdapter1.Connection.ConnectionString = gConnStr
        Equipment_Templates_pTableAdapter1.Fill(DataSet11.Equipment_Templates_p, gTemplNr)
    End Sub
End Class