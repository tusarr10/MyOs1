Public Class cifopen2

    Private Sub accountopen2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            ''TODO

        Catch ex As Exception

        Finally
            If info.accountexist = False Then
                Me.Hide()

                accopendialog1.ShowDialog()
                accopendialog1.BringToFront()
            Else
                MsgBox("Account Already Exist..")
            End If

        End Try
    End Sub

    Private Sub accountopen2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cifupdate = True Then
            SimpleButton1.Enabled = True

        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click ' update command for cif database
        Try
            subupdatedata()
            'GOTO accountopen3
            SimpleButton1.Enabled = True

        Catch ex As Exception

        Finally

        End Try
    End Sub

    Private Sub subupdatedata()
        Dim gender As String = "Male"

        If RadioGroup1.SelectedIndex = 0 Then
            gender = "Male"
        ElseIf RadioGroup1.SelectedIndex = 1 Then
            gender = "Female"
        ElseIf RadioGroup1.SelectedIndex = 2 Then
            gender = "Other"
        End If
        DataHelpercifdb.incertcif("Update cifdb set n_ame='" & nametb.Text & "',mobile= '" & mobiletb.Text & "',email='" & emailtb.Text & "',pan='" & pantb.Text & "',adhar='" & adhartb.Text & "',photo='" & "x" & "',sign='" & "y" & "',address='" & addresstb.Text & "',dob='" & dobtb.Text & "',gender='" & gender & "' where cif='" & ciftb.Text & "'")
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        MsgBox("Cif Update Successful .. Open Account latter ..")
        Me.Close()

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        nametb.Enabled = True
        emailtb.Enabled = True
        mobiletb.Enabled = True
        pantb.Enabled = True
        adhartb.Enabled = True
        dobtb.Enabled = True
        RadioGroup1.Enabled = True
        photobx.Enabled = True
        signbx.Enabled = True
        addresstb.Enabled = True

    End Sub
End Class