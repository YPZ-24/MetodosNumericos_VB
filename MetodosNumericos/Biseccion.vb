﻿Imports info.lundin.math
Public Class Biseccion

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

    Private Sub nav_Home_Click(sender As Object, e As EventArgs) Handles nav_Home.Click
        Me.Close()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        a = ta.Text
        b = tb.Text
        c = tc.Text
        ec = 0.5 * 10 ^ (-c)
        redon = c + 2
        x(i) = (a + b) / 2
        Err(i) = 1
        Do While Err(i) > ec
            If f(a) * f(x(i)) < 0 Then
                b = x(i)
            Else
                a = x(i)
            End If

            i = i + 1
            x(i) = (a + b) / 2
            Err(i) = Math.Abs((x(i) - x(i - 1)) / x(i))

            Salida.Rows.Add(i, Math.Round(a, redon), Math.Round(x(i), redon),
         Math.Round(b, redon),
         Math.Round(f(a), redon), Math.Round(f(x(i)), redon), Math.Round(f(b), redon),
         Math.Round(Err(i), redon))

        Loop

        Salida.Rows.Add("La raiz es ", " x = ", Math.Round(x(i), redon))
        lbraiz.Text = Math.Round(x(i), redon)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MetodosNumericos.Show()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Salida.Rows.Clear()
        lbraiz.Text = "Aún no se ha encontrado"
        tc.Text = ""
        tf.Text = ""
        ta.Text = ""
        tb.Text = ""
    End Sub
End Class