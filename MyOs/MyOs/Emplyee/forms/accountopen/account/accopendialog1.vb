
Public Class accopendialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

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

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        'TODO
        'when press Open A popup and show all details of cif database
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x = info.action
        If x = "new" Then
            Dim xa As String = opendialog1module.insertdata(scacnotb.Text, scciftb.Text, getnametb.Text)
            Dim y As String = opendialog1module.insertdatinnomini(scacnotb.Text)
            Dim z As String = opendialog1module.insertdatainproduct(scacnotb.Text)
            Dim k As String = opendialog1module.insertdatainoperatemode(scacnotb.Text)
            If xa = "Success" Then
                'TODO
                If y IsNot "Success" Then
                    MsgBox("Error in Nomini Table")
                End If
                If z IsNot "Success" Then
                    MsgBox("Error in Producttype table")
                End If
                If k IsNot "Success" Then
                    MsgBox("Error In Operate mOde Table")
                End If
                info.newacno = scacnotb.Text
                MsgBox("Account Open Successfully.. Complect KYC Now..")

                accountopen3.Show()
                accountopen3.BringToFront()
            End If
        ElseIf info.action = "update" Then

        End If
    End Sub
End Class
