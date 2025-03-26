<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        usernameTxt = New TextBox()
        signinBtn = New Button()
        Label1 = New Label()
        signupBtn = New Button()
        passwordTxt = New TextBox()
        SuspendLayout()
        ' 
        ' usernameTxt
        ' 
        usernameTxt.Location = New Point(108, 148)
        usernameTxt.Margin = New Padding(4)
        usernameTxt.Name = "usernameTxt"
        usernameTxt.Size = New Size(308, 31)
        usernameTxt.TabIndex = 1
        usernameTxt.Text = "Enter Username"
        usernameTxt.ForeColor = Color.Gray
        ' 
        ' signinBtn
        ' 
        signinBtn.Location = New Point(108, 269)
        signinBtn.Margin = New Padding(4)
        signinBtn.Name = "signinBtn"
        signinBtn.Size = New Size(118, 36)
        signinBtn.TabIndex = 2
        signinBtn.Text = "SIGN IN"
        signinBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22F)
        Label1.Location = New Point(165, 46)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 60)
        Label1.TabIndex = 0
        Label1.Text = "SIGN IN"
        ' 
        ' signupBtn
        ' 
        signupBtn.Location = New Point(299, 269)
        signupBtn.Margin = New Padding(4)
        signupBtn.Name = "signupBtn"
        signupBtn.Size = New Size(118, 36)
        signupBtn.TabIndex = 3
        signupBtn.Text = "SIGN UP"
        signupBtn.UseVisualStyleBackColor = True
        ' 
        ' passwordTxt
        ' 
        passwordTxt.Location = New Point(108, 205)
        passwordTxt.Margin = New Padding(4)
        passwordTxt.Name = "passwordTxt"
        passwordTxt.Size = New Size(308, 31)
        passwordTxt.TabIndex = 4
        passwordTxt.Text = "Enter Password"
        passwordTxt.ForeColor = Color.Gray
        passwordTxt.UseSystemPasswordChar = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(528, 364)
        Controls.Add(passwordTxt)
        Controls.Add(signupBtn)
        Controls.Add(signinBtn)
        Controls.Add(usernameTxt)
        Controls.Add(Label1)
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Sign In"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents usernameTxt As TextBox
    Friend WithEvents signinBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents signupBtn As Button
    Friend WithEvents passwordTxt As TextBox

End Class
