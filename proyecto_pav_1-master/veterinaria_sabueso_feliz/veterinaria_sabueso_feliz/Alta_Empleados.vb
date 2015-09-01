Public Class frm_alta_empleados

    Dim flag As Boolean
    
    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        limpiar()
        habilitar()
        txt_nombre.Focus()
    End Sub

    Private Sub limpiar()
        txt_nombre.Text = ""
        txt_apellido.Text = ""
        cmb_tipo_documento.SelectedIndex = -1
        msk_documento.Text = ""
        dtp_fecha_ingreso.MaxDate = Date.Today
        dtp_fecha_nac.MaxDate = Convert.ToDateTime(Date.Today.Day & "/" & Date.Today.Month & "/" & (Date.Today.Year - 18))
        rdo_si.Checked = False
        rdo_no.Checked = True
        msk_matricula.Text = ""

    End Sub

    Private Sub habilitar()
        pnl_datos_personales.Enabled = True
        btn_buscar.Enabled = True
        btn_cancelar.Enabled = True
        btn_guardar.Enabled = True
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
        carga_combo(cmb_tipo_documento, leo_tabla("TIPO_DOCUMENTO"), "id_tipo_doc", "descripcion")
    End Sub

    Private Sub carga_combo(ByVal combo As ComboBox, ByVal tabla As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click

        If validar() Then

            If validar_existensia() Then

                If Not rdo_si.Checked Then

                    sql = "insert into EMPLEADOS (tipo_doc,nro_doc,nombre,apellido,fecha_nacimiento,fecha_ingreso,sucursal)" & _
                      " values (" & cmb_tipo_documento.SelectedValue & "," & msk_documento.Text.Trim & ",'" & txt_nombre.Text & "'," & _
                      "'" & txt_apellido.Text & "','" & dtp_fecha_nac.Value & "','" & dtp_fecha_ingreso.Value & "'," & sucursal & ") "
                Else

                    sql = "insert into EMPLEADOS (tipo_doc,nro_doc,nombre,apellido,fecha_nacimiento,fecha_ingreso,matricula,sucursal)" & _
                      " values (" & cmb_tipo_documento.SelectedValue & "," & msk_documento.Text.Trim & ",'" & txt_nombre.Text & "'," & _
                      "'" & txt_apellido.Text & "','" & dtp_fecha_nac.Value & "','" & dtp_fecha_ingreso.Value & "'," & msk_matricula.Text & _
                      "," & sucursal & ") "

                End If

                If insert(sql) Then
                    MessageBox.Show("Empleado cargado con exito", "Carga datos")
                End If

            Else

                MessageBox.Show("Ya existe esa persona en la base de datos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        Else

            MessageBox.Show("Faltan datos", "Importante")

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

        If leo_tabla("EMPLEADOS", _
                     "tipo_doc = " & cmb_tipo_documento.SelectedValue & " and " & "nro_doc = " & msk_documento.Text.Trim).Rows.Count = 1 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click

    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click

    End Sub
End Class
