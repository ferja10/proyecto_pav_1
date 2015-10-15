Public Class frm_alta_medicamentos
    Dim tablaMed As Data.DataTable
    Dim modificar As Boolean = False
    Private Sub Alta_Medicamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_sucursal.Text += sucursal.ToString
        CambioGrilla()
        Limpiar()
        txt_Fecha.MaxDate = Today
        btn_eliminar.Enabled = False
        tablaMed = modulo._leo_tabla("id_medicamento,descripcion As Descripcion,id_laboratorio,fecha_ultima_compra AS 'Fecha de Ultima Compra',estado", "MEDICAMENTOS", "estado = 1")
        cargar_grilla(tablaMed)
        TTNuevo.SetToolTip(btn_nuevo, "Nuevo")
        TTEliminar.SetToolTip(btn_eliminar, "Eliminar Medicamento Seleccionado")
        TTSalir.SetToolTip(btn_salir, "Salir")
        modulo._cargar_combo(cmb_Laboratorio, modulo._leo_tabla("LABORATORIOS", "estado = 1"), "id_laboratorio", "razon_social")
    End Sub
    Private Sub cargar_grilla(ByVal tabla As Data.DataTable)
        dgc_Medicamentos.DataSource = tabla
        dgc_Medicamentos.Columns("id_medicamento").Visible = False
        dgc_Medicamentos.Columns("id_laboratorio").Visible = False
        dgc_Medicamentos.Columns("estado").Visible = False
        'Agregar el nombre del laboratorio
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        CambioAlta()
        Limpiar()
        modificar = False
        txt_Fecha.Text = Today
        'Colocar numero de Identificacion
        'Asigno el valor con el incremento de una unidad
        txt_Id.Text = modulo.valorId("MEDICAMENTOS", "id_medicamento")
    End Sub


    Function Validar() As Boolean
        'Caja de Texto descipcion

        If txt_Descripcion.Text = "" Then
            TTDesc.Show("Debe completar este campo", txt_Descripcion, 600)
            Return False
        End If
        If Existe("MEDICAMENTOS", "descripcion = '" & txt_Descripcion.Text & "'") Then
            If MessageBox.Show("Esta Descripcion ya existe, ¿Desea Recuperarlo?", "Dar de Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                modulo._modificar("update MEDICAMENTOS set estado = 1 where descripcion ='" & txt_Descripcion.Text & "'")
            End If
            Return False
        End If
        Return True
    End Function

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
    Private Sub Limpiar()
        txt_Id.Text = ""
        txt_Descripcion.Text = ""
        txt_Medicamentos.Text = ""
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        sql = "update MEDICAMENTOS set estado = 0 where id_medicamento = " & dgc_Medicamentos.CurrentRow.Cells("id_medicamento").Value

        If _eliminar(sql) Then

            MessageBox.Show("Medicamento eliminado exitosmente", "Baja", MessageBoxButtons.OK)
            cargar_grilla(modulo._leo_tabla("id_medicamento,descripcion As Descripcion,id_laboratorio,fecha_ultima_compra AS 'Fecha de Ultima Compra',estado", "MEDICAMENTOS", "estado = 1"))

        Else

            MessageBox.Show("Error al dar de baja", "Baja", MessageBoxButtons.OK)

        End If
        btn_eliminar.Enabled = False
    End Sub

    Private Sub dgc_Medicamentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgc_Medicamentos.CellClick
        If e.RowIndex >= 0 Then
            btn_eliminar.Enabled = True
        Else
            btn_eliminar.Enabled = False
        End If
    End Sub

    Private Sub txt_Medicamentos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Medicamentos.KeyPress
        btn_eliminar.Enabled = False
        If Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        'alvertencia
        'Limpar casilleros
        Limpiar()
        CambioGrilla()
        cargar_grilla(modulo._leo_tabla("id_medicamento,descripcion As Descripcion,id_laboratorio,fecha_ultima_compra AS 'Fecha de Ultima Compra',estado", "MEDICAMENTOS", "estado = 1"))
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If modificar Then
            modulo._modificar("update MEDICAMENTOS set descripcion = '" & txt_Descripcion.Text & "' , id_laboratorio = " & cmb_Laboratorio.SelectedValue & ", fecha_ultima_compra = '" & txt_Fecha.Text & "' Where id_medicamento = " & txt_Id.Text)
            modulo._modificar("UPDATE MEDICAMENTOxSUCURSAL SET cantidad_existente = " & txt_Cantidad_existente.Text & ", cantidad_minima = " & txt_CantidadMinima.Text & " WHERE id_medicamento = " & txt_Id.Text & " AND id_sucursal =" & sucursal)
        ElseIf Validar() Then
            'INSERT [INTO] table_or_view [(column_list)] data_values
            modulo._insertar("INSERT INTO MEDICAMENTOS (id_medicamento,descripcion,id_laboratorio,fecha_ultima_compra,estado) VALUES (" & txt_Id.Text & ",'" & txt_Descripcion.Text & "'," & cmb_Laboratorio.SelectedValue & ",'" & txt_Fecha.Text & "',1)")
            modulo._insertar("INSERT INTO MEDICAMENTOxSUCURSAL (id_medicamento,id_sucursal,cantidad_existente,cantidad_minima) VALUES (" & txt_Id.Text & "," & sucursal & "," & txt_Cantidad_existente.Text & "," & txt_CantidadMinima.Text & ")")
        Else
            Exit Sub
        End If
        'Cambio de contexto
        'Limpar casilleros
        Limpiar()
        CambioGrilla()
        cargar_grilla(modulo._leo_tabla("id_medicamento,descripcion As Descripcion,id_laboratorio,fecha_ultima_compra AS 'Fecha de Ultima Compra',estado", "MEDICAMENTOS", "estado = 1"))
    End Sub

    Private Sub dgc_Medicamentos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgc_Medicamentos.CellDoubleClick
        CambioAlta()
        txt_Id.Text = dgc_Medicamentos.CurrentRow.Cells(0).Value
        txt_Descripcion.Text = dgc_Medicamentos.CurrentRow.Cells(1).Value
        cmb_Laboratorio.SelectedValue = dgc_Medicamentos.CurrentRow.Cells(2).Value
        txt_Fecha.Text = dgc_Medicamentos.CurrentRow.Cells(3).Value
        modificar = True
    End Sub

    Private Sub CambioAlta()
        panel_Alta.Visible = True
        PanelGrilla.Visible = False
        btn_eliminar.Visible = False
        btn_guardar.Visible = True
        btn_Cancelar.Visible = True
    End Sub

    Private Sub CambioGrilla()
        PanelGrilla.Visible = True
        panel_Alta.Visible = False
        btn_eliminar.Visible = True
        btn_guardar.Visible = False
        btn_Cancelar.Visible = False
    End Sub

    Private Sub txt_Medicamentos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Medicamentos.KeyUp
        cargar_grilla(modulo._leo_tabla("id_medicamento,descripcion As Descripcion,id_laboratorio,fecha_ultima_compra AS 'Fecha de Ultima Compra',estado", "MEDICAMENTOS", "descripcion LIKE '%" & txt_Medicamentos.Text & "%' AND estado = 1"))
    End Sub

    Private Sub txt_Cantidad_existente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad_existente.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = ""
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txt_CantidadMinima_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CantidadMinima.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = ""
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub
End Class