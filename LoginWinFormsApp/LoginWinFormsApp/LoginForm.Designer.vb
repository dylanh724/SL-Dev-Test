<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.SQLStatusLabel = New System.Windows.Forms.Label()
        Me.ForgotPasswordLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(27, 160)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(224, 57)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(28, 38)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(222, 26)
        Me.UsernameTextBox.TabIndex = 0
        '
        'PasswordMaskedTextBox
        '
        Me.PasswordMaskedTextBox.Location = New System.Drawing.Point(28, 100)
        Me.PasswordMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PasswordMaskedTextBox.Name = "PasswordMaskedTextBox"
        Me.PasswordMaskedTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordMaskedTextBox.Size = New System.Drawing.Size(222, 26)
        Me.PasswordMaskedTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(27, 226)
        Me.RegisterButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(224, 35)
        Me.RegisterButton.TabIndex = 3
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(150, 266)
        Me.ErrorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(92, 20)
        Me.ErrorLabel.TabIndex = 7
        Me.ErrorLabel.Text = "Logging In.."
        Me.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ErrorLabel.Visible = False
        '
        'SQLStatusLabel
        '
        Me.SQLStatusLabel.AutoSize = True
        Me.SQLStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.SQLStatusLabel.Location = New System.Drawing.Point(24, 266)
        Me.SQLStatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SQLStatusLabel.Name = "SQLStatusLabel"
        Me.SQLStatusLabel.Size = New System.Drawing.Size(124, 20)
        Me.SQLStatusLabel.TabIndex = 8
        Me.SQLStatusLabel.Text = "(No Connection)"
        Me.SQLStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ForgotPasswordLabel
        '
        Me.ForgotPasswordLabel.AutoSize = True
        Me.ForgotPasswordLabel.ForeColor = System.Drawing.Color.Blue
        Me.ForgotPasswordLabel.Location = New System.Drawing.Point(78, 131)
        Me.ForgotPasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ForgotPasswordLabel.Name = "ForgotPasswordLabel"
        Me.ForgotPasswordLabel.Size = New System.Drawing.Size(129, 20)
        Me.ForgotPasswordLabel.TabIndex = 9
        Me.ForgotPasswordLabel.Text = "Forgot Password"
        '
        'LoginForm
        '
        Me.AcceptButton = Me.LoginButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 303)
        Me.Controls.Add(Me.ForgotPasswordLabel)
        Me.Controls.Add(Me.SQLStatusLabel)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordMaskedTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoginButton)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RegisterButton As System.Windows.Forms.Button
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
    Friend WithEvents SQLStatusLabel As System.Windows.Forms.Label
    Friend WithEvents ForgotPasswordLabel As System.Windows.Forms.Label

End Class
