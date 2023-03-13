Public Class FormAnalisis

    Dim paciente As Usuario
    Dim selectedAnalisis As SolicitudAnalisis
    Dim indexEntrevistas As List(Of List(Of Integer)) = New List(Of List(Of Integer))
    Dim x As Integer
    Dim y As Integer

    Public Sub actualizarAnalisis()
        listAnalisis.Items.Clear()
        indexEntrevistas.Clear()
        'Dim i As Integer = 0
        'Dim j As Integer
        'For Each entrevista As Entrevista In Window.sistema.Entrevistas1
        '    If entrevista.Paciente1 = paciente.Ci1 And entrevista.Diagnostico1 IsNot Nothing Then
        '        If entrevista.Diagnostico1.SolicitudesAnalisis1.Count > 0 Then
        '            j = 0
        '            indexEntrevistas.Add(New List(Of Integer))
        '            For Each solicitudAnalisis As SolicitudAnalisis In entrevista.Diagnostico1.SolicitudesAnalisis1
        '                indexEntrevistas(i).Add(j)
        '                If solicitudAnalisis.Analisis1 IsNot Nothing Then
        '                    listAnalisis.Items.Add($"{solicitudAnalisis.Tipo1}")
        '                Else
        '                    listAnalisis.Items.Add($"{solicitudAnalisis.Tipo1} (Sin Resultado)")
        '                End If
        '                j += 1
        '            Next
        '        End If
        '    End If
        '    i += 1
        'Next
        For Each solicitudAnalisis As SolicitudAnalisis In Window.sistema.GetAnalisisPaciente(paciente.Ci1)
            If solicitudAnalisis.Analisis1 IsNot Nothing Then
                listAnalisis.Items.Add($"{solicitudAnalisis.Tipo1}")
            Else
                listAnalisis.Items.Add($"{solicitudAnalisis.Tipo1} (Sin Resultado)")
            End If
        Next
    End Sub

    Private Sub FormAnalisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paciente = Window.sistema.GetUsuario(Window.selectedUser)
        tituloListaAnalisis.Text = $"Análisis de {paciente.Apellido1}, {paciente.Nombre1}"
        actualizarAnalisis()
    End Sub

    Private Sub btnVerResultados_Click(sender As Object, e As EventArgs) Handles btnVerResultados.Click
        If listAnalisis.SelectedIndex > -1 Then
            'Dim otheri = 0
            'x = 0
            'For Each entrevista As Entrevista In Window.sistema.Entrevistas1
            '    If entrevista.Paciente1 = paciente.Ci1 And entrevista.Diagnostico1 IsNot Nothing Then
            '        y = 0
            '        For Each solicitudAnalisis As SolicitudAnalisis In entrevista.Diagnostico1.SolicitudesAnalisis1
            '            If otheri = listAnalisis.SelectedIndex Then
            '                Exit For
            '            End If
            '            y += 1
            '            otheri += 1
            '        Next
            '    End If
            '    If otheri = listAnalisis.SelectedIndex Then
            '        Exit For
            '    End If
            '    x += 1
            'Next

            'selectedAnalisis = Window.sistema.Entrevistas1(x).Diagnostico1.SolicitudesAnalisis1(y)
            selectedAnalisis = Window.sistema.GetAnalisisPaciente(paciente.Ci1)(listAnalisis.SelectedIndex)
            If selectedAnalisis.Analisis1 IsNot Nothing Then
                tituloAnalisis.Text = $"Análisis de {selectedAnalisis.Tipo1}"
                listDetallesAnalisis.Items.Clear()
                listDetallesAnalisis.Items.Add("Resultado: ")
                listDetallesAnalisis.Items.Add(selectedAnalisis.Analisis1.Resultado1)
                analisis.BringToFront()
            End If
        End If
    End Sub

    Private Sub backAnalisis_Click(sender As Object, e As EventArgs) Handles backAnalisis.Click
        listaAnalisis.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backAnalisis_MouseEnter(sender As Object, e As EventArgs) Handles backAnalisis.MouseEnter
        backAnalisis.Cursor = Cursors.Hand
    End Sub

    Private Sub btnIngresarResultados_Click(sender As Object, e As EventArgs) Handles btnIngresarResultados.Click
        If listAnalisis.SelectedIndex > -1 Then
            'Dim otheri = 0
            'x = 0
            'For Each entrevista As Entrevista In Window.sistema.Entrevistas1
            '    If entrevista.Paciente1 = paciente.Ci1 And entrevista.Diagnostico1 IsNot Nothing Then
            '        y = 0
            '        For Each solicitudAnalisis As SolicitudAnalisis In entrevista.Diagnostico1.SolicitudesAnalisis1
            '            If otheri = listAnalisis.SelectedIndex Then
            '                Exit For
            '            End If
            '            y += 1
            '            otheri += 1
            '        Next
            '    End If
            '    If otheri = listAnalisis.SelectedIndex Then
            '        Exit For
            '    End If
            '    x += 1
            'Next
            'selectedAnalisis = Window.sistema.Entrevistas1(x).Diagnostico1.SolicitudesAnalisis1(y)
            selectedAnalisis = Window.sistema.GetAnalisisPaciente(paciente.Ci1)(listAnalisis.SelectedIndex)
            If selectedAnalisis.Analisis1 Is Nothing Then
                tituloIngresarResultado.Text = $"Ingresar resultado de análisis de {selectedAnalisis.Tipo1}"
                ingresarResultado.BringToFront()
            End If
        End If
    End Sub

    Private Sub aceptarIngresarResultado_Click(sender As Object, e As EventArgs) Handles aceptarIngresarResultado.Click
        If tboxDetalles.Text = "" Then
            ingresarControlError.Text = "El campo no puede estar vacío"
        Else
            ingresarControlError.Text = ""
            selectedAnalisis.Analisis1 = New Analisis(tboxDetalles.Text)
            Window.sistema.AnadirResultadoAnalisis(Window.sistema.GetDiagnosticoPaciente(paciente.Ci1)(listAnalisis.SelectedIndex), selectedAnalisis, listAnalisis.SelectedIndex)
            actualizarAnalisis()
            listaAnalisis.BringToFront()
        End If

    End Sub

    Private Sub backIngresarResultado_Click(sender As Object, e As EventArgs) Handles backIngresarResultado.Click
        listaAnalisis.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub backIngresarResultado_MouseEnter(sender As Object, e As EventArgs) Handles backIngresarResultado.MouseEnter
        backIngresarResultado.Cursor = Cursors.Hand
    End Sub
End Class