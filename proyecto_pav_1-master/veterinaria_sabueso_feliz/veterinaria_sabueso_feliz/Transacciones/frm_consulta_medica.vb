Public Class frm_consulta_medica

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

        If Existe("PERROS", "nro_historia_clinica = " & msk_historia_clinica.Text.Trim & " and id_sucursal = " & sucursal & " and estado = 1") Then

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

            Try

                abrir_transaccion()

                guardar()

                cerrar_transaccion()
            Catch ex As Exception

                cancelar_transaccion()

            End Try

        Else

            MessageBox.Show("Faltan datos por cargar")

        End If

    End Sub

    Private Function validar() As Boolean

        If cmb_doctor.SelectedValue = -1 Then
            cmb_doctor.Focus()
            Return False

        ElseIf msk_historia_clinica.Text = "" Then
            msk_historia_clinica.Focus()
            Return False
        ElseIf txt_nombre_perro.Text = "" Then
            txt_nombre_perro.Focus()
            Return False
        ElseIf txt_raza.Text = "" Then
            txt_raza.Focus()
            Return False
        ElseIf dgv_detalle.Rows.Count = 0 Then
            cmb_diagnostico.Focus()
            Return False
        ElseIf dgv_MedicamentoSeleccionado.Rows.Count = 0 Then

            If MessageBox.Show("No recetará ningún medicamento?", "Importante", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then

                txt_Medicamento.Focus()
                Return False

            End If

        End If

        Return True

    End Function

    Private Function guardar() As Boolean

        Dim tipo_doc As Integer = _leo_tabla("E.tipo_doc", "EMPLEADOS E", "nro_doc = " & cmb_doctor.SelectedValue).Rows(0)(0)

        sql = "insert into CONSULTAS (nro_historia_clinica,id_sucursal,id_consulta,fecha_entrada,fecha_salida,tipo_doc_empl,nro_doc_empl) " _
                & "values(" & msk_historia_clinica.Text & "," & sucursal & "," & txt_cod_consulta.Text & ",'" & DateTimePicker1.Text & "',null," & tipo_doc & "," & cmb_doctor.SelectedValue & ")"

        _insertar(sql)


        sql = "insert into DIAGNOSTICOxCONSULTA (nro_historia_clinica,id_consulta,id_sucursal,id_diagnostico) " _
            & "values (" & msk_historia_clinica.Text & "," & txt_cod_consulta.Text & "," & sucursal & "," & cmb_diagnostico.SelectedValue & ")"

        _insertar(sql)

        For i As Integer = 0 To dgv_detalle.Rows.Count - 1

            sql = "insert into SINTOMAxCONSULTA (nro_historia_clinica,id_sucursal,id_consulta,id_sintoma) " _
                & "values(" & msk_historia_clinica.Text & "," & sucursal & "," & txt_cod_consulta.Text & "," & dgv_detalle.Rows(i).Cells(0).Value & ")"

            _insertar(sql)

        Next

        For i As Integer = 0 To dgv_MedicamentoSeleccionado.Rows.Count - 1

            sql = "insert into MEDICAMENTOxCONSULTA (nro_historia_clinica,id_sucursal,id_consulta,id_medicamento,dosis,periodicidad) " _
                & "values (" & msk_historia_clinica.Text & "," & sucursal & "," & txt_cod_consulta.Text & "," & dgv_MedicamentoSeleccionado.Rows(i).Cells(0).Value & ",'" & dgv_MedicamentoSeleccionado.Rows(i).Cells(2).Value & "','" & dgv_MedicamentoSeleccionado.Rows(i).Cells(3).Value & "')"

            _insertar(sql)

        Next

        Return True

    End Function

    
    Private Sub cmb_diagnostico_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmb_diagnostico.SelectionChangeCommitted

        If Not cmb_diagnostico.SelectedValue = -1 Then

            _cargar_combo(cmb_sintoma, _leo_tabla("S.id_sintoma,S.descripcion", "SINTOMAS S, DIAGNOSTICOxSINTOMA DxS", _
                                                 " estado = 1 and S.id_sintoma = DxS.id_sintoma and DxS.id_diagnostico = " & cmb_diagnostico.SelectedValue), _
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

    Private Sub btn_buscar_Click(sender As System.Object, e As System.EventArgs) Handles btn_buscar.Click

        frm_busqueda_consulta.ShowDialog()

    End Sub
End Class