<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_abm_historia_clinica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_abm_historia_clinica))
        Me.lbl_sucursal = New System.Windows.Forms.Label()
        Me.txt_nro_historia_clinica = New System.Windows.Forms.TextBox()
        Me.lbl_nro_historia_clinica = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.dtp_fecha_nac = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.combo_raza = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_altura = New System.Windows.Forms.Label()
        Me.msk_altura = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_dueños = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_nueva_historia_clinica = New System.Windows.Forms.Button()
        Me.btn_buscar_historia_clinica = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.pnl_buscar = New System.Windows.Forms.Panel()
        Me.lblsucursal = New System.Windows.Forms.Label()
        Me.txt_sucursal = New System.Windows.Forms.MaskedTextBox()
        Me.GrillaHistoriaClinica = New System.Windows.Forms.DataGridView()
        Me.btn_buscar_hc = New System.Windows.Forms.Button()
        Me.txt__nro_hc_buscar = New System.Windows.Forms.TextBox()
        Me.lbl_nro_hc = New System.Windows.Forms.Label()
        Me.lbl_sucursal_frente = New System.Windows.Forms.Label()
        Me.txt_dueño = New System.Windows.Forms.TextBox()
        Me.msk_peso = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgv_dueños, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_buscar.SuspendLayout()
        CType(Me.GrillaHistoriaClinica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_sucursal
        '
        Me.lbl_sucursal.AutoSize = True
        Me.lbl_sucursal.Location = New System.Drawing.Point(12, 9)
        Me.lbl_sucursal.Name = "lbl_sucursal"
        Me.lbl_sucursal.Size = New System.Drawing.Size(39, 13)
        Me.lbl_sucursal.TabIndex = 0
        Me.lbl_sucursal.Text = "Label1"
        '
        'txt_nro_historia_clinica
        '
        Me.txt_nro_historia_clinica.Enabled = False
        Me.txt_nro_historia_clinica.Location = New System.Drawing.Point(765, 6)
        Me.txt_nro_historia_clinica.MaxLength = 8
        Me.txt_nro_historia_clinica.Name = "txt_nro_historia_clinica"
        Me.txt_nro_historia_clinica.Size = New System.Drawing.Size(100, 20)
        Me.txt_nro_historia_clinica.TabIndex = 1
        '
        'lbl_nro_historia_clinica
        '
        Me.lbl_nro_historia_clinica.AutoSize = True
        Me.lbl_nro_historia_clinica.Location = New System.Drawing.Point(658, 9)
        Me.lbl_nro_historia_clinica.Name = "lbl_nro_historia_clinica"
        Me.lbl_nro_historia_clinica.Size = New System.Drawing.Size(101, 13)
        Me.lbl_nro_historia_clinica.TabIndex = 2
        Me.lbl_nro_historia_clinica.Text = "Nro. Historia Clínica"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(151, 53)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(502, 20)
        Me.txt_nombre.TabIndex = 5
        '
        'dtp_fecha_nac
        '
        Me.dtp_fecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_nac.Location = New System.Drawing.Point(151, 102)
        Me.dtp_fecha_nac.Name = "dtp_fecha_nac"
        Me.dtp_fecha_nac.Size = New System.Drawing.Size(96, 20)
        Me.dtp_fecha_nac.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fercha Nac."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Raza"
        '
        'combo_raza
        '
        Me.combo_raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_raza.FormattingEnabled = True
        Me.combo_raza.Location = New System.Drawing.Point(151, 148)
        Me.combo_raza.Name = "combo_raza"
        Me.combo_raza.Size = New System.Drawing.Size(161, 21)
        Me.combo_raza.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Peso"
        '
        'lbl_altura
        '
        Me.lbl_altura.AutoSize = True
        Me.lbl_altura.Location = New System.Drawing.Point(106, 242)
        Me.lbl_altura.Name = "lbl_altura"
        Me.lbl_altura.Size = New System.Drawing.Size(34, 13)
        Me.lbl_altura.TabIndex = 11
        Me.lbl_altura.Text = "Altura"
        '
        'msk_altura
        '
        Me.msk_altura.Location = New System.Drawing.Point(151, 239)
        Me.msk_altura.Mask = "99.99"
        Me.msk_altura.Name = "msk_altura"
        Me.msk_altura.Size = New System.Drawing.Size(41, 20)
        Me.msk_altura.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Dueño"
        '
        'dgv_dueños
        '
        Me.dgv_dueños.AllowUserToAddRows = False
        Me.dgv_dueños.AllowUserToDeleteRows = False
        Me.dgv_dueños.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_dueños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dueños.Location = New System.Drawing.Point(151, 317)
        Me.dgv_dueños.Name = "dgv_dueños"
        Me.dgv_dueños.ReadOnly = True
        Me.dgv_dueños.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_dueños.Size = New System.Drawing.Size(502, 164)
        Me.dgv_dueños.TabIndex = 15
        '
        'btn_buscar
        '
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(661, 284)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(29, 21)
        Me.btn_buscar.TabIndex = 17
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(696, 284)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(25, 21)
        Me.btn_nuevo.TabIndex = 18
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.Location = New System.Drawing.Point(60, 496)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(45, 43)
        Me.btn_eliminar.TabIndex = 20
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(811, 496)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(45, 43)
        Me.btn_salir.TabIndex = 21
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_nueva_historia_clinica
        '
        Me.btn_nueva_historia_clinica.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_nueva_historia_clinica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nueva_historia_clinica.Image = CType(resources.GetObject("btn_nueva_historia_clinica.Image"), System.Drawing.Image)
        Me.btn_nueva_historia_clinica.Location = New System.Drawing.Point(3, 496)
        Me.btn_nueva_historia_clinica.Name = "btn_nueva_historia_clinica"
        Me.btn_nueva_historia_clinica.Size = New System.Drawing.Size(45, 43)
        Me.btn_nueva_historia_clinica.TabIndex = 19
        Me.btn_nueva_historia_clinica.UseVisualStyleBackColor = False
        '
        'btn_buscar_historia_clinica
        '
        Me.btn_buscar_historia_clinica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_buscar_historia_clinica.Image = CType(resources.GetObject("btn_buscar_historia_clinica.Image"), System.Drawing.Image)
        Me.btn_buscar_historia_clinica.Location = New System.Drawing.Point(117, 510)
        Me.btn_buscar_historia_clinica.Name = "btn_buscar_historia_clinica"
        Me.btn_buscar_historia_clinica.Size = New System.Drawing.Size(45, 37)
        Me.btn_buscar_historia_clinica.TabIndex = 24
        Me.btn_buscar_historia_clinica.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.Location = New System.Drawing.Point(6, 510)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(45, 37)
        Me.btn_guardar.TabIndex = 22
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.Location = New System.Drawing.Point(63, 510)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(45, 37)
        Me.btn_cancelar.TabIndex = 23
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'pnl_buscar
        '
        Me.pnl_buscar.Controls.Add(Me.lblsucursal)
        Me.pnl_buscar.Controls.Add(Me.txt_sucursal)
        Me.pnl_buscar.Controls.Add(Me.GrillaHistoriaClinica)
        Me.pnl_buscar.Controls.Add(Me.btn_buscar_hc)
        Me.pnl_buscar.Controls.Add(Me.txt__nro_hc_buscar)
        Me.pnl_buscar.Controls.Add(Me.lbl_nro_hc)
        Me.pnl_buscar.Controls.Add(Me.lbl_sucursal_frente)
        Me.pnl_buscar.Controls.Add(Me.btn_nueva_historia_clinica)
        Me.pnl_buscar.Controls.Add(Me.btn_eliminar)
        Me.pnl_buscar.Controls.Add(Me.btn_salir)
        Me.pnl_buscar.Location = New System.Drawing.Point(6, 5)
        Me.pnl_buscar.Name = "pnl_buscar"
        Me.pnl_buscar.Size = New System.Drawing.Size(859, 542)
        Me.pnl_buscar.TabIndex = 25
        '
        'lblsucursal
        '
        Me.lblsucursal.AutoSize = True
        Me.lblsucursal.Location = New System.Drawing.Point(667, 30)
        Me.lblsucursal.Name = "lblsucursal"
        Me.lblsucursal.Size = New System.Drawing.Size(48, 13)
        Me.lblsucursal.TabIndex = 28
        Me.lblsucursal.Text = "Sucursal"
        '
        'txt_sucursal
        '
        Me.txt_sucursal.Location = New System.Drawing.Point(737, 27)
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Size = New System.Drawing.Size(100, 20)
        Me.txt_sucursal.TabIndex = 27
        '
        'GrillaHistoriaClinica
        '
        Me.GrillaHistoriaClinica.AllowUserToAddRows = False
        Me.GrillaHistoriaClinica.AllowUserToDeleteRows = False
        Me.GrillaHistoriaClinica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrillaHistoriaClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaHistoriaClinica.Location = New System.Drawing.Point(57, 87)
        Me.GrillaHistoriaClinica.Name = "GrillaHistoriaClinica"
        Me.GrillaHistoriaClinica.ReadOnly = True
        Me.GrillaHistoriaClinica.Size = New System.Drawing.Size(754, 403)
        Me.GrillaHistoriaClinica.TabIndex = 26
        '
        'btn_buscar_hc
        '
        Me.btn_buscar_hc.Location = New System.Drawing.Point(299, 59)
        Me.btn_buscar_hc.Name = "btn_buscar_hc"
        Me.btn_buscar_hc.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar_hc.TabIndex = 25
        Me.btn_buscar_hc.Text = "Buscar"
        Me.btn_buscar_hc.UseVisualStyleBackColor = True
        '
        'txt__nro_hc_buscar
        '
        Me.txt__nro_hc_buscar.Location = New System.Drawing.Point(159, 61)
        Me.txt__nro_hc_buscar.Name = "txt__nro_hc_buscar"
        Me.txt__nro_hc_buscar.Size = New System.Drawing.Size(134, 20)
        Me.txt__nro_hc_buscar.TabIndex = 24
        '
        'lbl_nro_hc
        '
        Me.lbl_nro_hc.AutoSize = True
        Me.lbl_nro_hc.Location = New System.Drawing.Point(54, 64)
        Me.lbl_nro_hc.Name = "lbl_nro_hc"
        Me.lbl_nro_hc.Size = New System.Drawing.Size(96, 13)
        Me.lbl_nro_hc.TabIndex = 23
        Me.lbl_nro_hc.Text = "Nro Historia Clinica"
        '
        'lbl_sucursal_frente
        '
        Me.lbl_sucursal_frente.AutoSize = True
        Me.lbl_sucursal_frente.Location = New System.Drawing.Point(3, 8)
        Me.lbl_sucursal_frente.Name = "lbl_sucursal_frente"
        Me.lbl_sucursal_frente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_sucursal_frente.TabIndex = 22
        Me.lbl_sucursal_frente.Text = "Label6"
        '
        'txt_dueño
        '
        Me.txt_dueño.Location = New System.Drawing.Point(151, 284)
        Me.txt_dueño.Name = "txt_dueño"
        Me.txt_dueño.Size = New System.Drawing.Size(502, 20)
        Me.txt_dueño.TabIndex = 16
        '
        'msk_peso
        '
        Me.msk_peso.Location = New System.Drawing.Point(151, 197)
        Me.msk_peso.Mask = "99.99"
        Me.msk_peso.Name = "msk_peso"
        Me.msk_peso.Size = New System.Drawing.Size(41, 20)
        Me.msk_peso.TabIndex = 12
        '
        'frm_abm_historia_clinica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(867, 550)
        Me.Controls.Add(Me.pnl_buscar)
        Me.Controls.Add(Me.btn_buscar_historia_clinica)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_dueño)
        Me.Controls.Add(Me.dgv_dueños)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.msk_altura)
        Me.Controls.Add(Me.msk_peso)
        Me.Controls.Add(Me.lbl_altura)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.combo_raza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_fecha_nac)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_nro_historia_clinica)
        Me.Controls.Add(Me.txt_nro_historia_clinica)
        Me.Controls.Add(Me.lbl_sucursal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_abm_historia_clinica"
        Me.Text = "ABM Historia Clínica"
        CType(Me.dgv_dueños, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_buscar.ResumeLayout(False)
        Me.pnl_buscar.PerformLayout()
        CType(Me.GrillaHistoriaClinica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_sucursal As System.Windows.Forms.Label
    Friend WithEvents txt_nro_historia_clinica As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nro_historia_clinica As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha_nac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents combo_raza As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_altura As System.Windows.Forms.Label
    Friend WithEvents msk_altura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgv_dueños As System.Windows.Forms.DataGridView
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_nueva_historia_clinica As System.Windows.Forms.Button
    Friend WithEvents btn_buscar_historia_clinica As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents pnl_buscar As System.Windows.Forms.Panel
    Friend WithEvents GrillaHistoriaClinica As System.Windows.Forms.DataGridView
    Friend WithEvents btn_buscar_hc As System.Windows.Forms.Button
    Friend WithEvents txt__nro_hc_buscar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nro_hc As System.Windows.Forms.Label
    Friend WithEvents lbl_sucursal_frente As System.Windows.Forms.Label
    Friend WithEvents lblsucursal As System.Windows.Forms.Label
    Friend WithEvents txt_sucursal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_dueño As System.Windows.Forms.TextBox
    Friend WithEvents msk_peso As System.Windows.Forms.MaskedTextBox
End Class
