Imports info.lundin.math

Public Class Integracion_Simpson

    Dim c, redon, i As Integer
    Dim h, a, b, n, suma1, suma2, res, ec As Single

    Dim inte(500), err(500) As Single
    Dim g As Graphics

    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tf.Text)
    End Function

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        n = 10
        a = ta.Text
        b = tb.Text
        c = tc.Text
        h = (b - a) / (2 * n)
        redon = c + 2
        ec = 0.5 * 10 ^ (-c)


        For k = 1 To n - 1 Step 1
            suma1 += f(a + (2 * k - 1) * h)
            suma2 += f(a + (2 * k * h))
        Next
        'inte(i) = h * suma
        inte(i) = (h / 3) * (f(a) - f(b) + (4 * suma1) + (2 * suma2))
        Salida.Rows.Add(n, Math.Round(inte(i), redon), "----")

        err(i) = 1
        Do While err(i) > ec
            suma1 = 0
            suma2 = 0
            n += 10
            i += 1
            h = (b - a) / (2 * n)
            For k = 1 To n - 1 Step 1
                suma1 += f(a + (2 * k - 1) * h)
                suma2 += f(a + (2 * k * h))
            Next
            'inte(i) = h * suma
            inte(i) = (h / 3) * (f(a) - f(b) + (4 * suma1) + (2 * suma2))

            err(i) = Math.Abs((inte(i) - inte(i - 1)) / inte(i))
            Salida.Rows.Add(n, Math.Round(inte(i), redon), Math.Round(err(i), redon))
        Loop

    End Sub

    Private Sub btnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click
        g = CreateGraphics()
        Dim vari As Single = a

        Do While vari <= b
            grafica.Series(0).Points.AddXY(Math.Round(vari, 1), f(vari))
            vari += 0.1
        Loop

    End Sub





    Private Sub nav_Home_Click(sender As Object, e As EventArgs) Handles nav_Home.Click
        Me.Close()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MetodosNumericos.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class