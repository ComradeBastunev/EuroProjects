Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Proforma1

    Private Sub Invoice_Deal_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        If gShowCodes <> 0 Then XrTableCell31.DataBindings.Clear()
        Print_ProformaTableAdapter1.Connection.ConnectionString = gConnStr
        Print_ProformaTableAdapter1.Fill(DataSet11.Print_Proforma, CDec(gOrderNo), CDec(gService), CDec(gSplit), CDec(gCurr), CDec(gRateType), gRateDate, CDec(gShowAll), CDec(gOrderType), True)
        Bank_accTableAdapter1.Connection.ConnectionString = gConnStr
        Bank_accTableAdapter1.Fill(DataSet11.bank_acc, CDec(gBankAcc))
        SummaryTableAdapter1.Connection.ConnectionString = gConnStr
        SummaryTableAdapter1.Fill(DataSet11.SUMMARY)

        If DataSet11.Print_Proforma.Count > 0 AndAlso Not DataSet11.Print_Proforma.First.IsModelNull AndAlso DataSet11.Print_Proforma.First.Model.ToUpper.Contains("LEXUS") Then
            XrPictureBoxToyota.Visible = False
            XrPictureBoxLexus.Visible = True
        End If



    End Sub

    Private Sub Invoice_Deal_AfterPrint(sender As Object, e As EventArgs) Handles MyBase.AfterPrint


        Dim PubsConn As SqlConnection = New SqlConnection(gConnStr)
        Dim testCMD As SqlCommand = New SqlCommand("Set_Order_Proforma", PubsConn)
        testCMD.CommandType = CommandType.StoredProcedure
        Dim aOrder_No As SqlParameter = testCMD.Parameters.Add("@Order_No", SqlDbType.Decimal, 10)
        Dim aSplit As SqlParameter = testCMD.Parameters.Add("@Split", SqlDbType.Decimal, 10)
        Dim aService As SqlParameter = testCMD.Parameters.Add("@Service", SqlDbType.Decimal, 10)
        aOrder_No.Direction = ParameterDirection.Input
        aSplit.Direction = ParameterDirection.Input
        aService.Direction = ParameterDirection.Input
        aService.Value = gService
        aOrder_No.Value = gOrderNo
        aSplit.Value = gSplit
        PubsConn.Open()
        Dim rvRows As Integer = testCMD.ExecuteNonQuery
    End Sub
End Class