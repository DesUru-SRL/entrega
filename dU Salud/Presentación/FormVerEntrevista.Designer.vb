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
        Me.listaEntrevistas.SuspendLayout()
        Me.Panel67.SuspendLayout()
        Me.Panel68.SuspendLayout()
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
        'FormEntrevistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.listaEntrevistas)
        Me.Name = "FormEntrevistas"
        Me.Text = "Entrevistas"
        Me.listaEntrevistas.ResumeLayout(False)
        Me.Panel67.ResumeLayout(False)
        Me.Panel68.ResumeLayout(False)
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
End Class
