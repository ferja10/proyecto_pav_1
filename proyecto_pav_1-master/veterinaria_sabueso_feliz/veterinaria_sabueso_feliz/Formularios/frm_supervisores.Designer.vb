<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_supervisores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_supervisores))
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.chk_nro_doc = New System.Windows.Forms.CheckBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.rdo_suplente = New System.Windows.Forms.RadioButton()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.rdo_titular = New System.Windows.Forms.RadioButton()
        Me.dgv_empleados = New System.Windows.Forms.DataGridView()
        Me.msk_nro_doc = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nro_doc_sup = New System.Windows.Forms.Label()
        Me.cmb_tipo_doc_sup_supl = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo_doc_sup = New System.Windows.Forms.ComboBox()
        Me.btn_eliminar_sup_supl = New System.Windows.Forms.Button()
        Me.btn_eliminar_sup = New System.Windows.Forms.Button()
        Me.msk_nro_doc_sup_supl = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre_supl = New System.Windows.Forms.TextBox()
        Me.txt_apellido_supl = New System.Windows.Forms.TextBox()
        Me.msk_nro_doc_sup = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre_sup = New System.Windows.Forms.TextBox()
        Me.txt_apellido_sup = New System.Windows.Forms.TextBox()
        Me.lbl_matricula_supl = New System.Windows.Forms.Label()
        Me.lbl_nombre_supl = New System.Windows.Forms.Label()
        Me.lbl_apellido_supl = New System.Windows.Forms.Label()
        Me.lbl_supervisor_suplente = New System.Windows.Forms.Label()
        Me.lbl_matricula = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_apellido_sup = New System.Windows.Forms.Label()
        Me.lbl_supervisor = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.AutoSize = True
        Me.lbl_sucursal.Location = New System.Drawing.Point(12, 9)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(39, 13)
        Me.lbl_sucursal.TabIndex = 0
        Me.lbl_sucursal.Text = "Label1"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(89, 20)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido.TabIndex = 1
        Me.lbl_apellido.Text = "Apellido"
        '
        'txt_apellido
        '
        Me.txt_apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellido.Location = New System.Drawing.Point(139, 17)
        Me.txt_apellido.MaxLength = 50
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(391, 20)
        Me.txt_apellido.TabIndex = 1
        '
        'chk_nro_doc
        '
        Me.chk_nro_doc.AutoSize = True
        Me.chk_nro_doc.Location = New System.Drawing.Point(139, 54)
        Me.chk_nro_doc.Name = "chk_nro_doc"
        Me.chk_nro_doc.Size = New System.Drawing.Size(81, 17)
        Me.chk_nro_doc.TabIndex = 2
        Me.chk_nro_doc.Text = "Documento"
        Me.chk_nro_doc.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdo_suplente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_guardar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdo_titular)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgv_empleados)
        Me.SplitContainer1.Panel1.Controls.Add(Me.msk_nro_doc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_apellido)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chk_nro_doc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_apellido)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_nro_doc_sup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmb_tipo_doc_sup_supl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmb_tipo_doc_sup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_eliminar_sup_supl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_eliminar_sup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.msk_nro_doc_sup_supl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_nombre_supl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_apellido_supl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.msk_nro_doc_sup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_nombre_sup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_apellido_sup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_matricula_supl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_nombre_supl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_apellido_supl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_supervisor_suplente)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_matricula)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_nombre)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_apellido_sup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_supervisor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1080, 467)
        Me.SplitContainer1.SplitterDistance = 641
        Me.SplitContainer1.TabIndex = 4
        '
        'rdo_suplente
        '
        Me.rdo_suplente.AutoSize = True
        Me.rdo_suplente.Location = New System.Drawing.Point(226, 442)
        Me.rdo_suplente.Name = "rdo_suplente"
        Me.rdo_suplente.Size = New System.Drawing.Size(67, 17)
        Me.rdo_suplente.TabIndex = 6
        Me.rdo_suplente.TabStop = True
        Me.rdo_suplente.Text = "Suplente"
        Me.rdo_suplente.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(561, 439)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 7
        Me.btn_guardar.Text = "Grabar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'rdo_titular
        '
        Me.rdo_titular.AutoSize = True
        Me.rdo_titular.Location = New System.Drawing.Point(139, 442)
        Me.rdo_titular.Name = "rdo_titular"
        Me.rdo_titular.Size = New System.Drawing.Size(54, 17)
        Me.rdo_titular.TabIndex = 5
        Me.rdo_titular.TabStop = True
        Me.rdo_titular.Text = "Titular"
        Me.rdo_titular.UseVisualStyleBackColor = True
        '
        'dgv_empleados
        '
        Me.dgv_empleados.AllowUserToAddRows = False
        Me.dgv_empleados.AllowUserToDeleteRows = False
        Me.dgv_empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_empleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empleados.Location = New System.Drawing.Point(6, 83)
        Me.dgv_empleados.Name = "dgv_empleados"
        Me.dgv_empleados.ReadOnly = True
        Me.dgv_empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_empleados.Size = New System.Drawing.Size(636, 341)
        Me.dgv_empleados.TabIndex = 4
        Me.dgv_empleados.TabStop = False
        '
        'msk_nro_doc
        '
        Me.msk_nro_doc.Enabled = False
        Me.msk_nro_doc.Location = New System.Drawing.Point(226, 51)
        Me.msk_nro_doc.Mask = "99999999"
        Me.msk_nro_doc.Name = "msk_nro_doc"
        Me.msk_nro_doc.Size = New System.Drawing.Size(58, 20)
        Me.msk_nro_doc.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nro."
        '
        'lbl_nro_doc_sup
        '
        Me.lbl_nro_doc_sup.AutoSize = True
        Me.lbl_nro_doc_sup.Location = New System.Drawing.Point(230, 406)
        Me.lbl_nro_doc_sup.Name = "lbl_nro_doc_sup"
        Me.lbl_nro_doc_sup.Size = New System.Drawing.Size(27, 13)
        Me.lbl_nro_doc_sup.TabIndex = 19
        Me.lbl_nro_doc_sup.Text = "Nro."
        '
        'cmb_tipo_doc_sup_supl
        '
        Me.cmb_tipo_doc_sup_supl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_doc_sup_supl.Enabled = False
        Me.cmb_tipo_doc_sup_supl.FormattingEnabled = True
        Me.cmb_tipo_doc_sup_supl.Location = New System.Drawing.Point(63, 403)
        Me.cmb_tipo_doc_sup_supl.Name = "cmb_tipo_doc_sup_supl"
        Me.cmb_tipo_doc_sup_supl.Size = New System.Drawing.Size(142, 21)
        Me.cmb_tipo_doc_sup_supl.TabIndex = 15
        '
        'cmb_tipo_doc_sup
        '
        Me.cmb_tipo_doc_sup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_doc_sup.Enabled = False
        Me.cmb_tipo_doc_sup.FormattingEnabled = True
        Me.cmb_tipo_doc_sup.Location = New System.Drawing.Point(63, 169)
        Me.cmb_tipo_doc_sup.Name = "cmb_tipo_doc_sup"
        Me.cmb_tipo_doc_sup.Size = New System.Drawing.Size(142, 21)
        Me.cmb_tipo_doc_sup.TabIndex = 10
        '
        'btn_eliminar_sup_supl
        '
        Me.btn_eliminar_sup_supl.Location = New System.Drawing.Point(334, 439)
        Me.btn_eliminar_sup_supl.Name = "btn_eliminar_sup_supl"
        Me.btn_eliminar_sup_supl.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar_sup_supl.TabIndex = 17
        Me.btn_eliminar_sup_supl.Text = "Eliminar"
        Me.btn_eliminar_sup_supl.UseVisualStyleBackColor = True
        '
        'btn_eliminar_sup
        '
        Me.btn_eliminar_sup.Location = New System.Drawing.Point(334, 207)
        Me.btn_eliminar_sup.Name = "btn_eliminar_sup"
        Me.btn_eliminar_sup.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar_sup.TabIndex = 12
        Me.btn_eliminar_sup.Text = "Eliminar"
        Me.btn_eliminar_sup.UseVisualStyleBackColor = True
        '
        'msk_nro_doc_sup_supl
        '
        Me.msk_nro_doc_sup_supl.Enabled = False
        Me.msk_nro_doc_sup_supl.Location = New System.Drawing.Point(263, 403)
        Me.msk_nro_doc_sup_supl.Mask = "99999999"
        Me.msk_nro_doc_sup_supl.Name = "msk_nro_doc_sup_supl"
        Me.msk_nro_doc_sup_supl.Size = New System.Drawing.Size(63, 20)
        Me.msk_nro_doc_sup_supl.TabIndex = 16
        '
        'txt_nombre_supl
        '
        Me.txt_nombre_supl.Enabled = False
        Me.txt_nombre_supl.Location = New System.Drawing.Point(63, 350)
        Me.txt_nombre_supl.Name = "txt_nombre_supl"
        Me.txt_nombre_supl.Size = New System.Drawing.Size(347, 20)
        Me.txt_nombre_supl.TabIndex = 14
        '
        'txt_apellido_supl
        '
        Me.txt_apellido_supl.Enabled = False
        Me.txt_apellido_supl.Location = New System.Drawing.Point(63, 292)
        Me.txt_apellido_supl.Name = "txt_apellido_supl"
        Me.txt_apellido_supl.Size = New System.Drawing.Size(347, 20)
        Me.txt_apellido_supl.TabIndex = 13
        '
        'msk_nro_doc_sup
        '
        Me.msk_nro_doc_sup.Enabled = False
        Me.msk_nro_doc_sup.Location = New System.Drawing.Point(263, 169)
        Me.msk_nro_doc_sup.Mask = "99999999"
        Me.msk_nro_doc_sup.Name = "msk_nro_doc_sup"
        Me.msk_nro_doc_sup.Size = New System.Drawing.Size(63, 20)
        Me.msk_nro_doc_sup.TabIndex = 11
        '
        'txt_nombre_sup
        '
        Me.txt_nombre_sup.Enabled = False
        Me.txt_nombre_sup.Location = New System.Drawing.Point(62, 113)
        Me.txt_nombre_sup.Name = "txt_nombre_sup"
        Me.txt_nombre_sup.Size = New System.Drawing.Size(347, 20)
        Me.txt_nombre_sup.TabIndex = 9
        '
        'txt_apellido_sup
        '
        Me.txt_apellido_sup.Enabled = False
        Me.txt_apellido_sup.Location = New System.Drawing.Point(62, 54)
        Me.txt_apellido_sup.Name = "txt_apellido_sup"
        Me.txt_apellido_sup.Size = New System.Drawing.Size(347, 20)
        Me.txt_apellido_sup.TabIndex = 8
        '
        'lbl_matricula_supl
        '
        Me.lbl_matricula_supl.AutoSize = True
        Me.lbl_matricula_supl.Location = New System.Drawing.Point(3, 406)
        Me.lbl_matricula_supl.Name = "lbl_matricula_supl"
        Me.lbl_matricula_supl.Size = New System.Drawing.Size(54, 13)
        Me.lbl_matricula_supl.TabIndex = 7
        Me.lbl_matricula_supl.Text = "Tipo Doc."
        '
        'lbl_nombre_supl
        '
        Me.lbl_nombre_supl.AutoSize = True
        Me.lbl_nombre_supl.Location = New System.Drawing.Point(13, 353)
        Me.lbl_nombre_supl.Name = "lbl_nombre_supl"
        Me.lbl_nombre_supl.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre_supl.TabIndex = 6
        Me.lbl_nombre_supl.Text = "Nombre"
        '
        'lbl_apellido_supl
        '
        Me.lbl_apellido_supl.AutoSize = True
        Me.lbl_apellido_supl.Location = New System.Drawing.Point(12, 295)
        Me.lbl_apellido_supl.Name = "lbl_apellido_supl"
        Me.lbl_apellido_supl.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido_supl.TabIndex = 5
        Me.lbl_apellido_supl.Text = "Apellido"
        '
        'lbl_supervisor_suplente
        '
        Me.lbl_supervisor_suplente.AutoSize = True
        Me.lbl_supervisor_suplente.Location = New System.Drawing.Point(11, 260)
        Me.lbl_supervisor_suplente.Name = "lbl_supervisor_suplente"
        Me.lbl_supervisor_suplente.Size = New System.Drawing.Size(49, 13)
        Me.lbl_supervisor_suplente.TabIndex = 4
        Me.lbl_supervisor_suplente.Text = "Suplente"
        '
        'lbl_matricula
        '
        Me.lbl_matricula.AutoSize = True
        Me.lbl_matricula.Location = New System.Drawing.Point(3, 172)
        Me.lbl_matricula.Name = "lbl_matricula"
        Me.lbl_matricula.Size = New System.Drawing.Size(54, 13)
        Me.lbl_matricula.TabIndex = 3
        Me.lbl_matricula.Text = "Tipo Doc."
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(13, 116)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 2
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_apellido_sup
        '
        Me.lbl_apellido_sup.AutoSize = True
        Me.lbl_apellido_sup.Location = New System.Drawing.Point(13, 57)
        Me.lbl_apellido_sup.Name = "lbl_apellido_sup"
        Me.lbl_apellido_sup.Size = New System.Drawing.Size(44, 13)
        Me.lbl_apellido_sup.TabIndex = 1
        Me.lbl_apellido_sup.Text = "Apellido"
        '
        'lbl_supervisor
        '
        Me.lbl_supervisor.AutoSize = True
        Me.lbl_supervisor.Location = New System.Drawing.Point(3, 20)
        Me.lbl_supervisor.Name = "lbl_supervisor"
        Me.lbl_supervisor.Size = New System.Drawing.Size(57, 13)
        Me.lbl_supervisor.TabIndex = 0
        Me.lbl_supervisor.Text = "Supervisor"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(433, 465)
        Me.ShapeContainer1.TabIndex = 14
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 2
        Me.LineShape1.X2 = 430
        Me.LineShape1.Y1 = 238
        Me.LineShape1.Y2 = 238
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(1037, 498)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(45, 43)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'frm_supervisores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1086, 541)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lbl_sucursal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_supervisores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Supervisores"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_sucursal As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents chk_nro_doc As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgv_empleados As System.Windows.Forms.DataGridView
    Friend WithEvents msk_nro_doc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nombre_sup As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido_sup As System.Windows.Forms.TextBox
    Friend WithEvents lbl_matricula_supl As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_supl As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido_supl As System.Windows.Forms.Label
    Friend WithEvents lbl_supervisor_suplente As System.Windows.Forms.Label
    Friend WithEvents lbl_matricula As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido_sup As System.Windows.Forms.Label
    Friend WithEvents lbl_supervisor As System.Windows.Forms.Label
    Friend WithEvents msk_nro_doc_sup As System.Windows.Forms.MaskedTextBox
    Friend WithEvents msk_nro_doc_sup_supl As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nombre_supl As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido_supl As System.Windows.Forms.TextBox
    Friend WithEvents rdo_suplente As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_titular As System.Windows.Forms.RadioButton
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btn_eliminar_sup_supl As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar_sup As System.Windows.Forms.Button
    Friend WithEvents cmb_tipo_doc_sup As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_nro_doc_sup As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_doc_sup_supl As System.Windows.Forms.ComboBox
End Class
