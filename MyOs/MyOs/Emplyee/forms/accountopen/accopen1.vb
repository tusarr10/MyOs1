Imports System.ComponentModel

Public Class accopen1
    Private Sub accopen1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            subfilldata()
        Catch ex As Exception

        Finally
            accountopen2.MdiParent = Me
            accountopen2.WindowState = FormWindowState.Normal
            accountopen2.Show()
            accountopen2.BringToFront()
        End Try
    End Sub

    ' get name and all details from cif database if available
    Private Sub subfilldata()

    End Sub
End Class