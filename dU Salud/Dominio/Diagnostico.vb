Public Class Diagnostico

    'Variables
    Private detalles As String
    Private tipo As String
    Private solicitudesAnalisis As List(Of SolicitudAnalisis) = New List(Of SolicitudAnalisis)

    'Constructor
    Public Sub New(t As String, d As String)
        Me.detalles = d
        Me.tipo = t
    End Sub

    'Encapsulamiento
    Public Property Detalles1 As String
        Get
            Return detalles
        End Get
        Set(value As String)
            detalles = value
        End Set
    End Property

    Public Property SolicitudesAnalisis1 As List(Of SolicitudAnalisis)
        Get
            Return solicitudesAnalisis
        End Get
        Set(value As List(Of SolicitudAnalisis))
            solicitudesAnalisis = value
        End Set
    End Property

    Public Property Tipo1 As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property

    'Procedimientos y funciones
    Public Sub AnadirAnalisis(t As String)
        solicitudesAnalisis.Add(New SolicitudAnalisis(t))
    End Sub

End Class
