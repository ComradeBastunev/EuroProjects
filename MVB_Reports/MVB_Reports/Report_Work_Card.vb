Public Class Report_Work_Card

    Private Sub Report_Work_Card_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Dim i, MaxC As Integer, Rows1st As Integer, Rows1stfull As Integer, RowsOth As Integer
        i = 0
        Rows1st = 9
        Rows1stfull = 14
        RowsOth = 20
        Dim usern As String

        Using StoreEntitiesMVB As New StoreEntities1(EntityConnBuild(ConnStr.Value.ToString))
            usern = (From empl In StoreEntitiesMVB.Empl_Summary Select empl.EMPL_USERN).ToList.First
            StoreEntitiesMVB.Database.ExecuteSqlCommand(String.Format("DELETE TmpPrintOrder WHERE USERN = '{0}'", usern))
            Dim op1 = (From op In StoreEntitiesMVB.zMVBOrders_p Where op.ORDER_NO = CDec(Me.Order_No.Value) And op.SERVICE = CDec(Me.Service.Value) And op.SPLIT = CDec(Me.Split.Value) And op.ORDERP_TYPE = 1D).ToList
            For Each op11 In op1
                Dim tmpop As New TmpPrintOrder
                tmpop.ID = i
                tmpop.USERN = usern
                tmpop.Code = op11.CODE
                tmpop.Description = op11.DESCRIPTION
                tmpop.Empl_ID = op11.empl_id
                tmpop.Quant = op11.QUANT
                StoreEntitiesMVB.TmpPrintOrder.Add(tmpop)
                i = i + 1
            Next
            StoreEntitiesMVB.SaveChanges()
            If i > Rows1st Then MaxC = (((i - Rows1stfull - 1) \ RowsOth) + 1) * RowsOth + Rows1st Else MaxC = Rows1st
            While i < MaxC
                i = i + 1
                Dim tmpop As New TmpPrintOrder
                tmpop.ID = i
                tmpop.USERN = usern
                StoreEntitiesMVB.TmpPrintOrder.Add(tmpop)
            End While
            StoreEntitiesMVB.SaveChanges()
        End Using
        TmpPrintOrderTableAdapter.Connection.ConnectionString = ConnStr.Value.ToString
        TmpPrintOrderTableAdapter.Fill(DataSet11.TmpPrintOrder, usern)
        Order_Print_HeaderTableAdapter1.Connection.ConnectionString = ConnStr.Value.ToString
        Order_Print_HeaderTableAdapter1.Fill(DataSet11.Order_Print_Header, CDec(Service.Value), CDec(Order_No.Value), CDec(Split.Value))
        XrBarCode1.Text = "2" & Format(Me.Order_No.Value, "00000000000")
    End Sub
End Class