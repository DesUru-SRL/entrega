Public Class ControlPlan
    Private detalles As String

    Public Sub New(d As String)
        Me.detalles = d
    End Sub

    Public Property Detalles1 As String
        Get
            Return detalles
        End Get
        Set(value As String)
            detalles = value
        End Set
    End Property

End Class
