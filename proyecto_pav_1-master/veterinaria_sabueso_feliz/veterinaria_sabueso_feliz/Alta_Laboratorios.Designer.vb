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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alta_Laboratorios))
        Me.Lbl_Razon_Social = New System.Windows.Forms.Label()
        Me.txt_Razon_Social = New System.Windows.Forms.TextBox()
        Me.dgc_Laboratorios = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.dgc_Laboratorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Razon_Social
        '
        Me.Lbl_Razon_Social.AutoSize = True
        Me.Lbl_Razon_Social.Location = New System.Drawing.Point(46, 54)
        Me.Lbl_Razon_Social.Name = "Lbl_Razon_Social"
        Me.Lbl_Razon_Social.Size = New System.Drawing.Size(70, 13)
        Me.Lbl_Razon_Social.TabIndex = 0
        Me.Lbl_Razon_Social.Text = "Razon Social"
        '
        'txt_Razon_Social
        '
        Me.txt_Razon_Social.Location = New System.Drawing.Point(122, 51)
        Me.txt_Razon_Social.Name = "txt_Razon_Social"
        Me.txt_Razon_Social.Size = New System.Drawing.Size(146, 20)
        Me.txt_Razon_Social.TabIndex = 1
        '
        'dgc_Laboratorios
        '
        Me.dgc_Laboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgc_Laboratorios.Location = New System.Drawing.Point(0, 3)
        Me.dgc_Laboratorios.Name = "dgc_Laboratorios"
        Me.dgc_Laboratorios.Size = New System.Drawing.Size(704, 284)
        Me.dgc_Laboratorios.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgc_Laboratorios)
        Me.Panel1.Location = New System.Drawing.Point(12, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 284)
        Me.Panel1.TabIndex = 2
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
        'Alta_Laboratorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(753, 430)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_Razon_Social)
        Me.Controls.Add(Me.Lbl_Razon_Social)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "Alta_Laboratorios"
        Me.Text = "Laboriatorios"
        CType(Me.dgc_Laboratorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Razon_Social As System.Windows.Forms.Label
    Friend WithEvents txt_Razon_Social As System.Windows.Forms.TextBox
    Friend WithEvents dgc_Laboratorios As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
End Class
