<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PRINCIPAL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRINCIPAL))
        Me.tab_sob_fal = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_abonar = New System.Windows.Forms.Button()
        Me.txt_abono = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_buscar_sobfal = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.combo_selec_sobfalt = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.tab_control = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_analista = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.check_cerrar = New System.Windows.Forms.CheckBox()
        Me.txt_chofer = New System.Windows.Forms.TextBox()
        Me.txt_recibidor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Ruta = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_adulto_mayor = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_boleta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_codUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_unidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label_compania = New System.Windows.Forms.Label()
        Me.label_Chofer = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_ruta = New System.Windows.Forms.ComboBox()
        Me.combo_zona = New System.Windows.Forms.ComboBox()
        Me.bt_buscar = New System.Windows.Forms.Button()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.tab_sobrante_faltante = New System.Windows.Forms.TabControl()
        Me.tab_planillas = New System.Windows.Forms.TabPage()
        Me.Tab_mantenimiento = New System.Windows.Forms.TabPage()
        Me.txt_M_nombre = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_M_compañia = New System.Windows.Forms.TextBox()
        Me.txt_M_Código = New System.Windows.Forms.TextBox()
        Me.txt_M_2apellido = New System.Windows.Forms.TextBox()
        Me.txt_M_1apellido = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.tab_sob_fal.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_control.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tab_sobrante_faltante.SuspendLayout()
        Me.Tab_mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_sob_fal
        '
        Me.tab_sob_fal.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tab_sob_fal.Controls.Add(Me.GroupBox4)
        Me.tab_sob_fal.Controls.Add(Me.GroupBox3)
        Me.tab_sob_fal.Location = New System.Drawing.Point(4, 22)
        Me.tab_sob_fal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tab_sob_fal.Name = "tab_sob_fal"
        Me.tab_sob_fal.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tab_sob_fal.Size = New System.Drawing.Size(953, 633)
        Me.tab_sob_fal.TabIndex = 1
        Me.tab_sob_fal.Text = "Sobrantes, Vales"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_abonar)
        Me.GroupBox4.Controls.Add(Me.txt_abono)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(474, 43)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(302, 115)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Abonos"
        '
        'btn_abonar
        '
        Me.btn_abonar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_abonar.Location = New System.Drawing.Point(214, 49)
        Me.btn_abonar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_abonar.Name = "btn_abonar"
        Me.btn_abonar.Size = New System.Drawing.Size(64, 24)
        Me.btn_abonar.TabIndex = 2
        Me.btn_abonar.Text = "Abonar"
        Me.btn_abonar.UseVisualStyleBackColor = True
        '
        'txt_abono
        '
        Me.txt_abono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_abono.Location = New System.Drawing.Point(94, 51)
        Me.txt_abono.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_abono.Name = "txt_abono"
        Me.txt_abono.Size = New System.Drawing.Size(98, 23)
        Me.txt_abono.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(23, 56)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Abono"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.btn_buscar_sobfal)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.combo_selec_sobfalt)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 41)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(422, 435)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(95, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(248, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Busqueda del estado de choferes"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 101)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 17)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Busqueda en general"
        '
        'btn_buscar_sobfal
        '
        Me.btn_buscar_sobfal.BackgroundImage = CType(resources.GetObject("btn_buscar_sobfal.BackgroundImage"), System.Drawing.Image)
        Me.btn_buscar_sobfal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_buscar_sobfal.Location = New System.Drawing.Point(340, 45)
        Me.btn_buscar_sobfal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_buscar_sobfal.Name = "btn_buscar_sobfal"
        Me.btn_buscar_sobfal.Size = New System.Drawing.Size(39, 31)
        Me.btn_buscar_sobfal.TabIndex = 6
        Me.btn_buscar_sobfal.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 47)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 17)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Número de cédula"
        '
        'combo_selec_sobfalt
        '
        Me.combo_selec_sobfalt.FormattingEnabled = True
        Me.combo_selec_sobfalt.Location = New System.Drawing.Point(190, 98)
        Me.combo_selec_sobfalt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.combo_selec_sobfalt.Name = "combo_selec_sobfalt"
        Me.combo_selec_sobfalt.Size = New System.Drawing.Size(134, 21)
        Me.combo_selec_sobfalt.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(175, 45)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 23)
        Me.TextBox1.TabIndex = 4
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(17, 172)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(362, 243)
        Me.DataGridView2.TabIndex = 1
        '
        'tab_control
        '
        Me.tab_control.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tab_control.Controls.Add(Me.Label8)
        Me.tab_control.Controls.Add(Me.GroupBox2)
        Me.tab_control.Controls.Add(Me.Label7)
        Me.tab_control.Controls.Add(Me.DataGridView1)
        Me.tab_control.Controls.Add(Me.GroupBox1)
        Me.tab_control.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_control.Location = New System.Drawing.Point(4, 22)
        Me.tab_control.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tab_control.Name = "tab_control"
        Me.tab_control.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tab_control.Size = New System.Drawing.Size(953, 633)
        Me.tab_control.TabIndex = 0
        Me.tab_control.Text = "Control"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(574, 358)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 18)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "RUTAS REALIZADAS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_analista)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.btn_agregar)
        Me.GroupBox2.Controls.Add(Me.check_cerrar)
        Me.GroupBox2.Controls.Add(Me.txt_chofer)
        Me.GroupBox2.Controls.Add(Me.txt_recibidor)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(390, 115)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(547, 171)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresos de Ruta"
        '
        'txt_analista
        '
        Me.txt_analista.Location = New System.Drawing.Point(248, 96)
        Me.txt_analista.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_analista.Name = "txt_analista"
        Me.txt_analista.Size = New System.Drawing.Size(76, 24)
        Me.txt_analista.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(245, 45)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 18)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "ANALISTA"
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(440, 64)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(87, 28)
        Me.btn_agregar.TabIndex = 6
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'check_cerrar
        '
        Me.check_cerrar.AutoSize = True
        Me.check_cerrar.Location = New System.Drawing.Point(371, 98)
        Me.check_cerrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.check_cerrar.Name = "check_cerrar"
        Me.check_cerrar.Size = New System.Drawing.Size(15, 14)
        Me.check_cerrar.TabIndex = 5
        Me.check_cerrar.UseVisualStyleBackColor = True
        '
        'txt_chofer
        '
        Me.txt_chofer.Location = New System.Drawing.Point(136, 96)
        Me.txt_chofer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_chofer.Name = "txt_chofer"
        Me.txt_chofer.Size = New System.Drawing.Size(76, 24)
        Me.txt_chofer.TabIndex = 4
        '
        'txt_recibidor
        '
        Me.txt_recibidor.Location = New System.Drawing.Point(16, 96)
        Me.txt_recibidor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_recibidor.Name = "txt_recibidor"
        Me.txt_recibidor.Size = New System.Drawing.Size(76, 24)
        Me.txt_recibidor.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(344, 45)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "CERRADO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(133, 45)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "CHOFER"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 45)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "RECIBIDOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(867, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Label7"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(368, 388)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(583, 186)
        Me.DataGridView1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.txt_Ruta)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txt_adulto_mayor)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_boleta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_codUsuario)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_unidad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.label_compania)
        Me.GroupBox1.Controls.Add(Me.label_Chofer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.combo_ruta)
        Me.GroupBox1.Controls.Add(Me.combo_zona)
        Me.GroupBox1.Controls.Add(Me.bt_buscar)
        Me.GroupBox1.Controls.Add(Me.txt_cedula)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(339, 551)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese información del Chofer"
        '
        'txt_Ruta
        '
        Me.txt_Ruta.Location = New System.Drawing.Point(160, 487)
        Me.txt_Ruta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_Ruta.Name = "txt_Ruta"
        Me.txt_Ruta.Size = New System.Drawing.Size(76, 26)
        Me.txt_Ruta.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(25, 485)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Ruta"
        '
        'txt_adulto_mayor
        '
        Me.txt_adulto_mayor.Location = New System.Drawing.Point(160, 444)
        Me.txt_adulto_mayor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_adulto_mayor.Name = "txt_adulto_mayor"
        Me.txt_adulto_mayor.Size = New System.Drawing.Size(76, 26)
        Me.txt_adulto_mayor.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(21, 444)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Aduto Mayor"
        '
        'txt_boleta
        '
        Me.txt_boleta.Location = New System.Drawing.Point(160, 403)
        Me.txt_boleta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_boleta.Name = "txt_boleta"
        Me.txt_boleta.Size = New System.Drawing.Size(76, 26)
        Me.txt_boleta.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 403)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Boleta"
        '
        'txt_codUsuario
        '
        Me.txt_codUsuario.Location = New System.Drawing.Point(160, 365)
        Me.txt_codUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_codUsuario.Name = "txt_codUsuario"
        Me.txt_codUsuario.Size = New System.Drawing.Size(76, 26)
        Me.txt_codUsuario.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 365)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Codigo de Usuario"
        '
        'txt_unidad
        '
        Me.txt_unidad.Location = New System.Drawing.Point(160, 322)
        Me.txt_unidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_unidad.Name = "txt_unidad"
        Me.txt_unidad.Size = New System.Drawing.Size(76, 26)
        Me.txt_unidad.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 322)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Unidad"
        '
        'label_compania
        '
        Me.label_compania.AutoSize = True
        Me.label_compania.Location = New System.Drawing.Point(16, 138)
        Me.label_compania.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_compania.Name = "label_compania"
        Me.label_compania.Size = New System.Drawing.Size(29, 20)
        Me.label_compania.TabIndex = 8
        Me.label_compania.Text = "----"
        '
        'label_Chofer
        '
        Me.label_Chofer.AutoSize = True
        Me.label_Chofer.Location = New System.Drawing.Point(16, 99)
        Me.label_Chofer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_Chofer.Name = "label_Chofer"
        Me.label_Chofer.Size = New System.Drawing.Size(29, 20)
        Me.label_Chofer.TabIndex = 7
        Me.label_Chofer.Text = "----"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 251)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Seleccione la Carrera"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 183)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Seleccione la Zona"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Número de Cédula"
        '
        'combo_ruta
        '
        Me.combo_ruta.FormattingEnabled = True
        Me.combo_ruta.Location = New System.Drawing.Point(16, 280)
        Me.combo_ruta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.combo_ruta.Name = "combo_ruta"
        Me.combo_ruta.Size = New System.Drawing.Size(221, 28)
        Me.combo_ruta.TabIndex = 3
        '
        'combo_zona
        '
        Me.combo_zona.FormattingEnabled = True
        Me.combo_zona.Location = New System.Drawing.Point(16, 205)
        Me.combo_zona.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.combo_zona.Name = "combo_zona"
        Me.combo_zona.Size = New System.Drawing.Size(221, 28)
        Me.combo_zona.TabIndex = 2
        '
        'bt_buscar
        '
        Me.bt_buscar.BackgroundImage = CType(resources.GetObject("bt_buscar.BackgroundImage"), System.Drawing.Image)
        Me.bt_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_buscar.Location = New System.Drawing.Point(258, 91)
        Me.bt_buscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(39, 31)
        Me.bt_buscar.TabIndex = 1
        Me.bt_buscar.UseVisualStyleBackColor = True
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(16, 58)
        Me.txt_cedula.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(221, 26)
        Me.txt_cedula.TabIndex = 0
        '
        'tab_sobrante_faltante
        '
        Me.tab_sobrante_faltante.Controls.Add(Me.tab_control)
        Me.tab_sobrante_faltante.Controls.Add(Me.tab_sob_fal)
        Me.tab_sobrante_faltante.Controls.Add(Me.tab_planillas)
        Me.tab_sobrante_faltante.Controls.Add(Me.Tab_mantenimiento)
        Me.tab_sobrante_faltante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tab_sobrante_faltante.Location = New System.Drawing.Point(9, 10)
        Me.tab_sobrante_faltante.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tab_sobrante_faltante.Name = "tab_sobrante_faltante"
        Me.tab_sobrante_faltante.SelectedIndex = 0
        Me.tab_sobrante_faltante.Size = New System.Drawing.Size(961, 659)
        Me.tab_sobrante_faltante.TabIndex = 0
        '
        'tab_planillas
        '
        Me.tab_planillas.Location = New System.Drawing.Point(4, 22)
        Me.tab_planillas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tab_planillas.Name = "tab_planillas"
        Me.tab_planillas.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tab_planillas.Size = New System.Drawing.Size(953, 633)
        Me.tab_planillas.TabIndex = 2
        Me.tab_planillas.Text = "Planillas"
        Me.tab_planillas.UseVisualStyleBackColor = True
        '
        'Tab_mantenimiento
        '
        Me.Tab_mantenimiento.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Tab_mantenimiento.Controls.Add(Me.txt_M_nombre)
        Me.Tab_mantenimiento.Controls.Add(Me.Label19)
        Me.Tab_mantenimiento.Controls.Add(Me.txt_M_compañia)
        Me.Tab_mantenimiento.Controls.Add(Me.txt_M_Código)
        Me.Tab_mantenimiento.Controls.Add(Me.txt_M_2apellido)
        Me.Tab_mantenimiento.Controls.Add(Me.txt_M_1apellido)
        Me.Tab_mantenimiento.Controls.Add(Me.Label23)
        Me.Tab_mantenimiento.Controls.Add(Me.Label22)
        Me.Tab_mantenimiento.Controls.Add(Me.Label21)
        Me.Tab_mantenimiento.Controls.Add(Me.Label20)
        Me.Tab_mantenimiento.Controls.Add(Me.GroupBox5)
        Me.Tab_mantenimiento.Location = New System.Drawing.Point(4, 22)
        Me.Tab_mantenimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Tab_mantenimiento.Name = "Tab_mantenimiento"
        Me.Tab_mantenimiento.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Tab_mantenimiento.Size = New System.Drawing.Size(953, 633)
        Me.Tab_mantenimiento.TabIndex = 3
        Me.Tab_mantenimiento.Text = "Mantenimiento"
        '
        'txt_M_nombre
        '
        Me.txt_M_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_M_nombre.Location = New System.Drawing.Point(164, 84)
        Me.txt_M_nombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_M_nombre.Name = "txt_M_nombre"
        Me.txt_M_nombre.Size = New System.Drawing.Size(132, 23)
        Me.txt_M_nombre.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(28, 84)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 17)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Nombre "
        '
        'txt_M_compañia
        '
        Me.txt_M_compañia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_M_compañia.Location = New System.Drawing.Point(164, 251)
        Me.txt_M_compañia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_M_compañia.Name = "txt_M_compañia"
        Me.txt_M_compañia.Size = New System.Drawing.Size(132, 23)
        Me.txt_M_compañia.TabIndex = 9
        '
        'txt_M_Código
        '
        Me.txt_M_Código.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_M_Código.Location = New System.Drawing.Point(164, 208)
        Me.txt_M_Código.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_M_Código.Name = "txt_M_Código"
        Me.txt_M_Código.Size = New System.Drawing.Size(132, 23)
        Me.txt_M_Código.TabIndex = 8
        '
        'txt_M_2apellido
        '
        Me.txt_M_2apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_M_2apellido.Location = New System.Drawing.Point(164, 163)
        Me.txt_M_2apellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_M_2apellido.Name = "txt_M_2apellido"
        Me.txt_M_2apellido.Size = New System.Drawing.Size(132, 23)
        Me.txt_M_2apellido.TabIndex = 7
        '
        'txt_M_1apellido
        '
        Me.txt_M_1apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_M_1apellido.Location = New System.Drawing.Point(164, 125)
        Me.txt_M_1apellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_M_1apellido.Name = "txt_M_1apellido"
        Me.txt_M_1apellido.Size = New System.Drawing.Size(132, 23)
        Me.txt_M_1apellido.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(35, 251)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 17)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Compañia"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(33, 213)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 17)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Código "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(33, 166)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 17)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "2° Apellido"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(31, 125)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 17)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "1° Apellido"
        '
        'GroupBox5
        '
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(21, 24)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(328, 275)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos del Chofer"
        '
        'PRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 596)
        Me.Controls.Add(Me.tab_sobrante_faltante)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PRINCIPAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Ingresos"
        Me.tab_sob_fal.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_control.ResumeLayout(False)
        Me.tab_control.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tab_sobrante_faltante.ResumeLayout(False)
        Me.Tab_mantenimiento.ResumeLayout(False)
        Me.Tab_mantenimiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_sob_fal As TabPage
    Friend WithEvents tab_control As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_ruta As ComboBox
    Friend WithEvents combo_zona As ComboBox
    Friend WithEvents bt_buscar As Button
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents tab_sobrante_faltante As TabControl
    Friend WithEvents label_compania As Label
    Friend WithEvents label_Chofer As Label
    Friend WithEvents txt_boleta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_codUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_unidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents check_cerrar As CheckBox
    Friend WithEvents txt_chofer As TextBox
    Friend WithEvents txt_recibidor As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_analista As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents combo_selec_sobfalt As ComboBox
    Friend WithEvents btn_buscar_sobfal As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_adulto_mayor As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents tab_planillas As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_abonar As Button
    Friend WithEvents txt_abono As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_Ruta As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Tab_mantenimiento As TabPage
    Friend WithEvents txt_M_compañia As TextBox
    Friend WithEvents txt_M_Código As TextBox
    Friend WithEvents txt_M_2apellido As TextBox
    Friend WithEvents txt_M_1apellido As TextBox
    Friend WithEvents txt_M_nombre As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox5 As GroupBox
End Class
