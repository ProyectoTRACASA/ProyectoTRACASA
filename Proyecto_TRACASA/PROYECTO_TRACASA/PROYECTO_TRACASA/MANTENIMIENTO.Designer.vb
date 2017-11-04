<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MANTENIMIENTO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_M_choferes = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_M_modificar = New System.Windows.Forms.Button()
        Me.btn_M_eliminar = New System.Windows.Forms.Button()
        Me.btn_M_agregar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_M_cedula = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_M_compania = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_M_codigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_M_boleta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_M_nombre = New System.Windows.Forms.TextBox()
        Me.txt_M_folio = New System.Windows.Forms.TextBox()
        Me.txt_M_1apellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_M_2apellido = New System.Windows.Forms.TextBox()
        Me.tab_M_usuario = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.tab_M_choferes.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_M_choferes)
        Me.TabControl1.Controls.Add(Me.tab_M_usuario)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1355, 835)
        Me.TabControl1.TabIndex = 0
        '
        'tab_M_choferes
        '
        Me.tab_M_choferes.BackColor = System.Drawing.Color.Transparent
        Me.tab_M_choferes.Controls.Add(Me.Label10)
        Me.tab_M_choferes.Controls.Add(Me.DataGridView1)
        Me.tab_M_choferes.Controls.Add(Me.btn_M_modificar)
        Me.tab_M_choferes.Controls.Add(Me.btn_M_eliminar)
        Me.tab_M_choferes.Controls.Add(Me.btn_M_agregar)
        Me.tab_M_choferes.Controls.Add(Me.Button1)
        Me.tab_M_choferes.Controls.Add(Me.GroupBox2)
        Me.tab_M_choferes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_M_choferes.Location = New System.Drawing.Point(4, 25)
        Me.tab_M_choferes.Name = "tab_M_choferes"
        Me.tab_M_choferes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_M_choferes.Size = New System.Drawing.Size(1347, 806)
        Me.tab_M_choferes.TabIndex = 0
        Me.tab_M_choferes.Text = "CHOFERES"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(794, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(250, 22)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "DATOS DE LOS CHOFERES"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(602, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(722, 153)
        Me.DataGridView1.TabIndex = 22
        '
        'btn_M_modificar
        '
        Me.btn_M_modificar.Location = New System.Drawing.Point(880, 277)
        Me.btn_M_modificar.Name = "btn_M_modificar"
        Me.btn_M_modificar.Size = New System.Drawing.Size(148, 52)
        Me.btn_M_modificar.TabIndex = 21
        Me.btn_M_modificar.Text = "MODIFICAR"
        Me.btn_M_modificar.UseVisualStyleBackColor = True
        '
        'btn_M_eliminar
        '
        Me.btn_M_eliminar.Location = New System.Drawing.Point(1098, 277)
        Me.btn_M_eliminar.Name = "btn_M_eliminar"
        Me.btn_M_eliminar.Size = New System.Drawing.Size(148, 52)
        Me.btn_M_eliminar.TabIndex = 20
        Me.btn_M_eliminar.Text = "ELIMINAR"
        Me.btn_M_eliminar.UseVisualStyleBackColor = True
        '
        'btn_M_agregar
        '
        Me.btn_M_agregar.Location = New System.Drawing.Point(650, 277)
        Me.btn_M_agregar.Name = "btn_M_agregar"
        Me.btn_M_agregar.Size = New System.Drawing.Size(148, 52)
        Me.btn_M_agregar.TabIndex = 19
        Me.btn_M_agregar.Text = "AGREGAR"
        Me.btn_M_agregar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 710)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 74)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ATRÁS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.RosyBrown
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_M_cedula)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_M_compania)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_M_codigo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_M_boleta)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_M_nombre)
        Me.GroupBox2.Controls.Add(Me.txt_M_folio)
        Me.GroupBox2.Controls.Add(Me.txt_M_1apellido)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_M_2apellido)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(548, 478)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(97, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(247, 27)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Ingrese datos del Chofer"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 408)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 22)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Compañia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 22)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Boleta"
        '
        'txt_M_cedula
        '
        Me.txt_M_cedula.Location = New System.Drawing.Point(293, 43)
        Me.txt_M_cedula.Name = "txt_M_cedula"
        Me.txt_M_cedula.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_cedula.TabIndex = 11
        Me.txt_M_cedula.Text = "123"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Número de Folio"
        '
        'txt_M_compania
        '
        Me.txt_M_compania.Location = New System.Drawing.Point(293, 400)
        Me.txt_M_compania.Name = "txt_M_compania"
        Me.txt_M_compania.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_compania.TabIndex = 16
        Me.txt_M_compania.Text = "hjk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Segundo Apellido"
        '
        'txt_M_codigo
        '
        Me.txt_M_codigo.Location = New System.Drawing.Point(293, 93)
        Me.txt_M_codigo.Name = "txt_M_codigo"
        Me.txt_M_codigo.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_codigo.TabIndex = 10
        Me.txt_M_codigo.Text = "123"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Primer Apellido"
        '
        'txt_M_boleta
        '
        Me.txt_M_boleta.Location = New System.Drawing.Point(293, 348)
        Me.txt_M_boleta.Name = "txt_M_boleta"
        Me.txt_M_boleta.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_boleta.TabIndex = 15
        Me.txt_M_boleta.Text = "123"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'txt_M_nombre
        '
        Me.txt_M_nombre.Location = New System.Drawing.Point(293, 146)
        Me.txt_M_nombre.Name = "txt_M_nombre"
        Me.txt_M_nombre.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_nombre.TabIndex = 9
        Me.txt_M_nombre.Text = "asd"
        '
        'txt_M_folio
        '
        Me.txt_M_folio.Location = New System.Drawing.Point(293, 300)
        Me.txt_M_folio.Name = "txt_M_folio"
        Me.txt_M_folio.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_folio.TabIndex = 14
        Me.txt_M_folio.Text = "123"
        '
        'txt_M_1apellido
        '
        Me.txt_M_1apellido.Location = New System.Drawing.Point(293, 198)
        Me.txt_M_1apellido.Name = "txt_M_1apellido"
        Me.txt_M_1apellido.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_1apellido.TabIndex = 12
        Me.txt_M_1apellido.Text = "asd"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de cédula"
        '
        'txt_M_2apellido
        '
        Me.txt_M_2apellido.Location = New System.Drawing.Point(293, 248)
        Me.txt_M_2apellido.Name = "txt_M_2apellido"
        Me.txt_M_2apellido.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_2apellido.TabIndex = 13
        Me.txt_M_2apellido.Text = "asd"
        '
        'tab_M_usuario
        '
        Me.tab_M_usuario.Location = New System.Drawing.Point(4, 25)
        Me.tab_M_usuario.Name = "tab_M_usuario"
        Me.tab_M_usuario.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_M_usuario.Size = New System.Drawing.Size(1347, 806)
        Me.tab_M_usuario.TabIndex = 1
        Me.tab_M_usuario.Text = "USUARIOS"
        Me.tab_M_usuario.UseVisualStyleBackColor = True
        '
        'MANTENIMIENTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 844)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MANTENIMIENTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANTENIMIENTO"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_M_choferes.ResumeLayout(False)
        Me.tab_M_choferes.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_M_choferes As TabPage
    Friend WithEvents tab_M_usuario As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_M_compania As TextBox
    Friend WithEvents txt_M_boleta As TextBox
    Friend WithEvents txt_M_folio As TextBox
    Friend WithEvents txt_M_2apellido As TextBox
    Friend WithEvents txt_M_1apellido As TextBox
    Friend WithEvents txt_M_cedula As TextBox
    Friend WithEvents txt_M_codigo As TextBox
    Friend WithEvents txt_M_nombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_M_modificar As Button
    Friend WithEvents btn_M_eliminar As Button
    Friend WithEvents btn_M_agregar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
End Class
