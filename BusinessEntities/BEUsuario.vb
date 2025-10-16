Public Class BEUsuario
    Dim atListaFormularios As List(Of BEFormulario)
    Dim atIdUsuario As Integer
    Dim atNombreUsuario As String
    Dim atContrasenia As String
    Dim atNombre As String
    Dim atApellidos As String
    Dim atCorreo As String
    Public Sub New(atIdUsuario As Integer, atNombreUsuario As String, atContrasenia As String, atApellidos As String, atCorreo As String)
        Me.atIdUsuario = atIdUsuario
        Me.atNombreUsuario = atNombreUsuario
        Me.atContrasenia = atContrasenia
        Me.atApellidos = atApellidos
        Me.atCorreo = atCorreo
    End Sub

    Public Sub New()

    End Sub
    Public Property NombreUsuario() As String
        Get
            Return atNombreUsuario
        End Get
        Set(ByVal value As String)
            atNombreUsuario = value
        End Set
    End Property
    Public Property Correo() As String
        Get
            Return atCorreo
        End Get
        Set(ByVal value As String)
            atCorreo = value
        End Set
    End Property
    Public Property Contrasenia() As String
        Get
            Return atContrasenia
        End Get
        Set(ByVal value As String)
            atContrasenia = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return atNombre
        End Get
        Set(ByVal value As String)
            atNombre = value
        End Set
    End Property
    Public Property Apellidos() As String
        Get
            Return atApellidos

        End Get
        Set(ByVal value As String)
            atApellidos = value
        End Set
    End Property
    Public Property IdUsuario() As Integer
        Get
            Return atIdUsuario
        End Get
        Set(ByVal value As Integer)
            atIdUsuario = value
        End Set
    End Property
    Public Property ListaFormularios() As List(Of BEFormulario)
        Get
            Return atListaFormularios
        End Get
        Set(ByVal value As List(Of BEFormulario))
            atListaFormularios = value
        End Set
    End Property
End Class
