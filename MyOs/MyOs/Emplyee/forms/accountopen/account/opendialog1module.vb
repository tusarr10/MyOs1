Imports System.Data.SqlClient



Module opendialog1module


    ''' <summary>
    ''' Use In Insert account Number and Name In Live account
    ''' </summary>
    ''' <param name="accountNumber">Value of account Number As String</param>
    ''' <param name="Name"> Value Of name field i live account table</param>
    ''' <returns>Success Message When Data Save</returns>
    Function insertdata(ByVal accountNumber As String, ByVal cif As String, ByVal name As String) As String
        Try

            databaseconnection = New SqlConnection(ConnectionHelper.connectionString(""))
            Dim thiscommand As String = "insert into liveaccount (accountnumber,cif,n_ame)values('" & accountNumber & "','" & cif & "','" & name & "')" ' to insert data in new live account table

            datacommand = New SqlCommand(thiscommand, databaseconnection)
            databaseconnection.Open()
            Dim i
            i = datacommand.ExecuteNonQuery()
            If i > 0 Then
                '  MsgBox("Record successfully saved")
                'TODO
                Return "Success"
            Else
                MsgBox("Record Not saved ", MsgBoxStyle.Critical)
            End If
            databaseconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
            databaseconnection.Close()
            Return "Error"
        End Try
        Return Nothing
    End Function
    Function insertdatainproduct(ByVal accountnumber As String) As String
        Try

            databaseconnection = New SqlConnection(ConnectionHelper.connectionString(""))
            Dim thiscommand As String = "insert into producttype (accountnumber)values('" & accountnumber & "')" ' to insert data in new live account table

            datacommand = New SqlCommand(thiscommand, databaseconnection)
            databaseconnection.Open()
            Dim i
            i = datacommand.ExecuteNonQuery()
            If i > 0 Then
                '  MsgBox("Record successfully saved")
                'TODO
                Return "Success"
            Else
                MsgBox("Record Not add in product type .. ", MsgBoxStyle.Critical)
                'TODO 
                'add data to anther record for future correct
            End If
            databaseconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
            databaseconnection.Close()
            Return "Error"
        End Try
        Return Nothing
    End Function
    ''' <summary>
    ''' insert data into Noimini table 
    ''' </summary>
    ''' <param name="accountnumber">Enter Account Number ...</param>
    ''' <returns>return a message "Success" if success or "Else"</returns>
    Function insertdatinnomini(ByVal accountnumber As String) As String
        Try

            databaseconnection = New SqlConnection(ConnectionHelper.connectionString(""))
            Dim thiscommand As String = "insert into nominiinfo (accountnumber)values('" & accountnumber & "')" ' to insert data in new live account table

            datacommand = New SqlCommand(thiscommand, databaseconnection)
            databaseconnection.Open()
            Dim i
            i = datacommand.ExecuteNonQuery()
            If i > 0 Then
                '  MsgBox("Record successfully saved")
                'TODO
                Return "Success"
            Else
                MsgBox("Record Not Add in Nominitable .. ", MsgBoxStyle.Critical)
            End If
            databaseconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
            databaseconnection.Close()
            Return "Error"
        End Try
        Return Nothing
    End Function
    Function insertdatainoperatemode(ByVal accountnumber As String) As String
        Try

            databaseconnection = New SqlConnection(ConnectionHelper.connectionString(""))
            Dim thiscommand As String = "insert into accountopratemode (accountnumber)values('" & accountnumber & "')" ' to insert data in new live account table

            datacommand = New SqlCommand(thiscommand, databaseconnection)
            databaseconnection.Open()
            Dim i
            i = datacommand.ExecuteNonQuery()
            If i > 0 Then
                '  MsgBox("Record successfully saved")
                'TODO
                Return "Success"
            Else
                MsgBox("Record Not Add in Nominitable .. ", MsgBoxStyle.Critical)
            End If
            databaseconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
            databaseconnection.Close()
            Return "Error"
        End Try
        Return Nothing
    End Function
    Function updatedata() As String

        Return Nothing
    End Function

End Module
