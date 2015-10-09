<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_consulta_medica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_consulta_medica))
        Me.lbl_fecha_entrada = New System.Windows.Forms.Label()
        Me.lbl_fecha_salida = New System.Windows.Forms.Label()
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.lbl_nro_consulta = New System.Windows.Forms.Label()
        Me.lbl_nro_historia_clinica = New System.Windows.Forms.Label()
        Me.lbl_nombre_perro = New System.Windows.Forms.Label()
        Me.lbl_raza = New System.Windows.Forms.Label()
        Me.pnl_detalle = New System.Windows.Forms.Panel()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.dgv_id_diagnostico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_diagnostico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_fecha_entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_fecha_salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_tipo_doc_empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_nro_doc_empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_nombre_empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_doctor = New System.Windows.Forms.ComboBox()
        Me.cmb_diagnostico = New System.Windows.Forms.ComboBox()
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.dtp_fecha_salida = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Diagnostico = New System.Windows.Forms.Label()
        Me.dtp_fecha_entrada = New System.Windows.Forms.DateTimePicker()
        Me.txt_sucursal = New System.Windows.Forms.TextBox()
        Me.txt_cod_consulta = New System.Windows.Forms.TextBox()
        Me.msk_historia_clinica = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre_perro = New System.Windows.Forms.TextBox()
        Me.txt_raza = New System.Windows.Forms.TextBox()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_buscar_hc = New System.Windows.Forms.Button()
        Me.pnl_detalle.SuspendLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_fecha_entrada
        '
        Me.lbl_fecha_entrada.AutoSize = True
        Me.lbl_fecha_entrada.Location = New System.Drawing.Point(3, 11)
        Me.lbl_fecha_entrada.Name = "lbl_fecha_entrada"
        Me.lbl_fecha_entrada.Size = New System.Drawing.Size(77, 13)
        Me.lbl_fecha_entrada.TabIndex = 0
        Me.lbl_fecha_entrada.Text = "Fecha Entrada"
        '
        'lbl_fecha_salida
        '
        Me.lbl_fecha_salida.AutoSize = True
        Me.lbl_fecha_salida.Location = New System.Drawing.Point(203, 12)
        Me.lbl_fecha_salida.Name = "lbl_fecha_salida"
        Me.lbl_fecha_salida.Size = New System.Drawing.Size(69, 13)
        Me.lbl_fecha_salida.TabIndex = 1
        Me.lbl_fecha_salida.Text = "Fecha Salida"
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.AutoSize = True
        Me.lbl_sucursal.Location = New System.Drawing.Point(41, 50)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(48, 13)
        Me.lbl_sucursal.TabIndex = 2
        Me.lbl_sucursal.Text = "Sucursal"
        '
        'lbl_nro_consulta
        '
        Me.lbl_nro_consulta.AutoSize = True
        Me.lbl_nro_consulta.Location = New System.Drawing.Point(393, 15)
        Me.lbl_nro_consulta.Name = "lbl_nro_consulta"
        Me.lbl_nro_consulta.Size = New System.Drawing.Size(99, 13)
        Me.lbl_nro_consulta.TabIndex = 3
        Me.lbl_nro_consulta.Text = "Codigo de Consulta"
        '
        'lbl_nro_historia_clinica
        '
        Me.lbl_nro_historia_clinica.AutoSize = True
        Me.lbl_nro_historia_clinica.Location = New System.Drawing.Point(11, 91)
        Me.lbl_nro_historia_clinica.Name = "lbl_nro_historia_clinica"
        Me.lbl_nro_historia_clinica.Size = New System.Drawing.Size(78, 13)
        Me.lbl_nro_historia_clinica.TabIndex = 4
        Me.lbl_nro_historia_clinica.Text = "Historia Clínica"
        '
        'lbl_nombre_perro
        '
        Me.lbl_nombre_perro.AutoSize = True
        Me.lbl_nombre_perro.Location = New System.Drawing.Point(212, 91)
        Me.lbl_nombre_perro.Name = "lbl_nombre_perro"
        Me.lbl_nombre_perro.Size = New System.Drawing.Size(72, 13)
        Me.lbl_nombre_perro.TabIndex = 5
        Me.lbl_nombre_perro.Text = "Nombre Perro"
        '
        'lbl_raza
        '
        Me.lbl_raza.AutoSize = True
        Me.lbl_raza.Location = New System.Drawing.Point(252, 136)
        Me.lbl_raza.Name = "lbl_raza"
        Me.lbl_raza.Size = New System.Drawing.Size(32, 13)
        Me.lbl_raza.TabIndex = 6
        Me.lbl_raza.Text = "Raza"
        '
        'pnl_detalle
        '
        Me.pnl_detalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_detalle.Controls.Add(Me.btn_agregar)
        Me.pnl_detalle.Controls.Add(Me.dgv_detalle)
        Me.pnl_detalle.Controls.Add(Me.cmb_doctor)
        Me.pnl_detalle.Controls.Add(Me.cmb_diagnostico)
        Me.pnl_detalle.Controls.Add(Me.lbl_empleado)
        Me.pnl_detalle.Controls.Add(Me.dtp_fecha_salida)
        Me.pnl_detalle.Controls.Add(Me.lbl_Diagnostico)
        Me.pnl_detalle.Controls.Add(Me.dtp_fecha_entrada)
        Me.pnl_detalle.Controls.Add(Me.lbl_fecha_entrada)
        Me.pnl_detalle.Controls.Add(Me.lbl_fecha_salida)
        Me.pnl_detalle.Enabled = False
        Me.pnl_detalle.Location = New System.Drawing.Point(12, 159)
        Me.pnl_detalle.Name = "pnl_detalle"
        Me.pnl_detalle.Size = New System.Drawing.Size(600, 343)
        Me.pnl_detalle.TabIndex = 7
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(486, 85)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(87, 21)
        Me.btn_agregar.TabIndex = 11
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'dgv_detalle
        '
        Me.dgv_detalle.AllowUserToAddRows = False
        Me.dgv_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_id_diagnostico, Me.dgv_diagnostico, Me.dgv_fecha_entrada, Me.dgv_fecha_salida, Me.dgv_tipo_doc_empleado, Me.dgv_nro_doc_empleado, Me.dgv_nombre_empleado})
        Me.dgv_detalle.Location = New System.Drawing.Point(17, 112)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.ReadOnly = True
        Me.dgv_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle.Size = New System.Drawing.Size(569, 224)
        Me.dgv_detalle.TabIndex = 12
        '
        'dgv_id_diagnostico
        '
        Me.dgv_id_diagnostico.HeaderText = "ID Diagnostico"
        Me.dgv_id_diagnostico.Name = "dgv_id_diagnostico"
        Me.dgv_id_diagnostico.ReadOnly = True
        Me.dgv_id_diagnostico.Visible = False
        '
        'dgv_diagnostico
        '
        Me.dgv_diagnostico.HeaderText = "Diagnostico"
        Me.dgv_diagnostico.Name = "dgv_diagnostico"
        Me.dgv_diagnostico.ReadOnly = True
        '
        'dgv_fecha_entrada
        '
        Me.dgv_fecha_entrada.HeaderText = "Fecha Entrada"
        Me.dgv_fecha_entrada.Name = "dgv_fecha_entrada"
        Me.dgv_fecha_entrada.ReadOnly = True
        '
        'dgv_fecha_salida
        '
        Me.dgv_fecha_salida.HeaderText = "Fecha Salida"
        Me.dgv_fecha_salida.Name = "dgv_fecha_salida"
        Me.dgv_fecha_salida.ReadOnly = True
        '
        'dgv_tipo_doc_empleado
        '
        Me.dgv_tipo_doc_empleado.HeaderText = "Tipo Documento Empleado"
        Me.dgv_tipo_doc_empleado.Name = "dgv_tipo_doc_empleado"
        Me.dgv_tipo_doc_empleado.ReadOnly = True
        Me.dgv_tipo_doc_empleado.Visible = False
        '
        'dgv_nro_doc_empleado
        '
        Me.dgv_nro_doc_empleado.HeaderText = "Nro Doc Empleado"
        Me.dgv_nro_doc_empleado.Name = "dgv_nro_doc_empleado"
        Me.dgv_nro_doc_empleado.ReadOnly = True
        Me.dgv_nro_doc_empleado.Visible = False
        '
        'dgv_nombre_empleado
        '
        Me.dgv_nombre_empleado.HeaderText = "Nombre Empleado"
        Me.dgv_nombre_empleado.Name = "dgv_nombre_empleado"
        Me.dgv_nombre_empleado.ReadOnly = True
        '
        'cmb_doctor
        '
        Me.cmb_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_doctor.FormattingEnabled = True
        Me.cmb_doctor.Location = New System.Drawing.Point(90, 85)
        Me.cmb_doctor.Name = "cmb_doctor"
        Me.cmb_doctor.Size = New System.Drawing.Size(275, 21)
        Me.cmb_doctor.TabIndex = 10
        '
        'cmb_diagnostico
        '
        Me.cmb_diagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_diagnostico.FormattingEnabled = True
        Me.cmb_diagnostico.Location = New System.Drawing.Point(90, 45)
        Me.cmb_diagnostico.Name = "cmb_diagnostico"
        Me.cmb_diagnostico.Size = New System.Drawing.Size(275, 21)
        Me.cmb_diagnostico.TabIndex = 9
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = True
        Me.lbl_empleado.Location = New System.Drawing.Point(36, 88)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(39, 13)
        Me.lbl_empleado.TabIndex = 1
        Me.lbl_empleado.Text = "Doctor"
        '
        'dtp_fecha_salida
        '
        Me.dtp_fecha_salida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_salida.Location = New System.Drawing.Point(277, 6)
        Me.dtp_fecha_salida.Name = "dtp_fecha_salida"
        Me.dtp_fecha_salida.Size = New System.Drawing.Size(88, 20)
        Me.dtp_fecha_salida.TabIndex = 8
        '
        'lbl_Diagnostico
        '
        Me.lbl_Diagnostico.AutoSize = True
        Me.lbl_Diagnostico.Location = New System.Drawing.Point(14, 48)
        Me.lbl_Diagnostico.Name = "lbl_Diagnostico"
        Me.lbl_Diagnostico.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Diagnostico.TabIndex = 0
        Me.lbl_Diagnostico.Text = "Diagnostico"
        '
        'dtp_fecha_entrada
        '
        Me.dtp_fecha_entrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_entrada.Location = New System.Drawing.Point(92, 6)
        Me.dtp_fecha_entrada.Name = "dtp_fecha_entrada"
        Me.dtp_fecha_entrada.Size = New System.Drawing.Size(83, 20)
        Me.dtp_fecha_entrada.TabIndex = 7
        '
        'txt_sucursal
        '
        Me.txt_sucursal.Enabled = False
        Me.txt_sucursal.Location = New System.Drawing.Point(95, 47)
        Me.txt_sucursal.MaxLength = 2
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Size = New System.Drawing.Size(43, 20)
        Me.txt_sucursal.TabIndex = 2
        '
        'txt_cod_consulta
        '
        Me.txt_cod_consulta.Enabled = False
        Me.txt_cod_consulta.Location = New System.Drawing.Point(498, 8)
        Me.txt_cod_consulta.MaxLength = 8
        Me.txt_cod_consulta.Name = "txt_cod_consulta"
        Me.txt_cod_consulta.Size = New System.Drawing.Size(100, 20)
        Me.txt_cod_consulta.TabIndex = 1
        '
        'msk_historia_clinica
        '
        Me.msk_historia_clinica.Enabled = False
        Me.msk_historia_clinica.Location = New System.Drawing.Point(95, 88)
        Me.msk_historia_clinica.Mask = "99999999"
        Me.msk_historia_clinica.Name = "msk_historia_clinica"
        Me.msk_historia_clinica.Size = New System.Drawing.Size(61, 20)
        Me.msk_historia_clinica.TabIndex = 3
        '
        'txt_nombre_perro
        '
        Me.txt_nombre_perro.Enabled = False
        Me.txt_nombre_perro.Location = New System.Drawing.Point(289, 88)
        Me.txt_nombre_perro.MaxLength = 50
        Me.txt_nombre_perro.Name = "txt_nombre_perro"
        Me.txt_nombre_perro.Size = New System.Drawing.Size(309, 20)
        Me.txt_nombre_perro.TabIndex = 5
        '
        'txt_raza
        '
        Me.txt_raza.Enabled = False
        Me.txt_raza.Location = New System.Drawing.Point(290, 133)
        Me.txt_raza.Name = "txt_raza"
        Me.txt_raza.Size = New System.Drawing.Size(223, 20)
        Me.txt_raza.TabIndex = 6
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(50, 15)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fecha.TabIndex = 15
        Me.lbl_fecha.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(95, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(85, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(114, 508)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(45, 37)
        Me.btn_eliminar.TabIndex = 16
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(567, 508)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(45, 37)
        Me.btn_salir.TabIndex = 18
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 508)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(45, 37)
        Me.btn_nuevo.TabIndex = 13
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(195, 508)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(45, 37)
        Me.btn_buscar.TabIndex = 17
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.Location = New System.Drawing.Point(63, 508)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(45, 37)
        Me.btn_guardar.TabIndex = 14
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_buscar_hc
        '
        Me.btn_buscar_hc.Enabled = False
        Me.btn_buscar_hc.Location = New System.Drawing.Point(165, 89)
        Me.btn_buscar_hc.Name = "btn_buscar_hc"
        Me.btn_buscar_hc.Size = New System.Drawing.Size(41, 19)
        Me.btn_buscar_hc.TabIndex = 4
        Me.btn_buscar_hc.Text = "..."
        Me.btn_buscar_hc.UseVisualStyleBackColor = True
        '
        'frm_consulta_medica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(623, 545)
        Me.Controls.Add(Me.btn_buscar_hc)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.txt_raza)
        Me.Controls.Add(Me.txt_nombre_perro)
        Me.Controls.Add(Me.msk_historia_clinica)
        Me.Controls.Add(Me.txt_cod_consulta)
        Me.Controls.Add(Me.txt_sucursal)
        Me.Controls.Add(Me.pnl_detalle)
        Me.Controls.Add(Me.lbl_raza)
        Me.Controls.Add(Me.lbl_nombre_perro)
        Me.Controls.Add(Me.lbl_nro_historia_clinica)
        Me.Controls.Add(Me.lbl_nro_consulta)
        Me.Controls.Add(Me.lbl_sucursal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_consulta_medica"
        Me.Text = "Consulta"
        Me.pnl_detalle.ResumeLayout(False)
        Me.pnl_detalle.PerformLayout()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_fecha_entrada As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_salida As System.Windows.Forms.Label
    Friend WithEvents lbl_sucursal As System.Windows.Forms.Label
    Friend WithEvents lbl_nro_consulta As System.Windows.Forms.Label
    Friend WithEvents lbl_nro_historia_clinica As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_perro As System.Windows.Forms.Label
    Friend WithEvents lbl_raza As System.Windows.Forms.Label
    Friend WithEvents pnl_detalle As System.Windows.Forms.Panel
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_id_diagnostico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_diagnostico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_fecha_entrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_fecha_salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_tipo_doc_empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_nro_doc_empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_nombre_empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_diagnostico As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_empleado As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_salida As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Diagnostico As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_entrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_sucursal As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_consulta As System.Windows.Forms.TextBox
    Friend WithEvents msk_historia_clinica As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nombre_perro As System.Windows.Forms.TextBox
    Friend WithEvents txt_raza As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar_hc As System.Windows.Forms.Button
End Class
