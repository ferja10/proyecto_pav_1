Public Class frm_busqueda_consulta

    Private Sub frm_busqueda_consulta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        _cargar_grilla(dgv_consultas, _leo_tabla("C.id_consulta as ID,C.nro_historia_clinica as HISTORIAL,P.nombre as NOMBRE,C.fecha_entrada as INGRESO,C.fecha_salida as EGRESO" _
                                                 , "CONSULTAS C join PERROS P on C.nro_historia_clinica = P.nro_historia_clinica and C.id_sucursal = P.id_sucursal" _
                                                 , "C.id_sucursal = " & sucursal))

        _cargar_combo(cmb_doctor, _leo_tabla("E.nro_doc as ID,E.apellido + ' , ' + E.nombre as NOMBRE", "EMPLEADOS E", "estado = 1 and sucursal = " & sucursal), "ID", "NOMBRE")

        cmb_doctor.SelectedValue = -1

    End Sub



    Private Sub txt_nombre_perro_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre_perro.KeyPress

        If IsNumeric(e.KeyChar) Then

            e.KeyChar = ""

        End If

    End Sub

    Private Sub btn_buscar_Click(sender As System.Object, e As System.EventArgs) Handles btn_buscar.Click

        _cargar_grilla(dgv_consultas, _leo_tabla("C.id_consulta as ID,C.nro_historia_clinica as HISTORIAL,P.nombre as NOMBRE,C.fecha_entrada as INGRESO,C.fecha_salida as EGRESO" _
                                                 , "CONSULTAS C join PERROS P on C.nro_historia_clinica = P.nro_historia_clinica and C.id_sucursal = P.id_sucursal" _
                                                 , "C.id_sucursal = " & sucursal & " and nro_doc_empl = " & cmb_doctor.SelectedValue & " and P.nombre like '% " & txt_nombre_perro.Text & " %'"))


    End Sub

    Private Sub chk_doctor_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_doctor.CheckedChanged

        If chk_doctor.Checked Then

            cmb_doctor.Enabled = True

        Else

            cmb_doctor.Enabled = False
            cmb_doctor.SelectedValue = -1

        End If

    End Sub

End Class