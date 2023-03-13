Friend Class EVA
    Inherits Formulario

    Private valor As Integer

    Public Sub New(valor As Integer)
        Me.valor = valor
    End Sub

    Public Property Valor1 As Integer
        Get
            Return valor
        End Get
        Set(value As Integer)
            valor = value
        End Set
    End Property

End Class
