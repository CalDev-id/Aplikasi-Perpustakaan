Public Class HapusKoleksi



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblKoleksi.Text = Perpustakaan.selectedTableKoleksiNama

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'Dim hapus = Perpustakaan.ListBoxKoleksi.SelectedItem()
        'Perpustakaan.ListBoxKoleksi.Items.Remove(hapus)
        Perpustakaan.Koleksi.DeleteDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksi)

        Me.Close()
    End Sub

End Class