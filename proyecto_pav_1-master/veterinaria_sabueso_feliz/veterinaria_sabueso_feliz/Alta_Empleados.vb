Public Class frm_alta_empleados

    Dim flag, modificar As Boolean

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click

        pnl_buscar.Visible = False
        limpiar()
        habilitar()
        txt_nombre.Focus()
        modificar = False
        mostrar_sucursal(lbl_sucursal)

    End Sub

    Private Sub limpiar()

        txt_nombre.Text = ""
        txt_apellido.Text = ""
        cmb_tipo_documento.SelectedIndex = -1
        msk_documento.Text = ""
        dtp_fecha_ingreso.Text = Date.Today
        dtp_fecha_ingreso.MaxDate = Date.Today
        dtp_fecha_nac.Text = Convert.ToDateTime(Date.Today.Day & "/" & Date.Today.Month & "/" & (Date.Today.Year - 18))
        dtp_fecha_nac.MaxDate = Convert.ToDateTime(Date.Today.Day & "/" & Date.Today.Month & "/" & (Date.Today.Year - 18))
        rdo_si.Checked = False
        rdo_no.Checked = True
        msk_matricula.Text = ""

    End Sub

    Private Sub habilitar()
        pnl_datos_personales.Enabled = True
        btn_buscar.Enabled = True
        btn_guardar.Enabled = True
        btn_cancelar.Enabled = True
        msk_documento.Enabled = True
    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txt_apellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apellido.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub rdo_si_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_si.Click
        msk_matricula.Enabled = True
    End Sub


    Private Sub rdo_no_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_no.Click
        msk_matricula.Enabled = False
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click

        Close()

    End Sub


    Private Sub frm_alta_empleados_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If MessageBox.Show("Podría perder información no guardada" & Chr(13) & "            ¿Está seguro que desea salir?", "Importante", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub frm_alta_empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        pnl_buscar.Visible = True

        modificar = False

        mostrar_sucursal(lbl_nombre_sucursal)

        cargar_grilla(_leo_tabla("E.apellido as APELLIDO, E.nombre as NOMBRE, E.nro_doc as DOCUMENTO,E.fecha_nacimiento as NACIMIENTO, E.fecha_ingreso as INGRESO,E.matricula as MATRICULA, E.tipo_doc as 'TIPO DOCUMENTO'", _
                                "EMPLEADOS E join SUCURSALES S on E.sucursal = S.id_sucursal", "estado = 1 and E.sucursal = " & sucursal))

        carga_combo(cmb_tipo_documento, _leo_tabla("TIPO_DOCUMENTO"), "id_tipo_doc", "descripcion")

        txt_apellido_filtro.Focus()

    End Sub

  
    Private Sub carga_combo(ByVal combo As ComboBox, ByVal tabla As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click

        If modificar Then

            If validar() Then

                modificar_empleado()

            Else

                MessageBox.Show("Faltan datos", "Importante")

            End If

        Else

            If validar() Then

                If validar_existensia() Then

                    guardar_empleado()

                Else

                    MessageBox.Show("Ya existe esa persona en la base de datos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If

            Else

                MessageBox.Show("Faltan datos", "Importante")

            End If

        End If

    End Sub

    Private Function validar() As Boolean

        If txt_nombre.Text = "" Then
            txt_nombre.Focus()
            Return False
        ElseIf txt_apellido.Text = "" Then
            txt_apellido.Focus()
            Return False
        ElseIf cmb_tipo_documento.SelectedIndex = -1 Then
            cmb_tipo_documento.Focus()
            Return False
        ElseIf msk_documento.Text = "" Then
            msk_documento.Focus()
            Return False
        ElseIf rdo_si.Checked Then
            If msk_matricula.Text = "" Then
                msk_matricula.Focus()
                Return False
            End If
        End If
        Return True

    End Function

    Private Function validar_existensia() As Boolean

        If _leo_tabla("EMPLEADOS E join SUCURSALES S on E.sucursal = S.id_sucursal", _
                     "tipo_doc = " & cmb_tipo_documento.SelectedValue & " and " & "nro_doc = " & msk_documento.Text.Trim & " and estado = 1 and E.sucursal = " & sucursal).Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If

    End Function


    Private Sub guardar_empleado()

        If Not rdo_si.Checked Then

            sql = "insert into EMPLEADOS (tipo_doc,nro_doc,nombre,apellido,fecha_nacimiento,fecha_ingreso,sucursal,estado)" & _
              " values (" & cmb_tipo_documento.SelectedValue & "," & msk_documento.Text.Trim & ",'" & txt_nombre.Text & "'," & _
              "'" & txt_apellido.Text & "','" & dtp_fecha_nac.Value & "','" & dtp_fecha_ingreso.Value & "'," & sucursal & ",1) "
        Else

            sql = "insert into EMPLEADOS (tipo_doc,nro_doc,nombre,apellido,fecha_nacimiento,fecha_ingreso,matricula,sucursal,estado)" & _
              " values (" & cmb_tipo_documento.SelectedValue & "," & msk_documento.Text.Trim & ",'" & txt_nombre.Text & "'," & _
              "'" & txt_apellido.Text & "','" & dtp_fecha_nac.Value & "','" & dtp_fecha_ingreso.Value & "'," & msk_matricula.Text & _
              "," & sucursal & ",1) "

        End If

        If _insertar(sql) Then

            MessageBox.Show("Empleado cargado con exito", "Carga datos")

        Else

            If MessageBox.Show("La persona fue dada de baja" & Chr(13) & "Desea volver a restaurar sus datos?", _
                               "Importante", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                If restaurar_datos(msk_documento, cmb_tipo_documento) Then

                    MessageBox.Show("Se han recuperado los datos correctamente", "Alta empleados", MessageBoxButtons.OK)

                    pnl_buscar.Visible = True

                    cargar_grilla(_leo_tabla("E.apellido as APELLIDO, E.nombre as NOMBRE, E.nro_doc as DOCUMENTO,E.fecha_nacimiento as NACIMIENTO, E.fecha_ingreso as INGRESO,E.matricula as MATRICULA, E.tipo_doc as 'TIPO DOCUMENTO'", _
                                "EMPLEADOS E join SUCURSALES S on E.sucursal = S.id_sucursal", "estado = 1 and E.sucursal = " & sucursal))

                Else

                    MessageBox.Show("Error al intentar recuperar los datos", "Alta empleados", MessageBoxButtons.OK)

                End If

            End If

        End If

    End Sub

    Private Function restaurar_datos(ByVal nro_doc As MaskedTextBox, ByVal tipo_doc As ComboBox) As Boolean

        sql = "update EMPLEADOS set estado = 1 where tipo_doc = " & tipo_doc.SelectedValue & "and nro_doc = " & nro_doc.Text

        If _modificar(sql) Then

            Return True

        Else

            Return False

        End If

    End Function


    Private Sub modificar_empleado()

        If Not rdo_si.Checked Then

            sql = "update EMPLEADOS " & _
              " set tipo_doc = " & cmb_tipo_documento.SelectedValue & ", nro_doc = " & msk_documento.Text.Trim & ",nombre = '" & txt_nombre.Text & "'," & _
              "apellido = '" & txt_apellido.Text & "',fecha_nacimiento = '" & dtp_fecha_nac.Value & "',fecha_ingreso = '" & dtp_fecha_ingreso.Value & "',sucursal = " & sucursal _
              & " where tipo_doc = " & cmb_tipo_documento.SelectedValue & " and nro_doc = " & msk_documento.Text.Trim
        Else

            sql = "update EMPLEADOS " & _
              " set tipo_doc = " & cmb_tipo_documento.SelectedValue & ",nro_doc = " & msk_documento.Text.Trim & ",nombre = '" & txt_nombre.Text & "'," & _
              "apellido = '" & txt_apellido.Text & "',fecha_nacimiento = '" & dtp_fecha_nac.Value & "',fecha_ingreso = '" & dtp_fecha_ingreso.Value & "',matricula = " & msk_matricula.Text & _
              ",sucursal = " & sucursal & " where tipo_doc = " & cmb_tipo_documento.SelectedValue & " and nro_doc = " & msk_documento.Text.Trim

        End If

        If _modificar(sql) Then

            MessageBox.Show("Empleado modificado con exito", "Carga datos")

            modificar = False

        End If

    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click

        limpiar()
        pnl_buscar.Visible = True
        mostrar_sucursal(lbl_nombre_sucursal)
        cargar_grilla(_leo_tabla("E.apellido as APELLIDO, E.nombre as NOMBRE, E.nro_doc as DOCUMENTO,E.fecha_nacimiento as NACIMIENTO, E.fecha_ingreso as INGRESO,E.matricula as MATRICULA, E.tipo_doc as 'TIPO DOCUMENTO'", _
                                "EMPLEADOS E join SUCURSALES S on E.sucursal = S.id_sucursal", "estado = 1 and E.sucursal = " & sucursal))
        txt_apellido_filtro.Focus()

    End Sub

    Private Sub cargar_grilla(ByVal tabla As Data.DataTable)

        dgv_empleados.DataSource = tabla
        dgv_empleados.Columns("TIPO DOCUMENTO").Visible = False

    End Sub

    Private Sub txt_apellido_filtro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apellido_filtro.KeyPress

        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
        Else
            cargar_grilla(_leo_tabla("E.apellido as APELLIDO, E.nombre as NOMBRE, E.nro_doc as DOCUMENTO,E.fecha_nacimiento as NACIMIENTO,E.fecha_ingreso as INGRESO,E.matricula as MATRICULA, E.tipo_doc as 'TIPO DOCUMENTO'", _
                                "EMPLEADOS E join SUCURSALES S on E.sucursal = S.id_sucursal", "E.apellido like '%" & txt_apellido_filtro.Text & "%' and estado = 1 and E.sucursal = " & sucursal))
        End If

    End Sub

    
    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click

        If MessageBox.Show("Esta seguro de eliminar el siguiente registro?", "Dar de baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If Not validar_supervisor(dgv_empleados.CurrentRow) Then

                eliminar_empleado(dgv_empleados.CurrentRow)

                cargar_grilla(_leo_tabla("E.apellido as APELLIDO, E.nombre as NOMBRE, E.nro_doc as DOCUMENTO,E.fecha_nacimiento as NACIMIENTO, E.fecha_ingreso as INGRESO,E.matricula as MATRICULA, E.tipo_doc as 'TIPO DOCUMENTO'", _
                                "EMPLEADOS E join SUCURSALES S on E.sucursal = S.id_sucursal", "estado = 1 and E.sucursal = " & sucursal))

            Else

                If MessageBox.Show("El empleado que desea eliminar es es un supervisor" & Chr(13) & "debe darlo de baja primero de su puesto " & _
                                Chr(13) & " desea eliminarlo como supervisor? ", "Importante", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                    frm_supervisores.ShowDialog()

                End If

            End If


        End If

    End Sub

    Private Function validar_supervisor(ByVal grilla As DataGridViewRow) As Boolean

        If _leo_tabla("SUCURSALES", "id_sucursal = " & sucursal & " and ((tipo_doc_superv = " & grilla.Cells("TIPO DOCUMENTO").Value & " and nro_doc_superv = " & grilla.Cells("DOCUMENTO").Value & ")" _
                      & " or (tipo_doc_super_supl = " & grilla.Cells("TIPO DOCUMENTO").Value & "and nro_doc_super_supl = " & grilla.Cells("DOCUMENTO").Value & "))" _
                      ).Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Private Sub eliminar_empleado(ByVal fila As DataGridViewRow)

        sql = "update EMPLEADOS set estado = 0 where tipo_doc = " & fila.Cells("TIPO DOCUMENTO").Value & " and nro_doc = " & fila.Cells("DOCUMENTO").Value
        If _modificar(sql) Then

            MessageBox.Show("Baja realizada con éxito!", "Baja Empleados", MessageBoxButtons.OK)
            modificar = False

        End If

    End Sub

    Private Sub dgv_empleados_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv_empleados.CellMouseDoubleClick

        pnl_buscar.Visible = False

        modificar = True

        limpiar()
        habilitar()

        txt_apellido.Text = dgv_empleados.Rows(e.RowIndex).Cells(0).Value
        txt_nombre.Text = dgv_empleados.Rows(e.RowIndex).Cells(1).Value
        msk_documento.Text = dgv_empleados.Rows(e.RowIndex).Cells(2).Value
        dtp_fecha_nac.Value = dgv_empleados.Rows(e.RowIndex).Cells(3).Value
        dtp_fecha_ingreso.Value = dgv_empleados.Rows(e.RowIndex).Cells(4).Value

        If Not IsDBNull(dgv_empleados.Rows(e.RowIndex).Cells(5).Value) Then
            rdo_si.Checked = True
            msk_matricula.Text = dgv_empleados.Rows(e.RowIndex).Cells(5).Value
        Else
            rdo_no.Checked = True
        End If

        cmb_tipo_documento.SelectedValue = dgv_empleados.Rows(e.RowIndex).Cells("TIPO DOCUMENTO").Value

        msk_documento.Enabled = False
        msk_matricula.Enabled = False

    End Sub

   
    Private Sub btn_cancelar_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click

        limpiar()

        If Not msk_documento.Enabled Then

            msk_documento.Enabled = True

        End If

    End Sub

End Class
