Public Class Usuario
    Private ci As String
    Private nombre As String
    Private apellido As String
    Private contra As String
    Private telefono As String
    Private direccion As String
    Private fecha_nacimiento As String

    'Constructor
    Sub New(c As String, n As String, a As String, co As String, te As String, d As String, f As String)
        ci = c
        nombre = n
        apellido = a
        contra = co
        telefono = te
        direccion = d
        fecha_nacimiento = f
    End Sub

    'Encapsulamiento
    Public Property Ci1 As String
        Get
            Return ci
        End Get
        Set(value As String)
            ci = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Apellido1 As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property Contra1 As String
        Get
            Return contra
        End Get
        Set(value As String)
            contra = value
        End Set
    End Property

    Public Property Telefono1 As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property Direccion1 As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property Fecha_nacimiento1 As String
        Get
            Return fecha_nacimiento
        End Get
        Set(value As String)
            fecha_nacimiento = value
        End Set
    End Property

    'Procedimientos y funciones
    Friend Sub Modificar(n As String, a As String, co As String, te As String)
        nombre = n
        apellido = a
        contra = co
        telefono = te
    End Sub

    Public Function VerifyLogin(c As String, co As String) As Boolean
        Return ci = c And contra = co
    End Function

End Class
