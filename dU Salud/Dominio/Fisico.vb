Friend Class Fisico
    Inherits Formulario

    Private piel As String
    Private cuello As String
    Private linfogag As String
    Private mamas As String

    Public Sub New(p As String, c As String, l As String, m As String)
        Me.piel = p
        Me.cuello = c
        Me.linfogag = l
        Me.mamas = m
    End Sub

    Public Property Piel1 As String
        Get
            Return piel
        End Get
        Set(value As String)
            piel = value
        End Set
    End Property

    Public Property Cuello1 As String
        Get
            Return cuello
        End Get
        Set(value As String)
            cuello = value
        End Set
    End Property

    Public Property Linfogag1 As String
        Get
            Return linfogag
        End Get
        Set(value As String)
            linfogag = value
        End Set
    End Property

    Public Property Mamas1 As String
        Get
            Return mamas
        End Get
        Set(value As String)
            mamas = value
        End Set
    End Property

End Class
