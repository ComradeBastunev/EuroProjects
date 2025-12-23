Imports Math
Imports System.IO
Imports System.IO.Compression

Module Module1
    Friend gOrderNo As Long
    Friend gService As Integer
    Friend gSplit As Integer
    Friend gConnStr As String
    Friend gInv_No As Double
    Friend gForClient As Boolean
    Friend gCurr As Integer
    Friend gRateType As Integer
    Friend gRateDate As DateTime
    Friend gShowAll As Integer
    Friend gBankAcc As Integer
    Friend gShowCodes As Integer
    Friend gOrderType As Integer
    Friend gCode As String
    Friend gStore As Integer
    Friend gID As Integer
    Friend gEmplNo As Integer
    Friend gReportDate As DateTime
    Friend gOfferN As Integer
    Friend DocsByOfferNo As Boolean
    Friend ModelID As Integer
    Friend gTransl As Boolean
    Friend gShort As Boolean
    Friend gCarsDetID As Integer

    Function Slov(ByVal a As Double) As String
        Dim razre(3) As String
        Dim razrm(3) As String
        Dim razrt(3) As Boolean
        Dim numbs(9) As String
        Dim Curr(1) As String
        Dim b As String
        Dim ran_cval, ran_val As Integer
        Dim I, C, ran, b1, b2, b3, cval As Integer
        Dim a1 As Double
        Dim need_i As Boolean
        Dim aSlov As String
        Dim sign As String
        sign = ""
        If a < 0 Then
            sign = "Минус "
            a = -a
        End If
        If (a > 999999999999) Then
            aSlov = ""
            Return aSlov
        End If

        razre(0) = ""
        razre(1) = "хиляда"
        razre(2) = "милион"
        razre(3) = "милиард"
        razrm(0) = ""
        razrm(1) = "хиляди"
        razrm(2) = "милиона"
        razrm(3) = "милиарда"
        razrt(0) = True
        razrt(1) = False
        razrt(2) = True
        razrt(3) = True
        numbs(0) = "нула"
        numbs(1) = "едно"
        numbs(2) = "две"
        numbs(3) = "три"
        numbs(4) = "четири"
        numbs(5) = "пет"
        numbs(6) = "шест"
        numbs(7) = "седем"
        numbs(8) = "осем"
        numbs(9) = "девет"
        Curr(0) = "лев"
        Curr(1) = "лева"

        a1 = a - Math.Truncate(a)
        a = Math.Truncate(a)
        b = a.ToString
        ran = Math.Truncate((b.Length - 1) / 3) + 1
        C = ran * 3 - b.Length
        aSlov = ""
        For I = 1 To C
            b = "0" + b
        Next
        cval = 0
        For I = 1 To ran
            ran_cval = 0
            b1 = CInt(b.Substring((I - 1) * 3 + 0, 1))
            b2 = CInt(b.Substring((I - 1) * 3 + 1, 1))
            b3 = CInt(b.Substring((I - 1) * 3 + 2, 1))
            ran_val = b1 * 100 + b2 * 10 + b3
            'Изчисляване стотици}
            ran_cval = b1 * 100
            cval = cval + b1 * 100 * Math.Truncate(Math.Pow(1000, ran - I))
            If (I > 1) And (ran_cval = ran_val) And (cval = a) And (b1 > 0) Then aSlov = aSlov + "и "
            If (b1 * 100 * Math.Pow(1000, ran - I) < cval) And (b1 = 0) And (cval + (ran_val - ran_cval) * Math.Pow(1000, ran - I) = a) Then need_i = True Else need_i = False
            If b1 = 1 Then aSlov = aSlov + "сто "
            If (b1 = 2) Or (b1 = 3) Then aSlov = aSlov + numbs(b1) + "ста "
            If b1 > 3 Then aSlov = aSlov + numbs(b1) + "стотин "
            'Изчисляване десетки}
            ran_cval = ran_cval + b2 * 10
            cval = cval + b2 * 10 * Math.Truncate(Math.Pow(1000, ran - I))
            If ((b2 * 10 * Math.Pow(1000, ran - I) < cval) And (cval = a) And (b2 > 0)) Or (need_i And (((b3 = 0) And (b2 > 0)) Or (b2 = 1))) Or ((b1 > 0) And (((ran_cval = ran_val) And (b2 > 0)) Or (b2 = 1))) Then aSlov = aSlov + "и "
            cval = cval + b3 * Math.Truncate(Math.Pow(1000, ran - I))
            If b2 = 1 Then
                Select Case b3
                    Case 0
                        aSlov = aSlov + "десет "
                    Case 1
                        aSlov = aSlov + "единадесет "
                    Case 2
                        aSlov = aSlov + "дванадесет "
                    Case Else
                        aSlov = aSlov + numbs(b3) + "надесет "
                End Select
            Else
                If b2 = 2 Then aSlov = aSlov + "двадесет "
                If b2 > 2 Then aSlov = aSlov + numbs(b2) + "десет "
                'Изчисляване единици}
                If b3 > 0 Then
                    If ((b2 > 1) Or ((b1 <> 0) And (b2 = 0)) Or need_i) Then aSlov = aSlov + "и "
                    If b3 > 2 Then
                        aSlov = aSlov + numbs(b3) + " "
                    ElseIf b3 = 2 Then
                        If razrt(ran - I) Then aSlov = aSlov + "два " Else aSlov = aSlov + "две "
                    Else
                        If Not ((b1 = 0) And (b2 = 0) And (I = ran - 1)) Then
                            If razrt(ran - I) Then aSlov = aSlov + "един " Else aSlov = aSlov + "една "
                        End If
                    End If
                End If
            End If
            If I <= ran Then
                If ran_val > 0 Then
                    If ran_val > 1 Then
                        aSlov = aSlov + razrm(ran - I)
                    Else
                        aSlov = aSlov + razre(ran - I)
                    End If
                    If ran - I > 0 Then aSlov = aSlov + " "
                End If
            End If
        Next
        If a > 0 Then
            If a > 1 Then aSlov = aSlov + Curr(1) Else aSlov = aSlov + Curr(0)
            If aSlov <> "" Then aSlov = UCase(aSlov.Substring(0, 1)) + aSlov.Substring(1, aSlov.Length - 1)
            If a1 <> 0 Then
                If aSlov <> "" Then aSlov = aSlov + " и "
                aSlov = sign + aSlov + a1.ToString("0.00")
            End If
        End If
        Return aSlov
    End Function

    Friend Sub PrintingSystem_StartPrint(sender As Object, e As DevExpress.XtraPrinting.PrintDocumentEventArgs)
        e.PrintDocument.PrinterSettings.Duplex = System.Drawing.Printing.Duplex.Vertical
    End Sub

    Function Decompress(ByVal toDecompress As Byte()) As Byte()
        ' Get the stream of the source file.
        Using inputStream As MemoryStream = New MemoryStream(toDecompress)

            ' Create the decompressed stream.
            Using outputStream As MemoryStream = New MemoryStream()
                Using decompressionStream As DeflateStream =
                    New DeflateStream(inputStream, CompressionMode.Decompress)

                    ' Copy the decompression stream
                    ' into the output file.
                    decompressionStream.CopyTo(outputStream)

                End Using

                Decompress = outputStream.ToArray

            End Using
        End Using
    End Function

    Public Function DecompressGZip(bytesToDecompress As Byte()) As Byte()
        Using stream As New GZipStream(New MemoryStream(bytesToDecompress), CompressionMode.Decompress)
            Const size As Integer = 4096
            Dim buffer As Byte() = New Byte(size - 1) {}
            Using memoryStream As New MemoryStream()
                Dim count As Integer
                Do
                    count = stream.Read(buffer, 0, size)
                    If count > 0 Then
                        memoryStream.Write(buffer, 0, count)
                    End If
                Loop While count > 0
                Return memoryStream.ToArray()
            End Using
        End Using
    End Function

End Module
