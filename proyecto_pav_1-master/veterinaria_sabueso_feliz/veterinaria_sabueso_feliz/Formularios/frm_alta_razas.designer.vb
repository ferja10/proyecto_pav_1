<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alta_razas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alta_razas))
        Me.GrillaRaza = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelAlta = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_AMedH = New System.Windows.Forms.MaskedTextBox()
        Me.txt_PMinH = New System.Windows.Forms.MaskedTextBox()
        Me.txt_AMedM = New System.Windows.Forms.MaskedTextBox()
        Me.txt_PMinM = New System.Windows.Forms.MaskedTextBox()
        Me.txt_Denominacion = New System.Windows.Forms.MaskedTextBox()
        Me.txt_Codigo = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Cuidados = New System.Windows.Forms.Panel()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.PanelGrilla = New System.Windows.Forms.Panel()
        Me.txt_Buscar = New System.Windows.Forms.MaskedTextBox()
        CType(Me.GrillaRaza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAlta.SuspendLayout()
        Me.txt_Cuidados.SuspendLayout()
        Me.PanelGrilla.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillaRaza
        '
        Me.GrillaRaza.AllowUserToAddRows = False
        Me.GrillaRaza.AllowUserToDeleteRows = False
        Me.GrillaRaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaRaza.Location = New System.Drawing.Point(3, 70)
        Me.GrillaRaza.Name = "GrillaRaza"
        Me.GrillaRaza.ReadOnly = True
        Me.GrillaRaza.Size = New System.Drawing.Size(723, 260)
        Me.GrillaRaza.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar"
        '
        'PanelAlta
        '
        Me.PanelAlta.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelAlta.Controls.Add(Me.Label8)
        Me.PanelAlta.Controls.Add(Me.TextBox1)
        Me.PanelAlta.Controls.Add(Me.Label7)
        Me.PanelAlta.Controls.Add(Me.Label6)
        Me.PanelAlta.Controls.Add(Me.Label5)
        Me.PanelAlta.Controls.Add(Me.Label4)
        Me.PanelAlta.Controls.Add(Me.txt_AMedH)
        Me.PanelAlta.Controls.Add(Me.txt_PMinH)
        Me.PanelAlta.Controls.Add(Me.txt_AMedM)
        Me.PanelAlta.Controls.Add(Me.txt_PMinM)
        Me.PanelAlta.Controls.Add(Me.txt_Denominacion)
        Me.PanelAlta.Controls.Add(Me.txt_Codigo)
        Me.PanelAlta.Controls.Add(Me.Label3)
        Me.PanelAlta.Controls.Add(Me.Label2)
        Me.PanelAlta.Location = New System.Drawing.Point(12, 12)
        Me.PanelAlta.Name = "PanelAlta"
        Me.PanelAlta.Size = New System.Drawing.Size(729, 333)
        Me.PanelAlta.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nota de Cuidados"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(154, 194)
        Me.TextBox1.MaxLength = 500
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(528, 113)
        Me.TextBox1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Altura media Hembra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Peso Minimo Hembra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Altura Media Macho"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Peso Minimo Macho"
        '
        'txt_AMedH
        '
        Me.txt_AMedH.Location = New System.Drawing.Point(154, 155)
        Me.txt_AMedH.Mask = "999,99"
        Me.txt_AMedH.Name = "txt_AMedH"
        Me.txt_AMedH.Size = New System.Drawing.Size(41, 20)
        Me.txt_AMedH.TabIndex = 7
        '
        'txt_PMinH
        '
        Me.txt_PMinH.Location = New System.Drawing.Point(154, 129)
        Me.txt_PMinH.Mask = "99,99"
        Me.txt_PMinH.Name = "txt_PMinH"
        Me.txt_PMinH.Size = New System.Drawing.Size(41, 20)
        Me.txt_PMinH.TabIndex = 6
        '
        'txt_AMedM
        '
        Me.txt_AMedM.Location = New System.Drawing.Point(154, 103)
        Me.txt_AMedM.Mask = "999,99"
        Me.txt_AMedM.Name = "txt_AMedM"
        Me.txt_AMedM.Size = New System.Drawing.Size(41, 20)
        Me.txt_AMedM.TabIndex = 5
        '
        'txt_PMinM
        '
        Me.txt_PMinM.Location = New System.Drawing.Point(154, 77)
        Me.txt_PMinM.Mask = "99,99"
        Me.txt_PMinM.Name = "txt_PMinM"
        Me.txt_PMinM.Size = New System.Drawing.Size(41, 20)
        Me.txt_PMinM.TabIndex = 4
        '
        'txt_Denominacion
        '
        Me.txt_Denominacion.Location = New System.Drawing.Point(154, 51)
        Me.txt_Denominacion.Name = "txt_Denominacion"
        Me.txt_Denominacion.Size = New System.Drawing.Size(289, 20)
        Me.txt_Denominacion.TabIndex = 2
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Enabled = False
        Me.txt_Codigo.Location = New System.Drawing.Point(154, 25)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(60, 20)
        Me.txt_Codigo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Denominacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo"
        '
        'txt_Cuidados
        '
        Me.txt_Cuidados.Controls.Add(Me.btn_eliminar)
        Me.txt_Cuidados.Controls.Add(Me.btn_cancelar)
        Me.txt_Cuidados.Controls.Add(Me.btn_guardar)
        Me.txt_Cuidados.Controls.Add(Me.btn_nuevo)
        Me.txt_Cuidados.Controls.Add(Me.btn_salir)
        Me.txt_Cuidados.Location = New System.Drawing.Point(12, 366)
        Me.txt_Cuidados.Name = "txt_Cuidados"
        Me.txt_Cuidados.Size = New System.Drawing.Size(729, 52)
        Me.txt_Cuidados.TabIndex = 8
        '
        'btn_eliminar
        '
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(54, 3)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(45, 43)
        Me.btn_eliminar.TabIndex = 14
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(105, 3)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(45, 43)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.Location = New System.Drawing.Point(156, 3)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(45, 43)
        Me.btn_guardar.TabIndex = 12
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
        Me.btn_nuevo.TabIndex = 4
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(672, 6)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(45, 37)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.txt_Buscar)
        Me.PanelGrilla.Controls.Add(Me.GrillaRaza)
        Me.PanelGrilla.Controls.Add(Me.Label1)
        Me.PanelGrilla.Location = New System.Drawing.Point(12, 12)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.Size = New System.Drawing.Size(729, 333)
        Me.PanelGrilla.TabIndex = 12
        '
        'txt_Buscar
        '
        Me.txt_Buscar.Location = New System.Drawing.Point(67, 13)
        Me.txt_Buscar.Name = "txt_Buscar"
        Me.txt_Buscar.Size = New System.Drawing.Size(615, 20)
        Me.txt_Buscar.TabIndex = 1
        '
        'frm_alta_razas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(753, 430)
        Me.Controls.Add(Me.txt_Cuidados)
        Me.Controls.Add(Me.PanelAlta)
        Me.Controls.Add(Me.PanelGrilla)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_alta_razas"
        Me.Text = "Razas de Perros"
        CType(Me.GrillaRaza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAlta.ResumeLayout(False)
        Me.PanelAlta.PerformLayout()
        Me.txt_Cuidados.ResumeLayout(False)
        Me.PanelGrilla.ResumeLayout(False)
        Me.PanelGrilla.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrillaRaza As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelAlta As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_AMedH As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_PMinH As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_AMedM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_PMinM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Denominacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Codigo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Cuidados As System.Windows.Forms.Panel
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents PanelGrilla As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Buscar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
End Class
