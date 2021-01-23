Imports MySql.Data.MySqlClient
Public Class Form5
    Dim Conexion As New MySqlConnection
    Dim Datos As DataSet
    Dim Adaptador As MySqlDataAdapter
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=localhost;user=root;password=1982edno;database=tutorial"
            Conexion.Open()
            Dim Consulta As String
            Consulta = "SELECT codigo, nombre FROM registros"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Adaptador.Fill(Datos, "registros")
            DataGridView1.DataSource = Datos
            DataGridView1.DataMember = "registros"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class