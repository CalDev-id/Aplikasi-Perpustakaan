<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateKoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkBudaya = New System.Windows.Forms.CheckBox()
        Me.ChkTeknologi = New System.Windows.Forms.CheckBox()
        Me.ChkSosial = New System.Windows.Forms.CheckBox()
        Me.ChkSains = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdInggris = New System.Windows.Forms.RadioButton()
        Me.RdIndonesia = New System.Windows.Forms.RadioButton()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.DatePickTanggalMasukKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.TxtLokasiRak = New System.Windows.Forms.TextBox()
        Me.TxtTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.RTBDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.ComboBoxJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.TxtNamaKoleksi = New System.Windows.Forms.TextBox()
        Me.BtnUpdateKoleksi = New System.Windows.Forms.Button()
        Me.LabelKategori = New System.Windows.Forms.Label()
        Me.LabelBahasa = New System.Windows.Forms.Label()
        Me.LabelStock = New System.Windows.Forms.Label()
        Me.LabelTanggalMasukKoleksi = New System.Windows.Forms.Label()
        Me.LabelLokasiRak = New System.Windows.Forms.Label()
        Me.LabelTahunTerbit = New System.Windows.Forms.Label()
        Me.LabelPenerbit = New System.Windows.Forms.Label()
        Me.LabelDeskripsi = New System.Windows.Forms.Label()
        Me.LabelJenisKoleksi = New System.Windows.Forms.Label()
        Me.LabelNamaKoleksi = New System.Windows.Forms.Label()
        Me.BtnUpdateGambar = New System.Windows.Forms.Button()
        Me.PicBoxGambar = New System.Windows.Forms.PictureBox()
        Me.LabelTambahKoleksi = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicBoxGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkBudaya)
        Me.GroupBox2.Controls.Add(Me.ChkTeknologi)
        Me.GroupBox2.Controls.Add(Me.ChkSosial)
        Me.GroupBox2.Controls.Add(Me.ChkSains)
        Me.GroupBox2.Location = New System.Drawing.Point(487, 639)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 160)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'ChkBudaya
        '
        Me.ChkBudaya.AutoSize = True
        Me.ChkBudaya.Location = New System.Drawing.Point(16, 124)
        Me.ChkBudaya.Name = "ChkBudaya"
        Me.ChkBudaya.Size = New System.Drawing.Size(80, 24)
        Me.ChkBudaya.TabIndex = 28
        Me.ChkBudaya.Text = "Budaya"
        Me.ChkBudaya.UseVisualStyleBackColor = True
        '
        'ChkTeknologi
        '
        Me.ChkTeknologi.AutoSize = True
        Me.ChkTeknologi.Location = New System.Drawing.Point(16, 93)
        Me.ChkTeknologi.Name = "ChkTeknologi"
        Me.ChkTeknologi.Size = New System.Drawing.Size(96, 24)
        Me.ChkTeknologi.TabIndex = 27
        Me.ChkTeknologi.Text = "Teknologi"
        Me.ChkTeknologi.UseVisualStyleBackColor = True
        '
        'ChkSosial
        '
        Me.ChkSosial.AutoSize = True
        Me.ChkSosial.Location = New System.Drawing.Point(16, 61)
        Me.ChkSosial.Name = "ChkSosial"
        Me.ChkSosial.Size = New System.Drawing.Size(70, 24)
        Me.ChkSosial.TabIndex = 26
        Me.ChkSosial.Text = "Sosial"
        Me.ChkSosial.UseVisualStyleBackColor = True
        '
        'ChkSains
        '
        Me.ChkSains.AutoSize = True
        Me.ChkSains.Location = New System.Drawing.Point(16, 30)
        Me.ChkSains.Name = "ChkSains"
        Me.ChkSains.Size = New System.Drawing.Size(65, 24)
        Me.ChkSains.TabIndex = 25
        Me.ChkSains.Text = "Sains"
        Me.ChkSains.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdInggris)
        Me.GroupBox1.Controls.Add(Me.RdIndonesia)
        Me.GroupBox1.Location = New System.Drawing.Point(487, 527)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 100)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'RdInggris
        '
        Me.RdInggris.AutoSize = True
        Me.RdInggris.Location = New System.Drawing.Point(16, 60)
        Me.RdInggris.Name = "RdInggris"
        Me.RdInggris.Size = New System.Drawing.Size(126, 24)
        Me.RdInggris.TabIndex = 24
        Me.RdInggris.TabStop = True
        Me.RdInggris.Text = "Bahasa Inggris"
        Me.RdInggris.UseVisualStyleBackColor = True
        '
        'RdIndonesia
        '
        Me.RdIndonesia.AutoSize = True
        Me.RdIndonesia.Location = New System.Drawing.Point(16, 27)
        Me.RdIndonesia.Name = "RdIndonesia"
        Me.RdIndonesia.Size = New System.Drawing.Size(145, 24)
        Me.RdIndonesia.TabIndex = 23
        Me.RdIndonesia.TabStop = True
        Me.RdIndonesia.Text = "Bahasa Indonesia"
        Me.RdIndonesia.UseVisualStyleBackColor = True
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(487, 475)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(293, 27)
        Me.TxtStock.TabIndex = 71
        '
        'DatePickTanggalMasukKoleksi
        '
        Me.DatePickTanggalMasukKoleksi.CustomFormat = "dddd,  MMMM d  ,  yyyy"
        Me.DatePickTanggalMasukKoleksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePickTanggalMasukKoleksi.Location = New System.Drawing.Point(487, 442)
        Me.DatePickTanggalMasukKoleksi.Name = "DatePickTanggalMasukKoleksi"
        Me.DatePickTanggalMasukKoleksi.Size = New System.Drawing.Size(293, 27)
        Me.DatePickTanggalMasukKoleksi.TabIndex = 70
        '
        'TxtLokasiRak
        '
        Me.TxtLokasiRak.Location = New System.Drawing.Point(487, 400)
        Me.TxtLokasiRak.Name = "TxtLokasiRak"
        Me.TxtLokasiRak.Size = New System.Drawing.Size(293, 27)
        Me.TxtLokasiRak.TabIndex = 69
        '
        'TxtTahunTerbit
        '
        Me.TxtTahunTerbit.Location = New System.Drawing.Point(487, 357)
        Me.TxtTahunTerbit.Name = "TxtTahunTerbit"
        Me.TxtTahunTerbit.Size = New System.Drawing.Size(293, 27)
        Me.TxtTahunTerbit.TabIndex = 68
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(487, 315)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(293, 27)
        Me.TxtPenerbit.TabIndex = 67
        '
        'RTBDeskripsi
        '
        Me.RTBDeskripsi.Location = New System.Drawing.Point(487, 156)
        Me.RTBDeskripsi.Name = "RTBDeskripsi"
        Me.RTBDeskripsi.Size = New System.Drawing.Size(293, 142)
        Me.RTBDeskripsi.TabIndex = 66
        Me.RTBDeskripsi.Text = ""
        '
        'ComboBoxJenisKoleksi
        '
        Me.ComboBoxJenisKoleksi.FormattingEnabled = True
        Me.ComboBoxJenisKoleksi.Location = New System.Drawing.Point(487, 109)
        Me.ComboBoxJenisKoleksi.Name = "ComboBoxJenisKoleksi"
        Me.ComboBoxJenisKoleksi.Size = New System.Drawing.Size(293, 28)
        Me.ComboBoxJenisKoleksi.TabIndex = 65
        '
        'TxtNamaKoleksi
        '
        Me.TxtNamaKoleksi.Location = New System.Drawing.Point(487, 66)
        Me.TxtNamaKoleksi.Name = "TxtNamaKoleksi"
        Me.TxtNamaKoleksi.Size = New System.Drawing.Size(293, 27)
        Me.TxtNamaKoleksi.TabIndex = 64
        '
        'BtnUpdateKoleksi
        '
        Me.BtnUpdateKoleksi.Location = New System.Drawing.Point(250, 815)
        Me.BtnUpdateKoleksi.Name = "BtnUpdateKoleksi"
        Me.BtnUpdateKoleksi.Size = New System.Drawing.Size(183, 29)
        Me.BtnUpdateKoleksi.TabIndex = 63
        Me.BtnUpdateKoleksi.Text = "Tambah Koleksi"
        Me.BtnUpdateKoleksi.UseVisualStyleBackColor = True
        '
        'LabelKategori
        '
        Me.LabelKategori.AutoSize = True
        Me.LabelKategori.Location = New System.Drawing.Point(250, 642)
        Me.LabelKategori.Name = "LabelKategori"
        Me.LabelKategori.Size = New System.Drawing.Size(66, 20)
        Me.LabelKategori.TabIndex = 62
        Me.LabelKategori.Text = "Kategori"
        '
        'LabelBahasa
        '
        Me.LabelBahasa.AutoSize = True
        Me.LabelBahasa.Location = New System.Drawing.Point(250, 531)
        Me.LabelBahasa.Name = "LabelBahasa"
        Me.LabelBahasa.Size = New System.Drawing.Size(56, 20)
        Me.LabelBahasa.TabIndex = 61
        Me.LabelBahasa.Text = "Bahasa"
        '
        'LabelStock
        '
        Me.LabelStock.AutoSize = True
        Me.LabelStock.Location = New System.Drawing.Point(250, 489)
        Me.LabelStock.Name = "LabelStock"
        Me.LabelStock.Size = New System.Drawing.Size(45, 20)
        Me.LabelStock.TabIndex = 60
        Me.LabelStock.Text = "Stock"
        '
        'LabelTanggalMasukKoleksi
        '
        Me.LabelTanggalMasukKoleksi.AutoSize = True
        Me.LabelTanggalMasukKoleksi.Location = New System.Drawing.Point(250, 448)
        Me.LabelTanggalMasukKoleksi.Name = "LabelTanggalMasukKoleksi"
        Me.LabelTanggalMasukKoleksi.Size = New System.Drawing.Size(158, 20)
        Me.LabelTanggalMasukKoleksi.TabIndex = 59
        Me.LabelTanggalMasukKoleksi.Text = "Tanggal Masuk Koleksi"
        '
        'LabelLokasiRak
        '
        Me.LabelLokasiRak.AutoSize = True
        Me.LabelLokasiRak.Location = New System.Drawing.Point(250, 404)
        Me.LabelLokasiRak.Name = "LabelLokasiRak"
        Me.LabelLokasiRak.Size = New System.Drawing.Size(78, 20)
        Me.LabelLokasiRak.TabIndex = 58
        Me.LabelLokasiRak.Text = "Lokasi Rak"
        '
        'LabelTahunTerbit
        '
        Me.LabelTahunTerbit.AutoSize = True
        Me.LabelTahunTerbit.Location = New System.Drawing.Point(250, 360)
        Me.LabelTahunTerbit.Name = "LabelTahunTerbit"
        Me.LabelTahunTerbit.Size = New System.Drawing.Size(89, 20)
        Me.LabelTahunTerbit.TabIndex = 57
        Me.LabelTahunTerbit.Text = "Tahun Terbit"
        '
        'LabelPenerbit
        '
        Me.LabelPenerbit.AutoSize = True
        Me.LabelPenerbit.Location = New System.Drawing.Point(250, 318)
        Me.LabelPenerbit.Name = "LabelPenerbit"
        Me.LabelPenerbit.Size = New System.Drawing.Size(63, 20)
        Me.LabelPenerbit.TabIndex = 56
        Me.LabelPenerbit.Text = "Penerbit"
        '
        'LabelDeskripsi
        '
        Me.LabelDeskripsi.AutoSize = True
        Me.LabelDeskripsi.Location = New System.Drawing.Point(250, 156)
        Me.LabelDeskripsi.Name = "LabelDeskripsi"
        Me.LabelDeskripsi.Size = New System.Drawing.Size(69, 20)
        Me.LabelDeskripsi.TabIndex = 55
        Me.LabelDeskripsi.Text = "Deskripsi"
        '
        'LabelJenisKoleksi
        '
        Me.LabelJenisKoleksi.AutoSize = True
        Me.LabelJenisKoleksi.Location = New System.Drawing.Point(250, 112)
        Me.LabelJenisKoleksi.Name = "LabelJenisKoleksi"
        Me.LabelJenisKoleksi.Size = New System.Drawing.Size(91, 20)
        Me.LabelJenisKoleksi.TabIndex = 54
        Me.LabelJenisKoleksi.Text = "Jenis Koleksi"
        '
        'LabelNamaKoleksi
        '
        Me.LabelNamaKoleksi.AutoSize = True
        Me.LabelNamaKoleksi.Location = New System.Drawing.Point(250, 69)
        Me.LabelNamaKoleksi.Name = "LabelNamaKoleksi"
        Me.LabelNamaKoleksi.Size = New System.Drawing.Size(100, 20)
        Me.LabelNamaKoleksi.TabIndex = 53
        Me.LabelNamaKoleksi.Text = "Nama Koleksi"
        '
        'BtnUpdateGambar
        '
        Me.BtnUpdateGambar.Location = New System.Drawing.Point(27, 263)
        Me.BtnUpdateGambar.Name = "BtnUpdateGambar"
        Me.BtnUpdateGambar.Size = New System.Drawing.Size(183, 29)
        Me.BtnUpdateGambar.TabIndex = 52
        Me.BtnUpdateGambar.Text = "Tambah Gambar"
        Me.BtnUpdateGambar.UseVisualStyleBackColor = True
        '
        'PicBoxGambar
        '
        Me.PicBoxGambar.Location = New System.Drawing.Point(27, 69)
        Me.PicBoxGambar.Name = "PicBoxGambar"
        Me.PicBoxGambar.Size = New System.Drawing.Size(183, 186)
        Me.PicBoxGambar.TabIndex = 51
        Me.PicBoxGambar.TabStop = False
        '
        'LabelTambahKoleksi
        '
        Me.LabelTambahKoleksi.AutoSize = True
        Me.LabelTambahKoleksi.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTambahKoleksi.Location = New System.Drawing.Point(14, 14)
        Me.LabelTambahKoleksi.Name = "LabelTambahKoleksi"
        Me.LabelTambahKoleksi.Size = New System.Drawing.Size(212, 37)
        Me.LabelTambahKoleksi.TabIndex = 50
        Me.LabelTambahKoleksi.Text = "Update Koleksi"
        '
        'UpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 867)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.DatePickTanggalMasukKoleksi)
        Me.Controls.Add(Me.TxtLokasiRak)
        Me.Controls.Add(Me.TxtTahunTerbit)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.RTBDeskripsi)
        Me.Controls.Add(Me.ComboBoxJenisKoleksi)
        Me.Controls.Add(Me.TxtNamaKoleksi)
        Me.Controls.Add(Me.BtnUpdateKoleksi)
        Me.Controls.Add(Me.LabelKategori)
        Me.Controls.Add(Me.LabelBahasa)
        Me.Controls.Add(Me.LabelStock)
        Me.Controls.Add(Me.LabelTanggalMasukKoleksi)
        Me.Controls.Add(Me.LabelLokasiRak)
        Me.Controls.Add(Me.LabelTahunTerbit)
        Me.Controls.Add(Me.LabelPenerbit)
        Me.Controls.Add(Me.LabelDeskripsi)
        Me.Controls.Add(Me.LabelJenisKoleksi)
        Me.Controls.Add(Me.LabelNamaKoleksi)
        Me.Controls.Add(Me.BtnUpdateGambar)
        Me.Controls.Add(Me.PicBoxGambar)
        Me.Controls.Add(Me.LabelTambahKoleksi)
        Me.Name = "UpdateKoleksi"
        Me.Text = "UpdateKoleksi"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicBoxGambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ChkBudaya As CheckBox
    Friend WithEvents ChkTeknologi As CheckBox
    Friend WithEvents ChkSosial As CheckBox
    Friend WithEvents ChkSains As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdInggris As RadioButton
    Friend WithEvents RdIndonesia As RadioButton
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents DatePickTanggalMasukKoleksi As DateTimePicker
    Friend WithEvents TxtLokasiRak As TextBox
    Friend WithEvents TxtTahunTerbit As TextBox
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents RTBDeskripsi As RichTextBox
    Friend WithEvents ComboBoxJenisKoleksi As ComboBox
    Friend WithEvents TxtNamaKoleksi As TextBox
    Friend WithEvents BtnUpdateKoleksi As Button
    Friend WithEvents LabelKategori As Label
    Friend WithEvents LabelBahasa As Label
    Friend WithEvents LabelStock As Label
    Friend WithEvents LabelTanggalMasukKoleksi As Label
    Friend WithEvents LabelLokasiRak As Label
    Friend WithEvents LabelTahunTerbit As Label
    Friend WithEvents LabelPenerbit As Label
    Friend WithEvents LabelDeskripsi As Label
    Friend WithEvents LabelJenisKoleksi As Label
    Friend WithEvents LabelNamaKoleksi As Label
    Friend WithEvents BtnUpdateGambar As Button
    Friend WithEvents PicBoxGambar As PictureBox
    Friend WithEvents LabelTambahKoleksi As Label
End Class
