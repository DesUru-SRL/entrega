<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFormularios
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
        Me.mainFormularios = New System.Windows.Forms.Panel()
        Me.btnFisico = New System.Windows.Forms.Label()
        Me.btnDolor = New System.Windows.Forms.Label()
        Me.btnFiebre = New System.Windows.Forms.Label()
        Me.btnGlaslow = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.titleFormularios = New System.Windows.Forms.Label()
        Me.mainFormulariosAceptar = New System.Windows.Forms.Button()
        Me.glaslow = New System.Windows.Forms.Panel()
        Me.glasgowError = New System.Windows.Forms.Label()
        Me.tboxRMotora = New System.Windows.Forms.TextBox()
        Me.tboxRVerbal = New System.Windows.Forms.TextBox()
        Me.tboxROcular = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.glaslowAceptar = New System.Windows.Forms.Button()
        Me.fiebre = New System.Windows.Forms.Panel()
        Me.fiebreError = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tboxFiebre = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fiebreAceptar = New System.Windows.Forms.Button()
        Me.dolor = New System.Windows.Forms.Panel()
        Me.evaValor = New System.Windows.Forms.Label()
        Me.TrackBarEVA = New System.Windows.Forms.TrackBar()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.aceptarDolor = New System.Windows.Forms.Button()
        Me.fisico = New System.Windows.Forms.Panel()
        Me.fisicoError = New System.Windows.Forms.Label()
        Me.boxMamas = New System.Windows.Forms.ComboBox()
        Me.boxLinfogag = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.boxCuello = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.boxPiel = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.fisicoAceptar = New System.Windows.Forms.Button()
        Me.mainFormularios.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.glaslow.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.fiebre.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.dolor.SuspendLayout()
        CType(Me.TrackBarEVA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.fisico.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainFormularios
        '
        Me.mainFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.mainFormularios.Controls.Add(Me.btnFisico)
        Me.mainFormularios.Controls.Add(Me.btnDolor)
        Me.mainFormularios.Controls.Add(Me.btnFiebre)
        Me.mainFormularios.Controls.Add(Me.btnGlaslow)
        Me.mainFormularios.Controls.Add(Me.Panel2)
        Me.mainFormularios.Controls.Add(Me.mainFormulariosAceptar)
        Me.mainFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainFormularios.Location = New System.Drawing.Point(0, 0)
        Me.mainFormularios.Name = "mainFormularios"
        Me.mainFormularios.Size = New System.Drawing.Size(596, 675)
        Me.mainFormularios.TabIndex = 1
        '
        'btnFisico
        '
        Me.btnFisico.Image = Global.dU_Salud.My.Resources.Resources.fisico
        Me.btnFisico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFisico.Location = New System.Drawing.Point(321, 348)
        Me.btnFisico.Name = "btnFisico"
        Me.btnFisico.Size = New System.Drawing.Size(160, 160)
        Me.btnFisico.TabIndex = 4
        '
        'btnDolor
        '
        Me.btnDolor.Image = Global.dU_Salud.My.Resources.Resources.dolor
        Me.btnDolor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDolor.Location = New System.Drawing.Point(115, 348)
        Me.btnDolor.Name = "btnDolor"
        Me.btnDolor.Size = New System.Drawing.Size(160, 160)
        Me.btnDolor.TabIndex = 4
        '
        'btnFiebre
        '
        Me.btnFiebre.Image = Global.dU_Salud.My.Resources.Resources.fiebre
        Me.btnFiebre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFiebre.Location = New System.Drawing.Point(321, 140)
        Me.btnFiebre.Name = "btnFiebre"
        Me.btnFiebre.Size = New System.Drawing.Size(160, 160)
        Me.btnFiebre.TabIndex = 4
        '
        'btnGlaslow
        '
        Me.btnGlaslow.Image = Global.dU_Salud.My.Resources.Resources.glaslow
        Me.btnGlaslow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGlaslow.Location = New System.Drawing.Point(115, 140)
        Me.btnGlaslow.Name = "btnGlaslow"
        Me.btnGlaslow.Size = New System.Drawing.Size(160, 160)
        Me.btnGlaslow.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.titleFormularios)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(596, 118)
        Me.Panel2.TabIndex = 11
        '
        'titleFormularios
        '
        Me.titleFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titleFormularios.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleFormularios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.titleFormularios.Location = New System.Drawing.Point(0, 0)
        Me.titleFormularios.Name = "titleFormularios"
        Me.titleFormularios.Size = New System.Drawing.Size(596, 118)
        Me.titleFormularios.TabIndex = 10
        Me.titleFormularios.Text = "Formularios"
        Me.titleFormularios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mainFormulariosAceptar
        '
        Me.mainFormulariosAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mainFormulariosAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.mainFormulariosAceptar.FlatAppearance.BorderSize = 0
        Me.mainFormulariosAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mainFormulariosAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainFormulariosAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mainFormulariosAceptar.Location = New System.Drawing.Point(123, 583)
        Me.mainFormulariosAceptar.Name = "mainFormulariosAceptar"
        Me.mainFormulariosAceptar.Size = New System.Drawing.Size(353, 37)
        Me.mainFormulariosAceptar.TabIndex = 8
        Me.mainFormulariosAceptar.Text = "Aceptar"
        Me.mainFormulariosAceptar.UseVisualStyleBackColor = False
        '
        'glaslow
        '
        Me.glaslow.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.glaslow.Controls.Add(Me.glasgowError)
        Me.glaslow.Controls.Add(Me.tboxRMotora)
        Me.glaslow.Controls.Add(Me.tboxRVerbal)
        Me.glaslow.Controls.Add(Me.tboxROcular)
        Me.glaslow.Controls.Add(Me.Label4)
        Me.glaslow.Controls.Add(Me.Label2)
        Me.glaslow.Controls.Add(Me.Label1)
        Me.glaslow.Controls.Add(Me.Panel3)
        Me.glaslow.Controls.Add(Me.glaslowAceptar)
        Me.glaslow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.glaslow.Location = New System.Drawing.Point(0, 0)
        Me.glaslow.Name = "glaslow"
        Me.glaslow.Size = New System.Drawing.Size(596, 675)
        Me.glaslow.TabIndex = 2
        '
        'glasgowError
        '
        Me.glasgowError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glasgowError.ForeColor = System.Drawing.Color.Red
        Me.glasgowError.Location = New System.Drawing.Point(117, 624)
        Me.glasgowError.Name = "glasgowError"
        Me.glasgowError.Size = New System.Drawing.Size(363, 20)
        Me.glasgowError.TabIndex = 16
        Me.glasgowError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tboxRMotora
        '
        Me.tboxRMotora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tboxRMotora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxRMotora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxRMotora.Location = New System.Drawing.Point(177, 427)
        Me.tboxRMotora.Margin = New System.Windows.Forms.Padding(5)
        Me.tboxRMotora.MaxLength = 2
        Me.tboxRMotora.Name = "tboxRMotora"
        Me.tboxRMotora.Size = New System.Drawing.Size(242, 31)
        Me.tboxRMotora.TabIndex = 15
        Me.tboxRMotora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tboxRVerbal
        '
        Me.tboxRVerbal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tboxRVerbal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxRVerbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxRVerbal.Location = New System.Drawing.Point(177, 314)
        Me.tboxRVerbal.Margin = New System.Windows.Forms.Padding(5)
        Me.tboxRVerbal.MaxLength = 2
        Me.tboxRVerbal.Name = "tboxRVerbal"
        Me.tboxRVerbal.Size = New System.Drawing.Size(242, 31)
        Me.tboxRVerbal.TabIndex = 15
        Me.tboxRVerbal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tboxROcular
        '
        Me.tboxROcular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tboxROcular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxROcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxROcular.Location = New System.Drawing.Point(177, 202)
        Me.tboxROcular.Margin = New System.Windows.Forms.Padding(5)
        Me.tboxROcular.MaxLength = 2
        Me.tboxROcular.Name = "tboxROcular"
        Me.tboxROcular.Size = New System.Drawing.Size(242, 31)
        Me.tboxROcular.TabIndex = 15
        Me.tboxROcular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(572, 37)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Reacción motora"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(572, 37)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Reacción verbal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(572, 37)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Reacción ocular"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(596, 118)
        Me.Panel3.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(596, 118)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Glasgow"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'glaslowAceptar
        '
        Me.glaslowAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.glaslowAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.glaslowAceptar.FlatAppearance.BorderSize = 0
        Me.glaslowAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.glaslowAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glaslowAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.glaslowAceptar.Location = New System.Drawing.Point(123, 583)
        Me.glaslowAceptar.Name = "glaslowAceptar"
        Me.glaslowAceptar.Size = New System.Drawing.Size(353, 37)
        Me.glaslowAceptar.TabIndex = 8
        Me.glaslowAceptar.Text = "Aceptar"
        Me.glaslowAceptar.UseVisualStyleBackColor = False
        '
        'fiebre
        '
        Me.fiebre.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.fiebre.Controls.Add(Me.fiebreError)
        Me.fiebre.Controls.Add(Me.Label6)
        Me.fiebre.Controls.Add(Me.tboxFiebre)
        Me.fiebre.Controls.Add(Me.Panel4)
        Me.fiebre.Controls.Add(Me.fiebreAceptar)
        Me.fiebre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fiebre.Location = New System.Drawing.Point(0, 0)
        Me.fiebre.Name = "fiebre"
        Me.fiebre.Size = New System.Drawing.Size(596, 675)
        Me.fiebre.TabIndex = 3
        '
        'fiebreError
        '
        Me.fiebreError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiebreError.ForeColor = System.Drawing.Color.Red
        Me.fiebreError.Location = New System.Drawing.Point(118, 623)
        Me.fiebreError.Name = "fiebreError"
        Me.fiebreError.Size = New System.Drawing.Size(363, 20)
        Me.fiebreError.TabIndex = 13
        Me.fiebreError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(65, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 37)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Detalles"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tboxFiebre
        '
        Me.tboxFiebre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tboxFiebre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxFiebre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxFiebre.Location = New System.Drawing.Point(80, 145)
        Me.tboxFiebre.Margin = New System.Windows.Forms.Padding(5)
        Me.tboxFiebre.MaxLength = 0
        Me.tboxFiebre.Multiline = True
        Me.tboxFiebre.Name = "tboxFiebre"
        Me.tboxFiebre.Size = New System.Drawing.Size(440, 388)
        Me.tboxFiebre.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(596, 118)
        Me.Panel4.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(596, 118)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Fiebre"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fiebreAceptar
        '
        Me.fiebreAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fiebreAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.fiebreAceptar.FlatAppearance.BorderSize = 0
        Me.fiebreAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fiebreAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiebreAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.fiebreAceptar.Location = New System.Drawing.Point(123, 583)
        Me.fiebreAceptar.Name = "fiebreAceptar"
        Me.fiebreAceptar.Size = New System.Drawing.Size(353, 37)
        Me.fiebreAceptar.TabIndex = 8
        Me.fiebreAceptar.Text = "Aceptar"
        Me.fiebreAceptar.UseVisualStyleBackColor = False
        '
        'dolor
        '
        Me.dolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.dolor.Controls.Add(Me.evaValor)
        Me.dolor.Controls.Add(Me.TrackBarEVA)
        Me.dolor.Controls.Add(Me.Label12)
        Me.dolor.Controls.Add(Me.Label11)
        Me.dolor.Controls.Add(Me.Panel5)
        Me.dolor.Controls.Add(Me.aceptarDolor)
        Me.dolor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dolor.Location = New System.Drawing.Point(0, 0)
        Me.dolor.Name = "dolor"
        Me.dolor.Size = New System.Drawing.Size(596, 675)
        Me.dolor.TabIndex = 4
        '
        'evaValor
        '
        Me.evaValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.evaValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.evaValor.Location = New System.Drawing.Point(9, 367)
        Me.evaValor.Name = "evaValor"
        Me.evaValor.Size = New System.Drawing.Size(577, 159)
        Me.evaValor.TabIndex = 18
        Me.evaValor.Text = "0"
        Me.evaValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackBarEVA
        '
        Me.TrackBarEVA.LargeChange = 1
        Me.TrackBarEVA.Location = New System.Drawing.Point(30, 294)
        Me.TrackBarEVA.Name = "TrackBarEVA"
        Me.TrackBarEVA.Size = New System.Drawing.Size(539, 45)
        Me.TrackBarEVA.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(421, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(163, 71)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Dolor insoportable"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(12, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 37)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Sin dolor"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(596, 118)
        Me.Panel5.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(596, 118)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Escala visual analógica"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aceptarDolor
        '
        Me.aceptarDolor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.aceptarDolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.aceptarDolor.FlatAppearance.BorderSize = 0
        Me.aceptarDolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarDolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptarDolor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.aceptarDolor.Location = New System.Drawing.Point(123, 583)
        Me.aceptarDolor.Name = "aceptarDolor"
        Me.aceptarDolor.Size = New System.Drawing.Size(353, 37)
        Me.aceptarDolor.TabIndex = 8
        Me.aceptarDolor.Text = "Aceptar"
        Me.aceptarDolor.UseVisualStyleBackColor = False
        '
        'fisico
        '
        Me.fisico.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.fisico.Controls.Add(Me.fisicoError)
        Me.fisico.Controls.Add(Me.boxMamas)
        Me.fisico.Controls.Add(Me.boxLinfogag)
        Me.fisico.Controls.Add(Me.Label9)
        Me.fisico.Controls.Add(Me.boxCuello)
        Me.fisico.Controls.Add(Me.Label8)
        Me.fisico.Controls.Add(Me.boxPiel)
        Me.fisico.Controls.Add(Me.Label7)
        Me.fisico.Controls.Add(Me.Label3)
        Me.fisico.Controls.Add(Me.Panel6)
        Me.fisico.Controls.Add(Me.fisicoAceptar)
        Me.fisico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fisico.Location = New System.Drawing.Point(0, 0)
        Me.fisico.Name = "fisico"
        Me.fisico.Size = New System.Drawing.Size(596, 675)
        Me.fisico.TabIndex = 5
        '
        'fisicoError
        '
        Me.fisicoError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fisicoError.ForeColor = System.Drawing.Color.Red
        Me.fisicoError.Location = New System.Drawing.Point(116, 624)
        Me.fisicoError.Name = "fisicoError"
        Me.fisicoError.Size = New System.Drawing.Size(363, 20)
        Me.fisicoError.TabIndex = 18
        Me.fisicoError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'boxMamas
        '
        Me.boxMamas.DropDownHeight = 109
        Me.boxMamas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxMamas.FormattingEnabled = True
        Me.boxMamas.IntegralHeight = False
        Me.boxMamas.Location = New System.Drawing.Point(181, 504)
        Me.boxMamas.Name = "boxMamas"
        Me.boxMamas.Size = New System.Drawing.Size(234, 28)
        Me.boxMamas.TabIndex = 16
        '
        'boxLinfogag
        '
        Me.boxLinfogag.DropDownHeight = 109
        Me.boxLinfogag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxLinfogag.FormattingEnabled = True
        Me.boxLinfogag.IntegralHeight = False
        Me.boxLinfogag.Location = New System.Drawing.Point(181, 394)
        Me.boxLinfogag.Name = "boxLinfogag"
        Me.boxLinfogag.Size = New System.Drawing.Size(234, 28)
        Me.boxLinfogag.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(12, 452)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(572, 37)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Mamas"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'boxCuello
        '
        Me.boxCuello.DropDownHeight = 109
        Me.boxCuello.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxCuello.FormattingEnabled = True
        Me.boxCuello.IntegralHeight = False
        Me.boxCuello.Location = New System.Drawing.Point(181, 284)
        Me.boxCuello.Name = "boxCuello"
        Me.boxCuello.Size = New System.Drawing.Size(234, 28)
        Me.boxCuello.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(12, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(572, 37)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Linfogaglionar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'boxPiel
        '
        Me.boxPiel.DropDownHeight = 109
        Me.boxPiel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxPiel.FormattingEnabled = True
        Me.boxPiel.IntegralHeight = False
        Me.boxPiel.Items.AddRange(New Object() {"Normal", "Pálido", "Eritematoso", "Cianótico", "Ictérico"})
        Me.boxPiel.Location = New System.Drawing.Point(181, 174)
        Me.boxPiel.Name = "boxPiel"
        Me.boxPiel.Size = New System.Drawing.Size(234, 28)
        Me.boxPiel.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(572, 37)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cuello"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(572, 37)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Piel (Coloración)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(596, 118)
        Me.Panel6.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(0, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(596, 118)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Físico"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fisicoAceptar
        '
        Me.fisicoAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fisicoAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.fisicoAceptar.FlatAppearance.BorderSize = 0
        Me.fisicoAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fisicoAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fisicoAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.fisicoAceptar.Location = New System.Drawing.Point(123, 583)
        Me.fisicoAceptar.Name = "fisicoAceptar"
        Me.fisicoAceptar.Size = New System.Drawing.Size(353, 37)
        Me.fisicoAceptar.TabIndex = 8
        Me.fisicoAceptar.Text = "Aceptar"
        Me.fisicoAceptar.UseVisualStyleBackColor = False
        '
        'FormFormularios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(596, 675)
        Me.Controls.Add(Me.mainFormularios)
        Me.Controls.Add(Me.fiebre)
        Me.Controls.Add(Me.dolor)
        Me.Controls.Add(Me.fisico)
        Me.Controls.Add(Me.glaslow)
        Me.Name = "FormFormularios"
        Me.Text = "Formularios"
        Me.mainFormularios.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.glaslow.ResumeLayout(False)
        Me.glaslow.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.fiebre.ResumeLayout(False)
        Me.fiebre.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.dolor.ResumeLayout(False)
        Me.dolor.PerformLayout()
        CType(Me.TrackBarEVA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.fisico.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainFormularios As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents titleFormularios As Label
    Friend WithEvents mainFormulariosAceptar As Button
    Friend WithEvents btnFisico As Label
    Friend WithEvents btnDolor As Label
    Friend WithEvents btnFiebre As Label
    Friend WithEvents btnGlaslow As Label
    Friend WithEvents glaslow As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents glaslowAceptar As Button
    Friend WithEvents fiebre As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents fiebreAceptar As Button
    Friend WithEvents dolor As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents aceptarDolor As Button
    Friend WithEvents fisico As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents fisicoAceptar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tboxFiebre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tboxRMotora As TextBox
    Friend WithEvents tboxRVerbal As TextBox
    Friend WithEvents tboxROcular As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents boxMamas As ComboBox
    Friend WithEvents boxLinfogag As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents boxCuello As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents boxPiel As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents evaValor As Label
    Friend WithEvents TrackBarEVA As TrackBar
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents fiebreError As Label
    Friend WithEvents glasgowError As Label
    Friend WithEvents fisicoError As Label
End Class
