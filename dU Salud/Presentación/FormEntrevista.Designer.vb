<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEntrevista
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
        Me.loginPersonal = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.estadoNutricional = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.actitud = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gradoColaboracion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pulso = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.estadoGeneral = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.agregarSintomas = New System.Windows.Forms.Button()
        Me.agregarFormularios = New System.Windows.Forms.Button()
        Me.agregarMotivo = New System.Windows.Forms.Button()
        Me.frecuenciaCardiaca = New System.Windows.Forms.TextBox()
        Me.frecuenciaRespiratoria = New System.Windows.Forms.TextBox()
        Me.temperatura = New System.Windows.Forms.TextBox()
        Me.labelLoginPersonalSquare = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.tituloEntrevista = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.entrevistaError = New System.Windows.Forms.Label()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.loginPersonal.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginPersonal
        '
        Me.loginPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.loginPersonal.Controls.Add(Me.Panel13)
        Me.loginPersonal.Controls.Add(Me.Panel16)
        Me.loginPersonal.Controls.Add(Me.Panel17)
        Me.loginPersonal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loginPersonal.Location = New System.Drawing.Point(0, 0)
        Me.loginPersonal.Name = "loginPersonal"
        Me.loginPersonal.Size = New System.Drawing.Size(1200, 675)
        Me.loginPersonal.TabIndex = 6
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Panel15)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.ForeColor = System.Drawing.Color.Coral
        Me.Panel13.Location = New System.Drawing.Point(0, 99)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1200, 478)
        Me.Panel13.TabIndex = 2
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.estadoNutricional)
        Me.Panel15.Controls.Add(Me.Label13)
        Me.Panel15.Controls.Add(Me.Label11)
        Me.Panel15.Controls.Add(Me.Label4)
        Me.Panel15.Controls.Add(Me.actitud)
        Me.Panel15.Controls.Add(Me.Label10)
        Me.Panel15.Controls.Add(Me.Label5)
        Me.Panel15.Controls.Add(Me.Label9)
        Me.Panel15.Controls.Add(Me.gradoColaboracion)
        Me.Panel15.Controls.Add(Me.Label8)
        Me.Panel15.Controls.Add(Me.pulso)
        Me.Panel15.Controls.Add(Me.Label2)
        Me.Panel15.Controls.Add(Me.Label6)
        Me.Panel15.Controls.Add(Me.estadoGeneral)
        Me.Panel15.Controls.Add(Me.Label1)
        Me.Panel15.Controls.Add(Me.agregarSintomas)
        Me.Panel15.Controls.Add(Me.agregarFormularios)
        Me.Panel15.Controls.Add(Me.agregarMotivo)
        Me.Panel15.Controls.Add(Me.frecuenciaCardiaca)
        Me.Panel15.Controls.Add(Me.frecuenciaRespiratoria)
        Me.Panel15.Controls.Add(Me.temperatura)
        Me.Panel15.Controls.Add(Me.labelLoginPersonalSquare)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1200, 478)
        Me.Panel15.TabIndex = 0
        '
        'estadoNutricional
        '
        Me.estadoNutricional.DropDownHeight = 109
        Me.estadoNutricional.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estadoNutricional.FormattingEnabled = True
        Me.estadoNutricional.IntegralHeight = False
        Me.estadoNutricional.Items.AddRange(New Object() {"Normal", "Desnutrición", "Sobrepeso", "Obesidad"})
        Me.estadoNutricional.Location = New System.Drawing.Point(318, 213)
        Me.estadoNutricional.Name = "estadoNutricional"
        Me.estadoNutricional.Size = New System.Drawing.Size(234, 28)
        Me.estadoNutricional.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(558, 267)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(311, 31)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Motivo de consulta"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(558, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(311, 31)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Síntomas"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(311, 31)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Estado nutricional"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'actitud
        '
        Me.actitud.DropDownHeight = 109
        Me.actitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.actitud.FormattingEnabled = True
        Me.actitud.IntegralHeight = False
        Me.actitud.Items.AddRange(New Object() {"Normal", "Excitación", "Apatía"})
        Me.actitud.Location = New System.Drawing.Point(318, 158)
        Me.actitud.Name = "actitud"
        Me.actitud.Size = New System.Drawing.Size(234, 28)
        Me.actitud.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(1, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(311, 31)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Temperatura"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(1, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(311, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Actitud"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(558, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(311, 31)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Frecuencia cardíaca"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gradoColaboracion
        '
        Me.gradoColaboracion.DropDownHeight = 109
        Me.gradoColaboracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradoColaboracion.FormattingEnabled = True
        Me.gradoColaboracion.IntegralHeight = False
        Me.gradoColaboracion.Items.AddRange(New Object() {"Colabora", "No colabora"})
        Me.gradoColaboracion.Location = New System.Drawing.Point(318, 104)
        Me.gradoColaboracion.Name = "gradoColaboracion"
        Me.gradoColaboracion.Size = New System.Drawing.Size(234, 28)
        Me.gradoColaboracion.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(558, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(311, 31)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Frecuencia respiratoria"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pulso
        '
        Me.pulso.DropDownHeight = 109
        Me.pulso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pulso.FormattingEnabled = True
        Me.pulso.IntegralHeight = False
        Me.pulso.Items.AddRange(New Object() {"Normal", "Irregular", "Asincrónico", "Filiforme", "Ausente"})
        Me.pulso.Location = New System.Drawing.Point(875, 54)
        Me.pulso.Name = "pulso"
        Me.pulso.Size = New System.Drawing.Size(234, 28)
        Me.pulso.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Grado de colaboración"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(558, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(311, 31)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Pulso"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'estadoGeneral
        '
        Me.estadoGeneral.DropDownHeight = 109
        Me.estadoGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estadoGeneral.FormattingEnabled = True
        Me.estadoGeneral.IntegralHeight = False
        Me.estadoGeneral.Items.AddRange(New Object() {"Excelente", "Bueno", "Regular", "Malo"})
        Me.estadoGeneral.Location = New System.Drawing.Point(318, 51)
        Me.estadoGeneral.Name = "estadoGeneral"
        Me.estadoGeneral.Size = New System.Drawing.Size(234, 28)
        Me.estadoGeneral.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Estado General"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'agregarSintomas
        '
        Me.agregarSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.agregarSintomas.FlatAppearance.BorderSize = 0
        Me.agregarSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregarSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregarSintomas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.agregarSintomas.Location = New System.Drawing.Point(875, 213)
        Me.agregarSintomas.Name = "agregarSintomas"
        Me.agregarSintomas.Size = New System.Drawing.Size(234, 31)
        Me.agregarSintomas.TabIndex = 3
        Me.agregarSintomas.Text = "Agregar"
        Me.agregarSintomas.UseVisualStyleBackColor = False
        '
        'agregarFormularios
        '
        Me.agregarFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.agregarFormularios.FlatAppearance.BorderSize = 0
        Me.agregarFormularios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregarFormularios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregarFormularios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.agregarFormularios.Location = New System.Drawing.Point(465, 358)
        Me.agregarFormularios.Name = "agregarFormularios"
        Me.agregarFormularios.Size = New System.Drawing.Size(271, 60)
        Me.agregarFormularios.TabIndex = 3
        Me.agregarFormularios.Text = "Agregar formularios"
        Me.agregarFormularios.UseVisualStyleBackColor = False
        '
        'agregarMotivo
        '
        Me.agregarMotivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.agregarMotivo.FlatAppearance.BorderSize = 0
        Me.agregarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregarMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregarMotivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.agregarMotivo.Location = New System.Drawing.Point(875, 268)
        Me.agregarMotivo.Name = "agregarMotivo"
        Me.agregarMotivo.Size = New System.Drawing.Size(234, 31)
        Me.agregarMotivo.TabIndex = 3
        Me.agregarMotivo.Text = "Agregar"
        Me.agregarMotivo.UseVisualStyleBackColor = False
        '
        'frecuenciaCardiaca
        '
        Me.frecuenciaCardiaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frecuenciaCardiaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frecuenciaCardiaca.Location = New System.Drawing.Point(875, 107)
        Me.frecuenciaCardiaca.Margin = New System.Windows.Forms.Padding(5)
        Me.frecuenciaCardiaca.MaxLength = 32
        Me.frecuenciaCardiaca.Name = "frecuenciaCardiaca"
        Me.frecuenciaCardiaca.Size = New System.Drawing.Size(234, 27)
        Me.frecuenciaCardiaca.TabIndex = 2
        '
        'frecuenciaRespiratoria
        '
        Me.frecuenciaRespiratoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frecuenciaRespiratoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frecuenciaRespiratoria.Location = New System.Drawing.Point(875, 160)
        Me.frecuenciaRespiratoria.Margin = New System.Windows.Forms.Padding(5)
        Me.frecuenciaRespiratoria.MaxLength = 32
        Me.frecuenciaRespiratoria.Name = "frecuenciaRespiratoria"
        Me.frecuenciaRespiratoria.Size = New System.Drawing.Size(234, 27)
        Me.frecuenciaRespiratoria.TabIndex = 2
        '
        'temperatura
        '
        Me.temperatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.temperatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temperatura.Location = New System.Drawing.Point(318, 271)
        Me.temperatura.Margin = New System.Windows.Forms.Padding(5)
        Me.temperatura.MaxLength = 32
        Me.temperatura.Name = "temperatura"
        Me.temperatura.Size = New System.Drawing.Size(234, 27)
        Me.temperatura.TabIndex = 2
        '
        'labelLoginPersonalSquare
        '
        Me.labelLoginPersonalSquare.BackColor = System.Drawing.Color.Transparent
        Me.labelLoginPersonalSquare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelLoginPersonalSquare.Location = New System.Drawing.Point(0, 0)
        Me.labelLoginPersonalSquare.Name = "labelLoginPersonalSquare"
        Me.labelLoginPersonalSquare.Size = New System.Drawing.Size(1200, 478)
        Me.labelLoginPersonalSquare.TabIndex = 0
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.tituloEntrevista)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1200, 99)
        Me.Panel16.TabIndex = 0
        '
        'tituloEntrevista
        '
        Me.tituloEntrevista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloEntrevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloEntrevista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloEntrevista.Location = New System.Drawing.Point(0, 0)
        Me.tituloEntrevista.Name = "tituloEntrevista"
        Me.tituloEntrevista.Size = New System.Drawing.Size(1200, 99)
        Me.tituloEntrevista.TabIndex = 0
        Me.tituloEntrevista.Text = "Entrevista a Apellido, Nombre"
        Me.tituloEntrevista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.entrevistaError)
        Me.Panel17.Controls.Add(Me.aceptar)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 577)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1200, 98)
        Me.Panel17.TabIndex = 1
        '
        'entrevistaError
        '
        Me.entrevistaError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entrevistaError.ForeColor = System.Drawing.Color.Red
        Me.entrevistaError.Location = New System.Drawing.Point(465, 56)
        Me.entrevistaError.Name = "entrevistaError"
        Me.entrevistaError.Size = New System.Drawing.Size(271, 20)
        Me.entrevistaError.TabIndex = 19
        Me.entrevistaError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aceptar
        '
        Me.aceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.aceptar.FlatAppearance.BorderSize = 0
        Me.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.aceptar.Location = New System.Drawing.Point(513, 0)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(180, 51)
        Me.aceptar.TabIndex = 4
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = False
        '
        'FormEntrevista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.loginPersonal)
        Me.Name = "FormEntrevista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrevista"
        Me.loginPersonal.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loginPersonal As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents agregarMotivo As Button
    Friend WithEvents temperatura As TextBox
    Friend WithEvents labelLoginPersonalSquare As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents tituloEntrevista As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents aceptar As Button
    Friend WithEvents estadoNutricional As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents actitud As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents gradoColaboracion As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pulso As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents estadoGeneral As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents agregarSintomas As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents agregarFormularios As Button
    Friend WithEvents frecuenciaCardiaca As TextBox
    Friend WithEvents frecuenciaRespiratoria As TextBox
    Friend WithEvents entrevistaError As Label
End Class
