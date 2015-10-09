<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class busqueda
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(busqueda))
        Me.lbl_etiqueta = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.combo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbl_etiqueta
        '
        Me.lbl_etiqueta.AutoSize = True
        Me.lbl_etiqueta.Location = New System.Drawing.Point(3, 11)
        Me.lbl_etiqueta.Name = "lbl_etiqueta"
        Me.lbl_etiqueta.Size = New System.Drawing.Size(39, 13)
        Me.lbl_etiqueta.TabIndex = 0
        Me.lbl_etiqueta.Text = "Label1"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(48, 8)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(302, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(356, 6)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(23, 23)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.Location = New System.Drawing.Point(381, 6)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(22, 23)
        Me.btn_nuevo.TabIndex = 3
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'combo
        '
        Me.combo.FormattingEnabled = True
        Me.combo.Location = New System.Drawing.Point(48, 7)
        Me.combo.Name = "combo"
        Me.combo.Size = New System.Drawing.Size(355, 21)
        Me.combo.TabIndex = 4
        Me.combo.Visible = False
        '
        'busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_etiqueta)
        Me.Controls.Add(Me.combo)
        Me.Name = "busqueda"
        Me.Size = New System.Drawing.Size(409, 38)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_etiqueta As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents combo As System.Windows.Forms.ComboBox

End Class
