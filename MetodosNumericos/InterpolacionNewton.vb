Public Class InterpolacionNewton

    Dim i, k, r, n, vx, ib, m, c, redon As Integer
    Dim s, prod, suma, prod1, final As Single

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

        'Calculamos m
        'm empieza a contarse desde 0
        m = n - (ib + 1)
        lbM.Text = m

        'Otro paso
        s = (vx - xi(ib)) / (xi(ib + 1) - (xi(ib)))
        lbS.Text = s

        For k = 0 To m
            prod = 1
            For r = 1 To k
                prod = prod * ((s - (r - 1)) / r)
            Next
            sk(k) = prod

        Next


        For k = 0 To m Step 1
            suma = 0
            For j = 0 To k
                prod1 = 1
                For r = 1 To j
                    prod1 = prod1 * (k - (r - 1)) / r
                Next
                suma = suma + ((-1) ^ j) * prod1 * (yi(ib + k - j))
            Next
            delta(k) = suma
            SalidaCoeficientes.Rows.Add(Math.Round(delta(k), redon))
        Next

        For k = 0 To m Step 1
            final = final + sk(k) * delta(k)
        Next

        lbInterpolacion.Text = Math.Round(final, redon)
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MetodosNumericos.Show()
    End Sub

    Dim xi(50) As Single
    Dim yi(50) As Single
    Dim sk(50) As Single
    Dim delta(50) As Single

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub



    Private Sub nav_Home_Click(sender As Object, e As EventArgs) Handles nav_Home.Click
        Me.Close()
    End Sub


End Class