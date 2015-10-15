Module modulo

    'Dim string_conexion As String = "Provider=SQLOLEDB;Data Source=localhost\sqlexpress;Integrated Security=SSPI;Initial Catalog=proyecto_pav_1"
    Dim string_conexion As String = "Provider=SQLNCLI10.1;Data Source=USUARIO-PC\SQLEXPRESS;Initial Catalog=PAV;Integrated Security=SSPI"
    Dim cmd As OleDb.OleDbCommand
    Dim conexion As OleDb.OleDbConnection
    Dim dt As Data.DataTable
    Public sql As String
    Public sucursal As Integer
    Public clave As Boolean

    Public Sub conectar()

        conexion = New OleDb.OleDbConnection
        cmd = New OleDb.OleDbCommand
        dt = New Data.DataTable

        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            conexion.Close()
        End Try

    End Sub

    Public Sub cerrar()

        Try
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conexion.Close()
        End Try

    End Sub

    Public Function _leo_tabla(ByVal tabla As String) As Data.DataTable

        conectar()
        Try
            cmd.CommandType = CommandType.Text

            sql = "select * from " & tabla

            cmd.CommandText = sql

            dt.Load(cmd.ExecuteReader())

            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        Return dt

    End Function

    Public Function _leo_tabla(ByVal tabla As String, ByVal restriccion As String) As Data.DataTable

        conectar()
        Try
            cmd.CommandType = CommandType.Text

            sql = "select * from " & tabla & " where " & restriccion

            cmd.CommandText = sql

            dt.Load(cmd.ExecuteReader())

            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

        Return dt

    End Function

    Public Function _leo_tabla(ByVal columnas As String, ByVal tabla As String, ByVal restriccion As String) As Data.DataTable

        conectar()
        Try
            cmd.CommandType = CommandType.Text

            sql = "select " & columnas & " from " & tabla
            If Not restriccion.Trim = "" Then
                sql &= " where " & restriccion
            End If

            cmd.CommandText = sql

            dt.Load(cmd.ExecuteReader())

            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

        Return dt

    End Function

    Public Sub _consulta(ByVal comando As String, ByRef _tabla As Data.DataTable)
        conectar()
        cmd.CommandText = comando
        _tabla.Load(cmd.ExecuteReader())
        conexion.Close()
    End Sub

    Public Function _insertar(ByVal instruccion As String) As Boolean
        conectar()

        Try
            cmd.CommandType = CommandType.Text
            sql = instruccion
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cerrar()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cerrar()
            Return False
        End Try

    End Function

    Public Function _modificar(ByVal instruccion As String) As Boolean
        conectar()
        Try
            cmd.CommandType = CommandType.Text
            sql = instruccion
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cerrar()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cerrar()
            Return False
        End Try

    End Function

    Public Function _eliminar(ByVal instruccion As String) As Boolean
        conectar()
        Try
            cmd.CommandType = CommandType.Text
            sql = instruccion
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cerrar()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cerrar()
            Return False
        End Try

    End Function

    Public Sub _cargar_grilla(ByVal grilla As DataGridView, ByVal tabla As Data.DataTable)

        grilla.DataSource = tabla

    End Sub

    Public Sub _cargar_combo(ByVal combo As ComboBox, ByVal tabla As Data.DataTable, ByVal pk As String, ByVal descripcion As String)

        combo.DataSource = tabla
        combo.ValueMember = pk
        combo.DisplayMember = descripcion

    End Sub

    Public Sub mostrar_sucursal(ByVal lbl As Label)

        If sucursal = 1 Then
            lbl.Text = "CASA CENTRAL"
        Else
            lbl.Text = "SUCURSAL " & sucursal
        End If

    End Sub

    Public Function valorId(ByVal tabla As String, ByVal id As String) As Integer
        Dim _tabla As New Data.DataTable
        Dim valor As String
        modulo._consulta("SELECT MAX(" & id & ") AS ID FROM " & tabla, _tabla)
        If IsDBNull(_tabla.Rows(0)(0)) Then
            valor = 1
        Else
            valor = _tabla.Rows(0)(0) + 1
        End If
        Return valor
    End Function

    Public Function valorId(ByVal tabla As String, ByVal id As String, ByVal restricionHAVIN As String) As Integer
        Dim _tabla As New Data.DataTable
        Dim valor As String
        modulo._consulta("SELECT MAX(" & id & ") AS ID FROM " & tabla & restricionHAVIN, _tabla)
        If _tabla.Rows.Count = 0 Then
            valor = 1
        Else
            valor = _tabla.Rows(0)(0).ToString + 1
        End If
        Return valor
    End Function

    Public Function Existe(tabla As String, ByVal condicion As String) As Boolean
        Dim _tabla As New Data.DataTable
        _tabla = _leo_tabla(tabla, condicion)
        If _tabla.Rows.Count() > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Module
