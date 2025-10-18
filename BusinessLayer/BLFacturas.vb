Imports BusinessEntities
Imports DataLayer

Public Class BLFacturas

    Public Function RegistreLaFactura(ByVal laFacturaAGuardar As BEFacturas) As Boolean
        Dim dlFacturas As New DLFacturas
        Return dlFacturas.RegistreLaFactura(laFacturaAGuardar)
    End Function
    Public Function Cargar_Facturas_Por_Proveedor(ByVal numeroFactura As String, ByVal codigoProveedor As Int32) As DataTable
        Dim dlFacturas As New DLFacturas
        Return dlFacturas.Cargar_Facturas_Por_Proveedor(numeroFactura, codigoProveedor)
    End Function

    Public Function CargueElArticuloPorCodigo(ByVal codigoArticulo As Integer) As Articulo
        Dim dlFacturas As New DLFacturas
        Return dlFacturas.CargueElArticuloPorCodigo(codigoArticulo)
    End Function
    Public Function CargueLaCantidadDelArticulo(ByVal codigoArticulo As Integer) As Integer
        Dim dlFacturas As New DLFacturas
        Return dlFacturas.CargueLaCantidadDelArticulo(codigoArticulo)
    End Function

    Public Function CargueLaConsultaDeArticulosPorFiltros(ByVal elFiltroSeleccionadoNombre As String,
                                                          ByVal elFiltroSeleccionadoCodigo As String,
                                                          ByVal elCodigoArticulo As Integer,
                                                          ByVal elNombreDelArticulo As String) As DataTable
        Dim dlFacturas As New DLFacturas
        Return dlFacturas.CargueLaConsultaDeArticulosPorFiltros(elFiltroSeleccionadoNombre,
                                                                elFiltroSeleccionadoCodigo,
                                                                elCodigoArticulo,
                                                                elNombreDelArticulo)
    End Function

    Public Function CargueLaConsultaDeFacturasPorFiltros(ByVal elFiltroSeleccionadoCodigo As String,
                                                         ByVal elFiltroSeleccionadoNombre As String,
                                                         ByVal elFiltroSeleccionadoFechas As String,
                                                         ByVal elCodigoArticulo As Integer,
                                                         ByVal elNombreDelArticulo As String,
                                                         ByVal laFechaInicial As String,
                                                         ByVal laFechaFinal As String) As DataTable
        Dim dlFacturas As New DLFacturas
        Return dlFacturas.CargueLaConsultaDeFacturasPorFiltros(elFiltroSeleccionadoCodigo,
                                                               elFiltroSeleccionadoNombre,
                                                               elFiltroSeleccionadoFechas,
                                                               elCodigoArticulo,
                                                               elNombreDelArticulo,
                                                               laFechaInicial,
                                                               laFechaFinal)
    End Function

    Public Function CargueElDetalleDeLaFacturaSeleccionada(ByVal codigo As Integer) As List(Of BEFacturaLinea)
        Dim dlFacturas As New DLFacturas
        Return dlFacturas.CargueElDetalleDeLaFacturaSeleccionada(codigo)
    End Function
    Public Function ElimineLaFacturaSeleccionada(ByVal elCodigoFacturaSeleccionada As Integer) As Boolean
        Dim dlFacturas As New DLFacturas
        Return dlFacturas.ElimineLaFacturaSeleccionada(elCodigoFacturaSeleccionada)
    End Function
End Class
