<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alta_dueño
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombre = New System.Windows.Forms.MaskedTextBox()
        Me.txt_apellido = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telefono = New System.Windows.Forms.MaskedTextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.panel_duenos = New System.Windows.Forms.Panel()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.MaskedTextBox()
        Me.grilla_duenos = New System.Windows.Forms.DataGridView()
        Me.panel_duenos.SuspendLayout()
        CType(Me.grilla_duenos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Dueño"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "telefono"
        '
        'txt_codigo
        '
        Me.txt_codigo.Enabled = False
        Me.txt_codigo.Location = New System.Drawing.Point(87, 35)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 4
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(87, 62)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 5
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(87, 90)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(100, 20)
        Me.txt_apellido.TabIndex = 6
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(87, 116)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 7
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(216, 114)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 9
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(307, 114)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(398, 114)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 11
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'panel_duenos
        '
        Me.panel_duenos.Controls.Add(Me.btn_eliminar)
        Me.panel_duenos.Controls.Add(Me.btn_nuevo)
        Me.panel_duenos.Controls.Add(Me.Label5)
        Me.panel_duenos.Controls.Add(Me.txt_buscar)
        Me.panel_duenos.Controls.Add(Me.grilla_duenos)
        Me.panel_duenos.Location = New System.Drawing.Point(12, 12)
        Me.panel_duenos.Name = "panel_duenos"
        Me.panel_duenos.Size = New System.Drawing.Size(631, 236)
        Me.panel_duenos.TabIndex = 12
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(103, 196)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(21, 196)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.btn_nuevo.TabIndex = 3
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Buscar Dueño"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(103, 14)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(100, 20)
        Me.txt_buscar.TabIndex = 1
        '
        'grilla_duenos
        '
        Me.grilla_duenos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_duenos.Location = New System.Drawing.Point(21, 40)
        Me.grilla_duenos.Name = "grilla_duenos"
        Me.grilla_duenos.Size = New System.Drawing.Size(594, 150)
        Me.grilla_duenos.TabIndex = 0
        '
        'frm_alta_dueño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(655, 268)
        Me.Controls.Add(Me.panel_duenos)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_alta_dueño"
        Me.Text = "frm_alta_dueño"
        Me.panel_duenos.ResumeLayout(False)
        Me.panel_duenos.PerformLayout()
        CType(Me.grilla_duenos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents panel_duenos As System.Windows.Forms.Panel
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_buscar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grilla_duenos As System.Windows.Forms.DataGridView
End Class
