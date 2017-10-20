

Public Class Frm_principal
    Dim A, B, C As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim matriz(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        A = matriz(0, 1)
        B = matriz(2, 0)
        C = (A + B)






    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_suma.TextChanged


    End Sub

    Private Sub btn_suma_Click(sender As Object, e As EventArgs) Handles btn_suma.Click

        txt_suma.Text = C
        FrmAlumnos.Show()

    End Sub
End Class
