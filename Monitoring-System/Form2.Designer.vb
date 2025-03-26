<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        firstNameTxt = New TextBox()
        lastNameTxt = New TextBox()
        emailTxt = New TextBox()
        phoneNumberTxt = New TextBox()
        passwordTxt = New TextBox()
        confirmPasswordTxt = New TextBox()
        signupBtn = New Button()
        cancelBtn = New Button()
        usernameTxt = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22F)
        Label1.Location = New Point(146, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 50)
        Label1.TabIndex = 1
        Label1.Text = "SIGN UP"
        ' 
        ' firstNameTxt
        ' 
        firstNameTxt.ForeColor = Color.Gray
        firstNameTxt.Location = New Point(98, 94)
        firstNameTxt.Name = "firstNameTxt"
        firstNameTxt.Size = New Size(247, 27)
        firstNameTxt.TabIndex = 2
        firstNameTxt.Text = "First Name"
        ' 
        ' lastNameTxt
        ' 
        lastNameTxt.ForeColor = Color.Gray
        lastNameTxt.Location = New Point(98, 133)
        lastNameTxt.Name = "lastNameTxt"
        lastNameTxt.Size = New Size(247, 27)
        lastNameTxt.TabIndex = 3
        lastNameTxt.Text = "Last Name"
        ' 
        ' emailTxt
        ' 
        emailTxt.ForeColor = Color.Gray
        emailTxt.Location = New Point(98, 217)
        emailTxt.Name = "emailTxt"
        emailTxt.Size = New Size(247, 27)
        emailTxt.TabIndex = 4
        emailTxt.Text = "Email"
        ' 
        ' phoneNumberTxt
        ' 
        phoneNumberTxt.ForeColor = Color.Gray
        phoneNumberTxt.Location = New Point(98, 258)
        phoneNumberTxt.Name = "phoneNumberTxt"
        phoneNumberTxt.Size = New Size(247, 27)
        phoneNumberTxt.TabIndex = 5
        phoneNumberTxt.Text = "Phone Number"
        ' 
        ' passwordTxt
        ' 
        passwordTxt.ForeColor = Color.Gray
        passwordTxt.Location = New Point(98, 298)
        passwordTxt.Name = "passwordTxt"
        passwordTxt.UseSystemPasswordChar = True
        passwordTxt.Size = New Size(247, 27)
        passwordTxt.TabIndex = 6
        passwordTxt.Text = "Password"
        ' 
        ' confirmPasswordTxt
        ' 
        confirmPasswordTxt.ForeColor = Color.Gray
        confirmPasswordTxt.Location = New Point(98, 337)
        confirmPasswordTxt.Name = "confirmPasswordTxt"
        confirmPasswordTxt.UseSystemPasswordChar = True
        confirmPasswordTxt.Size = New Size(247, 27)
        confirmPasswordTxt.TabIndex = 7
        confirmPasswordTxt.Text = "Confirm Password"
        ' 
        ' signupBtn
        ' 
        signupBtn.Location = New Point(98, 377)
        signupBtn.Name = "signupBtn"
        signupBtn.Size = New Size(94, 29)
        signupBtn.TabIndex = 8
        signupBtn.Text = "SIGN UP"
        signupBtn.UseVisualStyleBackColor = True
        ' 
        ' cancelBtn
        ' 
        cancelBtn.Location = New Point(250, 377)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Size = New Size(94, 29)
        cancelBtn.TabIndex = 9
        cancelBtn.Text = "CANCEL"
        cancelBtn.UseVisualStyleBackColor = True
        ' 
        ' usernameTxt
        ' 
        usernameTxt.ForeColor = Color.Gray
        usernameTxt.Location = New Point(97, 175)
        usernameTxt.Name = "usernameTxt"
        usernameTxt.Size = New Size(247, 27)
        usernameTxt.TabIndex = 10
        usernameTxt.Text = "Username"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(454, 445)
        Controls.Add(usernameTxt)
        Controls.Add(cancelBtn)
        Controls.Add(signupBtn)
        Controls.Add(confirmPasswordTxt)
        Controls.Add(passwordTxt)
        Controls.Add(phoneNumberTxt)
        Controls.Add(emailTxt)
        Controls.Add(lastNameTxt)
        Controls.Add(firstNameTxt)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "Form2"
        Text = "Sign Up"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents firstNameTxt As TextBox
    Friend WithEvents lastNameTxt As TextBox
    Friend WithEvents emailTxt As TextBox
    Friend WithEvents phoneNumberTxt As TextBox
    Friend WithEvents passwordTxt As TextBox
    Friend WithEvents confirmPasswordTxt As TextBox
    Friend WithEvents signupBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents usernameTxt As TextBox
End Class
