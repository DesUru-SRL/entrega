Public Class FormDiagnosticos

    Dim paciente As Usuario
    Dim selectedEntrevista As Entrevista
    Dim indexEntrevistas As List(Of Integer) = New List(Of Integer)

    Private Sub FormDiagnosticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paciente = Window.sistema.GetUsuario(Window.selectedUser)
        tituloDiagnosticos.Text = $"Diagnosticos de {paciente.Apellido1}, {paciente.Nombre1}"
        actualizarEntrevistas()
    End Sub

    Public Sub actualizarEntrevistas()
        listEntrevistas.Items.Clear()
        indexEntrevistas.Clear()
        Dim i As Integer = 0

        'For Each entrevista As Entrevista In Window.sistema.Entrevistas1
        '    If entrevista.Paciente1 = paciente.Ci1 And entrevista.Diagnostico1 IsNot Nothing Then
        '        indexEntrevistas.Add(i)
        '        listEntrevistas.Items.Add($"{Window.sistema.GetUsuario(entrevista.Empleado1).Nombre1} {Window.sistema.GetUsuario(entrevista.Empleado1).Apellido1}, {entrevista.Fecha1}")
        '    End If
        '    i += 1
        'Next
        For Each entrevista As Entrevista In Window.sistema.GetDiagnosticoPaciente(paciente.Ci1)
            indexEntrevistas.Add(i)
            listEntrevistas.Items.Add($"{Window.sistema.GetUsuario(entrevista.Empleado1).Nombre1} {Window.sistema.GetUsuario(entrevista.Empleado1).Apellido1}, {entrevista.Fecha1}")
            i += 1
        Next
    End Sub

    Private Sub btnVerDiagnostico_Click(sender As Object, e As EventArgs) Handles btnVerDiagnostico.Click
        If listEntrevistas.SelectedIndex > -1 Then
            diagnostico.BringToFront()
            selectedEntrevista = Window.sistema.GetDiagnosticoPaciente(paciente.Ci1)(listEntrevistas.SelectedIndex)
            tituloEntrevista.Text = $"Diagnostico del {selectedEntrevista.Fecha1}"
            listEntrevista.Items.Clear()
            listEntrevista.Items.Add($"Empleado: {Window.sistema.GetUsuario(selectedEntrevista.Empleado1).Nombre1} {Window.sistema.GetUsuario(selectedEntrevista.Empleado1).Apellido1}")
            listEntrevista.Items.Add($"Paciente: {Window.sistema.GetUsuario(selectedEntrevista.Paciente1).Nombre1} {Window.sistema.GetUsuario(selectedEntrevista.Paciente1).Apellido1}")
            listEntrevista.Items.Add($"Fecha: {selectedEntrevista.Fecha1}")
            listEntrevista.Items.Add($"Tipo de diagnóstico: {selectedEntrevista.Diagnostico1.Tipo1}")
            listEntrevista.Items.Add($"Detalles de diagnóstico: {selectedEntrevista.Diagnostico1.Detalles1}")
        End If
    End Sub

    Private Sub backDiagnostico_Click(sender As Object, e As EventArgs) Handles backDiagnostico.Click
        listaDiagnosticos.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backDiagnostico_MouseEnter(sender As Object, e As EventArgs) Handles backDiagnostico.MouseEnter
        backDiagnostico.Cursor = Cursors.Hand
    End Sub

    Private Sub btnSolicitarAnalisis_Click(sender As Object, e As EventArgs) Handles btnSolicitarAnalisis.Click
        If listEntrevistas.SelectedIndex > -1 Then
            selectedEntrevista = Window.sistema.GetDiagnosticoPaciente(paciente.Ci1)(listEntrevistas.SelectedIndex)
            solicitarAnalisis.BringToFront()
        End If
    End Sub

    Private Sub aceptarSolicitarAnalisis_Click(sender As Object, e As EventArgs) Handles aceptarSolicitarAnalisis.Click
        If tboxTipo.Text = "" Then
            solicitarAnalisisError.Text = "El campo no puede estar vacío"
        Else
            solicitarAnalisisError.Text = ""
            selectedEntrevista.Diagnostico1.AnadirAnalisis(tboxTipo.Text)
            Window.sistema.SolicitarAnalisis(selectedEntrevista)
            listaDiagnosticos.BringToFront()
        End If
    End Sub

    Private Sub backSolicitarAnalisis_Click(sender As Object, e As EventArgs) Handles backSolicitarAnalisis.Click
        listaDiagnosticos.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backSolicitarAnalisis_MouseEnter(sender As Object, e As EventArgs) Handles backSolicitarAnalisis.MouseEnter
        backSolicitarAnalisis.Cursor = Cursors.Hand
    End Sub

    Private Sub btnIngresarTratamiento_Click(sender As Object, e As EventArgs) Handles btnIngresarTratamiento.Click
        If listEntrevistas.SelectedIndex > -1 Then
            selectedEntrevista = Window.sistema.GetDiagnosticoPaciente(paciente.Ci1)(listEntrevistas.SelectedIndex)
            ingresarTratamiento.BringToFront()
            End If
    End Sub

    Private Sub backIngresarTratamiento_Click(sender As Object, e As EventArgs) Handles backIngresarTratamiento.Click
        listaDiagnosticos.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backIngresarTratamiento_MouseEnter(sender As Object, e As EventArgs) Handles backIngresarTratamiento.MouseEnter
        backIngresarTratamiento.Cursor = Cursors.Hand
    End Sub

    Private Sub aceptarIngresarTratamiento_Click(sender As Object, e As EventArgs) Handles aceptarIngresarTratamiento.Click
        If tboxDetalles.Text = "" Then
            ingresarTratamientoError.Text = "El campo no puede estar vacío"
        Else
            ingresarTratamientoError.Text = ""
            selectedEntrevista.Plan1 = New Plan(tboxDetalles.Text)
            Window.sistema.AnadirTratamiento(selectedEntrevista)
            listaDiagnosticos.BringToFront()
        End If
    End Sub
End Class