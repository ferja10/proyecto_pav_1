Public Class frm_alta_empleados

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
        dtp_fecha_nac.MaxDate = Date.Today
        dtp_fecha_ingreso.MaxDate = Date.Today
        msk_matricula.Text = ""
        msk_sucursal.Text = ""
        cmb_puesto.SelectedIndex = -1
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
End Class
