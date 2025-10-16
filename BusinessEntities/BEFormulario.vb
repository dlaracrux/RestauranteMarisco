Public Class BEFormulario
    Private atIdFormulario As Integer
    Private atNombreFormulario As String

    Public Property IdFormulario() As Integer
        Get
            Return atIdFormulario
        End Get
        Set(ByVal value As Integer)
            atIdFormulario = value
        End Set
    End Property
    Public Property NombreFormulario() As String
        Get
            Return atNombreFormulario
        End Get
        Set(ByVal value As String)
            atNombreFormulario = value
        End Set
    End Property
End Class
