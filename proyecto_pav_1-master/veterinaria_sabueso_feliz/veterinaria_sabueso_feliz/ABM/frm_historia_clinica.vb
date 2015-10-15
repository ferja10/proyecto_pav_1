Public Class frm_abm_historia_clinica
    Dim tablaPerros As New Data.DataTable
    Dim modificar As Boolean = False
    Private Sub frm_abm_historia_clinica_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        dtp_fecha_nac.MaxDate() = Today
        modulo.mostrar_sucursal(lbl_sucursal)
        txt_nro_historia_clinica.Text = (modulo.valorId("PERROS", "nro_historia_clinica"))
        _cargar_grilla(dgv_dueños, _leo_tabla("DUEÑOS"))
        dgv_dueños.Columns(0).Visible = False
        modulo._cargar_combo(combo_raza, modulo._leo_tabla("RAZAS"), "id_raza", "denominacion")


    End Sub

    Private Sub cargar_grilla(ByVal Table As DataTable)
        GrillaHistoriaClinica.DataSource = Table
        GrillaHistoriaClinica.Columns("id_raza").Visible = False
        GrillaHistoriaClinica.Columns("estado").Visible = False
    End Sub

    Private Sub limpiar()
        txt__nro_hc_buscar.Text = ""
        txt_dueño.Text = ""
        txt_nombre.Text = ""
        txt_nro_historia_clinica.Text = ""
        msk_altura.Text = ""
        msk_peso.Text = ""

    End Sub

    Private Function validar()
        If txt_nombre.Text = "" Then
            MsgBox("El nombre esta incompleto", MsgBoxStyle.OkOnly, "Importante")
            Return False
        ElseIf msk_altura.Text = "" Then
            MsgBox("Complete la altura", MsgBoxStyle.OkOnly, "Importante")
            Return False
        ElseIf msk_peso.Text = "" Then
            MsgBox("Complete el peso", MsgBoxStyle.OkOnly, "Importante")
            Return False
        End If
        Return True
    End Function

    Private Sub btn_nueva_historia_clinica_Click(sender As System.Object, e As System.EventArgs) Handles btn_nueva_historia_clinica.Click
        Me.pnl_buscar.Visible = False
        Me.limpiar()
        modificar = False
    End Sub

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        If modificar = True Then
            modulo._modificar("update PERROS set nro_historia_clinica = " & txt_nro_historia_clinica.Text & ", id_sucursal = " & txt_sucursal.Text & ", nombre = '" & txt_nombre.Text & "' , fecha_nacimiento = '" & dtp_fecha_nac.Value & "' , id_raza = " & combo_raza.SelectedValue & "peso = " & msk_altura.Text & ", altura = " & msk_altura.Text & ", id_dueño = " & dgv_dueños.CurrentRow.Cells("id_dueño").Value & " , estado = 1)")
        ElseIf Validar() Then
            'INSERT [INTO] table_or_view [(column_list)] data_values
            modulo._insertar("insert into PERROS (nro_historia_clinica, id_sucursal, nombre, fecha_nacimiento, id_raza, peso, altura, id_dueño, estado) VALUES (" & txt_nro_historia_clinica.Text & ", " & txt_sucursal.Text & ", '" & txt_nombre.Text & "' , '" & dtp_fecha_nac.Value & "' , " & combo_raza.SelectedValue & ", " & msk_peso.Text & ", " & msk_altura.Text & ", " & dgv_dueños.CurrentRow.Cells(0).Value & ", 1)")
        End If
        'Cambio de contexto
        'Limpar casilleros
        limpiar()
        tablaPerros = modulo._leo_tabla("PERROS", "estado = 1")
        cargar_grilla(tablaPerros)
    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click
        sql = "update PERROS set estado = 0 where nro_historia_clinica = " & GrillaHistoriaClinica.CurrentRow.Cells("nro_historia_clinica").Value

        If _eliminar(sql) Then

            MessageBox.Show("Historia Clinica eliminada exitosmente", "Baja", MessageBoxButtons.OK)
            tablaPerros = modulo._leo_tabla("PERROS", "estado = 1")
            cargar_grilla(tablaPerros)

        Else

            MessageBox.Show("Error al dar de baja", "Baja", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As System.Object, e As System.EventArgs) Handles btn_nuevo.Click
        frm_alta_dueño.ShowDialog()
    End Sub

    Private Sub dgv_dueños_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_dueños.CellContentClick
        txt_dueño.Text = dgv_dueños.CurrentRow.Cells("nombre").Value & " " & dgv_dueños.CurrentRow.Cells("apellido").Value
    End Sub

    Private Sub btn_buscar_Click(sender As System.Object, e As System.EventArgs)
        Dim tablaDueños As New Data.DataTable
        tablaDueños.Load(_leo_tabla("DUEÑOS", "nombre = " & txt_dueño.Text & " AND estado = 1"))
        dgv_dueños.DataSource = tablaDueños



    End Sub

    Private Sub GrillaHistoriaClinica_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaHistoriaClinica.CellContentClick

    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        limpiar()
        pnl_buscar.Visible = True
    End Sub

    Private Sub btn_buscar_hc_Click(sender As System.Object, e As System.EventArgs) Handles btn_buscar_hc.Click
        If txt__nro_hc_buscar.Text = "" Then
            MsgBox("Complete el numero a buscar", MsgBoxStyle.OkOnly, "Importante")
        Else
            tablaPerros.Load(_leo_tabla("PERROS", "nro_historia_clinica = " & txt__nro_hc_buscar.Text & " AND estado = 1"))
            cargar_grilla(tablaPerros)
        End If

    End Sub
End Class