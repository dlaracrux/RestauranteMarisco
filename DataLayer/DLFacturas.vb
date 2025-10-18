Imports System.Data.SqlClient
Imports BusinessEntities

Public Class DLFacturas
    Inherits DLConexion
    Public Function RegistreLaFactura(ByVal laFacturaAGuardar As BEFacturas) As Boolean
        DefineStrConexion()

        Dim cnn As SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim transaccion As SqlTransaction
        Dim codigoFactura As Integer

        cnn = New SqlConnection(DBSistemaCnnStr)
        cnn.Open()
        transaccion = cnn.BeginTransaction("RegistroFacturas")

        Try
            Cmd.Connection = cnn
            Cmd.Transaction = transaccion
            Cmd.CommandTimeout = 60
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "SP_RegistreLaFacturaEncabezado"
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@NombreCliente", laFacturaAGuardar.NombreCliente)
            Cmd.Parameters.AddWithValue("@FechaFactura", laFacturaAGuardar.FechaFactura)
            Cmd.Parameters.AddWithValue("@CedulaCliente", laFacturaAGuardar.CedulaCliente)
            Cmd.Parameters.AddWithValue("@Usuario", laFacturaAGuardar.Usuario)
            Cmd.Parameters.AddWithValue("@TotalFactura", laFacturaAGuardar.TotalFactura)
            Cmd.Parameters.AddWithValue("@TotalImpuesto", laFacturaAGuardar.TotalImpuesto)
            Cmd.Parameters.AddWithValue("@Lugar", laFacturaAGuardar.Lugar)
            Da.SelectCommand = Cmd
            Da.Fill(Ds)
            codigoFactura = CInt(Ds.Tables(0).Rows(0)("codigoFactura"))

            For Cont As Integer = 0 To laFacturaAGuardar.Lineas.Count - 1
                Cmd.Connection = cnn
                Cmd.Transaction = transaccion
                Cmd.CommandTimeout = 60
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.CommandText = "SP_RegistreElDetalleDeFacturacion"
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@CodigoFactura", codigoFactura)
                Cmd.Parameters.AddWithValue("@CodigoArticulo", laFacturaAGuardar.Lineas(Cont).CodigoArticulo)
                Cmd.Parameters.AddWithValue("@Cantidad", laFacturaAGuardar.Lineas(Cont).Cantidad)
                Cmd.Parameters.AddWithValue("@PrecioUnitario", laFacturaAGuardar.Lineas(Cont).PrecioUnitario)
                Cmd.Parameters.AddWithValue("@TotalLinea", laFacturaAGuardar.Lineas(Cont).PrecioTotalLinea)
                Cmd.ExecuteNonQuery()
            Next
            transaccion.Commit()
            cnn.Close()
            MsgBox("La factura fue registrada correctamente", MsgBoxStyle.Information, "Mantenimiento de Facturas")
        Catch ex As SqlException
            transaccion.Rollback()
            cnn.Close()
            MsgBox("No se ha podido registrar la factura. Intente de nuevo.", MsgBoxStyle.Critical, "Mantenimiento de Facturas")
            Return False
        Catch ex As Exception
            transaccion.Rollback()
            cnn.Close()
            MsgBox("No se ha podido registrar la factura. Intente de nuevo.", MsgBoxStyle.Critical, "Mantenimiento de Facturas")
            Return False
        End Try
        Return True
    End Function

    Public Function CargueLaConsultaDeFacturasPorFiltros(ByVal elFiltroSeleccionadoCodigo As String,
                                                         ByVal elFiltroSeleccionadoNombre As String,
                                                         ByVal elFiltroSeleccionadoFechas As String,
                                                         ByVal elCodigoArticulo As Integer,
                                                         ByVal elNombreDelArticulo As String,
                                                         ByVal laFechaInicial As String,
                                                         ByVal laFechaFinal As String) As DataTable
        Dim cnn As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        DefineStrConexion()

        cnn.ConnectionString = DBSistemaCnnStr
        cnn.Open()

        Cmd.Connection = cnn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "SP_CargueLaConsultaDeFacturasPorFiltros"
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@elFiltroSeleccionadoNombre", elFiltroSeleccionadoNombre)
        Cmd.Parameters.AddWithValue("@elFiltroSeleccionadoCodigo", elFiltroSeleccionadoCodigo)
        Cmd.Parameters.AddWithValue("@elFiltroSeleccionadoFechas", elFiltroSeleccionadoFechas)
        Cmd.Parameters.AddWithValue("@elCodigoArticulo", elCodigoArticulo)
        Cmd.Parameters.AddWithValue("@elNombreDelArticulo", elNombreDelArticulo)
        Cmd.Parameters.AddWithValue("@laFechaInicial", CDate(laFechaInicial))
        Cmd.Parameters.AddWithValue("@laFechaFinal", CDate(laFechaFinal))
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).Rows.Count > 0 Then
            Return Ds.Tables(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function CargueElDetalleDeLaFacturaSeleccionada(ByVal codigo As Integer) As List(Of BEFacturaLinea)
        Dim cnn As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim FacturaLinea As BEFacturaLinea
        Dim Linea As New List(Of BEFacturaLinea)
        Dim Contador As Integer
        DefineStrConexion()

        cnn.ConnectionString = DBSistemaCnnStr
        cnn.Open()

        Cmd.Connection = cnn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "SP_CargueElDetalleDeFactura"
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@codigoFactura", codigo)
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).DefaultView.Count > 0 Then
            With Ds.Tables(0)
                While Contador <= .Rows.Count - 1
                    FacturaLinea = New BEFacturaLinea
                    FacturaLinea.CodigoDetalle = CInt(.Rows(Contador)("codigoDetalle"))
                    FacturaLinea.CodigoArticulo = CInt(.Rows(Contador)("codigoArticulo"))
                    FacturaLinea.Cantidad = CDbl(.Rows(Contador)("cantidad"))
                    FacturaLinea.PrecioTotalLinea = CDbl(.Rows(Contador)("precioUnitario"))
                    FacturaLinea.PrecioUnitario = CStr(.Rows(Contador)("total"))
                    FacturaLinea.NombreArticulo = CStr(.Rows(Contador)("nombreArticulo"))
                    Linea.Add(FacturaLinea)
                    Contador += 1
                End While
            End With

            Return Linea
        Else
            Return Nothing
        End If
    End Function

    Public Function Cargar_Facturas_Por_Proveedor(ByVal numeroFactura As String, ByVal codigoProveedor As Int32) As DataTable
        Dim cnn As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        DefineStrConexion()

        cnn.ConnectionString = DBSistemaCnnStr
        cnn.Open()

        Cmd.Connection = cnn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "SP_Cargar_Facturas_Por_Proveedor"
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@numeroFactura", numeroFactura)
        Cmd.Parameters.AddWithValue("@codigoProveedor", codigoProveedor)
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).Rows.Count > 0 Then
            Return Ds.Tables(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function CargueElArticuloPorCodigo(ByVal codigoArticulo As Integer) As Articulo
        Dim cnn As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim elArticulo As New Articulo
        DefineStrConexion()

        cnn.ConnectionString = DBSistemaCnnStr
        cnn.Open()

        Cmd.Connection = cnn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "SP_CargueElArticuloPorCodigo"
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@codigoArticulo", codigoArticulo)
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).DefaultView.Count > 0 Then
            With Ds.Tables(0)
                elArticulo.codigo = CInt(.DefaultView(0)("codigo"))
                elArticulo.cantidad = CInt(.DefaultView(0)("cantidad"))
                'elArticulo.costo = CDec(.DefaultView(0)("costo"))
                elArticulo.nombre = CStr(.DefaultView(0)("nombre"))
                elArticulo.precio = CDec(.DefaultView(0)("precio"))
                elArticulo.tipo = CInt(.DefaultView(0)("tipo"))
            End With

            Return elArticulo
        Else
            Return Nothing
        End If
    End Function
    Public Function CargueLaCantidadDelArticulo(ByVal codigoArticulo As Integer) As Integer
        Dim cnn As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        DefineStrConexion()

        cnn.ConnectionString = DBSistemaCnnStr
        cnn.Open()

        Cmd.Connection = cnn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "SP_CargueLaCantidadDelArticulo"
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@codigoArticulo", codigoArticulo)
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).DefaultView.Count > 0 Then
            Return Ds.Tables(0).DefaultView(0)("cantidad")
        Else
            Return 0
        End If
    End Function

    Public Function CargueLaConsultaDeArticulosPorFiltros(ByVal elFiltroSeleccionadoNombre As String, ByVal elFiltroSeleccionadoCodigo As String,
                                                            ByVal elCodigoArticulo As Integer, ByVal elNombreDelArticulo As String) As DataTable
        Dim cnn As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        DefineStrConexion()

        cnn.ConnectionString = DBSistemaCnnStr
        cnn.Open()

        Cmd.Connection = cnn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "SP_CargueLaConsultaDeArticulosPorFiltros"
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@elFiltroSeleccionadoNombre", elFiltroSeleccionadoNombre)
        Cmd.Parameters.AddWithValue("@elFiltroSeleccionadoCodigo", elFiltroSeleccionadoCodigo)
        Cmd.Parameters.AddWithValue("@elCodigoArticulo", elCodigoArticulo)
        Cmd.Parameters.AddWithValue("@elNombreDelArticulo", elNombreDelArticulo)
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).Rows.Count > 0 Then
            Return Ds.Tables(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function ElimineLaFacturaSeleccionada(ByVal elCodigoFacturaSeleccionada As Integer) As Boolean
        DefineStrConexion()

        Dim cnn As SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim transaccion As SqlTransaction
        Dim codigoCancelacion As Integer

        cnn = New SqlConnection(DBSistemaCnnStr)
        cnn.Open()
        transaccion = cnn.BeginTransaction("ElimineLaFactura")

        Try
            Cmd.Connection = cnn
            Cmd.Transaction = transaccion
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "SP_ActualiceElEstadoDeFacturaCancelada"
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@CodigoFactura", elCodigoFacturaSeleccionada)
            Cmd.Parameters.AddWithValue("@Estado", "E")
            Cmd.ExecuteNonQuery()

            transaccion.Commit()
            cnn.Close()
            MsgBox("La factura: " + CStr(elCodigoFacturaSeleccionada) + " fue eliminada correctamente", MsgBoxStyle.Information, "Cancelaciones")
            Return True
        Catch ex As SqlException
            transaccion.Rollback()
            cnn.Close()
            MsgBox("No se ha podido procesar la factura. Intente de nuevo.", MsgBoxStyle.Critical, "Cancelaciones")
            Return False
        Catch ex As Exception
            transaccion.Rollback()
            cnn.Close()
            MsgBox("No se ha podido procesar la factura. Intente de nuevo.", MsgBoxStyle.Critical, "Cancelaciones")
            Return False
        End Try
    End Function

End Class
