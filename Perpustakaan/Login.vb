Public Class Login

    Public Shared Perpustakaan As Perpustakaan
    Public Shared Users As Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Perpustakaan = New Perpustakaan()
        Users = New Users()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text

        Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            Users.usernameProperty = data_user(1)
            Perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Password Salah")
        End If
    End Sub

    Private Sub LinkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRegister.LinkClicked
        Dim register = New Register()
        register.Show()
    End Sub
End Class