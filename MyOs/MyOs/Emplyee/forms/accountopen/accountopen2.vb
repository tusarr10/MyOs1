Public Class accountopen2
    Private Sub accountopen2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            ''TODO

        Catch ex As Exception

        Finally
            accountopen3.MdiParent = Me
            accountopen3.WindowState = FormWindowState.Normal
            accountopen3.Show()
            accountopen3.BringToFront()
        End Try
    End Sub
End Class