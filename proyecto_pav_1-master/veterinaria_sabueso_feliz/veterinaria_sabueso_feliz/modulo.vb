Module modulo

    Dim string_conexion As String = "Provider=SQLOLEDB;Data Source=localhost\sqlexpress;Integrated Security=SSPI;Initial Catalog=proyecto_pav_1"
    Dim cmd As New OleDb.OleDbCommand
    Dim conexion As New OleDb.OleDbConnection
    Dim dt As New Data.DataTable
    Public sql As String

    Public Sub conectar()
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
        End Try

    End Sub

    Public Function leo_tabla(ByVal tabla As String) As Data.DataTable

        conectar()

        cmd.CommandType = CommandType.Text

        sql = "select * from " & tabla

        cmd.CommandText = sql

        dt.Load(cmd.ExecuteReader())

        cerrar()

        Return dt
    End Function

    Public Sub insert(ByVal instruccion As String)
        conectar()

        Try
            cmd.CommandType = CommandType.Text
            sql = instruccion
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Public Sub update(ByVal instruccion As String)

        Try
            cmd.CommandType = CommandType.Text
            sql = instruccion
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Public Sub delete(ByVal instruccion As String)

        Try
            cmd.CommandType = CommandType.Text
            sql = instruccion
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

End Module
