Imports System.Data.SqlClient


Module DataHelpercifdb
    Public cifupdate As Boolean = False

    Sub cifsearch(ByVal cif As String)

        Dim cs As String = ConnectionHelper.connectionString(databasesource)
        databaseconnection = New SqlConnection(cs)
        databaseconnection.Open()
        currentrow = 0
        dataadapter = New SqlDataAdapter("SELECT * FROM cifdb where cif='" & cif & "'", databaseconnection)

        dataadapter.Fill(datasetcifdb, "cifdb")
        'ShowData(currentrow)

        databaseconnection.Close()

    End Sub
    Sub accountsearch(ByVal cif As String)

        Dim cs As String = ConnectionHelper.connectionString("")
        databaseconnection = New SqlConnection(cs)
        databaseconnection.Open()
        currentrow = 0
        dataadapter = New SqlDataAdapter("SELECT * FROM liveaccount where accountnumber='" & cif & "'", databaseconnection)

        dataadapter.Fill(datasetcifdb, "liveaccount")
        'ShowData(currentrow)

        databaseconnection.Close()

    End Sub
    Function IsIdExist(ByVal matchingcif As String) As Boolean
        Dim Str, Str1 As String
        Dim i As Integer

        Str = matchingcif ' searchciftb.Text
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
    Function IsAccountExist(ByVal matchingaccount As String) As Boolean
        Dim Str, Str1 As String
        Dim i As Integer

        Str = matchingaccount 'searchciftb.Text
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
    Sub incertcif(ByVal command As String) '"insert into cifdb(cif) values(" & "'" & cif & "')"
        Try

            databaseconnection = New SqlConnection(ConnectionHelper.connectionString(""))
            datacommand = New SqlCommand(command, databaseconnection)
            databaseconnection.Open()
            Dim i
            i = datacommand.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Record successfully saved /update")

            Else
                MsgBox("Record Not saved /update", MsgBoxStyle.Critical)
            End If
            databaseconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
            databaseconnection.Close()

        End Try
    End Sub


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
