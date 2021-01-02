Imports info.lundin.math

Public Class Derivada_RungeKutta

    Dim c, redon, i As Integer
    Dim h, xf As Single
    Dim y(500), x(500) As Single
    Dim k1(500), k2(500), k3(500), k4(500) As Single

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        tf.Text = ""
        tx0.Text = ""
        ty0.Text = ""
        txf.Text = ""
        th.Text = ""
        tc.Text = ""
        lbresu.Text = ""
        Salida.Rows.Clear()
    End Sub

    Function AreSingleEquals(n1 As Single, n2 As Single) As Boolean
        Dim acceptableDifference As Double = 0.000001
        Dim absoluteDifference As Double = Math.Abs(n1 - n2)
        Return absoluteDifference <= acceptableDifference
    End Function

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        h = th.Text
        x(0) = tx0.Text
        y(0) = ty0.Text
        xf = txf.Text
        c = tc.Text
        redon = c + 2
        Salida.Rows.Add(Math.Round(x(0), redon), Math.Round(y(0), redon))

        i = 0
        Do While (x(i) < xf) And Not AreSingleEquals(x(i), xf)
            x(i + 1) = x(i) + h

            k1(i) = f(x(i), y(i))
            k2(i) = f(x(i) + (h / 2), y(i) + (h / 2) * k1(i))
            k3(i) = f(x(i) + (h / 2), y(i) + (h / 2) * k2(i))
            k4(i) = f(x(i + 1), y(i) + h * k3(i))

            y(i + 1) = y(i) + (h / 6) * (k1(i) + 2 * k2(i) + 2 * k3(i) + k4(i))
            Salida.Rows.Add(Math.Round(x(i + 1), redon), Math.Round(y(i + 1), redon))
            i = i + 1
        Loop

        lbresu.Text = "y(" & xf & ")" & " = " & Math.Round(y(i), redon)

    End Sub

    Function f(x As Single, y As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("y", y)
        parser.Values.Add("xy", x * y)
        parser.Values.Add("yx", x * y)
        parser.Values.Add("e", Math.E)
        parser.Values.Add("pi", Math.PI)
        Return parser.Parse(tf.Text)
    End Function

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MetodosNumericos.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class