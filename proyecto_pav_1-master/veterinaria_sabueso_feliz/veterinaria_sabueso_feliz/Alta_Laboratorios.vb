Public Class Alta_Laboratorios

    Private Sub Alta_Laboratorios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_eliminar.Enabled = False
        cargar_grilla()

    End Sub
    Private Sub cargar_grilla(ByVal tabla As Data.DataTable)

        dgc_Laboratorios.DataSource = tabla
    End Sub
End Class