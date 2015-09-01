Public Class frm_menu_principal

    Dim fc As New frm_clave

    Private Sub tsi_nuevo_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsi_nuevo_empleado.Click
        frm_alta_empleados.ShowDialog()
    End Sub


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
End Class