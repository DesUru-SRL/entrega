<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormControl
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
        Me.controlRegistro = New System.Windows.Forms.Panel()
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.btnVerRegistro = New System.Windows.Forms.Button()
        Me.registro = New System.Windows.Forms.ListBox()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.tituloControlTratamiento = New System.Windows.Forms.Label()
        Me.tratamiento = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.listControlTratamiento = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.backTratamiento = New System.Windows.Forms.Label()
        Me.tituloTratamiento = New System.Windows.Forms.Label()
        Me.controlRegistro.SuspendLayout()
        Me.Panel67.SuspendLayout()
        Me.Panel68.SuspendLayout()
        Me.tratamiento.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'controlRegistro
        '
        Me.controlRegistro.Controls.Add(Me.Panel67)
        Me.controlRegistro.Controls.Add(Me.Panel68)
        Me.controlRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.controlRegistro.Location = New System.Drawing.Point(0, 0)
        Me.controlRegistro.Name = "controlRegistro"
        Me.controlRegistro.Size = New System.Drawing.Size(1200, 675)
        Me.controlRegistro.TabIndex = 21
        '
        'Panel67
        '
        Me.Panel67.Controls.Add(Me.btnVerRegistro)
        Me.Panel67.Controls.Add(Me.registro)
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel67.Location = New System.Drawing.Point(0, 110)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(1200, 565)
        Me.Panel67.TabIndex = 2
        '
        'btnVerRegistro
        '
        Me.btnVerRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVerRegistro.BackColor = System.Drawing.Color.White
        Me.btnVerRegistro.FlatAppearance.BorderSize = 0
        Me.btnVerRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVerRegistro.Location = New System.Drawing.Point(104, 451)
        Me.btnVerRegistro.Name = "btnVerRegistro"
        Me.btnVerRegistro.Size = New System.Drawing.Size(1000, 44)
        Me.btnVerRegistro.TabIndex = 4
        Me.btnVerRegistro.Text = "Ver control de tratamiento"
        Me.btnVerRegistro.UseVisualStyleBackColor = False
        '
        'registro
        '
        Me.registro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.registro.BackColor = System.Drawing.Color.White
        Me.registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.registro.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registro.FormattingEnabled = True
        Me.registro.ItemHeight = 29
        Me.registro.Items.AddRange(New Object() {"Test 1", "Test 2", "Test 3", "Test 4", "Test 5", "Test 6", "Test 7", "Test 8", "Test 9", "Test 10"})
        Me.registro.Location = New System.Drawing.Point(104, 15)
        Me.registro.Name = "registro"
        Me.registro.Size = New System.Drawing.Size(1000, 408)
        Me.registro.TabIndex = 0
        '
        'Panel68
        '
        Me.Panel68.Controls.Add(Me.tituloControlTratamiento)
        Me.Panel68.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel68.Location = New System.Drawing.Point(0, 0)
        Me.Panel68.Name = "Panel68"
        Me.Panel68.Size = New System.Drawing.Size(1200, 110)
        Me.Panel68.TabIndex = 0
        '
        'tituloControlTratamiento
        '
        Me.tituloControlTratamiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloControlTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloControlTratamiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloControlTratamiento.Location = New System.Drawing.Point(0, 0)
        Me.tituloControlTratamiento.Name = "tituloControlTratamiento"
        Me.tituloControlTratamiento.Size = New System.Drawing.Size(1200, 110)
        Me.tituloControlTratamiento.TabIndex = 0
        Me.tituloControlTratamiento.Text = "Control de tratamientos de Nombre, Apellido"
        Me.tituloControlTratamiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tratamiento
        '
        Me.tratamiento.Controls.Add(Me.Panel2)
        Me.tratamiento.Controls.Add(Me.Panel3)
        Me.tratamiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tratamiento.Location = New System.Drawing.Point(0, 0)
        Me.tratamiento.Name = "tratamiento"
        Me.tratamiento.Size = New System.Drawing.Size(1200, 675)
        Me.tratamiento.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.listControlTratamiento)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 565)
        Me.Panel2.TabIndex = 2
        '
        'listControlTratamiento
        '
        Me.listControlTratamiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.listControlTratamiento.BackColor = System.Drawing.Color.White
        Me.listControlTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listControlTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listControlTratamiento.FormattingEnabled = True
        Me.listControlTratamiento.ItemHeight = 33
        Me.listControlTratamiento.Items.AddRange(New Object() {"Test 1", "Test 2", "Test 3", "Test 4", "Test 5", "Test 6", "Test 7", "Test 8", "Test 9", "Test 10"})
        Me.listControlTratamiento.Location = New System.Drawing.Point(104, 15)
        Me.listControlTratamiento.Name = "listControlTratamiento"
        Me.listControlTratamiento.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listControlTratamiento.Size = New System.Drawing.Size(1000, 464)
        Me.listControlTratamiento.TabIndex = 0
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
        'FormControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.controlRegistro)
        Me.Controls.Add(Me.tratamiento)
        Me.Name = "FormControl"
        Me.Text = "Control"
        Me.controlRegistro.ResumeLayout(False)
        Me.Panel67.ResumeLayout(False)
        Me.Panel68.ResumeLayout(False)
        Me.tratamiento.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents controlRegistro As Panel
    Friend WithEvents Panel67 As Panel
    Friend WithEvents btnVerRegistro As Button
    Friend WithEvents registro As ListBox
    Friend WithEvents Panel68 As Panel
    Friend WithEvents tituloControlTratamiento As Label
    Friend WithEvents tratamiento As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents listControlTratamiento As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents backTratamiento As Label
    Friend WithEvents tituloTratamiento As Label
End Class
