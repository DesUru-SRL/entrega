Public Class FormEntrevistas

    Dim paciente As Usuario

    Private Sub FormEntrevistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paciente = Window.sistema.GetUsuario(Window.selectedUser)
        tituloEntrevistas.Text = $"Entrevistas hechas a {paciente.Apellido1}, {paciente.Nombre1}"
        listEntrevistas.Items.Clear()
        For Each entrevista As Entrevista In Window.sistema.Entrevistas1
            If entrevista.Paciente1 = paciente.Ci1 Then
                listEntrevistas.Items.Add($"{Window.sistema.GetUsuario(entrevista.Empleado1).Nombre1} {Window.sistema.GetUsuario(entrevista.Empleado1).Apellido1}, {entrevista.Fecha1}")
            End If
        Next
    End Sub

    Private Sub btnNuevaEntrevista_Click(sender As Object, e As EventArgs) Handles btnNuevaEntrevista.Click
        FormEntrevista.Show()
    End Sub
End Class