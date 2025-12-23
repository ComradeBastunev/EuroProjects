Module Module1

    Sub Main()
        Dim clArgs() As String = Environment.GetCommandLineArgs()
        Dim sp = New VIA_Print.VIA_Reports
        If clArgs(1) = "1" Then
            sp.PreviewInvoice(clArgs(2), CDbl(clArgs(3)))
        ElseIf clArgs(1) = "2" Then
            sp.PrintInvoice(clArgs(2), CDbl(clArgs(3)))
        ElseIf clArgs(1) = "3" Then
            sp.PrintOrder(clArgs(2), CDbl(clArgs(3)), CDbl(clArgs(4)), CDbl(clArgs(5)))
        ElseIf clArgs(1) = "4" Then
            sp.PrintProforma(clArgs(2), CDbl(clArgs(3)), CDbl(clArgs(4)), CDbl(clArgs(5)), CDbl(clArgs(6)), CDbl(clArgs(7)), CDate(clArgs(8)), CDbl(clArgs(9)), CDbl(clArgs(10)), CDbl(clArgs(11)), CDbl(clArgs(12)))
        ElseIf clArgs(1) = "5" Then
            sp.PrintBodyCheck(clArgs(2), CDbl(clArgs(3)), CDbl(clArgs(4)), CDbl(clArgs(5)))

        End If

    End Sub

End Module
