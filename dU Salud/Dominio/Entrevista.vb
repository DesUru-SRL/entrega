Public Class Entrevista

    'Variables
    Private fecha As Date
    Private colabora As Boolean
    Private actitud As String
    Private estadoNutricional As String
    Private temperatura As Double
    Private pulso As String
    Private frecuenciaCardiaca As Integer
    Private frecuenciaRespiratoria As Integer
    Private motivo As String
    Private estadoGeneral As String
    Private sintomas As List(Of String)
    Private paciente As String
    Private empleado As String

    Private cx As New Conexion

    Private diagnostico As Diagnostico
    Private plan As Plan
    'Private formularios As List(Of Formulario) = New List(Of Formulario)
    Private eva As EVA
    Private glasgow As Glasgow
    Private fiebre As Fiebre
    Private fisico As Fisico

    'Constructor
    Public Sub New()
    End Sub

    Public Sub New(fecha As Date, colabora As Boolean, actitud As String, estadoNutricional As String, temperatura As Double, pulso As String, frecuenciaCardiaca As Integer, frecuenciaRespiratoria As Integer, motivo As String, estadoGeneral As String, sintomas As List(Of String), paciente As String, empleado As String)
        Me.fecha = fecha
        Me.colabora = colabora
        Me.actitud = actitud
        Me.estadoNutricional = estadoNutricional
        Me.temperatura = temperatura
        Me.pulso = pulso
        Me.frecuenciaCardiaca = frecuenciaCardiaca
        Me.frecuenciaRespiratoria = frecuenciaRespiratoria
        Me.motivo = motivo
        Me.estadoGeneral = estadoGeneral
        Me.sintomas = sintomas
        Me.paciente = paciente
        Me.empleado = empleado
    End Sub

    Public Sub SetNew(fecha As Date, colabora As Boolean, actitud As String, estadoNutricional As String, temperatura As Double, pulso As String, frecuenciaCardiaca As Integer, frecuenciaRespiratoria As Integer, motivo As String, estadoGeneral As String, sintomas As List(Of String), paciente As String, empleado As String)
        Me.fecha = fecha
        Me.colabora = colabora
        Me.actitud = actitud
        Me.estadoNutricional = estadoNutricional
        Me.temperatura = temperatura
        Me.pulso = pulso
        Me.frecuenciaCardiaca = frecuenciaCardiaca
        Me.frecuenciaRespiratoria = frecuenciaRespiratoria
        Me.motivo = motivo
        Me.estadoGeneral = estadoGeneral
        Me.sintomas = sintomas
        Me.paciente = paciente
        Me.empleado = empleado
    End Sub

    'Friend Sub Crear(fecha As Date, colabora As Boolean, actitud As String, estadoNutricional As String, temperatura As Double, pulso As String, frecuenciaCardiaca As Integer, frecuenciaRespiratoria As Integer, motivo As String, estadoGeneral As String, sintomas As List(Of String), paciente As String, empleado As String)
    '    Me.fecha = fecha
    '    Me.colabora = colabora
    '    Me.actitud = actitud
    '    Me.estadoNutricional = estadoNutricional
    '    Me.temperatura = temperatura
    '    Me.pulso = pulso
    '    Me.frecuenciaCardiaca = frecuenciaCardiaca
    '    Me.frecuenciaRespiratoria = frecuenciaRespiratoria
    '    Me.motivo = motivo
    '    Me.estadoGeneral = estadoGeneral
    '    Me.sintomas = sintomas
    '    Me.paciente = paciente
    '    Me.empleado = empleado
    'End Sub

    'Encapsulamiento
    Public Property Diagnostico1 As Diagnostico
        Get
            cx.obtenerDiagnostico(Me)
            Return diagnostico
        End Get
        Set(value As Diagnostico)
            diagnostico = value
        End Set
    End Property

    Public Property Plan1 As Plan
        Get
            Return plan
        End Get
        Set(value As Plan)
            plan = value
        End Set
    End Property

    Public Property Fecha1 As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property

    Public Property Colabora1 As Boolean
        Get
            Return colabora
        End Get
        Set(value As Boolean)
            colabora = value
        End Set
    End Property

    Public Property Actitud1 As String
        Get
            Return actitud
        End Get
        Set(value As String)
            actitud = value
        End Set
    End Property

    Public Property EstadoNutricional1 As String
        Get
            Return estadoNutricional
        End Get
        Set(value As String)
            estadoNutricional = value
        End Set
    End Property

    Public Property Temperatura1 As Double
        Get
            Return temperatura
        End Get
        Set(value As Double)
            temperatura = value
        End Set
    End Property

    Public Property Pulso1 As String
        Get
            Return pulso
        End Get
        Set(value As String)
            pulso = value
        End Set
    End Property

    Public Property FrecuenciaCardiaca1 As Integer
        Get
            Return frecuenciaCardiaca
        End Get
        Set(value As Integer)
            frecuenciaCardiaca = value
        End Set
    End Property

    Public Property FrecuenciaRespiratoria1 As Integer
        Get
            Return frecuenciaRespiratoria
        End Get
        Set(value As Integer)
            frecuenciaRespiratoria = value
        End Set
    End Property

    Public Property Motivo1 As String
        Get
            Return motivo
        End Get
        Set(value As String)
            motivo = value
        End Set
    End Property

    Public Property EstadoGeneral1 As String
        Get
            Return estadoGeneral
        End Get
        Set(value As String)
            estadoGeneral = value
        End Set
    End Property

    Public Property Sintomas1 As List(Of String)
        Get
            Return sintomas
        End Get
        Set(value As List(Of String))
            sintomas = value
        End Set
    End Property

    Public Property Paciente1 As String
        Get
            Return paciente
        End Get
        Set(value As String)
            paciente = value
        End Set
    End Property

    Public Property Empleado1 As String
        Get
            Return empleado
        End Get
        Set(value As String)
            empleado = value
        End Set
    End Property

    Friend Property Eva1 As EVA
        Get
            Return eva
        End Get
        Set(value As EVA)
            eva = value
        End Set
    End Property

    Friend Property Glasgow1 As Glasgow
        Get
            Return glasgow
        End Get
        Set(value As Glasgow)
            glasgow = value
        End Set
    End Property

    Friend Property Fiebre1 As Fiebre
        Get
            Return fiebre
        End Get
        Set(value As Fiebre)
            fiebre = value
        End Set
    End Property

    Friend Property Fisico1 As Fisico
        Get
            Return fisico
        End Get
        Set(value As Fisico)
            fisico = value
        End Set
    End Property

    'Procedimientos y funciones
    Public Sub AnadirGlasgow(ro As Integer, rm As Integer, rv As Integer)
        glasgow = New Glasgow(ro, rm, rv)
    End Sub

    Public Sub AnadirEVA(valor As Integer)
        eva = New EVA(valor)
    End Sub

    Public Sub AnadirFiebre(desc As String)
        fiebre = New Fiebre(desc)
    End Sub

    Public Sub AnadirFisico(p As String, c As String, l As String, m As String)
        fisico = New Fisico(p, c, l, m)
    End Sub

End Class
