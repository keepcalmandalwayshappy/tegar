Public Class FormSiswa

    Sub datasiswa()
        Call koneksiDB()
        da = New OleDb.OleDbDataAdapter("select * from Siswa", conn)
        ds = New DataSet
        da.Fill(ds)
        dgvDataSiswa.DataSource = ds.Tables(0)
        dgvDataSiswa.ReadOnly = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FormSiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datasiswa()
    End Sub
End Class