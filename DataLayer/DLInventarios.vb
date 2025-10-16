Imports System.Data.SqlClient
Imports BusinessEntities

Public Class DLInventarios
    Inherits DLConexion
    Public Function ObtengaLosArticulosDesdeBaseDeDatos() As DataTable
        Dim cnn As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        DefineStrConexion()

        cnn.ConnectionString = DBSistemaCnnStr
        cnn.Open()

        Cmd.Connection = cnn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "SP_ObtengaLosArticulos"
        Cmd.Parameters.Clear()
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).Rows.Count > 0 Then
            Return Ds.Tables(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function Cargar_Bancos_Activos() As DataTable
        Dim cnn As New SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        DefineStrConexion()

        cnn.ConnectionString = DBSistemaCnnStr
        cnn.Open()

        Cmd.Connection = cnn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "SP_Cargar_Bancos_Activos"
        Cmd.Parameters.Clear()
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).Rows.Count > 0 Then
            Return Ds.Tables(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function EliminaElArticuloSeleccionado(ByVal elCodigoDeArticulo As Integer) As Boolean
        DefineStrConexion()

        Dim cnn As SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim transaccion As SqlTransaction

        cnn = New SqlConnection(DBSistemaCnnStr)
        cnn.Open()
        transaccion = cnn.BeginTransaction("EliminarArticulo")

        Try
            Cmd.Connection = cnn
            Cmd.Transaction = transaccion
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "SP_ElimineElArticulo"
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@codigo", elCodigoDeArticulo)
            Da.SelectCommand = Cmd
            Da.Fill(Ds)

            transaccion.Commit()
            cnn.Close()
            MsgBox("El articulo con código: " & elCodigoDeArticulo & " fue eliminado correctamente", MsgBoxStyle.Information, "Mantenimiento de Inventarios")
            Return True
        Catch ex As SqlException
            transaccion.Rollback()
            cnn.Close()
            MsgBox("Error al eliminar el articulo con código: " & elCodigoDeArticulo & ".Intente de nuevo.", MsgBoxStyle.Critical, "Mantenimiento de Inventarios")
            Return False
        Catch ex As Exception
            transaccion.Rollback()
            cnn.Close()
            MsgBox("Error al eliminar el articulo con código: " & elCodigoDeArticulo & ".Intente de nuevo.", MsgBoxStyle.Critical, "Mantenimiento de Inventarios")
            Return False
        End Try
    End Function

    Public Sub GuardeElArticuloNuevo(ByVal elArticulo As Articulo)
        DefineStrConexion()

        Dim cnn As SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim transaccion As SqlTransaction

        cnn = New SqlConnection(DBSistemaCnnStr)
        cnn.Open()
        transaccion = cnn.BeginTransaction("GuardeElArticulo")

        Try
            Cmd.Connection = cnn
            Cmd.Transaction = transaccion
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "SP_GuardeElArticulo"
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@nombre", elArticulo.nombre)
            Cmd.Parameters.AddWithValue("@tipo", elArticulo.tipo)
            'Cmd.Parameters.AddWithValue("@costo", elArticulo.costo)
            Cmd.Parameters.AddWithValue("@precio", elArticulo.precio)
            Cmd.Parameters.AddWithValue("@cantidad", elArticulo.cantidad)
            Da.SelectCommand = Cmd
            Da.Fill(Ds)

            transaccion.Commit()
            cnn.Close()
            MsgBox("El articulo: " & elArticulo.nombre & " fue guardado correctamente", MsgBoxStyle.Information, "Mantenimiento de Inventarios")

        Catch ex As SqlException
            transaccion.Rollback()
            cnn.Close()
            MsgBox("Error al guardar el articulo: " & elArticulo.nombre & ".Intente de nuevo.", MsgBoxStyle.Critical, "Mantenimiento de Inventarios")
        Catch ex As Exception
            transaccion.Rollback()
            cnn.Close()
            MsgBox("Error al guardar el articulo: " & elArticulo.nombre & ".Intente de nuevo.", MsgBoxStyle.Critical, "Mantenimiento de Inventarios")
        End Try

    End Sub

    Public Sub ModifiqueElArticulo(ByVal elArticulo As Articulo)
        DefineStrConexion()

        Dim cnn As SqlConnection
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim transaccion As SqlTransaction

        cnn = New SqlConnection(DBSistemaCnnStr)
        cnn.Open()
        transaccion = cnn.BeginTransaction("ModificarArticulo")

        Try
            Cmd.Connection = cnn
            Cmd.Transaction = transaccion
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "SP_ModifiqueElArticulo"
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@codigo", elArticulo.codigo)
            Cmd.Parameters.AddWithValue("@nombre", elArticulo.nombre)
            Cmd.Parameters.AddWithValue("@tipo", elArticulo.tipo)
            Cmd.Parameters.AddWithValue("@costo", elArticulo.costo)
            Cmd.Parameters.AddWithValue("@precio", elArticulo.precio)
            Cmd.Parameters.AddWithValue("@cantidad", elArticulo.cantidad)
            Da.SelectCommand = Cmd
            Da.Fill(Ds)

            transaccion.Commit()
            cnn.Close()
            MsgBox("El articulo: " & elArticulo.nombre & "fue modificado correctamente", MsgBoxStyle.Information, "Mantenimiento de Inventarios")

        Catch ex As SqlException
            transaccion.Rollback()
            cnn.Close()
            MsgBox("Error al modificar el articulo: " & elArticulo.nombre & ".Intente de nuevo.", MsgBoxStyle.Critical, "Mantenimiento de Inventarios")
        Catch ex As Exception
            transaccion.Rollback()
            cnn.Close()
            MsgBox("Error al modificar el articulo: " & elArticulo.nombre & ".Intente de nuevo.", MsgBoxStyle.Critical, "Mantenimiento de Inventarios")
        End Try
    End Sub
End Class
