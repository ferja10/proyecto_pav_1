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
        Me.PanelGrilla = New System.Windows.Forms.Panel()
        Me.Lbl_Denominacion = New System.Windows.Forms.Label()
        Me.txt_Buscar = New System.Windows.Forms.TextBox()
        Me.GrillaRaza = New System.Windows.Forms.DataGridView()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.PanelAlta = New System.Windows.Forms.Panel()
        Me.txt_Cuidados = New System.Windows.Forms.TextBox()
        Me.txt_Denominacion = New System.Windows.Forms.TextBox()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.txt_AMedH = New System.Windows.Forms.MaskedTextBox()
        Me.txt_PMinH = New System.Windows.Forms.MaskedTextBox()
        Me.txt_AMedM = New System.Windows.Forms.MaskedTextBox()
        Me.txt_PMinM = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lebel2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.PanelGrilla.SuspendLayout()
        CType(Me.GrillaRaza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAlta.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.Lbl_Denominacion)
        Me.PanelGrilla.Controls.Add(Me.txt_Buscar)
        Me.PanelGrilla.Controls.Add(Me.GrillaRaza)
        Me.PanelGrilla.Location = New System.Drawing.Point(3, 5)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.Size = New System.Drawing.Size(753, 364)
        Me.PanelGrilla.TabIndex = 0
        '
        'Lbl_Denominacion
        '
        Me.Lbl_Denominacion.AutoSize = True
        Me.Lbl_Denominacion.Location = New System.Drawing.Point(59, 12)
        Me.Lbl_Denominacion.Name = "Lbl_Denominacion"
        Me.Lbl_Denominacion.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_Denominacion.TabIndex = 3
        Me.Lbl_Denominacion.Text = "Denominación"
        '
        'txt_Buscar
        '
        Me.txt_Buscar.Location = New System.Drawing.Point(164, 9)
        Me.txt_Buscar.Name = "txt_Buscar"
        Me.txt_Buscar.Size = New System.Drawing.Size(364, 20)
        Me.txt_Buscar.TabIndex = 2
        '
        'GrillaRaza
        '
        Me.GrillaRaza.AllowUserToAddRows = False
        Me.GrillaRaza.AllowUserToDeleteRows = False
        Me.GrillaRaza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrillaRaza.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GrillaRaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaRaza.Location = New System.Drawing.Point(24, 35)
        Me.GrillaRaza.Name = "GrillaRaza"
        Me.GrillaRaza.ReadOnly = True
        Me.GrillaRaza.Size = New System.Drawing.Size(704, 294)
        Me.GrillaRaza.TabIndex = 1
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 375)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(45, 43)
        Me.btn_nuevo.TabIndex = 6
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(63, 375)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(45, 43)
        Me.btn_eliminar.TabIndex = 7
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Cancelar.Image = CType(resources.GetObject("btn_Cancelar.Image"), System.Drawing.Image)
        Me.btn_Cancelar.Location = New System.Drawing.Point(114, 375)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(45, 43)
        Me.btn_Cancelar.TabIndex = 14
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        Me.btn_Cancelar.Visible = False
        '
        'btn_guardar
        '
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.Location = New System.Drawing.Point(165, 375)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(45, 43)
        Me.btn_guardar.TabIndex = 15
        Me.btn_guardar.UseVisualStyleBackColor = True
        Me.btn_guardar.Visible = False
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(696, 381)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(45, 37)
        Me.btn_salir.TabIndex = 16
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'PanelAlta
        '
        Me.PanelAlta.Controls.Add(Me.txt_Cuidados)
        Me.PanelAlta.Controls.Add(Me.txt_Denominacion)
        Me.PanelAlta.Controls.Add(Me.txt_Codigo)
        Me.PanelAlta.Controls.Add(Me.txt_AMedH)
        Me.PanelAlta.Controls.Add(Me.txt_PMinH)
        Me.PanelAlta.Controls.Add(Me.txt_AMedM)
        Me.PanelAlta.Controls.Add(Me.txt_PMinM)
        Me.PanelAlta.Controls.Add(Me.Label7)
        Me.PanelAlta.Controls.Add(Me.Label6)
        Me.PanelAlta.Controls.Add(Me.Label5)
        Me.PanelAlta.Controls.Add(Me.Label4)
        Me.PanelAlta.Controls.Add(Me.Label3)
        Me.PanelAlta.Controls.Add(Me.Lebel2)
        Me.PanelAlta.Controls.Add(Me.Label1)
        Me.PanelAlta.Location = New System.Drawing.Point(2, 5)
        Me.PanelAlta.Name = "PanelAlta"
        Me.PanelAlta.Size = New System.Drawing.Size(739, 352)
        Me.PanelAlta.TabIndex = 4
        '
        'txt_Cuidados
        '
        Me.txt_Cuidados.Location = New System.Drawing.Point(143, 197)
        Me.txt_Cuidados.Multiline = True
        Me.txt_Cuidados.Name = "txt_Cuidados"
        Me.txt_Cuidados.Size = New System.Drawing.Size(532, 84)
        Me.txt_Cuidados.TabIndex = 13
        '
        'txt_Denominacion
        '
        Me.txt_Denominacion.Location = New System.Drawing.Point(143, 67)
        Me.txt_Denominacion.MaxLength = 50
        Me.txt_Denominacion.Name = "txt_Denominacion"
        Me.txt_Denominacion.Size = New System.Drawing.Size(250, 20)
        Me.txt_Denominacion.TabIndex = 12
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Enabled = False
        Me.txt_Codigo.Location = New System.Drawing.Point(143, 41)
        Me.txt_Codigo.MaxLength = 999999
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(65, 20)
        Me.txt_Codigo.TabIndex = 11
        '
        'txt_AMedH
        '
        Me.txt_AMedH.Location = New System.Drawing.Point(143, 171)
        Me.txt_AMedH.Mask = "999"
        Me.txt_AMedH.Name = "txt_AMedH"
        Me.txt_AMedH.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txt_AMedH.Size = New System.Drawing.Size(37, 20)
        Me.txt_AMedH.TabIndex = 10
        '
        'txt_PMinH
        '
        Me.txt_PMinH.Location = New System.Drawing.Point(143, 145)
        Me.txt_PMinH.Mask = "999"
        Me.txt_PMinH.Name = "txt_PMinH"
        Me.txt_PMinH.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txt_PMinH.Size = New System.Drawing.Size(37, 20)
        Me.txt_PMinH.TabIndex = 9
        '
        'txt_AMedM
        '
        Me.txt_AMedM.Location = New System.Drawing.Point(143, 119)
        Me.txt_AMedM.Mask = "999"
        Me.txt_AMedM.Name = "txt_AMedM"
        Me.txt_AMedM.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txt_AMedM.Size = New System.Drawing.Size(37, 20)
        Me.txt_AMedM.TabIndex = 8
        '
        'txt_PMinM
        '
        Me.txt_PMinM.Location = New System.Drawing.Point(143, 93)
        Me.txt_PMinM.Mask = "999"
        Me.txt_PMinM.Name = "txt_PMinM"
        Me.txt_PMinM.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txt_PMinM.Size = New System.Drawing.Size(37, 20)
        Me.txt_PMinM.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cuidados"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Altura Media Hembra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Peso Minimo Hembra"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Altura Media Macho"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Peso minimo Macho"
        '
        'Lebel2
        '
        Me.Lebel2.AutoSize = True
        Me.Lebel2.Location = New System.Drawing.Point(35, 70)
        Me.Lebel2.Name = "Lebel2"
        Me.Lebel2.Size = New System.Drawing.Size(75, 13)
        Me.Lebel2.TabIndex = 1
        Me.Lebel2.Text = "Denominación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identificación"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(143, 93)
        Me.MaskedTextBox1.Mask = "99.99"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.MaskedTextBox1.Size = New System.Drawing.Size(37, 20)
        Me.MaskedTextBox1.TabIndex = 7
        '
        'frm_alta_razas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(753, 430)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.PanelGrilla)
        Me.Controls.Add(Me.PanelAlta)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_alta_razas"
        Me.Text = "Alta_razas"
        Me.PanelGrilla.ResumeLayout(False)
        Me.PanelGrilla.PerformLayout()
        CType(Me.GrillaRaza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAlta.ResumeLayout(False)
        Me.PanelAlta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelGrilla As System.Windows.Forms.Panel
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents GrillaRaza As System.Windows.Forms.DataGridView
    Friend WithEvents txt_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Denominacion As System.Windows.Forms.Label
    Friend WithEvents PanelAlta As System.Windows.Forms.Panel
    Friend WithEvents txt_Cuidados As System.Windows.Forms.TextBox
    Friend WithEvents txt_Denominacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_AMedH As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_PMinH As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_AMedM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_PMinM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lebel2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
End Class
