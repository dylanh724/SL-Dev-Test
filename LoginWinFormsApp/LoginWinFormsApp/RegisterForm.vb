' #########################################################################
' File:             RegisterForm.vb
' Author:           Dylan Hunt (dylan@dylanh-dev.com)
' Date Created:     9/3/2014
' Date Modified:    9/9/2014 (Taiwan time)
' Purpose:          Simple modal form of the parent LoginForm.vb;
'                   Registers a new user, submitting info
'                   to the LoginService, which sends to SQL-DB
' #########################################################################

Imports LoginWinFormsApp.LoginService

Public Class RegisterForm
    ' Global variables

    ' #################################################
    ' VALIDATION
    Public Function ValidateForm() As Boolean
        ' Variables
        Dim HasError As Boolean = False

        ' Validate - highlight blanks - TextBox
        For Each c As TextBox In Me.Controls.OfType(Of TextBox)()
            If c.Text = String.Empty Then
                c.BackColor = Color.LightYellow
                HasError = True
            End If
        Next

        ' Validate - highlight blanks - MaskedTextBox
        For Each c As MaskedTextBox In Me.Controls.OfType(Of MaskedTextBox)()
            If c.Text = String.Empty Then
                c.BackColor = Color.LightYellow
                HasError = True
            End If
        Next

        ' Validate email
        ValidateEmail(EmailTextBox.Text)

        ' Validate - test for password match
        If Not PasswordMaskedTextBox.Text = ConfirmPasswordMaskedTextBox.Text Then
            RegisterErrorProvider.SetError(PasswordMaskedTextBox, "Passwords do not match")
            HasError = True
        End If

        ' Validate - finalize, end if error
        If HasError Then
            ' Validation failed
            Return False
        End If

        ' Validation pass
        Return True

    End Function

    Public Sub ClearReset()
        ' Clear errors
        RegisterErrorProvider.Clear()

        ' Reset color - TextBox
        For Each c As TextBox In Me.Controls.OfType(Of TextBox)()
            c.BackColor = Color.White
        Next

        ' Reset color - MaskedTextBox
        For Each c As MaskedTextBox In Me.Controls.OfType(Of MaskedTextBox)()
            c.BackColor = Color.White
        Next
    End Sub
    ' /VALIDATION
    ' #################################################

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        ' Clear and Reset Form
        ClearReset()

        ' VALIDATION
        If Not ValidateForm() Then
            MsgBox("Validation failed")
            Exit Sub
        End If

        ' Form >> Variables
        Dim Username As String = Me.UsernameTextBox.Text
        Dim Password As String = Me.PasswordMaskedTextBox.Text
        Dim FirstName As String = Me.FirstNameTextBox.Text
        Dim LastName As String = Me.LastNameTextBox.Text
        Dim MobilePhone As String = Me.MobilePhoneMaskedTextbox.Text
        Dim Email As String = Me.EmailTextBox.Text
        Dim Birthday As Date = Me.BirthdayDateTimePicker.Value

        ' Check for existing user (username/mobile phone/email)
        Try
            If LoginForm.LoginServiceConnect.CheckExistingUser(Username, Email, MobilePhone) Then
                ' Exit sub if user already exists
                Me.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Variables >> SQL (Warning: Plaintext password used for this assignment)
        Try
            ' Attempt to register via web server + SQL-DB
            If LoginForm.LoginServiceConnect.RegisterNewUser(
            Username, Password,
            FirstName, LastName,
            MobilePhone, Email, Birthday) Then
                ' Success
                Me.Close()
            Else
                ' Failure
                UsernameTextBox.Focus()
                UsernameTextBox.SelectAll()
            End If

        Catch ex As Exception
            ' Error
            MsgBox(ex.Message)
        End Try

    End Sub

    Function ValidateEmail(ByVal email As String) As Boolean
        Try
            ' Validate email
            Dim emailRegex As New System.Text.RegularExpressions.Regex(
            "^(?<user>[^@]+)@(?<host>.+)$")
            Dim emailMatch As System.Text.RegularExpressions.Match =
               emailRegex.Match(email)

        Catch ex As Exception
            ' Error
            MsgBox("Enter valid email")
            Return False
        End Try

        ' Success
        Return True
        
    End Function

End Class