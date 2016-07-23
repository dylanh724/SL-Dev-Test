' #########################################################################
' File:             Members.vb
' Author:           Dylan Hunt (dylan@dylanh-dev.com)
' Date Created:     9/3/2014
' Date Modified:    9/9/2014 (Taiwan time)
' Purpose:          Web service with FOUR functions:
'                   (0 - Test function for simple local web service test)
'                   1 - SQLTest() to simply test connection to DB [Extra];
'                   2 - VerifyLogin() to verify user/pass against DB;
'                   3 - RegisterNewUser() to register new user info to DB.
'                   4 - CheckExistingUser() to check for already-registered
' #########################################################################

Option Strict On
Imports System.Windows.Forms
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data.SqlClient

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://dylanh-dev.com/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebService1
    Inherits System.Web.Services.WebService
    ' Global Variables
    Dim SQL As New SQLControl
    Dim SQLCmd As New SqlCommand
    Dim SQLAdapter As New SqlDataAdapter
    Dim SQLDataset As New DataSet

    ' #############################
    ' 0 - Testing web server without SQL

    '<WebMethod()> _
    'Public Function Login(UsernameEntered As String, PasswordEntered As String) As Boolean
    '    ' Placeholders
    '    Dim UsernameString As String = "DYLAN"
    '    Dim PasswordString As String = "Bloop"

    '    ' Try U+P; Username = UPPER; Password = case sensitive
    '    If UsernameEntered.ToUpper = UsernameString And PasswordEntered = PasswordString Then
    '        ' U+P matches
    '        Return True
    '    Else
    '        ' U+P does NOT match
    '        Return False
    '    End If
    'End Function

    ' /Testing web server without SQL
    '#############################

    ' 1 - Test connection to SQL
    <WebMethod()> _
    Public Function SQLTest() As Boolean
        Try
            SQL.HasConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return True

    End Function

    ' 2 - Verify login/password is correct
    <WebMethod()> _
    Public Function VerifyLogin(UsernameEntered As String, PasswordEntered As String) As Boolean
        ' SQL Variables
        Dim SQLCon = SQL.SQLCon
        'Dim SQLCmd As New SqlCommand
        'Dim SQLAdapter As New SqlDataAdapter
        'Dim SQLDataset As New DataSet

        ' Find matching U+P (case-sensitive PW)
        SQLCmd.CommandText =
            "SELECT * FROM [User] WHERE (Username='" & UsernameEntered.ToUpper &
            "') AND (password COLLATE Latin1_General_CS_AS='" & PasswordEntered & "');"
        SQLCon.Open()

        SQLCmd.Connection = SQLCon

        ' Send command to search for U+P, fill dataset
        SQLAdapter.SelectCommand = SQLCmd
        SQLAdapter.Fill(SQLDataset, "CheckCredentials")

        ' If > 0, then the U+P combo was found. Otherwise, invalid/not found.
        Dim count = SQLDataset.Tables(0).Rows.Count
        If count > 0 Then
            ' U+P valid
            Return True
        Else
            ' U+P invalid
            Return False
        End If

    End Function

    ' 3 - Register new users
    <WebMethod()> _
    Public Function RegisterNewUser(UsernameEntered As String, PasswordEntered As String,
                                    FirstNameEntered As String, LastNameEntered As String,
                                    MobilePhoneEntered As String, EmailEntered As String,
                                    BirthdayEntered As Date) As Boolean
        Dim SQLCmd As New SqlCommand
        Dim SQLAdapter As New SqlDataAdapter
        Dim SQLDataset As New DataSet

        ' Insert new user (Warning: No parameters, just basic insert for this project
        ' Vulnerable to SQL injection~ was told just basic for now.
        Try
            Dim SQLCon = SQL.SQLCon
            SQLCmd.CommandText =
                "INSERT INTO [User] ([Username], [Password], [FirstName], " &
                "[LastName], [MobilePhone], [Email], [Birthday]) VALUES ('" &
                UsernameEntered & "', '" &
                PasswordEntered & "', '" &
                FirstNameEntered & "', '" &
                LastNameEntered & "', '" &
                MobilePhoneEntered & "', '" &
                EmailEntered & "', '" &
                CStr(BirthdayEntered) & "');"
            'MessageBox.Show(SQLCmd.CommandText)
            SQLCon.Open()

            SQLCmd.Connection = SQLCon
            SQLCmd.ExecuteNonQuery()
        Catch ex As Exception
            ' Error - not registered, no connection, etc
            MessageBox.Show("Error while inserting record on table..." &
                            ex.Message, "Insert Records")
            Return False
        End Try
        ' Successfully registered
        MessageBox.Show("Successfully registered!" & vbCrLf &
                        "Please login now.", "Success")
        SQL.SQLCon.Close()
        Return True

    End Function

    ' 4 - Check if existing username, email, and phone already exist
    <WebMethod()> _
    Public Function CheckExistingUser(UsernameEntered As String, EmailEntered As String, MobilePhoneEntered As String) As Boolean
        ' SQL Variables
        Dim SQLCon = SQL.SQLCon
        Dim SQLCmd As New SqlCommand
        Dim SQLAdapter As New SqlDataAdapter
        Dim SQLDataset As New DataSet

        ' Find existing username, email, or phone:
        'SELECT * FROM [User] WHERE (Username='DYLAN') OR 
        '(MobilePhone='555-555-5552') OR 
        '(Email='asdf2@asdf.com');
        SQLCmd.CommandText =
            "SELECT * FROM [User] WHERE (Username='" & UsernameEntered.ToUpper & "');"
        'OR " &
        '"('" & MobilePhoneEntered & "') OR " &
        '"('" & EmailEntered & "');"

        SQLCon.Open()

        SQLCmd.Connection = SQLCon

        ' Send command to search for username, email or phone >> fill dataset
        SQLAdapter.SelectCommand = SQLCmd
        SQLAdapter.Fill(SQLDataset, "CheckExistingUser")

        ' If > 0, then 1 of the 3 was found: user exists.
        Dim count = SQLDataset.Tables(0).Rows.Count
        If count > 0 Then
            ' User exists - show generic msg since not coded specifically which one exists
            MessageBox.Show("User already exists" & vbCrLf &
                             "Try 'forgot password' link", "Existing User Found")
            Return True
        Else
            ' User does not exist, OK to continue registering
            Return False
        End If

    End Function

End Class