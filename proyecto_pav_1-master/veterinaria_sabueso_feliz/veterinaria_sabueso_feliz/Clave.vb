Public Class frm_clave

    Private Function validar() As Boolean

        If msk_sucursal.Text = "" Then
            msk_sucursal.Focus()
            Return False
        ElseIf txt_contraseña.Text = "" Then
            txt_contraseña.Focus()
            Return False
        End If
        Return True

    End Function

    Private Function validar_existensia() As Boolean

        If _leo_tabla("SUCURSALES", _
                     "id_sucursal = " & msk_sucursal.Text.Trim & " and clave = '" & txt_contraseña.Text.Trim & "'").Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click

        login()

    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click

        frm_menu_principal.Close()
    End Sub

    Private Sub msk_sucursal_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles msk_sucursal.KeyPress

        If Asc(e.KeyChar) = 13 Then
            login()
        End If

    End Sub

    Private Sub login()

        If validar() Then

            If validar_existensia() Then
                sucursal = msk_sucursal.Text.Trim
                clave = False
                Close()
            Else
                MessageBox.Show("Clave o Usuario incorrecto", "Importante")
            End If
        Else
            MessageBox.Show("Falta usuario/contraseña", "importante")
        End If
    End Sub

    Private Sub txt_contraseña_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_contraseña.KeyPress

        If Asc(e.KeyChar) = 13 Then
            login()
        End If
       
    End Sub
End Class