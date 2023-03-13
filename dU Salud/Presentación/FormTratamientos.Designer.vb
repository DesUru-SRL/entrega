<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTratamientos
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
        Me.listaTratamientos = New System.Windows.Forms.Panel()
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.btnIngresarControl = New System.Windows.Forms.Button()
        Me.btnVerTratamiento = New System.Windows.Forms.Button()
        Me.listTratamientos = New System.Windows.Forms.ListBox()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.tituloTratamientos = New System.Windows.Forms.Label()
        Me.tratamiento = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.listTratamiento = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.backTratamiento = New System.Windows.Forms.Label()
        Me.tituloTratamiento = New System.Windows.Forms.Label()
        Me.ingresarControl = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ingresarControlError = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.aceptarIngresarControl = New System.Windows.Forms.Button()
        Me.tboxDetalles = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.backIngresarControl = New System.Windows.Forms.Label()
        Me.tituloIngresarControl = New System.Windows.Forms.Label()
        Me.listaTratamientos.SuspendLayout()
        Me.Panel67.SuspendLayout()
        Me.Panel68.SuspendLayout()
        Me.tratamiento.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ingresarControl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'listaTratamientos
        '
        Me.listaTratamientos.Controls.Add(Me.Panel67)
        Me.listaTratamientos.Controls.Add(Me.Panel68)
        Me.listaTratamientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listaTratamientos.Location = New System.Drawing.Point(0, 0)
        Me.listaTratamientos.Name = "listaTratamientos"
        Me.listaTratamientos.Size = New System.Drawing.Size(1200, 675)
        Me.listaTratamientos.TabIndex = 20
        '
        'Panel67
        '
        Me.Panel67.Controls.Add(Me.btnIngresarControl)
        Me.Panel67.Controls.Add(Me.btnVerTratamiento)
        Me.Panel67.Controls.Add(Me.listTratamientos)
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel67.Location = New System.Drawing.Point(0, 110)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(1200, 565)
        Me.Panel67.TabIndex = 2
        '
        'btnIngresarControl
        '
        Me.btnIngresarControl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIngresarControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnIngresarControl.FlatAppearance.BorderSize = 0
        Me.btnIngresarControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarControl.ForeColor = System.Drawing.Color.White
        Me.btnIngresarControl.Location = New System.Drawing.Point(618, 451)
        Me.btnIngresarControl.Name = "btnIngresarControl"
        Me.btnIngresarControl.Size = New System.Drawing.Size(486, 44)
        Me.btnIngresarControl.TabIndex = 4
        Me.btnIngresarControl.Text = "Realizar control"
        Me.btnIngresarControl.UseVisualStyleBackColor = False
        '
        'btnVerTratamiento
        '
        Me.btnVerTratamiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVerTratamiento.BackColor = System.Drawing.Color.White
        Me.btnVerTratamiento.FlatAppearance.BorderSize = 0
        Me.btnVerTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerTratamiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVerTratamiento.Location = New System.Drawing.Point(104, 451)
        Me.btnVerTratamiento.Name = "btnVerTratamiento"
        Me.btnVerTratamiento.Size = New System.Drawing.Size(486, 44)
        Me.btnVerTratamiento.TabIndex = 4
        Me.btnVerTratamiento.Text = "Ver tratamiento"
        Me.btnVerTratamiento.UseVisualStyleBackColor = False
        '
        'listTratamientos
        '
        Me.listTratamientos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.listTratamientos.BackColor = System.Drawing.Color.White
        Me.listTratamientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listTratamientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listTratamientos.FormattingEnabled = True
        Me.listTratamientos.ItemHeight = 29
        Me.listTratamientos.Items.AddRange(New Object() {"Test 1", "Test 2", "Test 3", "Test 4", "Test 5", "Test 6", "Test 7", "Test 8", "Test 9", "Test 10"})
        Me.listTratamientos.Location = New System.Drawing.Point(104, 15)
        Me.listTratamientos.Name = "listTratamientos"
        Me.listTratamientos.Size = New System.Drawing.Size(1000, 408)
        Me.listTratamientos.TabIndex = 0
        '
        'Panel68
        '
        Me.Panel68.Controls.Add(Me.tituloTratamientos)
        Me.Panel68.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel68.Location = New System.Drawing.Point(0, 0)
        Me.Panel68.Name = "Panel68"
        Me.Panel68.Size = New System.Drawing.Size(1200, 110)
        Me.Panel68.TabIndex = 0
        '
        'tituloTratamientos
        '
        Me.tituloTratamientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloTratamientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloTratamientos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloTratamientos.Location = New System.Drawing.Point(0, 0)
        Me.tituloTratamientos.Name = "tituloTratamientos"
        Me.tituloTratamientos.Size = New System.Drawing.Size(1200, 110)
        Me.tituloTratamientos.TabIndex = 0
        Me.tituloTratamientos.Text = "Tratamientos de Apellido, Nombre"
        Me.tituloTratamientos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tratamiento
        '
        Me.tratamiento.Controls.Add(Me.Panel2)
        Me.tratamiento.Controls.Add(Me.Panel3)
        Me.tratamiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tratamiento.Location = New System.Drawing.Point(0, 0)
        Me.tratamiento.Name = "tratamiento"
        Me.tratamiento.Size = New System.Drawing.Size(1200, 675)
        Me.tratamiento.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.listTratamiento)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 565)
        Me.Panel2.TabIndex = 2
        '
        'listTratamiento
        '
        Me.listTratamiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.listTratamiento.BackColor = System.Drawing.Color.White
        Me.listTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listTratamiento.FormattingEnabled = True
        Me.listTratamiento.ItemHeight = 33
        Me.listTratamiento.Items.AddRange(New Object() {"Test 1", "Test 2", "Test 3", "Test 4", "Test 5", "Test 6", "Test 7", "Test 8", "Test 9", "Test 10"})
        Me.listTratamiento.Location = New System.Drawing.Point(104, 15)
        Me.listTratamiento.Name = "listTratamiento"
        Me.listTratamiento.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listTratamiento.Size = New System.Drawing.Size(1000, 464)
        Me.listTratamiento.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.backTratamiento)
        Me.Panel3.Controls.Add(Me.tituloTratamiento)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1200, 110)
        Me.Panel3.TabIndex = 0
        '
        'backTratamiento
        '
        Me.backTratamiento.BackColor = System.Drawing.Color.Transparent
        Me.backTratamiento.Image = Global.dU_Salud.My.Resources.Resources.back
        Me.backTratamiento.Location = New System.Drawing.Point(24, 26)
        Me.backTratamiento.Name = "backTratamiento"
        Me.backTratamiento.Size = New System.Drawing.Size(73, 71)
        Me.backTratamiento.TabIndex = 4
        '
        'tituloTratamiento
        '
        Me.tituloTratamiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloTratamiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloTratamiento.Location = New System.Drawing.Point(0, 0)
        Me.tituloTratamiento.Name = "tituloTratamiento"
        Me.tituloTratamiento.Size = New System.Drawing.Size(1200, 110)
        Me.tituloTratamiento.TabIndex = 0
        Me.tituloTratamiento.Text = "Tratamiento 12/09/2020"
        Me.tituloTratamiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ingresarControl
        '
        Me.ingresarControl.Controls.Add(Me.Panel1)
        Me.ingresarControl.Controls.Add(Me.Panel6)
        Me.ingresarControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ingresarControl.Location = New System.Drawing.Point(0, 0)
        Me.ingresarControl.Name = "ingresarControl"
        Me.ingresarControl.Size = New System.Drawing.Size(1200, 675)
        Me.ingresarControl.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ingresarControlError)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.aceptarIngresarControl)
        Me.Panel1.Controls.Add(Me.tboxDetalles)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 556)
        Me.Panel1.TabIndex = 2
        '
        'ingresarControlError
        '
        Me.ingresarControlError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingresarControlError.ForeColor = System.Drawing.Color.Red
        Me.ingresarControlError.Location = New System.Drawing.Point(280, 465)
        Me.ingresarControlError.Name = "ingresarControlError"
        Me.ingresarControlError.Size = New System.Drawing.Size(640, 20)
        Me.ingresarControlError.TabIndex = 20
        Me.ingresarControlError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'aceptarIngresarControl
        '
        Me.aceptarIngresarControl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.aceptarIngresarControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.aceptarIngresarControl.FlatAppearance.BorderSize = 0
        Me.aceptarIngresarControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarIngresarControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptarIngresarControl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.aceptarIngresarControl.Location = New System.Drawing.Point(280, 417)
        Me.aceptarIngresarControl.Name = "aceptarIngresarControl"
        Me.aceptarIngresarControl.Size = New System.Drawing.Size(640, 31)
        Me.aceptarIngresarControl.TabIndex = 10
        Me.aceptarIngresarControl.Text = "Aceptar"
        Me.aceptarIngresarControl.UseVisualStyleBackColor = False
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
        Me.Panel6.Controls.Add(Me.backIngresarControl)
        Me.Panel6.Controls.Add(Me.tituloIngresarControl)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1200, 119)
        Me.Panel6.TabIndex = 0
        '
        'backIngresarControl
        '
        Me.backIngresarControl.BackColor = System.Drawing.Color.Transparent
        Me.backIngresarControl.Image = Global.dU_Salud.My.Resources.Resources.back
        Me.backIngresarControl.Location = New System.Drawing.Point(24, 26)
        Me.backIngresarControl.Name = "backIngresarControl"
        Me.backIngresarControl.Size = New System.Drawing.Size(73, 71)
        Me.backIngresarControl.TabIndex = 4
        '
        'tituloIngresarControl
        '
        Me.tituloIngresarControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloIngresarControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloIngresarControl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloIngresarControl.Location = New System.Drawing.Point(0, 0)
        Me.tituloIngresarControl.Name = "tituloIngresarControl"
        Me.tituloIngresarControl.Size = New System.Drawing.Size(1200, 119)
        Me.tituloIngresarControl.TabIndex = 0
        Me.tituloIngresarControl.Text = "Ingresar Control"
        Me.tituloIngresarControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormTratamientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.listaTratamientos)
        Me.Controls.Add(Me.ingresarControl)
        Me.Controls.Add(Me.tratamiento)
        Me.Name = "FormTratamientos"
        Me.Text = "Tratamientos"
        Me.listaTratamientos.ResumeLayout(False)
        Me.Panel67.ResumeLayout(False)
        Me.Panel68.ResumeLayout(False)
        Me.tratamiento.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ingresarControl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listaTratamientos As Panel
    Friend WithEvents Panel67 As Panel
    Friend WithEvents btnIngresarControl As Button
    Friend WithEvents btnVerTratamiento As Button
    Friend WithEvents listTratamientos As ListBox
    Friend WithEvents Panel68 As Panel
    Friend WithEvents tituloTratamientos As Label
    Friend WithEvents tratamiento As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents listTratamiento As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents backTratamiento As Label
    Friend WithEvents tituloTratamiento As Label
    Friend WithEvents ingresarControl As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ingresarControlError As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents aceptarIngresarControl As Button
    Friend WithEvents tboxDetalles As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents backIngresarControl As Label
    Friend WithEvents tituloIngresarControl As Label
End Class
