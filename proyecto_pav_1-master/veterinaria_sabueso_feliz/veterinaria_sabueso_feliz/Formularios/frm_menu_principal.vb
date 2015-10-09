Public Class frm_menu_principal

    Dim fc As New frm_clave


    Private Sub frm_menu_principal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If MessageBox.Show("Salir?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            e.Cancel = False
            If clave Then
                fc.Close()
            End If
        Else
            e.Cancel = True
            If clave Then
                fc.Visible = True
            End If
        End If

    End Sub

    Private Sub frm_menu_principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Visible = True
        clave = True
        fc.ShowDialog()

    End Sub

    Private Sub tsi_subordinados_Click(sender As System.Object, e As System.EventArgs) Handles tsi_subordinados.Click

        frm_alta_empleados.ShowDialog()

    End Sub

    Private Sub tsi_supervisores_Click(sender As System.Object, e As System.EventArgs) Handles tsi_supervisores.Click

        frm_supervisores.ShowDialog()

    End Sub

    Private Sub tsi_vacunas_Click(sender As System.Object, e As System.EventArgs) Handles tsi_vacunas.Click

        frm_alta_Vacunas.ShowDialog()

    End Sub

    Private Sub tsi_laboratorios_Click(sender As System.Object, e As System.EventArgs) Handles tsi_laboratorios.Click

        frm_alta_labortorios.ShowDialog()

    End Sub

    Private Sub tsi_razas_Click(sender As System.Object, e As System.EventArgs) Handles tsi_razas.Click

        frm_alta_razas.ShowDialog()

    End Sub

    Private Sub tsi_medicamentos_Click(sender As System.Object, e As System.EventArgs) Handles tsi_medicamentos.Click

        frm_alta_medicamentos.ShowDialog()

    End Sub

    Private Sub tsi_Sucursales_Click(sender As System.Object, e As System.EventArgs) Handles tsi_Sucursales.Click

        frm_alta_Sucursal.ShowDialog()

    End Sub

    Private Sub tsi_cita_Click(sender As System.Object, e As System.EventArgs) Handles tsi_cita.Click

        frm_consulta_medica.ShowDialog()

    End Sub
End Class