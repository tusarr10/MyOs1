Imports System.Configuration
Imports System.Data.OleDb



Module ConnectionHelper

    Public databaseconnectionstring As String = ""

    Public bdatareader As OleDbDataReader = Nothing

    Public datatable As DataTable

    Public databaseconnection As OleDbConnection = Nothing

    Public dataadapter As OleDbDataAdapter

    Public datasetcifdb As New DataSet 'for cifdb
    Public datasetliveaccount As New DataSet ' for live account

    Public datacommand As OleDbCommand = Nothing

    Public currentrow As Object


    Public databasesource As String = ConfigurationSettings.AppSettings("dbsource").ToString()

    Dim configurationstring As String = ConfigurationSettings.AppSettings("dbconnectionstring").ToString()


    Function connectionString(ByVal databasename As String, ByVal databasepassword As String) As String
        databaseconnectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + databasename & ";Jet OLEDB:Database Password=" & databasepassword & ";"
        Return databaseconnectionstring
    End Function
    Function connectionString(ByVal databasename As String) As String
        databaseconnectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + databasename & ";"
        Return databaseconnectionstring
    End Function

End Module
