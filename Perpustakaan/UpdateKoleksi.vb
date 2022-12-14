Imports System.Configuration
Imports System.Globalization
Imports System.IO

Public Class UpdateKoleksi

    Public Shared fungsiperpustakaan As FungsiPerpustakaan

    Dim jeniskoleksi As New List(Of String) From {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PicBoxGambar.Load(Perpustakaan.Koleksi.dirGambarBukuProperty)
        PicBoxGambar.SizeMode = PictureBoxSizeMode.StretchImage
        DatePickTanggalMasukKoleksi.Format = DateTimePickerFormat.Custom
        DatePickTanggalMasukKoleksi.CustomFormat = "yyyy/MM/dd"
        TxtNamaKoleksi.Text = Perpustakaan.Koleksi.namaKoleksiProperty
        ComboBoxJenisKoleksi.SelectedItem() = Perpustakaan.Koleksi.jenisKoleksiProperty
        RTBDeskripsi.Text = Perpustakaan.Koleksi.deskripsiKoleksiProperty
        TxtPenerbit.Text = Perpustakaan.Koleksi.penerbitProperty
        TxtTahunTerbit.Text = Perpustakaan.Koleksi.tahunTerbitProperty
        TxtLokasiRak.Text = Perpustakaan.Koleksi.lokasiProperty
        DatePickTanggalMasukKoleksi.Value = Perpustakaan.Koleksi.tanggalMasukKoleksiProperty
        TxtStock.Text = Perpustakaan.Koleksi.stockProperty
        ComboBoxJenisKoleksi.DataSource = jeniskoleksi

        If String.Compare(Perpustakaan.Koleksi.bahasaProperty, "Indonesia") = 0 Then
            RdIndonesia.Checked = True
        ElseIf String.Compare(Perpustakaan.Koleksi.bahasaProperty, "Inggris") = 0 Then
            RdInggris.Checked = True
        End If

        For Each kategoriItem In Perpustakaan.Koleksi.getKategoriItem

            If String.Compare(kategoriItem, "Sains") = 0 Then
                ChkSains.Checked = True
            ElseIf String.Compare(kategoriItem, "Sosial") = 0 Then
                ChkSosial.Checked = True
            ElseIf String.Compare(kategoriItem, "Teknologi") = 0 Then
                ChkTeknologi.Checked = True
            ElseIf String.Compare(kategoriItem, "Budaya") = 0 Then
                ChkBudaya.Checked = True
            End If

        Next
        Perpustakaan.Koleksi.resetKategori()
    End Sub

    Private Sub TxtTahun_Terbit_Keypress(sender As Object, e As KeyPressEventArgs) Handles TxtTahunTerbit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub TxtStock_Keypress(sender As Object, e As KeyPressEventArgs) Handles TxtStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub BtnUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles BtnUpdateKoleksi.Click
        Perpustakaan.Koleksi.namaKoleksiProperty = TxtNamaKoleksi.Text.ToString()
        Perpustakaan.Koleksi.jenisKoleksiProperty = ComboBoxJenisKoleksi.SelectedItem().ToString()
        Perpustakaan.Koleksi.deskripsiKoleksiProperty = RTBDeskripsi.Text.ToString()
        Perpustakaan.Koleksi.penerbitProperty = TxtPenerbit.Text.ToString()
        Perpustakaan.Koleksi.tahunTerbitProperty = Integer.Parse(TxtTahunTerbit.Text)

        Perpustakaan.Koleksi.lokasiProperty = TxtLokasiRak.Text.ToString()
        Perpustakaan.Koleksi.tanggalMasukKoleksiProperty = DatePickTanggalMasukKoleksi.Value.ToString("yyyy/MM/dd")
        Perpustakaan.Koleksi.stockProperty = Integer.Parse(TxtStock.Text)

        If RdIndonesia.Checked Then
            Perpustakaan.Koleksi.bahasaProperty = "Indonesia"
        ElseIf RdInggris.Checked Then
            Perpustakaan.Koleksi.bahasaProperty = "Inggris"
        End If

        If ChkSains.Checked Then
            Perpustakaan.Koleksi.AddKategori("Sains")
        End If

        If ChkSosial.Checked Then
            Perpustakaan.Koleksi.AddKategori("Sosial")
        End If

        If ChkTeknologi.Checked Then
            Perpustakaan.Koleksi.AddKategori("Teknologi")
        End If

        If ChkBudaya.Checked Then
            Perpustakaan.Koleksi.AddKategori("Budaya")
        End If

        Perpustakaan.Koleksi.AddKoleksi(TxtNamaKoleksi.Text.ToString())

        Dim ConvertedKoleksi = Perpustakaan.Koleksi.ConvertKoleksiToString(Perpustakaan.Koleksi.getKategoriItem)

        Perpustakaan.Koleksi.UpdateDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksi,
                                                           Perpustakaan.Koleksi.dirGambarBukuProperty,
                                                           Perpustakaan.Koleksi.namaKoleksiProperty,
                                                           Perpustakaan.Koleksi.jenisKoleksiProperty,
                                                           Perpustakaan.Koleksi.deskripsiKoleksiProperty,
                                                           Perpustakaan.Koleksi.penerbitProperty,
                                                           Perpustakaan.Koleksi.tahunTerbitProperty,
                                                           Perpustakaan.Koleksi.lokasiProperty,
                                                           Perpustakaan.Koleksi.tanggalMasukKoleksiProperty,
                                                           Perpustakaan.Koleksi.stockProperty,
                                                           Perpustakaan.Koleksi.bahasaProperty,
                                                           ConvertedKoleksi
                                                           )

        Dim infotambahkoleksi_form = New InfoTambahKoleksi()
        infotambahkoleksi_form.Show()

        Me.Close()
    End Sub

    Private Sub BtnUpdateGambar_Click(sender As Object, e As EventArgs) Handles BtnUpdateGambar.Click
        OpenFileDialog1.Title = "Open Gambar Koleksi"
        OpenFileDialog1.Filter = "All Format|*.*|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|Image|*.bmp"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PicBoxGambar.Load(picKoleksiDir)
        PicBoxGambar.SizeMode = PictureBoxSizeMode.StretchImage
        Perpustakaan.Koleksi.dirGambarBukuProperty = picKoleksiDir.ToString()
        Perpustakaan.Koleksi.dirGambarBukuProperty = Perpustakaan.Koleksi.dirGambarBukuProperty.Replace("\", "/")
    End Sub

End Class