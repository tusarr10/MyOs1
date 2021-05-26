Imports System.Configuration
Imports System.Data.OleDb

Module DataHelpercifdb

    Sub cifsearch(ByVal cif As String)

        Dim cs As String = ConnectionHelper.connectionString(databasesource)
        databaseconnection = New OleDbConnection(cs)
        databaseconnection.Open()
        currentrow = 0
        dataadapter = New OleDbDataAdapter("SELECT * FROM cifdb where cif='" & cif & "'", databaseconnection)

        dataadapter.Fill(datasetcifdb, "cifdb")
        'ShowData(currentrow)

        databaseconnection.Close()

    End Sub
    Sub accountsearch(ByVal cif As String)

        Dim cs As String = ConnectionHelper.connectionString(databasesource)
        databaseconnection = New OleDbConnection(cs)
        databaseconnection.Open()
        currentrow = 0
        dataadapter = New OleDbDataAdapter("SELECT * FROM liveaccount where accountnumber='" & cif & "'", databaseconnection)

        dataadapter.Fill(datasetcifdb, "liveaccount")
        'ShowData(currentrow)

        databaseconnection.Close()

    End Sub
    '''<summary>
    '''enter database command For cif database
    ''' for example.../n
    ''' {insert into 'name of database ' ('name of column','name of column'...) values('value','value',...)}
    '''</summary>
    Sub incertcif(ByVal command As String) '"insert into cifdb(cif) values(" & "'" & cif & "')"
        Try

            databaseconnection = New OleDbConnection(ConnectionHelper.connectionString(databasesource))
            datacommand = New OleDbCommand(command, databaseconnection)
            databaseconnection.Open()
            Dim i
            i = datacommand.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Record successfully saved")

            Else
                MsgBox("Record Not saved", MsgBoxStyle.Critical)
            End If
            databaseconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
            databaseconnection.Close()

        End Try
    End Sub

    'Private Sub ShowData(ByVal CurrentRow)
    '    Try
    '        Id.Text = Dst.Tables("empinfo").Rows(CurrentRow)("Id")
    '        FName.Text = Dst.Tables("empinfo").Rows(CurrentRow)("FName")
    '        LName.Text = Dst.Tables("empinfo").Rows(CurrentRow)("LName")
    '        Designation.Text = Dst.Tables("empinfo").Rows(CurrentRow)("Designation")
    '        Salary.Text = Dst.Tables("empinfo").Rows(CurrentRow)("Salary")

    '    Catch ex As Exception
    '        MsgBox(ex.Message, "error")
    '    End Try
    'End Sub
    Function getcif(ByVal currentrow) As String
        Try : Return CType(datasetcifdb.Tables("cifdb").Rows(currentrow)("cif"), String)
        Catch
        Return Nothing
        End Try
    End Function
    Function getcifname(ByVal currentrow) As String
        Try
            Return CType(datasetcifdb.Tables("cifdb").Rows(currentrow)("n_ame"), String)
        Catch
            Return Nothing
        End Try

    End Function
    Function getcifmobile(ByVal currentrow) As String
        Try : Return CType(datasetcifdb.Tables("cifdb").Rows(currentrow)("mobile"), String)
        Catch
        Return Nothing
        End Try
    End Function
    Function getcifemail(ByVal currentrow) As String
        Try
            Return CType(datasetcifdb.Tables("cifdb").Rows(currentrow)("email"), String)
        Catch
            Return Nothing
        End Try
    End Function
    Function getcifpan(ByVal currentrow) As String
        Try
            Return CType(datasetcifdb.Tables("cifdb").Rows(currentrow)("pan"), String)
        Catch
            Return Nothing
        End Try
    End Function
    Function getcifadhar(ByVal currentrow) As String
        Try : Return CType(datasetcifdb.Tables("cifdb").Rows(currentrow)("adhar"), String)
        Catch
        Return Nothing
        End Try
    End Function
    Function getcifphoto(ByVal currentrow) As String
        Try : Return CType(datasetcifdb.Tables("cifdb").Rows(currentrow)("photo"), String)
        Catch
        Return Nothing
        End Try
    End Function

    Function getcifsign(ByVal currentrow) As String
        Try
            Return CType(datasetcifdb.Tables("cifdb").Rows(currentrow)("sign"), String)
        Catch
            Return Nothing
        End Try
    End Function
    Function getcifaddress(ByVal currentrow) As String
        Try
            Return CType(datasetcifdb.Tables("cifdb").Rows(currentrow)("address"), String)
        Catch
            Return Nothing
        End Try
    End Function
    Function getcifdob(ByVal currentrow) As String
        Try : Return CType(datasetcifdb.Tables("cifdb").Rows(currentrow)("dob"), String)
        Catch
        Return Nothing
        End Try
    End Function
    Function getcifgender(ByVal currentrow) As String
        Try : Return CType(datasetcifdb.Tables("cifdb").Rows(currentrow)("gender"), String)
        Catch
        Return Nothing
        End Try
    End Function


End Module
