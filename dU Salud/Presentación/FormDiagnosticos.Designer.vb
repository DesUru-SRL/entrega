<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDiagnosticos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.listaDiagnosticos = New System.Windows.Forms.Panel()
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.btnSolicitarAnalisis = New System.Windows.Forms.Button()
        Me.btnIngresarTratamiento = New System.Windows.Forms.Button()
        Me.btnVerDiagnostico = New System.Windows.Forms.Button()
        Me.listEntrevistas = New System.Windows.Forms.ListBox()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.tituloDiagnosticos = New System.Windows.Forms.Label()
        Me.diagnostico = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.listEntrevista = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.backDiagnostico = New System.Windows.Forms.Label()
        Me.tituloEntrevista = New System.Windows.Forms.Label()
        Me.solicitarAnalisis = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.solicitarAnalisisError = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tboxTipo = New System.Windows.Forms.TextBox()
        Me.aceptarSolicitarAnalisis = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.backSolicitarAnalisis = New System.Windows.Forms.Label()
        Me.tituloSolicitarAnalisis = New System.Windows.Forms.Label()
        Me.ingresarTratamiento = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ingresarTratamientoError = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.aceptarIngresarTratamiento = New System.Windows.Forms.Button()
        Me.tboxDetalles = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.backIngresarTratamiento = New System.Windows.Forms.Label()
        Me.tituloIngresarTratamiento = New System.Windows.Forms.Label()
        Me.listaDiagnosticos.SuspendLayout()
        Me.Panel67.SuspendLayout()
        Me.Panel68.SuspendLayout()
        Me.diagnostico.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.solicitarAnalisis.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.ingresarTratamiento.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'listaDiagnosticos
        '
        Me.listaDiagnosticos.Controls.Add(Me.Panel67)
        Me.listaDiagnosticos.Controls.Add(Me.Panel68)
        Me.listaDiagnosticos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listaDiagnosticos.Location = New System.Drawing.Point(0, 0)
        Me.listaDiagnosticos.Name = "listaDiagnosticos"
        Me.listaDiagnosticos.Size = New System.Drawing.Size(1200, 675)
        Me.listaDiagnosticos.TabIndex = 18
        '
        'Panel67
        '
        Me.Panel67.Controls.Add(Me.btnSolicitarAnalisis)
        Me.Panel67.Controls.Add(Me.btnIngresarTratamiento)
        Me.Panel67.Controls.Add(Me.btnVerDiagnostico)
        Me.Panel67.Controls.Add(Me.listEntrevistas)
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel67.Location = New System.Drawing.Point(0, 110)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(1200, 565)
        Me.Panel67.TabIndex = 2
        '
        'btnSolicitarAnalisis
        '
        Me.btnSolicitarAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSolicitarAnalisis.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnSolicitarAnalisis.FlatAppearance.BorderSize = 0
        Me.btnSolicitarAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolicitarAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitarAnalisis.ForeColor = System.Drawing.Color.White
        Me.btnSolicitarAnalisis.Location = New System.Drawing.Point(447, 451)
        Me.btnSolicitarAnalisis.Name = "btnSolicitarAnalisis"
        Me.btnSolicitarAnalisis.Size = New System.Drawing.Size(316, 44)
        Me.btnSolicitarAnalisis.TabIndex = 4
        Me.btnSolicitarAnalisis.Text = "Solicitar análisis"
        Me.btnSolicitarAnalisis.UseVisualStyleBackColor = False
        '
        'btnIngresarTratamiento
        '
        Me.btnIngresarTratamiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIngresarTratamiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnIngresarTratamiento.FlatAppearance.BorderSize = 0
        Me.btnIngresarTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarTratamiento.ForeColor = System.Drawing.Color.White
        Me.btnIngresarTratamiento.Location = New System.Drawing.Point(788, 452)
        Me.btnIngresarTratamiento.Name = "btnIngresarTratamiento"
        Me.btnIngresarTratamiento.Size = New System.Drawing.Size(316, 44)
        Me.btnIngresarTratamiento.TabIndex = 4
        Me.btnIngresarTratamiento.Text = "Ingresar tratamiento"
        Me.btnIngresarTratamiento.UseVisualStyleBackColor = False
        '
        'btnVerDiagnostico
        '
        Me.btnVerDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVerDiagnostico.BackColor = System.Drawing.Color.White
        Me.btnVerDiagnostico.FlatAppearance.BorderSize = 0
        Me.btnVerDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDiagnostico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVerDiagnostico.Location = New System.Drawing.Point(104, 451)
        Me.btnVerDiagnostico.Name = "btnVerDiagnostico"
        Me.btnVerDiagnostico.Size = New System.Drawing.Size(316, 44)
        Me.btnVerDiagnostico.TabIndex = 4
        Me.btnVerDiagnostico.Text = "Ver diagnóstico"
        Me.btnVerDiagnostico.UseVisualStyleBackColor = False
        '
        'listEntrevistas
        '
        Me.listEntrevistas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.listEntrevistas.BackColor = System.Drawing.Color.White
        Me.listEntrevistas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listEntrevistas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listEntrevistas.FormattingEnabled = True
        Me.listEntrevistas.ItemHeight = 29
        Me.listEntrevistas.Items.AddRange(New Object() {"Test 1", "Test 2", "Test 3", "Test 4", "Test 5", "Test 6", "Test 7", "Test 8", "Test 9", "Test 10"})
        Me.listEntrevistas.Location = New System.Drawing.Point(104, 15)
        Me.listEntrevistas.Name = "listEntrevistas"
        Me.listEntrevistas.Size = New System.Drawing.Size(1000, 408)
        Me.listEntrevistas.TabIndex = 0
        '
        'Panel68
        '
        Me.Panel68.Controls.Add(Me.tituloDiagnosticos)
        Me.Panel68.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel68.Location = New System.Drawing.Point(0, 0)
        Me.Panel68.Name = "Panel68"
        Me.Panel68.Size = New System.Drawing.Size(1200, 110)
        Me.Panel68.TabIndex = 0
        '
        'tituloDiagnosticos
        '
        Me.tituloDiagnosticos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloDiagnosticos.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloDiagnosticos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloDiagnosticos.Location = New System.Drawing.Point(0, 0)
        Me.tituloDiagnosticos.Name = "tituloDiagnosticos"
        Me.tituloDiagnosticos.Size = New System.Drawing.Size(1200, 110)
        Me.tituloDiagnosticos.TabIndex = 0
        Me.tituloDiagnosticos.Text = "Diagnosticos realizados a Nombre, Apellido"
        Me.tituloDiagnosticos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'diagnostico
        '
        Me.diagnostico.Controls.Add(Me.Panel2)
        Me.diagnostico.Controls.Add(Me.Panel3)
        Me.diagnostico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.diagnostico.Location = New System.Drawing.Point(0, 0)
        Me.diagnostico.Name = "diagnostico"
        Me.diagnostico.Size = New System.Drawing.Size(1200, 675)
        Me.diagnostico.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.listEntrevista)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 565)
        Me.Panel2.TabIndex = 2
        '
        'listEntrevista
        '
        Me.listEntrevista.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.listEntrevista.BackColor = System.Drawing.Color.White
        Me.listEntrevista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listEntrevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listEntrevista.FormattingEnabled = True
        Me.listEntrevista.ItemHeight = 33
        Me.listEntrevista.Items.AddRange(New Object() {"Test 1", "Test 2", "Test 3", "Test 4", "Test 5", "Test 6", "Test 7", "Test 8", "Test 9", "Test 10"})
        Me.listEntrevista.Location = New System.Drawing.Point(104, 15)
        Me.listEntrevista.Name = "listEntrevista"
        Me.listEntrevista.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listEntrevista.Size = New System.Drawing.Size(1000, 464)
        Me.listEntrevista.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.backDiagnostico)
        Me.Panel3.Controls.Add(Me.tituloEntrevista)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1200, 110)
        Me.Panel3.TabIndex = 0
        '
        'backDiagnostico
        '
        Me.backDiagnostico.BackColor = System.Drawing.Color.Transparent
        Me.backDiagnostico.Image = Global.dU_Salud.My.Resources.Resources.back
        Me.backDiagnostico.Location = New System.Drawing.Point(24, 26)
        Me.backDiagnostico.Name = "backDiagnostico"
        Me.backDiagnostico.Size = New System.Drawing.Size(73, 71)
        Me.backDiagnostico.TabIndex = 4
        '
        'tituloEntrevista
        '
        Me.tituloEntrevista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloEntrevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloEntrevista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloEntrevista.Location = New System.Drawing.Point(0, 0)
        Me.tituloEntrevista.Name = "tituloEntrevista"
        Me.tituloEntrevista.Size = New System.Drawing.Size(1200, 110)
        Me.tituloEntrevista.TabIndex = 0
        Me.tituloEntrevista.Text = "Entrevistas hechas a Nombre, Apellido"
        Me.tituloEntrevista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'solicitarAnalisis
        '
        Me.solicitarAnalisis.Controls.Add(Me.Panel4)
        Me.solicitarAnalisis.Controls.Add(Me.Panel5)
        Me.solicitarAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.solicitarAnalisis.Location = New System.Drawing.Point(0, 0)
        Me.solicitarAnalisis.Name = "solicitarAnalisis"
        Me.solicitarAnalisis.Size = New System.Drawing.Size(1200, 675)
        Me.solicitarAnalisis.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.solicitarAnalisisError)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.tboxTipo)
        Me.Panel4.Controls.Add(Me.aceptarSolicitarAnalisis)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 119)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1200, 556)
        Me.Panel4.TabIndex = 2
        '
        'solicitarAnalisisError
        '
        Me.solicitarAnalisisError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.solicitarAnalisisError.ForeColor = System.Drawing.Color.Red
        Me.solicitarAnalisisError.Location = New System.Drawing.Point(280, 260)
        Me.solicitarAnalisisError.Name = "solicitarAnalisisError"
        Me.solicitarAnalisisError.Size = New System.Drawing.Size(640, 20)
        Me.solicitarAnalisisError.TabIndex = 20
        Me.solicitarAnalisisError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(525, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 31)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tipo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tboxTipo
        '
        Me.tboxTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxTipo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tboxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxTipo.Location = New System.Drawing.Point(280, 180)
        Me.tboxTipo.Margin = New System.Windows.Forms.Padding(5)
        Me.tboxTipo.MaxLength = 32
        Me.tboxTipo.Name = "tboxTipo"
        Me.tboxTipo.Size = New System.Drawing.Size(640, 29)
        Me.tboxTipo.TabIndex = 11
        Me.tboxTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'aceptarSolicitarAnalisis
        '
        Me.aceptarSolicitarAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.aceptarSolicitarAnalisis.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.aceptarSolicitarAnalisis.FlatAppearance.BorderSize = 0
        Me.aceptarSolicitarAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarSolicitarAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptarSolicitarAnalisis.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.aceptarSolicitarAnalisis.Location = New System.Drawing.Point(280, 228)
        Me.aceptarSolicitarAnalisis.Name = "aceptarSolicitarAnalisis"
        Me.aceptarSolicitarAnalisis.Size = New System.Drawing.Size(640, 31)
        Me.aceptarSolicitarAnalisis.TabIndex = 10
        Me.aceptarSolicitarAnalisis.Text = "Aceptar"
        Me.aceptarSolicitarAnalisis.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.backSolicitarAnalisis)
        Me.Panel5.Controls.Add(Me.tituloSolicitarAnalisis)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1200, 119)
        Me.Panel5.TabIndex = 0
        '
        'backSolicitarAnalisis
        '
        Me.backSolicitarAnalisis.BackColor = System.Drawing.Color.Transparent
        Me.backSolicitarAnalisis.Image = Global.dU_Salud.My.Resources.Resources.back
        Me.backSolicitarAnalisis.Location = New System.Drawing.Point(24, 26)
        Me.backSolicitarAnalisis.Name = "backSolicitarAnalisis"
        Me.backSolicitarAnalisis.Size = New System.Drawing.Size(73, 71)
        Me.backSolicitarAnalisis.TabIndex = 4
        '
        'tituloSolicitarAnalisis
        '
        Me.tituloSolicitarAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloSolicitarAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloSolicitarAnalisis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloSolicitarAnalisis.Location = New System.Drawing.Point(0, 0)
        Me.tituloSolicitarAnalisis.Name = "tituloSolicitarAnalisis"
        Me.tituloSolicitarAnalisis.Size = New System.Drawing.Size(1200, 119)
        Me.tituloSolicitarAnalisis.TabIndex = 0
        Me.tituloSolicitarAnalisis.Text = "Solicitar análisis"
        Me.tituloSolicitarAnalisis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ingresarTratamiento
        '
        Me.ingresarTratamiento.Controls.Add(Me.Panel1)
        Me.ingresarTratamiento.Controls.Add(Me.Panel6)
        Me.ingresarTratamiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ingresarTratamiento.Location = New System.Drawing.Point(0, 0)
        Me.ingresarTratamiento.Name = "ingresarTratamiento"
        Me.ingresarTratamiento.Size = New System.Drawing.Size(1200, 675)
        Me.ingresarTratamiento.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ingresarTratamientoError)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.aceptarIngresarTratamiento)
        Me.Panel1.Controls.Add(Me.tboxDetalles)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 556)
        Me.Panel1.TabIndex = 2
        '
        'ingresarTratamientoError
        '
        Me.ingresarTratamientoError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingresarTratamientoError.ForeColor = System.Drawing.Color.Red
        Me.ingresarTratamientoError.Location = New System.Drawing.Point(280, 465)
        Me.ingresarTratamientoError.Name = "ingresarTratamientoError"
        Me.ingresarTratamientoError.Size = New System.Drawing.Size(640, 20)
        Me.ingresarTratamientoError.TabIndex = 20
        Me.ingresarTratamientoError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(520, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 31)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Detalles"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aceptarIngresarTratamiento
        '
        Me.aceptarIngresarTratamiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.aceptarIngresarTratamiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.aceptarIngresarTratamiento.FlatAppearance.BorderSize = 0
        Me.aceptarIngresarTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarIngresarTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptarIngresarTratamiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.aceptarIngresarTratamiento.Location = New System.Drawing.Point(280, 417)
        Me.aceptarIngresarTratamiento.Name = "aceptarIngresarTratamiento"
        Me.aceptarIngresarTratamiento.Size = New System.Drawing.Size(640, 31)
        Me.aceptarIngresarTratamiento.TabIndex = 10
        Me.aceptarIngresarTratamiento.Text = "Aceptar"
        Me.aceptarIngresarTratamiento.UseVisualStyleBackColor = False
        '
        'tboxDetalles
        '
        Me.tboxDetalles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tboxDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxDetalles.Location = New System.Drawing.Point(280, 84)
        Me.tboxDetalles.Margin = New System.Windows.Forms.Padding(5)
        Me.tboxDetalles.MaxLength = 0
        Me.tboxDetalles.Multiline = True
        Me.tboxDetalles.Name = "tboxDetalles"
        Me.tboxDetalles.Size = New System.Drawing.Size(640, 299)
        Me.tboxDetalles.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.backIngresarTratamiento)
        Me.Panel6.Controls.Add(Me.tituloIngresarTratamiento)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1200, 119)
        Me.Panel6.TabIndex = 0
        '
        'backIngresarTratamiento
        '
        Me.backIngresarTratamiento.BackColor = System.Drawing.Color.Transparent
        Me.backIngresarTratamiento.Image = Global.dU_Salud.My.Resources.Resources.back
        Me.backIngresarTratamiento.Location = New System.Drawing.Point(24, 26)
        Me.backIngresarTratamiento.Name = "backIngresarTratamiento"
        Me.backIngresarTratamiento.Size = New System.Drawing.Size(73, 71)
        Me.backIngresarTratamiento.TabIndex = 4
        '
        'tituloIngresarTratamiento
        '
        Me.tituloIngresarTratamiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloIngresarTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloIngresarTratamiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloIngresarTratamiento.Location = New System.Drawing.Point(0, 0)
        Me.tituloIngresarTratamiento.Name = "tituloIngresarTratamiento"
        Me.tituloIngresarTratamiento.Size = New System.Drawing.Size(1200, 119)
        Me.tituloIngresarTratamiento.TabIndex = 0
        Me.tituloIngresarTratamiento.Text = "Ingresar Tratamiento"
        Me.tituloIngresarTratamiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormDiagnosticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.listaDiagnosticos)
        Me.Controls.Add(Me.ingresarTratamiento)
        Me.Controls.Add(Me.solicitarAnalisis)
        Me.Controls.Add(Me.diagnostico)
        Me.Name = "FormDiagnosticos"
        Me.Text = "Diagnosticos"
        Me.listaDiagnosticos.ResumeLayout(False)
        Me.Panel67.ResumeLayout(False)
        Me.Panel68.ResumeLayout(False)
        Me.diagnostico.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.solicitarAnalisis.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ingresarTratamiento.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listaDiagnosticos As Panel
    Friend WithEvents Panel67 As Panel
    Friend WithEvents btnSolicitarAnalisis As Button
    Friend WithEvents btnIngresarTratamiento As Button
    Friend WithEvents btnVerDiagnostico As Button
    Friend WithEvents listEntrevistas As ListBox
    Friend WithEvents Panel68 As Panel
    Friend WithEvents tituloDiagnosticos As Label
    Friend WithEvents diagnostico As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents listEntrevista As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents backDiagnostico As Label
    Friend WithEvents tituloEntrevista As Label
    Friend WithEvents solicitarAnalisis As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents solicitarAnalisisError As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tboxTipo As TextBox
    Friend WithEvents aceptarSolicitarAnalisis As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents backSolicitarAnalisis As Label
    Friend WithEvents tituloSolicitarAnalisis As Label
    Friend WithEvents ingresarTratamiento As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents backIngresarTratamiento As Label
    Friend WithEvents tituloIngresarTratamiento As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ingresarTratamientoError As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents aceptarIngresarTratamiento As Button
    Friend WithEvents tboxDetalles As TextBox
End Class
