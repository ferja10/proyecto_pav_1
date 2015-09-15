<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_Laboratorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alta_Laboratorios))
        Me.Lbl_Razon_Social = New System.Windows.Forms.Label()
        Me.txt_Razon_Social = New System.Windows.Forms.TextBox()
        Me.dgc_Laboratorios = New System.Windows.Forms.DataGridView()
        Me.LABORATORIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelGrilla = New System.Windows.Forms.Panel()
        Me.panel_Alta = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.txt_RazonSocialNew = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Razon_Social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgc_Laboratorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LABORATORIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

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
        Me.dgc_Laboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgc_Laboratorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Razon_Social, Me.Direccion})
        Me.dgc_Laboratorios.Location = New System.Drawing.Point(20, 58)
        Me.dgc_Laboratorios.Name = "dgc_Laboratorios"
        Me.dgc_Laboratorios.Size = New System.Drawing.Size(704, 294)
        Me.dgc_Laboratorios.TabIndex = 0
        '
        'LABORATORIOSBindingSource
        '
        Me.LABORATORIOSBindingSource.DataMember = "LABORATORIOS"

        '
        'PAVDataSet
        '
        
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.dgc_Laboratorios)
        Me.PanelGrilla.Controls.Add(Me.txt_Razon_Social)
        Me.PanelGrilla.Controls.Add(Me.Lbl_Razon_Social)
        Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrilla.Location = New System.Drawing.Point(0, 0)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.Size = New System.Drawing.Size(753, 430)
        Me.PanelGrilla.TabIndex = 2
        '
        'panel_Alta
        '
        Me.panel_Alta.Controls.Add(Me.txt_RazonSocialNew)
        Me.panel_Alta.Controls.Add(Me.btn_Cancelar)
        Me.panel_Alta.Controls.Add(Me.Label3)
        Me.panel_Alta.Controls.Add(Me.btn_Aceptar)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Numero de Identificacción"
        '
        'txt_Id
        '
        Me.txt_Id.Enabled = False
        Me.txt_Id.Location = New System.Drawing.Point(171, 123)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(62, 20)
        Me.txt_Id.TabIndex = 2
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Location = New System.Drawing.Point(110, 63)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(364, 20)
        Me.txt_Direccion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 66)
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
        Me.btn_nuevo.TabIndex = 6
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(71, 384)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(45, 43)
        Me.btn_eliminar.TabIndex = 5
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'LABORATORIOSTableAdapter
        '

        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Location = New System.Drawing.Point(110, 163)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Aceptar.TabIndex = 4
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(399, 163)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancelar.TabIndex = 5
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'txt_RazonSocialNew
        '
        Me.txt_RazonSocialNew.Location = New System.Drawing.Point(110, 25)
        Me.txt_RazonSocialNew.Name = "txt_RazonSocialNew"
        Me.txt_RazonSocialNew.Size = New System.Drawing.Size(364, 20)
        Me.txt_RazonSocialNew.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Razon Social"
        '
        'Razon_Social
        '
        Me.Razon_Social.HeaderText = "Razon Social"
        Me.Razon_Social.Name = "Razon_Social"
        Me.Razon_Social.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Dirección"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'Alta_Laboratorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(753, 430)
        Me.Controls.Add(Me.PanelGrilla)
        Me.Controls.Add(Me.panel_Alta)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_eliminar)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "Alta_Laboratorios"
        Me.Text = "Laboriatorios"
        CType(Me.dgc_Laboratorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LABORATORIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LABORATORIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents panel_Alta As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Id As System.Windows.Forms.TextBox
    Friend WithEvents txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_RazonSocialNew As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Razon_Social As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
