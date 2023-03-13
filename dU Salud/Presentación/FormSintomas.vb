Public Class FormSintomas

    Public sintomas As List(Of String) = New List(Of String)

    Private Sub aceptarAgregarSintoma_Click(sender As Object, e As EventArgs) Handles aceptarAgregarSintoma.Click
        FormEntrevista.sintomas = sintomas
        Close()
    End Sub

    Private Sub agregarSintoma_Click(sender As Object, e As EventArgs) Handles agregarSintoma.Click

        If tboxSintoma.Text = "" Then
            sintomaError.Text = "El campo no puede estar vacío"
        Else
            sintomaError.Text = ""
            sintomas.Add(tboxSintoma.Text)
            tboxSintoma.Clear()
        End If
    End Sub

End Class