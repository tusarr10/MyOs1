Imports System.ComponentModel
Imports System.Data.OleDb

Public Class accopen1
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
            If IsIdExist() = True Then
                'TODO
                '''<summary>
                ''' check if account exist
                ''' </summary>
                If IsAccountExist() = True Then
                    MsgBox("Account Already Exist..Just Update CIF")
                    Try
                        accountopen2.acnolb.Text = CType(datasetcifdb.Tables("liveaccount").Rows(0)("accountnumber"), String)
                    Catch ex As Exception

                    End Try

                End If
                Try
                    If DataHelpercifdb.getcif(0) = Nothing Then

                    Else
                        accountopen2.ciftb.Text = DataHelpercifdb.getcif(0)
                        accountopen2.ciftb.Enabled = False

                    End If
                    If DataHelpercifdb.getcifname(0) IsNot Nothing Then
                        accountopen2.nametb.Text = DataHelpercifdb.getcifname(0)
                        accountopen2.nametb.Enabled = False

                    End If
                    If DataHelpercifdb.getcifemail(0) IsNot Nothing Then
                        accountopen2.emailtb.Text = DataHelpercifdb.getcifemail(0)
                        accountopen2.emailtb.Enabled = False

                    End If
                    If DataHelpercifdb.getcifmobile(0) IsNot Nothing Then
                        accountopen2.mobiletb.Text = DataHelpercifdb.getcifmobile(0)
                        accountopen2.mobiletb.Enabled = False

                    End If
                    If DataHelpercifdb.getcifpan(0) IsNot Nothing Then
                        accountopen2.pantb.Text = DataHelpercifdb.getcifpan(0)
                        accountopen2.pantb.Enabled = False

                    End If
                    If DataHelpercifdb.getcifadhar(0) IsNot Nothing Then
                        accountopen2.adhartb.Text = DataHelpercifdb.getcifadhar(0)
                        accountopen2.adhartb.Enabled = False

                    End If
                    If DataHelpercifdb.getcifdob(0) IsNot Nothing Then
                        accountopen2.dobtb.Text = DataHelpercifdb.getcifdob(0)
                        accountopen2.dobtb.Enabled = False
                    End If
                    If DataHelpercifdb.getcifgender(0) IsNot Nothing Then
                        If DataHelpercifdb.getcifgender(0) = "Male" Then
                            accountopen2.RadioGroup1.SelectedIndex = 0
                        ElseIf DataHelpercifdb.getcifgender(0) = "Female" Then
                            accountopen2.RadioGroup1.SelectedIndex = 1
                        ElseIf DataHelpercifdb.getcifgender(0) = "Other" Then
                            accountopen2.RadioGroup1.SelectedIndex = 2
                        End If
                        accountopen2.RadioGroup1.Enabled = False

                    End If
                    If DataHelpercifdb.getcifaddress(0) IsNot Nothing Then
                        accountopen2.addresstb.Text = DataHelpercifdb.getcifaddress(0)
                        accountopen2.addresstb.Enabled = False

                    End If

                    'accountopen2.ciftb.Text = DataHelpercifdb.getcifphoto(0)
                    'accountopen2.ciftb.Text = DataHelpercifdb.getcifsign(0)  'photo and sign not upload
                    Me.Hide()
                    accountopen2.ShowDialog()
                    accountopen2.BringToFront()
                Catch ex As Exception

                Finally

                End Try
            ElseIf IsIdExist() = False Then
                'TODO

                DataHelpercifdb.incertcif("insert into cifdb(cif)values('" & searchciftb.Text & "')")
                MsgBox("click Again")
                Exit Try
            End If
        Catch ex As Exception
        Finally
        End Try
    End Sub
    Private Function IsIdExist() As Boolean
        Dim Str, Str1 As String
        Dim i As Integer

        Str = searchciftb.Text
        i = 0
        While i <> datasetcifdb.Tables("cifdb").Rows.Count
            Str1 = CType(datasetcifdb.Tables("cifdb").Rows(i)("cif"), String)

            If Str = Str1 Then
                Return True

            End If
            i += 1


        End While
        Return False
    End Function
    Private Function IsAccountExist() As Boolean
        Dim Str, Str1 As String
        Dim i As Integer

        Str = searchciftb.Text
        i = 0
        While i <> datasetcifdb.Tables("liveaccount").Rows.Count
            Str1 = CType(datasetcifdb.Tables("liveaccount").Rows(i)("accountnumber"), String)

            If Str = Str1 Then
                Return True

            End If
            i += 1


        End While
        Return False

    End Function
    Private Sub accopen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class