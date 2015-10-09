Public Class frm_alta_Sucursal
    Dim tablaSuc As New Data.DataTable
    Dim modificar As Boolean = False
    Private Sub Form_Sucursal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btn_eliminar.Enabled = False
        tablaSuc = modulo._leo_tabla("SUCURSALES", "estado = 1")
        cargarGrilla(tablaSuc)
    End Sub

    Private Sub cargarGrilla(ByVal _tabla As Data.DataTable)
        Me.GrillaSucursales.DataSource = _tabla
        Me.GrillaSucursales.Columns("id_sucursal").Visible = False
        Me.GrillaSucursales.Columns(7).Visible = False
        Me.GrillaSucursales.Columns(6).Visible = False
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        CambioAlta()
        Limpiar()
        modificar = False
        txt_Codigo.Text = modulo.valorId("SUCURSALES") + 1
    End Sub
    Function Validar() As Boolean
        If txt_Nombre.Text = "" Then
            MsgBox("Falta completar nombre")
            Return False
        End If
        If Existe("SUCURSALES", "nombre = '" & txt_Nombre.Text & "'") Then
            If MsgBox("Ya existe una Sucursal con este nombre, ¿Desea Restaurar los datos?", MsgBoxStyle.OkCancel, "¡Atención!") = MsgBoxResult.Ok Then
                sql = "update SUCURSALES set estado = 1 where nombre = '" & txt_Nombre.Text & "'"
                modulo._modificar(sql)
            End If
            Return False
        End If
        If txt_Contr.Text = "" Then
            MsgBox("Debe completar la contraseña de Acceso al sistema")
            Return False
        End If
        Return True
    End Function

    Private Sub Limpiar()
        Me.txt_Nombre.Text = ""
        Me.txt_Contr.Text = ""
        txt_Buscar.Text = ""
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click

        If modificar Then
            modulo._modificar("update SUCURSALES set nombre = '" & txt_Nombre.Text & "' , clave = " & txt_Codigo.Text & ",Where id_sucursal = " & txt_Codigo.Text)
        ElseIf Validar() Then
            _insertar("insert into SUCURSALES (id_sucursal, nombre, clave, estado) VALUES (" + txt_Codigo.Text & ", '" & txt_Nombre.Text & "','" & txt_Contr.Text & "',1)")
            cargarGrilla(modulo._leo_tabla("SUCURSALES", "estado = 1"))
            CambioGrilla()
            Limpiar()
        End If
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        CambioGrilla()
        Limpiar()
    End Sub

    Private Sub txt_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Buscar.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.KeyChar = ""
        Else
            modulo._cargar_grilla(GrillaSucursales, _leo_tabla("SUCURSALES", "nombre LIKE '%" & txt_Buscar.Text & "%' and estado = 1 "))
        End If
    End Sub

    Private Sub txt_Nombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Nombre.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub GrillaSucursales_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrillaSucursales.CellMouseClick
        btn_eliminar.Enabled = True
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        sql = "update SUCURSALES set estado = 0 where id_sucursal = " & GrillaSucursales.CurrentRow.Cells("id_sucursal").Value

        If _eliminar(sql) Then

            MessageBox.Show("Laboratorio eliminado exitosmente", "Baja", MessageBoxButtons.OK)
            cargarGrilla(modulo._leo_tabla("SUCURSALES", "estado = 1"))

        Else

            MessageBox.Show("Error al dar de baja", "Baja", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub GrillaSucursales_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GrillaSucursales.DoubleClick

        PanelGrilla.Visible = False
        Me.PanelAlta.Visible = True

        txt_Codigo.Text = GrillaSucursales.CurrentRow.Cells(0).Value
        txt_Nombre.Text = GrillaSucursales.CurrentRow.Cells(1).Value
        txt_Contr.Text = GrillaSucursales.CurrentRow.Cells(6).Value

    End Sub

    Private Sub CambioAlta()
        PanelAlta.Visible = True
        PanelGrilla.Visible = False
        btn_eliminar.Visible = False
        btn_guardar.Visible = True
        btn_cancelar.Visible = True
    End Sub

    Private Sub CambioGrilla()
        PanelGrilla.Visible = True
        PanelAlta.Visible = False
        btn_eliminar.Visible = True
        btn_guardar.Visible = False
        btn_cancelar.Visible = False
    End Sub

    Private Sub GrillaSucursales_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaSucursales.CellClick
        btn_eliminar.Visible = True
        btn_eliminar.Enabled = True
    End Sub
End Class