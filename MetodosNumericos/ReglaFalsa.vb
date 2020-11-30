Imports info.lundin.math

Public Class ReglaFalsa

    Dim a As Single
    Dim b As Single
    Dim c As Integer
    Dim err(50) As Single
    Dim ec As Single
    Dim i As Integer
    Dim redon As Integer
    Dim x(50) As Single

    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tf.Text)
    End Function

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        a = ta.Text
        b = tb.Text
        c = tc.Text
        ec = 0.5 * 10 ^ (-c)
        redon = c + 2
        x(i) = ((a * f(b)) - (f(a) * b)) / ((f(b) - f(a)))
        err(i) = 1
        Do While err(i) > ec
            If f(a) * f(x(i)) < 0 Then
                b = x(i)
            Else
                a = x(i)
            End If

            i = i + 1
            x(i) = ((a * f(b)) - (f(a) * b)) / ((f(b) - f(a)))
            err(i) = Math.Abs((x(i) - x(i - 1)) / x(i))

            Salida.Rows.Add(i, Math.Round(a, redon), Math.Round(x(i), redon),
         Math.Round(b, redon),
         Math.Round(f(a), redon), Math.Round(f(x(i)), redon), Math.Round(f(b), redon),
         Math.Round(err(i), redon))

        Loop

        Salida.Rows.Add("La raiz es ", " x = ", Math.Round(x(i), redon))
        lbraiz.Text = Math.Round(x(i), redon)
    End Sub




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MetodosNumericos.Show()
    End Sub

End Class