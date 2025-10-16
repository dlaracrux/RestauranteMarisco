Imports System.Data.SqlClient
Imports BusinessEntities

Public Class DLCajas
    Inherits DLConexion

    Public Function VerificaSiLaCajaEstaAbierta(ByVal IdMaquina As String) As BECajas
        Dim cnn As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim laCajaConsultada As New BECajas
        DefineStrConexion()

        cnn.ConnectionString = DBSistemaCnnStr
        cnn.Open()

        Cmd.Connection = cnn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "SP_VerifiqueCajaAbierta"
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@idMaquina", IdMaquina)
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).DefaultView.Count > 0 Then
            With Ds.Tables(0)
                laCajaConsultada = New BECajas
                laCajaConsultada.IdCaja = CInt(.DefaultView(0)("IdCaja"))
                laCajaConsultada.FechaApertura = CDate(.DefaultView(0)("FechaApertura"))
                laCajaConsultada.Estado = CStr(.DefaultView(0)("Estado"))
                laCajaConsultada.IdUsuario = CInt(.DefaultView(0)("IdUsuario"))
                laCajaConsultada.IdMaquina = CStr(.DefaultView(0)("IdMaquina"))
                laCajaConsultada.MontoInicial = CDec(.DefaultView(0)("MontoInicial"))
                laCajaConsultada.MontoCierre = CDec(.DefaultView(0)("MontoCierre"))
                laCajaConsultada.FechaCierre = CDate(.DefaultView(0)("FechaCierre"))
            End With
            Return laCajaConsultada
        Else
            Return Nothing
        End If
    End Function

    Public Function ProceseLaFacturaSeleccionada(ByVal elCodigoFacturaSeleccionada As Integer, ByVal laCaja As String,
                                                 ByVal laFormaDePago As String, ByVal idUsuario As Integer) As Boolean
        DefineStrConexion()

        Dim cnn As SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim transaccion As SqlTransaction
        Dim codigoCancelacion As Integer

        cnn = New SqlConnection(DBSistemaCnnStr)
        cnn.Open()
        transaccion = cnn.BeginTransaction("ProceseLaFactura")

        Try
            Cmd.Connection = cnn
            Cmd.Transaction = transaccion
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "SP_ProceseLaFactura"
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@CodigoFactura", elCodigoFacturaSeleccionada)
            Cmd.Parameters.AddWithValue("@Caja", laCaja)
            Cmd.Parameters.AddWithValue("@FormaPago", laFormaDePago)
            Cmd.Parameters.AddWithValue("@Usuario", idUsuario)
            Cmd.Parameters.AddWithValue("@FechaCancelacion", Now)
            Cmd.ExecuteNonQuery()

            Cmd.Connection = cnn
            Cmd.Transaction = transaccion
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "SP_ActualiceElEstadoDeFacturaCancelada"
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@CodigoFactura", elCodigoFacturaSeleccionada)
            Cmd.ExecuteNonQuery()

            transaccion.Commit()
            cnn.Close()
            MsgBox("La factura: " + CStr(elCodigoFacturaSeleccionada) + " fue procesada correctamente", MsgBoxStyle.Information, "Cancelaciones")
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

    Public Function EliminaLaFacturaSeleccionada(ByVal elCodigoFactura As Integer) As Boolean
        DefineStrConexion()

        Dim cnn As SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim transaccion As SqlTransaction

        cnn = New SqlConnection(DBSistemaCnnStr)
        cnn.Open()
        transaccion = cnn.BeginTransaction("ElimineLaFactura")

        Try
            Cmd.Connection = cnn
            Cmd.Transaction = transaccion
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "SP_ElimineLaFactura"
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@codigo", elCodigoFactura)
            Da.SelectCommand = Cmd
            Da.Fill(Ds)

            transaccion.Commit()
            cnn.Close()
            MsgBox("La factura con código: " & elCodigoFactura & " fue eliminado correctamente", MsgBoxStyle.Information, "Cancelaciones")
            Return True
        Catch ex As SqlException
            transaccion.Rollback()
            cnn.Close()
            MsgBox("Error al eliminar la factura con código: " & elCodigoFactura & ".Intente de nuevo.", MsgBoxStyle.Critical, "Cancelaciones")
            Return False
        Catch ex As Exception
            transaccion.Rollback()
            cnn.Close()
            MsgBox("Error al eliminar la factura con código: " & elCodigoFactura & ".Intente de nuevo.", MsgBoxStyle.Critical, "Cancelaciones")
            Return False
        End Try
    End Function

    Public Function CierreLaCaja(laCaja As String, elMontoTotalFacturas As Decimal) As Boolean
        DefineStrConexion()

        Dim cnn As SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim transaccion As SqlTransaction

        cnn = New SqlConnection(DBSistemaCnnStr)
        cnn.Open()
        transaccion = cnn.BeginTransaction("CierraCaja")

        Try
            Cmd.Connection = cnn
            Cmd.Transaction = transaccion
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "SP_CierreLaCaja"
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@Caja", laCaja)
            Cmd.Parameters.AddWithValue("@MontoCierre", elMontoTotalFacturas)
            Cmd.Parameters.AddWithValue("@FechaCierre", Now)
            Da.SelectCommand = Cmd
            Da.Fill(Ds)

            transaccion.Commit()
            cnn.Close()
            MsgBox("La caja: " + laCaja + " fue cerrada correctamente", MsgBoxStyle.Information, "Cierre de Cajas")
            Return True
        Catch ex As SqlException
            transaccion.Rollback()
            cnn.Close()
            MsgBox("No se ha podido realizar el cierre de caja. Intente de nuevo.", MsgBoxStyle.Critical, "Cierre de Cajas")
            Return False
        Catch ex As Exception
            transaccion.Rollback()
            cnn.Close()
            MsgBox("No se ha podido realizar el cierre de caja. Intente de nuevo.", MsgBoxStyle.Critical, "Cierre de Cajas")
            Return False
        End Try
    End Function

    Public Function ConsulteElMontoTotalDeFacturasProcesadasEnElDia(ByVal laCaja As String) As Decimal
        Dim cnn As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        DefineStrConexion()

        cnn.ConnectionString = DBSistemaCnnStr
        cnn.Open()

        Cmd.Connection = cnn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "SP_CargaMontoTotalFacturasProcesadas"
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@Caja", laCaja)
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).Rows.Count > 0 Then
            Return CDbl(Ds.Tables(0).Rows(0)("totalFacturaCancelada"))
        Else
            Return 0
        End If
    End Function

    Public Function InserteLaApertuaDeCaja(idUsuario As Integer, elMontoInicial As Double, laCaja As String) As Integer
        DefineStrConexion()

        Dim cnn As SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim transaccion As SqlTransaction
        Dim codigoCaja As Integer

        cnn = New SqlConnection(DBSistemaCnnStr)
        cnn.Open()
        transaccion = cnn.BeginTransaction("RegistroCajas")

        Try
            Cmd.Connection = cnn
            Cmd.Transaction = transaccion
            Cmd.CommandTimeout = 60
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "SP_InserteLaApertuaDeCaja"
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@Caja", laCaja)
            Cmd.Parameters.AddWithValue("@MontoInicial", elMontoInicial)
            Cmd.Parameters.AddWithValue("@Usuario", idUsuario)
            Cmd.Parameters.AddWithValue("@FechaApertura", Now)
            Da.SelectCommand = Cmd
            Da.Fill(Ds)
            codigoCaja = CInt(Ds.Tables(0).Rows(0)("codigoCaja"))

            transaccion.Commit()
            cnn.Close()
            MsgBox("La caja fue registrada correctamente", MsgBoxStyle.Information, "Cajas")
            Return codigoCaja
        Catch ex As SqlException
            transaccion.Rollback()
            cnn.Close()
            MsgBox("No se ha podido registrar la caja Intente de nuevo.", MsgBoxStyle.Critical, "Cajas")
            Return Nothing
        Catch ex As Exception
            transaccion.Rollback()
            cnn.Close()
            MsgBox("No se ha podido registrar la caja. Intente de nuevo.", MsgBoxStyle.Critical, "Cajas")
            Return Nothing
        End Try
    End Function

    Public Function CargueLaFacturasPendientesDeCobro() As DataTable
        Dim cnn As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        DefineStrConexion()

        cnn.ConnectionString = DBSistemaCnnStr
        cnn.Open()

        Cmd.Connection = cnn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "SP_CargueLaFacturasPendientesDeCobro"
        Cmd.Parameters.Clear()
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).Rows.Count > 0 Then
            Return Ds.Tables(0)
        Else
            Return Nothing
        End If
    End Function


    Public Sub Modificar_Monedas(monedaSelecionado As BECajas)
        DefineStrConexion()

        Dim cnn As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim transaccion As SqlTransaction

        cnn = New SqlConnection(DBSistemaCnnStr)
        cnn.Open()
        transaccion = cnn.BeginTransaction("ModificarMoneda")

        Try
            Cmd.Connection = cnn
            Cmd.Transaction = transaccion
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "SP_Modificar_Moneda"
            Cmd.Parameters.Clear()
            ' Cmd.Parameters.AddWithValue("@ID", monedaSelecionado.MON_ID)
            'Cmd.Parameters.AddWithValue("@nombre", monedaSelecionado.MON_Nombre)
            'Cmd.Parameters.AddWithValue("@estado", monedaSelecionado.MON_Estado)
            Da.SelectCommand = Cmd
            Da.Fill(Ds)

            transaccion.Commit()
            cnn.Close()
            MsgBox("La moneda fué modificada correctamente", MsgBoxStyle.Information, "Mantenimiento de Monedas")

        Catch ex As SqlException
            transaccion.Rollback()
            cnn.Close()
            MsgBox("No se han podido modificar la moneda. Intente de nuevo.", MsgBoxStyle.Critical, "Mantenimiento de Monedas")
        Catch ex As Exception
            transaccion.Rollback()
            cnn.Close()
            MsgBox("No se han podido modificar la moneda. Intente de nuevo.", MsgBoxStyle.Critical, "Mantenimiento de Monedas")
        End Try
    End Sub

    Public Function Cargar_Monedas() As DataTable
        Dim cnn As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        DefineStrConexion()

        cnn.ConnectionString = DBSistemaCnnStr
        cnn.Open()

        Cmd.Connection = cnn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "SP_Cargar_Monedas"
        Cmd.Parameters.Clear()
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).Rows.Count > 0 Then
            Return Ds.Tables(0)
        Else
            Return Nothing
        End If
    End Function
End Class
