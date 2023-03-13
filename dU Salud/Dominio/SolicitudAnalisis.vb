Public Class SolicitudAnalisis

    Private tipo As String
    Private analisis As Analisis

    Public Sub New(t As String)
        Me.tipo = t
    End Sub

    Public Property Tipo1 As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property

    Public Property Analisis1 As Analisis
        Get
            Return analisis
        End Get
        Set(value As Analisis)
            analisis = value
        End Set
    End Property
End Class
