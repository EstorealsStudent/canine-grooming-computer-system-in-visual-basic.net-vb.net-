Imports AccesoDatos
Imports Dominio

Public Class ReportVentas
    Private _reportDate As DateTime
    Private _startDate As DateTime
    Private _endDAte As DateTime
    Private _listBestServices As List(Of MejoresServicios)
    Private _total As Double

    Public Property ReportDate As Date
        Get
            Return _reportDate
        End Get
        Private Set(value As Date)
            _reportDate = value
        End Set
    End Property

    Public Property StartDate As Date
        Get
            Return _startDate
        End Get
        Private Set(value As Date)
            _startDate = value
        End Set
    End Property

    Public Property EndDAte As Date
        Get
            Return _endDAte
        End Get
        Private Set(value As Date)
            _endDAte = value
        End Set
    End Property

    Public Property ListBestServices As List(Of MejoresServicios)
        Get
            Return _listBestServices
        End Get
        Private Set(value As List(Of MejoresServicios))
            _listBestServices = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return _total
        End Get
        Private Set(value As Double)
            _total = value
        End Set
    End Property



    'Methods
    Public Sub GetBestSellingProductsReport(fromDate As DateTime, toDate As DateTime)
        'implement dates
        ReportDate = Date.Now()
        StartDate = fromDate
        EndDAte = toDate
        'Create list best selling products
        ListBestServices = New List(Of MejoresServicios)()
        Dim orderDao = New OrderDao()
        Dim resultTable = orderDao.GetBestSellingProducts(fromDate, toDate)
        For Each row As DataRow In resultTable.Rows
            Dim bestProductModel = New MejoresServicios() With
                {
            .ServicioID = Convert.ToInt32(row(0)),
            .ServicioNombre = Convert.ToString(row(1)),
            .Costo = Convert.ToDouble(row(2)),
            .Cantidad = Convert.ToInt32(row(3)),
            .Total = Convert.ToDouble(row(4))
            }
            ListBestServices.Add(bestProductModel)
            Total += Convert.ToDouble(row(4))
        Next
    End Sub
End Class
