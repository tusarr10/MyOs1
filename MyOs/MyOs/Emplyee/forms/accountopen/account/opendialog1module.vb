Imports System.Data.SqlClient



Module opendialog1module
    Function insertdata()
        Try

            databaseconnection = New SqlConnection(ConnectionHelper.connectionString(""))
            Dim thiscommand As String = "insert into liveaccount ()values()"
            datacommand = New SqlCommand(thiscommand, databaseconnection)
            databaseconnection.Open()
            Dim i
            i = datacommand.ExecuteNonQuery()
            If i > 0 Then
                '  MsgBox("Record successfully saved")
                'TODO

            Else
                MsgBox("Record Not saved ", MsgBoxStyle.Critical)
            End If
            databaseconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
            databaseconnection.Close()

        End Try
    End Function
    Function updatedata()

    End Function

End Module
