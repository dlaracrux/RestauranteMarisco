Public Class BEPermisosFormularios
    Private atIdFormulario As Integer
    Private atIdUsuario As Integer

    Public Property IdUsuario() As Integer
        Get
            Return atIdUsuario
        End Get
        Set(ByVal value As Integer)
            atIdUsuario = value
        End Set
    End Property
    Public Property IdFormulario() As Integer
        Get
            Return atIdFormulario
        End Get
        Set(ByVal value As Integer)
            atIdFormulario = value
        End Set
    End Property
End Class
