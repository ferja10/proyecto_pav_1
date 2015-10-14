<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alta_Sucursal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alta_Sucursal))
        Me.txt_Buscar = New System.Windows.Forms.MaskedTextBox()
        Me.GrillaSucursales = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelAlta = New System.Windows.Forms.Panel()
        Me.txt_Contr = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Codigo = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelGrilla = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        CType(Me.GrillaSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAlta.SuspendLayout()
        Me.PanelGrilla.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Buscar
        '
        Me.txt_Buscar.Location = New System.Drawing.Point(78, 18)
        Me.txt_Buscar.Name = "txt_Buscar"
        Me.txt_Buscar.Size = New System.Drawing.Size(577, 20)
        Me.txt_Buscar.TabIndex = 0
        '
        'GrillaSucursales
        '
        Me.GrillaSucursales.AllowUserToAddRows = False
        Me.GrillaSucursales.AllowUserToDeleteRows = False
        Me.GrillaSucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrillaSucursales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GrillaSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaSucursales.Location = New System.Drawing.Point(25, 55)
        Me.GrillaSucursales.Name = "GrillaSucursales"
        Me.GrillaSucursales.ReadOnly = True
        Me.GrillaSucursales.Size = New System.Drawing.Size(704, 178)
        Me.GrillaSucursales.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar"
        '
        'PanelAlta
        '
        Me.PanelAlta.Controls.Add(Me.txt_Contr)
        Me.PanelAlta.Controls.Add(Me.txt_Nombre)
        Me.PanelAlta.Controls.Add(Me.Label3)
        Me.PanelAlta.Controls.Add(Me.txt_Codigo)
        Me.PanelAlta.Controls.Add(Me.Label7)
        Me.PanelAlta.Controls.Add(Me.Label6)
        Me.PanelAlta.Location = New System.Drawing.Point(12, 12)
        Me.PanelAlta.Name = "PanelAlta"
        Me.PanelAlta.Size = New System.Drawing.Size(739, 230)
        Me.PanelAlta.TabIndex = 7
        '
        'txt_Contr
        '
        Me.txt_Contr.Location = New System.Drawing.Point(17, 193)
        Me.txt_Contr.MaxLength = 50
        Me.txt_Contr.Name = "txt_Contr"
        Me.txt_Contr.Size = New System.Drawing.Size(277, 20)
        Me.txt_Contr.TabIndex = 3
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(18, 112)
        Me.txt_Nombre.MaxLength = 50
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(292, 20)
        Me.txt_Nombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Contraseña"
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Enabled = False
        Me.txt_Codigo.Location = New System.Drawing.Point(17, 49)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(96, 20)
        Me.txt_Codigo.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Codigo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nombre"
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.Label1)
        Me.PanelGrilla.Controls.Add(Me.GrillaSucursales)
        Me.PanelGrilla.Controls.Add(Me.txt_Buscar)
        Me.PanelGrilla.Location = New System.Drawing.Point(12, 9)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.Size = New System.Drawing.Size(739, 233)
        Me.PanelGrilla.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_cancelar)
        Me.Panel3.Controls.Add(Me.btn_guardar)
        Me.Panel3.Controls.Add(Me.btn_nuevo)
        Me.Panel3.Controls.Add(Me.btn_salir)
        Me.Panel3.Controls.Add(Me.btn_eliminar)
        Me.Panel3.Location = New System.Drawing.Point(12, 248)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(739, 52)
        Me.Panel3.TabIndex = 8
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(105, 3)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(45, 43)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.Location = New System.Drawing.Point(156, 3)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(45, 43)
        Me.btn_guardar.TabIndex = 8
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(3, 3)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(45, 43)
        Me.btn_nuevo.TabIndex = 6
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(691, 6)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(45, 37)
        Me.btn_salir.TabIndex = 10
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(54, 3)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(45, 43)
        Me.btn_eliminar.TabIndex = 7
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'frm_alta_Sucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(753, 303)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelGrilla)
        Me.Controls.Add(Me.PanelAlta)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_alta_Sucursal"
        Me.ShowIcon = False
        Me.Text = "Alta Sucursal"
        CType(Me.GrillaSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAlta.ResumeLayout(False)
        Me.PanelAlta.PerformLayout()
        Me.PanelGrilla.ResumeLayout(False)
        Me.PanelGrilla.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Buscar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GrillaSucursales As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelAlta As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PanelGrilla As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_Codigo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Contr As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
End Class
