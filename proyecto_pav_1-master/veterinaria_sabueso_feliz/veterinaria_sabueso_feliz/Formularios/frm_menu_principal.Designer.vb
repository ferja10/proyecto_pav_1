<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu_principal))
        Me.mst_menu_principal = New System.Windows.Forms.MenuStrip()
        Me.mts_paciente = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_nuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_historia_clinica = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_calendarioDeVacunas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsi_cerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mts_consultas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_cita = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_vacunacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_internacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mts_listados = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_listadoDeEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_inventarioDeMedicamentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_inventarioDeVacunas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mts_reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_administrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_empleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_subordinados = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_supervisores = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_vacunas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_laboratorios = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_razas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_medicamentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_Sucursales = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_consulta = New System.Windows.Forms.Button()
        Me.btn_consultar_hc = New System.Windows.Forms.Button()
        Me.btn_registrar_vacunacion = New System.Windows.Forms.Button()
        Me.mst_menu_principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mst_menu_principal
        '
        Me.mst_menu_principal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.mst_menu_principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mts_paciente, Me.mts_consultas, Me.mts_listados, Me.mts_reportes, Me.tsm_administrar})
        Me.mst_menu_principal.Location = New System.Drawing.Point(0, 0)
        Me.mst_menu_principal.Name = "mst_menu_principal"
        Me.mst_menu_principal.Size = New System.Drawing.Size(844, 24)
        Me.mst_menu_principal.TabIndex = 0
        Me.mst_menu_principal.Text = "Paciente"
        '
        'mts_paciente
        '
        Me.mts_paciente.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsi_nuevo, Me.tsi_historia_clinica, Me.tsi_calendarioDeVacunas, Me.ToolStripSeparator1, Me.tsi_cerrarSesion, Me.tsi_salir})
        Me.mts_paciente.Name = "mts_paciente"
        Me.mts_paciente.Size = New System.Drawing.Size(64, 20)
        Me.mts_paciente.Text = "Paciente"
        '
        'tsi_nuevo
        '
        Me.tsi_nuevo.Name = "tsi_nuevo"
        Me.tsi_nuevo.Size = New System.Drawing.Size(193, 22)
        Me.tsi_nuevo.Text = "Nuevo"
        '
        'tsi_historia_clinica
        '
        Me.tsi_historia_clinica.Name = "tsi_historia_clinica"
        Me.tsi_historia_clinica.Size = New System.Drawing.Size(193, 22)
        Me.tsi_historia_clinica.Text = "Historia Clinica"
        '
        'tsi_calendarioDeVacunas
        '
        Me.tsi_calendarioDeVacunas.Name = "tsi_calendarioDeVacunas"
        Me.tsi_calendarioDeVacunas.Size = New System.Drawing.Size(193, 22)
        Me.tsi_calendarioDeVacunas.Text = "Calendario de vacunas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'tsi_cerrarSesion
        '
        Me.tsi_cerrarSesion.Name = "tsi_cerrarSesion"
        Me.tsi_cerrarSesion.Size = New System.Drawing.Size(193, 22)
        Me.tsi_cerrarSesion.Text = "Cerrar sesion"
        '
        'tsi_salir
        '
        Me.tsi_salir.Name = "tsi_salir"
        Me.tsi_salir.Size = New System.Drawing.Size(193, 22)
        Me.tsi_salir.Text = "Salir"
        '
        'mts_consultas
        '
        Me.mts_consultas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsi_cita, Me.tsi_vacunacion, Me.tsi_internacion})
        Me.mts_consultas.Name = "mts_consultas"
        Me.mts_consultas.Size = New System.Drawing.Size(45, 20)
        Me.mts_consultas.Text = "Citas"
        '
        'tsi_cita
        '
        Me.tsi_cita.Name = "tsi_cita"
        Me.tsi_cita.Size = New System.Drawing.Size(136, 22)
        Me.tsi_cita.Text = "Control"
        '
        'tsi_vacunacion
        '
        Me.tsi_vacunacion.Name = "tsi_vacunacion"
        Me.tsi_vacunacion.Size = New System.Drawing.Size(136, 22)
        Me.tsi_vacunacion.Text = "Vacunacion"
        '
        'tsi_internacion
        '
        Me.tsi_internacion.Name = "tsi_internacion"
        Me.tsi_internacion.Size = New System.Drawing.Size(136, 22)
        Me.tsi_internacion.Text = "internacion"
        '
        'mts_listados
        '
        Me.mts_listados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsi_listadoDeEmpleados, Me.tsi_inventarioDeMedicamentos, Me.tsi_inventarioDeVacunas})
        Me.mts_listados.Name = "mts_listados"
        Me.mts_listados.Size = New System.Drawing.Size(62, 20)
        Me.mts_listados.Text = "Listados"
        '
        'tsi_listadoDeEmpleados
        '
        Me.tsi_listadoDeEmpleados.Name = "tsi_listadoDeEmpleados"
        Me.tsi_listadoDeEmpleados.Size = New System.Drawing.Size(225, 22)
        Me.tsi_listadoDeEmpleados.Text = "Listado de empleados"
        '
        'tsi_inventarioDeMedicamentos
        '
        Me.tsi_inventarioDeMedicamentos.Name = "tsi_inventarioDeMedicamentos"
        Me.tsi_inventarioDeMedicamentos.Size = New System.Drawing.Size(225, 22)
        Me.tsi_inventarioDeMedicamentos.Text = "Inventario de medicamentos"
        '
        'tsi_inventarioDeVacunas
        '
        Me.tsi_inventarioDeVacunas.Name = "tsi_inventarioDeVacunas"
        Me.tsi_inventarioDeVacunas.Size = New System.Drawing.Size(225, 22)
        Me.tsi_inventarioDeVacunas.Text = "Inventario de vacunas"
        '
        'mts_reportes
        '
        Me.mts_reportes.Name = "mts_reportes"
        Me.mts_reportes.Size = New System.Drawing.Size(65, 20)
        Me.mts_reportes.Text = "Reportes"
        '
        'tsm_administrar
        '
        Me.tsm_administrar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsi_empleados, Me.tsi_vacunas, Me.tsi_laboratorios, Me.tsi_razas, Me.tsi_medicamentos, Me.tsi_Sucursales})
        Me.tsm_administrar.Name = "tsm_administrar"
        Me.tsm_administrar.Size = New System.Drawing.Size(81, 20)
        Me.tsm_administrar.Text = "Administrar"
        '
        'tsi_empleados
        '
        Me.tsi_empleados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsi_subordinados, Me.tsi_supervisores})
        Me.tsi_empleados.Name = "tsi_empleados"
        Me.tsi_empleados.Size = New System.Drawing.Size(153, 22)
        Me.tsi_empleados.Text = "Empleados"
        '
        'tsi_subordinados
        '
        Me.tsi_subordinados.Name = "tsi_subordinados"
        Me.tsi_subordinados.Size = New System.Drawing.Size(147, 22)
        Me.tsi_subordinados.Text = "Subordinados"
        '
        'tsi_supervisores
        '
        Me.tsi_supervisores.Name = "tsi_supervisores"
        Me.tsi_supervisores.Size = New System.Drawing.Size(147, 22)
        Me.tsi_supervisores.Text = "Supervisores"
        '
        'tsi_vacunas
        '
        Me.tsi_vacunas.Name = "tsi_vacunas"
        Me.tsi_vacunas.Size = New System.Drawing.Size(153, 22)
        Me.tsi_vacunas.Text = "Vacunas"
        '
        'tsi_laboratorios
        '
        Me.tsi_laboratorios.Name = "tsi_laboratorios"
        Me.tsi_laboratorios.Size = New System.Drawing.Size(153, 22)
        Me.tsi_laboratorios.Text = "Laboratorios"
        '
        'tsi_razas
        '
        Me.tsi_razas.Name = "tsi_razas"
        Me.tsi_razas.Size = New System.Drawing.Size(153, 22)
        Me.tsi_razas.Text = "Razas"
        '
        'tsi_medicamentos
        '
        Me.tsi_medicamentos.Name = "tsi_medicamentos"
        Me.tsi_medicamentos.Size = New System.Drawing.Size(153, 22)
        Me.tsi_medicamentos.Text = "Medicamentos"
        '
        'tsi_Sucursales
        '
        Me.tsi_Sucursales.Name = "tsi_Sucursales"
        Me.tsi_Sucursales.Size = New System.Drawing.Size(153, 22)
        Me.tsi_Sucursales.Text = "Sucursales"
        '
        'btn_consulta
        '
        Me.btn_consulta.Location = New System.Drawing.Point(159, 60)
        Me.btn_consulta.Name = "btn_consulta"
        Me.btn_consulta.Size = New System.Drawing.Size(103, 23)
        Me.btn_consulta.TabIndex = 1
        Me.btn_consulta.Text = "Nueva Consulta"
        Me.btn_consulta.UseVisualStyleBackColor = True
        '
        'btn_consultar_hc
        '
        Me.btn_consultar_hc.Location = New System.Drawing.Point(159, 100)
        Me.btn_consultar_hc.Name = "btn_consultar_hc"
        Me.btn_consultar_hc.Size = New System.Drawing.Size(103, 35)
        Me.btn_consultar_hc.TabIndex = 2
        Me.btn_consultar_hc.Text = "Historia Clinica"
        Me.btn_consultar_hc.UseVisualStyleBackColor = True
        '
        'btn_registrar_vacunacion
        '
        Me.btn_registrar_vacunacion.Location = New System.Drawing.Point(159, 155)
        Me.btn_registrar_vacunacion.Name = "btn_registrar_vacunacion"
        Me.btn_registrar_vacunacion.Size = New System.Drawing.Size(103, 35)
        Me.btn_registrar_vacunacion.TabIndex = 3
        Me.btn_registrar_vacunacion.Text = "Registrar Vacunacion"
        Me.btn_registrar_vacunacion.UseVisualStyleBackColor = True
        '
        'frm_menu_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(844, 527)
        Me.Controls.Add(Me.btn_registrar_vacunacion)
        Me.Controls.Add(Me.btn_consultar_hc)
        Me.Controls.Add(Me.btn_consulta)
        Me.Controls.Add(Me.mst_menu_principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_menu_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal - Sabueso Feliz"
        Me.mst_menu_principal.ResumeLayout(False)
        Me.mst_menu_principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mst_menu_principal As System.Windows.Forms.MenuStrip
    Friend WithEvents mts_paciente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_nuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mts_consultas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_historia_clinica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mts_listados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mts_reportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_calendarioDeVacunas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsi_cerrarSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_cita As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_vacunacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_listadoDeEmpleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_inventarioDeMedicamentos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_inventarioDeVacunas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_administrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_empleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_subordinados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_supervisores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_vacunas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_laboratorios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_razas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_medicamentos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_Sucursales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_internacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_consulta As System.Windows.Forms.Button
    Friend WithEvents btn_consultar_hc As System.Windows.Forms.Button
    Friend WithEvents btn_registrar_vacunacion As System.Windows.Forms.Button
End Class
