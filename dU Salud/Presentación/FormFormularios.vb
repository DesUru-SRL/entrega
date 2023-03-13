Public Class FormFormularios

    Dim glasgowEnabled As Boolean = False
    Dim fiebreEnabled As Boolean = False
    Dim dolorEnabled As Boolean = False
    Dim fisicoEnabled As Boolean = False


    Private Sub btnGlaslow_Click(sender As Object, e As EventArgs) Handles btnGlaslow.Click
        glaslow.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub btnGlaslow_MouseEnter(sender As Object, e As EventArgs) Handles btnGlaslow.MouseEnter
        btnGlaslow.Cursor = Cursors.Hand
    End Sub

    Private Sub btnFiebre_Click(sender As Object, e As EventArgs) Handles btnFiebre.Click
        fiebre.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub btnFiebre_MouseEnter(sender As Object, e As EventArgs) Handles btnFiebre.MouseEnter
        btnFiebre.Cursor = Cursors.Hand
    End Sub

    Private Sub btnDolor_Click(sender As Object, e As EventArgs) Handles btnDolor.Click
        dolor.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub btnDolor_MouseEnter(sender As Object, e As EventArgs) Handles btnDolor.MouseEnter
        btnDolor.Cursor = Cursors.Hand
    End Sub

    Private Sub btnFisico_Click(sender As Object, e As EventArgs) Handles btnFisico.Click
        fisico.BringToFront()
    End Sub
    ''MouseEnter
    Private Sub btnFisico_MouseEnter(sender As Object, e As EventArgs) Handles btnFisico.MouseEnter
        btnFisico.Cursor = Cursors.Hand
    End Sub

    Private Sub mainFormulariosAceptar_Click(sender As Object, e As EventArgs) Handles mainFormulariosAceptar.Click
        If glasgowEnabled Then
            FormEntrevista.entrevista.AnadirGlasgow(tboxROcular.Text, tboxRMotora.Text, tboxRVerbal.Text)
        End If
        If fisicoEnabled Then
            FormEntrevista.entrevista.AnadirFisico(boxPiel.Text, boxCuello.Text, boxLinfogag.Text, boxMamas.Text)
        End If
        If dolorEnabled Then
            FormEntrevista.entrevista.AnadirEVA(evaValor.Text)
        End If
        If fiebreEnabled Then
            FormEntrevista.entrevista.AnadirFiebre(tboxFiebre.Text)
        End If
        Close()
    End Sub

    Private Sub fiebreAceptar_Click(sender As Object, e As EventArgs) Handles fiebreAceptar.Click
        If tboxFiebre.Text = "" Then
            fiebreError.Text = "El campo no puede estar vacío"
        Else
            fiebreError.Text = ""
            fiebreEnabled = True
            mainFormularios.BringToFront()
        End If
    End Sub

    Private Sub glaslowAceptar_Click(sender As Object, e As EventArgs) Handles glaslowAceptar.Click
        If tboxROcular.Text = "" Or tboxRVerbal.Text = "" Or tboxRMotora.Text = "" Then
            glasgowError.Text = "Los campos no pueden estar vacíos"
        Else
            glasgowError.Text = ""
            glasgowEnabled = True
            mainFormularios.BringToFront()
        End If
    End Sub

    Private Sub fisicoAceptar_Click(sender As Object, e As EventArgs) Handles fisicoAceptar.Click
        If boxCuello.Text = "" Or boxLinfogag.Text = "" Or boxMamas.Text = "" Or boxPiel.Text = "" Then
            fisicoError.Text = "Los campos no pueden estar vacíos"
        Else
            fisicoError.Text = ""
            fisicoEnabled = True
            mainFormularios.BringToFront()
        End If
    End Sub

    Private Sub aceptarDolor_Click(sender As Object, e As EventArgs) Handles aceptarDolor.Click
        mainFormularios.BringToFront()
        dolorEnabled = True
    End Sub

    Private Sub TrackBarEVA_Scroll(sender As Object, e As EventArgs) Handles TrackBarEVA.Scroll
        evaValor.Text = TrackBarEVA.Value
    End Sub

    'Validaciones
    Private Sub tboxROcular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxROcular.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub tboxRMotora_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxRMotora.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub tboxRVerbal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxRVerbal.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

End Class