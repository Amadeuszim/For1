Public Class frmrepete

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        For i = 1 To 10
            MsgBox("to passando aqui")
            Label1.Text = i
        Next
        MsgBox("Acabou!!!")
        Close()
    End Sub
End Class
