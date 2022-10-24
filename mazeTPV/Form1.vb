Public Class Form1
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles btIniciar.Click
        Form2.Show()
        Me.Hide()


    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        If MsgBox("¿Salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub


End Class
