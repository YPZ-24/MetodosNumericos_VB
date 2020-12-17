Public Class MetodosNumericos
    Private Sub nav_Bi_Click(sender As Object, e As EventArgs) Handles nav_Bi.Click
        Biseccion.Show()
        Me.Hide()
    End Sub

    Private Sub nav_Im_Click(sender As Object, e As EventArgs) Handles nav_Im.Click
        Impares.Show()
        Me.Hide()
    End Sub

    Private Sub nav_R2_Click(sender As Object, e As EventArgs) Handles nav_R2.Click
        RaizCuadradaDeDos.Show()
        Me.Hide()
    End Sub

    Private Sub nav_RF_Click(sender As Object, e As EventArgs) Handles nav_RF.Click
        ReglaFalsa.Show()
        Me.Hide()
    End Sub

    Private Sub nav_NR_Click(sender As Object, e As EventArgs) Handles nav_NR.Click
        NewtonRaphson.Show()
        Me.Hide()
    End Sub

    Private Sub nav_Ja_Click(sender As Object, e As EventArgs) Handles nav_Ja.Click
        Jacobi.Show()
        Me.Hide()
    End Sub

    Private Sub nav_GS_Click(sender As Object, e As EventArgs) Handles nav_GS.Click
        GaussSeidel.Show()
        Me.Hide()
    End Sub

    Private Sub nav_IN_Click(sender As Object, e As EventArgs) Handles nav_IN.Click
        InterpolacionNewton.Show()
        Me.Hide()
    End Sub

    Private Sub nav_IL_Click(sender As Object, e As EventArgs) Handles nav_IL.Click
        InterpolacionLagrange.Show()
        Me.Hide()
    End Sub

    Private Sub nav_MC_Click(sender As Object, e As EventArgs) Handles nav_MC.Click
        MinimosCuadrados.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Integracion_Rectangulos.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Integracion_Trapecio.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Integracion_Simpson.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Integracion_CuadraturaGauss.Show()
        Me.Hide()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Derivada_Euler.Show()
        Me.Hide()
    End Sub
End Class
