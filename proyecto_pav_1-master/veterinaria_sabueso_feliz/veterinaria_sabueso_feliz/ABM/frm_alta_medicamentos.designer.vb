<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alta_medicamentos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alta_medicamentos))
        Me.Lbl_Razon_Social = New System.Windows.Forms.Label()
        Me.txt_Medicamentos = New System.Windows.Forms.TextBox()
        Me.dgc_Medicamentos = New System.Windows.Forms.DataGridView()
        Me.PanelGrilla = New System.Windows.Forms.Panel()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.panel_Alta = New System.Windows.Forms.Panel()
        Me.txt_Cantidad_existente = New System.Windows.Forms.MaskedTextBox()
        Me.txt_CantidadMinima = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.txt_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.cmb_Laboratorio = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.TTNuevo = New System.Windows.Forms.ToolTip(Me.components)
        Me.TTEliminar = New System.Windows.Forms.ToolTip(Me.components)
        Me.TTSalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.TTDesc = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgc_Medicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrilla.SuspendLayout()
        Me.panel_Alta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Razon_Social
        '
        Me.Lbl_Razon_Social.AutoSize = True
        Me.Lbl_Razon_Social.Location = New System.Drawing.Point(17, 19)
        Me.Lbl_Razon_Social.Name = "Lbl_Razon_Social"
        Me.Lbl_Razon_Social.Size = New System.Drawing.Size(63, 13)
        Me.Lbl_Razon_Social.TabIndex = 0
        Me.Lbl_Razon_Social.Text = "Descripción"
        '
        'txt_Medicamentos
        '
        Me.txt_Medicamentos.Location = New System.Drawing.Point(121, 16)
        Me.txt_Medicamentos.MaxLength = 50
        Me.txt_Medicamentos.Name = "txt_Medicamentos"
        Me.txt_Medicamentos.Size = New System.Drawing.Size(364, 20)
        Me.txt_Medicamentos.TabIndex = 1
        '
        'dgc_Medicamentos
        '
        Me.dgc_Medicamentos.AllowUserToAddRows = False
        Me.dgc_Medicamentos.AllowUserToDeleteRows = False
        Me.dgc_Medicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgc_Medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgc_Medicamentos.Location = New System.Drawing.Point(20, 58)
        Me.dgc_Medicamentos.Name = "dgc_Medicamentos"
        Me.dgc_Medicamentos.ReadOnly = True
        Me.dgc_Medicamentos.Size = New System.Drawing.Size(704, 294)
        Me.dgc_Medicamentos.TabIndex = 0
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.txt_Medicamentos)
        Me.PanelGrilla.Controls.Add(Me.Lbl_Razon_Social)
        Me.PanelGrilla.Controls.Add(Me.dgc_Medicamentos)
        Me.PanelGrilla.Location = New System.Drawing.Point(0, 0)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.Size = New System.Drawing.Size(753, 364)
        Me.PanelGrilla.TabIndex = 2
        '
        'btn_guardar
        '
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.Location = New System.Drawing.Point(165, 384)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(45, 43)
        Me.btn_guardar.TabIndex = 15
        Me.btn_guardar.UseVisualStyleBackColor = True
        Me.btn_guardar.Visible = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.Location = New System.Drawing.Point(114, 384)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(45, 43)
        Me.btn_Cancelar.TabIndex = 14
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        Me.btn_Cancelar.Visible = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(63, 384)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(45, 43)
        Me.btn_eliminar.TabIndex = 8
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'panel_Alta
        '
        Me.panel_Alta.Controls.Add(Me.txt_Cantidad_existente)
        Me.panel_Alta.Controls.Add(Me.txt_CantidadMinima)
        Me.panel_Alta.Controls.Add(Me.Label6)
        Me.panel_Alta.Controls.Add(Me.Label5)
        Me.panel_Alta.Controls.Add(Me.lbl_sucursal)
        Me.panel_Alta.Controls.Add(Me.txt_Fecha)
        Me.panel_Alta.Controls.Add(Me.cmb_Laboratorio)
        Me.panel_Alta.Controls.Add(Me.Label4)
        Me.panel_Alta.Controls.Add(Me.txt_Descripcion)
        Me.panel_Alta.Controls.Add(Me.Label3)
        Me.panel_Alta.Controls.Add(Me.Label2)
        Me.panel_Alta.Controls.Add(Me.txt_Id)
        Me.panel_Alta.Controls.Add(Me.Label1)
        Me.panel_Alta.Location = New System.Drawing.Point(2, 12)
        Me.panel_Alta.Name = "panel_Alta"
        Me.panel_Alta.Size = New System.Drawing.Size(739, 352)
        Me.panel_Alta.TabIndex = 1
        Me.panel_Alta.Visible = False
        '
        'txt_Cantidad_existente
        '
        Me.txt_Cantidad_existente.Location = New System.Drawing.Point(281, 233)
        Me.txt_Cantidad_existente.Mask = "999999999"
        Me.txt_Cantidad_existente.Name = "txt_Cantidad_existente"
        Me.txt_Cantidad_existente.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txt_Cantidad_existente.Size = New System.Drawing.Size(63, 20)
        Me.txt_Cantidad_existente.TabIndex = 19
        '
        'txt_CantidadMinima
        '
        Me.txt_CantidadMinima.Location = New System.Drawing.Point(125, 233)
        Me.txt_CantidadMinima.Mask = "99999999"
        Me.txt_CantidadMinima.Name = "txt_CantidadMinima"
        Me.txt_CantidadMinima.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txt_CantidadMinima.Size = New System.Drawing.Size(54, 20)
        Me.txt_CantidadMinima.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Cantidad Minimo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Cantidad"
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.AutoSize = True
        Me.lbl_sucursal.Location = New System.Drawing.Point(617, 36)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(48, 13)
        Me.lbl_sucursal.TabIndex = 13
        Me.lbl_sucursal.Text = "Sucursal"
        '
        'txt_Fecha
        '
        Me.txt_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_Fecha.Location = New System.Drawing.Point(192, 121)
        Me.txt_Fecha.MaxDate = New Date(2015, 10, 8, 0, 0, 0, 0)
        Me.txt_Fecha.MinDate = New Date(1999, 12, 31, 0, 0, 0, 0)
        Me.txt_Fecha.Name = "txt_Fecha"
        Me.txt_Fecha.Size = New System.Drawing.Size(96, 20)
        Me.txt_Fecha.TabIndex = 3
        Me.txt_Fecha.Value = New Date(2015, 10, 8, 0, 0, 0, 0)
        '
        'cmb_Laboratorio
        '
        Me.cmb_Laboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Laboratorio.FormattingEnabled = True
        Me.cmb_Laboratorio.ItemHeight = 13
        Me.cmb_Laboratorio.Location = New System.Drawing.Point(192, 179)
        Me.cmb_Laboratorio.Name = "cmb_Laboratorio"
        Me.cmb_Laboratorio.Size = New System.Drawing.Size(364, 21)
        Me.cmb_Laboratorio.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nombre de Laboratorio"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Location = New System.Drawing.Point(192, 77)
        Me.txt_Descripcion.MaxLength = 50
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(364, 20)
        Me.txt_Descripcion.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Descripción o Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Numero de Identificacción"
        '
        'txt_Id
        '
        Me.txt_Id.Enabled = False
        Me.txt_Id.Location = New System.Drawing.Point(192, 33)
        Me.txt_Id.MaxLength = 99999
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(62, 20)
        Me.txt_Id.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha de Compra"
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(696, 390)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(45, 37)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 384)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(45, 43)
        Me.btn_nuevo.TabIndex = 7
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'frm_alta_medicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(753, 435)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.panel_Alta)
        Me.Controls.Add(Me.PanelGrilla)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_alta_medicamentos"
        Me.Text = "Medicamentos"
        CType(Me.dgc_Medicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrilla.ResumeLayout(False)
        Me.PanelGrilla.PerformLayout()
        Me.panel_Alta.ResumeLayout(False)
        Me.panel_Alta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_Razon_Social As System.Windows.Forms.Label
    Friend WithEvents txt_Medicamentos As System.Windows.Forms.TextBox
    Friend WithEvents dgc_Medicamentos As System.Windows.Forms.DataGridView
    Friend WithEvents PanelGrilla As System.Windows.Forms.Panel
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents panel_Alta As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Id As System.Windows.Forms.TextBox
    Friend WithEvents txt_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TTNuevo As System.Windows.Forms.ToolTip
    Friend WithEvents TTEliminar As System.Windows.Forms.ToolTip
    Friend WithEvents TTSalir As System.Windows.Forms.ToolTip
    Friend WithEvents TTDesc As System.Windows.Forms.ToolTip
    Friend WithEvents cmb_Laboratorio As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents txt_Cantidad_existente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_CantidadMinima As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_sucursal As System.Windows.Forms.Label
End Class
