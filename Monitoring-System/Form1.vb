Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetPlaceholder(usernameTxt, "Enter Username")
        SetPlaceholder(passwordTxt, "Enter Password")
    End Sub

    Private Sub usernameTxt_GotFocus(sender As Object, e As EventArgs) Handles usernameTxt.GotFocus
        RemovePlaceholder(usernameTxt, "Enter Username")
    End Sub

    Private Sub usernameTxt_LostFocus(sender As Object, e As EventArgs) Handles usernameTxt.LostFocus
        SetPlaceholder(usernameTxt, "Enter Username")
    End Sub

    Private Sub passwordTxt_GotFocus(sender As Object, e As EventArgs) Handles passwordTxt.GotFocus
        RemovePlaceholder(passwordTxt, "Enter Password")
    End Sub

    Private Sub passwordTxt_LostFocus(sender As Object, e As EventArgs) Handles passwordTxt.LostFocus
        SetPlaceholder(passwordTxt, "Enter Password")
    End Sub

    Private Sub SetPlaceholder(textBox As TextBox, placeholder As String)
        If String.IsNullOrWhiteSpace(textBox.Text) Then
            textBox.Text = placeholder
            textBox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub RemovePlaceholder(textBox As TextBox, placeholder As String)
        If textBox.Text = placeholder Then
            textBox.Text = ""
            textBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub signinBtn_Click(sender As Object, e As EventArgs) Handles signinBtn.Click

    End Sub

    Private Sub signupBtn_Click(sender As Object, e As EventArgs) Handles signupBtn.Click

    End Sub
End Class