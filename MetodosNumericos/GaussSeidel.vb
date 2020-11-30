Imports info.lundin.math

Public Class GaussSeidel
    Dim c As Integer
    Dim ec As Single
    Dim i As Integer
    Dim redon As Integer
    Dim ex(50), ey(50), ez(50) As Single
    Dim x(50), y(50), z(50) As Single

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Salida.Rows.Clear()
        lbraiz.Text = "Aún no se ha encontrado"
        tc.Text = ""
        a11.Clear()
        a12.Clear()
        a13.Clear()
        a21.Clear()
        a22.Clear()
        a23.Clear()
        a31.Clear()
        a32.Clear()
        a33.Clear()
        b1.Clear()
        b2.Clear()
        b3.Clear()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MetodosNumericos.Show()
    End Sub

    Private Sub nav_Home_Click(sender As Object, e As EventArgs) Handles nav_Home.Click
        Me.Close()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        i = 0
        c = tc.Text
        redon = c + 2
        ec = 0.5 * 10 ^ (-c)
        ex(i) = 1 : ey(i) = 1 : ez(i) = 1
        Do While ex(i) > ec Or ey(i) > ec Or ez(i) > ec
            i = i + 1
            x(i) = (b1.Text - a12.Text * y(i - 1) - a13.Text * z(i - 1)) / a11.Text
            y(i) = (b2.Text - a21.Text * x(i) - a23.Text * z(i - 1)) / a22.Text
            z(i) = (b3.Text - a31.Text * x(i) - a32.Text * y(i)) / a33.Text
            ex(i) = Math.Abs((x(i) - x(i - 1)) / x(i))
            ey(i) = Math.Abs((y(i) - y(i - 1)) / x(i))
            ez(i) = Math.Abs((z(i) - z(i - 1)) / x(i))
            Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(y(i), redon),
            Math.Round(z(i), redon),
            Math.Round(ex(i), redon), Math.Round(ey(i), redon), Math.Round(ez(i), redon))
        Loop
        lbraiz.Text = "x = " & Math.Round(x(i), redon) & ", y = " & Math.Round(y(i), redon) & ", z = " & Math.Round(z(i), redon)
    End Sub
End Class