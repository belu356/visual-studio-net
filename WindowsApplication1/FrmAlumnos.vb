Public Class FrmAlumnos
    Private Sub FrmAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ColegioDataSet.alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.ColegioDataSet.alumnos)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        ApellidoTextBox.Focus()
        AlumnosBindingSource.AddNew()

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        AlumnosBindingSource.EndEdit()
        AlumnosTableAdapter.Update(ColegioDataSet.alumnos)

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Dim g As String
        g = MsgBox("¿Desea modificar el registro?", MsgBoxStyle.Question + vbYesNo,
                   "Modificar")
        If g = vbYes Then
            AlumnosBindingSource.EndEdit()
            AlumnosTableAdapter.Update(ColegioDataSet.alumnos)
        Else
            MsgBox("Registro no actualizado", "Modificar")
            Me.AlumnosTableAdapter.Fill(Me.ColegioDataSet.alumnos)
        End If



    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim el As String
        el = MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.Question + vbYesNo, "Eliminar")
        If el = vbYes Then
            AlumnosBindingSource.RemoveCurrent()
            AlumnosTableAdapter.Update(ColegioDataSet.alumnos)
            MsgBox("Registro eliminado")

        Else

        End If
    End Sub
End Class