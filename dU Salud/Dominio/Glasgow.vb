Friend Class Glasgow
    Inherits Formulario

    Private reaccionOcular As Integer
    Private reaccionMotora As Integer
    Private reaccionVisual As Integer

    Public Sub New(ro As Integer, rm As Integer, rv As Integer)
        Me.reaccionOcular = ro
        Me.reaccionMotora = rm
        Me.reaccionVisual = rv
    End Sub

    Public Property ReaccionOcular1 As Integer
        Get
            Return reaccionOcular
        End Get
        Set(value As Integer)
            reaccionOcular = value
        End Set
    End Property

    Public Property ReaccionMotora1 As Integer
        Get
            Return reaccionMotora
        End Get
        Set(value As Integer)
            reaccionMotora = value
        End Set
    End Property

    Public Property ReaccionVisual1 As Integer
        Get
            Return reaccionVisual
        End Get
        Set(value As Integer)
            reaccionVisual = value
        End Set
    End Property
End Class
