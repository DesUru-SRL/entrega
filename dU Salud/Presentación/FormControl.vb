Public Class FormControl

    Dim paciente As Usuario
    Dim selectedEntrevista As Entrevista
    Dim indexEntrevistas As List(Of Integer) = New List(Of Integer)

    Public Sub actualizarControles()
        registro.Items.Clear()
        indexEntrevistas.Clear()
        Dim i As Integer = 0
        For Each entrevista As Entrevista In Window.sistema.GetTratamientoPaciente(paciente.Ci1)
            indexEntrevistas.Add(i)
            registro.Items.Add($"Tratamiento del {entrevista.Fecha1}")
            i += 1
        Next
    End Sub

    Private Sub FormControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paciente = Window.sistema.GetUsuario(Window.selectedUser)
        tituloControlTratamiento.Text = $"Control de tratamientos de {paciente.Apellido1}, {paciente.Nombre1}"
        actualizarControles()
    End Sub

    Private Sub btnVerRegistro_Click(sender As Object, e As EventArgs) Handles btnVerRegistro.Click
        If registro.SelectedIndex > -1 Then
            selectedEntrevista = Window.sistema.GetTratamientoPaciente(paciente.Ci1)(registro.SelectedIndex)
            tituloTratamiento.Text = $"Tratamiento del {selectedEntrevista.Fecha1}"
            tratamiento.BringToFront()
            listControlTratamiento.Items.Clear()
            For Each control As ControlPlan In selectedEntrevista.Plan1.Control1
                listControlTratamiento.Items.Add(control.Detalles1)
            Next
        End If
    End Sub

    Private Sub backTratamiento_Click(sender As Object, e As EventArgs) Handles backTratamiento.Click
        controlRegistro.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backTratamiento_MouseEnter(sender As Object, e As EventArgs) Handles backTratamiento.MouseEnter
        backTratamiento.Cursor = Cursors.Hand
    End Sub

End Class