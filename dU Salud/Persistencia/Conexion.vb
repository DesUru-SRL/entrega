Imports System.Data
Imports System.Data.Odbc

Public Class Conexion
    Public con As OdbcConnection
    Public cmd As OdbcCommand
    Public da As OdbcDataAdapter
    Public ds As New DataSet


    Dim cad As String = "FILEDSN=c:\conn.dsn;Uid=informix;Pwd=informix"

    Public Sub registrarUsuario(usuario As Usuario)
        con = New OdbcConnection(cad)

        Try
            con.Open()

            cmd = New OdbcCommand("INSERT INTO persona VALUES(?, ?, ?, ?, ?, ?, ?)", con)
            cmd.Parameters.AddWithValue("@fechanac", usuario.Fecha_nacimiento1)
            cmd.Parameters.AddWithValue("@direccion", usuario.Direccion1)
            cmd.Parameters.AddWithValue("@nombre", usuario.Nombre1)
            cmd.Parameters.AddWithValue("@apellido", usuario.Apellido1)
            cmd.Parameters.AddWithValue("@contra", usuario.Contra1)
            cmd.Parameters.AddWithValue("@telefono", usuario.Telefono1)
            cmd.Parameters.AddWithValue("@ci", usuario.Ci1)

            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub registrarEntrevista(entrevista As Entrevista)
        con = New OdbcConnection(cad)

        Try
            con.Open()

            Dim datos As DataTable = New DataTable
            Dim num As Integer

            cmd = New OdbcCommand("SELECT MAX(cod) FROM formulario", con)
            cmd.ExecuteNonQuery()

            da = New OdbcDataAdapter(cmd)
            da.Fill(datos)

            If IsDBNull(datos.Rows(0)(0)) Then
                num = 0
            Else
                num = datos.Rows(0)(0)
            End If


            Dim colab As String = "F"
            If entrevista.Colabora1 Then
                colab = "T"
            End If

            cmd = New OdbcCommand("INSERT INTO entrevista VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", con)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@fecha", entrevista.Fecha1)
            cmd.Parameters.AddWithValue("@actitud", entrevista.Actitud1)
            cmd.Parameters.AddWithValue("@estado_nutricional", entrevista.EstadoNutricional1)
            cmd.Parameters.AddWithValue("@pulso", entrevista.Pulso1)
            cmd.Parameters.AddWithValue("@frecuencia_cardiaca", entrevista.FrecuenciaCardiaca1)
            cmd.Parameters.AddWithValue("@frecuencia_respiratoria", entrevista.FrecuenciaRespiratoria1)
            cmd.Parameters.AddWithValue("@motivo", entrevista.Motivo1)
            cmd.Parameters.AddWithValue("@estado_general", entrevista.EstadoGeneral1)
            cmd.Parameters.AddWithValue("@temperatura", entrevista.Temperatura1)
            cmd.Parameters.AddWithValue("@colabora", colab)

            cmd.ExecuteNonQuery()

            If entrevista.Glasgow1 IsNot Nothing Then
                cmd = New OdbcCommand("INSERT INTO formulario VALUES(?, ?, ?, ?)", con)
                cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
                cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
                cmd.Parameters.AddWithValue("@cod", num + 1)
                cmd.Parameters.AddWithValue("@fecha", entrevista.Fecha1)
                cmd.ExecuteNonQuery()

                cmd = New OdbcCommand("INSERT INTO glasgow VALUES(?, ?, ?, ?)", con)
                cmd.Parameters.AddWithValue("@cod", num + 1)
                cmd.Parameters.AddWithValue("@ocular", entrevista.Glasgow1.ReaccionOcular1)
                cmd.Parameters.AddWithValue("@verbal", entrevista.Glasgow1.ReaccionVisual1)
                cmd.Parameters.AddWithValue("@motora", entrevista.Glasgow1.ReaccionMotora1)
                cmd.ExecuteNonQuery()
            End If

            If entrevista.Eva1 IsNot Nothing Then
                cmd = New OdbcCommand("INSERT INTO formulario VALUES(?, ?, ?, ?)", con)
                cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
                cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
                cmd.Parameters.AddWithValue("@cod", num + 2)
                cmd.Parameters.AddWithValue("@fecha", entrevista.Fecha1)
                cmd.ExecuteNonQuery()

                cmd = New OdbcCommand("INSERT INTO dolor VALUES(?, ?)", con)
                cmd.Parameters.AddWithValue("@cod", num + 2)
                cmd.Parameters.AddWithValue("@valor", entrevista.Eva1.Valor1)
                cmd.ExecuteNonQuery()
            End If

            If entrevista.Fiebre1 IsNot Nothing Then
                cmd = New OdbcCommand("INSERT INTO formulario VALUES(?, ?, ?, ?)", con)
                cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
                cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
                cmd.Parameters.AddWithValue("@cod", num + 3)
                cmd.Parameters.AddWithValue("@fecha", entrevista.Fecha1)
                cmd.ExecuteNonQuery()

                cmd = New OdbcCommand("INSERT INTO fiebre VALUES(?, ?)", con)
                cmd.Parameters.AddWithValue("@cod", num + 3)
                cmd.Parameters.AddWithValue("@descripcion", entrevista.Fiebre1.Descripcion1)
                cmd.ExecuteNonQuery()
            End If

            If entrevista.Fisico1 IsNot Nothing Then
                cmd = New OdbcCommand("INSERT INTO formulario VALUES(?, ?, ?, ?)", con)
                cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
                cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
                cmd.Parameters.AddWithValue("@cod", num + 4)
                cmd.Parameters.AddWithValue("@fecha", entrevista.Fecha1)
                cmd.ExecuteNonQuery()

                cmd = New OdbcCommand("INSERT INTO fisico VALUES(?, ?, ?, ?, ?, ?)", con)
                cmd.Parameters.AddWithValue("@cod", num + 4)
                cmd.Parameters.AddWithValue("@piel", entrevista.Fisico1.Piel1)
                cmd.Parameters.AddWithValue("@bucofaringeo", "")
                cmd.Parameters.AddWithValue("@cuello", entrevista.Fisico1.Cuello1)
                cmd.Parameters.AddWithValue("@linfogaglionar", entrevista.Fisico1.Linfogag1)
                cmd.Parameters.AddWithValue("@mamas", entrevista.Fisico1.Mamas1)
                cmd.ExecuteNonQuery()
            End If

            If entrevista.Sintomas1 IsNot Nothing Then
                If entrevista.Sintomas1.Count > 0 Then
                    For Each sintoma As String In entrevista.Sintomas1
                        cmd = New OdbcCommand("INSERT INTO sintomas VALUES(?, ?, ?, ?)", con)
                        cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
                        cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
                        cmd.Parameters.AddWithValue("@fecha", entrevista.Fecha1)
                        cmd.Parameters.AddWithValue("@sintoma", sintoma)
                        cmd.ExecuteNonQuery()
                    Next
                End If

            End If


            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub registrarAdministrador(admin As Usuario)
        con = New OdbcConnection(cad)

        Try
            con.Open()

            cmd = New OdbcCommand("INSERT INTO administrador VALUES(?)", con)
            cmd.Parameters.AddWithValue("@ci", admin.Ci1)

            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub registrarMedico(medico As Usuario, admin As String)
        con = New OdbcConnection(cad)

        Try
            con.Open()

            cmd = New OdbcCommand("INSERT INTO empleado VALUES(?,?)", con)
            cmd.Parameters.AddWithValue("@ci", medico.Ci1)
            cmd.Parameters.AddWithValue("@cargo", "Medico")

            cmd.ExecuteNonQuery()


            cmd = New OdbcCommand("INSERT INTO agrega_empleado VALUES(?,?,?)", con)
            cmd.Parameters.AddWithValue("@empleado", medico.Ci1)
            cmd.Parameters.AddWithValue("@administrador", admin)
            cmd.Parameters.AddWithValue("@fecha", Now.ToString("yyyy-MM-dd"))

            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub registrarAuxiliar(auxiliar As Usuario, admin As String)
        con = New OdbcConnection(cad)

        Try
            con.Open()

            cmd = New OdbcCommand("INSERT INTO empleado VALUES(?,?)", con)
            cmd.Parameters.AddWithValue("@ci", auxiliar.Ci1)
            cmd.Parameters.AddWithValue("@cargo", "Auxiliar")

            cmd.ExecuteNonQuery()


            cmd = New OdbcCommand("INSERT INTO agrega_empleado VALUES(?,?,?)", con)
            cmd.Parameters.AddWithValue("@empleado", auxiliar.Ci1)
            cmd.Parameters.AddWithValue("@administrador", admin)
            cmd.Parameters.AddWithValue("@fecha", Now.ToString("yyyy-MM-dd"))

            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub registrarPaciente(paciente As Usuario)
        con = New OdbcConnection(cad)

        Try
            con.Open()

            cmd = New OdbcCommand("INSERT INTO paciente VALUES(?)", con)
            cmd.Parameters.AddWithValue("@ci", paciente.Ci1)

            cmd.ExecuteNonQuery()

            cmd = New OdbcCommand("INSERT INTO paciente_estado VALUES(?,?,?)", con)
            cmd.Parameters.AddWithValue("@ci", paciente.Ci1)
            cmd.Parameters.AddWithValue("@fecha", Now.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@estado", 0)

            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub cambiarEstado(paciente As String, estado As Integer)
        con = New OdbcConnection(cad)

        Try
            con.Open()

            cmd = New OdbcCommand("INSERT INTO paciente_estado VALUES(?,?,?)", con)
            cmd.Parameters.AddWithValue("@ci", paciente)
            cmd.Parameters.AddWithValue("@fecha", Now.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@estado", estado)

            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub anadirControl(entrevista As Entrevista)
        con = New OdbcConnection(cad)

        Try
            con.Open()

            Dim datos As DataTable = New DataTable
            Dim num As Integer

            cmd = New OdbcCommand("SELECT MAX(cod) FROM control", con)
            cmd.ExecuteNonQuery()

            da = New OdbcDataAdapter(cmd)
            da.Fill(datos)

            If IsDBNull(datos.Rows(0)(0)) Then
                num = 0
            Else
                num = datos.Rows(0)(0)
            End If

            Dim datos2 As DataTable = New DataTable
            Dim plan As Integer

            cmd = New OdbcCommand("SELECT cod FROM plan WHERE paciente = ? AND empleado = ? AND fecha_entrevista = ?", con)
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
            cmd.Parameters.AddWithValue("@fecha_entrevista", entrevista.Fecha1.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.ExecuteNonQuery()

            da = New OdbcDataAdapter(cmd)
            da.Fill(datos2)

            plan = datos2.Rows(0)(0)

            cmd = New OdbcCommand("INSERT INTO control VALUES(?,?,?,?,?,?,?)", con)
            cmd.Parameters.AddWithValue("@cod", num + 1)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@fecha_entrevista", entrevista.Fecha1.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@plan", plan)
            cmd.Parameters.AddWithValue("@detalles", entrevista.Plan1.Control1(entrevista.Plan1.Control1.Count - 1).Detalles1)
            cmd.Parameters.AddWithValue("@fecha", Now.ToString("yyyy-MM-dd HH:mm:ss"))

            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub diagnosticar(entrevista As Entrevista)
        con = New OdbcConnection(cad)

        Try
            con.Open()

            Dim datos As DataTable = New DataTable
            Dim num As Integer

            cmd = New OdbcCommand("SELECT MAX(cod) FROM diagnostico", con)
            cmd.ExecuteNonQuery()

            da = New OdbcDataAdapter(cmd)
            da.Fill(datos)

            If IsDBNull(datos.Rows(0)(0)) Then
                num = 0
            Else
                num = datos.Rows(0)(0)
            End If

            cmd = New OdbcCommand("INSERT INTO diagnostico VALUES(?,?,?,?,?,?,?)", con)
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@fecha_entrevista", entrevista.Fecha1.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@tipo", entrevista.Diagnostico1.Tipo1)
            cmd.Parameters.AddWithValue("@detalle", entrevista.Diagnostico1.Detalles1)
            cmd.Parameters.AddWithValue("@fecha", Now.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@cod", num + 1)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)

            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub anadirResultadoAnalisis(entrevista As Entrevista, solAnalisis As SolicitudAnalisis, index As Integer)
        con = New OdbcConnection(cad)

        Try
            con.Open()

            Dim datos As DataTable = New DataTable
            Dim num As Integer

            cmd = New OdbcCommand("SELECT MAX(cod) FROM resultado_analisis", con)
            cmd.ExecuteNonQuery()

            da = New OdbcDataAdapter(cmd)
            da.Fill(datos)

            If IsDBNull(datos.Rows(0)(0)) Then
                num = 0
            Else
                num = datos.Rows(0)(0)
            End If

            Dim datos2 As DataTable = New DataTable
            Dim cod As Integer
            Dim diag As Integer
            cmd = New OdbcCommand("SELECT cod, diagnostico FROM solicitud_analisis WHERE empleado = ? AND paciente = ? AND fecha_entrevista = ? AND tipo = ?", con)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@fecha_entrevista", entrevista.Fecha1.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@tipo", solAnalisis.Tipo1)
            cmd.ExecuteNonQuery()

            da = New OdbcDataAdapter(cmd)
            da.Fill(datos2)

            If IsDBNull(datos2.Rows(0)(0)) Then
                cod = 0
            Else
                cod = datos2.Rows(0)(0)
                diag = datos2.Rows(0)(1)
            End If

            cmd = New OdbcCommand("INSERT INTO resultado_analisis VALUES(?,?,?,?,?,?,?,?)", con)
            cmd.Parameters.AddWithValue("@cod", num + 1)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@fecha_entrevista", entrevista.Fecha1.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@diagnostico", diag)
            cmd.Parameters.AddWithValue("@solicitud", cod)
            cmd.Parameters.AddWithValue("@detalles", solAnalisis.Analisis1.Resultado1)
            cmd.Parameters.AddWithValue("@fecha", Now.ToString("yyyy-MM-dd HH:mm:ss"))

            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub anadirTratamiento(entrevista As Entrevista)
        con = New OdbcConnection(cad)

        Try
            con.Open()

            Dim datos As DataTable = New DataTable
            Dim num As Integer

            cmd = New OdbcCommand("SELECT MAX(cod) FROM plan", con)
            cmd.ExecuteNonQuery()

            da = New OdbcDataAdapter(cmd)
            da.Fill(datos)

            If IsDBNull(datos.Rows(0)(0)) Then
                num = 0
            Else
                num = datos.Rows(0)(0)
            End If

            cmd = New OdbcCommand("INSERT INTO plan VALUES(?,?,?,?,?,?)", con)
            cmd.Parameters.AddWithValue("@cod", num + 1)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@fecha_entrevista", entrevista.Fecha1.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@detalles", entrevista.Plan1.Detalles1)
            cmd.Parameters.AddWithValue("@fecha", Now.ToString("yyyy-MM-dd HH:mm:ss"))

            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub solicitarAnalisis(entrevista As Entrevista)
        con = New OdbcConnection(cad)

        Try
            con.Open()

            Dim datos As DataTable = New DataTable
            Dim num As Integer

            cmd = New OdbcCommand("SELECT MAX(cod) FROM solicitud_analisis", con)
            cmd.ExecuteNonQuery()

            da = New OdbcDataAdapter(cmd)
            da.Fill(datos)

            If IsDBNull(datos.Rows(0)(0)) Then
                num = 0
            Else
                num = datos.Rows(0)(0)
            End If

            Dim datos2 As DataTable = New DataTable
            Dim diagnostico As Integer

            cmd = New OdbcCommand("SELECT cod FROM diagnostico WHERE paciente = ? AND empleado = ? AND fecha_entrevista = ?", con)
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
            cmd.Parameters.AddWithValue("@fecha_entrevista", entrevista.Fecha1.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.ExecuteNonQuery()

            da = New OdbcDataAdapter(cmd)
            da.Fill(datos2)

            diagnostico = datos2.Rows(0)(0)

            cmd = New OdbcCommand("INSERT INTO solicitud_analisis VALUES(?,?,?,?,?,?)", con)
            cmd.Parameters.AddWithValue("@cod", num + 1)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@fecha_entrevista", entrevista.Fecha1.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@diagnostico", diagnostico)
            cmd.Parameters.AddWithValue("@tipo", entrevista.Diagnostico1.SolicitudesAnalisis1(entrevista.Diagnostico1.SolicitudesAnalisis1.Count - 1).Tipo1)

            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Public Sub registrarAlu(alu As Alumno)
    '    con = New OdbcConnection(cad)

    '    Try
    '        con.Open()

    '        cmd = New OdbcCommand("Insert into usuario values(@codAlu, @nom, @foto,@casado,@presente)", con)
    '        cmd.Parameters.AddWithValue("@codAlu", alu.CodAlu)
    '        cmd.Parameters.AddWithValue("@nom", alu.Nombre)
    '        cmd.Parameters.AddWithValue("@foto", alu.Imagen)
    '        cmd.Parameters.AddWithValue("@casado", alu.Casado)
    '        cmd.Parameters.AddWithValue("@soltero", alu.Presente)

    '        cmd.ExecuteNonQuery()
    '        con.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try


    'End Sub

    'Public Sub editarAlumno(alu As Alumno)
    '    con = New OdbcConnection(cad)
    '    Try
    '        con.Open()
    '        cmd = New OdbcCommand("Update usuario
    '                              set codAlu = @codAlu,
    '                                  nombre = @nombre,
    '                                  foto = @foto
    '                              Where codAlu = @codAlu", con
    '                                  )
    '        cmd.Parameters.AddWithValue("@codAlu", alu.CodAlu)
    '        cmd.Parameters.AddWithValue("@nombre", alu.Nombre)
    '        cmd.Parameters.AddWithValue("@foto", alu.Imagen)

    '        cmd.ExecuteNonQuery()
    '        con.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Public Function mostrarAlumnos() As DataTable
    '    con = New OdbcConnection(cad)
    '    Dim alumnos As DataTable
    '    Try
    '        con.Open()

    '        cmd = New OdbcCommand("Select * From usuario", con)
    '        cmd.ExecuteNonQuery()

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    da = New OdbcDataAdapter(cmd)
    '    alumnos = New DataTable
    '    da.Fill(alumnos)
    '    con.Close()
    '    Return alumnos
    'End Function

    Public Function obtenerUsuarios() As List(Of Usuario)
        con = New OdbcConnection(cad)
        Dim usuarios As DataTable = New DataTable
        Dim listaUsuarios As List(Of Usuario) = New List(Of Usuario)
        Try
            con.Open()

            cmd = New OdbcCommand("SELECT * FROM persona", con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        da = New OdbcDataAdapter(cmd)
        da.Fill(usuarios)
        con.Close()


        If usuarios.Rows.Count > 0 Then
            For i As Integer = 0 To usuarios.Rows.Count - 1
                ''Dim DataType() As String = myTableData.Rows(i).Item(1)
                listaUsuarios.Add(New Usuario(usuarios.Rows(i)(6), usuarios.Rows(i)(2), usuarios.Rows(i)(3), usuarios.Rows(i)(4), usuarios.Rows(i)(5), usuarios.Rows(i)(1), usuarios.Rows(i)(0)))
            Next
        End If

        Return listaUsuarios
    End Function

    Public Function obtenerPacientes() As List(Of Paciente)
        con = New OdbcConnection(cad)
        Dim pacientes As DataTable = New DataTable
        Dim listaPacientes As List(Of Paciente) = New List(Of Paciente)
        Try
            con.Open()

            cmd = New OdbcCommand("SELECT paciente, estado FROM paciente_estado WHERE NOT EXISTS ( SELECT * FROM paciente_estado AS p WHERE p.paciente = paciente_estado.paciente AND p.fecha > paciente_estado.fecha )", con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        da = New OdbcDataAdapter(cmd)
        da.Fill(pacientes)
        con.Close()


        If pacientes.Rows.Count > 0 Then
            For i As Integer = 0 To pacientes.Rows.Count - 1
                listaPacientes.Add(New Paciente(pacientes.Rows(i)(0), pacientes.Rows(i)(1)))
            Next
        End If

        Return listaPacientes
    End Function

    Public Function obtenerMedicos() As List(Of String)
        con = New OdbcConnection(cad)
        Dim medicos As DataTable = New DataTable
        Dim listaMedicos As List(Of String) = New List(Of String)
        Try
            con.Open()

            cmd = New OdbcCommand("SELECT ci FROM empleado WHERE cargo = 'Medico'", con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        da = New OdbcDataAdapter(cmd)
        da.Fill(medicos)
        con.Close()


        If medicos.Rows.Count > 0 Then
            For i As Integer = 0 To medicos.Rows.Count - 1
                listaMedicos.Add(medicos.Rows(i)(0))
            Next
        End If

        Return listaMedicos
    End Function

    Public Function obtenerAuxiliares() As List(Of String)
        con = New OdbcConnection(cad)
        Dim auxiliares As DataTable = New DataTable
        Dim listaAuxiliares As List(Of String) = New List(Of String)
        Try
            con.Open()

            cmd = New OdbcCommand("SELECT ci FROM empleado WHERE cargo = 'Auxiliar'", con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        da = New OdbcDataAdapter(cmd)
        da.Fill(auxiliares)
        con.Close()


        If auxiliares.Rows.Count > 0 Then
            For i As Integer = 0 To auxiliares.Rows.Count - 1
                listaAuxiliares.Add(auxiliares.Rows(i)(0))
            Next
        End If

        Return listaAuxiliares
    End Function

    Public Function obtenerDiagnostico(entrevista As Entrevista) As Diagnostico
        con = New OdbcConnection(cad)
        Dim datos As DataTable = New DataTable
        Dim diagnostico As Diagnostico

        Try
            con.Open()

            cmd = New OdbcCommand("SELECT tipo, detalle FROM diagnostico WHERE fecha_entrevista = ? AND paciente = ? AND empleado = ?", con)
            cmd.Parameters.AddWithValue("@fecha_entrevista", entrevista.Fecha1.ToString("yyyy-MM-dd HH:mm:ss"))
            'MsgBox(entrevista.Fecha1.ToString("MM/dd/yyyy HH:mm:ss"))
            'cmd.Parameters.AddWithValue("@fecha_entrevista", Now.ToString("MM/dd/yyyy HH:mm:ss"))
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        da = New OdbcDataAdapter(cmd)
        da.Fill(datos)
        con.Close()

        If datos.Rows.Count > 0 Then
            diagnostico = New Diagnostico(datos.Rows(0)(0), datos.Rows(0)(1))
        End If

        Return diagnostico
    End Function

    Public Function obtenerPlan(entrevista As Entrevista) As Plan
        con = New OdbcConnection(cad)
        Dim datos As DataTable = New DataTable
        Dim plan As Plan

        Try
            con.Open()

            cmd = New OdbcCommand("SELECT detalles FROM plan WHERE fecha_entrevista = ? AND paciente = ? AND empleado = ?", con)
            cmd.Parameters.AddWithValue("@fecha_entrevista", entrevista.Fecha1.ToString("yyyy-MM-dd HH:mm:ss"))
            'MsgBox(entrevista.Fecha1.ToString("MM/dd/yyyy HH:mm:ss"))
            'cmd.Parameters.AddWithValue("@fecha_entrevista", Now.ToString("MM/dd/yyyy HH:mm:ss"))
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        da = New OdbcDataAdapter(cmd)
        da.Fill(datos)
        con.Close()

        If datos.Rows.Count > 0 Then
            plan = New Plan(datos.Rows(0)(0))
        End If

        Return plan
    End Function

    Public Function obtenerSolicitudesAnalisis(entrevista As Entrevista) As List(Of SolicitudAnalisis)
        con = New OdbcConnection(cad)
        Dim datos As DataTable = New DataTable
        Dim sanal As List(Of SolicitudAnalisis) = New List(Of SolicitudAnalisis)

        Try
            con.Open()

            cmd = New OdbcCommand("SELECT tipo FROM solicitud_analisis WHERE fecha_entrevista = ? AND paciente = ? AND empleado = ?", con)
            cmd.Parameters.AddWithValue("@fecha_entrevista", entrevista.Fecha1.ToString("yyyy-MM-dd HH:mm:ss"))
            'MsgBox(entrevista.Fecha1.ToString("MM/dd/yyyy HH:mm:ss"))
            'cmd.Parameters.AddWithValue("@fecha_entrevista", Now.ToString("MM/dd/yyyy HH:mm:ss"))
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        da = New OdbcDataAdapter(cmd)
        da.Fill(datos)
        con.Close()

        If datos.Rows.Count > 0 Then
            For i As Integer = 0 To datos.Rows.Count - 1
                sanal.Add(New SolicitudAnalisis(datos.Rows(i)(0)))
            Next
        End If

        Return sanal
    End Function

    Public Function obtenerControl(entrevista As Entrevista) As List(Of ControlPlan)
        con = New OdbcConnection(cad)
        Dim datos As DataTable = New DataTable
        Dim control As List(Of ControlPlan) = New List(Of ControlPlan)

        Try
            con.Open()

            cmd = New OdbcCommand("SELECT detalles FROM control WHERE fecha_entrevista = ? AND paciente = ? AND empleado = ?", con)
            cmd.Parameters.AddWithValue("@fecha_entrevista", entrevista.Fecha1.ToString("yyyy-MM-dd HH:mm:ss"))
            'MsgBox(entrevista.Fecha1.ToString("MM/dd/yyyy HH:mm:ss"))
            'cmd.Parameters.AddWithValue("@fecha_entrevista", Now.ToString("MM/dd/yyyy HH:mm:ss"))
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        da = New OdbcDataAdapter(cmd)
        da.Fill(datos)
        con.Close()

        If datos.Rows.Count > 0 Then
            For i As Integer = 0 To datos.Rows.Count - 1
                control.Add(New ControlPlan(datos.Rows(i)(0)))
            Next
        End If

        Return control
    End Function

    Public Function obtenerAnalisis(entrevista As Entrevista, solicitudAnalisis As SolicitudAnalisis) As Analisis
        con = New OdbcConnection(cad)
        Dim datos As DataTable = New DataTable
        Dim analisis As Analisis

        Try
            con.Open()

            cmd = New OdbcCommand("SELECT resultado_analisis.detalles FROM resultado_analisis, solicitud_analisis WHERE resultado_analisis.fecha_entrevista = ? AND resultado_analisis.paciente = ? AND resultado_analisis.empleado = ? AND resultado_analisis.solicitud = solicitud_analisis.cod AND solicitud_analisis.tipo = ?", con)
            cmd.Parameters.AddWithValue("@fecha_entrevista", entrevista.Fecha1.ToString("yyyy-MM-dd HH:mm:ss"))
            'MsgBox(entrevista.Fecha1.ToString("MM/dd/yyyy HH:mm:ss"))
            'cmd.Parameters.AddWithValue("@fecha_entrevista", Now.ToString("MM/dd/yyyy HH:mm:ss"))
            cmd.Parameters.AddWithValue("@paciente", entrevista.Paciente1)
            cmd.Parameters.AddWithValue("@empleado", entrevista.Empleado1)
            cmd.Parameters.AddWithValue("@tipo", solicitudAnalisis.Tipo1)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        da = New OdbcDataAdapter(cmd)
        da.Fill(datos)
        con.Close()

        If datos.Rows.Count > 0 Then
            analisis = New Analisis(datos.Rows(0)(0))
        End If

        Return analisis
    End Function

    Public Function obtenerAdministradores() As List(Of String)
        con = New OdbcConnection(cad)
        Dim administradores As DataTable = New DataTable
        Dim listaAdministradores As List(Of String) = New List(Of String)
        Try
            con.Open()

            cmd = New OdbcCommand("SELECT ci FROM administrador", con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        da = New OdbcDataAdapter(cmd)
        da.Fill(administradores)
        con.Close()


        If administradores.Rows.Count > 0 Then
            For i As Integer = 0 To administradores.Rows.Count - 1
                listaAdministradores.Add(administradores.Rows(i)(0))
            Next
        End If

        Return listaAdministradores
    End Function

    Public Function obtenerEntrevistas() As List(Of Entrevista)
        con = New OdbcConnection(cad)
        Dim entrevistas As DataTable = New DataTable
        Dim listaEntrevistas As List(Of Entrevista) = New List(Of Entrevista)
        Try
            con.Open()

            cmd = New OdbcCommand("SELECT fecha, colabora, actitud, estado_nutricional, temperatura, pulso, frecuencia_cardiaca, frecuencia_respiratoria, motivo, estado_general, paciente, empleado FROM entrevista", con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        da = New OdbcDataAdapter(cmd)
        da.Fill(entrevistas)
        con.Close()

        If entrevistas.Rows.Count > 0 Then

            Dim colabora As Boolean = False


            For i As Integer = 0 To entrevistas.Rows.Count - 1
                Dim datos As DataTable = New DataTable
                Dim sintomas As List(Of String) = New List(Of String)
                Try
                    con.Open()

                    cmd = New OdbcCommand("SELECT sintoma FROM sintoma WHERE fecha_entrevista = ? AND paciente = ? AND empleado = ?", con)
                    cmd.Parameters.AddWithValue("@fecha_entrevista", entrevistas.Rows(i)(0))
                    'MsgBox(entrevista.Fecha1.ToString("MM/dd/yyyy HH:mm:ss"))
                    'cmd.Parameters.AddWithValue("@fecha_entrevista", Now.ToString("MM/dd/yyyy HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@paciente", entrevistas.Rows(i)(10))
                    cmd.Parameters.AddWithValue("@empleado", entrevistas.Rows(i)(11))
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                da = New OdbcDataAdapter(cmd)
                da.Fill(datos)
                If datos.Rows.Count > 0 Then
                    For j As Integer = 0 To datos.Rows.Count - 1
                        sintomas.Add(datos.Rows(j)(0))
                    Next
                End If
                con.Close()
                colabora = entrevistas.Rows(i)(1) = "T"
                listaEntrevistas.Add(New Entrevista(
                                     entrevistas.Rows(i)(0),
                                     colabora,
                                     entrevistas.Rows(i)(2),
                                     entrevistas.Rows(i)(3),
                                     entrevistas.Rows(i)(4),
                                     entrevistas.Rows(i)(5),
                                     entrevistas.Rows(i)(6),
                                     entrevistas.Rows(i)(7),
                                     entrevistas.Rows(i)(8),
                                     entrevistas.Rows(i)(9),
                                     sintomas,
                                     entrevistas.Rows(i)(10),
                                     entrevistas.Rows(i)(11))) 'entrevistas.Rows(i)(0)
                Try
                    con.Open()


                    cmd = New OdbcCommand("SELECT cod FROM formulario WHERE paciente = ? AND empleado = ? AND fecha = ?", con)
                    cmd.Parameters.AddWithValue("@paciente", entrevistas.Rows(i)(10))
                    cmd.Parameters.AddWithValue("@empleado", entrevistas.Rows(i)(11))
                    cmd.Parameters.AddWithValue("@fecha", entrevistas.Rows(i)(0))
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Dim datos2 As DataTable = New DataTable
                da = New OdbcDataAdapter(cmd)
                da.Fill(datos2)
                If datos2.Rows.Count > 0 Then
                    For j As Integer = 0 To datos2.Rows.Count - 1

                        Dim datos3 As DataTable = New DataTable
                        cmd = New OdbcCommand("SELECT ocular, verbal, motora FROM glasgow WHERE cod = ?", con)
                        cmd.Parameters.AddWithValue("@cod", datos2.Rows(j)(0))
                        cmd.ExecuteNonQuery()
                        da = New OdbcDataAdapter(cmd)
                        da.Fill(datos3)

                        If datos3.Rows.Count > 0 Then
                            listaEntrevistas(i).AnadirGlasgow(datos3.Rows(0)(0), datos3.Rows(0)(1), datos3.Rows(0)(2))
                        End If

                        Dim datos4 As DataTable = New DataTable
                        cmd = New OdbcCommand("SELECT valor FROM dolor WHERE cod = ?", con)
                        cmd.Parameters.AddWithValue("@cod", datos2.Rows(j)(0))
                        cmd.ExecuteNonQuery()
                        da = New OdbcDataAdapter(cmd)
                        da.Fill(datos4)
                        If datos4.Rows.Count > 0 Then
                            listaEntrevistas(i).AnadirEVA(datos4.Rows(0)(0))
                        End If

                        Dim datos5 As DataTable = New DataTable
                        cmd = New OdbcCommand("SELECT descripcion FROM fiebre WHERE cod = ?", con)
                        cmd.Parameters.AddWithValue("@cod", datos2.Rows(j)(0))
                        cmd.ExecuteNonQuery()
                        da = New OdbcDataAdapter(cmd)
                        da.Fill(datos5)
                        If datos5.Rows.Count > 0 Then
                            listaEntrevistas(i).AnadirFiebre(datos5.Rows(0)(0))
                        End If

                        Dim datos6 As DataTable = New DataTable
                        cmd = New OdbcCommand("SELECT piel, cuello, linfogaglionar, mamas FROM fisico WHERE cod = ?", con)
                        cmd.Parameters.AddWithValue("@cod", datos2.Rows(j)(0))
                        cmd.ExecuteNonQuery()
                        da = New OdbcDataAdapter(cmd)
                        da.Fill(datos6)
                        If datos6.Rows.Count > 0 Then
                            listaEntrevistas(i).AnadirFisico(datos6.Rows(0)(0), datos6.Rows(0)(1), datos6.Rows(0)(2), datos6.Rows(0)(3))
                        End If
                    Next
                End If



                con.Close()
            Next
        End If

        Return listaEntrevistas
    End Function

    Public Sub bajaPaciente(paciente As String)
        con = New OdbcConnection(cad)

        Try
            con.Open()

            cmd = New OdbcCommand("DELETE FROM paciente WHERE ci = ?", con)
            cmd.Parameters.AddWithValue("@ci", paciente)

            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
