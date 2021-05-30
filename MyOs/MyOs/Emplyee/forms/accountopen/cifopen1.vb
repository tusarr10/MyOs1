Imports System.ComponentModel

Public Class cifopen1
    Private Sub accopen1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' e.Cancel = True
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            subfilldata()
        Catch ex As Exception

        Finally

        End Try
    End Sub
    ''' <summary>
    ''' Get data from cifdb 
    ''' </summary>
    ' get name and all details from cif database if available
    Private Sub subfilldata()

        Try
            DataHelpercifdb.cifsearch(Me.searchciftb.Text)
            DataHelpercifdb.accountsearch(Me.searchactb.Text)



            If IsIdExist(searchciftb.Text) = True Then
                info.cifexist = True

                '''<summary>
                ''' check if account exist
                ''' </summary>
                If IsAccountExist(searchactb.Text) = True Then
                    info.accountexist = True ' send status to info module so that it can be use latter 

                    MsgBox("Account Already Exist..Just Update CIF")
                    Try
                        cifopen2.acnolb.Text = CType(datasetcifdb.Tables("liveaccount").Rows(0)("accountnumber"), String)
                    Catch ex As Exception

                    End Try
                Else
                    cifopen2.acnolb.Text = ""
                End If
                Try
                    If DataHelpercifdb.getcif(0) = Nothing Then

                    Else
                        cifopen2.ciftb.Text = DataHelpercifdb.getcif(0)
                        cifopen2.ciftb.Enabled = False

                    End If
                    If DataHelpercifdb.getcifname(0) IsNot Nothing Then
                        cifopen2.nametb.Text = DataHelpercifdb.getcifname(0)
                        cifopen2.nametb.Enabled = False

                    End If
                    If DataHelpercifdb.getcifemail(0) IsNot Nothing Then
                        cifopen2.emailtb.Text = DataHelpercifdb.getcifemail(0)
                        cifopen2.emailtb.Enabled = False

                    End If
                    If DataHelpercifdb.getcifmobile(0) IsNot Nothing Then
                        cifopen2.mobiletb.Text = DataHelpercifdb.getcifmobile(0)
                        cifopen2.mobiletb.Enabled = False

                    End If
                    If DataHelpercifdb.getcifpan(0) IsNot Nothing Then
                        cifopen2.pantb.Text = DataHelpercifdb.getcifpan(0)
                        cifopen2.pantb.Enabled = False

                    End If
                    If DataHelpercifdb.getcifadhar(0) IsNot Nothing Then
                        cifopen2.adhartb.Text = DataHelpercifdb.getcifadhar(0)
                        cifopen2.adhartb.Enabled = False

                    End If
                    If DataHelpercifdb.getcifdob(0) IsNot Nothing Then
                        cifopen2.dobtb.Text = DataHelpercifdb.getcifdob(0)
                        cifopen2.dobtb.Enabled = False
                    End If
                    If DataHelpercifdb.getcifgender(0) IsNot Nothing Then
                        If DataHelpercifdb.getcifgender(0) = "Male" Then
                            cifopen2.RadioGroup1.SelectedIndex = 0
                        ElseIf DataHelpercifdb.getcifgender(0) = "Female" Then
                            cifopen2.RadioGroup1.SelectedIndex = 1
                        ElseIf DataHelpercifdb.getcifgender(0) = "Other" Then
                            cifopen2.RadioGroup1.SelectedIndex = 2
                        End If
                        cifopen2.RadioGroup1.Enabled = False

                    End If
                    If DataHelpercifdb.getcifaddress(0) IsNot Nothing Then
                        cifopen2.addresstb.Text = DataHelpercifdb.getcifaddress(0)
                        cifopen2.addresstb.Enabled = False

                    End If
                    If getcifaddress(0) IsNot Nothing And getcifadhar(0) IsNot Nothing And getcifdob(0) IsNot Nothing And getcifemail(0) IsNot Nothing And getcifgender(0) IsNot Nothing And getcifmobile(0) IsNot Nothing And getcifname(0) IsNot Nothing And getcifpan(0) IsNot Nothing Then
                        DataHelpercifdb.cifupdate = True

                    End If

                    Me.Hide()
                    cifopen2.ShowDialog()
                    cifopen2.BringToFront()
                Catch ex As Exception

                Finally

                End Try
            ElseIf IsIdExist(searchciftb.Text) = False Then
                'TODO
                info.cifexist = False

                DataHelpercifdb.incertcif("insert into cifdb(cif)values('" & searchciftb.Text & "')")
                MsgBox("click Again")
                Exit Try
            End If
        Catch ex As Exception
        Finally
        End Try
    End Sub

    Private Sub accopen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class