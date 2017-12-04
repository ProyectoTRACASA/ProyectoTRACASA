Imports System.Data



Public Class PRINCIPAL



    Dim db As New SistemaControlDataContext

    Public Sub New()

        InitializeComponent()

        Llenar_Cbx()

    End Sub

#Region "//Control"
#Region "//METODOS "


    Public Sub CargarGControl()

        Dim cargarc = (From datos In db.Co_Control Select datos)
        DGControl.DataSource = cargarc.ToList

    End Sub
    Public Sub AgregarControl()

        Dim Agregar As New Co_Control
        Dim vales As Integer
        Dim sob As Integer
        Try

            If txt_cod_Usuario.Text = "" Then
                MsgBox("Porfavor ingrese el código de usuario")
            Else
                Agregar.Cod_Usuario_ID_Chofer = Integer.Parse(txt_cod_Usuario.Text)
                Agregar.Pasajeros = Integer.Parse(txtPasaj.Text)
                Agregar.Costo_Pasaje = Integer.Parse(txtCostoPasaj.Text)
                Agregar.Adultos_Mayores = Integer.Parse(txt_adulto_mayor.Text)
                Agregar.Numero_de_Ruta = Integer.Parse(txt_Ruta.Text)
                Agregar.Unidad = Integer.Parse(txt_unidad.Text)
                Agregar.Monto_Entregar = Integer.Parse(txt_MEntregar.Text)
                Agregar.Monto_Entregado = Integer.Parse(txt_MEntregado.Text)
                Agregar.Codigo = Convert.ToDecimal(txtCod.Text)

                If (CInt(txt_MEntregar.Text) < CInt(txt_MEntregado.Text)) Then

                    vales = (CInt(txt_MEntregar.Text) - CInt(txt_MEntregado.Text))

                Else
                    'If (CInt(txt_MEntregado.Text) > CInt(txt_MEntregar.Text)) Then

                    sob = (CInt(txt_MEntregado.Text) - CInt(txt_MEntregar.Text))

                End If

                'End If
                'End If
                Agregar.Sobrantes = sob.ToString
                Agregar.Vales = vales.ToString
                'Agregar.Sobrantes = sob.ToString
                'Agregar.Vales = vales.ToString

                Agregar.Fecha_Hora = DateTimePicker1.Text

                'Agregar.Fecha_Hora = Convert.ToDateTime(lbFecha.Text)

                db.Co_Control.InsertOnSubmit(Agregar)
                db.SubmitChanges()
                MsgBox("DATOS DEL CHOFER INGRESADOS SATISFACTORIAMENTE")
                CargarGControl()
                'Met()
                limpiar()


            End If
        Catch ex As Exception

        End Try


    End Sub
    Public Sub Llenar_Cbx()

        cbx_carrera.SelectedValue = "ID "
        cbx_carrera.DisplayMember = "Carrer"
        cbx_carrera.DataSource = db.Ca_Carreras.ToList()

    End Sub
    Public Sub buscarC(ByVal cod_U As Integer)

        Try

            Dim buscarCon = (From dato In db.Cho_Choferes
                             Where dato.Cod_Usuario_ID_Chofer = cod_U
                             Select dato)

            Dim buscarDet = (From dato In db.Cho_Choferes
                             Where dato.Cod_Usuario_ID_Chofer = cod_U
                             Select dato).FirstOrDefault

            txtnombre.Text = buscarDet.Nombre
            txtAP.Text = buscarDet.Primer_Apellido
            txtced.Text = buscarDet.Cedula.ToString

            DGAbo.DataSource = buscarCon.ToList

        Catch ex As Exception

        End Try

    End Sub

    Public Sub cargar_rutas_dia()
        Try
            Dim buscar = (From datos In db.Co_Control
                          Where datos.Fecha_Hora = DateTimePicker1.Text And datos.Cod_Usuario_ID_Chofer = txt_cod_Usuario.Text
                          Select datos)


            DGControl.DataSource = buscar.ToList

        Catch ex As Exception


        End Try


    End Sub

    Public Sub limpiar()

        txt_cod_Usuario.Clear()
        txtnombre.Clear()
        txtced.Clear()

        txt_Ruta.Clear()
        txt_unidad.Clear()
        txtCod.Clear()
        txtPasaj.Clear()
        txtCostoPasaj.Clear()
        txt_MEntregar.Clear()
        txt_MEntregado.Clear()
        txt_adulto_mayor.Clear()
        txtAP.Clear()


    End Sub
    Private Sub txt_MEntregar_TextChanged(sender As Object, e As EventArgs) Handles txt_MEntregar.TextChanged
        'Public Sub entregar()

        If txtPasaj.Text = "" Or txtCostoPasaj.Text = "" Or txt_adulto_mayor.Text = "" Then
            Exit Sub
        End If
        Dim total As Integer = ((CInt(txtPasaj.Text) * CInt(txtCostoPasaj.Text)) - (CInt(txt_adulto_mayor.Text) * CInt(txtCostoPasaj.Text)))
        txt_MEntregar.Text = total


    End Sub


#End Region

#Region "//BOTONES Control"

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        AgregarControl()

    End Sub


    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click

        If txt_cod_Usuario.Text = "" Then
            MsgBox("NO HA INGRESADO UN CODIGO DE CHOFER")
        Else
            Try
                buscarC(Convert.ToInt32(txt_cod_Usuario.Text))

            Catch ex As Exception
                MsgBox("INGRESE SOLO NUMEROS")
            End Try

            'lbFecha.Text = Date.Now().ToLocalTime
        End If
        cargar_rutas_dia()
    End Sub

    Private Sub btn_cargarc_Click(sender As Object, e As EventArgs) Handles btn_cargarc.Click
        CargarGControl()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim men As New MENU
        men.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim men As New MENU
        men.Show()
        Me.Hide()

    End Sub

    Private Sub PRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'lbFecha.Text = Date.Now().ToLocalTime
        DateTimePicker1.Enabled = False


    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'entregar()

    End Sub

#End Region

#Region "//Abonos"

    Public Sub cargargridAbo()

        Dim cargarAbo = (From datos In db.A_Abono Select datos)
        DGAbo.DataSource = cargarAbo.ToList


    End Sub





#Region "//Botones Abono"
    Private Sub btnCargarAbo_Click(sender As Object, e As EventArgs) Handles btnCargarAbo.Click
        cargargridAbo()
    End Sub



    Private Sub btn_buscar_sobfal_Click(sender As Object, e As EventArgs) Handles btn_buscar_sobfal.Click

        If txt_Usu_Abono.Text = "" Then
            MsgBox("NO HA INGRESADO EL NUMERO DE CEDULA")
        Else
            Try
                buscarC(Convert.ToInt32(txt_Usu_Abono.Text))

            Catch ex As Exception
                MsgBox("INGRESE SOLO NUMEROS")
            End Try

        End If
    End Sub













#End Region


#End Region

#End Region







End Class