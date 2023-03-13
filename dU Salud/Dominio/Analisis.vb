Public Class Analisis

    'Variables
    Private resultado As String

    'Constructor
    Public Sub New(resultado As String)
        Me.resultado = resultado
    End Sub

    'Encapsulamiento
    Public Property Resultado1 As String
        Get
            Return resultado
        End Get
        Set(value As String)
            resultado = value
        End Set
    End Property

End Class
