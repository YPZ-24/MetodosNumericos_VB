Public Class RaizCuadradaDeDos
    Dim i As Integer
    Dim c As Integer
    Dim x(50) As Single
    Dim ec As Single
    Dim err(50) As Single
    Dim redon As Integer

    Private Sub nav_Home_Click(sender As Object, e As EventArgs) Handles nav_Home.Click
        Me.Close()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MetodosNumericos.Show()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        x(i) = ti.Text
        c = tc.Text
        ec = 0.5 * 10 ^ (-c)
        Err(i) = 1
        redon = c + 2
        Do While Err(i) > ec
            i = i + 1
            x(i) = 0.5 * (x(i - 1) + 2 / x(i - 1))
            Err(i) = Math.Abs((x(i) - x(i - 1)) / x(i))
            Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(err(i), redon))
        Loop
        lbraiz.Text = Math.Round(x(i), redon)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class