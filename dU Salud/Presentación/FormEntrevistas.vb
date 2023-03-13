Public Class FormEntrevistas

    Dim paciente As Usuario
    Dim selectedEntrevista As Entrevista
    Dim indexEntrevistas As List(Of Integer) = New List(Of Integer)

    Private Sub FormEntrevistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paciente = Window.sistema.GetUsuario(Window.selectedUser)
        tituloEntrevistas.Text = $"Entrevistas hechas a {paciente.Apellido1}, {paciente.Nombre1}"
        actualizarEntrevistas()
    End Sub

    Public Sub actualizarEntrevistas()
        listEntrevistas.Items.Clear()
        indexEntrevistas.Clear()
        Dim i As Integer = 0

        For Each entrevista As Entrevista In Window.sistema.GetEntrevistaPaciente(paciente.Ci1)
            indexEntrevistas.Add(i)
            listEntrevistas.Items.Add($"{Window.sistema.GetUsuario(entrevista.Empleado1).Nombre1} {Window.sistema.GetUsuario(entrevista.Empleado1).Apellido1}, {entrevista.Fecha1}")
            i += 1
        Next
    End Sub

    Private Sub btnNuevaEntrevista_Click(sender As Object, e As EventArgs) Handles btnNuevaEntrevista.Click
        FormEntrevista.Show()
    End Sub

    Private Sub btnVerEntrevista_Click(sender As Object, e As EventArgs) Handles btnVerEntrevista.Click
        If listEntrevistas.SelectedIndex > -1 Then
            entrevista.BringToFront()
            selectedEntrevista = Window.sistema.GetEntrevistaPaciente(paciente.Ci1)(listEntrevistas.SelectedIndex)
            tituloEntrevista.Text = $"Entrevista del {selectedEntrevista.Fecha1}"
            listEntrevista.Items.Clear()
            'MsgBox(selectedEntrevista.Glasgow1.ReaccionMotora1)
            listEntrevista.Items.Add($"Empleado: {Window.sistema.GetUsuario(selectedEntrevista.Empleado1).Nombre1} {Window.sistema.GetUsuario(selectedEntrevista.Empleado1).Apellido1}")
            listEntrevista.Items.Add($"Paciente: {Window.sistema.GetUsuario(selectedEntrevista.Paciente1).Nombre1} {Window.sistema.GetUsuario(selectedEntrevista.Paciente1).Apellido1}")
            listEntrevista.Items.Add($"Fecha: {selectedEntrevista.Fecha1}")
            listEntrevista.Items.Add($"Estado General: {selectedEntrevista.EstadoGeneral1}")
            If selectedEntrevista.Colabora1 Then
                listEntrevista.Items.Add($"Colabora: Si")
            Else
                listEntrevista.Items.Add($"Colabora: No")
            End If
            listEntrevista.Items.Add($"Actitud: {selectedEntrevista.Actitud1}")
            listEntrevista.Items.Add($"Estado Nutricional: {selectedEntrevista.EstadoNutricional1}")
            listEntrevista.Items.Add($"Pulso: {selectedEntrevista.Pulso1}")
            listEntrevista.Items.Add($"Frecuencia Cardíaca: {selectedEntrevista.FrecuenciaCardiaca1}")
            listEntrevista.Items.Add($"Frecuencia Respiratoria: {selectedEntrevista.FrecuenciaRespiratoria1}")
            listEntrevista.Items.Add($"Temperatura: {selectedEntrevista.Temperatura1}")
            listEntrevista.Items.Add($"Síntomas: ")
            For Each sintoma In selectedEntrevista.Sintomas1
                listEntrevista.Items.Add($"    {sintoma}")
            Next
            listEntrevista.Items.Add($"Motivo: {selectedEntrevista.Motivo1}")
            If selectedEntrevista.Eva1 IsNot Nothing Then
                listEntrevista.Items.Add($"Escala visual analógica: {selectedEntrevista.Eva1.Valor1}")
            End If
            If selectedEntrevista.Glasgow1 IsNot Nothing Then
                listEntrevista.Items.Add($"Glawgow:")
                listEntrevista.Items.Add($"    Reacción motora: {selectedEntrevista.Glasgow1.ReaccionMotora1}")
                listEntrevista.Items.Add($"    Reacción visual: {selectedEntrevista.Glasgow1.ReaccionVisual1}")
                listEntrevista.Items.Add($"    Reacción ocular: {selectedEntrevista.Glasgow1.ReaccionOcular1}")
            End If
            If selectedEntrevista.Fisico1 IsNot Nothing Then
                listEntrevista.Items.Add($"Examen físico:")
                listEntrevista.Items.Add($"    Piel: {selectedEntrevista.Fisico1.Piel1}")
                listEntrevista.Items.Add($"    Cuello: {selectedEntrevista.Fisico1.Cuello1}")
                listEntrevista.Items.Add($"    Linfogaglionar: {selectedEntrevista.Fisico1.Linfogag1}")
                listEntrevista.Items.Add($"    Mamas: {selectedEntrevista.Fisico1.Mamas1}")
            End If
        End If

    End Sub

    Private Sub btnDiagnosticar_Click(sender As Object, e As EventArgs) Handles btnDiagnosticar.Click
        If listEntrevistas.SelectedIndex > -1 Then
            selectedEntrevista = Window.sistema.GetEntrevistaPaciente(paciente.Ci1)(listEntrevistas.SelectedIndex)
            If selectedEntrevista.Diagnostico1 Is Nothing Then
                diagnosticar.BringToFront()
            End If
        End If
    End Sub

    Private Sub backEntrevista_Click(sender As Object, e As EventArgs) Handles backEntrevista.Click
        listaEntrevistas.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backEntrevista_MouseEnter(sender As Object, e As EventArgs) Handles backEntrevista.MouseEnter
        backEntrevista.Cursor = Cursors.Hand
    End Sub

    Private Sub backDiagnosticar_Click(sender As Object, e As EventArgs) Handles backDiagnosticar.Click
        listaEntrevistas.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backDiagnosticar_MouseEnter(sender As Object, e As EventArgs) Handles backDiagnosticar.MouseEnter
        backEntrevista.Cursor = Cursors.Hand
    End Sub

    Private Sub aceptarDiagnosticar_Click(sender As Object, e As EventArgs) Handles aceptarDiagnosticar.Click
        If tboxTipo.Text = "" Or tboxDetalles.Text = "" Then
            diagnosticarError.Text = "Los campos no pueden estar vacíos"
        Else
            selectedEntrevista = Window.sistema.GetEntrevistaPaciente(paciente.Ci1)(listEntrevistas.SelectedIndex)
            selectedEntrevista.Diagnostico1 = New Diagnostico(tboxTipo.Text, tboxDetalles.Text)
            Window.sistema.Diagnosticar(selectedEntrevista)
            actualizarEntrevistas()
            listaEntrevistas.BringToFront()
        End If
    End Sub
End Class