Imports DevExpress.XtraPrinting
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraReports.UI

Public Class FormChooseContractType
    Public OrderNo As Double, Split As Double, Service As Double, ConnStr As String

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim DocumentName As String = ""

        Select Case RadioGroup1.SelectedIndex
            Case 2
                DocumentName = "000_Order_name.xls"
            Case 1
                DocumentName = "000_Contract_name.doc"
        End Select
        If RadioGroup1.SelectedIndex = 0 Then
            Using ReportOrder As New ReportOffer
                gForClient = True
                Using printTool As New ReportPrintTool(ReportOrder)
                    ' Invoke the Ribbon Print Preview form modally, 
                    ' and load the report document into it.
                    Try
                        printTool.ShowRibbonPreviewDialog()
                    Catch ex As Exception
                        printTool.ShowRibbonPreviewDialog()
                    End Try

                End Using
            End Using
        ElseIf RadioGroup1.SelectedIndex = 3 Then
            Using ReportOrder As New Report_PPP
                Using printTool As New ReportPrintTool(ReportOrder)
                    ' Invoke the Ribbon Print Preview form modally, 
                    ' and load the report document into it.
                    Try
                        printTool.ShowRibbonPreviewDialog()
                    Catch ex As Exception
                        printTool.ShowRibbonPreviewDialog()
                    End Try
                End Using
            End Using
        ElseIf {1}.Contains(RadioGroup1.SelectedIndex) Then
            Dim FormContract1 As New FormContract
            FormContract1.Rep_Offer_Print_ContractTableAdapter1.Connection.ConnectionString = gConnStr
            Dim tmpDataSource = FormContract1.Rep_Offer_Print_ContractTableAdapter1.GetDataOfferNo(gOfferN).ToList
            If tmpDataSource.Count <> 0 AndAlso Not tmpDataSource.First.IsContr_TypeNull AndAlso tmpDataSource.First.Contr_Type = 2 Then
                DocumentName = "000_Contract_Firm.doc"
            End If
            FormContract1.RichEditControl2.LoadDocument(DocumentName)
            FormContract1.RichEditControl2.Options.MailMerge.DataSource = tmpDataSource
            FormContract1.RichEditControl2.MailMerge(FormContract1.RichEditControl1.Document)
            If RadioGroup1.SelectedIndex = 1 Then
                With FormContract1.RichEditControl1.Document
                    'Try
                    .InsertText(.Bookmarks.Item("SumEuro").Range.Start, Math.Round(tmpDataSource.First.PriceTotal / 1.95583, 2).ToString("0.00"))
                    .InsertText(.Bookmarks.Item("SumEuroNoDiscount").Range.Start, Math.Round(tmpDataSource.First.PriceTotalNoDisc / 1.95583, 2).ToString("0.00"))
                    .InsertText(.Bookmarks.Item("SumTotalEUR").Range.Start, Math.Round(tmpDataSource.First.PriceTotalVAT / 1.95583, 2).ToString("0.00"))
                    .InsertText(.Bookmarks.Item("VAT").Range.Start, Math.Round(tmpDataSource.First.PriceTotalVAT - tmpDataSource.First.PriceTotal, 2).ToString("0.00"))
                    .InsertText(.Bookmarks.Item("VATEuro").Range.Start, Math.Round((tmpDataSource.First.PriceTotalVAT - tmpDataSource.First.PriceTotal) / 1.95583, 2).ToString("0.00"))
                    .InsertText(.Bookmarks.Item("SumTotalVATSlov").Range.Start, Slov(tmpDataSource.First.PriceTotalVAT))
                    'Catch ex As Exception
                    'End Try
                    Dim tbladapter1 = New DataSet1TableAdapters.Equipment_Templates_pTableAdapter
                    tbladapter1.Connection.ConnectionString = gConnStr
                    'Dim tmpEqTempl = tbladapter1.GetData(gOfferN).ToList
                    'Dim tbl1 = .Tables.Create(.Bookmarks.Item("TableOptions").Range.Start, tmpEqTempl.Where(Function(p) (p.EqType = 1 Or p.EqType = 2) And p.IsPackEqIDNull).Count, 1)
                    'Dim i As Integer = 0
                    'For Each eq In tmpEqTempl.Where(Function(p) (p.EqType = 1 Or p.EqType = 2) And p.IsPackEqIDNull)
                    '    Dim tmptxt As String = ""
                    '    If eq.ISPack Then
                    '        For Each eqp In tmpEqTempl.Where(Function(p) (p.EqType = 1 Or p.EqType = 2) And Not p.IsPackEqIDNull).Where(Function(p) p.PackEqID = eq.ID)
                    '            tmptxt = tmptxt + "; " + eqp.Description
                    '        Next
                    '    End If
                    '    .InsertText(tbl1.Rows(i).FirstCell.Range.Start, String.Format("({0}) {1}{2}", eq.Code, eq.Description, tmptxt))
                    '    i = i + 1
                    'Next
                End With
            End If
            FormContract1.Show()
        ElseIf RadioGroup1.SelectedIndex = 2 Then
            Dim formXLS = New Form1
            Dim SpreadsheetControl1 = formXLS.SpreadsheetControl1
            With SpreadsheetControl1
                .LoadDocument(DocumentName)
                .Document.Unit = DevExpress.Office.DocumentUnit.Millimeter
                .ActiveWorksheet.PrintOptions.FitToPage = True
                .ActiveWorksheet.PrintOptions.FitToHeight = 2
                .ActiveWorksheet.PrintOptions.FitToWidth = 0
                With .Document.Worksheets(0)
                    Dim tmpadapt = New DataSet1TableAdapters.Rep_Orders_OfferTableAdapter
                    tmpadapt.Connection.ConnectionString = gConnStr
                    If LookUpEdit1.EditValue Is Nothing Then
                        Throw New Exception("Не сте избрали поръчка")
                    End If
                    Dim ord = tmpadapt.GetData(gOfferN).ToList.Where(Function(p) p.order_no = LookUpEdit1.EditValue).First
                    Dim tmpadapt1 = New DataSet1TableAdapters.Rep_Equipment_OfferTableAdapter
                    tmpadapt1.Connection.ConnectionString = gConnStr
                    Dim cardata = tmpadapt1.GetData(gOfferN).ToList.First
                    .Cells("B7").SetValue("ПОРЪЧКА " + ord.Internal_Nr.ToString)

                    .Cells("C10").SetValue(ord.firm)
                    .Cells("C11").SetValue(ord.VAT_NO)
                    .Cells("C12").SetValue(ord.CITY + " " + ord.ADDRESS1)
                    If Not ord.IsPHONENull Then .Cells("C14").SetValue(ord.PHONE)
                    If Not ord.IsEMAILNull Then .Cells("C14").SetValue(.Cells("C14").Value.TextValue + "/" + ord.EMAIL)
                    If ord.Contr_Type = 1 Then
                        .Cells("C15").SetValue(ord.firm)
                    Else
                        If Not ord.IsREPRESENTNull Then .Cells("C15").SetValue(ord.REPRESENT)
                    End If
                    .Cells("C17").SetValue(ord.PORDER_NO)
                    .Cells("C18").SetValue(ord.Serie)
                    .Cells("C19").SetValue(ord.Trim)
                    .Cells("C20").SetValue(ord.Descipt)
                    .Cells("C21").SetValue(ord.Fuel + "/" + ord.PowerKW.ToString + " kW")
                    .Cells("C22").SetValue(ord.Transmission + " " + ord.TransmissionType)
                    .Cells("C23").SetValue(ord.Code)
                    .Cells("C24").SetValue(ord.ENGINE_NR)
                    .Cells("C25").SetValue(cardata.ColorCode + "/" + cardata.ColorName)
                    .Cells("G32").SetValue((cardata.BasePriceNoDiscVAT))
                    .Cells("G49").SetValue((cardata.BasePriceVAT - cardata.BasePriceNoDiscVAT + cardata.DiscountVAT))
                    .Cells("G50").SetValue((cardata.PriceTotalVAT))
                    If Not ord.IsSumAdvanceVATNull Then .Cells("G51").SetValue((ord.SumAdvanceVAT))
                    Dim tbladapter1 = New DataSet1TableAdapters.Rep_Equipment_Templates_pTableAdapter
                    tbladapter1.Connection.ConnectionString = gConnStr
                    Dim tmpEqTempl = tbladapter1.GetData(ord.TemplNr).ToList
                    Dim PriceColor As Decimal = 0

                    For Each eq In tmpEqTempl.Where(Function(p) (p.EqType = 1) And p.IsColor)
                        PriceColor = PriceColor + eq.PriceVat
                    Next
                    .Cells("G34").SetValue(PriceColor)
                    Dim i As Integer = 35
                    Dim PriceOthers As Decimal = 0
                    For Each addeq In tmpEqTempl.Where(Function(p) ((p.EqType = 2 Or p.EqType = 1) And Not p.IsProductTax And Not p.IsColor And p.PriceVat <> 0)).OrderByDescending(Function(p) p.Row_No)
                        If i > 45 Then
                            PriceOthers = PriceOthers + addeq.SummVAT
                        Else
                            .Cells("A" + i.ToString("0")).SetValue(addeq.DEscription)
                            .Cells("G" + i.ToString("0")).SetValue(addeq.SummVAT)
                            i = i + 1
                        End If
                    Next
                    If PriceOthers <> 0 Then
                        .Cells("A46").SetValue("Допълнително оборудване")
                        .Cells("G46").SetValue(PriceOthers)
                    End If
                    .Cells("A85").SetValue((ord.PreparedByName))
                    If ord.Contr_Type = 1 Then
                        .Cells("E85").SetValue((ord.firm))
                    Else
                        If Not ord.IsREPRESENTNull Then .Cells("E85").SetValue(ord.REPRESENT) Else .Cells("E85").SetValue(ord.firm)
                    End If
                End With
                formXLS.Show()
                SpreadsheetControl1.ActiveWorksheet.PrintOptions.FitToPage = True
                SpreadsheetControl1.ActiveWorksheet.PrintOptions.FitToWidth = 1
                'Using printingSystem As New PrintingSystem
                '    Using link As New PrintableComponentLink(printingSystem)
                '        link.Component = SpreadsheetControl1
                '        link.CreateDocument()
                '        link.EnablePageDialog = False
                '        Dim ps As PrintingSystemBase = link.PrintingSystem
                '        ps.SetCommandVisibility(PrintingSystemCommand.Find, CommandVisibility.None)
                '        ps.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.None)
                '        ps.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.None)
                '        ps.SetCommandVisibility(PrintingSystemCommand.EditPageHF, CommandVisibility.None)
                '        ps.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.None)
                '        ps.SetCommandVisibility(PrintingSystemCommand.Magnifier, CommandVisibility.None)
                '        ps.SetCommandVisibility(PrintingSystemCommand.MultiplePages, CommandVisibility.None)

                '        link.PrintingSystem.PreviewFormEx.ShowDialog()
                '        'link.PrintingSystem.Print()

                '    End Using
                'End Using
            End With
        ElseIf RadioGroup1.SelectedIndex = 3 Then
            Dim formXLS = New Form1
            Dim SpreadsheetControl1 = formXLS.SpreadsheetControl1
            With SpreadsheetControl1
                .LoadDocument(DocumentName)
                .Document.Unit = DevExpress.Office.DocumentUnit.Millimeter
                .ActiveWorksheet.PrintOptions.FitToPage = True
                .ActiveWorksheet.PrintOptions.FitToHeight = 2
                .ActiveWorksheet.PrintOptions.FitToWidth = 1
                With .Document.Worksheets(0)
                    Dim tmpadapt = New DataSet1TableAdapters.Rep_Orders_OfferTableAdapter
                    If LookUpEdit1.EditValue Is Nothing Then
                        Throw New Exception("Не сте избрали поръчка")
                    End If
                    Dim ord = tmpadapt.GetData(gOfferN).ToList.Where(Function(p) p.order_no = LookUpEdit1.EditValue).First

                    Dim tmpadapt1 = New DataSet1TableAdapters.Rep_Offer_Print_ContractTableAdapter
                    Dim cardata = tmpadapt1.GetDataOfferNo(gOfferN).ToList.First
                    .Cells("B5").SetValue(Now.ToShortDateString)
                    .Cells("B21").SetValue(ord.firm)
                    .Cells("F21").SetValue(ord.VAT_NO)
                    .Cells("A22").SetValue(ord.CITY + " " + ord.ADDRESS1)
                    .Cells("C31").SetValue(ord.Make)
                    .Cells("C32").SetValue(ord.Descipt)
                    .Cells("C33").SetValue(ord.Code)
                    If Not cardata.IsSumAdvanceVATNull Then
                        .Cells("A40").SetValue("В размер на " + cardata.SumAdvanceVAT.ToString("0.00") + " (" + Slov(cardata.SumAdvanceVAT) + ")")
                    End If
                End With

                formXLS.Show()

                'Using printingSystem As New PrintingSystem
                '    Using link As New PrintableComponentLink(printingSystem)
                '        link.Component = SpreadsheetControl1
                '        link.CreateDocument()
                '        link.EnablePageDialog = False
                '        Dim ps As PrintingSystemBase = link.PrintingSystem
                '        ps.SetCommandVisibility(PrintingSystemCommand.Find, CommandVisibility.None)
                '        ps.SetCommandVisibility(PrintingSystemCommand.Background, CommandVisibility.None)
                '        ps.SetCommandVisibility(PrintingSystemCommand.FillBackground, CommandVisibility.None)
                '        ps.SetCommandVisibility(PrintingSystemCommand.EditPageHF, CommandVisibility.None)
                '        ps.SetCommandVisibility(PrintingSystemCommand.HandTool, CommandVisibility.None)
                '        ps.SetCommandVisibility(PrintingSystemCommand.Magnifier, CommandVisibility.None)
                '        ps.SetCommandVisibility(PrintingSystemCommand.MultiplePages, CommandVisibility.None)
                '        link.PrintingSystem.PreviewFormEx.ShowDialog()
                '        'link.PrintingSystem.Print()
                '    End Using
                'End Using
            End With
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim DocumentName As String = ""

        Select Case RadioGroup1.SelectedIndex
            Case 0
                DocumentName = "000_Order_name.xls"
            Case 1
                DocumentName = "000_Contract_name.doc"
        End Select
        If {1}.Contains(RadioGroup1.SelectedIndex) Then
            Dim FormContract1 As New FormContract
            FormContract1.Rep_Offer_Print_ContractTableAdapter1.Connection.ConnectionString = gConnStr
            If RadioGroup1.SelectedIndex = 4 Or RadioGroup1.SelectedIndex = 5 Then
                Dim tmpadapter = New DataSet1TableAdapters.Rep_Orders_OfferTableAdapter
                Dim tmpDataSource = tmpadapter.GetData(gOfferN)
                FormContract1.RichEditControl1.Options.MailMerge.DataSource = tmpDataSource
            Else
                Dim tmpDataSource = FormContract1.Rep_Offer_Print_ContractTableAdapter1.GetDataOfferNo(gOfferN).ToList
                FormContract1.RichEditControl1.Options.MailMerge.DataSource = tmpDataSource
                If tmpDataSource.Count <> 0 AndAlso Not tmpDataSource.First.IsContr_TypeNull AndAlso tmpDataSource.First.Contr_Type = 2 Then
                    DocumentName = "000_Contract_Firm.doc"
                End If
            End If
            FormContract1.RichEditControl1.LoadDocument(DocumentName)
            FormContract1.MailingsRibbonPage1.Visible = True
            FormContract1.Show()
        End If




    End Sub
End Class