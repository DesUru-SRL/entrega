Public Class Window

    'Variables globales
    Public user As String 'Usuario
    Dim pass As String 'Contraseña
    Dim login As String 'Puede ser Med, Aux, Admin o Pat
    Dim loginReady As Boolean 'Esto sirve para saber si ya se puso o no la cedula de identidad, y toca poner el codigo de seguridad
    Dim loginCorrect As Boolean 'Para saber si introdujo el usuario correctamente o no
    Dim patOption As String 'Puede ser administrar o entrevistar
    Dim regOption As String 'Puede ser Diagnostico, Analisis, Tratamiento, TratInfo'
    Dim adminOption As String 'Puede ser Med o Aux
    Dim abmOption As String 'Puede ser Alta, Mod o Baja
    Dim selectedTratamiento As Integer

    Public selectedUser As String 'El CI del usuario seleccionado

    Dim cx As Conexion = New Conexion

    'Sistema
    Public sistema As Sistema = New Sistema

    'Window Load
    Private Sub Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelLoginPersonal.Parent = labelLoginPersonalSquare
        loginPersonalError.Parent = labelLoginPersonalSquare
        labelLoginPaciente.Parent = labelLoginPacienteSquare
        loginPacienteError.Parent = labelLoginPacienteSquare
        labelAdministrarEntrevistarPaciente.Parent = labelAdministrarEntrevistarPacienteSquare
        entrevistarPacienteError.Parent = labelAdministrarEntrevistarPacienteSquare
        Timer.Enabled = True

        'Usuarios pre-registrados
        'sistema.AnadirUsuario(Usuarios.ezequiel, "Admin")
        'sistema.AnadirUsuario(Usuarios.matias, "Med")
        'sistema.AnadirUsuario(Usuarios.rodrigo, "Aux")
        'sistema.AnadirUsuario(Usuarios.jonas, "Pat")
    End Sub

    'Timer
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        dateTipoEmpleado.Text = Date.Now().ToString("dd/MM/yyyy hh:mm")
        dateLoginPersonal.Text = dateTipoEmpleado.Text
        dateMain.Text = dateTipoEmpleado.Text
        dateLoginPaciente.Text = dateTipoEmpleado.Text
        datePaciente.Text = dateTipoEmpleado.Text
        dateEmpleado.Text = dateTipoEmpleado.Text
        dateAdministrador.Text = dateTipoEmpleado.Text
        dateMedicoAdministrarPaciente.Text = dateTipoEmpleado.Text
        dateAuxiliarAdministrarPaciente.Text = dateTipoEmpleado.Text
        dateListaRegistros.Text = dateTipoEmpleado.Text
        dateRegistro.Text = dateTipoEmpleado.Text
        dateAdministrarEntrevistarPaciente.Text = dateTipoEmpleado.Text
        dateAbmPaciente.Text = dateTipoEmpleado.Text
        dateAbmEmpleado.Text = dateTipoEmpleado.Text
        dateListaMedicos.Text = dateTipoEmpleado.Text
        dateListaAuxiliares.Text = dateTipoEmpleado.Text
    End Sub

    'Cosas del panel main
    ''Esto sirve para ir al panel empleado
    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        tipoEmpleado.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub btnEmpleado_MouseEnter(sender As Object, e As EventArgs) Handles btnEmpleado.MouseEnter
        btnEmpleado.Cursor = Cursors.Hand
    End Sub
    ''
    ''Esto sirve para ir a la pantalla de iniciar sesion con un administrador
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        loginPersonal.BringToFront()
        loginReady = False
        login = "Admin"
        loginPersonalTitle.Text = "Bienvenido Sr/a Administrador/a!"
    End Sub
    ''MouseEnter
    Private Sub btnAdmin_MouseEnter(sender As Object, e As EventArgs) Handles btnAdmin.MouseEnter
        btnAdmin.Cursor = Cursors.Hand
    End Sub
    ''Esto sirve para ir a la pantalla de iniciar sesion con un paciente
    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        loginPaciente.BringToFront()
        labelLoginPaciente.Text = "Ingrese su cédula de identidad"
        loginReady = False
        tboxLoginPaciente.MaxLength = 8
    End Sub
    ''MouseEnter
    Private Sub btnPaciente_MouseEnter(sender As Object, e As EventArgs) Handles btnPaciente.MouseEnter
        btnPaciente.Cursor = Cursors.Hand
    End Sub
    ''
    ''Esto sirve para deshabilitar el "modo administrador"
    Private Sub disableBack_Click(sender As Object, e As EventArgs) Handles disableBack.Click
        disableBack.Visible = False
        backTipoEmpleado.Visible = False
        backLoginPaciente.Visible = False
        backEmpleado.Visible = False
    End Sub



    'Cosas del panel loginPersonal, que sirve para iniciar sesion con auxiliar, medico o administrador
    ''Boton de volver (main, empleado)
    Private Sub backPanelPersonal_Click(sender As Object, e As EventArgs) Handles backPanelPersonal.Click
        labelLoginPersonal.Text = "Ingrese su cédula de identidad"
        tboxLoginPersonal.MaxLength = 8
        loginReady = False
        If login = "Med" Or login = "Aux" Then
            tipoEmpleado.BringToFront()
        ElseIf login = "Admin" Then
            main.BringToFront()
        End If

    End Sub
    ''
    Private Sub backPanelPersonal_MouseEnter(sender As Object, e As EventArgs) Handles backPanelPersonal.MouseEnter
        backPanelPersonal.Cursor = Cursors.Hand
    End Sub
    ''
    ''Boton de ingresar
    Private Sub btnLoginPersonal_Click(sender As Object, e As EventArgs) Handles btnLoginPersonal.Click
        If tboxLoginPersonal.Text = "" Then
            loginPersonalError.Text = "El campo no puede estar vacío"
        Else
            loginPersonalError.Text = ""
            If Not loginReady Then
                user = tboxLoginPersonal.Text
                tboxLoginPersonal.MaxLength = 4
                labelLoginPersonal.Text = "Ingrese su código de seguridad"
                user = tboxLoginPersonal.Text
                tboxLoginPersonal.Text = ""
                loginReady = True
            Else
                pass = tboxLoginPersonal.Text
                labelLoginPersonal.Text = "Ingrese su cédula de identidad"
                tboxLoginPersonal.MaxLength = 8
                pass = tboxLoginPersonal.Text
                tboxLoginPersonal.Text = ""
                loginReady = False
                loginCorrect = False
                If login = "Med" Then
                    If sistema.MedicoExiste(user) Then
                        If sistema.GetUsuario(user).Contra1 = pass Then
                            loginCorrect = True
                        End If
                    End If
                ElseIf login = "Aux" Then
                    If sistema.AuxiliarExiste(user) Then
                        If sistema.GetUsuario(user).Contra1 = pass Then
                            loginCorrect = True
                        End If
                    End If
                ElseIf login = "Admin" Then
                    If sistema.AdministradorExiste(user) Then
                        If sistema.GetUsuario(user).Contra1 = pass Then
                            loginCorrect = True
                        End If
                    End If
                End If
                If loginCorrect Then
                    If login = "Admin" Then
                        administrador.BringToFront()
                        tituloAdministrador.Text = $"{sistema.GetUsuario(user).Apellido1}, {sistema.GetUsuario(user).Nombre1}"
                    Else
                        empleado.BringToFront()
                        tituloEmpleado.Text = $"{sistema.GetUsuario(user).Apellido1}, {sistema.GetUsuario(user).Nombre1}"
                    End If

                Else
                    loginPersonalError.Text = "CI o Código de seguridad equivocados."
                End If
            End If
        End If
    End Sub



    'Cosas del panel empleado
    ''Esto sirve para ir a la pantalla de iniciar sesion con un auxiliar
    Private Sub btnAuxiliar_Click(sender As Object, e As EventArgs) Handles btnAuxiliar.Click
        loginPersonal.BringToFront()
        loginReady = False
        login = "Aux"
        loginPersonalTitle.Text = "Bienvenido Sr/a Auxiliar!"
    End Sub
    ''
    Private Sub btnAuxiliar_MouseEnter(sender As Object, e As EventArgs) Handles btnAuxiliar.MouseEnter
        btnAuxiliar.Cursor = Cursors.Hand
    End Sub
    ''
    ''Esto sirve para ir a la pantalla de iniciar sesion con un auxiliar
    Private Sub btnMedico_Click(sender As Object, e As EventArgs) Handles btnMedico.Click
        loginPersonal.BringToFront()
        loginReady = False
        login = "Med"
        loginPersonalTitle.Text = "Bienvenido Sr/a Médico/a!"
    End Sub
    ''
    Private Sub btnMedico_MouseEnter(sender As Object, e As EventArgs) Handles btnMedico.MouseEnter
        btnMedico.Cursor = Cursors.Hand
    End Sub
    ''
    ''Boton de volver (main)
    Private Sub backTipoEmpleado_Click(sender As Object, e As EventArgs) Handles backTipoEmpleado.Click
        main.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backTipoEmpleado_MouseEnter(sender As Object, e As EventArgs) Handles backTipoEmpleado.MouseEnter
        backTipoEmpleado.Cursor = Cursors.Hand
    End Sub




    'Cosas del panel loginPaciente
    ''Boton de volver (main)
    Private Sub backLoginPaciente_Click(sender As Object, e As EventArgs) Handles backLoginPaciente.Click
        main.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backLoginPaciente_MouseEnter(sender As Object, e As EventArgs) Handles backLoginPaciente.MouseEnter
        backLoginPaciente.Cursor = Cursors.Hand
    End Sub
    ''
    ''Boton de ingresar
    Private Sub btnLoginPaciente_Click(sender As Object, e As EventArgs) Handles btnLoginPaciente.Click
        If tboxLoginPaciente.Text = "" Then
            loginPacienteError.Text = "El campo no puede estar vacío"
        Else
            loginPacienteError.Text = ""
            If Not loginReady Then
                tboxLoginPaciente.MaxLength = 4
                labelLoginPaciente.Text = "Ingrese su código de seguridad"
                user = tboxLoginPaciente.Text
                tboxLoginPaciente.Text = ""
                loginReady = True
            Else
                tboxLoginPaciente.MaxLength = 8
                labelLoginPaciente.Text = "Ingrese su cédula de identidad"
                pass = tboxLoginPaciente.Text
                tboxLoginPaciente.Text = ""
                loginReady = False
                login = "Pat"

                loginCorrect = False
                If sistema.PacienteExiste(user) Then
                    If sistema.GetUsuario(user).Contra1 = pass Then
                        loginCorrect = True
                    End If
                End If

                If loginCorrect Then
                    paciente.BringToFront()
                    tituloPaciente.Text = $"{sistema.GetUsuario(user).Apellido1}, {sistema.GetUsuario(user).Nombre1}"
                Else
                    loginPacienteError.Text = "CI o Código de seguridad equivocados"
                End If
            End If
        End If
    End Sub
    ''
    ''Teclado numerico
    '''1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        tboxLoginPaciente.Text += "1"
    End Sub
    '''2
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        tboxLoginPaciente.Text += "2"
    End Sub
    '''3
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        tboxLoginPaciente.Text += "3"
    End Sub
    '''4
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        tboxLoginPaciente.Text += "4"
    End Sub
    '''5
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        tboxLoginPaciente.Text += "5"
    End Sub
    '''6
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        tboxLoginPaciente.Text += "6"
    End Sub
    '''7
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        tboxLoginPaciente.Text += "7"
    End Sub
    '''8
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        tboxLoginPaciente.Text += "8"
    End Sub
    '''9
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        tboxLoginPaciente.Text += "9"
    End Sub
    '''0
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        tboxLoginPaciente.Text += "0"
    End Sub
    '''Delete
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If tboxLoginPaciente.Text.Length > 0 Then
            tboxLoginPaciente.Text = tboxLoginPaciente.Text.Substring(0, tboxLoginPaciente.Text.Length - 1)
        End If
    End Sub
    ''
    ''Validaciones
    Private Sub tboxLoginPaciente_TextChanged(sender As Object, e As EventArgs) Handles tboxLoginPaciente.TextChanged
        Dim size As Integer
        If loginReady Then
            size = 4
        Else
            size = 8
        End If
        If tboxLoginPaciente.Text.Length > size Then
            tboxLoginPaciente.Text = tboxLoginPaciente.Text.Substring(0, tboxLoginPaciente.Text.Length - 1)
            tboxLoginPaciente_TextChanged(sender, e)
        End If
    End Sub




    'Cosas del panel paciente
    ''Boton de volver
    Private Sub backPaciente_Click(sender As Object, e As EventArgs) Handles backPaciente.Click
        loginPaciente.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backPaciente_MouseEnter(sender As Object, e As EventArgs) Handles backPaciente.MouseEnter
        backPaciente.Cursor = Cursors.Hand
    End Sub
    ''
    ''Esto sirve para ir a ver los diagnosticos del paciente logueado
    Private Sub btnPacienteDiagnostico_Click(sender As Object, e As EventArgs) Handles btnPacienteDiagnostico.Click
        listaRegistros.BringToFront()
        regOption = "Diagnostico"
        tituloListaRegistros.Text = "Mis diagnósticos"
        btnVerRegistro.Text = "Ver diagnóstico"
        actualizarListDiagnosticos()
    End Sub
    Private Sub actualizarListDiagnosticos()
        listBoxListaRegistros.Items.Clear()

        If sistema.GetEntrevistaPaciente(user).Count > 0 Then
            'For Each entrevista As Entrevista In sistema.GetEntrevistaPaciente(user)
            '    If entrevista.Diagnostico1 IsNot Nothing Then
            '        listBoxListaRegistros.Items.Add($"{sistema.GetUsuario(entrevista.Empleado1).Nombre1} {sistema.GetUsuario(entrevista.Empleado1).Apellido1}, {entrevista.Fecha1}")
            '    End If
            'Next
            For Each entrevista As Entrevista In sistema.GetDiagnosticoPaciente(user)
                listBoxListaRegistros.Items.Add($"{sistema.GetUsuario(entrevista.Empleado1).Nombre1} {sistema.GetUsuario(entrevista.Empleado1).Apellido1}, {entrevista.Fecha1}")
            Next
        End If
    End Sub
    ''MouseEnter
    Private Sub btnPacienteDiagnostico_MouseEnter(sender As Object, e As EventArgs) Handles btnPacienteDiagnostico.MouseEnter
        btnPacienteDiagnostico.Cursor = Cursors.Hand
    End Sub
    ''
    ''Esto sirve para ir a ver los analisis del paciente logueado
    Private Sub btnPacienteAnalisis_Click(sender As Object, e As EventArgs) Handles btnPacienteAnalisis.Click
        listaRegistros.BringToFront()
        regOption = "Analisis"
        tituloListaRegistros.Text = "Mis análisis clínicos"
        btnVerRegistro.Text = "Ver análisis"
        tituloRegistro.Text = "Análisis clínico 07/28/2020"
        actualizarListAnalisis()
    End Sub
    Private Sub actualizarListAnalisis()
        listBoxListaRegistros.Items.Clear()

        'If sistema.GetEntrevistaPaciente(user).Count > 0 Then
        '    For Each entrevista As Entrevista In sistema.GetEntrevistaPaciente(user)
        '        If entrevista.Diagnostico1 IsNot Nothing Then
        '            For Each solicitudAnalisis In entrevista.Diagnostico1.SolicitudesAnalisis1
        '                If solicitudAnalisis.Analisis1 IsNot Nothing Then
        '                    listBoxListaRegistros.Items.Add($"Análisis de {solicitudAnalisis.Tipo1}")
        '                End If
        '            Next
        '        End If
        '    Next
        'End If

        If sistema.GetEntrevistaPaciente(user).Count > 0 Then
            For Each entrevista As Entrevista In sistema.GetDiagnosticoPaciente(user)
                If entrevista.Diagnostico1 IsNot Nothing Then
                    For Each solicitudAnalisis In sistema.GetAnalisisPaciente(user)
                        If solicitudAnalisis.Analisis1 IsNot Nothing Then
                            listBoxListaRegistros.Items.Add($"Análisis de {solicitudAnalisis.Tipo1}")
                        End If
                    Next
                End If
            Next
        End If

    End Sub
    ''MouseEnter
    Private Sub btnPacienteAnalisis_MouseEnter(sender As Object, e As EventArgs) Handles btnPacienteAnalisis.MouseEnter
        btnPacienteAnalisis.Cursor = Cursors.Hand
    End Sub
    ''
    ''Esto sirve para ir a ver los tratamientos del paciente logueado
    Private Sub btnPacienteTratamiento_Click(sender As Object, e As EventArgs) Handles btnPacienteTratamiento.Click
        listaRegistros.BringToFront()
        regOption = "Tratamiento"
        tituloListaRegistros.Text = "Mis tratamientos"
        btnVerRegistro.Text = "Ver tratamiento"
        actualizarListTratamientos()
    End Sub
    Private Sub actualizarListTratamientos()
        listBoxListaRegistros.Items.Clear()

        If sistema.GetEntrevistaPaciente(user).Count > 0 Then
            For Each entrevista As Entrevista In sistema.GetTratamientoPaciente(user)
                If entrevista.Plan1 IsNot Nothing Then
                    listBoxListaRegistros.Items.Add($"{sistema.GetUsuario(entrevista.Empleado1).Nombre1} {sistema.GetUsuario(entrevista.Empleado1).Apellido1}, {entrevista.Fecha1} ")
                End If
            Next
        End If
    End Sub
    ''MouseEnter
    Private Sub btnPacienteTratamiento_MouseEnter(sender As Object, e As EventArgs) Handles btnPacienteTratamiento.MouseEnter
        btnPacienteTratamiento.Cursor = Cursors.Hand
    End Sub


    'Cosas del panel empleado
    ''Esto sirve para ir al panel de administrar paciente, dependiendo si es médico o auxiliar (medAdministrarPaciente, auxAdministrarPaciente)
    Private Sub btnAdministrarPaciente_Click(sender As Object, e As EventArgs) Handles btnAdministrarPaciente.Click
        patOption = "Administrar"
        administrarEntrevistarPaciente.BringToFront()
        tituloAbmPaciente.Text = "Nuevo paciente detectado"
        subitutloAbmPaciente.Text = "Rellene los siguientes datos"
    End Sub
    ''MouseEnter
    Private Sub btnAdministrarPaciente_MouseEnter(sender As Object, e As EventArgs) Handles btnAdministrarPaciente.MouseEnter
        btnAdministrarPaciente.Cursor = Cursors.Hand
    End Sub
    ''
    ''Esto sirve para ir al panel entrevistarPaciente
    Private Sub btnEntrevistarPaciente_Click(sender As Object, e As EventArgs) Handles btnEntrevistarPaciente.Click
        patOption = "Entrevistar"
        administrarEntrevistarPaciente.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub btnEntrevistarPaciente_MouseEnter(sender As Object, e As EventArgs) Handles btnEntrevistarPaciente.MouseEnter
        btnEntrevistarPaciente.Cursor = Cursors.Hand
    End Sub
    ''
    ''Boton de volver
    Private Sub backEmpleado_Click(sender As Object, e As EventArgs) Handles backEmpleado.Click
        tipoEmpleado.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backEmpleado_MouseEnter(sender As Object, e As EventArgs) Handles backEmpleado.MouseEnter
        backEmpleado.Cursor = Cursors.Hand
    End Sub




    'Cosas del panel administrador
    ''Boton de volver
    Private Sub backAdministrador_Click(sender As Object, e As EventArgs) Handles backAdministrador.Click
        main.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backAdministrador_MouseEnter(sender As Object, e As EventArgs) Handles backAdministrador.MouseEnter
        backAdministrador.Cursor = Cursors.Hand
    End Sub
    ''
    ''Esto sirve para ir al panel para administrar medicos
    Private Sub btnAdministrarMedicos_Click(sender As Object, e As EventArgs) Handles btnAdministrarMedicos.Click
        listaMedicos.BringToFront()
        actualizarListMedicos()
    End Sub
    Private Sub actualizarListMedicos()
        listMedicos.Items.Clear()
        If sistema.Medicos1.Count > 0 Then
            For Each medico As String In sistema.Medicos1
                listMedicos.Items.Add($"{sistema.GetUsuario(medico).Nombre1} {sistema.GetUsuario(medico).Apellido1}")
            Next
        End If
    End Sub
    ''MouseEnter
    Private Sub btnAdministrarMedicos_MouseEnter(sender As Object, e As EventArgs) Handles btnAdministrarMedicos.MouseEnter
        btnAdministrarMedicos.Cursor = Cursors.Hand
    End Sub
    ''
    ''Esto sirve para ir al panel para administrar auxiliares
    Private Sub btnAdministrarAuxiliares_Click(sender As Object, e As EventArgs) Handles btnAdministrarAuxiliares.Click
        listaAuxiliares.BringToFront()
        actualizarListAuxiliares()
    End Sub
    Private Sub actualizarListAuxiliares()
        listAuxiliares.Items.Clear()
        If sistema.Auxiliares1.Count > 0 Then
            For Each auxiliar As String In sistema.Auxiliares1
                listAuxiliares.Items.Add($"{sistema.GetUsuario(auxiliar).Nombre1} {sistema.GetUsuario(auxiliar).Apellido1}")
            Next
        End If
    End Sub
    ''MouseEnter
    Private Sub btnAdministrarAuxiliares_MouseEnter(sender As Object, e As EventArgs) Handles btnAdministrarAuxiliares.MouseEnter
        btnAdministrarAuxiliares.Cursor = Cursors.Hand
    End Sub



    'Cosas del panel auxiliarAdministrarPaciente
    ''Boton de volver (empleado)
    Private Sub backAuxiliarAdministrarPaciente_Click(sender As Object, e As EventArgs) Handles backAuxiliarAdministrarPaciente.Click
        empleado.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backAuxiliarAdministrarPaciente_MouseEnter(sender As Object, e As EventArgs) Handles backAuxiliarAdministrarPaciente.MouseEnter
        backAuxiliarAdministrarPaciente.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub auxiliarEntrevistar_Click(sender As Object, e As EventArgs) Handles auxiliarEntrevistar.Click
        FormEntrevista.Show()
    End Sub
    ''MouseEnter
    Private Sub auxiliarEntrevistar_MouseEnter(sender As Object, e As EventArgs) Handles auxiliarEntrevistar.MouseEnter
        auxiliarEntrevistar.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub auxiliarDiagnosticar_Click(sender As Object, e As EventArgs) Handles auxiliarDiagnosticar.Click
        FormEntrevistas.Show()
    End Sub
    ''MouseEnter
    Private Sub auxiliarDiagnosticar_MouseEnter(sender As Object, e As EventArgs) Handles auxiliarDiagnosticar.MouseEnter
        auxiliarDiagnosticar.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub auxiliarSolicitarAnalisis_Click(sender As Object, e As EventArgs) Handles auxiliarSolicitarAnalisis.Click
        FormDiagnosticos.Show()
    End Sub
    ''MouseEnter
    Private Sub auxiliarSolicitarAnalisis_MouseEnter(sender As Object, e As EventArgs) Handles auxiliarSolicitarAnalisis.MouseEnter
        auxiliarSolicitarAnalisis.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub auxiliarPacienteEstado_Click(sender As Object, e As EventArgs) Handles auxiliarPacienteEstado.Click
        FormEstados.Show()
    End Sub
    ''MouseEnter
    Private Sub auxiliarPacienteEstado_MouseEnter(sender As Object, e As EventArgs) Handles auxiliarPacienteEstado.MouseEnter
        auxiliarPacienteEstado.Cursor = Cursors.Help
    End Sub
    ''
    Private Sub auxiliarModificar_Click(sender As Object, e As EventArgs) Handles auxiliarModificar.Click
        abmPaciente.BringToFront()
        abmOption = "Mod"
        subitutloAbmPaciente.Text = ""
        tituloAbmPaciente.Text = "Modificar paciente"
        tboxABMPacienteNombre.Text = sistema.GetUsuario(selectedUser).Nombre1
        tboxABMPacienteApellido.Text = sistema.GetUsuario(selectedUser).Apellido1
        tboxABMPacienteCI.Text = sistema.GetUsuario(selectedUser).Ci1
        tboxABMPacienteCOD.Text = sistema.GetUsuario(selectedUser).Contra1
        tboxABMPacienteTelefono.Text = sistema.GetUsuario(selectedUser).Telefono1

    End Sub
    ''MouseEnter
    Private Sub auxiliarModificar_MouseEnter(sender As Object, e As EventArgs) Handles auxiliarModificar.MouseEnter
        auxiliarModificar.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub auxiliarDarDeBaja_Click(sender As Object, e As EventArgs) Handles auxiliarDarDeBaja.Click
        sistema.BajaPaciente(selectedUser)
        empleado.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub auxiliarDarDeBaja_MouseEnter(sender As Object, e As EventArgs) Handles auxiliarDarDeBaja.MouseEnter
        auxiliarDarDeBaja.Cursor = Cursors.Hand
    End Sub

    'Cosas del panel medicoAdministrarPaciente
    ''Boton de volver (empleado)
    Private Sub backMedicoAdministrarPaciente_Click(sender As Object, e As EventArgs) Handles backMedicoAdministrarPaciente.Click
        empleado.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backMedicoAdministrarPaciente_MouseEnter(sender As Object, e As EventArgs) Handles backMedicoAdministrarPaciente.MouseEnter
        backMedicoAdministrarPaciente.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub medicoEntrevistas_Click(sender As Object, e As EventArgs) Handles medicoEntrevistas.Click
        FormEntrevistas.Show()
    End Sub
    ''MouseEnter
    Private Sub medicoEntrevistas_MouseEnter(sender As Object, e As EventArgs) Handles medicoEntrevistas.MouseEnter
        medicoEntrevistas.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub medicoDiagnosticos_Click(sender As Object, e As EventArgs) Handles medicoDiagnosticos.Click
        FormDiagnosticos.Show()
    End Sub
    ''MouseEnter
    Private Sub medicoDiagnosticos_MouseEnter(sender As Object, e As EventArgs) Handles medicoDiagnosticos.MouseEnter
        medicoDiagnosticos.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub medicoTratamientos_Click(sender As Object, e As EventArgs) Handles medicoTratamientos.Click
        FormTratamientos.Show()
    End Sub
    ''MouseEnter
    Private Sub medicoTratamientos_MouseEnter(sender As Object, e As EventArgs) Handles medicoTratamientos.MouseEnter
        medicoTratamientos.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub medicoControlTratamiento_Click(sender As Object, e As EventArgs) Handles medicoControlTratamiento.Click
        FormControl.Show()
    End Sub
    ''MouseEnter
    Private Sub medicoControlTratamiento_MouseEnter(sender As Object, e As EventArgs) Handles medicoControlTratamiento.MouseEnter
        medicoControlTratamiento.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub medicoAnalisisClinicos_Click(sender As Object, e As EventArgs) Handles medicoAnalisisClinicos.Click
        FormAnalisis.Show()
    End Sub
    ''MouseEnter
    Private Sub medicoAnalisisClinicos_MouseEnter(sender As Object, e As EventArgs) Handles medicoAnalisisClinicos.MouseEnter
        medicoAnalisisClinicos.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub medicoPacienteEstado_Click(sender As Object, e As EventArgs) Handles medicoPacienteEstado.Click
        FormEstados.Show()
    End Sub
    ''MouseEnter
    Private Sub medicoPacienteEstado_MouseEnter(sender As Object, e As EventArgs) Handles medicoPacienteEstado.MouseEnter
        medicoPacienteEstado.Cursor = Cursors.Help
    End Sub
    ''
    Private Sub medicoModificar_Click(sender As Object, e As EventArgs) Handles medicoModificar.Click
        abmPaciente.BringToFront()
        abmOption = "Mod"
        subitutloAbmPaciente.Text = ""
        tituloAbmPaciente.Text = "Modificar paciente"
        tboxABMPacienteNombre.Text = sistema.GetUsuario(selectedUser).Nombre1
        tboxABMPacienteApellido.Text = sistema.GetUsuario(selectedUser).Apellido1
        tboxABMPacienteCI.Text = sistema.GetUsuario(selectedUser).Ci1
        tboxABMPacienteCOD.Text = sistema.GetUsuario(selectedUser).Contra1
        tboxABMPacienteTelefono.Text = sistema.GetUsuario(selectedUser).Telefono1
    End Sub
    ''MouseEnter
    Private Sub medicoModificar_MouseEnter(sender As Object, e As EventArgs) Handles medicoModificar.MouseEnter
        medicoModificar.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub medicoDarDeBaja_Click(sender As Object, e As EventArgs) Handles medicoDarDeBaja.Click
        sistema.BajaPaciente(selectedUser)
        empleado.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub medicoDarDeBaja_MouseEnter(sender As Object, e As EventArgs) Handles medicoDarDeBaja.MouseEnter
        medicoDarDeBaja.Cursor = Cursors.Hand
    End Sub

    'Cosas del panel listaRegistros
    ''Boton de volver (paciente)
    Private Sub backDiagnosticos_Click(sender As Object, e As EventArgs) Handles backListaRegistros.Click
        If login = "Pat" Then
            If regOption = "TratInfo" Then
                regOption = "Tratamiento"
                tituloListaRegistros.Text = "Mis tratamientos"
                btnVerRegistro.Text = "Ver tratamiento"
                listBoxListaRegistros.SelectionMode = SelectionMode.One
                actualizarListTratamientos()
            Else
                paciente.BringToFront()
            End If
        End If
    End Sub
    ''MouseEnter
    Private Sub backListaRegistros_MouseEnter(sender As Object, e As EventArgs) Handles backListaRegistros.MouseEnter
        backListaRegistros.Cursor = Cursors.Hand
    End Sub

    'Cosas del panel registro
    ''Boton de volver (listaRegistros)
    Private Sub backRegistro_Click(sender As Object, e As EventArgs) Handles backRegistro.Click
        listaRegistros.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backDiagnostico_MouseEnter(sender As Object, e As EventArgs) Handles backRegistro.MouseEnter
        backRegistro.Cursor = Cursors.Hand
    End Sub
    ''Esto sirve para ver el registro seleccionado
    Private Sub btnVerRegistro_Click(sender As Object, e As EventArgs) Handles btnVerRegistro.Click
        If regOption = "Tratamiento" Then
            If listBoxListaRegistros.SelectedIndex > -1 Then
                regOption = "TratInfo"
                selectedTratamiento = listBoxListaRegistros.SelectedIndex
                tituloListaRegistros.Text = $"Tratamiento {sistema.GetTratamientoPaciente(user)(listBoxListaRegistros.SelectedIndex).Fecha1}"
                btnVerRegistro.Text = "Ver control"
                listBoxListaRegistros.SelectionMode = SelectionMode.None
                actualizarTratamiento()
            End If
        ElseIf regOption = "Diagnostico" And listBoxListaRegistros.SelectedIndex > -1 Then
            tituloRegistro.Text = $"Diagnóstico {sistema.GetDiagnosticoPaciente(user)(listBoxListaRegistros.SelectedIndex).Fecha1}"
            actualizarListDiagnostico(sistema.GetDiagnosticoPaciente(user)(listBoxListaRegistros.SelectedIndex))
            registro.BringToFront()
        ElseIf regOption = "Analisis" And listBoxListaRegistros.SelectedIndex > -1 Then
            tituloRegistro.Text = $"Análisis de {sistema.GetAnalisisPaciente(user)(listBoxListaRegistros.SelectedIndex).Tipo1}"
            actualizarAnalisis(sistema.GetAnalisisPaciente(user)(listBoxListaRegistros.SelectedIndex).Analisis1)
            registro.BringToFront()
        ElseIf regOption = "TratInfo" Then
            tituloRegistro.Text = $"Control de tratamiento {sistema.GetTratamientoPaciente(user)(selectedTratamiento).Fecha1}"
            actualizarControlTratamiento()
            registro.BringToFront()
        End If

    End Sub
    '
    Private Sub actualizarControlTratamiento()
        listBoxRegistro.Items.Clear()

        For Each control In sistema.GetTratamientoPaciente(user)(selectedTratamiento).Plan1.Control1
            listBoxRegistro.Items.Add(control.Detalles1)
        Next
    End Sub

    Private Sub actualizarTratamiento()
        listBoxListaRegistros.Items.Clear()

        listBoxListaRegistros.Items.Add($"Detalles:")
        listBoxListaRegistros.Items.Add($"{sistema.GetTratamientoPaciente(user)(selectedTratamiento).Plan1.Detalles1}")

    End Sub
    '
    Private Sub actualizarListDiagnostico(entrevista As Entrevista)
        listBoxRegistro.Items.Clear()

        listBoxRegistro.Items.Add($"Empleado: {sistema.GetUsuario(entrevista.Empleado1).Nombre1} {sistema.GetUsuario(entrevista.Empleado1).Apellido1}")
        listBoxRegistro.Items.Add($"Paciente: {sistema.GetUsuario(entrevista.Paciente1).Nombre1} {sistema.GetUsuario(entrevista.Paciente1).Apellido1}")
        listBoxRegistro.Items.Add($"Fecha: {entrevista.Fecha1}")
        listBoxRegistro.Items.Add($"Tipo de diagnóstico: {entrevista.Diagnostico1.Tipo1}")
        listBoxRegistro.Items.Add($"Detalles de diagnóstico: {entrevista.Diagnostico1.Detalles1}")
    End Sub
    '
    Private Sub actualizarAnalisis(analisis As Analisis)
        listBoxRegistro.Items.Clear()

        listBoxRegistro.Items.Add($"Detalles de análisis: ")
        listBoxRegistro.Items.Add(analisis.Resultado1)
    End Sub
    'Cosas del panel administrarEntrevistarPaciente
    Private Sub backAdministrarEntrevistarPaciente_Click(sender As Object, e As EventArgs) Handles backAdministrarEntrevistarPaciente.Click
        empleado.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backAdministrarEntrevistarPaciente_MouseEnter(sender As Object, e As EventArgs) Handles backAdministrarEntrevistarPaciente.MouseEnter
        backAdministrarEntrevistarPaciente.Cursor = Cursors.Hand
    End Sub

    Private Sub btnAdministrarEntrevistarPaciente_Click(sender As Object, e As EventArgs) Handles btnAdministrarEntrevistarPaciente.Click
        If tboxEntrevistarPaciente.Text = "" Then
            entrevistarPacienteError.Text = "El campo no puede estar vacío"
        Else
            entrevistarPacienteError.Text = ""
            If sistema.PacienteExiste(tboxEntrevistarPaciente.Text) Then
                selectedUser = tboxEntrevistarPaciente.Text

                If login = "Med" Then
                    medicoAdministrarPaciente.BringToFront()
                    tituloMedicoAdministrarPaciente.Text = $"Paciente {sistema.GetUsuario(selectedUser).Apellido1}, {sistema.GetUsuario(selectedUser).Nombre1}"
                    medicoActualizarEstadoPaciente()
                    If patOption = "Entrevistar" Then
                        FormEntrevista.Show()
                    End If
                ElseIf login = "Aux" Then
                    auxiliarAdministrarPaciente.BringToFront()
                    tituloAuxiliarAdministrarPaciente.Text = $"Paciente {sistema.GetUsuario(selectedUser).Apellido1}, {sistema.GetUsuario(selectedUser).Nombre1}"
                    auxiliarActualizarEstadoPaciente()
                    If patOption = "Entrevistar" Then
                        FormEntrevista.Show()
                    End If
                Else
                    Console.WriteLine("Algo ha salido mal.")
                End If
            Else
                abmOption = "Alta"
                abmPaciente.BringToFront()
                tituloAbmPaciente.Text = "Nuevo paciente detectado"
                subitutloAbmPaciente.Text = "Rellene los siguientes datos"
                tboxABMPacienteCI.Text = tboxEntrevistarPaciente.Text
            End If
        End If


    End Sub

    Public Sub medicoActualizarEstadoPaciente()
        Select Case sistema.GetEstadoPaciente(selectedUser)
            Case 0
                medicoPacienteEstado.Image = My.Resources.ResourceManager.GetObject("estadoA")
            Case 1
                medicoPacienteEstado.Image = My.Resources.ResourceManager.GetObject("estadoB")
            Case 2
                medicoPacienteEstado.Image = My.Resources.ResourceManager.GetObject("estadoC")
            Case 3
                medicoPacienteEstado.Image = My.Resources.ResourceManager.GetObject("estadoD")
            Case 4
                medicoPacienteEstado.Image = My.Resources.ResourceManager.GetObject("estadoE")
        End Select
    End Sub

    Public Sub auxiliarActualizarEstadoPaciente()
        Select Case sistema.GetEstadoPaciente(selectedUser)
            Case 0
                auxiliarPacienteEstado.Image = My.Resources.ResourceManager.GetObject("estadoA")
            Case 1
                auxiliarPacienteEstado.Image = My.Resources.ResourceManager.GetObject("estadoB")
            Case 2
                auxiliarPacienteEstado.Image = My.Resources.ResourceManager.GetObject("estadoC")
            Case 3
                auxiliarPacienteEstado.Image = My.Resources.ResourceManager.GetObject("estadoD")
            Case 4
                auxiliarPacienteEstado.Image = My.Resources.ResourceManager.GetObject("estadoE")
        End Select
    End Sub


    'Cosas del panel abmPaciente
    ''Volver
    Private Sub backAbmPaciente_Click(sender As Object, e As EventArgs) Handles backAbmPaciente.Click
        If login = "Aux" Then
            If abmOption = "Mod" Then
                auxiliarAdministrarPaciente.BringToFront()
            ElseIf abmOption = "Alta" Then
                empleado.BringToFront()
            End If
        ElseIf login = "Med" Then
            If abmOption = "Mod" Then
                medicoAdministrarPaciente.BringToFront()
            ElseIf abmOption = "Alta" Then
                empleado.BringToFront()
            End If
        Else
            Console.WriteLine("Algo ha salido mal.")
        End If
    End Sub
    ''MouseEnter
    Private Sub backAbmPaciente_MouseEnter(sender As Object, e As EventArgs) Handles backAbmPaciente.MouseEnter
        backAbmPaciente.Cursor = Cursors.Hand
    End Sub

    Private Sub aceptarAbmPaciente_Click(sender As Object, e As EventArgs) Handles aceptarAbmPaciente.Click
        If tboxABMPacienteCI.Text = "" Or tboxABMPacienteCOD.Text = "" Or tboxABMPacienteNombre.Text = "" Or tboxABMPacienteApellido.Text = "" Or tboxABMPacienteTelefono.Text = "" Or tboxABMPacienteDireccion.Text = "" Or tboxABMPacienteFechanacimiento.Text = "" Then
            abmPacienteError.Text = "No pueden haber campos vacíos"
        Else
            abmPacienteError.Text = ""

            If abmOption = "Alta" Then
                If sistema.PacienteExiste(tboxABMPacienteCI.Text) Then
                    abmPacienteError.Text = "Este paciente ya existe"
                Else
                    sistema.AnadirUsuario(tboxABMPacienteCI.Text, tboxABMPacienteNombre.Text, tboxABMPacienteApellido.Text, tboxABMPacienteCOD.Text, tboxABMPacienteTelefono.Text, tboxABMPacienteDireccion.Text, tboxABMPacienteFechanacimiento.Text, "Pat")

                    selectedUser = tboxABMPacienteCI.Text


                End If
            ElseIf abmOption = "Mod" Then
                'sistema.GetUsuario(selectedUser).Ci1 = tboxABMPacienteCI.Text
                sistema.GetUsuario(selectedUser).Nombre1 = tboxABMPacienteNombre.Text
                sistema.GetUsuario(selectedUser).Apellido1 = tboxABMPacienteApellido.Text
                sistema.GetUsuario(selectedUser).Contra1 = tboxABMPacienteCOD.Text
                clearABM()
            End If

            If login = "Aux" Then
                auxiliarAdministrarPaciente.BringToFront()
                tituloAuxiliarAdministrarPaciente.Text = $"Paciente {sistema.GetUsuario(selectedUser).Apellido1}, {sistema.GetUsuario(selectedUser).Nombre1}"
                If patOption = "Entrevistar" Then
                    FormEntrevista.Show()
                End If
            ElseIf login = "Med" Then
                medicoAdministrarPaciente.BringToFront()
                tituloMedicoAdministrarPaciente.Text = $"Paciente {sistema.GetUsuario(selectedUser).Apellido1}, {sistema.GetUsuario(selectedUser).Nombre1}"
                If patOption = "Entrevistar" Then
                    FormEntrevista.Show()
                End If
            Else
                Console.WriteLine("Algo ha salido mal.")
            End If
        End If

    End Sub



    'Cosas del panel abmEmpleado
    Private Sub backAbmEmpleado_Click(sender As Object, e As EventArgs) Handles backAbmEmpleado.Click
        If adminOption = "Med" Then
            clearABM()
            listaMedicos.BringToFront()
            actualizarListMedicos()
        ElseIf adminOption = "Aux" Then
            clearABM()
            listaAuxiliares.BringToFront()
            actualizarListAuxiliares()
        Else
            Console.WriteLine("Algo ha salido mal.")
        End If
    End Sub
    ''MouseEnter
    Private Sub backAbmEmpleado_MouseEnter(sender As Object, e As EventArgs) Handles backAbmEmpleado.MouseEnter
        backAbmEmpleado.Cursor = Cursors.Hand
    End Sub



    'Cosas del panel listaAuxiliares
    Private Sub backListaAuxiliares_Click(sender As Object, e As EventArgs) Handles backListaAuxiliares.Click
        administrador.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backListaAuxiliares_MouseEnter(sender As Object, e As EventArgs) Handles backListaAuxiliares.MouseEnter
        backListaAuxiliares.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub btnModificarAuxiliar_Click(sender As Object, e As EventArgs) Handles btnModificarAuxiliar.Click
        If listMedicos.SelectedIndex > -1 Then
            abmEmpleado.BringToFront()
            adminOption = "Aux"
            abmOption = "Mod"
            titleAbmEmpleado.Text = "Modificar auxiliar"
            abmEmpleadoAceptar.Text = "Guardar cambios"
            selectedUser = sistema.Auxiliares1(listMedicos.SelectedIndex)
            tboxAgregarEmpleadoCI.Text = sistema.GetUsuario(selectedUser).Ci1
            tboxAgregarEmpleadoNombre.Text = sistema.GetUsuario(selectedUser).Nombre1
            tboxAgregarEmpleadoApellido.Text = sistema.GetUsuario(selectedUser).Apellido1
            tboxAgregarEmpleadoCOD.Text = sistema.GetUsuario(selectedUser).Contra1
        End If
    End Sub
    ''
    Private Sub btnAgregarAuxiliar_Click(sender As Object, e As EventArgs) Handles btnAgregarAuxiliar.Click
        abmEmpleado.BringToFront()
        adminOption = "Aux"
        abmOption = "Alta"
        titleAbmEmpleado.Text = "Agregar auxiliar"
        abmEmpleadoAceptar.Text = "Aceptar"
    End Sub
    ''
    Private Sub btnEliminarAuxiliar_Click(sender As Object, e As EventArgs) Handles btnEliminarAuxiliar.Click
        If listAuxiliares.SelectedIndex > -1 Then
            sistema.Auxiliares1.RemoveAt(listAuxiliares.SelectedIndex)
            actualizarListAuxiliares()
        End If
    End Sub


    'Cosas del panel listaMedicos
    Private Sub backListaMedicos_Click(sender As Object, e As EventArgs) Handles backListaMedicos.Click
        administrador.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backListaMedicos_MouseEnter(sender As Object, e As EventArgs) Handles backListaMedicos.MouseEnter
        backListaMedicos.Cursor = Cursors.Hand
    End Sub
    ''
    Private Sub btnModificarMedico_Click(sender As Object, e As EventArgs) Handles btnModificarMedico.Click
        If listMedicos.SelectedIndex > -1 Then
            abmEmpleado.BringToFront()
            adminOption = "Med"
            abmOption = "Mod"
            titleAbmEmpleado.Text = "Modificar médico"
            abmEmpleadoAceptar.Text = "Guardar cambios"
            selectedUser = sistema.Medicos1(listMedicos.SelectedIndex)
            tboxAgregarEmpleadoCI.Text = sistema.GetUsuario(selectedUser).Ci1
            tboxAgregarEmpleadoNombre.Text = sistema.GetUsuario(selectedUser).Nombre1
            tboxAgregarEmpleadoApellido.Text = sistema.GetUsuario(selectedUser).Apellido1
            tboxAgregarEmpleadoCOD.Text = sistema.GetUsuario(selectedUser).Contra1
            tboxAgregarEmpleadoTelefono.Text = sistema.GetUsuario(selectedUser).Telefono1
        End If
    End Sub
    ''
    Private Sub btnAgregarMedico_Click(sender As Object, e As EventArgs) Handles btnAgregarMedico.Click
        abmEmpleado.BringToFront()
        adminOption = "Med"
        abmOption = "Alta"
        titleAbmEmpleado.Text = "Agregar médico"
        abmEmpleadoAceptar.Text = "Aceptar"
    End Sub
    ''
    Private Sub abmEmpleadoAceptar_Click(sender As Object, e As EventArgs) Handles abmEmpleadoAceptar.Click
        If tboxAgregarEmpleadoCI.Text = "" Or tboxAgregarEmpleadoCOD.Text = "" Or tboxAgregarEmpleadoNombre.Text = "" Or tboxAgregarEmpleadoApellido.Text = "" Or tboxAgregarEmpleadoTelefono.Text = "" Or tboxAgregarEmpleadoDireccion.Text = "" Or tboxAgregarEmpleadoFechanacimiento.Text = "" Then
            abmEmpleadoError.Text = "No pueden haber campos vacíos"
        Else
            abmEmpleadoError.Text = ""

            If abmOption = "Alta" Then
                If adminOption = "Med" Then
                    If sistema.MedicoExiste(tboxAgregarEmpleadoCI.Text) Then
                        abmEmpleadoError.Text = "Este médico ya existe"
                    Else
                        sistema.AnadirUsuario(tboxAgregarEmpleadoCI.Text, tboxAgregarEmpleadoNombre.Text, tboxAgregarEmpleadoApellido.Text, tboxAgregarEmpleadoCOD.Text, tboxAgregarEmpleadoTelefono.Text, tboxAgregarEmpleadoDireccion.Text, tboxAgregarEmpleadoFechanacimiento.Text, "Med")
                        clearABM()
                        listaMedicos.BringToFront()
                        actualizarListMedicos()
                    End If
                ElseIf adminOption = "Aux" Then
                    If sistema.AuxiliarExiste(tboxAgregarEmpleadoCI.Text) Then
                        abmEmpleadoError.Text = "Este médico ya existe"
                    Else
                        sistema.AnadirUsuario(tboxAgregarEmpleadoCI.Text, tboxAgregarEmpleadoNombre.Text, tboxAgregarEmpleadoApellido.Text, tboxAgregarEmpleadoCOD.Text, tboxAgregarEmpleadoTelefono.Text, tboxAgregarEmpleadoDireccion.Text, tboxAgregarEmpleadoFechanacimiento.Text, "Aux")
                        clearABM()
                        listaAuxiliares.BringToFront()
                        actualizarListAuxiliares()
                    End If
                Else
                    Console.WriteLine("Algo ha salido mal.")
                End If
            ElseIf abmOption = "Mod" Then
                'sistema.GetUsuario(selectedUser).Ci1 = tboxAgregarEmpleadoCI.Text
                sistema.GetUsuario(selectedUser).Nombre1 = tboxAgregarEmpleadoNombre.Text
                sistema.GetUsuario(selectedUser).Apellido1 = tboxAgregarEmpleadoApellido.Text
                sistema.GetUsuario(selectedUser).Contra1 = tboxAgregarEmpleadoCOD.Text
                If adminOption = "Med" Then
                    clearABM()
                    listaMedicos.BringToFront()
                    actualizarListMedicos()
                ElseIf adminOption = "Aux" Then
                    clearABM()
                    listaAuxiliares.BringToFront()
                    actualizarListAuxiliares()
                End If

            End If
        End If

    End Sub
    ''
    Private Sub btnEliminarMedico_Click(sender As Object, e As EventArgs) Handles btnEliminarMedico.Click
        If listMedicos.SelectedIndex > -1 Then
            sistema.Medicos1.RemoveAt(listMedicos.SelectedIndex)
            actualizarListMedicos()
        End If
    End Sub
    Private Sub clearABM()
        tboxAgregarEmpleadoCI.Text = ""
        tboxAgregarEmpleadoNombre.Text = ""
        tboxAgregarEmpleadoApellido.Text = ""
        tboxAgregarEmpleadoCOD.Text = ""
        tboxABMPacienteCI.Text = ""
        tboxABMPacienteNombre.Text = ""
        tboxABMPacienteApellido.Text = ""
        tboxABMPacienteCOD.Text = ""
    End Sub


    'Validaciones
    '97 - 122 = Ascii de letras minusculas
    '65 - 90  = Ascii de letras mayusculas
    '48 - 57  = Ascii de numeros
    Private Sub tboxLoginPersonal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxLoginPersonal.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub tboxLoginPaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxLoginPaciente.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub tboxEntrevistarPaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxEntrevistarPaciente.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub tboxAgregarEmpleadoCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxAgregarEmpleadoCI.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub tboxAgregarEmpleadoCOD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxAgregarEmpleadoCOD.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub tboxABMPacienteCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxABMPacienteCI.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub tboxABMPacienteCOD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxABMPacienteCOD.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

End Class
