Public Class Form2
    Private Sub signupBtn_Click(sender As Object, e As EventArgs) Handles signupBtn.Click
        ' Handle sign up logic here
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox_GotFocus(sender As Object, e As EventArgs) Handles firstNameTxt.GotFocus, lastNameTxt.GotFocus, emailTxt.GotFocus, phoneNumberTxt.GotFocus, passwordTxt.GotFocus, confirmPasswordTxt.GotFocus
        Dim txtBox As TextBox = CType(sender, TextBox)
        If txtBox.ForeColor = Color.Gray Then
            txtBox.Text = ""
            txtBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox_LostFocus(sender As Object, e As EventArgs) Handles firstNameTxt.LostFocus, lastNameTxt.LostFocus, emailTxt.LostFocus, phoneNumberTxt.LostFocus, passwordTxt.LostFocus, confirmPasswordTxt.LostFocus
        Dim txtBox As TextBox = CType(sender, TextBox)
        If String.IsNullOrWhiteSpace(txtBox.Text) Then
            txtBox.ForeColor = Color.Gray
            Select Case txtBox.Name
                Case "firstNameTxt"
                    txtBox.Text = "First Name"
                Case "lastNameTxt"
                    txtBox.Text = "Last Name"
                Case "emailTxt"
                    txtBox.Text = "Email"
                Case "phoneNumberTxt"
                    txtBox.Text = "Phone Number"
                Case "passwordTxt"
                    txtBox.Text = "Password"
                Case "confirmPasswordTxt"
                    txtBox.Text = "Confirm Password"
            End Select
        End If
    End Sub
End Class