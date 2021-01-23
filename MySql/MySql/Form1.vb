Imports MySql.Data.MySqlClient
Public Class Form1
    Dim Conexion As New MySqlConnection
    Dim Comandos As New MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Comandos = New MySqlCommand("INSERT INTO registros(codigo,nombre)" & Chr(13) &
                "VALUES(@codigo,@nombre)", Conexion)
            Comandos.Parameters.AddWithValue("@codigo", txtboxCodigo.Text)
            Comandos.Parameters.AddWithValue("@nombre", txtboxNombre.Text)
            Comandos.ExecuteNonQuery()
            txtboxCodigo.Text = ""
            txtboxNombre.Text = ""
            txtboxCodigo.Select()
            MsgBox("Datos Guardados")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form6.Show()
        Me.Close()
    End Sub
End Class
