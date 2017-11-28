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
    Public Sub insertar_Control()

        Dim Agregar As New Co_Control

        'Try

        '    If txt_cod_Usuario.Text = "" Then
        '        MsgBox("Porfavor ingrese el código de usuario")
        '    Else
        Agregar.Cod_Usu_ID_Chofer = Integer.Parse(txt_cod_Usuario.Text)
                Agregar.Numero_de_Ruta = Integer.Parse(txt_Ruta.Text)
                Agregar.Unidad = Integer.Parse(txt_unidad.Text)
                Agregar.Monto_Entregar = Convert.ToDecimal(txt_MEntregar.Text)
                Agregar.Monto_Entregado = Convert.ToDecimal(txt_MEntregado.Text)
                Agregar.Codigo = Convert.ToDecimal(txtCod.Text)
        Agregar.ID_Zona = (cbx_carrera.SelectedValue)
        Agregar.Nombre_chofer = Convert.ToString(txtnombre.Text)
                Agregar.Fecha_Hora = Convert.ToDateTime(lbFecha.Text)

                db.Co_Control.InsertOnSubmit(Agregar)
                db.SubmitChanges()
        'MsgBox("DATOS DEL CHOFER INGRESADOS SATISFACTORIAMENTE")
        CargarGControl()





        '    End If
        'Catch ex As Exception

        'End Try


    End Sub
    Public Sub Llenar_Cbx()

        cbx_carrera.SelectedValue = "ID "
        cbx_carrera.DisplayMember = "Carrer"
        cbx_carrera.DataSource = db.Ca_Carreras.ToList

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
            txtced.Text = buscarDet.Cedula.ToString

            DGControl.DataSource = buscarCon.ToList
            DGAbo.DataSource = buscarCon.ToList


        Catch ex As Exception

        End Try

    End Sub



    Public Sub limpiar()



        txt_cod_Usuario.Text = ""
        txtnombre.Text = ""
        txtnombre.Text = ""
        txtnombre.Text = ""
        txtced.Text = ""


        lbFecha.Text = ""

        txt_Ruta.Text = ""
        txt_unidad.Text = ""
        txtCod.Text = ""
        txtPasaj.Text = ""
        txtCostoPasaj.Text = ""
        txtCostoPasaj.Text = ""
        txt_MEntregar.Text = ""
        txt_MEntregado.Text = ""
        txt_adulto_mayor.Text = ""


    End Sub

    'Private Sub datagridControl_CellClick(sender As Object, e As DataGridViewCellEventArgs)


    '    If e.RowIndex >= 0 Then

    '        Dim index As Integer
    '        index = e.RowIndex

    '        Dim selectedRow As DataGridViewRow

    '        selectedRow = datagridchoferes.rows(index)



    '        txt_cod_Usuario.Text = selectedRow.Cells(0).Value.ToString()
    '        txtnombre.Text = selectedRow.Cells(1).Value.ToString()
    '        txtced.Text = selectedRow.Cells(2).Value.ToString()
    '        cbx_carrera.SelectedValue = selectedRow.Cells(3).Value.ToString()
    '        txt_Ruta.Text = selectedRow.Cells(4).Value.ToString()
    '        txt_unidad.Text = selectedRow.Cells(5).Value.ToString()
    '        txtCod.Text = selectedRow.Cells(6).Value.ToString()
    '        txtPasaj.Text = selectedRow.Cells(7).Value.ToString()
    '        txtCostoPasaj.Text = selectedRow.Cells(8).Value.ToString()
    '        txt_MEntregar.Text = selectedRow.Cells(9).Value.ToString()
    '        txt_MEntregado.Text = selectedRow.Cells(10).Value.ToString()
    '        txt_adulto_mayor.Text = selectedRow.Cells(11).Value.ToString()
    '        lbFecha.Text = selectedRow.Cells(12).Value.ToString()

    '    End If


    'End Sub



    Public Sub MetodoCal()

        Dim CanP As Decimal = Convert.ToDecimal(txtPasaj.Text)
        Dim Cos As Decimal = Convert.ToDecimal(txtCostoPasaj.Text)
        Dim Adul As Integer = Int32.Parse(txt_adulto_mayor.Text)
        'Dim toEnt As Decimal = Convert.ToDecimal(txt_MEntregar.Text)
        'Dim Entre As Decimal = Convert.ToDecimal(txt_MEntregado.Text)


        txt_MEntregar.Text = ((CanP * Cos) - (Adul * Cos)).ToString


    End Sub
#End Region

#Region "//BOTONES Control"






    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        insertar_Control()


    End Sub


    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click


        If txt_cod_Usuario.Text = "" Then
            MsgBox("NO HA INGRESADO EL NUMERO DE CEDULA")
        Else
            Try
                buscarC(Convert.ToInt32(txt_cod_Usuario.Text))

            Catch ex As Exception
                MsgBox("INGRESE SOLO NUMEROS")
            End Try

        End If

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

        lbFecha.Text = DateAndTime.Now().ToLocalTime


    End Sub


    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        MetodoCal()




    End Sub




#End Region



#Region "//Abonos"

    Public Sub cargargridAbo()

        Dim cargarAbo = (From datos In db.A_Abono Select datos)
        DGAbo.DataSource = cargarAbo.ToList


    End Sub


    Public Sub Met()

        Dim sob As Decimal = Convert.ToDecimal(txtSobrantes.Text)
        Dim vales As Decimal = Convert.ToDecimal(txtVales.Text)
        Dim AEntre As Decimal = Convert.ToDecimal(txt_MEntregado.Text)
        Dim Entrega As Decimal = Convert.ToDecimal(txt_MEntregar.Text)
        Dim Boni As Decimal = Convert.ToDecimal(txtBonificacion.Text)
        Dim MonRe As Decimal = Convert.ToDecimal(txtBonificacion.Text)

        If (Entrega < AEntre) Then

            vales = (AEntre - Entrega)

        Else
            If (Entrega > AEntre) Then

                MonRe = (Entrega - AEntre)
            Else

                If (Entrega = AEntre) Then
                    Boni = (MonRe = 15000)
                End If
            End If


        End If

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