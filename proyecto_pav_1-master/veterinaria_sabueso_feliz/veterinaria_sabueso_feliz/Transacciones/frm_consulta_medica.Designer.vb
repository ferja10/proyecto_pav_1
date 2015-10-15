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
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.lbl_nro_consulta = New System.Windows.Forms.Label()
        Me.lbl_nro_historia_clinica = New System.Windows.Forms.Label()
        Me.lbl_nombre_perro = New System.Windows.Forms.Label()
        Me.lbl_raza = New System.Windows.Forms.Label()
        Me.btn_agregar_diagnostico = New System.Windows.Forms.Button()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.dgv_id_sintoma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_sintoma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_doctor = New System.Windows.Forms.ComboBox()
        Me.cmb_diagnostico = New System.Windows.Forms.ComboBox()
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.lbl_Diagnostico = New System.Windows.Forms.Label()
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
        Me.spc_detalles = New System.Windows.Forms.SplitContainer()
        Me.grb_detalle_sintomas = New System.Windows.Forms.GroupBox()
        Me.lbl_sintomas = New System.Windows.Forms.Label()
        Me.cmb_sintoma = New System.Windows.Forms.ComboBox()
        Me.btn_quitar_diagnostico = New System.Windows.Forms.Button()
        Me.btn_quitar_medicamento = New System.Windows.Forms.Button()
        Me.bl_receta = New System.Windows.Forms.Label()
        Me.btn_agregarMedicamento = New System.Windows.Forms.Button()
        Me.dgv_MedicamentoSeleccionado = New System.Windows.Forms.DataGridView()
        Me.dgv_id_medicamentos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_nombre_medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_dosis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_periodicidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_Medicamento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_ListaMedicamento = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spc_detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spc_detalles.Panel1.SuspendLayout()
        Me.spc_detalles.Panel2.SuspendLayout()
        Me.spc_detalles.SuspendLayout()
        Me.grb_detalle_sintomas.SuspendLayout()
        CType(Me.dgv_MedicamentoSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_ListaMedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.AutoSize = True
        Me.lbl_sucursal.Location = New System.Drawing.Point(9, 11)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(48, 13)
        Me.lbl_sucursal.TabIndex = 2
        Me.lbl_sucursal.Text = "Sucursal"
        '
        'lbl_nro_consulta
        '
        Me.lbl_nro_consulta.AutoSize = True
        Me.lbl_nro_consulta.Location = New System.Drawing.Point(125, 9)
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
        Me.lbl_raza.Location = New System.Drawing.Point(631, 92)
        Me.lbl_raza.Name = "lbl_raza"
        Me.lbl_raza.Size = New System.Drawing.Size(32, 13)
        Me.lbl_raza.TabIndex = 6
        Me.lbl_raza.Text = "Raza"
        '
        'btn_agregar_diagnostico
        '
        Me.btn_agregar_diagnostico.Location = New System.Drawing.Point(428, 24)
        Me.btn_agregar_diagnostico.Name = "btn_agregar_diagnostico"
        Me.btn_agregar_diagnostico.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar_diagnostico.TabIndex = 11
        Me.btn_agregar_diagnostico.Text = "Agregar"
        Me.btn_agregar_diagnostico.UseVisualStyleBackColor = True
        '
        'dgv_detalle
        '
        Me.dgv_detalle.AllowUserToAddRows = False
        Me.dgv_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_id_sintoma, Me.dgv_sintoma})
        Me.dgv_detalle.Location = New System.Drawing.Point(27, 53)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.ReadOnly = True
        Me.dgv_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_detalle.Size = New System.Drawing.Size(569, 275)
        Me.dgv_detalle.TabIndex = 12
        '
        'dgv_id_sintoma
        '
        Me.dgv_id_sintoma.HeaderText = "ID Sintoma"
        Me.dgv_id_sintoma.Name = "dgv_id_sintoma"
        Me.dgv_id_sintoma.ReadOnly = True
        Me.dgv_id_sintoma.Visible = False
        '
        'dgv_sintoma
        '
        Me.dgv_sintoma.HeaderText = "Sintoma"
        Me.dgv_sintoma.Name = "dgv_sintoma"
        Me.dgv_sintoma.ReadOnly = True
        '
        'cmb_doctor
        '
        Me.cmb_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_doctor.FormattingEnabled = True
        Me.cmb_doctor.Location = New System.Drawing.Point(54, 47)
        Me.cmb_doctor.Name = "cmb_doctor"
        Me.cmb_doctor.Size = New System.Drawing.Size(275, 21)
        Me.cmb_doctor.TabIndex = 10
        '
        'cmb_diagnostico
        '
        Me.cmb_diagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_diagnostico.FormattingEnabled = True
        Me.cmb_diagnostico.Location = New System.Drawing.Point(80, 14)
        Me.cmb_diagnostico.Name = "cmb_diagnostico"
        Me.cmb_diagnostico.Size = New System.Drawing.Size(275, 21)
        Me.cmb_diagnostico.TabIndex = 9
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = True
        Me.lbl_empleado.Location = New System.Drawing.Point(9, 50)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(39, 13)
        Me.lbl_empleado.TabIndex = 1
        Me.lbl_empleado.Text = "Doctor"
        '
        'lbl_Diagnostico
        '
        Me.lbl_Diagnostico.AutoSize = True
        Me.lbl_Diagnostico.Location = New System.Drawing.Point(11, 17)
        Me.lbl_Diagnostico.Name = "lbl_Diagnostico"
        Me.lbl_Diagnostico.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Diagnostico.TabIndex = 0
        Me.lbl_Diagnostico.Text = "Diagnostico"
        '
        'txt_sucursal
        '
        Me.txt_sucursal.Enabled = False
        Me.txt_sucursal.Location = New System.Drawing.Point(63, 8)
        Me.txt_sucursal.MaxLength = 2
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Size = New System.Drawing.Size(43, 20)
        Me.txt_sucursal.TabIndex = 2
        '
        'txt_cod_consulta
        '
        Me.txt_cod_consulta.Enabled = False
        Me.txt_cod_consulta.Location = New System.Drawing.Point(230, 6)
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
        Me.txt_raza.Location = New System.Drawing.Point(669, 88)
        Me.txt_raza.Name = "txt_raza"
        Me.txt_raza.Size = New System.Drawing.Size(223, 20)
        Me.txt_raza.TabIndex = 6
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(1194, 11)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fecha.TabIndex = 15
        Me.lbl_fecha.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(1237, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(77, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(114, 523)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(45, 37)
        Me.btn_eliminar.TabIndex = 16
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(1269, 523)
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
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 523)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(45, 37)
        Me.btn_nuevo.TabIndex = 13
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(195, 523)
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
        Me.btn_guardar.Location = New System.Drawing.Point(63, 523)
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
        'spc_detalles
        '
        Me.spc_detalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.spc_detalles.Location = New System.Drawing.Point(14, 117)
        Me.spc_detalles.Name = "spc_detalles"
        '
        'spc_detalles.Panel1
        '
        Me.spc_detalles.Panel1.Controls.Add(Me.grb_detalle_sintomas)
        Me.spc_detalles.Panel1.Controls.Add(Me.cmb_diagnostico)
        Me.spc_detalles.Panel1.Controls.Add(Me.lbl_Diagnostico)
        '
        'spc_detalles.Panel2
        '
        Me.spc_detalles.Panel2.Controls.Add(Me.btn_quitar_medicamento)
        Me.spc_detalles.Panel2.Controls.Add(Me.bl_receta)
        Me.spc_detalles.Panel2.Controls.Add(Me.btn_agregarMedicamento)
        Me.spc_detalles.Panel2.Controls.Add(Me.dgv_MedicamentoSeleccionado)
        Me.spc_detalles.Panel2.Controls.Add(Me.txt_Medicamento)
        Me.spc_detalles.Panel2.Controls.Add(Me.Label1)
        Me.spc_detalles.Panel2.Controls.Add(Me.dgv_ListaMedicamento)
        Me.spc_detalles.Size = New System.Drawing.Size(1300, 400)
        Me.spc_detalles.SplitterDistance = 659
        Me.spc_detalles.TabIndex = 19
        '
        'grb_detalle_sintomas
        '
        Me.grb_detalle_sintomas.Controls.Add(Me.lbl_sintomas)
        Me.grb_detalle_sintomas.Controls.Add(Me.cmb_sintoma)
        Me.grb_detalle_sintomas.Controls.Add(Me.btn_agregar_diagnostico)
        Me.grb_detalle_sintomas.Controls.Add(Me.dgv_detalle)
        Me.grb_detalle_sintomas.Controls.Add(Me.btn_quitar_diagnostico)
        Me.grb_detalle_sintomas.Location = New System.Drawing.Point(12, 52)
        Me.grb_detalle_sintomas.Name = "grb_detalle_sintomas"
        Me.grb_detalle_sintomas.Size = New System.Drawing.Size(620, 334)
        Me.grb_detalle_sintomas.TabIndex = 17
        Me.grb_detalle_sintomas.TabStop = False
        Me.grb_detalle_sintomas.Text = "Sintomas"
        '
        'lbl_sintomas
        '
        Me.lbl_sintomas.AutoSize = True
        Me.lbl_sintomas.Location = New System.Drawing.Point(24, 27)
        Me.lbl_sintomas.Name = "lbl_sintomas"
        Me.lbl_sintomas.Size = New System.Drawing.Size(45, 13)
        Me.lbl_sintomas.TabIndex = 15
        Me.lbl_sintomas.Text = "Sintoma"
        '
        'cmb_sintoma
        '
        Me.cmb_sintoma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_sintoma.FormattingEnabled = True
        Me.cmb_sintoma.Location = New System.Drawing.Point(78, 24)
        Me.cmb_sintoma.Name = "cmb_sintoma"
        Me.cmb_sintoma.Size = New System.Drawing.Size(275, 21)
        Me.cmb_sintoma.TabIndex = 16
        '
        'btn_quitar_diagnostico
        '
        Me.btn_quitar_diagnostico.Location = New System.Drawing.Point(509, 24)
        Me.btn_quitar_diagnostico.Name = "btn_quitar_diagnostico"
        Me.btn_quitar_diagnostico.Size = New System.Drawing.Size(75, 23)
        Me.btn_quitar_diagnostico.TabIndex = 14
        Me.btn_quitar_diagnostico.Text = "Quitar"
        Me.btn_quitar_diagnostico.UseVisualStyleBackColor = True
        '
        'btn_quitar_medicamento
        '
        Me.btn_quitar_medicamento.Location = New System.Drawing.Point(516, 232)
        Me.btn_quitar_medicamento.Name = "btn_quitar_medicamento"
        Me.btn_quitar_medicamento.Size = New System.Drawing.Size(75, 23)
        Me.btn_quitar_medicamento.TabIndex = 7
        Me.btn_quitar_medicamento.Text = "Quitar"
        Me.btn_quitar_medicamento.UseVisualStyleBackColor = True
        '
        'bl_receta
        '
        Me.bl_receta.AutoSize = True
        Me.bl_receta.Location = New System.Drawing.Point(40, 245)
        Me.bl_receta.Name = "bl_receta"
        Me.bl_receta.Size = New System.Drawing.Size(54, 13)
        Me.bl_receta.TabIndex = 6
        Me.bl_receta.Text = "Recetado"
        '
        'btn_agregarMedicamento
        '
        Me.btn_agregarMedicamento.Location = New System.Drawing.Point(516, 52)
        Me.btn_agregarMedicamento.Name = "btn_agregarMedicamento"
        Me.btn_agregarMedicamento.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregarMedicamento.TabIndex = 5
        Me.btn_agregarMedicamento.Text = "Agregar"
        Me.btn_agregarMedicamento.UseVisualStyleBackColor = True
        '
        'dgv_MedicamentoSeleccionado
        '
        Me.dgv_MedicamentoSeleccionado.AllowUserToAddRows = False
        Me.dgv_MedicamentoSeleccionado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_MedicamentoSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_MedicamentoSeleccionado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_id_medicamentos, Me.dgv_nombre_medicamento, Me.dgv_dosis, Me.dgv_periodicidad})
        Me.dgv_MedicamentoSeleccionado.Location = New System.Drawing.Point(43, 261)
        Me.dgv_MedicamentoSeleccionado.Name = "dgv_MedicamentoSeleccionado"
        Me.dgv_MedicamentoSeleccionado.Size = New System.Drawing.Size(548, 125)
        Me.dgv_MedicamentoSeleccionado.TabIndex = 4
        '
        'dgv_id_medicamentos
        '
        Me.dgv_id_medicamentos.HeaderText = "ID Medicamentos"
        Me.dgv_id_medicamentos.Name = "dgv_id_medicamentos"
        Me.dgv_id_medicamentos.Visible = False
        '
        'dgv_nombre_medicamento
        '
        Me.dgv_nombre_medicamento.HeaderText = "Medicamento"
        Me.dgv_nombre_medicamento.Name = "dgv_nombre_medicamento"
        Me.dgv_nombre_medicamento.ReadOnly = True
        '
        'dgv_dosis
        '
        Me.dgv_dosis.HeaderText = "Dosis"
        Me.dgv_dosis.Name = "dgv_dosis"
        '
        'dgv_periodicidad
        '
        Me.dgv_periodicidad.HeaderText = "Periodicidad"
        Me.dgv_periodicidad.Name = "dgv_periodicidad"
        '
        'txt_Medicamento
        '
        Me.txt_Medicamento.Location = New System.Drawing.Point(132, 55)
        Me.txt_Medicamento.Name = "txt_Medicamento"
        Me.txt_Medicamento.Size = New System.Drawing.Size(354, 20)
        Me.txt_Medicamento.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Medicamento"
        '
        'dgv_ListaMedicamento
        '
        Me.dgv_ListaMedicamento.AllowUserToAddRows = False
        Me.dgv_ListaMedicamento.AllowUserToDeleteRows = False
        Me.dgv_ListaMedicamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_ListaMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ListaMedicamento.Location = New System.Drawing.Point(43, 85)
        Me.dgv_ListaMedicamento.Name = "dgv_ListaMedicamento"
        Me.dgv_ListaMedicamento.ReadOnly = True
        Me.dgv_ListaMedicamento.Size = New System.Drawing.Size(548, 115)
        Me.dgv_ListaMedicamento.TabIndex = 0
        '
        'frm_consulta_medica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1284, 563)
        Me.Controls.Add(Me.spc_detalles)
        Me.Controls.Add(Me.btn_buscar_hc)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.cmb_doctor)
        Me.Controls.Add(Me.lbl_empleado)
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
        Me.Controls.Add(Me.lbl_raza)
        Me.Controls.Add(Me.lbl_nombre_perro)
        Me.Controls.Add(Me.lbl_nro_historia_clinica)
        Me.Controls.Add(Me.lbl_nro_consulta)
        Me.Controls.Add(Me.lbl_sucursal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_consulta_medica"
        Me.Text = "Consulta"
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spc_detalles.Panel1.ResumeLayout(False)
        Me.spc_detalles.Panel1.PerformLayout()
        Me.spc_detalles.Panel2.ResumeLayout(False)
        Me.spc_detalles.Panel2.PerformLayout()
        CType(Me.spc_detalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spc_detalles.ResumeLayout(False)
        Me.grb_detalle_sintomas.ResumeLayout(False)
        Me.grb_detalle_sintomas.PerformLayout()
        CType(Me.dgv_MedicamentoSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_ListaMedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_sucursal As System.Windows.Forms.Label
    Friend WithEvents lbl_nro_consulta As System.Windows.Forms.Label
    Friend WithEvents lbl_nro_historia_clinica As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_perro As System.Windows.Forms.Label
    Friend WithEvents lbl_raza As System.Windows.Forms.Label
    Friend WithEvents btn_agregar_diagnostico As System.Windows.Forms.Button
    Friend WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_diagnostico As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_empleado As System.Windows.Forms.Label
    Friend WithEvents lbl_Diagnostico As System.Windows.Forms.Label
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
    Friend WithEvents spc_detalles As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_agregarMedicamento As System.Windows.Forms.Button
    Friend WithEvents dgv_MedicamentoSeleccionado As System.Windows.Forms.DataGridView
    Friend WithEvents txt_Medicamento As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_ListaMedicamento As System.Windows.Forms.DataGridView
    Friend WithEvents btn_quitar_diagnostico As System.Windows.Forms.Button
    Friend WithEvents btn_quitar_medicamento As System.Windows.Forms.Button
    Friend WithEvents bl_receta As System.Windows.Forms.Label
    Friend WithEvents lbl_sintomas As System.Windows.Forms.Label
    Friend WithEvents grb_detalle_sintomas As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_sintoma As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_id_sintoma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_sintoma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_id_medicamentos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_nombre_medicamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_dosis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_periodicidad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
