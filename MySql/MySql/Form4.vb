Imports MySql.Data.MySqlClient
Public Class Form4
    Dim Conexion As New MySqlConnection
    Dim Datos As DataSet
    Dim Adaptador As MySqlDataAdapter
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=localhost;user=root;password=1982edno;database=tutorial"
            Conexion.Open()
            Dim Consulta As String
            Consulta = "SELECT * FROM registros"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Datos.Tables.Add("registros")
            Adaptador.Fill(Datos.Tables("registros"))
            ComboBox1.DataSource = Datos.Tables("registros")
            ComboBox1.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class