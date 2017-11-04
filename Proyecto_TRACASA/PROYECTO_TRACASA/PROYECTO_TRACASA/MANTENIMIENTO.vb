Imports System.Data




Public Class MANTENIMIENTO

    Dim db As New SistemaControl



    Public Sub New()

        InitializeComponent()

        cargargrid()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim men As New MENU
        men.Show()
        Me.Hide()

    End Sub
    Public Sub cargargrid()
        Dim datos = (From dat In db.Cho_Choferes
                     Select dat)

        DataGridView1.DataSource = datos.ToList

    End Sub

    Public Sub inserta_choferes()

        Dim inserta As New Cho_Choferes


        inserta.Cho_Nombre = txt_M_nombre.Text
            inserta.Cho_Cedula = txt_M_cedula.Text
            inserta.Cho_Apellido1 = txt_M_1apellido.Text
            inserta.Cho_Apellido2 = txt_M_2apellido.Text
            inserta.Cho_Compania = txt_M_compania.Text
            inserta.Cho_Num_Codigo = txt_M_codigo.Text
            inserta.Cho_Num_folio = txt_M_folio.Text
            inserta.Cho_Boleta = txt_M_boleta.Text

            db.Cho_Choferes.Add(inserta)
            db.SaveChanges()

    End Sub

    Private Sub btn_M_agregar_Click(sender As Object, e As EventArgs) Handles btn_M_agregar.Click
        inserta_choferes()
    End Sub


End Class