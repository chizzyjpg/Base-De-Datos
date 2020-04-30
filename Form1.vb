Imports MySql.Data.MySqlClient
Partial Class Form1
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim conexion As MySqlConnection
        conexion = New MySqlConnection
        Dim cmd As New MySqlCommand
        conexion.ConnectionString = "server=localhost; database=encuesta; Uid=root; Pwd=;"

        Try
            conexion.Open()
            cmd.Connection = conexion

            cmd.CommandText = "INSERT INTO encuesta_series(nombre, apellido, serie_favorita) VALUES (@nombre, @apellido, @serie_favorita)"
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@apellido", txtApellido.Text)
            cmd.Parameters.AddWithValue("@serie_favorita", cbxSerie.Text)
            cmd.ExecuteNonQuery()

            conexion.Close()

            txtApellido.Clear()
            txtNombre.Clear()
            cbxSerie.SelectedIndex = -1
        Catch ex As Exception

        End Try
    End Sub
End Class

