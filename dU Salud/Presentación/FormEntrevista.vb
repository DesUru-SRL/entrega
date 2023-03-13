Public Class FormEntrevista

    Dim paciente As Usuario
    Public entrevista As Entrevista
    Dim fecha As Date
    Public motivo As String
    Public sintomas As List(Of String) = New List(Of String)


    Private Sub FormEntrevista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paciente = Window.sistema.GetUsuario(Window.selectedUser)
        tituloEntrevista.Text = $"Entrevista a {paciente.Apellido1}, {paciente.Nombre1}"
        FormSintomas.sintomas.Clear()
        FormMotivo.tboxMotivo.Clear()
        fecha = Date.Now()
        entrevista = New Entrevista()
        sintomas.Clear()
    End Sub

    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        If estadoGeneral.Text = "" Or gradoColaboracion.Text = "" Or estadoNutricional.Text = "" Or actitud.Text = "" Or temperatura.Text = "" Or frecuenciaRespiratoria.Text = "" Or frecuenciaCardiaca.Text = "" Then
            entrevistaError.Text = "Los campos no pueden estar vacíos"
        Else
            entrevistaError.Text = ""
            entrevista.SetNew(fecha, Not gradoColaboracion.SelectedIndex, actitud.Text, estadoNutricional.Text, temperatura.Text, pulso.Text, frecuenciaCardiaca.Text, frecuenciaRespiratoria.Text, motivo, estadoGeneral.Text, sintomas, paciente.Ci1, Window.user)
            'Window.sistema.Entrevistas1.Add(entrevista)
            Window.sistema.AnadirEntrevista(entrevista)
            FormEntrevistas.actualizarEntrevistas()
            Close()
        End If
    End Sub

    Private Sub agregarSintomas_Click(sender As Object, e As EventArgs) Handles agregarSintomas.Click
        FormSintomas.Show()
    End Sub

    Private Sub agregarMotivo_Click(sender As Object, e As EventArgs) Handles agregarMotivo.Click
        FormMotivo.Show()
    End Sub

    Private Sub agregarFormularios_Click(sender As Object, e As EventArgs) Handles agregarFormularios.Click
        FormFormularios.Show()
    End Sub


End Class