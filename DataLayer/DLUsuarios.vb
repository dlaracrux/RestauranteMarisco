Imports System.Data.SqlClient
Imports BusinessEntities

Public Class DLUsuarios

    Inherits DLConexion
    Public Function ConsultaUsuarios() As DataTable
        DefineStrConexion()
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter

        Cmd.Connection = New SqlConnection(DBSistemaCnnStr)
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "Usu_ConsultaUsuarios"
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).Rows.Count > 0 Then
            Return Ds.Tables(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function ConsultaFormularios() As DataTable
        DefineStrConexion()
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter

        Cmd.Connection = New SqlConnection(DBSistemaCnnStr)
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "Usu_ConsultaFormularios"
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).Rows.Count > 0 Then
            Return Ds.Tables(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function ConsultaPermisosFormularios(ByVal idUsuario As Integer) As BEUsuario
        DefineStrConexion()
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim BEUsuario As New BEUsuario
        Dim BEFormulario As BEFormulario
        Dim Contador As Integer

        Cmd.Connection = New SqlConnection(DBSistemaCnnStr)
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "Usu_ConsultaPermisosFormularios"
        Cmd.Parameters.AddWithValue("@idUsuario", idUsuario)
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).DefaultView.Count > 0 Then
            With Ds.Tables(0)
                BEUsuario.IdUsuario = CInt(.DefaultView(0)("idUsuario"))
                BEUsuario.ListaFormularios = New List(Of BEFormulario)
                While Contador <= .Rows.Count - 1
                    BEFormulario = New BEFormulario
                    BEFormulario.IdFormulario = CInt(.Rows(Contador)("idFormulario"))
                    BEFormulario.NombreFormulario = CStr(.Rows(Contador)("nombreFormulario"))
                    BEUsuario.ListaFormularios.Add(BEFormulario)
                    Contador += 1
                End While
            End With

            Return BEUsuario
        Else
            Return Nothing
        End If
    End Function

    Public Function Mantenimiento_PermisosUsuarios(ByVal listaPermisos As List(Of BEPermisosFormularios)) As Boolean
        DefineStrConexion()
        Dim cmd As SqlCommand
        Dim transaccion As SqlTransaction
        Dim cnnBDSistema As New SqlConnection
        Dim cmdlistaPermisos As SqlCommand

        cnnBDSistema = New SqlConnection(DBSistemaCnnStr)
        cnnBDSistema.Open()
        transaccion = cnnBDSistema.BeginTransaction("PERMISOS")
        Try
            cmd = New SqlCommand
            cmd.Connection = cnnBDSistema
            cmd.CommandTimeout = 60
            cmd.Transaction = transaccion
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "USU_EliminaPermisosUsuarios"
            cmd.Parameters.AddWithValue("@idUsuario", listaPermisos(0).IdUsuario)
            cmd.ExecuteNonQuery()

            For Contador As Integer = 0 To listaPermisos.Count - 1
                cmdlistaPermisos = New SqlCommand
                cmdlistaPermisos.CommandTimeout = 60
                cmdlistaPermisos.Connection = cnnBDSistema
                cmdlistaPermisos.Transaction = transaccion
                cmdlistaPermisos.CommandType = CommandType.StoredProcedure
                cmdlistaPermisos.CommandText = "USU_InsertaPermisosUsuarios"
                cmdlistaPermisos.Parameters.Clear()
                cmdlistaPermisos.Parameters.AddWithValue("@idFormulario", listaPermisos(Contador).IdFormulario)
                cmdlistaPermisos.Parameters.AddWithValue("@idUsuario", listaPermisos(Contador).IdUsuario)
                cmdlistaPermisos.ExecuteNonQuery()
            Next
            transaccion.Commit()
            cnnBDSistema.Close()
            Return True

        Catch ex As SqlException
            transaccion.Rollback()
            cnnBDSistema.Close()
            Return Nothing

        Catch ex As Exception
            transaccion.Rollback()
            cnnBDSistema.Close()
            Return Nothing
        End Try
    End Function

    Public Function MantenimientoUsuarios(ByVal BEUsuario As BEUsuario) As Boolean
        DefineStrConexion()
        Dim cmd As SqlCommand
        Dim transaccion As SqlTransaction
        Dim cnnBDSistema As SqlConnection

        cnnBDSistema = New SqlConnection(DBSistemaCnnStr)
        cnnBDSistema.Open()
        transaccion = cnnBDSistema.BeginTransaction("USUARIOS")
        Try
            cmd = New SqlCommand
            cmd.Connection = cnnBDSistema
            cmd.CommandTimeout = 60
            cmd.Transaction = transaccion
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "USU_MantenimientoUsuarios"
            cmd.Parameters.AddWithValue("@Usuario", BEUsuario.NombreUsuario)
            cmd.Parameters.AddWithValue("@Contrasenia", BEUsuario.Contrasenia)
            cmd.Parameters.AddWithValue("@Nombre", BEUsuario.Nombre)
            cmd.Parameters.AddWithValue("@Apellidos", BEUsuario.Apellidos)
            cmd.Parameters.AddWithValue("@correo", BEUsuario.Correo)
            cmd.ExecuteNonQuery()
            transaccion.Commit()
            cnnBDSistema.Close()
            Return True

        Catch ex As SqlException
            transaccion.Rollback()
            cnnBDSistema.Close()
            Return Nothing

        Catch ex As Exception
            transaccion.Rollback()
            cnnBDSistema.Close()
            Return Nothing
        End Try
    End Function

    Public Function ValidaInicioSesion(ByVal usuario As String, ByVal contrasenia As String) As BEUsuario
        DefineStrConexion()
        Dim Cmd As New SqlCommand
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim BEUsuario As New BEUsuario

        Cmd.Connection = New SqlConnection(DBSistemaCnnStr)
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "Usu_ValidaUsuarios"
        Cmd.Parameters.AddWithValue("@usuario", usuario)
        Cmd.Parameters.AddWithValue("@contrasenia", contrasenia)
        Da.SelectCommand = Cmd
        Da.Fill(Ds)

        If Ds.Tables(0).DefaultView.Count > 0 Then
            With Ds.Tables(0)
                BEUsuario.IdUsuario = CInt(.DefaultView(0)("idUsuario"))
                BEUsuario.Nombre = CStr(.DefaultView(0)("nombre"))
                BEUsuario.Apellidos = CStr(.DefaultView(0)("apellidos"))
                BEUsuario.Correo = CStr(.DefaultView(0)("correoElectronico"))
                BEUsuario.Contrasenia = CStr(.DefaultView(0)("contrasenia"))
                BEUsuario.NombreUsuario = CStr(.DefaultView(0)("nombreUsuario"))
            End With

            Return BEUsuario
        Else
            Return Nothing
        End If
    End Function
End Class
