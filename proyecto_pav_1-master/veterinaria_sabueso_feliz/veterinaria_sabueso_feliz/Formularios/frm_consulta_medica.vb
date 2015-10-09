Public Class frm_consulta_medica

    Private Sub frm_consulta_medica_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        nvo_cod_consulta()

        txt_sucursal.Text = sucursal

        dtp_fecha_entrada.MinDate = Today
        dtp_fecha_salida.MinDate = Today

        _cargar_combo(cmb_diagnostico, _leo_tabla("D.id_diagnostico,D.descripcion", "DIAGNOSTICOS D", "D.estado = 1"), "id_diagnostico", "descripcion")

        _cargar_combo(cmb_doctor, _leo_tabla("E.apellido + ' , ' + E.nombre as NOMBRE, E.nro_doc", "EMPLEADOS E", "E.estado = 1"), "nro_doc", "NOMBRE")

    End Sub

    Private Sub nvo_cod_consulta()

        txt_cod_consulta.Text = (valorId("CONSULTAS") + 1)

    End Sub

    Private Sub btn_buscar_hc_Click(sender As System.Object, e As System.EventArgs) Handles btn_buscar_hc.Click

        If Existe("PERROS", "nro_historia_clinica = " & msk_historia_clinica.Text.Trim & " and id_sucursal = " & sucursal & " and estado = 1") Then

            txt_nombre_perro.Text = _leo_tabla("PERROS", "nro_historia_clinica = " & msk_historia_clinica.Text).Rows(0)(2)

            txt_raza.Text = _leo_tabla("R.denominacion", "PERROS P, RAZAS R", "nro_historia_clinica = " & msk_historia_clinica.Text & _
                                       " and P.id_raza = R.id_raza and R.estado = 1").Rows(0)(0)

        End If

    End Sub

    Private Sub dtp_fecha_entrada_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtp_fecha_entrada.ValueChanged

        dtp_fecha_salida.MinDate = dtp_fecha_entrada.Value

    End Sub


    Private Sub btn_nuevo_Click(sender As System.Object, e As System.EventArgs) Handles btn_nuevo.Click

        limpiar()
        habilitar()

    End Sub

    Private Sub limpiar()

       txt_nombre_perro.Text = ""
        txt_raza.Text = ""
        msk_historia_clinica.Text = ""
        nvo_cod_consulta()
        dtp_fecha_entrada.Text = Today
        cmb_diagnostico.SelectedIndex = -1
        cmb_doctor.SelectedIndex = -1
        dgv_detalle.Rows.Clear()

    End Sub

    Private Sub habilitar()

        btn_buscar_hc.Enabled = True
        pnl_detalle.Enabled = True
        msk_historia_clinica.Enabled = True
        btn_guardar.Enabled = True

    End Sub

    Private Sub btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar.Click

        For i As Integer = 0 To dgv_detalle.Rows.Count - 1

            If dgv_detalle.Rows(i).Cells(0).Value = cmb_diagnostico.SelectedValue Then

                MessageBox.Show("Ya esta incluido ese diagnostico en el detalle")

                Exit Sub

            End If

        Next

        Dim dt As New Data.DataTable

        dt = _leo_tabla("E.tipo_doc", "EMPLEADOS E", "E.nro_doc = " & cmb_doctor.SelectedValue)

        dgv_detalle.Rows.Add(cmb_diagnostico.SelectedValue, cmb_diagnostico.Text, dtp_fecha_entrada.Text _
                             , dtp_fecha_salida.Text, dt.Rows(0)(0), cmb_doctor.SelectedValue, cmb_doctor.Text)

    End Sub

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click

    End Sub
End Class