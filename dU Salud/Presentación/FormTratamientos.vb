Public Class FormTratamientos

    Dim paciente As Usuario
    Dim selectedEntrevista As Entrevista
    Dim indexEntrevistas As List(Of Integer) = New List(Of Integer)

    Private Sub FormTratamientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paciente = Window.sistema.GetUsuario(Window.selectedUser)
        tituloTratamientos.Text = $"Tratamientos de {paciente.Apellido1}, {paciente.Nombre1}"
        actualizarTratamientos()
    End Sub

    Public Sub actualizarTratamientos()
        listTratamientos.Items.Clear()

        indexEntrevistas.Clear()
        Dim i As Integer = 0
        For Each entrevista As Entrevista In Window.sistema.GetTratamientoPaciente(paciente.Ci1)
            indexEntrevistas.Add(i)
            listTratamientos.Items.Add($"{Window.sistema.GetUsuario(entrevista.Empleado1).Nombre1} {Window.sistema.GetUsuario(entrevista.Empleado1).Apellido1}, {entrevista.Fecha1}")
            i += 1
        Next
    End Sub

    Private Sub btnVerTratamiento_Click(sender As Object, e As EventArgs) Handles btnVerTratamiento.Click
        If listTratamientos.SelectedIndex > -1 Then
            selectedEntrevista = Window.sistema.GetTratamientoPaciente(paciente.Ci1)(listTratamientos.SelectedIndex)
            tratamiento.BringToFront()
            tituloTratamiento.Text = $"Tratamiento del {selectedEntrevista.Fecha1}"
            listTratamiento.Items.Clear()
            listTratamiento.Items.Add($"Empleado: {Window.sistema.GetUsuario(selectedEntrevista.Empleado1).Nombre1} {Window.sistema.GetUsuario(selectedEntrevista.Empleado1).Apellido1}")
            listTratamiento.Items.Add($"Paciente: {Window.sistema.GetUsuario(selectedEntrevista.Paciente1).Nombre1} {Window.sistema.GetUsuario(selectedEntrevista.Paciente1).Apellido1}")
            listTratamiento.Items.Add($"Fecha: {selectedEntrevista.Fecha1}")
            listTratamiento.Items.Add($"Detalles: {selectedEntrevista.Plan1.Detalles1}")
        End If
    End Sub

    Private Sub backTratamiento_Click(sender As Object, e As EventArgs) Handles backTratamiento.Click
        listaTratamientos.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backTratamiento_MouseEnter(sender As Object, e As EventArgs) Handles backTratamiento.MouseEnter
        backTratamiento.Cursor = Cursors.Hand
    End Sub

    Private Sub btnIngresarControl_Click(sender As Object, e As EventArgs) Handles btnIngresarControl.Click
        If listTratamientos.SelectedIndex > -1 Then
            'selectedEntrevista = Window.sistema.Entrevistas1(indexEntrevistas(listTratamientos.SelectedIndex))
            selectedEntrevista = Window.sistema.GetTratamientoPaciente(paciente.Ci1)(listTratamientos.SelectedIndex)
            ingresarControl.BringToFront()
        End If
    End Sub

    Private Sub backIngresarControl_Click(sender As Object, e As EventArgs) Handles backIngresarControl.Click
        listaTratamientos.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backIngresarControl_MouseEnter(sender As Object, e As EventArgs) Handles backIngresarControl.MouseEnter
        backIngresarControl.Cursor = Cursors.Hand
    End Sub

    Private Sub aceptarIngresarControl_Click(sender As Object, e As EventArgs) Handles aceptarIngresarControl.Click
        If tboxDetalles.Text = "" Then
            ingresarControlError.Text = "El campo no puede estar vacío"
        Else
            ingresarControlError.Text = ""
            selectedEntrevista.Plan1.Control1.Add(New ControlPlan(tboxDetalles.Text))
            Window.sistema.AnadirControl(selectedEntrevista)
            listaTratamientos.BringToFront()
        End If
    End Sub
End Class