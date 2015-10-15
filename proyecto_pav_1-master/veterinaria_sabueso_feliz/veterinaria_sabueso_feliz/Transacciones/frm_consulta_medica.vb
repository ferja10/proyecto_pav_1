﻿Public Class frm_consulta_medica

    Private Sub frm_consulta_medica_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        nvo_cod_consulta()

        txt_sucursal.Text = sucursal

        spc_detalles.Enabled = False

        _cargar_combo(cmb_diagnostico, _leo_tabla("D.id_diagnostico,D.descripcion", "DIAGNOSTICOS D", "D.estado = 1"), "id_diagnostico", "descripcion")

        _cargar_combo(cmb_doctor, _leo_tabla("E.apellido + ' , ' + E.nombre as NOMBRE, E.nro_doc", "EMPLEADOS E", "E.estado = 1"), "nro_doc", "NOMBRE")

        _cargar_grilla(dgv_ListaMedicamento, _leo_tabla("id_medicamento as ID, descripcion as NOMBRE", "MEDICAMENTOS", "estado = 1"))

        _cargar_combo(cmb_diagnostico, _leo_tabla("DIAGNOSTICOS"), "id_diagnostico", "descripcion")

    End Sub

    Private Sub nvo_cod_consulta()

        txt_cod_consulta.Text = (valorId("CONSULTAS", "id_consulta", " GROUP BY id_sucursal, id_consulta HAVING id_sucursal = " & sucursal))

    End Sub

    Private Sub btn_buscar_hc_Click(sender As System.Object, e As System.EventArgs) Handles btn_buscar_hc.Click

        If msk_historia_clinica.Text = "" Then
            MsgBox("Debe colocar un numero de historia clinica")
        ElseIf Existe("PERROS", "nro_historia_clinica = " & msk_historia_clinica.Text.Trim & " and id_sucursal = " & sucursal & " and estado = 1") Then

            txt_nombre_perro.Text = _leo_tabla("PERROS", "nro_historia_clinica = " & msk_historia_clinica.Text).Rows(0)(2)

            txt_raza.Text = _leo_tabla("R.denominacion", "PERROS P, RAZAS R", "nro_historia_clinica = " & msk_historia_clinica.Text & _
                                       " and P.id_raza = R.id_raza and R.estado = 1").Rows(0)(0)

        Else

            MessageBox.Show("No existe ese paciente en la base de datos")

        End If

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
        cmb_diagnostico.SelectedIndex = -1
        cmb_doctor.SelectedIndex = -1
        dgv_detalle.Rows.Clear()
        dgv_MedicamentoSeleccionado.Rows.Clear()

    End Sub

    Private Sub habilitar()

        btn_buscar_hc.Enabled = True
        spc_detalles.Enabled = True
        msk_historia_clinica.Enabled = True
        btn_guardar.Enabled = True

    End Sub

    Private Sub btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar_diagnostico.Click

        For i As Integer = 0 To dgv_detalle.Rows.Count - 1

            If dgv_detalle.Rows(i).Cells(0).Value = cmb_sintoma.SelectedValue Then

                MessageBox.Show("Ya esta incluido ese Síntoma en el detalle")

                Exit Sub

            End If

        Next

        dgv_detalle.Rows.Add(cmb_sintoma.SelectedValue, cmb_sintoma.Text)

    End Sub

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click

        If validar() Then

            guardar()

        Else

            MessageBox.Show("Faltan datos por cargar")

        End If


    End Sub

    Private Function validar() As Boolean

        Return True

    End Function

    Private Function guardar() As Boolean

        For i As Integer = 0 To dgv_detalle.Rows.Count - 1


            
        Next

        Return True

    End Function

    
    Private Sub cmb_diagnostico_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmb_diagnostico.SelectionChangeCommitted

        If Not cmb_diagnostico.SelectedValue = -1 Then

            _cargar_combo(cmb_sintoma, _leo_tabla("S.id_sintoma,S.descripcion", "SINTOMAS S, DIAGNOSTICOxSINTOMA DxS", _
                                                 " S.estado = 1 and S.id_sintoma = DxS.id_sintoma and DxS.id_diagnostico = " & cmb_diagnostico.SelectedValue), _
                                             "id_sintoma", "descripcion")

        End If

    End Sub

    Private Sub btn_quitar_diagnostico_Click(sender As System.Object, e As System.EventArgs) Handles btn_quitar_diagnostico.Click

        dgv_detalle.Rows.Remove(dgv_detalle.CurrentRow)

    End Sub

    Private Sub btn_agregarMedicamento_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregarMedicamento.Click

        For i As Integer = 0 To dgv_detalle.Rows.Count - 1

            If dgv_MedicamentoSeleccionado.Rows(i).Cells(0).Value = dgv_ListaMedicamento.CurrentRow.Cells(0).Value Then

                MessageBox.Show("Ya esta recetado el medicamento")

                Exit Sub

            End If

        Next

        dgv_MedicamentoSeleccionado.Rows.Add(dgv_ListaMedicamento.CurrentRow.Cells(0).Value, dgv_ListaMedicamento.CurrentRow.Cells(1).Value)

    End Sub

    Private Sub btn_quitar_medicamento_Click(sender As System.Object, e As System.EventArgs) Handles btn_quitar_medicamento.Click

        dgv_MedicamentoSeleccionado.Rows.Remove(dgv_MedicamentoSeleccionado.CurrentRow)

    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim tablaConsulta As New Data.DataTable
        Dim tablaPerro As New Data.DataTable
        Dim tablaRaza As New Data.DataTable
        Dim tablaDxC As New Data.DataTable
        Dim tablaDiagnostico As New Data.DataTable
        Dim tabladetalleSintoma As New Data.DataTable
        Dim tabladetalleMedicamento As New Data.DataTable

        tablaConsulta.Load(modulo._leo_tabla("CONSULTA", "id_consulta = " & txt_cod_consulta.Text & " AND id_sucursal = " & txt_sucursal.Text))
        tablaPerro.Load(modulo._leo_tabla("nombre", "PERROS", "nro_historia_clinica = " & msk_historia_clinica.Text & "id_sucursal = " & txt_sucursal.Text))
        tablaRaza.Load(modulo._leo_tabla("denominacion", "RAZAS", "id_raza = " & tablaPerro.Rows(0)("id_raza").ToString))
        tablaDxC.Load(modulo._leo_tabla("id_diagnostico", "DIAGNOSTICOxCONSULTA", "id_sucursal = " & txt_sucursal.Text & " AND id_consulta = " & txt_cod_consulta.Text))
        tablaDiagnostico.Load(modulo._leo_tabla("id_diagnostico", "DIAGNOSTICO", "id_diagnostico = " & tablaDxC.Rows(0)("id_diagnostico").ToString))
        tabladetalleMedicamento.Load(modulo._leo_tabla("M.descripcion", " MEDICAMENTOS M INNER JOIN MEDICAMENTOxCONSULTA MC", "M.id_medicamento = MC.id_medicamento AND MC.id_consulta = " & txt_cod_consulta.Text & ", MC.nro_historia_clinica = " & msk_historia_clinica.Text & ", MC.id_sucursal = " & sucursal))

        tabladetalleSintoma.Load(modulo._leo_tabla("S.descripcion", "SINTOMAS S INNER JOIN SINTOMAxCONSULTA SC", "S.id_sintoma = SC.id_sintoma AND SC.id_consulta = " & txt_cod_consulta.Text & ", SC.nro_historia_clinica = " & msk_historia_clinica.Text & ", SC.id_sucursal = " & sucursal))

        dgv_detalle.DataSource = tabladetalleSintoma
        dgv_MedicamentoSeleccionado.DataSource = tabladetalleMedicamento




        msk_historia_clinica.Text = tablaConsulta.Rows(0)("nro_historia_clinica").ToString
        txt_nombre_perro.Text = tablaPerro.Rows(0)("nombre").ToString
        txt_raza.Text = tablaRaza.Rows(0)("denominacion").ToString
        cmb_diagnostico.SelectedValue = tablaDiagnostico.Rows(0)("id_diagnostico")

    End Sub
End Class