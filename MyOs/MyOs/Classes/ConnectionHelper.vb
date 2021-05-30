Imports System.Configuration
Imports System.Data.SqlClient




Module ConnectionHelper

    Public databaseconnectionstring As String = ""

    Public bdatareader As SqlDataReader = Nothing

    Public datatable As DataTable

    Public databaseconnection As SqlConnection = Nothing

    Public dataadapter As SqlDataAdapter

    Public datasetcifdb As New DataSet 'for cifdb
    Public datasetliveaccount As New DataSet ' for live account

    Public datacommand As SqlCommand = Nothing

    Public currentrow As Object


    Public databasesource As String = ConfigurationSettings.AppSettings("dbsource").ToString()


    Function connectionString(ByVal databasename As String, ByVal databasepassword As String) As String
        databaseconnectionstring = "server=tmedia ; database=" & databasename & ";user=tusar;password=tusarranjan"
        Return databaseconnectionstring
    End Function
    Function connectionString(ByVal databasename As String) As String
        databaseconnectionstring = "server=tmedia ; database=" & databasename & ";user=tusar;password=tusarranjan"
        Return databaseconnectionstring
    End Function

End Module
