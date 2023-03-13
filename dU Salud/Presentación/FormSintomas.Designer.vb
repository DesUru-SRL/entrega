<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSintomas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.main = New System.Windows.Forms.Panel()
        Me.sintomaError = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.aceptarAgregarSintoma = New System.Windows.Forms.Button()
        Me.agregarSintoma = New System.Windows.Forms.Button()
        Me.tboxSintoma = New System.Windows.Forms.TextBox()
        Me.main.SuspendLayout()
        Me.SuspendLayout()
        '
        'main
        '
        Me.main.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.main.Controls.Add(Me.sintomaError)
        Me.main.Controls.Add(Me.Label28)
        Me.main.Controls.Add(Me.aceptarAgregarSintoma)
        Me.main.Controls.Add(Me.agregarSintoma)
        Me.main.Controls.Add(Me.tboxSintoma)
        Me.main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main.Location = New System.Drawing.Point(0, 0)
        Me.main.Name = "main"
        Me.main.Size = New System.Drawing.Size(381, 198)
        Me.main.TabIndex = 4
        '
        'sintomaError
        '
        Me.sintomaError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sintomaError.ForeColor = System.Drawing.Color.Red
        Me.sintomaError.Location = New System.Drawing.Point(16, 99)
        Me.sintomaError.Name = "sintomaError"
        Me.sintomaError.Size = New System.Drawing.Size(353, 20)
        Me.sintomaError.TabIndex = 20
        Me.sintomaError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(14, 17)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(114, 31)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "Sintoma"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aceptarAgregarSintoma
        '
        Me.aceptarAgregarSintoma.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.aceptarAgregarSintoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.aceptarAgregarSintoma.FlatAppearance.BorderSize = 0
        Me.aceptarAgregarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarAgregarSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptarAgregarSintoma.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.aceptarAgregarSintoma.Location = New System.Drawing.Point(16, 149)
        Me.aceptarAgregarSintoma.Name = "aceptarAgregarSintoma"
        Me.aceptarAgregarSintoma.Size = New System.Drawing.Size(353, 31)
        Me.aceptarAgregarSintoma.TabIndex = 5
        Me.aceptarAgregarSintoma.Text = "Aceptar"
        Me.aceptarAgregarSintoma.UseVisualStyleBackColor = False
        '
        'agregarSintoma
        '
        Me.agregarSintoma.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.agregarSintoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.agregarSintoma.FlatAppearance.BorderSize = 0
        Me.agregarSintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregarSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregarSintoma.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.agregarSintoma.Location = New System.Drawing.Point(16, 64)
        Me.agregarSintoma.Name = "agregarSintoma"
        Me.agregarSintoma.Size = New System.Drawing.Size(353, 31)
        Me.agregarSintoma.TabIndex = 5
        Me.agregarSintoma.Text = "Agregar"
        Me.agregarSintoma.UseVisualStyleBackColor = False
        '
        'tboxSintoma
        '
        Me.tboxSintoma.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tboxSintoma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxSintoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxSintoma.Location = New System.Drawing.Point(127, 17)
        Me.tboxSintoma.Margin = New System.Windows.Forms.Padding(5)
        Me.tboxSintoma.MaxLength = 0
        Me.tboxSintoma.Name = "tboxSintoma"
        Me.tboxSintoma.Size = New System.Drawing.Size(242, 31)
        Me.tboxSintoma.TabIndex = 4
        Me.tboxSintoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormSintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 198)
        Me.Controls.Add(Me.main)
        Me.Name = "FormSintomas"
        Me.Text = "Agregar síntomas"
        Me.main.ResumeLayout(False)
        Me.main.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents main As Panel
    Friend WithEvents agregarSintoma As Button
    Friend WithEvents tboxSintoma As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents aceptarAgregarSintoma As Button
    Friend WithEvents sintomaError As Label
End Class
