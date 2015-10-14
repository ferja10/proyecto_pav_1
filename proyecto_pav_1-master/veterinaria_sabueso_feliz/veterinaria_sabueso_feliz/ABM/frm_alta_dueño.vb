Public Class frm_alta_dueño

    Dim tabla_dueños As New Data.DataTable
    Dim modificar As Boolean = False

    Private Sub frm_alta_dueño_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        btn_eliminar.Enabled = False
        cargar_grilla(modulo._leo_tabla("DUEÑOS"))


    End Sub

    Private Sub cargar_grilla(ByVal Table As DataTable)
        grilla_duenos.DataSource = Table
        grilla_duenos.Columns("id_dueño").Visible = False
        grilla_duenos.Columns("estado").Visible = False
    End Sub

    Private Sub limpiar()
        txt_apellido.Text = ""
        txt_buscar.Text = ""
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        txt_telefono.Text = ""

    End Sub

    Private Sub btn_nuevo_Click(sender As System.Object, e As System.EventArgs) Handles btn_nuevo.Click
        Me.panel_duenos.Visible = False
        limpiar()
        modificar = False
        txt_codigo.Text = modulo.valorId("DUEÑOS", "id_dueño")

    End Sub


    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        If modificar Then
            modulo._modificar("update DUEÑOS set id_dueño = " & txt_codigo.Text & " , nombre = '" & txt_nombre.Text & "' , apellido = '" & txt_apellido.Text & "' , telefono = " & txt_telefono.Text)
        ElseIf Validar() Then
            'INSERT [INTO] table_or_view [(column_list)] data_values
            modulo._insertar("insert into DUEÑOS (id_dueño, nombre, apellido, telefono, estado) VALUES (" & txt_codigo.Text & ",'" & txt_nombre.Text & "', '" & txt_apellido.Text & "', " & txt_telefono.Text & ", 1)")
        End If
        'Cambio de contexto
        'Limpar casilleros
        limpiar()
        panel_duenos.Visible = True
        tabla_dueños = modulo._leo_tabla("DUEÑOS", "estado = 1")
        cargar_grilla(tabla_dueños)
    End Sub

    Private Function Validar() As Boolean


        If txt_apellido.Text = "" Then
            MsgBox("Completar Apellido", MsgBoxStyle.OkOnly, "Importante")
            Return False
        ElseIf txt_nombre.Text = "" Then
            MsgBox("Completar Nombre", MsgBoxStyle.OkOnly, "Importante")
            Return False
        ElseIf txt_telefono.Text = "" Then
            MsgBox("Completar telefono", MsgBoxStyle.OkOnly, "Importante")
            Return False
        End If

        Return True


    End Function


    Private Sub btn_salir_Click(sender As System.Object, e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        limpiar()
        Me.panel_duenos.Visible = True

    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click
        sql = "update DUEÑOS set estado = 0 where id_raza = " & grilla_duenos.CurrentRow.Cells("id_dueño").Value

        If modulo._eliminar(sql) Then

            MessageBox.Show("Dueño eliminado exitosmente", "Baja", MessageBoxButtons.OK)
            tabla_dueños = modulo._leo_tabla("RAZAS", "estado = 1")
            cargar_grilla(tabla_dueños)

        Else

            MessageBox.Show("Error al dar de baja", "Baja", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub grilla_duenos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grilla_duenos.CellContentClick

    End Sub
End Class