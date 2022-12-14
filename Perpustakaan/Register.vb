Public Class Register

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        If Login.Users.CheckUser(TxtRegisterUsername.Text) = True Then
            MessageBox.Show("Username Sudah Terdaftar")
        Else
            If TxtRegisterUsername.Text.Length > 0 And TxtRegisterPassword.Text.Length > 0 Then
                Login.Users.AddUsersDatabase(TxtRegisterUsername.Text, TxtRegisterPassword.Text)
                Me.Close()
            Else
                MessageBox.Show("Lengkapi Data")
            End If
        End If

    End Sub

    Private Sub LinkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogin.LinkClicked
        Me.Close()
    End Sub
End Class