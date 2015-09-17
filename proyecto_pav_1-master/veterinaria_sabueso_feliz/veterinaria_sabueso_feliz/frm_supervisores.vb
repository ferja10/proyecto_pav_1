Public Class frm_supervisores

  
    Private Sub frm_supervisores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim cad As String = " Faltan cargar "

        Me.Visible = True

        mostrar_sucursal(lbl_sucursal)

        cargar_combo(cmb_tipo_doc_sup, _leo_tabla("TIPO_DOCUMENTO"), "id_tipo_doc", "descripcion")
        cargar_combo(cmb_tipo_doc_sup_supl, _leo_tabla("TIPO_DOCUMENTO"), "id_tipo_doc", "descripcion")

        cargar_grilla(_leo_tabla("E.tipo_doc as 'TIPO DOCUMENTO',E.apellido as APELLIDO, E.nombre as NOMBRE, E.nro_doc as DOCUMENTO,E.matricula as MATRICULA", _
                                "EMPLEADOS E join SUCURSALES S on E.sucursal = S.id_sucursal", "estado = 1 and E.sucursal = " & sucursal))

        If validar_supervisores() Then

            cargar_supervisores(_leo_tabla("S.tipo_doc_superv as 'TIPO DOCUMENTO', E.apellido as APELLIDO, E.nombre as NOMBRE, S.nro_doc_superv as DOCUMENTO, E.matricula as MATRICULA", _
                      "EMPLEADOS E join SUCURSALES S on E.nro_doc = S.nro_doc_superv and E.tipo_doc = S.tipo_doc_superv", _
                      "sucursal = " & sucursal))

            If validar_supervisores_suplentes() Then

                cargar_supervisores_suplentes(_leo_tabla("S.tipo_doc_super_supl as 'TIPO DOCUMENTO', E.apellido as APELLIDO, E.nombre as NOMBRE, S.nro_doc_super_supl as DOCUMENTO, E.matricula as MATRICULA", _
                      "EMPLEADOS E join SUCURSALES S on E.nro_doc = S.nro_doc_super_supl and E.tipo_doc = S.tipo_doc_super_supl", _
                      "sucursal = " & sucursal))

            Else

                MessageBox.Show(cad & "El supervisor suplente", "Importante", MessageBoxButtons.OK)

            End If

        ElseIf validar_supervisores_suplentes() Then

            cargar_supervisores_suplentes(_leo_tabla("S.tipo_doc_super_supl as 'TIPO DOCUMENTO', E.apellido as APELLIDO, E.nombre as NOMBRE, S.nro_doc_super_supl as DOCUMENTO, E.matricula as MATRICULA", _
                      "EMPLEADOS E join SUCURSALES S on E.nro_doc = S.nro_doc_super_supl and E.tipo_doc = S.tipo_doc_super_supl", _
                      "sucursal = " & sucursal))

            MessageBox.Show(cad & "El supervisor Titular", "Importante", MessageBoxButtons.OK)

        Else

            MessageBox.Show(cad & "Los supervisores", "Importante", MessageBoxButtons.OK)


        End If

    End Sub

    
    Private Sub cargar_supervisores(ByVal tabla As Data.DataTable)

        If tabla.Rows.Count > 0 Then

            txt_apellido_sup.Text = tabla.Rows(0)(1)
            txt_nombre_sup.Text = tabla.Rows(0)(2)
            cmb_tipo_doc_sup.SelectedValue = tabla.Rows(0)(0)
            msk_nro_doc_sup.Text = tabla.Rows(0)(3)

        Else

            txt_apellido_sup.Text = ""
            txt_nombre_sup.Text = ""
            cmb_tipo_doc_sup.SelectedValue = -1
            msk_nro_doc_sup.Text = ""

        End If
        
    End Sub

    Private Sub cargar_supervisores_suplentes(ByVal tabla As Data.DataTable)

        If tabla.Rows.Count > 0 Then

            txt_apellido_supl.Text = tabla.Rows(0)(1)
            txt_nombre_supl.Text = tabla.Rows(0)(2)
            cmb_tipo_doc_sup_supl.SelectedValue = tabla.Rows(0)(0)
            msk_nro_doc_sup_supl.Text = tabla.Rows(0)(3)

        Else

            txt_apellido_supl.Text = ""
            txt_nombre_supl.Text = ""
            cmb_tipo_doc_sup_supl.SelectedValue = -1
            msk_nro_doc_sup_supl.Text = ""

        End If

    End Sub

    Private Function validar_supervisores() As Boolean

        If _leo_tabla("S.tipo_doc_superv as 'TIPO DOCUMENTO', E.apellido as APELLIDO, E.nombre as NOMBRE, S.nro_doc_superv as DOCUMENTO, E.matricula as MATRICULA", _
                      "EMPLEADOS E join SUCURSALES S on E.nro_doc = S.nro_doc_superv and E.tipo_doc = S.tipo_doc_superv", _
                      "sucursal = " & sucursal).Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Private Function validar_supervisores_suplentes() As Boolean

        If _leo_tabla("S.tipo_doc_super_supl as 'TIPO DOCUMENTO', E.apellido as APELLIDO, E.nombre as NOMBRE, S.nro_doc_super_supl as DOCUMENTO, E.matricula as MATRICULA", _
                      "EMPLEADOS E join SUCURSALES S on E.nro_doc = S.nro_doc_super_supl and E.tipo_doc = S.tipo_doc_super_supl", _
                      "sucursal = " & sucursal).Rows.Count > 0 Then

            Return True

        Else

            Return False

        End If

    End Function

    Private Sub cargar_grilla(ByVal tabla As Data.DataTable)

        dgv_empleados.DataSource = tabla
        dgv_empleados.Columns("TIPO DOCUMENTO").Visible = False

    End Sub

    Private Sub chk_matricula_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_nro_doc.CheckedChanged

        If chk_nro_doc.Checked Then

            msk_nro_doc.Enabled = True

        Else

            msk_nro_doc.Enabled = False
            msk_nro_doc.Text = ""

        End If

    End Sub

    Private Sub txt_apellido_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apellido.KeyPress

        If IsNumeric(e.KeyChar) Then

            e.KeyChar = ""

        End If

    End Sub

    Private Sub txt_apellido_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_apellido.TextChanged

        cargar_grilla(_leo_tabla("E.tipo_doc as 'TIPO DOCUMENTO',E.apellido as APELLIDO, E.nombre as NOMBRE, E.nro_doc as DOCUMENTO,E.matricula as MATRICULA", _
                                "EMPLEADOS E join SUCURSALES S on E.sucursal = S.id_sucursal", "E.apellido like '%" & txt_apellido.Text & "%' and estado = 1 and E.sucursal = " & sucursal))

    End Sub



    Private Sub msk_nro_doc_TextChanged(sender As System.Object, e As System.EventArgs) Handles msk_nro_doc.TextChanged

        cargar_grilla(_leo_tabla("E.tipo_doc as 'TIPO DOCUMENTO',E.apellido as APELLIDO, E.nombre as NOMBRE, E.nro_doc as DOCUMENTO,E.matricula as MATRICULA", _
                                "EMPLEADOS E join SUCURSALES S on E.sucursal = S.id_sucursal", "E.nro_doc like '%" & msk_nro_doc.Text & "%' and estado = 1 and E.sucursal = " & sucursal))

    End Sub

    Private Sub chk_nro_doc_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles chk_nro_doc.KeyPress

        If Asc(e.KeyChar) = 13 Then

            If chk_nro_doc.Checked Then

                chk_nro_doc.Checked = False

            Else

                chk_nro_doc.Checked = True

            End If

        End If

    End Sub

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click

        If rdo_titular.Checked Then

            guardar_supervisor(dgv_empleados.CurrentRow)

        ElseIf rdo_suplente.Checked Then

            guardar_supervisor_suplente(dgv_empleados.CurrentRow)

        Else

            MessageBox.Show("Seleccione si es suplente o titular el empleado a asignar", "Importante", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub guardar_supervisor(ByVal fila As DataGridViewRow)

        sql = "update SUCURSALES set tipo_doc_superv = " & fila.Cells(0).Value & _
            ", nro_doc_superv = " & fila.Cells(3).Value & _
            " where id_sucursal = " & sucursal

        If _modificar(sql) Then

            cargar_supervisores(_leo_tabla("S.tipo_doc_superv as 'TIPO DOCUMENTO', E.apellido as APELLIDO, E.nombre as NOMBRE, S.nro_doc_superv as DOCUMENTO, E.matricula as MATRICULA", _
                     "EMPLEADOS E join SUCURSALES S on E.nro_doc = S.nro_doc_superv and E.tipo_doc = S.tipo_doc_superv", _
                     "sucursal = " & sucursal))

            MessageBox.Show("Modificacion realizada con éxito", "Alta Suervisores", MessageBoxButtons.OK)

        Else

            MessageBox.Show("Error al modificar supervisor", "Error", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub guardar_supervisor_suplente(ByVal fila As DataGridViewRow)

        sql = "update SUCURSALES set tipo_doc_super_supl = " & fila.Cells(0).Value & _
            ", nro_doc_super_supl = " & fila.Cells(3).Value & _
            " where id_sucursal = " & sucursal

        If _modificar(sql) Then

            cargar_supervisores_suplentes(_leo_tabla("S.tipo_doc_super_supl as 'TIPO DOCUMENTO', E.apellido as APELLIDO, E.nombre as NOMBRE, S.nro_doc_super_supl as DOCUMENTO, E.matricula as MATRICULA", _
                      "EMPLEADOS E join SUCURSALES S on E.nro_doc = S.nro_doc_super_supl and E.tipo_doc = S.tipo_doc_super_supl", _
                      "sucursal = " & sucursal))

            MessageBox.Show("Modificacion realizada con éxito", "Alta Suervisores", MessageBoxButtons.OK)

        Else

            MessageBox.Show("Error al modificar supervisor", "Error", MessageBoxButtons.OK)

        End If

    End Sub

    
    Private Sub btn_eliminar_sup_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar_sup.Click

        If MessageBox.Show("Esta seguro?", "Eliminar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            eliminar_supervisor()

        End If

    End Sub



    Private Sub btn_eliminar_sup_supl_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar_sup_supl.Click

        If MessageBox.Show("Esta seguro?", "Eliminar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            eliminar_supervisor_suplente()

        End If

    End Sub


    Private Sub eliminar_supervisor()

        sql = "update SUCURSALES set tipo_doc_superv = null" & _
            ", nro_doc_superv = null" & _
            " where id_sucursal = " & sucursal

        If _modificar(sql) Then

            cargar_supervisores(_leo_tabla("S.tipo_doc_superv as 'TIPO DOCUMENTO', E.apellido as APELLIDO, E.nombre as NOMBRE, S.nro_doc_superv as DOCUMENTO, E.matricula as MATRICULA", _
                     "EMPLEADOS E join SUCURSALES S on E.nro_doc = S.nro_doc_superv and E.tipo_doc = S.tipo_doc_superv", _
                     "sucursal = " & sucursal))

            MessageBox.Show("Eliminación realizada con éxito", "Baja Suervisores", MessageBoxButtons.OK)

        Else

            MessageBox.Show("Error al eliminar supervisor", "Error", MessageBoxButtons.OK)

        End If


    End Sub

    Private Sub eliminar_supervisor_suplente()

        sql = "update SUCURSALES set tipo_doc_super_supl = null" & _
            ", nro_doc_super_supl = null" & _
            " where id_sucursal = " & sucursal

        If _modificar(sql) Then

            cargar_supervisores_suplentes(_leo_tabla("S.tipo_doc_super_supl as 'TIPO DOCUMENTO', E.apellido as APELLIDO, E.nombre as NOMBRE, S.nro_doc_super_supl as DOCUMENTO, E.matricula as MATRICULA", _
                      "EMPLEADOS E join SUCURSALES S on E.nro_doc = S.nro_doc_super_supl and E.tipo_doc = S.tipo_doc_super_supl", _
                      "sucursal = " & sucursal))

            MessageBox.Show("Eliminación realizada con éxito", "Baja Suervisores", MessageBoxButtons.OK)

        Else

            MessageBox.Show("Error al Eliminar supervisor", "Error", MessageBoxButtons.OK)

        End If


    End Sub

    Private Sub btn_salir_Click(sender As System.Object, e As System.EventArgs) Handles btn_salir.Click

        Close()

    End Sub

    Private Sub frm_supervisores_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If MessageBox.Show("Podría perder información no guardada" & Chr(13) & "            ¿Está seguro que desea salir?", "Importante", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub
End Class