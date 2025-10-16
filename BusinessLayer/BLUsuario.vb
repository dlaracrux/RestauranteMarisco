Imports BusinessEntities
Imports DataLayer

Public Class BLUsuario
    Public Function ConsultaUsuarios() As DataTable
        Dim DLUsuarios As New DLUsuarios
        Return DLUsuarios.ConsultaUsuarios()
    End Function
    Public Function ConsultaFormularios() As DataTable
        Dim DLUsuarios As New DLUsuarios
        Return DLUsuarios.ConsultaFormularios()
    End Function
    Public Function ConsultaPermisosFormularios(ByVal idUsuario As Integer) As BEUsuario
        Dim DLUsuarios As New DLUsuarios
        Return DLUsuarios.ConsultaPermisosFormularios(idUsuario)
    End Function
    Public Function Mantenimiento_PermisosUsuarios(ByVal listaPermisos As List(Of BEPermisosFormularios)) As Boolean
        Dim DLUsuarios As New DLUsuarios
        Return DLUsuarios.Mantenimiento_PermisosUsuarios(listaPermisos)
    End Function
    Public Function MantenimientoUsuarios(ByVal BEUsuario As BEUsuario) As Boolean
        Dim DLUsuario As New DLUsuarios
        Return DLUsuario.MantenimientoUsuarios(BEUsuario)
    End Function
    Public Function ValidaInicioSesion(ByVal usuario As String, ByVal contrasenia As String) As BEUsuario
        Dim DLUsuarios As New DLUsuarios
        Return DLUsuarios.ValidaInicioSesion(usuario, contrasenia)
    End Function
End Class
