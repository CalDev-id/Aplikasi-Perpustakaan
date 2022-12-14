Imports Google.Protobuf.WellKnownTypes
Imports Microsoft.VisualBasic.Devices

Public Class Perpustakaan
    Public Shared Koleksi As Koleksi
    Dim selected As String
    Public Shared selectedListBox
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Koleksi = New Koleksi()
        ReloadDataTableDatabase()

    End Sub

    Private Sub ClearListBox()
        ListBoxKoleksi.ClearSelected()
    End Sub

    Private Sub ResetGrid()
        Dim index As Integer = 0
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim tambahkoleksi_form = New TambahKoleksi()
        tambahkoleksi_form.Show()
        ResetGrid()
    End Sub

    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        Dim tambahkoleksi_form = New TambahKoleksi()
        tambahkoleksi_form.Show()
        ResetGrid()
    End Sub

    Private Sub BtnHapusKoleksi_Click(sender As Object, e As EventArgs) Handles BtnHapusKoleksi.Click
        Dim hapus = New HapusListKoleksi()

        selected = ListBoxKoleksi.SelectedItem()

        If Not String.IsNullOrEmpty(selected) Then
            hapus.Show()
        Else
            MessageBox.Show("Pilih Koleksi Yang Ingin Dihapus")
        End If
        ResetGrid()
    End Sub

    Public Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = Koleksi.GetDataKoleksiDatabase()
    End Sub

    Public Sub ReloadDataList()
        ListBoxKoleksi.DataSource = Koleksi.GetListKoleksi()
    End Sub

    Private Sub Perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
        ReloadDataList()
        ClearListBox()
    End Sub

    Private Sub Perpustakaan_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ResetGrid()
    End Sub

    Private Sub ArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrayToolStripMenuItem.Click
        Dim array_form = New Array()
        array_form.Show()
        ResetGrid()
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        If (e.RowIndex >= 0) Then
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridKoleksi.Rows(index)

            selectedTableKoleksi = selectedRow.Cells(0).Value
            selectedTableKoleksiNama = selectedRow.Cells(1).Value
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selectedKoleksi As List(Of String) = Koleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        Koleksi.dirGambarBukuProperty = selectedKoleksi(2)

        Koleksi.namaKoleksiProperty = selectedKoleksi(1)
        Koleksi.jenisKoleksiProperty = selectedKoleksi(5)
        Koleksi.deskripsiKoleksiProperty = selectedKoleksi(3)
        Koleksi.penerbitProperty = selectedKoleksi(4)
        Koleksi.tahunTerbitProperty = selectedKoleksi(6)
        Koleksi.lokasiProperty = selectedKoleksi(7)
        Koleksi.tanggalMasukKoleksiProperty = selectedKoleksi(8)
        Koleksi.stockProperty = selectedKoleksi(9)
        Koleksi.bahasaProperty = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = Koleksi.ConvertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            Koleksi.AddKategori(info_kategori)
        Next

        ResetGrid()

        Dim formUpdate = New UpdateKoleksi()
        formUpdate.Show()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        ResetGrid()

        Dim formHapus = New HapusKoleksi()
        formHapus.Show()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim selectedKoleksi As List(Of String) = Koleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        Koleksi.dirGambarBukuProperty = selectedKoleksi(2)

        Koleksi.namaKoleksiProperty = selectedKoleksi(1)
        Koleksi.jenisKoleksiProperty = selectedKoleksi(5)
        Koleksi.deskripsiKoleksiProperty = selectedKoleksi(3)
        Koleksi.penerbitProperty = selectedKoleksi(4)
        Koleksi.tahunTerbitProperty = selectedKoleksi(6)
        Koleksi.lokasiProperty = selectedKoleksi(7)
        Koleksi.tanggalMasukKoleksiProperty = selectedKoleksi(8)
        Koleksi.stockProperty = selectedKoleksi(9)
        Koleksi.bahasaProperty = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = Koleksi.ConvertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            Koleksi.AddKategori(info_kategori)
        Next

        ResetGrid()

        Dim infoTambah = New InfoTambahKoleksi()
        infoTambah.Show()
    End Sub

    Private Sub ListBoxKoleksi_Click(sender As Object, e As EventArgs) Handles ListBoxKoleksi.Click
        selectedListBox = ListBoxKoleksi.SelectedItem
    End Sub

End Class
