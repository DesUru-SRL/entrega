<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnalisis
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
        Me.listaAnalisis = New System.Windows.Forms.Panel()
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.btnIngresarResultados = New System.Windows.Forms.Button()
        Me.btnVerResultados = New System.Windows.Forms.Button()
        Me.listAnalisis = New System.Windows.Forms.ListBox()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.tituloListaAnalisis = New System.Windows.Forms.Label()
        Me.analisis = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.listDetallesAnalisis = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.backAnalisis = New System.Windows.Forms.Label()
        Me.tituloAnalisis = New System.Windows.Forms.Label()
        Me.ingresarResultado = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ingresarControlError = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.aceptarIngresarResultado = New System.Windows.Forms.Button()
        Me.tboxDetalles = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.backIngresarResultado = New System.Windows.Forms.Label()
        Me.tituloIngresarResultado = New System.Windows.Forms.Label()
        Me.listaAnalisis.SuspendLayout()
        Me.Panel67.SuspendLayout()
        Me.Panel68.SuspendLayout()
        Me.analisis.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ingresarResultado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'listaAnalisis
        '
        Me.listaAnalisis.Controls.Add(Me.Panel67)
        Me.listaAnalisis.Controls.Add(Me.Panel68)
        Me.listaAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listaAnalisis.Location = New System.Drawing.Point(0, 0)
        Me.listaAnalisis.Name = "listaAnalisis"
        Me.listaAnalisis.Size = New System.Drawing.Size(1200, 675)
        Me.listaAnalisis.TabIndex = 21
        '
        'Panel67
        '
        Me.Panel67.Controls.Add(Me.btnIngresarResultados)
        Me.Panel67.Controls.Add(Me.btnVerResultados)
        Me.Panel67.Controls.Add(Me.listAnalisis)
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel67.Location = New System.Drawing.Point(0, 110)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(1200, 565)
        Me.Panel67.TabIndex = 2
        '
        'btnIngresarResultados
        '
        Me.btnIngresarResultados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnIngresarResultados.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnIngresarResultados.FlatAppearance.BorderSize = 0
        Me.btnIngresarResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarResultados.ForeColor = System.Drawing.Color.White
        Me.btnIngresarResultados.Location = New System.Drawing.Point(618, 451)
        Me.btnIngresarResultados.Name = "btnIngresarResultados"
        Me.btnIngresarResultados.Size = New System.Drawing.Size(486, 44)
        Me.btnIngresarResultados.TabIndex = 4
        Me.btnIngresarResultados.Text = "Ingresar resultados"
        Me.btnIngresarResultados.UseVisualStyleBackColor = False
        '
        'btnVerResultados
        '
        Me.btnVerResultados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVerResultados.BackColor = System.Drawing.Color.White
        Me.btnVerResultados.FlatAppearance.BorderSize = 0
        Me.btnVerResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerResultados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVerResultados.Location = New System.Drawing.Point(104, 451)
        Me.btnVerResultados.Name = "btnVerResultados"
        Me.btnVerResultados.Size = New System.Drawing.Size(486, 44)
        Me.btnVerResultados.TabIndex = 4
        Me.btnVerResultados.Text = "Ver resultados"
        Me.btnVerResultados.UseVisualStyleBackColor = False
        '
        'listAnalisis
        '
        Me.listAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.listAnalisis.BackColor = System.Drawing.Color.White
        Me.listAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listAnalisis.FormattingEnabled = True
        Me.listAnalisis.ItemHeight = 29
        Me.listAnalisis.Items.AddRange(New Object() {"Test 1", "Test 2", "Test 3", "Test 4", "Test 5", "Test 6", "Test 7", "Test 8", "Test 9", "Test 10"})
        Me.listAnalisis.Location = New System.Drawing.Point(104, 15)
        Me.listAnalisis.Name = "listAnalisis"
        Me.listAnalisis.Size = New System.Drawing.Size(1000, 408)
        Me.listAnalisis.TabIndex = 0
        '
        'Panel68
        '
        Me.Panel68.Controls.Add(Me.tituloListaAnalisis)
        Me.Panel68.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel68.Location = New System.Drawing.Point(0, 0)
        Me.Panel68.Name = "Panel68"
        Me.Panel68.Size = New System.Drawing.Size(1200, 110)
        Me.Panel68.TabIndex = 0
        '
        'tituloListaAnalisis
        '
        Me.tituloListaAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloListaAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloListaAnalisis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloListaAnalisis.Location = New System.Drawing.Point(0, 0)
        Me.tituloListaAnalisis.Name = "tituloListaAnalisis"
        Me.tituloListaAnalisis.Size = New System.Drawing.Size(1200, 110)
        Me.tituloListaAnalisis.TabIndex = 0
        Me.tituloListaAnalisis.Text = "Análisis clínicos de Apellido, Nombre"
        Me.tituloListaAnalisis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'analisis
        '
        Me.analisis.Controls.Add(Me.Panel2)
        Me.analisis.Controls.Add(Me.Panel3)
        Me.analisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.analisis.Location = New System.Drawing.Point(0, 0)
        Me.analisis.Name = "analisis"
        Me.analisis.Size = New System.Drawing.Size(1200, 675)
        Me.analisis.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.listDetallesAnalisis)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 565)
        Me.Panel2.TabIndex = 2
        '
        'listDetallesAnalisis
        '
        Me.listDetallesAnalisis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.listDetallesAnalisis.BackColor = System.Drawing.Color.White
        Me.listDetallesAnalisis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listDetallesAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listDetallesAnalisis.FormattingEnabled = True
        Me.listDetallesAnalisis.ItemHeight = 33
        Me.listDetallesAnalisis.Items.AddRange(New Object() {"Test 1", "Test 2", "Test 3", "Test 4", "Test 5", "Test 6", "Test 7", "Test 8", "Test 9", "Test 10"})
        Me.listDetallesAnalisis.Location = New System.Drawing.Point(104, 15)
        Me.listDetallesAnalisis.Name = "listDetallesAnalisis"
        Me.listDetallesAnalisis.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listDetallesAnalisis.Size = New System.Drawing.Size(1000, 464)
        Me.listDetallesAnalisis.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.backAnalisis)
        Me.Panel3.Controls.Add(Me.tituloAnalisis)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1200, 110)
        Me.Panel3.TabIndex = 0
        '
        'backAnalisis
        '
        Me.backAnalisis.BackColor = System.Drawing.Color.Transparent
        Me.backAnalisis.Image = Global.dU_Salud.My.Resources.Resources.back
        Me.backAnalisis.Location = New System.Drawing.Point(24, 26)
        Me.backAnalisis.Name = "backAnalisis"
        Me.backAnalisis.Size = New System.Drawing.Size(73, 71)
        Me.backAnalisis.TabIndex = 4
        '
        'tituloAnalisis
        '
        Me.tituloAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloAnalisis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloAnalisis.Location = New System.Drawing.Point(0, 0)
        Me.tituloAnalisis.Name = "tituloAnalisis"
        Me.tituloAnalisis.Size = New System.Drawing.Size(1200, 110)
        Me.tituloAnalisis.TabIndex = 0
        Me.tituloAnalisis.Text = "Análisis de TIPO"
        Me.tituloAnalisis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ingresarResultado
        '
        Me.ingresarResultado.Controls.Add(Me.Panel1)
        Me.ingresarResultado.Controls.Add(Me.Panel6)
        Me.ingresarResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ingresarResultado.Location = New System.Drawing.Point(0, 0)
        Me.ingresarResultado.Name = "ingresarResultado"
        Me.ingresarResultado.Size = New System.Drawing.Size(1200, 675)
        Me.ingresarResultado.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ingresarControlError)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.aceptarIngresarResultado)
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
        'aceptarIngresarResultado
        '
        Me.aceptarIngresarResultado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.aceptarIngresarResultado.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.aceptarIngresarResultado.FlatAppearance.BorderSize = 0
        Me.aceptarIngresarResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarIngresarResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptarIngresarResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.aceptarIngresarResultado.Location = New System.Drawing.Point(280, 417)
        Me.aceptarIngresarResultado.Name = "aceptarIngresarResultado"
        Me.aceptarIngresarResultado.Size = New System.Drawing.Size(640, 31)
        Me.aceptarIngresarResultado.TabIndex = 10
        Me.aceptarIngresarResultado.Text = "Aceptar"
        Me.aceptarIngresarResultado.UseVisualStyleBackColor = False
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
        Me.Panel6.Controls.Add(Me.backIngresarResultado)
        Me.Panel6.Controls.Add(Me.tituloIngresarResultado)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1200, 119)
        Me.Panel6.TabIndex = 0
        '
        'backIngresarResultado
        '
        Me.backIngresarResultado.BackColor = System.Drawing.Color.Transparent
        Me.backIngresarResultado.Image = Global.dU_Salud.My.Resources.Resources.back
        Me.backIngresarResultado.Location = New System.Drawing.Point(24, 26)
        Me.backIngresarResultado.Name = "backIngresarResultado"
        Me.backIngresarResultado.Size = New System.Drawing.Size(73, 71)
        Me.backIngresarResultado.TabIndex = 4
        '
        'tituloIngresarResultado
        '
        Me.tituloIngresarResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloIngresarResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloIngresarResultado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloIngresarResultado.Location = New System.Drawing.Point(0, 0)
        Me.tituloIngresarResultado.Name = "tituloIngresarResultado"
        Me.tituloIngresarResultado.Size = New System.Drawing.Size(1200, 119)
        Me.tituloIngresarResultado.TabIndex = 0
        Me.tituloIngresarResultado.Text = "Ingresar resultado de Análisis"
        Me.tituloIngresarResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormAnalisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.listaAnalisis)
        Me.Controls.Add(Me.ingresarResultado)
        Me.Controls.Add(Me.analisis)
        Me.Name = "FormAnalisis"
        Me.Text = "Analisis"
        Me.listaAnalisis.ResumeLayout(False)
        Me.Panel67.ResumeLayout(False)
        Me.Panel68.ResumeLayout(False)
        Me.analisis.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ingresarResultado.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listaAnalisis As Panel
    Friend WithEvents Panel67 As Panel
    Friend WithEvents btnIngresarResultados As Button
    Friend WithEvents btnVerResultados As Button
    Friend WithEvents listAnalisis As ListBox
    Friend WithEvents Panel68 As Panel
    Friend WithEvents tituloListaAnalisis As Label
    Friend WithEvents analisis As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents listDetallesAnalisis As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents backAnalisis As Label
    Friend WithEvents tituloAnalisis As Label
    Friend WithEvents ingresarResultado As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ingresarControlError As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents aceptarIngresarResultado As Button
    Friend WithEvents tboxDetalles As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents backIngresarResultado As Label
    Friend WithEvents tituloIngresarResultado As Label
End Class
