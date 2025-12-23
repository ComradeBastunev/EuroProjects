Module Module1

    Sub Main()
        Dim clArgs() As String = Environment.GetCommandLineArgs()
        Dim CopyNum As Integer
        Dim sp = New StarMotorsPrint.StarMotorsReports
        If clArgs(1) = "1" Then
            sp.IStarMotorsReports_PreviewInvoice(clArgs(2), CDbl(clArgs(3)))
        ElseIf clArgs(1) = "2" Then
            CopyNum = CInt(clArgs(4))
            While CopyNum > 0
                sp.IStarMotorsReports_PrintInvoice(clArgs(2), CDbl(clArgs(3)))
                CopyNum = CopyNum - 1
            End While
        ElseIf clArgs(1) = "3" Then
            sp.IStarMotorsReports_PrintOrder(clArgs(2), CDbl(clArgs(3)), CDbl(clArgs(4)), CDbl(clArgs(5)))
        ElseIf clArgs(1) = "4" Then
            sp.IStarMotorsReports_PrintProforma(clArgs(2), CDbl(clArgs(3)), CDbl(clArgs(4)), CDbl(clArgs(5)), CDbl(clArgs(6)), CDbl(clArgs(7)), CDate(clArgs(8)), CDbl(clArgs(9)), CDbl(clArgs(10)), CDbl(clArgs(11)), CDbl(clArgs(12)))
        ElseIf clArgs(1) = "5" Then
            sp.IStarMotorsReports_PrintCarDocs(clArgs(2), clArgs(3), CDbl(clArgs(4)), CDbl(clArgs(5)))
        ElseIf clArgs(1) = "6" Then
            sp.IStarMotorsReports_PrintOffer(clArgs(2), CDbl(clArgs(3)))
        ElseIf clArgs(1) = "7" Then
            sp.IStarMotorsReports_PrintProtocolPPP(clArgs(2), clArgs(3), CDbl(clArgs(4)))

        End If

    End Sub

End Module
