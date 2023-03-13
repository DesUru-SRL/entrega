Public Class FormMotivo
    Private Sub aceptarAgregarMotivo_Click(sender As Object, e As EventArgs) Handles aceptarAgregarMotivo.Click
        If tboxMotivo.Text = "" Then
            motivoError.Text = "El campo no puede estar vacío"
        Else
            motivoError.Text = ""
            FormEntrevista.motivo = tboxMotivo.Text
            Close()
        End If
    End Sub
End Class