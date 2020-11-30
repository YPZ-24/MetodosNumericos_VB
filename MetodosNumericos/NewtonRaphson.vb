Imports info.lundin.math
Public Class NewtonRaphson

    Dim c As Integer
    Dim err(50) As Single
    Dim ec As Single
    Dim i As Integer
    Dim redon As Integer
    Dim x(50) As Single

    Function fNormal(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tf.Text)
    End Function

    Function fDerivada(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tfd.Text)
    End Function


    Private Sub BtnCalcular_NR_Click(sender As Object, e As EventArgs) Handles BtnCalcular_NR.Click
        Salida.Rows.Clear()
        c = tc.Text
        ec = 0.5 * 10 ^ (-c)
        redon = c + 2
        x(i) = txi.Text
        err(i) = 1
        Do While err(i) > ec
            Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(err(i), redon))
            i = i + 1
            x(i) = x(i - 1) - (fNormal(x(i - 1)) / fDerivada(x(i - 1)))
            err(i) = Math.Abs((x(i) - x(i - 1)) / x(i))
        Loop
        Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(err(i), redon))

        Salida.Rows.Add("La raiz es ", " x = ", Math.Round(x(i), redon))
        lbraiz.Text = Math.Round(x(i), redon)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MetodosNumericos.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class