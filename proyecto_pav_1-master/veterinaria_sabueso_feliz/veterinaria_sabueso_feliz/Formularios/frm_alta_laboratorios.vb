Public Class frm_alta_labortorios
    Dim tablaLab As Data.DataTable
    Dim modificar As Boolean
    Private Sub Alta_Laboratorios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_eliminar.Enabled = False
        tablaLab = modulo._leo_tabla("LABORATORIOS", "estado = 1")
        cargar_grilla(tablaLab)
        TTNuevo.SetToolTip(btn_nuevo, "Nuevo")
        TTEliminar.SetToolTip(btn_eliminar, "Eliminar Laboratorio Seleccionado")
        TTSalir.SetToolTip(btn_salir, "Salir")
    End Sub
    Private Sub cargar_grilla(ByVal tabla As Data.DataTable)
        dgc_Laboratorios.DataSource = tabla
        dgc_Laboratorios.Columns("id_laboratorio").Visible = False
        dgc_Laboratorios.Columns("estado").Visible = False
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        CambioAlta()
        Limpiar()
        modificar = False
        'Colocar numero de Identificacion
        'Asigno el valor con el incremento de una unidad
        txt_Id.Text = modulo.valorId("LABORATORIOS") + 1
    End Sub

    Function Validar() As Boolean
        If txt_RazonSocialNew.Text = "" Then
            TTRazonSoc.Show("Debe completar este campo", txt_RazonSocialNew, 600)
            Return False
        End If
        If Existe("LABORATORIOS", "razon_social = '" & txt_RazonSocialNew.Text & "'") Then
            If MsgBox("Ya existe un Laboratorio con esta Razon Social, ¿Desea Restaurar los datos?", MsgBoxStyle.OkCancel, "¡Atención!") = MsgBoxResult.Ok Then
                modulo._modificar("update LABORATORIOS set estado = 1 where razon_social = '" & txt_RazonSocialNew.Text & "'")
            End If
            Return False
        End If
        If txt_Direccion.Text = "" Then
            TTDirec.Show("Debe completar este campo", txt_Direccion, 600)
            Return False
        End If
        Return True
    End Function

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
    Private Sub Limpiar()
        txt_Id.Text = ""
        txt_RazonSocialNew.Text = ""
        txt_Direccion.Text = ""
        txt_Razon_Social.Text = ""
    End Sub

    Private Sub dgc_Laboratorios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgc_Laboratorios.CellClick
        btn_eliminar.Enabled = True
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        sql = "update LABORATORIOS set estado = 0 where id_laboratorio = " & dgc_Laboratorios.CurrentRow.Cells("id_laboratorio").Value

        If _eliminar(sql) Then

            MessageBox.Show("Laboratorio eliminado exitosmente", "Baja", MessageBoxButtons.OK)
            tablaLab = modulo._leo_tabla("LABORATORIOS", "estado = 1")
            cargar_grilla(tablaLab)

        Else

            MessageBox.Show("Error al dar de baja", "Baja", MessageBoxButtons.OK)

        End If

    End Sub

    
    Private Sub txt_Razon_Social_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Razon_Social.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.KeyChar = ""
        Else
            cargar_grilla(_leo_tabla("LABORATORIOS", "razon_social LIKE '%" & txt_Razon_Social.Text & "%' and estado = 1 "))
        End If

    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        'alvertencia
        'Limpar casilleros
        Limpiar()
        CambioGrilla()
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If modificar Then
            modulo._modificar("update LABORATORIOS set razon_social = '" & txt_RazonSocialNew.Text & "' , direccion = " & txt_Direccion.Text & " Where id_laboratorio = " & txt_Id.Text)
        ElseIf Validar() Then
            'INSERT [INTO] table_or_view [(column_list)] data_values
            modulo._insertar("INSERT INTO LABORATORIOS (id_laboratorio,razon_social,direccion,estado) VALUES (" & txt_Id.Text & ",'" & txt_RazonSocialNew.Text & "','" & txt_Direccion.Text & "',1)")
        End If
        Limpiar()
        CambioGrilla()
        cargar_grilla(modulo._leo_tabla("LABORATORIOS", "estado = 1"))
    End Sub

    Private Sub txt_RazonSocialNew_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RazonSocialNew.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub CambioGrilla()
        PanelGrilla.Visible = True
        panel_Alta.Visible = False
        btn_eliminar.Visible = True
        btn_guardar.Visible = False
        btn_Cancelar.Visible = False
    End Sub

    Private Sub CambioAlta()
        panel_Alta.Visible = True
        PanelGrilla.Visible = False
        btn_eliminar.Visible = False
        btn_guardar.Visible = True
        btn_Cancelar.Visible = True
    End Sub

    Private Sub dgc_Laboratorios_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgc_Laboratorios.CellMouseDoubleClick
        CambioAlta()
        txt_Id.Text = dgc_Laboratorios.CurrentRow.Cells(0).Value
        txt_RazonSocialNew.Text = dgc_Laboratorios.CurrentRow.Cells(1).Value
        txt_Direccion.Text = dgc_Laboratorios.CurrentRow.Cells(2).Value
    End Sub
End Class