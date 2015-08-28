<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.mst_menu_principal = New System.Windows.Forms.MenuStrip()
        Me.mts_paciente = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_nuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_historia_clinica = New System.Windows.Forms.ToolStripMenuItem()
        Me.mts_consultas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mts_listados = New System.Windows.Forms.ToolStripMenuItem()
        Me.mts_reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mts_empleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_nuevo_empleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_administrar_supervisores = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_titular = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsi_suplente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mst_menu_principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mst_menu_principal
        '
        Me.mst_menu_principal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.mst_menu_principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mts_paciente, Me.mts_consultas, Me.mts_listados, Me.mts_reportes, Me.mts_empleados})
        Me.mst_menu_principal.Location = New System.Drawing.Point(0, 0)
        Me.mst_menu_principal.Name = "mst_menu_principal"
        Me.mst_menu_principal.Size = New System.Drawing.Size(844, 24)
        Me.mst_menu_principal.TabIndex = 0
        Me.mst_menu_principal.Text = "Paciente"
        '
        'mts_paciente
        '
        Me.mts_paciente.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsi_nuevo, Me.tsi_historia_clinica})
        Me.mts_paciente.Name = "mts_paciente"
        Me.mts_paciente.Size = New System.Drawing.Size(64, 20)
        Me.mts_paciente.Text = "Paciente"
        '
        'tsi_nuevo
        '
        Me.tsi_nuevo.Name = "tsi_nuevo"
        Me.tsi_nuevo.Size = New System.Drawing.Size(154, 22)
        Me.tsi_nuevo.Text = "Nuevo"
        '
        'tsi_historia_clinica
        '
        Me.tsi_historia_clinica.Name = "tsi_historia_clinica"
        Me.tsi_historia_clinica.Size = New System.Drawing.Size(154, 22)
        Me.tsi_historia_clinica.Text = "Historia Clinica"
        '
        'mts_consultas
        '
        Me.mts_consultas.Name = "mts_consultas"
        Me.mts_consultas.Size = New System.Drawing.Size(71, 20)
        Me.mts_consultas.Text = "Consultas"
        '
        'mts_listados
        '
        Me.mts_listados.Name = "mts_listados"
        Me.mts_listados.Size = New System.Drawing.Size(62, 20)
        Me.mts_listados.Text = "Listados"
        '
        'mts_reportes
        '
        Me.mts_reportes.Name = "mts_reportes"
        Me.mts_reportes.Size = New System.Drawing.Size(65, 20)
        Me.mts_reportes.Text = "Reportes"
        '
        'mts_empleados
        '
        Me.mts_empleados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsi_nuevo_empleado, Me.tsi_administrar_supervisores})
        Me.mts_empleados.Name = "mts_empleados"
        Me.mts_empleados.Size = New System.Drawing.Size(77, 20)
        Me.mts_empleados.Text = "Empleados"
        '
        'tsi_nuevo_empleado
        '
        Me.tsi_nuevo_empleado.Name = "tsi_nuevo_empleado"
        Me.tsi_nuevo_empleado.Size = New System.Drawing.Size(205, 22)
        Me.tsi_nuevo_empleado.Text = "Nuevo"
        '
        'tsi_administrar_supervisores
        '
        Me.tsi_administrar_supervisores.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsi_titular, Me.tsi_suplente})
        Me.tsi_administrar_supervisores.Name = "tsi_administrar_supervisores"
        Me.tsi_administrar_supervisores.Size = New System.Drawing.Size(205, 22)
        Me.tsi_administrar_supervisores.Text = "Administrar Supervisores"
        '
        'tsi_titular
        '
        Me.tsi_titular.Name = "tsi_titular"
        Me.tsi_titular.Size = New System.Drawing.Size(120, 22)
        Me.tsi_titular.Text = "Titular"
        '
        'tsi_suplente
        '
        Me.tsi_suplente.Name = "tsi_suplente"
        Me.tsi_suplente.Size = New System.Drawing.Size(120, 22)
        Me.tsi_suplente.Text = "Suplente"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(844, 527)
        Me.Controls.Add(Me.mst_menu_principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MenuPrincipal"
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
    Friend WithEvents mts_empleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_nuevo_empleado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_administrar_supervisores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_titular As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsi_suplente As System.Windows.Forms.ToolStripMenuItem
End Class
