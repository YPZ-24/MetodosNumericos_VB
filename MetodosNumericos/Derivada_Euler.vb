Imports info.lundin.math

Public Class Derivada_Euler

    Dim c, redon, i As Integer
    Dim h, xf As Single
    Dim inte(500), err(500) As Single
    Dim y(500), x(500) As Single

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

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        h = th.Text
        x(0) = tx0.Text
        y(0) = ty0.Text
        xf = txf.Text
        c = tc.Text
        redon = c + 2
        Salida.Rows.Add(Math.Round(x(0), redon), Math.Round(y(0), redon))

        i = 0
        Do While x(i) < xf
            y(i + 1) = y(i) + h * (f(x(i), y(i)))
            x(i + 1) = x(i) + h
            Salida.Rows.Add(Math.Round(x(i + 1), redon), Math.Round(y(i + 1), redon))
            i = i + 1
        Loop

    End Sub






    Private Sub nav_Home_Click(sender As Object, e As EventArgs) Handles nav_Home.Click
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MetodosNumericos.Show()
    End Sub


End Class