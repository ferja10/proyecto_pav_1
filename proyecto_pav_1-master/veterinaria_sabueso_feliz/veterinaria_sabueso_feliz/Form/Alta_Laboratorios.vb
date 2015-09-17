Public Class Alta_Laboratorios
    Dim tablaLab As Data.DataTable
    Private Sub Alta_Laboratorios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_eliminar.Enabled = False
        tablaLab = modulo._leo_tabla("LABORATORIOS")
        cargar_grilla(tablaLab)
        'Indicadores de botones
        TTNuevo.SetToolTip(btn_nuevo, "Nuevo")
        TTEliminar.SetToolTip(btn_eliminar, "Eliminar Laboratorio Seleccionado")
        TTSalir.SetToolTip(btn_salir, "Salir")
    End Sub
    Private Sub cargar_grilla(ByVal tabla As Data.DataTable)
        dgc_Laboratorios.DataSource = tabla
        dgc_Laboratorios.Columns("id_laboratorio").Visible = False
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        panel_Alta.Visible = True
        txt_Id.Enabled = False
        btn_eliminar.Enabled = False
        'Colocar numero de Identificacion
        'Asigno el valor con el incremento de una unidad
        txt_Id.Text = valorId() + 1
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        'alvertencia
        'Limpar casilleros
        Limpiar()
        PanelGrilla.Visible = True
        panel_Alta.Visible = False
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'validaciones

        If Validar() Then
            'INSERT [INTO] table_or_view [(column_list)] data_values
            modulo._insertar("INSERT INTO LABORATORIOS (id_laboratorio,razon_social,direccion) VALUES (" & txt_Id.Text & ",'" & txt_RazonSocialNew.Text & "','" & txt_Direccion.Text & "')")
            'Cambio de contexto
            'Limpar casilleros
            Limpiar()
            panel_Alta.Visible = False
            PanelGrilla.Visible = True
            tablaLab = modulo._leo_tabla("LABORATORIOS")
            cargar_grilla(tablaLab)
        End If
    End Sub
    'Esta Funcion devuelve la cantidad de registros actules 
    Function valorId() As Integer
        Dim _tabla As New Data.DataTable
        Dim valor As String
        modulo._consulta("SELECT COUNT(*) AS ID FROM LABORATORIOS", _tabla)
        valor = _tabla.Rows(0)(0).ToString
        Return (valor)
    End Function
    'Este metodo retorna si existe un cirto parmetro dentro de la columna especificada
    Function Existe(ByVal texto As String, ByVal columna As String) As Boolean
        Dim _tabla As New Data.DataTable
        modulo._consulta("SELECT COUNT(*) AS CANTIDAD FROM(LABORATORIOS) WHERE(" & columna & " = '" & texto & "')", _tabla)
        'Si la cantidad de columnas encontradas es mayor o igual a uno significa que exite
        If _tabla.Rows.Count() = 1 Then
            Return True
        End If
        Return False
    End Function
    Function Validar() As Boolean
        If txt_RazonSocialNew.Text = "" Then
            TTRazonSoc.Show("Debe completar este campo (Para quitar este Mensaje as click aqui)", txt_RazonSocialNew)
            Return False
        End If
        If Existe(txt_Razon_Social.Text, "razon_social") Then
            TTRazonSoc.Show("Ya existe un Laboratorio con este nombre (Para quitar este Mensaje as click aqui)", txt_RazonSocialNew)
            Return False
        End If
        If txt_Direccion.Text = "" Then
            TTDirec.Show("Debe completar este campo (Para quitar este Mensaje as click aqui)", txt_Direccion)
            Return False
        End If
        Return True
    End Function

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
    Private Sub Limpiar()
        txt_Id.Text = ""
        txt_RazonSocialNew.Text = ""
        txt_Direccion.Text = ""
    End Sub

    Private Sub dgc_Laboratorios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgc_Laboratorios.CellClick
        btn_eliminar.Enabled = True
    End Sub

    Private Sub txt_Razon_Social_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Razon_Social.TextChanged
        btn_eliminar.Enabled = False
        tablaLab = modulo._leo_tabla("LABORATORIOS", "razon_social LIKE '" & txt_Razon_Social.Text & "%'")
        cargar_grilla(tablaLab)
    End Sub
End Class