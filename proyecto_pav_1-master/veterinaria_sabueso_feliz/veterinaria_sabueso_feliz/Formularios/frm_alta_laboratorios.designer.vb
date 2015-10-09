<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alta_labortorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alta_labortorios))
        Me.Lbl_Razon_Social = New System.Windows.Forms.Label()
        Me.txt_Razon_Social = New System.Windows.Forms.TextBox()
        Me.dgc_Laboratorios = New System.Windows.Forms.DataGridView()
        Me.PanelGrilla = New System.Windows.Forms.Panel()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.panel_Alta = New System.Windows.Forms.Panel()
        Me.txt_RazonSocialNew = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.TTNuevo = New System.Windows.Forms.ToolTip(Me.components)
        Me.TTEliminar = New System.Windows.Forms.ToolTip(Me.components)
        Me.TTSalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.TTDirec = New System.Windows.Forms.ToolTip(Me.components)
        Me.TTRazonSoc = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgc_Laboratorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrilla.SuspendLayout()
        Me.panel_Alta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Razon_Social
        '
        Me.Lbl_Razon_Social.AutoSize = True
        Me.Lbl_Razon_Social.Location = New System.Drawing.Point(17, 19)
        Me.Lbl_Razon_Social.Name = "Lbl_Razon_Social"
        Me.Lbl_Razon_Social.Size = New System.Drawing.Size(70, 13)
        Me.Lbl_Razon_Social.TabIndex = 0
        Me.Lbl_Razon_Social.Text = "Razon Social"
        '
        'txt_Razon_Social
        '
        Me.txt_Razon_Social.Location = New System.Drawing.Point(121, 16)
        Me.txt_Razon_Social.Name = "txt_Razon_Social"
        Me.txt_Razon_Social.Size = New System.Drawing.Size(364, 20)
        Me.txt_Razon_Social.TabIndex = 1
        '
        'dgc_Laboratorios
        '
        Me.dgc_Laboratorios.AllowUserToAddRows = False
        Me.dgc_Laboratorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgc_Laboratorios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgc_Laboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgc_Laboratorios.Location = New System.Drawing.Point(20, 58)
        Me.dgc_Laboratorios.Name = "dgc_Laboratorios"
        Me.dgc_Laboratorios.ReadOnly = True
        Me.dgc_Laboratorios.Size = New System.Drawing.Size(704, 294)
        Me.dgc_Laboratorios.TabIndex = 0
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.txt_Razon_Social)
        Me.PanelGrilla.Controls.Add(Me.Lbl_Razon_Social)
        Me.PanelGrilla.Controls.Add(Me.dgc_Laboratorios)
        Me.PanelGrilla.Location = New System.Drawing.Point(0, 0)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.Size = New System.Drawing.Size(753, 364)
        Me.PanelGrilla.TabIndex = 2
        '
        'btn_guardar
        '
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.Location = New System.Drawing.Point(194, 384)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(45, 43)
        Me.btn_guardar.TabIndex = 14
        Me.btn_guardar.UseVisualStyleBackColor = True
        Me.btn_guardar.Visible = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.Location = New System.Drawing.Point(131, 384)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(45, 43)
        Me.btn_Cancelar.TabIndex = 13
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        Me.btn_Cancelar.Visible = False
        '
        'panel_Alta
        '
        Me.panel_Alta.Controls.Add(Me.txt_RazonSocialNew)
        Me.panel_Alta.Controls.Add(Me.Label3)
        Me.panel_Alta.Controls.Add(Me.Label2)
        Me.panel_Alta.Controls.Add(Me.txt_Id)
        Me.panel_Alta.Controls.Add(Me.txt_Direccion)
        Me.panel_Alta.Controls.Add(Me.Label1)
        Me.panel_Alta.Location = New System.Drawing.Point(2, 12)
        Me.panel_Alta.Name = "panel_Alta"
        Me.panel_Alta.Size = New System.Drawing.Size(739, 352)
        Me.panel_Alta.TabIndex = 1
        Me.panel_Alta.Visible = False
        '
        'txt_RazonSocialNew
        '
        Me.txt_RazonSocialNew.Location = New System.Drawing.Point(192, 77)
        Me.txt_RazonSocialNew.MaxLength = 50
        Me.txt_RazonSocialNew.Name = "txt_RazonSocialNew"
        Me.txt_RazonSocialNew.Size = New System.Drawing.Size(364, 20)
        Me.txt_RazonSocialNew.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Razon Social"
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
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(62, 20)
        Me.txt_Id.TabIndex = 8
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Location = New System.Drawing.Point(192, 121)
        Me.txt_Direccion.MaxLength = 50
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(364, 20)
        Me.txt_Direccion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dirección"
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(696, 390)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(45, 37)
        Me.btn_salir.TabIndex = 7
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
        Me.btn_nuevo.TabIndex = 5
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(71, 384)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(45, 43)
        Me.btn_eliminar.TabIndex = 6
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'frm_alta_labortorios
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(753, 430)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.PanelGrilla)
        Me.Controls.Add(Me.panel_Alta)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_alta_labortorios"
        Me.Text = "Laboriatorios"
        CType(Me.dgc_Laboratorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrilla.ResumeLayout(False)
        Me.PanelGrilla.PerformLayout()
        Me.panel_Alta.ResumeLayout(False)
        Me.panel_Alta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_Razon_Social As System.Windows.Forms.Label
    Friend WithEvents txt_Razon_Social As System.Windows.Forms.TextBox
    Friend WithEvents dgc_Laboratorios As System.Windows.Forms.DataGridView
    Friend WithEvents PanelGrilla As System.Windows.Forms.Panel
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents panel_Alta As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Id As System.Windows.Forms.TextBox
    Friend WithEvents txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_RazonSocialNew As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TTNuevo As System.Windows.Forms.ToolTip
    Friend WithEvents TTEliminar As System.Windows.Forms.ToolTip
    Friend WithEvents TTSalir As System.Windows.Forms.ToolTip
    Friend WithEvents TTDirec As System.Windows.Forms.ToolTip
    Friend WithEvents TTRazonSoc As System.Windows.Forms.ToolTip
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
End Class
