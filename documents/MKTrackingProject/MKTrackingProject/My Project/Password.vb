Public Class Password






    Public Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click


        Dim Username As New My.MySettings()
        Dim Password As New My.MySettings()

        If txtPassword.Text = "" And txtUsername.Text = "" Then
            MsgBox("Username and Password are Required!", MsgBoxStyle.Critical, "Error!")

            txtUsername.Focus()

        ElseIf txtUsername.Text = Username.Username And txtPassword.Text = Password.Password Then
            MsgBox("You have entered the correct Username and Passwrod", MsgBoxStyle.Information, "Thank You!")


            MKTracking.ShowDialog()



        Else
            MsgBox("Invalid User!", MsgBoxStyle.Critical, "Error!")

            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
        End If

    End Sub

    Private Sub Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True

    End Sub
End Class



