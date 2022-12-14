Public Class FungsiPerpustakaan

    Private gambar_koleksi As String
    Private nama_koleksi As String
    Private jenis_koleksi
    Private deskripsi
    Private penerbit As String
    Private tahun_terbit As String
    Private lokasi_rak As String
    Private tanggal_masuk_koleksi
    Private stock As String
    Private bahasa As String
    Private kategori As New List(Of String)

    Public Property GSGambar_Koleksi() As String
        Get
            Return gambar_koleksi
        End Get
        Set(ByVal value As String)
            gambar_koleksi = value
        End Set
    End Property

    Public Property GSNama_Koleksi() As String
        Get
            Return nama_koleksi
        End Get
        Set(ByVal value As String)
            nama_koleksi = value
        End Set
    End Property

    Public Property GSJenis_Koleksi() As String
        Get
            Return jenis_koleksi
        End Get
        Set(ByVal value As String)
            jenis_koleksi = value
        End Set
    End Property

    Public Property GSDeskripsi() As String
        Get
            Return deskripsi
        End Get
        Set(ByVal value As String)
            deskripsi = value
        End Set
    End Property

    Public Property GSPenerbit() As String
        Get
            Return penerbit
        End Get
        Set(ByVal value As String)
            penerbit = value
        End Set
    End Property

    Public Property GSTahun_Terbit() As String
        Get
            Return tahun_terbit
        End Get
        Set(ByVal value As String)
            tahun_terbit = value
        End Set
    End Property

    Public Property GSTanggal_Masuk_Koleksi() As String
        Get
            Return tanggal_masuk_koleksi
        End Get
        Set(ByVal value As String)
            tanggal_masuk_koleksi = value
        End Set
    End Property

    Public Property GSLokasi_Rak() As String
        Get
            Return lokasi_rak
        End Get
        Set(ByVal value As String)
            lokasi_rak = value
        End Set
    End Property

    Public Property GSStock() As String
        Get
            Return stock
        End Get
        Set(ByVal value As String)
            stock = value
        End Set
    End Property

    Public Property GSBahasa() As String
        Get
            Return bahasa
        End Get
        Set(ByVal value As String)
            bahasa = value
        End Set
    End Property

    Public Property GSKategori()
        Get
            Return kategori
        End Get
        Set(ByVal value)
            kategori = value
        End Set
    End Property
End Class
