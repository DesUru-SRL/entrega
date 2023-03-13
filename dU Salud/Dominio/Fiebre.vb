Friend Class Fiebre
    Inherits Formulario

    Private descripcion As String

    Public Sub New(desc As String)
        Me.descripcion = desc
    End Sub

    Public Property Descripcion1 As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

End Class
