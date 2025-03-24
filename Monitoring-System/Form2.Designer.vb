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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22F)
        Label1.Location = New Point(183, 32)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 60)
        Label1.TabIndex = 1
        Label1.Text = "SIGN UP"
        ' 
        ' firstNameTxt
        ' 
        firstNameTxt.Location = New Point(122, 117)
        firstNameTxt.Margin = New Padding(4)
        firstNameTxt.Name = "firstNameTxt"
        firstNameTxt.Size = New Size(308, 31)
        firstNameTxt.TabIndex = 2
        ' 
        ' lastNameTxt
        ' 
        lastNameTxt.Location = New Point(122, 166)
        lastNameTxt.Margin = New Padding(4)
        lastNameTxt.Name = "lastNameTxt"
        lastNameTxt.Size = New Size(308, 31)
        lastNameTxt.TabIndex = 3
        ' 
        ' emailTxt
        ' 
        emailTxt.Location = New Point(122, 217)
        emailTxt.Margin = New Padding(4)
        emailTxt.Name = "emailTxt"
        emailTxt.Size = New Size(308, 31)
        emailTxt.TabIndex = 4
        ' 
        ' phoneNumberTxt
        ' 
        phoneNumberTxt.Location = New Point(122, 269)
        phoneNumberTxt.Margin = New Padding(4)
        phoneNumberTxt.Name = "phoneNumberTxt"
        phoneNumberTxt.Size = New Size(308, 31)
        phoneNumberTxt.TabIndex = 5
        ' 
        ' passwordTxt
        ' 
        passwordTxt.Location = New Point(122, 319)
        passwordTxt.Margin = New Padding(4)
        passwordTxt.Name = "passwordTxt"
        passwordTxt.Size = New Size(308, 31)
        passwordTxt.TabIndex = 6
        ' 
        ' confirmPasswordTxt
        ' 
        confirmPasswordTxt.Location = New Point(122, 368)
        confirmPasswordTxt.Margin = New Padding(4)
        confirmPasswordTxt.Name = "confirmPasswordTxt"
        confirmPasswordTxt.Size = New Size(308, 31)
        confirmPasswordTxt.TabIndex = 7
        ' 
        ' signupBtn
        ' 
        signupBtn.Location = New Point(122, 418)
        signupBtn.Margin = New Padding(4)
        signupBtn.Name = "signupBtn"
        signupBtn.Size = New Size(118, 36)
        signupBtn.TabIndex = 8
        signupBtn.Text = "SIGN UP"
        signupBtn.UseVisualStyleBackColor = True
        ' 
        ' cancelBtn
        ' 
        cancelBtn.Location = New Point(312, 418)
        cancelBtn.Margin = New Padding(4)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Size = New Size(118, 36)
        cancelBtn.TabIndex = 9
        cancelBtn.Text = "CANCEL"
        cancelBtn.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 499)
        Controls.Add(cancelBtn)
        Controls.Add(signupBtn)
        Controls.Add(confirmPasswordTxt)
        Controls.Add(passwordTxt)
        Controls.Add(phoneNumberTxt)
        Controls.Add(emailTxt)
        Controls.Add(lastNameTxt)
        Controls.Add(firstNameTxt)
        Controls.Add(Label1)
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
End Class
