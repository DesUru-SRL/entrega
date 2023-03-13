<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMotivo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.aceptarAgregarMotivo = New System.Windows.Forms.Button()
        Me.tboxMotivo = New System.Windows.Forms.TextBox()
        Me.motivoError = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel1.Controls.Add(Me.motivoError)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.aceptarAgregarMotivo)
        Me.Panel1.Controls.Add(Me.tboxMotivo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 466)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(491, 94)
        Me.Panel2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(491, 94)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Motivo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aceptarAgregarMotivo
        '
        Me.aceptarAgregarMotivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.aceptarAgregarMotivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.aceptarAgregarMotivo.FlatAppearance.BorderSize = 0
        Me.aceptarAgregarMotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarAgregarMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptarAgregarMotivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.aceptarAgregarMotivo.Location = New System.Drawing.Point(70, 374)
        Me.aceptarAgregarMotivo.Name = "aceptarAgregarMotivo"
        Me.aceptarAgregarMotivo.Size = New System.Drawing.Size(353, 31)
        Me.aceptarAgregarMotivo.TabIndex = 8
        Me.aceptarAgregarMotivo.Text = "Aceptar"
        Me.aceptarAgregarMotivo.UseVisualStyleBackColor = False
        '
        'tboxMotivo
        '
        Me.tboxMotivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tboxMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxMotivo.Location = New System.Drawing.Point(70, 99)
        Me.tboxMotivo.Margin = New System.Windows.Forms.Padding(5)
        Me.tboxMotivo.MaxLength = 0
        Me.tboxMotivo.Multiline = True
        Me.tboxMotivo.Name = "tboxMotivo"
        Me.tboxMotivo.Size = New System.Drawing.Size(353, 231)
        Me.tboxMotivo.TabIndex = 7
        '
        'motivoError
        '
        Me.motivoError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motivoError.ForeColor = System.Drawing.Color.Red
        Me.motivoError.Location = New System.Drawing.Point(70, 409)
        Me.motivoError.Name = "motivoError"
        Me.motivoError.Size = New System.Drawing.Size(353, 20)
        Me.motivoError.TabIndex = 21
        Me.motivoError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Motivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 466)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Motivo"
        Me.Text = "Motivo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents aceptarAgregarMotivo As Button
    Friend WithEvents tboxMotivo As TextBox
    Friend WithEvents motivoError As Label
End Class
