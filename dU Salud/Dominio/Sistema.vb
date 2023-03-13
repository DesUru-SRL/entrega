Public Class Sistema

    'Variables
    Private usuarios As List(Of Usuario) = New List(Of Usuario)
    Private medicos As List(Of String) = New List(Of String)
    Private auxiliares As List(Of String) = New List(Of String)
    Private pacientes As List(Of Paciente) = New List(Of Paciente)
    Private administradores As List(Of String) = New List(Of String)

    Private cx As New Conexion

    Private entrevistas As List(Of Entrevista) = New List(Of Entrevista)


    'Constructor
    Sub New()

    End Sub

    'Encapsulamiento
    Public Property Usuarios1 As List(Of Usuario)
        Get
            usuarios = cx.obtenerUsuarios
            Return usuarios
        End Get
        Set(value As List(Of Usuario))
            usuarios = value
        End Set
    End Property

    Public Property Medicos1 As List(Of String)
        Get
            medicos = cx.obtenerMedicos()
            Return medicos
        End Get
        Set(value As List(Of String))
            medicos = value
        End Set
    End Property

    Public Property Auxiliares1 As List(Of String)
        Get
            auxiliares = cx.obtenerAuxiliares()
            Return auxiliares
        End Get
        Set(value As List(Of String))
            auxiliares = value
        End Set
    End Property

    Public Property Administradores1 As List(Of String)
        Get
            administradores = cx.obtenerAdministradores()
            Return administradores
        End Get
        Set(value As List(Of String))
            administradores = value
        End Set
    End Property

    Friend Property Entrevistas1 As List(Of Entrevista)
        Get
            entrevistas = cx.obtenerEntrevistas()
            Return entrevistas
        End Get
        Set(value As List(Of Entrevista))
            entrevistas = value
        End Set
    End Property

    Friend Property Pacientes1 As List(Of Paciente)
        Get
            pacientes = cx.obtenerPacientes
            Return pacientes
        End Get
        Set(value As List(Of Paciente))
            pacientes = value
        End Set
    End Property

    'Procedimientos y funciones
    Public Sub AnadirUsuario(c As String, n As String, a As String, co As String, te As String, d As String, f As String, rol As String)
        Dim usu = New Usuario(c, n, a, co, te, d, f)
        Select Case rol
            Case "Med"
                If Not UsuarioExiste(c) Then
                    'usuarios.Add(New Usuario(c, n, a, co, te, d))
                    cx.registrarUsuario(usu)
                End If
                'medicos.Add(c)
                cx.registrarMedico(usu, "12344321")
            Case "Aux"
                If Not UsuarioExiste(c) Then
                    'usuarios.Add(New Usuario(c, n, a, co, te, d))
                    cx.registrarUsuario(usu)
                End If
                'auxiliares.Add(c)
                cx.registrarAuxiliar(usu, "12344321")
            Case "Pat"
                If Not UsuarioExiste(c) Then
                    'usuarios.Add(New Usuario(c, n, a, co, te, d))
                    cx.registrarUsuario(usu)
                End If
                'pacientes.Add(New Paciente(c))
                cx.registrarPaciente(usu)
            Case "Admin"
                If Not UsuarioExiste(c) Then
                    'usuarios.Add(New Usuario(c, n, a, co, te, d))
                    cx.registrarUsuario(usu)
                End If
                'administradores.Add(c)
                cx.registrarAdministrador(usu)
        End Select
    End Sub

    'Public Sub AnadirUsuario(usuario As Usuario, rol As String)
    '    Select Case rol
    '        Case "Med"
    '            If Not UsuarioExiste(usuario.Ci1) Then
    '                usuarios.Add(usuario)
    '            End If
    '            medicos.Add(usuario.Ci1)
    '        Case "Aux"
    '            If Not UsuarioExiste(usuario.Ci1) Then
    '                usuarios.Add(usuario)
    '            End If
    '            auxiliares.Add(usuario.Ci1)
    '        Case "Pat"
    '            If Not UsuarioExiste(usuario.Ci1) Then
    '                usuarios.Add(usuario)
    '            End If
    '            pacientes.Add(New Paciente(usuario.Ci1))
    '        Case "Admin"
    '            If Not UsuarioExiste(usuario.Ci1) Then
    '                usuarios.Add(usuario)
    '            End If
    '            administradores.Add(usuario.Ci1)
    '    End Select
    'End Sub

    'Public Sub AnadirEntrevista(fecha As Date, colabora As Boolean, actitud As String, estadoNutricional As String, temperatura As Double, pulso As String, frecuenciaCardiaca As Integer, frecuenciaRespiratoria As Integer, motivo As String, estadoGeneral As String, sintomas As List(Of String), paciente As String, empleado As String)
    '    entrevistas.Add(New Entrevista(fecha, colabora, actitud, estadoNutricional, temperatura, pulso, frecuenciaCardiaca, frecuenciaRespiratoria, motivo, estadoGeneral, sintomas, paciente, empleado))
    'End Sub

    Public Sub AnadirEntrevista(entrevista As Entrevista)
        cx.registrarEntrevista(entrevista)
    End Sub

    Public Function UsuarioExiste(c As String) As Boolean
        Dim value As Boolean = False
        usuarios = cx.obtenerUsuarios()
        For Each usuario In usuarios
            If usuario.Ci1 = c Then
                value = True
                Exit For
            End If
        Next
        Return value
    End Function

    Public Function MedicoExiste(c As String) As Boolean
        Dim value As Boolean = False
        medicos = cx.obtenerMedicos()
        For Each usuarioCi In medicos
            If usuarioCi = c Then
                value = True
                Exit For
            End If
        Next
        Return value
    End Function

    Public Function AuxiliarExiste(c As String) As Boolean
        Dim value As Boolean = False
        auxiliares = cx.obtenerAuxiliares
        For Each usuarioCi In auxiliares
            If usuarioCi = c Then
                value = True
                Exit For
            End If
        Next
        Return value
    End Function

    Public Function PacienteExiste(c As String) As Boolean
        Dim value As Boolean = False
        pacientes = cx.obtenerPacientes()
        For Each paciente In pacientes
            If paciente.Ci1 = c Then
                value = True
                Exit For
            End If
        Next
        Return value
    End Function

    Public Function AdministradorExiste(c As String) As Boolean
        Dim value As Boolean = False
        administradores = cx.obtenerAdministradores
        For Each usuarioCi In administradores
            If usuarioCi = c Then
                value = True
                Exit For
            End If
        Next
        Return value
    End Function

    Public Function GetUsuario(c As String) As Usuario
        usuarios = cx.obtenerUsuarios()
        For Each usuario In usuarios
            If usuario.Ci1 = c Then
                Return usuario
                Exit For
            End If
        Next
    End Function

    Public Function GetEstadoPaciente(c As String) As Integer
        pacientes = cx.obtenerPacientes
        For Each paciente As Paciente In pacientes
            If paciente.Ci1 = c Then
                Return paciente.Estado1
            End If
        Next
    End Function

    Public Function GetEntrevistaPaciente(paciente As String) As List(Of Entrevista)
        Dim listaEntrevistas As List(Of Entrevista) = New List(Of Entrevista)
        entrevistas = cx.obtenerEntrevistas
        For Each entrevista In entrevistas
            If entrevista.Paciente1 = paciente Then
                listaEntrevistas.Add(entrevista)
            End If
        Next
        Return listaEntrevistas
    End Function

    Public Function GetDiagnosticoPaciente(paciente As String) As List(Of Entrevista)
        Dim listaEntrevistas As List(Of Entrevista) = New List(Of Entrevista)
        entrevistas = cx.obtenerEntrevistas
        For Each entrevista In entrevistas
            entrevista.Diagnostico1 = cx.obtenerDiagnostico(entrevista)
            If entrevista.Paciente1 = paciente And entrevista.Diagnostico1 IsNot Nothing Then
                listaEntrevistas.Add(entrevista)
            End If
        Next
        Return listaEntrevistas
    End Function

    Public Function GetTratamientoPaciente(paciente As String) As List(Of Entrevista)
        Dim listaEntrevistas As List(Of Entrevista) = New List(Of Entrevista)
        entrevistas = cx.obtenerEntrevistas
        For Each entrevista In entrevistas
            entrevista.Plan1 = cx.obtenerPlan(entrevista)
            If entrevista.Paciente1 = paciente And entrevista.Plan1 IsNot Nothing Then
                entrevista.Plan1.Control1 = cx.obtenerControl(entrevista)
                listaEntrevistas.Add(entrevista)
            End If
        Next
        Return listaEntrevistas
    End Function

    Public Function GetAnalisisPaciente(paciente As String) As List(Of SolicitudAnalisis)
        Dim listaSolicitudAnalisis As List(Of SolicitudAnalisis) = New List(Of SolicitudAnalisis)
        entrevistas = cx.obtenerEntrevistas
        For Each entrevista In entrevistas
            entrevista.Diagnostico1 = cx.obtenerDiagnostico(entrevista)
            If entrevista.Paciente1 = paciente And entrevista.Diagnostico1 IsNot Nothing Then
                entrevista.Diagnostico1.SolicitudesAnalisis1 = cx.obtenerSolicitudesAnalisis(entrevista)
                For Each solicitudAnalisis In entrevista.Diagnostico1.SolicitudesAnalisis1
                    solicitudAnalisis.Analisis1 = cx.obtenerAnalisis(entrevista, solicitudAnalisis)
                    'If solicitudAnalisis.Analisis1 IsNot Nothing Then
                    '    listaSolicitudAnalisis.Add(solicitudAnalisis)
                    'End If
                    listaSolicitudAnalisis.Add(solicitudAnalisis)
                Next
            End If
        Next

        Return listaSolicitudAnalisis
    End Function

    Public Sub Diagnosticar(entrevista As Entrevista)
        cx.diagnosticar(entrevista)
    End Sub
    Public Sub AnadirTratamiento(entrevista As Entrevista)
        cx.anadirTratamiento(entrevista)
    End Sub

    Public Sub AnadirResultadoAnalisis(entrevista As Entrevista, solAnalisis As SolicitudAnalisis, index As Integer)
        cx.anadirResultadoAnalisis(entrevista, solAnalisis, index)
    End Sub



    Public Sub BajaPaciente(ciPaciente As String)
        'Dim i As Integer = 0
        'pacientes = cx.obtenerPacientes()
        'For Each paciente In pacientes
        '    If paciente.Ci1 = ciPaciente Then
        '        pacientes.RemoveAt(i)
        '        Exit For
        '    End If
        '    i += 1
        'Next
        cx.bajaPaciente(ciPaciente)
    End Sub

    Public Sub CambiarEstado(ci As String, estado As Integer)
        cx.cambiarEstado(ci, estado)
    End Sub

    Public Sub AnadirControl(entrevista As Entrevista)
        cx.AnadirControl(entrevista)
    End Sub

    Public Sub SolicitarAnalisis(entrevista As Entrevista)
        cx.solicitarAnalisis(entrevista)
    End Sub
End Class