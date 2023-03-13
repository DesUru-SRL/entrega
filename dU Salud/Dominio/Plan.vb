Public Class Plan

    'Variables
    Private detalles As String
    Private control As List(Of ControlPlan) = New List(Of ControlPlan)

    'Constructor
    Public Sub New(detalles As String)
        Me.detalles = detalles
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

    Friend Property Control1 As List(Of ControlPlan)
        Get
            Return control
        End Get
        Set(value As List(Of ControlPlan))
            control = value
        End Set
    End Property

    'Procedimientos y funciones
    Public Sub AnadirControl(d As String)
        control.Add(New ControlPlan(d))
    End Sub


End Class
