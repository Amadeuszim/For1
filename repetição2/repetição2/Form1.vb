Public Class Form1

    Private Sub btnpar_Click(sender As Object, e As EventArgs) Handles btnpar.Click
        For numero As Integer = 0 To 10 Step 2
            MsgBox(numero)
        Next
    End Sub

    Private Sub btnvoltar_Click(sender As Object, e As EventArgs) Handles btnvoltar.Click
        For numero As Integer = 30 To 0 Step -1
            MsgBox(numero)
        Next
    End Sub
End Class
