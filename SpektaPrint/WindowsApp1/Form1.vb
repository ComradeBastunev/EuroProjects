Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sp = New SpektaPrint.Spekta_Reports
        sp.PreviewInvoice(TextBox1.Text, NumericUpDown1.Value)
    End Sub
End Class
