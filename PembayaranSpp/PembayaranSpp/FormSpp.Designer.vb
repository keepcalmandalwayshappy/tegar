<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSpp
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
        Me.components = New System.ComponentModel.Container()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvSpp = New System.Windows.Forms.DataGridView()
        Me.gbxBayar = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNisn = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtTunggakan = New System.Windows.Forms.TextBox()
        Me.txtNominal = New System.Windows.Forms.TextBox()
        Me.txtTanggal = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        CType(Me.dgvSpp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBayar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(588, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dgvSpp
        '
        Me.dgvSpp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSpp.Location = New System.Drawing.Point(4, 174)
        Me.dgvSpp.Name = "dgvSpp"
        Me.dgvSpp.Size = New System.Drawing.Size(668, 238)
        Me.dgvSpp.TabIndex = 17
        '
        'gbxBayar
        '
        Me.gbxBayar.Controls.Add(Me.btnHapus)
        Me.gbxBayar.Controls.Add(Me.btnBatal)
        Me.gbxBayar.Controls.Add(Me.btnEdit)
        Me.gbxBayar.Controls.Add(Me.btnSimpan)
        Me.gbxBayar.Controls.Add(Me.btnBayar)
        Me.gbxBayar.Controls.Add(Me.txtTanggal)
        Me.gbxBayar.Controls.Add(Me.txtNominal)
        Me.gbxBayar.Controls.Add(Me.txtTunggakan)
        Me.gbxBayar.Controls.Add(Me.txtNama)
        Me.gbxBayar.Controls.Add(Me.txtNisn)
        Me.gbxBayar.Controls.Add(Me.Label5)
        Me.gbxBayar.Controls.Add(Me.Label4)
        Me.gbxBayar.Controls.Add(Me.Label3)
        Me.gbxBayar.Controls.Add(Me.Label2)
        Me.gbxBayar.Controls.Add(Me.Label1)
        Me.gbxBayar.Controls.Add(Me.btnClose)
        Me.gbxBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBayar.Location = New System.Drawing.Point(-1, 1)
        Me.gbxBayar.Name = "gbxBayar"
        Me.gbxBayar.Size = New System.Drawing.Size(673, 167)
        Me.gbxBayar.TabIndex = 18
        Me.gbxBayar.TabStop = False
        Me.gbxBayar.Text = "Pembayaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "NISN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "TANGGAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "TUNGGAKAN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(312, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "NOMINAL"
        '
        'txtNisn
        '
        Me.txtNisn.Location = New System.Drawing.Point(91, 27)
        Me.txtNisn.Name = "txtNisn"
        Me.txtNisn.Size = New System.Drawing.Size(193, 22)
        Me.txtNisn.TabIndex = 22
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(91, 56)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(193, 22)
        Me.txtNama.TabIndex = 23
        '
        'txtTunggakan
        '
        Me.txtTunggakan.Location = New System.Drawing.Point(410, 27)
        Me.txtTunggakan.Name = "txtTunggakan"
        Me.txtTunggakan.Size = New System.Drawing.Size(122, 22)
        Me.txtTunggakan.TabIndex = 24
        '
        'txtNominal
        '
        Me.txtNominal.Location = New System.Drawing.Point(410, 56)
        Me.txtNominal.Name = "txtNominal"
        Me.txtNominal.Size = New System.Drawing.Size(122, 22)
        Me.txtNominal.TabIndex = 25
        '
        'txtTanggal
        '
        Me.txtTanggal.Location = New System.Drawing.Point(91, 89)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(122, 22)
        Me.txtTanggal.TabIndex = 26
        '
        'Timer1
        '
        '
        'btnBayar
        '
        Me.btnBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.Location = New System.Drawing.Point(37, 126)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(75, 23)
        Me.btnBayar.TabIndex = 27
        Me.btnBayar.Text = "BAYAR"
        Me.btnBayar.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(128, 126)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 28
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(221, 126)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 29
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(372, 92)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 30
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(469, 92)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 31
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'FormSpp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 415)
        Me.Controls.Add(Me.gbxBayar)
        Me.Controls.Add(Me.dgvSpp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSpp"
        Me.Text = "FormSpp"
        CType(Me.dgvSpp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBayar.ResumeLayout(False)
        Me.gbxBayar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dgvSpp As System.Windows.Forms.DataGridView
    Friend WithEvents gbxBayar As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTanggal As System.Windows.Forms.TextBox
    Friend WithEvents txtNominal As System.Windows.Forms.TextBox
    Friend WithEvents txtTunggakan As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNisn As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBayar As System.Windows.Forms.Button
End Class
