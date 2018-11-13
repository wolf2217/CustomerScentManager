Public Class Form1
    Public db As New FunctionsDataContext
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim checkLogin = From cm_users In db.cm_users
                         Where cm_users.Username = txtUsername.Text And cm_users.Password = txtPassword.Text

        If checkLogin.Count = 1 Then
            My.Settings.Username = txtUsername.Text
            My.Settings.Save()
            Hide()
            Dashboard.Show()
            Close()
        Else
            MsgBox("Wrong login credentials, try again", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
