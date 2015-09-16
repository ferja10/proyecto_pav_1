Public Class Alta_Laboratorios
    Dim tablaLab As Data.DataTable
    Private Sub Alta_Laboratorios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_eliminar.Enabled = False
        tablaLab = modulo._leo_tabla("LABORATORIOS")
        cargar_grilla(tablaLab)
    End Sub
    Private Sub cargar_grilla(ByVal tabla As Data.DataTable)
        dgc_Laboratorios.DataSource = tabla
        dgc_Laboratorios.Columns("Id").Visible = False
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        panel_Alta.Visible = True
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        'alvertencia
        PanelGrilla.Visible = True
        panel_Alta.Visible = False
    End Sub

    Private Sub btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Aceptar.Click
        'validaciones
        'lectura
        'Cargar
        PanelGrilla.Visible = True
        panel_Alta.Visible = False
    End Sub
End Class