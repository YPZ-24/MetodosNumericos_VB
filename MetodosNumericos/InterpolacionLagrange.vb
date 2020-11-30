Public Class InterpolacionLagrange

    Dim i, n, ib, c, redon As Integer
    Dim yx, vx As Single

    Dim xi(50) As Single

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Salida.Rows.Clear()
        lbInterpolacion.Text = "Aún no se ha encontrado"
        lbI.Text = "Aún no se ha encontrado"
        tc.Text = ""
        tn.Text = ""
        x.Text = ""
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MetodosNumericos.Show()
    End Sub

    Dim yi(50) As Single

    Private Sub nav_Home_Click(sender As Object, e As EventArgs) Handles nav_Home.Click
        Me.Close()
    End Sub


    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        n = tn.Text
        vx = x.Text
        c = tc.Text
        redon = c + 2

        'Aceptamos los valores de "x" y "y"
        For i = 0 To n - 1 Step 1
            xi(i) = InputBox("x(" & i & ") = ")
            yi(i) = InputBox("y(" & i & ") = ")
            Salida.Rows.Add(i, xi(i), yi(i))
        Next

        'Buscamos el indice
        For i = 1 To n Step 1
            If xi(i) > vx And xi(i - 1) < vx Then
                ib = i - 1
            End If
        Next
        lbI.Text = ib

        'y(x) primer grado
        yx = ((vx - xi(ib + 1)) / (xi(ib) - xi(ib + 1)) * yi(ib)) + ((vx - xi(ib)) / (xi(ib + 1) - xi(ib)) * yi(ib + 1))
        lbInterpolacion.Text = Math.Round(yx, redon)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class