Imports MySql.Data.MySqlClient
Public Class Form6
    Dim Conexion As New MySqlConnection
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Consulta As String
        Dim Lista As Byte
        If txtboxUser.Text <> "" And txtboxPass.Text <> "" Then
            Consulta = "SELECT * FROM registros where nombre='" & txtboxUser.Text & "' and codigo='" & txtboxPass.Text & "'"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Adaptador.Fill(Datos, "registros")
            Lista = Datos.Tables("registros").Rows.Count


        End If
        If Lista <> 0 Then
            MsgBox("Bienvenido")
        Else
            MsgBox("Intentelo de nuevo")
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=localhost;user=root;password=1982edno;database=tutorial"
            Conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class