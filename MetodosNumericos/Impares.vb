Public Class Impares

    Dim fin As Integer
    Dim k As Integer
    Dim impar As Integer

    Private Sub nav_Home_Click(sender As Object, e As EventArgs) Handles nav_Home.Click
        Me.Close()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MetodosNumericos.Show()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        fin = tn.Text
        For k = 1 To fin
            impar = 2 * k - 1
            Salida.Rows.Add(k, impar)
        Next
    End Sub
End Class