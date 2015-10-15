<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_busqueda_consulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_busqueda_consulta))
        Me.lbl_perro = New System.Windows.Forms.Label()
        Me.txt_nombre_perro = New System.Windows.Forms.TextBox()
        Me.cmb_doctor = New System.Windows.Forms.ComboBox()
        Me.lbl_doctor = New System.Windows.Forms.Label()
        Me.dgv_consultas = New System.Windows.Forms.DataGridView()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.chk_doctor = New System.Windows.Forms.CheckBox()
        CType(Me.dgv_consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_perro
        '
        Me.lbl_perro.AutoSize = True
        Me.lbl_perro.Location = New System.Drawing.Point(12, 21)
        Me.lbl_perro.Name = "lbl_perro"
        Me.lbl_perro.Size = New System.Drawing.Size(72, 13)
        Me.lbl_perro.TabIndex = 0
        Me.lbl_perro.Text = "Nombre Perro"
        '
        'txt_nombre_perro
        '
        Me.txt_nombre_perro.Location = New System.Drawing.Point(90, 18)
        Me.txt_nombre_perro.Name = "txt_nombre_perro"
        Me.txt_nombre_perro.Size = New System.Drawing.Size(418, 20)
        Me.txt_nombre_perro.TabIndex = 1
        '
        'cmb_doctor
        '
        Me.cmb_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_doctor.Enabled = False
        Me.cmb_doctor.FormattingEnabled = True
        Me.cmb_doctor.Location = New System.Drawing.Point(90, 57)
        Me.cmb_doctor.Name = "cmb_doctor"
        Me.cmb_doctor.Size = New System.Drawing.Size(244, 21)
        Me.cmb_doctor.TabIndex = 2
        '
        'lbl_doctor
        '
        Me.lbl_doctor.AutoSize = True
        Me.lbl_doctor.Location = New System.Drawing.Point(45, 60)
        Me.lbl_doctor.Name = "lbl_doctor"
        Me.lbl_doctor.Size = New System.Drawing.Size(39, 13)
        Me.lbl_doctor.TabIndex = 3
        Me.lbl_doctor.Text = "Doctor"
        '
        'dgv_consultas
        '
        Me.dgv_consultas.AllowUserToAddRows = False
        Me.dgv_consultas.AllowUserToDeleteRows = False
        Me.dgv_consultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_consultas.Location = New System.Drawing.Point(14, 84)
        Me.dgv_consultas.Name = "dgv_consultas"
        Me.dgv_consultas.ReadOnly = True
        Me.dgv_consultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_consultas.Size = New System.Drawing.Size(609, 268)
        Me.dgv_consultas.TabIndex = 4
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(578, 358)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(45, 37)
        Me.btn_salir.TabIndex = 19
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(527, 358)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(45, 37)
        Me.btn_eliminar.TabIndex = 20
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(548, 55)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 21
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'chk_doctor
        '
        Me.chk_doctor.AutoSize = True
        Me.chk_doctor.Location = New System.Drawing.Point(24, 60)
        Me.chk_doctor.Name = "chk_doctor"
        Me.chk_doctor.Size = New System.Drawing.Size(15, 14)
        Me.chk_doctor.TabIndex = 22
        Me.chk_doctor.UseVisualStyleBackColor = True
        '
        'frm_busqueda_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(635, 395)
        Me.Controls.Add(Me.chk_doctor)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.dgv_consultas)
        Me.Controls.Add(Me.lbl_doctor)
        Me.Controls.Add(Me.cmb_doctor)
        Me.Controls.Add(Me.txt_nombre_perro)
        Me.Controls.Add(Me.lbl_perro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_busqueda_consulta"
        Me.Text = "Busqueda de Consultas"
        CType(Me.dgv_consultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_perro As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_perro As System.Windows.Forms.TextBox
    Friend WithEvents cmb_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_doctor As System.Windows.Forms.Label
    Friend WithEvents dgv_consultas As System.Windows.Forms.DataGridView
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents chk_doctor As System.Windows.Forms.CheckBox
End Class
