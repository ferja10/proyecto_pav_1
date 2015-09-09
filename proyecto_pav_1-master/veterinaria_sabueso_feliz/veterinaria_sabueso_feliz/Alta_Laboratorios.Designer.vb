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
        Me.Lbl_Razon_Social = New System.Windows.Forms.Label()
        Me.txt_Razon_Social = New System.Windows.Forms.TextBox()
        Me.dgc_Laboratorios = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.dgc_Laboratorios.Location = New System.Drawing.Point(-3, 3)
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
        'Alta_Laboratorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(753, 430)
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
End Class
