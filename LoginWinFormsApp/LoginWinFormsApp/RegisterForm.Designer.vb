<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PasswordMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ConfirmPasswordMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BirthdayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MobilePhoneMaskedTextbox = New System.Windows.Forms.MaskedTextBox()
        Me.RegisterErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        CType(Me.RegisterErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(206, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirm Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 163)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "First Name"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(22, 188)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(148, 26)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 163)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Last Name"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(210, 188)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(148, 26)
        Me.LastNameTextBox.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 223)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Mobile Phone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(206, 223)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 283)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Birthday"
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(22, 360)
        Me.RegisterButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(336, 51)
        Me.RegisterButton.TabIndex = 9
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(98, 14)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "REGISTER NEW USER"
        '
        'PasswordMaskedTextBox
        '
        Me.PasswordMaskedTextBox.Location = New System.Drawing.Point(22, 128)
        Me.PasswordMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PasswordMaskedTextBox.Name = "PasswordMaskedTextBox"
        Me.PasswordMaskedTextBox.Size = New System.Drawing.Size(148, 26)
        Me.PasswordMaskedTextBox.TabIndex = 2
        '
        'ConfirmPasswordMaskedTextBox
        '
        Me.ConfirmPasswordMaskedTextBox.Location = New System.Drawing.Point(210, 128)
        Me.ConfirmPasswordMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConfirmPasswordMaskedTextBox.Name = "ConfirmPasswordMaskedTextBox"
        Me.ConfirmPasswordMaskedTextBox.Size = New System.Drawing.Size(148, 26)
        Me.ConfirmPasswordMaskedTextBox.TabIndex = 3
        '
        'BirthdayDateTimePicker
        '
        Me.BirthdayDateTimePicker.Location = New System.Drawing.Point(22, 308)
        Me.BirthdayDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker"
        Me.BirthdayDateTimePicker.Size = New System.Drawing.Size(336, 26)
        Me.BirthdayDateTimePicker.TabIndex = 8
        '
        'MobilePhoneMaskedTextbox
        '
        Me.MobilePhoneMaskedTextbox.Location = New System.Drawing.Point(22, 248)
        Me.MobilePhoneMaskedTextbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MobilePhoneMaskedTextbox.Mask = "999-000-0000"
        Me.MobilePhoneMaskedTextbox.Name = "MobilePhoneMaskedTextbox"
        Me.MobilePhoneMaskedTextbox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MobilePhoneMaskedTextbox.Size = New System.Drawing.Size(148, 26)
        Me.MobilePhoneMaskedTextbox.TabIndex = 6
        '
        'RegisterErrorProvider
        '
        Me.RegisterErrorProvider.ContainerControl = Me
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(210, 248)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(148, 26)
        Me.EmailTextBox.TabIndex = 7
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(22, 68)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(336, 26)
        Me.UsernameTextBox.TabIndex = 1
        '
        'RegisterForm
        '
        Me.AcceptButton = Me.RegisterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 432)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.MobilePhoneMaskedTextbox)
        Me.Controls.Add(Me.BirthdayDateTimePicker)
        Me.Controls.Add(Me.ConfirmPasswordMaskedTextBox)
        Me.Controls.Add(Me.PasswordMaskedTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegisterForm"
        Me.Text = "Register"
        CType(Me.RegisterErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RegisterButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PasswordMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ConfirmPasswordMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BirthdayDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MobilePhoneMaskedTextbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RegisterErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
End Class
