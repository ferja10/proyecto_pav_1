Public Class frm_alta_Vacunas
    Dim tablaVac As Data.DataTable
    Dim modifica As Boolean = False
    Private Sub Alta_Vacunas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_eliminar.Enabled = False
        CambioGrilla()
        Limpiar()
        tablaVac = modulo._leo_tabla("id_vacuna,descripcion AS Descripcion, estado", "VACUNAS", "estado = 1")
        cargar_grilla(tablaVac)
    End Sub
    Private Sub cargar_grilla(ByVal tabla As Data.DataTable)
        dgc_Vacunas.DataSource = tabla
        dgc_Vacunas.Columns("id_vacuna").Visible = False
        dgc_Vacunas.Columns("estado").Visible = False
    End Sub
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
    Private Sub Limpiar()
        txt_Descripcion.Text = ""
        txt_DescripcionNueva.Text = ""
        txt_Id.Text = ""
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sql = "update VACUNAS set estado = 0 where id_vacuna = " & dgc_Vacunas.CurrentRow.Cells("id_vacuna").Value

        If _eliminar(sql) Then

            MessageBox.Show("Vacuna eliminada exitosmente", "Baja", MessageBoxButtons.OK)
            tablaVac = modulo._leo_tabla("id_vacuna,descripcion AS Descripcion, estado", "VACUNAS", "estado = 1")
            cargar_grilla(tablaVac)

        Else

            MessageBox.Show("Error al dar de baja", "Baja", MessageBoxButtons.OK)

        End If
        btn_eliminar.Enabled = False
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If Validar() Then
            'INSERT [INTO] table_or_view [(column_list)] data_values
            modulo._insertar("INSERT INTO VACUNAS (id_vacuna,descripcion,estado) VALUES (" & txt_Id.Text & ",'" & txt_DescripcionNueva.Text & "',1)")
        End If
        Limpiar()
        tablaVac = modulo._leo_tabla("id_vacuna,descripcion AS Descripcion, estado", "VACUNAS", "estado = 1")
        cargar_grilla(tablaVac)
        CambioGrilla()
    End Sub

    Private Function Validar() As Boolean
        If txt_Descripcion.Text = "" Then
            MsgBox("Debe completar este campo")
            Return False
        End If
        If Existe("VACUNAS", "descripcion = '" & txt_Descripcion.Text & "'") Then
            MsgBox("La vacuna ya existe")
            Return False
        End If
        Return True
    End Function

    Private Sub txt_Descripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Descripcion.KeyPress
        btn_eliminar.Enabled = False
        If Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub


    Private Sub dgc_Vacunas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgc_Vacunas.CellClick
        If e.RowIndex >= 0 Then
            btn_eliminar.Enabled = True
        Else
            btn_eliminar.Enabled = False
        End If
    End Sub

    Private Sub dgc_Vacunas_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgc_Vacunas.CellDoubleClick

        If e.RowIndex >= 0 Then
            txt_Descripcion.Text = dgc_Vacunas.CurrentRow.Cells("descripcion").Value
        End If

    End Sub

    Private Sub txt_Descripcion_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Descripcion.KeyUp
        cargar_grilla(modulo._leo_tabla("id_vacuna,descripcion AS Descripcion, estado", "VACUNAS", "descripcion LIKE '%" & txt_Descripcion.Text & "%' AND estado = 1"))
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

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        CambioAlta()
        Limpiar()
        modifica = False
        txt_id.Text = modulo.valorId("VACUNAS", "id_vacuna")
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Limpiar()
        CambioGrilla()
        cargar_grilla(modulo._leo_tabla("id_vacuna, descripcion AS Descripción, estado", "VACUNAS", "estado = 1"))
    End Sub

    Private Sub txt_DescripcionNueva_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DescripcionNueva.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub
End Class