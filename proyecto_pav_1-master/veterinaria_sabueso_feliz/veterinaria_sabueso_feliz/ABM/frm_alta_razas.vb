Public Class frm_alta_razas
    Dim tablaRazas As Data.DataTable
    Dim modificar As Boolean = False
    Private Sub frm_alta_razas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_eliminar.Enabled = False
        Limpiar()
        CambioGrilla()
        cargar_grilla(modulo._leo_tabla("id_raza,denominacion AS Denominación, peso_minimo_hembra AS 'Peso Minimo Hembra', peso_minimo_macho AS 'Peso Minimo Macho', altura_media_hembra AS 'Altura Media Hembra', altura_media_macho AS 'Altura Media Macho', nota_cuidados AS Cuidados,estado", "RAZAS", "estado = 1"))
    End Sub
    Private Sub cargar_grilla(ByVal Table As DataTable)
        GrillaRaza.DataSource = Table
        GrillaRaza.Columns("id_raza").Visible = False
        GrillaRaza.Columns("estado").Visible = False
    End Sub
    Private Sub Limpiar()
        Me.txt_Codigo.Text = ""
        Me.txt_Denominacion.Text = ""
        Me.txt_PMinM.Text = ""
        Me.txt_AMedM.Text = ""
        Me.txt_PMinH.Text = ""
        Me.txt_AMedH.Text = ""
        Me.txt_Cuidados.Text = ""
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        CambioAlta()
        Limpiar()
        modificar = False
        txt_Codigo.Text = modulo.valorId("RAZAS", "id_raza")
    End Sub
    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If modificar Then
            modulo._modificar("UPDATE RAZAS SET denominacion = '" & txt_Denominacion.Text & "', peso_minimo_hembra = " & txt_PMinH.Text & ", peso_minimo_macho = " & txt_PMinM.Text & ", altura_media_hembra = " & txt_AMedH.Text & ", altura_media_macho = " & txt_AMedM.Text & ", nota_cuidados = '" & txt_Cuidados.Text & "',estado = 1 WHERE (id_raza = " & txt_Codigo.Text & ")")
        ElseIf Validar() Then
            'INSERT [INTO] table_or_view [(column_list)] data_values
            modulo._insertar("insert into RAZAS (id_raza, denominacion, peso_minimo_hembra, peso_minimo_macho, altura_media_hembra, altura_media_macho, nota_cuidados, estado) VALUES (" & txt_Codigo.Text & ",'" & txt_Denominacion.Text & "'," & txt_PMinM.Text & ", " & txt_PMinH.Text & ", " & txt_AMedM.Text & ", " & txt_AMedH.Text & ",'" & txt_Cuidados.Text & "',1)")
        Else
            Exit Sub
        End If
        'Cambio de contexto
        'Limpar casilleros
        Limpiar()
        CambioGrilla()
        cargar_grilla(modulo._leo_tabla("id_raza,denominacion AS Denominación, peso_minimo_hembra AS 'Peso Minimo Hembra', peso_minimo_macho AS 'Peso Minimo Macho', altura_media_hembra AS 'Altura Media Hembra', altura_media_macho AS 'Altura Media Macho', nota_cuidados AS Cuidados,estado", "RAZAS", "estado = 1"))
    End Sub
    Private Function Validar() As Boolean
        If txt_Denominacion.Text = "" Then
            MsgBox("Completar Denominacion", MsgBoxStyle.OkOnly, "Importante")
            Return False
        ElseIf modulo.Existe("RAZAS", "denominacion = '" & txt_Denominacion.Text & "'") Then
            If MessageBox.Show("Esta Denominacion ya existe, ¿Desea Recuperarlo?", "Dar de Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                modulo._modificar("update RAZAS set estado = 1 where descripcion ='" & txt_Denominacion.Text & "'")
            End If
            Return False
        ElseIf txt_AMedH.Text = "" Then
            MsgBox("Completar Peso Maximo Hembra", MsgBoxStyle.OkOnly, "Importante")
            Return False
        ElseIf txt_AMedM.Text = "" Then
            MsgBox("Completar Peso Maximo Macho", MsgBoxStyle.OkOnly, "Importante")
            Return False
        ElseIf txt_PMinH.Text = "" Then
            MsgBox("Completar Peso Minimo Hembra", MsgBoxStyle.OkOnly, "Importante")
            Return False
        ElseIf txt_PMinM.Text = "" Then
            MsgBox("Completar Peso Minimo Macho", MsgBoxStyle.OkOnly, "Importante")
            Return False
        End If
        Return True
    End Function
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

    Private Sub txt_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Buscar.KeyPress
        btn_eliminar.Enabled = False
        If Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub txt_Denominacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Denominacion.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Limpiar()
        CambioGrilla()
        cargar_grilla(modulo._leo_tabla("id_raza,denominacion AS Denominación, peso_minimo_hembra AS 'Peso Minimo Hembra', peso_minimo_macho AS 'Peso Minimo Macho', altura_media_hembra AS 'Altura Media Hembra', altura_media_macho AS 'Altura Media Macho', nota_cuidados AS Cuidados,estado", "RAZAS", "estado = 1"))
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        sql = "update RAZAS set estado = 0 where id_raza = " & GrillaRaza.CurrentRow.Cells("id_raza").Value

        If _eliminar(sql) Then

            MessageBox.Show("Raza eliminado exitosmente", "Baja", MessageBoxButtons.OK)

            cargar_grilla(modulo._leo_tabla("id_raza,denominacion AS Denominación, peso_minimo_hembra AS 'Peso Minimo Hembra', peso_minimo_macho AS 'Peso Minimo Macho', altura_media_hembra AS 'Altura Media Hembra', altura_media_macho AS 'Altura Media Macho', nota_cuidados AS Cuidados,estado", "RAZAS", "estado = 1"))

        Else

            MessageBox.Show("Error al dar de baja", "Baja", MessageBoxButtons.OK)

        End If
        btn_eliminar.Enabled = False
    End Sub

    Private Sub GrillaRaza_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaRaza.CellDoubleClick
        CambioAlta()
        txt_Codigo.Text = GrillaRaza.CurrentRow.Cells(0).Value
        txt_Denominacion.Text = GrillaRaza.CurrentRow.Cells(1).Value
        txt_PMinH.Text = GrillaRaza.CurrentRow.Cells(2).Value
        txt_PMinM.Text = GrillaRaza.CurrentRow.Cells(3).Value
        txt_AMedH.Text = GrillaRaza.CurrentRow.Cells(4).Value
        txt_AMedM.Text = GrillaRaza.CurrentRow.Cells(5).Value
        txt_Cuidados.Text = GrillaRaza.CurrentRow.Cells(6).Value
        modificar = True
    End Sub

    Private Sub txt_Buscar_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Buscar.KeyUp
        cargar_grilla(modulo._leo_tabla("id_raza,denominacion AS Denominación, peso_minimo_hembra AS 'Peso Minimo Hembra', peso_minimo_macho AS 'Peso Minimo Macho', altura_media_hembra AS 'Altura Media Hembra', altura_media_macho AS 'Altura Media Macho', nota_cuidados AS Cuidados,estado", "RAZAS", "denominacion LIKE '%" & txt_Buscar.Text & "%' AND estado = 1"))
    End Sub

    Private Sub GrillaRaza_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaRaza.CellClick
        If e.RowIndex >= 0 Then
            btn_eliminar.Enabled = True
        Else
            btn_eliminar.Enabled = False
        End If
    End Sub
End Class