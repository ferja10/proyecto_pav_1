Module modulo

    Dim string_conexion As String = "Provider=SQLOLEDB;Data Source=localhost\sqlexpress;Integrated Security=SSPI;Initial Catalog=proyecto_pav_1"
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

    Public Sub cargar_grilla(ByVal grilla As DataGridView, ByVal tabla As Data.DataTable)

        grilla.DataSource = tabla

    End Sub

    Public Sub cargar_combo(ByVal combo As ComboBox, ByVal tabla As Data.DataTable, ByVal pk As String, ByVal descripcion As String)

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

End Module
