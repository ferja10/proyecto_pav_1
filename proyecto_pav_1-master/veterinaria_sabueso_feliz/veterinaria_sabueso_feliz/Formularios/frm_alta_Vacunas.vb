Public Class frm_alta_Vacunas
    Dim tablaVac As Data.DataTable
    Private Sub Alta_Vacunas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_eliminar.Enabled = False
        tablaVac = modulo._leo_tabla("VACUNAS", "estado = 1")
        cargar_grilla(tablaVac)
    End Sub
    Private Sub cargar_grilla(ByVal tabla As Data.DataTable)
        dgc_Vacunas.DataSource = tabla
        dgc_Vacunas.Columns("id_vacuna").Visible = False
    End Sub
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
    Private Sub Limpiar()
        txt_Descripcion.Text = ""
    End Sub

    Private Sub dgc_Vacunas_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgc_Vacunas.CellClick
        btn_eliminar.Enabled = True
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sql = "update VACUNAS set estado = 0 where id_vacuna = " & dgc_Vacunas.CurrentRow.Cells("id_medicamento").Value

        If _eliminar(sql) Then

            MessageBox.Show("Vacuna eliminada exitosmente", "Baja", MessageBoxButtons.OK)
            tablaVac = modulo._leo_tabla("VACUNAS", "estado = 1")
            cargar_grilla(tablaVac)

        Else

            MessageBox.Show("Error al dar de baja", "Baja", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If Validar() Then
            'INSERT [INTO] table_or_view [(column_list)] data_values
            modulo._insertar("INSERT INTO VACUNAS (id_vacuna,descripcion,estado) VALUES (" & valorId("VACUNAS") + 1 & ",'" & txt_Descripcion.Text & "',1)")
        End If
        'Cambio de contexto
        'Limpar casilleros
        Limpiar()
        tablaVac = modulo._leo_tabla("MEDICAMENTOS", "estado = 1")
        cargar_grilla(tablaVac)
    End Sub

    Private Function Validar() As Boolean
        If txt_Descripcion.Text = "" Then
            MsgBox("Debe completar este campo")
            Return False
        End If
        If Existe("VACUNAS", "descripcion = '" & txt_Descripcion.Text & "'") Then
            MsgBox("La vacuna ya existe")
            Return False
        End If
        Return True
    End Function

    Private Sub txt_Descripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Descripcion.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.KeyChar = ""
        Else
            Dim tablacons As Data.DataTable
            tablacons = modulo._leo_tabla("VACUNAS", "descripcion LIKE '%" & txt_Descripcion.Text & "%' AND estado = 1")
            cargar_grilla(tablacons)
        End If
    End Sub
End Class