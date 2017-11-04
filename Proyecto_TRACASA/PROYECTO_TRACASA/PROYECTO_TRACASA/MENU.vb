Public Class MENU
    Private Sub btn_Control_Click(sender As Object, e As EventArgs) Handles btn_Control.Click
        Dim prin As New PRINCIPAL

        Me.Hide()
        prin.Show()
    End Sub

    Private Sub btn_mantenimiento_Click(sender As Object, e As EventArgs) Handles btn_mantenimiento.Click
        Dim mant As New MANTENIMIENTO
        mant.Show()
        Me.Hide()
    End Sub
End Class