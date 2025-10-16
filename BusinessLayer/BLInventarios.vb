Imports BusinessEntities
Imports DataLayer

Public Class BLInventarios

    Public Function ObtengaLosArticulosDesdeBaseDeDatos() As DataTable
        Dim dlBanco As New DLInventarios
        Return dlBanco.ObtengaLosArticulosDesdeBaseDeDatos()
    End Function

    Public Sub GuardeElArticuloNuevo(ByVal elArticulo As Articulo)

        Dim dlInventario As New DLInventarios

        dlInventario.GuardeElArticuloNuevo(elArticulo)
    End Sub

    Public Sub ModifiqueElArticulo(ByVal elArticulo As Articulo)

        Dim dlInventario As New DLInventarios

        dlInventario.ModifiqueElArticulo(elArticulo)
    End Sub

    Public Function EliminaElArticuloSeleccionado(ByVal elCodigoDeArticulo As Integer) As Boolean
        Dim dlInventario As New DLInventarios
        Return dlInventario.EliminaElArticuloSeleccionado(elCodigoDeArticulo)
    End Function
End Class
