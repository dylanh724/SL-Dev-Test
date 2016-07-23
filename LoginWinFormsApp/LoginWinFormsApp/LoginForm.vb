' #########################################################################
' File:             LoginForm.vb
' Author:           Dylan Hunt (dylan@dylanh-dev.com)
' Date Created:     9/3/2014
' Date Modified:    9/9/2014 (Taiwan time)
' Purpose:          Simple parent for modal child RegisterForm.vb;
'                   Verifies username/password login against the
'                   LoginService web service (+SQL-DB);
'                   Register button opens child prompt, RegisterForm.vb
' #########################################################################

Option Strict On
' Web service
Imports LoginWinFormsApp.LoginService
' Send Email
Imports System.Net.Mail

Public Class LoginForm

    Protected Friend LoginServiceConnect As New WebService1SoapClient

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim UserNameString As String = UsernameTextBox.Text
        Dim PasswordString As String = PasswordMaskedTextBox.Text

        ' Show error/status label
        ErrorLabel.ForeColor = Color.Red
        ErrorLabel.Text = "Logging in.."
        ErrorLabel.Show()

        Try
            If LoginServiceConnect.VerifyLogin(UserNameString, PasswordString) Then
                ' Login Success
                ErrorLabel.ForeColor = Color.Green
                ErrorLabel.Text = "Login Successful"
            Else
                ' Login Failure
                ErrorLabel.Text = "Login Failed"
                ' Double check for DB issue
                CheckSQLStatus()
            End If
        Catch ex As Exception
            MsgBox("Cannot reach server")
        End Try



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize
        UsernameTextBox.Focus()
        CheckSQLStatus()

    End Sub

    Public Sub CheckSQLStatus()
        ' SQL Connection
        Dim SQLStatus = LoginServiceConnect.SQLTest
        If SQLStatus = True Then
            SQLStatusLabel.ForeColor = Color.Green
            SQLStatusLabel.Text = "(Connected)"
        Else
            SQLStatusLabel.ForeColor = Color.Red
            SQLStatusLabel.Text = "(No Connection)"
        End If
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim NewRegisterForm As New RegisterForm
        NewRegisterForm.ShowDialog()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ForgotPasswordLabel_Click(sender As Object, e As EventArgs) Handles ForgotPasswordLabel.Click
        ' Prompt for email
        Dim RecoveryEmailString As String = InputBox("Lost your password?" + vbCrLf + "We can remind you!", "test!", "example@domain.com")

        ' Ghetto validation - check empty space
        If Not RecoveryEmailString = "" Then
            Try
                Dim Mail As New MailMessage
                Dim SMTP As New SmtpClient("smtp.gmail.com")

                Mail.Subject = "Smartlaunch Password Recovery"
                Mail.From = New MailAddress("noreplyfromdylan@gmail.com")
                SMTP.Credentials = New System.Net.NetworkCredential("noreplyfromdylan@gmail.com", "AbcDef123") '<-- Password Here

                Mail.To.Add(RecoveryEmailString)

                ' Message Here
                Mail.Body = "Hi," & vbCrLf & vbCrLf &
                    "Your SmartLaunch password is:" &
                    "<PLACEHOLDER>"

                SMTP.EnableSsl = True
                SMTP.Port = 587
                SMTP.Send(Mail)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub
End Class
