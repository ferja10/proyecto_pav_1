Public Class busqueda

    Dim tabla As String
    Dim pk As String
    Dim descripcion As String
    Dim restriccion As String

    Public Property _nuevo_visible() As Boolean
        Get
            Return Me.btn_nuevo.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.btn_nuevo.Visible = value
        End Set
    End Property

    Public Property _etiqueta() As String
        Get
            Return Me.lbl_etiqueta.Text
        End Get
        Set(ByVal value As String)
            Me.lbl_etiqueta.Text = value
        End Set
    End Property

    Public Property _tabla() As String
        Get
            Return Me.tabla
        End Get
        Set(ByVal value As String)
            Me.tabla = value
        End Set
    End Property

    Public Property _pk() As String
        Get
            Return Me.pk
        End Get
        Set(ByVal value As String)
            Me.pk = value
        End Set
    End Property

    Public Property _descripcion() As String
        Get
            Return Me.descripcion
        End Get
        Set(ByVal value As String)
            Me.descripcion = value
        End Set
    End Property

    Public Property _restriccion() As String
        Get
            Return Me.restriccion
        End Get
        Set(value As String)
            Me.restriccion = value
        End Set
    End Property

    Private Sub txt_nombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_nombre.TextChanged
        If Me.txt_nombre.Text = "" Then
            Exit Sub
        End If
        Me.buscar_dato(Me.restriccion)
    End Sub

    Private Sub buscar_dato(ByVal restriccion As String)
        Dim dt As New Data.DataTable
        dt = _leo_tabla(Me.tabla, restriccion)

        Select Case dt.Rows.Count
            Case 1

                Me.txt_nombre.Text = dt.Rows(0)(Me.descripcion)

            Case 0

                _cargar_combo(combo, _leo_tabla(tabla), Me.pk, Me.descripcion)
                Me.cambio_estado()
                Me.combo.SelectedIndex = 0

            Case Else

                _cargar_combo(combo, _leo_tabla(tabla), pk, descripcion)
                Me.cambio_estado()
                Me.combo.SelectedIndex = 0

        End Select
    End Sub

    Private Sub _cmb_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        _cargar_combo(combo, _leo_tabla(Me.tabla, Me.restriccion), pk, descripcion)
        Me.cambio_estado()
    End Sub

    Private Sub cambio_estado()

        If combo.Visible = False Then
            Me.btn_buscar.Visible = False
            Me.btn_nuevo.Visible = False
            Me.txt_nombre.Visible = False
            Me.combo.Visible = True
            Me.combo.DroppedDown = True
        Else
            Me.btn_buscar.Visible = True
            Me.txt_nombre.Visible = True
            Me.combo.Visible = False
        End If
    End Sub

    Private Sub _cmb_combo_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo.SelectionChangeCommitted
        Me.txt_nombre.Text = sender.selectedValue
        Me.cambio_estado()
    End Sub

    Private Sub txt_nombre_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress

        If IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
        End If

    End Sub
End Class
