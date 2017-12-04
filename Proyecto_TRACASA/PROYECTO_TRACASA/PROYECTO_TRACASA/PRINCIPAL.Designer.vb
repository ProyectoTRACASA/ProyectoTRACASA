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
        Me.btnCargarAbo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_abonar = New System.Windows.Forms.Button()
        Me.txt_abono = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCalAbo = New System.Windows.Forms.Button()
        Me.txtBonificacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSobrantes = New System.Windows.Forms.TextBox()
        Me.txtVales = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_buscar_sobfal = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_Usu_Abono = New System.Windows.Forms.TextBox()
        Me.DGAbo = New System.Windows.Forms.DataGridView()
        Me.tab_control = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbCodU = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lbCostoP = New System.Windows.Forms.Label()
        Me.txtCostoPasaj = New System.Windows.Forms.TextBox()
        Me.lbCanPasa = New System.Windows.Forms.Label()
        Me.txtPasaj = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_MEntregado = New System.Windows.Forms.TextBox()
        Me.txt_cod_Usuario = New System.Windows.Forms.TextBox()
        Me.bt_buscar = New System.Windows.Forms.Button()
        Me.txt_MEntregar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_adulto_mayor = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbHoraLo = New System.Windows.Forms.Label()
        Me.btn_cargarc = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGControl = New System.Windows.Forms.DataGridView()
        Me.lbAtras = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpLLenaControl = New System.Windows.Forms.GroupBox()
        Me.txtAP = New System.Windows.Forms.TextBox()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.lbCodig = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.txtced = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbx_carrera = New System.Windows.Forms.ComboBox()
        Me.lbRuta = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lb_Hora_Fecha = New System.Windows.Forms.Label()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.label_cedula = New System.Windows.Forms.Label()
        Me.lbUnid = New System.Windows.Forms.Label()
        Me.txt_unidad = New System.Windows.Forms.TextBox()
        Me.txt_Ruta = New System.Windows.Forms.TextBox()
        Me.label_nom_Chofer = New System.Windows.Forms.Label()
        Me.tabAbonos = New System.Windows.Forms.TabControl()
        Me.tab_planillas = New System.Windows.Forms.TabPage()
        Me.tab_sob_fal.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGAbo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_control.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLLenaControl.SuspendLayout()
        Me.tabAbonos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_sob_fal
        '
        Me.tab_sob_fal.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tab_sob_fal.Controls.Add(Me.btnCargarAbo)
        Me.tab_sob_fal.Controls.Add(Me.Button2)
        Me.tab_sob_fal.Controls.Add(Me.PictureBox2)
        Me.tab_sob_fal.Controls.Add(Me.GroupBox4)
        Me.tab_sob_fal.Controls.Add(Me.GroupBox3)
        Me.tab_sob_fal.Controls.Add(Me.DGAbo)
        Me.tab_sob_fal.Location = New System.Drawing.Point(4, 28)
        Me.tab_sob_fal.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_sob_fal.Name = "tab_sob_fal"
        Me.tab_sob_fal.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_sob_fal.Size = New System.Drawing.Size(1040, 842)
        Me.tab_sob_fal.TabIndex = 1
        Me.tab_sob_fal.Text = "Abonos"
        '
        'btnCargarAbo
        '
        Me.btnCargarAbo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarAbo.Location = New System.Drawing.Point(484, 245)
        Me.btnCargarAbo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCargarAbo.Name = "btnCargarAbo"
        Me.btnCargarAbo.Size = New System.Drawing.Size(64, 30)
        Me.btnCargarAbo.TabIndex = 3
        Me.btnCargarAbo.Text = "Cargar"
        Me.btnCargarAbo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(10, 577)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 60)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-3, 531)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1037, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_abonar)
        Me.GroupBox4.Controls.Add(Me.txt_abono)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(542, 76)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(302, 115)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Abonos"
        '
        'btn_abonar
        '
        Me.btn_abonar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_abonar.Location = New System.Drawing.Point(214, 49)
        Me.btn_abonar.Margin = New System.Windows.Forms.Padding(2)
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
        Me.txt_abono.Margin = New System.Windows.Forms.Padding(2)
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
        Me.GroupBox3.Controls.Add(Me.btnCalAbo)
        Me.GroupBox3.Controls.Add(Me.txtBonificacion)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtSobrantes)
        Me.GroupBox3.Controls.Add(Me.txtVales)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.btn_buscar_sobfal)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txt_Usu_Abono)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(49, 31)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(422, 285)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'btnCalAbo
        '
        Me.btnCalAbo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalAbo.Location = New System.Drawing.Point(340, 147)
        Me.btnCalAbo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalAbo.Name = "btnCalAbo"
        Me.btnCalAbo.Size = New System.Drawing.Size(64, 30)
        Me.btnCalAbo.TabIndex = 11
        Me.btnCalAbo.Text = "Calcular"
        Me.btnCalAbo.UseVisualStyleBackColor = True
        '
        'txtBonificacion
        '
        Me.txtBonificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBonificacion.Location = New System.Drawing.Point(175, 213)
        Me.txtBonificacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBonificacion.Name = "txtBonificacion"
        Me.txtBonificacion.Size = New System.Drawing.Size(149, 23)
        Me.txtBonificacion.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 214)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Bonificacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 116)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Sobrantes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 158)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Vales"
        '
        'txtSobrantes
        '
        Me.txtSobrantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSobrantes.Location = New System.Drawing.Point(175, 115)
        Me.txtSobrantes.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSobrantes.Name = "txtSobrantes"
        Me.txtSobrantes.Size = New System.Drawing.Size(149, 23)
        Me.txtSobrantes.TabIndex = 8
        '
        'txtVales
        '
        Me.txtVales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVales.Location = New System.Drawing.Point(175, 158)
        Me.txtVales.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVales.Name = "txtVales"
        Me.txtVales.Size = New System.Drawing.Size(149, 23)
        Me.txtVales.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(38, 2)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(257, 21)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Busqueda del estado de choferes"
        '
        'btn_buscar_sobfal
        '
        Me.btn_buscar_sobfal.BackgroundImage = CType(resources.GetObject("btn_buscar_sobfal.BackgroundImage"), System.Drawing.Image)
        Me.btn_buscar_sobfal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_buscar_sobfal.Location = New System.Drawing.Point(340, 45)
        Me.btn_buscar_sobfal.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar_sobfal.Name = "btn_buscar_sobfal"
        Me.btn_buscar_sobfal.Size = New System.Drawing.Size(39, 31)
        Me.btn_buscar_sobfal.TabIndex = 6
        Me.btn_buscar_sobfal.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(38, 49)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 19)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Código Chofer"
        '
        'txt_Usu_Abono
        '
        Me.txt_Usu_Abono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Usu_Abono.Location = New System.Drawing.Point(175, 45)
        Me.txt_Usu_Abono.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Usu_Abono.Name = "txt_Usu_Abono"
        Me.txt_Usu_Abono.Size = New System.Drawing.Size(149, 23)
        Me.txt_Usu_Abono.TabIndex = 4
        '
        'DGAbo
        '
        Me.DGAbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAbo.Location = New System.Drawing.Point(49, 373)
        Me.DGAbo.Margin = New System.Windows.Forms.Padding(2)
        Me.DGAbo.Name = "DGAbo"
        Me.DGAbo.RowTemplate.Height = 24
        Me.DGAbo.Size = New System.Drawing.Size(940, 142)
        Me.DGAbo.TabIndex = 1
        '
        'tab_control
        '
        Me.tab_control.BackColor = System.Drawing.Color.Transparent
        Me.tab_control.Controls.Add(Me.GroupBox1)
        Me.tab_control.Controls.Add(Me.Label20)
        Me.tab_control.Controls.Add(Me.lbHoraLo)
        Me.tab_control.Controls.Add(Me.btn_cargarc)
        Me.tab_control.Controls.Add(Me.Label8)
        Me.tab_control.Controls.Add(Me.DGControl)
        Me.tab_control.Controls.Add(Me.lbAtras)
        Me.tab_control.Controls.Add(Me.PictureBox3)
        Me.tab_control.Controls.Add(Me.btnAtras)
        Me.tab_control.Controls.Add(Me.PictureBox1)
        Me.tab_control.Controls.Add(Me.grpLLenaControl)
        Me.tab_control.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tab_control.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_control.Location = New System.Drawing.Point(4, 28)
        Me.tab_control.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_control.Name = "tab_control"
        Me.tab_control.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_control.Size = New System.Drawing.Size(1040, 842)
        Me.tab_control.TabIndex = 0
        Me.tab_control.Text = "Control"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbCodU)
        Me.GroupBox1.Controls.Add(Me.btnCalcular)
        Me.GroupBox1.Controls.Add(Me.lbCostoP)
        Me.GroupBox1.Controls.Add(Me.txtCostoPasaj)
        Me.GroupBox1.Controls.Add(Me.lbCanPasa)
        Me.GroupBox1.Controls.Add(Me.txtPasaj)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_MEntregado)
        Me.GroupBox1.Controls.Add(Me.txt_cod_Usuario)
        Me.GroupBox1.Controls.Add(Me.bt_buscar)
        Me.GroupBox1.Controls.Add(Me.txt_MEntregar)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_adulto_mayor)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 330)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Ingrese Valores"
        '
        'lbCodU
        '
        Me.lbCodU.AutoSize = True
        Me.lbCodU.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodU.Location = New System.Drawing.Point(18, 44)
        Me.lbCodU.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCodU.Name = "lbCodU"
        Me.lbCodU.Size = New System.Drawing.Size(100, 19)
        Me.lbCodU.TabIndex = 27
        Me.lbCodU.Text = "Código Chofer"
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(263, 114)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(76, 36)
        Me.btnCalcular.TabIndex = 41
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lbCostoP
        '
        Me.lbCostoP.AutoSize = True
        Me.lbCostoP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCostoP.Location = New System.Drawing.Point(22, 127)
        Me.lbCostoP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCostoP.Name = "lbCostoP"
        Me.lbCostoP.Size = New System.Drawing.Size(90, 19)
        Me.lbCostoP.TabIndex = 22
        Me.lbCostoP.Text = "Costo Pasaje"
        '
        'txtCostoPasaj
        '
        Me.txtCostoPasaj.Location = New System.Drawing.Point(160, 120)
        Me.txtCostoPasaj.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCostoPasaj.Name = "txtCostoPasaj"
        Me.txtCostoPasaj.Size = New System.Drawing.Size(94, 24)
        Me.txtCostoPasaj.TabIndex = 25
        '
        'lbCanPasa
        '
        Me.lbCanPasa.AutoSize = True
        Me.lbCanPasa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCanPasa.Location = New System.Drawing.Point(22, 98)
        Me.lbCanPasa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCanPasa.Name = "lbCanPasa"
        Me.lbCanPasa.Size = New System.Drawing.Size(127, 19)
        Me.lbCanPasa.TabIndex = 23
        Me.lbCanPasa.Text = "Cantidad Pasajeros"
        '
        'txtPasaj
        '
        Me.txtPasaj.Location = New System.Drawing.Point(160, 91)
        Me.txtPasaj.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPasaj.Name = "txtPasaj"
        Me.txtPasaj.Size = New System.Drawing.Size(94, 24)
        Me.txtPasaj.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 228)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Monto a Entregar"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(22, 153)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 19)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Adulto Mayor"
        '
        'txt_MEntregado
        '
        Me.txt_MEntregado.Location = New System.Drawing.Point(160, 252)
        Me.txt_MEntregado.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_MEntregado.Name = "txt_MEntregado"
        Me.txt_MEntregado.Size = New System.Drawing.Size(94, 24)
        Me.txt_MEntregado.TabIndex = 4
        '
        'txt_cod_Usuario
        '
        Me.txt_cod_Usuario.Location = New System.Drawing.Point(160, 44)
        Me.txt_cod_Usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cod_Usuario.Name = "txt_cod_Usuario"
        Me.txt_cod_Usuario.Size = New System.Drawing.Size(136, 24)
        Me.txt_cod_Usuario.TabIndex = 0
        '
        'bt_buscar
        '
        Me.bt_buscar.BackgroundImage = CType(resources.GetObject("bt_buscar.BackgroundImage"), System.Drawing.Image)
        Me.bt_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bt_buscar.Location = New System.Drawing.Point(300, 40)
        Me.bt_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(39, 31)
        Me.bt_buscar.TabIndex = 1
        Me.bt_buscar.UseVisualStyleBackColor = True
        '
        'txt_MEntregar
        '
        Me.txt_MEntregar.Location = New System.Drawing.Point(160, 221)
        Me.txt_MEntregar.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_MEntregar.Name = "txt_MEntregar"
        Me.txt_MEntregar.Size = New System.Drawing.Size(94, 24)
        Me.txt_MEntregar.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 261)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Monto Entregado"
        '
        'txt_adulto_mayor
        '
        Me.txt_adulto_mayor.Location = New System.Drawing.Point(160, 153)
        Me.txt_adulto_mayor.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_adulto_mayor.Name = "txt_adulto_mayor"
        Me.txt_adulto_mayor.Size = New System.Drawing.Size(94, 24)
        Me.txt_adulto_mayor.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(410, 15)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(173, 27)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Ingresos de Ruta"
        '
        'lbHoraLo
        '
        Me.lbHoraLo.AutoSize = True
        Me.lbHoraLo.BackColor = System.Drawing.Color.Silver
        Me.lbHoraLo.Location = New System.Drawing.Point(770, 39)
        Me.lbHoraLo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbHoraLo.Name = "lbHoraLo"
        Me.lbHoraLo.Size = New System.Drawing.Size(0, 18)
        Me.lbHoraLo.TabIndex = 38
        '
        'btn_cargarc
        '
        Me.btn_cargarc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cargarc.Location = New System.Drawing.Point(530, 330)
        Me.btn_cargarc.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cargarc.Name = "btn_cargarc"
        Me.btn_cargarc.Size = New System.Drawing.Size(76, 36)
        Me.btn_cargarc.TabIndex = 36
        Me.btn_cargarc.Text = "Cargar"
        Me.btn_cargarc.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(146, 348)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 21)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Informe de barras"
        '
        'DGControl
        '
        Me.DGControl.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGControl.Location = New System.Drawing.Point(15, 370)
        Me.DGControl.Margin = New System.Windows.Forms.Padding(2)
        Me.DGControl.Name = "DGControl"
        Me.DGControl.RowTemplate.Height = 24
        Me.DGControl.Size = New System.Drawing.Size(591, 162)
        Me.DGControl.TabIndex = 28
        '
        'lbAtras
        '
        Me.lbAtras.AutoSize = True
        Me.lbAtras.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAtras.Location = New System.Drawing.Point(73, 598)
        Me.lbAtras.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbAtras.Name = "lbAtras"
        Me.lbAtras.Size = New System.Drawing.Size(42, 19)
        Me.lbAtras.TabIndex = 22
        Me.lbAtras.Text = "Atrás"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(830, 606)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(144, 58)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'btnAtras
        '
        Me.btnAtras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAtras.BackColor = System.Drawing.Color.Transparent
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtras.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(68, 619)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(47, 45)
        Me.btnAtras.TabIndex = 7
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 545)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1033, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'grpLLenaControl
        '
        Me.grpLLenaControl.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpLLenaControl.Controls.Add(Me.txtAP)
        Me.grpLLenaControl.Controls.Add(Me.txtCod)
        Me.grpLLenaControl.Controls.Add(Me.lbCodig)
        Me.grpLLenaControl.Controls.Add(Me.lbFecha)
        Me.grpLLenaControl.Controls.Add(Me.txtced)
        Me.grpLLenaControl.Controls.Add(Me.Label19)
        Me.grpLLenaControl.Controls.Add(Me.Label3)
        Me.grpLLenaControl.Controls.Add(Me.cbx_carrera)
        Me.grpLLenaControl.Controls.Add(Me.lbRuta)
        Me.grpLLenaControl.Controls.Add(Me.txtnombre)
        Me.grpLLenaControl.Controls.Add(Me.lb_Hora_Fecha)
        Me.grpLLenaControl.Controls.Add(Me.btn_Agregar)
        Me.grpLLenaControl.Controls.Add(Me.label_cedula)
        Me.grpLLenaControl.Controls.Add(Me.lbUnid)
        Me.grpLLenaControl.Controls.Add(Me.txt_unidad)
        Me.grpLLenaControl.Controls.Add(Me.txt_Ruta)
        Me.grpLLenaControl.Controls.Add(Me.label_nom_Chofer)
        Me.grpLLenaControl.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLLenaControl.Location = New System.Drawing.Point(629, 15)
        Me.grpLLenaControl.Margin = New System.Windows.Forms.Padding(2)
        Me.grpLLenaControl.Name = "grpLLenaControl"
        Me.grpLLenaControl.Padding = New System.Windows.Forms.Padding(2)
        Me.grpLLenaControl.Size = New System.Drawing.Size(369, 517)
        Me.grpLLenaControl.TabIndex = 0
        Me.grpLLenaControl.TabStop = False
        '
        'txtAP
        '
        Me.txtAP.Location = New System.Drawing.Point(154, 148)
        Me.txtAP.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAP.Name = "txtAP"
        Me.txtAP.Size = New System.Drawing.Size(149, 27)
        Me.txtAP.TabIndex = 41
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(125, 395)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(159, 27)
        Me.txtCod.TabIndex = 21
        '
        'lbCodig
        '
        Me.lbCodig.AutoSize = True
        Me.lbCodig.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCodig.Location = New System.Drawing.Point(20, 395)
        Me.lbCodig.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCodig.Name = "lbCodig"
        Me.lbCodig.Size = New System.Drawing.Size(64, 51)
        Me.lbCodig.TabIndex = 20
        Me.lbCodig.Text = "Código" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recibidor"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(186, 51)
        Me.lbFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(33, 20)
        Me.lbFecha.TabIndex = 40
        Me.lbFecha.Text = "----"
        '
        'txtced
        '
        Me.txtced.Location = New System.Drawing.Point(125, 190)
        Me.txtced.Margin = New System.Windows.Forms.Padding(2)
        Me.txtced.Name = "txtced"
        Me.txtced.Size = New System.Drawing.Size(159, 27)
        Me.txtced.TabIndex = 39
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(46, 3)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(232, 21)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Ingrese información requerida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 252)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Carrera"
        '
        'cbx_carrera
        '
        Me.cbx_carrera.FormattingEnabled = True
        Me.cbx_carrera.Location = New System.Drawing.Point(125, 244)
        Me.cbx_carrera.Margin = New System.Windows.Forms.Padding(2)
        Me.cbx_carrera.Name = "cbx_carrera"
        Me.cbx_carrera.Size = New System.Drawing.Size(178, 27)
        Me.cbx_carrera.TabIndex = 29
        '
        'lbRuta
        '
        Me.lbRuta.AutoSize = True
        Me.lbRuta.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRuta.Location = New System.Drawing.Point(23, 350)
        Me.lbRuta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbRuta.Name = "lbRuta"
        Me.lbRuta.Size = New System.Drawing.Size(36, 17)
        Me.lbRuta.TabIndex = 17
        Me.lbRuta.Text = "Ruta"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(23, 148)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(280, 27)
        Me.txtnombre.TabIndex = 37
        '
        'lb_Hora_Fecha
        '
        Me.lb_Hora_Fecha.AutoSize = True
        Me.lb_Hora_Fecha.Location = New System.Drawing.Point(19, 51)
        Me.lb_Hora_Fecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_Hora_Fecha.Name = "lb_Hora_Fecha"
        Me.lb_Hora_Fecha.Size = New System.Drawing.Size(108, 20)
        Me.lb_Hora_Fecha.TabIndex = 30
        Me.lb_Hora_Fecha.Text = "Fecha / Hora "
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar.Location = New System.Drawing.Point(279, 427)
        Me.btn_Agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(76, 36)
        Me.btn_Agregar.TabIndex = 26
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'label_cedula
        '
        Me.label_cedula.AutoSize = True
        Me.label_cedula.Location = New System.Drawing.Point(19, 193)
        Me.label_cedula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_cedula.Name = "label_cedula"
        Me.label_cedula.Size = New System.Drawing.Size(59, 20)
        Me.label_cedula.TabIndex = 34
        Me.label_cedula.Text = "Cédula"
        '
        'lbUnid
        '
        Me.lbUnid.AutoSize = True
        Me.lbUnid.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUnid.Location = New System.Drawing.Point(23, 303)
        Me.lbUnid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbUnid.Name = "lbUnid"
        Me.lbUnid.Size = New System.Drawing.Size(50, 17)
        Me.lbUnid.TabIndex = 9
        Me.lbUnid.Text = "Unidad"
        '
        'txt_unidad
        '
        Me.txt_unidad.Location = New System.Drawing.Point(125, 293)
        Me.txt_unidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_unidad.Name = "txt_unidad"
        Me.txt_unidad.Size = New System.Drawing.Size(159, 27)
        Me.txt_unidad.TabIndex = 10
        '
        'txt_Ruta
        '
        Me.txt_Ruta.Location = New System.Drawing.Point(125, 340)
        Me.txt_Ruta.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Ruta.Name = "txt_Ruta"
        Me.txt_Ruta.Size = New System.Drawing.Size(159, 27)
        Me.txt_Ruta.TabIndex = 18
        '
        'label_nom_Chofer
        '
        Me.label_nom_Chofer.AutoSize = True
        Me.label_nom_Chofer.Location = New System.Drawing.Point(84, 120)
        Me.label_nom_Chofer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_nom_Chofer.Name = "label_nom_Chofer"
        Me.label_nom_Chofer.Size = New System.Drawing.Size(149, 20)
        Me.label_nom_Chofer.TabIndex = 33
        Me.label_nom_Chofer.Text = "Nombre del Chofer"
        '
        'tabAbonos
        '
        Me.tabAbonos.Controls.Add(Me.tab_control)
        Me.tabAbonos.Controls.Add(Me.tab_sob_fal)
        Me.tabAbonos.Controls.Add(Me.tab_planillas)
        Me.tabAbonos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabAbonos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAbonos.Location = New System.Drawing.Point(11, 11)
        Me.tabAbonos.Margin = New System.Windows.Forms.Padding(2)
        Me.tabAbonos.Name = "tabAbonos"
        Me.tabAbonos.SelectedIndex = 0
        Me.tabAbonos.Size = New System.Drawing.Size(1048, 874)
        Me.tabAbonos.TabIndex = 0
        '
        'tab_planillas
        '
        Me.tab_planillas.Location = New System.Drawing.Point(4, 28)
        Me.tab_planillas.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_planillas.Name = "tab_planillas"
        Me.tab_planillas.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_planillas.Size = New System.Drawing.Size(1040, 842)
        Me.tab_planillas.TabIndex = 2
        Me.tab_planillas.Text = "Planillas"
        Me.tab_planillas.UseVisualStyleBackColor = True
        '
        'PRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 712)
        Me.Controls.Add(Me.tabAbonos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PRINCIPAL"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Ingresos"
        Me.tab_sob_fal.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGAbo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_control.ResumeLayout(False)
        Me.tab_control.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLLenaControl.ResumeLayout(False)
        Me.grpLLenaControl.PerformLayout()
        Me.tabAbonos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab_sob_fal As TabPage
    Friend WithEvents tab_control As TabPage
    Friend WithEvents grpLLenaControl As GroupBox
    Friend WithEvents bt_buscar As Button
    Friend WithEvents txt_cod_Usuario As TextBox
    Friend WithEvents tabAbonos As TabControl
    Friend WithEvents txt_unidad As TextBox
    Friend WithEvents lbUnid As Label
    Friend WithEvents txt_MEntregado As TextBox
    Friend WithEvents txt_MEntregar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_Usu_Abono As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DGAbo As DataGridView
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
    Friend WithEvents lbRuta As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAtras As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents txtCod As TextBox
    Friend WithEvents lbCodig As Label
    Friend WithEvents lbAtras As Label
    Friend WithEvents txtCostoPasaj As TextBox
    Friend WithEvents txtPasaj As TextBox
    Friend WithEvents lbCanPasa As Label
    Friend WithEvents lbCostoP As Label
    Friend WithEvents txtced As TextBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents lbHoraLo As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents cbx_carrera As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents label_cedula As Label
    Friend WithEvents label_nom_Chofer As Label
    Friend WithEvents btn_cargarc As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lb_Hora_Fecha As Label
    Friend WithEvents DGControl As DataGridView
    Friend WithEvents btnCargarAbo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbCodU As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSobrantes As TextBox
    Friend WithEvents txtVales As TextBox
    Friend WithEvents txtBonificacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalAbo As Button
    Friend WithEvents txtAP As TextBox
End Class
