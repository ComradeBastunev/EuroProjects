Imports System.Runtime.InteropServices
Imports DevExpress.XtraReports.UI


Public Interface ITopes_Reports_Client
    Function PrintProtocol(aConnStr As String, aInv_No As Long) As Integer

End Interface

<ClassInterface(ClassInterfaceType.None)> Public Class Topes_Reports
    Implements ITopes_Reports_Client

    Function PrintProtocol(aConnStr As String, aInv_No As Long) As Integer Implements ITopes_Reports_Client.PrintProtocol
        PrintProtocol = 0
        Dim ReportProtocol As New XtraReport1
        ReportProtocol.ConnStr.Value = aConnStr
        ReportProtocol.Inv_No.Value = CDec(aInv_No)
        ReportProtocol.ShowRibbonPreviewDialog()
        PrintProtocol = 1
        Return PrintProtocol
    End Function

End Class

