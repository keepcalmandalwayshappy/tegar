Public Class FormEditSiswa

    Sub matikan()
        txtNisn.Enabled = False
        txtNama.Enabled = False
        cbxKelas.Enabled = False
        cbxKelamin.Enabled = False
        txtAlamat.Enabled = False
    End Sub

    Sub hidupkan()
        txtNisn.Enabled = True
        txtNama.Enabled = True
        cbxKelas.Enabled = True
        cbxKelamin.Enabled = True
        txtAlamat.Enabled = True
    End Sub

    Sub kosongkan()
        txtNisn.Text = ""
        txtNama.Text = ""
        cbxKelas.Text = ""
        cbxKelamin.Text = ""
        txtAlamat.Text = ""
    End Sub

    Sub datasiswa()
        Call koneksiDB()
        da = New OleDb.OleDbDataAdapter("select * from Siswa", conn)
        ds = New DataSet
        da.Fill(ds)
        dgvEditSiswa.DataSource = ds.Tables(0)
        dgvEditSiswa.ReadOnly = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FormEditSiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksiDB()
        datasiswa()
        matikan()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtNisn.Text = "" Or txtNama.Text = "" Or cbxKelas.Text = "" Then
            MsgBox("Harap diisi!")
            Exit Sub
        Else
            Call koneksiDB()
            cmd = New OleDb.OleDbCommand("select * from Siswa where nisn='" & txtNisn.Text & "'", conn)
            dr = cmd.ExecuteReader
            If Not dr.HasRows Then
                Call koneksiDB()
                Dim simpan As String
                simpan = "insert into Siswa values('" & txtNisn.Text & "','" & txtNama.Text & "','" & cbxKelas.Text & "','" & cbxKelamin.Text & "','" & txtAlamat.Text & "')"
                cmd = New OleDb.OleDbCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil terinput")
            Else
                MsgBox("Data sudah ada!")
            End If
            Call matikan()
            Call datasiswa()
            Call kosongkan()
        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Call hidupkan()
        Call kosongkan()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Call matikan()
        Call kosongkan()
    End Sub

    Private Sub dgvEditSiswa_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvEditSiswa.CellMouseClick
        On Error Resume Next
        txtNisn.Text = dgvEditSiswa.Rows(e.RowIndex).Cells(0).Value
        txtNama.Text = dgvEditSiswa.Rows(e.RowIndex).Cells(1).Value
        cbxKelas.Text = dgvEditSiswa.Rows(e.RowIndex).Cells(2).Value
        cbxKelamin.Text = dgvEditSiswa.Rows(e.RowIndex).Cells(3).Value
        txtAlamat.Text = dgvEditSiswa.Rows(e.RowIndex).Cells(4).Value

        Call hidupkan()
        txtNisn.Enabled = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtNisn.Text = "" Or txtNama.Text = "" Or cbxKelas.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        Else
            Call koneksiDB()
            cmd = New OleDb.OleDbCommand("update Siswa set nama='" & txtNama.Text & "',kelas='" & cbxKelas.Text & "',kelamin='" & cbxKelamin.Text & "' where nisn='" & txtNisn.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Edit data sukses")
        End If
        Call matikan()
        Call kosongkan()
        Call datasiswa()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click

    End Sub
End Class