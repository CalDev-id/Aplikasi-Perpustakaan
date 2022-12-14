Public Class HapusListKoleksi

    Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblKoleksi.Text = Perpustakaan.selectedListBox

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Perpustakaan.Koleksi.DeleteDataKoleksiByNamaDatabase(Perpustakaan.selectedListBox)

        Me.Close()
    End Sub

End Class