Public Class InfoTambahKoleksi

    Public Shared perpustakaan As Perpustakaan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ListBoxKategori.Items.Clear()

        PicBoxGambar.Load(Perpustakaan.Koleksi.dirGambarBukuProperty)
        PicBoxGambar.SizeMode = PictureBoxSizeMode.StretchImage

        LblNamaKoleksi.Text = Perpustakaan.Koleksi.namaKoleksiProperty
        LblJenisKoleksi.Text = Perpustakaan.Koleksi.jenisKoleksiProperty
        LblDeskripsi.Text = Perpustakaan.Koleksi.deskripsiKoleksiProperty
        LblPenerbit.Text = Perpustakaan.Koleksi.penerbitProperty
        LblTahunTerbit.Text = Perpustakaan.Koleksi.tahunTerbitProperty
        LblLokasiRak.Text = Perpustakaan.Koleksi.lokasiProperty
        LblTanggalMasukKoleksi.Text = Perpustakaan.Koleksi.tanggalMasukKoleksiProperty
        LblStock.Text = Perpustakaan.Koleksi.stockProperty
        LblBahasa.Text = Perpustakaan.Koleksi.bahasaProperty

        For Each info_tambah In Perpustakaan.Koleksi.getKategoriItem
            ListBoxKategori.Items.Add(info_tambah)
        Next

        Perpustakaan.Koleksi.getKategoriItem.Clear()

    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()

        'Dim koleksi = TambahKoleksi.fungsiperpustakaan.GSNama_Koleksi
        'perpustakaan.ListBoxKoleksi.Items.Add(koleksi)
    End Sub

End Class