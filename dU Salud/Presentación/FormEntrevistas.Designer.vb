<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEntrevistas
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
        Me.listaEntrevistas = New System.Windows.Forms.Panel()
        Me.Panel67 = New System.Windows.Forms.Panel()
        Me.btnDiagnosticar = New System.Windows.Forms.Button()
        Me.btnNuevaEntrevista = New System.Windows.Forms.Button()
        Me.btnVerEntrevista = New System.Windows.Forms.Button()
        Me.listEntrevistas = New System.Windows.Forms.ListBox()
        Me.Panel68 = New System.Windows.Forms.Panel()
        Me.tituloEntrevistas = New System.Windows.Forms.Label()
        Me.entrevista = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.listEntrevista = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.backEntrevista = New System.Windows.Forms.Label()
        Me.tituloEntrevista = New System.Windows.Forms.Label()
        Me.diagnosticar = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.diagnosticarError = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tboxTipo = New System.Windows.Forms.TextBox()
        Me.aceptarDiagnosticar = New System.Windows.Forms.Button()
        Me.tboxDetalles = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.backDiagnosticar = New System.Windows.Forms.Label()
        Me.tituloDiagnosticar = New System.Windows.Forms.Label()
        Me.listaEntrevistas.SuspendLayout()
        Me.Panel67.SuspendLayout()
        Me.Panel68.SuspendLayout()
        Me.entrevista.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.diagnosticar.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'listaEntrevistas
        '
        Me.listaEntrevistas.Controls.Add(Me.Panel67)
        Me.listaEntrevistas.Controls.Add(Me.Panel68)
        Me.listaEntrevistas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listaEntrevistas.Location = New System.Drawing.Point(0, 0)
        Me.listaEntrevistas.Name = "listaEntrevistas"
        Me.listaEntrevistas.Size = New System.Drawing.Size(1200, 675)
        Me.listaEntrevistas.TabIndex = 19
        '
        'Panel67
        '
        Me.Panel67.Controls.Add(Me.btnDiagnosticar)
        Me.Panel67.Controls.Add(Me.btnNuevaEntrevista)
        Me.Panel67.Controls.Add(Me.btnVerEntrevista)
        Me.Panel67.Controls.Add(Me.listEntrevistas)
        Me.Panel67.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel67.Location = New System.Drawing.Point(0, 110)
        Me.Panel67.Name = "Panel67"
        Me.Panel67.Size = New System.Drawing.Size(1200, 565)
        Me.Panel67.TabIndex = 2
        '
        'btnDiagnosticar
        '
        Me.btnDiagnosticar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDiagnosticar.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnDiagnosticar.FlatAppearance.BorderSize = 0
        Me.btnDiagnosticar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiagnosticar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiagnosticar.ForeColor = System.Drawing.Color.White
        Me.btnDiagnosticar.Location = New System.Drawing.Point(447, 451)
        Me.btnDiagnosticar.Name = "btnDiagnosticar"
        Me.btnDiagnosticar.Size = New System.Drawing.Size(316, 44)
        Me.btnDiagnosticar.TabIndex = 4
        Me.btnDiagnosticar.Text = "Diagnosticar"
        Me.btnDiagnosticar.UseVisualStyleBackColor = False
        '
        'btnNuevaEntrevista
        '
        Me.btnNuevaEntrevista.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNuevaEntrevista.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btnNuevaEntrevista.FlatAppearance.BorderSize = 0
        Me.btnNuevaEntrevista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaEntrevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaEntrevista.ForeColor = System.Drawing.Color.White
        Me.btnNuevaEntrevista.Location = New System.Drawing.Point(788, 452)
        Me.btnNuevaEntrevista.Name = "btnNuevaEntrevista"
        Me.btnNuevaEntrevista.Size = New System.Drawing.Size(316, 44)
        Me.btnNuevaEntrevista.TabIndex = 4
        Me.btnNuevaEntrevista.Text = "Nueva entrevista"
        Me.btnNuevaEntrevista.UseVisualStyleBackColor = False
        '
        'btnVerEntrevista
        '
        Me.btnVerEntrevista.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVerEntrevista.BackColor = System.Drawing.Color.White
        Me.btnVerEntrevista.FlatAppearance.BorderSize = 0
        Me.btnVerEntrevista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerEntrevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerEntrevista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVerEntrevista.Location = New System.Drawing.Point(104, 451)
        Me.btnVerEntrevista.Name = "btnVerEntrevista"
        Me.btnVerEntrevista.Size = New System.Drawing.Size(316, 44)
        Me.btnVerEntrevista.TabIndex = 4
        Me.btnVerEntrevista.Text = "Ver entrevista"
        Me.btnVerEntrevista.UseVisualStyleBackColor = False
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
        Me.Panel68.Controls.Add(Me.tituloEntrevistas)
        Me.Panel68.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel68.Location = New System.Drawing.Point(0, 0)
        Me.Panel68.Name = "Panel68"
        Me.Panel68.Size = New System.Drawing.Size(1200, 110)
        Me.Panel68.TabIndex = 0
        '
        'tituloEntrevistas
        '
        Me.tituloEntrevistas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloEntrevistas.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloEntrevistas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloEntrevistas.Location = New System.Drawing.Point(0, 0)
        Me.tituloEntrevistas.Name = "tituloEntrevistas"
        Me.tituloEntrevistas.Size = New System.Drawing.Size(1200, 110)
        Me.tituloEntrevistas.TabIndex = 0
        Me.tituloEntrevistas.Text = "Entrevistas hechas a Nombre, Apellido"
        Me.tituloEntrevistas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'entrevista
        '
        Me.entrevista.Controls.Add(Me.Panel2)
        Me.entrevista.Controls.Add(Me.Panel3)
        Me.entrevista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.entrevista.Location = New System.Drawing.Point(0, 0)
        Me.entrevista.Name = "entrevista"
        Me.entrevista.Size = New System.Drawing.Size(1200, 675)
        Me.entrevista.TabIndex = 20
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
        Me.Panel3.Controls.Add(Me.backEntrevista)
        Me.Panel3.Controls.Add(Me.tituloEntrevista)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1200, 110)
        Me.Panel3.TabIndex = 0
        '
        'backEntrevista
        '
        Me.backEntrevista.BackColor = System.Drawing.Color.Transparent
        Me.backEntrevista.Image = Global.dU_Salud.My.Resources.Resources.back
        Me.backEntrevista.Location = New System.Drawing.Point(24, 26)
        Me.backEntrevista.Name = "backEntrevista"
        Me.backEntrevista.Size = New System.Drawing.Size(73, 71)
        Me.backEntrevista.TabIndex = 4
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
        'diagnosticar
        '
        Me.diagnosticar.Controls.Add(Me.Panel4)
        Me.diagnosticar.Controls.Add(Me.Panel5)
        Me.diagnosticar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.diagnosticar.Location = New System.Drawing.Point(0, 0)
        Me.diagnosticar.Name = "diagnosticar"
        Me.diagnosticar.Size = New System.Drawing.Size(1200, 675)
        Me.diagnosticar.TabIndex = 21
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.diagnosticarError)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.tboxTipo)
        Me.Panel4.Controls.Add(Me.aceptarDiagnosticar)
        Me.Panel4.Controls.Add(Me.tboxDetalles)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 119)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1200, 556)
        Me.Panel4.TabIndex = 2
        '
        'diagnosticarError
        '
        Me.diagnosticarError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diagnosticarError.ForeColor = System.Drawing.Color.Red
        Me.diagnosticarError.Location = New System.Drawing.Point(280, 465)
        Me.diagnosticarError.Name = "diagnosticarError"
        Me.diagnosticarError.Size = New System.Drawing.Size(640, 20)
        Me.diagnosticarError.TabIndex = 20
        Me.diagnosticarError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(111, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 31)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Detalles"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(111, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 31)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tipo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tboxTipo
        '
        Me.tboxTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxTipo.Location = New System.Drawing.Point(280, 60)
        Me.tboxTipo.Margin = New System.Windows.Forms.Padding(5)
        Me.tboxTipo.MaxLength = 32
        Me.tboxTipo.Name = "tboxTipo"
        Me.tboxTipo.Size = New System.Drawing.Size(640, 29)
        Me.tboxTipo.TabIndex = 11
        '
        'aceptarDiagnosticar
        '
        Me.aceptarDiagnosticar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.aceptarDiagnosticar.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.aceptarDiagnosticar.FlatAppearance.BorderSize = 0
        Me.aceptarDiagnosticar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarDiagnosticar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptarDiagnosticar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.aceptarDiagnosticar.Location = New System.Drawing.Point(280, 417)
        Me.aceptarDiagnosticar.Name = "aceptarDiagnosticar"
        Me.aceptarDiagnosticar.Size = New System.Drawing.Size(640, 31)
        Me.aceptarDiagnosticar.TabIndex = 10
        Me.aceptarDiagnosticar.Text = "Aceptar"
        Me.aceptarDiagnosticar.UseVisualStyleBackColor = False
        '
        'tboxDetalles
        '
        Me.tboxDetalles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tboxDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxDetalles.Location = New System.Drawing.Point(280, 115)
        Me.tboxDetalles.Margin = New System.Windows.Forms.Padding(5)
        Me.tboxDetalles.MaxLength = 0
        Me.tboxDetalles.Multiline = True
        Me.tboxDetalles.Name = "tboxDetalles"
        Me.tboxDetalles.Size = New System.Drawing.Size(640, 268)
        Me.tboxDetalles.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.backDiagnosticar)
        Me.Panel5.Controls.Add(Me.tituloDiagnosticar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1200, 119)
        Me.Panel5.TabIndex = 0
        '
        'backDiagnosticar
        '
        Me.backDiagnosticar.BackColor = System.Drawing.Color.Transparent
        Me.backDiagnosticar.Image = Global.dU_Salud.My.Resources.Resources.back
        Me.backDiagnosticar.Location = New System.Drawing.Point(24, 26)
        Me.backDiagnosticar.Name = "backDiagnosticar"
        Me.backDiagnosticar.Size = New System.Drawing.Size(73, 71)
        Me.backDiagnosticar.TabIndex = 4
        '
        'tituloDiagnosticar
        '
        Me.tituloDiagnosticar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tituloDiagnosticar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloDiagnosticar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tituloDiagnosticar.Location = New System.Drawing.Point(0, 0)
        Me.tituloDiagnosticar.Name = "tituloDiagnosticar"
        Me.tituloDiagnosticar.Size = New System.Drawing.Size(1200, 119)
        Me.tituloDiagnosticar.TabIndex = 0
        Me.tituloDiagnosticar.Text = "Diagnosticar entrevista 10/09/2020"
        Me.tituloDiagnosticar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormEntrevistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.listaEntrevistas)
        Me.Controls.Add(Me.diagnosticar)
        Me.Controls.Add(Me.entrevista)
        Me.Name = "FormEntrevistas"
        Me.Text = "Entrevistas"
        Me.listaEntrevistas.ResumeLayout(False)
        Me.Panel67.ResumeLayout(False)
        Me.Panel68.ResumeLayout(False)
        Me.entrevista.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.diagnosticar.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listaEntrevistas As Panel
    Friend WithEvents Panel67 As Panel
    Friend WithEvents btnDiagnosticar As Button
    Friend WithEvents btnNuevaEntrevista As Button
    Friend WithEvents btnVerEntrevista As Button
    Friend WithEvents listEntrevistas As ListBox
    Friend WithEvents Panel68 As Panel
    Friend WithEvents tituloEntrevistas As Label
    Friend WithEvents entrevista As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents listEntrevista As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tituloEntrevista As Label
    Friend WithEvents backEntrevista As Label
    Friend WithEvents diagnosticar As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents backDiagnosticar As Label
    Friend WithEvents tituloDiagnosticar As Label
    Friend WithEvents aceptarDiagnosticar As Button
    Friend WithEvents tboxDetalles As TextBox
    Friend WithEvents tboxTipo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents diagnosticarError As Label
End Class
