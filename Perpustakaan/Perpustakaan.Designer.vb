<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perpustakaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBoxKoleksi = New System.Windows.Forms.ListBox()
        Me.BtnTambahKoleksi = New System.Windows.Forms.Button()
        Me.BtnHapusKoleksi = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem, Me.ArrayToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(941, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'ArrayToolStripMenuItem
        '
        Me.ArrayToolStripMenuItem.Name = "ArrayToolStripMenuItem"
        Me.ArrayToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.ArrayToolStripMenuItem.Text = "Array"
        '
        'ListBoxKoleksi
        '
        Me.ListBoxKoleksi.FormattingEnabled = True
        Me.ListBoxKoleksi.ItemHeight = 20
        Me.ListBoxKoleksi.Location = New System.Drawing.Point(12, 72)
        Me.ListBoxKoleksi.Name = "ListBoxKoleksi"
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(473, 624)
        Me.ListBoxKoleksi.TabIndex = 1
        '
        'BtnTambahKoleksi
        '
        Me.BtnTambahKoleksi.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.plus
        Me.BtnTambahKoleksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnTambahKoleksi.FlatAppearance.BorderSize = 0
        Me.BtnTambahKoleksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahKoleksi.Location = New System.Drawing.Point(10, 31)
        Me.BtnTambahKoleksi.Name = "BtnTambahKoleksi"
        Me.BtnTambahKoleksi.Size = New System.Drawing.Size(33, 33)
        Me.BtnTambahKoleksi.TabIndex = 2
        Me.BtnTambahKoleksi.UseVisualStyleBackColor = True
        '
        'BtnHapusKoleksi
        '
        Me.BtnHapusKoleksi.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.minus
        Me.BtnHapusKoleksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHapusKoleksi.FlatAppearance.BorderSize = 0
        Me.BtnHapusKoleksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapusKoleksi.Location = New System.Drawing.Point(46, 31)
        Me.BtnHapusKoleksi.Name = "BtnHapusKoleksi"
        Me.BtnHapusKoleksi.Size = New System.Drawing.Size(33, 33)
        Me.BtnHapusKoleksi.TabIndex = 3
        Me.BtnHapusKoleksi.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(792, 710)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(137, 41)
        Me.BtnRemove.TabIndex = 7
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(644, 710)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(137, 41)
        Me.BtnSelect.TabIndex = 8
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(496, 710)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(137, 41)
        Me.BtnUpdate.TabIndex = 9
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.AllowUserToAddRows = False
        Me.DataGridKoleksi.AllowUserToDeleteRows = False
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(496, 72)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.ReadOnly = True
        Me.DataGridKoleksi.RowHeadersWidth = 51
        Me.DataGridKoleksi.RowTemplate.Height = 29
        Me.DataGridKoleksi.Size = New System.Drawing.Size(433, 624)
        Me.DataGridKoleksi.TabIndex = 10
        '
        'Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 764)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnHapusKoleksi)
        Me.Controls.Add(Me.BtnTambahKoleksi)
        Me.Controls.Add(Me.ListBoxKoleksi)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Perpustakaan"
        Me.Text = "Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBoxKoleksi As ListBox
    Friend WithEvents BtnTambahKoleksi As Button
    Friend WithEvents BtnHapusKoleksi As Button
    Friend WithEvents ArrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents DataGridKoleksi As DataGridView
End Class
