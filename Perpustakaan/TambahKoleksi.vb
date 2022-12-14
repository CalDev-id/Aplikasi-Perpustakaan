Imports System.Configuration
Imports System.Globalization
Imports System.IO

Public Class TambahKoleksi

    Public Shared fungsiperpustakaan As FungsiPerpustakaan

    Dim jeniskoleksi As New List(Of String) From {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        fungsiperpustakaan = New FungsiPerpustakaan()

        ComboBoxJenisKoleksi.DataSource = jeniskoleksi

        DatePickTanggalMasukKoleksi.Format = DateTimePickerFormat.Custom
        DatePickTanggalMasukKoleksi.CustomFormat = "yyyy/MM/dd"

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



    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        If TxtTahunTerbit.Text = "" Then
            MessageBox.Show("Data Tahun Terbit Tidak Boleh Kosong")
        Else
            If TxtStock.Text = "" Then
                MessageBox.Show("Data Stock Tidak Boleh Kosong")
            Else
                If PicBoxGambar.ImageLocation = "" Then
                    MessageBox.Show("Data Gambar Tidak Boleh Kosong")
                Else
                    Perpustakaan.Koleksi.namaKoleksiProperty = TxtNamaKoleksi.Text.ToString()
                    Perpustakaan.Koleksi.jenisKoleksiProperty = ComboBoxJenisKoleksi.SelectedItem().ToString()
                    Perpustakaan.Koleksi.deskripsiKoleksiProperty = RTBDeskripsi.Text.ToString()
                    Perpustakaan.Koleksi.penerbitProperty = TxtPenerbit.Text.ToString()
                    Perpustakaan.Koleksi.tahunTerbitProperty = Integer.Parse(TxtTahunTerbit.Text)

                    Perpustakaan.Koleksi.lokasiProperty = TxtLokasiRak.Text.ToString()
                    Perpustakaan.Koleksi.tanggalMasukKoleksiProperty = DatePickTanggalMasukKoleksi.Value.ToShortDateString()
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

                    Perpustakaan.Koleksi.AddDataKoleksiDatabase(Perpustakaan.Koleksi.dirGambarBukuProperty,
                                                                Perpustakaan.Koleksi.namaKoleksiProperty,
                                                                Perpustakaan.Koleksi.jenisKoleksiProperty,
                                                                Perpustakaan.Koleksi.penerbitProperty,
                                                                Perpustakaan.Koleksi.deskripsiKoleksiProperty,
                                                                Perpustakaan.Koleksi.tahunTerbitProperty,
                                                                Perpustakaan.Koleksi.lokasiProperty,
                                                                Perpustakaan.Koleksi.tanggalMasukKoleksiProperty,
                                                                Perpustakaan.Koleksi.stockProperty,
                                                                Perpustakaan.Koleksi.bahasaProperty,
                                                                ConvertedKoleksi)

                    'Perpustakaan.ReloadDataTableDatabase()
                    Dim infotambahkoleksi_form = New InfoTambahKoleksi()
                    infotambahkoleksi_form.Show()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
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