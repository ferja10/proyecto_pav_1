Public Class frm_abm_historia_clinica

    Private Sub frm_abm_historia_clinica_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        modulo.mostrar_sucursal(lbl_sucursal)
        txt_nro_historia_clinica.Text = (modulo.valorId("PERROS") + 1)
        _cargar_grilla(dgv_dueños, _leo_tabla("DUEÑOS"))
        dgv_dueños.Columns(0).Visible = False

    End Sub




End Class