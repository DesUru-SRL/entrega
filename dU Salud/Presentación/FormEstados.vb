Public Class FormEstados
    Private Sub FormEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Parent = Label1
        Label3.Parent = Label1
        Label4.Parent = Label1
        Label5.Parent = Label1
        Label6.Parent = Label1
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Window.sistema.CambiarEstado(Window.selectedUser, 0)
        Window.auxiliarActualizarEstadoPaciente()
        Window.medicoActualizarEstadoPaciente()
    End Sub
    ''MouseEnter
    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.Cursor = Cursors.Hand
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Window.sistema.CambiarEstado(Window.selectedUser, 1)
        Window.auxiliarActualizarEstadoPaciente()
        Window.medicoActualizarEstadoPaciente()
    End Sub
    ''MouseEnter
    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.Cursor = Cursors.Hand
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Window.sistema.CambiarEstado(Window.selectedUser, 2)
        Window.auxiliarActualizarEstadoPaciente()
        Window.medicoActualizarEstadoPaciente()
    End Sub
    ''MouseEnter
    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.Cursor = Cursors.Hand
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Window.sistema.CambiarEstado(Window.selectedUser, 3)
        Window.auxiliarActualizarEstadoPaciente()
        Window.medicoActualizarEstadoPaciente()
    End Sub
    ''MouseEnter
    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.Cursor = Cursors.Hand
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Window.sistema.CambiarEstado(Window.selectedUser, 4)
        Window.auxiliarActualizarEstadoPaciente()
        Window.medicoActualizarEstadoPaciente()
    End Sub
    ''MouseEnter
    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.Cursor = Cursors.Hand
    End Sub


End Class