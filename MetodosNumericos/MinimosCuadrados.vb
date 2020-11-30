Public Class MinimosCuadrados

    Dim i, n, c, redon As Integer
    Dim a, b, sumaX, sumaY, sumaXY, sumaXX, xMedia, yMedia, xMin, yMin, xMax, yMax As Single

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Salida.Rows.Clear()
        lbVx.Text = "Aún no se ha encontrado"
        lbA.Text = "Aún no se ha encontrado"
        lbB.Text = "Aún no se ha encontrado"
        tc.Text = ""
        tn.Text = ""
        vx.Text = ""
        graf.Series(0).Points.Clear()
        graf.Series(1).Points.Clear()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Dim g As Graphics
    Dim xi(50) As Single
    Dim yi(50) As Single

    Private Sub nav_Home_Click(sender As Object, e As EventArgs) Handles nav_Home.Click
        Me.Close()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        n = tn.Text
        c = tc.Text
        redon = c + 2

        sumaXY = 0
        sumaXX = 0
        sumaX = 0
        sumaY = 0

        'Aceptamos los valores de "x" y "y"
        For i = 1 To n Step 1
            xi(i) = InputBox("x(" & i & ") = ")
            yi(i) = InputBox("y(" & i & ") = ")
            Salida.Rows.Add(i, xi(i), yi(i))

            'Suma x
            sumaX = sumaX + xi(i)

            'Suma y
            sumaY = sumaY + yi(i)

            'Suma xy
            sumaXY = sumaXY + xi(i) * yi(i)

            'Suma x cuadrada
            sumaXX = sumaXX + xi(i) * xi(i)

        Next

        xMedia = sumaX / n
        yMedia = sumaY / n

        b = (sumaXY - n * xMedia * yMedia) / (sumaXX - n * (xMedia ^ 2))
        a = yMedia - b * xMedia
        'y=a+b*x

        lbVx.Text = "y(" & vx.Text & ")=" & Math.Round(a + b * vx.Text, redon)

        xMin = xi(1)
        yMin = a + b * xMin
        xMax = xi(n)
        yMax = a + b * xMax

        lbA.Text = Math.Round(a, redon)
        lbB.Text = Math.Round(b, redon)
    End Sub

    Private Sub btnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click
        g = CreateGraphics()
        For i = 1 To n Step 1
            graf.Series(0).Points.AddXY(xi(i), yi(i))
        Next

        graf.Series(1).Points.AddXY(xMin, yMin)
        graf.Series(1).Points.AddXY(xMax, yMax)
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MetodosNumericos.Show()
    End Sub

End Class