Public Class accountopen2

    Dim gender As String

    Private Sub accountopen2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            ''TODO

        Catch ex As Exception

        Finally
            Me.Hide()
            accountopen3.ShowDialog()
            accountopen3.BringToFront()
        End Try
    End Sub

    Private Sub accountopen2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click ' update command for cif database

    End Sub
End Class