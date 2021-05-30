Imports System.Windows.Forms

Public Class accopendialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            DataHelpercifdb.cifsearch(Me.scciftb.Text)
            DataHelpercifdb.accountsearch(Me.scacnotb.Text)
            If IsAccountExist(scacnotb.Text) = True Then
                getnametb.Text = CType(datasetcifdb.Tables("liveaccount").Rows(0)("n_ame"), String)
                MsgBox("Account Already Exist")
            Else
                getnametb.Text = ""
            End If
            If IsIdExist(scciftb.Text) = True Then
                If DataHelpercifdb.getcifname(0) IsNot Nothing Then
                    getnametb.Text = DataHelpercifdb.getcifname(0)

                Else
                    MsgBox("first Update Cif")
                    Exit Sub


                End If
            Else

            End If
        Catch ex As Exception

        Finally

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            DataHelpercifdb.cifsearch(Me.scciftb.Text)
            DataHelpercifdb.accountsearch(Me.scacnotb.Text)
            If IsIdExist(scciftb.Text) = True Then
                If DataHelpercifdb.getcifname(0) IsNot Nothing Then
                    getnametb.Text = DataHelpercifdb.getcifname(0)

                Else
                    MsgBox("first Update Cif")
                    Exit Sub


                End If
            Else

            End If
        Catch ex As Exception

        End Try

    End Sub
End Class
