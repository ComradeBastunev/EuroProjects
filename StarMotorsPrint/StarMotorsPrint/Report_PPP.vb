Public Class Report_PPP
    Private Sub ReportHeader_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles ReportHeader.BeforePrint
    End Sub

    Private Sub Report_PPP_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        CarOrdersListTableAdapter1.Connection.ConnectionString = gConnStr
        CarOrdersListTableAdapter1.Fill(DataSet11.CarOrdersList, gCode, CDec(gStore))
        If DataSet11.CarOrdersList.Count <> 0 Then
            gCarsDetID = DataSet11.CarOrdersList.First.Cars_Det_ID
            If Not DataSet11.CarOrdersList.First.IsInvoiceToNull Then
                If MsgBox("Получател е крайният клиент (YES) или този на, когото се фактурира (NO) ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    If DataSet11.CarOrdersList.First.Contr_Type <> 1 Then
                        XrTableCellPPPHeader.Text = "Днес, [DateSale!dd.MM.yyyy 'г.'] [InvoiceToFirm] със седалище и адрес на управление в [InvToCITY], [InvToADDRESS1], вписано в Търговския регистър при Агенция по вписванията с ЕИК [InvToVAT_NO], с ДДС номер [InvToBulstat], представлявано от [InvToREPRESENT], получих от Добромир Станчев- служител на фирма "“Стар Моторс"” ЕООД, със седалище и адрес на управление гр. София, бул. "“Христофор Колумб "“ 43, ЕИК: BG130571835, наричан Продавач следния нов автомобил"
                    Else
                        XrTableCellPPPHeader.Text = "Днес, [DateSale!dd.MM.yyyy 'г.']  [InvoiceToFirm] с ЕГН: [IntToVAT_NO] и адрес [InvToCITY], [InvToADDRESS1], наричано по-долу КУПУВАЧ, получих от Добромир Станчев - служител на фирма "“Стар Моторс”" ЕООД, със седалище и адрес на управление гр. София, бул. "“Христофор Колумб "“ 43, ЕИК: BG130571835, наричан Продавач следния лек автомобил:"
                    End If
                Else
                    If DataSet11.CarOrdersList.First.Contr_Type <> 1 Then
                        XrTableCellPPPHeader.Text = "Днес, [DateSale!dd.MM.yyyy 'г.'] [FIRM] със седалище и адрес на управление в [City], [Address1] [Address2] , вписано в Търговския регистър при Агенция по вписванията с ЕИК [VAT_NO], с ДДС номер [Bulstat], представлявано от [Represent], получих от Добромир Станчев- служител на фирма "“Стар Моторс"” ЕООД, със седалище и адрес на управление гр. София, бул. "“Христофор Колумб "“ 43, ЕИК: BG130571835, наричан Продавач следния нов автомобил"
                    End If
                End If
            Else
                If DataSet11.CarOrdersList.First.Contr_Type <> 1 Then
                    XrTableCellPPPHeader.Text = "Днес, [DateSale!dd.MM.yyyy 'г.'] [FIRM] със седалище и адрес на управление в [City], [Address1] [Address2] , вписано в Търговския регистър при Агенция по вписванията с ЕИК [VAT_NO], с ДДС номер [Bulstat], представлявано от [Represent], получих от Добромир Станчев- служител на фирма "“Стар Моторс"” ЕООД, със седалище и адрес на управление гр. София, бул. "“Христофор Колумб "“ 43, ЕИК: BG130571835, наричан Продавач следния нов автомобил"
                End If

            End If
        End If
    End Sub
End Class