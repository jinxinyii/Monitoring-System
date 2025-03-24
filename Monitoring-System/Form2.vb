Public Class Form2
    Private Sub signupBtn_Click(sender As Object, e As EventArgs) Handles signupBtn.Click

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()
    End Sub
End Class