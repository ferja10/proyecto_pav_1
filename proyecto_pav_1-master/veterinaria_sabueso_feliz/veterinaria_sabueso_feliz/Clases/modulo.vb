Module modulo


    Dim string_conexion As String = "Provider=SQLOLEDB;Data Source=localhost\sqlexpress;Integrated Security=SSPI;Initial Catalog=proyecto_pav_1"
    ''Dim string_conexion As String = "Provider=SQLNCLI10.1;Integrated Security=SSPI;Persist Security Info=False;User ID="";Initial Catalog=PAV;Data Source=USUARIO-PC\SQLEXPRESS;Initial File Name="";Server SPN="""
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

End Module
