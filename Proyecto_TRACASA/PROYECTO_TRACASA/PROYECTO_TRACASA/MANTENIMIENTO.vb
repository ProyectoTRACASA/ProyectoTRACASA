Imports System.Data

'Arreglar error al dar click en la ultima fila del datagrid
'no se puede poner 01 en los campos de texto, aplicar con double o float'

Public Class MANTENIMIENTO

    Dim db As New SistemaControlDataContext

    Public Sub New()

        InitializeComponent()

    End Sub


    Public Sub cargargrid()

        Dim cargar = (From datos In db.Cho_Choferes Select datos)
        datagridchoferes.DataSource = cargar

    End Sub

    Public Sub inserta_choferes()

        Dim ingresar As New Cho_Choferes

        'With { .Cho_Nombre = txt_M_nombre.Text,
        '    .Cho_Cedula = txt_M_cedula.Text, .Cho_Num_Codigo = txt_M_codigo.Text,
        '    .Cho_Apellido1 = txt_M_1apellido.Text, .Cho_Apellido2 = txt_M_2apellido.Text,
        '    .Cho_Num_folio = txt_M_folio.Text, .Cho_Boleta = txt_M_boleta.Text,
        '    .Cho_Compania = txt_M_compania.Text}

        'End With

        Try

            If txt_M_cedula.Text = "" Then
                MsgBox("No ha ingresado el numero de cedula, Por favor ingreselo para poder registrarlo")
            Else
                ingresar.Cho_Nombre = txt_M_nombre.Text
                ingresar.Cho_Cedula = txt_M_cedula.Text
                ingresar.Cho_Num_Codigo = txt_M_codigo.Text
                ingresar.Cho_Apellido1 = txt_M_1apellido.Text
                ingresar.Cho_Apellido2 = txt_M_2apellido.Text
                ingresar.Cho_Num_folio = txt_M_folio.Text
                ingresar.Cho_Boleta = txt_M_boleta.Text
                ingresar.Cho_Compania = txt_M_compania.Text

                db.Cho_Choferes.InsertOnSubmit(ingresar)
                db.SubmitChanges()
                MsgBox("DATOS DEL CHOFER INGRESADOS SATISFACTORIAMENTE")

            End If
        Catch ex As Exception

        End Try


    End Sub

    Public Sub buscar(ByVal buscar_cedula As Integer)

        Try


            Dim buscar = (From dato In db.Cho_Choferes
                          Where dato.Cho_Cedula = buscar_cedula
                          Select dato)

            datagridchoferes.DataSource = buscar


        Catch ex As Exception

        End Try



    End Sub

    Public Sub modificar(ByVal cedula As Integer)

        Try
            Dim modificar = (From dato In db.Cho_Choferes
                             Where dato.Cho_Cedula = cedula
                             Select dato).FirstOrDefault

            modificar.Cho_Nombre = txt_M_nombre.Text
            modificar.Cho_Cedula = txt_M_cedula.Text
            modificar.Cho_Num_Codigo = txt_M_codigo.Text
            modificar.Cho_Apellido1 = txt_M_1apellido.Text
            modificar.Cho_Apellido2 = txt_M_2apellido.Text
            modificar.Cho_Num_folio = txt_M_folio.Text
            modificar.Cho_Boleta = txt_M_boleta.Text
            modificar.Cho_Compania = txt_M_compania.Text

            db.SubmitChanges()
            MsgBox("Modificado correctamente")

            Dim buscarid = (From dato In db.Cho_Choferes
                            Where dato.Cho_Cedula = cedula
                            Select dato)

            datagridchoferes.DataSource = buscarid
            limpiar()

        Catch ex As Exception

        End Try


    End Sub

    'Public Sub insertaUsuarios()
    '    Dim insert As New U_Usuario

    '    insert.U_Usuario = txt_usuario.Text
    '    insert.U_Contrasena = txt_contra.Text
    '    insert.U_ID_Zona = txt_zona.Text

    '    db.U_Usuario.(insert)
    '    db.SaveChanges()

    'End Sub


    Public Sub limpiar()

        txt_M_cedula.Text = ""
        txt_M_codigo.Text = ""
        txt_M_nombre.Text = ""
        txt_M_1apellido.Text = ""
        txt_M_2apellido.Text = ""
        txt_M_folio.Text = ""
        txt_M_compania.Text = ""
        txt_M_boleta.Text = ""

    End Sub
    Private Sub btn_M_agregar_Click(sender As Object, e As EventArgs) Handles btn_M_agregar.Click
        inserta_choferes()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cargargrid()

    End Sub

    Private Sub datagridchoferes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridchoferes.CellClick


        If e.RowIndex >= 0 Then

            Dim index As Integer
            index = e.RowIndex

            Dim selectedRow As DataGridViewRow
            selectedRow = datagridchoferes.Rows(index)

            txt_M_cedula.Text = selectedRow.Cells(0).Value.ToString()
            txt_M_codigo.Text = selectedRow.Cells(1).Value.ToString()
            txt_M_nombre.Text = selectedRow.Cells(2).Value.ToString()
            txt_M_1apellido.Text = selectedRow.Cells(3).Value.ToString()
            txt_M_2apellido.Text = selectedRow.Cells(4).Value.ToString()
            txt_M_folio.Text = selectedRow.Cells(5).Value.ToString()
            txt_M_boleta.Text = selectedRow.Cells(6).Value.ToString()
            txt_M_compania.Text = selectedRow.Cells(7).Value.ToString()


        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim men As New MENU
        men.Show()
        Me.Hide()

    End Sub

    Private Sub btn_M_modificar_Click(sender As Object, e As EventArgs) Handles btn_M_modificar.Click
        Try
            modificar(Convert.ToInt32(txt_M_cedula.Text))
        Catch ex As Exception
            MsgBox("NO HAY DATOS QUE MODIFICAR")
        End Try

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If txt_M_buscar.Text = "" Then
            MsgBox("NO HA INGRESADO EL NUMERO DE CEDULA")
        Else
            Try
                buscar(Convert.ToInt32(txt_M_buscar.Text))
                btn_M_agregar.Enabled = False
            Catch ex As Exception
                MsgBox("INGRESE SOLO NUMEROS")
            End Try

        End If

    End Sub
End Class