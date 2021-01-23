Imports MySql.Data.MySqlClient
Public Class Form2
    Dim Conexion As New MySqlConnection
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As DataSet
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=localhost;user=root;password=1982edno;database=tutorial"
            Conexion.Open()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            txtboxNombre.Enabled = False
            txtboxCodigo.Enabled = False
            Button1.Enabled = False
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Consulta As String
        Dim Lista As Byte
        If txtboxBuscar.Text <> "" Then
            Consulta = "SELECT * FROM registros WHERE codigo='" & txtboxBuscar.Text & "'"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Adaptador.Fill(Datos, "registros")
            Lista = Datos.Tables("registros").Rows.Count
        End If
        If Lista <> 0 Then
            txtboxCodigo.Text = Datos.Tables("registros").Rows(0).Item("codigo")
            txtboxNombre.Text = Datos.Tables("registros").Rows(0).Item("nombre")
        Else
            txtboxBuscar.Text = ""
            txtboxBuscar.Select()
            MsgBox("Datos no encontrados")
            txtboxCodigo.Text = ""
            txtboxNombre.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Consulta As String
        Dim Lista As Byte
        If txtboxBuscar.Text <> "" Then
            Consulta = "SELECT codigo, nombre FROM registros WHERE codigo='" & txtboxBuscar.Text & "'"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Adaptador.Fill(Datos, "registros")
            Lista = Datos.Tables("registros").Rows.Count
        End If
        If Lista <> 0 Then
            TablaDeDatos.DataSource = Datos
            TablaDeDatos.DataMember = "registros"
        Else
            txtboxBuscar.Text = ""
            txtboxBuscar.Select()
            MsgBox("Datos no encontrados")
            txtboxCodigo.Text = ""
            txtboxNombre.Text = ""
        End If
    End Sub
End Class