Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class SQLControl
    Public SQLCon As New SqlConnection With
        {.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Members.mdf;Integrated Security=True"}

    Public Function HasConnection() As Boolean
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function



End Class
