Module Module1

    Sub Main()

        Dim clArgs() As String = Environment.GetCommandLineArgs()
        Dim sp = New SpektaPrint.Spekta_Reports
        If clArgs(1) = "1" Then
            sp.PreviewInvoice(clArgs(2), CDbl(clArgs(3)))
        ElseIf clArgs(1) = "2" Then
            sp.PrintInvoice(clArgs(2), CDbl(clArgs(3)))
        ElseIf clArgs(1) = "3" Then
            sp.PrintBill(clArgs(2), CDbl(clArgs(3)), CDbl(clArgs(4)), CDbl(clArgs(5)), CDbl(clArgs(6)), CDbl(clArgs(7)), CDate(clArgs(8)), CDbl(clArgs(9)), CDbl(clArgs(10)), CDbl(clArgs(11)), CDbl(clArgs(12)))
        ElseIf clArgs(1) = "4" Then
            sp.PrintOrder(clArgs(2), CDbl(clArgs(3)), CDbl(clArgs(4)), CDbl(clArgs(5)))
        ElseIf clArgs(1) = "5" Then
            sp.PrintProforma(clArgs(2), CDbl(clArgs(3)), CDbl(clArgs(4)), CDbl(clArgs(5)), CDbl(clArgs(6)), CDbl(clArgs(7)), CDate(clArgs(8)), CDbl(clArgs(9)), CDbl(clArgs(10)), CDbl(clArgs(11)), CDbl(clArgs(12)))
        ElseIf clArgs(1) = "6" Then
            sp.PrintDoc163(clArgs(2), CInt(clArgs(3)), CInt(clArgs(4)))
        ElseIf clArgs(1) = "7" Then
            sp.PrintStokova(clArgs(2), CInt(clArgs(3)), CInt(clArgs(4)))
        ElseIf clArgs(1) = "8" Then
            sp.PrintCheckList(clArgs(2), CDbl(clArgs(3)), CDbl(clArgs(4)), CDbl(clArgs(5)))
        ElseIf clArgs(1) = "9" Then
            sp.PrintLabels(clArgs(2), CInt(clArgs(3)))
        ElseIf clArgs(1) = "10" Then
            sp.PrintOffer(clArgs(2), CInt(clArgs(3)))
        ElseIf clArgs(1) = "11" Then
            sp.PrintCarDocs(clArgs(2), clArgs(3), CInt(clArgs(4)))
        End If



    End Sub

End Module
