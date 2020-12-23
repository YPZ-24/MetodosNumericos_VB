Imports info.lundin.math

Public Class Integracion_CuadraturaGauss

    Dim c, redon, i As Integer
    Dim h, a, b, n, suma, ec As Single
    Dim fila As Integer
    Dim xk, ck As Single
    Dim inte(500), err(500) As Single
    Dim g As Graphics
    Dim ExcelApp = New Microsoft.Office.Interop.Excel.Application
    Dim path As String = Environment.CurrentDirectory + "\" + "tablaSubdivisiones"
    Dim Libro = ExcelApp.Workbooks.Open(Filename:=path)

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ta.Text = ""
        tb.Text = ""
        tc.Text = ""
        tf.Text = ""
        lbresu.Text = ""
        Salida.Rows.Clear()
        grafica.Series(0).Points.Clear()
        grafica.Series(1).Points.Clear()
    End Sub

    Private Sub btnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click
        g = CreateGraphics()
        Dim vari As Single = a

        Do While vari <= b
            grafica.Series(1).Points.AddXY(Math.Round(vari, 1), f(vari))
            grafica.Series(0).Points.AddXY(Math.Round(vari, 1), f(vari))
            vari += 0.1
        Loop
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        n = 1
        a = ta.Text
        b = tb.Text
        c = tc.Text
        h = (b - a) / (2 * n)
        redon = c + 2
        ec = 0.5 * 10 ^ (-c)

        'Calculando la fila
        For Each celda In Libro.Sheets(1).Range("A2:A30")
            If celda.Value = n Then
                fila = celda.Row
            End If
        Next

        'Cuadratura de Gauss
        For k = 1 To n Step 1
            xk = Libro.Sheets(1).Cells(fila + (k - 1), 3).Value
            ck = Libro.Sheets(1).Cells(fila + (k - 1), 4).Value
            suma += ck * f(((b + a) / 2) + ((b - a) / 2) * xk)
        Next
        inte(i) = ((b - a) / 2) * suma

        Salida.Rows.Add(n, Math.Round(inte(i), redon), "----")

        err(i) = 1
        Do While err(i) > ec
            suma = 0
            n += 1
            i += 1
            h = (b - a) / (2 * n)

            'Calculando la fila
            For Each celda In Libro.Sheets(1).Range("A2:A30")
                If celda.Value = n Then
                    fila = celda.Row
                End If
            Next

            'Cuadratura de Gauss
            For k = 1 To n Step 1
                xk = Libro.Sheets(1).Cells(fila + (k - 1), 3).Value
                ck = Libro.Sheets(1).Cells(fila + (k - 1), 4).Value
                suma += ck * f(((b + a) / 2) + ((b - a) / 2) * xk)
            Next
            inte(i) = ((b - a) / 2) * suma

            err(i) = Math.Abs((inte(i) - inte(i - 1)) / inte(i))
            Salida.Rows.Add(n, Math.Round(inte(i), redon), Math.Round(err(i), redon))
        Loop

        lbresu.Text = Math.Round(inte(i), redon)

    End Sub

    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("e", Math.E)
        parser.Values.Add("pi", Math.PI)
        Return parser.Parse(tf.Text)
    End Function

    Private Sub nav_Home_Click(sender As Object, e As EventArgs) Handles nav_Home.Click
        Me.Close()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Libro.Close()
        ExcelApp.Quit()
        MetodosNumericos.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class