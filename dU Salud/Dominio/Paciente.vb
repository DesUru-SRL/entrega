Public Class Paciente

    Private ci As String
    Private estado As Integer

    Public Sub New(c As String)
        ci = c
        estado = 0
    End Sub

    Public Sub New(c As String, e As Integer)
        Me.New(c)
        Me.estado = e
    End Sub

    Public Property Estado1 As Integer
        Get
            Return estado
        End Get
        Set(ByVal value As Integer)
            estado = value
        End Set
    End Property

    Public Property Ci1 As String
        Get
            Return ci
        End Get
        Set(value As String)
            ci = value
        End Set
    End Property
End Class
