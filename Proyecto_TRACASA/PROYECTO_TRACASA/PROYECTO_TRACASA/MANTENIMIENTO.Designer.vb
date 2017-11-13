<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MANTENIMIENTO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MANTENIMIENTO))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_M_choferes = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_M_buscar = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.datagridchoferes = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_M_idchofer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_M_cedula = New System.Windows.Forms.TextBox()
        Me.btn_M_eliminar = New System.Windows.Forms.Button()
        Me.btn_M_modificar = New System.Windows.Forms.Button()
        Me.txt_M_nombre = New System.Windows.Forms.TextBox()
        Me.txt_M_folio = New System.Windows.Forms.TextBox()
        Me.txt_M_1apellido = New System.Windows.Forms.TextBox()
        Me.txt_M_2apellido = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_M_agregar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_M_compania = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_M_usuario = New System.Windows.Forms.TabPage()
        Me.datagridusuarios = New System.Windows.Forms.DataGridView()
        Me.btn_agregar_usu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.combo_usuario = New System.Windows.Forms.ComboBox()
        Me.txt_contra = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tab_M_choferes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.datagridchoferes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tab_M_usuario.SuspendLayout()
        CType(Me.datagridusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.tab_M_choferes.Controls.Add(Me.PictureBox1)
        Me.tab_M_choferes.Controls.Add(Me.GroupBox3)
        Me.tab_M_choferes.Controls.Add(Me.Button2)
        Me.tab_M_choferes.Controls.Add(Me.Label10)
        Me.tab_M_choferes.Controls.Add(Me.datagridchoferes)
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 615)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1348, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.RosyBrown
        Me.GroupBox3.Controls.Add(Me.btn_buscar)
        Me.GroupBox3.Controls.Add(Me.txt_M_buscar)
        Me.GroupBox3.Location = New System.Drawing.Point(650, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(440, 123)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese Numero de Cedula"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(337, 60)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(80, 31)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_M_buscar
        '
        Me.txt_M_buscar.Location = New System.Drawing.Point(19, 60)
        Me.txt_M_buscar.Name = "txt_M_buscar"
        Me.txt_M_buscar.Size = New System.Drawing.Size(297, 30)
        Me.txt_M_buscar.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(988, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 30)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Cargar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(646, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(250, 22)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "DATOS DE LOS CHOFERES"
        '
        'datagridchoferes
        '
        Me.datagridchoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridchoferes.Location = New System.Drawing.Point(650, 204)
        Me.datagridchoferes.Name = "datagridchoferes"
        Me.datagridchoferes.RowTemplate.Height = 24
        Me.datagridchoferes.Size = New System.Drawing.Size(681, 390)
        Me.datagridchoferes.TabIndex = 22
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
        Me.GroupBox2.Controls.Add(Me.txt_M_idchofer)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_M_cedula)
        Me.GroupBox2.Controls.Add(Me.btn_M_eliminar)
        Me.GroupBox2.Controls.Add(Me.btn_M_modificar)
        Me.GroupBox2.Controls.Add(Me.txt_M_nombre)
        Me.GroupBox2.Controls.Add(Me.txt_M_folio)
        Me.GroupBox2.Controls.Add(Me.txt_M_1apellido)
        Me.GroupBox2.Controls.Add(Me.txt_M_2apellido)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btn_M_agregar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_M_compania)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(557, 588)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'txt_M_idchofer
        '
        Me.txt_M_idchofer.Location = New System.Drawing.Point(293, 40)
        Me.txt_M_idchofer.Name = "txt_M_idchofer"
        Me.txt_M_idchofer.Size = New System.Drawing.Size(100, 30)
        Me.txt_M_idchofer.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 22)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "ID del Chofer"
        '
        'txt_M_cedula
        '
        Me.txt_M_cedula.Location = New System.Drawing.Point(293, 90)
        Me.txt_M_cedula.Name = "txt_M_cedula"
        Me.txt_M_cedula.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_cedula.TabIndex = 11
        '
        'btn_M_eliminar
        '
        Me.btn_M_eliminar.Location = New System.Drawing.Point(378, 474)
        Me.btn_M_eliminar.Name = "btn_M_eliminar"
        Me.btn_M_eliminar.Size = New System.Drawing.Size(141, 45)
        Me.btn_M_eliminar.TabIndex = 20
        Me.btn_M_eliminar.Text = "ELIMINAR"
        Me.btn_M_eliminar.UseVisualStyleBackColor = True
        '
        'btn_M_modificar
        '
        Me.btn_M_modificar.Location = New System.Drawing.Point(201, 474)
        Me.btn_M_modificar.Name = "btn_M_modificar"
        Me.btn_M_modificar.Size = New System.Drawing.Size(143, 45)
        Me.btn_M_modificar.TabIndex = 21
        Me.btn_M_modificar.Text = "MODIFICAR"
        Me.btn_M_modificar.UseVisualStyleBackColor = True
        '
        'txt_M_nombre
        '
        Me.txt_M_nombre.Location = New System.Drawing.Point(293, 142)
        Me.txt_M_nombre.Name = "txt_M_nombre"
        Me.txt_M_nombre.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_nombre.TabIndex = 9
        '
        'txt_M_folio
        '
        Me.txt_M_folio.Location = New System.Drawing.Point(293, 296)
        Me.txt_M_folio.Name = "txt_M_folio"
        Me.txt_M_folio.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_folio.TabIndex = 14
        '
        'txt_M_1apellido
        '
        Me.txt_M_1apellido.Location = New System.Drawing.Point(293, 194)
        Me.txt_M_1apellido.Name = "txt_M_1apellido"
        Me.txt_M_1apellido.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_1apellido.TabIndex = 12
        '
        'txt_M_2apellido
        '
        Me.txt_M_2apellido.Location = New System.Drawing.Point(293, 244)
        Me.txt_M_2apellido.Name = "txt_M_2apellido"
        Me.txt_M_2apellido.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_2apellido.TabIndex = 13
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
        Me.Label8.Location = New System.Drawing.Point(36, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 22)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Compañia"
        '
        'btn_M_agregar
        '
        Me.btn_M_agregar.Location = New System.Drawing.Point(24, 474)
        Me.btn_M_agregar.Name = "btn_M_agregar"
        Me.btn_M_agregar.Size = New System.Drawing.Size(132, 45)
        Me.btn_M_agregar.TabIndex = 19
        Me.btn_M_agregar.Text = "AGREGAR"
        Me.btn_M_agregar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Número de Folio"
        '
        'txt_M_compania
        '
        Me.txt_M_compania.Location = New System.Drawing.Point(293, 340)
        Me.txt_M_compania.Name = "txt_M_compania"
        Me.txt_M_compania.Size = New System.Drawing.Size(214, 30)
        Me.txt_M_compania.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Segundo Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Primer Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de cédula"
        '
        'tab_M_usuario
        '
        Me.tab_M_usuario.Controls.Add(Me.datagridusuarios)
        Me.tab_M_usuario.Controls.Add(Me.btn_agregar_usu)
        Me.tab_M_usuario.Controls.Add(Me.GroupBox1)
        Me.tab_M_usuario.Location = New System.Drawing.Point(4, 25)
        Me.tab_M_usuario.Name = "tab_M_usuario"
        Me.tab_M_usuario.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_M_usuario.Size = New System.Drawing.Size(1347, 806)
        Me.tab_M_usuario.TabIndex = 1
        Me.tab_M_usuario.Text = "USUARIOS"
        Me.tab_M_usuario.UseVisualStyleBackColor = True
        '
        'datagridusuarios
        '
        Me.datagridusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridusuarios.Location = New System.Drawing.Point(609, 52)
        Me.datagridusuarios.Name = "datagridusuarios"
        Me.datagridusuarios.RowTemplate.Height = 24
        Me.datagridusuarios.Size = New System.Drawing.Size(431, 172)
        Me.datagridusuarios.TabIndex = 2
        '
        'btn_agregar_usu
        '
        Me.btn_agregar_usu.Location = New System.Drawing.Point(741, 299)
        Me.btn_agregar_usu.Name = "btn_agregar_usu"
        Me.btn_agregar_usu.Size = New System.Drawing.Size(204, 50)
        Me.btn_agregar_usu.TabIndex = 1
        Me.btn_agregar_usu.Text = "Button2"
        Me.btn_agregar_usu.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.combo_usuario)
        Me.GroupBox1.Controls.Add(Me.txt_contra)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(65, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 344)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 19)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "CONTRASEÑA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 19)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "TIPO DE ZONA"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"GUAPILES", "SIQUIRRES", "LIMON"})
        Me.ComboBox1.Location = New System.Drawing.Point(233, 145)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 27)
        Me.ComboBox1.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 19)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "TIPO DE USUARIO"
        '
        'combo_usuario
        '
        Me.combo_usuario.FormattingEnabled = True
        Me.combo_usuario.Items.AddRange(New Object() {"ADMINISTRADOR", "RECIBIDOR"})
        Me.combo_usuario.Location = New System.Drawing.Point(233, 73)
        Me.combo_usuario.Name = "combo_usuario"
        Me.combo_usuario.Size = New System.Drawing.Size(197, 27)
        Me.combo_usuario.TabIndex = 3
        '
        'txt_contra
        '
        Me.txt_contra.Location = New System.Drawing.Point(233, 216)
        Me.txt_contra.Name = "txt_contra"
        Me.txt_contra.Size = New System.Drawing.Size(197, 27)
        Me.txt_contra.TabIndex = 1
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.datagridchoferes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tab_M_usuario.ResumeLayout(False)
        CType(Me.datagridusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_M_choferes As TabPage
    Friend WithEvents tab_M_usuario As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_M_compania As TextBox
    Friend WithEvents txt_M_folio As TextBox
    Friend WithEvents txt_M_2apellido As TextBox
    Friend WithEvents txt_M_1apellido As TextBox
    Friend WithEvents txt_M_cedula As TextBox
    Friend WithEvents txt_M_nombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_M_modificar As Button
    Friend WithEvents btn_M_eliminar As Button
    Friend WithEvents btn_M_agregar As Button
    Friend WithEvents datagridchoferes As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_agregar_usu As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_contra As TextBox
    Friend WithEvents datagridusuarios As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_M_buscar As TextBox
    Friend WithEvents combo_usuario As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_M_idchofer As TextBox
    Friend WithEvents Label7 As Label
End Class
