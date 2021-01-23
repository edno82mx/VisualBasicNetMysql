<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtboxNombre = New System.Windows.Forms.TextBox()
        Me.txtboxCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtboxBuscar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TablaDeDatos = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.TablaDeDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtboxNombre
        '
        Me.txtboxNombre.Enabled = False
        Me.txtboxNombre.Location = New System.Drawing.Point(127, 73)
        Me.txtboxNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxNombre.Name = "txtboxNombre"
        Me.txtboxNombre.Size = New System.Drawing.Size(102, 20)
        Me.txtboxNombre.TabIndex = 8
        Me.txtboxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxCodigo
        '
        Me.txtboxCodigo.Enabled = False
        Me.txtboxCodigo.Location = New System.Drawing.Point(127, 52)
        Me.txtboxCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxCodigo.Name = "txtboxCodigo"
        Me.txtboxCodigo.Size = New System.Drawing.Size(102, 20)
        Me.txtboxCodigo.TabIndex = 7
        Me.txtboxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Codigo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 119)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 19)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtboxBuscar
        '
        Me.txtboxBuscar.Location = New System.Drawing.Point(127, 31)
        Me.txtboxBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtboxBuscar.Name = "txtboxBuscar"
        Me.txtboxBuscar.Size = New System.Drawing.Size(102, 20)
        Me.txtboxBuscar.TabIndex = 14
        Me.txtboxBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 33)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Buscar"
        '
        'TablaDeDatos
        '
        Me.TablaDeDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.TablaDeDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.TablaDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDeDatos.Location = New System.Drawing.Point(12, 155)
        Me.TablaDeDatos.Name = "TablaDeDatos"
        Me.TablaDeDatos.Size = New System.Drawing.Size(250, 128)
        Me.TablaDeDatos.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(148, 119)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 19)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 308)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TablaDeDatos)
        Me.Controls.Add(Me.txtboxBuscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtboxNombre)
        Me.Controls.Add(Me.txtboxCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySql"
        CType(Me.TablaDeDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxNombre As TextBox
    Friend WithEvents txtboxCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtboxBuscar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TablaDeDatos As DataGridView
    Friend WithEvents Button2 As Button
End Class
