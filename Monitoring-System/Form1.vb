Public Class Form1

    Private Sub signinBtn_Click(sender As Object, e As EventArgs) Handles signinBtn.Click

    End Sub

    Private Sub signupBtn_Click(sender As Object, e As EventArgs) Handles signupBtn.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox_GotFocus(sender As Object, e As EventArgs) Handles usernameTxt.GotFocus, passwordTxt.GotFocus
        Dim txtBox As TextBox = CType(sender, TextBox)
        If txtBox.ForeColor = Color.Gray Then
            txtBox.Text = ""
            txtBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox_LostFocus(sender As Object, e As EventArgs) Handles usernameTxt.LostFocus, passwordTxt.LostFocus
        Dim txtBox As TextBox = CType(sender, TextBox)
        If String.IsNullOrWhiteSpace(txtBox.Text) Then
            txtBox.ForeColor = Color.Gray
            Select Case txtBox.Name
                Case "usernameTxt"
                    txtBox.Text = "Enter Username"
                Case "passwordTxt"
                    txtBox.Text = "Enter Password"
            End Select
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usernameTxt.Text = "Enter Username"
        usernameTxt.ForeColor = Color.Gray
        passwordTxt.Text = "Enter Password"
        passwordTxt.ForeColor = Color.Gray
    End Sub

End Class