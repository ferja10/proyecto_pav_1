<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alta_empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alta_empleados))
        Me.pnl_datos_personales = New System.Windows.Forms.Panel()
        Me.msk_documento = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.lbl_tipo_documento = New System.Windows.Forms.Label()
        Me.msk_matricula = New System.Windows.Forms.MaskedTextBox()
        Me.dtp_fecha_ingreso = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha_nac = New System.Windows.Forms.DateTimePicker()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.rdo_no = New System.Windows.Forms.RadioButton()
        Me.rdo_si = New System.Windows.Forms.RadioButton()
        Me.lbl_recibido = New System.Windows.Forms.Label()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.lbl_fecha_ingreso = New System.Windows.Forms.Label()
        Me.lbl_fecha_nac = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.pnl_buscar = New System.Windows.Forms.Panel()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.lbl_nombre_sucursal = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.lbl_apellido_a_buscar = New System.Windows.Forms.Label()
        Me.txt_apellido_filtro = New System.Windows.Forms.TextBox()
        Me.dgv_empleados = New System.Windows.Forms.DataGridView()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.pnl_datos_personales.SuspendLayout()
        Me.pnl_buscar.SuspendLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_datos_personales
        '
        Me.pnl_datos_personales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_datos_personales.Controls.Add(Me.msk_documento)
        Me.pnl_datos_personales.Controls.Add(Me.cmb_tipo_documento)
        Me.pnl_datos_personales.Controls.Add(Me.lbl_documento)
        Me.pnl_datos_personales.Controls.Add(Me.lbl_tipo_documento)
        Me.pnl_datos_personales.Controls.Add(Me.msk_matricula)
        Me.pnl_datos_personales.Controls.Add(Me.dtp_fecha_ingreso)
        Me.pnl_datos_personales.Controls.Add(Me.dtp_fecha_nac)
        Me.pnl_datos_personales.Controls.Add(Me.txt_apellido)
        Me.pnl_datos_personales.Controls.Add(Me.txt_nombre)
        Me.pnl_datos_personales.Controls.Add(Me.rdo_no)
        Me.pnl_datos_personales.Controls.Add(Me.rdo_si)
        Me.pnl_datos_personales.Controls.Add(Me.lbl_recibido)
        Me.pnl_datos_personales.Controls.Add(Me.lbl_matricula)
        Me.pnl_datos_personales.Controls.Add(Me.lbl_fecha_ingreso)
        Me.pnl_datos_personales.Controls.Add(Me.lbl_fecha_nac)
        Me.pnl_datos_personales.Controls.Add(Me.lbl_apellido)
        Me.pnl_datos_personales.Controls.Add(Me.lbl_nombre)
        Me.pnl_datos_personales.Enabled = False
        Me.pnl_datos_personales.Location = New System.Drawing.Point(12, 35)
        Me.pnl_datos_personales.Name = "pnl_datos_personales"
        Me.pnl_datos_personales.Size = New System.Drawing.Size(709, 333)
        Me.pnl_datos_personales.TabIndex = 0
        '
        'msk_documento
        '
        Me.msk_documento.Location = New System.Drawing.Point(131, 152)
        Me.msk_documento.Mask = "99999999"
        Me.msk_documento.Name = "msk_documento"
        Me.msk_documento.Size = New System.Drawing.Size(60, 20)
        Me.msk_documento.TabIndex = 4
        '
        'cmb_tipo_documento
        '
        Me.cmb_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_documento.FormattingEnabled = True
        Me.cmb_tipo_documento.Location = New System.Drawing.Point(131, 111)
        Me.cmb_tipo_documento.Name = "cmb_tipo_documento"
        Me.cmb_tipo_documento.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipo_documento.TabIndex = 3
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Location = New System.Drawing.Point(63, 155)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(62, 13)
        Me.lbl_documento.TabIndex = 16
        Me.lbl_documento.Text = "Documento"
        '
        'lbl_tipo_documento
        '
        Me.lbl_tipo_documento.AutoSize = True
        Me.lbl_tipo_documento.Location = New System.Drawing.Point(41, 114)
        Me.lbl_tipo_documento.Name = "lbl_tipo_documento"
        Me.lbl_tipo_documento.Size = New System.Drawing.Size(84, 13)
        Me.lbl_tipo_documento.TabIndex = 15
        Me.lbl_tipo_documento.Text = "Tipo documento"
        '
        'msk_matricula
        '
        Me.msk_matricula.Enabled = False
        Me.msk_matricula.Location = New System.Drawing.Point(321, 276)
        Me.msk_matricula.Mask = "99999"
        Me.msk_matricula.Name = "msk_matricula"
        Me.msk_matricula.Size = New System.Drawing.Size(41, 20)
        Me.msk_matricula.TabIndex = 9
        Me.msk_matricula.ValidatingType = GetType(Integer)
        '
        'dtp_fecha_ingreso
        '
        Me.dtp_fecha_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_ingreso.Location = New System.Drawing.Point(131, 236)
        Me.dtp_fecha_ingreso.Name = "dtp_fecha_ingreso"
        Me.dtp_fecha_ingreso.Size = New System.Drawing.Size(96, 20)
        Me.dtp_fecha_ingreso.TabIndex = 6
        '
        'dtp_fecha_nac
        '
        Me.dtp_fecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_nac.Location = New System.Drawing.Point(131, 191)
        Me.dtp_fecha_nac.Name = "dtp_fecha_nac"
        Me.dtp_fecha_nac.Size = New System.Drawing.Size(96, 20)
        Me.dtp_fecha_nac.TabIndex = 5
        '
        'txt_apellido
        '
        Me.txt_apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellido.Location = New System.Drawing.Point(131, 60)
        Me.txt_apellido.MaxLength = 50
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(465, 20)
        Me.txt_apellido.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Location = New System.Drawing.Point(131, 15)
        Me.txt_nombre.MaxLength = 50
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(465, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'rdo_no
        '
        Me.rdo_no.AutoSize = True
        Me.rdo_no.Location = New System.Drawing.Point(188, 279)
        Me.rdo_no.Name = "rdo_no"
        Me.rdo_no.Size = New System.Drawing.Size(39, 17)
        Me.rdo_no.TabIndex = 8
        Me.rdo_no.TabStop = True
        Me.rdo_no.Text = "No"
        Me.rdo_no.UseVisualStyleBackColor = True
        '
        'rdo_si
        '
        Me.rdo_si.AutoSize = True
        Me.rdo_si.Location = New System.Drawing.Point(142, 279)
        Me.rdo_si.Name = "rdo_si"
        Me.rdo_si.Size = New System.Drawing.Size(34, 17)
        Me.rdo_si.TabIndex = 7
        Me.rdo_si.TabStop = True
        Me.rdo_si.Text = "Si"
        Me.rdo_si.UseVisualStyleBackColor = True
        '
        'lbl_recibido
        '
        Me.lbl_recibido.AutoSize = True
        Me.lbl_recibido.Location = New System.Drawing.Point(76, 283)
        Me.lbl_recibido.Name = "lbl_recibido"
        Me.lbl_recibido.Size = New System.Drawing.Size(49, 13)
        Me.lbl_recibido.TabIndex = 5
        Me.lbl_recibido.Text = "Recibido"
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Location = New System.Drawing.Point(265, 279)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(50, 13)
        Me.lbl_matricula.TabIndex = 4
        Me.lbl_matricula.Text = "Matricula"
        '
        'lbl_fecha_ingreso
        '
        Me.lbl_fecha_ingreso.AutoSize = True
        Me.lbl_fecha_ingreso.Location = New System.Drawing.Point(51, 242)
        Me.lbl_fecha_ingreso.Name = "lbl_fecha_ingreso"
        Me.lbl_fecha_ingreso.Size = New System.Drawing.Size(74, 13)
        Me.lbl_fecha_ingreso.TabIndex = 3
        Me.lbl_fecha_ingreso.Text = "Fecha ingreso"
        '
        'lbl_fecha_nac
        '
        Me.lbl_fecha_nac.AutoSize = True
        Me.lbl_fecha_nac.Location = New System.Drawing.Point(17, 197)
        Me.lbl_fecha_nac.Name = "lbl_fecha_nac"
        Me.lbl_fecha_nac.Size = New System.Drawing.Size(108, 13)
        Me.lbl_fecha_nac.TabIndex = 2
        Me.lbl_fecha_nac.Text = "Fecha de Nacimiento"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(81, 67)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(81, 18)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(18, 396)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(45, 43)
        Me.btn_nuevo.TabIndex = 3
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.Location = New System.Drawing.Point(12, 397)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(45, 37)
        Me.btn_guardar.TabIndex = 13
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.AutoSize = True
        Me.lbl_sucursal.Location = New System.Drawing.Point(14, 9)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(53, 13)
        Me.lbl_sucursal.TabIndex = 17
        Me.lbl_sucursal.Text = "SUC XXX"
        '
        'btn_buscar
        '
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(114, 397)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(45, 37)
        Me.btn_buscar.TabIndex = 15
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'pnl_buscar
        '
        Me.pnl_buscar.Controls.Add(Me.btn_eliminar)
        Me.pnl_buscar.Controls.Add(Me.lbl_nombre_sucursal)
        Me.pnl_buscar.Controls.Add(Me.btn_salir)
        Me.pnl_buscar.Controls.Add(Me.lbl_apellido_a_buscar)
        Me.pnl_buscar.Controls.Add(Me.txt_apellido_filtro)
        Me.pnl_buscar.Controls.Add(Me.btn_nuevo)
        Me.pnl_buscar.Controls.Add(Me.dgv_empleados)
        Me.pnl_buscar.Location = New System.Drawing.Point(-1, 1)
        Me.pnl_buscar.Name = "pnl_buscar"
        Me.pnl_buscar.Size = New System.Drawing.Size(736, 443)
        Me.pnl_buscar.TabIndex = 18
        '
        'btn_eliminar
        '
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(75, 396)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(45, 43)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'lbl_nombre_sucursal
        '
        Me.lbl_nombre_sucursal.AutoSize = True
        Me.lbl_nombre_sucursal.Location = New System.Drawing.Point(9, 21)
        Me.lbl_nombre_sucursal.Name = "lbl_nombre_sucursal"
        Me.lbl_nombre_sucursal.Size = New System.Drawing.Size(39, 13)
        Me.lbl_nombre_sucursal.TabIndex = 3
        Me.lbl_nombre_sucursal.Text = "Label1"
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(671, 399)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(45, 37)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'lbl_apellido_a_buscar
        '
        Me.lbl_apellido_a_buscar.AutoSize = True
        Me.lbl_apellido_a_buscar.Location = New System.Drawing.Point(72, 54)
        Me.lbl_apellido_a_buscar.Name = "lbl_apellido_a_buscar"
        Me.lbl_apellido_a_buscar.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido_a_buscar.TabIndex = 2
        Me.lbl_apellido_a_buscar.Text = "Apellido"
        '
        'txt_apellido_filtro
        '
        Me.txt_apellido_filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellido_filtro.Location = New System.Drawing.Point(122, 51)
        Me.txt_apellido_filtro.MaxLength = 50
        Me.txt_apellido_filtro.Name = "txt_apellido_filtro"
        Me.txt_apellido_filtro.Size = New System.Drawing.Size(452, 20)
        Me.txt_apellido_filtro.TabIndex = 1
        '
        'dgv_empleados
        '
        Me.dgv_empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_empleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgv_empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_empleados.Location = New System.Drawing.Point(12, 96)
        Me.dgv_empleados.Name = "dgv_empleados"
        Me.dgv_empleados.ReadOnly = True
        Me.dgv_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_empleados.Size = New System.Drawing.Size(704, 284)
        Me.dgv_empleados.TabIndex = 2
        Me.dgv_empleados.TabStop = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(63, 397)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(45, 37)
        Me.btn_cancelar.TabIndex = 14
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_alta_empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(733, 440)
        Me.Controls.Add(Me.pnl_buscar)
        Me.Controls.Add(Me.lbl_sucursal)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.pnl_datos_personales)
        Me.Controls.Add(Me.btn_cancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_alta_empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Empleados"
        Me.pnl_datos_personales.ResumeLayout(False)
        Me.pnl_datos_personales.PerformLayout()
        Me.pnl_buscar.ResumeLayout(False)
        Me.pnl_buscar.PerformLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_datos_personales As System.Windows.Forms.Panel
    Friend WithEvents msk_documento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_documento As System.Windows.Forms.Label
    Friend WithEvents msk_matricula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtp_fecha_ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_nac As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents rdo_no As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_si As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_recibido As System.Windows.Forms.Label
    Friend WithEvents lbl_matricula As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_ingreso As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_nac As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_sucursal As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents pnl_buscar As System.Windows.Forms.Panel
    Friend WithEvents lbl_apellido_a_buscar As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_filtro As System.Windows.Forms.TextBox
    Friend WithEvents dgv_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents lbl_nombre_sucursal As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button

End Class
