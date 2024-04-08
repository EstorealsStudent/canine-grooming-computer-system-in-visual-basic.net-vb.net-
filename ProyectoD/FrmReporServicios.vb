Imports Dominio
Public Class FrmReporServicios
    Private Sub FrmReporServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
        Dim fromDate = DateTime.Today
        Dim toDate = DateTime.Now
        LoadBestProductsReport(fromDate, toDate)
    End Sub
    Private Sub LoadBestProductsReport(startDate As DateTime, endDate As DateTime)
        Dim salesOrderModel = New ReportVentas()
        salesOrderModel.GetBestSellingProductsReport(startDate, endDate)
        ReportVentasBindingSource.DataSource = salesOrderModel
        MejoresServiciosBindingSource.DataSource = salesOrderModel.ListBestServices
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ButtonHoy_Click(sender As Object, e As EventArgs) Handles ButtonHoy.Click
        Dim fromDate = DateTime.Today
        Dim toDate = DateTime.Now
        LoadBestProductsReport(fromDate, toDate)
    End Sub

    Private Sub Button7Dias_Click(sender As Object, e As EventArgs) Handles Button7Dias.Click
        Dim fromDate = DateTime.Today.AddDays(-7)
        Dim toDate = DateTime.Now
        LoadBestProductsReport(fromDate, toDate)
    End Sub

    Private Sub ButtonMes_Click(sender As Object, e As EventArgs) Handles ButtonMes.Click
        Dim fromDate = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        Dim toDate = DateTime.Now
        LoadBestProductsReport(fromDate, toDate)
    End Sub

    Private Sub Button30dias_Click(sender As Object, e As EventArgs) Handles Button30dias.Click
        Dim fromDate = DateTime.Today.AddDays(-30)
        Dim toDate = DateTime.Now
        LoadBestProductsReport(fromDate, toDate)
    End Sub

    Private Sub ButtonElAño_Click(sender As Object, e As EventArgs) Handles ButtonElAño.Click
        Dim fromDate = New DateTime(DateTime.Now.Year, 1, 1)
        Dim toDate = DateTime.Now
        LoadBestProductsReport(fromDate, toDate)
    End Sub

    Private Sub ButtonAplicar_Click(sender As Object, e As EventArgs) Handles ButtonAplicar.Click
        Dim fromDate = DateTimePicker1.Value
        Dim toDate = DateTimePicker2.Value
        LoadBestProductsReport(fromDate, New DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59))
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub
End Class